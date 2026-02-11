using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.commands
{
	// Token: 0x02000012 RID: 18
	public static class CommandRegistry : Object
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00007020 File Offset: 0x00005220
		// Note: this type is marked as 'beforefieldinit'.
		static CommandRegistry()
		{
			Il2CppClassPointerStore<CommandRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "CommandRegistry");
			CommandRegistry.NativeFieldInfoPtr_runningCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRegistry>.NativeClassPtr, "runningCommands");
			CommandRegistry.NativeMethodInfoPtr_NewCommand_Public_Static_Void_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry>.NativeClassPtr, 100663405);
			CommandRegistry.NativeMethodInfoPtr_PurgeDeadCommands_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry>.NativeClassPtr, 100663406);
			CommandRegistry.NativeMethodInfoPtr_GetAllCommands_Public_Static_IEnumerable_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry>.NativeClassPtr, 100663407);
			CommandRegistry.NativeMethodInfoPtr_GetPendingCommands_Public_Static_IEnumerable_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry>.NativeClassPtr, 100663408);
			CommandRegistry.NativeMethodInfoPtr_GetRunningCommands_Public_Static_IEnumerable_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry>.NativeClassPtr, 100663409);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000070C0 File Offset: 0x000052C0
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 1207075, RefRangeEnd = 1207119, XrefRangeStart = 1207055, XrefRangeEnd = 1207075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NewCommand(Command command)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry.NativeMethodInfoPtr_NewCommand_Public_Static_Void_Command_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000070F8 File Offset: 0x000052F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1207147, RefRangeEnd = 1207149, XrefRangeStart = 1207119, XrefRangeEnd = 1207147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PurgeDeadCommands()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry.NativeMethodInfoPtr_PurgeDeadCommands_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00007120 File Offset: 0x00005320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1207154, RefRangeEnd = 1207155, XrefRangeStart = 1207149, XrefRangeEnd = 1207154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Command> GetAllCommands()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry.NativeMethodInfoPtr_GetAllCommands_Public_Static_IEnumerable_1_Command_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Command>>(intPtr3) : null;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00007154 File Offset: 0x00005354
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1207160, RefRangeEnd = 1207161, XrefRangeStart = 1207155, XrefRangeEnd = 1207160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Command> GetPendingCommands()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry.NativeMethodInfoPtr_GetPendingCommands_Public_Static_IEnumerable_1_Command_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Command>>(intPtr3) : null;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00007188 File Offset: 0x00005388
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1207166, RefRangeEnd = 1207181, XrefRangeStart = 1207161, XrefRangeEnd = 1207166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Command> GetRunningCommands()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry.NativeMethodInfoPtr_GetRunningCommands_Public_Static_IEnumerable_1_Command_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Command>>(intPtr3) : null;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000024FB File Offset: 0x000006FB
		public CommandRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x000071BC File Offset: 0x000053BC
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002504 File Offset: 0x00000704
		public unsafe static List<WeakReference> runningCommands
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CommandRegistry.NativeFieldInfoPtr_runningCommands, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeakReference>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CommandRegistry.NativeFieldInfoPtr_runningCommands, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_runningCommands;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_NewCommand_Public_Static_Void_Command_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_PurgeDeadCommands_Public_Static_Void_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCommands_Public_Static_IEnumerable_1_Command_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_GetPendingCommands_Public_Static_IEnumerable_1_Command_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_GetRunningCommands_Public_Static_IEnumerable_1_Command_0;

		// Token: 0x02000042 RID: 66
		[ObfuscatedName("dwd.core.commands.CommandRegistry+<GetAllCommands>d__4")]
		public sealed class _GetAllCommands_d__4 : Object
		{
			// Token: 0x06000272 RID: 626 RVA: 0x0000DD68 File Offset: 0x0000BF68
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAllCommands_d__4()
			{
				Il2CppClassPointerStore<CommandRegistry._GetAllCommands_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandRegistry>.NativeClassPtr, "<GetAllCommands>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandRegistry._GetAllCommands_d__4>.NativeClassPtr);
				CommandRegistry._GetAllCommands_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRegistry._GetAllCommands_d__4>.NativeClassPtr, "<>1__state");
				CommandRegistry._GetAllCommands_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRegistry._GetAllCommands_d__4>.NativeClassPtr, "<>2__current");
				CommandRegistry._GetAllCommands_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRegistry._GetAllCommands_d__4>.NativeClassPtr, "<>l__initialThreadId");
				CommandRegistry._GetAllCommands_d__4.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRegistry._GetAllCommands_d__4>.NativeClassPtr, "<>7__wrap1");
				CommandRegistry._GetAllCommands_d__4.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRegistry._GetAllCommands_d__4>.NativeClassPtr, "<>7__wrap2");
				CommandRegistry._GetAllCommands_d__4.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRegistry._GetAllCommands_d__4>.NativeClassPtr, "<i>5__4");
				CommandRegistry._GetAllCommands_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetAllCommands_d__4>.NativeClassPtr, 100663410);
				CommandRegistry._GetAllCommands_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetAllCommands_d__4>.NativeClassPtr, 100663411);
				CommandRegistry._GetAllCommands_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetAllCommands_d__4>.NativeClassPtr, 100663412);
				CommandRegistry._GetAllCommands_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetAllCommands_d__4>.NativeClassPtr, 100663413);
				CommandRegistry._GetAllCommands_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_commands_Command__get_Current_Private_Virtual_Final_New_get_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetAllCommands_d__4>.NativeClassPtr, 100663414);
				CommandRegistry._GetAllCommands_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetAllCommands_d__4>.NativeClassPtr, 100663415);
				CommandRegistry._GetAllCommands_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetAllCommands_d__4>.NativeClassPtr, 100663416);
				CommandRegistry._GetAllCommands_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_commands_Command__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetAllCommands_d__4>.NativeClassPtr, 100663417);
				CommandRegistry._GetAllCommands_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetAllCommands_d__4>.NativeClassPtr, 100663418);
			}

			// Token: 0x06000273 RID: 627 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetAllCommands_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandRegistry._GetAllCommands_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetAllCommands_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000274 RID: 628 RVA: 0x0000DF08 File Offset: 0x0000C108
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1206939, RefRangeEnd = 1206940, XrefRangeStart = 1206936, XrefRangeEnd = 1206939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetAllCommands_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000275 RID: 629 RVA: 0x0000DF3C File Offset: 0x0000C13C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206940, XrefRangeEnd = 1206971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetAllCommands_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000276 RID: 630 RVA: 0x0000DF78 File Offset: 0x0000C178
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206971, XrefRangeEnd = 1206972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetAllCommands_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x06000277 RID: 631 RVA: 0x0000DFAC File Offset: 0x0000C1AC
			public unsafe Command System.Collections.Generic.IEnumerator<dwd.core.commands.Command>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetAllCommands_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_commands_Command__get_Current_Private_Virtual_Final_New_get_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
				}
			}

			// Token: 0x06000278 RID: 632 RVA: 0x0000DFEC File Offset: 0x0000C1EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206972, XrefRangeEnd = 1206977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetAllCommands_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x06000279 RID: 633 RVA: 0x0000E020 File Offset: 0x0000C220
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetAllCommands_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600027A RID: 634 RVA: 0x0000E060 File Offset: 0x0000C260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206977, XrefRangeEnd = 1206979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Command> System_Collections_Generic_IEnumerable_dwd_core_commands_Command__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetAllCommands_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_commands_Command__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Command>>(intPtr3) : null;
			}

			// Token: 0x0600027B RID: 635 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetAllCommands_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600027C RID: 636 RVA: 0x000030EE File Offset: 0x000012EE
			public _GetAllCommands_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x0600027D RID: 637 RVA: 0x0000E0E0 File Offset: 0x0000C2E0
			// (set) Token: 0x0600027E RID: 638 RVA: 0x000030F7 File Offset: 0x000012F7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetAllCommands_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetAllCommands_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x0600027F RID: 639 RVA: 0x0000E108 File Offset: 0x0000C308
			// (set) Token: 0x06000280 RID: 640 RVA: 0x00003112 File Offset: 0x00001312
			public unsafe Command __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetAllCommands_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetAllCommands_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x06000281 RID: 641 RVA: 0x0000E138 File Offset: 0x0000C338
			// (set) Token: 0x06000282 RID: 642 RVA: 0x00003131 File Offset: 0x00001331
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetAllCommands_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetAllCommands_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x06000283 RID: 643 RVA: 0x0000E160 File Offset: 0x0000C360
			// (set) Token: 0x06000284 RID: 644 RVA: 0x0000314C File Offset: 0x0000134C
			public unsafe List<WeakReference> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetAllCommands_d__4.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeakReference>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetAllCommands_d__4.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x06000285 RID: 645 RVA: 0x0000E190 File Offset: 0x0000C390
			// (set) Token: 0x06000286 RID: 646 RVA: 0x0000316B File Offset: 0x0000136B
			public unsafe bool __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetAllCommands_d__4.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetAllCommands_d__4.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x06000287 RID: 647 RVA: 0x0000E1B8 File Offset: 0x0000C3B8
			// (set) Token: 0x06000288 RID: 648 RVA: 0x00003186 File Offset: 0x00001386
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetAllCommands_d__4.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetAllCommands_d__4.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x0400017F RID: 383
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000180 RID: 384
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000181 RID: 385
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000182 RID: 386
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000183 RID: 387
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04000184 RID: 388
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x04000185 RID: 389
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000186 RID: 390
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000187 RID: 391
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000188 RID: 392
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000189 RID: 393
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_commands_Command__get_Current_Private_Virtual_Final_New_get_Command_0;

			// Token: 0x0400018A RID: 394
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400018B RID: 395
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400018C RID: 396
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_commands_Command__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Command_0;

			// Token: 0x0400018D RID: 397
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000043 RID: 67
		[ObfuscatedName("dwd.core.commands.CommandRegistry+<GetPendingCommands>d__5")]
		public sealed class _GetPendingCommands_d__5 : Object
		{
			// Token: 0x06000289 RID: 649 RVA: 0x0000E1E0 File Offset: 0x0000C3E0
			// Note: this type is marked as 'beforefieldinit'.
			static _GetPendingCommands_d__5()
			{
				Il2CppClassPointerStore<CommandRegistry._GetPendingCommands_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandRegistry>.NativeClassPtr, "<GetPendingCommands>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandRegistry._GetPendingCommands_d__5>.NativeClassPtr);
				CommandRegistry._GetPendingCommands_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRegistry._GetPendingCommands_d__5>.NativeClassPtr, "<>1__state");
				CommandRegistry._GetPendingCommands_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRegistry._GetPendingCommands_d__5>.NativeClassPtr, "<>2__current");
				CommandRegistry._GetPendingCommands_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRegistry._GetPendingCommands_d__5>.NativeClassPtr, "<>l__initialThreadId");
				CommandRegistry._GetPendingCommands_d__5.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRegistry._GetPendingCommands_d__5>.NativeClassPtr, "<>7__wrap1");
				CommandRegistry._GetPendingCommands_d__5.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRegistry._GetPendingCommands_d__5>.NativeClassPtr, "<>7__wrap2");
				CommandRegistry._GetPendingCommands_d__5.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRegistry._GetPendingCommands_d__5>.NativeClassPtr, "<i>5__4");
				CommandRegistry._GetPendingCommands_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetPendingCommands_d__5>.NativeClassPtr, 100663419);
				CommandRegistry._GetPendingCommands_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetPendingCommands_d__5>.NativeClassPtr, 100663420);
				CommandRegistry._GetPendingCommands_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetPendingCommands_d__5>.NativeClassPtr, 100663421);
				CommandRegistry._GetPendingCommands_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetPendingCommands_d__5>.NativeClassPtr, 100663422);
				CommandRegistry._GetPendingCommands_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_commands_Command__get_Current_Private_Virtual_Final_New_get_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetPendingCommands_d__5>.NativeClassPtr, 100663423);
				CommandRegistry._GetPendingCommands_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetPendingCommands_d__5>.NativeClassPtr, 100663424);
				CommandRegistry._GetPendingCommands_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetPendingCommands_d__5>.NativeClassPtr, 100663425);
				CommandRegistry._GetPendingCommands_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_commands_Command__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetPendingCommands_d__5>.NativeClassPtr, 100663426);
				CommandRegistry._GetPendingCommands_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetPendingCommands_d__5>.NativeClassPtr, 100663427);
			}

			// Token: 0x0600028A RID: 650 RVA: 0x0000E338 File Offset: 0x0000C538
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetPendingCommands_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandRegistry._GetPendingCommands_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetPendingCommands_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600028B RID: 651 RVA: 0x0000E380 File Offset: 0x0000C580
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1206939, RefRangeEnd = 1206940, XrefRangeStart = 1206939, XrefRangeEnd = 1206940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetPendingCommands_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600028C RID: 652 RVA: 0x0000E3B4 File Offset: 0x0000C5B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206979, XrefRangeEnd = 1207010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetPendingCommands_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600028D RID: 653 RVA: 0x0000E3F0 File Offset: 0x0000C5F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetPendingCommands_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x0600028E RID: 654 RVA: 0x0000E424 File Offset: 0x0000C624
			public unsafe Command System.Collections.Generic.IEnumerator<dwd.core.commands.Command>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetPendingCommands_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_commands_Command__get_Current_Private_Virtual_Final_New_get_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
				}
			}

			// Token: 0x0600028F RID: 655 RVA: 0x0000E464 File Offset: 0x0000C664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207010, XrefRangeEnd = 1207015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetPendingCommands_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x06000290 RID: 656 RVA: 0x0000E498 File Offset: 0x0000C698
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetPendingCommands_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000291 RID: 657 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207015, XrefRangeEnd = 1207017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Command> System_Collections_Generic_IEnumerable_dwd_core_commands_Command__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetPendingCommands_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_commands_Command__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Command>>(intPtr3) : null;
			}

			// Token: 0x06000292 RID: 658 RVA: 0x0000E518 File Offset: 0x0000C718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetPendingCommands_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000293 RID: 659 RVA: 0x000031A1 File Offset: 0x000013A1
			public _GetPendingCommands_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x06000294 RID: 660 RVA: 0x0000E558 File Offset: 0x0000C758
			// (set) Token: 0x06000295 RID: 661 RVA: 0x000031AA File Offset: 0x000013AA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetPendingCommands_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetPendingCommands_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x06000296 RID: 662 RVA: 0x0000E580 File Offset: 0x0000C780
			// (set) Token: 0x06000297 RID: 663 RVA: 0x000031C5 File Offset: 0x000013C5
			public unsafe Command __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetPendingCommands_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetPendingCommands_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x06000298 RID: 664 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
			// (set) Token: 0x06000299 RID: 665 RVA: 0x000031E4 File Offset: 0x000013E4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetPendingCommands_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetPendingCommands_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x0600029A RID: 666 RVA: 0x0000E5D8 File Offset: 0x0000C7D8
			// (set) Token: 0x0600029B RID: 667 RVA: 0x000031FF File Offset: 0x000013FF
			public unsafe List<WeakReference> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetPendingCommands_d__5.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeakReference>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetPendingCommands_d__5.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x0600029C RID: 668 RVA: 0x0000E608 File Offset: 0x0000C808
			// (set) Token: 0x0600029D RID: 669 RVA: 0x0000321E File Offset: 0x0000141E
			public unsafe bool __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetPendingCommands_d__5.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetPendingCommands_d__5.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x0600029E RID: 670 RVA: 0x0000E630 File Offset: 0x0000C830
			// (set) Token: 0x0600029F RID: 671 RVA: 0x00003239 File Offset: 0x00001439
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetPendingCommands_d__5.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetPendingCommands_d__5.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x0400018E RID: 398
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400018F RID: 399
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000190 RID: 400
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000191 RID: 401
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000192 RID: 402
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04000193 RID: 403
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x04000194 RID: 404
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000195 RID: 405
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000196 RID: 406
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000197 RID: 407
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000198 RID: 408
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_commands_Command__get_Current_Private_Virtual_Final_New_get_Command_0;

			// Token: 0x04000199 RID: 409
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400019A RID: 410
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400019B RID: 411
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_commands_Command__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Command_0;

			// Token: 0x0400019C RID: 412
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000044 RID: 68
		[ObfuscatedName("dwd.core.commands.CommandRegistry+<GetRunningCommands>d__6")]
		public sealed class _GetRunningCommands_d__6 : Object
		{
			// Token: 0x060002A0 RID: 672 RVA: 0x0000E658 File Offset: 0x0000C858
			// Note: this type is marked as 'beforefieldinit'.
			static _GetRunningCommands_d__6()
			{
				Il2CppClassPointerStore<CommandRegistry._GetRunningCommands_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandRegistry>.NativeClassPtr, "<GetRunningCommands>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandRegistry._GetRunningCommands_d__6>.NativeClassPtr);
				CommandRegistry._GetRunningCommands_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRegistry._GetRunningCommands_d__6>.NativeClassPtr, "<>1__state");
				CommandRegistry._GetRunningCommands_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRegistry._GetRunningCommands_d__6>.NativeClassPtr, "<>2__current");
				CommandRegistry._GetRunningCommands_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRegistry._GetRunningCommands_d__6>.NativeClassPtr, "<>l__initialThreadId");
				CommandRegistry._GetRunningCommands_d__6.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRegistry._GetRunningCommands_d__6>.NativeClassPtr, "<>7__wrap1");
				CommandRegistry._GetRunningCommands_d__6.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRegistry._GetRunningCommands_d__6>.NativeClassPtr, "<>7__wrap2");
				CommandRegistry._GetRunningCommands_d__6.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRegistry._GetRunningCommands_d__6>.NativeClassPtr, "<i>5__4");
				CommandRegistry._GetRunningCommands_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetRunningCommands_d__6>.NativeClassPtr, 100663428);
				CommandRegistry._GetRunningCommands_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetRunningCommands_d__6>.NativeClassPtr, 100663429);
				CommandRegistry._GetRunningCommands_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetRunningCommands_d__6>.NativeClassPtr, 100663430);
				CommandRegistry._GetRunningCommands_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetRunningCommands_d__6>.NativeClassPtr, 100663431);
				CommandRegistry._GetRunningCommands_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_commands_Command__get_Current_Private_Virtual_Final_New_get_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetRunningCommands_d__6>.NativeClassPtr, 100663432);
				CommandRegistry._GetRunningCommands_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetRunningCommands_d__6>.NativeClassPtr, 100663433);
				CommandRegistry._GetRunningCommands_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetRunningCommands_d__6>.NativeClassPtr, 100663434);
				CommandRegistry._GetRunningCommands_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_commands_Command__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetRunningCommands_d__6>.NativeClassPtr, 100663435);
				CommandRegistry._GetRunningCommands_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandRegistry._GetRunningCommands_d__6>.NativeClassPtr, 100663436);
			}

			// Token: 0x060002A1 RID: 673 RVA: 0x0000E7B0 File Offset: 0x0000C9B0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetRunningCommands_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandRegistry._GetRunningCommands_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetRunningCommands_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002A2 RID: 674 RVA: 0x0000E7F8 File Offset: 0x0000C9F8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1206939, RefRangeEnd = 1206940, XrefRangeStart = 1206939, XrefRangeEnd = 1206940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetRunningCommands_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002A3 RID: 675 RVA: 0x0000E82C File Offset: 0x0000CA2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207017, XrefRangeEnd = 1207048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetRunningCommands_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060002A4 RID: 676 RVA: 0x0000E868 File Offset: 0x0000CA68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetRunningCommands_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000E89C File Offset: 0x0000CA9C
			public unsafe Command System.Collections.Generic.IEnumerator<dwd.core.commands.Command>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetRunningCommands_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_commands_Command__get_Current_Private_Virtual_Final_New_get_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
				}
			}

			// Token: 0x060002A6 RID: 678 RVA: 0x0000E8DC File Offset: 0x0000CADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207048, XrefRangeEnd = 1207053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetRunningCommands_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000E910 File Offset: 0x0000CB10
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetRunningCommands_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002A8 RID: 680 RVA: 0x0000E950 File Offset: 0x0000CB50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207053, XrefRangeEnd = 1207055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Command> System_Collections_Generic_IEnumerable_dwd_core_commands_Command__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetRunningCommands_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_commands_Command__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Command>>(intPtr3) : null;
			}

			// Token: 0x060002A9 RID: 681 RVA: 0x0000E990 File Offset: 0x0000CB90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandRegistry._GetRunningCommands_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060002AA RID: 682 RVA: 0x00003254 File Offset: 0x00001454
			public _GetRunningCommands_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x060002AB RID: 683 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
			// (set) Token: 0x060002AC RID: 684 RVA: 0x0000325D File Offset: 0x0000145D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetRunningCommands_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetRunningCommands_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x060002AD RID: 685 RVA: 0x0000E9F8 File Offset: 0x0000CBF8
			// (set) Token: 0x060002AE RID: 686 RVA: 0x00003278 File Offset: 0x00001478
			public unsafe Command __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetRunningCommands_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetRunningCommands_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x060002AF RID: 687 RVA: 0x0000EA28 File Offset: 0x0000CC28
			// (set) Token: 0x060002B0 RID: 688 RVA: 0x00003297 File Offset: 0x00001497
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetRunningCommands_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetRunningCommands_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x060002B1 RID: 689 RVA: 0x0000EA50 File Offset: 0x0000CC50
			// (set) Token: 0x060002B2 RID: 690 RVA: 0x000032B2 File Offset: 0x000014B2
			public unsafe List<WeakReference> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetRunningCommands_d__6.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeakReference>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetRunningCommands_d__6.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x060002B3 RID: 691 RVA: 0x0000EA80 File Offset: 0x0000CC80
			// (set) Token: 0x060002B4 RID: 692 RVA: 0x000032D1 File Offset: 0x000014D1
			public unsafe bool __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetRunningCommands_d__6.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetRunningCommands_d__6.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x060002B5 RID: 693 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
			// (set) Token: 0x060002B6 RID: 694 RVA: 0x000032EC File Offset: 0x000014EC
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetRunningCommands_d__6.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandRegistry._GetRunningCommands_d__6.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x0400019D RID: 413
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400019E RID: 414
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400019F RID: 415
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040001A0 RID: 416
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040001A1 RID: 417
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040001A2 RID: 418
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x040001A3 RID: 419
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001A4 RID: 420
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001A5 RID: 421
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001A6 RID: 422
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040001A7 RID: 423
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_commands_Command__get_Current_Private_Virtual_Final_New_get_Command_0;

			// Token: 0x040001A8 RID: 424
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001A9 RID: 425
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001AA RID: 426
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_commands_Command__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Command_0;

			// Token: 0x040001AB RID: 427
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
