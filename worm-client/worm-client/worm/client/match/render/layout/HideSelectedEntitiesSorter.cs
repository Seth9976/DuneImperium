using System;
using boardgames.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace worm.client.match.render.layout
{
	// Token: 0x020002A2 RID: 674
	public class HideSelectedEntitiesSorter : MonoBehaviour
	{
		// Token: 0x06001B5B RID: 7003 RVA: 0x0006C350 File Offset: 0x0006A550
		// Note: this type is marked as 'beforefieldinit'.
		static HideSelectedEntitiesSorter()
		{
			Il2CppClassPointerStore<HideSelectedEntitiesSorter>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.match.render.layout", "HideSelectedEntitiesSorter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideSelectedEntitiesSorter>.NativeClassPtr);
			HideSelectedEntitiesSorter.NativeFieldInfoPtr_kindsToObserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideSelectedEntitiesSorter>.NativeClassPtr, "kindsToObserve");
			HideSelectedEntitiesSorter.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideSelectedEntitiesSorter>.NativeClassPtr, "selectionResponder");
			HideSelectedEntitiesSorter.NativeMethodInfoPtr_SortViews_Public_Virtual_Final_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideSelectedEntitiesSorter>.NativeClassPtr, 100667286);
			HideSelectedEntitiesSorter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideSelectedEntitiesSorter>.NativeClassPtr, 100667287);
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0006C3D0 File Offset: 0x0006A5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724608, XrefRangeEnd = 724643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SortViews(List<UnitView> views)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideSelectedEntitiesSorter.NativeMethodInfoPtr_SortViews_Public_Virtual_Final_New_Void_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0006C414 File Offset: 0x0006A614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724643, XrefRangeEnd = 724651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HideSelectedEntitiesSorter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HideSelectedEntitiesSorter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideSelectedEntitiesSorter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0000FCF5 File Offset: 0x0000DEF5
		public HideSelectedEntitiesSorter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x0006C450 File Offset: 0x0006A650
		// (set) Token: 0x06001B60 RID: 7008 RVA: 0x0000FCFE File Offset: 0x0000DEFE
		public unsafe List<string> kindsToObserve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideSelectedEntitiesSorter.NativeFieldInfoPtr_kindsToObserve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideSelectedEntitiesSorter.NativeFieldInfoPtr_kindsToObserve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x0006C480 File Offset: 0x0006A680
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x0000FD1D File Offset: 0x0000DF1D
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideSelectedEntitiesSorter.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideSelectedEntitiesSorter.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeFieldInfoPtr_kindsToObserve;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeMethodInfoPtr_SortViews_Public_Virtual_Final_New_Void_List_1_UnitView_0;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
