using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000068 RID: 104
	public class XmlDocumentType : XmlLinkedNode
	{
		// Token: 0x06000CCF RID: 3279 RVA: 0x0004D7C8 File Offset: 0x0004B9C8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlDocumentType()
		{
			Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlDocumentType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr);
			XmlDocumentType.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, "name");
			XmlDocumentType.NativeFieldInfoPtr_publicId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, "publicId");
			XmlDocumentType.NativeFieldInfoPtr_systemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, "systemId");
			XmlDocumentType.NativeFieldInfoPtr_internalSubset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, "internalSubset");
			XmlDocumentType.NativeFieldInfoPtr_namespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, "namespaces");
			XmlDocumentType.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, "entities");
			XmlDocumentType.NativeFieldInfoPtr_notations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, "notations");
			XmlDocumentType.NativeFieldInfoPtr_schemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, "schemaInfo");
			XmlDocumentType.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_String_String_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100665384);
			XmlDocumentType.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100665385);
			XmlDocumentType.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100665386);
			XmlDocumentType.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100665387);
			XmlDocumentType.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100665388);
			XmlDocumentType.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100665389);
			XmlDocumentType.NativeMethodInfoPtr_get_Entities_Public_get_XmlNamedNodeMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100665390);
			XmlDocumentType.NativeMethodInfoPtr_get_Notations_Public_get_XmlNamedNodeMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100665391);
			XmlDocumentType.NativeMethodInfoPtr_get_PublicId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100665392);
			XmlDocumentType.NativeMethodInfoPtr_get_SystemId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100665393);
			XmlDocumentType.NativeMethodInfoPtr_get_InternalSubset_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100665394);
			XmlDocumentType.NativeMethodInfoPtr_get_ParseWithNamespaces_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100665395);
			XmlDocumentType.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100665396);
			XmlDocumentType.NativeMethodInfoPtr_WriteContentTo_Public_Virtual_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100665397);
			XmlDocumentType.NativeMethodInfoPtr_get_DtdSchemaInfo_Internal_get_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100665398);
			XmlDocumentType.NativeMethodInfoPtr_set_DtdSchemaInfo_Internal_set_Void_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100665399);
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x0004D9D8 File Offset: 0x0004BBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374359, XrefRangeEnd = 374371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDocumentType(string name, string publicId, string systemId, string internalSubset, XmlDocument doc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentType.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_String_String_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x0004DA70 File Offset: 0x0004BC70
		public unsafe override string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentType.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x0004DAB4 File Offset: 0x0004BCB4
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentType.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x0004DAF8 File Offset: 0x0004BCF8
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentType.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0004DB40 File Offset: 0x0004BD40
		[CallerCount(0)]
		public unsafe override XmlNode CloneNode(bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentType.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x0004DB98 File Offset: 0x0004BD98
		public unsafe override bool IsReadOnly
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentType.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x0004DBE0 File Offset: 0x0004BDE0
		public unsafe XmlNamedNodeMap Entities
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 374376, RefRangeEnd = 374380, XrefRangeStart = 374371, XrefRangeEnd = 374376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentType.NativeMethodInfoPtr_get_Entities_Public_get_XmlNamedNodeMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNamedNodeMap>(intPtr3) : null;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x0004DC20 File Offset: 0x0004BE20
		public unsafe XmlNamedNodeMap Notations
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374380, XrefRangeEnd = 374385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentType.NativeMethodInfoPtr_get_Notations_Public_get_XmlNamedNodeMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNamedNodeMap>(intPtr3) : null;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x0004DC60 File Offset: 0x0004BE60
		public unsafe string PublicId
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentType.NativeMethodInfoPtr_get_PublicId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x0004DC98 File Offset: 0x0004BE98
		public unsafe string SystemId
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentType.NativeMethodInfoPtr_get_SystemId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x0004DCD0 File Offset: 0x0004BED0
		public unsafe string InternalSubset
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentType.NativeMethodInfoPtr_get_InternalSubset_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x0004DD08 File Offset: 0x0004BF08
		public unsafe bool ParseWithNamespaces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentType.NativeMethodInfoPtr_get_ParseWithNamespaces_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x0004DD44 File Offset: 0x0004BF44
		[CallerCount(0)]
		public unsafe override void WriteTo(XmlWriter w)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(w);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentType.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x0004DD94 File Offset: 0x0004BF94
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteContentTo(XmlWriter w)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(w);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentType.NativeMethodInfoPtr_WriteContentTo_Public_Virtual_Void_XmlWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0004DDE4 File Offset: 0x0004BFE4
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x0004DE24 File Offset: 0x0004C024
		public unsafe SchemaInfo DtdSchemaInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentType.NativeMethodInfoPtr_get_DtdSchemaInfo_Internal_get_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr3) : null;
			}
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentType.NativeMethodInfoPtr_set_DtdSchemaInfo_Internal_set_Void_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x000064E0 File Offset: 0x000046E0
		public XmlDocumentType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x0004DE68 File Offset: 0x0004C068
		// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x000064E9 File Offset: 0x000046E9
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x0004DE90 File Offset: 0x0004C090
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x00006508 File Offset: 0x00004708
		public unsafe string publicId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_publicId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_publicId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0004DEB8 File Offset: 0x0004C0B8
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x00006527 File Offset: 0x00004727
		public unsafe string systemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_systemId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_systemId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x0004DEE0 File Offset: 0x0004C0E0
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x00006546 File Offset: 0x00004746
		public unsafe string internalSubset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_internalSubset);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_internalSubset), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x0004DF08 File Offset: 0x0004C108
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x00006565 File Offset: 0x00004765
		public unsafe bool namespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_namespaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_namespaces)) = value;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x0004DF30 File Offset: 0x0004C130
		// (set) Token: 0x06000CEC RID: 3308 RVA: 0x00006580 File Offset: 0x00004780
		public unsafe XmlNamedNodeMap entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamedNodeMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x0004DF60 File Offset: 0x0004C160
		// (set) Token: 0x06000CEE RID: 3310 RVA: 0x0000659F File Offset: 0x0000479F
		public unsafe XmlNamedNodeMap notations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_notations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamedNodeMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_notations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x0004DF90 File Offset: 0x0004C190
		// (set) Token: 0x06000CF0 RID: 3312 RVA: 0x000065BE File Offset: 0x000047BE
		public unsafe SchemaInfo schemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_schemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_schemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeFieldInfoPtr_publicId;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeFieldInfoPtr_systemId;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeFieldInfoPtr_internalSubset;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeFieldInfoPtr_namespaces;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeFieldInfoPtr_notations;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeFieldInfoPtr_schemaInfo;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_String_String_XmlDocument_0;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr_get_Entities_Public_get_XmlNamedNodeMap_0;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_get_Notations_Public_get_XmlNamedNodeMap_0;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicId_Public_get_String_0;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeMethodInfoPtr_get_SystemId_Public_get_String_0;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSubset_Public_get_String_0;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeMethodInfoPtr_get_ParseWithNamespaces_Internal_get_Boolean_0;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeMethodInfoPtr_WriteContentTo_Public_Virtual_Void_XmlWriter_0;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdSchemaInfo_Internal_get_SchemaInfo_0;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeMethodInfoPtr_set_DtdSchemaInfo_Internal_set_Void_SchemaInfo_0;
	}
}
