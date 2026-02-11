using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Internal.Runtime.Augments;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001CE RID: 462
	public static class DebuggerSupport : Object
	{
		// Token: 0x06001E35 RID: 7733 RVA: 0x000AF6BC File Offset: 0x000AD8BC
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerSupport()
		{
			Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "DebuggerSupport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr);
			DebuggerSupport.NativeFieldInfoPtr_s_activeTasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, "s_activeTasks");
			DebuggerSupport.NativeFieldInfoPtr_s_activeTasksLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, "s_activeTasksLock");
			DebuggerSupport.NativeMethodInfoPtr_get_LoggingOn_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668432);
			DebuggerSupport.NativeMethodInfoPtr_TraceOperationCreation_Public_Static_Void_CausalityTraceLevel_Task_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668433);
			DebuggerSupport.NativeMethodInfoPtr_TraceOperationCompletion_Public_Static_Void_CausalityTraceLevel_Task_AsyncStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668434);
			DebuggerSupport.NativeMethodInfoPtr_TraceOperationRelation_Public_Static_Void_CausalityTraceLevel_Task_CausalityRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668435);
			DebuggerSupport.NativeMethodInfoPtr_TraceSynchronousWorkStart_Public_Static_Void_CausalityTraceLevel_Task_CausalitySynchronousWork_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668436);
			DebuggerSupport.NativeMethodInfoPtr_TraceSynchronousWorkCompletion_Public_Static_Void_CausalityTraceLevel_CausalitySynchronousWork_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668437);
			DebuggerSupport.NativeMethodInfoPtr_AddToActiveTasks_Public_Static_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668438);
			DebuggerSupport.NativeMethodInfoPtr_AddToActiveTasksNonInlined_Private_Static_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668439);
			DebuggerSupport.NativeMethodInfoPtr_RemoveFromActiveTasks_Public_Static_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668440);
			DebuggerSupport.NativeMethodInfoPtr_RemoveFromActiveTasksNonInlined_Private_Static_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668441);
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x000AF7DC File Offset: 0x000AD9DC
		public unsafe static bool LoggingOn
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerSupport.NativeMethodInfoPtr_get_LoggingOn_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x000AF80C File Offset: 0x000ADA0C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceOperationCreation(CausalityTraceLevel traceLevel, Task task, string operationName, ulong relatedContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(task);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(operationName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relatedContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerSupport.NativeMethodInfoPtr_TraceOperationCreation_Public_Static_Void_CausalityTraceLevel_Task_String_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x000AF870 File Offset: 0x000ADA70
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceOperationCompletion(CausalityTraceLevel traceLevel, Task task, AsyncStatus status)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(task);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerSupport.NativeMethodInfoPtr_TraceOperationCompletion_Public_Static_Void_CausalityTraceLevel_Task_AsyncStatus_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x000AF8C4 File Offset: 0x000ADAC4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceOperationRelation(CausalityTraceLevel traceLevel, Task task, CausalityRelation relation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(task);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerSupport.NativeMethodInfoPtr_TraceOperationRelation_Public_Static_Void_CausalityTraceLevel_Task_CausalityRelation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x000AF918 File Offset: 0x000ADB18
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, Task task, CausalitySynchronousWork work)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(task);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref work;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerSupport.NativeMethodInfoPtr_TraceSynchronousWorkStart_Public_Static_Void_CausalityTraceLevel_Task_CausalitySynchronousWork_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x000AF96C File Offset: 0x000ADB6C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref work;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerSupport.NativeMethodInfoPtr_TraceSynchronousWorkCompletion_Public_Static_Void_CausalityTraceLevel_CausalitySynchronousWork_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x000AF9AC File Offset: 0x000ADBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358204, XrefRangeEnd = 1358212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddToActiveTasks(Task task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerSupport.NativeMethodInfoPtr_AddToActiveTasks_Public_Static_Void_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x000AF9E4 File Offset: 0x000ADBE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1358227, RefRangeEnd = 1358228, XrefRangeStart = 1358212, XrefRangeEnd = 1358227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddToActiveTasksNonInlined(Task task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerSupport.NativeMethodInfoPtr_AddToActiveTasksNonInlined_Private_Static_Void_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x000AFA1C File Offset: 0x000ADC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358228, XrefRangeEnd = 1358236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveFromActiveTasks(Task task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerSupport.NativeMethodInfoPtr_RemoveFromActiveTasks_Public_Static_Void_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x000AFA54 File Offset: 0x000ADC54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1358251, RefRangeEnd = 1358252, XrefRangeStart = 1358236, XrefRangeEnd = 1358251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveFromActiveTasksNonInlined(Task task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerSupport.NativeMethodInfoPtr_RemoveFromActiveTasksNonInlined_Private_Static_Void_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x00009E5B File Offset: 0x0000805B
		public DebuggerSupport(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001E41 RID: 7745 RVA: 0x000AFA8C File Offset: 0x000ADC8C
		// (set) Token: 0x06001E42 RID: 7746 RVA: 0x00009E64 File Offset: 0x00008064
		public unsafe static LowLevelDictionary<int, Task> s_activeTasks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebuggerSupport.NativeFieldInfoPtr_s_activeTasks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LowLevelDictionary<int, Task>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebuggerSupport.NativeFieldInfoPtr_s_activeTasks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x000AFAB4 File Offset: 0x000ADCB4
		// (set) Token: 0x06001E44 RID: 7748 RVA: 0x00009E76 File Offset: 0x00008076
		public unsafe static Object s_activeTasksLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebuggerSupport.NativeFieldInfoPtr_s_activeTasksLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebuggerSupport.NativeFieldInfoPtr_s_activeTasksLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AF9 RID: 6905
		private static readonly IntPtr NativeFieldInfoPtr_s_activeTasks;

		// Token: 0x04001AFA RID: 6906
		private static readonly IntPtr NativeFieldInfoPtr_s_activeTasksLock;

		// Token: 0x04001AFB RID: 6907
		private static readonly IntPtr NativeMethodInfoPtr_get_LoggingOn_Public_Static_get_Boolean_0;

		// Token: 0x04001AFC RID: 6908
		private static readonly IntPtr NativeMethodInfoPtr_TraceOperationCreation_Public_Static_Void_CausalityTraceLevel_Task_String_UInt64_0;

		// Token: 0x04001AFD RID: 6909
		private static readonly IntPtr NativeMethodInfoPtr_TraceOperationCompletion_Public_Static_Void_CausalityTraceLevel_Task_AsyncStatus_0;

		// Token: 0x04001AFE RID: 6910
		private static readonly IntPtr NativeMethodInfoPtr_TraceOperationRelation_Public_Static_Void_CausalityTraceLevel_Task_CausalityRelation_0;

		// Token: 0x04001AFF RID: 6911
		private static readonly IntPtr NativeMethodInfoPtr_TraceSynchronousWorkStart_Public_Static_Void_CausalityTraceLevel_Task_CausalitySynchronousWork_0;

		// Token: 0x04001B00 RID: 6912
		private static readonly IntPtr NativeMethodInfoPtr_TraceSynchronousWorkCompletion_Public_Static_Void_CausalityTraceLevel_CausalitySynchronousWork_0;

		// Token: 0x04001B01 RID: 6913
		private static readonly IntPtr NativeMethodInfoPtr_AddToActiveTasks_Public_Static_Void_Task_0;

		// Token: 0x04001B02 RID: 6914
		private static readonly IntPtr NativeMethodInfoPtr_AddToActiveTasksNonInlined_Private_Static_Void_Task_0;

		// Token: 0x04001B03 RID: 6915
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromActiveTasks_Public_Static_Void_Task_0;

		// Token: 0x04001B04 RID: 6916
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromActiveTasksNonInlined_Private_Static_Void_Task_0;
	}
}
