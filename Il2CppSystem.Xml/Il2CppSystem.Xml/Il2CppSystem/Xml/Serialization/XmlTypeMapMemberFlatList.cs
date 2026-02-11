using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000F6 RID: 246
	public class XmlTypeMapMemberFlatList : XmlTypeMapMemberExpandable
	{
		// Token: 0x0600168B RID: 5771 RVA: 0x0007756C File Offset: 0x0007576C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapMemberFlatList()
		{
			Il2CppClassPointerStore<XmlTypeMapMemberFlatList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapMemberFlatList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapMemberFlatList>.NativeClassPtr);
			XmlTypeMapMemberFlatList.NativeFieldInfoPtr__listMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberFlatList>.NativeClassPtr, "_listMap");
			XmlTypeMapMemberFlatList.NativeMethodInfoPtr_get_ListMap_Public_get_ListMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberFlatList>.NativeClassPtr, 100666872);
			XmlTypeMapMemberFlatList.NativeMethodInfoPtr_set_ListMap_Public_set_Void_ListMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberFlatList>.NativeClassPtr, 100666873);
			XmlTypeMapMemberFlatList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberFlatList>.NativeClassPtr, 100666874);
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x0600168C RID: 5772 RVA: 0x000775EC File Offset: 0x000757EC
		// (set) Token: 0x0600168D RID: 5773 RVA: 0x0007762C File Offset: 0x0007582C
		public unsafe ListMap ListMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberFlatList.NativeMethodInfoPtr_get_ListMap_Public_get_ListMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ListMap>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberFlatList.NativeMethodInfoPtr_set_ListMap_Public_set_Void_ListMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00077670 File Offset: 0x00075870
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 389801, RefRangeEnd = 389807, XrefRangeStart = 389801, XrefRangeEnd = 389807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMemberFlatList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapMemberFlatList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberFlatList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x000098E3 File Offset: 0x00007AE3
		public XmlTypeMapMemberFlatList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001690 RID: 5776 RVA: 0x000776AC File Offset: 0x000758AC
		// (set) Token: 0x06001691 RID: 5777 RVA: 0x000098EC File Offset: 0x00007AEC
		public unsafe ListMap _listMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberFlatList.NativeFieldInfoPtr__listMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberFlatList.NativeFieldInfoPtr__listMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeFieldInfoPtr__listMap;

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeMethodInfoPtr_get_ListMap_Public_get_ListMap_0;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeMethodInfoPtr_set_ListMap_Public_set_Void_ListMap_0;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
