using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000023 RID: 35
	public class ISteamNetworkingMessages : SteamInterface
	{
		// Token: 0x060004C0 RID: 1216 RVA: 0x0002B914 File Offset: 0x00029B14
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamNetworkingMessages()
		{
			Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamNetworkingMessages");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr);
			ISteamNetworkingMessages.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr, 100664445);
			ISteamNetworkingMessages.NativeMethodInfoPtr_SteamAPI_SteamNetworkingMessages_SteamAPI_v002_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr, 100664446);
			ISteamNetworkingMessages.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr, 100664447);
			ISteamNetworkingMessages.NativeMethodInfoPtr_SteamAPI_SteamGameServerNetworkingMessages_SteamAPI_v002_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr, 100664448);
			ISteamNetworkingMessages.NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr, 100664449);
			ISteamNetworkingMessages.NativeMethodInfoPtr__SendMessageToUser_Private_Static_Result_IntPtr_byref_NetIdentity_Il2CppStructArray_1_IntPtr_UInt32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr, 100664450);
			ISteamNetworkingMessages.NativeMethodInfoPtr_SendMessageToUser_Internal_Result_byref_NetIdentity_Il2CppStructArray_1_IntPtr_UInt32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr, 100664451);
			ISteamNetworkingMessages.NativeMethodInfoPtr__ReceiveMessagesOnChannel_Private_Static_Int32_IntPtr_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr, 100664452);
			ISteamNetworkingMessages.NativeMethodInfoPtr_ReceiveMessagesOnChannel_Internal_Int32_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr, 100664453);
			ISteamNetworkingMessages.NativeMethodInfoPtr__AcceptSessionWithUser_Private_Static_Boolean_IntPtr_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr, 100664454);
			ISteamNetworkingMessages.NativeMethodInfoPtr_AcceptSessionWithUser_Internal_Boolean_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr, 100664455);
			ISteamNetworkingMessages.NativeMethodInfoPtr__CloseSessionWithUser_Private_Static_Boolean_IntPtr_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr, 100664456);
			ISteamNetworkingMessages.NativeMethodInfoPtr_CloseSessionWithUser_Internal_Boolean_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr, 100664457);
			ISteamNetworkingMessages.NativeMethodInfoPtr__CloseChannelWithUser_Private_Static_Boolean_IntPtr_byref_NetIdentity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr, 100664458);
			ISteamNetworkingMessages.NativeMethodInfoPtr_CloseChannelWithUser_Internal_Boolean_byref_NetIdentity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr, 100664459);
			ISteamNetworkingMessages.NativeMethodInfoPtr__GetSessionConnectionInfo_Private_Static_ConnectionState_IntPtr_byref_NetIdentity_byref_ConnectionInfo_byref_ConnectionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr, 100664460);
			ISteamNetworkingMessages.NativeMethodInfoPtr_GetSessionConnectionInfo_Internal_ConnectionState_byref_NetIdentity_byref_ConnectionInfo_byref_ConnectionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr, 100664461);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0002BA98 File Offset: 0x00029C98
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamNetworkingMessages(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamNetworkingMessages>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingMessages.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0002BAE0 File Offset: 0x00029CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934010, XrefRangeEnd = 934012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamNetworkingMessages_SteamAPI_v002()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingMessages.NativeMethodInfoPtr_SteamAPI_SteamNetworkingMessages_SteamAPI_v002_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0002BB10 File Offset: 0x00029D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamNetworkingMessages.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0002BB58 File Offset: 0x00029D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934012, XrefRangeEnd = 934014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamGameServerNetworkingMessages_SteamAPI_v002()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingMessages.NativeMethodInfoPtr_SteamAPI_SteamGameServerNetworkingMessages_SteamAPI_v002_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0002BB88 File Offset: 0x00029D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetServerInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamNetworkingMessages.NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0002BBD0 File Offset: 0x00029DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934014, XrefRangeEnd = 934016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Result _SendMessageToUser(IntPtr self, ref NetIdentity identityRemote, [In] [Out] Il2CppStructArray<IntPtr> pubData, uint cubData, int nSendFlags, int nRemoteChannel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &identityRemote;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nSendFlags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRemoteChannel;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingMessages.NativeMethodInfoPtr__SendMessageToUser_Private_Static_Result_IntPtr_byref_NetIdentity_Il2CppStructArray_1_IntPtr_UInt32_Int32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pubData = ((intPtr4 == 0) ? null : new Il2CppStructArray<IntPtr>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0002BC68 File Offset: 0x00029E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934016, XrefRangeEnd = 934018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result SendMessageToUser(ref NetIdentity identityRemote, [In] [Out] Il2CppStructArray<IntPtr> pubData, uint cubData, int nSendFlags, int nRemoteChannel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &identityRemote;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nSendFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRemoteChannel;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingMessages.NativeMethodInfoPtr_SendMessageToUser_Internal_Result_byref_NetIdentity_Il2CppStructArray_1_IntPtr_UInt32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pubData = ((intPtr4 == 0) ? null : new Il2CppStructArray<IntPtr>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0002BD00 File Offset: 0x00029F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934018, XrefRangeEnd = 934020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _ReceiveMessagesOnChannel(IntPtr self, int nLocalChannel, IntPtr ppOutMessages, int nMaxMessages)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nLocalChannel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ppOutMessages;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxMessages;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingMessages.NativeMethodInfoPtr__ReceiveMessagesOnChannel_Private_Static_Int32_IntPtr_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0002BD68 File Offset: 0x00029F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934020, XrefRangeEnd = 934022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReceiveMessagesOnChannel(int nLocalChannel, IntPtr ppOutMessages, int nMaxMessages)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nLocalChannel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ppOutMessages;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxMessages;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingMessages.NativeMethodInfoPtr_ReceiveMessagesOnChannel_Internal_Int32_Int32_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0002BDD0 File Offset: 0x00029FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934022, XrefRangeEnd = 934024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _AcceptSessionWithUser(IntPtr self, ref NetIdentity identityRemote)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &identityRemote;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingMessages.NativeMethodInfoPtr__AcceptSessionWithUser_Private_Static_Boolean_IntPtr_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0002BE1C File Offset: 0x0002A01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934024, XrefRangeEnd = 934026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AcceptSessionWithUser(ref NetIdentity identityRemote)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &identityRemote;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingMessages.NativeMethodInfoPtr_AcceptSessionWithUser_Internal_Boolean_byref_NetIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0002BE68 File Offset: 0x0002A068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934026, XrefRangeEnd = 934028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _CloseSessionWithUser(IntPtr self, ref NetIdentity identityRemote)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &identityRemote;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingMessages.NativeMethodInfoPtr__CloseSessionWithUser_Private_Static_Boolean_IntPtr_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0002BEB4 File Offset: 0x0002A0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934028, XrefRangeEnd = 934030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CloseSessionWithUser(ref NetIdentity identityRemote)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &identityRemote;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingMessages.NativeMethodInfoPtr_CloseSessionWithUser_Internal_Boolean_byref_NetIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0002BF00 File Offset: 0x0002A100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934030, XrefRangeEnd = 934032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _CloseChannelWithUser(IntPtr self, ref NetIdentity identityRemote, int nLocalChannel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &identityRemote;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nLocalChannel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingMessages.NativeMethodInfoPtr__CloseChannelWithUser_Private_Static_Boolean_IntPtr_byref_NetIdentity_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0002BF5C File Offset: 0x0002A15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934032, XrefRangeEnd = 934034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CloseChannelWithUser(ref NetIdentity identityRemote, int nLocalChannel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &identityRemote;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nLocalChannel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingMessages.NativeMethodInfoPtr_CloseChannelWithUser_Internal_Boolean_byref_NetIdentity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0002BFB4 File Offset: 0x0002A1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934034, XrefRangeEnd = 934045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConnectionState _GetSessionConnectionInfo(IntPtr self, ref NetIdentity identityRemote, ref ConnectionInfo pConnectionInfo, ref ConnectionStatus pQuickStatus)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &identityRemote;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pConnectionInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pQuickStatus);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingMessages.NativeMethodInfoPtr__GetSessionConnectionInfo_Private_Static_ConnectionState_IntPtr_byref_NetIdentity_byref_ConnectionInfo_byref_ConnectionStatus_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0002C028 File Offset: 0x0002A228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934045, XrefRangeEnd = 934056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConnectionState GetSessionConnectionInfo(ref NetIdentity identityRemote, ref ConnectionInfo pConnectionInfo, ref ConnectionStatus pQuickStatus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &identityRemote;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pConnectionInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pQuickStatus);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingMessages.NativeMethodInfoPtr_GetSessionConnectionInfo_Internal_ConnectionState_byref_NetIdentity_byref_ConnectionInfo_byref_ConnectionStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00002399 File Offset: 0x00000599
		public ISteamNetworkingMessages(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamNetworkingMessages_SteamAPI_v002_Internal_Static_IntPtr_0;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamGameServerNetworkingMessages_SteamAPI_v002_Internal_Static_IntPtr_0;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeMethodInfoPtr__SendMessageToUser_Private_Static_Result_IntPtr_byref_NetIdentity_Il2CppStructArray_1_IntPtr_UInt32_Int32_Int32_0;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeMethodInfoPtr_SendMessageToUser_Internal_Result_byref_NetIdentity_Il2CppStructArray_1_IntPtr_UInt32_Int32_Int32_0;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeMethodInfoPtr__ReceiveMessagesOnChannel_Private_Static_Int32_IntPtr_Int32_IntPtr_Int32_0;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessagesOnChannel_Internal_Int32_Int32_IntPtr_Int32_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr__AcceptSessionWithUser_Private_Static_Boolean_IntPtr_byref_NetIdentity_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_AcceptSessionWithUser_Internal_Boolean_byref_NetIdentity_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr__CloseSessionWithUser_Private_Static_Boolean_IntPtr_byref_NetIdentity_0;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr_CloseSessionWithUser_Internal_Boolean_byref_NetIdentity_0;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr__CloseChannelWithUser_Private_Static_Boolean_IntPtr_byref_NetIdentity_Int32_0;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr_CloseChannelWithUser_Internal_Boolean_byref_NetIdentity_Int32_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr__GetSessionConnectionInfo_Private_Static_ConnectionState_IntPtr_byref_NetIdentity_byref_ConnectionInfo_byref_ConnectionStatus_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionConnectionInfo_Internal_ConnectionState_byref_NetIdentity_byref_ConnectionInfo_byref_ConnectionStatus_0;
	}
}
