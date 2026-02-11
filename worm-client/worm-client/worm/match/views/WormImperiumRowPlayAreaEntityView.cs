using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.views
{
	// Token: 0x020000AD RID: 173
	public class WormImperiumRowPlayAreaEntityView : ContainerView
	{
		// Token: 0x060006B0 RID: 1712 RVA: 0x0002D0FC File Offset: 0x0002B2FC
		// Note: this type is marked as 'beforefieldinit'.
		static WormImperiumRowPlayAreaEntityView()
		{
			Il2CppClassPointerStore<WormImperiumRowPlayAreaEntityView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.views", "WormImperiumRowPlayAreaEntityView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormImperiumRowPlayAreaEntityView>.NativeClassPtr);
			WormImperiumRowPlayAreaEntityView.NativeFieldInfoPtr_exhaustedPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumRowPlayAreaEntityView>.NativeClassPtr, "exhaustedPile");
			WormImperiumRowPlayAreaEntityView.NativeFieldInfoPtr_revealedPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumRowPlayAreaEntityView>.NativeClassPtr, "revealedPile");
			WormImperiumRowPlayAreaEntityView.NativeFieldInfoPtr_intriguePile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumRowPlayAreaEntityView>.NativeClassPtr, "intriguePile");
			WormImperiumRowPlayAreaEntityView.NativeMethodInfoPtr_ContainerForViewAndSlot_Public_Virtual_Transform_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumRowPlayAreaEntityView>.NativeClassPtr, 100664238);
			WormImperiumRowPlayAreaEntityView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumRowPlayAreaEntityView>.NativeClassPtr, 100664239);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0002D190 File Offset: 0x0002B390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696737, XrefRangeEnd = 696751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormImperiumRowPlayAreaEntityView.NativeMethodInfoPtr_ContainerForViewAndSlot_Public_Virtual_Transform_UnitView_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0002D1FC File Offset: 0x0002B3FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 690714, RefRangeEnd = 690716, XrefRangeStart = 690714, XrefRangeEnd = 690716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormImperiumRowPlayAreaEntityView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormImperiumRowPlayAreaEntityView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumRowPlayAreaEntityView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00005598 File Offset: 0x00003798
		public WormImperiumRowPlayAreaEntityView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x0002D238 File Offset: 0x0002B438
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x000055A1 File Offset: 0x000037A1
		public unsafe Transform exhaustedPile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowPlayAreaEntityView.NativeFieldInfoPtr_exhaustedPile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowPlayAreaEntityView.NativeFieldInfoPtr_exhaustedPile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x0002D268 File Offset: 0x0002B468
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x000055C0 File Offset: 0x000037C0
		public unsafe Transform revealedPile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowPlayAreaEntityView.NativeFieldInfoPtr_revealedPile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowPlayAreaEntityView.NativeFieldInfoPtr_revealedPile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x0002D298 File Offset: 0x0002B498
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x000055DF File Offset: 0x000037DF
		public unsafe Transform intriguePile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowPlayAreaEntityView.NativeFieldInfoPtr_intriguePile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowPlayAreaEntityView.NativeFieldInfoPtr_intriguePile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeFieldInfoPtr_exhaustedPile;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeFieldInfoPtr_revealedPile;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeFieldInfoPtr_intriguePile;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_ContainerForViewAndSlot_Public_Virtual_Transform_UnitView_Int32_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
