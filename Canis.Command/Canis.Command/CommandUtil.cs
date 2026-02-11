using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Utils.commands
{
	// Token: 0x02000003 RID: 3
	public static class CommandUtil : Object
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000024AC File Offset: 0x000006AC
		// Note: this type is marked as 'beforefieldinit'.
		static CommandUtil()
		{
			Il2CppClassPointerStore<CommandUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.Command.dll", "Utils.commands", "CommandUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtil>.NativeClassPtr);
			CommandUtil.NativeFieldInfoPtr_paused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtil>.NativeClassPtr, "paused");
			CommandUtil.NativeMethodInfoPtr_get_Paused_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtil>.NativeClassPtr, 100663299);
			CommandUtil.NativeMethodInfoPtr_set_Paused_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtil>.NativeClassPtr, 100663300);
			CommandUtil.NativeMethodInfoPtr_Execute_Public_Static_Void_IEnumerator_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtil>.NativeClassPtr, 100663301);
			CommandUtil.NativeMethodInfoPtr_Execute_Public_Static_Task_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtil>.NativeClassPtr, 100663302);
			CommandUtil.NativeMethodInfoPtr_RunCoroutine_Public_Static_Task_IEnumerator_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtil>.NativeClassPtr, 100663303);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002554 File Offset: 0x00000754
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002584 File Offset: 0x00000784
		public unsafe static bool Paused
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273611, XrefRangeEnd = 1273613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandUtil.NativeMethodInfoPtr_get_Paused_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273613, XrefRangeEnd = 1273615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandUtil.NativeMethodInfoPtr_set_Paused_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000025B8 File Offset: 0x000007B8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1273621, RefRangeEnd = 1273626, XrefRangeStart = 1273615, XrefRangeEnd = 1273621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(this IEnumerator coroutine, Nullable<int> delayMillis = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coroutine);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(delayMillis));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandUtil.NativeMethodInfoPtr_Execute_Public_Static_Void_IEnumerator_Nullable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002608 File Offset: 0x00000808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273626, XrefRangeEnd = 1273636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task Execute(this Task task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandUtil.NativeMethodInfoPtr_Execute_Public_Static_Task_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000264C File Offset: 0x0000084C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1273646, RefRangeEnd = 1273648, XrefRangeStart = 1273636, XrefRangeEnd = 1273646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task RunCoroutine(IEnumerator coroutine, Nullable<int> delayMillis = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coroutine);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(delayMillis));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandUtil.NativeMethodInfoPtr_RunCoroutine_Public_Static_Task_IEnumerator_Nullable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002059 File Offset: 0x00000259
		public CommandUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000026A8 File Offset: 0x000008A8
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002062 File Offset: 0x00000262
		public unsafe static bool paused
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(CommandUtil.NativeFieldInfoPtr_paused, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CommandUtil.NativeFieldInfoPtr_paused, (void*)(&value));
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_paused;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_get_Paused_Public_Static_get_Boolean_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_set_Paused_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Static_Void_IEnumerator_Nullable_1_Int32_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Static_Task_Task_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_RunCoroutine_Public_Static_Task_IEnumerator_Nullable_1_Int32_0;

		// Token: 0x02000006 RID: 6
		[ObfuscatedName("Utils.commands.CommandUtil+<Execute>d__4")]
		public sealed class _Execute_d__4 : ValueType
		{
			// Token: 0x06000021 RID: 33 RVA: 0x000028B4 File Offset: 0x00000AB4
			// Note: this type is marked as 'beforefieldinit'.
			static _Execute_d__4()
			{
				Il2CppClassPointerStore<CommandUtil._Execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtil>.NativeClassPtr, "<Execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtil._Execute_d__4>.NativeClassPtr);
				CommandUtil._Execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtil._Execute_d__4>.NativeClassPtr, "<>1__state");
				CommandUtil._Execute_d__4.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtil._Execute_d__4>.NativeClassPtr, "<>t__builder");
				CommandUtil._Execute_d__4.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtil._Execute_d__4>.NativeClassPtr, "coroutine");
				CommandUtil._Execute_d__4.NativeFieldInfoPtr_delayMillis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtil._Execute_d__4>.NativeClassPtr, "delayMillis");
				CommandUtil._Execute_d__4.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtil._Execute_d__4>.NativeClassPtr, "<>u__1");
				CommandUtil._Execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtil._Execute_d__4>.NativeClassPtr, 100663304);
				CommandUtil._Execute_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtil._Execute_d__4>.NativeClassPtr, 100663305);
			}

			// Token: 0x06000022 RID: 34 RVA: 0x0000296C File Offset: 0x00000B6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273516, XrefRangeEnd = 1273540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandUtil._Execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000023 RID: 35 RVA: 0x000029A4 File Offset: 0x00000BA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandUtil._Execute_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000024 RID: 36 RVA: 0x0000213F File Offset: 0x0000033F
			public _Execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000025 RID: 37 RVA: 0x00002148 File Offset: 0x00000348
			public _Execute_d__4()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtil._Execute_d__4>.NativeClassPtr))
			{
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000026 RID: 38 RVA: 0x000029EC File Offset: 0x00000BEC
			// (set) Token: 0x06000027 RID: 39 RVA: 0x0000215A File Offset: 0x0000035A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._Execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._Execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000028 RID: 40 RVA: 0x00002A14 File Offset: 0x00000C14
			// (set) Token: 0x06000029 RID: 41 RVA: 0x00002175 File Offset: 0x00000375
			public AsyncVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._Execute_d__4.NativeFieldInfoPtr___t__builder);
					return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._Execute_d__4.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600002A RID: 42 RVA: 0x00002A44 File Offset: 0x00000C44
			// (set) Token: 0x0600002B RID: 43 RVA: 0x000021A3 File Offset: 0x000003A3
			public unsafe IEnumerator coroutine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._Execute_d__4.NativeFieldInfoPtr_coroutine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._Execute_d__4.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x0600002C RID: 44 RVA: 0x00002A74 File Offset: 0x00000C74
			// (set) Token: 0x0600002D RID: 45 RVA: 0x000021C2 File Offset: 0x000003C2
			public Nullable<int> delayMillis
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._Execute_d__4.NativeFieldInfoPtr_delayMillis);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._Execute_d__4.NativeFieldInfoPtr_delayMillis), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x0600002E RID: 46 RVA: 0x00002AA4 File Offset: 0x00000CA4
			// (set) Token: 0x0600002F RID: 47 RVA: 0x000021F0 File Offset: 0x000003F0
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._Execute_d__4.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._Execute_d__4.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000010 RID: 16
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000011 RID: 17
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000012 RID: 18
			private static readonly IntPtr NativeFieldInfoPtr_coroutine;

			// Token: 0x04000013 RID: 19
			private static readonly IntPtr NativeFieldInfoPtr_delayMillis;

			// Token: 0x04000014 RID: 20
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000015 RID: 21
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000016 RID: 22
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000007 RID: 7
		[ObfuscatedName("Utils.commands.CommandUtil+<Execute>d__5")]
		public sealed class _Execute_d__5 : ValueType
		{
			// Token: 0x06000030 RID: 48 RVA: 0x00002AD4 File Offset: 0x00000CD4
			// Note: this type is marked as 'beforefieldinit'.
			static _Execute_d__5()
			{
				Il2CppClassPointerStore<CommandUtil._Execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtil>.NativeClassPtr, "<Execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtil._Execute_d__5>.NativeClassPtr);
				CommandUtil._Execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtil._Execute_d__5>.NativeClassPtr, "<>1__state");
				CommandUtil._Execute_d__5.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtil._Execute_d__5>.NativeClassPtr, "<>t__builder");
				CommandUtil._Execute_d__5.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtil._Execute_d__5>.NativeClassPtr, "task");
				CommandUtil._Execute_d__5.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtil._Execute_d__5>.NativeClassPtr, "<>u__1");
				CommandUtil._Execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtil._Execute_d__5>.NativeClassPtr, 100663306);
				CommandUtil._Execute_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtil._Execute_d__5>.NativeClassPtr, 100663307);
			}

			// Token: 0x06000031 RID: 49 RVA: 0x00002B78 File Offset: 0x00000D78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273540, XrefRangeEnd = 1273559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandUtil._Execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000032 RID: 50 RVA: 0x00002BB0 File Offset: 0x00000DB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273559, XrefRangeEnd = 1273563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandUtil._Execute_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000033 RID: 51 RVA: 0x0000221E File Offset: 0x0000041E
			public _Execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000034 RID: 52 RVA: 0x00002227 File Offset: 0x00000427
			public _Execute_d__5()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtil._Execute_d__5>.NativeClassPtr))
			{
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000035 RID: 53 RVA: 0x00002BF8 File Offset: 0x00000DF8
			// (set) Token: 0x06000036 RID: 54 RVA: 0x00002239 File Offset: 0x00000439
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._Execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._Execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000037 RID: 55 RVA: 0x00002C20 File Offset: 0x00000E20
			// (set) Token: 0x06000038 RID: 56 RVA: 0x00002254 File Offset: 0x00000454
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._Execute_d__5.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._Execute_d__5.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000039 RID: 57 RVA: 0x00002C50 File Offset: 0x00000E50
			// (set) Token: 0x0600003A RID: 58 RVA: 0x00002282 File Offset: 0x00000482
			public unsafe Task task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._Execute_d__5.NativeFieldInfoPtr_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._Execute_d__5.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600003B RID: 59 RVA: 0x00002C80 File Offset: 0x00000E80
			// (set) Token: 0x0600003C RID: 60 RVA: 0x000022A1 File Offset: 0x000004A1
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._Execute_d__5.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._Execute_d__5.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000017 RID: 23
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000018 RID: 24
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000019 RID: 25
			private static readonly IntPtr NativeFieldInfoPtr_task;

			// Token: 0x0400001A RID: 26
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400001B RID: 27
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400001C RID: 28
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000008 RID: 8
		[ObfuscatedName("Utils.commands.CommandUtil+<RunCoroutine>d__6")]
		public sealed class _RunCoroutine_d__6 : ValueType
		{
			// Token: 0x0600003D RID: 61 RVA: 0x00002CB0 File Offset: 0x00000EB0
			// Note: this type is marked as 'beforefieldinit'.
			static _RunCoroutine_d__6()
			{
				Il2CppClassPointerStore<CommandUtil._RunCoroutine_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtil>.NativeClassPtr, "<RunCoroutine>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtil._RunCoroutine_d__6>.NativeClassPtr);
				CommandUtil._RunCoroutine_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtil._RunCoroutine_d__6>.NativeClassPtr, "<>1__state");
				CommandUtil._RunCoroutine_d__6.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtil._RunCoroutine_d__6>.NativeClassPtr, "<>t__builder");
				CommandUtil._RunCoroutine_d__6.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtil._RunCoroutine_d__6>.NativeClassPtr, "coroutine");
				CommandUtil._RunCoroutine_d__6.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtil._RunCoroutine_d__6>.NativeClassPtr, "<>u__1");
				CommandUtil._RunCoroutine_d__6.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtil._RunCoroutine_d__6>.NativeClassPtr, "<>u__2");
				CommandUtil._RunCoroutine_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtil._RunCoroutine_d__6>.NativeClassPtr, 100663308);
				CommandUtil._RunCoroutine_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtil._RunCoroutine_d__6>.NativeClassPtr, 100663309);
			}

			// Token: 0x0600003E RID: 62 RVA: 0x00002D68 File Offset: 0x00000F68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273563, XrefRangeEnd = 1273607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandUtil._RunCoroutine_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600003F RID: 63 RVA: 0x00002DA0 File Offset: 0x00000FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273607, XrefRangeEnd = 1273611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandUtil._RunCoroutine_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000040 RID: 64 RVA: 0x000022CF File Offset: 0x000004CF
			public _RunCoroutine_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000041 RID: 65 RVA: 0x000022D8 File Offset: 0x000004D8
			public _RunCoroutine_d__6()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtil._RunCoroutine_d__6>.NativeClassPtr))
			{
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000042 RID: 66 RVA: 0x00002DE8 File Offset: 0x00000FE8
			// (set) Token: 0x06000043 RID: 67 RVA: 0x000022EA File Offset: 0x000004EA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._RunCoroutine_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._RunCoroutine_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000044 RID: 68 RVA: 0x00002E10 File Offset: 0x00001010
			// (set) Token: 0x06000045 RID: 69 RVA: 0x00002305 File Offset: 0x00000505
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._RunCoroutine_d__6.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._RunCoroutine_d__6.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000046 RID: 70 RVA: 0x00002E40 File Offset: 0x00001040
			// (set) Token: 0x06000047 RID: 71 RVA: 0x00002333 File Offset: 0x00000533
			public unsafe IEnumerator coroutine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._RunCoroutine_d__6.NativeFieldInfoPtr_coroutine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._RunCoroutine_d__6.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000048 RID: 72 RVA: 0x00002E70 File Offset: 0x00001070
			// (set) Token: 0x06000049 RID: 73 RVA: 0x00002352 File Offset: 0x00000552
			public unsafe YieldAwaitable.YieldAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._RunCoroutine_d__6.NativeFieldInfoPtr___u__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._RunCoroutine_d__6.NativeFieldInfoPtr___u__1)) = value;
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x0600004A RID: 74 RVA: 0x00002E98 File Offset: 0x00001098
			// (set) Token: 0x0600004B RID: 75 RVA: 0x0000236D File Offset: 0x0000056D
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._RunCoroutine_d__6.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandUtil._RunCoroutine_d__6.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400001D RID: 29
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400001E RID: 30
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400001F RID: 31
			private static readonly IntPtr NativeFieldInfoPtr_coroutine;

			// Token: 0x04000020 RID: 32
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000021 RID: 33
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04000022 RID: 34
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000023 RID: 35
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
