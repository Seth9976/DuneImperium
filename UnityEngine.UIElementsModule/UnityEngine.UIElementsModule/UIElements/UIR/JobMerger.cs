using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000258 RID: 600
	public class JobMerger : Object
	{
		// Token: 0x06002C47 RID: 11335 RVA: 0x000BED20 File Offset: 0x000BCF20
		// Note: this type is marked as 'beforefieldinit'.
		static JobMerger()
		{
			Il2CppClassPointerStore<JobMerger>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "JobMerger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobMerger>.NativeClassPtr);
			JobMerger.NativeFieldInfoPtr_m_Jobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobMerger>.NativeClassPtr, "m_Jobs");
			JobMerger.NativeFieldInfoPtr_m_JobCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobMerger>.NativeClassPtr, "m_JobCount");
			JobMerger.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobMerger>.NativeClassPtr, "<disposed>k__BackingField");
			JobMerger.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobMerger>.NativeClassPtr, 100669847);
			JobMerger.NativeMethodInfoPtr_Add_Public_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobMerger>.NativeClassPtr, 100669848);
			JobMerger.NativeMethodInfoPtr_MergeAndReset_Public_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobMerger>.NativeClassPtr, 100669849);
			JobMerger.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobMerger>.NativeClassPtr, 100669850);
			JobMerger.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobMerger>.NativeClassPtr, 100669851);
			JobMerger.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobMerger>.NativeClassPtr, 100669852);
			JobMerger.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobMerger>.NativeClassPtr, 100669853);
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x000BEE18 File Offset: 0x000BD018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350265, XrefRangeEnd = 350273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JobMerger(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JobMerger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobMerger.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x000BEE60 File Offset: 0x000BD060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350273, XrefRangeEnd = 350274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(JobHandle job)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref job;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobMerger.NativeMethodInfoPtr_Add_Public_Void_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x000BEEA0 File Offset: 0x000BD0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350274, XrefRangeEnd = 350279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JobHandle MergeAndReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobMerger.NativeMethodInfoPtr_MergeAndReset_Public_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06002C4B RID: 11339 RVA: 0x000BEEDC File Offset: 0x000BD0DC
		// (set) Token: 0x06002C4C RID: 11340 RVA: 0x000BEF18 File Offset: 0x000BD118
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobMerger.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobMerger.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x000BEF58 File Offset: 0x000BD158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350279, XrefRangeEnd = 350286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobMerger.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x000BEF8C File Offset: 0x000BD18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350286, XrefRangeEnd = 350289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobMerger.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x00011FDC File Offset: 0x000101DC
		public JobMerger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06002C50 RID: 11344 RVA: 0x000BEFCC File Offset: 0x000BD1CC
		// (set) Token: 0x06002C51 RID: 11345 RVA: 0x00011FE5 File Offset: 0x000101E5
		public NativeArray<JobHandle> m_Jobs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobMerger.NativeFieldInfoPtr_m_Jobs);
				return new NativeArray<JobHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<JobHandle>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobMerger.NativeFieldInfoPtr_m_Jobs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<JobHandle>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06002C52 RID: 11346 RVA: 0x000BEFFC File Offset: 0x000BD1FC
		// (set) Token: 0x06002C53 RID: 11347 RVA: 0x00012013 File Offset: 0x00010213
		public unsafe int m_JobCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobMerger.NativeFieldInfoPtr_m_JobCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobMerger.NativeFieldInfoPtr_m_JobCount)) = value;
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06002C54 RID: 11348 RVA: 0x000BF024 File Offset: 0x000BD224
		// (set) Token: 0x06002C55 RID: 11349 RVA: 0x0001202E File Offset: 0x0001022E
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobMerger.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobMerger.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x04001FC4 RID: 8132
		private static readonly IntPtr NativeFieldInfoPtr_m_Jobs;

		// Token: 0x04001FC5 RID: 8133
		private static readonly IntPtr NativeFieldInfoPtr_m_JobCount;

		// Token: 0x04001FC6 RID: 8134
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x04001FC7 RID: 8135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001FC8 RID: 8136
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_JobHandle_0;

		// Token: 0x04001FC9 RID: 8137
		private static readonly IntPtr NativeMethodInfoPtr_MergeAndReset_Public_JobHandle_0;

		// Token: 0x04001FCA RID: 8138
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0;

		// Token: 0x04001FCB RID: 8139
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x04001FCC RID: 8140
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001FCD RID: 8141
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0;
	}
}
