using System;
using boardgames.account;
using boardgames.menus.prompts;
using dwd.core.commands;
using dwd.core.session.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Networking.lobby;
using Networking.lobby.responses;

namespace boardgames.menus.commands
{
	// Token: 0x02000221 RID: 545
	public class RunConfigureGameFlow : Command
	{
		// Token: 0x060018D4 RID: 6356 RVA: 0x0006E280 File Offset: 0x0006C480
		// Note: this type is marked as 'beforefieldinit'.
		static RunConfigureGameFlow()
		{
			Il2CppClassPointerStore<RunConfigureGameFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunConfigureGameFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunConfigureGameFlow>.NativeClassPtr);
			RunConfigureGameFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureGameFlow>.NativeClassPtr, 100667057);
			RunConfigureGameFlow.NativeMethodInfoPtr_CreateLobbyGame_Protected_Virtual_New_IEnumerator_CreateLobbyGame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureGameFlow>.NativeClassPtr, 100667058);
			RunConfigureGameFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureGameFlow>.NativeClassPtr, 100667059);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0006E2EC File Offset: 0x0006C4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528088, XrefRangeEnd = 528093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunConfigureGameFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0006E338 File Offset: 0x0006C538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528093, XrefRangeEnd = 528098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator CreateLobbyGame(CreateLobbyGame lobbyGame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lobbyGame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunConfigureGameFlow.NativeMethodInfoPtr_CreateLobbyGame_Protected_Virtual_New_IEnumerator_CreateLobbyGame_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0006E394 File Offset: 0x0006C594
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunConfigureGameFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunConfigureGameFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureGameFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x0000DB6A File Offset: 0x0000BD6A
		public RunConfigureGameFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeMethodInfoPtr_CreateLobbyGame_Protected_Virtual_New_IEnumerator_CreateLobbyGame_0;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003FC RID: 1020
		[ObfuscatedName("boardgames.menus.commands.RunConfigureGameFlow+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002FD6 RID: 12246 RVA: 0x000B74FC File Offset: 0x000B56FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunConfigureGameFlow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunConfigureGameFlow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunConfigureGameFlow.__c>.NativeClassPtr);
				RunConfigureGameFlow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureGameFlow.__c>.NativeClassPtr, "<>9");
				RunConfigureGameFlow.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureGameFlow.__c>.NativeClassPtr, "<>9__1_0");
				RunConfigureGameFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureGameFlow.__c>.NativeClassPtr, 100667061);
				RunConfigureGameFlow.__c.NativeMethodInfoPtr__CreateLobbyGame_b__1_0_Internal_Boolean_LobbyGameAdded_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureGameFlow.__c>.NativeClassPtr, 100667062);
			}

			// Token: 0x06002FD7 RID: 12247 RVA: 0x000B7578 File Offset: 0x000B5778
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunConfigureGameFlow.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureGameFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FD8 RID: 12248 RVA: 0x000B75B4 File Offset: 0x000B57B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527975, XrefRangeEnd = 527984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateLobbyGame_b__1_0(LobbyGameAdded added)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(added);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureGameFlow.__c.NativeMethodInfoPtr__CreateLobbyGame_b__1_0_Internal_Boolean_LobbyGameAdded_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002FD9 RID: 12249 RVA: 0x00018B8B File Offset: 0x00016D8B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DC0 RID: 3520
			// (get) Token: 0x06002FDA RID: 12250 RVA: 0x000B7604 File Offset: 0x000B5804
			// (set) Token: 0x06002FDB RID: 12251 RVA: 0x00018B94 File Offset: 0x00016D94
			public unsafe static RunConfigureGameFlow.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunConfigureGameFlow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunConfigureGameFlow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunConfigureGameFlow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC1 RID: 3521
			// (get) Token: 0x06002FDC RID: 12252 RVA: 0x000B762C File Offset: 0x000B582C
			// (set) Token: 0x06002FDD RID: 12253 RVA: 0x00018BA6 File Offset: 0x00016DA6
			public unsafe static Func<LobbyGameAdded, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunConfigureGameFlow.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LobbyGameAdded, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunConfigureGameFlow.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D98 RID: 7576
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001D99 RID: 7577
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04001D9A RID: 7578
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001D9B RID: 7579
			private static readonly IntPtr NativeMethodInfoPtr__CreateLobbyGame_b__1_0_Internal_Boolean_LobbyGameAdded_0;
		}

		// Token: 0x020003FD RID: 1021
		[ObfuscatedName("boardgames.menus.commands.RunConfigureGameFlow+<CreateLobbyGame>d__1")]
		public sealed class _CreateLobbyGame_d__1 : Object
		{
			// Token: 0x06002FDE RID: 12254 RVA: 0x000B7654 File Offset: 0x000B5854
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateLobbyGame_d__1()
			{
				Il2CppClassPointerStore<RunConfigureGameFlow._CreateLobbyGame_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunConfigureGameFlow>.NativeClassPtr, "<CreateLobbyGame>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunConfigureGameFlow._CreateLobbyGame_d__1>.NativeClassPtr);
				RunConfigureGameFlow._CreateLobbyGame_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureGameFlow._CreateLobbyGame_d__1>.NativeClassPtr, "<>1__state");
				RunConfigureGameFlow._CreateLobbyGame_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureGameFlow._CreateLobbyGame_d__1>.NativeClassPtr, "<>2__current");
				RunConfigureGameFlow._CreateLobbyGame_d__1.NativeFieldInfoPtr_lobbyGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureGameFlow._CreateLobbyGame_d__1>.NativeClassPtr, "lobbyGame");
				RunConfigureGameFlow._CreateLobbyGame_d__1.NativeFieldInfoPtr__lobbySessionProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureGameFlow._CreateLobbyGame_d__1>.NativeClassPtr, "<lobbySessionProvider>5__2");
				RunConfigureGameFlow._CreateLobbyGame_d__1.NativeFieldInfoPtr__writeAndAwait_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureGameFlow._CreateLobbyGame_d__1>.NativeClassPtr, "<writeAndAwait>5__3");
				RunConfigureGameFlow._CreateLobbyGame_d__1.NativeFieldInfoPtr__check_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureGameFlow._CreateLobbyGame_d__1>.NativeClassPtr, "<check>5__4");
				RunConfigureGameFlow._CreateLobbyGame_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureGameFlow._CreateLobbyGame_d__1>.NativeClassPtr, 100667063);
				RunConfigureGameFlow._CreateLobbyGame_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureGameFlow._CreateLobbyGame_d__1>.NativeClassPtr, 100667064);
				RunConfigureGameFlow._CreateLobbyGame_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureGameFlow._CreateLobbyGame_d__1>.NativeClassPtr, 100667065);
				RunConfigureGameFlow._CreateLobbyGame_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureGameFlow._CreateLobbyGame_d__1>.NativeClassPtr, 100667066);
				RunConfigureGameFlow._CreateLobbyGame_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureGameFlow._CreateLobbyGame_d__1>.NativeClassPtr, 100667067);
				RunConfigureGameFlow._CreateLobbyGame_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureGameFlow._CreateLobbyGame_d__1>.NativeClassPtr, 100667068);
			}

			// Token: 0x06002FDF RID: 12255 RVA: 0x000B7770 File Offset: 0x000B5970
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CreateLobbyGame_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunConfigureGameFlow._CreateLobbyGame_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureGameFlow._CreateLobbyGame_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002FE0 RID: 12256 RVA: 0x000B77B8 File Offset: 0x000B59B8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureGameFlow._CreateLobbyGame_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FE1 RID: 12257 RVA: 0x000B77EC File Offset: 0x000B59EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527984, XrefRangeEnd = 528075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureGameFlow._CreateLobbyGame_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000DC8 RID: 3528
			// (get) Token: 0x06002FE2 RID: 12258 RVA: 0x000B7828 File Offset: 0x000B5A28
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureGameFlow._CreateLobbyGame_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002FE3 RID: 12259 RVA: 0x000B7868 File Offset: 0x000B5A68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528075, XrefRangeEnd = 528080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureGameFlow._CreateLobbyGame_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DC9 RID: 3529
			// (get) Token: 0x06002FE4 RID: 12260 RVA: 0x000B789C File Offset: 0x000B5A9C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureGameFlow._CreateLobbyGame_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002FE5 RID: 12261 RVA: 0x00018BB8 File Offset: 0x00016DB8
			public _CreateLobbyGame_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DC2 RID: 3522
			// (get) Token: 0x06002FE6 RID: 12262 RVA: 0x000B78DC File Offset: 0x000B5ADC
			// (set) Token: 0x06002FE7 RID: 12263 RVA: 0x00018BC1 File Offset: 0x00016DC1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._CreateLobbyGame_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._CreateLobbyGame_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DC3 RID: 3523
			// (get) Token: 0x06002FE8 RID: 12264 RVA: 0x000B7904 File Offset: 0x000B5B04
			// (set) Token: 0x06002FE9 RID: 12265 RVA: 0x00018BDC File Offset: 0x00016DDC
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._CreateLobbyGame_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._CreateLobbyGame_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC4 RID: 3524
			// (get) Token: 0x06002FEA RID: 12266 RVA: 0x000B7934 File Offset: 0x000B5B34
			// (set) Token: 0x06002FEB RID: 12267 RVA: 0x00018BFB File Offset: 0x00016DFB
			public unsafe CreateLobbyGame lobbyGame
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._CreateLobbyGame_d__1.NativeFieldInfoPtr_lobbyGame);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateLobbyGame>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._CreateLobbyGame_d__1.NativeFieldInfoPtr_lobbyGame), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC5 RID: 3525
			// (get) Token: 0x06002FEC RID: 12268 RVA: 0x000B7964 File Offset: 0x000B5B64
			// (set) Token: 0x06002FED RID: 12269 RVA: 0x00018C1A File Offset: 0x00016E1A
			public unsafe LobbySessionProvider _lobbySessionProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._CreateLobbyGame_d__1.NativeFieldInfoPtr__lobbySessionProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbySessionProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._CreateLobbyGame_d__1.NativeFieldInfoPtr__lobbySessionProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC6 RID: 3526
			// (get) Token: 0x06002FEE RID: 12270 RVA: 0x000B7994 File Offset: 0x000B5B94
			// (set) Token: 0x06002FEF RID: 12271 RVA: 0x00018C39 File Offset: 0x00016E39
			public unsafe WriteToSessionAndAwaitResponse<LobbyGameAdded> _writeAndAwait_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._CreateLobbyGame_d__1.NativeFieldInfoPtr__writeAndAwait_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WriteToSessionAndAwaitResponse<LobbyGameAdded>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._CreateLobbyGame_d__1.NativeFieldInfoPtr__writeAndAwait_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC7 RID: 3527
			// (get) Token: 0x06002FF0 RID: 12272 RVA: 0x000B79C4 File Offset: 0x000B5BC4
			// (set) Token: 0x06002FF1 RID: 12273 RVA: 0x00018C58 File Offset: 0x00016E58
			public unsafe ICheckPrivilegesCommand _check_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._CreateLobbyGame_d__1.NativeFieldInfoPtr__check_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICheckPrivilegesCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._CreateLobbyGame_d__1.NativeFieldInfoPtr__check_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D9C RID: 7580
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D9D RID: 7581
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D9E RID: 7582
			private static readonly IntPtr NativeFieldInfoPtr_lobbyGame;

			// Token: 0x04001D9F RID: 7583
			private static readonly IntPtr NativeFieldInfoPtr__lobbySessionProvider_5__2;

			// Token: 0x04001DA0 RID: 7584
			private static readonly IntPtr NativeFieldInfoPtr__writeAndAwait_5__3;

			// Token: 0x04001DA1 RID: 7585
			private static readonly IntPtr NativeFieldInfoPtr__check_5__4;

			// Token: 0x04001DA2 RID: 7586
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001DA3 RID: 7587
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DA4 RID: 7588
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001DA5 RID: 7589
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001DA6 RID: 7590
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DA7 RID: 7591
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003FE RID: 1022
		[ObfuscatedName("boardgames.menus.commands.RunConfigureGameFlow+<execute>d__0")]
		public sealed class _execute_d__0 : Object
		{
			// Token: 0x06002FF2 RID: 12274 RVA: 0x000B79F4 File Offset: 0x000B5BF4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__0()
			{
				Il2CppClassPointerStore<RunConfigureGameFlow._execute_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunConfigureGameFlow>.NativeClassPtr, "<execute>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunConfigureGameFlow._execute_d__0>.NativeClassPtr);
				RunConfigureGameFlow._execute_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureGameFlow._execute_d__0>.NativeClassPtr, "<>1__state");
				RunConfigureGameFlow._execute_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureGameFlow._execute_d__0>.NativeClassPtr, "<>2__current");
				RunConfigureGameFlow._execute_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureGameFlow._execute_d__0>.NativeClassPtr, "<>4__this");
				RunConfigureGameFlow._execute_d__0.NativeFieldInfoPtr__configurePrompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureGameFlow._execute_d__0>.NativeClassPtr, "<configurePrompt>5__2");
				RunConfigureGameFlow._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureGameFlow._execute_d__0>.NativeClassPtr, 100667069);
				RunConfigureGameFlow._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureGameFlow._execute_d__0>.NativeClassPtr, 100667070);
				RunConfigureGameFlow._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureGameFlow._execute_d__0>.NativeClassPtr, 100667071);
				RunConfigureGameFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureGameFlow._execute_d__0>.NativeClassPtr, 100667072);
				RunConfigureGameFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureGameFlow._execute_d__0>.NativeClassPtr, 100667073);
				RunConfigureGameFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureGameFlow._execute_d__0>.NativeClassPtr, 100667074);
			}

			// Token: 0x06002FF3 RID: 12275 RVA: 0x000B7AE8 File Offset: 0x000B5CE8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunConfigureGameFlow._execute_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureGameFlow._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002FF4 RID: 12276 RVA: 0x000B7B30 File Offset: 0x000B5D30
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureGameFlow._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FF5 RID: 12277 RVA: 0x000B7B64 File Offset: 0x000B5D64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528080, XrefRangeEnd = 528083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureGameFlow._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000DCE RID: 3534
			// (get) Token: 0x06002FF6 RID: 12278 RVA: 0x000B7BA0 File Offset: 0x000B5DA0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureGameFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002FF7 RID: 12279 RVA: 0x000B7BE0 File Offset: 0x000B5DE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528083, XrefRangeEnd = 528088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureGameFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DCF RID: 3535
			// (get) Token: 0x06002FF8 RID: 12280 RVA: 0x000B7C14 File Offset: 0x000B5E14
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureGameFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002FF9 RID: 12281 RVA: 0x00018C77 File Offset: 0x00016E77
			public _execute_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DCA RID: 3530
			// (get) Token: 0x06002FFA RID: 12282 RVA: 0x000B7C54 File Offset: 0x000B5E54
			// (set) Token: 0x06002FFB RID: 12283 RVA: 0x00018C80 File Offset: 0x00016E80
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._execute_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._execute_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DCB RID: 3531
			// (get) Token: 0x06002FFC RID: 12284 RVA: 0x000B7C7C File Offset: 0x000B5E7C
			// (set) Token: 0x06002FFD RID: 12285 RVA: 0x00018C9B File Offset: 0x00016E9B
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._execute_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._execute_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DCC RID: 3532
			// (get) Token: 0x06002FFE RID: 12286 RVA: 0x000B7CAC File Offset: 0x000B5EAC
			// (set) Token: 0x06002FFF RID: 12287 RVA: 0x00018CBA File Offset: 0x00016EBA
			public unsafe RunConfigureGameFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._execute_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunConfigureGameFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._execute_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DCD RID: 3533
			// (get) Token: 0x06003000 RID: 12288 RVA: 0x000B7CDC File Offset: 0x000B5EDC
			// (set) Token: 0x06003001 RID: 12289 RVA: 0x00018CD9 File Offset: 0x00016ED9
			public unsafe ConfigureGamePrompt _configurePrompt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._execute_d__0.NativeFieldInfoPtr__configurePrompt_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigureGamePrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureGameFlow._execute_d__0.NativeFieldInfoPtr__configurePrompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001DA8 RID: 7592
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001DA9 RID: 7593
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001DAA RID: 7594
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001DAB RID: 7595
			private static readonly IntPtr NativeFieldInfoPtr__configurePrompt_5__2;

			// Token: 0x04001DAC RID: 7596
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001DAD RID: 7597
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DAE RID: 7598
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001DAF RID: 7599
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001DB0 RID: 7600
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DB1 RID: 7601
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
