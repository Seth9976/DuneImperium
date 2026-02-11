using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using localization;
using UnityEngine;

namespace worm.menus.components
{
	// Token: 0x0200009B RID: 155
	public class PullLocKeyFromOtherLocalizer : MonoBehaviour
	{
		// Token: 0x06000615 RID: 1557 RVA: 0x0002B3C0 File Offset: 0x000295C0
		// Note: this type is marked as 'beforefieldinit'.
		static PullLocKeyFromOtherLocalizer()
		{
			Il2CppClassPointerStore<PullLocKeyFromOtherLocalizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.components", "PullLocKeyFromOtherLocalizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PullLocKeyFromOtherLocalizer>.NativeClassPtr);
			PullLocKeyFromOtherLocalizer.NativeFieldInfoPtr_pullFromLocalizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PullLocKeyFromOtherLocalizer>.NativeClassPtr, "pullFromLocalizer");
			PullLocKeyFromOtherLocalizer.NativeFieldInfoPtr_pullToLocalizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PullLocKeyFromOtherLocalizer>.NativeClassPtr, "pullToLocalizer");
			PullLocKeyFromOtherLocalizer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PullLocKeyFromOtherLocalizer>.NativeClassPtr, 100664164);
			PullLocKeyFromOtherLocalizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PullLocKeyFromOtherLocalizer>.NativeClassPtr, 100664165);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0002B440 File Offset: 0x00029640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696013, XrefRangeEnd = 696021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PullLocKeyFromOtherLocalizer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0002B474 File Offset: 0x00029674
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PullLocKeyFromOtherLocalizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PullLocKeyFromOtherLocalizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PullLocKeyFromOtherLocalizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x000050BC File Offset: 0x000032BC
		public PullLocKeyFromOtherLocalizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x0002B4B0 File Offset: 0x000296B0
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x000050C5 File Offset: 0x000032C5
		public unsafe TMPLocalizer pullFromLocalizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PullLocKeyFromOtherLocalizer.NativeFieldInfoPtr_pullFromLocalizer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMPLocalizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PullLocKeyFromOtherLocalizer.NativeFieldInfoPtr_pullFromLocalizer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0002B4E0 File Offset: 0x000296E0
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x000050E4 File Offset: 0x000032E4
		public unsafe TMPLocalizer pullToLocalizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PullLocKeyFromOtherLocalizer.NativeFieldInfoPtr_pullToLocalizer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMPLocalizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PullLocKeyFromOtherLocalizer.NativeFieldInfoPtr_pullToLocalizer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeFieldInfoPtr_pullFromLocalizer;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeFieldInfoPtr_pullToLocalizer;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
