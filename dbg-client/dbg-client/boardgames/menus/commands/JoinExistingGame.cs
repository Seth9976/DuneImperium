using System;
using boardgames.data;
using boardgames.menus.prompts;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.session.commands;
using dwd.core.ui.prompt.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.lobby;
using Networking.lobby.responses;

namespace boardgames.menus.commands
{
	// Token: 0x02000213 RID: 531
	public class JoinExistingGame : Command
	{
		// Token: 0x0600185C RID: 6236 RVA: 0x0006CA54 File Offset: 0x0006AC54
		// Note: this type is marked as 'beforefieldinit'.
		static JoinExistingGame()
		{
			Il2CppClassPointerStore<JoinExistingGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "JoinExistingGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinExistingGame>.NativeClassPtr);
			JoinExistingGame.NativeFieldInfoPtr_GameJoined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinExistingGame>.NativeClassPtr, "GameJoined");
			JoinExistingGame.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinExistingGame>.NativeClassPtr, "gameID");
			JoinExistingGame.NativeFieldInfoPtr_metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinExistingGame>.NativeClassPtr, "metadata");
			JoinExistingGame.NativeMethodInfoPtr__ctor_Public_Void_GameID_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinExistingGame>.NativeClassPtr, 100666903);
			JoinExistingGame.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinExistingGame>.NativeClassPtr, 100666904);
			JoinExistingGame.NativeMethodInfoPtr__execute_b__4_0_Private_Boolean_LobbyJoined_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinExistingGame>.NativeClassPtr, 100666905);
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x0006CAFC File Offset: 0x0006ACFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 526769, RefRangeEnd = 526771, XrefRangeStart = 526766, XrefRangeEnd = 526769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JoinExistingGame(GameID gameID, Dictionary<string, string> metadata)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoinExistingGame>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metadata);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinExistingGame.NativeMethodInfoPtr__ctor_Public_Void_GameID_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x0006CB5C File Offset: 0x0006AD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526771, XrefRangeEnd = 526776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JoinExistingGame.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0006CBA8 File Offset: 0x0006ADA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526776, XrefRangeEnd = 526780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _execute_b__4_0(LobbyJoined success)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(success);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinExistingGame.NativeMethodInfoPtr__execute_b__4_0_Private_Boolean_LobbyJoined_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x0000D7D3 File Offset: 0x0000B9D3
		public JoinExistingGame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001861 RID: 6241 RVA: 0x0006CBF8 File Offset: 0x0006ADF8
		// (set) Token: 0x06001862 RID: 6242 RVA: 0x0000D7DC File Offset: 0x0000B9DC
		public unsafe bool GameJoined
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame.NativeFieldInfoPtr_GameJoined);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame.NativeFieldInfoPtr_GameJoined)) = value;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001863 RID: 6243 RVA: 0x0006CC20 File Offset: 0x0006AE20
		// (set) Token: 0x06001864 RID: 6244 RVA: 0x0000D7F7 File Offset: 0x0000B9F7
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x0006CC50 File Offset: 0x0006AE50
		// (set) Token: 0x06001866 RID: 6246 RVA: 0x0000D816 File Offset: 0x0000BA16
		public unsafe Dictionary<string, string> metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame.NativeFieldInfoPtr_metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame.NativeFieldInfoPtr_metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeFieldInfoPtr_GameJoined;

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04000F41 RID: 3905
		private static readonly IntPtr NativeFieldInfoPtr_metadata;

		// Token: 0x04000F42 RID: 3906
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_Dictionary_2_String_String_0;

		// Token: 0x04000F43 RID: 3907
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F44 RID: 3908
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__4_0_Private_Boolean_LobbyJoined_0;

		// Token: 0x020003E7 RID: 999
		[ObfuscatedName("boardgames.menus.commands.JoinExistingGame+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002E94 RID: 11924 RVA: 0x000B391C File Offset: 0x000B1B1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<JoinExistingGame.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JoinExistingGame>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinExistingGame.__c>.NativeClassPtr);
				JoinExistingGame.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinExistingGame.__c>.NativeClassPtr, "<>9");
				JoinExistingGame.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinExistingGame.__c>.NativeClassPtr, "<>9__4_1");
				JoinExistingGame.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinExistingGame.__c>.NativeClassPtr, 100666907);
				JoinExistingGame.__c.NativeMethodInfoPtr__execute_b__4_1_Internal_Boolean_LobbyJoinFailed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinExistingGame.__c>.NativeClassPtr, 100666908);
			}

			// Token: 0x06002E95 RID: 11925 RVA: 0x000B3998 File Offset: 0x000B1B98
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoinExistingGame.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinExistingGame.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E96 RID: 11926 RVA: 0x000B39D4 File Offset: 0x000B1BD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526692, XrefRangeEnd = 526711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__4_1(LobbyJoinFailed failure)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(failure);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinExistingGame.__c.NativeMethodInfoPtr__execute_b__4_1_Internal_Boolean_LobbyJoinFailed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002E97 RID: 11927 RVA: 0x00018121 File Offset: 0x00016321
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D4A RID: 3402
			// (get) Token: 0x06002E98 RID: 11928 RVA: 0x000B3A24 File Offset: 0x000B1C24
			// (set) Token: 0x06002E99 RID: 11929 RVA: 0x0001812A File Offset: 0x0001632A
			public unsafe static JoinExistingGame.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JoinExistingGame.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JoinExistingGame.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JoinExistingGame.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D4B RID: 3403
			// (get) Token: 0x06002E9A RID: 11930 RVA: 0x000B3A4C File Offset: 0x000B1C4C
			// (set) Token: 0x06002E9B RID: 11931 RVA: 0x0001813C File Offset: 0x0001633C
			public unsafe static Func<LobbyJoinFailed, bool> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JoinExistingGame.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LobbyJoinFailed, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JoinExistingGame.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001CD6 RID: 7382
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001CD7 RID: 7383
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x04001CD8 RID: 7384
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001CD9 RID: 7385
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__4_1_Internal_Boolean_LobbyJoinFailed_0;
		}

		// Token: 0x020003E8 RID: 1000
		[ObfuscatedName("boardgames.menus.commands.JoinExistingGame+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06002E9C RID: 11932 RVA: 0x000B3A74 File Offset: 0x000B1C74
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<JoinExistingGame._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JoinExistingGame>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinExistingGame._execute_d__4>.NativeClassPtr);
				JoinExistingGame._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinExistingGame._execute_d__4>.NativeClassPtr, "<>1__state");
				JoinExistingGame._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinExistingGame._execute_d__4>.NativeClassPtr, "<>2__current");
				JoinExistingGame._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinExistingGame._execute_d__4>.NativeClassPtr, "<>4__this");
				JoinExistingGame._execute_d__4.NativeFieldInfoPtr__pendingGameData_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinExistingGame._execute_d__4>.NativeClassPtr, "<pendingGameData>5__2");
				JoinExistingGame._execute_d__4.NativeFieldInfoPtr__joinMessage_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinExistingGame._execute_d__4>.NativeClassPtr, "<joinMessage>5__3");
				JoinExistingGame._execute_d__4.NativeFieldInfoPtr__writeAndAwait_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinExistingGame._execute_d__4>.NativeClassPtr, "<writeAndAwait>5__4");
				JoinExistingGame._execute_d__4.NativeFieldInfoPtr__spinner_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinExistingGame._execute_d__4>.NativeClassPtr, "<spinner>5__5");
				JoinExistingGame._execute_d__4.NativeFieldInfoPtr__gamePasswordPrompt_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinExistingGame._execute_d__4>.NativeClassPtr, "<gamePasswordPrompt>5__6");
				JoinExistingGame._execute_d__4.NativeFieldInfoPtr__passwordPrompt_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinExistingGame._execute_d__4>.NativeClassPtr, "<passwordPrompt>5__7");
				JoinExistingGame._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinExistingGame._execute_d__4>.NativeClassPtr, 100666909);
				JoinExistingGame._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinExistingGame._execute_d__4>.NativeClassPtr, 100666910);
				JoinExistingGame._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinExistingGame._execute_d__4>.NativeClassPtr, 100666911);
				JoinExistingGame._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinExistingGame._execute_d__4>.NativeClassPtr, 100666912);
				JoinExistingGame._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinExistingGame._execute_d__4>.NativeClassPtr, 100666913);
				JoinExistingGame._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinExistingGame._execute_d__4>.NativeClassPtr, 100666914);
			}

			// Token: 0x06002E9D RID: 11933 RVA: 0x000B3BCC File Offset: 0x000B1DCC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoinExistingGame._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinExistingGame._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002E9E RID: 11934 RVA: 0x000B3C14 File Offset: 0x000B1E14
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinExistingGame._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E9F RID: 11935 RVA: 0x000B3C48 File Offset: 0x000B1E48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526711, XrefRangeEnd = 526761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinExistingGame._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D55 RID: 3413
			// (get) Token: 0x06002EA0 RID: 11936 RVA: 0x000B3C84 File Offset: 0x000B1E84
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinExistingGame._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002EA1 RID: 11937 RVA: 0x000B3CC4 File Offset: 0x000B1EC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526761, XrefRangeEnd = 526766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinExistingGame._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D56 RID: 3414
			// (get) Token: 0x06002EA2 RID: 11938 RVA: 0x000B3CF8 File Offset: 0x000B1EF8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinExistingGame._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002EA3 RID: 11939 RVA: 0x0001814E File Offset: 0x0001634E
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D4C RID: 3404
			// (get) Token: 0x06002EA4 RID: 11940 RVA: 0x000B3D38 File Offset: 0x000B1F38
			// (set) Token: 0x06002EA5 RID: 11941 RVA: 0x00018157 File Offset: 0x00016357
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D4D RID: 3405
			// (get) Token: 0x06002EA6 RID: 11942 RVA: 0x000B3D60 File Offset: 0x000B1F60
			// (set) Token: 0x06002EA7 RID: 11943 RVA: 0x00018172 File Offset: 0x00016372
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D4E RID: 3406
			// (get) Token: 0x06002EA8 RID: 11944 RVA: 0x000B3D90 File Offset: 0x000B1F90
			// (set) Token: 0x06002EA9 RID: 11945 RVA: 0x00018191 File Offset: 0x00016391
			public unsafe JoinExistingGame __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JoinExistingGame>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D4F RID: 3407
			// (get) Token: 0x06002EAA RID: 11946 RVA: 0x000B3DC0 File Offset: 0x000B1FC0
			// (set) Token: 0x06002EAB RID: 11947 RVA: 0x000181B0 File Offset: 0x000163B0
			public unsafe PendingGameData _pendingGameData_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame._execute_d__4.NativeFieldInfoPtr__pendingGameData_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingGameData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame._execute_d__4.NativeFieldInfoPtr__pendingGameData_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D50 RID: 3408
			// (get) Token: 0x06002EAC RID: 11948 RVA: 0x000B3DF0 File Offset: 0x000B1FF0
			// (set) Token: 0x06002EAD RID: 11949 RVA: 0x000181CF File Offset: 0x000163CF
			public unsafe JoinLobbyGame _joinMessage_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame._execute_d__4.NativeFieldInfoPtr__joinMessage_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JoinLobbyGame>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame._execute_d__4.NativeFieldInfoPtr__joinMessage_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D51 RID: 3409
			// (get) Token: 0x06002EAE RID: 11950 RVA: 0x000B3E20 File Offset: 0x000B2020
			// (set) Token: 0x06002EAF RID: 11951 RVA: 0x000181EE File Offset: 0x000163EE
			public unsafe WriteToSessionAndAwaitResponse<LobbyJoined, LobbyJoinFailed> _writeAndAwait_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame._execute_d__4.NativeFieldInfoPtr__writeAndAwait_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WriteToSessionAndAwaitResponse<LobbyJoined, LobbyJoinFailed>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame._execute_d__4.NativeFieldInfoPtr__writeAndAwait_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D52 RID: 3410
			// (get) Token: 0x06002EB0 RID: 11952 RVA: 0x000B3E50 File Offset: 0x000B2050
			// (set) Token: 0x06002EB1 RID: 11953 RVA: 0x0001820D File Offset: 0x0001640D
			public unsafe ShowSpinnerWhile<IFailable> _spinner_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame._execute_d__4.NativeFieldInfoPtr__spinner_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShowSpinnerWhile<IFailable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame._execute_d__4.NativeFieldInfoPtr__spinner_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D53 RID: 3411
			// (get) Token: 0x06002EB2 RID: 11954 RVA: 0x000B3E80 File Offset: 0x000B2080
			// (set) Token: 0x06002EB3 RID: 11955 RVA: 0x0001822C File Offset: 0x0001642C
			public unsafe GamePasswordPrompt _gamePasswordPrompt_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame._execute_d__4.NativeFieldInfoPtr__gamePasswordPrompt_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GamePasswordPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame._execute_d__4.NativeFieldInfoPtr__gamePasswordPrompt_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D54 RID: 3412
			// (get) Token: 0x06002EB4 RID: 11956 RVA: 0x000B3EB0 File Offset: 0x000B20B0
			// (set) Token: 0x06002EB5 RID: 11957 RVA: 0x0001824B File Offset: 0x0001644B
			public unsafe DisplayGenericPrompt _passwordPrompt_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame._execute_d__4.NativeFieldInfoPtr__passwordPrompt_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayGenericPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinExistingGame._execute_d__4.NativeFieldInfoPtr__passwordPrompt_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001CDA RID: 7386
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001CDB RID: 7387
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001CDC RID: 7388
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001CDD RID: 7389
			private static readonly IntPtr NativeFieldInfoPtr__pendingGameData_5__2;

			// Token: 0x04001CDE RID: 7390
			private static readonly IntPtr NativeFieldInfoPtr__joinMessage_5__3;

			// Token: 0x04001CDF RID: 7391
			private static readonly IntPtr NativeFieldInfoPtr__writeAndAwait_5__4;

			// Token: 0x04001CE0 RID: 7392
			private static readonly IntPtr NativeFieldInfoPtr__spinner_5__5;

			// Token: 0x04001CE1 RID: 7393
			private static readonly IntPtr NativeFieldInfoPtr__gamePasswordPrompt_5__6;

			// Token: 0x04001CE2 RID: 7394
			private static readonly IntPtr NativeFieldInfoPtr__passwordPrompt_5__7;

			// Token: 0x04001CE3 RID: 7395
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001CE4 RID: 7396
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CE5 RID: 7397
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001CE6 RID: 7398
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001CE7 RID: 7399
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CE8 RID: 7400
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
