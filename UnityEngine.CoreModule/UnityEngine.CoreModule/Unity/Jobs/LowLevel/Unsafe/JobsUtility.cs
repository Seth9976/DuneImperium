using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Jobs.LowLevel.Unsafe
{
	// Token: 0x02000013 RID: 19
	public static class JobsUtility : Object
	{
		// Token: 0x0600005F RID: 95 RVA: 0x00017AC8 File Offset: 0x00015CC8
		// Note: this type is marked as 'beforefieldinit'.
		static JobsUtility()
		{
			Il2CppClassPointerStore<JobsUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs.LowLevel.Unsafe", "JobsUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr);
			JobsUtility.NativeFieldInfoPtr_PanicFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, "PanicFunction");
			JobsUtility.NativeMethodInfoPtr_GetJobRange_Public_Static_Void_byref_JobRanges_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663344);
			JobsUtility.NativeMethodInfoPtr_GetWorkStealingRange_Public_Static_Boolean_byref_JobRanges_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663345);
			JobsUtility.NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_byref_JobScheduleParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663346);
			JobsUtility.NativeMethodInfoPtr_ScheduleParallelFor_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663347);
			JobsUtility.NativeMethodInfoPtr_ScheduleParallelForTransform_Public_Static_JobHandle_byref_JobScheduleParameters_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663348);
			JobsUtility.NativeMethodInfoPtr_CreateJobReflectionData_Private_Static_IntPtr_Type_Type_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663349);
			JobsUtility.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_IntPtr_Type_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663350);
			JobsUtility.NativeMethodInfoPtr_set_JobCompilerEnabled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663351);
			JobsUtility.NativeMethodInfoPtr_InvokePanicFunction_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663352);
			JobsUtility.NativeMethodInfoPtr_Schedule_Injected_Private_Static_Void_byref_JobScheduleParameters_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663353);
			JobsUtility.NativeMethodInfoPtr_ScheduleParallelFor_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_Int32_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663354);
			JobsUtility.NativeMethodInfoPtr_ScheduleParallelForTransform_Injected_Private_Static_Void_byref_JobScheduleParameters_IntPtr_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663355);
			JobsUtility.PatchBufferMinMaxRangesDelegateField = IL2CPP.ResolveICall<JobsUtility.PatchBufferMinMaxRangesDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::PatchBufferMinMaxRanges");
			JobsUtility.get_IsExecutingJobDelegateField = IL2CPP.ResolveICall<JobsUtility.get_IsExecutingJobDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_IsExecutingJob");
			JobsUtility.get_JobDebuggerEnabledDelegateField = IL2CPP.ResolveICall<JobsUtility.get_JobDebuggerEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobDebuggerEnabled");
			JobsUtility.set_JobDebuggerEnabledDelegateField = IL2CPP.ResolveICall<JobsUtility.set_JobDebuggerEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::set_JobDebuggerEnabled");
			JobsUtility.get_JobCompilerEnabledDelegateField = IL2CPP.ResolveICall<JobsUtility.get_JobCompilerEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobCompilerEnabled");
			JobsUtility.GetJobQueueWorkerThreadCountDelegateField = IL2CPP.ResolveICall<JobsUtility.GetJobQueueWorkerThreadCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetJobQueueWorkerThreadCount");
			JobsUtility.SetJobQueueMaximumActiveThreadCountDelegateField = IL2CPP.ResolveICall<JobsUtility.SetJobQueueMaximumActiveThreadCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::SetJobQueueMaximumActiveThreadCount");
			JobsUtility.get_JobWorkerMaximumCountDelegateField = IL2CPP.ResolveICall<JobsUtility.get_JobWorkerMaximumCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobWorkerMaximumCount");
			JobsUtility.ResetJobWorkerCountDelegateField = IL2CPP.ResolveICall<JobsUtility.ResetJobWorkerCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ResetJobWorkerCount");
			JobsUtility.get_ThreadIndexDelegateField = IL2CPP.ResolveICall<JobsUtility.get_ThreadIndexDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_ThreadIndex");
			JobsUtility.get_ThreadIndexCountDelegateField = IL2CPP.ResolveICall<JobsUtility.get_ThreadIndexCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_ThreadIndexCount");
			JobsUtility.GetJobBatchingEnabledDelegateField = IL2CPP.ResolveICall<JobsUtility.GetJobBatchingEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetJobBatchingEnabled");
			JobsUtility.GetSystemIdCellPtrDelegateField = IL2CPP.ResolveICall<JobsUtility.GetSystemIdCellPtrDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetSystemIdCellPtr");
			JobsUtility.ClearSystemIdsDelegateField = IL2CPP.ResolveICall<JobsUtility.ClearSystemIdsDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ClearSystemIds");
			JobsUtility.GetSystemIdMappingsDelegateField = IL2CPP.ResolveICall<JobsUtility.GetSystemIdMappingsDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetSystemIdMappings");
			JobsUtility.ScheduleParallelForDeferArraySize_InjectedDelegateField = IL2CPP.ResolveICall<JobsUtility.ScheduleParallelForDeferArraySize_InjectedDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ScheduleParallelForDeferArraySize_Injected");
			JobsUtility.ScheduleParallelForTransformReadOnly_InjectedDelegateField = IL2CPP.ResolveICall<JobsUtility.ScheduleParallelForTransformReadOnly_InjectedDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ScheduleParallelForTransformReadOnly_Injected");
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00017CFC File Offset: 0x00015EFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 643120, RefRangeEnd = 643121, XrefRangeStart = 643119, XrefRangeEnd = 643120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetJobRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ranges;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &beginIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &endIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_GetJobRange_Public_Static_Void_byref_JobRanges_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00017D58 File Offset: 0x00015F58
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 643123, RefRangeEnd = 643131, XrefRangeStart = 643121, XrefRangeEnd = 643123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ranges;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &beginIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &endIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_GetWorkStealingRange_Public_Static_Boolean_byref_JobRanges_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00017DC0 File Offset: 0x00015FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 643133, RefRangeEnd = 643134, XrefRangeStart = 643131, XrefRangeEnd = 643133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle Schedule(ref JobsUtility.JobScheduleParameters parameters)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &parameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_byref_JobScheduleParameters_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00017E00 File Offset: 0x00016000
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 643136, RefRangeEnd = 643138, XrefRangeStart = 643134, XrefRangeEnd = 643136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle ScheduleParallelFor(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &parameters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref innerloopBatchCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_ScheduleParallelFor_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00017E5C File Offset: 0x0001605C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 643140, RefRangeEnd = 643141, XrefRangeStart = 643138, XrefRangeEnd = 643140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle ScheduleParallelForTransform(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &parameters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transfromAccesssArray;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_ScheduleParallelForTransform_Public_Static_JobHandle_byref_JobScheduleParameters_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00017EA8 File Offset: 0x000160A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643141, XrefRangeEnd = 643143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, Object managedJobFunction0, Object managedJobFunction1, Object managedJobFunction2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wrapperJobType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userJobType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction1);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_CreateJobReflectionData_Private_Static_IntPtr_Type_Type_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00017F34 File Offset: 0x00016134
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 643145, RefRangeEnd = 643149, XrefRangeStart = 643143, XrefRangeEnd = 643145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateJobReflectionData(Type type, Object managedJobFunction0, Object managedJobFunction1 = null, Object managedJobFunction2 = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_IntPtr_Type_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002382 File Offset: 0x00000582
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00017FAC File Offset: 0x000161AC
		public unsafe static bool JobCompilerEnabled
		{
			get
			{
				return JobsUtility.get_JobCompilerEnabledDelegateField();
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 643151, RefRangeEnd = 643156, XrefRangeStart = 643149, XrefRangeEnd = 643151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_set_JobCompilerEnabled_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00017FE0 File Offset: 0x000161E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643156, XrefRangeEnd = 643158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokePanicFunction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_InvokePanicFunction_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00018008 File Offset: 0x00016208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643158, XrefRangeEnd = 643160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Schedule_Injected(ref JobsUtility.JobScheduleParameters parameters, out JobHandle ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &parameters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_Schedule_Injected_Private_Static_Void_byref_JobScheduleParameters_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00018048 File Offset: 0x00016248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643160, XrefRangeEnd = 643162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScheduleParallelFor_Injected(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &parameters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref innerloopBatchCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_ScheduleParallelFor_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_Int32_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000180A4 File Offset: 0x000162A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643162, XrefRangeEnd = 643164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScheduleParallelForTransform_Injected(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray, out JobHandle ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &parameters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transfromAccesssArray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_ScheduleParallelForTransform_Injected_Private_Static_Void_byref_JobScheduleParameters_IntPtr_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002332 File Offset: 0x00000532
		public JobsUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600006D RID: 109 RVA: 0x000180F4 File Offset: 0x000162F4
		// (set) Token: 0x0600006E RID: 110 RVA: 0x0000233B File Offset: 0x0000053B
		public unsafe static JobsUtility.PanicFunction_ PanicFunction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JobsUtility.NativeFieldInfoPtr_PanicFunction, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JobsUtility.PanicFunction_>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JobsUtility.NativeFieldInfoPtr_PanicFunction, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0001811C File Offset: 0x0001631C
		public unsafe static JobHandle ScheduleParallelForDeferArraySize(ref JobsUtility.JobScheduleParameters parameters, int innerloopBatchCount, void* listData, void* listDataAtomicSafetyHandle)
		{
			JobHandle jobHandle;
			JobsUtility.ScheduleParallelForDeferArraySize_Injected(ref parameters, innerloopBatchCount, listData, listDataAtomicSafetyHandle, out jobHandle);
			return jobHandle;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00018138 File Offset: 0x00016338
		public static JobHandle ScheduleParallelForTransformReadOnly(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray, int innerloopBatchCount)
		{
			JobHandle jobHandle;
			JobsUtility.ScheduleParallelForTransformReadOnly_Injected(ref parameters, transfromAccesssArray, innerloopBatchCount, out jobHandle);
			return jobHandle;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000234D File Offset: 0x0000054D
		public unsafe static void PatchBufferMinMaxRanges(IntPtr bufferRangePatchData, void* jobdata, int startIndex, int rangeSize)
		{
			JobsUtility.PatchBufferMinMaxRangesDelegateField(bufferRangePatchData, jobdata, startIndex, rangeSize);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00018150 File Offset: 0x00016350
		public static IntPtr CreateJobReflectionData(Type type, JobType jobType, Object managedJobFunction0, [Optional] Object managedJobFunction1, [Optional] Object managedJobFunction2)
		{
			return JobsUtility.CreateJobReflectionData(type, type, managedJobFunction0, managedJobFunction1, managedJobFunction2);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00018170 File Offset: 0x00016370
		public static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, JobType jobType, Object managedJobFunction0)
		{
			return JobsUtility.CreateJobReflectionData(wrapperJobType, userJobType, managedJobFunction0, null, null);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0001818C File Offset: 0x0001638C
		public static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, Object managedJobFunction0)
		{
			return JobsUtility.CreateJobReflectionData(wrapperJobType, userJobType, managedJobFunction0, null, null);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000235D File Offset: 0x0000055D
		public static bool IsExecutingJob
		{
			get
			{
				return JobsUtility.get_IsExecutingJobDelegateField();
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002369 File Offset: 0x00000569
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002375 File Offset: 0x00000575
		public static bool JobDebuggerEnabled
		{
			get
			{
				return JobsUtility.get_JobDebuggerEnabledDelegateField();
			}
			set
			{
				JobsUtility.set_JobDebuggerEnabledDelegateField(value);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000238E File Offset: 0x0000058E
		public static int GetJobQueueWorkerThreadCount()
		{
			return JobsUtility.GetJobQueueWorkerThreadCountDelegateField();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000239A File Offset: 0x0000059A
		public static void SetJobQueueMaximumActiveThreadCount(int count)
		{
			JobsUtility.SetJobQueueMaximumActiveThreadCountDelegateField(count);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000023A7 File Offset: 0x000005A7
		public static int JobWorkerMaximumCount
		{
			get
			{
				return JobsUtility.get_JobWorkerMaximumCountDelegateField();
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000023B3 File Offset: 0x000005B3
		public static void ResetJobWorkerCount()
		{
			JobsUtility.ResetJobWorkerCountDelegateField();
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000181A8 File Offset: 0x000163A8
		// (set) Token: 0x0600007E RID: 126 RVA: 0x000181C0 File Offset: 0x000163C0
		public static int JobWorkerCount
		{
			get
			{
				return JobsUtility.GetJobQueueWorkerThreadCount();
			}
			set
			{
				bool flag = value < 0 || value > JobsUtility.JobWorkerMaximumCount;
				if (flag)
				{
					throw new ArgumentOutOfRangeException("JobWorkerCount", String.Format("Invalid JobWorkerCount {0} must be in the range 0 -> {1}", value, JobsUtility.JobWorkerMaximumCount));
				}
				JobsUtility.SetJobQueueMaximumActiveThreadCount(value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000023BF File Offset: 0x000005BF
		public static int ThreadIndex
		{
			get
			{
				return JobsUtility.get_ThreadIndexDelegateField();
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000023CB File Offset: 0x000005CB
		public static int ThreadIndexCount
		{
			get
			{
				return JobsUtility.get_ThreadIndexCountDelegateField();
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000023D7 File Offset: 0x000005D7
		public static bool GetJobBatchingEnabled()
		{
			return JobsUtility.GetJobBatchingEnabledDelegateField();
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000023E3 File Offset: 0x000005E3
		public static bool JobBatchingEnabled
		{
			get
			{
				return JobsUtility.GetJobBatchingEnabled();
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000023EA File Offset: 0x000005EA
		public static IntPtr GetSystemIdCellPtr()
		{
			return JobsUtility.GetSystemIdCellPtrDelegateField();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000023F6 File Offset: 0x000005F6
		public static void ClearSystemIds()
		{
			JobsUtility.ClearSystemIdsDelegateField();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002402 File Offset: 0x00000602
		public unsafe static int GetSystemIdMappings(JobHandle* handles, int* systemIds, int maxCount)
		{
			return JobsUtility.GetSystemIdMappingsDelegateField(handles, systemIds, maxCount);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002411 File Offset: 0x00000611
		public unsafe static void ScheduleParallelForDeferArraySize_Injected(ref JobsUtility.JobScheduleParameters parameters, int innerloopBatchCount, void* listData, void* listDataAtomicSafetyHandle, out JobHandle ret)
		{
			JobsUtility.ScheduleParallelForDeferArraySize_InjectedDelegateField(ref parameters, innerloopBatchCount, listData, listDataAtomicSafetyHandle, out ret);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002423 File Offset: 0x00000623
		public static void ScheduleParallelForTransformReadOnly_Injected(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray, int innerloopBatchCount, out JobHandle ret)
		{
			JobsUtility.ScheduleParallelForTransformReadOnly_InjectedDelegateField(ref parameters, transfromAccesssArray, innerloopBatchCount, out ret);
		}

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_PanicFunction;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_GetJobRange_Public_Static_Void_byref_JobRanges_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_GetWorkStealingRange_Public_Static_Boolean_byref_JobRanges_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_byref_JobScheduleParameters_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleParallelFor_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_Int32_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleParallelForTransform_Public_Static_JobHandle_byref_JobScheduleParameters_IntPtr_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Private_Static_IntPtr_Type_Type_Object_Object_Object_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_IntPtr_Type_Object_Object_Object_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_set_JobCompilerEnabled_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_InvokePanicFunction_Private_Static_Void_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Injected_Private_Static_Void_byref_JobScheduleParameters_byref_JobHandle_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleParallelFor_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_Int32_byref_JobHandle_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleParallelForTransform_Injected_Private_Static_Void_byref_JobScheduleParameters_IntPtr_byref_JobHandle_0;

		// Token: 0x0400004B RID: 75
		public const int MaxJobThreadCount = 128;

		// Token: 0x0400004C RID: 76
		public const int CacheLineSize = 64;

		// Token: 0x0400004D RID: 77
		private static readonly JobsUtility.PatchBufferMinMaxRangesDelegate PatchBufferMinMaxRangesDelegateField;

		// Token: 0x0400004E RID: 78
		private static readonly JobsUtility.get_IsExecutingJobDelegate get_IsExecutingJobDelegateField;

		// Token: 0x0400004F RID: 79
		private static readonly JobsUtility.get_JobDebuggerEnabledDelegate get_JobDebuggerEnabledDelegateField;

		// Token: 0x04000050 RID: 80
		private static readonly JobsUtility.set_JobDebuggerEnabledDelegate set_JobDebuggerEnabledDelegateField;

		// Token: 0x04000051 RID: 81
		private static readonly JobsUtility.get_JobCompilerEnabledDelegate get_JobCompilerEnabledDelegateField;

		// Token: 0x04000052 RID: 82
		private static readonly JobsUtility.GetJobQueueWorkerThreadCountDelegate GetJobQueueWorkerThreadCountDelegateField;

		// Token: 0x04000053 RID: 83
		private static readonly JobsUtility.SetJobQueueMaximumActiveThreadCountDelegate SetJobQueueMaximumActiveThreadCountDelegateField;

		// Token: 0x04000054 RID: 84
		private static readonly JobsUtility.get_JobWorkerMaximumCountDelegate get_JobWorkerMaximumCountDelegateField;

		// Token: 0x04000055 RID: 85
		private static readonly JobsUtility.ResetJobWorkerCountDelegate ResetJobWorkerCountDelegateField;

		// Token: 0x04000056 RID: 86
		private static readonly JobsUtility.get_ThreadIndexDelegate get_ThreadIndexDelegateField;

		// Token: 0x04000057 RID: 87
		private static readonly JobsUtility.get_ThreadIndexCountDelegate get_ThreadIndexCountDelegateField;

		// Token: 0x04000058 RID: 88
		private static readonly JobsUtility.GetJobBatchingEnabledDelegate GetJobBatchingEnabledDelegateField;

		// Token: 0x04000059 RID: 89
		private static readonly JobsUtility.GetSystemIdCellPtrDelegate GetSystemIdCellPtrDelegateField;

		// Token: 0x0400005A RID: 90
		private static readonly JobsUtility.ClearSystemIdsDelegate ClearSystemIdsDelegateField;

		// Token: 0x0400005B RID: 91
		private static readonly JobsUtility.GetSystemIdMappingsDelegate GetSystemIdMappingsDelegateField;

		// Token: 0x0400005C RID: 92
		private static readonly JobsUtility.ScheduleParallelForDeferArraySize_InjectedDelegate ScheduleParallelForDeferArraySize_InjectedDelegateField;

		// Token: 0x0400005D RID: 93
		private static readonly JobsUtility.ScheduleParallelForTransformReadOnly_InjectedDelegate ScheduleParallelForTransformReadOnly_InjectedDelegateField;

		// Token: 0x02000385 RID: 901
		[StructLayout(2)]
		public struct JobScheduleParameters
		{
			// Token: 0x06002FE1 RID: 12257 RVA: 0x000B6710 File Offset: 0x000B4910
			// Note: this type is marked as 'beforefieldinit'.
			static JobScheduleParameters()
			{
				Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, "JobScheduleParameters");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr);
				JobsUtility.JobScheduleParameters.NativeFieldInfoPtr_Dependency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, "Dependency");
				JobsUtility.JobScheduleParameters.NativeFieldInfoPtr_ScheduleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, "ScheduleMode");
				JobsUtility.JobScheduleParameters.NativeFieldInfoPtr_ReflectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, "ReflectionData");
				JobsUtility.JobScheduleParameters.NativeFieldInfoPtr_JobDataPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, "JobDataPtr");
				JobsUtility.JobScheduleParameters.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_IntPtr_JobHandle_ScheduleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, 100663356);
			}

			// Token: 0x06002FE2 RID: 12258 RVA: 0x000B67A0 File Offset: 0x000B49A0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 643115, RefRangeEnd = 643119, XrefRangeStart = 643114, XrefRangeEnd = 643115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe JobScheduleParameters(void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = i_jobData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i_reflectionData;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i_dependency;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i_scheduleMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.JobScheduleParameters.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_IntPtr_JobHandle_ScheduleMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FE3 RID: 12259 RVA: 0x0001369C File Offset: 0x0001189C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, ref this));
			}

			// Token: 0x04002AC4 RID: 10948
			private static readonly IntPtr NativeFieldInfoPtr_Dependency;

			// Token: 0x04002AC5 RID: 10949
			private static readonly IntPtr NativeFieldInfoPtr_ScheduleMode;

			// Token: 0x04002AC6 RID: 10950
			private static readonly IntPtr NativeFieldInfoPtr_ReflectionData;

			// Token: 0x04002AC7 RID: 10951
			private static readonly IntPtr NativeFieldInfoPtr_JobDataPtr;

			// Token: 0x04002AC8 RID: 10952
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_IntPtr_JobHandle_ScheduleMode_0;

			// Token: 0x04002AC9 RID: 10953
			[FieldOffset(0)]
			public JobHandle Dependency;

			// Token: 0x04002ACA RID: 10954
			[FieldOffset(16)]
			public int ScheduleMode;

			// Token: 0x04002ACB RID: 10955
			[FieldOffset(24)]
			public IntPtr ReflectionData;

			// Token: 0x04002ACC RID: 10956
			[FieldOffset(32)]
			public IntPtr JobDataPtr;
		}

		// Token: 0x02000386 RID: 902
		public sealed class PanicFunction_ : MulticastDelegate
		{
			// Token: 0x06002FE4 RID: 12260 RVA: 0x000136AE File Offset: 0x000118AE
			// Note: this type is marked as 'beforefieldinit'.
			static PanicFunction_()
			{
				Il2CppClassPointerStore<JobsUtility.PanicFunction_>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, "PanicFunction_");
				JobsUtility.PanicFunction_.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility.PanicFunction_>.NativeClassPtr, 100663357);
				JobsUtility.PanicFunction_.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility.PanicFunction_>.NativeClassPtr, 100663358);
			}

			// Token: 0x06002FE5 RID: 12261 RVA: 0x000B67FC File Offset: 0x000B49FC
			[CallerCount(288)]
			[CachedScanResults(RefRangeStart = 320972, RefRangeEnd = 321260, XrefRangeStart = 320972, XrefRangeEnd = 321260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PanicFunction_(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JobsUtility.PanicFunction_>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.PanicFunction_.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FE6 RID: 12262 RVA: 0x000B6858 File Offset: 0x000B4A58
			[CallerCount(0)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.PanicFunction_.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FE7 RID: 12263 RVA: 0x000136EC File Offset: 0x000118EC
			public PanicFunction_(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002FE8 RID: 12264 RVA: 0x000136F5 File Offset: 0x000118F5
			public static implicit operator JobsUtility.PanicFunction_(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<JobsUtility.PanicFunction_>(A_0);
			}

			// Token: 0x06002FE9 RID: 12265 RVA: 0x000136FD File Offset: 0x000118FD
			public static JobsUtility.PanicFunction_ operator +(JobsUtility.PanicFunction_ A_0, JobsUtility.PanicFunction_ A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<JobsUtility.PanicFunction_>();
			}

			// Token: 0x06002FEA RID: 12266 RVA: 0x0001370B File Offset: 0x0001190B
			public static JobsUtility.PanicFunction_ operator -(JobsUtility.PanicFunction_ A_0, JobsUtility.PanicFunction_ A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<JobsUtility.PanicFunction_>();
				}
				return delegate2;
			}

			// Token: 0x04002ACD RID: 10957
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002ACE RID: 10958
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}

		// Token: 0x02000387 RID: 903
		// (Invoke) Token: 0x06002FEC RID: 12268
		private delegate void PatchBufferMinMaxRangesDelegate(IntPtr bufferRangePatchData, IntPtr jobdata, int startIndex, int rangeSize);

		// Token: 0x02000388 RID: 904
		// (Invoke) Token: 0x06002FEE RID: 12270
		private delegate bool get_IsExecutingJobDelegate();

		// Token: 0x02000389 RID: 905
		// (Invoke) Token: 0x06002FF0 RID: 12272
		private delegate bool get_JobDebuggerEnabledDelegate();

		// Token: 0x0200038A RID: 906
		// (Invoke) Token: 0x06002FF2 RID: 12274
		private delegate void set_JobDebuggerEnabledDelegate(bool value);

		// Token: 0x0200038B RID: 907
		// (Invoke) Token: 0x06002FF4 RID: 12276
		private delegate bool get_JobCompilerEnabledDelegate();

		// Token: 0x0200038C RID: 908
		// (Invoke) Token: 0x06002FF6 RID: 12278
		private delegate int GetJobQueueWorkerThreadCountDelegate();

		// Token: 0x0200038D RID: 909
		// (Invoke) Token: 0x06002FF8 RID: 12280
		private delegate void SetJobQueueMaximumActiveThreadCountDelegate(int count);

		// Token: 0x0200038E RID: 910
		// (Invoke) Token: 0x06002FFA RID: 12282
		private delegate int get_JobWorkerMaximumCountDelegate();

		// Token: 0x0200038F RID: 911
		// (Invoke) Token: 0x06002FFC RID: 12284
		private delegate void ResetJobWorkerCountDelegate();

		// Token: 0x02000390 RID: 912
		// (Invoke) Token: 0x06002FFE RID: 12286
		private delegate int get_ThreadIndexDelegate();

		// Token: 0x02000391 RID: 913
		// (Invoke) Token: 0x06003000 RID: 12288
		private delegate int get_ThreadIndexCountDelegate();

		// Token: 0x02000392 RID: 914
		// (Invoke) Token: 0x06003002 RID: 12290
		private delegate bool GetJobBatchingEnabledDelegate();

		// Token: 0x02000393 RID: 915
		// (Invoke) Token: 0x06003004 RID: 12292
		private delegate IntPtr GetSystemIdCellPtrDelegate();

		// Token: 0x02000394 RID: 916
		// (Invoke) Token: 0x06003006 RID: 12294
		private delegate void ClearSystemIdsDelegate();

		// Token: 0x02000395 RID: 917
		// (Invoke) Token: 0x06003008 RID: 12296
		private delegate int GetSystemIdMappingsDelegate(IntPtr handles, IntPtr systemIds, int maxCount);

		// Token: 0x02000396 RID: 918
		// (Invoke) Token: 0x0600300A RID: 12298
		private delegate void ScheduleParallelForDeferArraySize_InjectedDelegate(IntPtr parameters, int innerloopBatchCount, IntPtr listData, IntPtr listDataAtomicSafetyHandle, [Out] IntPtr ret);

		// Token: 0x02000397 RID: 919
		// (Invoke) Token: 0x0600300C RID: 12300
		private delegate void ScheduleParallelForTransformReadOnly_InjectedDelegate(IntPtr parameters, IntPtr transfromAccesssArray, int innerloopBatchCount, [Out] IntPtr ret);
	}
}
