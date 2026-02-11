using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x020002A0 RID: 672
	public static class AsyncReadManagerMetrics
	{
		// Token: 0x06002C8C RID: 11404 RVA: 0x0001154B File Offset: 0x0000F74B
		public static bool IsEnabled()
		{
			return AsyncReadManagerMetrics.IsEnabledDelegateField();
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x00011557 File Offset: 0x0000F757
		public static void ClearMetrics_Internal()
		{
			AsyncReadManagerMetrics.ClearMetrics_InternalDelegateField();
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x00011563 File Offset: 0x0000F763
		public static void ClearCompletedMetrics()
		{
			AsyncReadManagerMetrics.ClearMetrics_Internal();
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x000B28D8 File Offset: 0x000B0AD8
		public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics_Internal(bool clear)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetMetrics_InternalDelegateField(clear);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AsyncReadManagerRequestMetric>>(intPtr2) : null;
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x0001156C File Offset: 0x0000F76C
		public static void GetMetrics_NoAlloc_Internal(List<AsyncReadManagerRequestMetric> metrics, bool clear)
		{
			AsyncReadManagerMetrics.GetMetrics_NoAlloc_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics), clear);
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x000B2900 File Offset: 0x000B0B00
		public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics_Filtered_Internal(AsyncReadManagerMetricsFilters filters, bool clear)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetMetrics_Filtered_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(filters), clear);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AsyncReadManagerRequestMetric>>(intPtr2) : null;
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x0001157F File Offset: 0x0000F77F
		public static void GetMetrics_NoAlloc_Filtered_Internal(List<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters filters, bool clear)
		{
			AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics), IL2CPP.Il2CppObjectBaseToPtr(filters), clear);
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x000B2930 File Offset: 0x000B0B30
		public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics(AsyncReadManagerMetricsFilters filters, AsyncReadManagerMetrics.Flags flags)
		{
			bool flag = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			return AsyncReadManagerMetrics.GetMetrics_Filtered_Internal(filters, flag);
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x000B2954 File Offset: 0x000B0B54
		public static void GetMetrics(List<AsyncReadManagerRequestMetric> outMetrics, AsyncReadManagerMetricsFilters filters, AsyncReadManagerMetrics.Flags flags)
		{
			bool flag = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_Internal(outMetrics, filters, flag);
		}

		// Token: 0x06002C95 RID: 11413 RVA: 0x000B2978 File Offset: 0x000B0B78
		public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics(AsyncReadManagerMetrics.Flags flags)
		{
			bool flag = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			return AsyncReadManagerMetrics.GetMetrics_Internal(flag);
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x000B299C File Offset: 0x000B0B9C
		public static void GetMetrics(List<AsyncReadManagerRequestMetric> outMetrics, AsyncReadManagerMetrics.Flags flags)
		{
			bool flag = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			AsyncReadManagerMetrics.GetMetrics_NoAlloc_Internal(outMetrics, flag);
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x00011598 File Offset: 0x0000F798
		public static void StartCollectingMetrics()
		{
			AsyncReadManagerMetrics.StartCollectingMetricsDelegateField();
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x000115A4 File Offset: 0x0000F7A4
		public static void StopCollectingMetrics()
		{
			AsyncReadManagerMetrics.StopCollectingMetricsDelegateField();
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x000B29C0 File Offset: 0x000B0BC0
		public static AsyncReadManagerSummaryMetrics GetSummaryMetrics_Internal(bool clear)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryMetrics_InternalDelegateField(clear);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x000B29E8 File Offset: 0x000B0BE8
		public static AsyncReadManagerSummaryMetrics GetCurrentSummaryMetrics(AsyncReadManagerMetrics.Flags flags)
		{
			bool flag = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			return AsyncReadManagerMetrics.GetSummaryMetrics_Internal(flag);
		}

		// Token: 0x06002C9B RID: 11419 RVA: 0x000B2A0C File Offset: 0x000B0C0C
		public static AsyncReadManagerSummaryMetrics GetSummaryMetricsWithFilters_Internal(AsyncReadManagerMetricsFilters metricsFilters, bool clear)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metricsFilters), clear);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x000B2A3C File Offset: 0x000B0C3C
		public static AsyncReadManagerSummaryMetrics GetCurrentSummaryMetrics(AsyncReadManagerMetricsFilters metricsFilters, AsyncReadManagerMetrics.Flags flags)
		{
			bool flag = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			return AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_Internal(metricsFilters, flag);
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x000B2A60 File Offset: 0x000B0C60
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics_Internal(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryOfMetrics_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x000B2A8C File Offset: 0x000B0C8C
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics)
		{
			return AsyncReadManagerMetrics.GetSummaryOfMetrics_Internal(metrics);
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x000B2AA4 File Offset: 0x000B0CA4
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics_FromContainer_Internal(List<AsyncReadManagerRequestMetric> metrics)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x000B2AD0 File Offset: 0x000B0CD0
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(List<AsyncReadManagerRequestMetric> metrics)
		{
			return AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_Internal(metrics);
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x000B2AE8 File Offset: 0x000B0CE8
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetricsWithFilters_Internal(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics), IL2CPP.Il2CppObjectBaseToPtr(metricsFilters));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x000B2B1C File Offset: 0x000B0D1C
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
		{
			return AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_Internal(metrics, metricsFilters);
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x000B2B38 File Offset: 0x000B0D38
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetricsWithFilters_FromContainer_Internal(List<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics), IL2CPP.Il2CppObjectBaseToPtr(metricsFilters));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x000B2B6C File Offset: 0x000B0D6C
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(List<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
		{
			return AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_Internal(metrics, metricsFilters);
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x000115B0 File Offset: 0x0000F7B0
		public static ulong GetTotalSizeOfNonASRMReadsBytes(bool emptyAfterRead)
		{
			return AsyncReadManagerMetrics.GetTotalSizeOfNonASRMReadsBytesDelegateField(emptyAfterRead);
		}

		// Token: 0x040027FD RID: 10237
		private static readonly AsyncReadManagerMetrics.IsEnabledDelegate IsEnabledDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.IsEnabledDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::IsEnabled");

		// Token: 0x040027FE RID: 10238
		private static readonly AsyncReadManagerMetrics.ClearMetrics_InternalDelegate ClearMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.ClearMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::ClearMetrics_Internal");

		// Token: 0x040027FF RID: 10239
		private static readonly AsyncReadManagerMetrics.GetMetrics_InternalDelegate GetMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_Internal");

		// Token: 0x04002800 RID: 10240
		private static readonly AsyncReadManagerMetrics.GetMetrics_NoAlloc_InternalDelegate GetMetrics_NoAlloc_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_NoAlloc_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_NoAlloc_Internal");

		// Token: 0x04002801 RID: 10241
		private static readonly AsyncReadManagerMetrics.GetMetrics_Filtered_InternalDelegate GetMetrics_Filtered_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_Filtered_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_Filtered_Internal");

		// Token: 0x04002802 RID: 10242
		private static readonly AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_InternalDelegate GetMetrics_NoAlloc_Filtered_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_NoAlloc_Filtered_Internal");

		// Token: 0x04002803 RID: 10243
		private static readonly AsyncReadManagerMetrics.StartCollectingMetricsDelegate StartCollectingMetricsDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.StartCollectingMetricsDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::StartCollectingMetrics");

		// Token: 0x04002804 RID: 10244
		private static readonly AsyncReadManagerMetrics.StopCollectingMetricsDelegate StopCollectingMetricsDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.StopCollectingMetricsDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::StopCollectingMetrics");

		// Token: 0x04002805 RID: 10245
		private static readonly AsyncReadManagerMetrics.GetSummaryMetrics_InternalDelegate GetSummaryMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryMetrics_Internal");

		// Token: 0x04002806 RID: 10246
		private static readonly AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_InternalDelegate GetSummaryMetricsWithFilters_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryMetricsWithFilters_Internal");

		// Token: 0x04002807 RID: 10247
		private static readonly AsyncReadManagerMetrics.GetSummaryOfMetrics_InternalDelegate GetSummaryOfMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetrics_Internal");

		// Token: 0x04002808 RID: 10248
		private static readonly AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_InternalDelegate GetSummaryOfMetrics_FromContainer_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetrics_FromContainer_Internal");

		// Token: 0x04002809 RID: 10249
		private static readonly AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_InternalDelegate GetSummaryOfMetricsWithFilters_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetricsWithFilters_Internal");

		// Token: 0x0400280A RID: 10250
		private static readonly AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegate GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetricsWithFilters_FromContainer_Internal");

		// Token: 0x0400280B RID: 10251
		private static readonly AsyncReadManagerMetrics.GetTotalSizeOfNonASRMReadsBytesDelegate GetTotalSizeOfNonASRMReadsBytesDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetTotalSizeOfNonASRMReadsBytesDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetTotalSizeOfNonASRMReadsBytes");

		// Token: 0x02000AD0 RID: 2768
		public enum Flags
		{
			// Token: 0x04002DAE RID: 11694
			None,
			// Token: 0x04002DAF RID: 11695
			ClearOnRead
		}

		// Token: 0x02000AD1 RID: 2769
		// (Invoke) Token: 0x06003E99 RID: 16025
		private delegate bool IsEnabledDelegate();

		// Token: 0x02000AD2 RID: 2770
		// (Invoke) Token: 0x06003E9B RID: 16027
		private delegate void ClearMetrics_InternalDelegate();

		// Token: 0x02000AD3 RID: 2771
		// (Invoke) Token: 0x06003E9D RID: 16029
		private delegate IntPtr GetMetrics_InternalDelegate(bool clear);

		// Token: 0x02000AD4 RID: 2772
		// (Invoke) Token: 0x06003E9F RID: 16031
		private delegate void GetMetrics_NoAlloc_InternalDelegate(IntPtr metrics, bool clear);

		// Token: 0x02000AD5 RID: 2773
		// (Invoke) Token: 0x06003EA1 RID: 16033
		private delegate IntPtr GetMetrics_Filtered_InternalDelegate(IntPtr filters, bool clear);

		// Token: 0x02000AD6 RID: 2774
		// (Invoke) Token: 0x06003EA3 RID: 16035
		private delegate void GetMetrics_NoAlloc_Filtered_InternalDelegate(IntPtr metrics, IntPtr filters, bool clear);

		// Token: 0x02000AD7 RID: 2775
		// (Invoke) Token: 0x06003EA5 RID: 16037
		private delegate void StartCollectingMetricsDelegate();

		// Token: 0x02000AD8 RID: 2776
		// (Invoke) Token: 0x06003EA7 RID: 16039
		private delegate void StopCollectingMetricsDelegate();

		// Token: 0x02000AD9 RID: 2777
		// (Invoke) Token: 0x06003EA9 RID: 16041
		private delegate IntPtr GetSummaryMetrics_InternalDelegate(bool clear);

		// Token: 0x02000ADA RID: 2778
		// (Invoke) Token: 0x06003EAB RID: 16043
		private delegate IntPtr GetSummaryMetricsWithFilters_InternalDelegate(IntPtr metricsFilters, bool clear);

		// Token: 0x02000ADB RID: 2779
		// (Invoke) Token: 0x06003EAD RID: 16045
		private delegate IntPtr GetSummaryOfMetrics_InternalDelegate(IntPtr metrics);

		// Token: 0x02000ADC RID: 2780
		// (Invoke) Token: 0x06003EAF RID: 16047
		private delegate IntPtr GetSummaryOfMetrics_FromContainer_InternalDelegate(IntPtr metrics);

		// Token: 0x02000ADD RID: 2781
		// (Invoke) Token: 0x06003EB1 RID: 16049
		private delegate IntPtr GetSummaryOfMetricsWithFilters_InternalDelegate(IntPtr metrics, IntPtr metricsFilters);

		// Token: 0x02000ADE RID: 2782
		// (Invoke) Token: 0x06003EB3 RID: 16051
		private delegate IntPtr GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegate(IntPtr metrics, IntPtr metricsFilters);

		// Token: 0x02000ADF RID: 2783
		// (Invoke) Token: 0x06003EB5 RID: 16053
		private delegate ulong GetTotalSizeOfNonASRMReadsBytesDelegate(bool emptyAfterRead);
	}
}
