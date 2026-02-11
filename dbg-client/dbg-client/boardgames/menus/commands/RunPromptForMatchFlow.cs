using System;
using Canis.utils.ids;
using dwd.core;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.ui.prompt.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.menus.commands
{
	// Token: 0x02000231 RID: 561
	public class RunPromptForMatchFlow : Command
	{
		// Token: 0x0600197B RID: 6523 RVA: 0x000706A8 File Offset: 0x0006E8A8
		// Note: this type is marked as 'beforefieldinit'.
		static RunPromptForMatchFlow()
		{
			Il2CppClassPointerStore<RunPromptForMatchFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunPromptForMatchFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunPromptForMatchFlow>.NativeClassPtr);
			RunPromptForMatchFlow.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPromptForMatchFlow>.NativeClassPtr, "gameID");
			RunPromptForMatchFlow.NativeFieldInfoPtr_isLive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPromptForMatchFlow>.NativeClassPtr, "isLive");
			RunPromptForMatchFlow.NativeFieldInfoPtr_promptData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPromptForMatchFlow>.NativeClassPtr, "promptData");
			RunPromptForMatchFlow.NativeFieldInfoPtr_playCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPromptForMatchFlow>.NativeClassPtr, "playCommand");
			RunPromptForMatchFlow.NativeMethodInfoPtr__ctor_Public_Void_GameID_Boolean_DataComposition_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPromptForMatchFlow>.NativeClassPtr, 100667259);
			RunPromptForMatchFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPromptForMatchFlow>.NativeClassPtr, 100667260);
			RunPromptForMatchFlow.NativeMethodInfoPtr_AlreadyInGame_Private_Static_Boolean_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPromptForMatchFlow>.NativeClassPtr, 100667261);
			RunPromptForMatchFlow.NativeMethodInfoPtr_LoadingPlaymat_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPromptForMatchFlow>.NativeClassPtr, 100667262);
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x00070778 File Offset: 0x0006E978
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 529651, RefRangeEnd = 529654, XrefRangeStart = 529647, XrefRangeEnd = 529651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunPromptForMatchFlow(GameID gameID, bool isLive, DataComposition promptData, IFailable playCommand)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunPromptForMatchFlow>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLive;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(promptData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playCommand);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPromptForMatchFlow.NativeMethodInfoPtr__ctor_Public_Void_GameID_Boolean_DataComposition_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x000707F8 File Offset: 0x0006E9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529654, XrefRangeEnd = 529659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunPromptForMatchFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x00070844 File Offset: 0x0006EA44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 529662, RefRangeEnd = 529664, XrefRangeStart = 529659, XrefRangeEnd = 529662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AlreadyInGame(GameID gameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPromptForMatchFlow.NativeMethodInfoPtr_AlreadyInGame_Private_Static_Boolean_GameID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00070888 File Offset: 0x0006EA88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 529686, RefRangeEnd = 529688, XrefRangeStart = 529664, XrefRangeEnd = 529686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LoadingPlaymat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPromptForMatchFlow.NativeMethodInfoPtr_LoadingPlaymat_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x0000DFDE File Offset: 0x0000C1DE
		public RunPromptForMatchFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06001981 RID: 6529 RVA: 0x000708B8 File Offset: 0x0006EAB8
		// (set) Token: 0x06001982 RID: 6530 RVA: 0x0000DFE7 File Offset: 0x0000C1E7
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06001983 RID: 6531 RVA: 0x000708E8 File Offset: 0x0006EAE8
		// (set) Token: 0x06001984 RID: 6532 RVA: 0x0000E006 File Offset: 0x0000C206
		public unsafe bool isLive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow.NativeFieldInfoPtr_isLive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow.NativeFieldInfoPtr_isLive)) = value;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001985 RID: 6533 RVA: 0x00070910 File Offset: 0x0006EB10
		// (set) Token: 0x06001986 RID: 6534 RVA: 0x0000E021 File Offset: 0x0000C221
		public unsafe DataComposition promptData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow.NativeFieldInfoPtr_promptData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow.NativeFieldInfoPtr_promptData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001987 RID: 6535 RVA: 0x00070940 File Offset: 0x0006EB40
		// (set) Token: 0x06001988 RID: 6536 RVA: 0x0000E040 File Offset: 0x0000C240
		public unsafe IFailable playCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow.NativeFieldInfoPtr_playCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow.NativeFieldInfoPtr_playCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeFieldInfoPtr_isLive;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeFieldInfoPtr_promptData;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeFieldInfoPtr_playCommand;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_Boolean_DataComposition_IFailable_0;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeMethodInfoPtr_AlreadyInGame_Private_Static_Boolean_GameID_0;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeMethodInfoPtr_LoadingPlaymat_Private_Static_Boolean_0;

		// Token: 0x02000414 RID: 1044
		[ObfuscatedName("boardgames.menus.commands.RunPromptForMatchFlow+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003152 RID: 12626 RVA: 0x000BBB88 File Offset: 0x000B9D88
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunPromptForMatchFlow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunPromptForMatchFlow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunPromptForMatchFlow.__c>.NativeClassPtr);
				RunPromptForMatchFlow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPromptForMatchFlow.__c>.NativeClassPtr, "<>9");
				RunPromptForMatchFlow.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPromptForMatchFlow.__c>.NativeClassPtr, "<>9__5_0");
				RunPromptForMatchFlow.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPromptForMatchFlow.__c>.NativeClassPtr, "<>9__7_0");
				RunPromptForMatchFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPromptForMatchFlow.__c>.NativeClassPtr, 100667264);
				RunPromptForMatchFlow.__c.NativeMethodInfoPtr__execute_b__5_0_Internal_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPromptForMatchFlow.__c>.NativeClassPtr, 100667265);
				RunPromptForMatchFlow.__c.NativeMethodInfoPtr__LoadingPlaymat_b__7_0_Internal_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPromptForMatchFlow.__c>.NativeClassPtr, 100667266);
			}

			// Token: 0x06003153 RID: 12627 RVA: 0x000BBC2C File Offset: 0x000B9E2C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunPromptForMatchFlow.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPromptForMatchFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003154 RID: 12628 RVA: 0x000BBC68 File Offset: 0x000B9E68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529523, XrefRangeEnd = 529556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__5_0(ErrorInfo _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPromptForMatchFlow.__c.NativeMethodInfoPtr__execute_b__5_0_Internal_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003155 RID: 12629 RVA: 0x000BBCB0 File Offset: 0x000B9EB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529556, XrefRangeEnd = 529559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadingPlaymat_b__7_0(Command c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPromptForMatchFlow.__c.NativeMethodInfoPtr__LoadingPlaymat_b__7_0_Internal_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003156 RID: 12630 RVA: 0x00019802 File Offset: 0x00017A02
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E4D RID: 3661
			// (get) Token: 0x06003157 RID: 12631 RVA: 0x000BBD00 File Offset: 0x000B9F00
			// (set) Token: 0x06003158 RID: 12632 RVA: 0x0001980B File Offset: 0x00017A0B
			public unsafe static RunPromptForMatchFlow.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunPromptForMatchFlow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunPromptForMatchFlow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunPromptForMatchFlow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E4E RID: 3662
			// (get) Token: 0x06003159 RID: 12633 RVA: 0x000BBD28 File Offset: 0x000B9F28
			// (set) Token: 0x0600315A RID: 12634 RVA: 0x0001981D File Offset: 0x00017A1D
			public unsafe static Action<ErrorInfo> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunPromptForMatchFlow.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunPromptForMatchFlow.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E4F RID: 3663
			// (get) Token: 0x0600315B RID: 12635 RVA: 0x000BBD50 File Offset: 0x000B9F50
			// (set) Token: 0x0600315C RID: 12636 RVA: 0x0001982F File Offset: 0x00017A2F
			public unsafe static Func<Command, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunPromptForMatchFlow.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunPromptForMatchFlow.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E7D RID: 7805
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001E7E RID: 7806
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04001E7F RID: 7807
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04001E80 RID: 7808
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001E81 RID: 7809
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__5_0_Internal_Void_ErrorInfo_0;

			// Token: 0x04001E82 RID: 7810
			private static readonly IntPtr NativeMethodInfoPtr__LoadingPlaymat_b__7_0_Internal_Boolean_Command_0;
		}

		// Token: 0x02000415 RID: 1045
		[ObfuscatedName("boardgames.menus.commands.RunPromptForMatchFlow+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x0600315D RID: 12637 RVA: 0x000BBD78 File Offset: 0x000B9F78
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<RunPromptForMatchFlow._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunPromptForMatchFlow>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunPromptForMatchFlow._execute_d__5>.NativeClassPtr);
				RunPromptForMatchFlow._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPromptForMatchFlow._execute_d__5>.NativeClassPtr, "<>1__state");
				RunPromptForMatchFlow._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPromptForMatchFlow._execute_d__5>.NativeClassPtr, "<>2__current");
				RunPromptForMatchFlow._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPromptForMatchFlow._execute_d__5>.NativeClassPtr, "<>4__this");
				RunPromptForMatchFlow._execute_d__5.NativeFieldInfoPtr__modalScopes_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPromptForMatchFlow._execute_d__5>.NativeClassPtr, "<modalScopes>5__2");
				RunPromptForMatchFlow._execute_d__5.NativeFieldInfoPtr__confirmOrDeny_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPromptForMatchFlow._execute_d__5>.NativeClassPtr, "<confirmOrDeny>5__3");
				RunPromptForMatchFlow._execute_d__5.NativeFieldInfoPtr__showPrompt_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPromptForMatchFlow._execute_d__5>.NativeClassPtr, "<showPrompt>5__4");
				RunPromptForMatchFlow._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPromptForMatchFlow._execute_d__5>.NativeClassPtr, 100667267);
				RunPromptForMatchFlow._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPromptForMatchFlow._execute_d__5>.NativeClassPtr, 100667268);
				RunPromptForMatchFlow._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPromptForMatchFlow._execute_d__5>.NativeClassPtr, 100667269);
				RunPromptForMatchFlow._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPromptForMatchFlow._execute_d__5>.NativeClassPtr, 100667270);
				RunPromptForMatchFlow._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPromptForMatchFlow._execute_d__5>.NativeClassPtr, 100667271);
				RunPromptForMatchFlow._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPromptForMatchFlow._execute_d__5>.NativeClassPtr, 100667272);
			}

			// Token: 0x0600315E RID: 12638 RVA: 0x000BBE94 File Offset: 0x000BA094
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunPromptForMatchFlow._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPromptForMatchFlow._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600315F RID: 12639 RVA: 0x000BBEDC File Offset: 0x000BA0DC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPromptForMatchFlow._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003160 RID: 12640 RVA: 0x000BBF10 File Offset: 0x000BA110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529559, XrefRangeEnd = 529642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPromptForMatchFlow._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000E56 RID: 3670
			// (get) Token: 0x06003161 RID: 12641 RVA: 0x000BBF4C File Offset: 0x000BA14C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPromptForMatchFlow._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003162 RID: 12642 RVA: 0x000BBF8C File Offset: 0x000BA18C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529642, XrefRangeEnd = 529647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPromptForMatchFlow._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E57 RID: 3671
			// (get) Token: 0x06003163 RID: 12643 RVA: 0x000BBFC0 File Offset: 0x000BA1C0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPromptForMatchFlow._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003164 RID: 12644 RVA: 0x00019841 File Offset: 0x00017A41
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E50 RID: 3664
			// (get) Token: 0x06003165 RID: 12645 RVA: 0x000BC000 File Offset: 0x000BA200
			// (set) Token: 0x06003166 RID: 12646 RVA: 0x0001984A File Offset: 0x00017A4A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E51 RID: 3665
			// (get) Token: 0x06003167 RID: 12647 RVA: 0x000BC028 File Offset: 0x000BA228
			// (set) Token: 0x06003168 RID: 12648 RVA: 0x00019865 File Offset: 0x00017A65
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E52 RID: 3666
			// (get) Token: 0x06003169 RID: 12649 RVA: 0x000BC058 File Offset: 0x000BA258
			// (set) Token: 0x0600316A RID: 12650 RVA: 0x00019884 File Offset: 0x00017A84
			public unsafe RunPromptForMatchFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunPromptForMatchFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E53 RID: 3667
			// (get) Token: 0x0600316B RID: 12651 RVA: 0x000BC088 File Offset: 0x000BA288
			// (set) Token: 0x0600316C RID: 12652 RVA: 0x000198A3 File Offset: 0x00017AA3
			public unsafe ModalScopes _modalScopes_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow._execute_d__5.NativeFieldInfoPtr__modalScopes_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScopes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow._execute_d__5.NativeFieldInfoPtr__modalScopes_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E54 RID: 3668
			// (get) Token: 0x0600316D RID: 12653 RVA: 0x000BC0B8 File Offset: 0x000BA2B8
			// (set) Token: 0x0600316E RID: 12654 RVA: 0x000198C2 File Offset: 0x00017AC2
			public unsafe ConfirmOrDenyPrompt _confirmOrDeny_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow._execute_d__5.NativeFieldInfoPtr__confirmOrDeny_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow._execute_d__5.NativeFieldInfoPtr__confirmOrDeny_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E55 RID: 3669
			// (get) Token: 0x0600316F RID: 12655 RVA: 0x000BC0E8 File Offset: 0x000BA2E8
			// (set) Token: 0x06003170 RID: 12656 RVA: 0x000198E1 File Offset: 0x00017AE1
			public unsafe DisplayGenericPrompt _showPrompt_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow._execute_d__5.NativeFieldInfoPtr__showPrompt_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayGenericPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPromptForMatchFlow._execute_d__5.NativeFieldInfoPtr__showPrompt_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E83 RID: 7811
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001E84 RID: 7812
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001E85 RID: 7813
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001E86 RID: 7814
			private static readonly IntPtr NativeFieldInfoPtr__modalScopes_5__2;

			// Token: 0x04001E87 RID: 7815
			private static readonly IntPtr NativeFieldInfoPtr__confirmOrDeny_5__3;

			// Token: 0x04001E88 RID: 7816
			private static readonly IntPtr NativeFieldInfoPtr__showPrompt_5__4;

			// Token: 0x04001E89 RID: 7817
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001E8A RID: 7818
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E8B RID: 7819
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001E8C RID: 7820
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001E8D RID: 7821
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E8E RID: 7822
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
