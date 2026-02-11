using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Jobs.LowLevel.Unsafe
{
	// Token: 0x02000011 RID: 17
	[StructLayout(2)]
	public struct JobRanges
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00017A48 File Offset: 0x00015C48
		// Note: this type is marked as 'beforefieldinit'.
		static JobRanges()
		{
			Il2CppClassPointerStore<JobRanges>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs.LowLevel.Unsafe", "JobRanges");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobRanges>.NativeClassPtr);
			JobRanges.NativeFieldInfoPtr_BatchSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, "BatchSize");
			JobRanges.NativeFieldInfoPtr_NumJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, "NumJobs");
			JobRanges.NativeFieldInfoPtr_TotalIterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, "TotalIterationCount");
			JobRanges.NativeFieldInfoPtr_StartEndIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, "StartEndIndex");
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002320 File Offset: 0x00000520
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, ref this));
		}

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_BatchSize;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_NumJobs;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_TotalIterationCount;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_StartEndIndex;

		// Token: 0x04000035 RID: 53
		[FieldOffset(0)]
		public int BatchSize;

		// Token: 0x04000036 RID: 54
		[FieldOffset(4)]
		public int NumJobs;

		// Token: 0x04000037 RID: 55
		[FieldOffset(8)]
		public int TotalIterationCount;

		// Token: 0x04000038 RID: 56
		[FieldOffset(16)]
		public IntPtr StartEndIndex;
	}
}
