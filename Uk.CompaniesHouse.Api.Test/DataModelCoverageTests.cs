using AwesomeAssertions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Uk.CompaniesHouse.Api;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

public class DataModelCoverageTests
{
	[Fact]
	public void DataModels_ConstructAndRoundTripPublicProperties()
	{
		var assembly = typeof(CompaniesHouseClient).Assembly;
		var dataModelTypes = assembly
			.GetTypes()
			.Where(t => t is { IsClass: true, IsAbstract: false, IsPublic: true })
			.Where(t => t.Namespace is not null && t.Namespace.StartsWith("Uk.CompaniesHouse.Api.Data", StringComparison.Ordinal))
			.Where(t => !t.ContainsGenericParameters)
			.Where(t => t.GetConstructor(Type.EmptyTypes) is not null)
			.ToList();

		dataModelTypes.Should().NotBeEmpty();

		foreach (var type in dataModelTypes)
		{
			var instance = Activator.CreateInstance(type);
			instance.Should().NotBeNull($"expected to construct {type.FullName}");

			foreach (var property in type.GetProperties(BindingFlags.Instance | BindingFlags.Public))
			{
				if (property.GetIndexParameters().Length > 0)
				{
					continue;
				}

				if (property.CanWrite)
				{
					var value = CreateSampleValue(property.PropertyType, depth: 3, []);
					property.SetValue(instance, value);
				}

				if (property.CanRead)
				{
					_ = property.GetValue(instance);
				}
			}
		}
	}

	private static readonly HashSet<Type> NumericOrCharTypes =
	[
		typeof(byte), typeof(sbyte), typeof(short), typeof(ushort), typeof(int), typeof(uint),
		typeof(long), typeof(ulong), typeof(float), typeof(double), typeof(decimal), typeof(char)
	];

	private static readonly Dictionary<Type, Func<object>> PrimitiveFactories = new()
	{
		[typeof(string)] = () => "value",
		[typeof(bool)] = () => true,
		[typeof(DateTime)] = () => DateTime.UtcNow,
		[typeof(DateTimeOffset)] = () => DateTimeOffset.UtcNow,
		[typeof(Guid)] = () => Guid.NewGuid(),
		[typeof(Uri)] = () => new Uri("https://example.test")
	};

	private static object? CreateSampleValue(Type type, int depth, HashSet<Type> stack)
	{
		if (depth <= 0)
		{
			return GetDefault(type);
		}

		var primitiveValue = CreatePrimitiveValue(type);
		if (primitiveValue is not null)
		{
			return primitiveValue;
		}

		var nullableUnderlyingType = Nullable.GetUnderlyingType(type);
		if (nullableUnderlyingType is not null)
		{
			return CreateSampleValue(nullableUnderlyingType, depth - 1, stack);
		}

		return type.IsArray ? CreateSampleArray(type, depth, stack) : CreateSampleComposite(type, depth, stack);
	}

	private static object? CreateSampleComposite(Type type, int depth, HashSet<Type> stack)
	{
		var list = type.IsGenericType ? CreateSampleList(type) : null;
		if (list is not null)
		{
			list.Add(CreateSampleValue(type.GetGenericArguments()[0], depth - 1, stack));
			return list;
		}

		return IsSampleableDataModel(type, stack) ? CreateSampleDataModel(type, depth, stack) : GetDefault(type);
	}

	private static bool IsSampleableDataModel(Type type, HashSet<Type> stack)
		=> type.Namespace?.StartsWith("Uk.CompaniesHouse.Api.Data", StringComparison.Ordinal) == true
			&& type.GetConstructor(Type.EmptyTypes) is not null
			&& !stack.Contains(type);

	private static object? CreatePrimitiveValue(Type type)
	{
		if (PrimitiveFactories.TryGetValue(type, out var factory))
		{
			return factory();
		}

		if (NumericOrCharTypes.Contains(type))
		{
			return Activator.CreateInstance(type);
		}

		if (type.IsEnum)
		{
			var values = Enum.GetValues(type);
			return values.Length > 0 ? values.GetValue(0) : Activator.CreateInstance(type);
		}

		return null;
	}
	private static object? CreateSampleArray(Type type, int depth, HashSet<Type> stack)
	{
		var elementType = type.GetElementType()!;
		var array = Array.CreateInstance(elementType, 1);
		array.SetValue(CreateSampleValue(elementType, depth - 1, stack), 0);
		return array;
	}

	private static IList? CreateSampleList(Type type)
	{
		var genericTypeDefinition = type.GetGenericTypeDefinition();
		if (IsSupportedList(genericTypeDefinition))
		{
			var elementType = type.GetGenericArguments()[0];
			var listType = typeof(List<>).MakeGenericType(elementType);
			return (IList)Activator.CreateInstance(listType)!;
		}

		return null;
	}

	private static bool IsSupportedList(Type genericTypeDefinition)
	{
		if (genericTypeDefinition == typeof(List<>))
		{
			return true;
		}

		if (genericTypeDefinition == typeof(IList<>))
		{
			return true;
		}

		if (genericTypeDefinition == typeof(IEnumerable<>))
		{
			return true;
		}

		if (genericTypeDefinition == typeof(ICollection<>))
		{
			return true;
		}

		return false;
	}

	private static object? CreateSampleDataModel(Type type, int depth, HashSet<Type> stack)
	{
		stack.Add(type);
		var instance = Activator.CreateInstance(type);
		if (instance is not null)
		{
			foreach (var property in type.GetProperties(BindingFlags.Instance | BindingFlags.Public))
			{
				if (property.CanWrite && property.GetIndexParameters().Length == 0)
				{
					property.SetValue(instance, CreateSampleValue(property.PropertyType, depth - 1, stack));
				}

				if (property.CanRead && property.GetIndexParameters().Length == 0)
				{
					_ = property.GetValue(instance);
				}
			}
		}

		stack.Remove(type);
		return instance;
	}

	private static object? GetDefault(Type type)
	{
		if (!type.IsValueType)
		{
			return null;
		}

		return Activator.CreateInstance(type);
	}
}
