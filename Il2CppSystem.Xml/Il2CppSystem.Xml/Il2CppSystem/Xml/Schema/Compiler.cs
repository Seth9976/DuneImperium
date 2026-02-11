using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200018D RID: 397
	public sealed class Compiler : BaseProcessor
	{
		// Token: 0x0600219C RID: 8604 RVA: 0x000A14BC File Offset: 0x0009F6BC
		// Note: this type is marked as 'beforefieldinit'.
		static Compiler()
		{
			Il2CppClassPointerStore<Compiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Compiler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Compiler>.NativeClassPtr);
			Compiler.NativeFieldInfoPtr_restrictionErrorMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "restrictionErrorMsg");
			Compiler.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "attributes");
			Compiler.NativeFieldInfoPtr_attributeGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "attributeGroups");
			Compiler.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "elements");
			Compiler.NativeFieldInfoPtr_schemaTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "schemaTypes");
			Compiler.NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "groups");
			Compiler.NativeFieldInfoPtr_notations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "notations");
			Compiler.NativeFieldInfoPtr_examplars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "examplars");
			Compiler.NativeFieldInfoPtr_identityConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "identityConstraints");
			Compiler.NativeFieldInfoPtr_complexTypeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "complexTypeStack");
			Compiler.NativeFieldInfoPtr_schemasToCompile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "schemasToCompile");
			Compiler.NativeFieldInfoPtr_importedSchemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "importedSchemas");
			Compiler.NativeFieldInfoPtr_schemaForSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compiler>.NativeClassPtr, "schemaForSchema");
			Compiler.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_ValidationEventHandler_XmlSchema_XmlSchemaCompilationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668179);
			Compiler.NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchemaSet_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668180);
			Compiler.NativeMethodInfoPtr_Prepare_Internal_Void_XmlSchema_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668181);
			Compiler.NativeMethodInfoPtr_UpdateSForSSimpleTypes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668182);
			Compiler.NativeMethodInfoPtr_Output_Private_Void_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668183);
			Compiler.NativeMethodInfoPtr_ImportAllCompiledSchemas_Internal_Void_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668184);
			Compiler.NativeMethodInfoPtr_Compile_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668185);
			Compiler.NativeMethodInfoPtr_CleanupAttribute_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668186);
			Compiler.NativeMethodInfoPtr_CleanupAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668187);
			Compiler.NativeMethodInfoPtr_CleanupComplexType_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668188);
			Compiler.NativeMethodInfoPtr_CleanupSimpleType_Private_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668189);
			Compiler.NativeMethodInfoPtr_CleanupElement_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668190);
			Compiler.NativeMethodInfoPtr_CleanupAttributes_Private_Void_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668191);
			Compiler.NativeMethodInfoPtr_CleanupGroup_Private_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668192);
			Compiler.NativeMethodInfoPtr_CleanupParticle_Private_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668193);
			Compiler.NativeMethodInfoPtr_ProcessSubstitutionGroups_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668194);
			Compiler.NativeMethodInfoPtr_CompileSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668195);
			Compiler.NativeMethodInfoPtr_RecursivelyCheckRedefinedGroups_Private_Void_XmlSchemaGroup_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668196);
			Compiler.NativeMethodInfoPtr_RecursivelyCheckRedefinedAttributeGroups_Private_Void_XmlSchemaAttributeGroup_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668197);
			Compiler.NativeMethodInfoPtr_CompileGroup_Private_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668198);
			Compiler.NativeMethodInfoPtr_CompileSimpleType_Private_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668199);
			Compiler.NativeMethodInfoPtr_CompileBaseMemberTypes_Private_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668200);
			Compiler.NativeMethodInfoPtr_CheckUnionType_Private_Void_XmlSchemaSimpleType_ArrayList_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668201);
			Compiler.NativeMethodInfoPtr_CompileComplexType_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668202);
			Compiler.NativeMethodInfoPtr_CompileSimpleContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668203);
			Compiler.NativeMethodInfoPtr_CompileSimpleContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentRestriction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668204);
			Compiler.NativeMethodInfoPtr_CompileComplexContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668205);
			Compiler.NativeMethodInfoPtr_CompileComplexContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentRestriction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668206);
			Compiler.NativeMethodInfoPtr_CheckParticleDerivation_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668207);
			Compiler.NativeMethodInfoPtr_CheckParticleDerivation_Private_Void_XmlSchemaParticle_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668208);
			Compiler.NativeMethodInfoPtr_CompileContentTypeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668209);
			Compiler.NativeMethodInfoPtr_CannonicalizeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668210);
			Compiler.NativeMethodInfoPtr_CannonicalizeElement_Private_XmlSchemaParticle_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668211);
			Compiler.NativeMethodInfoPtr_CannonicalizeGroupRef_Private_XmlSchemaParticle_XmlSchemaGroupRef_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668212);
			Compiler.NativeMethodInfoPtr_CannonicalizeAll_Private_XmlSchemaParticle_XmlSchemaAll_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668213);
			Compiler.NativeMethodInfoPtr_CannonicalizeChoice_Private_XmlSchemaParticle_XmlSchemaChoice_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668214);
			Compiler.NativeMethodInfoPtr_CannonicalizeSequence_Private_XmlSchemaParticle_XmlSchemaSequence_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668215);
			Compiler.NativeMethodInfoPtr_CannonicalizePointlessRoot_Private_XmlSchemaParticle_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668216);
			Compiler.NativeMethodInfoPtr_IsValidRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668217);
			Compiler.NativeMethodInfoPtr_IsElementFromElement_Private_Boolean_XmlSchemaElement_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668218);
			Compiler.NativeMethodInfoPtr_IsElementFromAny_Private_Boolean_XmlSchemaElement_XmlSchemaAny_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668219);
			Compiler.NativeMethodInfoPtr_IsAnyFromAny_Private_Boolean_XmlSchemaAny_XmlSchemaAny_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668220);
			Compiler.NativeMethodInfoPtr_IsGroupBaseFromAny_Private_Boolean_XmlSchemaGroupBase_XmlSchemaAny_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668221);
			Compiler.NativeMethodInfoPtr_IsElementFromGroupBase_Private_Boolean_XmlSchemaElement_XmlSchemaGroupBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668222);
			Compiler.NativeMethodInfoPtr_IsChoiceFromChoiceSubstGroup_Private_Boolean_XmlSchemaChoice_XmlSchemaChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668223);
			Compiler.NativeMethodInfoPtr_IsGroupBaseFromGroupBase_Private_Boolean_XmlSchemaGroupBase_XmlSchemaGroupBase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668224);
			Compiler.NativeMethodInfoPtr_IsSequenceFromAll_Private_Boolean_XmlSchemaSequence_XmlSchemaAll_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668225);
			Compiler.NativeMethodInfoPtr_IsSequenceFromChoice_Private_Boolean_XmlSchemaSequence_XmlSchemaChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668226);
			Compiler.NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668227);
			Compiler.NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_Decimal_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668228);
			Compiler.NativeMethodInfoPtr_GetMappingParticle_Private_Int32_XmlSchemaParticle_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668229);
			Compiler.NativeMethodInfoPtr_IsParticleEmptiable_Private_Boolean_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668230);
			Compiler.NativeMethodInfoPtr_CalculateEffectiveTotalRange_Private_Void_XmlSchemaParticle_byref_Decimal_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668231);
			Compiler.NativeMethodInfoPtr_PushComplexType_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668232);
			Compiler.NativeMethodInfoPtr_GetSchemaContentType_Private_XmlSchemaContentType_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668233);
			Compiler.NativeMethodInfoPtr_CompileAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668234);
			Compiler.NativeMethodInfoPtr_CompileLocalAttributes_Private_Void_XmlSchemaComplexType_XmlSchemaComplexType_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668235);
			Compiler.NativeMethodInfoPtr_CheckAtrributeGroupRestriction_Private_Void_XmlSchemaAttributeGroup_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668236);
			Compiler.NativeMethodInfoPtr_IsProcessContentsRestricted_Private_Boolean_XmlSchemaComplexType_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668237);
			Compiler.NativeMethodInfoPtr_CompileAnyAttributeUnion_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668238);
			Compiler.NativeMethodInfoPtr_CompileAnyAttributeIntersection_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668239);
			Compiler.NativeMethodInfoPtr_CompileAttribute_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668240);
			Compiler.NativeMethodInfoPtr_SetDefaultFixed_Private_Void_XmlSchemaAttribute_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668241);
			Compiler.NativeMethodInfoPtr_CompileIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668242);
			Compiler.NativeMethodInfoPtr_CompileElement_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668243);
			Compiler.NativeMethodInfoPtr_CompileComplexContent_Private_ContentValidator_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668244);
			Compiler.NativeMethodInfoPtr_BuildParticleContentModel_Private_Boolean_ParticleContentValidator_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668245);
			Compiler.NativeMethodInfoPtr_CompileParticleElements_Private_Void_XmlSchemaComplexType_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668246);
			Compiler.NativeMethodInfoPtr_CompileParticleElements_Private_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668247);
			Compiler.NativeMethodInfoPtr_CompileComplexTypeElements_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668248);
			Compiler.NativeMethodInfoPtr_GetSimpleType_Private_XmlSchemaSimpleType_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668249);
			Compiler.NativeMethodInfoPtr_GetComplexType_Private_XmlSchemaComplexType_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668250);
			Compiler.NativeMethodInfoPtr_GetAnySchemaType_Private_XmlSchemaType_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668251);
			Compiler.NativeMethodInfoPtr_CopyPosition_Private_Void_XmlSchemaAnnotated_XmlSchemaAnnotated_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668252);
			Compiler.NativeMethodInfoPtr_IsFixedEqual_Private_Boolean_SchemaDeclBase_SchemaDeclBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compiler>.NativeClassPtr, 100668253);
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x000A1BCC File Offset: 0x0009FDCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 405382, RefRangeEnd = 405384, XrefRangeStart = 405333, XrefRangeEnd = 405382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Compiler(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Compiler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaForSchema);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compilationSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_ValidationEventHandler_XmlSchema_XmlSchemaCompilationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x000A1C50 File Offset: 0x0009FE50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 405392, RefRangeEnd = 405393, XrefRangeStart = 405384, XrefRangeEnd = 405392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaCompiledInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchemaSet_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x000A1CB0 File Offset: 0x0009FEB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 405557, RefRangeEnd = 405561, XrefRangeStart = 405393, XrefRangeEnd = 405557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Prepare(XmlSchema schema, bool cleanup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cleanup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_Prepare_Internal_Void_XmlSchema_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x000A1D00 File Offset: 0x0009FF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 405561, XrefRangeEnd = 405573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSForSSimpleTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_UpdateSForSSimpleTypes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x000A1D34 File Offset: 0x0009FF34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 405705, RefRangeEnd = 405706, XrefRangeStart = 405573, XrefRangeEnd = 405705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Output(SchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_Output_Private_Void_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x000A1D78 File Offset: 0x0009FF78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 405710, RefRangeEnd = 405711, XrefRangeStart = 405706, XrefRangeEnd = 405710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportAllCompiledSchemas(XmlSchemaSet schemaSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_ImportAllCompiledSchemas_Internal_Void_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x000A1DBC File Offset: 0x0009FFBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 405966, RefRangeEnd = 405968, XrefRangeStart = 405711, XrefRangeEnd = 405966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Compile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_Compile_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x000A1DF8 File Offset: 0x0009FFF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 405977, RefRangeEnd = 405979, XrefRangeStart = 405968, XrefRangeEnd = 405977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupAttribute(XmlSchemaAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CleanupAttribute_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x000A1E3C File Offset: 0x000A003C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 405984, RefRangeEnd = 405985, XrefRangeStart = 405979, XrefRangeEnd = 405984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CleanupAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x000A1E80 File Offset: 0x000A0080
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 406032, RefRangeEnd = 406034, XrefRangeStart = 405985, XrefRangeEnd = 406032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupComplexType(XmlSchemaComplexType complexType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CleanupComplexType_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x000A1EC4 File Offset: 0x000A00C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 406041, RefRangeEnd = 406044, XrefRangeStart = 406034, XrefRangeEnd = 406041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupSimpleType(XmlSchemaSimpleType simpleType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(simpleType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CleanupSimpleType_Private_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x000A1F08 File Offset: 0x000A0108
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 406066, RefRangeEnd = 406068, XrefRangeStart = 406044, XrefRangeEnd = 406066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupElement(XmlSchemaElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CleanupElement_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x000A1F4C File Offset: 0x000A014C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 406074, RefRangeEnd = 406076, XrefRangeStart = 406068, XrefRangeEnd = 406074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupAttributes(XmlSchemaObjectCollection attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CleanupAttributes_Private_Void_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x000A1F90 File Offset: 0x000A0190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 406079, RefRangeEnd = 406080, XrefRangeStart = 406076, XrefRangeEnd = 406079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupGroup(XmlSchemaGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CleanupGroup_Private_Void_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x000A1FD4 File Offset: 0x000A01D4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 406092, RefRangeEnd = 406097, XrefRangeStart = 406080, XrefRangeEnd = 406092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupParticle(XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CleanupParticle_Private_Void_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x000A2018 File Offset: 0x000A0218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 406157, RefRangeEnd = 406158, XrefRangeStart = 406097, XrefRangeEnd = 406157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSubstitutionGroups()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_ProcessSubstitutionGroups_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x000A204C File Offset: 0x000A024C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 406166, RefRangeEnd = 406167, XrefRangeStart = 406158, XrefRangeEnd = 406166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(substitutionGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x000A2090 File Offset: 0x000A0290
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 406182, RefRangeEnd = 406184, XrefRangeStart = 406167, XrefRangeEnd = 406182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(redefinedGroup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseGroup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_RecursivelyCheckRedefinedGroups_Private_Void_XmlSchemaGroup_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x000A20E4 File Offset: 0x000A02E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 406188, RefRangeEnd = 406190, XrefRangeStart = 406184, XrefRangeEnd = 406188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeGroup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseAttributeGroup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_RecursivelyCheckRedefinedAttributeGroups_Private_Void_XmlSchemaAttributeGroup_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x000A2138 File Offset: 0x000A0338
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 406194, RefRangeEnd = 406196, XrefRangeStart = 406190, XrefRangeEnd = 406194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileGroup(XmlSchemaGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileGroup_Private_Void_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x000A217C File Offset: 0x000A037C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 406267, RefRangeEnd = 406275, XrefRangeStart = 406196, XrefRangeEnd = 406267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileSimpleType(XmlSchemaSimpleType simpleType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(simpleType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileSimpleType_Private_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x000A21C0 File Offset: 0x000A03C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 406305, RefRangeEnd = 406306, XrefRangeStart = 406275, XrefRangeEnd = 406305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<XmlSchemaSimpleType> CompileBaseMemberTypes(XmlSchemaSimpleType simpleType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(simpleType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileBaseMemberTypes_Private_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaSimpleType>>(intPtr3) : null;
			}
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x000A2210 File Offset: 0x000A0410
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 406310, RefRangeEnd = 406312, XrefRangeStart = 406306, XrefRangeEnd = 406310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unionMember);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypeDefinitions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CheckUnionType_Private_Void_XmlSchemaSimpleType_ArrayList_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x000A2278 File Offset: 0x000A0478
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 406412, RefRangeEnd = 406419, XrefRangeStart = 406312, XrefRangeEnd = 406412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileComplexType(XmlSchemaComplexType complexType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileComplexType_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x000A22BC File Offset: 0x000A04BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 406447, RefRangeEnd = 406448, XrefRangeStart = 406419, XrefRangeEnd = 406447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(simpleExtension);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileSimpleContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x000A2310 File Offset: 0x000A0510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 406474, RefRangeEnd = 406475, XrefRangeStart = 406448, XrefRangeEnd = 406474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(simpleRestriction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileSimpleContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentRestriction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x000A2364 File Offset: 0x000A0564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 406500, RefRangeEnd = 406501, XrefRangeStart = 406475, XrefRangeEnd = 406500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(complexContent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(complexExtension);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileComplexContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x000A23CC File Offset: 0x000A05CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 406525, RefRangeEnd = 406526, XrefRangeStart = 406501, XrefRangeEnd = 406525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(complexContent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(complexRestriction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileComplexContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentRestriction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x000A2434 File Offset: 0x000A0634
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 406565, RefRangeEnd = 406567, XrefRangeStart = 406526, XrefRangeEnd = 406565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckParticleDerivation(XmlSchemaComplexType complexType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CheckParticleDerivation_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x000A2478 File Offset: 0x000A0678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 406567, XrefRangeEnd = 406577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedParticle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseParticle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CheckParticleDerivation_Private_Void_XmlSchemaParticle_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x000A24CC File Offset: 0x000A06CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 406594, RefRangeEnd = 406596, XrefRangeStart = 406577, XrefRangeEnd = 406594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileContentTypeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
			}
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x000A251C File Offset: 0x000A071C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 406603, RefRangeEnd = 406611, XrefRangeStart = 406596, XrefRangeEnd = 406603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref root;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CannonicalizeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x000A257C File Offset: 0x000A077C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 406617, RefRangeEnd = 406619, XrefRangeStart = 406611, XrefRangeEnd = 406617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CannonicalizeElement_Private_XmlSchemaParticle_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
			}
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x000A25CC File Offset: 0x000A07CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 406619, XrefRangeEnd = 406687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref root;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CannonicalizeGroupRef_Private_XmlSchemaParticle_XmlSchemaGroupRef_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x000A262C File Offset: 0x000A082C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 406687, XrefRangeEnd = 406708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(all);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref root;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CannonicalizeAll_Private_XmlSchemaParticle_XmlSchemaAll_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x000A268C File Offset: 0x000A088C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 406708, XrefRangeEnd = 406752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(choice);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref root;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CannonicalizeChoice_Private_XmlSchemaParticle_XmlSchemaChoice_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x000A26EC File Offset: 0x000A08EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 406752, XrefRangeEnd = 406796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref root;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CannonicalizeSequence_Private_XmlSchemaParticle_XmlSchemaSequence_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x000A274C File Offset: 0x000A094C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 406819, RefRangeEnd = 406825, XrefRangeStart = 406796, XrefRangeEnd = 406819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CannonicalizePointlessRoot_Private_XmlSchemaParticle_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
			}
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x000A279C File Offset: 0x000A099C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 406951, RefRangeEnd = 406958, XrefRangeStart = 406825, XrefRangeEnd = 406951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedParticle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseParticle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsValidRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x000A27FC File Offset: 0x000A09FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 406967, RefRangeEnd = 406968, XrefRangeStart = 406958, XrefRangeEnd = 406967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseElement);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsElementFromElement_Private_Boolean_XmlSchemaElement_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x000A285C File Offset: 0x000A0A5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 406973, RefRangeEnd = 406974, XrefRangeStart = 406968, XrefRangeEnd = 406973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseAny);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsElementFromAny_Private_Boolean_XmlSchemaElement_XmlSchemaAny_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x000A28BC File Offset: 0x000A0ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 406974, XrefRangeEnd = 406981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedAny);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseAny);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsAnyFromAny_Private_Boolean_XmlSchemaAny_XmlSchemaAny_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x000A291C File Offset: 0x000A0B1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 407007, RefRangeEnd = 407009, XrefRangeStart = 406981, XrefRangeEnd = 407007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedGroupBase);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseAny);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsGroupBaseFromAny_Private_Boolean_XmlSchemaGroupBase_XmlSchemaAny_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x000A297C File Offset: 0x000A0B7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407117, RefRangeEnd = 407118, XrefRangeStart = 407009, XrefRangeEnd = 407117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseGroupBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsElementFromGroupBase_Private_Boolean_XmlSchemaElement_XmlSchemaGroupBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x000A29DC File Offset: 0x000A0BDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407125, RefRangeEnd = 407126, XrefRangeStart = 407118, XrefRangeEnd = 407125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedChoice);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseChoice);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsChoiceFromChoiceSubstGroup_Private_Boolean_XmlSchemaChoice_XmlSchemaChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x000A2A3C File Offset: 0x000A0C3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 407144, RefRangeEnd = 407148, XrefRangeStart = 407126, XrefRangeEnd = 407144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedGroupBase);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseGroupBase);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipEmptableOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsGroupBaseFromGroupBase_Private_Boolean_XmlSchemaGroupBase_XmlSchemaGroupBase_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x000A2AAC File Offset: 0x000A0CAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407169, RefRangeEnd = 407170, XrefRangeStart = 407148, XrefRangeEnd = 407169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedSequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseAll);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsSequenceFromAll_Private_Boolean_XmlSchemaSequence_XmlSchemaAll_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x000A2B0C File Offset: 0x000A0D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407201, RefRangeEnd = 407202, XrefRangeStart = 407170, XrefRangeEnd = 407201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedSequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseChoice);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsSequenceFromChoice_Private_Boolean_XmlSchemaSequence_XmlSchemaChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x000A2B6C File Offset: 0x000A0D6C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 407206, RefRangeEnd = 407213, XrefRangeStart = 407202, XrefRangeEnd = 407206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedParticle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseParticle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x000A2BCC File Offset: 0x000A0DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407213, XrefRangeEnd = 407217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minOccurs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxOccurs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseMinOccurs;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseMaxOccurs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_Decimal_Decimal_Decimal_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x000A2C40 File Offset: 0x000A0E40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 407222, RefRangeEnd = 407225, XrefRangeStart = 407217, XrefRangeEnd = 407222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_GetMappingParticle_Private_Int32_XmlSchemaParticle_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x000A2CA0 File Offset: 0x000A0EA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 407231, RefRangeEnd = 407233, XrefRangeStart = 407225, XrefRangeEnd = 407231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsParticleEmptiable(XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsParticleEmptiable_Private_Boolean_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x000A2CF0 File Offset: 0x000A0EF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 407277, RefRangeEnd = 407280, XrefRangeStart = 407233, XrefRangeEnd = 407277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &minOccurs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxOccurs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CalculateEffectiveTotalRange_Private_Void_XmlSchemaParticle_byref_Decimal_byref_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x000A2D50 File Offset: 0x000A0F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407280, XrefRangeEnd = 407281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushComplexType(XmlSchemaComplexType complexType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_PushComplexType_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x000A2D94 File Offset: 0x000A0F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(complexContent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_GetSchemaContentType_Private_XmlSchemaContentType_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x000A2E08 File Offset: 0x000A1008
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 407351, RefRangeEnd = 407358, XrefRangeStart = 407281, XrefRangeEnd = 407351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x000A2E4C File Offset: 0x000A104C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 407533, RefRangeEnd = 407538, XrefRangeStart = 407358, XrefRangeEnd = 407533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(derivedType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(anyAttribute);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref derivedBy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileLocalAttributes_Private_Void_XmlSchemaComplexType_XmlSchemaComplexType_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x000A2ED4 File Offset: 0x000A10D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 407616, RefRangeEnd = 407618, XrefRangeStart = 407538, XrefRangeEnd = 407616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseAttributeGroup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(derivedAttributeGroup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CheckAtrributeGroupRestriction_Private_Void_XmlSchemaAttributeGroup_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x000A2F28 File Offset: 0x000A1128
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 407627, RefRangeEnd = 407629, XrefRangeStart = 407618, XrefRangeEnd = 407627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(derivedAttributeWildcard);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseAttributeWildcard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsProcessContentsRestricted_Private_Boolean_XmlSchemaComplexType_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x000A2F9C File Offset: 0x000A119C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407629, XrefRangeEnd = 407633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileAnyAttributeUnion_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr3) : null;
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x000A3000 File Offset: 0x000A1200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407633, XrefRangeEnd = 407637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileAnyAttributeIntersection_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr3) : null;
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x000A3064 File Offset: 0x000A1264
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 407692, RefRangeEnd = 407696, XrefRangeStart = 407637, XrefRangeEnd = 407692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileAttribute(XmlSchemaAttribute xa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileAttribute_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x000A30A8 File Offset: 0x000A12A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 407698, RefRangeEnd = 407700, XrefRangeStart = 407696, XrefRangeEnd = 407698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xa);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decl);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_SetDefaultFixed_Private_Void_XmlSchemaAttribute_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x000A30FC File Offset: 0x000A12FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 407734, RefRangeEnd = 407737, XrefRangeStart = 407700, XrefRangeEnd = 407734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x000A3140 File Offset: 0x000A1340
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 407845, RefRangeEnd = 407850, XrefRangeStart = 407737, XrefRangeEnd = 407845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileElement(XmlSchemaElement xe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xe);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileElement_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x000A3184 File Offset: 0x000A1384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407883, RefRangeEnd = 407884, XrefRangeStart = 407850, XrefRangeEnd = 407883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentValidator CompileComplexContent(XmlSchemaComplexType complexType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileComplexContent_Private_ContentValidator_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr3) : null;
			}
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x000A31D4 File Offset: 0x000A13D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407948, RefRangeEnd = 407949, XrefRangeStart = 407884, XrefRangeEnd = 407948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contentValidator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_BuildParticleContentModel_Private_Boolean_ParticleContentValidator_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x000A3234 File Offset: 0x000A1434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407962, RefRangeEnd = 407963, XrefRangeStart = 407949, XrefRangeEnd = 407962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileParticleElements_Private_Void_XmlSchemaComplexType_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x000A3288 File Offset: 0x000A1488
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 407973, RefRangeEnd = 407976, XrefRangeStart = 407963, XrefRangeEnd = 407973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileParticleElements(XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileParticleElements_Private_Void_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x000A32CC File Offset: 0x000A14CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407986, RefRangeEnd = 407987, XrefRangeStart = 407976, XrefRangeEnd = 407986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileComplexTypeElements(XmlSchemaComplexType complexType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CompileComplexTypeElements_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x000A3310 File Offset: 0x000A1510
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 407993, RefRangeEnd = 407997, XrefRangeStart = 407987, XrefRangeEnd = 407993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_GetSimpleType_Private_XmlSchemaSimpleType_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x000A3360 File Offset: 0x000A1560
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 407999, RefRangeEnd = 408001, XrefRangeStart = 407997, XrefRangeEnd = 407999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaComplexType GetComplexType(XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_GetComplexType_Private_XmlSchemaComplexType_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr3) : null;
			}
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x000A33B0 File Offset: 0x000A15B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 408009, RefRangeEnd = 408011, XrefRangeStart = 408001, XrefRangeEnd = 408009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaType GetAnySchemaType(XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_GetAnySchemaType_Private_XmlSchemaType_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x000A3400 File Offset: 0x000A1600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408011, XrefRangeEnd = 408013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(to);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(from);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyParent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_CopyPosition_Private_Void_XmlSchemaAnnotated_XmlSchemaAnnotated_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x000A3464 File Offset: 0x000A1664
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 408017, RefRangeEnd = 408020, XrefRangeStart = 408013, XrefRangeEnd = 408017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFixedEqual(SchemaDeclBase baseDecl, SchemaDeclBase derivedDecl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseDecl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(derivedDecl);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compiler.NativeMethodInfoPtr_IsFixedEqual_Private_Boolean_SchemaDeclBase_SchemaDeclBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x0000E4A7 File Offset: 0x0000C6A7
		public Compiler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x060021E9 RID: 8681 RVA: 0x000A34C4 File Offset: 0x000A16C4
		// (set) Token: 0x060021EA RID: 8682 RVA: 0x0000E4B0 File Offset: 0x0000C6B0
		public unsafe string restrictionErrorMsg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_restrictionErrorMsg);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_restrictionErrorMsg), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x060021EB RID: 8683 RVA: 0x000A34EC File Offset: 0x000A16EC
		// (set) Token: 0x060021EC RID: 8684 RVA: 0x0000E4CF File Offset: 0x0000C6CF
		public unsafe XmlSchemaObjectTable attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x060021ED RID: 8685 RVA: 0x000A351C File Offset: 0x000A171C
		// (set) Token: 0x060021EE RID: 8686 RVA: 0x0000E4EE File Offset: 0x0000C6EE
		public unsafe XmlSchemaObjectTable attributeGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_attributeGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_attributeGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x060021EF RID: 8687 RVA: 0x000A354C File Offset: 0x000A174C
		// (set) Token: 0x060021F0 RID: 8688 RVA: 0x0000E50D File Offset: 0x0000C70D
		public unsafe XmlSchemaObjectTable elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060021F1 RID: 8689 RVA: 0x000A357C File Offset: 0x000A177C
		// (set) Token: 0x060021F2 RID: 8690 RVA: 0x0000E52C File Offset: 0x0000C72C
		public unsafe XmlSchemaObjectTable schemaTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_schemaTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_schemaTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x060021F3 RID: 8691 RVA: 0x000A35AC File Offset: 0x000A17AC
		// (set) Token: 0x060021F4 RID: 8692 RVA: 0x0000E54B File Offset: 0x0000C74B
		public unsafe XmlSchemaObjectTable groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x060021F5 RID: 8693 RVA: 0x000A35DC File Offset: 0x000A17DC
		// (set) Token: 0x060021F6 RID: 8694 RVA: 0x0000E56A File Offset: 0x0000C76A
		public unsafe XmlSchemaObjectTable notations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_notations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_notations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x060021F7 RID: 8695 RVA: 0x000A360C File Offset: 0x000A180C
		// (set) Token: 0x060021F8 RID: 8696 RVA: 0x0000E589 File Offset: 0x0000C789
		public unsafe XmlSchemaObjectTable examplars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_examplars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_examplars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x060021F9 RID: 8697 RVA: 0x000A363C File Offset: 0x000A183C
		// (set) Token: 0x060021FA RID: 8698 RVA: 0x0000E5A8 File Offset: 0x0000C7A8
		public unsafe XmlSchemaObjectTable identityConstraints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_identityConstraints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_identityConstraints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x060021FB RID: 8699 RVA: 0x000A366C File Offset: 0x000A186C
		// (set) Token: 0x060021FC RID: 8700 RVA: 0x0000E5C7 File Offset: 0x0000C7C7
		public unsafe Stack complexTypeStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_complexTypeStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_complexTypeStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x060021FD RID: 8701 RVA: 0x000A369C File Offset: 0x000A189C
		// (set) Token: 0x060021FE RID: 8702 RVA: 0x0000E5E6 File Offset: 0x0000C7E6
		public unsafe Hashtable schemasToCompile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_schemasToCompile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_schemasToCompile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x060021FF RID: 8703 RVA: 0x000A36CC File Offset: 0x000A18CC
		// (set) Token: 0x06002200 RID: 8704 RVA: 0x0000E605 File Offset: 0x0000C805
		public unsafe Hashtable importedSchemas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_importedSchemas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_importedSchemas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06002201 RID: 8705 RVA: 0x000A36FC File Offset: 0x000A18FC
		// (set) Token: 0x06002202 RID: 8706 RVA: 0x0000E624 File Offset: 0x0000C824
		public unsafe XmlSchema schemaForSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_schemaForSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compiler.NativeFieldInfoPtr_schemaForSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001960 RID: 6496
		private static readonly IntPtr NativeFieldInfoPtr_restrictionErrorMsg;

		// Token: 0x04001961 RID: 6497
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04001962 RID: 6498
		private static readonly IntPtr NativeFieldInfoPtr_attributeGroups;

		// Token: 0x04001963 RID: 6499
		private static readonly IntPtr NativeFieldInfoPtr_elements;

		// Token: 0x04001964 RID: 6500
		private static readonly IntPtr NativeFieldInfoPtr_schemaTypes;

		// Token: 0x04001965 RID: 6501
		private static readonly IntPtr NativeFieldInfoPtr_groups;

		// Token: 0x04001966 RID: 6502
		private static readonly IntPtr NativeFieldInfoPtr_notations;

		// Token: 0x04001967 RID: 6503
		private static readonly IntPtr NativeFieldInfoPtr_examplars;

		// Token: 0x04001968 RID: 6504
		private static readonly IntPtr NativeFieldInfoPtr_identityConstraints;

		// Token: 0x04001969 RID: 6505
		private static readonly IntPtr NativeFieldInfoPtr_complexTypeStack;

		// Token: 0x0400196A RID: 6506
		private static readonly IntPtr NativeFieldInfoPtr_schemasToCompile;

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeFieldInfoPtr_importedSchemas;

		// Token: 0x0400196C RID: 6508
		private static readonly IntPtr NativeFieldInfoPtr_schemaForSchema;

		// Token: 0x0400196D RID: 6509
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_ValidationEventHandler_XmlSchema_XmlSchemaCompilationSettings_0;

		// Token: 0x0400196E RID: 6510
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchemaSet_SchemaInfo_0;

		// Token: 0x0400196F RID: 6511
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Internal_Void_XmlSchema_Boolean_0;

		// Token: 0x04001970 RID: 6512
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSForSSimpleTypes_Private_Void_0;

		// Token: 0x04001971 RID: 6513
		private static readonly IntPtr NativeMethodInfoPtr_Output_Private_Void_SchemaInfo_0;

		// Token: 0x04001972 RID: 6514
		private static readonly IntPtr NativeMethodInfoPtr_ImportAllCompiledSchemas_Internal_Void_XmlSchemaSet_0;

		// Token: 0x04001973 RID: 6515
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Internal_Boolean_0;

		// Token: 0x04001974 RID: 6516
		private static readonly IntPtr NativeMethodInfoPtr_CleanupAttribute_Private_Void_XmlSchemaAttribute_0;

		// Token: 0x04001975 RID: 6517
		private static readonly IntPtr NativeMethodInfoPtr_CleanupAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0;

		// Token: 0x04001976 RID: 6518
		private static readonly IntPtr NativeMethodInfoPtr_CleanupComplexType_Private_Void_XmlSchemaComplexType_0;

		// Token: 0x04001977 RID: 6519
		private static readonly IntPtr NativeMethodInfoPtr_CleanupSimpleType_Private_Void_XmlSchemaSimpleType_0;

		// Token: 0x04001978 RID: 6520
		private static readonly IntPtr NativeMethodInfoPtr_CleanupElement_Private_Void_XmlSchemaElement_0;

		// Token: 0x04001979 RID: 6521
		private static readonly IntPtr NativeMethodInfoPtr_CleanupAttributes_Private_Void_XmlSchemaObjectCollection_0;

		// Token: 0x0400197A RID: 6522
		private static readonly IntPtr NativeMethodInfoPtr_CleanupGroup_Private_Void_XmlSchemaGroup_0;

		// Token: 0x0400197B RID: 6523
		private static readonly IntPtr NativeMethodInfoPtr_CleanupParticle_Private_Void_XmlSchemaParticle_0;

		// Token: 0x0400197C RID: 6524
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSubstitutionGroups_Private_Void_0;

		// Token: 0x0400197D RID: 6525
		private static readonly IntPtr NativeMethodInfoPtr_CompileSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroup_0;

		// Token: 0x0400197E RID: 6526
		private static readonly IntPtr NativeMethodInfoPtr_RecursivelyCheckRedefinedGroups_Private_Void_XmlSchemaGroup_XmlSchemaGroup_0;

		// Token: 0x0400197F RID: 6527
		private static readonly IntPtr NativeMethodInfoPtr_RecursivelyCheckRedefinedAttributeGroups_Private_Void_XmlSchemaAttributeGroup_XmlSchemaAttributeGroup_0;

		// Token: 0x04001980 RID: 6528
		private static readonly IntPtr NativeMethodInfoPtr_CompileGroup_Private_Void_XmlSchemaGroup_0;

		// Token: 0x04001981 RID: 6529
		private static readonly IntPtr NativeMethodInfoPtr_CompileSimpleType_Private_Void_XmlSchemaSimpleType_0;

		// Token: 0x04001982 RID: 6530
		private static readonly IntPtr NativeMethodInfoPtr_CompileBaseMemberTypes_Private_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaSimpleType_0;

		// Token: 0x04001983 RID: 6531
		private static readonly IntPtr NativeMethodInfoPtr_CheckUnionType_Private_Void_XmlSchemaSimpleType_ArrayList_XmlSchemaSimpleType_0;

		// Token: 0x04001984 RID: 6532
		private static readonly IntPtr NativeMethodInfoPtr_CompileComplexType_Private_Void_XmlSchemaComplexType_0;

		// Token: 0x04001985 RID: 6533
		private static readonly IntPtr NativeMethodInfoPtr_CompileSimpleContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentExtension_0;

		// Token: 0x04001986 RID: 6534
		private static readonly IntPtr NativeMethodInfoPtr_CompileSimpleContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentRestriction_0;

		// Token: 0x04001987 RID: 6535
		private static readonly IntPtr NativeMethodInfoPtr_CompileComplexContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentExtension_0;

		// Token: 0x04001988 RID: 6536
		private static readonly IntPtr NativeMethodInfoPtr_CompileComplexContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentRestriction_0;

		// Token: 0x04001989 RID: 6537
		private static readonly IntPtr NativeMethodInfoPtr_CheckParticleDerivation_Private_Void_XmlSchemaComplexType_0;

		// Token: 0x0400198A RID: 6538
		private static readonly IntPtr NativeMethodInfoPtr_CheckParticleDerivation_Private_Void_XmlSchemaParticle_XmlSchemaParticle_0;

		// Token: 0x0400198B RID: 6539
		private static readonly IntPtr NativeMethodInfoPtr_CompileContentTypeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_0;

		// Token: 0x0400198C RID: 6540
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_Boolean_0;

		// Token: 0x0400198D RID: 6541
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizeElement_Private_XmlSchemaParticle_XmlSchemaElement_0;

		// Token: 0x0400198E RID: 6542
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizeGroupRef_Private_XmlSchemaParticle_XmlSchemaGroupRef_Boolean_0;

		// Token: 0x0400198F RID: 6543
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizeAll_Private_XmlSchemaParticle_XmlSchemaAll_Boolean_0;

		// Token: 0x04001990 RID: 6544
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizeChoice_Private_XmlSchemaParticle_XmlSchemaChoice_Boolean_0;

		// Token: 0x04001991 RID: 6545
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizeSequence_Private_XmlSchemaParticle_XmlSchemaSequence_Boolean_0;

		// Token: 0x04001992 RID: 6546
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizePointlessRoot_Private_XmlSchemaParticle_XmlSchemaParticle_0;

		// Token: 0x04001993 RID: 6547
		private static readonly IntPtr NativeMethodInfoPtr_IsValidRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0;

		// Token: 0x04001994 RID: 6548
		private static readonly IntPtr NativeMethodInfoPtr_IsElementFromElement_Private_Boolean_XmlSchemaElement_XmlSchemaElement_0;

		// Token: 0x04001995 RID: 6549
		private static readonly IntPtr NativeMethodInfoPtr_IsElementFromAny_Private_Boolean_XmlSchemaElement_XmlSchemaAny_0;

		// Token: 0x04001996 RID: 6550
		private static readonly IntPtr NativeMethodInfoPtr_IsAnyFromAny_Private_Boolean_XmlSchemaAny_XmlSchemaAny_0;

		// Token: 0x04001997 RID: 6551
		private static readonly IntPtr NativeMethodInfoPtr_IsGroupBaseFromAny_Private_Boolean_XmlSchemaGroupBase_XmlSchemaAny_0;

		// Token: 0x04001998 RID: 6552
		private static readonly IntPtr NativeMethodInfoPtr_IsElementFromGroupBase_Private_Boolean_XmlSchemaElement_XmlSchemaGroupBase_0;

		// Token: 0x04001999 RID: 6553
		private static readonly IntPtr NativeMethodInfoPtr_IsChoiceFromChoiceSubstGroup_Private_Boolean_XmlSchemaChoice_XmlSchemaChoice_0;

		// Token: 0x0400199A RID: 6554
		private static readonly IntPtr NativeMethodInfoPtr_IsGroupBaseFromGroupBase_Private_Boolean_XmlSchemaGroupBase_XmlSchemaGroupBase_Boolean_0;

		// Token: 0x0400199B RID: 6555
		private static readonly IntPtr NativeMethodInfoPtr_IsSequenceFromAll_Private_Boolean_XmlSchemaSequence_XmlSchemaAll_0;

		// Token: 0x0400199C RID: 6556
		private static readonly IntPtr NativeMethodInfoPtr_IsSequenceFromChoice_Private_Boolean_XmlSchemaSequence_XmlSchemaChoice_0;

		// Token: 0x0400199D RID: 6557
		private static readonly IntPtr NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0;

		// Token: 0x0400199E RID: 6558
		private static readonly IntPtr NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_Decimal_Decimal_Decimal_Decimal_0;

		// Token: 0x0400199F RID: 6559
		private static readonly IntPtr NativeMethodInfoPtr_GetMappingParticle_Private_Int32_XmlSchemaParticle_XmlSchemaObjectCollection_0;

		// Token: 0x040019A0 RID: 6560
		private static readonly IntPtr NativeMethodInfoPtr_IsParticleEmptiable_Private_Boolean_XmlSchemaParticle_0;

		// Token: 0x040019A1 RID: 6561
		private static readonly IntPtr NativeMethodInfoPtr_CalculateEffectiveTotalRange_Private_Void_XmlSchemaParticle_byref_Decimal_byref_Decimal_0;

		// Token: 0x040019A2 RID: 6562
		private static readonly IntPtr NativeMethodInfoPtr_PushComplexType_Private_Void_XmlSchemaComplexType_0;

		// Token: 0x040019A3 RID: 6563
		private static readonly IntPtr NativeMethodInfoPtr_GetSchemaContentType_Private_XmlSchemaContentType_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaParticle_0;

		// Token: 0x040019A4 RID: 6564
		private static readonly IntPtr NativeMethodInfoPtr_CompileAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0;

		// Token: 0x040019A5 RID: 6565
		private static readonly IntPtr NativeMethodInfoPtr_CompileLocalAttributes_Private_Void_XmlSchemaComplexType_XmlSchemaComplexType_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaDerivationMethod_0;

		// Token: 0x040019A6 RID: 6566
		private static readonly IntPtr NativeMethodInfoPtr_CheckAtrributeGroupRestriction_Private_Void_XmlSchemaAttributeGroup_XmlSchemaAttributeGroup_0;

		// Token: 0x040019A7 RID: 6567
		private static readonly IntPtr NativeMethodInfoPtr_IsProcessContentsRestricted_Private_Boolean_XmlSchemaComplexType_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0;

		// Token: 0x040019A8 RID: 6568
		private static readonly IntPtr NativeMethodInfoPtr_CompileAnyAttributeUnion_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0;

		// Token: 0x040019A9 RID: 6569
		private static readonly IntPtr NativeMethodInfoPtr_CompileAnyAttributeIntersection_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0;

		// Token: 0x040019AA RID: 6570
		private static readonly IntPtr NativeMethodInfoPtr_CompileAttribute_Private_Void_XmlSchemaAttribute_0;

		// Token: 0x040019AB RID: 6571
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultFixed_Private_Void_XmlSchemaAttribute_SchemaAttDef_0;

		// Token: 0x040019AC RID: 6572
		private static readonly IntPtr NativeMethodInfoPtr_CompileIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0;

		// Token: 0x040019AD RID: 6573
		private static readonly IntPtr NativeMethodInfoPtr_CompileElement_Private_Void_XmlSchemaElement_0;

		// Token: 0x040019AE RID: 6574
		private static readonly IntPtr NativeMethodInfoPtr_CompileComplexContent_Private_ContentValidator_XmlSchemaComplexType_0;

		// Token: 0x040019AF RID: 6575
		private static readonly IntPtr NativeMethodInfoPtr_BuildParticleContentModel_Private_Boolean_ParticleContentValidator_XmlSchemaParticle_0;

		// Token: 0x040019B0 RID: 6576
		private static readonly IntPtr NativeMethodInfoPtr_CompileParticleElements_Private_Void_XmlSchemaComplexType_XmlSchemaParticle_0;

		// Token: 0x040019B1 RID: 6577
		private static readonly IntPtr NativeMethodInfoPtr_CompileParticleElements_Private_Void_XmlSchemaParticle_0;

		// Token: 0x040019B2 RID: 6578
		private static readonly IntPtr NativeMethodInfoPtr_CompileComplexTypeElements_Private_Void_XmlSchemaComplexType_0;

		// Token: 0x040019B3 RID: 6579
		private static readonly IntPtr NativeMethodInfoPtr_GetSimpleType_Private_XmlSchemaSimpleType_XmlQualifiedName_0;

		// Token: 0x040019B4 RID: 6580
		private static readonly IntPtr NativeMethodInfoPtr_GetComplexType_Private_XmlSchemaComplexType_XmlQualifiedName_0;

		// Token: 0x040019B5 RID: 6581
		private static readonly IntPtr NativeMethodInfoPtr_GetAnySchemaType_Private_XmlSchemaType_XmlQualifiedName_0;

		// Token: 0x040019B6 RID: 6582
		private static readonly IntPtr NativeMethodInfoPtr_CopyPosition_Private_Void_XmlSchemaAnnotated_XmlSchemaAnnotated_Boolean_0;

		// Token: 0x040019B7 RID: 6583
		private static readonly IntPtr NativeMethodInfoPtr_IsFixedEqual_Private_Boolean_SchemaDeclBase_SchemaDeclBase_0;
	}
}
