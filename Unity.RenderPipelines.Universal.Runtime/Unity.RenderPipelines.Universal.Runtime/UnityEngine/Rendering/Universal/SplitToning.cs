using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000A2 RID: 162
	[Serializable]
	public sealed class SplitToning : VolumeComponent
	{
		// Token: 0x06000D4E RID: 3406 RVA: 0x0004397C File Offset: 0x00041B7C
		// Note: this type is marked as 'beforefieldinit'.
		static SplitToning()
		{
			Il2CppClassPointerStore<SplitToning>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "SplitToning");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplitToning>.NativeClassPtr);
			SplitToning.NativeFieldInfoPtr_shadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplitToning>.NativeClassPtr, "shadows");
			SplitToning.NativeFieldInfoPtr_highlights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplitToning>.NativeClassPtr, "highlights");
			SplitToning.NativeFieldInfoPtr_balance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplitToning>.NativeClassPtr, "balance");
			SplitToning.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplitToning>.NativeClassPtr, 100665042);
			SplitToning.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplitToning>.NativeClassPtr, 100665043);
			SplitToning.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplitToning>.NativeClassPtr, 100665044);
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00043A24 File Offset: 0x00041C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612283, XrefRangeEnd = 612286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplitToning.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00043A60 File Offset: 0x00041C60
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileCompatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplitToning.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00043A9C File Offset: 0x00041C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612286, XrefRangeEnd = 612301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SplitToning()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplitToning>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplitToning.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x000083AC File Offset: 0x000065AC
		public SplitToning(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x00043AD8 File Offset: 0x00041CD8
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x000083B5 File Offset: 0x000065B5
		public unsafe ColorParameter shadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplitToning.NativeFieldInfoPtr_shadows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplitToning.NativeFieldInfoPtr_shadows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x00043B08 File Offset: 0x00041D08
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x000083D4 File Offset: 0x000065D4
		public unsafe ColorParameter highlights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplitToning.NativeFieldInfoPtr_highlights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplitToning.NativeFieldInfoPtr_highlights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x00043B38 File Offset: 0x00041D38
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x000083F3 File Offset: 0x000065F3
		public unsafe ClampedFloatParameter balance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplitToning.NativeFieldInfoPtr_balance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplitToning.NativeFieldInfoPtr_balance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeFieldInfoPtr_shadows;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeFieldInfoPtr_highlights;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeFieldInfoPtr_balance;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
