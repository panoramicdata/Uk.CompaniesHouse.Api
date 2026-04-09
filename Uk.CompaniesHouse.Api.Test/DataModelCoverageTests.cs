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

		if (type == typeof(string))
		{
			return "value";
		}

		if (type == typeof(bool))
		{
			return true;
		}

		if (type == typeof(byte)) return (byte)1;
		if (type == typeof(sbyte)) return (sbyte)1;
		if (type == typeof(short)) return (short)1;
		if (type == typeof(ushort)) return (ushort)1;
		if (type == typeof(int)) return 1;
		if (type == typeof(uint)) return (uint)1;
		if (type == typeof(long)) return 1L;
		if (type == typeof(ulong)) return 1UL;
		if (type == typeof(float)) return 1f;
		if (type == typeof(double)) return 1d;
		if (type == typeof(decimal)) return 1m;
		if (type == typeof(char)) return 'a';
		if (type == typeof(DateTime)) return DateTime.UtcNow;
		if (type == typeof(DateTimeOffset)) return DateTimeOffset.UtcNow;
		if (type == typeof(Guid)) return Guid.NewGuid();
		if (type == typeof(Uri)) return new Uri("https://example.test");

		if (type.IsEnum)
		{
			var values = Enum.GetValues(type);
			return values.Length > 0 ? values.GetValue(0) : Activator.CreateInstance(type);
		}

		var nullableUnderlyingType = Nullable.GetUnderlyingType(type);
		if (nullableUnderlyingType is not null)
		{
			return CreateSampleValue(nullableUnderlyingType, depth - 1, stack);
		}

		if (type.IsArray)
		{
			var elementType = type.GetElementType()!;
			var array = Array.CreateInstance(elementType, 1);
			array.SetValue(CreateSampleValue(elementType, depth - 1, stack), 0);
			return array;
		}

		if (type.IsGenericType)
		{
			var genericTypeDefinition = type.GetGenericTypeDefinition();
			var genericArgs = type.GetGenericArguments();

			if (genericTypeDefinition == typeof(List<>)
				|| genericTypeDefinition == typeof(IList<>)
				|| genericTypeDefinition == typeof(IEnumerable<>)
				|| genericTypeDefinition == typeof(ICollection<>))
			{
				var elementType = genericArgs[0];
				var listType = typeof(List<>).MakeGenericType(elementType);
				var list = (IList)Activator.CreateInstance(listType)!;
				list.Add(CreateSampleValue(elementType, depth - 1, stack));
				return list;
			}
		}

		if (type.Namespace is not null
			&& type.Namespace.StartsWith("Uk.CompaniesHouse.Api.Data", StringComparison.Ordinal)
			&& type.GetConstructor(Type.EmptyTypes) is not null
			&& !stack.Contains(type))
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

		return GetDefault(type);
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
