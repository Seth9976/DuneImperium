using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000A0 RID: 160
	[Serializable]
	public sealed class PaniniProjection : VolumeComponent
	{
		// Token: 0x06000D32 RID: 3378 RVA: 0x000434D8 File Offset: 0x000416D8
		// Note: this type is marked as 'beforefieldinit'.
		static PaniniProjection()
		{
			Il2CppClassPointerStore<PaniniProjection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PaniniProjection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaniniProjection>.NativeClassPtr);
			PaniniProjection.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaniniProjection>.NativeClassPtr, "distance");
			PaniniProjection.NativeFieldInfoPtr_cropToFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaniniProjection>.NativeClassPtr, "cropToFit");
			PaniniProjection.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaniniProjection>.NativeClassPtr, 100665036);
			PaniniProjection.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaniniProjection>.NativeClassPtr, 100665037);
			PaniniProjection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaniniProjection>.NativeClassPtr, 100665038);
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x0004356C File Offset: 0x0004176C
		[CallerCount(0)]
		public unsafe bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaniniProjection.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x000435A8 File Offset: 0x000417A8
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileCompatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaniniProjection.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x000435E4 File Offset: 0x000417E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612235, XrefRangeEnd = 612245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PaniniProjection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PaniniProjection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaniniProjection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00008283 File Offset: 0x00006483
		public PaniniProjection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x00043620 File Offset: 0x00041820
		// (set) Token: 0x06000D38 RID: 3384 RVA: 0x0000828C File Offset: 0x0000648C
		public unsafe ClampedFloatParameter distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaniniProjection.NativeFieldInfoPtr_distance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaniniProjection.NativeFieldInfoPtr_distance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x00043650 File Offset: 0x00041850
		// (set) Token: 0x06000D3A RID: 3386 RVA: 0x000082AB File Offset: 0x000064AB
		public unsafe ClampedFloatParameter cropToFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaniniProjection.NativeFieldInfoPtr_cropToFit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaniniProjection.NativeFieldInfoPtr_cropToFit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeFieldInfoPtr_cropToFit;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
