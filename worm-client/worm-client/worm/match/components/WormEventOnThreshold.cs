using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace worm.match.components
{
	// Token: 0x020001EE RID: 494
	public class WormEventOnThreshold : MonoBehaviour
	{
		// Token: 0x060015DA RID: 5594 RVA: 0x0005A8C0 File Offset: 0x00058AC0
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventOnThreshold()
		{
			Il2CppClassPointerStore<WormEventOnThreshold>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormEventOnThreshold");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventOnThreshold>.NativeClassPtr);
			WormEventOnThreshold.NativeFieldInfoPtr_threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventOnThreshold>.NativeClassPtr, "threshold");
			WormEventOnThreshold.NativeFieldInfoPtr_onActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventOnThreshold>.NativeClassPtr, "onActivate");
			WormEventOnThreshold.NativeFieldInfoPtr_onUnder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventOnThreshold>.NativeClassPtr, "onUnder");
			WormEventOnThreshold.NativeMethodInfoPtr_Event_Activate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventOnThreshold>.NativeClassPtr, 100666319);
			WormEventOnThreshold.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventOnThreshold>.NativeClassPtr, 100666320);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x0005A954 File Offset: 0x00058B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715915, XrefRangeEnd = 715918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Activate(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventOnThreshold.NativeMethodInfoPtr_Event_Activate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x0005A994 File Offset: 0x00058B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715918, XrefRangeEnd = 715928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventOnThreshold()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventOnThreshold>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventOnThreshold.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x0000D329 File Offset: 0x0000B529
		public WormEventOnThreshold(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060015DE RID: 5598 RVA: 0x0005A9D0 File Offset: 0x00058BD0
		// (set) Token: 0x060015DF RID: 5599 RVA: 0x0000D332 File Offset: 0x0000B532
		public unsafe float threshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventOnThreshold.NativeFieldInfoPtr_threshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventOnThreshold.NativeFieldInfoPtr_threshold)) = value;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x0005A9F8 File Offset: 0x00058BF8
		// (set) Token: 0x060015E1 RID: 5601 RVA: 0x0000D34D File Offset: 0x0000B54D
		public unsafe UnityEvent onActivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventOnThreshold.NativeFieldInfoPtr_onActivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventOnThreshold.NativeFieldInfoPtr_onActivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x0005AA28 File Offset: 0x00058C28
		// (set) Token: 0x060015E3 RID: 5603 RVA: 0x0000D36C File Offset: 0x0000B56C
		public unsafe UnityEvent onUnder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventOnThreshold.NativeFieldInfoPtr_onUnder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventOnThreshold.NativeFieldInfoPtr_onUnder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeFieldInfoPtr_threshold;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeFieldInfoPtr_onActivate;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeFieldInfoPtr_onUnder;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeMethodInfoPtr_Event_Activate_Public_Void_Single_0;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
