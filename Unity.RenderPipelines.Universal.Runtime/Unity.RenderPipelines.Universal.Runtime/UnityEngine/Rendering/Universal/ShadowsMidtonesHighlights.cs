using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000A1 RID: 161
	[Serializable]
	public sealed class ShadowsMidtonesHighlights : VolumeComponent
	{
		// Token: 0x06000D3B RID: 3387 RVA: 0x00043680 File Offset: 0x00041880
		// Note: this type is marked as 'beforefieldinit'.
		static ShadowsMidtonesHighlights()
		{
			Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShadowsMidtonesHighlights");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr);
			ShadowsMidtonesHighlights.NativeFieldInfoPtr_shadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, "shadows");
			ShadowsMidtonesHighlights.NativeFieldInfoPtr_midtones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, "midtones");
			ShadowsMidtonesHighlights.NativeFieldInfoPtr_highlights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, "highlights");
			ShadowsMidtonesHighlights.NativeFieldInfoPtr_shadowsStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, "shadowsStart");
			ShadowsMidtonesHighlights.NativeFieldInfoPtr_shadowsEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, "shadowsEnd");
			ShadowsMidtonesHighlights.NativeFieldInfoPtr_highlightsStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, "highlightsStart");
			ShadowsMidtonesHighlights.NativeFieldInfoPtr_highlightsEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, "highlightsEnd");
			ShadowsMidtonesHighlights.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, 100665039);
			ShadowsMidtonesHighlights.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, 100665040);
			ShadowsMidtonesHighlights.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, 100665041);
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00043778 File Offset: 0x00041978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612245, XrefRangeEnd = 612252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowsMidtonesHighlights.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x000437B4 File Offset: 0x000419B4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileCompatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowsMidtonesHighlights.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x000437F0 File Offset: 0x000419F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612252, XrefRangeEnd = 612283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShadowsMidtonesHighlights()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowsMidtonesHighlights.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x000082CA File Offset: 0x000064CA
		public ShadowsMidtonesHighlights(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x0004382C File Offset: 0x00041A2C
		// (set) Token: 0x06000D41 RID: 3393 RVA: 0x000082D3 File Offset: 0x000064D3
		public unsafe Vector4Parameter shadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_shadows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector4Parameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_shadows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x0004385C File Offset: 0x00041A5C
		// (set) Token: 0x06000D43 RID: 3395 RVA: 0x000082F2 File Offset: 0x000064F2
		public unsafe Vector4Parameter midtones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_midtones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector4Parameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_midtones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x0004388C File Offset: 0x00041A8C
		// (set) Token: 0x06000D45 RID: 3397 RVA: 0x00008311 File Offset: 0x00006511
		public unsafe Vector4Parameter highlights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_highlights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector4Parameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_highlights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x000438BC File Offset: 0x00041ABC
		// (set) Token: 0x06000D47 RID: 3399 RVA: 0x00008330 File Offset: 0x00006530
		public unsafe MinFloatParameter shadowsStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_shadowsStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_shadowsStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x000438EC File Offset: 0x00041AEC
		// (set) Token: 0x06000D49 RID: 3401 RVA: 0x0000834F File Offset: 0x0000654F
		public unsafe MinFloatParameter shadowsEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_shadowsEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_shadowsEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x0004391C File Offset: 0x00041B1C
		// (set) Token: 0x06000D4B RID: 3403 RVA: 0x0000836E File Offset: 0x0000656E
		public unsafe MinFloatParameter highlightsStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_highlightsStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_highlightsStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x0004394C File Offset: 0x00041B4C
		// (set) Token: 0x06000D4D RID: 3405 RVA: 0x0000838D File Offset: 0x0000658D
		public unsafe MinFloatParameter highlightsEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_highlightsEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_highlightsEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeFieldInfoPtr_shadows;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeFieldInfoPtr_midtones;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeFieldInfoPtr_highlights;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeFieldInfoPtr_shadowsStart;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeFieldInfoPtr_shadowsEnd;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeFieldInfoPtr_highlightsStart;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeFieldInfoPtr_highlightsEnd;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
