using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;

namespace dwd.core.await
{
	// Token: 0x0200020B RID: 523
	public static class TaskExtensions : Object
	{
		// Token: 0x06001CD9 RID: 7385 RVA: 0x00085F20 File Offset: 0x00084120
		// Note: this type is marked as 'beforefieldinit'.
		static TaskExtensions()
		{
			Il2CppClassPointerStore<TaskExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.await", "TaskExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskExtensions>.NativeClassPtr);
			TaskExtensions.NativeMethodInfoPtr_AsIEnumerator_Public_Static_IEnumerator_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExtensions>.NativeClassPtr, 100667942);
			TaskExtensions.NativeMethodInfoPtr_AsCommand_Public_Static_TaskCommand_1_T_Task_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExtensions>.NativeClassPtr, 100667943);
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x00085F78 File Offset: 0x00084178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 886005, RefRangeEnd = 886006, XrefRangeStart = 886000, XrefRangeEnd = 886005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator AsIEnumerator(this Task task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExtensions.NativeMethodInfoPtr_AsIEnumerator_Public_Static_IEnumerator_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x00085FBC File Offset: 0x000841BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886006, XrefRangeEnd = 886009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TaskCommand<T> AsCommand<T>(this Task<T> task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExtensions.MethodInfoStoreGeneric_AsCommand_Public_Static_TaskCommand_1_T_Task_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaskCommand<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x0000C57C File Offset: 0x0000A77C
		public TaskExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001438 RID: 5176
		private static readonly IntPtr NativeMethodInfoPtr_AsIEnumerator_Public_Static_IEnumerator_Task_0;

		// Token: 0x04001439 RID: 5177
		private static readonly IntPtr NativeMethodInfoPtr_AsCommand_Public_Static_TaskCommand_1_T_Task_1_T_0;

		// Token: 0x0200039E RID: 926
		[ObfuscatedName("dwd.core.await.TaskExtensions+<AsIEnumerator>d__0")]
		public sealed class _AsIEnumerator_d__0 : Object
		{
			// Token: 0x06002949 RID: 10569 RVA: 0x000AD480 File Offset: 0x000AB680
			// Note: this type is marked as 'beforefieldinit'.
			static _AsIEnumerator_d__0()
			{
				Il2CppClassPointerStore<TaskExtensions._AsIEnumerator_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskExtensions>.NativeClassPtr, "<AsIEnumerator>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskExtensions._AsIEnumerator_d__0>.NativeClassPtr);
				TaskExtensions._AsIEnumerator_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExtensions._AsIEnumerator_d__0>.NativeClassPtr, "<>1__state");
				TaskExtensions._AsIEnumerator_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExtensions._AsIEnumerator_d__0>.NativeClassPtr, "<>2__current");
				TaskExtensions._AsIEnumerator_d__0.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExtensions._AsIEnumerator_d__0>.NativeClassPtr, "task");
				TaskExtensions._AsIEnumerator_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExtensions._AsIEnumerator_d__0>.NativeClassPtr, 100667944);
				TaskExtensions._AsIEnumerator_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExtensions._AsIEnumerator_d__0>.NativeClassPtr, 100667945);
				TaskExtensions._AsIEnumerator_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExtensions._AsIEnumerator_d__0>.NativeClassPtr, 100667946);
				TaskExtensions._AsIEnumerator_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExtensions._AsIEnumerator_d__0>.NativeClassPtr, 100667947);
				TaskExtensions._AsIEnumerator_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExtensions._AsIEnumerator_d__0>.NativeClassPtr, 100667948);
				TaskExtensions._AsIEnumerator_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExtensions._AsIEnumerator_d__0>.NativeClassPtr, 100667949);
			}

			// Token: 0x0600294A RID: 10570 RVA: 0x000AD560 File Offset: 0x000AB760
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AsIEnumerator_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskExtensions._AsIEnumerator_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExtensions._AsIEnumerator_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600294B RID: 10571 RVA: 0x000AD5A8 File Offset: 0x000AB7A8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExtensions._AsIEnumerator_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600294C RID: 10572 RVA: 0x000AD5DC File Offset: 0x000AB7DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885993, XrefRangeEnd = 885995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExtensions._AsIEnumerator_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BB9 RID: 3001
			// (get) Token: 0x0600294D RID: 10573 RVA: 0x000AD618 File Offset: 0x000AB818
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExtensions._AsIEnumerator_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600294E RID: 10574 RVA: 0x000AD658 File Offset: 0x000AB858
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885995, XrefRangeEnd = 886000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExtensions._AsIEnumerator_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BBA RID: 3002
			// (get) Token: 0x0600294F RID: 10575 RVA: 0x000AD68C File Offset: 0x000AB88C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExtensions._AsIEnumerator_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002950 RID: 10576 RVA: 0x00012C45 File Offset: 0x00010E45
			public _AsIEnumerator_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BB6 RID: 2998
			// (get) Token: 0x06002951 RID: 10577 RVA: 0x000AD6CC File Offset: 0x000AB8CC
			// (set) Token: 0x06002952 RID: 10578 RVA: 0x00012C4E File Offset: 0x00010E4E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExtensions._AsIEnumerator_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExtensions._AsIEnumerator_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BB7 RID: 2999
			// (get) Token: 0x06002953 RID: 10579 RVA: 0x000AD6F4 File Offset: 0x000AB8F4
			// (set) Token: 0x06002954 RID: 10580 RVA: 0x00012C69 File Offset: 0x00010E69
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExtensions._AsIEnumerator_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExtensions._AsIEnumerator_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BB8 RID: 3000
			// (get) Token: 0x06002955 RID: 10581 RVA: 0x000AD724 File Offset: 0x000AB924
			// (set) Token: 0x06002956 RID: 10582 RVA: 0x00012C88 File Offset: 0x00010E88
			public unsafe Task task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExtensions._AsIEnumerator_d__0.NativeFieldInfoPtr_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExtensions._AsIEnumerator_d__0.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BED RID: 7149
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001BEE RID: 7150
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001BEF RID: 7151
			private static readonly IntPtr NativeFieldInfoPtr_task;

			// Token: 0x04001BF0 RID: 7152
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001BF1 RID: 7153
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BF2 RID: 7154
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001BF3 RID: 7155
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001BF4 RID: 7156
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BF5 RID: 7157
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200039F RID: 927
		private sealed class MethodInfoStoreGeneric_AsCommand_Public_Static_TaskCommand_1_T_Task_1_T_0<T>
		{
			// Token: 0x04001BF6 RID: 7158
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskExtensions.NativeMethodInfoPtr_AsCommand_Public_Static_TaskCommand_1_T_Task_1_T_0, Il2CppClassPointerStore<TaskExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
