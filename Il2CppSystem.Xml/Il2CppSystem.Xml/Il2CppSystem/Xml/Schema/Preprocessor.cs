using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000180 RID: 384
	public sealed class Preprocessor : BaseProcessor
	{
		// Token: 0x06001E54 RID: 7764 RVA: 0x00095B60 File Offset: 0x00093D60
		// Note: this type is marked as 'beforefieldinit'.
		static Preprocessor()
		{
			Il2CppClassPointerStore<Preprocessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Preprocessor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr);
			Preprocessor.NativeFieldInfoPtr_Xmlns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "Xmlns");
			Preprocessor.NativeFieldInfoPtr_NsXsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "NsXsi");
			Preprocessor.NativeFieldInfoPtr_targetNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "targetNamespace");
			Preprocessor.NativeFieldInfoPtr_rootSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "rootSchema");
			Preprocessor.NativeFieldInfoPtr_currentSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "currentSchema");
			Preprocessor.NativeFieldInfoPtr_elementFormDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "elementFormDefault");
			Preprocessor.NativeFieldInfoPtr_attributeFormDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "attributeFormDefault");
			Preprocessor.NativeFieldInfoPtr_blockDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "blockDefault");
			Preprocessor.NativeFieldInfoPtr_finalDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "finalDefault");
			Preprocessor.NativeFieldInfoPtr_schemaLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "schemaLocations");
			Preprocessor.NativeFieldInfoPtr_chameleonSchemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "chameleonSchemas");
			Preprocessor.NativeFieldInfoPtr_referenceNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "referenceNamespaces");
			Preprocessor.NativeFieldInfoPtr_processedExternals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "processedExternals");
			Preprocessor.NativeFieldInfoPtr_lockList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "lockList");
			Preprocessor.NativeFieldInfoPtr_readerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "readerSettings");
			Preprocessor.NativeFieldInfoPtr_rootSchemaForRedefine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "rootSchemaForRedefine");
			Preprocessor.NativeFieldInfoPtr_redefinedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "redefinedList");
			Preprocessor.NativeFieldInfoPtr_builtInSchemaForXmlNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "builtInSchemaForXmlNS");
			Preprocessor.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "xmlResolver");
			Preprocessor.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_XmlSchemaCompilationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667843);
			Preprocessor.NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667844);
			Preprocessor.NativeMethodInfoPtr_Cleanup_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667845);
			Preprocessor.NativeMethodInfoPtr_CleanupRedefine_Private_Void_XmlSchemaExternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667846);
			Preprocessor.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667847);
			Preprocessor.NativeMethodInfoPtr_set_ReaderSettings_Internal_set_Void_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667848);
			Preprocessor.NativeMethodInfoPtr_set_SchemaLocations_Internal_set_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667849);
			Preprocessor.NativeMethodInfoPtr_set_ChameleonSchemas_Internal_set_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667850);
			Preprocessor.NativeMethodInfoPtr_get_RootSchema_Internal_get_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667851);
			Preprocessor.NativeMethodInfoPtr_BuildSchemaList_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667852);
			Preprocessor.NativeMethodInfoPtr_LoadExternals_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667853);
			Preprocessor.NativeMethodInfoPtr_GetBuildInSchema_Internal_Static_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667854);
			Preprocessor.NativeMethodInfoPtr_BuildRefNamespaces_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667855);
			Preprocessor.NativeMethodInfoPtr_ParseUri_Private_Void_String_String_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667856);
			Preprocessor.NativeMethodInfoPtr_Preprocess_Private_Void_XmlSchema_String_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667857);
			Preprocessor.NativeMethodInfoPtr_CopyIncludedComponents_Private_Void_XmlSchema_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667858);
			Preprocessor.NativeMethodInfoPtr_PreprocessRedefine_Private_Void_RedefineEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667859);
			Preprocessor.NativeMethodInfoPtr_GetIncludedSet_Private_Void_XmlSchema_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667860);
			Preprocessor.NativeMethodInfoPtr_GetParentSchema_Internal_Static_XmlSchema_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667861);
			Preprocessor.NativeMethodInfoPtr_SetSchemaDefaults_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667862);
			Preprocessor.NativeMethodInfoPtr_CountGroupSelfReference_Private_Int32_XmlSchemaObjectCollection_XmlQualifiedName_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667863);
			Preprocessor.NativeMethodInfoPtr_CheckRefinedGroup_Private_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667864);
			Preprocessor.NativeMethodInfoPtr_CheckRefinedAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667865);
			Preprocessor.NativeMethodInfoPtr_CheckRefinedSimpleType_Private_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667866);
			Preprocessor.NativeMethodInfoPtr_CheckRefinedComplexType_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667867);
			Preprocessor.NativeMethodInfoPtr_PreprocessAttribute_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667868);
			Preprocessor.NativeMethodInfoPtr_PreprocessLocalAttribute_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667869);
			Preprocessor.NativeMethodInfoPtr_PreprocessAttributeContent_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667870);
			Preprocessor.NativeMethodInfoPtr_PreprocessAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667871);
			Preprocessor.NativeMethodInfoPtr_PreprocessElement_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667872);
			Preprocessor.NativeMethodInfoPtr_PreprocessLocalElement_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667873);
			Preprocessor.NativeMethodInfoPtr_PreprocessElementContent_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667874);
			Preprocessor.NativeMethodInfoPtr_PreprocessIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667875);
			Preprocessor.NativeMethodInfoPtr_PreprocessSimpleType_Private_Void_XmlSchemaSimpleType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667876);
			Preprocessor.NativeMethodInfoPtr_PreprocessComplexType_Private_Void_XmlSchemaComplexType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667877);
			Preprocessor.NativeMethodInfoPtr_PreprocessGroup_Private_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667878);
			Preprocessor.NativeMethodInfoPtr_PreprocessNotation_Private_Void_XmlSchemaNotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667879);
			Preprocessor.NativeMethodInfoPtr_PreprocessParticle_Private_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667880);
			Preprocessor.NativeMethodInfoPtr_PreprocessAttributes_Private_Void_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667881);
			Preprocessor.NativeMethodInfoPtr_ValidateIdAttribute_Private_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667882);
			Preprocessor.NativeMethodInfoPtr_ValidateNameAttribute_Private_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667883);
			Preprocessor.NativeMethodInfoPtr_ValidateQNameAttribute_Private_Void_XmlSchemaObject_String_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667884);
			Preprocessor.NativeMethodInfoPtr_ResolveSchemaLocationUri_Private_Uri_XmlSchema_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667885);
			Preprocessor.NativeMethodInfoPtr_GetSchemaEntity_Private_Object_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667886);
			Preprocessor.NativeMethodInfoPtr_GetChameleonSchema_Private_XmlSchema_String_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667887);
			Preprocessor.NativeMethodInfoPtr_SetParent_Private_Void_XmlSchemaObject_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667888);
			Preprocessor.NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667889);
			Preprocessor.NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaAnnotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100667890);
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x000960CC File Offset: 0x000942CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397849, RefRangeEnd = 397850, XrefRangeStart = 397834, XrefRangeEnd = 397849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Preprocessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compilationSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_XmlSchemaCompilationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00096150 File Offset: 0x00094350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397891, RefRangeEnd = 397892, XrefRangeStart = 397850, XrefRangeEnd = 397891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadExternals;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x000961C0 File Offset: 0x000943C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397892, XrefRangeEnd = 397904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_Cleanup_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x00096204 File Offset: 0x00094404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397911, RefRangeEnd = 397912, XrefRangeStart = 397904, XrefRangeEnd = 397911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupRedefine(XmlSchemaExternal include)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(include);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_CleanupRedefine_Private_Void_XmlSchemaExternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (set) Token: 0x06001E59 RID: 7769 RVA: 0x00096248 File Offset: 0x00094448
		public unsafe XmlResolver XmlResolver
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (set) Token: 0x06001E5A RID: 7770 RVA: 0x0009628C File Offset: 0x0009448C
		public unsafe XmlReaderSettings ReaderSettings
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_set_ReaderSettings_Internal_set_Void_XmlReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (set) Token: 0x06001E5B RID: 7771 RVA: 0x000962D0 File Offset: 0x000944D0
		public unsafe Hashtable SchemaLocations
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_set_SchemaLocations_Internal_set_Void_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (set) Token: 0x06001E5C RID: 7772 RVA: 0x00096314 File Offset: 0x00094514
		public unsafe Hashtable ChameleonSchemas
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_set_ChameleonSchemas_Internal_set_Void_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06001E5D RID: 7773 RVA: 0x00096358 File Offset: 0x00094558
		public unsafe XmlSchema RootSchema
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_get_RootSchema_Internal_get_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
			}
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x00096398 File Offset: 0x00094598
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 397924, RefRangeEnd = 397926, XrefRangeStart = 397912, XrefRangeEnd = 397924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildSchemaList(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_BuildSchemaList_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x000963DC File Offset: 0x000945DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 398039, RefRangeEnd = 398042, XrefRangeStart = 397926, XrefRangeEnd = 398039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadExternals(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_LoadExternals_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x00096420 File Offset: 0x00094620
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 398174, RefRangeEnd = 398181, XrefRangeStart = 398042, XrefRangeEnd = 398174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchema GetBuildInSchema()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_GetBuildInSchema_Internal_Static_XmlSchema_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x00096454 File Offset: 0x00094654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 398193, RefRangeEnd = 398194, XrefRangeStart = 398181, XrefRangeEnd = 398193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildRefNamespaces(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_BuildRefNamespaces_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x00096498 File Offset: 0x00094698
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 398203, RefRangeEnd = 398207, XrefRangeStart = 398194, XrefRangeEnd = 398203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceSchemaObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_ParseUri_Private_Void_String_String_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x00096500 File Offset: 0x00094700
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 398427, RefRangeEnd = 398430, XrefRangeStart = 398207, XrefRangeEnd = 398427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(imports);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_Preprocess_Private_Void_XmlSchema_String_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x00096568 File Offset: 0x00094768
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 398561, RefRangeEnd = 398562, XrefRangeStart = 398430, XrefRangeEnd = 398561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(includedSchema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_CopyIncludedComponents_Private_Void_XmlSchema_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x000965BC File Offset: 0x000947BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 398705, RefRangeEnd = 398706, XrefRangeStart = 398562, XrefRangeEnd = 398705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessRedefine(RedefineEntry redefineEntry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(redefineEntry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessRedefine_Private_Void_RedefineEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x00096600 File Offset: 0x00094800
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 398711, RefRangeEnd = 398713, XrefRangeStart = 398706, XrefRangeEnd = 398711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetIncludedSet(XmlSchema schema, ArrayList includesList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(includesList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_GetIncludedSet_Private_Void_XmlSchema_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x00096654 File Offset: 0x00094854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 398716, RefRangeEnd = 398717, XrefRangeStart = 398713, XrefRangeEnd = 398716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentSchemaObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_GetParentSchema_Internal_Static_XmlSchema_XmlSchemaObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
			}
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x00096698 File Offset: 0x00094898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 398726, RefRangeEnd = 398728, XrefRangeStart = 398717, XrefRangeEnd = 398726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSchemaDefaults(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_SetSchemaDefaults_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x000966DC File Offset: 0x000948DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 398755, RefRangeEnd = 398757, XrefRangeStart = 398728, XrefRangeEnd = 398755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(redefined);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_CountGroupSelfReference_Private_Int32_XmlSchemaObjectCollection_XmlQualifiedName_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x00096750 File Offset: 0x00094950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 398761, RefRangeEnd = 398762, XrefRangeStart = 398757, XrefRangeEnd = 398761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRefinedGroup(XmlSchemaGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_CheckRefinedGroup_Private_Void_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x00096794 File Offset: 0x00094994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 398774, RefRangeEnd = 398775, XrefRangeStart = 398762, XrefRangeEnd = 398774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_CheckRefinedAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x000967D8 File Offset: 0x000949D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 398785, RefRangeEnd = 398786, XrefRangeStart = 398775, XrefRangeEnd = 398785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRefinedSimpleType(XmlSchemaSimpleType stype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_CheckRefinedSimpleType_Private_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x0009681C File Offset: 0x00094A1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 398811, RefRangeEnd = 398812, XrefRangeStart = 398786, XrefRangeEnd = 398811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRefinedComplexType(XmlSchemaComplexType ctype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_CheckRefinedComplexType_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00096860 File Offset: 0x00094A60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 398836, RefRangeEnd = 398837, XrefRangeStart = 398812, XrefRangeEnd = 398836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAttribute(XmlSchemaAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessAttribute_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x000968A4 File Offset: 0x00094AA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 398863, RefRangeEnd = 398864, XrefRangeStart = 398837, XrefRangeEnd = 398863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessLocalAttribute(XmlSchemaAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessLocalAttribute_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x000968E8 File Offset: 0x00094AE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 398895, RefRangeEnd = 398897, XrefRangeStart = 398864, XrefRangeEnd = 398895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAttributeContent(XmlSchemaAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessAttributeContent_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x0009692C File Offset: 0x00094B2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 398913, RefRangeEnd = 398915, XrefRangeStart = 398897, XrefRangeEnd = 398913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x00096970 File Offset: 0x00094B70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 398953, RefRangeEnd = 398955, XrefRangeStart = 398915, XrefRangeEnd = 398953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessElement(XmlSchemaElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessElement_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x000969B4 File Offset: 0x00094BB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 399008, RefRangeEnd = 399011, XrefRangeStart = 398955, XrefRangeEnd = 399008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessLocalElement(XmlSchemaElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessLocalElement_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x000969F8 File Offset: 0x00094BF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 399051, RefRangeEnd = 399053, XrefRangeStart = 399011, XrefRangeEnd = 399051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessElementContent(XmlSchemaElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessElementContent_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x00096A3C File Offset: 0x00094C3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399095, RefRangeEnd = 399096, XrefRangeStart = 399053, XrefRangeEnd = 399095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constraint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x00096A80 File Offset: 0x00094C80
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 399197, RefRangeEnd = 399207, XrefRangeStart = 399096, XrefRangeEnd = 399197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(simpleType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref local;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessSimpleType_Private_Void_XmlSchemaSimpleType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x00096AD0 File Offset: 0x00094CD0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 399332, RefRangeEnd = 399336, XrefRangeStart = 399207, XrefRangeEnd = 399332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessComplexType(XmlSchemaComplexType complexType, bool local)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref local;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessComplexType_Private_Void_XmlSchemaComplexType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00096B20 File Offset: 0x00094D20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 399366, RefRangeEnd = 399369, XrefRangeStart = 399336, XrefRangeEnd = 399366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessGroup(XmlSchemaGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessGroup_Private_Void_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x00096B64 File Offset: 0x00094D64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 399402, RefRangeEnd = 399404, XrefRangeStart = 399369, XrefRangeEnd = 399402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessNotation(XmlSchemaNotation notation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessNotation_Private_Void_XmlSchemaNotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x00096BA8 File Offset: 0x00094DA8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 399520, RefRangeEnd = 399525, XrefRangeStart = 399404, XrefRangeEnd = 399520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessParticle(XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessParticle_Private_Void_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x00096BEC File Offset: 0x00094DEC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 399555, RefRangeEnd = 399559, XrefRangeStart = 399525, XrefRangeEnd = 399555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(anyAttribute);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessAttributes_Private_Void_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x00096C54 File Offset: 0x00094E54
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 399566, RefRangeEnd = 399594, XrefRangeStart = 399559, XrefRangeEnd = 399566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateIdAttribute(XmlSchemaObject xso)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xso);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_ValidateIdAttribute_Private_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x00096C98 File Offset: 0x00094E98
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 399624, RefRangeEnd = 399634, XrefRangeStart = 399594, XrefRangeEnd = 399624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateNameAttribute(XmlSchemaObject xso)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xso);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_ValidateNameAttribute_Private_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x00096CDC File Offset: 0x00094EDC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 399647, RefRangeEnd = 399661, XrefRangeStart = 399634, XrefRangeEnd = 399647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xso);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_ValidateQNameAttribute_Private_Void_XmlSchemaObject_String_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x00096D44 File Offset: 0x00094F44
		[CallerCount(0)]
		public unsafe Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enclosingSchema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(location);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_ResolveSchemaLocationUri_Private_Uri_XmlSchema_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x00096DA8 File Offset: 0x00094FA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399661, RefRangeEnd = 399662, XrefRangeStart = 399661, XrefRangeEnd = 399661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetSchemaEntity(Uri ruri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ruri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_GetSchemaEntity_Private_Object_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x00096DF8 File Offset: 0x00094FF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 399672, RefRangeEnd = 399674, XrefRangeStart = 399662, XrefRangeEnd = 399672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_GetChameleonSchema_Private_XmlSchema_String_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x00096E5C File Offset: 0x0009505C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399674, XrefRangeEnd = 399676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParent(XmlSchemaObject child, XmlSchemaObject parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_SetParent_Private_Void_XmlSchemaObject_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x00096EB0 File Offset: 0x000950B0
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 399680, RefRangeEnd = 399697, XrefRangeStart = 399676, XrefRangeEnd = 399680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAnnotation(XmlSchemaObject schemaObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x00096EF4 File Offset: 0x000950F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 399701, RefRangeEnd = 399706, XrefRangeStart = 399697, XrefRangeEnd = 399701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAnnotation(XmlSchemaAnnotation annotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(annotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preprocessor.NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaAnnotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x0000C7C7 File Offset: 0x0000A9C7
		public Preprocessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x00096F38 File Offset: 0x00095138
		// (set) Token: 0x06001E87 RID: 7815 RVA: 0x0000C7D0 File Offset: 0x0000A9D0
		public unsafe string Xmlns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_Xmlns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_Xmlns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x00096F60 File Offset: 0x00095160
		// (set) Token: 0x06001E89 RID: 7817 RVA: 0x0000C7EF File Offset: 0x0000A9EF
		public unsafe string NsXsi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_NsXsi);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_NsXsi), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x00096F88 File Offset: 0x00095188
		// (set) Token: 0x06001E8B RID: 7819 RVA: 0x0000C80E File Offset: 0x0000AA0E
		public unsafe string targetNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_targetNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_targetNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x00096FB0 File Offset: 0x000951B0
		// (set) Token: 0x06001E8D RID: 7821 RVA: 0x0000C82D File Offset: 0x0000AA2D
		public unsafe XmlSchema rootSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_rootSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_rootSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x00096FE0 File Offset: 0x000951E0
		// (set) Token: 0x06001E8F RID: 7823 RVA: 0x0000C84C File Offset: 0x0000AA4C
		public unsafe XmlSchema currentSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_currentSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_currentSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x00097010 File Offset: 0x00095210
		// (set) Token: 0x06001E91 RID: 7825 RVA: 0x0000C86B File Offset: 0x0000AA6B
		public unsafe XmlSchemaForm elementFormDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_elementFormDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_elementFormDefault)) = value;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x00097038 File Offset: 0x00095238
		// (set) Token: 0x06001E93 RID: 7827 RVA: 0x0000C886 File Offset: 0x0000AA86
		public unsafe XmlSchemaForm attributeFormDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_attributeFormDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_attributeFormDefault)) = value;
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x00097060 File Offset: 0x00095260
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x0000C8A1 File Offset: 0x0000AAA1
		public unsafe XmlSchemaDerivationMethod blockDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_blockDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_blockDefault)) = value;
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x00097088 File Offset: 0x00095288
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x0000C8BC File Offset: 0x0000AABC
		public unsafe XmlSchemaDerivationMethod finalDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_finalDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_finalDefault)) = value;
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x000970B0 File Offset: 0x000952B0
		// (set) Token: 0x06001E99 RID: 7833 RVA: 0x0000C8D7 File Offset: 0x0000AAD7
		public unsafe Hashtable schemaLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_schemaLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_schemaLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06001E9A RID: 7834 RVA: 0x000970E0 File Offset: 0x000952E0
		// (set) Token: 0x06001E9B RID: 7835 RVA: 0x0000C8F6 File Offset: 0x0000AAF6
		public unsafe Hashtable chameleonSchemas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_chameleonSchemas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_chameleonSchemas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06001E9C RID: 7836 RVA: 0x00097110 File Offset: 0x00095310
		// (set) Token: 0x06001E9D RID: 7837 RVA: 0x0000C915 File Offset: 0x0000AB15
		public unsafe Hashtable referenceNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_referenceNamespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_referenceNamespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06001E9E RID: 7838 RVA: 0x00097140 File Offset: 0x00095340
		// (set) Token: 0x06001E9F RID: 7839 RVA: 0x0000C934 File Offset: 0x0000AB34
		public unsafe Hashtable processedExternals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_processedExternals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_processedExternals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x00097170 File Offset: 0x00095370
		// (set) Token: 0x06001EA1 RID: 7841 RVA: 0x0000C953 File Offset: 0x0000AB53
		public unsafe SortedList lockList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_lockList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_lockList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x000971A0 File Offset: 0x000953A0
		// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x0000C972 File Offset: 0x0000AB72
		public unsafe XmlReaderSettings readerSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_readerSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_readerSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x000971D0 File Offset: 0x000953D0
		// (set) Token: 0x06001EA5 RID: 7845 RVA: 0x0000C991 File Offset: 0x0000AB91
		public unsafe XmlSchema rootSchemaForRedefine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_rootSchemaForRedefine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_rootSchemaForRedefine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x00097200 File Offset: 0x00095400
		// (set) Token: 0x06001EA7 RID: 7847 RVA: 0x0000C9B0 File Offset: 0x0000ABB0
		public unsafe ArrayList redefinedList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_redefinedList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_redefinedList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06001EA8 RID: 7848 RVA: 0x00097230 File Offset: 0x00095430
		// (set) Token: 0x06001EA9 RID: 7849 RVA: 0x0000C9CF File Offset: 0x0000ABCF
		public unsafe static XmlSchema builtInSchemaForXmlNS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Preprocessor.NativeFieldInfoPtr_builtInSchemaForXmlNS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Preprocessor.NativeFieldInfoPtr_builtInSchemaForXmlNS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x00097258 File Offset: 0x00095458
		// (set) Token: 0x06001EAB RID: 7851 RVA: 0x0000C9E1 File Offset: 0x0000ABE1
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preprocessor.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001716 RID: 5910
		private static readonly IntPtr NativeFieldInfoPtr_Xmlns;

		// Token: 0x04001717 RID: 5911
		private static readonly IntPtr NativeFieldInfoPtr_NsXsi;

		// Token: 0x04001718 RID: 5912
		private static readonly IntPtr NativeFieldInfoPtr_targetNamespace;

		// Token: 0x04001719 RID: 5913
		private static readonly IntPtr NativeFieldInfoPtr_rootSchema;

		// Token: 0x0400171A RID: 5914
		private static readonly IntPtr NativeFieldInfoPtr_currentSchema;

		// Token: 0x0400171B RID: 5915
		private static readonly IntPtr NativeFieldInfoPtr_elementFormDefault;

		// Token: 0x0400171C RID: 5916
		private static readonly IntPtr NativeFieldInfoPtr_attributeFormDefault;

		// Token: 0x0400171D RID: 5917
		private static readonly IntPtr NativeFieldInfoPtr_blockDefault;

		// Token: 0x0400171E RID: 5918
		private static readonly IntPtr NativeFieldInfoPtr_finalDefault;

		// Token: 0x0400171F RID: 5919
		private static readonly IntPtr NativeFieldInfoPtr_schemaLocations;

		// Token: 0x04001720 RID: 5920
		private static readonly IntPtr NativeFieldInfoPtr_chameleonSchemas;

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeFieldInfoPtr_referenceNamespaces;

		// Token: 0x04001722 RID: 5922
		private static readonly IntPtr NativeFieldInfoPtr_processedExternals;

		// Token: 0x04001723 RID: 5923
		private static readonly IntPtr NativeFieldInfoPtr_lockList;

		// Token: 0x04001724 RID: 5924
		private static readonly IntPtr NativeFieldInfoPtr_readerSettings;

		// Token: 0x04001725 RID: 5925
		private static readonly IntPtr NativeFieldInfoPtr_rootSchemaForRedefine;

		// Token: 0x04001726 RID: 5926
		private static readonly IntPtr NativeFieldInfoPtr_redefinedList;

		// Token: 0x04001727 RID: 5927
		private static readonly IntPtr NativeFieldInfoPtr_builtInSchemaForXmlNS;

		// Token: 0x04001728 RID: 5928
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x04001729 RID: 5929
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_XmlSchemaCompilationSettings_0;

		// Token: 0x0400172A RID: 5930
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_String_Boolean_0;

		// Token: 0x0400172B RID: 5931
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_XmlSchema_0;

		// Token: 0x0400172C RID: 5932
		private static readonly IntPtr NativeMethodInfoPtr_CleanupRedefine_Private_Void_XmlSchemaExternal_0;

		// Token: 0x0400172D RID: 5933
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0;

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeMethodInfoPtr_set_ReaderSettings_Internal_set_Void_XmlReaderSettings_0;

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaLocations_Internal_set_Void_Hashtable_0;

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeMethodInfoPtr_set_ChameleonSchemas_Internal_set_Void_Hashtable_0;

		// Token: 0x04001731 RID: 5937
		private static readonly IntPtr NativeMethodInfoPtr_get_RootSchema_Internal_get_XmlSchema_0;

		// Token: 0x04001732 RID: 5938
		private static readonly IntPtr NativeMethodInfoPtr_BuildSchemaList_Private_Void_XmlSchema_0;

		// Token: 0x04001733 RID: 5939
		private static readonly IntPtr NativeMethodInfoPtr_LoadExternals_Private_Void_XmlSchema_0;

		// Token: 0x04001734 RID: 5940
		private static readonly IntPtr NativeMethodInfoPtr_GetBuildInSchema_Internal_Static_XmlSchema_0;

		// Token: 0x04001735 RID: 5941
		private static readonly IntPtr NativeMethodInfoPtr_BuildRefNamespaces_Private_Void_XmlSchema_0;

		// Token: 0x04001736 RID: 5942
		private static readonly IntPtr NativeMethodInfoPtr_ParseUri_Private_Void_String_String_XmlSchemaObject_0;

		// Token: 0x04001737 RID: 5943
		private static readonly IntPtr NativeMethodInfoPtr_Preprocess_Private_Void_XmlSchema_String_ArrayList_0;

		// Token: 0x04001738 RID: 5944
		private static readonly IntPtr NativeMethodInfoPtr_CopyIncludedComponents_Private_Void_XmlSchema_XmlSchema_0;

		// Token: 0x04001739 RID: 5945
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessRedefine_Private_Void_RedefineEntry_0;

		// Token: 0x0400173A RID: 5946
		private static readonly IntPtr NativeMethodInfoPtr_GetIncludedSet_Private_Void_XmlSchema_ArrayList_0;

		// Token: 0x0400173B RID: 5947
		private static readonly IntPtr NativeMethodInfoPtr_GetParentSchema_Internal_Static_XmlSchema_XmlSchemaObject_0;

		// Token: 0x0400173C RID: 5948
		private static readonly IntPtr NativeMethodInfoPtr_SetSchemaDefaults_Private_Void_XmlSchema_0;

		// Token: 0x0400173D RID: 5949
		private static readonly IntPtr NativeMethodInfoPtr_CountGroupSelfReference_Private_Int32_XmlSchemaObjectCollection_XmlQualifiedName_XmlSchemaGroup_0;

		// Token: 0x0400173E RID: 5950
		private static readonly IntPtr NativeMethodInfoPtr_CheckRefinedGroup_Private_Void_XmlSchemaGroup_0;

		// Token: 0x0400173F RID: 5951
		private static readonly IntPtr NativeMethodInfoPtr_CheckRefinedAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0;

		// Token: 0x04001740 RID: 5952
		private static readonly IntPtr NativeMethodInfoPtr_CheckRefinedSimpleType_Private_Void_XmlSchemaSimpleType_0;

		// Token: 0x04001741 RID: 5953
		private static readonly IntPtr NativeMethodInfoPtr_CheckRefinedComplexType_Private_Void_XmlSchemaComplexType_0;

		// Token: 0x04001742 RID: 5954
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAttribute_Private_Void_XmlSchemaAttribute_0;

		// Token: 0x04001743 RID: 5955
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessLocalAttribute_Private_Void_XmlSchemaAttribute_0;

		// Token: 0x04001744 RID: 5956
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAttributeContent_Private_Void_XmlSchemaAttribute_0;

		// Token: 0x04001745 RID: 5957
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0;

		// Token: 0x04001746 RID: 5958
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessElement_Private_Void_XmlSchemaElement_0;

		// Token: 0x04001747 RID: 5959
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessLocalElement_Private_Void_XmlSchemaElement_0;

		// Token: 0x04001748 RID: 5960
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessElementContent_Private_Void_XmlSchemaElement_0;

		// Token: 0x04001749 RID: 5961
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0;

		// Token: 0x0400174A RID: 5962
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessSimpleType_Private_Void_XmlSchemaSimpleType_Boolean_0;

		// Token: 0x0400174B RID: 5963
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessComplexType_Private_Void_XmlSchemaComplexType_Boolean_0;

		// Token: 0x0400174C RID: 5964
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessGroup_Private_Void_XmlSchemaGroup_0;

		// Token: 0x0400174D RID: 5965
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessNotation_Private_Void_XmlSchemaNotation_0;

		// Token: 0x0400174E RID: 5966
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessParticle_Private_Void_XmlSchemaParticle_0;

		// Token: 0x0400174F RID: 5967
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAttributes_Private_Void_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaObject_0;

		// Token: 0x04001750 RID: 5968
		private static readonly IntPtr NativeMethodInfoPtr_ValidateIdAttribute_Private_Void_XmlSchemaObject_0;

		// Token: 0x04001751 RID: 5969
		private static readonly IntPtr NativeMethodInfoPtr_ValidateNameAttribute_Private_Void_XmlSchemaObject_0;

		// Token: 0x04001752 RID: 5970
		private static readonly IntPtr NativeMethodInfoPtr_ValidateQNameAttribute_Private_Void_XmlSchemaObject_String_XmlQualifiedName_0;

		// Token: 0x04001753 RID: 5971
		private static readonly IntPtr NativeMethodInfoPtr_ResolveSchemaLocationUri_Private_Uri_XmlSchema_String_0;

		// Token: 0x04001754 RID: 5972
		private static readonly IntPtr NativeMethodInfoPtr_GetSchemaEntity_Private_Object_Uri_0;

		// Token: 0x04001755 RID: 5973
		private static readonly IntPtr NativeMethodInfoPtr_GetChameleonSchema_Private_XmlSchema_String_XmlSchema_0;

		// Token: 0x04001756 RID: 5974
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Private_Void_XmlSchemaObject_XmlSchemaObject_0;

		// Token: 0x04001757 RID: 5975
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaObject_0;

		// Token: 0x04001758 RID: 5976
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaAnnotation_0;
	}
}
