using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000091 RID: 145
	[Serializable]
	public sealed class ColorCurves : VolumeComponent
	{
		// Token: 0x06000CB8 RID: 3256 RVA: 0x00042174 File Offset: 0x00040374
		// Note: this type is marked as 'beforefieldinit'.
		static ColorCurves()
		{
			Il2CppClassPointerStore<ColorCurves>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ColorCurves");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorCurves>.NativeClassPtr);
			ColorCurves.NativeFieldInfoPtr_master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorCurves>.NativeClassPtr, "master");
			ColorCurves.NativeFieldInfoPtr_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorCurves>.NativeClassPtr, "red");
			ColorCurves.NativeFieldInfoPtr_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorCurves>.NativeClassPtr, "green");
			ColorCurves.NativeFieldInfoPtr_blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorCurves>.NativeClassPtr, "blue");
			ColorCurves.NativeFieldInfoPtr_hueVsHue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorCurves>.NativeClassPtr, "hueVsHue");
			ColorCurves.NativeFieldInfoPtr_hueVsSat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorCurves>.NativeClassPtr, "hueVsSat");
			ColorCurves.NativeFieldInfoPtr_satVsSat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorCurves>.NativeClassPtr, "satVsSat");
			ColorCurves.NativeFieldInfoPtr_lumVsSat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorCurves>.NativeClassPtr, "lumVsSat");
			ColorCurves.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorCurves>.NativeClassPtr, 100665010);
			ColorCurves.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorCurves>.NativeClassPtr, 100665011);
			ColorCurves.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorCurves>.NativeClassPtr, 100665012);
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x00042280 File Offset: 0x00040480
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorCurves.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x000422BC File Offset: 0x000404BC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileCompatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorCurves.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x000422F8 File Offset: 0x000404F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611963, XrefRangeEnd = 612047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorCurves()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorCurves>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorCurves.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00007CC1 File Offset: 0x00005EC1
		public ColorCurves(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x00042334 File Offset: 0x00040534
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x00007CCA File Offset: 0x00005ECA
		public unsafe TextureCurveParameter master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorCurves.NativeFieldInfoPtr_master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureCurveParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorCurves.NativeFieldInfoPtr_master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x00042364 File Offset: 0x00040564
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x00007CE9 File Offset: 0x00005EE9
		public unsafe TextureCurveParameter red
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorCurves.NativeFieldInfoPtr_red);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureCurveParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorCurves.NativeFieldInfoPtr_red), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00042394 File Offset: 0x00040594
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x00007D08 File Offset: 0x00005F08
		public unsafe TextureCurveParameter green
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorCurves.NativeFieldInfoPtr_green);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureCurveParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorCurves.NativeFieldInfoPtr_green), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x000423C4 File Offset: 0x000405C4
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x00007D27 File Offset: 0x00005F27
		public unsafe TextureCurveParameter blue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorCurves.NativeFieldInfoPtr_blue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureCurveParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorCurves.NativeFieldInfoPtr_blue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x000423F4 File Offset: 0x000405F4
		// (set) Token: 0x06000CC6 RID: 3270 RVA: 0x00007D46 File Offset: 0x00005F46
		public unsafe TextureCurveParameter hueVsHue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorCurves.NativeFieldInfoPtr_hueVsHue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureCurveParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorCurves.NativeFieldInfoPtr_hueVsHue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x00042424 File Offset: 0x00040624
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x00007D65 File Offset: 0x00005F65
		public unsafe TextureCurveParameter hueVsSat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorCurves.NativeFieldInfoPtr_hueVsSat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureCurveParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorCurves.NativeFieldInfoPtr_hueVsSat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x00042454 File Offset: 0x00040654
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x00007D84 File Offset: 0x00005F84
		public unsafe TextureCurveParameter satVsSat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorCurves.NativeFieldInfoPtr_satVsSat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureCurveParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorCurves.NativeFieldInfoPtr_satVsSat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00042484 File Offset: 0x00040684
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x00007DA3 File Offset: 0x00005FA3
		public unsafe TextureCurveParameter lumVsSat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorCurves.NativeFieldInfoPtr_lumVsSat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureCurveParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorCurves.NativeFieldInfoPtr_lumVsSat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeFieldInfoPtr_master;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeFieldInfoPtr_red;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeFieldInfoPtr_green;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeFieldInfoPtr_blue;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeFieldInfoPtr_hueVsHue;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeFieldInfoPtr_hueVsSat;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeFieldInfoPtr_satVsSat;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeFieldInfoPtr_lumVsSat;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
