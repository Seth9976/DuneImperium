using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000183 RID: 387
	public sealed class SchemaCollectionCompiler : BaseProcessor
	{
		// Token: 0x06001EEB RID: 7915 RVA: 0x000982F8 File Offset: 0x000964F8
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaCollectionCompiler()
		{
			Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaCollectionCompiler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr);
			SchemaCollectionCompiler.NativeFieldInfoPtr_compileContentModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, "compileContentModel");
			SchemaCollectionCompiler.NativeFieldInfoPtr_examplars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, "examplars");
			SchemaCollectionCompiler.NativeFieldInfoPtr_complexTypeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, "complexTypeStack");
			SchemaCollectionCompiler.NativeFieldInfoPtr_schema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, "schema");
			SchemaCollectionCompiler.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667933);
			SchemaCollectionCompiler.NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_SchemaInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667934);
			SchemaCollectionCompiler.NativeMethodInfoPtr_Prepare_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667935);
			SchemaCollectionCompiler.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667936);
			SchemaCollectionCompiler.NativeMethodInfoPtr_Cleanup_Internal_Static_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667937);
			SchemaCollectionCompiler.NativeMethodInfoPtr_Compile_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667938);
			SchemaCollectionCompiler.NativeMethodInfoPtr_Output_Private_Void_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667939);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CleanupAttribute_Private_Static_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667940);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CleanupAttributeGroup_Private_Static_Void_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667941);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CleanupComplexType_Private_Static_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667942);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CleanupSimpleType_Private_Static_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667943);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CleanupElement_Private_Static_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667944);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CleanupAttributes_Private_Static_Void_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667945);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CleanupGroup_Private_Static_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667946);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CleanupParticle_Private_Static_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667947);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroupV1Compat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667948);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CheckSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667949);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileGroup_Private_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667950);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileSimpleType_Private_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667951);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileBaseMemberTypes_Private_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667952);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CheckUnionType_Private_Void_XmlSchemaSimpleType_ArrayList_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667953);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileComplexType_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667954);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileSimpleContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667955);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileSimpleContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentRestriction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667956);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileComplexContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667957);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileComplexContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentRestriction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667958);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CheckParticleDerivation_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667959);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileContentTypeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667960);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CannonicalizeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667961);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CannonicalizeElement_Private_XmlSchemaParticle_XmlSchemaElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667962);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CannonicalizeGroupRef_Private_XmlSchemaParticle_XmlSchemaGroupRef_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667963);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CannonicalizeAll_Private_XmlSchemaParticle_XmlSchemaAll_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667964);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CannonicalizeChoice_Private_XmlSchemaParticle_XmlSchemaChoice_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667965);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CannonicalizeSequence_Private_XmlSchemaParticle_XmlSchemaSequence_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667966);
			SchemaCollectionCompiler.NativeMethodInfoPtr_IsValidRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667967);
			SchemaCollectionCompiler.NativeMethodInfoPtr_IsElementFromElement_Private_Boolean_XmlSchemaElement_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667968);
			SchemaCollectionCompiler.NativeMethodInfoPtr_IsElementFromAny_Private_Boolean_XmlSchemaElement_XmlSchemaAny_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667969);
			SchemaCollectionCompiler.NativeMethodInfoPtr_IsAnyFromAny_Private_Boolean_XmlSchemaAny_XmlSchemaAny_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667970);
			SchemaCollectionCompiler.NativeMethodInfoPtr_IsGroupBaseFromAny_Private_Boolean_XmlSchemaGroupBase_XmlSchemaAny_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667971);
			SchemaCollectionCompiler.NativeMethodInfoPtr_IsElementFromGroupBase_Private_Boolean_XmlSchemaElement_XmlSchemaGroupBase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667972);
			SchemaCollectionCompiler.NativeMethodInfoPtr_IsGroupBaseFromGroupBase_Private_Boolean_XmlSchemaGroupBase_XmlSchemaGroupBase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667973);
			SchemaCollectionCompiler.NativeMethodInfoPtr_IsSequenceFromAll_Private_Boolean_XmlSchemaSequence_XmlSchemaAll_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667974);
			SchemaCollectionCompiler.NativeMethodInfoPtr_IsSequenceFromChoice_Private_Boolean_XmlSchemaSequence_XmlSchemaChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667975);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CalculateSequenceRange_Private_Void_XmlSchemaSequence_byref_Decimal_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667976);
			SchemaCollectionCompiler.NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667977);
			SchemaCollectionCompiler.NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_Decimal_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667978);
			SchemaCollectionCompiler.NativeMethodInfoPtr_GetMappingParticle_Private_Int32_XmlSchemaParticle_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667979);
			SchemaCollectionCompiler.NativeMethodInfoPtr_IsParticleEmptiable_Private_Boolean_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667980);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CalculateEffectiveTotalRange_Private_Void_XmlSchemaParticle_byref_Decimal_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667981);
			SchemaCollectionCompiler.NativeMethodInfoPtr_PushComplexType_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667982);
			SchemaCollectionCompiler.NativeMethodInfoPtr_GetSchemaContentType_Private_XmlSchemaContentType_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667983);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667984);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileLocalAttributes_Private_Void_XmlSchemaComplexType_XmlSchemaComplexType_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667985);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileAnyAttributeUnion_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667986);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileAnyAttributeIntersection_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667987);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileAttribute_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667988);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667989);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileElement_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667990);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileComplexContent_Private_ContentValidator_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667991);
			SchemaCollectionCompiler.NativeMethodInfoPtr_BuildParticleContentModel_Private_Void_ParticleContentValidator_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667992);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileParticleElements_Private_Void_XmlSchemaComplexType_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667993);
			SchemaCollectionCompiler.NativeMethodInfoPtr_CompileCompexTypeElements_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667994);
			SchemaCollectionCompiler.NativeMethodInfoPtr_GetSimpleType_Private_XmlSchemaSimpleType_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667995);
			SchemaCollectionCompiler.NativeMethodInfoPtr_GetComplexType_Private_XmlSchemaComplexType_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667996);
			SchemaCollectionCompiler.NativeMethodInfoPtr_GetAnySchemaType_Private_XmlSchemaType_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100667997);
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x0009888C File Offset: 0x00096A8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399764, RefRangeEnd = 399765, XrefRangeStart = 399753, XrefRangeEnd = 399764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaCollectionCompiler(XmlNameTable nameTable, ValidationEventHandler eventHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x000988EC File Offset: 0x00096AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399772, RefRangeEnd = 399773, XrefRangeStart = 399765, XrefRangeEnd = 399772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compileContentModel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_SchemaInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x0009895C File Offset: 0x00096B5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399806, RefRangeEnd = 399807, XrefRangeStart = 399773, XrefRangeEnd = 399806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Prepare()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_Prepare_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x00098990 File Offset: 0x00096B90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399924, RefRangeEnd = 399925, XrefRangeStart = 399807, XrefRangeEnd = 399924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x000989C4 File Offset: 0x00096BC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 400014, RefRangeEnd = 400016, XrefRangeStart = 399925, XrefRangeEnd = 400014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Cleanup(XmlSchema schema)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_Cleanup_Internal_Static_Void_XmlSchema_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x000989FC File Offset: 0x00096BFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 400264, RefRangeEnd = 400265, XrefRangeStart = 400016, XrefRangeEnd = 400264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Compile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_Compile_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x00098A30 File Offset: 0x00096C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 400386, RefRangeEnd = 400387, XrefRangeStart = 400265, XrefRangeEnd = 400386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Output(SchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_Output_Private_Void_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x00098A74 File Offset: 0x00096C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400387, XrefRangeEnd = 400390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupAttribute(XmlSchemaAttribute attribute)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CleanupAttribute_Private_Static_Void_XmlSchemaAttribute_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x00098AAC File Offset: 0x00096CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400390, XrefRangeEnd = 400395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CleanupAttributeGroup_Private_Static_Void_XmlSchemaAttributeGroup_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x00098AE4 File Offset: 0x00096CE4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 400435, RefRangeEnd = 400439, XrefRangeStart = 400395, XrefRangeEnd = 400435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupComplexType(XmlSchemaComplexType complexType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CleanupComplexType_Private_Static_Void_XmlSchemaComplexType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x00098B1C File Offset: 0x00096D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400439, XrefRangeEnd = 400441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupSimpleType(XmlSchemaSimpleType simpleType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(simpleType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CleanupSimpleType_Private_Static_Void_XmlSchemaSimpleType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x00098B54 File Offset: 0x00096D54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 400460, RefRangeEnd = 400464, XrefRangeStart = 400441, XrefRangeEnd = 400460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupElement(XmlSchemaElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CleanupElement_Private_Static_Void_XmlSchemaElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x00098B8C File Offset: 0x00096D8C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 400471, RefRangeEnd = 400476, XrefRangeStart = 400464, XrefRangeEnd = 400471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupAttributes(XmlSchemaObjectCollection attributes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CleanupAttributes_Private_Static_Void_XmlSchemaObjectCollection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00098BC4 File Offset: 0x00096DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400476, XrefRangeEnd = 400479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupGroup(XmlSchemaGroup group)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CleanupGroup_Private_Static_Void_XmlSchemaGroup_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x00098BFC File Offset: 0x00096DFC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 400491, RefRangeEnd = 400499, XrefRangeStart = 400479, XrefRangeEnd = 400491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupParticle(XmlSchemaParticle particle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CleanupParticle_Private_Static_Void_XmlSchemaParticle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x00098C34 File Offset: 0x00096E34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 400507, RefRangeEnd = 400508, XrefRangeStart = 400499, XrefRangeEnd = 400507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(substitutionGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroupV1Compat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x00098C78 File Offset: 0x00096E78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 400518, RefRangeEnd = 400519, XrefRangeStart = 400508, XrefRangeEnd = 400518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(substitutionGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CheckSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x00098CBC File Offset: 0x00096EBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 400523, RefRangeEnd = 400525, XrefRangeStart = 400519, XrefRangeEnd = 400523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileGroup(XmlSchemaGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileGroup_Private_Void_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x00098D00 File Offset: 0x00096F00
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 400592, RefRangeEnd = 400600, XrefRangeStart = 400525, XrefRangeEnd = 400592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileSimpleType(XmlSchemaSimpleType simpleType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(simpleType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileSimpleType_Private_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x00098D44 File Offset: 0x00096F44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 400630, RefRangeEnd = 400631, XrefRangeStart = 400600, XrefRangeEnd = 400630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<XmlSchemaSimpleType> CompileBaseMemberTypes(XmlSchemaSimpleType simpleType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(simpleType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileBaseMemberTypes_Private_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaSimpleType>>(intPtr3) : null;
			}
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x00098D94 File Offset: 0x00096F94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 400635, RefRangeEnd = 400637, XrefRangeStart = 400631, XrefRangeEnd = 400635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CheckUnionType_Private_Void_XmlSchemaSimpleType_ArrayList_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x00098DFC File Offset: 0x00096FFC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 400755, RefRangeEnd = 400762, XrefRangeStart = 400637, XrefRangeEnd = 400755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileComplexType(XmlSchemaComplexType complexType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileComplexType_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x00098E40 File Offset: 0x00097040
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 400790, RefRangeEnd = 400792, XrefRangeStart = 400762, XrefRangeEnd = 400790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileSimpleContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x00098E94 File Offset: 0x00097094
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 400818, RefRangeEnd = 400820, XrefRangeStart = 400792, XrefRangeEnd = 400818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileSimpleContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentRestriction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x00098EE8 File Offset: 0x000970E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 400838, RefRangeEnd = 400839, XrefRangeStart = 400820, XrefRangeEnd = 400838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileComplexContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x00098F50 File Offset: 0x00097150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 400855, RefRangeEnd = 400856, XrefRangeStart = 400839, XrefRangeEnd = 400855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileComplexContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentRestriction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x00098FB8 File Offset: 0x000971B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 400869, RefRangeEnd = 400871, XrefRangeStart = 400856, XrefRangeEnd = 400869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckParticleDerivation(XmlSchemaComplexType complexType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CheckParticleDerivation_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x00098FFC File Offset: 0x000971FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 400888, RefRangeEnd = 400889, XrefRangeStart = 400871, XrefRangeEnd = 400888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref substitution;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileContentTypeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x0009905C File Offset: 0x0009725C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 400922, RefRangeEnd = 400927, XrefRangeStart = 400889, XrefRangeEnd = 400922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref root;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref substitution;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CannonicalizeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x000990C8 File Offset: 0x000972C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400927, XrefRangeEnd = 400935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref substitution;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CannonicalizeElement_Private_XmlSchemaParticle_XmlSchemaElement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x00099128 File Offset: 0x00097328
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401002, RefRangeEnd = 401003, XrefRangeStart = 400935, XrefRangeEnd = 401002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref root;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref substitution;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CannonicalizeGroupRef_Private_XmlSchemaParticle_XmlSchemaGroupRef_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x00099194 File Offset: 0x00097394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401035, RefRangeEnd = 401036, XrefRangeStart = 401003, XrefRangeEnd = 401035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(all);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref root;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref substitution;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CannonicalizeAll_Private_XmlSchemaParticle_XmlSchemaAll_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x00099200 File Offset: 0x00097400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401078, RefRangeEnd = 401079, XrefRangeStart = 401036, XrefRangeEnd = 401078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(choice);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref root;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref substitution;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CannonicalizeChoice_Private_XmlSchemaParticle_XmlSchemaChoice_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x0009926C File Offset: 0x0009746C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401121, RefRangeEnd = 401122, XrefRangeStart = 401079, XrefRangeEnd = 401121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref root;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref substitution;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CannonicalizeSequence_Private_XmlSchemaParticle_XmlSchemaSequence_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x000992D8 File Offset: 0x000974D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 401152, RefRangeEnd = 401156, XrefRangeStart = 401122, XrefRangeEnd = 401152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_IsValidRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x00099338 File Offset: 0x00097538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401156, XrefRangeEnd = 401163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_IsElementFromElement_Private_Boolean_XmlSchemaElement_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00099398 File Offset: 0x00097598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401163, XrefRangeEnd = 401164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_IsElementFromAny_Private_Boolean_XmlSchemaElement_XmlSchemaAny_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x000993F8 File Offset: 0x000975F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401164, XrefRangeEnd = 401165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_IsAnyFromAny_Private_Boolean_XmlSchemaAny_XmlSchemaAny_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00099458 File Offset: 0x00097658
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401185, RefRangeEnd = 401186, XrefRangeStart = 401165, XrefRangeEnd = 401185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_IsGroupBaseFromAny_Private_Boolean_XmlSchemaGroupBase_XmlSchemaAny_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x000994B8 File Offset: 0x000976B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401191, RefRangeEnd = 401192, XrefRangeStart = 401186, XrefRangeEnd = 401191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseGroupBase);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipEmptableOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_IsElementFromGroupBase_Private_Boolean_XmlSchemaElement_XmlSchemaGroupBase_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00099528 File Offset: 0x00097728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401192, XrefRangeEnd = 401206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_IsGroupBaseFromGroupBase_Private_Boolean_XmlSchemaGroupBase_XmlSchemaGroupBase_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00099598 File Offset: 0x00097798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401206, XrefRangeEnd = 401227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_IsSequenceFromAll_Private_Boolean_XmlSchemaSequence_XmlSchemaAll_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x000995F8 File Offset: 0x000977F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401227, XrefRangeEnd = 401242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_IsSequenceFromChoice_Private_Boolean_XmlSchemaSequence_XmlSchemaChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x00099658 File Offset: 0x00097858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401273, RefRangeEnd = 401274, XrefRangeStart = 401242, XrefRangeEnd = 401273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateSequenceRange(XmlSchemaSequence sequence, out Decimal minOccurs, out Decimal maxOccurs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &minOccurs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxOccurs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CalculateSequenceRange_Private_Void_XmlSchemaSequence_byref_Decimal_byref_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x000996B8 File Offset: 0x000978B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 401278, RefRangeEnd = 401285, XrefRangeStart = 401274, XrefRangeEnd = 401278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x00099718 File Offset: 0x00097918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401285, XrefRangeEnd = 401289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_Decimal_Decimal_Decimal_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x0009978C File Offset: 0x0009798C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 401294, RefRangeEnd = 401296, XrefRangeStart = 401289, XrefRangeEnd = 401294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_GetMappingParticle_Private_Int32_XmlSchemaParticle_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x000997EC File Offset: 0x000979EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 401302, RefRangeEnd = 401305, XrefRangeStart = 401296, XrefRangeEnd = 401302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsParticleEmptiable(XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_IsParticleEmptiable_Private_Boolean_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x0009983C File Offset: 0x00097A3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 401341, RefRangeEnd = 401344, XrefRangeStart = 401305, XrefRangeEnd = 401341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CalculateEffectiveTotalRange_Private_Void_XmlSchemaParticle_byref_Decimal_byref_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x0009989C File Offset: 0x00097A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401344, XrefRangeEnd = 401345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushComplexType(XmlSchemaComplexType complexType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_PushComplexType_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x000998E0 File Offset: 0x00097AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401345, XrefRangeEnd = 401346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_GetSchemaContentType_Private_XmlSchemaContentType_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x00099954 File Offset: 0x00097B54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 401413, RefRangeEnd = 401416, XrefRangeStart = 401346, XrefRangeEnd = 401413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x00099998 File Offset: 0x00097B98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 401584, RefRangeEnd = 401587, XrefRangeStart = 401416, XrefRangeEnd = 401584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileLocalAttributes_Private_Void_XmlSchemaComplexType_XmlSchemaComplexType_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x00099A20 File Offset: 0x00097C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401587, XrefRangeEnd = 401591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileAnyAttributeUnion_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr3) : null;
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00099A84 File Offset: 0x00097C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401591, XrefRangeEnd = 401595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileAnyAttributeIntersection_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr3) : null;
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00099AE8 File Offset: 0x00097CE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 401675, RefRangeEnd = 401679, XrefRangeStart = 401595, XrefRangeEnd = 401675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileAttribute(XmlSchemaAttribute xa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileAttribute_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x00099B2C File Offset: 0x00097D2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 401712, RefRangeEnd = 401715, XrefRangeStart = 401679, XrefRangeEnd = 401712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x00099B70 File Offset: 0x00097D70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 401812, RefRangeEnd = 401816, XrefRangeStart = 401715, XrefRangeEnd = 401812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileElement(XmlSchemaElement xe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xe);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileElement_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x00099BB4 File Offset: 0x00097DB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401849, RefRangeEnd = 401850, XrefRangeStart = 401816, XrefRangeEnd = 401849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentValidator CompileComplexContent(XmlSchemaComplexType complexType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileComplexContent_Private_ContentValidator_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr3) : null;
			}
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x00099C04 File Offset: 0x00097E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401850, XrefRangeEnd = 401875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_BuildParticleContentModel_Private_Void_ParticleContentValidator_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x00099C58 File Offset: 0x00097E58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 401888, RefRangeEnd = 401890, XrefRangeStart = 401875, XrefRangeEnd = 401888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileParticleElements_Private_Void_XmlSchemaComplexType_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x00099CAC File Offset: 0x00097EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401890, XrefRangeEnd = 401896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileCompexTypeElements(XmlSchemaComplexType complexType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_CompileCompexTypeElements_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x00099CF0 File Offset: 0x00097EF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 401903, RefRangeEnd = 401907, XrefRangeStart = 401896, XrefRangeEnd = 401903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_GetSimpleType_Private_XmlSchemaSimpleType_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x00099D40 File Offset: 0x00097F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401907, XrefRangeEnd = 401910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaComplexType GetComplexType(XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_GetComplexType_Private_XmlSchemaComplexType_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr3) : null;
			}
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x00099D90 File Offset: 0x00097F90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 401919, RefRangeEnd = 401921, XrefRangeStart = 401910, XrefRangeEnd = 401919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaType GetAnySchemaType(XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionCompiler.NativeMethodInfoPtr_GetAnySchemaType_Private_XmlSchemaType_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x0000CB04 File Offset: 0x0000AD04
		public SchemaCollectionCompiler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06001F2E RID: 7982 RVA: 0x00099DE0 File Offset: 0x00097FE0
		// (set) Token: 0x06001F2F RID: 7983 RVA: 0x0000CB0D File Offset: 0x0000AD0D
		public unsafe bool compileContentModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionCompiler.NativeFieldInfoPtr_compileContentModel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionCompiler.NativeFieldInfoPtr_compileContentModel)) = value;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06001F30 RID: 7984 RVA: 0x00099E08 File Offset: 0x00098008
		// (set) Token: 0x06001F31 RID: 7985 RVA: 0x0000CB28 File Offset: 0x0000AD28
		public unsafe XmlSchemaObjectTable examplars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionCompiler.NativeFieldInfoPtr_examplars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionCompiler.NativeFieldInfoPtr_examplars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06001F32 RID: 7986 RVA: 0x00099E38 File Offset: 0x00098038
		// (set) Token: 0x06001F33 RID: 7987 RVA: 0x0000CB47 File Offset: 0x0000AD47
		public unsafe Stack complexTypeStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionCompiler.NativeFieldInfoPtr_complexTypeStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionCompiler.NativeFieldInfoPtr_complexTypeStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06001F34 RID: 7988 RVA: 0x00099E68 File Offset: 0x00098068
		// (set) Token: 0x06001F35 RID: 7989 RVA: 0x0000CB66 File Offset: 0x0000AD66
		public unsafe XmlSchema schema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionCompiler.NativeFieldInfoPtr_schema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionCompiler.NativeFieldInfoPtr_schema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400178B RID: 6027
		private static readonly IntPtr NativeFieldInfoPtr_compileContentModel;

		// Token: 0x0400178C RID: 6028
		private static readonly IntPtr NativeFieldInfoPtr_examplars;

		// Token: 0x0400178D RID: 6029
		private static readonly IntPtr NativeFieldInfoPtr_complexTypeStack;

		// Token: 0x0400178E RID: 6030
		private static readonly IntPtr NativeFieldInfoPtr_schema;

		// Token: 0x0400178F RID: 6031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_ValidationEventHandler_0;

		// Token: 0x04001790 RID: 6032
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_SchemaInfo_Boolean_0;

		// Token: 0x04001791 RID: 6033
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Private_Void_0;

		// Token: 0x04001792 RID: 6034
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

		// Token: 0x04001793 RID: 6035
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Internal_Static_Void_XmlSchema_0;

		// Token: 0x04001794 RID: 6036
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Private_Void_0;

		// Token: 0x04001795 RID: 6037
		private static readonly IntPtr NativeMethodInfoPtr_Output_Private_Void_SchemaInfo_0;

		// Token: 0x04001796 RID: 6038
		private static readonly IntPtr NativeMethodInfoPtr_CleanupAttribute_Private_Static_Void_XmlSchemaAttribute_0;

		// Token: 0x04001797 RID: 6039
		private static readonly IntPtr NativeMethodInfoPtr_CleanupAttributeGroup_Private_Static_Void_XmlSchemaAttributeGroup_0;

		// Token: 0x04001798 RID: 6040
		private static readonly IntPtr NativeMethodInfoPtr_CleanupComplexType_Private_Static_Void_XmlSchemaComplexType_0;

		// Token: 0x04001799 RID: 6041
		private static readonly IntPtr NativeMethodInfoPtr_CleanupSimpleType_Private_Static_Void_XmlSchemaSimpleType_0;

		// Token: 0x0400179A RID: 6042
		private static readonly IntPtr NativeMethodInfoPtr_CleanupElement_Private_Static_Void_XmlSchemaElement_0;

		// Token: 0x0400179B RID: 6043
		private static readonly IntPtr NativeMethodInfoPtr_CleanupAttributes_Private_Static_Void_XmlSchemaObjectCollection_0;

		// Token: 0x0400179C RID: 6044
		private static readonly IntPtr NativeMethodInfoPtr_CleanupGroup_Private_Static_Void_XmlSchemaGroup_0;

		// Token: 0x0400179D RID: 6045
		private static readonly IntPtr NativeMethodInfoPtr_CleanupParticle_Private_Static_Void_XmlSchemaParticle_0;

		// Token: 0x0400179E RID: 6046
		private static readonly IntPtr NativeMethodInfoPtr_CompileSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroupV1Compat_0;

		// Token: 0x0400179F RID: 6047
		private static readonly IntPtr NativeMethodInfoPtr_CheckSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroup_0;

		// Token: 0x040017A0 RID: 6048
		private static readonly IntPtr NativeMethodInfoPtr_CompileGroup_Private_Void_XmlSchemaGroup_0;

		// Token: 0x040017A1 RID: 6049
		private static readonly IntPtr NativeMethodInfoPtr_CompileSimpleType_Private_Void_XmlSchemaSimpleType_0;

		// Token: 0x040017A2 RID: 6050
		private static readonly IntPtr NativeMethodInfoPtr_CompileBaseMemberTypes_Private_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaSimpleType_0;

		// Token: 0x040017A3 RID: 6051
		private static readonly IntPtr NativeMethodInfoPtr_CheckUnionType_Private_Void_XmlSchemaSimpleType_ArrayList_XmlSchemaSimpleType_0;

		// Token: 0x040017A4 RID: 6052
		private static readonly IntPtr NativeMethodInfoPtr_CompileComplexType_Private_Void_XmlSchemaComplexType_0;

		// Token: 0x040017A5 RID: 6053
		private static readonly IntPtr NativeMethodInfoPtr_CompileSimpleContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentExtension_0;

		// Token: 0x040017A6 RID: 6054
		private static readonly IntPtr NativeMethodInfoPtr_CompileSimpleContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentRestriction_0;

		// Token: 0x040017A7 RID: 6055
		private static readonly IntPtr NativeMethodInfoPtr_CompileComplexContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentExtension_0;

		// Token: 0x040017A8 RID: 6056
		private static readonly IntPtr NativeMethodInfoPtr_CompileComplexContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentRestriction_0;

		// Token: 0x040017A9 RID: 6057
		private static readonly IntPtr NativeMethodInfoPtr_CheckParticleDerivation_Private_Void_XmlSchemaComplexType_0;

		// Token: 0x040017AA RID: 6058
		private static readonly IntPtr NativeMethodInfoPtr_CompileContentTypeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_Boolean_0;

		// Token: 0x040017AB RID: 6059
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_Boolean_Boolean_0;

		// Token: 0x040017AC RID: 6060
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizeElement_Private_XmlSchemaParticle_XmlSchemaElement_Boolean_0;

		// Token: 0x040017AD RID: 6061
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizeGroupRef_Private_XmlSchemaParticle_XmlSchemaGroupRef_Boolean_Boolean_0;

		// Token: 0x040017AE RID: 6062
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizeAll_Private_XmlSchemaParticle_XmlSchemaAll_Boolean_Boolean_0;

		// Token: 0x040017AF RID: 6063
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizeChoice_Private_XmlSchemaParticle_XmlSchemaChoice_Boolean_Boolean_0;

		// Token: 0x040017B0 RID: 6064
		private static readonly IntPtr NativeMethodInfoPtr_CannonicalizeSequence_Private_XmlSchemaParticle_XmlSchemaSequence_Boolean_Boolean_0;

		// Token: 0x040017B1 RID: 6065
		private static readonly IntPtr NativeMethodInfoPtr_IsValidRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0;

		// Token: 0x040017B2 RID: 6066
		private static readonly IntPtr NativeMethodInfoPtr_IsElementFromElement_Private_Boolean_XmlSchemaElement_XmlSchemaElement_0;

		// Token: 0x040017B3 RID: 6067
		private static readonly IntPtr NativeMethodInfoPtr_IsElementFromAny_Private_Boolean_XmlSchemaElement_XmlSchemaAny_0;

		// Token: 0x040017B4 RID: 6068
		private static readonly IntPtr NativeMethodInfoPtr_IsAnyFromAny_Private_Boolean_XmlSchemaAny_XmlSchemaAny_0;

		// Token: 0x040017B5 RID: 6069
		private static readonly IntPtr NativeMethodInfoPtr_IsGroupBaseFromAny_Private_Boolean_XmlSchemaGroupBase_XmlSchemaAny_0;

		// Token: 0x040017B6 RID: 6070
		private static readonly IntPtr NativeMethodInfoPtr_IsElementFromGroupBase_Private_Boolean_XmlSchemaElement_XmlSchemaGroupBase_Boolean_0;

		// Token: 0x040017B7 RID: 6071
		private static readonly IntPtr NativeMethodInfoPtr_IsGroupBaseFromGroupBase_Private_Boolean_XmlSchemaGroupBase_XmlSchemaGroupBase_Boolean_0;

		// Token: 0x040017B8 RID: 6072
		private static readonly IntPtr NativeMethodInfoPtr_IsSequenceFromAll_Private_Boolean_XmlSchemaSequence_XmlSchemaAll_0;

		// Token: 0x040017B9 RID: 6073
		private static readonly IntPtr NativeMethodInfoPtr_IsSequenceFromChoice_Private_Boolean_XmlSchemaSequence_XmlSchemaChoice_0;

		// Token: 0x040017BA RID: 6074
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSequenceRange_Private_Void_XmlSchemaSequence_byref_Decimal_byref_Decimal_0;

		// Token: 0x040017BB RID: 6075
		private static readonly IntPtr NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0;

		// Token: 0x040017BC RID: 6076
		private static readonly IntPtr NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_Decimal_Decimal_Decimal_Decimal_0;

		// Token: 0x040017BD RID: 6077
		private static readonly IntPtr NativeMethodInfoPtr_GetMappingParticle_Private_Int32_XmlSchemaParticle_XmlSchemaObjectCollection_0;

		// Token: 0x040017BE RID: 6078
		private static readonly IntPtr NativeMethodInfoPtr_IsParticleEmptiable_Private_Boolean_XmlSchemaParticle_0;

		// Token: 0x040017BF RID: 6079
		private static readonly IntPtr NativeMethodInfoPtr_CalculateEffectiveTotalRange_Private_Void_XmlSchemaParticle_byref_Decimal_byref_Decimal_0;

		// Token: 0x040017C0 RID: 6080
		private static readonly IntPtr NativeMethodInfoPtr_PushComplexType_Private_Void_XmlSchemaComplexType_0;

		// Token: 0x040017C1 RID: 6081
		private static readonly IntPtr NativeMethodInfoPtr_GetSchemaContentType_Private_XmlSchemaContentType_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaParticle_0;

		// Token: 0x040017C2 RID: 6082
		private static readonly IntPtr NativeMethodInfoPtr_CompileAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0;

		// Token: 0x040017C3 RID: 6083
		private static readonly IntPtr NativeMethodInfoPtr_CompileLocalAttributes_Private_Void_XmlSchemaComplexType_XmlSchemaComplexType_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaDerivationMethod_0;

		// Token: 0x040017C4 RID: 6084
		private static readonly IntPtr NativeMethodInfoPtr_CompileAnyAttributeUnion_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0;

		// Token: 0x040017C5 RID: 6085
		private static readonly IntPtr NativeMethodInfoPtr_CompileAnyAttributeIntersection_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0;

		// Token: 0x040017C6 RID: 6086
		private static readonly IntPtr NativeMethodInfoPtr_CompileAttribute_Private_Void_XmlSchemaAttribute_0;

		// Token: 0x040017C7 RID: 6087
		private static readonly IntPtr NativeMethodInfoPtr_CompileIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0;

		// Token: 0x040017C8 RID: 6088
		private static readonly IntPtr NativeMethodInfoPtr_CompileElement_Private_Void_XmlSchemaElement_0;

		// Token: 0x040017C9 RID: 6089
		private static readonly IntPtr NativeMethodInfoPtr_CompileComplexContent_Private_ContentValidator_XmlSchemaComplexType_0;

		// Token: 0x040017CA RID: 6090
		private static readonly IntPtr NativeMethodInfoPtr_BuildParticleContentModel_Private_Void_ParticleContentValidator_XmlSchemaParticle_0;

		// Token: 0x040017CB RID: 6091
		private static readonly IntPtr NativeMethodInfoPtr_CompileParticleElements_Private_Void_XmlSchemaComplexType_XmlSchemaParticle_0;

		// Token: 0x040017CC RID: 6092
		private static readonly IntPtr NativeMethodInfoPtr_CompileCompexTypeElements_Private_Void_XmlSchemaComplexType_0;

		// Token: 0x040017CD RID: 6093
		private static readonly IntPtr NativeMethodInfoPtr_GetSimpleType_Private_XmlSchemaSimpleType_XmlQualifiedName_0;

		// Token: 0x040017CE RID: 6094
		private static readonly IntPtr NativeMethodInfoPtr_GetComplexType_Private_XmlSchemaComplexType_XmlQualifiedName_0;

		// Token: 0x040017CF RID: 6095
		private static readonly IntPtr NativeMethodInfoPtr_GetAnySchemaType_Private_XmlSchemaType_XmlQualifiedName_0;
	}
}
