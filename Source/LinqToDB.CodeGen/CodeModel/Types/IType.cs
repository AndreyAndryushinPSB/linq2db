﻿namespace LinqToDB.CodeGen.Model
{
	/// <summary>
	/// Type descriptor interface.
	/// </summary>
	public interface IType
	{
		/// <summary>
		/// Type kind.
		/// </summary>
		TypeKind          Kind                { get; }

		/// <summary>
		/// Type nullability. E.g. NRT annotation status for reference type and Nullable`T wrapper presence for value type.
		/// </summary>
		bool              IsNullable          { get; }

		/// <summary>
		/// Value or reference type.
		/// </summary>
		bool              IsValueType         { get; }

		/// <summary>
		/// Type namespace.
		/// </summary>
		CodeIdentifier[]? Namespace           { get; }

		/// <summary>
		/// Parent type for nested types.
		/// </summary>
		IType?            Parent              { get; }

		// TODO: remove from type?
		/// <summary>
		/// Language-specic type alias.
		/// </summary>
		string?           Alias               { get; }

		/// <summary>
		/// Type name.
		/// </summary>
		CodeIdentifier?   Name                { get; }

		/// <summary>
		/// Type of array element for array type.
		/// </summary>
		IType?            ArrayElementType    { get; }

		/// <summary>
		/// Optional array sizes for array type.
		/// Use array as property type to support multi-dimensional arrays.
		/// </summary>
		int?[]?           ArraySizes          { get; }

		/// <summary>
		/// Number of type arguments for open generic type.
		/// </summary>
		int?              OpenGenericArgCount { get; }

		/// <summary>
		/// Type arguments for generic type.
		/// </summary>
		IType[]?          TypeArguments       { get; }

		// TODO: needed?
		/// <summary>
		/// Indicates wether type is imported or declared in current model.
		/// </summary>
		bool              External            { get; }

		/// <summary>
		/// Apply nullability flag to current type.
		/// </summary>
		/// <param name="nullable">New type nullability status.</param>
		/// <returns>New type instance if nullability changed.</returns>
		IType WithNullability(bool nullable);

		/// <summary>
		/// Specify type arguments for open generic type.
		/// Method call valid only on open-generic types.
		/// </summary>
		/// <param name="typeArguments">Types to use as generic type arguments.</param>
		/// <returns>Generic type with provided type arguments.</returns>
		IType WithTypeArguments(IType[] typeArguments);
	}
}
