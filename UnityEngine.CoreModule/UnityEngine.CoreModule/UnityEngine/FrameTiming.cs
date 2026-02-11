using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000095 RID: 149
	[StructLayout(2)]
	public struct FrameTiming
	{
		// Token: 0x0600094C RID: 2380 RVA: 0x0003430C File Offset: 0x0003250C
		// Note: this type is marked as 'beforefieldinit'.
		static FrameTiming()
		{
			Il2CppClassPointerStore<FrameTiming>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "FrameTiming");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr);
			FrameTiming.NativeFieldInfoPtr_cpuFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "cpuFrameTime");
			FrameTiming.NativeFieldInfoPtr_cpuMainThreadFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "cpuMainThreadFrameTime");
			FrameTiming.NativeFieldInfoPtr_cpuMainThreadPresentWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "cpuMainThreadPresentWaitTime");
			FrameTiming.NativeFieldInfoPtr_cpuRenderThreadFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "cpuRenderThreadFrameTime");
			FrameTiming.NativeFieldInfoPtr_gpuFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "gpuFrameTime");
			FrameTiming.NativeFieldInfoPtr_frameStartTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "frameStartTimestamp");
			FrameTiming.NativeFieldInfoPtr_firstSubmitTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "firstSubmitTimestamp");
			FrameTiming.NativeFieldInfoPtr_cpuTimePresentCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "cpuTimePresentCalled");
			FrameTiming.NativeFieldInfoPtr_cpuTimeFrameComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "cpuTimeFrameComplete");
			FrameTiming.NativeFieldInfoPtr_heightScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "heightScale");
			FrameTiming.NativeFieldInfoPtr_widthScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "widthScale");
			FrameTiming.NativeFieldInfoPtr_syncInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "syncInterval");
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00005854 File Offset: 0x00003A54
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, ref this));
		}

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeFieldInfoPtr_cpuFrameTime;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeFieldInfoPtr_cpuMainThreadFrameTime;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeFieldInfoPtr_cpuMainThreadPresentWaitTime;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeFieldInfoPtr_cpuRenderThreadFrameTime;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeFieldInfoPtr_gpuFrameTime;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeFieldInfoPtr_frameStartTimestamp;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeFieldInfoPtr_firstSubmitTimestamp;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeFieldInfoPtr_cpuTimePresentCalled;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeFieldInfoPtr_cpuTimeFrameComplete;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeFieldInfoPtr_heightScale;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeFieldInfoPtr_widthScale;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeFieldInfoPtr_syncInterval;

		// Token: 0x0400073A RID: 1850
		[FieldOffset(0)]
		public double cpuFrameTime;

		// Token: 0x0400073B RID: 1851
		[FieldOffset(8)]
		public double cpuMainThreadFrameTime;

		// Token: 0x0400073C RID: 1852
		[FieldOffset(16)]
		public double cpuMainThreadPresentWaitTime;

		// Token: 0x0400073D RID: 1853
		[FieldOffset(24)]
		public double cpuRenderThreadFrameTime;

		// Token: 0x0400073E RID: 1854
		[FieldOffset(32)]
		public double gpuFrameTime;

		// Token: 0x0400073F RID: 1855
		[FieldOffset(40)]
		public ulong frameStartTimestamp;

		// Token: 0x04000740 RID: 1856
		[FieldOffset(48)]
		public ulong firstSubmitTimestamp;

		// Token: 0x04000741 RID: 1857
		[FieldOffset(56)]
		public ulong cpuTimePresentCalled;

		// Token: 0x04000742 RID: 1858
		[FieldOffset(64)]
		public ulong cpuTimeFrameComplete;

		// Token: 0x04000743 RID: 1859
		[FieldOffset(72)]
		public float heightScale;

		// Token: 0x04000744 RID: 1860
		[FieldOffset(76)]
		public float widthScale;

		// Token: 0x04000745 RID: 1861
		[FieldOffset(80)]
		public uint syncInterval;
	}
}
