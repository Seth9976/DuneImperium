using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000199 RID: 409
	public class XmlSchemaAnnotation : XmlSchemaObject
	{
		// Token: 0x060023BA RID: 9146 RVA: 0x000A9FEC File Offset: 0x000A81EC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaAnnotation()
		{
			Il2CppClassPointerStore<XmlSchemaAnnotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaAnnotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaAnnotation>.NativeClassPtr);
			XmlSchemaAnnotation.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAnnotation>.NativeClassPtr, "id");
			XmlSchemaAnnotation.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAnnotation>.NativeClassPtr, "items");
			XmlSchemaAnnotation.NativeFieldInfoPtr_moreAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAnnotation>.NativeClassPtr, "moreAttributes");
			XmlSchemaAnnotation.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnnotation>.NativeClassPtr, 100668486);
			XmlSchemaAnnotation.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnnotation>.NativeClassPtr, 100668487);
			XmlSchemaAnnotation.NativeMethodInfoPtr_get_Items_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnnotation>.NativeClassPtr, 100668488);
			XmlSchemaAnnotation.NativeMethodInfoPtr_get_IdAttribute_Internal_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnnotation>.NativeClassPtr, 100668489);
			XmlSchemaAnnotation.NativeMethodInfoPtr_set_IdAttribute_Internal_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnnotation>.NativeClassPtr, 100668490);
			XmlSchemaAnnotation.NativeMethodInfoPtr_SetUnhandledAttributes_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnnotation>.NativeClassPtr, 100668491);
			XmlSchemaAnnotation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnnotation>.NativeClassPtr, 100668492);
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x060023BB RID: 9147 RVA: 0x000AA0E4 File Offset: 0x000A82E4
		// (set) Token: 0x060023BC RID: 9148 RVA: 0x000AA11C File Offset: 0x000A831C
		public unsafe string Id
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnnotation.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnnotation.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x000AA160 File Offset: 0x000A8360
		public unsafe XmlSchemaObjectCollection Items
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnnotation.NativeMethodInfoPtr_get_Items_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x060023BE RID: 9150 RVA: 0x000AA1A0 File Offset: 0x000A83A0
		// (set) Token: 0x060023BF RID: 9151 RVA: 0x000AA1E4 File Offset: 0x000A83E4
		public unsafe override string IdAttribute
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAnnotation.NativeMethodInfoPtr_get_IdAttribute_Internal_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAnnotation.NativeMethodInfoPtr_set_IdAttribute_Internal_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x000AA234 File Offset: 0x000A8434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetUnhandledAttributes(Il2CppReferenceArray<XmlAttribute> moreAttributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(moreAttributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAnnotation.NativeMethodInfoPtr_SetUnhandledAttributes_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x000AA284 File Offset: 0x000A8484
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 410884, RefRangeEnd = 410885, XrefRangeStart = 410878, XrefRangeEnd = 410884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAnnotation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaAnnotation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnnotation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x0000F23A File Offset: 0x0000D43A
		public XmlSchemaAnnotation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x060023C3 RID: 9155 RVA: 0x000AA2C0 File Offset: 0x000A84C0
		// (set) Token: 0x060023C4 RID: 9156 RVA: 0x0000F243 File Offset: 0x0000D443
		public unsafe string id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnnotation.NativeFieldInfoPtr_id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnnotation.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x060023C5 RID: 9157 RVA: 0x000AA2E8 File Offset: 0x000A84E8
		// (set) Token: 0x060023C6 RID: 9158 RVA: 0x0000F262 File Offset: 0x0000D462
		public unsafe XmlSchemaObjectCollection items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnnotation.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnnotation.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x060023C7 RID: 9159 RVA: 0x000AA318 File Offset: 0x000A8518
		// (set) Token: 0x060023C8 RID: 9160 RVA: 0x0000F281 File Offset: 0x0000D481
		public unsafe Il2CppReferenceArray<XmlAttribute> moreAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnnotation.NativeFieldInfoPtr_moreAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlAttribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnnotation.NativeFieldInfoPtr_moreAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AFD RID: 6909
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04001AFE RID: 6910
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04001AFF RID: 6911
		private static readonly IntPtr NativeFieldInfoPtr_moreAttributes;

		// Token: 0x04001B00 RID: 6912
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

		// Token: 0x04001B01 RID: 6913
		private static readonly IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_String_0;

		// Token: 0x04001B02 RID: 6914
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001B03 RID: 6915
		private static readonly IntPtr NativeMethodInfoPtr_get_IdAttribute_Internal_Virtual_get_String_0;

		// Token: 0x04001B04 RID: 6916
		private static readonly IntPtr NativeMethodInfoPtr_set_IdAttribute_Internal_Virtual_set_Void_String_0;

		// Token: 0x04001B05 RID: 6917
		private static readonly IntPtr NativeMethodInfoPtr_SetUnhandledAttributes_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlAttribute_0;

		// Token: 0x04001B06 RID: 6918
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
