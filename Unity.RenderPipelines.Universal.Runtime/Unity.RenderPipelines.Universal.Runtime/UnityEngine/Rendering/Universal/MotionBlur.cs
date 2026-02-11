using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200009D RID: 157
	[Serializable]
	public sealed class MotionBlur : VolumeComponent
	{
		// Token: 0x06000D1F RID: 3359 RVA: 0x000431F8 File Offset: 0x000413F8
		// Note: this type is marked as 'beforefieldinit'.
		static MotionBlur()
		{
			Il2CppClassPointerStore<MotionBlur>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "MotionBlur");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlur>.NativeClassPtr);
			MotionBlur.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlur>.NativeClassPtr, "mode");
			MotionBlur.NativeFieldInfoPtr_quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlur>.NativeClassPtr, "quality");
			MotionBlur.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlur>.NativeClassPtr, "intensity");
			MotionBlur.NativeFieldInfoPtr_clamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlur>.NativeClassPtr, "clamp");
			MotionBlur.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlur>.NativeClassPtr, 100665031);
			MotionBlur.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlur>.NativeClassPtr, 100665032);
			MotionBlur.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlur>.NativeClassPtr, 100665033);
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x000432B4 File Offset: 0x000414B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 612204, RefRangeEnd = 612205, XrefRangeStart = 612204, XrefRangeEnd = 612204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlur.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x000432F0 File Offset: 0x000414F0
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileCompatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlur.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0004332C File Offset: 0x0004152C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612205, XrefRangeEnd = 612229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MotionBlur()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionBlur>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlur.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0000817A File Offset: 0x0000637A
		public MotionBlur(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x00043368 File Offset: 0x00041568
		// (set) Token: 0x06000D25 RID: 3365 RVA: 0x00008183 File Offset: 0x00006383
		public unsafe MotionBlurModeParameter mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlur.NativeFieldInfoPtr_mode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MotionBlurModeParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlur.NativeFieldInfoPtr_mode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x00043398 File Offset: 0x00041598
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x000081A2 File Offset: 0x000063A2
		public unsafe MotionBlurQualityParameter quality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlur.NativeFieldInfoPtr_quality);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MotionBlurQualityParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlur.NativeFieldInfoPtr_quality), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x000433C8 File Offset: 0x000415C8
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x000081C1 File Offset: 0x000063C1
		public unsafe ClampedFloatParameter intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlur.NativeFieldInfoPtr_intensity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlur.NativeFieldInfoPtr_intensity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x000433F8 File Offset: 0x000415F8
		// (set) Token: 0x06000D2B RID: 3371 RVA: 0x000081E0 File Offset: 0x000063E0
		public unsafe ClampedFloatParameter clamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlur.NativeFieldInfoPtr_clamp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlur.NativeFieldInfoPtr_clamp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeFieldInfoPtr_quality;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeFieldInfoPtr_intensity;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeFieldInfoPtr_clamp;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
