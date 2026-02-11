using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.lobby.responses;

namespace boardgames.menus
{
	// Token: 0x020001A2 RID: 418
	public class GameLobbySessionProvider : OnlinePlaySessionProvider
	{
		// Token: 0x060012AC RID: 4780 RVA: 0x00059A0C File Offset: 0x00057C0C
		// Note: this type is marked as 'beforefieldinit'.
		static GameLobbySessionProvider()
		{
			Il2CppClassPointerStore<GameLobbySessionProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus", "GameLobbySessionProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLobbySessionProvider>.NativeClassPtr);
			GameLobbySessionProvider.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLobbySessionProvider>.NativeClassPtr, "gameID");
			GameLobbySessionProvider.NativeMethodInfoPtr_Init_Public_IEnumerator_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbySessionProvider>.NativeClassPtr, 100666029);
			GameLobbySessionProvider.NativeMethodInfoPtr_Log_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbySessionProvider>.NativeClassPtr, 100666030);
			GameLobbySessionProvider.NativeMethodInfoPtr_handleUserRegistered_Private_Void_GameLobbyAuthenticated_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbySessionProvider>.NativeClassPtr, 100666031);
			GameLobbySessionProvider.NativeMethodInfoPtr_handleOpen_Protected_Virtual_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbySessionProvider>.NativeClassPtr, 100666032);
			GameLobbySessionProvider.NativeMethodInfoPtr_RegisterUser_Protected_Virtual_NetworkMessageEvent_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbySessionProvider>.NativeClassPtr, 100666033);
			GameLobbySessionProvider.NativeMethodInfoPtr_handleClose_Protected_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbySessionProvider>.NativeClassPtr, 100666034);
			GameLobbySessionProvider.NativeMethodInfoPtr_disposeSocket_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbySessionProvider>.NativeClassPtr, 100666035);
			GameLobbySessionProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbySessionProvider>.NativeClassPtr, 100666036);
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00059AF0 File Offset: 0x00057CF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 518140, RefRangeEnd = 518143, XrefRangeStart = 518134, XrefRangeEnd = 518140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init(GameID gameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLobbySessionProvider.NativeMethodInfoPtr_Init_Public_IEnumerator_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x00059B40 File Offset: 0x00057D40
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Log(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameLobbySessionProvider.NativeMethodInfoPtr_Log_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00059B90 File Offset: 0x00057D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518143, XrefRangeEnd = 518153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleUserRegistered(GameLobbyAuthenticated message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLobbySessionProvider.NativeMethodInfoPtr_handleUserRegistered_Private_Void_GameLobbyAuthenticated_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00059BD4 File Offset: 0x00057DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518153, XrefRangeEnd = 518176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void handleOpen(Object sender, EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameLobbySessionProvider.NativeMethodInfoPtr_handleOpen_Protected_Virtual_Void_Object_EventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00059C34 File Offset: 0x00057E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518176, XrefRangeEnd = 518199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NetworkMessageEvent RegisterUser(Dictionary<string, string> metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameLobbySessionProvider.NativeMethodInfoPtr_RegisterUser_Protected_Virtual_NetworkMessageEvent_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr3) : null;
			}
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00059C90 File Offset: 0x00057E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518199, XrefRangeEnd = 518208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void handleClose(int code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameLobbySessionProvider.NativeMethodInfoPtr_handleClose_Protected_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00059CDC File Offset: 0x00057EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518208, XrefRangeEnd = 518233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void disposeSocket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameLobbySessionProvider.NativeMethodInfoPtr_disposeSocket_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00059D18 File Offset: 0x00057F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518233, XrefRangeEnd = 518234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLobbySessionProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLobbySessionProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLobbySessionProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x0000AD50 File Offset: 0x00008F50
		public GameLobbySessionProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x00059D54 File Offset: 0x00057F54
		// (set) Token: 0x060012B7 RID: 4791 RVA: 0x0000AD59 File Offset: 0x00008F59
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLobbySessionProvider.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLobbySessionProvider.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_IEnumerator_GameID_0;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_Log_Protected_Virtual_Void_String_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_handleUserRegistered_Private_Void_GameLobbyAuthenticated_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_handleOpen_Protected_Virtual_Void_Object_EventArgs_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_RegisterUser_Protected_Virtual_NetworkMessageEvent_Dictionary_2_String_String_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_handleClose_Protected_Virtual_Void_Int32_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_disposeSocket_Protected_Virtual_Void_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000396 RID: 918
		[ObfuscatedName("boardgames.menus.GameLobbySessionProvider+<Init>d__1")]
		public sealed class _Init_d__1 : Object
		{
			// Token: 0x06002B3D RID: 11069 RVA: 0x000A9CF0 File Offset: 0x000A7EF0
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__1()
			{
				Il2CppClassPointerStore<GameLobbySessionProvider._Init_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLobbySessionProvider>.NativeClassPtr, "<Init>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLobbySessionProvider._Init_d__1>.NativeClassPtr);
				GameLobbySessionProvider._Init_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLobbySessionProvider._Init_d__1>.NativeClassPtr, "<>1__state");
				GameLobbySessionProvider._Init_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLobbySessionProvider._Init_d__1>.NativeClassPtr, "<>2__current");
				GameLobbySessionProvider._Init_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLobbySessionProvider._Init_d__1>.NativeClassPtr, "<>4__this");
				GameLobbySessionProvider._Init_d__1.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLobbySessionProvider._Init_d__1>.NativeClassPtr, "gameID");
				GameLobbySessionProvider._Init_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbySessionProvider._Init_d__1>.NativeClassPtr, 100666037);
				GameLobbySessionProvider._Init_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbySessionProvider._Init_d__1>.NativeClassPtr, 100666038);
				GameLobbySessionProvider._Init_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbySessionProvider._Init_d__1>.NativeClassPtr, 100666039);
				GameLobbySessionProvider._Init_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbySessionProvider._Init_d__1>.NativeClassPtr, 100666040);
				GameLobbySessionProvider._Init_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbySessionProvider._Init_d__1>.NativeClassPtr, 100666041);
				GameLobbySessionProvider._Init_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbySessionProvider._Init_d__1>.NativeClassPtr, 100666042);
			}

			// Token: 0x06002B3E RID: 11070 RVA: 0x000A9DE4 File Offset: 0x000A7FE4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLobbySessionProvider._Init_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLobbySessionProvider._Init_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B3F RID: 11071 RVA: 0x000A9E2C File Offset: 0x000A802C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLobbySessionProvider._Init_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B40 RID: 11072 RVA: 0x000A9E60 File Offset: 0x000A8060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518105, XrefRangeEnd = 518129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLobbySessionProvider._Init_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C41 RID: 3137
			// (get) Token: 0x06002B41 RID: 11073 RVA: 0x000A9E9C File Offset: 0x000A809C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLobbySessionProvider._Init_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B42 RID: 11074 RVA: 0x000A9EDC File Offset: 0x000A80DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518129, XrefRangeEnd = 518134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLobbySessionProvider._Init_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C42 RID: 3138
			// (get) Token: 0x06002B43 RID: 11075 RVA: 0x000A9F10 File Offset: 0x000A8110
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLobbySessionProvider._Init_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B44 RID: 11076 RVA: 0x00016589 File Offset: 0x00014789
			public _Init_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C3D RID: 3133
			// (get) Token: 0x06002B45 RID: 11077 RVA: 0x000A9F50 File Offset: 0x000A8150
			// (set) Token: 0x06002B46 RID: 11078 RVA: 0x00016592 File Offset: 0x00014792
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLobbySessionProvider._Init_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLobbySessionProvider._Init_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C3E RID: 3134
			// (get) Token: 0x06002B47 RID: 11079 RVA: 0x000A9F78 File Offset: 0x000A8178
			// (set) Token: 0x06002B48 RID: 11080 RVA: 0x000165AD File Offset: 0x000147AD
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLobbySessionProvider._Init_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLobbySessionProvider._Init_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C3F RID: 3135
			// (get) Token: 0x06002B49 RID: 11081 RVA: 0x000A9FA8 File Offset: 0x000A81A8
			// (set) Token: 0x06002B4A RID: 11082 RVA: 0x000165CC File Offset: 0x000147CC
			public unsafe GameLobbySessionProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLobbySessionProvider._Init_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLobbySessionProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLobbySessionProvider._Init_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C40 RID: 3136
			// (get) Token: 0x06002B4B RID: 11083 RVA: 0x000A9FD8 File Offset: 0x000A81D8
			// (set) Token: 0x06002B4C RID: 11084 RVA: 0x000165EB File Offset: 0x000147EB
			public unsafe GameID gameID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLobbySessionProvider._Init_d__1.NativeFieldInfoPtr_gameID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLobbySessionProvider._Init_d__1.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001AF3 RID: 6899
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001AF4 RID: 6900
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001AF5 RID: 6901
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001AF6 RID: 6902
			private static readonly IntPtr NativeFieldInfoPtr_gameID;

			// Token: 0x04001AF7 RID: 6903
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001AF8 RID: 6904
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AF9 RID: 6905
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001AFA RID: 6906
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001AFB RID: 6907
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AFC RID: 6908
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
