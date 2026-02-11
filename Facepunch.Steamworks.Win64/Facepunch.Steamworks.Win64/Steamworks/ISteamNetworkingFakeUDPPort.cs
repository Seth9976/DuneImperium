using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000022 RID: 34
	public class ISteamNetworkingFakeUDPPort : SteamInterface
	{
		// Token: 0x060004B5 RID: 1205 RVA: 0x0002B560 File Offset: 0x00029760
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamNetworkingFakeUDPPort()
		{
			Il2CppClassPointerStore<ISteamNetworkingFakeUDPPort>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamNetworkingFakeUDPPort");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamNetworkingFakeUDPPort>.NativeClassPtr);
			ISteamNetworkingFakeUDPPort.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingFakeUDPPort>.NativeClassPtr, 100664436);
			ISteamNetworkingFakeUDPPort.NativeMethodInfoPtr__DestroyFakeUDPPort_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingFakeUDPPort>.NativeClassPtr, 100664437);
			ISteamNetworkingFakeUDPPort.NativeMethodInfoPtr_DestroyFakeUDPPort_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingFakeUDPPort>.NativeClassPtr, 100664438);
			ISteamNetworkingFakeUDPPort.NativeMethodInfoPtr__SendMessageToFakeIP_Private_Static_Result_IntPtr_byref_NetAddress_IntPtr_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingFakeUDPPort>.NativeClassPtr, 100664439);
			ISteamNetworkingFakeUDPPort.NativeMethodInfoPtr_SendMessageToFakeIP_Internal_Result_byref_NetAddress_IntPtr_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingFakeUDPPort>.NativeClassPtr, 100664440);
			ISteamNetworkingFakeUDPPort.NativeMethodInfoPtr__ReceiveMessages_Private_Static_Int32_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingFakeUDPPort>.NativeClassPtr, 100664441);
			ISteamNetworkingFakeUDPPort.NativeMethodInfoPtr_ReceiveMessages_Internal_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingFakeUDPPort>.NativeClassPtr, 100664442);
			ISteamNetworkingFakeUDPPort.NativeMethodInfoPtr__ScheduleCleanup_Private_Static_Void_IntPtr_byref_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingFakeUDPPort>.NativeClassPtr, 100664443);
			ISteamNetworkingFakeUDPPort.NativeMethodInfoPtr_ScheduleCleanup_Internal_Void_byref_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingFakeUDPPort>.NativeClassPtr, 100664444);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0002B644 File Offset: 0x00029844
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamNetworkingFakeUDPPort(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamNetworkingFakeUDPPort>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingFakeUDPPort.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0002B68C File Offset: 0x0002988C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933994, XrefRangeEnd = 933996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _DestroyFakeUDPPort(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingFakeUDPPort.NativeMethodInfoPtr__DestroyFakeUDPPort_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0002B6C0 File Offset: 0x000298C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933996, XrefRangeEnd = 933998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyFakeUDPPort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingFakeUDPPort.NativeMethodInfoPtr_DestroyFakeUDPPort_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0002B6F4 File Offset: 0x000298F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933998, XrefRangeEnd = 934000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Result _SendMessageToFakeIP(IntPtr self, ref NetAddress remoteAddress, IntPtr pData, uint cbData, int nSendFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &remoteAddress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbData;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nSendFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingFakeUDPPort.NativeMethodInfoPtr__SendMessageToFakeIP_Private_Static_Result_IntPtr_byref_NetAddress_IntPtr_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0002B76C File Offset: 0x0002996C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934000, XrefRangeEnd = 934002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result SendMessageToFakeIP(ref NetAddress remoteAddress, IntPtr pData, uint cbData, int nSendFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &remoteAddress;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nSendFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingFakeUDPPort.NativeMethodInfoPtr_SendMessageToFakeIP_Internal_Result_byref_NetAddress_IntPtr_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0002B7E0 File Offset: 0x000299E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934002, XrefRangeEnd = 934004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _ReceiveMessages(IntPtr self, IntPtr ppOutMessages, int nMaxMessages)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ppOutMessages;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxMessages;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingFakeUDPPort.NativeMethodInfoPtr__ReceiveMessages_Private_Static_Int32_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0002B83C File Offset: 0x00029A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934004, XrefRangeEnd = 934006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReceiveMessages(IntPtr ppOutMessages, int nMaxMessages)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ppOutMessages;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxMessages;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingFakeUDPPort.NativeMethodInfoPtr_ReceiveMessages_Internal_Int32_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0002B894 File Offset: 0x00029A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934006, XrefRangeEnd = 934008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ScheduleCleanup(IntPtr self, ref NetAddress remoteAddress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &remoteAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingFakeUDPPort.NativeMethodInfoPtr__ScheduleCleanup_Private_Static_Void_IntPtr_byref_NetAddress_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0002B8D4 File Offset: 0x00029AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934008, XrefRangeEnd = 934010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScheduleCleanup(ref NetAddress remoteAddress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &remoteAddress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingFakeUDPPort.NativeMethodInfoPtr_ScheduleCleanup_Internal_Void_byref_NetAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002390 File Offset: 0x00000590
		public ISteamNetworkingFakeUDPPort(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr__DestroyFakeUDPPort_Private_Static_Void_IntPtr_0;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr_DestroyFakeUDPPort_Internal_Void_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr__SendMessageToFakeIP_Private_Static_Result_IntPtr_byref_NetAddress_IntPtr_UInt32_Int32_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_SendMessageToFakeIP_Internal_Result_byref_NetAddress_IntPtr_UInt32_Int32_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr__ReceiveMessages_Private_Static_Int32_IntPtr_IntPtr_Int32_0;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessages_Internal_Int32_IntPtr_Int32_0;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr__ScheduleCleanup_Private_Static_Void_IntPtr_byref_NetAddress_0;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleCleanup_Internal_Void_byref_NetAddress_0;
	}
}
