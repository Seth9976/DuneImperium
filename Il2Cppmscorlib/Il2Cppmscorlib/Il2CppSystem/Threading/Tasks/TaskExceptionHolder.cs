using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Runtime.ExceptionServices;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001E5 RID: 485
	public class TaskExceptionHolder : Object
	{
		// Token: 0x06001FBB RID: 8123 RVA: 0x000B64A8 File Offset: 0x000B46A8
		// Note: this type is marked as 'beforefieldinit'.
		static TaskExceptionHolder()
		{
			Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskExceptionHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr);
			TaskExceptionHolder.NativeFieldInfoPtr_s_failFastOnUnobservedException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, "s_failFastOnUnobservedException");
			TaskExceptionHolder.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, "m_task");
			TaskExceptionHolder.NativeFieldInfoPtr_m_faultExceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, "m_faultExceptions");
			TaskExceptionHolder.NativeFieldInfoPtr_m_cancellationException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, "m_cancellationException");
			TaskExceptionHolder.NativeFieldInfoPtr_m_isHandled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, "m_isHandled");
			TaskExceptionHolder.NativeMethodInfoPtr__ctor_Internal_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100668690);
			TaskExceptionHolder.NativeMethodInfoPtr_ShouldFailFastOnUnobservedException_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100668691);
			TaskExceptionHolder.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100668692);
			TaskExceptionHolder.NativeMethodInfoPtr_get_ContainsFaultList_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100668693);
			TaskExceptionHolder.NativeMethodInfoPtr_Add_Internal_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100668694);
			TaskExceptionHolder.NativeMethodInfoPtr_SetCancellationException_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100668695);
			TaskExceptionHolder.NativeMethodInfoPtr_AddFaultException_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100668696);
			TaskExceptionHolder.NativeMethodInfoPtr_MarkAsUnhandled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100668697);
			TaskExceptionHolder.NativeMethodInfoPtr_MarkAsHandled_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100668698);
			TaskExceptionHolder.NativeMethodInfoPtr_CreateExceptionObject_Internal_AggregateException_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100668699);
			TaskExceptionHolder.NativeMethodInfoPtr_GetExceptionDispatchInfos_Internal_ReadOnlyCollection_1_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100668700);
			TaskExceptionHolder.NativeMethodInfoPtr_GetCancellationExceptionDispatchInfo_Internal_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100668701);
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x000B662C File Offset: 0x000B482C
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskExceptionHolder(Task task)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr__ctor_Internal_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x000B6678 File Offset: 0x000B4878
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldFailFastOnUnobservedException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_ShouldFailFastOnUnobservedException_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x000B66A8 File Offset: 0x000B48A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361595, XrefRangeEnd = 1361624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskExceptionHolder.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x000B66E4 File Offset: 0x000B48E4
		public unsafe bool ContainsFaultList
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361624, XrefRangeEnd = 1361625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_get_ContainsFaultList_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x000B6720 File Offset: 0x000B4920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361625, XrefRangeEnd = 1361640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Object exceptionObject, bool representsCancellation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref representsCancellation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_Add_Internal_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x000B6770 File Offset: 0x000B4970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361640, XrefRangeEnd = 1361654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCancellationException(Object exceptionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_SetCancellationException_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x000B67B4 File Offset: 0x000B49B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1361710, RefRangeEnd = 1361712, XrefRangeStart = 1361654, XrefRangeEnd = 1361710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFaultException(Object exceptionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_AddFaultException_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x000B67F8 File Offset: 0x000B49F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361712, XrefRangeEnd = 1361718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkAsUnhandled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_MarkAsUnhandled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x000B682C File Offset: 0x000B4A2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1361724, RefRangeEnd = 1361726, XrefRangeStart = 1361718, XrefRangeEnd = 1361724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkAsHandled(bool calledFromFinalizer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calledFromFinalizer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_MarkAsHandled_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x000B686C File Offset: 0x000B4A6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1361744, RefRangeEnd = 1361745, XrefRangeStart = 1361726, XrefRangeEnd = 1361744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calledFromFinalizer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(includeThisException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_CreateExceptionObject_Internal_AggregateException_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AggregateException>(intPtr3) : null;
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x000B68CC File Offset: 0x000B4ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361745, XrefRangeEnd = 1361758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_GetExceptionDispatchInfos_Internal_ReadOnlyCollection_1_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ExceptionDispatchInfo>>(intPtr3) : null;
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x000B690C File Offset: 0x000B4B0C
		[CallerCount(0)]
		public unsafe ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_GetCancellationExceptionDispatchInfo_Internal_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr3) : null;
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x0000A4E8 File Offset: 0x000086E8
		public TaskExceptionHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x000B694C File Offset: 0x000B4B4C
		// (set) Token: 0x06001FCA RID: 8138 RVA: 0x0000A4F1 File Offset: 0x000086F1
		public unsafe static bool s_failFastOnUnobservedException
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TaskExceptionHolder.NativeFieldInfoPtr_s_failFastOnUnobservedException, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskExceptionHolder.NativeFieldInfoPtr_s_failFastOnUnobservedException, (void*)(&value));
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x000B6968 File Offset: 0x000B4B68
		// (set) Token: 0x06001FCC RID: 8140 RVA: 0x0000A4FF File Offset: 0x000086FF
		public unsafe Task m_task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x000B6998 File Offset: 0x000B4B98
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x0000A51E File Offset: 0x0000871E
		public unsafe LowLevelListWithIList<ExceptionDispatchInfo> m_faultExceptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_faultExceptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LowLevelListWithIList<ExceptionDispatchInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_faultExceptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x000B69C8 File Offset: 0x000B4BC8
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x0000A53D File Offset: 0x0000873D
		public unsafe ExceptionDispatchInfo m_cancellationException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_cancellationException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_cancellationException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x000B69F8 File Offset: 0x000B4BF8
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x0000A55C File Offset: 0x0000875C
		public unsafe bool m_isHandled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_isHandled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_isHandled)) = value;
			}
		}

		// Token: 0x04001C40 RID: 7232
		private static readonly IntPtr NativeFieldInfoPtr_s_failFastOnUnobservedException;

		// Token: 0x04001C41 RID: 7233
		private static readonly IntPtr NativeFieldInfoPtr_m_task;

		// Token: 0x04001C42 RID: 7234
		private static readonly IntPtr NativeFieldInfoPtr_m_faultExceptions;

		// Token: 0x04001C43 RID: 7235
		private static readonly IntPtr NativeFieldInfoPtr_m_cancellationException;

		// Token: 0x04001C44 RID: 7236
		private static readonly IntPtr NativeFieldInfoPtr_m_isHandled;

		// Token: 0x04001C45 RID: 7237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_0;

		// Token: 0x04001C46 RID: 7238
		private static readonly IntPtr NativeMethodInfoPtr_ShouldFailFastOnUnobservedException_Private_Static_Boolean_0;

		// Token: 0x04001C47 RID: 7239
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001C48 RID: 7240
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainsFaultList_Internal_get_Boolean_0;

		// Token: 0x04001C49 RID: 7241
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_Object_Boolean_0;

		// Token: 0x04001C4A RID: 7242
		private static readonly IntPtr NativeMethodInfoPtr_SetCancellationException_Private_Void_Object_0;

		// Token: 0x04001C4B RID: 7243
		private static readonly IntPtr NativeMethodInfoPtr_AddFaultException_Private_Void_Object_0;

		// Token: 0x04001C4C RID: 7244
		private static readonly IntPtr NativeMethodInfoPtr_MarkAsUnhandled_Private_Void_0;

		// Token: 0x04001C4D RID: 7245
		private static readonly IntPtr NativeMethodInfoPtr_MarkAsHandled_Internal_Void_Boolean_0;

		// Token: 0x04001C4E RID: 7246
		private static readonly IntPtr NativeMethodInfoPtr_CreateExceptionObject_Internal_AggregateException_Boolean_Exception_0;

		// Token: 0x04001C4F RID: 7247
		private static readonly IntPtr NativeMethodInfoPtr_GetExceptionDispatchInfos_Internal_ReadOnlyCollection_1_ExceptionDispatchInfo_0;

		// Token: 0x04001C50 RID: 7248
		private static readonly IntPtr NativeMethodInfoPtr_GetCancellationExceptionDispatchInfo_Internal_ExceptionDispatchInfo_0;
	}
}
