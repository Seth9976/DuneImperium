using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000099 RID: 153
	[Serializable]
	public sealed class LensDistortion : VolumeComponent
	{
		// Token: 0x06000D05 RID: 3333 RVA: 0x00042D98 File Offset: 0x00040F98
		// Note: this type is marked as 'beforefieldinit'.
		static LensDistortion()
		{
			Il2CppClassPointerStore<LensDistortion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "LensDistortion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr);
			LensDistortion.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr, "intensity");
			LensDistortion.NativeFieldInfoPtr_xMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr, "xMultiplier");
			LensDistortion.NativeFieldInfoPtr_yMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr, "yMultiplier");
			LensDistortion.NativeFieldInfoPtr_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr, "center");
			LensDistortion.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr, "scale");
			LensDistortion.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr, 100665025);
			LensDistortion.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr, 100665026);
			LensDistortion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr, 100665027);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00042E68 File Offset: 0x00041068
		[CallerCount(0)]
		public unsafe bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensDistortion.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00042EA4 File Offset: 0x000410A4
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileCompatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensDistortion.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00042EE0 File Offset: 0x000410E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612160, XrefRangeEnd = 612183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LensDistortion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensDistortion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00008070 File Offset: 0x00006270
		public LensDistortion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x00042F1C File Offset: 0x0004111C
		// (set) Token: 0x06000D0B RID: 3339 RVA: 0x00008079 File Offset: 0x00006279
		public unsafe ClampedFloatParameter intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_intensity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_intensity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x00042F4C File Offset: 0x0004114C
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x00008098 File Offset: 0x00006298
		public unsafe ClampedFloatParameter xMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_xMultiplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_xMultiplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x00042F7C File Offset: 0x0004117C
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x000080B7 File Offset: 0x000062B7
		public unsafe ClampedFloatParameter yMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_yMultiplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_yMultiplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x00042FAC File Offset: 0x000411AC
		// (set) Token: 0x06000D11 RID: 3345 RVA: 0x000080D6 File Offset: 0x000062D6
		public unsafe Vector2Parameter center
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_center);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2Parameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_center), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x00042FDC File Offset: 0x000411DC
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x000080F5 File Offset: 0x000062F5
		public unsafe ClampedFloatParameter scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_scale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_scale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeFieldInfoPtr_intensity;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeFieldInfoPtr_xMultiplier;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeFieldInfoPtr_yMultiplier;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeFieldInfoPtr_center;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
