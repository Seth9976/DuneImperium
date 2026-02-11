using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Utils
{
	// Token: 0x02000038 RID: 56
	public static class TaskUtil : Object
	{
		// Token: 0x06000262 RID: 610 RVA: 0x0000E7C4 File Offset: 0x0000C9C4
		// Note: this type is marked as 'beforefieldinit'.
		static TaskUtil()
		{
			Il2CppClassPointerStore<TaskUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Utils", "TaskUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskUtil>.NativeClassPtr);
			TaskUtil.NativeMethodInfoPtr_TimeoutAfter_Public_Static_Task_1_TResult_Task_1_TResult_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskUtil>.NativeClassPtr, 100663873);
			TaskUtil.NativeMethodInfoPtr_TimeoutAfter_Public_Static_Task_Task_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskUtil>.NativeClassPtr, 100663874);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000E81C File Offset: 0x0000CA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184354, XrefRangeEnd = 1184359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> TimeoutAfter<TResult>(this Task<TResult> task, TimeSpan timeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskUtil.MethodInfoStoreGeneric_TimeoutAfter_Public_Static_Task_1_TResult_Task_1_TResult_TimeSpan_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000E870 File Offset: 0x0000CA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184359, XrefRangeEnd = 1184369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task TimeoutAfter(this Task task, TimeSpan timeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskUtil.NativeMethodInfoPtr_TimeoutAfter_Public_Static_Task_Task_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002A74 File Offset: 0x00000C74
		public TaskUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_TimeoutAfter_Public_Static_Task_1_TResult_Task_1_TResult_TimeSpan_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_TimeoutAfter_Public_Static_Task_Task_TimeSpan_0;

		// Token: 0x020000B4 RID: 180
		[ObfuscatedName("Utils.TaskUtil+<TimeoutAfter>d__0`1")]
		public sealed class _TimeoutAfter_d__0<TResult> : ValueType
		{
			// Token: 0x06000589 RID: 1417 RVA: 0x00019990 File Offset: 0x00017B90
			// Note: this type is marked as 'beforefieldinit'.
			static _TimeoutAfter_d__0()
			{
				Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__0<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskUtil>.NativeClassPtr, "<TimeoutAfter>d__0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__0<TResult>>.NativeClassPtr);
				TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__0<TResult>>.NativeClassPtr, "<>1__state");
				TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__0<TResult>>.NativeClassPtr, "<>t__builder");
				TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__0<TResult>>.NativeClassPtr, "task");
				TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__0<TResult>>.NativeClassPtr, "timeout");
				TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr__timeoutCancellationTokenSource_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__0<TResult>>.NativeClassPtr, "<timeoutCancellationTokenSource>5__2");
				TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__0<TResult>>.NativeClassPtr, "<>u__1");
				TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__0<TResult>>.NativeClassPtr, "<>u__2");
				TaskUtil._TimeoutAfter_d__0<TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__0<TResult>>.NativeClassPtr, 100663875);
				TaskUtil._TimeoutAfter_d__0<TResult>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__0<TResult>>.NativeClassPtr, 100663876);
			}

			// Token: 0x0600058A RID: 1418 RVA: 0x00019AAC File Offset: 0x00017CAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184232, XrefRangeEnd = 1184283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskUtil._TimeoutAfter_d__0<TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600058B RID: 1419 RVA: 0x00019AE4 File Offset: 0x00017CE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184283, XrefRangeEnd = 1184288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskUtil._TimeoutAfter_d__0<TResult>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600058C RID: 1420 RVA: 0x00004237 File Offset: 0x00002437
			public _TimeoutAfter_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600058D RID: 1421 RVA: 0x00004240 File Offset: 0x00002440
			public _TimeoutAfter_d__0()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__0<TResult>>.NativeClassPtr))
			{
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x0600058E RID: 1422 RVA: 0x00019B2C File Offset: 0x00017D2C
			// (set) Token: 0x0600058F RID: 1423 RVA: 0x00004252 File Offset: 0x00002452
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700015E RID: 350
			// (get) Token: 0x06000590 RID: 1424 RVA: 0x00019B54 File Offset: 0x00017D54
			// (set) Token: 0x06000591 RID: 1425 RVA: 0x0000426D File Offset: 0x0000246D
			public AsyncTaskMethodBuilder<TResult> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<TResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700015F RID: 351
			// (get) Token: 0x06000592 RID: 1426 RVA: 0x00019B84 File Offset: 0x00017D84
			// (set) Token: 0x06000593 RID: 1427 RVA: 0x0000429B File Offset: 0x0000249B
			public unsafe Task<TResult> task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000160 RID: 352
			// (get) Token: 0x06000594 RID: 1428 RVA: 0x00019BB4 File Offset: 0x00017DB4
			// (set) Token: 0x06000595 RID: 1429 RVA: 0x000042BA File Offset: 0x000024BA
			public unsafe TimeSpan timeout
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr_timeout);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr_timeout)) = value;
				}
			}

			// Token: 0x17000161 RID: 353
			// (get) Token: 0x06000596 RID: 1430 RVA: 0x00019BDC File Offset: 0x00017DDC
			// (set) Token: 0x06000597 RID: 1431 RVA: 0x000042D5 File Offset: 0x000024D5
			public unsafe CancellationTokenSource _timeoutCancellationTokenSource_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr__timeoutCancellationTokenSource_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr__timeoutCancellationTokenSource_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x06000598 RID: 1432 RVA: 0x00019C0C File Offset: 0x00017E0C
			// (set) Token: 0x06000599 RID: 1433 RVA: 0x000042F4 File Offset: 0x000024F4
			public TaskAwaiter<Task> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Task>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Task>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Task>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000163 RID: 355
			// (get) Token: 0x0600059A RID: 1434 RVA: 0x00019C3C File Offset: 0x00017E3C
			// (set) Token: 0x0600059B RID: 1435 RVA: 0x00004322 File Offset: 0x00002522
			public TaskAwaiter<TResult> __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter<TResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__0<TResult>.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040003A3 RID: 931
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040003A4 RID: 932
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040003A5 RID: 933
			private static readonly IntPtr NativeFieldInfoPtr_task;

			// Token: 0x040003A6 RID: 934
			private static readonly IntPtr NativeFieldInfoPtr_timeout;

			// Token: 0x040003A7 RID: 935
			private static readonly IntPtr NativeFieldInfoPtr__timeoutCancellationTokenSource_5__2;

			// Token: 0x040003A8 RID: 936
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040003A9 RID: 937
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040003AA RID: 938
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040003AB RID: 939
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020000B5 RID: 181
		[ObfuscatedName("Utils.TaskUtil+<TimeoutAfter>d__1")]
		public sealed class _TimeoutAfter_d__1 : ValueType
		{
			// Token: 0x0600059C RID: 1436 RVA: 0x00019C6C File Offset: 0x00017E6C
			// Note: this type is marked as 'beforefieldinit'.
			static _TimeoutAfter_d__1()
			{
				Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskUtil>.NativeClassPtr, "<TimeoutAfter>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__1>.NativeClassPtr);
				TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__1>.NativeClassPtr, "<>1__state");
				TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__1>.NativeClassPtr, "<>t__builder");
				TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__1>.NativeClassPtr, "task");
				TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__1>.NativeClassPtr, "timeout");
				TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr__timeoutCancellationTokenSource_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__1>.NativeClassPtr, "<timeoutCancellationTokenSource>5__2");
				TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__1>.NativeClassPtr, "<>u__1");
				TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__1>.NativeClassPtr, "<>u__2");
				TaskUtil._TimeoutAfter_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__1>.NativeClassPtr, 100663877);
				TaskUtil._TimeoutAfter_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__1>.NativeClassPtr, 100663878);
			}

			// Token: 0x0600059D RID: 1437 RVA: 0x00019D4C File Offset: 0x00017F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184288, XrefRangeEnd = 1184350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskUtil._TimeoutAfter_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600059E RID: 1438 RVA: 0x00019D84 File Offset: 0x00017F84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184350, XrefRangeEnd = 1184354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskUtil._TimeoutAfter_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600059F RID: 1439 RVA: 0x00004350 File Offset: 0x00002550
			public _TimeoutAfter_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060005A0 RID: 1440 RVA: 0x00004359 File Offset: 0x00002559
			public _TimeoutAfter_d__1()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskUtil._TimeoutAfter_d__1>.NativeClassPtr))
			{
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00019DCC File Offset: 0x00017FCC
			// (set) Token: 0x060005A2 RID: 1442 RVA: 0x0000436B File Offset: 0x0000256B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00019DF4 File Offset: 0x00017FF4
			// (set) Token: 0x060005A4 RID: 1444 RVA: 0x00004386 File Offset: 0x00002586
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00019E24 File Offset: 0x00018024
			// (set) Token: 0x060005A6 RID: 1446 RVA: 0x000043B4 File Offset: 0x000025B4
			public unsafe Task task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00019E54 File Offset: 0x00018054
			// (set) Token: 0x060005A8 RID: 1448 RVA: 0x000043D3 File Offset: 0x000025D3
			public unsafe TimeSpan timeout
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr_timeout);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr_timeout)) = value;
				}
			}

			// Token: 0x17000168 RID: 360
			// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00019E7C File Offset: 0x0001807C
			// (set) Token: 0x060005AA RID: 1450 RVA: 0x000043EE File Offset: 0x000025EE
			public unsafe CancellationTokenSource _timeoutCancellationTokenSource_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr__timeoutCancellationTokenSource_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr__timeoutCancellationTokenSource_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000169 RID: 361
			// (get) Token: 0x060005AB RID: 1451 RVA: 0x00019EAC File Offset: 0x000180AC
			// (set) Token: 0x060005AC RID: 1452 RVA: 0x0000440D File Offset: 0x0000260D
			public TaskAwaiter<Task> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Task>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Task>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Task>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700016A RID: 362
			// (get) Token: 0x060005AD RID: 1453 RVA: 0x00019EDC File Offset: 0x000180DC
			// (set) Token: 0x060005AE RID: 1454 RVA: 0x0000443B File Offset: 0x0000263B
			public TaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskUtil._TimeoutAfter_d__1.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040003AC RID: 940
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040003AD RID: 941
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040003AE RID: 942
			private static readonly IntPtr NativeFieldInfoPtr_task;

			// Token: 0x040003AF RID: 943
			private static readonly IntPtr NativeFieldInfoPtr_timeout;

			// Token: 0x040003B0 RID: 944
			private static readonly IntPtr NativeFieldInfoPtr__timeoutCancellationTokenSource_5__2;

			// Token: 0x040003B1 RID: 945
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040003B2 RID: 946
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040003B3 RID: 947
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040003B4 RID: 948
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020000B6 RID: 182
		private sealed class MethodInfoStoreGeneric_TimeoutAfter_Public_Static_Task_1_TResult_Task_1_TResult_TimeSpan_0<TResult>
		{
			// Token: 0x040003B5 RID: 949
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskUtil.NativeMethodInfoPtr_TimeoutAfter_Public_Static_Task_1_TResult_Task_1_TResult_TimeSpan_0, Il2CppClassPointerStore<TaskUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}
	}
}
