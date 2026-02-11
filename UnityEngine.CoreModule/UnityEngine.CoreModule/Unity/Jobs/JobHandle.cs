using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Jobs
{
	// Token: 0x0200000F RID: 15
	[StructLayout(2)]
	public struct JobHandle
	{
		// Token: 0x0600003F RID: 63 RVA: 0x000173AC File Offset: 0x000155AC
		// Note: this type is marked as 'beforefieldinit'.
		static JobHandle()
		{
			Il2CppClassPointerStore<JobHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs", "JobHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobHandle>.NativeClassPtr);
			JobHandle.NativeFieldInfoPtr_jobGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, "jobGroup");
			JobHandle.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, "version");
			JobHandle.NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663330);
			JobHandle.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663331);
			JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobs_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663332);
			JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobsAndComplete_Private_Static_Void_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663333);
			JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobsAndIsCompleted_Private_Static_Boolean_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663334);
			JobHandle.NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_JobHandle_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663335);
			JobHandle.NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeArray_1_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663336);
			JobHandle.NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeSlice_1_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663337);
			JobHandle.NativeMethodInfoPtr_CombineDependenciesInternal2_Private_Static_JobHandle_byref_JobHandle_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663338);
			JobHandle.NativeMethodInfoPtr_CombineDependenciesInternalPtr_Internal_Static_JobHandle_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663339);
			JobHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663340);
			JobHandle.NativeMethodInfoPtr_CombineDependenciesInternal2_Injected_Private_Static_Void_byref_JobHandle_byref_JobHandle_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663341);
			JobHandle.NativeMethodInfoPtr_CombineDependenciesInternalPtr_Injected_Private_Static_Void_ptr_Void_Int32_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663342);
			JobHandle.ScheduleBatchedJobsAndCompleteAllDelegateField = IL2CPP.ResolveICall<JobHandle.ScheduleBatchedJobsAndCompleteAllDelegate>("Unity.Jobs.JobHandle::ScheduleBatchedJobsAndCompleteAll");
			JobHandle.CombineDependenciesInternal3_InjectedDelegateField = IL2CPP.ResolveICall<JobHandle.CombineDependenciesInternal3_InjectedDelegate>("Unity.Jobs.JobHandle::CombineDependenciesInternal3_Injected");
			JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegateField = IL2CPP.ResolveICall<JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegate>("Unity.Jobs.JobHandle::CheckFenceIsDependencyOrDidSyncFence_Injected");
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00017538 File Offset: 0x00015738
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 643037, RefRangeEnd = 643068, XrefRangeStart = 643035, XrefRangeEnd = 643037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_Complete_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00017560 File Offset: 0x00015760
		public unsafe bool IsCompleted
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 643070, RefRangeEnd = 643071, XrefRangeStart = 643068, XrefRangeEnd = 643070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00017590 File Offset: 0x00015790
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 643073, RefRangeEnd = 643077, XrefRangeStart = 643071, XrefRangeEnd = 643073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScheduleBatchedJobs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobs_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000175B8 File Offset: 0x000157B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643077, XrefRangeEnd = 643079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScheduleBatchedJobsAndComplete(ref JobHandle job)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &job;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobsAndComplete_Private_Static_Void_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000175EC File Offset: 0x000157EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 643070, RefRangeEnd = 643071, XrefRangeStart = 643070, XrefRangeEnd = 643071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ScheduleBatchedJobsAndIsCompleted(ref JobHandle job)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &job;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobsAndIsCompleted_Private_Static_Boolean_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0001762C File Offset: 0x0001582C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 643081, RefRangeEnd = 643082, XrefRangeStart = 643079, XrefRangeEnd = 643081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle CombineDependencies(JobHandle job0, JobHandle job1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref job0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref job1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_JobHandle_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00017678 File Offset: 0x00015878
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 643087, RefRangeEnd = 643092, XrefRangeStart = 643082, XrefRangeEnd = 643087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle CombineDependencies(Unity.Collections.NativeArray<JobHandle> jobs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(jobs));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeArray_1_JobHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000176C0 File Offset: 0x000158C0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 643100, RefRangeEnd = 643106, XrefRangeStart = 643092, XrefRangeEnd = 643100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle CombineDependencies(Unity.Collections.NativeSlice<JobHandle> jobs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(jobs));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeSlice_1_JobHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00017708 File Offset: 0x00015908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643106, XrefRangeEnd = 643108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &job0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &job1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_CombineDependenciesInternal2_Private_Static_JobHandle_byref_JobHandle_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00017754 File Offset: 0x00015954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643108, XrefRangeEnd = 643110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle CombineDependenciesInternalPtr(void* jobs, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = jobs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_CombineDependenciesInternalPtr_Internal_Static_JobHandle_ptr_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000177A0 File Offset: 0x000159A0
		[CallerCount(0)]
		public unsafe bool Equals(JobHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_JobHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000177E0 File Offset: 0x000159E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643110, XrefRangeEnd = 643112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &job0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &job1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_CombineDependenciesInternal2_Injected_Private_Static_Void_byref_JobHandle_byref_JobHandle_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00017830 File Offset: 0x00015A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643112, XrefRangeEnd = 643114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CombineDependenciesInternalPtr_Injected(void* jobs, int count, out JobHandle ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = jobs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_CombineDependenciesInternalPtr_Injected_Private_Static_Void_ptr_Void_Int32_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002291 File Offset: 0x00000491
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00017880 File Offset: 0x00015A80
		public unsafe static void CompleteAll(ref JobHandle job0, ref JobHandle job1)
		{
			JobHandle* ptr;
			checked
			{
				ptr = stackalloc JobHandle[unchecked((UIntPtr)2) * (UIntPtr)sizeof(JobHandle)];
				*ptr = job0;
			}
			ptr[1] = job1;
			JobHandle.ScheduleBatchedJobsAndCompleteAll((void*)ptr, 2);
			job0 = default(JobHandle);
			job1 = default(JobHandle);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000178D0 File Offset: 0x00015AD0
		public unsafe static void CompleteAll(ref JobHandle job0, ref JobHandle job1, ref JobHandle job2)
		{
			JobHandle* ptr;
			checked
			{
				ptr = stackalloc JobHandle[unchecked((UIntPtr)3) * (UIntPtr)sizeof(JobHandle)];
				*ptr = job0;
			}
			ptr[1] = job1;
			ptr[2] = job2;
			JobHandle.ScheduleBatchedJobsAndCompleteAll((void*)ptr, 3);
			job0 = default(JobHandle);
			job1 = default(JobHandle);
			job2 = default(JobHandle);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000022A3 File Offset: 0x000004A3
		public static void CompleteAll(Unity.Collections.NativeArray<JobHandle> jobs)
		{
			JobHandle.ScheduleBatchedJobsAndCompleteAll(jobs.GetUnsafeReadOnlyPtr<JobHandle>(), jobs.Length);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000022B9 File Offset: 0x000004B9
		public unsafe static void ScheduleBatchedJobsAndCompleteAll(void* jobs, int count)
		{
			JobHandle.ScheduleBatchedJobsAndCompleteAllDelegateField(jobs, count);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0001793C File Offset: 0x00015B3C
		public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1, JobHandle job2)
		{
			return JobHandle.CombineDependenciesInternal3(ref job0, ref job1, ref job2);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0001795C File Offset: 0x00015B5C
		public static JobHandle CombineDependenciesInternal3(ref JobHandle job0, ref JobHandle job1, ref JobHandle job2)
		{
			JobHandle jobHandle;
			JobHandle.CombineDependenciesInternal3_Injected(ref job0, ref job1, ref job2, out jobHandle);
			return jobHandle;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000022C7 File Offset: 0x000004C7
		public static bool CheckFenceIsDependencyOrDidSyncFence(JobHandle jobHandle, JobHandle dependsOn)
		{
			return JobHandle.CheckFenceIsDependencyOrDidSyncFence_Injected(ref jobHandle, ref dependsOn);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000022D2 File Offset: 0x000004D2
		public static void CombineDependenciesInternal3_Injected(ref JobHandle job0, ref JobHandle job1, ref JobHandle job2, out JobHandle ret)
		{
			JobHandle.CombineDependenciesInternal3_InjectedDelegateField(ref job0, ref job1, ref job2, out ret);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000022E2 File Offset: 0x000004E2
		public static bool CheckFenceIsDependencyOrDidSyncFence_Injected(ref JobHandle jobHandle, ref JobHandle dependsOn)
		{
			return JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegateField(ref jobHandle, ref dependsOn);
		}

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_jobGroup;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleBatchedJobs_Public_Static_Void_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleBatchedJobsAndComplete_Private_Static_Void_byref_JobHandle_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleBatchedJobsAndIsCompleted_Private_Static_Boolean_byref_JobHandle_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_JobHandle_JobHandle_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeArray_1_JobHandle_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeSlice_1_JobHandle_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_CombineDependenciesInternal2_Private_Static_JobHandle_byref_JobHandle_byref_JobHandle_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_CombineDependenciesInternalPtr_Internal_Static_JobHandle_ptr_Void_Int32_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_JobHandle_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_CombineDependenciesInternal2_Injected_Private_Static_Void_byref_JobHandle_byref_JobHandle_byref_JobHandle_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_CombineDependenciesInternalPtr_Injected_Private_Static_Void_ptr_Void_Int32_byref_JobHandle_0;

		// Token: 0x0400002A RID: 42
		[FieldOffset(0)]
		public ulong jobGroup;

		// Token: 0x0400002B RID: 43
		[FieldOffset(8)]
		public int version;

		// Token: 0x0400002C RID: 44
		private static readonly JobHandle.ScheduleBatchedJobsAndCompleteAllDelegate ScheduleBatchedJobsAndCompleteAllDelegateField;

		// Token: 0x0400002D RID: 45
		private static readonly JobHandle.CombineDependenciesInternal3_InjectedDelegate CombineDependenciesInternal3_InjectedDelegateField;

		// Token: 0x0400002E RID: 46
		private static readonly JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegate CheckFenceIsDependencyOrDidSyncFence_InjectedDelegateField;

		// Token: 0x02000382 RID: 898
		// (Invoke) Token: 0x06002FDC RID: 12252
		private delegate void ScheduleBatchedJobsAndCompleteAllDelegate(IntPtr jobs, int count);

		// Token: 0x02000383 RID: 899
		// (Invoke) Token: 0x06002FDE RID: 12254
		private delegate void CombineDependenciesInternal3_InjectedDelegate(IntPtr job0, IntPtr job1, IntPtr job2, [Out] IntPtr ret);

		// Token: 0x02000384 RID: 900
		// (Invoke) Token: 0x06002FE0 RID: 12256
		private delegate bool CheckFenceIsDependencyOrDidSyncFence_InjectedDelegate(IntPtr jobHandle, IntPtr dependsOn);
	}
}
