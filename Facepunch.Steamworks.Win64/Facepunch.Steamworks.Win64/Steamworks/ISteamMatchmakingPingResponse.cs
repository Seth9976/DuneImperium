using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x0200001A RID: 26
	public class ISteamMatchmakingPingResponse : SteamInterface
	{
		// Token: 0x060003F7 RID: 1015 RVA: 0x00027130 File Offset: 0x00025330
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamMatchmakingPingResponse()
		{
			Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamMatchmakingPingResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr);
			ISteamMatchmakingPingResponse.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, 100664262);
			ISteamMatchmakingPingResponse.NativeMethodInfoPtr__ServerResponded_Private_Static_Void_IntPtr_byref_gameserveritem_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, 100664263);
			ISteamMatchmakingPingResponse.NativeMethodInfoPtr_ServerResponded_Internal_Void_byref_gameserveritem_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, 100664264);
			ISteamMatchmakingPingResponse.NativeMethodInfoPtr__ServerFailedToRespond_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, 100664265);
			ISteamMatchmakingPingResponse.NativeMethodInfoPtr_ServerFailedToRespond_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, 100664266);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000271C4 File Offset: 0x000253C4
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamMatchmakingPingResponse(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0002720C File Offset: 0x0002540C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933524, XrefRangeEnd = 933530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ServerResponded(IntPtr self, ref gameserveritem_t server)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(server);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.NativeMethodInfoPtr__ServerResponded_Private_Static_Void_IntPtr_byref_gameserveritem_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00027254 File Offset: 0x00025454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933530, XrefRangeEnd = 933536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ServerResponded(ref gameserveritem_t server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(server);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.NativeMethodInfoPtr_ServerResponded_Internal_Void_byref_gameserveritem_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00027298 File Offset: 0x00025498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933536, XrefRangeEnd = 933538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ServerFailedToRespond(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.NativeMethodInfoPtr__ServerFailedToRespond_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x000272CC File Offset: 0x000254CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933538, XrefRangeEnd = 933540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ServerFailedToRespond()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.NativeMethodInfoPtr_ServerFailedToRespond_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00002348 File Offset: 0x00000548
		public ISteamMatchmakingPingResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr__ServerResponded_Private_Static_Void_IntPtr_byref_gameserveritem_t_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr_ServerResponded_Internal_Void_byref_gameserveritem_t_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr__ServerFailedToRespond_Private_Static_Void_IntPtr_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_ServerFailedToRespond_Internal_Void_0;
	}
}
