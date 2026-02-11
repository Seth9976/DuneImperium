using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Threading.Tasks;

namespace dwd.core.commands
{
	// Token: 0x02000020 RID: 32
	public static class TaskCommands : Object
	{
		// Token: 0x0600014A RID: 330 RVA: 0x0000279A File Offset: 0x0000099A
		// Note: this type is marked as 'beforefieldinit'.
		static TaskCommands()
		{
			Il2CppClassPointerStore<TaskCommands>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "TaskCommands");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskCommands>.NativeClassPtr);
			TaskCommands.NativeMethodInfoPtr_RunTask_Public_Static_IEnumerator_Func_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCommands>.NativeClassPtr, 100663680);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000A24C File Offset: 0x0000844C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209154, XrefRangeEnd = 1209159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator RunTask(Func<Task> task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCommands.NativeMethodInfoPtr_RunTask_Public_Static_IEnumerator_Func_1_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000027D3 File Offset: 0x000009D3
		public TaskCommands(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_RunTask_Public_Static_IEnumerator_Func_1_Task_0;

		// Token: 0x02000082 RID: 130
		[ObfuscatedName("dwd.core.commands.TaskCommands+<RunTask>d__0")]
		public sealed class _RunTask_d__0 : Object
		{
			// Token: 0x0600048E RID: 1166 RVA: 0x00015268 File Offset: 0x00013468
			// Note: this type is marked as 'beforefieldinit'.
			static _RunTask_d__0()
			{
				Il2CppClassPointerStore<TaskCommands._RunTask_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskCommands>.NativeClassPtr, "<RunTask>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskCommands._RunTask_d__0>.NativeClassPtr);
				TaskCommands._RunTask_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskCommands._RunTask_d__0>.NativeClassPtr, "<>1__state");
				TaskCommands._RunTask_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskCommands._RunTask_d__0>.NativeClassPtr, "<>2__current");
				TaskCommands._RunTask_d__0.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskCommands._RunTask_d__0>.NativeClassPtr, "task");
				TaskCommands._RunTask_d__0.NativeFieldInfoPtr__runTask_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskCommands._RunTask_d__0>.NativeClassPtr, "<runTask>5__2");
				TaskCommands._RunTask_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCommands._RunTask_d__0>.NativeClassPtr, 100663681);
				TaskCommands._RunTask_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCommands._RunTask_d__0>.NativeClassPtr, 100663682);
				TaskCommands._RunTask_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCommands._RunTask_d__0>.NativeClassPtr, 100663683);
				TaskCommands._RunTask_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCommands._RunTask_d__0>.NativeClassPtr, 100663684);
				TaskCommands._RunTask_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCommands._RunTask_d__0>.NativeClassPtr, 100663685);
				TaskCommands._RunTask_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCommands._RunTask_d__0>.NativeClassPtr, 100663686);
			}

			// Token: 0x0600048F RID: 1167 RVA: 0x0001535C File Offset: 0x0001355C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunTask_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskCommands._RunTask_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCommands._RunTask_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000490 RID: 1168 RVA: 0x000153A4 File Offset: 0x000135A4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCommands._RunTask_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000491 RID: 1169 RVA: 0x000153D8 File Offset: 0x000135D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209141, XrefRangeEnd = 1209149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCommands._RunTask_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000492 RID: 1170 RVA: 0x00015414 File Offset: 0x00013614
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCommands._RunTask_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000493 RID: 1171 RVA: 0x00015454 File Offset: 0x00013654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209149, XrefRangeEnd = 1209154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCommands._RunTask_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000494 RID: 1172 RVA: 0x00015488 File Offset: 0x00013688
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCommands._RunTask_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000495 RID: 1173 RVA: 0x00003F7F File Offset: 0x0000217F
			public _RunTask_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x06000496 RID: 1174 RVA: 0x000154C8 File Offset: 0x000136C8
			// (set) Token: 0x06000497 RID: 1175 RVA: 0x00003F88 File Offset: 0x00002188
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskCommands._RunTask_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskCommands._RunTask_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x06000498 RID: 1176 RVA: 0x000154F0 File Offset: 0x000136F0
			// (set) Token: 0x06000499 RID: 1177 RVA: 0x00003FA3 File Offset: 0x000021A3
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskCommands._RunTask_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskCommands._RunTask_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x0600049A RID: 1178 RVA: 0x00015520 File Offset: 0x00013720
			// (set) Token: 0x0600049B RID: 1179 RVA: 0x00003FC2 File Offset: 0x000021C2
			public unsafe Func<Task> task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskCommands._RunTask_d__0.NativeFieldInfoPtr_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Task>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskCommands._RunTask_d__0.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x0600049C RID: 1180 RVA: 0x00015550 File Offset: 0x00013750
			// (set) Token: 0x0600049D RID: 1181 RVA: 0x00003FE1 File Offset: 0x000021E1
			public unsafe Task _runTask_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskCommands._RunTask_d__0.NativeFieldInfoPtr__runTask_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskCommands._RunTask_d__0.NativeFieldInfoPtr__runTask_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002C6 RID: 710
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002C7 RID: 711
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002C8 RID: 712
			private static readonly IntPtr NativeFieldInfoPtr_task;

			// Token: 0x040002C9 RID: 713
			private static readonly IntPtr NativeFieldInfoPtr__runTask_5__2;

			// Token: 0x040002CA RID: 714
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002CB RID: 715
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002CC RID: 716
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002CD RID: 717
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002CE RID: 718
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002CF RID: 719
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
