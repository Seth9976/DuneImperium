using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x0200006C RID: 108
	public class BottleneckHistory : Object
	{
		// Token: 0x06000780 RID: 1920 RVA: 0x00029CB8 File Offset: 0x00027EB8
		// Note: this type is marked as 'beforefieldinit'.
		static BottleneckHistory()
		{
			Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "BottleneckHistory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr);
			BottleneckHistory.NativeFieldInfoPtr_m_Bottlenecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr, "m_Bottlenecks");
			BottleneckHistory.NativeFieldInfoPtr_Histogram = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr, "Histogram");
			BottleneckHistory.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr, 100664498);
			BottleneckHistory.NativeMethodInfoPtr_DiscardOldSamples_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr, 100664499);
			BottleneckHistory.NativeMethodInfoPtr_AddBottleneckFromAveragedSample_Internal_Void_FrameTimeSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr, 100664500);
			BottleneckHistory.NativeMethodInfoPtr_ComputeHistogram_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr, 100664501);
			BottleneckHistory.NativeMethodInfoPtr_DetermineBottleneck_Private_Static_PerformanceBottleneck_FrameTimeSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr, 100664502);
			BottleneckHistory.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr, 100664503);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00029D88 File Offset: 0x00027F88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 964844, RefRangeEnd = 964845, XrefRangeStart = 964832, XrefRangeEnd = 964844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BottleneckHistory(int initialCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BottleneckHistory.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00029DD0 File Offset: 0x00027FD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 964854, RefRangeEnd = 964855, XrefRangeStart = 964845, XrefRangeEnd = 964854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DiscardOldSamples(int historySize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref historySize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BottleneckHistory.NativeMethodInfoPtr_DiscardOldSamples_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00029E10 File Offset: 0x00028010
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 964861, RefRangeEnd = 964862, XrefRangeStart = 964855, XrefRangeEnd = 964861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBottleneckFromAveragedSample(FrameTimeSample frameHistorySampleAverage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref frameHistorySampleAverage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BottleneckHistory.NativeMethodInfoPtr_AddBottleneckFromAveragedSample_Internal_Void_FrameTimeSample_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00029E50 File Offset: 0x00028050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 964870, RefRangeEnd = 964871, XrefRangeStart = 964862, XrefRangeEnd = 964870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ComputeHistogram()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BottleneckHistory.NativeMethodInfoPtr_ComputeHistogram_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00029E84 File Offset: 0x00028084
		[CallerCount(0)]
		public unsafe static PerformanceBottleneck DetermineBottleneck(FrameTimeSample s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref s;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BottleneckHistory.NativeMethodInfoPtr_DetermineBottleneck_Private_Static_PerformanceBottleneck_FrameTimeSample_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00029EC4 File Offset: 0x000280C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 964872, RefRangeEnd = 964873, XrefRangeStart = 964871, XrefRangeEnd = 964872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BottleneckHistory.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00004FDA File Offset: 0x000031DA
		public BottleneckHistory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x00029EF8 File Offset: 0x000280F8
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x00004FE3 File Offset: 0x000031E3
		public unsafe List<PerformanceBottleneck> m_Bottlenecks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BottleneckHistory.NativeFieldInfoPtr_m_Bottlenecks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PerformanceBottleneck>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BottleneckHistory.NativeFieldInfoPtr_m_Bottlenecks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00029F28 File Offset: 0x00028128
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x00005002 File Offset: 0x00003202
		public unsafe BottleneckHistogram Histogram
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BottleneckHistory.NativeFieldInfoPtr_Histogram);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BottleneckHistory.NativeFieldInfoPtr_Histogram)) = value;
			}
		}

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeFieldInfoPtr_m_Bottlenecks;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeFieldInfoPtr_Histogram;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_DiscardOldSamples_Internal_Void_Int32_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_AddBottleneckFromAveragedSample_Internal_Void_FrameTimeSample_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_ComputeHistogram_Internal_Void_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_DetermineBottleneck_Private_Static_PerformanceBottleneck_FrameTimeSample_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;
	}
}
