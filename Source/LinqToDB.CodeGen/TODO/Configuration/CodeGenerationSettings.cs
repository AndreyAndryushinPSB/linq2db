﻿using System;
using System.Collections.Generic;
using LinqToDB.CodeGen.ContextModel;
using LinqToDB.CodeGen.Naming;

namespace LinqToDB.CodeGen.CodeGeneration
{
	public class CodeGenerationSettings
	{
		public bool MarkAsAutoGenerated { get; set; }
		public bool NullableReferenceTypes { get; set; } = true;
		public string? Namespace { get; set; } = "DataModel";
		public string? Indent { get; set; } = "\t";
		public bool PartialContext { get; set; } = true;
		public bool IncludeDatabaseInfo { get; set; } = true;
		public string? BaseContextClass { get; set; }
		public string ContextFileName { get; set; } = null!;
		public string ContextFolder { get; set; } = null!;
		public bool SuppressMissingXmlCommentWarnings { get; set; } = true;
		public bool AssociationCollectionAsArray { get; set; }
		public string? AssociationCollectionType { get; set; }
		public string NewLine { get; set; } = Environment.NewLine;

		public bool ClassPerFile { get; set; }

		public bool GenerateDbType { get; set; }
		public bool GenerateDataType { get; set; }
		public bool GenerateLength { get; set; }
		public bool GeneratePrecision { get; set; }
		public bool GenerateScale { get; set; }

		public bool PreferProviderTypes { get; set; }// = true;

		public bool GenerateAssociations { get; set; } = true;
		public bool GenerateAssociationExtensions { get; set; } = true;
		public bool GenerateFindExtensions { get; set; } = true;
		// or by pk ordinal
		public bool OrderFindParametersByColumnOrdinal { get; set; } = true;

		public bool TableFunctionReturnsTable { get; set; } = true;
		public bool GenerateProcedureResultAsList { get; set; } = true;
		public bool GenerateProcedureParameterDbType { get; set; } = true;

		public ObjectNormalizationSettings ParameterNameNormalization { get; } = new() { Casing = NameCasing.CamelCase, Transformation = NameTransformation.SplitByUnderscore, Pluralization = Pluralization.None, DontCaseAllCaps = false };
		public ObjectNormalizationSettings SchemaClassNameNormalization { get; } = new() { Casing = NameCasing.Pascal, Transformation = NameTransformation.SplitByUnderscore, Pluralization = Pluralization.None, Suffix = "Schema" };
		public ObjectNormalizationSettings SchemaPropertyNormalization { get; } = new() { Casing = NameCasing.Pascal, Transformation = NameTransformation.SplitByUnderscore, Pluralization = Pluralization.None };

		// T4-compat option, not recommended
		public bool PutSchemaStoredProceduresToNestedClass { get; set; } = true;
		public bool PutSchemaFunctionsToNestedClass { get; set; }

		public bool SkipProceduresWithSchemaErrors { get; set; }
		public bool GenerateProceduresSchemaError { get; set; }

		public List<string> ConflictingNames { get; } = new();
	}
}
