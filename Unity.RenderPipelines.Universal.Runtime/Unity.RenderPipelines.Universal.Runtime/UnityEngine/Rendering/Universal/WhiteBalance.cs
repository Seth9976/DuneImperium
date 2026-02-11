using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000AB RID: 171
	[Serializable]
	public sealed class WhiteBalance : VolumeComponent
	{
		// Token: 0x06000D88 RID: 3464 RVA: 0x00044268 File Offset: 0x00042468
		// Note: this type is marked as 'beforefieldinit'.
		static WhiteBalance()
		{
			Il2CppClassPointerStore<WhiteBalance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "WhiteBalance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WhiteBalance>.NativeClassPtr);
			WhiteBalance.NativeFieldInfoPtr_temperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhiteBalance>.NativeClassPtr, "temperature");
			WhiteBalance.NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhiteBalance>.NativeClassPtr, "tint");
			WhiteBalance.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhiteBalance>.NativeClassPtr, 100665054);
			WhiteBalance.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhiteBalance>.NativeClassPtr, 100665055);
			WhiteBalance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhiteBalance>.NativeClassPtr, 100665056);
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x000442FC File Offset: 0x000424FC
		[CallerCount(0)]
		public unsafe bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhiteBalance.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00044338 File Offset: 0x00042538
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileCompatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhiteBalance.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00044374 File Offset: 0x00042574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612383, XrefRangeEnd = 612393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WhiteBalance()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WhiteBalance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhiteBalance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0000869C File Offset: 0x0000689C
		public WhiteBalance(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x000443B0 File Offset: 0x000425B0
		// (set) Token: 0x06000D8E RID: 3470 RVA: 0x000086A5 File Offset: 0x000068A5
		public unsafe ClampedFloatParameter temperature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteBalance.NativeFieldInfoPtr_temperature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteBalance.NativeFieldInfoPtr_temperature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x000443E0 File Offset: 0x000425E0
		// (set) Token: 0x06000D90 RID: 3472 RVA: 0x000086C4 File Offset: 0x000068C4
		public unsafe ClampedFloatParameter tint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteBalance.NativeFieldInfoPtr_tint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteBalance.NativeFieldInfoPtr_tint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeFieldInfoPtr_temperature;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeFieldInfoPtr_tint;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
