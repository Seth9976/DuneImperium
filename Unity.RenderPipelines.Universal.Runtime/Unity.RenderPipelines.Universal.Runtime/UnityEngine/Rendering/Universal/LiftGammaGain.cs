using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200009A RID: 154
	[Serializable]
	public sealed class LiftGammaGain : VolumeComponent
	{
		// Token: 0x06000D14 RID: 3348 RVA: 0x0004300C File Offset: 0x0004120C
		// Note: this type is marked as 'beforefieldinit'.
		static LiftGammaGain()
		{
			Il2CppClassPointerStore<LiftGammaGain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "LiftGammaGain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiftGammaGain>.NativeClassPtr);
			LiftGammaGain.NativeFieldInfoPtr_lift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiftGammaGain>.NativeClassPtr, "lift");
			LiftGammaGain.NativeFieldInfoPtr_gamma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiftGammaGain>.NativeClassPtr, "gamma");
			LiftGammaGain.NativeFieldInfoPtr_gain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiftGammaGain>.NativeClassPtr, "gain");
			LiftGammaGain.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiftGammaGain>.NativeClassPtr, 100665028);
			LiftGammaGain.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiftGammaGain>.NativeClassPtr, 100665029);
			LiftGammaGain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiftGammaGain>.NativeClassPtr, 100665030);
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x000430B4 File Offset: 0x000412B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612183, XrefRangeEnd = 612190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiftGammaGain.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x000430F0 File Offset: 0x000412F0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileCompatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiftGammaGain.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x0004312C File Offset: 0x0004132C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612190, XrefRangeEnd = 612204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiftGammaGain()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiftGammaGain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiftGammaGain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00008114 File Offset: 0x00006314
		public LiftGammaGain(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x00043168 File Offset: 0x00041368
		// (set) Token: 0x06000D1A RID: 3354 RVA: 0x0000811D File Offset: 0x0000631D
		public unsafe Vector4Parameter lift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiftGammaGain.NativeFieldInfoPtr_lift);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector4Parameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiftGammaGain.NativeFieldInfoPtr_lift), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x00043198 File Offset: 0x00041398
		// (set) Token: 0x06000D1C RID: 3356 RVA: 0x0000813C File Offset: 0x0000633C
		public unsafe Vector4Parameter gamma
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiftGammaGain.NativeFieldInfoPtr_gamma);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector4Parameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiftGammaGain.NativeFieldInfoPtr_gamma), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x000431C8 File Offset: 0x000413C8
		// (set) Token: 0x06000D1E RID: 3358 RVA: 0x0000815B File Offset: 0x0000635B
		public unsafe Vector4Parameter gain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiftGammaGain.NativeFieldInfoPtr_gain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector4Parameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiftGammaGain.NativeFieldInfoPtr_gain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeFieldInfoPtr_lift;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeFieldInfoPtr_gamma;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeFieldInfoPtr_gain;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
