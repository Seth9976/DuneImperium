using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x020001D8 RID: 472
	[Serializable]
	public class PlayerConnection : ScriptableObject
	{
		// Token: 0x06002145 RID: 8517 RVA: 0x000928F0 File Offset: 0x00090AF0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerConnection()
		{
			Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Networking.PlayerConnection", "PlayerConnection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr);
			PlayerConnection.NativeFieldInfoPtr_connectionNative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "connectionNative");
			PlayerConnection.NativeFieldInfoPtr_m_PlayerEditorConnectionEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "m_PlayerEditorConnectionEvents");
			PlayerConnection.NativeFieldInfoPtr_m_connectedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "m_connectedPlayers");
			PlayerConnection.NativeFieldInfoPtr_m_IsInitilized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "m_IsInitilized");
			PlayerConnection.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "s_Instance");
			PlayerConnection.NativeMethodInfoPtr_get_instance_Public_Static_get_PlayerConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100667776);
			PlayerConnection.NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100667777);
			PlayerConnection.NativeMethodInfoPtr_CreateInstance_Private_Static_PlayerConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100667778);
			PlayerConnection.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100667779);
			PlayerConnection.NativeMethodInfoPtr_GetConnectionNativeApi_Private_IPlayerEditorConnectionNative_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100667780);
			PlayerConnection.NativeMethodInfoPtr_Register_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100667781);
			PlayerConnection.NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100667782);
			PlayerConnection.NativeMethodInfoPtr_RegisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100667783);
			PlayerConnection.NativeMethodInfoPtr_RegisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100667784);
			PlayerConnection.NativeMethodInfoPtr_UnregisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100667785);
			PlayerConnection.NativeMethodInfoPtr_UnregisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100667786);
			PlayerConnection.NativeMethodInfoPtr_Send_Public_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100667787);
			PlayerConnection.NativeMethodInfoPtr_TrySend_Public_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100667788);
			PlayerConnection.NativeMethodInfoPtr_BlockUntilRecvMsg_Public_Boolean_Guid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100667789);
			PlayerConnection.NativeMethodInfoPtr_DisconnectAll_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100667790);
			PlayerConnection.NativeMethodInfoPtr_MessageCallbackInternal_Private_Static_Void_IntPtr_UInt64_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100667791);
			PlayerConnection.NativeMethodInfoPtr_ConnectedCallbackInternal_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100667792);
			PlayerConnection.NativeMethodInfoPtr_DisconnectedCallback_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100667793);
			PlayerConnection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100667794);
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06002146 RID: 8518 RVA: 0x00092B00 File Offset: 0x00090D00
		public unsafe static PlayerConnection instance
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 680950, RefRangeEnd = 680956, XrefRangeStart = 680934, XrefRangeEnd = 680950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_get_instance_Public_Static_get_PlayerConnection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerConnection>(intPtr3) : null;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06002147 RID: 8519 RVA: 0x00092B34 File Offset: 0x00090D34
		public unsafe bool isConnected
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680956, XrefRangeEnd = 680966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x00092B70 File Offset: 0x00090D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680966, XrefRangeEnd = 680976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayerConnection CreateInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_CreateInstance_Private_Static_PlayerConnection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerConnection>(intPtr3) : null;
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x00092BA4 File Offset: 0x00090DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680976, XrefRangeEnd = 680980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00092BD8 File Offset: 0x00090DD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 680986, RefRangeEnd = 680989, XrefRangeStart = 680980, XrefRangeEnd = 680986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPlayerEditorConnectionNative GetConnectionNativeApi()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_GetConnectionNativeApi_Private_IPlayerEditorConnectionNative_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPlayerEditorConnectionNative>(intPtr3) : null;
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x00092C18 File Offset: 0x00090E18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681022, RefRangeEnd = 681023, XrefRangeStart = 680989, XrefRangeEnd = 681022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Register(Guid messageId, UnityEngine.Events.UnityAction<MessageEventArgs> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_Register_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x00092C68 File Offset: 0x00090E68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681059, RefRangeEnd = 681060, XrefRangeStart = 681023, XrefRangeEnd = 681059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unregister(Guid messageId, UnityEngine.Events.UnityAction<MessageEventArgs> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x00092CB8 File Offset: 0x00090EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681060, XrefRangeEnd = 681077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RegisterConnection(UnityEngine.Events.UnityAction<int> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_RegisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x00092CFC File Offset: 0x00090EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681077, XrefRangeEnd = 681081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RegisterDisconnection(UnityEngine.Events.UnityAction<int> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_RegisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x00092D40 File Offset: 0x00090F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681081, XrefRangeEnd = 681085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnregisterConnection(UnityEngine.Events.UnityAction<int> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_UnregisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x00092D84 File Offset: 0x00090F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681085, XrefRangeEnd = 681089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnregisterDisconnection(UnityEngine.Events.UnityAction<int> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_UnregisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x00092DC8 File Offset: 0x00090FC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681101, RefRangeEnd = 681102, XrefRangeStart = 681089, XrefRangeEnd = 681101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Send(Guid messageId, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_Send_Public_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x00092E18 File Offset: 0x00091018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681102, XrefRangeEnd = 681114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TrySend(Guid messageId, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_TrySend_Public_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x00092E74 File Offset: 0x00091074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681114, XrefRangeEnd = 681149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BlockUntilRecvMsg(Guid messageId, int timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_BlockUntilRecvMsg_Public_Boolean_Guid_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x00092ECC File Offset: 0x000910CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681149, XrefRangeEnd = 681159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DisconnectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_DisconnectAll_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x00092F00 File Offset: 0x00091100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681159, XrefRangeEnd = 681170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guid;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(messageId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_MessageCallbackInternal_Private_Static_Void_IntPtr_UInt64_UInt64_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x00092F60 File Offset: 0x00091160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681170, XrefRangeEnd = 681181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConnectedCallbackInternal(int playerId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_ConnectedCallbackInternal_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x00092F94 File Offset: 0x00091194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681181, XrefRangeEnd = 681190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisconnectedCallback(int playerId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_DisconnectedCallback_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x00092FC8 File Offset: 0x000911C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681190, XrefRangeEnd = 681223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerConnection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x0000CBC1 File Offset: 0x0000ADC1
		public PlayerConnection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x0600215A RID: 8538 RVA: 0x00093004 File Offset: 0x00091204
		// (set) Token: 0x0600215B RID: 8539 RVA: 0x0000CBCA File Offset: 0x0000ADCA
		public unsafe static IPlayerEditorConnectionNative connectionNative
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerConnection.NativeFieldInfoPtr_connectionNative, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPlayerEditorConnectionNative>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerConnection.NativeFieldInfoPtr_connectionNative, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x0009302C File Offset: 0x0009122C
		// (set) Token: 0x0600215D RID: 8541 RVA: 0x0000CBDC File Offset: 0x0000ADDC
		public unsafe PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.NativeFieldInfoPtr_m_PlayerEditorConnectionEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEditorConnectionEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.NativeFieldInfoPtr_m_PlayerEditorConnectionEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x0009305C File Offset: 0x0009125C
		// (set) Token: 0x0600215F RID: 8543 RVA: 0x0000CBFB File Offset: 0x0000ADFB
		public unsafe List<int> m_connectedPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.NativeFieldInfoPtr_m_connectedPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.NativeFieldInfoPtr_m_connectedPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x0009308C File Offset: 0x0009128C
		// (set) Token: 0x06002161 RID: 8545 RVA: 0x0000CC1A File Offset: 0x0000AE1A
		public unsafe bool m_IsInitilized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.NativeFieldInfoPtr_m_IsInitilized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.NativeFieldInfoPtr_m_IsInitilized)) = value;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06002162 RID: 8546 RVA: 0x000930B4 File Offset: 0x000912B4
		// (set) Token: 0x06002163 RID: 8547 RVA: 0x0000CC35 File Offset: 0x0000AE35
		public unsafe static PlayerConnection s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerConnection.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerConnection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerConnection.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C5B RID: 7259
		private static readonly IntPtr NativeFieldInfoPtr_connectionNative;

		// Token: 0x04001C5C RID: 7260
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayerEditorConnectionEvents;

		// Token: 0x04001C5D RID: 7261
		private static readonly IntPtr NativeFieldInfoPtr_m_connectedPlayers;

		// Token: 0x04001C5E RID: 7262
		private static readonly IntPtr NativeFieldInfoPtr_m_IsInitilized;

		// Token: 0x04001C5F RID: 7263
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04001C60 RID: 7264
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_PlayerConnection_0;

		// Token: 0x04001C61 RID: 7265
		private static readonly IntPtr NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0;

		// Token: 0x04001C62 RID: 7266
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Private_Static_PlayerConnection_0;

		// Token: 0x04001C63 RID: 7267
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04001C64 RID: 7268
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionNativeApi_Private_IPlayerEditorConnectionNative_0;

		// Token: 0x04001C65 RID: 7269
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0;

		// Token: 0x04001C66 RID: 7270
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0;

		// Token: 0x04001C67 RID: 7271
		private static readonly IntPtr NativeMethodInfoPtr_RegisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0;

		// Token: 0x04001C68 RID: 7272
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0;

		// Token: 0x04001C69 RID: 7273
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0;

		// Token: 0x04001C6A RID: 7274
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0;

		// Token: 0x04001C6B RID: 7275
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001C6C RID: 7276
		private static readonly IntPtr NativeMethodInfoPtr_TrySend_Public_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001C6D RID: 7277
		private static readonly IntPtr NativeMethodInfoPtr_BlockUntilRecvMsg_Public_Boolean_Guid_Int32_0;

		// Token: 0x04001C6E RID: 7278
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectAll_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001C6F RID: 7279
		private static readonly IntPtr NativeMethodInfoPtr_MessageCallbackInternal_Private_Static_Void_IntPtr_UInt64_UInt64_String_0;

		// Token: 0x04001C70 RID: 7280
		private static readonly IntPtr NativeMethodInfoPtr_ConnectedCallbackInternal_Private_Static_Void_Int32_0;

		// Token: 0x04001C71 RID: 7281
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectedCallback_Private_Static_Void_Int32_0;

		// Token: 0x04001C72 RID: 7282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200091B RID: 2331
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerConnection+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x06003B3C RID: 15164 RVA: 0x000BE120 File Offset: 0x000BC320
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr);
				PlayerConnection.__c__DisplayClass12_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr, "messageId");
				PlayerConnection.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr, 100667795);
				PlayerConnection.__c__DisplayClass12_0.NativeMethodInfoPtr__Register_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr, 100667796);
			}

			// Token: 0x06003B3D RID: 15165 RVA: 0x000BE188 File Offset: 0x000BC388
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B3E RID: 15166 RVA: 0x000BE1C4 File Offset: 0x000BC3C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680932, XrefRangeEnd = 680934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Register_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.__c__DisplayClass12_0.NativeMethodInfoPtr__Register_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003B3F RID: 15167 RVA: 0x0001631C File Offset: 0x0001451C
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A32 RID: 2610
			// (get) Token: 0x06003B40 RID: 15168 RVA: 0x000BE214 File Offset: 0x000BC414
			// (set) Token: 0x06003B41 RID: 15169 RVA: 0x00016325 File Offset: 0x00014525
			public unsafe Guid messageId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.__c__DisplayClass12_0.NativeFieldInfoPtr_messageId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.__c__DisplayClass12_0.NativeFieldInfoPtr_messageId)) = value;
				}
			}

			// Token: 0x04002D02 RID: 11522
			private static readonly IntPtr NativeFieldInfoPtr_messageId;

			// Token: 0x04002D03 RID: 11523
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D04 RID: 11524
			private static readonly IntPtr NativeMethodInfoPtr__Register_b__0_Internal_Boolean_MessageTypeSubscribers_0;
		}

		// Token: 0x0200091C RID: 2332
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerConnection+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x06003B42 RID: 15170 RVA: 0x000BE23C File Offset: 0x000BC43C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr);
				PlayerConnection.__c__DisplayClass13_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr, "messageId");
				PlayerConnection.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr, 100667797);
				PlayerConnection.__c__DisplayClass13_0.NativeMethodInfoPtr__Unregister_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr, 100667798);
			}

			// Token: 0x06003B43 RID: 15171 RVA: 0x000BE2A4 File Offset: 0x000BC4A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B44 RID: 15172 RVA: 0x000BE2E0 File Offset: 0x000BC4E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Unregister_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.__c__DisplayClass13_0.NativeMethodInfoPtr__Unregister_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003B45 RID: 15173 RVA: 0x00016340 File Offset: 0x00014540
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A33 RID: 2611
			// (get) Token: 0x06003B46 RID: 15174 RVA: 0x000BE330 File Offset: 0x000BC530
			// (set) Token: 0x06003B47 RID: 15175 RVA: 0x00016349 File Offset: 0x00014549
			public unsafe Guid messageId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.__c__DisplayClass13_0.NativeFieldInfoPtr_messageId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.__c__DisplayClass13_0.NativeFieldInfoPtr_messageId)) = value;
				}
			}

			// Token: 0x04002D05 RID: 11525
			private static readonly IntPtr NativeFieldInfoPtr_messageId;

			// Token: 0x04002D06 RID: 11526
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D07 RID: 11527
			private static readonly IntPtr NativeMethodInfoPtr__Unregister_b__0_Internal_Boolean_MessageTypeSubscribers_0;
		}

		// Token: 0x0200091D RID: 2333
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerConnection+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Object
		{
			// Token: 0x06003B48 RID: 15176 RVA: 0x000BE358 File Offset: 0x000BC558
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr);
				PlayerConnection.__c__DisplayClass20_0.NativeFieldInfoPtr_msgReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr, "msgReceived");
				PlayerConnection.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr, 100667799);
				PlayerConnection.__c__DisplayClass20_0.NativeMethodInfoPtr__BlockUntilRecvMsg_b__0_Internal_Void_MessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr, 100667800);
			}

			// Token: 0x06003B49 RID: 15177 RVA: 0x000BE3C0 File Offset: 0x000BC5C0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B4A RID: 15178 RVA: 0x000BE3FC File Offset: 0x000BC5FC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 478427, RefRangeEnd = 478428, XrefRangeStart = 478427, XrefRangeEnd = 478428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BlockUntilRecvMsg_b__0(MessageEventArgs args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.__c__DisplayClass20_0.NativeMethodInfoPtr__BlockUntilRecvMsg_b__0_Internal_Void_MessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003B4B RID: 15179 RVA: 0x00016364 File Offset: 0x00014564
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A34 RID: 2612
			// (get) Token: 0x06003B4C RID: 15180 RVA: 0x000BE440 File Offset: 0x000BC640
			// (set) Token: 0x06003B4D RID: 15181 RVA: 0x0001636D File Offset: 0x0001456D
			public unsafe bool msgReceived
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.__c__DisplayClass20_0.NativeFieldInfoPtr_msgReceived);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.__c__DisplayClass20_0.NativeFieldInfoPtr_msgReceived)) = value;
				}
			}

			// Token: 0x04002D08 RID: 11528
			private static readonly IntPtr NativeFieldInfoPtr_msgReceived;

			// Token: 0x04002D09 RID: 11529
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D0A RID: 11530
			private static readonly IntPtr NativeMethodInfoPtr__BlockUntilRecvMsg_b__0_Internal_Void_MessageEventArgs_0;
		}

		// Token: 0x0200091E RID: 2334
		public sealed class <>c__DisplayClass12_0
		{
		}

		// Token: 0x0200091F RID: 2335
		public sealed class <>c__DisplayClass13_0
		{
		}

		// Token: 0x02000920 RID: 2336
		public sealed class <>c__DisplayClass20_0
		{
		}
	}
}
