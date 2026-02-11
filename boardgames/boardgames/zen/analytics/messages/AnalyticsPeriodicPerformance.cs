using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace zen.analytics.messages
{
	// Token: 0x02000096 RID: 150
	public class AnalyticsPeriodicPerformance : AnalyticsPerformance
	{
		// Token: 0x06000743 RID: 1859 RVA: 0x000053F8 File Offset: 0x000035F8
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsPeriodicPerformance()
		{
			Il2CppClassPointerStore<AnalyticsPeriodicPerformance>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.analytics.messages", "AnalyticsPeriodicPerformance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsPeriodicPerformance>.NativeClassPtr);
			AnalyticsPeriodicPerformance.NativeMethodInfoPtr__ctor_Public_Void_AveragedPerformanceMetric_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsPeriodicPerformance>.NativeClassPtr, 100664472);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00027DD0 File Offset: 0x00025FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990641, XrefRangeEnd = 990668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsPeriodicPerformance(AveragedPerformanceMetric frameRateMetrics, string currentScene, float lowMemory, float highMemory, float timeScale)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsPeriodicPerformance>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frameRateMetrics);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currentScene);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowMemory;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highMemory;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsPeriodicPerformance.NativeMethodInfoPtr__ctor_Public_Void_AveragedPerformanceMetric_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00005431 File Offset: 0x00003631
		public AnalyticsPeriodicPerformance(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AveragedPerformanceMetric_String_Single_Single_Single_0;
	}
}
