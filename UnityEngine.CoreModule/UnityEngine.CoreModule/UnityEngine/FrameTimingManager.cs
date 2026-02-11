using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000096 RID: 150
	public static class FrameTimingManager : Object
	{
		// Token: 0x0600094E RID: 2382 RVA: 0x0003442C File Offset: 0x0003262C
		// Note: this type is marked as 'beforefieldinit'.
		static FrameTimingManager()
		{
			Il2CppClassPointerStore<FrameTimingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "FrameTimingManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameTimingManager>.NativeClassPtr);
			FrameTimingManager.NativeMethodInfoPtr_CaptureFrameTimings_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimingManager>.NativeClassPtr, 100664356);
			FrameTimingManager.NativeMethodInfoPtr_GetLatestTimings_Public_Static_UInt32_UInt32_Il2CppStructArray_1_FrameTiming_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimingManager>.NativeClassPtr, 100664357);
			FrameTimingManager.IsFeatureEnabledDelegateField = IL2CPP.ResolveICall<FrameTimingManager.IsFeatureEnabledDelegate>("UnityEngine.FrameTimingManager::IsFeatureEnabled");
			FrameTimingManager.GetVSyncsPerSecondDelegateField = IL2CPP.ResolveICall<FrameTimingManager.GetVSyncsPerSecondDelegate>("UnityEngine.FrameTimingManager::GetVSyncsPerSecond");
			FrameTimingManager.GetGpuTimerFrequencyDelegateField = IL2CPP.ResolveICall<FrameTimingManager.GetGpuTimerFrequencyDelegate>("UnityEngine.FrameTimingManager::GetGpuTimerFrequency");
			FrameTimingManager.GetCpuTimerFrequencyDelegateField = IL2CPP.ResolveICall<FrameTimingManager.GetCpuTimerFrequencyDelegate>("UnityEngine.FrameTimingManager::GetCpuTimerFrequency");
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x000344C0 File Offset: 0x000326C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 649970, RefRangeEnd = 649971, XrefRangeStart = 649968, XrefRangeEnd = 649970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CaptureFrameTimings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimingManager.NativeMethodInfoPtr_CaptureFrameTimings_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x000344E8 File Offset: 0x000326E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 649973, RefRangeEnd = 649974, XrefRangeStart = 649971, XrefRangeEnd = 649973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetLatestTimings(uint numFrames, Il2CppStructArray<FrameTiming> timings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numFrames;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(timings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimingManager.NativeMethodInfoPtr_GetLatestTimings_Public_Static_UInt32_UInt32_Il2CppStructArray_1_FrameTiming_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00005866 File Offset: 0x00003A66
		public FrameTimingManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0000586F File Offset: 0x00003A6F
		public static bool IsFeatureEnabled()
		{
			return FrameTimingManager.IsFeatureEnabledDelegateField();
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0000587B File Offset: 0x00003A7B
		public static float GetVSyncsPerSecond()
		{
			return FrameTimingManager.GetVSyncsPerSecondDelegateField();
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00005887 File Offset: 0x00003A87
		public static ulong GetGpuTimerFrequency()
		{
			return FrameTimingManager.GetGpuTimerFrequencyDelegateField();
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00005893 File Offset: 0x00003A93
		public static ulong GetCpuTimerFrequency()
		{
			return FrameTimingManager.GetCpuTimerFrequencyDelegateField();
		}

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr_CaptureFrameTimings_Public_Static_Void_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_GetLatestTimings_Public_Static_UInt32_UInt32_Il2CppStructArray_1_FrameTiming_0;

		// Token: 0x04000748 RID: 1864
		private static readonly FrameTimingManager.IsFeatureEnabledDelegate IsFeatureEnabledDelegateField;

		// Token: 0x04000749 RID: 1865
		private static readonly FrameTimingManager.GetVSyncsPerSecondDelegate GetVSyncsPerSecondDelegateField;

		// Token: 0x0400074A RID: 1866
		private static readonly FrameTimingManager.GetGpuTimerFrequencyDelegate GetGpuTimerFrequencyDelegateField;

		// Token: 0x0400074B RID: 1867
		private static readonly FrameTimingManager.GetCpuTimerFrequencyDelegate GetCpuTimerFrequencyDelegateField;

		// Token: 0x0200050D RID: 1293
		// (Invoke) Token: 0x0600332B RID: 13099
		private delegate bool IsFeatureEnabledDelegate();

		// Token: 0x0200050E RID: 1294
		// (Invoke) Token: 0x0600332D RID: 13101
		private delegate float GetVSyncsPerSecondDelegate();

		// Token: 0x0200050F RID: 1295
		// (Invoke) Token: 0x0600332F RID: 13103
		private delegate ulong GetGpuTimerFrequencyDelegate();

		// Token: 0x02000510 RID: 1296
		// (Invoke) Token: 0x06003331 RID: 13105
		private delegate ulong GetCpuTimerFrequencyDelegate();
	}
}
