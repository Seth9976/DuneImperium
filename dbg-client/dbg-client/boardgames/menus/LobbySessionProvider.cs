using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace boardgames.menus
{
	// Token: 0x020001A5 RID: 421
	public class LobbySessionProvider : OnlinePlaySessionProvider
	{
		// Token: 0x060012C9 RID: 4809 RVA: 0x0005A1E4 File Offset: 0x000583E4
		// Note: this type is marked as 'beforefieldinit'.
		static LobbySessionProvider()
		{
			Il2CppClassPointerStore<LobbySessionProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus", "LobbySessionProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbySessionProvider>.NativeClassPtr);
			LobbySessionProvider.NativeMethodInfoPtr_RegisterUser_Protected_Virtual_NetworkMessageEvent_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySessionProvider>.NativeClassPtr, 100666052);
			LobbySessionProvider.NativeMethodInfoPtr_handleOpen_Protected_Virtual_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySessionProvider>.NativeClassPtr, 100666053);
			LobbySessionProvider.NativeMethodInfoPtr_disposeSocket_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySessionProvider>.NativeClassPtr, 100666054);
			LobbySessionProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySessionProvider>.NativeClassPtr, 100666055);
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x0005A264 File Offset: 0x00058464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518259, XrefRangeEnd = 518281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NetworkMessageEvent RegisterUser(Dictionary<string, string> metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbySessionProvider.NativeMethodInfoPtr_RegisterUser_Protected_Virtual_NetworkMessageEvent_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr3) : null;
			}
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0005A2C0 File Offset: 0x000584C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518281, XrefRangeEnd = 518304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbySessionProvider.NativeMethodInfoPtr_handleOpen_Protected_Virtual_Void_Object_EventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0005A320 File Offset: 0x00058520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518304, XrefRangeEnd = 518329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void disposeSocket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbySessionProvider.NativeMethodInfoPtr_disposeSocket_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x0005A35C File Offset: 0x0005855C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbySessionProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbySessionProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySessionProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x0000ADC8 File Offset: 0x00008FC8
		public LobbySessionProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr_RegisterUser_Protected_Virtual_NetworkMessageEvent_Dictionary_2_String_String_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr_handleOpen_Protected_Virtual_Void_Object_EventArgs_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_disposeSocket_Protected_Virtual_Void_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
