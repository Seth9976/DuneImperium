using System;
using Canis.json.events;
using dwd.canis;
using dwd.canis.dbg_client.switchboard;
using dwd.core.session;
using dwd.core.wargServer;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;
using NativeWebSocket;
using platform.websocket;

namespace boardgames.menus
{
	// Token: 0x020001AB RID: 427
	public class OnlinePlaySessionProvider : SessionProvider
	{
		// Token: 0x06001310 RID: 4880 RVA: 0x0005B36C File Offset: 0x0005956C
		// Note: this type is marked as 'beforefieldinit'.
		static OnlinePlaySessionProvider()
		{
			Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus", "OnlinePlaySessionProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr);
			OnlinePlaySessionProvider.NativeFieldInfoPtr_socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, "socket");
			OnlinePlaySessionProvider.NativeFieldInfoPtr_messagesToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, "messagesToProcess");
			OnlinePlaySessionProvider.NativeFieldInfoPtr_MaxConnectAttempts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, "MaxConnectAttempts");
			OnlinePlaySessionProvider.NativeFieldInfoPtr_connectAttempts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, "connectAttempts");
			OnlinePlaySessionProvider.NativeFieldInfoPtr_receivedDisconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, "receivedDisconnect");
			OnlinePlaySessionProvider.NativeFieldInfoPtr_additionalMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, "additionalMetadata");
			OnlinePlaySessionProvider.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, "<Initialized>k__BackingField");
			OnlinePlaySessionProvider.NativeFieldInfoPtr_networkMonitorCancellationSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, "networkMonitorCancellationSource");
			OnlinePlaySessionProvider.NativeMethodInfoPtr_get_Initialized_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666111);
			OnlinePlaySessionProvider.NativeMethodInfoPtr_set_Initialized_Protected_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666112);
			OnlinePlaySessionProvider.NativeMethodInfoPtr_get_SocketState_Public_get_WebSocketState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666113);
			OnlinePlaySessionProvider.NativeMethodInfoPtr_Initialize_Public_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666114);
			OnlinePlaySessionProvider.NativeMethodInfoPtr_AddAdditionalMetadata_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666115);
			OnlinePlaySessionProvider.NativeMethodInfoPtr_Log_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666116);
			OnlinePlaySessionProvider.NativeMethodInfoPtr_get_AlwaysLogMessages_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666117);
			OnlinePlaySessionProvider.NativeMethodInfoPtr_DeserializeMessage_Private_NetworkMessageEvent_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666118);
			OnlinePlaySessionProvider.NativeMethodInfoPtr_handleOpen_Protected_Virtual_New_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666119);
			OnlinePlaySessionProvider.NativeMethodInfoPtr_RegisterUser_Protected_Abstract_Virtual_New_NetworkMessageEvent_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666120);
			OnlinePlaySessionProvider.NativeMethodInfoPtr_handleRegistered_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666121);
			OnlinePlaySessionProvider.NativeMethodInfoPtr_handleClose_Private_Void_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666122);
			OnlinePlaySessionProvider.NativeMethodInfoPtr_handleClose_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666123);
			OnlinePlaySessionProvider.NativeMethodInfoPtr_Terminate_Public_Virtual_Void_DisconnectReasons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666124);
			OnlinePlaySessionProvider.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666125);
			OnlinePlaySessionProvider.NativeMethodInfoPtr_MonitorSocket_Private_Task_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666126);
			OnlinePlaySessionProvider.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666127);
			OnlinePlaySessionProvider.NativeMethodInfoPtr_Write_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666128);
			OnlinePlaySessionProvider.NativeMethodInfoPtr_disposeSocket_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666129);
			OnlinePlaySessionProvider.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, 100666130);
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001311 RID: 4881 RVA: 0x0005B5CC File Offset: 0x000597CC
		// (set) Token: 0x06001312 RID: 4882 RVA: 0x0005B614 File Offset: 0x00059814
		public unsafe override bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlinePlaySessionProvider.NativeMethodInfoPtr_get_Initialized_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlinePlaySessionProvider.NativeMethodInfoPtr_set_Initialized_Protected_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001313 RID: 4883 RVA: 0x0005B660 File Offset: 0x00059860
		public unsafe WebSocketState SocketState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519005, XrefRangeEnd = 519008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlinePlaySessionProvider.NativeMethodInfoPtr_get_SocketState_Public_get_WebSocketState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x0005B69C File Offset: 0x0005989C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 519014, RefRangeEnd = 519016, XrefRangeStart = 519008, XrefRangeEnd = 519014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Initialize(string lobbyUrl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(lobbyUrl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlinePlaySessionProvider.NativeMethodInfoPtr_Initialize_Public_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0005B6EC File Offset: 0x000598EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519016, XrefRangeEnd = 519020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAdditionalMetadata(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlinePlaySessionProvider.NativeMethodInfoPtr_AddAdditionalMetadata_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0005B740 File Offset: 0x00059940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519020, XrefRangeEnd = 519031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Log(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlinePlaySessionProvider.NativeMethodInfoPtr_Log_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x0005B790 File Offset: 0x00059990
		public unsafe virtual bool AlwaysLogMessages
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlinePlaySessionProvider.NativeMethodInfoPtr_get_AlwaysLogMessages_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0005B7D8 File Offset: 0x000599D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519031, XrefRangeEnd = 519063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkMessageEvent DeserializeMessage(Il2CppStructArray<byte> e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlinePlaySessionProvider.NativeMethodInfoPtr_DeserializeMessage_Private_NetworkMessageEvent_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x0005B828 File Offset: 0x00059A28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 519131, RefRangeEnd = 519133, XrefRangeStart = 519063, XrefRangeEnd = 519131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void handleOpen(Object sender, EventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlinePlaySessionProvider.NativeMethodInfoPtr_handleOpen_Protected_Virtual_New_Void_Object_EventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x0005B888 File Offset: 0x00059A88
		[CallerCount(0)]
		public unsafe virtual NetworkMessageEvent RegisterUser(Dictionary<string, string> metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlinePlaySessionProvider.NativeMethodInfoPtr_RegisterUser_Protected_Abstract_Virtual_New_NetworkMessageEvent_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x0005B8E4 File Offset: 0x00059AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519133, XrefRangeEnd = 519135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleRegistered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlinePlaySessionProvider.NativeMethodInfoPtr_handleRegistered_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x0005B918 File Offset: 0x00059B18
		[CallerCount(0)]
		public unsafe void handleClose(Object sender, int code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref code;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlinePlaySessionProvider.NativeMethodInfoPtr_handleClose_Private_Void_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0005B968 File Offset: 0x00059B68
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void handleClose(int code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlinePlaySessionProvider.NativeMethodInfoPtr_handleClose_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0005B9B4 File Offset: 0x00059BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519135, XrefRangeEnd = 519141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Terminate(WargSession.DisconnectReasons reason = WargSession.DisconnectReasons.Error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reason;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlinePlaySessionProvider.NativeMethodInfoPtr_Terminate_Public_Virtual_Void_DisconnectReasons_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0005BA00 File Offset: 0x00059C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519141, XrefRangeEnd = 519142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlinePlaySessionProvider.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x0005BA3C File Offset: 0x00059C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519142, XrefRangeEnd = 519154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task MonitorSocket(string lobbyUrl, CancellationToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(lobbyUrl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlinePlaySessionProvider.NativeMethodInfoPtr_MonitorSocket_Private_Task_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0005BAA4 File Offset: 0x00059CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519154, XrefRangeEnd = 519174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlinePlaySessionProvider.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0005BAD8 File Offset: 0x00059CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519174, XrefRangeEnd = 519187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Object message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlinePlaySessionProvider.NativeMethodInfoPtr_Write_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x0005BB28 File Offset: 0x00059D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519187, XrefRangeEnd = 519191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void disposeSocket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlinePlaySessionProvider.NativeMethodInfoPtr_disposeSocket_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x0005BB64 File Offset: 0x00059D64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 519206, RefRangeEnd = 519210, XrefRangeStart = 519191, XrefRangeEnd = 519206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnlinePlaySessionProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlinePlaySessionProvider.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0000AF3E File Offset: 0x0000913E
		public OnlinePlaySessionProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x0005BBA0 File Offset: 0x00059DA0
		// (set) Token: 0x06001327 RID: 4903 RVA: 0x0000AF47 File Offset: 0x00009147
		public unsafe DWDWebSocket<NetworkMessageEvent> socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider.NativeFieldInfoPtr_socket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDWebSocket<NetworkMessageEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider.NativeFieldInfoPtr_socket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x0005BBD0 File Offset: 0x00059DD0
		// (set) Token: 0x06001329 RID: 4905 RVA: 0x0000AF66 File Offset: 0x00009166
		public unsafe List<NetworkMessageEvent> messagesToProcess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider.NativeFieldInfoPtr_messagesToProcess);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NetworkMessageEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider.NativeFieldInfoPtr_messagesToProcess), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x0005BC00 File Offset: 0x00059E00
		// (set) Token: 0x0600132B RID: 4907 RVA: 0x0000AF85 File Offset: 0x00009185
		public unsafe static int MaxConnectAttempts
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OnlinePlaySessionProvider.NativeFieldInfoPtr_MaxConnectAttempts, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OnlinePlaySessionProvider.NativeFieldInfoPtr_MaxConnectAttempts, (void*)(&value));
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x0005BC1C File Offset: 0x00059E1C
		// (set) Token: 0x0600132D RID: 4909 RVA: 0x0000AF93 File Offset: 0x00009193
		public unsafe int connectAttempts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider.NativeFieldInfoPtr_connectAttempts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider.NativeFieldInfoPtr_connectAttempts)) = value;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x0005BC44 File Offset: 0x00059E44
		// (set) Token: 0x0600132F RID: 4911 RVA: 0x0000AFAE File Offset: 0x000091AE
		public unsafe bool receivedDisconnect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider.NativeFieldInfoPtr_receivedDisconnect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider.NativeFieldInfoPtr_receivedDisconnect)) = value;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x0005BC6C File Offset: 0x00059E6C
		// (set) Token: 0x06001331 RID: 4913 RVA: 0x0000AFC9 File Offset: 0x000091C9
		public unsafe Dictionary<string, string> additionalMetadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider.NativeFieldInfoPtr_additionalMetadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider.NativeFieldInfoPtr_additionalMetadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x0005BC9C File Offset: 0x00059E9C
		// (set) Token: 0x06001333 RID: 4915 RVA: 0x0000AFE8 File Offset: 0x000091E8
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x0005BCC4 File Offset: 0x00059EC4
		// (set) Token: 0x06001335 RID: 4917 RVA: 0x0000B003 File Offset: 0x00009203
		public unsafe CancellationTokenSource networkMonitorCancellationSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider.NativeFieldInfoPtr_networkMonitorCancellationSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider.NativeFieldInfoPtr_networkMonitorCancellationSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeFieldInfoPtr_socket;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeFieldInfoPtr_messagesToProcess;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeFieldInfoPtr_MaxConnectAttempts;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeFieldInfoPtr_connectAttempts;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeFieldInfoPtr_receivedDisconnect;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeFieldInfoPtr_additionalMetadata;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeFieldInfoPtr_networkMonitorCancellationSource;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Virtual_get_Boolean_0;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Protected_Virtual_set_Void_Boolean_0;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeMethodInfoPtr_get_SocketState_Public_get_WebSocketState_0;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_IEnumerator_String_0;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeMethodInfoPtr_AddAdditionalMetadata_Public_Void_String_String_0;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeMethodInfoPtr_Log_Protected_Virtual_New_Void_String_0;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr_get_AlwaysLogMessages_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeMessage_Private_NetworkMessageEvent_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr_handleOpen_Protected_Virtual_New_Void_Object_EventArgs_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr_RegisterUser_Protected_Abstract_Virtual_New_NetworkMessageEvent_Dictionary_2_String_String_0;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr_handleRegistered_Protected_Void_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr_handleClose_Private_Void_Object_Int32_0;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr_handleClose_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeMethodInfoPtr_Terminate_Public_Virtual_Void_DisconnectReasons_0;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeMethodInfoPtr_MonitorSocket_Private_Task_String_CancellationToken_0;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Object_0;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeMethodInfoPtr_disposeSocket_Protected_Virtual_New_Void_0;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020003A3 RID: 931
		[ObfuscatedName("boardgames.menus.OnlinePlaySessionProvider+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x06002B99 RID: 11161 RVA: 0x000AAF84 File Offset: 0x000A9184
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<OnlinePlaySessionProvider.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlinePlaySessionProvider.__c__DisplayClass13_0>.NativeClassPtr);
				OnlinePlaySessionProvider.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				OnlinePlaySessionProvider.__c__DisplayClass13_0.NativeFieldInfoPtr_lobbyUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider.__c__DisplayClass13_0>.NativeClassPtr, "lobbyUrl");
				OnlinePlaySessionProvider.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider.__c__DisplayClass13_0>.NativeClassPtr, 100666131);
				OnlinePlaySessionProvider.__c__DisplayClass13_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider.__c__DisplayClass13_0>.NativeClassPtr, 100666132);
			}

			// Token: 0x06002B9A RID: 11162 RVA: 0x000AB000 File Offset: 0x000A9200
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlinePlaySessionProvider.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlinePlaySessionProvider.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B9B RID: 11163 RVA: 0x000AB03C File Offset: 0x000A923C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518764, XrefRangeEnd = 518777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task _Initialize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlinePlaySessionProvider.__c__DisplayClass13_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}

			// Token: 0x06002B9C RID: 11164 RVA: 0x00016832 File Offset: 0x00014A32
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C58 RID: 3160
			// (get) Token: 0x06002B9D RID: 11165 RVA: 0x000AB07C File Offset: 0x000A927C
			// (set) Token: 0x06002B9E RID: 11166 RVA: 0x0001683B File Offset: 0x00014A3B
			public unsafe OnlinePlaySessionProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OnlinePlaySessionProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C59 RID: 3161
			// (get) Token: 0x06002B9F RID: 11167 RVA: 0x000AB0AC File Offset: 0x000A92AC
			// (set) Token: 0x06002BA0 RID: 11168 RVA: 0x0001685A File Offset: 0x00014A5A
			public unsafe string lobbyUrl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider.__c__DisplayClass13_0.NativeFieldInfoPtr_lobbyUrl);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider.__c__DisplayClass13_0.NativeFieldInfoPtr_lobbyUrl), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001B2A RID: 6954
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B2B RID: 6955
			private static readonly IntPtr NativeFieldInfoPtr_lobbyUrl;

			// Token: 0x04001B2C RID: 6956
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B2D RID: 6957
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_Task_0;
		}

		// Token: 0x020003A4 RID: 932
		[ObfuscatedName("boardgames.menus.OnlinePlaySessionProvider+<Initialize>d__13")]
		public sealed class _Initialize_d__13 : Object
		{
			// Token: 0x06002BA1 RID: 11169 RVA: 0x000AB0D4 File Offset: 0x000A92D4
			// Note: this type is marked as 'beforefieldinit'.
			static _Initialize_d__13()
			{
				Il2CppClassPointerStore<OnlinePlaySessionProvider._Initialize_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, "<Initialize>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlinePlaySessionProvider._Initialize_d__13>.NativeClassPtr);
				OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider._Initialize_d__13>.NativeClassPtr, "<>1__state");
				OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider._Initialize_d__13>.NativeClassPtr, "<>2__current");
				OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider._Initialize_d__13>.NativeClassPtr, "<>4__this");
				OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr_lobbyUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider._Initialize_d__13>.NativeClassPtr, "lobbyUrl");
				OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider._Initialize_d__13>.NativeClassPtr, "<>8__1");
				OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr__bulwarkingCommand_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider._Initialize_d__13>.NativeClassPtr, "<bulwarkingCommand>5__2");
				OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr__reputationCommand_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider._Initialize_d__13>.NativeClassPtr, "<reputationCommand>5__3");
				OnlinePlaySessionProvider._Initialize_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider._Initialize_d__13>.NativeClassPtr, 100666133);
				OnlinePlaySessionProvider._Initialize_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider._Initialize_d__13>.NativeClassPtr, 100666134);
				OnlinePlaySessionProvider._Initialize_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider._Initialize_d__13>.NativeClassPtr, 100666135);
				OnlinePlaySessionProvider._Initialize_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider._Initialize_d__13>.NativeClassPtr, 100666136);
				OnlinePlaySessionProvider._Initialize_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider._Initialize_d__13>.NativeClassPtr, 100666137);
				OnlinePlaySessionProvider._Initialize_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider._Initialize_d__13>.NativeClassPtr, 100666138);
			}

			// Token: 0x06002BA2 RID: 11170 RVA: 0x000AB204 File Offset: 0x000A9404
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Initialize_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlinePlaySessionProvider._Initialize_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlinePlaySessionProvider._Initialize_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002BA3 RID: 11171 RVA: 0x000AB24C File Offset: 0x000A944C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlinePlaySessionProvider._Initialize_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BA4 RID: 11172 RVA: 0x000AB280 File Offset: 0x000A9480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518777, XrefRangeEnd = 518817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlinePlaySessionProvider._Initialize_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C61 RID: 3169
			// (get) Token: 0x06002BA5 RID: 11173 RVA: 0x000AB2BC File Offset: 0x000A94BC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlinePlaySessionProvider._Initialize_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002BA6 RID: 11174 RVA: 0x000AB2FC File Offset: 0x000A94FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518817, XrefRangeEnd = 518822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlinePlaySessionProvider._Initialize_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C62 RID: 3170
			// (get) Token: 0x06002BA7 RID: 11175 RVA: 0x000AB330 File Offset: 0x000A9530
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlinePlaySessionProvider._Initialize_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002BA8 RID: 11176 RVA: 0x00016879 File Offset: 0x00014A79
			public _Initialize_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C5A RID: 3162
			// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x000AB370 File Offset: 0x000A9570
			// (set) Token: 0x06002BAA RID: 11178 RVA: 0x00016882 File Offset: 0x00014A82
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C5B RID: 3163
			// (get) Token: 0x06002BAB RID: 11179 RVA: 0x000AB398 File Offset: 0x000A9598
			// (set) Token: 0x06002BAC RID: 11180 RVA: 0x0001689D File Offset: 0x00014A9D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C5C RID: 3164
			// (get) Token: 0x06002BAD RID: 11181 RVA: 0x000AB3C8 File Offset: 0x000A95C8
			// (set) Token: 0x06002BAE RID: 11182 RVA: 0x000168BC File Offset: 0x00014ABC
			public unsafe OnlinePlaySessionProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OnlinePlaySessionProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C5D RID: 3165
			// (get) Token: 0x06002BAF RID: 11183 RVA: 0x000AB3F8 File Offset: 0x000A95F8
			// (set) Token: 0x06002BB0 RID: 11184 RVA: 0x000168DB File Offset: 0x00014ADB
			public unsafe string lobbyUrl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr_lobbyUrl);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr_lobbyUrl), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000C5E RID: 3166
			// (get) Token: 0x06002BB1 RID: 11185 RVA: 0x000AB420 File Offset: 0x000A9620
			// (set) Token: 0x06002BB2 RID: 11186 RVA: 0x000168FA File Offset: 0x00014AFA
			public unsafe OnlinePlaySessionProvider.__c__DisplayClass13_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OnlinePlaySessionProvider.__c__DisplayClass13_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C5F RID: 3167
			// (get) Token: 0x06002BB3 RID: 11187 RVA: 0x000AB450 File Offset: 0x000A9650
			// (set) Token: 0x06002BB4 RID: 11188 RVA: 0x00016919 File Offset: 0x00014B19
			public unsafe GetSwitchboardFeatureCommand _bulwarkingCommand_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr__bulwarkingCommand_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetSwitchboardFeatureCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr__bulwarkingCommand_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C60 RID: 3168
			// (get) Token: 0x06002BB5 RID: 11189 RVA: 0x000AB480 File Offset: 0x000A9680
			// (set) Token: 0x06002BB6 RID: 11190 RVA: 0x00016938 File Offset: 0x00014B38
			public unsafe FetchPlayerReputation _reputationCommand_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr__reputationCommand_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FetchPlayerReputation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._Initialize_d__13.NativeFieldInfoPtr__reputationCommand_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B2E RID: 6958
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B2F RID: 6959
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B30 RID: 6960
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B31 RID: 6961
			private static readonly IntPtr NativeFieldInfoPtr_lobbyUrl;

			// Token: 0x04001B32 RID: 6962
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04001B33 RID: 6963
			private static readonly IntPtr NativeFieldInfoPtr__bulwarkingCommand_5__2;

			// Token: 0x04001B34 RID: 6964
			private static readonly IntPtr NativeFieldInfoPtr__reputationCommand_5__3;

			// Token: 0x04001B35 RID: 6965
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B36 RID: 6966
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B37 RID: 6967
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B38 RID: 6968
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B39 RID: 6969
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B3A RID: 6970
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003A5 RID: 933
		[ObfuscatedName("boardgames.menus.OnlinePlaySessionProvider+<MonitorSocket>d__26")]
		public sealed class _MonitorSocket_d__26 : ValueType
		{
			// Token: 0x06002BB7 RID: 11191 RVA: 0x000AB4B0 File Offset: 0x000A96B0
			// Note: this type is marked as 'beforefieldinit'.
			static _MonitorSocket_d__26()
			{
				Il2CppClassPointerStore<OnlinePlaySessionProvider._MonitorSocket_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnlinePlaySessionProvider>.NativeClassPtr, "<MonitorSocket>d__26");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlinePlaySessionProvider._MonitorSocket_d__26>.NativeClassPtr);
				OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider._MonitorSocket_d__26>.NativeClassPtr, "<>1__state");
				OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider._MonitorSocket_d__26>.NativeClassPtr, "<>t__builder");
				OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider._MonitorSocket_d__26>.NativeClassPtr, "<>4__this");
				OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr_lobbyUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider._MonitorSocket_d__26>.NativeClassPtr, "lobbyUrl");
				OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider._MonitorSocket_d__26>.NativeClassPtr, "token");
				OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider._MonitorSocket_d__26>.NativeClassPtr, "<>u__1");
				OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider._MonitorSocket_d__26>.NativeClassPtr, "<>u__2");
				OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlinePlaySessionProvider._MonitorSocket_d__26>.NativeClassPtr, "<>u__3");
				OnlinePlaySessionProvider._MonitorSocket_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider._MonitorSocket_d__26>.NativeClassPtr, 100666139);
				OnlinePlaySessionProvider._MonitorSocket_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlinePlaySessionProvider._MonitorSocket_d__26>.NativeClassPtr, 100666140);
			}

			// Token: 0x06002BB8 RID: 11192 RVA: 0x000AB5A4 File Offset: 0x000A97A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518822, XrefRangeEnd = 519001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlinePlaySessionProvider._MonitorSocket_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BB9 RID: 11193 RVA: 0x000AB5DC File Offset: 0x000A97DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519001, XrefRangeEnd = 519005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlinePlaySessionProvider._MonitorSocket_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002BBA RID: 11194 RVA: 0x00016957 File Offset: 0x00014B57
			public _MonitorSocket_d__26(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002BBB RID: 11195 RVA: 0x00016960 File Offset: 0x00014B60
			public _MonitorSocket_d__26()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlinePlaySessionProvider._MonitorSocket_d__26>.NativeClassPtr))
			{
			}

			// Token: 0x17000C63 RID: 3171
			// (get) Token: 0x06002BBC RID: 11196 RVA: 0x000AB624 File Offset: 0x000A9824
			// (set) Token: 0x06002BBD RID: 11197 RVA: 0x00016972 File Offset: 0x00014B72
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C64 RID: 3172
			// (get) Token: 0x06002BBE RID: 11198 RVA: 0x000AB64C File Offset: 0x000A984C
			// (set) Token: 0x06002BBF RID: 11199 RVA: 0x0001698D File Offset: 0x00014B8D
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000C65 RID: 3173
			// (get) Token: 0x06002BC0 RID: 11200 RVA: 0x000AB67C File Offset: 0x000A987C
			// (set) Token: 0x06002BC1 RID: 11201 RVA: 0x000169BB File Offset: 0x00014BBB
			public unsafe OnlinePlaySessionProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OnlinePlaySessionProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C66 RID: 3174
			// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x000AB6AC File Offset: 0x000A98AC
			// (set) Token: 0x06002BC3 RID: 11203 RVA: 0x000169DA File Offset: 0x00014BDA
			public unsafe string lobbyUrl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr_lobbyUrl);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr_lobbyUrl), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000C67 RID: 3175
			// (get) Token: 0x06002BC4 RID: 11204 RVA: 0x000AB6D4 File Offset: 0x000A98D4
			// (set) Token: 0x06002BC5 RID: 11205 RVA: 0x000169F9 File Offset: 0x00014BF9
			public CancellationToken token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr_token);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr_token), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000C68 RID: 3176
			// (get) Token: 0x06002BC6 RID: 11206 RVA: 0x000AB704 File Offset: 0x000A9904
			// (set) Token: 0x06002BC7 RID: 11207 RVA: 0x00016A27 File Offset: 0x00014C27
			public TaskAwaiter<WebSocketCloseCode> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<WebSocketCloseCode>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<WebSocketCloseCode>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<WebSocketCloseCode>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000C69 RID: 3177
			// (get) Token: 0x06002BC8 RID: 11208 RVA: 0x000AB734 File Offset: 0x000A9934
			// (set) Token: 0x06002BC9 RID: 11209 RVA: 0x00016A55 File Offset: 0x00014C55
			public TaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000C6A RID: 3178
			// (get) Token: 0x06002BCA RID: 11210 RVA: 0x000AB764 File Offset: 0x000A9964
			// (set) Token: 0x06002BCB RID: 11211 RVA: 0x00016A83 File Offset: 0x00014C83
			public unsafe Object __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr___u__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlinePlaySessionProvider._MonitorSocket_d__26.NativeFieldInfoPtr___u__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B3B RID: 6971
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B3C RID: 6972
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001B3D RID: 6973
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B3E RID: 6974
			private static readonly IntPtr NativeFieldInfoPtr_lobbyUrl;

			// Token: 0x04001B3F RID: 6975
			private static readonly IntPtr NativeFieldInfoPtr_token;

			// Token: 0x04001B40 RID: 6976
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001B41 RID: 6977
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04001B42 RID: 6978
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x04001B43 RID: 6979
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B44 RID: 6980
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
