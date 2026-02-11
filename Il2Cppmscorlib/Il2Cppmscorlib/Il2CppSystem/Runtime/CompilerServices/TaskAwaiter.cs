using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003CA RID: 970
	public sealed class TaskAwaiter : ValueType, INotifyCompletion
	{
		// Token: 0x06003974 RID: 14708 RVA: 0x00115EDC File Offset: 0x001140DC
		// Note: this type is marked as 'beforefieldinit'.
		static TaskAwaiter()
		{
			Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "TaskAwaiter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr);
			TaskAwaiter.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, "m_task");
			TaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, 100671862);
			TaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, 100671863);
			TaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, 100671864);
			TaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, 100671865);
			TaskAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, 100671866);
			TaskAwaiter.NativeMethodInfoPtr_ValidateEnd_Internal_Static_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, 100671867);
			TaskAwaiter.NativeMethodInfoPtr_HandleNonSuccessAndDebuggerNotification_Private_Static_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, 100671868);
			TaskAwaiter.NativeMethodInfoPtr_ThrowForNonSuccess_Private_Static_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, 100671869);
			TaskAwaiter.NativeMethodInfoPtr_OnCompletedInternal_Internal_Static_Void_Task_Action_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, 100671870);
			TaskAwaiter.NativeMethodInfoPtr_OutputWaitEtwEvents_Private_Static_Action_Task_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, 100671871);
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x00115FE8 File Offset: 0x001141E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskAwaiter(Task task)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_Task_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06003976 RID: 14710 RVA: 0x00116038 File Offset: 0x00114238
		public unsafe bool IsCompleted
		{
			[CallerCount(604)]
			[CachedScanResults(RefRangeStart = 1393084, RefRangeEnd = 1393688, XrefRangeStart = 1393082, XrefRangeEnd = 1393084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x0011607C File Offset: 0x0011427C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1393688, XrefRangeEnd = 1393691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x001160C4 File Offset: 0x001142C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1393691, XrefRangeEnd = 1393694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsafeOnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x0011610C File Offset: 0x0011430C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 1393696, RefRangeEnd = 1394007, XrefRangeStart = 1393694, XrefRangeEnd = 1393696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x00116144 File Offset: 0x00114344
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1394009, RefRangeEnd = 1394015, XrefRangeStart = 1394007, XrefRangeEnd = 1394009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateEnd(Task task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.NativeMethodInfoPtr_ValidateEnd_Internal_Static_Void_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600397B RID: 14715 RVA: 0x0011617C File Offset: 0x0011437C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1394028, RefRangeEnd = 1394031, XrefRangeStart = 1394015, XrefRangeEnd = 1394028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleNonSuccessAndDebuggerNotification(Task task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.NativeMethodInfoPtr_HandleNonSuccessAndDebuggerNotification_Private_Static_Void_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x001161B4 File Offset: 0x001143B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1394031, XrefRangeEnd = 1394040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowForNonSuccess(Task task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.NativeMethodInfoPtr_ThrowForNonSuccess_Private_Static_Void_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600397D RID: 14717 RVA: 0x001161EC File Offset: 0x001143EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1394050, RefRangeEnd = 1394054, XrefRangeStart = 1394040, XrefRangeEnd = 1394050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(continuation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueOnCapturedContext;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flowExecutionContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.NativeMethodInfoPtr_OnCompletedInternal_Internal_Static_Void_Task_Action_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x00116250 File Offset: 0x00114450
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1394087, RefRangeEnd = 1394092, XrefRangeStart = 1394054, XrefRangeEnd = 1394087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action OutputWaitEtwEvents(Task task, Action continuation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(continuation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.NativeMethodInfoPtr_OutputWaitEtwEvents_Private_Static_Action_Task_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x000154DA File Offset: 0x000136DA
		public TaskAwaiter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x000154E3 File Offset: 0x000136E3
		public TaskAwaiter()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr))
		{
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06003981 RID: 14721 RVA: 0x001162A8 File Offset: 0x001144A8
		// (set) Token: 0x06003982 RID: 14722 RVA: 0x000154F5 File Offset: 0x000136F5
		public unsafe Task m_task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskAwaiter.NativeFieldInfoPtr_m_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskAwaiter.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x00015514 File Offset: 0x00013714
		public void OnCompleted(Action continuation)
		{
			this.OnCompleted(continuation);
		}

		// Token: 0x04002EAB RID: 11947
		private static readonly IntPtr NativeFieldInfoPtr_m_task;

		// Token: 0x04002EAC RID: 11948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_0;

		// Token: 0x04002EAD RID: 11949
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		// Token: 0x04002EAE RID: 11950
		private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04002EAF RID: 11951
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04002EB0 RID: 11952
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Void_0;

		// Token: 0x04002EB1 RID: 11953
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEnd_Internal_Static_Void_Task_0;

		// Token: 0x04002EB2 RID: 11954
		private static readonly IntPtr NativeMethodInfoPtr_HandleNonSuccessAndDebuggerNotification_Private_Static_Void_Task_0;

		// Token: 0x04002EB3 RID: 11955
		private static readonly IntPtr NativeMethodInfoPtr_ThrowForNonSuccess_Private_Static_Void_Task_0;

		// Token: 0x04002EB4 RID: 11956
		private static readonly IntPtr NativeMethodInfoPtr_OnCompletedInternal_Internal_Static_Void_Task_Action_Boolean_Boolean_0;

		// Token: 0x04002EB5 RID: 11957
		private static readonly IntPtr NativeMethodInfoPtr_OutputWaitEtwEvents_Private_Static_Action_Task_Action_0;

		// Token: 0x0200068D RID: 1677
		[ObfuscatedName("System.Runtime.CompilerServices.TaskAwaiter+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x06005BCB RID: 23499 RVA: 0x001A1398 File Offset: 0x0019F598
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<TaskAwaiter.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskAwaiter.__c__DisplayClass11_0>.NativeClassPtr);
				TaskAwaiter.__c__DisplayClass11_0.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskAwaiter.__c__DisplayClass11_0>.NativeClassPtr, "task");
				TaskAwaiter.__c__DisplayClass11_0.NativeFieldInfoPtr_continuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskAwaiter.__c__DisplayClass11_0>.NativeClassPtr, "continuation");
				TaskAwaiter.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter.__c__DisplayClass11_0>.NativeClassPtr, 100671872);
				TaskAwaiter.__c__DisplayClass11_0.NativeMethodInfoPtr__OutputWaitEtwEvents_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter.__c__DisplayClass11_0>.NativeClassPtr, 100671873);
			}

			// Token: 0x06005BCC RID: 23500 RVA: 0x001A1414 File Offset: 0x0019F614
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskAwaiter.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005BCD RID: 23501 RVA: 0x001A1450 File Offset: 0x0019F650
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1393059, XrefRangeEnd = 1393082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OutputWaitEtwEvents_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.__c__DisplayClass11_0.NativeMethodInfoPtr__OutputWaitEtwEvents_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005BCE RID: 23502 RVA: 0x00021470 File Offset: 0x0001F670
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700177D RID: 6013
			// (get) Token: 0x06005BCF RID: 23503 RVA: 0x001A1484 File Offset: 0x0019F684
			// (set) Token: 0x06005BD0 RID: 23504 RVA: 0x00021479 File Offset: 0x0001F679
			public unsafe Task task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskAwaiter.__c__DisplayClass11_0.NativeFieldInfoPtr_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskAwaiter.__c__DisplayClass11_0.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700177E RID: 6014
			// (get) Token: 0x06005BD1 RID: 23505 RVA: 0x001A14B4 File Offset: 0x0019F6B4
			// (set) Token: 0x06005BD2 RID: 23506 RVA: 0x00021498 File Offset: 0x0001F698
			public unsafe Action continuation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskAwaiter.__c__DisplayClass11_0.NativeFieldInfoPtr_continuation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskAwaiter.__c__DisplayClass11_0.NativeFieldInfoPtr_continuation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004AB5 RID: 19125
			private static readonly IntPtr NativeFieldInfoPtr_task;

			// Token: 0x04004AB6 RID: 19126
			private static readonly IntPtr NativeFieldInfoPtr_continuation;

			// Token: 0x04004AB7 RID: 19127
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004AB8 RID: 19128
			private static readonly IntPtr NativeMethodInfoPtr__OutputWaitEtwEvents_b__0_Internal_Void_0;
		}
	}
}
