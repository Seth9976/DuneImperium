using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.moz
{
	// Token: 0x0200011E RID: 286
	public class OverlayUI : MonoBehaviour
	{
		// Token: 0x06000CD9 RID: 3289 RVA: 0x0004611C File Offset: 0x0004431C
		// Note: this type is marked as 'beforefieldinit'.
		static OverlayUI()
		{
			Il2CppClassPointerStore<OverlayUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "OverlayUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverlayUI>.NativeClassPtr);
			OverlayUI.NativeFieldInfoPtr_mozCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayUI>.NativeClassPtr, "mozCanvas");
			OverlayUI.NativeFieldInfoPtr_tooltipCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayUI>.NativeClassPtr, "tooltipCanvas");
			OverlayUI.NativeMethodInfoPtr_get_MozCanvas_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayUI>.NativeClassPtr, 100665163);
			OverlayUI.NativeMethodInfoPtr_get_TooltipCanvas_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayUI>.NativeClassPtr, 100665164);
			OverlayUI.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayUI>.NativeClassPtr, 100665165);
			OverlayUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayUI>.NativeClassPtr, 100665166);
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x000461C4 File Offset: 0x000443C4
		public unsafe RectTransform MozCanvas
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayUI.NativeMethodInfoPtr_get_MozCanvas_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x00046204 File Offset: 0x00044404
		public unsafe RectTransform TooltipCanvas
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayUI.NativeMethodInfoPtr_get_TooltipCanvas_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00046244 File Offset: 0x00044444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510271, XrefRangeEnd = 510278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayUI.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00046278 File Offset: 0x00044478
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverlayUI()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x000083F0 File Offset: 0x000065F0
		public OverlayUI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x000462B4 File Offset: 0x000444B4
		// (set) Token: 0x06000CE0 RID: 3296 RVA: 0x000083F9 File Offset: 0x000065F9
		public unsafe RectTransform mozCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayUI.NativeFieldInfoPtr_mozCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayUI.NativeFieldInfoPtr_mozCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x000462E4 File Offset: 0x000444E4
		// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x00008418 File Offset: 0x00006618
		public unsafe RectTransform tooltipCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayUI.NativeFieldInfoPtr_tooltipCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayUI.NativeFieldInfoPtr_tooltipCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeFieldInfoPtr_mozCanvas;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeFieldInfoPtr_tooltipCanvas;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_get_MozCanvas_Public_get_RectTransform_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_get_TooltipCanvas_Public_get_RectTransform_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
