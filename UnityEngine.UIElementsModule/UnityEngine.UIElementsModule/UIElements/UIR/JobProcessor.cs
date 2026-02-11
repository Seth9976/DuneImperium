using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Jobs;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000244 RID: 580
	public static class JobProcessor : Object
	{
		// Token: 0x06002AD2 RID: 10962 RVA: 0x000BA264 File Offset: 0x000B8464
		// Note: this type is marked as 'beforefieldinit'.
		static JobProcessor()
		{
			Il2CppClassPointerStore<JobProcessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "JobProcessor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobProcessor>.NativeClassPtr);
			JobProcessor.NativeMethodInfoPtr_ScheduleNudgeJobs_Internal_Static_JobHandle_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobProcessor>.NativeClassPtr, 100669703);
			JobProcessor.NativeMethodInfoPtr_ScheduleConvertMeshJobs_Internal_Static_JobHandle_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobProcessor>.NativeClassPtr, 100669704);
			JobProcessor.NativeMethodInfoPtr_ScheduleCopyClosingMeshJobs_Internal_Static_JobHandle_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobProcessor>.NativeClassPtr, 100669705);
			JobProcessor.NativeMethodInfoPtr_ScheduleNudgeJobs_Injected_Private_Static_Void_IntPtr_Int32_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobProcessor>.NativeClassPtr, 100669706);
			JobProcessor.NativeMethodInfoPtr_ScheduleConvertMeshJobs_Injected_Private_Static_Void_IntPtr_Int32_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobProcessor>.NativeClassPtr, 100669707);
			JobProcessor.NativeMethodInfoPtr_ScheduleCopyClosingMeshJobs_Injected_Private_Static_Void_IntPtr_Int32_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobProcessor>.NativeClassPtr, 100669708);
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x000BA30C File Offset: 0x000B850C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348046, XrefRangeEnd = 348048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle ScheduleNudgeJobs(IntPtr buffer, int jobCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobProcessor.NativeMethodInfoPtr_ScheduleNudgeJobs_Internal_Static_JobHandle_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x000BA358 File Offset: 0x000B8558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348048, XrefRangeEnd = 348050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle ScheduleConvertMeshJobs(IntPtr buffer, int jobCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobProcessor.NativeMethodInfoPtr_ScheduleConvertMeshJobs_Internal_Static_JobHandle_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x000BA3A4 File Offset: 0x000B85A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348050, XrefRangeEnd = 348052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle ScheduleCopyClosingMeshJobs(IntPtr buffer, int jobCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobProcessor.NativeMethodInfoPtr_ScheduleCopyClosingMeshJobs_Internal_Static_JobHandle_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x000BA3F0 File Offset: 0x000B85F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348052, XrefRangeEnd = 348054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScheduleNudgeJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobProcessor.NativeMethodInfoPtr_ScheduleNudgeJobs_Injected_Private_Static_Void_IntPtr_Int32_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x000BA440 File Offset: 0x000B8640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348054, XrefRangeEnd = 348056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScheduleConvertMeshJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobProcessor.NativeMethodInfoPtr_ScheduleConvertMeshJobs_Injected_Private_Static_Void_IntPtr_Int32_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x000BA490 File Offset: 0x000B8690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348056, XrefRangeEnd = 348058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScheduleCopyClosingMeshJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobProcessor.NativeMethodInfoPtr_ScheduleCopyClosingMeshJobs_Injected_Private_Static_Void_IntPtr_Int32_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x0001135C File Offset: 0x0000F55C
		public JobProcessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001E87 RID: 7815
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleNudgeJobs_Internal_Static_JobHandle_IntPtr_Int32_0;

		// Token: 0x04001E88 RID: 7816
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleConvertMeshJobs_Internal_Static_JobHandle_IntPtr_Int32_0;

		// Token: 0x04001E89 RID: 7817
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleCopyClosingMeshJobs_Internal_Static_JobHandle_IntPtr_Int32_0;

		// Token: 0x04001E8A RID: 7818
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleNudgeJobs_Injected_Private_Static_Void_IntPtr_Int32_byref_JobHandle_0;

		// Token: 0x04001E8B RID: 7819
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleConvertMeshJobs_Injected_Private_Static_Void_IntPtr_Int32_byref_JobHandle_0;

		// Token: 0x04001E8C RID: 7820
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleCopyClosingMeshJobs_Injected_Private_Static_Void_IntPtr_Int32_byref_JobHandle_0;
	}
}
