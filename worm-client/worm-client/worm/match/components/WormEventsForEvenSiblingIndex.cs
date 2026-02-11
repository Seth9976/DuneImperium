using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace worm.match.components
{
	// Token: 0x020001F0 RID: 496
	public class WormEventsForEvenSiblingIndex : MonoBehaviour
	{
		// Token: 0x060015F5 RID: 5621 RVA: 0x0005AD88 File Offset: 0x00058F88
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventsForEvenSiblingIndex()
		{
			Il2CppClassPointerStore<WormEventsForEvenSiblingIndex>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormEventsForEvenSiblingIndex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForEvenSiblingIndex>.NativeClassPtr);
			WormEventsForEvenSiblingIndex.NativeFieldInfoPtr_onEven = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForEvenSiblingIndex>.NativeClassPtr, "onEven");
			WormEventsForEvenSiblingIndex.NativeFieldInfoPtr_onOdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForEvenSiblingIndex>.NativeClassPtr, "onOdd");
			WormEventsForEvenSiblingIndex.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForEvenSiblingIndex>.NativeClassPtr, 100666326);
			WormEventsForEvenSiblingIndex.NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForEvenSiblingIndex>.NativeClassPtr, 100666327);
			WormEventsForEvenSiblingIndex.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForEvenSiblingIndex>.NativeClassPtr, 100666328);
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x0005AE1C File Offset: 0x0005901C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715977, XrefRangeEnd = 715982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForEvenSiblingIndex.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x0005AE50 File Offset: 0x00059050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForEvenSiblingIndex.NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x0005AE84 File Offset: 0x00059084
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventsForEvenSiblingIndex()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForEvenSiblingIndex>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForEvenSiblingIndex.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x0000D42F File Offset: 0x0000B62F
		public WormEventsForEvenSiblingIndex(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x0005AEC0 File Offset: 0x000590C0
		// (set) Token: 0x060015FB RID: 5627 RVA: 0x0000D438 File Offset: 0x0000B638
		public unsafe UnityEvent onEven
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForEvenSiblingIndex.NativeFieldInfoPtr_onEven);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForEvenSiblingIndex.NativeFieldInfoPtr_onEven), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x0005AEF0 File Offset: 0x000590F0
		// (set) Token: 0x060015FD RID: 5629 RVA: 0x0000D457 File Offset: 0x0000B657
		public unsafe UnityEvent onOdd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForEvenSiblingIndex.NativeFieldInfoPtr_onOdd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForEvenSiblingIndex.NativeFieldInfoPtr_onOdd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeFieldInfoPtr_onEven;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeFieldInfoPtr_onOdd;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
