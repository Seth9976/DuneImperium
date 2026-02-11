using System;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.menus.prompts
{
	// Token: 0x020001D9 RID: 473
	public class OnlineMatchesPromptBehaviour : PromptBehaviour<OnlineMatchesPrompt>
	{
		// Token: 0x060015BC RID: 5564 RVA: 0x00063DA4 File Offset: 0x00061FA4
		// Note: this type is marked as 'beforefieldinit'.
		static OnlineMatchesPromptBehaviour()
		{
			Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "OnlineMatchesPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr);
			OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_itemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, "itemPrefab");
			OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_noGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, "noGames");
			OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_gameListSpinner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, "gameListSpinner");
			OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_passwordGameToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, "passwordGameToggle");
			OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_incrementPageButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, "incrementPageButton");
			OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_decrementPageButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, "decrementPageButton");
			OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_paginationText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, "paginationText");
			OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_paginationTextFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, "paginationTextFormat");
			OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_cachedLobbyProviderVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, "cachedLobbyProviderVersion");
			OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_lobbyGameProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, "lobbyGameProvider");
			OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_lobbySessionProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, "lobbySessionProvider");
			OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_showPasswordGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, "showPasswordGames");
			OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_settingUpPasswordToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, "settingUpPasswordToggle");
			OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, "dirty");
			OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_currentPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, "currentPage");
			OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_currentItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, "currentItems");
			OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, 100666493);
			OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, 100666494);
			OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_orderLobbies_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, 100666495);
			OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_Event_JoinGame_Public_Virtual_New_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, 100666496);
			OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_Event_CreateGame_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, 100666497);
			OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_Event_CreateFriendGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, 100666498);
			OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, 100666499);
			OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_Event_ToggleShowPasswordGames_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, 100666500);
			OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_Event_IncrementDecrementPage_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, 100666501);
			OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, 100666502);
			OnlineMatchesPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, 100666503);
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00063FF0 File Offset: 0x000621F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522980, XrefRangeEnd = 522996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x0006402C File Offset: 0x0006222C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522996, XrefRangeEnd = 523141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00064060 File Offset: 0x00062260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523141, XrefRangeEnd = 523165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void orderLobbies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_orderLobbies_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x0006409C File Offset: 0x0006229C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523165, XrefRangeEnd = 523209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_JoinGame(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_Event_JoinGame_Public_Virtual_New_Void_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x000640EC File Offset: 0x000622EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523209, XrefRangeEnd = 523214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_CreateGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_Event_CreateGame_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00064128 File Offset: 0x00062328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523214, XrefRangeEnd = 523219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_CreateFriendGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_Event_CreateFriendGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x0006415C File Offset: 0x0006235C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523219, XrefRangeEnd = 523224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00064190 File Offset: 0x00062390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523224, XrefRangeEnd = 523234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleShowPasswordGames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_Event_ToggleShowPasswordGames_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x000641C4 File Offset: 0x000623C4
		[CallerCount(0)]
		public unsafe void Event_IncrementDecrementPage(int direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_Event_IncrementDecrementPage_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x00064204 File Offset: 0x00062404
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 523260, RefRangeEnd = 523262, XrefRangeStart = 523234, XrefRangeEnd = 523260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateButtonStates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineMatchesPromptBehaviour.NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00064238 File Offset: 0x00062438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523262, XrefRangeEnd = 523276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnlineMatchesPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineMatchesPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x0000C47C File Offset: 0x0000A67C
		public OnlineMatchesPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x060015C9 RID: 5577 RVA: 0x00064274 File Offset: 0x00062474
		// (set) Token: 0x060015CA RID: 5578 RVA: 0x0000C485 File Offset: 0x0000A685
		public unsafe SubscriptionProvider itemPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_itemPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_itemPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x000642A4 File Offset: 0x000624A4
		// (set) Token: 0x060015CC RID: 5580 RVA: 0x0000C4A4 File Offset: 0x0000A6A4
		public unsafe GameObject noGames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_noGames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_noGames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x000642D4 File Offset: 0x000624D4
		// (set) Token: 0x060015CE RID: 5582 RVA: 0x0000C4C3 File Offset: 0x0000A6C3
		public unsafe GameObject gameListSpinner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_gameListSpinner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_gameListSpinner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x060015CF RID: 5583 RVA: 0x00064304 File Offset: 0x00062504
		// (set) Token: 0x060015D0 RID: 5584 RVA: 0x0000C4E2 File Offset: 0x0000A6E2
		public unsafe Toggle passwordGameToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_passwordGameToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_passwordGameToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x00064334 File Offset: 0x00062534
		// (set) Token: 0x060015D2 RID: 5586 RVA: 0x0000C501 File Offset: 0x0000A701
		public unsafe Selectable incrementPageButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_incrementPageButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_incrementPageButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x00064364 File Offset: 0x00062564
		// (set) Token: 0x060015D4 RID: 5588 RVA: 0x0000C520 File Offset: 0x0000A720
		public unsafe Selectable decrementPageButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_decrementPageButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_decrementPageButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x060015D5 RID: 5589 RVA: 0x00064394 File Offset: 0x00062594
		// (set) Token: 0x060015D6 RID: 5590 RVA: 0x0000C53F File Offset: 0x0000A73F
		public unsafe TMP_Text paginationText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_paginationText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_paginationText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060015D7 RID: 5591 RVA: 0x000643C4 File Offset: 0x000625C4
		// (set) Token: 0x060015D8 RID: 5592 RVA: 0x0000C55E File Offset: 0x0000A75E
		public unsafe string paginationTextFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_paginationTextFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_paginationTextFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060015D9 RID: 5593 RVA: 0x000643EC File Offset: 0x000625EC
		// (set) Token: 0x060015DA RID: 5594 RVA: 0x0000C57D File Offset: 0x0000A77D
		public unsafe ulong cachedLobbyProviderVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_cachedLobbyProviderVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_cachedLobbyProviderVersion)) = value;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x00064414 File Offset: 0x00062614
		// (set) Token: 0x060015DC RID: 5596 RVA: 0x0000C598 File Offset: 0x0000A798
		public unsafe DBGLobbyGameProvider lobbyGameProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_lobbyGameProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGLobbyGameProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_lobbyGameProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060015DD RID: 5597 RVA: 0x00064444 File Offset: 0x00062644
		// (set) Token: 0x060015DE RID: 5598 RVA: 0x0000C5B7 File Offset: 0x0000A7B7
		public unsafe LobbySessionProvider lobbySessionProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_lobbySessionProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbySessionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_lobbySessionProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x00064474 File Offset: 0x00062674
		// (set) Token: 0x060015E0 RID: 5600 RVA: 0x0000C5D6 File Offset: 0x0000A7D6
		public unsafe bool showPasswordGames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_showPasswordGames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_showPasswordGames)) = value;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x0006449C File Offset: 0x0006269C
		// (set) Token: 0x060015E2 RID: 5602 RVA: 0x0000C5F1 File Offset: 0x0000A7F1
		public unsafe bool settingUpPasswordToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_settingUpPasswordToggle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_settingUpPasswordToggle)) = value;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x000644C4 File Offset: 0x000626C4
		// (set) Token: 0x060015E4 RID: 5604 RVA: 0x0000C60C File Offset: 0x0000A80C
		public unsafe bool dirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_dirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_dirty)) = value;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x000644EC File Offset: 0x000626EC
		// (set) Token: 0x060015E6 RID: 5606 RVA: 0x0000C627 File Offset: 0x0000A827
		public unsafe int currentPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_currentPage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_currentPage)) = value;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060015E7 RID: 5607 RVA: 0x00064514 File Offset: 0x00062714
		// (set) Token: 0x060015E8 RID: 5608 RVA: 0x0000C642 File Offset: 0x0000A842
		public unsafe SortedList<GameID, SubscriptionProvider> currentItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_currentItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList<GameID, SubscriptionProvider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.NativeFieldInfoPtr_currentItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeFieldInfoPtr_itemPrefab;

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeFieldInfoPtr_noGames;

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeFieldInfoPtr_gameListSpinner;

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeFieldInfoPtr_passwordGameToggle;

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeFieldInfoPtr_incrementPageButton;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeFieldInfoPtr_decrementPageButton;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeFieldInfoPtr_paginationText;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeFieldInfoPtr_paginationTextFormat;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeFieldInfoPtr_cachedLobbyProviderVersion;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeFieldInfoPtr_lobbyGameProvider;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeFieldInfoPtr_lobbySessionProvider;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeFieldInfoPtr_showPasswordGames;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeFieldInfoPtr_settingUpPasswordToggle;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeFieldInfoPtr_dirty;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeFieldInfoPtr_currentPage;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeFieldInfoPtr_currentItems;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeMethodInfoPtr_orderLobbies_Protected_Virtual_New_Void_0;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeMethodInfoPtr_Event_JoinGame_Public_Virtual_New_Void_DataComposition_0;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeMethodInfoPtr_Event_CreateGame_Public_Virtual_New_Void_0;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeMethodInfoPtr_Event_CreateFriendGame_Public_Void_0;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeMethodInfoPtr_Event_Back_Public_Void_0;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleShowPasswordGames_Public_Void_0;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeMethodInfoPtr_Event_IncrementDecrementPage_Public_Void_Int32_0;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003C8 RID: 968
		[ObfuscatedName("boardgames.menus.prompts.OnlineMatchesPromptBehaviour+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002D25 RID: 11557 RVA: 0x000AF5BC File Offset: 0x000AD7BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<OnlineMatchesPromptBehaviour.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour.__c__DisplayClass17_0>.NativeClassPtr);
				OnlineMatchesPromptBehaviour.__c__DisplayClass17_0.NativeFieldInfoPtr_myAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour.__c__DisplayClass17_0>.NativeClassPtr, "myAccountID");
				OnlineMatchesPromptBehaviour.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour.__c__DisplayClass17_0>.NativeClassPtr, 100666504);
				OnlineMatchesPromptBehaviour.__c__DisplayClass17_0.NativeMethodInfoPtr__Update_b__0_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour.__c__DisplayClass17_0>.NativeClassPtr, 100666505);
			}

			// Token: 0x06002D26 RID: 11558 RVA: 0x000AF624 File Offset: 0x000AD824
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlineMatchesPromptBehaviour.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineMatchesPromptBehaviour.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D27 RID: 11559 RVA: 0x000AF660 File Offset: 0x000AD860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522975, XrefRangeEnd = 522980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Update_b__0(AccountIDUsernameMetadata p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineMatchesPromptBehaviour.__c__DisplayClass17_0.NativeMethodInfoPtr__Update_b__0_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D28 RID: 11560 RVA: 0x000175AC File Offset: 0x000157AC
			public __c__DisplayClass17_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CD2 RID: 3282
			// (get) Token: 0x06002D29 RID: 11561 RVA: 0x000AF6B0 File Offset: 0x000AD8B0
			// (set) Token: 0x06002D2A RID: 11562 RVA: 0x000175B5 File Offset: 0x000157B5
			public unsafe AccountID myAccountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.__c__DisplayClass17_0.NativeFieldInfoPtr_myAccountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesPromptBehaviour.__c__DisplayClass17_0.NativeFieldInfoPtr_myAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C03 RID: 7171
			private static readonly IntPtr NativeFieldInfoPtr_myAccountID;

			// Token: 0x04001C04 RID: 7172
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001C05 RID: 7173
			private static readonly IntPtr NativeMethodInfoPtr__Update_b__0_Internal_Boolean_AccountIDUsernameMetadata_0;
		}
	}
}
