using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001C9 RID: 457
	public static class TaskToApm : Object
	{
		// Token: 0x06001DEB RID: 7659 RVA: 0x000AE364 File Offset: 0x000AC564
		// Note: this type is marked as 'beforefieldinit'.
		static TaskToApm()
		{
			Il2CppClassPointerStore<TaskToApm>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskToApm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr);
			TaskToApm.NativeMethodInfoPtr_Begin_Public_Static_IAsyncResult_Task_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr, 100668374);
			TaskToApm.NativeMethodInfoPtr_End_Public_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr, 100668375);
			TaskToApm.NativeMethodInfoPtr_End_Public_Static_TResult_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr, 100668376);
			TaskToApm.NativeMethodInfoPtr_InvokeCallbackWhenTaskCompletes_Private_Static_Void_Task_AsyncCallback_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr, 100668377);
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x000AE3E4 File Offset: 0x000AC5E4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1357961, RefRangeEnd = 1357973, XrefRangeStart = 1357930, XrefRangeEnd = 1357961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IAsyncResult Begin(Task task, AsyncCallback callback, Object state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.NativeMethodInfoPtr_Begin_Public_Static_IAsyncResult_Task_AsyncCallback_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x000AE44C File Offset: 0x000AC64C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1357981, RefRangeEnd = 1357986, XrefRangeStart = 1357973, XrefRangeEnd = 1357981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void End(IAsyncResult asyncResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.NativeMethodInfoPtr_End_Public_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x000AE484 File Offset: 0x000AC684
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1357995, RefRangeEnd = 1358000, XrefRangeStart = 1357986, XrefRangeEnd = 1357995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TResult End<TResult>(IAsyncResult asyncResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.MethodInfoStoreGeneric_End_Public_Static_TResult_IAsyncResult_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x000AE4C4 File Offset: 0x000AC6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358000, XrefRangeEnd = 1358014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(antecedent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.NativeMethodInfoPtr_InvokeCallbackWhenTaskCompletes_Private_Static_Void_Task_AsyncCallback_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x00009CC4 File Offset: 0x00007EC4
		public TaskToApm(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001AC7 RID: 6855
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Static_IAsyncResult_Task_AsyncCallback_Object_0;

		// Token: 0x04001AC8 RID: 6856
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Static_Void_IAsyncResult_0;

		// Token: 0x04001AC9 RID: 6857
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Static_TResult_IAsyncResult_0;

		// Token: 0x04001ACA RID: 6858
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCallbackWhenTaskCompletes_Private_Static_Void_Task_AsyncCallback_IAsyncResult_0;

		// Token: 0x02000620 RID: 1568
		public sealed class TaskWrapperAsyncResult : Object
		{
			// Token: 0x060058DF RID: 22751 RVA: 0x00198064 File Offset: 0x00196264
			// Note: this type is marked as 'beforefieldinit'.
			static TaskWrapperAsyncResult()
			{
				Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr, "TaskWrapperAsyncResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr);
				TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_Task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, "Task");
				TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, "_state");
				TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr__completedSynchronously = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, "_completedSynchronously");
				TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Task_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, 100668378);
				TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_AsyncState_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, 100668379);
				TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_CompletedSynchronously_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, 100668380);
				TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_IsCompleted_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, 100668381);
				TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_AsyncWaitHandle_Private_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, 100668382);
			}

			// Token: 0x060058E0 RID: 22752 RVA: 0x00198130 File Offset: 0x00196330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TaskWrapperAsyncResult(Task task, Object state, bool completedSynchronously)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref completedSynchronously;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Task_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170016A7 RID: 5799
			// (get) Token: 0x060058E1 RID: 22753 RVA: 0x0019819C File Offset: 0x0019639C
			public unsafe Object System.IAsyncResult.AsyncState
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_AsyncState_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170016A8 RID: 5800
			// (get) Token: 0x060058E2 RID: 22754 RVA: 0x001981DC File Offset: 0x001963DC
			public unsafe bool System.IAsyncResult.CompletedSynchronously
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_CompletedSynchronously_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170016A9 RID: 5801
			// (get) Token: 0x060058E3 RID: 22755 RVA: 0x00198218 File Offset: 0x00196418
			public unsafe bool System.IAsyncResult.IsCompleted
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357922, XrefRangeEnd = 1357926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_IsCompleted_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170016AA RID: 5802
			// (get) Token: 0x060058E4 RID: 22756 RVA: 0x00198254 File Offset: 0x00196454
			public unsafe WaitHandle System.IAsyncResult.AsyncWaitHandle
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357926, XrefRangeEnd = 1357930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_AsyncWaitHandle_Private_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
				}
			}

			// Token: 0x060058E5 RID: 22757 RVA: 0x0001FBBD File Offset: 0x0001DDBD
			public TaskWrapperAsyncResult(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016A4 RID: 5796
			// (get) Token: 0x060058E6 RID: 22758 RVA: 0x00198294 File Offset: 0x00196494
			// (set) Token: 0x060058E7 RID: 22759 RVA: 0x0001FBC6 File Offset: 0x0001DDC6
			public unsafe Task Task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_Task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_Task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016A5 RID: 5797
			// (get) Token: 0x060058E8 RID: 22760 RVA: 0x001982C4 File Offset: 0x001964C4
			// (set) Token: 0x060058E9 RID: 22761 RVA: 0x0001FBE5 File Offset: 0x0001DDE5
			public unsafe Object _state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr__state);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr__state), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016A6 RID: 5798
			// (get) Token: 0x060058EA RID: 22762 RVA: 0x001982F4 File Offset: 0x001964F4
			// (set) Token: 0x060058EB RID: 22763 RVA: 0x0001FC04 File Offset: 0x0001DE04
			public unsafe bool _completedSynchronously
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr__completedSynchronously);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr__completedSynchronously)) = value;
				}
			}

			// Token: 0x04004901 RID: 18689
			private static readonly IntPtr NativeFieldInfoPtr_Task;

			// Token: 0x04004902 RID: 18690
			private static readonly IntPtr NativeFieldInfoPtr__state;

			// Token: 0x04004903 RID: 18691
			private static readonly IntPtr NativeFieldInfoPtr__completedSynchronously;

			// Token: 0x04004904 RID: 18692
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_Object_Boolean_0;

			// Token: 0x04004905 RID: 18693
			private static readonly IntPtr NativeMethodInfoPtr_System_IAsyncResult_get_AsyncState_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004906 RID: 18694
			private static readonly IntPtr NativeMethodInfoPtr_System_IAsyncResult_get_CompletedSynchronously_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04004907 RID: 18695
			private static readonly IntPtr NativeMethodInfoPtr_System_IAsyncResult_get_IsCompleted_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04004908 RID: 18696
			private static readonly IntPtr NativeMethodInfoPtr_System_IAsyncResult_get_AsyncWaitHandle_Private_Virtual_Final_New_get_WaitHandle_0;
		}

		// Token: 0x02000621 RID: 1569
		[ObfuscatedName("System.Threading.Tasks.TaskToApm+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x060058EC RID: 22764 RVA: 0x0019831C File Offset: 0x0019651C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr);
				TaskToApm.__c__DisplayClass3_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr, "callback");
				TaskToApm.__c__DisplayClass3_0.NativeFieldInfoPtr_asyncResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr, "asyncResult");
				TaskToApm.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr, 100668383);
				TaskToApm.__c__DisplayClass3_0.NativeMethodInfoPtr__InvokeCallbackWhenTaskCompletes_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr, 100668384);
			}

			// Token: 0x060058ED RID: 22765 RVA: 0x00198398 File Offset: 0x00196598
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058EE RID: 22766 RVA: 0x001983D4 File Offset: 0x001965D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InvokeCallbackWhenTaskCompletes_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.__c__DisplayClass3_0.NativeMethodInfoPtr__InvokeCallbackWhenTaskCompletes_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058EF RID: 22767 RVA: 0x0001FC1F File Offset: 0x0001DE1F
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016AB RID: 5803
			// (get) Token: 0x060058F0 RID: 22768 RVA: 0x00198408 File Offset: 0x00196608
			// (set) Token: 0x060058F1 RID: 22769 RVA: 0x0001FC28 File Offset: 0x0001DE28
			public unsafe AsyncCallback callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.__c__DisplayClass3_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.__c__DisplayClass3_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016AC RID: 5804
			// (get) Token: 0x060058F2 RID: 22770 RVA: 0x00198438 File Offset: 0x00196638
			// (set) Token: 0x060058F3 RID: 22771 RVA: 0x0001FC47 File Offset: 0x0001DE47
			public unsafe IAsyncResult asyncResult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.__c__DisplayClass3_0.NativeFieldInfoPtr_asyncResult);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.__c__DisplayClass3_0.NativeFieldInfoPtr_asyncResult), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004909 RID: 18697
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x0400490A RID: 18698
			private static readonly IntPtr NativeFieldInfoPtr_asyncResult;

			// Token: 0x0400490B RID: 18699
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400490C RID: 18700
			private static readonly IntPtr NativeMethodInfoPtr__InvokeCallbackWhenTaskCompletes_b__0_Internal_Void_0;
		}

		// Token: 0x02000622 RID: 1570
		private sealed class MethodInfoStoreGeneric_End_Public_Static_TResult_IAsyncResult_0<TResult>
		{
			// Token: 0x0400490D RID: 18701
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskToApm.NativeMethodInfoPtr_End_Public_Static_TResult_IAsyncResult_0, Il2CppClassPointerStore<TaskToApm>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}
	}
}
