using System;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace lotus
{
	// Token: 0x020000B4 RID: 180
	public static class EmoteUtil : Object
	{
		// Token: 0x06000917 RID: 2327 RVA: 0x0002DBDC File Offset: 0x0002BDDC
		// Note: this type is marked as 'beforefieldinit'.
		static EmoteUtil()
		{
			Il2CppClassPointerStore<EmoteUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "EmoteUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmoteUtil>.NativeClassPtr);
			EmoteUtil.NativeMethodInfoPtr_IsEmoteMessage_Public_Static_Boolean_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteUtil>.NativeClassPtr, 100664718);
			EmoteUtil.NativeMethodInfoPtr_CreateEmoteMessage_Public_Static_ClientChatMessage_AccountID_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteUtil>.NativeClassPtr, 100664719);
			EmoteUtil.NativeMethodInfoPtr_CreateEmoteEntityComponent_Public_Static_EntityComponent_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteUtil>.NativeClassPtr, 100664720);
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0002DC48 File Offset: 0x0002BE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992135, XrefRangeEnd = 992141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEmoteMessage(ClientChatMessage chatMessage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chatMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteUtil.NativeMethodInfoPtr_IsEmoteMessage_Public_Static_Boolean_ClientChatMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0002DC8C File Offset: 0x0002BE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992141, XrefRangeEnd = 992172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClientChatMessage CreateEmoteMessage(AccountID sendingAccountID, string emoteType, string emoteMessage = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sendingAccountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(emoteType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(emoteMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteUtil.NativeMethodInfoPtr_CreateEmoteMessage_Public_Static_ClientChatMessage_AccountID_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientChatMessage>(intPtr3) : null;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0002DCF4 File Offset: 0x0002BEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992172, XrefRangeEnd = 992196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EntityComponent CreateEmoteEntityComponent(ClientChatMessage chatMessage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chatMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteUtil.NativeMethodInfoPtr_CreateEmoteEntityComponent_Public_Static_EntityComponent_ClientChatMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00006316 File Offset: 0x00004516
		public EmoteUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_IsEmoteMessage_Public_Static_Boolean_ClientChatMessage_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr_CreateEmoteMessage_Public_Static_ClientChatMessage_AccountID_String_String_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_CreateEmoteEntityComponent_Public_Static_EntityComponent_ClientChatMessage_0;
	}
}
