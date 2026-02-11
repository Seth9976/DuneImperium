using System;
using System.Runtime.InteropServices;
using boardgames.menus.prompts;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.session.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Networking.lobby.responses;

namespace boardgames.menus.commands
{
	// Token: 0x0200023E RID: 574
	public class RunWaitingForPlayersFlow : Command
	{
		// Token: 0x060019E2 RID: 6626 RVA: 0x00071BF4 File Offset: 0x0006FDF4
		// Note: this type is marked as 'beforefieldinit'.
		static RunWaitingForPlayersFlow()
		{
			Il2CppClassPointerStore<RunWaitingForPlayersFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunWaitingForPlayersFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunWaitingForPlayersFlow>.NativeClassPtr);
			RunWaitingForPlayersFlow.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunWaitingForPlayersFlow>.NativeClassPtr, "gameID");
			RunWaitingForPlayersFlow.NativeFieldInfoPtr_additionalFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunWaitingForPlayersFlow>.NativeClassPtr, "additionalFlavors");
			RunWaitingForPlayersFlow.NativeMethodInfoPtr__ctor_Public_Void_GameID_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunWaitingForPlayersFlow>.NativeClassPtr, 100667409);
			RunWaitingForPlayersFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunWaitingForPlayersFlow>.NativeClassPtr, 100667410);
			RunWaitingForPlayersFlow.NativeMethodInfoPtr_GoBack_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunWaitingForPlayersFlow>.NativeClassPtr, 100667411);
			RunWaitingForPlayersFlow.NativeMethodInfoPtr__execute_b__3_2_Private_Boolean_LobbyGameStarted_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunWaitingForPlayersFlow>.NativeClassPtr, 100667412);
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00071C9C File Offset: 0x0006FE9C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 495165, RefRangeEnd = 495182, XrefRangeStart = 495165, XrefRangeEnd = 495182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunWaitingForPlayersFlow(GameID gameID, [Optional] Il2CppStringArray additionalFlavors)
		{
			if (additionalFlavors == null)
			{
				additionalFlavors = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunWaitingForPlayersFlow>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalFlavors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunWaitingForPlayersFlow.NativeMethodInfoPtr__ctor_Public_Void_GameID_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x00071D08 File Offset: 0x0006FF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531055, XrefRangeEnd = 531060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunWaitingForPlayersFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x00071D54 File Offset: 0x0006FF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531060, XrefRangeEnd = 531065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GoBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunWaitingForPlayersFlow.NativeMethodInfoPtr_GoBack_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x00071D90 File Offset: 0x0006FF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531065, XrefRangeEnd = 531071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _execute_b__3_2(LobbyGameStarted started)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(started);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunWaitingForPlayersFlow.NativeMethodInfoPtr__execute_b__3_2_Private_Boolean_LobbyGameStarted_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x0000E2AE File Offset: 0x0000C4AE
		public RunWaitingForPlayersFlow(GameID gameID, params string[] additionalFlavors)
			: this(gameID, new Il2CppStringArray(additionalFlavors))
		{
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x0000E2BD File Offset: 0x0000C4BD
		public RunWaitingForPlayersFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x00071DE0 File Offset: 0x0006FFE0
		// (set) Token: 0x060019EA RID: 6634 RVA: 0x0000E2C6 File Offset: 0x0000C4C6
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWaitingForPlayersFlow.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWaitingForPlayersFlow.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x00071E10 File Offset: 0x00070010
		// (set) Token: 0x060019EC RID: 6636 RVA: 0x0000E2E5 File Offset: 0x0000C4E5
		public unsafe Il2CppStringArray additionalFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWaitingForPlayersFlow.NativeFieldInfoPtr_additionalFlavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWaitingForPlayersFlow.NativeFieldInfoPtr_additionalFlavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeFieldInfoPtr_additionalFlavors;

		// Token: 0x04001025 RID: 4133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_Il2CppStringArray_0;

		// Token: 0x04001026 RID: 4134
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04001027 RID: 4135
		private static readonly IntPtr NativeMethodInfoPtr_GoBack_Protected_Virtual_New_Void_0;

		// Token: 0x04001028 RID: 4136
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__3_2_Private_Boolean_LobbyGameStarted_0;

		// Token: 0x0200042C RID: 1068
		[ObfuscatedName("boardgames.menus.commands.RunWaitingForPlayersFlow+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003280 RID: 12928 RVA: 0x000BF38C File Offset: 0x000BD58C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunWaitingForPlayersFlow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunWaitingForPlayersFlow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunWaitingForPlayersFlow.__c>.NativeClassPtr);
				RunWaitingForPlayersFlow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunWaitingForPlayersFlow.__c>.NativeClassPtr, "<>9");
				RunWaitingForPlayersFlow.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunWaitingForPlayersFlow.__c>.NativeClassPtr, "<>9__3_0");
				RunWaitingForPlayersFlow.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunWaitingForPlayersFlow.__c>.NativeClassPtr, "<>9__3_1");
				RunWaitingForPlayersFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunWaitingForPlayersFlow.__c>.NativeClassPtr, 100667414);
				RunWaitingForPlayersFlow.__c.NativeMethodInfoPtr__execute_b__3_0_Internal_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunWaitingForPlayersFlow.__c>.NativeClassPtr, 100667415);
				RunWaitingForPlayersFlow.__c.NativeMethodInfoPtr__execute_b__3_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunWaitingForPlayersFlow.__c>.NativeClassPtr, 100667416);
			}

			// Token: 0x06003281 RID: 12929 RVA: 0x000BF430 File Offset: 0x000BD630
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunWaitingForPlayersFlow.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunWaitingForPlayersFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003282 RID: 12930 RVA: 0x000BF46C File Offset: 0x000BD66C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530891, XrefRangeEnd = 530892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__3_0(Command cmd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunWaitingForPlayersFlow.__c.NativeMethodInfoPtr__execute_b__3_0_Internal_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003283 RID: 12931 RVA: 0x000BF4BC File Offset: 0x000BD6BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530892, XrefRangeEnd = 530908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__3_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunWaitingForPlayersFlow.__c.NativeMethodInfoPtr__execute_b__3_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003284 RID: 12932 RVA: 0x0001A143 File Offset: 0x00018343
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EB4 RID: 3764
			// (get) Token: 0x06003285 RID: 12933 RVA: 0x000BF4F0 File Offset: 0x000BD6F0
			// (set) Token: 0x06003286 RID: 12934 RVA: 0x0001A14C File Offset: 0x0001834C
			public unsafe static RunWaitingForPlayersFlow.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunWaitingForPlayersFlow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunWaitingForPlayersFlow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunWaitingForPlayersFlow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EB5 RID: 3765
			// (get) Token: 0x06003287 RID: 12935 RVA: 0x000BF518 File Offset: 0x000BD718
			// (set) Token: 0x06003288 RID: 12936 RVA: 0x0001A15E File Offset: 0x0001835E
			public unsafe static Func<Command, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunWaitingForPlayersFlow.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunWaitingForPlayersFlow.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EB6 RID: 3766
			// (get) Token: 0x06003289 RID: 12937 RVA: 0x000BF540 File Offset: 0x000BD740
			// (set) Token: 0x0600328A RID: 12938 RVA: 0x0001A170 File Offset: 0x00018370
			public unsafe static Action __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunWaitingForPlayersFlow.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunWaitingForPlayersFlow.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F30 RID: 7984
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001F31 RID: 7985
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04001F32 RID: 7986
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x04001F33 RID: 7987
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F34 RID: 7988
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__3_0_Internal_Boolean_Command_0;

			// Token: 0x04001F35 RID: 7989
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__3_1_Internal_Void_0;
		}

		// Token: 0x0200042D RID: 1069
		[ObfuscatedName("boardgames.menus.commands.RunWaitingForPlayersFlow+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x0600328B RID: 12939 RVA: 0x000BF568 File Offset: 0x000BD768
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<RunWaitingForPlayersFlow._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunWaitingForPlayersFlow>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunWaitingForPlayersFlow._execute_d__3>.NativeClassPtr);
				RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunWaitingForPlayersFlow._execute_d__3>.NativeClassPtr, "<>1__state");
				RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunWaitingForPlayersFlow._execute_d__3>.NativeClassPtr, "<>2__current");
				RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunWaitingForPlayersFlow._execute_d__3>.NativeClassPtr, "<>4__this");
				RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr__lobbySessionProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunWaitingForPlayersFlow._execute_d__3>.NativeClassPtr, "<lobbySessionProvider>5__2");
				RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr__data_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunWaitingForPlayersFlow._execute_d__3>.NativeClassPtr, "<data>5__3");
				RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr__waitForPlayers_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunWaitingForPlayersFlow._execute_d__3>.NativeClassPtr, "<waitForPlayers>5__4");
				RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr__writeAndAwait_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunWaitingForPlayersFlow._execute_d__3>.NativeClassPtr, "<writeAndAwait>5__5");
				RunWaitingForPlayersFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunWaitingForPlayersFlow._execute_d__3>.NativeClassPtr, 100667417);
				RunWaitingForPlayersFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunWaitingForPlayersFlow._execute_d__3>.NativeClassPtr, 100667418);
				RunWaitingForPlayersFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunWaitingForPlayersFlow._execute_d__3>.NativeClassPtr, 100667419);
				RunWaitingForPlayersFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunWaitingForPlayersFlow._execute_d__3>.NativeClassPtr, 100667420);
				RunWaitingForPlayersFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunWaitingForPlayersFlow._execute_d__3>.NativeClassPtr, 100667421);
				RunWaitingForPlayersFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunWaitingForPlayersFlow._execute_d__3>.NativeClassPtr, 100667422);
			}

			// Token: 0x0600328C RID: 12940 RVA: 0x000BF698 File Offset: 0x000BD898
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunWaitingForPlayersFlow._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunWaitingForPlayersFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600328D RID: 12941 RVA: 0x000BF6E0 File Offset: 0x000BD8E0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunWaitingForPlayersFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600328E RID: 12942 RVA: 0x000BF714 File Offset: 0x000BD914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530908, XrefRangeEnd = 531050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunWaitingForPlayersFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000EBE RID: 3774
			// (get) Token: 0x0600328F RID: 12943 RVA: 0x000BF750 File Offset: 0x000BD950
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunWaitingForPlayersFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003290 RID: 12944 RVA: 0x000BF790 File Offset: 0x000BD990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531050, XrefRangeEnd = 531055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunWaitingForPlayersFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000EBF RID: 3775
			// (get) Token: 0x06003291 RID: 12945 RVA: 0x000BF7C4 File Offset: 0x000BD9C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunWaitingForPlayersFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003292 RID: 12946 RVA: 0x0001A182 File Offset: 0x00018382
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EB7 RID: 3767
			// (get) Token: 0x06003293 RID: 12947 RVA: 0x000BF804 File Offset: 0x000BDA04
			// (set) Token: 0x06003294 RID: 12948 RVA: 0x0001A18B File Offset: 0x0001838B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000EB8 RID: 3768
			// (get) Token: 0x06003295 RID: 12949 RVA: 0x000BF82C File Offset: 0x000BDA2C
			// (set) Token: 0x06003296 RID: 12950 RVA: 0x0001A1A6 File Offset: 0x000183A6
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EB9 RID: 3769
			// (get) Token: 0x06003297 RID: 12951 RVA: 0x000BF85C File Offset: 0x000BDA5C
			// (set) Token: 0x06003298 RID: 12952 RVA: 0x0001A1C5 File Offset: 0x000183C5
			public unsafe RunWaitingForPlayersFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunWaitingForPlayersFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EBA RID: 3770
			// (get) Token: 0x06003299 RID: 12953 RVA: 0x000BF88C File Offset: 0x000BDA8C
			// (set) Token: 0x0600329A RID: 12954 RVA: 0x0001A1E4 File Offset: 0x000183E4
			public unsafe LobbySessionProvider _lobbySessionProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr__lobbySessionProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbySessionProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr__lobbySessionProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EBB RID: 3771
			// (get) Token: 0x0600329B RID: 12955 RVA: 0x000BF8BC File Offset: 0x000BDABC
			// (set) Token: 0x0600329C RID: 12956 RVA: 0x0001A203 File Offset: 0x00018403
			public unsafe DataComposition _data_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr__data_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr__data_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EBC RID: 3772
			// (get) Token: 0x0600329D RID: 12957 RVA: 0x000BF8EC File Offset: 0x000BDAEC
			// (set) Token: 0x0600329E RID: 12958 RVA: 0x0001A222 File Offset: 0x00018422
			public unsafe WaitingForPlayersPrompt _waitForPlayers_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr__waitForPlayers_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitingForPlayersPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr__waitForPlayers_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EBD RID: 3773
			// (get) Token: 0x0600329F RID: 12959 RVA: 0x000BF91C File Offset: 0x000BDB1C
			// (set) Token: 0x060032A0 RID: 12960 RVA: 0x0001A241 File Offset: 0x00018441
			public unsafe WriteToSessionAndAwaitResponse<LobbyGameStarted> _writeAndAwait_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr__writeAndAwait_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WriteToSessionAndAwaitResponse<LobbyGameStarted>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWaitingForPlayersFlow._execute_d__3.NativeFieldInfoPtr__writeAndAwait_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F36 RID: 7990
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001F37 RID: 7991
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001F38 RID: 7992
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001F39 RID: 7993
			private static readonly IntPtr NativeFieldInfoPtr__lobbySessionProvider_5__2;

			// Token: 0x04001F3A RID: 7994
			private static readonly IntPtr NativeFieldInfoPtr__data_5__3;

			// Token: 0x04001F3B RID: 7995
			private static readonly IntPtr NativeFieldInfoPtr__waitForPlayers_5__4;

			// Token: 0x04001F3C RID: 7996
			private static readonly IntPtr NativeFieldInfoPtr__writeAndAwait_5__5;

			// Token: 0x04001F3D RID: 7997
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001F3E RID: 7998
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F3F RID: 7999
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001F40 RID: 8000
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001F41 RID: 8001
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F42 RID: 8002
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
