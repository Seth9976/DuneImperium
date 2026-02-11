using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000AA RID: 170
	[Serializable]
	public sealed class Vignette : VolumeComponent
	{
		// Token: 0x06000D79 RID: 3449 RVA: 0x00043FF4 File Offset: 0x000421F4
		// Note: this type is marked as 'beforefieldinit'.
		static Vignette()
		{
			Il2CppClassPointerStore<Vignette>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "Vignette");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vignette>.NativeClassPtr);
			Vignette.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vignette>.NativeClassPtr, "color");
			Vignette.NativeFieldInfoPtr_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vignette>.NativeClassPtr, "center");
			Vignette.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vignette>.NativeClassPtr, "intensity");
			Vignette.NativeFieldInfoPtr_smoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vignette>.NativeClassPtr, "smoothness");
			Vignette.NativeFieldInfoPtr_rounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vignette>.NativeClassPtr, "rounded");
			Vignette.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vignette>.NativeClassPtr, 100665051);
			Vignette.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vignette>.NativeClassPtr, 100665052);
			Vignette.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vignette>.NativeClassPtr, 100665053);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x000440C4 File Offset: 0x000422C4
		[CallerCount(0)]
		public unsafe bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vignette.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00044100 File Offset: 0x00042300
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileCompatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vignette.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0004413C File Offset: 0x0004233C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612358, XrefRangeEnd = 612383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vignette()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vignette>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vignette.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x000085F8 File Offset: 0x000067F8
		public Vignette(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x00044178 File Offset: 0x00042378
		// (set) Token: 0x06000D7F RID: 3455 RVA: 0x00008601 File Offset: 0x00006801
		public unsafe ColorParameter color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x000441A8 File Offset: 0x000423A8
		// (set) Token: 0x06000D81 RID: 3457 RVA: 0x00008620 File Offset: 0x00006820
		public unsafe Vector2Parameter center
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_center);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2Parameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_center), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x000441D8 File Offset: 0x000423D8
		// (set) Token: 0x06000D83 RID: 3459 RVA: 0x0000863F File Offset: 0x0000683F
		public unsafe ClampedFloatParameter intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_intensity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_intensity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00044208 File Offset: 0x00042408
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x0000865E File Offset: 0x0000685E
		public unsafe ClampedFloatParameter smoothness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_smoothness);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_smoothness), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x00044238 File Offset: 0x00042438
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x0000867D File Offset: 0x0000687D
		public unsafe BoolParameter rounded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_rounded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_rounded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeFieldInfoPtr_center;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeFieldInfoPtr_intensity;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeFieldInfoPtr_smoothness;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeFieldInfoPtr_rounded;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
