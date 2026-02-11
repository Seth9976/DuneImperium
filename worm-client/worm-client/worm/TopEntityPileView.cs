using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm
{
	// Token: 0x02000041 RID: 65
	public class TopEntityPileView : ContainerView
	{
		// Token: 0x060002CD RID: 717 RVA: 0x0002170C File Offset: 0x0001F90C
		// Note: this type is marked as 'beforefieldinit'.
		static TopEntityPileView()
		{
			Il2CppClassPointerStore<TopEntityPileView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "TopEntityPileView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TopEntityPileView>.NativeClassPtr);
			TopEntityPileView.NativeFieldInfoPtr_topEntityContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopEntityPileView>.NativeClassPtr, "topEntityContainer");
			TopEntityPileView.NativeFieldInfoPtr_cachedView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopEntityPileView>.NativeClassPtr, "cachedView");
			TopEntityPileView.NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopEntityPileView>.NativeClassPtr, 100663746);
			TopEntityPileView.NativeMethodInfoPtr_ContainerForViewAndSlot_Public_Virtual_Transform_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopEntityPileView>.NativeClassPtr, 100663747);
			TopEntityPileView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopEntityPileView>.NativeClassPtr, 100663748);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000217A0 File Offset: 0x0001F9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690692, XrefRangeEnd = 690710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LayoutViews()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TopEntityPileView.NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000217DC File Offset: 0x0001F9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690710, XrefRangeEnd = 690713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Transform ContainerForViewAndSlot(UnitView view, int slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TopEntityPileView.NativeMethodInfoPtr_ContainerForViewAndSlot_Public_Virtual_Transform_UnitView_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00021848 File Offset: 0x0001FA48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 690714, RefRangeEnd = 690716, XrefRangeStart = 690713, XrefRangeEnd = 690714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TopEntityPileView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TopEntityPileView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TopEntityPileView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000034B7 File Offset: 0x000016B7
		public TopEntityPileView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00021884 File Offset: 0x0001FA84
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x000034C0 File Offset: 0x000016C0
		public unsafe Transform topEntityContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TopEntityPileView.NativeFieldInfoPtr_topEntityContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TopEntityPileView.NativeFieldInfoPtr_topEntityContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x000218B4 File Offset: 0x0001FAB4
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x000034DF File Offset: 0x000016DF
		public unsafe UnitView cachedView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TopEntityPileView.NativeFieldInfoPtr_cachedView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TopEntityPileView.NativeFieldInfoPtr_cachedView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeFieldInfoPtr_topEntityContainer;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeFieldInfoPtr_cachedView;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_ContainerForViewAndSlot_Public_Virtual_Transform_UnitView_Int32_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
