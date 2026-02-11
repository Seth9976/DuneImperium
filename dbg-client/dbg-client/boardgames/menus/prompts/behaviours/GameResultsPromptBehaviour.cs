using System;
using boardgames.match.data;
using boardgames.menus.commands;
using Canis;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace boardgames.menus.prompts.behaviours
{
	// Token: 0x02000206 RID: 518
	public class GameResultsPromptBehaviour : PromptBehaviour<GameResultsPrompt>
	{
		// Token: 0x060017C6 RID: 6086 RVA: 0x0006ACF4 File Offset: 0x00068EF4
		// Note: this type is marked as 'beforefieldinit'.
		static GameResultsPromptBehaviour()
		{
			Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts.behaviours", "GameResultsPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr);
			GameResultsPromptBehaviour.NativeFieldInfoPtr_playerEntryPrototype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr, "playerEntryPrototype");
			GameResultsPromptBehaviour.NativeFieldInfoPtr_playerEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr, "playerEntryContainer");
			GameResultsPromptBehaviour.NativeFieldInfoPtr_chatPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr, "chatPanel");
			GameResultsPromptBehaviour.NativeFieldInfoPtr_menuButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr, "menuButton");
			GameResultsPromptBehaviour.NativeFieldInfoPtr_continueButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr, "continueButton");
			GameResultsPromptBehaviour.NativeFieldInfoPtr_retryButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr, "retryButton");
			GameResultsPromptBehaviour.NativeFieldInfoPtr_gameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr, "gameOptions");
			GameResultsPromptBehaviour.NativeMethodInfoPtr_get_CanContinueTutorial_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr, 100666768);
			GameResultsPromptBehaviour.NativeMethodInfoPtr_get_CanContinueChallenge_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr, 100666769);
			GameResultsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr, 100666770);
			GameResultsPromptBehaviour.NativeMethodInfoPtr_configurePlayerEntries_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr, 100666771);
			GameResultsPromptBehaviour.NativeMethodInfoPtr_Event_Continue_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr, 100666772);
			GameResultsPromptBehaviour.NativeMethodInfoPtr_Event_Retry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr, 100666773);
			GameResultsPromptBehaviour.NativeMethodInfoPtr_configureMatchData_Protected_Virtual_New_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr, 100666774);
			GameResultsPromptBehaviour.NativeMethodInfoPtr_Event_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr, 100666775);
			GameResultsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr, 100666776);
			GameResultsPromptBehaviour.NativeMethodInfoPtr__Event_Continue_b__13_0_Private_Void_RunConfigureOfflineMatchFlow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr, 100666777);
			GameResultsPromptBehaviour.NativeMethodInfoPtr__Event_Retry_b__14_0_Private_Void_RunConfigureOfflineMatchFlow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr, 100666778);
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x0006AE8C File Offset: 0x0006908C
		public unsafe bool CanContinueTutorial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525478, XrefRangeEnd = 525480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsPromptBehaviour.NativeMethodInfoPtr_get_CanContinueTutorial_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x0006AEC8 File Offset: 0x000690C8
		public unsafe bool CanContinueChallenge
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525480, XrefRangeEnd = 525482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsPromptBehaviour.NativeMethodInfoPtr_get_CanContinueChallenge_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x0006AF04 File Offset: 0x00069104
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 525535, RefRangeEnd = 525536, XrefRangeStart = 525482, XrefRangeEnd = 525535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameResultsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x0006AF40 File Offset: 0x00069140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525536, XrefRangeEnd = 525605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void configurePlayerEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameResultsPromptBehaviour.NativeMethodInfoPtr_configurePlayerEntries_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x0006AF7C File Offset: 0x0006917C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525605, XrefRangeEnd = 525635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_Continue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameResultsPromptBehaviour.NativeMethodInfoPtr_Event_Continue_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x0006AFB8 File Offset: 0x000691B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525635, XrefRangeEnd = 525658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Retry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsPromptBehaviour.NativeMethodInfoPtr_Event_Retry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x0006AFEC File Offset: 0x000691EC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void configureMatchData(MatchInitData matchData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameResultsPromptBehaviour.NativeMethodInfoPtr_configureMatchData_Protected_Virtual_New_Void_MatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x0006B03C File Offset: 0x0006923C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525658, XrefRangeEnd = 525665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameResultsPromptBehaviour.NativeMethodInfoPtr_Event_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x0006B078 File Offset: 0x00069278
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 525668, RefRangeEnd = 525669, XrefRangeStart = 525665, XrefRangeEnd = 525668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameResultsPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x0006B0B4 File Offset: 0x000692B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525669, XrefRangeEnd = 525676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Event_Continue_b__13_0(RunConfigureOfflineMatchFlow flow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(flow);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsPromptBehaviour.NativeMethodInfoPtr__Event_Continue_b__13_0_Private_Void_RunConfigureOfflineMatchFlow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x0006B0F8 File Offset: 0x000692F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525676, XrefRangeEnd = 525683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Event_Retry_b__14_0(RunConfigureOfflineMatchFlow flow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(flow);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsPromptBehaviour.NativeMethodInfoPtr__Event_Retry_b__14_0_Private_Void_RunConfigureOfflineMatchFlow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x0000D351 File Offset: 0x0000B551
		public GameResultsPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x0006B13C File Offset: 0x0006933C
		// (set) Token: 0x060017D4 RID: 6100 RVA: 0x0000D35A File Offset: 0x0000B55A
		public unsafe SubscriptionProvider playerEntryPrototype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPromptBehaviour.NativeFieldInfoPtr_playerEntryPrototype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPromptBehaviour.NativeFieldInfoPtr_playerEntryPrototype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060017D5 RID: 6101 RVA: 0x0006B16C File Offset: 0x0006936C
		// (set) Token: 0x060017D6 RID: 6102 RVA: 0x0000D379 File Offset: 0x0000B579
		public unsafe Transform playerEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPromptBehaviour.NativeFieldInfoPtr_playerEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPromptBehaviour.NativeFieldInfoPtr_playerEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060017D7 RID: 6103 RVA: 0x0006B19C File Offset: 0x0006939C
		// (set) Token: 0x060017D8 RID: 6104 RVA: 0x0000D398 File Offset: 0x0000B598
		public unsafe GameObject chatPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPromptBehaviour.NativeFieldInfoPtr_chatPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPromptBehaviour.NativeFieldInfoPtr_chatPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060017D9 RID: 6105 RVA: 0x0006B1CC File Offset: 0x000693CC
		// (set) Token: 0x060017DA RID: 6106 RVA: 0x0000D3B7 File Offset: 0x0000B5B7
		public unsafe GameObject menuButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPromptBehaviour.NativeFieldInfoPtr_menuButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPromptBehaviour.NativeFieldInfoPtr_menuButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060017DB RID: 6107 RVA: 0x0006B1FC File Offset: 0x000693FC
		// (set) Token: 0x060017DC RID: 6108 RVA: 0x0000D3D6 File Offset: 0x0000B5D6
		public unsafe GameObject continueButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPromptBehaviour.NativeFieldInfoPtr_continueButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPromptBehaviour.NativeFieldInfoPtr_continueButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x0006B22C File Offset: 0x0006942C
		// (set) Token: 0x060017DE RID: 6110 RVA: 0x0000D3F5 File Offset: 0x0000B5F5
		public unsafe GameObject retryButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPromptBehaviour.NativeFieldInfoPtr_retryButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPromptBehaviour.NativeFieldInfoPtr_retryButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060017DF RID: 6111 RVA: 0x0006B25C File Offset: 0x0006945C
		// (set) Token: 0x060017E0 RID: 6112 RVA: 0x0000D414 File Offset: 0x0000B614
		public unsafe GameOptionsData gameOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPromptBehaviour.NativeFieldInfoPtr_gameOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameOptionsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPromptBehaviour.NativeFieldInfoPtr_gameOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeFieldInfoPtr_playerEntryPrototype;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeFieldInfoPtr_playerEntryContainer;

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeFieldInfoPtr_chatPanel;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeFieldInfoPtr_menuButton;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeFieldInfoPtr_continueButton;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeFieldInfoPtr_retryButton;

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeFieldInfoPtr_gameOptions;

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeMethodInfoPtr_get_CanContinueTutorial_Private_get_Boolean_0;

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeMethodInfoPtr_get_CanContinueChallenge_Private_get_Boolean_0;

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeMethodInfoPtr_configurePlayerEntries_Protected_Virtual_New_Void_0;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeMethodInfoPtr_Event_Continue_Public_Virtual_New_Void_0;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeMethodInfoPtr_Event_Retry_Public_Void_0;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeMethodInfoPtr_configureMatchData_Protected_Virtual_New_Void_MatchInitData_0;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr_Event_Close_Public_Virtual_New_Void_0;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeMethodInfoPtr__Event_Continue_b__13_0_Private_Void_RunConfigureOfflineMatchFlow_0;

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeMethodInfoPtr__Event_Retry_b__14_0_Private_Void_RunConfigureOfflineMatchFlow_0;

		// Token: 0x020003D6 RID: 982
		[ObfuscatedName("boardgames.menus.prompts.behaviours.GameResultsPromptBehaviour+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002DAE RID: 11694 RVA: 0x000B0E9C File Offset: 0x000AF09C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GameResultsPromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameResultsPromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameResultsPromptBehaviour.__c>.NativeClassPtr);
				GameResultsPromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsPromptBehaviour.__c>.NativeClassPtr, "<>9");
				GameResultsPromptBehaviour.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsPromptBehaviour.__c>.NativeClassPtr, "<>9__12_0");
				GameResultsPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPromptBehaviour.__c>.NativeClassPtr, 100666780);
				GameResultsPromptBehaviour.__c.NativeMethodInfoPtr__configurePlayerEntries_b__12_0_Internal_Boolean_GameResultsPlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPromptBehaviour.__c>.NativeClassPtr, 100666781);
			}

			// Token: 0x06002DAF RID: 11695 RVA: 0x000B0F18 File Offset: 0x000AF118
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameResultsPromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002DB0 RID: 11696 RVA: 0x000B0F54 File Offset: 0x000AF154
			[CallerCount(0)]
			public unsafe bool _configurePlayerEntries_b__12_0(GameResultsPlayerData playerData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerData);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsPromptBehaviour.__c.NativeMethodInfoPtr__configurePlayerEntries_b__12_0_Internal_Boolean_GameResultsPlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002DB1 RID: 11697 RVA: 0x000179FB File Offset: 0x00015BFB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CFA RID: 3322
			// (get) Token: 0x06002DB2 RID: 11698 RVA: 0x000B0FA4 File Offset: 0x000AF1A4
			// (set) Token: 0x06002DB3 RID: 11699 RVA: 0x00017A04 File Offset: 0x00015C04
			public unsafe static GameResultsPromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameResultsPromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameResultsPromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameResultsPromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CFB RID: 3323
			// (get) Token: 0x06002DB4 RID: 11700 RVA: 0x000B0FCC File Offset: 0x000AF1CC
			// (set) Token: 0x06002DB5 RID: 11701 RVA: 0x00017A16 File Offset: 0x00015C16
			public unsafe static Func<GameResultsPlayerData, bool> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameResultsPromptBehaviour.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameResultsPlayerData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameResultsPromptBehaviour.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C4E RID: 7246
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001C4F RID: 7247
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04001C50 RID: 7248
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001C51 RID: 7249
			private static readonly IntPtr NativeMethodInfoPtr__configurePlayerEntries_b__12_0_Internal_Boolean_GameResultsPlayerData_0;
		}
	}
}
