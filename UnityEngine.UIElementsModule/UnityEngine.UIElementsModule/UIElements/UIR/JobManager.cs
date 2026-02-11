using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000254 RID: 596
	public class JobManager : Object
	{
		// Token: 0x06002C2A RID: 11306 RVA: 0x000BE51C File Offset: 0x000BC71C
		// Note: this type is marked as 'beforefieldinit'.
		static JobManager()
		{
			Il2CppClassPointerStore<JobManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "JobManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobManager>.NativeClassPtr);
			JobManager.NativeFieldInfoPtr_m_NudgeJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobManager>.NativeClassPtr, "m_NudgeJobs");
			JobManager.NativeFieldInfoPtr_m_ConvertMeshJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobManager>.NativeClassPtr, "m_ConvertMeshJobs");
			JobManager.NativeFieldInfoPtr_m_CopyClosingMeshJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobManager>.NativeClassPtr, "m_CopyClosingMeshJobs");
			JobManager.NativeFieldInfoPtr_m_JobMerger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobManager>.NativeClassPtr, "m_JobMerger");
			JobManager.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobManager>.NativeClassPtr, "<disposed>k__BackingField");
			JobManager.NativeMethodInfoPtr_Add_Public_Void_byref_NudgeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobManager>.NativeClassPtr, 100669836);
			JobManager.NativeMethodInfoPtr_Add_Public_Void_byref_ConvertMeshJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobManager>.NativeClassPtr, 100669837);
			JobManager.NativeMethodInfoPtr_Add_Public_Void_byref_CopyClosingMeshJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobManager>.NativeClassPtr, 100669838);
			JobManager.NativeMethodInfoPtr_CompleteNudgeJobs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobManager>.NativeClassPtr, 100669839);
			JobManager.NativeMethodInfoPtr_CompleteConvertMeshJobs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobManager>.NativeClassPtr, 100669840);
			JobManager.NativeMethodInfoPtr_CompleteClosingMeshJobs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobManager>.NativeClassPtr, 100669841);
			JobManager.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobManager>.NativeClassPtr, 100669842);
			JobManager.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobManager>.NativeClassPtr, 100669843);
			JobManager.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobManager>.NativeClassPtr, 100669844);
			JobManager.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobManager>.NativeClassPtr, 100669845);
			JobManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobManager>.NativeClassPtr, 100669846);
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x000BE68C File Offset: 0x000BC88C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350069, RefRangeEnd = 350070, XrefRangeStart = 350065, XrefRangeEnd = 350069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(ref NudgeJobData job)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &job;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobManager.NativeMethodInfoPtr_Add_Public_Void_byref_NudgeJobData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x000BE6CC File Offset: 0x000BC8CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350074, RefRangeEnd = 350075, XrefRangeStart = 350070, XrefRangeEnd = 350074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(ref ConvertMeshJobData job)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &job;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobManager.NativeMethodInfoPtr_Add_Public_Void_byref_ConvertMeshJobData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x000BE70C File Offset: 0x000BC90C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350079, RefRangeEnd = 350080, XrefRangeStart = 350075, XrefRangeEnd = 350079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(ref CopyClosingMeshJobData job)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &job;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobManager.NativeMethodInfoPtr_Add_Public_Void_byref_CopyClosingMeshJobData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x000BE74C File Offset: 0x000BC94C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350117, RefRangeEnd = 350118, XrefRangeStart = 350080, XrefRangeEnd = 350117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteNudgeJobs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobManager.NativeMethodInfoPtr_CompleteNudgeJobs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x000BE780 File Offset: 0x000BC980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350155, RefRangeEnd = 350156, XrefRangeStart = 350118, XrefRangeEnd = 350155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteConvertMeshJobs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobManager.NativeMethodInfoPtr_CompleteConvertMeshJobs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x000BE7B4 File Offset: 0x000BC9B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350193, RefRangeEnd = 350194, XrefRangeStart = 350156, XrefRangeEnd = 350193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteClosingMeshJobs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobManager.NativeMethodInfoPtr_CompleteClosingMeshJobs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x06002C31 RID: 11313 RVA: 0x000BE7E8 File Offset: 0x000BC9E8
		// (set) Token: 0x06002C32 RID: 11314 RVA: 0x000BE824 File Offset: 0x000BCA24
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobManager.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobManager.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x000BE864 File Offset: 0x000BCA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350194, XrefRangeEnd = 350215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobManager.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x000BE898 File Offset: 0x000BCA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350215, XrefRangeEnd = 350231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobManager.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x000BE8D8 File Offset: 0x000BCAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350231, XrefRangeEnd = 350265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JobManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JobManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x00011F06 File Offset: 0x00010106
		public JobManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06002C37 RID: 11319 RVA: 0x000BE914 File Offset: 0x000BCB14
		// (set) Token: 0x06002C38 RID: 11320 RVA: 0x00011F0F File Offset: 0x0001010F
		public unsafe NativePagedList<NudgeJobData> m_NudgeJobs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobManager.NativeFieldInfoPtr_m_NudgeJobs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativePagedList<NudgeJobData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobManager.NativeFieldInfoPtr_m_NudgeJobs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06002C39 RID: 11321 RVA: 0x000BE944 File Offset: 0x000BCB44
		// (set) Token: 0x06002C3A RID: 11322 RVA: 0x00011F2E File Offset: 0x0001012E
		public unsafe NativePagedList<ConvertMeshJobData> m_ConvertMeshJobs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobManager.NativeFieldInfoPtr_m_ConvertMeshJobs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativePagedList<ConvertMeshJobData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobManager.NativeFieldInfoPtr_m_ConvertMeshJobs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06002C3B RID: 11323 RVA: 0x000BE974 File Offset: 0x000BCB74
		// (set) Token: 0x06002C3C RID: 11324 RVA: 0x00011F4D File Offset: 0x0001014D
		public unsafe NativePagedList<CopyClosingMeshJobData> m_CopyClosingMeshJobs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobManager.NativeFieldInfoPtr_m_CopyClosingMeshJobs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativePagedList<CopyClosingMeshJobData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobManager.NativeFieldInfoPtr_m_CopyClosingMeshJobs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06002C3D RID: 11325 RVA: 0x000BE9A4 File Offset: 0x000BCBA4
		// (set) Token: 0x06002C3E RID: 11326 RVA: 0x00011F6C File Offset: 0x0001016C
		public unsafe JobMerger m_JobMerger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobManager.NativeFieldInfoPtr_m_JobMerger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JobMerger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobManager.NativeFieldInfoPtr_m_JobMerger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06002C3F RID: 11327 RVA: 0x000BE9D4 File Offset: 0x000BCBD4
		// (set) Token: 0x06002C40 RID: 11328 RVA: 0x00011F8B File Offset: 0x0001018B
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobManager.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobManager.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x04001F72 RID: 8050
		private static readonly IntPtr NativeFieldInfoPtr_m_NudgeJobs;

		// Token: 0x04001F73 RID: 8051
		private static readonly IntPtr NativeFieldInfoPtr_m_ConvertMeshJobs;

		// Token: 0x04001F74 RID: 8052
		private static readonly IntPtr NativeFieldInfoPtr_m_CopyClosingMeshJobs;

		// Token: 0x04001F75 RID: 8053
		private static readonly IntPtr NativeFieldInfoPtr_m_JobMerger;

		// Token: 0x04001F76 RID: 8054
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x04001F77 RID: 8055
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_byref_NudgeJobData_0;

		// Token: 0x04001F78 RID: 8056
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_byref_ConvertMeshJobData_0;

		// Token: 0x04001F79 RID: 8057
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_byref_CopyClosingMeshJobData_0;

		// Token: 0x04001F7A RID: 8058
		private static readonly IntPtr NativeMethodInfoPtr_CompleteNudgeJobs_Public_Void_0;

		// Token: 0x04001F7B RID: 8059
		private static readonly IntPtr NativeMethodInfoPtr_CompleteConvertMeshJobs_Public_Void_0;

		// Token: 0x04001F7C RID: 8060
		private static readonly IntPtr NativeMethodInfoPtr_CompleteClosingMeshJobs_Public_Void_0;

		// Token: 0x04001F7D RID: 8061
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0;

		// Token: 0x04001F7E RID: 8062
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x04001F7F RID: 8063
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001F80 RID: 8064
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0;

		// Token: 0x04001F81 RID: 8065
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
