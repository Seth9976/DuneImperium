using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.user;

namespace lobbychat.data
{
	// Token: 0x0200000E RID: 14
	public class ChatMessage : Object
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00002C5C File Offset: 0x00000E5C
		// Note: this type is marked as 'beforefieldinit'.
		static ChatMessage()
		{
			Il2CppClassPointerStore<ChatMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("LobbyChat.dll", "lobbychat.data", "ChatMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatMessage>.NativeClassPtr);
			ChatMessage.NativeFieldInfoPtr_Timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessage>.NativeClassPtr, "Timestamp");
			ChatMessage.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessage>.NativeClassPtr, "AccountID");
			ChatMessage.NativeFieldInfoPtr_ScreenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessage>.NativeClassPtr, "ScreenName");
			ChatMessage.NativeFieldInfoPtr_FederatedNameData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessage>.NativeClassPtr, "FederatedNameData");
			ChatMessage.NativeFieldInfoPtr_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessage>.NativeClassPtr, "Metadata");
			ChatMessage.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessage>.NativeClassPtr, "Message");
			ChatMessage.NativeFieldInfoPtr_Game = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessage>.NativeClassPtr, "Game");
			ChatMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessage>.NativeClassPtr, 100663311);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002D2C File Offset: 0x00000F2C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChatMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000225B File Offset: 0x0000045B
		public ChatMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002D68 File Offset: 0x00000F68
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002264 File Offset: 0x00000464
		public unsafe long Timestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessage.NativeFieldInfoPtr_Timestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessage.NativeFieldInfoPtr_Timestamp)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002D90 File Offset: 0x00000F90
		// (set) Token: 0x0600003D RID: 61 RVA: 0x0000227F File Offset: 0x0000047F
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessage.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessage.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002DC0 File Offset: 0x00000FC0
		// (set) Token: 0x0600003F RID: 63 RVA: 0x0000229E File Offset: 0x0000049E
		public unsafe string ScreenName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessage.NativeFieldInfoPtr_ScreenName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessage.NativeFieldInfoPtr_ScreenName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002DE8 File Offset: 0x00000FE8
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000022BD File Offset: 0x000004BD
		public unsafe FederatedNameData FederatedNameData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessage.NativeFieldInfoPtr_FederatedNameData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FederatedNameData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessage.NativeFieldInfoPtr_FederatedNameData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002E18 File Offset: 0x00001018
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000022DC File Offset: 0x000004DC
		public unsafe Dictionary<string, string> Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessage.NativeFieldInfoPtr_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessage.NativeFieldInfoPtr_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002E48 File Offset: 0x00001048
		// (set) Token: 0x06000045 RID: 69 RVA: 0x000022FB File Offset: 0x000004FB
		public unsafe string Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessage.NativeFieldInfoPtr_Message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessage.NativeFieldInfoPtr_Message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002E70 File Offset: 0x00001070
		// (set) Token: 0x06000047 RID: 71 RVA: 0x0000231A File Offset: 0x0000051A
		public unsafe string Game
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessage.NativeFieldInfoPtr_Game);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessage.NativeFieldInfoPtr_Game), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_Timestamp;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_ScreenName;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_FederatedNameData;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_Metadata;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_Game;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
