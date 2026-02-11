using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000090 RID: 144
	[Serializable]
	public sealed class ColorAdjustments : VolumeComponent
	{
		// Token: 0x06000CA9 RID: 3241 RVA: 0x00041F00 File Offset: 0x00040100
		// Note: this type is marked as 'beforefieldinit'.
		static ColorAdjustments()
		{
			Il2CppClassPointerStore<ColorAdjustments>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ColorAdjustments");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorAdjustments>.NativeClassPtr);
			ColorAdjustments.NativeFieldInfoPtr_postExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorAdjustments>.NativeClassPtr, "postExposure");
			ColorAdjustments.NativeFieldInfoPtr_contrast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorAdjustments>.NativeClassPtr, "contrast");
			ColorAdjustments.NativeFieldInfoPtr_colorFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorAdjustments>.NativeClassPtr, "colorFilter");
			ColorAdjustments.NativeFieldInfoPtr_hueShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorAdjustments>.NativeClassPtr, "hueShift");
			ColorAdjustments.NativeFieldInfoPtr_saturation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorAdjustments>.NativeClassPtr, "saturation");
			ColorAdjustments.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorAdjustments>.NativeClassPtr, 100665007);
			ColorAdjustments.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorAdjustments>.NativeClassPtr, 100665008);
			ColorAdjustments.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorAdjustments>.NativeClassPtr, 100665009);
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00041FD0 File Offset: 0x000401D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611931, XrefRangeEnd = 611939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorAdjustments.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x0004200C File Offset: 0x0004020C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileCompatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorAdjustments.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00042048 File Offset: 0x00040248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611939, XrefRangeEnd = 611963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorAdjustments()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorAdjustments>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorAdjustments.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00007C1D File Offset: 0x00005E1D
		public ColorAdjustments(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x00042084 File Offset: 0x00040284
		// (set) Token: 0x06000CAF RID: 3247 RVA: 0x00007C26 File Offset: 0x00005E26
		public unsafe FloatParameter postExposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorAdjustments.NativeFieldInfoPtr_postExposure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorAdjustments.NativeFieldInfoPtr_postExposure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x000420B4 File Offset: 0x000402B4
		// (set) Token: 0x06000CB1 RID: 3249 RVA: 0x00007C45 File Offset: 0x00005E45
		public unsafe ClampedFloatParameter contrast
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorAdjustments.NativeFieldInfoPtr_contrast);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorAdjustments.NativeFieldInfoPtr_contrast), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x000420E4 File Offset: 0x000402E4
		// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x00007C64 File Offset: 0x00005E64
		public unsafe ColorParameter colorFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorAdjustments.NativeFieldInfoPtr_colorFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorAdjustments.NativeFieldInfoPtr_colorFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x00042114 File Offset: 0x00040314
		// (set) Token: 0x06000CB5 RID: 3253 RVA: 0x00007C83 File Offset: 0x00005E83
		public unsafe ClampedFloatParameter hueShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorAdjustments.NativeFieldInfoPtr_hueShift);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorAdjustments.NativeFieldInfoPtr_hueShift), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x00042144 File Offset: 0x00040344
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x00007CA2 File Offset: 0x00005EA2
		public unsafe ClampedFloatParameter saturation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorAdjustments.NativeFieldInfoPtr_saturation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorAdjustments.NativeFieldInfoPtr_saturation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeFieldInfoPtr_postExposure;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeFieldInfoPtr_contrast;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeFieldInfoPtr_colorFilter;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeFieldInfoPtr_hueShift;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeFieldInfoPtr_saturation;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
