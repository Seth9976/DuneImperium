using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000AA RID: 170
	public class SteamRemotePlay : SteamClientClass<SteamRemotePlay>
	{
		// Token: 0x06000A34 RID: 2612 RVA: 0x00049C08 File Offset: 0x00047E08
		// Note: this type is marked as 'beforefieldinit'.
		static SteamRemotePlay()
		{
			Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamRemotePlay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr);
			SteamRemotePlay.NativeFieldInfoPtr_OnSessionConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, "OnSessionConnected");
			SteamRemotePlay.NativeFieldInfoPtr_OnSessionDisconnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, "OnSessionDisconnected");
			SteamRemotePlay.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamRemotePlay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, 100665807);
			SteamRemotePlay.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, 100665808);
			SteamRemotePlay.NativeMethodInfoPtr_InstallEvents_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, 100665809);
			SteamRemotePlay.NativeMethodInfoPtr_add_OnSessionConnected_Public_Static_add_Void_Action_1_RemotePlaySession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, 100665810);
			SteamRemotePlay.NativeMethodInfoPtr_remove_OnSessionConnected_Public_Static_rem_Void_Action_1_RemotePlaySession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, 100665811);
			SteamRemotePlay.NativeMethodInfoPtr_add_OnSessionDisconnected_Public_Static_add_Void_Action_1_RemotePlaySession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, 100665812);
			SteamRemotePlay.NativeMethodInfoPtr_remove_OnSessionDisconnected_Public_Static_rem_Void_Action_1_RemotePlaySession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, 100665813);
			SteamRemotePlay.NativeMethodInfoPtr_get_SessionCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, 100665814);
			SteamRemotePlay.NativeMethodInfoPtr_GetSession_Public_Static_RemotePlaySession_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, 100665815);
			SteamRemotePlay.NativeMethodInfoPtr_SendInvite_Public_Static_Boolean_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, 100665816);
			SteamRemotePlay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, 100665817);
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00049D3C File Offset: 0x00047F3C
		public unsafe static ISteamRemotePlay Internal
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 941926, RefRangeEnd = 941932, XrefRangeStart = 941923, XrefRangeEnd = 941926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamRemotePlay_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamRemotePlay>(intPtr3) : null;
			}
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00049D70 File Offset: 0x00047F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941932, XrefRangeEnd = 941937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamRemotePlay.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00049DBC File Offset: 0x00047FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 941977, RefRangeEnd = 941978, XrefRangeStart = 941937, XrefRangeEnd = 941977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstallEvents(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.NativeMethodInfoPtr_InstallEvents_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00049DFC File Offset: 0x00047FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941978, XrefRangeEnd = 941987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnSessionConnected(Action<RemotePlaySession> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.NativeMethodInfoPtr_add_OnSessionConnected_Public_Static_add_Void_Action_1_RemotePlaySession_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00049E34 File Offset: 0x00048034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941987, XrefRangeEnd = 941996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnSessionConnected(Action<RemotePlaySession> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.NativeMethodInfoPtr_remove_OnSessionConnected_Public_Static_rem_Void_Action_1_RemotePlaySession_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00049E6C File Offset: 0x0004806C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941996, XrefRangeEnd = 942005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnSessionDisconnected(Action<RemotePlaySession> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.NativeMethodInfoPtr_add_OnSessionDisconnected_Public_Static_add_Void_Action_1_RemotePlaySession_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00049EA4 File Offset: 0x000480A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942005, XrefRangeEnd = 942014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnSessionDisconnected(Action<RemotePlaySession> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.NativeMethodInfoPtr_remove_OnSessionDisconnected_Public_Static_rem_Void_Action_1_RemotePlaySession_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x00049EDC File Offset: 0x000480DC
		public unsafe static int SessionCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942014, XrefRangeEnd = 942017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.NativeMethodInfoPtr_get_SessionCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00049F0C File Offset: 0x0004810C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942017, XrefRangeEnd = 942021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RemotePlaySession GetSession(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.NativeMethodInfoPtr_GetSession_Public_Static_RemotePlaySession_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00049F4C File Offset: 0x0004814C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942021, XrefRangeEnd = 942024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SendInvite(SteamId steamid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.NativeMethodInfoPtr_SendInvite_Public_Static_Boolean_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00049F8C File Offset: 0x0004818C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942024, XrefRangeEnd = 942027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamRemotePlay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00002AB7 File Offset: 0x00000CB7
		public SteamRemotePlay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00049FC8 File Offset: 0x000481C8
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x00002AC0 File Offset: 0x00000CC0
		public unsafe static Action<RemotePlaySession> OnSessionConnected
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamRemotePlay.NativeFieldInfoPtr_OnSessionConnected, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<RemotePlaySession>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamRemotePlay.NativeFieldInfoPtr_OnSessionConnected, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00049FF0 File Offset: 0x000481F0
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x00002AD2 File Offset: 0x00000CD2
		public unsafe static Action<RemotePlaySession> OnSessionDisconnected
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamRemotePlay.NativeFieldInfoPtr_OnSessionDisconnected, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<RemotePlaySession>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamRemotePlay.NativeFieldInfoPtr_OnSessionDisconnected, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeFieldInfoPtr_OnSessionConnected;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeFieldInfoPtr_OnSessionDisconnected;

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamRemotePlay_0;

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x04001114 RID: 4372
		private static readonly IntPtr NativeMethodInfoPtr_InstallEvents_Internal_Void_Boolean_0;

		// Token: 0x04001115 RID: 4373
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSessionConnected_Public_Static_add_Void_Action_1_RemotePlaySession_0;

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSessionConnected_Public_Static_rem_Void_Action_1_RemotePlaySession_0;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSessionDisconnected_Public_Static_add_Void_Action_1_RemotePlaySession_0;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSessionDisconnected_Public_Static_rem_Void_Action_1_RemotePlaySession_0;

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeMethodInfoPtr_get_SessionCount_Public_Static_get_Int32_0;

		// Token: 0x0400111A RID: 4378
		private static readonly IntPtr NativeMethodInfoPtr_GetSession_Public_Static_RemotePlaySession_Int32_0;

		// Token: 0x0400111B RID: 4379
		private static readonly IntPtr NativeMethodInfoPtr_SendInvite_Public_Static_Boolean_SteamId_0;

		// Token: 0x0400111C RID: 4380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200024F RID: 591
		[ObfuscatedName("Steamworks.SteamRemotePlay+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001DCA RID: 7626 RVA: 0x000883AC File Offset: 0x000865AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SteamRemotePlay.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamRemotePlay.__c>.NativeClassPtr);
				SteamRemotePlay.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRemotePlay.__c>.NativeClassPtr, "<>9");
				SteamRemotePlay.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRemotePlay.__c>.NativeClassPtr, "<>9__3_0");
				SteamRemotePlay.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRemotePlay.__c>.NativeClassPtr, "<>9__3_1");
				SteamRemotePlay.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay.__c>.NativeClassPtr, 100665819);
				SteamRemotePlay.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_SteamRemotePlaySessionConnected_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay.__c>.NativeClassPtr, 100665820);
				SteamRemotePlay.__c.NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_SteamRemotePlaySessionDisconnected_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay.__c>.NativeClassPtr, 100665821);
			}

			// Token: 0x06001DCB RID: 7627 RVA: 0x00088450 File Offset: 0x00086650
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamRemotePlay.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DCC RID: 7628 RVA: 0x0008848C File Offset: 0x0008668C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941917, XrefRangeEnd = 941920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_0(SteamRemotePlaySessionConnected_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_SteamRemotePlaySessionConnected_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DCD RID: 7629 RVA: 0x000884CC File Offset: 0x000866CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941920, XrefRangeEnd = 941923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_1(SteamRemotePlaySessionDisconnected_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.__c.NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_SteamRemotePlaySessionDisconnected_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DCE RID: 7630 RVA: 0x0000A9B3 File Offset: 0x00008BB3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000784 RID: 1924
			// (get) Token: 0x06001DCF RID: 7631 RVA: 0x0008850C File Offset: 0x0008670C
			// (set) Token: 0x06001DD0 RID: 7632 RVA: 0x0000A9BC File Offset: 0x00008BBC
			public unsafe static SteamRemotePlay.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamRemotePlay.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamRemotePlay.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamRemotePlay.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000785 RID: 1925
			// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x00088534 File Offset: 0x00086734
			// (set) Token: 0x06001DD2 RID: 7634 RVA: 0x0000A9CE File Offset: 0x00008BCE
			public unsafe static Action<SteamRemotePlaySessionConnected_t> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamRemotePlay.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamRemotePlaySessionConnected_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamRemotePlay.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000786 RID: 1926
			// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x0008855C File Offset: 0x0008675C
			// (set) Token: 0x06001DD4 RID: 7636 RVA: 0x0000A9E0 File Offset: 0x00008BE0
			public unsafe static Action<SteamRemotePlaySessionDisconnected_t> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamRemotePlay.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamRemotePlaySessionDisconnected_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamRemotePlay.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400215E RID: 8542
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400215F RID: 8543
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04002160 RID: 8544
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x04002161 RID: 8545
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002162 RID: 8546
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_SteamRemotePlaySessionConnected_t_0;

			// Token: 0x04002163 RID: 8547
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_SteamRemotePlaySessionDisconnected_t_0;
		}
	}
}
