using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using worm.canis.data.enums;

namespace worm.match.dataRenderers
{
	// Token: 0x02000135 RID: 309
	public class WormHagalSwordmasterCountdownRenderer : VersionedView<IAttribute<Nullable<int>>>
	{
		// Token: 0x06000DE5 RID: 3557 RVA: 0x000420B4 File Offset: 0x000402B4
		// Note: this type is marked as 'beforefieldinit'.
		static WormHagalSwordmasterCountdownRenderer()
		{
			Il2CppClassPointerStore<WormHagalSwordmasterCountdownRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormHagalSwordmasterCountdownRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHagalSwordmasterCountdownRenderer>.NativeClassPtr);
			WormHagalSwordmasterCountdownRenderer.NativeFieldInfoPtr_counter3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHagalSwordmasterCountdownRenderer>.NativeClassPtr, "counter3");
			WormHagalSwordmasterCountdownRenderer.NativeFieldInfoPtr_counter4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHagalSwordmasterCountdownRenderer>.NativeClassPtr, "counter4");
			WormHagalSwordmasterCountdownRenderer.NativeFieldInfoPtr_counter5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHagalSwordmasterCountdownRenderer>.NativeClassPtr, "counter5");
			WormHagalSwordmasterCountdownRenderer.NativeFieldInfoPtr_counters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHagalSwordmasterCountdownRenderer>.NativeClassPtr, "counters");
			WormHagalSwordmasterCountdownRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalSwordmasterCountdownRenderer>.NativeClassPtr, 100665172);
			WormHagalSwordmasterCountdownRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalSwordmasterCountdownRenderer>.NativeClassPtr, 100665173);
			WormHagalSwordmasterCountdownRenderer.NativeMethodInfoPtr_Event_Blue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalSwordmasterCountdownRenderer>.NativeClassPtr, 100665174);
			WormHagalSwordmasterCountdownRenderer.NativeMethodInfoPtr_Event_Green_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalSwordmasterCountdownRenderer>.NativeClassPtr, 100665175);
			WormHagalSwordmasterCountdownRenderer.NativeMethodInfoPtr_Event_Red_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalSwordmasterCountdownRenderer>.NativeClassPtr, 100665176);
			WormHagalSwordmasterCountdownRenderer.NativeMethodInfoPtr_Event_Yellow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalSwordmasterCountdownRenderer>.NativeClassPtr, 100665177);
			WormHagalSwordmasterCountdownRenderer.NativeMethodInfoPtr_UpdateColor_Private_Void_PieceColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalSwordmasterCountdownRenderer>.NativeClassPtr, 100665178);
			WormHagalSwordmasterCountdownRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalSwordmasterCountdownRenderer>.NativeClassPtr, 100665179);
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x000421D4 File Offset: 0x000403D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706015, XrefRangeEnd = 706041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHagalSwordmasterCountdownRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00042210 File Offset: 0x00040410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706041, XrefRangeEnd = 706069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHagalSwordmasterCountdownRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0004224C File Offset: 0x0004044C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706069, XrefRangeEnd = 706070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Blue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHagalSwordmasterCountdownRenderer.NativeMethodInfoPtr_Event_Blue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00042280 File Offset: 0x00040480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706070, XrefRangeEnd = 706071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Green()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHagalSwordmasterCountdownRenderer.NativeMethodInfoPtr_Event_Green_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x000422B4 File Offset: 0x000404B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706071, XrefRangeEnd = 706072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Red()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHagalSwordmasterCountdownRenderer.NativeMethodInfoPtr_Event_Red_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x000422E8 File Offset: 0x000404E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706072, XrefRangeEnd = 706073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Yellow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHagalSwordmasterCountdownRenderer.NativeMethodInfoPtr_Event_Yellow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0004231C File Offset: 0x0004051C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 706094, RefRangeEnd = 706098, XrefRangeStart = 706073, XrefRangeEnd = 706094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateColor(PieceColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHagalSwordmasterCountdownRenderer.NativeMethodInfoPtr_UpdateColor_Private_Void_PieceColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x0004235C File Offset: 0x0004055C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706098, XrefRangeEnd = 706101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormHagalSwordmasterCountdownRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHagalSwordmasterCountdownRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHagalSwordmasterCountdownRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00009536 File Offset: 0x00007736
		public WormHagalSwordmasterCountdownRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000DEF RID: 3567 RVA: 0x00042398 File Offset: 0x00040598
		// (set) Token: 0x06000DF0 RID: 3568 RVA: 0x0000953F File Offset: 0x0000773F
		public unsafe GameObject counter3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalSwordmasterCountdownRenderer.NativeFieldInfoPtr_counter3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalSwordmasterCountdownRenderer.NativeFieldInfoPtr_counter3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x000423C8 File Offset: 0x000405C8
		// (set) Token: 0x06000DF2 RID: 3570 RVA: 0x0000955E File Offset: 0x0000775E
		public unsafe GameObject counter4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalSwordmasterCountdownRenderer.NativeFieldInfoPtr_counter4);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalSwordmasterCountdownRenderer.NativeFieldInfoPtr_counter4), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x000423F8 File Offset: 0x000405F8
		// (set) Token: 0x06000DF4 RID: 3572 RVA: 0x0000957D File Offset: 0x0000777D
		public unsafe GameObject counter5
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalSwordmasterCountdownRenderer.NativeFieldInfoPtr_counter5);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalSwordmasterCountdownRenderer.NativeFieldInfoPtr_counter5), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x00042428 File Offset: 0x00040628
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x0000959C File Offset: 0x0000779C
		public unsafe Dictionary<int, GameObject> counters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalSwordmasterCountdownRenderer.NativeFieldInfoPtr_counters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalSwordmasterCountdownRenderer.NativeFieldInfoPtr_counters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeFieldInfoPtr_counter3;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeFieldInfoPtr_counter4;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeFieldInfoPtr_counter5;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeFieldInfoPtr_counters;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_Event_Blue_Public_Void_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr_Event_Green_Public_Void_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_Event_Red_Public_Void_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_Event_Yellow_Public_Void_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_UpdateColor_Private_Void_PieceColor_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
