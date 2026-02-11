using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.IO;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000184 RID: 388
	public sealed class SchemaCollectionPreprocessor : BaseProcessor
	{
		// Token: 0x06001F36 RID: 7990 RVA: 0x00099E98 File Offset: 0x00098098
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaCollectionPreprocessor()
		{
			Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaCollectionPreprocessor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr);
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_schema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "schema");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_targetNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "targetNamespace");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_buildinIncluded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "buildinIncluded");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_elementFormDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "elementFormDefault");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_attributeFormDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "attributeFormDefault");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_blockDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "blockDefault");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_finalDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "finalDefault");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_schemaLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "schemaLocations");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_referenceNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "referenceNamespaces");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_Xmlns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "Xmlns");
			SchemaCollectionPreprocessor.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, "xmlResolver");
			SchemaCollectionPreprocessor.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667998);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_String_Boolean_XmlSchemaCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100667999);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_Cleanup_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668000);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668001);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_LoadExternals_Private_Void_XmlSchema_XmlSchemaCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668002);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_BuildRefNamespaces_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668003);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_Preprocess_Private_Void_XmlSchema_String_Compositor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668004);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessRedefine_Private_Void_XmlSchemaRedefine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668005);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_CountGroupSelfReference_Private_Int32_XmlSchemaObjectCollection_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668006);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_CheckRefinedGroup_Private_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668007);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_CheckRefinedAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668008);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_CheckRefinedSimpleType_Private_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668009);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_CheckRefinedComplexType_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668010);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAttribute_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668011);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessLocalAttribute_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668012);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAttributeContent_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668013);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668014);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessElement_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668015);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessLocalElement_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668016);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessElementContent_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668017);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668018);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessSimpleType_Private_Void_XmlSchemaSimpleType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668019);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessComplexType_Private_Void_XmlSchemaComplexType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668020);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessGroup_Private_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668021);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessNotation_Private_Void_XmlSchemaNotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668022);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessParticle_Private_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668023);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAttributes_Private_Void_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668024);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_ValidateIdAttribute_Private_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668025);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_ValidateNameAttribute_Private_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668026);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_ValidateQNameAttribute_Private_Void_XmlSchemaObject_String_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668027);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_SetParent_Private_Void_XmlSchemaObject_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668028);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668029);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_ResolveSchemaLocationUri_Private_Uri_XmlSchema_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668030);
			SchemaCollectionPreprocessor.NativeMethodInfoPtr_GetSchemaEntity_Private_Stream_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr, 100668031);
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x0009A24C File Offset: 0x0009844C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401922, RefRangeEnd = 401923, XrefRangeStart = 401921, XrefRangeEnd = 401922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaCollectionPreprocessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaCollectionPreprocessor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x0009A2BC File Offset: 0x000984BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 401946, RefRangeEnd = 401947, XrefRangeStart = 401923, XrefRangeEnd = 401946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadExternals;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xsc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_String_Boolean_XmlSchemaCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x0009A33C File Offset: 0x0009853C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 401968, RefRangeEnd = 401970, XrefRangeStart = 401947, XrefRangeEnd = 401968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_Cleanup_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (set) Token: 0x06001F3A RID: 7994 RVA: 0x0009A380 File Offset: 0x00098580
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x0009A3C4 File Offset: 0x000985C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 402057, RefRangeEnd = 402060, XrefRangeStart = 401970, XrefRangeEnd = 402057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xsc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_LoadExternals_Private_Void_XmlSchema_XmlSchemaCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x0009A418 File Offset: 0x00098618
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 402074, RefRangeEnd = 402075, XrefRangeStart = 402060, XrefRangeEnd = 402074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildRefNamespaces(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_BuildRefNamespaces_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x0009A45C File Offset: 0x0009865C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 402353, RefRangeEnd = 402356, XrefRangeStart = 402075, XrefRangeEnd = 402353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Preprocess(XmlSchema schema, string targetNamespace, SchemaCollectionPreprocessor.Compositor compositor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compositor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_Preprocess_Private_Void_XmlSchema_String_Compositor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x0009A4C0 File Offset: 0x000986C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 402525, RefRangeEnd = 402526, XrefRangeStart = 402356, XrefRangeEnd = 402525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessRedefine(XmlSchemaRedefine redefine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(redefine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessRedefine_Private_Void_XmlSchemaRedefine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x0009A504 File Offset: 0x00098704
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 402552, RefRangeEnd = 402554, XrefRangeStart = 402526, XrefRangeEnd = 402552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_CountGroupSelfReference_Private_Int32_XmlSchemaObjectCollection_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x0009A564 File Offset: 0x00098764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 402558, RefRangeEnd = 402559, XrefRangeStart = 402554, XrefRangeEnd = 402558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRefinedGroup(XmlSchemaGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_CheckRefinedGroup_Private_Void_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x0009A5A8 File Offset: 0x000987A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 402571, RefRangeEnd = 402572, XrefRangeStart = 402559, XrefRangeEnd = 402571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_CheckRefinedAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x0009A5EC File Offset: 0x000987EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 402582, RefRangeEnd = 402583, XrefRangeStart = 402572, XrefRangeEnd = 402582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRefinedSimpleType(XmlSchemaSimpleType stype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_CheckRefinedSimpleType_Private_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x0009A630 File Offset: 0x00098830
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 402608, RefRangeEnd = 402609, XrefRangeStart = 402583, XrefRangeEnd = 402608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRefinedComplexType(XmlSchemaComplexType ctype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_CheckRefinedComplexType_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x0009A674 File Offset: 0x00098874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 402633, RefRangeEnd = 402634, XrefRangeStart = 402609, XrefRangeEnd = 402633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAttribute(XmlSchemaAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAttribute_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x0009A6B8 File Offset: 0x000988B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 402660, RefRangeEnd = 402661, XrefRangeStart = 402634, XrefRangeEnd = 402660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessLocalAttribute(XmlSchemaAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessLocalAttribute_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x0009A6FC File Offset: 0x000988FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 402694, RefRangeEnd = 402696, XrefRangeStart = 402661, XrefRangeEnd = 402694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAttributeContent(XmlSchemaAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAttributeContent_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x0009A740 File Offset: 0x00098940
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 402712, RefRangeEnd = 402714, XrefRangeStart = 402696, XrefRangeEnd = 402712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x0009A784 File Offset: 0x00098984
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 402752, RefRangeEnd = 402754, XrefRangeStart = 402714, XrefRangeEnd = 402752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessElement(XmlSchemaElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessElement_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x0009A7C8 File Offset: 0x000989C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 402807, RefRangeEnd = 402810, XrefRangeStart = 402754, XrefRangeEnd = 402807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessLocalElement(XmlSchemaElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessLocalElement_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x0009A80C File Offset: 0x00098A0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 402851, RefRangeEnd = 402853, XrefRangeStart = 402810, XrefRangeEnd = 402851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessElementContent(XmlSchemaElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessElementContent_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x0009A850 File Offset: 0x00098A50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 402895, RefRangeEnd = 402896, XrefRangeStart = 402853, XrefRangeEnd = 402895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constraint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x0009A894 File Offset: 0x00098A94
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 402987, RefRangeEnd = 402996, XrefRangeStart = 402896, XrefRangeEnd = 402987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessSimpleType_Private_Void_XmlSchemaSimpleType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x0009A8E4 File Offset: 0x00098AE4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 403121, RefRangeEnd = 403125, XrefRangeStart = 402996, XrefRangeEnd = 403121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessComplexType_Private_Void_XmlSchemaComplexType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x0009A934 File Offset: 0x00098B34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 403155, RefRangeEnd = 403158, XrefRangeStart = 403125, XrefRangeEnd = 403155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessGroup(XmlSchemaGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessGroup_Private_Void_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x0009A978 File Offset: 0x00098B78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 403190, RefRangeEnd = 403192, XrefRangeStart = 403158, XrefRangeEnd = 403190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessNotation(XmlSchemaNotation notation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessNotation_Private_Void_XmlSchemaNotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x0009A9BC File Offset: 0x00098BBC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 403302, RefRangeEnd = 403307, XrefRangeStart = 403192, XrefRangeEnd = 403302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessParticle(XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessParticle_Private_Void_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x0009AA00 File Offset: 0x00098C00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 403334, RefRangeEnd = 403338, XrefRangeStart = 403307, XrefRangeEnd = 403334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAttributes_Private_Void_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x0009AA68 File Offset: 0x00098C68
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 403349, RefRangeEnd = 403373, XrefRangeStart = 403338, XrefRangeEnd = 403349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateIdAttribute(XmlSchemaObject xso)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xso);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_ValidateIdAttribute_Private_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x0009AAAC File Offset: 0x00098CAC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 403403, RefRangeEnd = 403413, XrefRangeStart = 403373, XrefRangeEnd = 403403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateNameAttribute(XmlSchemaObject xso)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xso);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_ValidateNameAttribute_Private_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x0009AAF0 File Offset: 0x00098CF0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 403421, RefRangeEnd = 403435, XrefRangeStart = 403413, XrefRangeEnd = 403421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_ValidateQNameAttribute_Private_Void_XmlSchemaObject_String_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x0009AB58 File Offset: 0x00098D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_SetParent_Private_Void_XmlSchemaObject_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x0009ABAC File Offset: 0x00098DAC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 403442, RefRangeEnd = 403458, XrefRangeStart = 403435, XrefRangeEnd = 403442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreprocessAnnotation(XmlSchemaObject schemaObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x0009ABF0 File Offset: 0x00098DF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 403459, RefRangeEnd = 403460, XrefRangeStart = 403458, XrefRangeEnd = 403459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_ResolveSchemaLocationUri_Private_Uri_XmlSchema_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x0009AC54 File Offset: 0x00098E54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 403463, RefRangeEnd = 403464, XrefRangeStart = 403460, XrefRangeEnd = 403463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream GetSchemaEntity(Uri ruri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ruri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaCollectionPreprocessor.NativeMethodInfoPtr_GetSchemaEntity_Private_Stream_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x0000CB85 File Offset: 0x0000AD85
		public SchemaCollectionPreprocessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06001F5A RID: 8026 RVA: 0x0009ACA4 File Offset: 0x00098EA4
		// (set) Token: 0x06001F5B RID: 8027 RVA: 0x0000CB8E File Offset: 0x0000AD8E
		public unsafe XmlSchema schema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_schema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_schema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06001F5C RID: 8028 RVA: 0x0009ACD4 File Offset: 0x00098ED4
		// (set) Token: 0x06001F5D RID: 8029 RVA: 0x0000CBAD File Offset: 0x0000ADAD
		public unsafe string targetNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_targetNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_targetNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06001F5E RID: 8030 RVA: 0x0009ACFC File Offset: 0x00098EFC
		// (set) Token: 0x06001F5F RID: 8031 RVA: 0x0000CBCC File Offset: 0x0000ADCC
		public unsafe bool buildinIncluded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_buildinIncluded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_buildinIncluded)) = value;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06001F60 RID: 8032 RVA: 0x0009AD24 File Offset: 0x00098F24
		// (set) Token: 0x06001F61 RID: 8033 RVA: 0x0000CBE7 File Offset: 0x0000ADE7
		public unsafe XmlSchemaForm elementFormDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_elementFormDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_elementFormDefault)) = value;
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06001F62 RID: 8034 RVA: 0x0009AD4C File Offset: 0x00098F4C
		// (set) Token: 0x06001F63 RID: 8035 RVA: 0x0000CC02 File Offset: 0x0000AE02
		public unsafe XmlSchemaForm attributeFormDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_attributeFormDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_attributeFormDefault)) = value;
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x0009AD74 File Offset: 0x00098F74
		// (set) Token: 0x06001F65 RID: 8037 RVA: 0x0000CC1D File Offset: 0x0000AE1D
		public unsafe XmlSchemaDerivationMethod blockDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_blockDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_blockDefault)) = value;
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06001F66 RID: 8038 RVA: 0x0009AD9C File Offset: 0x00098F9C
		// (set) Token: 0x06001F67 RID: 8039 RVA: 0x0000CC38 File Offset: 0x0000AE38
		public unsafe XmlSchemaDerivationMethod finalDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_finalDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_finalDefault)) = value;
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x0009ADC4 File Offset: 0x00098FC4
		// (set) Token: 0x06001F69 RID: 8041 RVA: 0x0000CC53 File Offset: 0x0000AE53
		public unsafe Hashtable schemaLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_schemaLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_schemaLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x0009ADF4 File Offset: 0x00098FF4
		// (set) Token: 0x06001F6B RID: 8043 RVA: 0x0000CC72 File Offset: 0x0000AE72
		public unsafe Hashtable referenceNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_referenceNamespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_referenceNamespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x0009AE24 File Offset: 0x00099024
		// (set) Token: 0x06001F6D RID: 8045 RVA: 0x0000CC91 File Offset: 0x0000AE91
		public unsafe string Xmlns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_Xmlns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_Xmlns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06001F6E RID: 8046 RVA: 0x0009AE4C File Offset: 0x0009904C
		// (set) Token: 0x06001F6F RID: 8047 RVA: 0x0000CCB0 File Offset: 0x0000AEB0
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaCollectionPreprocessor.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017D0 RID: 6096
		private static readonly IntPtr NativeFieldInfoPtr_schema;

		// Token: 0x040017D1 RID: 6097
		private static readonly IntPtr NativeFieldInfoPtr_targetNamespace;

		// Token: 0x040017D2 RID: 6098
		private static readonly IntPtr NativeFieldInfoPtr_buildinIncluded;

		// Token: 0x040017D3 RID: 6099
		private static readonly IntPtr NativeFieldInfoPtr_elementFormDefault;

		// Token: 0x040017D4 RID: 6100
		private static readonly IntPtr NativeFieldInfoPtr_attributeFormDefault;

		// Token: 0x040017D5 RID: 6101
		private static readonly IntPtr NativeFieldInfoPtr_blockDefault;

		// Token: 0x040017D6 RID: 6102
		private static readonly IntPtr NativeFieldInfoPtr_finalDefault;

		// Token: 0x040017D7 RID: 6103
		private static readonly IntPtr NativeFieldInfoPtr_schemaLocations;

		// Token: 0x040017D8 RID: 6104
		private static readonly IntPtr NativeFieldInfoPtr_referenceNamespaces;

		// Token: 0x040017D9 RID: 6105
		private static readonly IntPtr NativeFieldInfoPtr_Xmlns;

		// Token: 0x040017DA RID: 6106
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x040017DB RID: 6107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_0;

		// Token: 0x040017DC RID: 6108
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_String_Boolean_XmlSchemaCollection_0;

		// Token: 0x040017DD RID: 6109
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_XmlSchema_0;

		// Token: 0x040017DE RID: 6110
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0;

		// Token: 0x040017DF RID: 6111
		private static readonly IntPtr NativeMethodInfoPtr_LoadExternals_Private_Void_XmlSchema_XmlSchemaCollection_0;

		// Token: 0x040017E0 RID: 6112
		private static readonly IntPtr NativeMethodInfoPtr_BuildRefNamespaces_Private_Void_XmlSchema_0;

		// Token: 0x040017E1 RID: 6113
		private static readonly IntPtr NativeMethodInfoPtr_Preprocess_Private_Void_XmlSchema_String_Compositor_0;

		// Token: 0x040017E2 RID: 6114
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessRedefine_Private_Void_XmlSchemaRedefine_0;

		// Token: 0x040017E3 RID: 6115
		private static readonly IntPtr NativeMethodInfoPtr_CountGroupSelfReference_Private_Int32_XmlSchemaObjectCollection_XmlQualifiedName_0;

		// Token: 0x040017E4 RID: 6116
		private static readonly IntPtr NativeMethodInfoPtr_CheckRefinedGroup_Private_Void_XmlSchemaGroup_0;

		// Token: 0x040017E5 RID: 6117
		private static readonly IntPtr NativeMethodInfoPtr_CheckRefinedAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0;

		// Token: 0x040017E6 RID: 6118
		private static readonly IntPtr NativeMethodInfoPtr_CheckRefinedSimpleType_Private_Void_XmlSchemaSimpleType_0;

		// Token: 0x040017E7 RID: 6119
		private static readonly IntPtr NativeMethodInfoPtr_CheckRefinedComplexType_Private_Void_XmlSchemaComplexType_0;

		// Token: 0x040017E8 RID: 6120
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAttribute_Private_Void_XmlSchemaAttribute_0;

		// Token: 0x040017E9 RID: 6121
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessLocalAttribute_Private_Void_XmlSchemaAttribute_0;

		// Token: 0x040017EA RID: 6122
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAttributeContent_Private_Void_XmlSchemaAttribute_0;

		// Token: 0x040017EB RID: 6123
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0;

		// Token: 0x040017EC RID: 6124
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessElement_Private_Void_XmlSchemaElement_0;

		// Token: 0x040017ED RID: 6125
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessLocalElement_Private_Void_XmlSchemaElement_0;

		// Token: 0x040017EE RID: 6126
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessElementContent_Private_Void_XmlSchemaElement_0;

		// Token: 0x040017EF RID: 6127
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0;

		// Token: 0x040017F0 RID: 6128
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessSimpleType_Private_Void_XmlSchemaSimpleType_Boolean_0;

		// Token: 0x040017F1 RID: 6129
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessComplexType_Private_Void_XmlSchemaComplexType_Boolean_0;

		// Token: 0x040017F2 RID: 6130
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessGroup_Private_Void_XmlSchemaGroup_0;

		// Token: 0x040017F3 RID: 6131
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessNotation_Private_Void_XmlSchemaNotation_0;

		// Token: 0x040017F4 RID: 6132
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessParticle_Private_Void_XmlSchemaParticle_0;

		// Token: 0x040017F5 RID: 6133
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAttributes_Private_Void_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaObject_0;

		// Token: 0x040017F6 RID: 6134
		private static readonly IntPtr NativeMethodInfoPtr_ValidateIdAttribute_Private_Void_XmlSchemaObject_0;

		// Token: 0x040017F7 RID: 6135
		private static readonly IntPtr NativeMethodInfoPtr_ValidateNameAttribute_Private_Void_XmlSchemaObject_0;

		// Token: 0x040017F8 RID: 6136
		private static readonly IntPtr NativeMethodInfoPtr_ValidateQNameAttribute_Private_Void_XmlSchemaObject_String_XmlQualifiedName_0;

		// Token: 0x040017F9 RID: 6137
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Private_Void_XmlSchemaObject_XmlSchemaObject_0;

		// Token: 0x040017FA RID: 6138
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaObject_0;

		// Token: 0x040017FB RID: 6139
		private static readonly IntPtr NativeMethodInfoPtr_ResolveSchemaLocationUri_Private_Uri_XmlSchema_String_0;

		// Token: 0x040017FC RID: 6140
		private static readonly IntPtr NativeMethodInfoPtr_GetSchemaEntity_Private_Stream_Uri_0;

		// Token: 0x0200025D RID: 605
		public enum Compositor
		{
			// Token: 0x0400266B RID: 9835
			Root,
			// Token: 0x0400266C RID: 9836
			Include,
			// Token: 0x0400266D RID: 9837
			Import
		}
	}
}
