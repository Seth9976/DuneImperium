using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace boardgames.moz
{
	// Token: 0x02000124 RID: 292
	public class TapMozPaginationContainer : MonoBehaviour
	{
		// Token: 0x06000D00 RID: 3328 RVA: 0x000468F8 File Offset: 0x00044AF8
		// Note: this type is marked as 'beforefieldinit'.
		static TapMozPaginationContainer()
		{
			Il2CppClassPointerStore<TapMozPaginationContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "TapMozPaginationContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TapMozPaginationContainer>.NativeClassPtr);
			TapMozPaginationContainer.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMozPaginationContainer>.NativeClassPtr, "container");
			TapMozPaginationContainer.NativeFieldInfoPtr_sorter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMozPaginationContainer>.NativeClassPtr, "sorter");
			TapMozPaginationContainer.NativeMethodInfoPtr_GetViews_Public_Virtual_Final_New_IReadOnlyList_1_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPaginationContainer>.NativeClassPtr, 100665182);
			TapMozPaginationContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPaginationContainer>.NativeClassPtr, 100665183);
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00046978 File Offset: 0x00044B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510388, XrefRangeEnd = 510406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IReadOnlyList<EntityView> GetViews()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPaginationContainer.NativeMethodInfoPtr_GetViews_Public_Virtual_Final_New_IReadOnlyList_1_EntityView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<EntityView>>(intPtr3) : null;
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x000469B8 File Offset: 0x00044BB8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TapMozPaginationContainer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TapMozPaginationContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPaginationContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x000084BD File Offset: 0x000066BD
		public TapMozPaginationContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x000469F4 File Offset: 0x00044BF4
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x000084C6 File Offset: 0x000066C6
		public unsafe ContainerView container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPaginationContainer.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPaginationContainer.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x00046A24 File Offset: 0x00044C24
		// (set) Token: 0x06000D07 RID: 3335 RVA: 0x000084E5 File Offset: 0x000066E5
		public unsafe IViewSorter sorter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPaginationContainer.NativeFieldInfoPtr_sorter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IViewSorter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPaginationContainer.NativeFieldInfoPtr_sorter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeFieldInfoPtr_sorter;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_GetViews_Public_Virtual_Final_New_IReadOnlyList_1_EntityView_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
