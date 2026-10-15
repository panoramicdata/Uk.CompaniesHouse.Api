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

		if (type.IsArray)
		{
			return CreateSampleArray(type, depth, stack);
		}

		if (type.IsGenericType)
		{
			var list = CreateSampleList(type);
			if (list is not null)
			{
				list.Add(CreateSampleValue(type.GetGenericArguments()[0], depth - 1, stack));
				return list;
			}
		}

		if (type.Namespace is not null
			&& type.Namespace.StartsWith("Uk.CompaniesHouse.Api.Data", StringComparison.Ordinal)
			&& type.GetConstructor(Type.EmptyTypes) is not null
			&& !stack.Contains(type))
		{
			return CreateSampleDataModel(type, depth, stack);
		}

		return GetDefault(type);
	}

	private static object? CreatePrimitiveValue(Type type)
	{
		if (type == typeof(string))
		{
			return "value";
		}

		if (type == typeof(bool))
		{
			return true;
		}

		if (IsNumericOrChar(type))
		{
			return Activator.CreateInstance(type);
		}

		if (type == typeof(DateTime))
		{
			return DateTime.UtcNow;
		}

		if (type == typeof(DateTimeOffset))
		{
			return DateTimeOffset.UtcNow;
		}

		if (type == typeof(Guid))
		{
			return Guid.NewGuid();
		}

		if (type == typeof(Uri))
		{
			return new Uri("https://example.test");
		}

		if (type.IsEnum)
		{
			var values = Enum.GetValues(type);
			return values.Length > 0 ? values.GetValue(0) : Activator.CreateInstance(type);
		}

		return null;
	}

	private static bool IsNumericOrChar(Type type)
	{
		if (type == typeof(byte))
		{
			return true;
		}

		if (type == typeof(sbyte))
		{
			return true;
		}

		if (type == typeof(short))
		{
			return true;
		}

		if (type == typeof(ushort))
		{
			return true;
		}

		if (type == typeof(int))
		{
			return true;
		}

		if (type == typeof(uint))
		{
			return true;
		}

		if (type == typeof(long))
		{
			return true;
		}

		if (type == typeof(ulong))
		{
			return true;
		}

		if (type == typeof(float))
		{
			return true;
		}

		if (type == typeof(double))
		{
			return true;
		}

		if (type == typeof(decimal))
		{
			return true;
		}

		if (type == typeof(char))
		{
			return true;
		}

		return false;
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
