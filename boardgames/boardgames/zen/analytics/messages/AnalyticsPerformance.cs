using System;
using boardgames.analytics;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace zen.analytics.messages
{
	// Token: 0x02000095 RID: 149
	public class AnalyticsPerformance : ClientAnalyticsMessage
	{
		// Token: 0x06000740 RID: 1856 RVA: 0x000053B6 File Offset: 0x000035B6
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsPerformance()
		{
			Il2CppClassPointerStore<AnalyticsPerformance>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.analytics.messages", "AnalyticsPerformance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsPerformance>.NativeClassPtr);
			AnalyticsPerformance.NativeMethodInfoPtr__ctor_Protected_Void_AveragedPerformanceMetric_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsPerformance>.NativeClassPtr, 100664471);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00027D70 File Offset: 0x00025F70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 990639, RefRangeEnd = 990641, XrefRangeStart = 990538, XrefRangeEnd = 990639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsPerformance(AveragedPerformanceMetric frameRateMetrics, string eventName = "analyticsPerformance")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsPerformance>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frameRateMetrics);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsPerformance.NativeMethodInfoPtr__ctor_Protected_Void_AveragedPerformanceMetric_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000053EF File Offset: 0x000035EF
		public AnalyticsPerformance(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_AveragedPerformanceMetric_String_0;
	}
}
