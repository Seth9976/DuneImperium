using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000094 RID: 148
	[Serializable]
	public sealed class DepthOfField : VolumeComponent
	{
		// Token: 0x06000CD7 RID: 3287 RVA: 0x000426AC File Offset: 0x000408AC
		// Note: this type is marked as 'beforefieldinit'.
		static DepthOfField()
		{
			Il2CppClassPointerStore<DepthOfField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DepthOfField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr);
			DepthOfField.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, "mode");
			DepthOfField.NativeFieldInfoPtr_gaussianStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, "gaussianStart");
			DepthOfField.NativeFieldInfoPtr_gaussianEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, "gaussianEnd");
			DepthOfField.NativeFieldInfoPtr_gaussianMaxRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, "gaussianMaxRadius");
			DepthOfField.NativeFieldInfoPtr_highQualitySampling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, "highQualitySampling");
			DepthOfField.NativeFieldInfoPtr_focusDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, "focusDistance");
			DepthOfField.NativeFieldInfoPtr_aperture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, "aperture");
			DepthOfField.NativeFieldInfoPtr_focalLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, "focalLength");
			DepthOfField.NativeFieldInfoPtr_bladeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, "bladeCount");
			DepthOfField.NativeFieldInfoPtr_bladeCurvature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, "bladeCurvature");
			DepthOfField.NativeFieldInfoPtr_bladeRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, "bladeRotation");
			DepthOfField.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, 100665017);
			DepthOfField.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, 100665018);
			DepthOfField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, 100665019);
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x000427F4 File Offset: 0x000409F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 612078, RefRangeEnd = 612079, XrefRangeStart = 612077, XrefRangeEnd = 612078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfField.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00042830 File Offset: 0x00040A30
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileCompatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfField.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x0004286C File Offset: 0x00040A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612079, XrefRangeEnd = 612131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DepthOfField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00007E09 File Offset: 0x00006009
		public DepthOfField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x000428A8 File Offset: 0x00040AA8
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x00007E12 File Offset: 0x00006012
		public unsafe DepthOfFieldModeParameter mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_mode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DepthOfFieldModeParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_mode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x000428D8 File Offset: 0x00040AD8
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x00007E31 File Offset: 0x00006031
		public unsafe MinFloatParameter gaussianStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_gaussianStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_gaussianStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x00042908 File Offset: 0x00040B08
		// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x00007E50 File Offset: 0x00006050
		public unsafe MinFloatParameter gaussianEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_gaussianEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_gaussianEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x00042938 File Offset: 0x00040B38
		// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x00007E6F File Offset: 0x0000606F
		public unsafe ClampedFloatParameter gaussianMaxRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_gaussianMaxRadius);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_gaussianMaxRadius), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00042968 File Offset: 0x00040B68
		// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x00007E8E File Offset: 0x0000608E
		public unsafe BoolParameter highQualitySampling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_highQualitySampling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_highQualitySampling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00042998 File Offset: 0x00040B98
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x00007EAD File Offset: 0x000060AD
		public unsafe MinFloatParameter focusDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_focusDistance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_focusDistance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x000429C8 File Offset: 0x00040BC8
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00007ECC File Offset: 0x000060CC
		public unsafe ClampedFloatParameter aperture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_aperture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_aperture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x000429F8 File Offset: 0x00040BF8
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x00007EEB File Offset: 0x000060EB
		public unsafe ClampedFloatParameter focalLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_focalLength);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_focalLength), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x00042A28 File Offset: 0x00040C28
		// (set) Token: 0x06000CED RID: 3309 RVA: 0x00007F0A File Offset: 0x0000610A
		public unsafe ClampedIntParameter bladeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_bladeCount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedIntParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_bladeCount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x00042A58 File Offset: 0x00040C58
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x00007F29 File Offset: 0x00006129
		public unsafe ClampedFloatParameter bladeCurvature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_bladeCurvature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_bladeCurvature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x00042A88 File Offset: 0x00040C88
		// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x00007F48 File Offset: 0x00006148
		public unsafe ClampedFloatParameter bladeRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_bladeRotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_bladeRotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeFieldInfoPtr_gaussianStart;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeFieldInfoPtr_gaussianEnd;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeFieldInfoPtr_gaussianMaxRadius;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeFieldInfoPtr_highQualitySampling;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeFieldInfoPtr_focusDistance;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeFieldInfoPtr_aperture;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeFieldInfoPtr_focalLength;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeFieldInfoPtr_bladeCount;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeFieldInfoPtr_bladeCurvature;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeFieldInfoPtr_bladeRotation;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
