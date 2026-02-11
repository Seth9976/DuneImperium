using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001DC RID: 476
	public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent
	{
		// Token: 0x060027E8 RID: 10216 RVA: 0x000B9DAC File Offset: 0x000B7FAC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSimpleTypeList()
		{
			Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSimpleTypeList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr);
			XmlSchemaSimpleTypeList.NativeFieldInfoPtr_itemTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr, "itemTypeName");
			XmlSchemaSimpleTypeList.NativeFieldInfoPtr_itemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr, "itemType");
			XmlSchemaSimpleTypeList.NativeFieldInfoPtr_baseItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr, "baseItemType");
			XmlSchemaSimpleTypeList.NativeMethodInfoPtr_get_ItemTypeName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr, 100669070);
			XmlSchemaSimpleTypeList.NativeMethodInfoPtr_set_ItemTypeName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr, 100669071);
			XmlSchemaSimpleTypeList.NativeMethodInfoPtr_get_ItemType_Public_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr, 100669072);
			XmlSchemaSimpleTypeList.NativeMethodInfoPtr_set_ItemType_Public_set_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr, 100669073);
			XmlSchemaSimpleTypeList.NativeMethodInfoPtr_get_BaseItemType_Public_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr, 100669074);
			XmlSchemaSimpleTypeList.NativeMethodInfoPtr_set_BaseItemType_Public_set_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr, 100669075);
			XmlSchemaSimpleTypeList.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr, 100669076);
			XmlSchemaSimpleTypeList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr, 100669077);
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x060027E9 RID: 10217 RVA: 0x000B9EB8 File Offset: 0x000B80B8
		// (set) Token: 0x060027EA RID: 10218 RVA: 0x000B9EF8 File Offset: 0x000B80F8
		public unsafe XmlQualifiedName ItemTypeName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeList.NativeMethodInfoPtr_get_ItemTypeName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 414615, RefRangeEnd = 414616, XrefRangeStart = 414606, XrefRangeEnd = 414615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeList.NativeMethodInfoPtr_set_ItemTypeName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x060027EB RID: 10219 RVA: 0x000B9F3C File Offset: 0x000B813C
		// (set) Token: 0x060027EC RID: 10220 RVA: 0x000B9F7C File Offset: 0x000B817C
		public unsafe XmlSchemaSimpleType ItemType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeList.NativeMethodInfoPtr_get_ItemType_Public_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeList.NativeMethodInfoPtr_set_ItemType_Public_set_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x060027ED RID: 10221 RVA: 0x000B9FC0 File Offset: 0x000B81C0
		// (set) Token: 0x060027EE RID: 10222 RVA: 0x000BA000 File Offset: 0x000B8200
		public unsafe XmlSchemaSimpleType BaseItemType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeList.NativeMethodInfoPtr_get_BaseItemType_Public_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeList.NativeMethodInfoPtr_set_BaseItemType_Public_set_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x000BA044 File Offset: 0x000B8244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414616, XrefRangeEnd = 414628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlSchemaObject Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaSimpleTypeList.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x000BA090 File Offset: 0x000B8290
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 414634, RefRangeEnd = 414636, XrefRangeStart = 414628, XrefRangeEnd = 414634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSimpleTypeList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x00010E6D File Offset: 0x0000F06D
		public XmlSchemaSimpleTypeList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x060027F2 RID: 10226 RVA: 0x000BA0CC File Offset: 0x000B82CC
		// (set) Token: 0x060027F3 RID: 10227 RVA: 0x00010E76 File Offset: 0x0000F076
		public unsafe XmlQualifiedName itemTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeList.NativeFieldInfoPtr_itemTypeName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeList.NativeFieldInfoPtr_itemTypeName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x060027F4 RID: 10228 RVA: 0x000BA0FC File Offset: 0x000B82FC
		// (set) Token: 0x060027F5 RID: 10229 RVA: 0x00010E95 File Offset: 0x0000F095
		public unsafe XmlSchemaSimpleType itemType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeList.NativeFieldInfoPtr_itemType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeList.NativeFieldInfoPtr_itemType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x060027F6 RID: 10230 RVA: 0x000BA12C File Offset: 0x000B832C
		// (set) Token: 0x060027F7 RID: 10231 RVA: 0x00010EB4 File Offset: 0x0000F0B4
		public unsafe XmlSchemaSimpleType baseItemType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeList.NativeFieldInfoPtr_baseItemType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeList.NativeFieldInfoPtr_baseItemType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E15 RID: 7701
		private static readonly IntPtr NativeFieldInfoPtr_itemTypeName;

		// Token: 0x04001E16 RID: 7702
		private static readonly IntPtr NativeFieldInfoPtr_itemType;

		// Token: 0x04001E17 RID: 7703
		private static readonly IntPtr NativeFieldInfoPtr_baseItemType;

		// Token: 0x04001E18 RID: 7704
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemTypeName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001E19 RID: 7705
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemTypeName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001E1A RID: 7706
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_get_XmlSchemaSimpleType_0;

		// Token: 0x04001E1B RID: 7707
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemType_Public_set_Void_XmlSchemaSimpleType_0;

		// Token: 0x04001E1C RID: 7708
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseItemType_Public_get_XmlSchemaSimpleType_0;

		// Token: 0x04001E1D RID: 7709
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseItemType_Public_set_Void_XmlSchemaSimpleType_0;

		// Token: 0x04001E1E RID: 7710
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0;

		// Token: 0x04001E1F RID: 7711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
