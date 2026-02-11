using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.data
{
	// Token: 0x020000A9 RID: 169
	public class VFXTagsPrefabLookupData : PrefabLookupData
	{
		// Token: 0x060009A5 RID: 2469 RVA: 0x00029980 File Offset: 0x00027B80
		// Note: this type is marked as 'beforefieldinit'.
		static VFXTagsPrefabLookupData()
		{
			Il2CppClassPointerStore<VFXTagsPrefabLookupData>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.match.data", "VFXTagsPrefabLookupData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXTagsPrefabLookupData>.NativeClassPtr);
			VFXTagsPrefabLookupData.NativeFieldInfoPtr_vfxTagsAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXTagsPrefabLookupData>.NativeClassPtr, "vfxTagsAttribute");
			VFXTagsPrefabLookupData.NativeFieldInfoPtr_flavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXTagsPrefabLookupData>.NativeClassPtr, "flavors");
			VFXTagsPrefabLookupData.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXTagsPrefabLookupData>.NativeClassPtr, "cachedVersion");
			VFXTagsPrefabLookupData.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXTagsPrefabLookupData>.NativeClassPtr, 100664691);
			VFXTagsPrefabLookupData.NativeMethodInfoPtr_get_Flavors_Public_Virtual_get_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXTagsPrefabLookupData>.NativeClassPtr, 100664692);
			VFXTagsPrefabLookupData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXTagsPrefabLookupData>.NativeClassPtr, 100664693);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00029A28 File Offset: 0x00027C28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1117644, RefRangeEnd = 1117646, XrefRangeStart = 1117635, XrefRangeEnd = 1117644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VFXTagsPrefabLookupData(IAttribute<List<string>> vfxTagsAttribute)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXTagsPrefabLookupData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vfxTagsAttribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXTagsPrefabLookupData.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x00029A74 File Offset: 0x00027C74
		public unsafe override HashSet<string> Flavors
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117646, XrefRangeEnd = 1117657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXTagsPrefabLookupData.NativeMethodInfoPtr_get_Flavors_Public_Virtual_get_HashSet_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x00029AC0 File Offset: 0x00027CC0
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117657, XrefRangeEnd = 1117661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXTagsPrefabLookupData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00006AAF File Offset: 0x00004CAF
		public VFXTagsPrefabLookupData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x00029B08 File Offset: 0x00027D08
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x00006AB8 File Offset: 0x00004CB8
		public unsafe IAttribute<List<string>> vfxTagsAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXTagsPrefabLookupData.NativeFieldInfoPtr_vfxTagsAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<List<string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXTagsPrefabLookupData.NativeFieldInfoPtr_vfxTagsAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x00029B38 File Offset: 0x00027D38
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x00006AD7 File Offset: 0x00004CD7
		public unsafe HashSet<string> flavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXTagsPrefabLookupData.NativeFieldInfoPtr_flavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXTagsPrefabLookupData.NativeFieldInfoPtr_flavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x00029B68 File Offset: 0x00027D68
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x00006AF6 File Offset: 0x00004CF6
		public unsafe ulong cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXTagsPrefabLookupData.NativeFieldInfoPtr_cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXTagsPrefabLookupData.NativeFieldInfoPtr_cachedVersion)) = value;
			}
		}

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeFieldInfoPtr_vfxTagsAttribute;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeFieldInfoPtr_flavors;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_List_1_String_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_get_Flavors_Public_Virtual_get_HashSet_1_String_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;
	}
}
