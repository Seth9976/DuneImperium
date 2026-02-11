using System;
using boardgames.chat;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001D9 RID: 473
	public class WormChatStinger : MonoBehaviour
	{
		// Token: 0x060014E6 RID: 5350 RVA: 0x00057940 File Offset: 0x00055B40
		// Note: this type is marked as 'beforefieldinit'.
		static WormChatStinger()
		{
			Il2CppClassPointerStore<WormChatStinger>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormChatStinger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChatStinger>.NativeClassPtr);
			WormChatStinger.NativeFieldInfoPtr_messageColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChatStinger>.NativeClassPtr, "messageColor");
			WormChatStinger.NativeFieldInfoPtr_otherUserColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChatStinger>.NativeClassPtr, "otherUserColor");
			WormChatStinger.NativeFieldInfoPtr_messageView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChatStinger>.NativeClassPtr, "messageView");
			WormChatStinger.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChatStinger>.NativeClassPtr, "animator");
			WormChatStinger.NativeFieldInfoPtr_chat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChatStinger>.NativeClassPtr, "chat");
			WormChatStinger.NativeFieldInfoPtr_ChatMessageShowParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChatStinger>.NativeClassPtr, "ChatMessageShowParam");
			WormChatStinger.NativeFieldInfoPtr_ChatMessageHideParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChatStinger>.NativeClassPtr, "ChatMessageHideParam");
			WormChatStinger.NativeMethodInfoPtr_Event_ShowMessage_Public_Void_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChatStinger>.NativeClassPtr, 100666160);
			WormChatStinger.NativeMethodInfoPtr_Event_OnPanelOpened_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChatStinger>.NativeClassPtr, 100666161);
			WormChatStinger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChatStinger>.NativeClassPtr, 100666162);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00057A38 File Offset: 0x00055C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714544, XrefRangeEnd = 714549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowMessage(ClientChatMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChatStinger.NativeMethodInfoPtr_Event_ShowMessage_Public_Void_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00057A7C File Offset: 0x00055C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714549, XrefRangeEnd = 714555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnPanelOpened()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChatStinger.NativeMethodInfoPtr_Event_OnPanelOpened_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00057AB0 File Offset: 0x00055CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714555, XrefRangeEnd = 714556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormChatStinger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChatStinger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChatStinger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x0000CC11 File Offset: 0x0000AE11
		public WormChatStinger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x00057AEC File Offset: 0x00055CEC
		// (set) Token: 0x060014EC RID: 5356 RVA: 0x0000CC1A File Offset: 0x0000AE1A
		public unsafe Color messageColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChatStinger.NativeFieldInfoPtr_messageColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChatStinger.NativeFieldInfoPtr_messageColor)) = value;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x00057B14 File Offset: 0x00055D14
		// (set) Token: 0x060014EE RID: 5358 RVA: 0x0000CC35 File Offset: 0x0000AE35
		public unsafe Color otherUserColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChatStinger.NativeFieldInfoPtr_otherUserColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChatStinger.NativeFieldInfoPtr_otherUserColor)) = value;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x00057B3C File Offset: 0x00055D3C
		// (set) Token: 0x060014F0 RID: 5360 RVA: 0x0000CC50 File Offset: 0x0000AE50
		public unsafe DBGChatMessageView messageView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChatStinger.NativeFieldInfoPtr_messageView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGChatMessageView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChatStinger.NativeFieldInfoPtr_messageView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x00057B6C File Offset: 0x00055D6C
		// (set) Token: 0x060014F2 RID: 5362 RVA: 0x0000CC6F File Offset: 0x0000AE6F
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChatStinger.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChatStinger.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x00057B9C File Offset: 0x00055D9C
		// (set) Token: 0x060014F4 RID: 5364 RVA: 0x0000CC8E File Offset: 0x0000AE8E
		public unsafe WormPlaymatChatView chat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChatStinger.NativeFieldInfoPtr_chat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlaymatChatView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChatStinger.NativeFieldInfoPtr_chat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x00057BCC File Offset: 0x00055DCC
		// (set) Token: 0x060014F6 RID: 5366 RVA: 0x0000CCAD File Offset: 0x0000AEAD
		public unsafe static int ChatMessageShowParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormChatStinger.NativeFieldInfoPtr_ChatMessageShowParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormChatStinger.NativeFieldInfoPtr_ChatMessageShowParam, (void*)(&value));
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x00057BE8 File Offset: 0x00055DE8
		// (set) Token: 0x060014F8 RID: 5368 RVA: 0x0000CCBB File Offset: 0x0000AEBB
		public unsafe static int ChatMessageHideParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormChatStinger.NativeFieldInfoPtr_ChatMessageHideParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormChatStinger.NativeFieldInfoPtr_ChatMessageHideParam, (void*)(&value));
			}
		}

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeFieldInfoPtr_messageColor;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeFieldInfoPtr_otherUserColor;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeFieldInfoPtr_messageView;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeFieldInfoPtr_chat;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeFieldInfoPtr_ChatMessageShowParam;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeFieldInfoPtr_ChatMessageHideParam;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowMessage_Public_Void_ClientChatMessage_0;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnPanelOpened_Public_Void_0;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
