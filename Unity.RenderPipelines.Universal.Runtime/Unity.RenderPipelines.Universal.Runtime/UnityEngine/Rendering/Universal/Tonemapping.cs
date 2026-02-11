using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000A6 RID: 166
	[Serializable]
	public sealed class Tonemapping : VolumeComponent
	{
		// Token: 0x06000D59 RID: 3417 RVA: 0x00043B68 File Offset: 0x00041D68
		// Note: this type is marked as 'beforefieldinit'.
		static Tonemapping()
		{
			Il2CppClassPointerStore<Tonemapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "Tonemapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tonemapping>.NativeClassPtr);
			Tonemapping.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tonemapping>.NativeClassPtr, "mode");
			Tonemapping.NativeFieldInfoPtr_neutralHDRRangeReductionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tonemapping>.NativeClassPtr, "neutralHDRRangeReductionMode");
			Tonemapping.NativeFieldInfoPtr_acesPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tonemapping>.NativeClassPtr, "acesPreset");
			Tonemapping.NativeFieldInfoPtr_hueShiftAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tonemapping>.NativeClassPtr, "hueShiftAmount");
			Tonemapping.NativeFieldInfoPtr_detectPaperWhite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tonemapping>.NativeClassPtr, "detectPaperWhite");
			Tonemapping.NativeFieldInfoPtr_paperWhite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tonemapping>.NativeClassPtr, "paperWhite");
			Tonemapping.NativeFieldInfoPtr_detectBrightnessLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tonemapping>.NativeClassPtr, "detectBrightnessLimits");
			Tonemapping.NativeFieldInfoPtr_minNits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tonemapping>.NativeClassPtr, "minNits");
			Tonemapping.NativeFieldInfoPtr_maxNits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tonemapping>.NativeClassPtr, "maxNits");
			Tonemapping.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tonemapping>.NativeClassPtr, 100665045);
			Tonemapping.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tonemapping>.NativeClassPtr, 100665046);
			Tonemapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tonemapping>.NativeClassPtr, 100665047);
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00043C88 File Offset: 0x00041E88
		[CallerCount(0)]
		public unsafe bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tonemapping.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00043CC4 File Offset: 0x00041EC4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileCompatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tonemapping.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00043D00 File Offset: 0x00041F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612301, XrefRangeEnd = 612349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tonemapping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tonemapping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tonemapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00008412 File Offset: 0x00006612
		public Tonemapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x00043D3C File Offset: 0x00041F3C
		// (set) Token: 0x06000D5F RID: 3423 RVA: 0x0000841B File Offset: 0x0000661B
		public unsafe TonemappingModeParameter mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tonemapping.NativeFieldInfoPtr_mode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TonemappingModeParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tonemapping.NativeFieldInfoPtr_mode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x00043D6C File Offset: 0x00041F6C
		// (set) Token: 0x06000D61 RID: 3425 RVA: 0x0000843A File Offset: 0x0000663A
		public unsafe NeutralRangeReductionModeParameter neutralHDRRangeReductionMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tonemapping.NativeFieldInfoPtr_neutralHDRRangeReductionMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NeutralRangeReductionModeParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tonemapping.NativeFieldInfoPtr_neutralHDRRangeReductionMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x00043D9C File Offset: 0x00041F9C
		// (set) Token: 0x06000D63 RID: 3427 RVA: 0x00008459 File Offset: 0x00006659
		public unsafe HDRACESPresetParameter acesPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tonemapping.NativeFieldInfoPtr_acesPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HDRACESPresetParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tonemapping.NativeFieldInfoPtr_acesPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x00043DCC File Offset: 0x00041FCC
		// (set) Token: 0x06000D65 RID: 3429 RVA: 0x00008478 File Offset: 0x00006678
		public unsafe ClampedFloatParameter hueShiftAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tonemapping.NativeFieldInfoPtr_hueShiftAmount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tonemapping.NativeFieldInfoPtr_hueShiftAmount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x00043DFC File Offset: 0x00041FFC
		// (set) Token: 0x06000D67 RID: 3431 RVA: 0x00008497 File Offset: 0x00006697
		public unsafe BoolParameter detectPaperWhite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tonemapping.NativeFieldInfoPtr_detectPaperWhite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tonemapping.NativeFieldInfoPtr_detectPaperWhite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00043E2C File Offset: 0x0004202C
		// (set) Token: 0x06000D69 RID: 3433 RVA: 0x000084B6 File Offset: 0x000066B6
		public unsafe ClampedFloatParameter paperWhite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tonemapping.NativeFieldInfoPtr_paperWhite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tonemapping.NativeFieldInfoPtr_paperWhite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x00043E5C File Offset: 0x0004205C
		// (set) Token: 0x06000D6B RID: 3435 RVA: 0x000084D5 File Offset: 0x000066D5
		public unsafe BoolParameter detectBrightnessLimits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tonemapping.NativeFieldInfoPtr_detectBrightnessLimits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tonemapping.NativeFieldInfoPtr_detectBrightnessLimits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x00043E8C File Offset: 0x0004208C
		// (set) Token: 0x06000D6D RID: 3437 RVA: 0x000084F4 File Offset: 0x000066F4
		public unsafe ClampedFloatParameter minNits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tonemapping.NativeFieldInfoPtr_minNits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tonemapping.NativeFieldInfoPtr_minNits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x00043EBC File Offset: 0x000420BC
		// (set) Token: 0x06000D6F RID: 3439 RVA: 0x00008513 File Offset: 0x00006713
		public unsafe ClampedFloatParameter maxNits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tonemapping.NativeFieldInfoPtr_maxNits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tonemapping.NativeFieldInfoPtr_maxNits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeFieldInfoPtr_neutralHDRRangeReductionMode;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeFieldInfoPtr_acesPreset;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeFieldInfoPtr_hueShiftAmount;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeFieldInfoPtr_detectPaperWhite;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeFieldInfoPtr_paperWhite;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeFieldInfoPtr_detectBrightnessLimits;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeFieldInfoPtr_minNits;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeFieldInfoPtr_maxNits;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
