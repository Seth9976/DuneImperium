using System;
using dwd.core.platform.websocket.incoming;
using dwd.core.ui.match.prompt.prompts;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UI;

namespace boardgames.menus.prompts.behaviours
{
	// Token: 0x02000203 RID: 515
	public class ChatSocialPromptBehaviour : PromptBehaviour<FlavoredDismissablePrompt>
	{
		// Token: 0x060017AB RID: 6059 RVA: 0x0006A6DC File Offset: 0x000688DC
		// Note: this type is marked as 'beforefieldinit'.
		static ChatSocialPromptBehaviour()
		{
			Il2CppClassPointerStore<ChatSocialPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts.behaviours", "ChatSocialPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatSocialPromptBehaviour>.NativeClassPtr);
			ChatSocialPromptBehaviour.NativeFieldInfoPtr_addFriendButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatSocialPromptBehaviour>.NativeClassPtr, "addFriendButton");
			ChatSocialPromptBehaviour.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatSocialPromptBehaviour>.NativeClassPtr, 100666751);
			ChatSocialPromptBehaviour.NativeMethodInfoPtr_Event_AddPlayerAsFriend_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatSocialPromptBehaviour>.NativeClassPtr, 100666752);
			ChatSocialPromptBehaviour.NativeMethodInfoPtr_Event_BlockPlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatSocialPromptBehaviour>.NativeClassPtr, 100666753);
			ChatSocialPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatSocialPromptBehaviour>.NativeClassPtr, 100666754);
			ChatSocialPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatSocialPromptBehaviour>.NativeClassPtr, 100666755);
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x0006A784 File Offset: 0x00068984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525307, XrefRangeEnd = 525331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatSocialPromptBehaviour.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x0006A7B8 File Offset: 0x000689B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525331, XrefRangeEnd = 525388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_AddPlayerAsFriend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatSocialPromptBehaviour.NativeMethodInfoPtr_Event_AddPlayerAsFriend_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x0006A7EC File Offset: 0x000689EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525388, XrefRangeEnd = 525407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_BlockPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatSocialPromptBehaviour.NativeMethodInfoPtr_Event_BlockPlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x0006A820 File Offset: 0x00068A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525407, XrefRangeEnd = 525412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatSocialPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x0006A854 File Offset: 0x00068A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525412, XrefRangeEnd = 525415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChatSocialPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatSocialPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatSocialPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x0000D2D9 File Offset: 0x0000B4D9
		public ChatSocialPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x0006A890 File Offset: 0x00068A90
		// (set) Token: 0x060017B3 RID: 6067 RVA: 0x0000D2E2 File Offset: 0x0000B4E2
		public unsafe Button addFriendButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatSocialPromptBehaviour.NativeFieldInfoPtr_addFriendButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatSocialPromptBehaviour.NativeFieldInfoPtr_addFriendButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeFieldInfoPtr_addFriendButton;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeMethodInfoPtr_Event_AddPlayerAsFriend_Public_Void_0;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeMethodInfoPtr_Event_BlockPlayer_Public_Void_0;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeMethodInfoPtr_Event_Dismiss_Public_Void_0;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003D5 RID: 981
		[ObfuscatedName("boardgames.menus.prompts.behaviours.ChatSocialPromptBehaviour+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06002DA8 RID: 11688 RVA: 0x000B0D80 File Offset: 0x000AEF80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<ChatSocialPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChatSocialPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatSocialPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr);
				ChatSocialPromptBehaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_playerAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatSocialPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr, "playerAccountID");
				ChatSocialPromptBehaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatSocialPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr, 100666756);
				ChatSocialPromptBehaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__Start_b__0_Internal_Boolean_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatSocialPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr, 100666757);
			}

			// Token: 0x06002DA9 RID: 11689 RVA: 0x000B0DE8 File Offset: 0x000AEFE8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatSocialPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatSocialPromptBehaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002DAA RID: 11690 RVA: 0x000B0E24 File Offset: 0x000AF024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525305, XrefRangeEnd = 525307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__0(RosterEntry friend)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(friend);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatSocialPromptBehaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__Start_b__0_Internal_Boolean_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002DAB RID: 11691 RVA: 0x000179D3 File Offset: 0x00015BD3
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CF9 RID: 3321
			// (get) Token: 0x06002DAC RID: 11692 RVA: 0x000B0E74 File Offset: 0x000AF074
			// (set) Token: 0x06002DAD RID: 11693 RVA: 0x000179DC File Offset: 0x00015BDC
			public unsafe string playerAccountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatSocialPromptBehaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_playerAccountID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatSocialPromptBehaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_playerAccountID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001C4B RID: 7243
			private static readonly IntPtr NativeFieldInfoPtr_playerAccountID;

			// Token: 0x04001C4C RID: 7244
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001C4D RID: 7245
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Boolean_RosterEntry_0;
		}
	}
}
