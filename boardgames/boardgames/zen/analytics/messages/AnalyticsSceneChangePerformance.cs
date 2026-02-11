using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace zen.analytics.messages
{
	// Token: 0x02000097 RID: 151
	public class AnalyticsSceneChangePerformance : AnalyticsPerformance
	{
		// Token: 0x06000746 RID: 1862 RVA: 0x0000543A File Offset: 0x0000363A
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsSceneChangePerformance()
		{
			Il2CppClassPointerStore<AnalyticsSceneChangePerformance>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.analytics.messages", "AnalyticsSceneChangePerformance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsSceneChangePerformance>.NativeClassPtr);
			AnalyticsSceneChangePerformance.NativeMethodInfoPtr__ctor_Public_Void_AveragedPerformanceMetric_String_String_Single_Single_Single_Single_AnalyticsSceneChangeStart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSceneChangePerformance>.NativeClassPtr, 100664473);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00027E58 File Offset: 0x00026058
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 990724, RefRangeEnd = 990725, XrefRangeStart = 990668, XrefRangeEnd = 990724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsSceneChangePerformance(AveragedPerformanceMetric frameRateMetrics, string leavingScene, string enteringScene, float preLoadMemory, float preUnloadMemory, float postUnloadMemory, float postLoadMemory, AnalyticsSceneChangeStart sceneChangeStart)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsSceneChangePerformance>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frameRateMetrics);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(leavingScene);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(enteringScene);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preLoadMemory;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preUnloadMemory;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref postUnloadMemory;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref postLoadMemory;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sceneChangeStart);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSceneChangePerformance.NativeMethodInfoPtr__ctor_Public_Void_AveragedPerformanceMetric_String_String_Single_Single_Single_Single_AnalyticsSceneChangeStart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00005473 File Offset: 0x00003673
		public AnalyticsSceneChangePerformance(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AveragedPerformanceMetric_String_String_Single_Single_Single_Single_AnalyticsSceneChangeStart_0;
	}
}
