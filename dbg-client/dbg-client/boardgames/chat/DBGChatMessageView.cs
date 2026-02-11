using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.chat
{
	// Token: 0x02000242 RID: 578
	public class DBGChatMessageView : ChatMessageView
	{
		// Token: 0x06001A15 RID: 6677 RVA: 0x00072550 File Offset: 0x00070750
		// Note: this type is marked as 'beforefieldinit'.
		static DBGChatMessageView()
		{
			Il2CppClassPointerStore<DBGChatMessageView>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.chat", "DBGChatMessageView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGChatMessageView>.NativeClassPtr);
			DBGChatMessageView.NativeFieldInfoPtr_nameField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGChatMessageView>.NativeClassPtr, "nameField");
			DBGChatMessageView.NativeFieldInfoPtr_timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGChatMessageView>.NativeClassPtr, "timestamp");
			DBGChatMessageView.NativeFieldInfoPtr_playerChatSocialButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGChatMessageView>.NativeClassPtr, "playerChatSocialButton");
			DBGChatMessageView.NativeFieldInfoPtr_disableChatSocialButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGChatMessageView>.NativeClassPtr, "disableChatSocialButton");
			DBGChatMessageView.NativeFieldInfoPtr_useChatSocialButtonGameObjectActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGChatMessageView>.NativeClassPtr, "useChatSocialButtonGameObjectActive");
			DBGChatMessageView.NativeFieldInfoPtr_currentMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGChatMessageView>.NativeClassPtr, "currentMessage");
			DBGChatMessageView.NativeMethodInfoPtr_ConstructMessage_Public_Virtual_Void_ClientChatMessage_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGChatMessageView>.NativeClassPtr, 100667451);
			DBGChatMessageView.NativeMethodInfoPtr_Event_ShowChatSocialPrompt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGChatMessageView>.NativeClassPtr, 100667452);
			DBGChatMessageView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGChatMessageView>.NativeClassPtr, 100667453);
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00072634 File Offset: 0x00070834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531238, XrefRangeEnd = 531316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConstructMessage(ClientChatMessage message, Color messageColor, Color userColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGChatMessageView.NativeMethodInfoPtr_ConstructMessage_Public_Virtual_Void_ClientChatMessage_Color_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x000726A0 File Offset: 0x000708A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531316, XrefRangeEnd = 531349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowChatSocialPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGChatMessageView.NativeMethodInfoPtr_Event_ShowChatSocialPrompt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x000726D4 File Offset: 0x000708D4
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGChatMessageView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGChatMessageView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGChatMessageView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x0000E469 File Offset: 0x0000C669
		public DBGChatMessageView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x00072710 File Offset: 0x00070910
		// (set) Token: 0x06001A1B RID: 6683 RVA: 0x0000E472 File Offset: 0x0000C672
		public unsafe TMP_Text nameField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGChatMessageView.NativeFieldInfoPtr_nameField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGChatMessageView.NativeFieldInfoPtr_nameField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x00072740 File Offset: 0x00070940
		// (set) Token: 0x06001A1D RID: 6685 RVA: 0x0000E491 File Offset: 0x0000C691
		public unsafe TMP_Text timestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGChatMessageView.NativeFieldInfoPtr_timestamp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGChatMessageView.NativeFieldInfoPtr_timestamp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x00072770 File Offset: 0x00070970
		// (set) Token: 0x06001A1F RID: 6687 RVA: 0x0000E4B0 File Offset: 0x0000C6B0
		public unsafe Button playerChatSocialButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGChatMessageView.NativeFieldInfoPtr_playerChatSocialButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGChatMessageView.NativeFieldInfoPtr_playerChatSocialButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x000727A0 File Offset: 0x000709A0
		// (set) Token: 0x06001A21 RID: 6689 RVA: 0x0000E4CF File Offset: 0x0000C6CF
		public unsafe bool disableChatSocialButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGChatMessageView.NativeFieldInfoPtr_disableChatSocialButton);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGChatMessageView.NativeFieldInfoPtr_disableChatSocialButton)) = value;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x000727C8 File Offset: 0x000709C8
		// (set) Token: 0x06001A23 RID: 6691 RVA: 0x0000E4EA File Offset: 0x0000C6EA
		public unsafe bool useChatSocialButtonGameObjectActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGChatMessageView.NativeFieldInfoPtr_useChatSocialButtonGameObjectActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGChatMessageView.NativeFieldInfoPtr_useChatSocialButtonGameObjectActive)) = value;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001A24 RID: 6692 RVA: 0x000727F0 File Offset: 0x000709F0
		// (set) Token: 0x06001A25 RID: 6693 RVA: 0x0000E505 File Offset: 0x0000C705
		public unsafe ClientChatMessage currentMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGChatMessageView.NativeFieldInfoPtr_currentMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientChatMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGChatMessageView.NativeFieldInfoPtr_currentMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeFieldInfoPtr_nameField;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeFieldInfoPtr_timestamp;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeFieldInfoPtr_playerChatSocialButton;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeFieldInfoPtr_disableChatSocialButton;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeFieldInfoPtr_useChatSocialButtonGameObjectActive;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeFieldInfoPtr_currentMessage;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeMethodInfoPtr_ConstructMessage_Public_Virtual_Void_ClientChatMessage_Color_Color_0;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowChatSocialPrompt_Public_Void_0;

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
