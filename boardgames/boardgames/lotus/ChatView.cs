using System;
using Canis.utils.ids;
using dwd.core.account;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace lotus
{
	// Token: 0x020000AF RID: 175
	public class ChatView : MonoBehaviour
	{
		// Token: 0x0600087F RID: 2175 RVA: 0x0002BF14 File Offset: 0x0002A114
		// Note: this type is marked as 'beforefieldinit'.
		static ChatView()
		{
			Il2CppClassPointerStore<ChatView>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "ChatView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatView>.NativeClassPtr);
			ChatView.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "<Initialized>k__BackingField");
			ChatView.NativeFieldInfoPtr_SCROLL_END = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "SCROLL_END");
			ChatView.NativeFieldInfoPtr_chatProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "chatProvider");
			ChatView.NativeFieldInfoPtr_cachedProviderVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "cachedProviderVersion");
			ChatView.NativeFieldInfoPtr_accountProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "accountProvider");
			ChatView.NativeFieldInfoPtr_messagePrototype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "messagePrototype");
			ChatView.NativeFieldInfoPtr_chatMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "chatMessages");
			ChatView.NativeFieldInfoPtr_scrollBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "scrollBar");
			ChatView.NativeFieldInfoPtr_messageInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "messageInput");
			ChatView.NativeFieldInfoPtr_sendButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "sendButton");
			ChatView.NativeFieldInfoPtr_notificationPip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "notificationPip");
			ChatView.NativeFieldInfoPtr_panelAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "panelAnimator");
			ChatView.NativeFieldInfoPtr_startMinimized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "startMinimized");
			ChatView.NativeFieldInfoPtr_panelDefaultIsMinimized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "panelDefaultIsMinimized");
			ChatView.NativeFieldInfoPtr_panelRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "panelRoot");
			ChatView.NativeFieldInfoPtr_showChatButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "showChatButton");
			ChatView.NativeFieldInfoPtr_messageColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "messageColor");
			ChatView.NativeFieldInfoPtr_thisUserColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "thisUserColor");
			ChatView.NativeFieldInfoPtr_otherUserColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "otherUserColor");
			ChatView.NativeFieldInfoPtr_observerColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "observerColor");
			ChatView.NativeFieldInfoPtr_collapsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "collapsed");
			ChatView.NativeFieldInfoPtr_showChatToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "showChatToggle");
			ChatView.NativeFieldInfoPtr__LastViewedTimestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "<LastViewedTimestamp>k__BackingField");
			ChatView.NativeFieldInfoPtr_minimizeParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "minimizeParam");
			ChatView.NativeFieldInfoPtr_forceScrollToEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "forceScrollToEnd");
			ChatView.NativeFieldInfoPtr_onChatReceivedExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "onChatReceivedExpanded");
			ChatView.NativeFieldInfoPtr_onChatReceivedCollapsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "onChatReceivedCollapsed");
			ChatView.NativeFieldInfoPtr_onChatPanelOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "onChatPanelOpened");
			ChatView.NativeFieldInfoPtr_onChatPanelClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "onChatPanelClosed");
			ChatView.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664627);
			ChatView.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664628);
			ChatView.NativeMethodInfoPtr_get_MessageColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664629);
			ChatView.NativeMethodInfoPtr_get_OtherUserColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664630);
			ChatView.NativeMethodInfoPtr_get_ThisUserColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664631);
			ChatView.NativeMethodInfoPtr_get_PanelCollapsed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664632);
			ChatView.NativeMethodInfoPtr_set_PanelCollapsed_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664633);
			ChatView.NativeMethodInfoPtr_activate_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664634);
			ChatView.NativeMethodInfoPtr_get_MostRecentTimestamp_Protected_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664635);
			ChatView.NativeMethodInfoPtr_get_LastViewedTimestamp_Protected_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664636);
			ChatView.NativeMethodInfoPtr_set_LastViewedTimestamp_Protected_Virtual_New_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664637);
			ChatView.NativeMethodInfoPtr_get_OnChatPanelOpened_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664638);
			ChatView.NativeMethodInfoPtr_get_OnChatPanelClosed_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664639);
			ChatView.NativeMethodInfoPtr_Start_Protected_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664640);
			ChatView.NativeMethodInfoPtr_Init_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664641);
			ChatView.NativeMethodInfoPtr_ShowChat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664642);
			ChatView.NativeMethodInfoPtr_HideChat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664643);
			ChatView.NativeMethodInfoPtr_FindProvider_Protected_Virtual_New_ChatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664644);
			ChatView.NativeMethodInfoPtr_SetChatProvider_Public_Void_ChatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664645);
			ChatView.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664646);
			ChatView.NativeMethodInfoPtr_updateChat_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664647);
			ChatView.NativeMethodInfoPtr_GetOrderedChatMessages_Protected_Virtual_New_IReadOnlyList_1_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664648);
			ChatView.NativeMethodInfoPtr_canSendMessage_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664649);
			ChatView.NativeMethodInfoPtr_Event_UpdateChat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664650);
			ChatView.NativeMethodInfoPtr_Event_SendChatMessage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664651);
			ChatView.NativeMethodInfoPtr_SendChatMessage_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664652);
			ChatView.NativeMethodInfoPtr_Event_ToggleCollapsed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664653);
			ChatView.NativeMethodInfoPtr_ToggleCollapsed_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664654);
			ChatView.NativeMethodInfoPtr_Event_Expand_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664655);
			ChatView.NativeMethodInfoPtr_Event_Collapse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664656);
			ChatView.NativeMethodInfoPtr_GetColor_Public_Virtual_New_Color_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664657);
			ChatView.NativeMethodInfoPtr_RenderMessages_Protected_IEnumerator_IReadOnlyList_1_ClientChatMessage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664658);
			ChatView.NativeMethodInfoPtr_NotifyAfterUpdate_Protected_Void_IReadOnlyList_1_ClientChatMessage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664659);
			ChatView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView>.NativeClassPtr, 100664660);
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x0002C430 File Offset: 0x0002A630
		// (set) Token: 0x06000881 RID: 2177 RVA: 0x0002C46C File Offset: 0x0002A66C
		public unsafe bool Initialized
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x0002C4AC File Offset: 0x0002A6AC
		public unsafe Color MessageColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_get_MessageColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x0002C4E8 File Offset: 0x0002A6E8
		public unsafe Color OtherUserColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_get_OtherUserColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x0002C524 File Offset: 0x0002A724
		public unsafe Color ThisUserColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_get_ThisUserColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x0002C560 File Offset: 0x0002A760
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x0002C59C File Offset: 0x0002A79C
		public unsafe bool PanelCollapsed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_get_PanelCollapsed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 991705, RefRangeEnd = 991706, XrefRangeStart = 991698, XrefRangeEnd = 991705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_set_PanelCollapsed_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0002C5DC File Offset: 0x0002A7DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 991711, RefRangeEnd = 991713, XrefRangeStart = 991706, XrefRangeEnd = 991711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_activate_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x0002C61C File Offset: 0x0002A81C
		public unsafe virtual long MostRecentTimestamp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatView.NativeMethodInfoPtr_get_MostRecentTimestamp_Protected_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x0002C664 File Offset: 0x0002A864
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x0002C6AC File Offset: 0x0002A8AC
		public unsafe virtual long LastViewedTimestamp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatView.NativeMethodInfoPtr_get_LastViewedTimestamp_Protected_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatView.NativeMethodInfoPtr_set_LastViewedTimestamp_Protected_Virtual_New_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x0002C6F8 File Offset: 0x0002A8F8
		public unsafe UnityEvent OnChatPanelOpened
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_get_OnChatPanelOpened_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x0002C738 File Offset: 0x0002A938
		public unsafe UnityEvent OnChatPanelClosed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_get_OnChatPanelClosed_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0002C778 File Offset: 0x0002A978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991713, XrefRangeEnd = 991718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_Start_Protected_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0002C7B8 File Offset: 0x0002A9B8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatView.NativeMethodInfoPtr_Init_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0002C7F4 File Offset: 0x0002A9F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 991725, RefRangeEnd = 991726, XrefRangeStart = 991718, XrefRangeEnd = 991725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowChat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_ShowChat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0002C828 File Offset: 0x0002AA28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 991734, RefRangeEnd = 991735, XrefRangeStart = 991726, XrefRangeEnd = 991734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideChat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_HideChat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0002C85C File Offset: 0x0002AA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991735, XrefRangeEnd = 991745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ChatProvider FindProvider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatView.NativeMethodInfoPtr_FindProvider_Protected_Virtual_New_ChatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChatProvider>(intPtr3) : null;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0002C8A8 File Offset: 0x0002AAA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 991746, RefRangeEnd = 991747, XrefRangeStart = 991745, XrefRangeEnd = 991746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChatProvider(ChatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_SetChatProvider_Public_Void_ChatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0002C8EC File Offset: 0x0002AAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991747, XrefRangeEnd = 991760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x0002C920 File Offset: 0x0002AB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991760, XrefRangeEnd = 991765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator updateChat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatView.NativeMethodInfoPtr_updateChat_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x0002C96C File Offset: 0x0002AB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991765, XrefRangeEnd = 991808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IReadOnlyList<ClientChatMessage> GetOrderedChatMessages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatView.NativeMethodInfoPtr_GetOrderedChatMessages_Protected_Virtual_New_IReadOnlyList_1_ClientChatMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ClientChatMessage>>(intPtr3) : null;
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x0002C9B8 File Offset: 0x0002ABB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 991812, RefRangeEnd = 991814, XrefRangeStart = 991808, XrefRangeEnd = 991812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool canSendMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_canSendMessage_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0002C9F4 File Offset: 0x0002ABF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991814, XrefRangeEnd = 991815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_UpdateChat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_Event_UpdateChat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0002CA28 File Offset: 0x0002AC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991815, XrefRangeEnd = 991839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SendChatMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_Event_SendChatMessage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0002CA5C File Offset: 0x0002AC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991839, XrefRangeEnd = 991841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendChatMessage(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatView.NativeMethodInfoPtr_SendChatMessage_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0002CAAC File Offset: 0x0002ACAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991841, XrefRangeEnd = 991842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_ToggleCollapsed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatView.NativeMethodInfoPtr_Event_ToggleCollapsed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0002CAE8 File Offset: 0x0002ACE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 991855, RefRangeEnd = 991860, XrefRangeStart = 991842, XrefRangeEnd = 991855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleCollapsed(bool isInitialState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isInitialState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_ToggleCollapsed_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0002CB28 File Offset: 0x0002AD28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 991861, RefRangeEnd = 991863, XrefRangeStart = 991860, XrefRangeEnd = 991861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Expand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_Event_Expand_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0002CB5C File Offset: 0x0002AD5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 991864, RefRangeEnd = 991865, XrefRangeStart = 991863, XrefRangeEnd = 991864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Collapse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_Event_Collapse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0002CB90 File Offset: 0x0002AD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991865, XrefRangeEnd = 991873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Color GetColor(ClientChatMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatView.NativeMethodInfoPtr_GetColor_Public_Virtual_New_Color_ClientChatMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0002CBE8 File Offset: 0x0002ADE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991873, XrefRangeEnd = 991879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RenderMessages(IReadOnlyList<ClientChatMessage> orderedMessages, bool scrolledToEnd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderedMessages);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrolledToEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_RenderMessages_Protected_IEnumerator_IReadOnlyList_1_ClientChatMessage_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0002CC48 File Offset: 0x0002AE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991879, XrefRangeEnd = 991891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyAfterUpdate(IReadOnlyList<ClientChatMessage> orderedMessages, bool chatChanged)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderedMessages);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chatChanged;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr_NotifyAfterUpdate_Protected_Void_IReadOnlyList_1_ClientChatMessage_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0002CC98 File Offset: 0x0002AE98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 991924, RefRangeEnd = 991926, XrefRangeStart = 991891, XrefRangeEnd = 991924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChatView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00005DB4 File Offset: 0x00003FB4
		public ChatView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x0002CCD4 File Offset: 0x0002AED4
		// (set) Token: 0x060008A4 RID: 2212 RVA: 0x00005DBD File Offset: 0x00003FBD
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x0002CCFC File Offset: 0x0002AEFC
		// (set) Token: 0x060008A6 RID: 2214 RVA: 0x00005DD8 File Offset: 0x00003FD8
		public unsafe static float SCROLL_END
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ChatView.NativeFieldInfoPtr_SCROLL_END, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChatView.NativeFieldInfoPtr_SCROLL_END, (void*)(&value));
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x0002CD18 File Offset: 0x0002AF18
		// (set) Token: 0x060008A8 RID: 2216 RVA: 0x00005DE6 File Offset: 0x00003FE6
		public unsafe ChatProvider chatProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_chatProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_chatProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x0002CD48 File Offset: 0x0002AF48
		// (set) Token: 0x060008AA RID: 2218 RVA: 0x00005E05 File Offset: 0x00004005
		public unsafe ulong cachedProviderVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_cachedProviderVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_cachedProviderVersion)) = value;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x0002CD70 File Offset: 0x0002AF70
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x00005E20 File Offset: 0x00004020
		public unsafe AccountProvider accountProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_accountProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_accountProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x0002CDA0 File Offset: 0x0002AFA0
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x00005E3F File Offset: 0x0000403F
		public unsafe ChatMessageView messagePrototype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_messagePrototype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatMessageView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_messagePrototype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x0002CDD0 File Offset: 0x0002AFD0
		// (set) Token: 0x060008B0 RID: 2224 RVA: 0x00005E5E File Offset: 0x0000405E
		public unsafe List<ChatMessageView> chatMessages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_chatMessages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ChatMessageView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_chatMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x0002CE00 File Offset: 0x0002B000
		// (set) Token: 0x060008B2 RID: 2226 RVA: 0x00005E7D File Offset: 0x0000407D
		public unsafe Scrollbar scrollBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_scrollBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_scrollBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x0002CE30 File Offset: 0x0002B030
		// (set) Token: 0x060008B4 RID: 2228 RVA: 0x00005E9C File Offset: 0x0000409C
		public unsafe TMP_InputField messageInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_messageInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_messageInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x0002CE60 File Offset: 0x0002B060
		// (set) Token: 0x060008B6 RID: 2230 RVA: 0x00005EBB File Offset: 0x000040BB
		public unsafe Button sendButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_sendButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_sendButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x0002CE90 File Offset: 0x0002B090
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x00005EDA File Offset: 0x000040DA
		public unsafe GameObject notificationPip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_notificationPip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_notificationPip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x0002CEC0 File Offset: 0x0002B0C0
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x00005EF9 File Offset: 0x000040F9
		public unsafe Animator panelAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_panelAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_panelAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x0002CEF0 File Offset: 0x0002B0F0
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x00005F18 File Offset: 0x00004118
		public unsafe bool startMinimized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_startMinimized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_startMinimized)) = value;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x0002CF18 File Offset: 0x0002B118
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x00005F33 File Offset: 0x00004133
		public unsafe bool panelDefaultIsMinimized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_panelDefaultIsMinimized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_panelDefaultIsMinimized)) = value;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x0002CF40 File Offset: 0x0002B140
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x00005F4E File Offset: 0x0000414E
		public unsafe GameObject panelRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_panelRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_panelRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x0002CF70 File Offset: 0x0002B170
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x00005F6D File Offset: 0x0000416D
		public unsafe GameObject showChatButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_showChatButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_showChatButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x0002CFA0 File Offset: 0x0002B1A0
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x00005F8C File Offset: 0x0000418C
		public unsafe Color messageColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_messageColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_messageColor)) = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x0002CFC8 File Offset: 0x0002B1C8
		// (set) Token: 0x060008C6 RID: 2246 RVA: 0x00005FA7 File Offset: 0x000041A7
		public unsafe Color thisUserColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_thisUserColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_thisUserColor)) = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x0002CFF0 File Offset: 0x0002B1F0
		// (set) Token: 0x060008C8 RID: 2248 RVA: 0x00005FC2 File Offset: 0x000041C2
		public unsafe Color otherUserColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_otherUserColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_otherUserColor)) = value;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x0002D018 File Offset: 0x0002B218
		// (set) Token: 0x060008CA RID: 2250 RVA: 0x00005FDD File Offset: 0x000041DD
		public unsafe Color observerColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_observerColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_observerColor)) = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x0002D040 File Offset: 0x0002B240
		// (set) Token: 0x060008CC RID: 2252 RVA: 0x00005FF8 File Offset: 0x000041F8
		public unsafe bool collapsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_collapsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_collapsed)) = value;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x0002D068 File Offset: 0x0002B268
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x00006013 File Offset: 0x00004213
		public unsafe Toggle showChatToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_showChatToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_showChatToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x0002D098 File Offset: 0x0002B298
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x00006032 File Offset: 0x00004232
		public unsafe long _LastViewedTimestamp_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr__LastViewedTimestamp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr__LastViewedTimestamp_k__BackingField)) = value;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x0002D0C0 File Offset: 0x0002B2C0
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x0000604D File Offset: 0x0000424D
		public unsafe string minimizeParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_minimizeParam);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_minimizeParam), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x0002D0E8 File Offset: 0x0002B2E8
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x0000606C File Offset: 0x0000426C
		public unsafe bool forceScrollToEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_forceScrollToEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_forceScrollToEnd)) = value;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x0002D110 File Offset: 0x0002B310
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x00006087 File Offset: 0x00004287
		public unsafe UnityEvent<ClientChatMessage> onChatReceivedExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_onChatReceivedExpanded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ClientChatMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_onChatReceivedExpanded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x0002D140 File Offset: 0x0002B340
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x000060A6 File Offset: 0x000042A6
		public unsafe UnityEvent<ClientChatMessage> onChatReceivedCollapsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_onChatReceivedCollapsed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ClientChatMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_onChatReceivedCollapsed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x0002D170 File Offset: 0x0002B370
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x000060C5 File Offset: 0x000042C5
		public unsafe UnityEvent onChatPanelOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_onChatPanelOpened);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_onChatPanelOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x0002D1A0 File Offset: 0x0002B3A0
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x000060E4 File Offset: 0x000042E4
		public unsafe UnityEvent onChatPanelClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_onChatPanelClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.NativeFieldInfoPtr_onChatPanelClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeFieldInfoPtr_SCROLL_END;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeFieldInfoPtr_chatProvider;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeFieldInfoPtr_cachedProviderVersion;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeFieldInfoPtr_accountProvider;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeFieldInfoPtr_messagePrototype;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeFieldInfoPtr_chatMessages;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeFieldInfoPtr_scrollBar;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeFieldInfoPtr_messageInput;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeFieldInfoPtr_sendButton;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeFieldInfoPtr_notificationPip;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeFieldInfoPtr_panelAnimator;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeFieldInfoPtr_startMinimized;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeFieldInfoPtr_panelDefaultIsMinimized;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeFieldInfoPtr_panelRoot;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeFieldInfoPtr_showChatButton;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeFieldInfoPtr_messageColor;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeFieldInfoPtr_thisUserColor;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeFieldInfoPtr_otherUserColor;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeFieldInfoPtr_observerColor;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeFieldInfoPtr_collapsed;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeFieldInfoPtr_showChatToggle;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeFieldInfoPtr__LastViewedTimestamp_k__BackingField;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeFieldInfoPtr_minimizeParam;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeFieldInfoPtr_forceScrollToEnd;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeFieldInfoPtr_onChatReceivedExpanded;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeFieldInfoPtr_onChatReceivedCollapsed;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeFieldInfoPtr_onChatPanelOpened;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeFieldInfoPtr_onChatPanelClosed;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr_get_MessageColor_Public_get_Color_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_get_OtherUserColor_Public_get_Color_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_get_ThisUserColor_Public_get_Color_0;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_get_PanelCollapsed_Public_get_Boolean_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr_set_PanelCollapsed_Protected_set_Void_Boolean_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr_activate_Private_IEnumerator_0;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeMethodInfoPtr_get_MostRecentTimestamp_Protected_Virtual_New_get_Int64_0;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr_get_LastViewedTimestamp_Protected_Virtual_New_get_Int64_0;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeMethodInfoPtr_set_LastViewedTimestamp_Protected_Virtual_New_set_Void_Int64_0;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeMethodInfoPtr_get_OnChatPanelOpened_Public_get_UnityEvent_0;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr_get_OnChatPanelClosed_Public_get_UnityEvent_0;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_IEnumerator_0;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_New_Void_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr_ShowChat_Public_Void_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_HideChat_Public_Void_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_FindProvider_Protected_Virtual_New_ChatProvider_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_SetChatProvider_Public_Void_ChatProvider_0;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr_updateChat_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderedChatMessages_Protected_Virtual_New_IReadOnlyList_1_ClientChatMessage_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_canSendMessage_Protected_Boolean_0;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr_Event_UpdateChat_Public_Void_0;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_Event_SendChatMessage_Public_Void_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_SendChatMessage_Protected_Virtual_New_Void_String_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleCollapsed_Public_Virtual_New_Void_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_ToggleCollapsed_Private_Void_Boolean_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_Event_Expand_Public_Void_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_Event_Collapse_Public_Void_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Virtual_New_Color_ClientChatMessage_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_RenderMessages_Protected_IEnumerator_IReadOnlyList_1_ClientChatMessage_Boolean_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_NotifyAfterUpdate_Protected_Void_IReadOnlyList_1_ClientChatMessage_Boolean_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200021A RID: 538
		[ObfuscatedName("lotus.ChatView+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060018AD RID: 6317 RVA: 0x0005D91C File Offset: 0x0005BB1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ChatView.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatView.__c>.NativeClassPtr);
				ChatView.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView.__c>.NativeClassPtr, "<>9");
				ChatView.__c.NativeFieldInfoPtr___9__59_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView.__c>.NativeClassPtr, "<>9__59_1");
				ChatView.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView.__c>.NativeClassPtr, 100664662);
				ChatView.__c.NativeMethodInfoPtr__GetOrderedChatMessages_b__59_1_Internal_Int64_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView.__c>.NativeClassPtr, 100664663);
			}

			// Token: 0x060018AE RID: 6318 RVA: 0x0005D998 File Offset: 0x0005BB98
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatView.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018AF RID: 6319 RVA: 0x0005D9D4 File Offset: 0x0005BBD4
			[CallerCount(0)]
			public unsafe long _GetOrderedChatMessages_b__59_1(ClientChatMessage x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.__c.NativeMethodInfoPtr__GetOrderedChatMessages_b__59_1_Internal_Int64_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018B0 RID: 6320 RVA: 0x0000D7D9 File Offset: 0x0000B9D9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700071E RID: 1822
			// (get) Token: 0x060018B1 RID: 6321 RVA: 0x0005DA24 File Offset: 0x0005BC24
			// (set) Token: 0x060018B2 RID: 6322 RVA: 0x0000D7E2 File Offset: 0x0000B9E2
			public unsafe static ChatView.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ChatView.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatView.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChatView.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071F RID: 1823
			// (get) Token: 0x060018B3 RID: 6323 RVA: 0x0005DA4C File Offset: 0x0005BC4C
			// (set) Token: 0x060018B4 RID: 6324 RVA: 0x0000D7F4 File Offset: 0x0000B9F4
			public unsafe static Func<ClientChatMessage, long> __9__59_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ChatView.__c.NativeFieldInfoPtr___9__59_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ClientChatMessage, long>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChatView.__c.NativeFieldInfoPtr___9__59_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000EF2 RID: 3826
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000EF3 RID: 3827
			private static readonly IntPtr NativeFieldInfoPtr___9__59_1;

			// Token: 0x04000EF4 RID: 3828
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000EF5 RID: 3829
			private static readonly IntPtr NativeMethodInfoPtr__GetOrderedChatMessages_b__59_1_Internal_Int64_ClientChatMessage_0;
		}

		// Token: 0x0200021B RID: 539
		[ObfuscatedName("lotus.ChatView+<>c__DisplayClass59_0")]
		public sealed class __c__DisplayClass59_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060018B5 RID: 6325 RVA: 0x0005DA74 File Offset: 0x0005BC74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass59_0()
			{
				Il2CppClassPointerStore<ChatView.__c__DisplayClass59_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "<>c__DisplayClass59_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatView.__c__DisplayClass59_0>.NativeClassPtr);
				ChatView.__c__DisplayClass59_0.NativeFieldInfoPtr_blockedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView.__c__DisplayClass59_0>.NativeClassPtr, "blockedPlayers");
				ChatView.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView.__c__DisplayClass59_0>.NativeClassPtr, 100664664);
				ChatView.__c__DisplayClass59_0.NativeMethodInfoPtr__GetOrderedChatMessages_b__0_Internal_Boolean_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView.__c__DisplayClass59_0>.NativeClassPtr, 100664665);
			}

			// Token: 0x060018B6 RID: 6326 RVA: 0x0005DADC File Offset: 0x0005BCDC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass59_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatView.__c__DisplayClass59_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018B7 RID: 6327 RVA: 0x0005DB18 File Offset: 0x0005BD18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991622, XrefRangeEnd = 991625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetOrderedChatMessages_b__0(ClientChatMessage x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView.__c__DisplayClass59_0.NativeMethodInfoPtr__GetOrderedChatMessages_b__0_Internal_Boolean_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018B8 RID: 6328 RVA: 0x0000D806 File Offset: 0x0000BA06
			public __c__DisplayClass59_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000720 RID: 1824
			// (get) Token: 0x060018B9 RID: 6329 RVA: 0x0005DB68 File Offset: 0x0005BD68
			// (set) Token: 0x060018BA RID: 6330 RVA: 0x0000D80F File Offset: 0x0000BA0F
			public unsafe List<AccountID> blockedPlayers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.__c__DisplayClass59_0.NativeFieldInfoPtr_blockedPlayers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AccountID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView.__c__DisplayClass59_0.NativeFieldInfoPtr_blockedPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000EF6 RID: 3830
			private static readonly IntPtr NativeFieldInfoPtr_blockedPlayers;

			// Token: 0x04000EF7 RID: 3831
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000EF8 RID: 3832
			private static readonly IntPtr NativeMethodInfoPtr__GetOrderedChatMessages_b__0_Internal_Boolean_ClientChatMessage_0;
		}

		// Token: 0x0200021C RID: 540
		[ObfuscatedName("lotus.ChatView+<RenderMessages>d__69")]
		public sealed class _RenderMessages_d__69 : global::Il2CppSystem.Object
		{
			// Token: 0x060018BB RID: 6331 RVA: 0x0005DB98 File Offset: 0x0005BD98
			// Note: this type is marked as 'beforefieldinit'.
			static _RenderMessages_d__69()
			{
				Il2CppClassPointerStore<ChatView._RenderMessages_d__69>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "<RenderMessages>d__69");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatView._RenderMessages_d__69>.NativeClassPtr);
				ChatView._RenderMessages_d__69.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView._RenderMessages_d__69>.NativeClassPtr, "<>1__state");
				ChatView._RenderMessages_d__69.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView._RenderMessages_d__69>.NativeClassPtr, "<>2__current");
				ChatView._RenderMessages_d__69.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView._RenderMessages_d__69>.NativeClassPtr, "<>4__this");
				ChatView._RenderMessages_d__69.NativeFieldInfoPtr_orderedMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView._RenderMessages_d__69>.NativeClassPtr, "orderedMessages");
				ChatView._RenderMessages_d__69.NativeFieldInfoPtr_scrolledToEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView._RenderMessages_d__69>.NativeClassPtr, "scrolledToEnd");
				ChatView._RenderMessages_d__69.NativeFieldInfoPtr__zeroed_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView._RenderMessages_d__69>.NativeClassPtr, "<zeroed>5__2");
				ChatView._RenderMessages_d__69.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._RenderMessages_d__69>.NativeClassPtr, 100664666);
				ChatView._RenderMessages_d__69.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._RenderMessages_d__69>.NativeClassPtr, 100664667);
				ChatView._RenderMessages_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._RenderMessages_d__69>.NativeClassPtr, 100664668);
				ChatView._RenderMessages_d__69.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._RenderMessages_d__69>.NativeClassPtr, 100664669);
				ChatView._RenderMessages_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._RenderMessages_d__69>.NativeClassPtr, 100664670);
				ChatView._RenderMessages_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._RenderMessages_d__69>.NativeClassPtr, 100664671);
			}

			// Token: 0x060018BC RID: 6332 RVA: 0x0005DCB4 File Offset: 0x0005BEB4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RenderMessages_d__69(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatView._RenderMessages_d__69>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._RenderMessages_d__69.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018BD RID: 6333 RVA: 0x0005DCFC File Offset: 0x0005BEFC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._RenderMessages_d__69.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018BE RID: 6334 RVA: 0x0005DD30 File Offset: 0x0005BF30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991625, XrefRangeEnd = 991640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._RenderMessages_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000727 RID: 1831
			// (get) Token: 0x060018BF RID: 6335 RVA: 0x0005DD6C File Offset: 0x0005BF6C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._RenderMessages_d__69.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060018C0 RID: 6336 RVA: 0x0005DDAC File Offset: 0x0005BFAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991640, XrefRangeEnd = 991645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._RenderMessages_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000728 RID: 1832
			// (get) Token: 0x060018C1 RID: 6337 RVA: 0x0005DDE0 File Offset: 0x0005BFE0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._RenderMessages_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060018C2 RID: 6338 RVA: 0x0000D82E File Offset: 0x0000BA2E
			public _RenderMessages_d__69(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000721 RID: 1825
			// (get) Token: 0x060018C3 RID: 6339 RVA: 0x0005DE20 File Offset: 0x0005C020
			// (set) Token: 0x060018C4 RID: 6340 RVA: 0x0000D837 File Offset: 0x0000BA37
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._RenderMessages_d__69.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._RenderMessages_d__69.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000722 RID: 1826
			// (get) Token: 0x060018C5 RID: 6341 RVA: 0x0005DE48 File Offset: 0x0005C048
			// (set) Token: 0x060018C6 RID: 6342 RVA: 0x0000D852 File Offset: 0x0000BA52
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._RenderMessages_d__69.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._RenderMessages_d__69.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000723 RID: 1827
			// (get) Token: 0x060018C7 RID: 6343 RVA: 0x0005DE78 File Offset: 0x0005C078
			// (set) Token: 0x060018C8 RID: 6344 RVA: 0x0000D871 File Offset: 0x0000BA71
			public unsafe ChatView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._RenderMessages_d__69.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._RenderMessages_d__69.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000724 RID: 1828
			// (get) Token: 0x060018C9 RID: 6345 RVA: 0x0005DEA8 File Offset: 0x0005C0A8
			// (set) Token: 0x060018CA RID: 6346 RVA: 0x0000D890 File Offset: 0x0000BA90
			public unsafe IReadOnlyList<ClientChatMessage> orderedMessages
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._RenderMessages_d__69.NativeFieldInfoPtr_orderedMessages);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ClientChatMessage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._RenderMessages_d__69.NativeFieldInfoPtr_orderedMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000725 RID: 1829
			// (get) Token: 0x060018CB RID: 6347 RVA: 0x0005DED8 File Offset: 0x0005C0D8
			// (set) Token: 0x060018CC RID: 6348 RVA: 0x0000D8AF File Offset: 0x0000BAAF
			public unsafe bool scrolledToEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._RenderMessages_d__69.NativeFieldInfoPtr_scrolledToEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._RenderMessages_d__69.NativeFieldInfoPtr_scrolledToEnd)) = value;
				}
			}

			// Token: 0x17000726 RID: 1830
			// (get) Token: 0x060018CD RID: 6349 RVA: 0x0005DF00 File Offset: 0x0005C100
			// (set) Token: 0x060018CE RID: 6350 RVA: 0x0000D8CA File Offset: 0x0000BACA
			public unsafe bool _zeroed_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._RenderMessages_d__69.NativeFieldInfoPtr__zeroed_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._RenderMessages_d__69.NativeFieldInfoPtr__zeroed_5__2)) = value;
				}
			}

			// Token: 0x04000EF9 RID: 3833
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000EFA RID: 3834
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000EFB RID: 3835
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000EFC RID: 3836
			private static readonly IntPtr NativeFieldInfoPtr_orderedMessages;

			// Token: 0x04000EFD RID: 3837
			private static readonly IntPtr NativeFieldInfoPtr_scrolledToEnd;

			// Token: 0x04000EFE RID: 3838
			private static readonly IntPtr NativeFieldInfoPtr__zeroed_5__2;

			// Token: 0x04000EFF RID: 3839
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F00 RID: 3840
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F01 RID: 3841
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F02 RID: 3842
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F03 RID: 3843
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F04 RID: 3844
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200021D RID: 541
		[ObfuscatedName("lotus.ChatView+<Start>d__51")]
		public sealed class _Start_d__51 : global::Il2CppSystem.Object
		{
			// Token: 0x060018CF RID: 6351 RVA: 0x0005DF28 File Offset: 0x0005C128
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__51()
			{
				Il2CppClassPointerStore<ChatView._Start_d__51>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "<Start>d__51");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatView._Start_d__51>.NativeClassPtr);
				ChatView._Start_d__51.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView._Start_d__51>.NativeClassPtr, "<>1__state");
				ChatView._Start_d__51.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView._Start_d__51>.NativeClassPtr, "<>2__current");
				ChatView._Start_d__51.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView._Start_d__51>.NativeClassPtr, "<>4__this");
				ChatView._Start_d__51.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._Start_d__51>.NativeClassPtr, 100664672);
				ChatView._Start_d__51.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._Start_d__51>.NativeClassPtr, 100664673);
				ChatView._Start_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._Start_d__51>.NativeClassPtr, 100664674);
				ChatView._Start_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._Start_d__51>.NativeClassPtr, 100664675);
				ChatView._Start_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._Start_d__51>.NativeClassPtr, 100664676);
				ChatView._Start_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._Start_d__51>.NativeClassPtr, 100664677);
			}

			// Token: 0x060018D0 RID: 6352 RVA: 0x0005E008 File Offset: 0x0005C208
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__51(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatView._Start_d__51>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._Start_d__51.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018D1 RID: 6353 RVA: 0x0005E050 File Offset: 0x0005C250
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._Start_d__51.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018D2 RID: 6354 RVA: 0x0005E084 File Offset: 0x0005C284
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991645, XrefRangeEnd = 991658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._Start_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700072C RID: 1836
			// (get) Token: 0x060018D3 RID: 6355 RVA: 0x0005E0C0 File Offset: 0x0005C2C0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._Start_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060018D4 RID: 6356 RVA: 0x0005E100 File Offset: 0x0005C300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991658, XrefRangeEnd = 991663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._Start_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700072D RID: 1837
			// (get) Token: 0x060018D5 RID: 6357 RVA: 0x0005E134 File Offset: 0x0005C334
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._Start_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060018D6 RID: 6358 RVA: 0x0000D8E5 File Offset: 0x0000BAE5
			public _Start_d__51(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000729 RID: 1833
			// (get) Token: 0x060018D7 RID: 6359 RVA: 0x0005E174 File Offset: 0x0005C374
			// (set) Token: 0x060018D8 RID: 6360 RVA: 0x0000D8EE File Offset: 0x0000BAEE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._Start_d__51.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._Start_d__51.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700072A RID: 1834
			// (get) Token: 0x060018D9 RID: 6361 RVA: 0x0005E19C File Offset: 0x0005C39C
			// (set) Token: 0x060018DA RID: 6362 RVA: 0x0000D909 File Offset: 0x0000BB09
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._Start_d__51.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._Start_d__51.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700072B RID: 1835
			// (get) Token: 0x060018DB RID: 6363 RVA: 0x0005E1CC File Offset: 0x0005C3CC
			// (set) Token: 0x060018DC RID: 6364 RVA: 0x0000D928 File Offset: 0x0000BB28
			public unsafe ChatView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._Start_d__51.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._Start_d__51.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F05 RID: 3845
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F06 RID: 3846
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F07 RID: 3847
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000F08 RID: 3848
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F09 RID: 3849
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F0A RID: 3850
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F0B RID: 3851
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F0C RID: 3852
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F0D RID: 3853
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200021E RID: 542
		[ObfuscatedName("lotus.ChatView+<activate>d__34")]
		public sealed class _activate_d__34 : global::Il2CppSystem.Object
		{
			// Token: 0x060018DD RID: 6365 RVA: 0x0005E1FC File Offset: 0x0005C3FC
			// Note: this type is marked as 'beforefieldinit'.
			static _activate_d__34()
			{
				Il2CppClassPointerStore<ChatView._activate_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "<activate>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatView._activate_d__34>.NativeClassPtr);
				ChatView._activate_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView._activate_d__34>.NativeClassPtr, "<>1__state");
				ChatView._activate_d__34.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView._activate_d__34>.NativeClassPtr, "<>2__current");
				ChatView._activate_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView._activate_d__34>.NativeClassPtr, "<>4__this");
				ChatView._activate_d__34.NativeFieldInfoPtr__canvasGroup_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView._activate_d__34>.NativeClassPtr, "<canvasGroup>5__2");
				ChatView._activate_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._activate_d__34>.NativeClassPtr, 100664678);
				ChatView._activate_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._activate_d__34>.NativeClassPtr, 100664679);
				ChatView._activate_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._activate_d__34>.NativeClassPtr, 100664680);
				ChatView._activate_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._activate_d__34>.NativeClassPtr, 100664681);
				ChatView._activate_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._activate_d__34>.NativeClassPtr, 100664682);
				ChatView._activate_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._activate_d__34>.NativeClassPtr, 100664683);
			}

			// Token: 0x060018DE RID: 6366 RVA: 0x0005E2F0 File Offset: 0x0005C4F0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _activate_d__34(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatView._activate_d__34>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._activate_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018DF RID: 6367 RVA: 0x0005E338 File Offset: 0x0005C538
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._activate_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018E0 RID: 6368 RVA: 0x0005E36C File Offset: 0x0005C56C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991663, XrefRangeEnd = 991666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._activate_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000732 RID: 1842
			// (get) Token: 0x060018E1 RID: 6369 RVA: 0x0005E3A8 File Offset: 0x0005C5A8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._activate_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060018E2 RID: 6370 RVA: 0x0005E3E8 File Offset: 0x0005C5E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991666, XrefRangeEnd = 991671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._activate_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000733 RID: 1843
			// (get) Token: 0x060018E3 RID: 6371 RVA: 0x0005E41C File Offset: 0x0005C61C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._activate_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060018E4 RID: 6372 RVA: 0x0000D947 File Offset: 0x0000BB47
			public _activate_d__34(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700072E RID: 1838
			// (get) Token: 0x060018E5 RID: 6373 RVA: 0x0005E45C File Offset: 0x0005C65C
			// (set) Token: 0x060018E6 RID: 6374 RVA: 0x0000D950 File Offset: 0x0000BB50
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._activate_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._activate_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700072F RID: 1839
			// (get) Token: 0x060018E7 RID: 6375 RVA: 0x0005E484 File Offset: 0x0005C684
			// (set) Token: 0x060018E8 RID: 6376 RVA: 0x0000D96B File Offset: 0x0000BB6B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._activate_d__34.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._activate_d__34.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000730 RID: 1840
			// (get) Token: 0x060018E9 RID: 6377 RVA: 0x0005E4B4 File Offset: 0x0005C6B4
			// (set) Token: 0x060018EA RID: 6378 RVA: 0x0000D98A File Offset: 0x0000BB8A
			public unsafe ChatView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._activate_d__34.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._activate_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000731 RID: 1841
			// (get) Token: 0x060018EB RID: 6379 RVA: 0x0005E4E4 File Offset: 0x0005C6E4
			// (set) Token: 0x060018EC RID: 6380 RVA: 0x0000D9A9 File Offset: 0x0000BBA9
			public unsafe CanvasGroup _canvasGroup_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._activate_d__34.NativeFieldInfoPtr__canvasGroup_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._activate_d__34.NativeFieldInfoPtr__canvasGroup_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F0E RID: 3854
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F0F RID: 3855
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F10 RID: 3856
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000F11 RID: 3857
			private static readonly IntPtr NativeFieldInfoPtr__canvasGroup_5__2;

			// Token: 0x04000F12 RID: 3858
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F13 RID: 3859
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F14 RID: 3860
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F15 RID: 3861
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F16 RID: 3862
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F17 RID: 3863
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200021F RID: 543
		[ObfuscatedName("lotus.ChatView+<updateChat>d__58")]
		public sealed class _updateChat_d__58 : global::Il2CppSystem.Object
		{
			// Token: 0x060018ED RID: 6381 RVA: 0x0005E514 File Offset: 0x0005C714
			// Note: this type is marked as 'beforefieldinit'.
			static _updateChat_d__58()
			{
				Il2CppClassPointerStore<ChatView._updateChat_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChatView>.NativeClassPtr, "<updateChat>d__58");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatView._updateChat_d__58>.NativeClassPtr);
				ChatView._updateChat_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView._updateChat_d__58>.NativeClassPtr, "<>1__state");
				ChatView._updateChat_d__58.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView._updateChat_d__58>.NativeClassPtr, "<>2__current");
				ChatView._updateChat_d__58.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView._updateChat_d__58>.NativeClassPtr, "<>4__this");
				ChatView._updateChat_d__58.NativeFieldInfoPtr__orderedMessages_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatView._updateChat_d__58>.NativeClassPtr, "<orderedMessages>5__2");
				ChatView._updateChat_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._updateChat_d__58>.NativeClassPtr, 100664684);
				ChatView._updateChat_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._updateChat_d__58>.NativeClassPtr, 100664685);
				ChatView._updateChat_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._updateChat_d__58>.NativeClassPtr, 100664686);
				ChatView._updateChat_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._updateChat_d__58>.NativeClassPtr, 100664687);
				ChatView._updateChat_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._updateChat_d__58>.NativeClassPtr, 100664688);
				ChatView._updateChat_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatView._updateChat_d__58>.NativeClassPtr, 100664689);
			}

			// Token: 0x060018EE RID: 6382 RVA: 0x0005E608 File Offset: 0x0005C808
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _updateChat_d__58(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatView._updateChat_d__58>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._updateChat_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018EF RID: 6383 RVA: 0x0005E650 File Offset: 0x0005C850
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._updateChat_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018F0 RID: 6384 RVA: 0x0005E684 File Offset: 0x0005C884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991671, XrefRangeEnd = 991693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._updateChat_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000738 RID: 1848
			// (get) Token: 0x060018F1 RID: 6385 RVA: 0x0005E6C0 File Offset: 0x0005C8C0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._updateChat_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060018F2 RID: 6386 RVA: 0x0005E700 File Offset: 0x0005C900
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991693, XrefRangeEnd = 991698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._updateChat_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000739 RID: 1849
			// (get) Token: 0x060018F3 RID: 6387 RVA: 0x0005E734 File Offset: 0x0005C934
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatView._updateChat_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060018F4 RID: 6388 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
			public _updateChat_d__58(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000734 RID: 1844
			// (get) Token: 0x060018F5 RID: 6389 RVA: 0x0005E774 File Offset: 0x0005C974
			// (set) Token: 0x060018F6 RID: 6390 RVA: 0x0000D9D1 File Offset: 0x0000BBD1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._updateChat_d__58.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._updateChat_d__58.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000735 RID: 1845
			// (get) Token: 0x060018F7 RID: 6391 RVA: 0x0005E79C File Offset: 0x0005C99C
			// (set) Token: 0x060018F8 RID: 6392 RVA: 0x0000D9EC File Offset: 0x0000BBEC
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._updateChat_d__58.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._updateChat_d__58.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000736 RID: 1846
			// (get) Token: 0x060018F9 RID: 6393 RVA: 0x0005E7CC File Offset: 0x0005C9CC
			// (set) Token: 0x060018FA RID: 6394 RVA: 0x0000DA0B File Offset: 0x0000BC0B
			public unsafe ChatView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._updateChat_d__58.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._updateChat_d__58.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000737 RID: 1847
			// (get) Token: 0x060018FB RID: 6395 RVA: 0x0005E7FC File Offset: 0x0005C9FC
			// (set) Token: 0x060018FC RID: 6396 RVA: 0x0000DA2A File Offset: 0x0000BC2A
			public unsafe IReadOnlyList<ClientChatMessage> _orderedMessages_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._updateChat_d__58.NativeFieldInfoPtr__orderedMessages_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ClientChatMessage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatView._updateChat_d__58.NativeFieldInfoPtr__orderedMessages_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F18 RID: 3864
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F19 RID: 3865
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F1A RID: 3866
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000F1B RID: 3867
			private static readonly IntPtr NativeFieldInfoPtr__orderedMessages_5__2;

			// Token: 0x04000F1C RID: 3868
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F1D RID: 3869
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F1E RID: 3870
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F1F RID: 3871
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F20 RID: 3872
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F21 RID: 3873
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
