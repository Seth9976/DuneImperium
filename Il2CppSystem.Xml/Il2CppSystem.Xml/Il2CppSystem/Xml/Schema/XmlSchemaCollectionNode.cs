using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001A2 RID: 418
	public sealed class XmlSchemaCollectionNode : Object
	{
		// Token: 0x06002485 RID: 9349 RVA: 0x000AD028 File Offset: 0x000AB228
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaCollectionNode()
		{
			Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaCollectionNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr);
			XmlSchemaCollectionNode.NativeFieldInfoPtr_namespaceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr, "namespaceUri");
			XmlSchemaCollectionNode.NativeFieldInfoPtr_schemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr, "schemaInfo");
			XmlSchemaCollectionNode.NativeFieldInfoPtr_schema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr, "schema");
			XmlSchemaCollectionNode.NativeMethodInfoPtr_set_NamespaceURI_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr, 100668591);
			XmlSchemaCollectionNode.NativeMethodInfoPtr_get_SchemaInfo_Internal_get_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr, 100668592);
			XmlSchemaCollectionNode.NativeMethodInfoPtr_set_SchemaInfo_Internal_set_Void_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr, 100668593);
			XmlSchemaCollectionNode.NativeMethodInfoPtr_get_Schema_Internal_get_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr, 100668594);
			XmlSchemaCollectionNode.NativeMethodInfoPtr_set_Schema_Internal_set_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr, 100668595);
			XmlSchemaCollectionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr, 100668596);
		}

		// Token: 0x17000C5F RID: 3167
		// (set) Token: 0x06002486 RID: 9350 RVA: 0x000AD10C File Offset: 0x000AB30C
		public unsafe string NamespaceURI
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollectionNode.NativeMethodInfoPtr_set_NamespaceURI_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06002487 RID: 9351 RVA: 0x000AD150 File Offset: 0x000AB350
		// (set) Token: 0x06002488 RID: 9352 RVA: 0x000AD190 File Offset: 0x000AB390
		public unsafe SchemaInfo SchemaInfo
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollectionNode.NativeMethodInfoPtr_get_SchemaInfo_Internal_get_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollectionNode.NativeMethodInfoPtr_set_SchemaInfo_Internal_set_Void_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06002489 RID: 9353 RVA: 0x000AD1D4 File Offset: 0x000AB3D4
		// (set) Token: 0x0600248A RID: 9354 RVA: 0x000AD214 File Offset: 0x000AB414
		public unsafe XmlSchema Schema
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollectionNode.NativeMethodInfoPtr_get_Schema_Internal_get_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollectionNode.NativeMethodInfoPtr_set_Schema_Internal_set_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x000AD258 File Offset: 0x000AB458
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaCollectionNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollectionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x0000F747 File Offset: 0x0000D947
		public XmlSchemaCollectionNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x0600248D RID: 9357 RVA: 0x000AD294 File Offset: 0x000AB494
		// (set) Token: 0x0600248E RID: 9358 RVA: 0x0000F750 File Offset: 0x0000D950
		public unsafe string namespaceUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollectionNode.NativeFieldInfoPtr_namespaceUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollectionNode.NativeFieldInfoPtr_namespaceUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x0600248F RID: 9359 RVA: 0x000AD2BC File Offset: 0x000AB4BC
		// (set) Token: 0x06002490 RID: 9360 RVA: 0x0000F76F File Offset: 0x0000D96F
		public unsafe SchemaInfo schemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollectionNode.NativeFieldInfoPtr_schemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollectionNode.NativeFieldInfoPtr_schemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06002491 RID: 9361 RVA: 0x000AD2EC File Offset: 0x000AB4EC
		// (set) Token: 0x06002492 RID: 9362 RVA: 0x0000F78E File Offset: 0x0000D98E
		public unsafe XmlSchema schema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollectionNode.NativeFieldInfoPtr_schema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollectionNode.NativeFieldInfoPtr_schema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B8E RID: 7054
		private static readonly IntPtr NativeFieldInfoPtr_namespaceUri;

		// Token: 0x04001B8F RID: 7055
		private static readonly IntPtr NativeFieldInfoPtr_schemaInfo;

		// Token: 0x04001B90 RID: 7056
		private static readonly IntPtr NativeFieldInfoPtr_schema;

		// Token: 0x04001B91 RID: 7057
		private static readonly IntPtr NativeMethodInfoPtr_set_NamespaceURI_Internal_set_Void_String_0;

		// Token: 0x04001B92 RID: 7058
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaInfo_Internal_get_SchemaInfo_0;

		// Token: 0x04001B93 RID: 7059
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaInfo_Internal_set_Void_SchemaInfo_0;

		// Token: 0x04001B94 RID: 7060
		private static readonly IntPtr NativeMethodInfoPtr_get_Schema_Internal_get_XmlSchema_0;

		// Token: 0x04001B95 RID: 7061
		private static readonly IntPtr NativeMethodInfoPtr_set_Schema_Internal_set_Void_XmlSchema_0;

		// Token: 0x04001B96 RID: 7062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
