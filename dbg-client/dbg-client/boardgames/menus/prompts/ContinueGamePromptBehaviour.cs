using System;
using boardgames.data;
using boardgames.ui.commands;
using Canis;
using Canis.utils.ids;
using dwd.core;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.ui.prompt.behaviours;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using zen.src.matchMaking.commands;

namespace boardgames.menus.prompts
{
	// Token: 0x020001CC RID: 460
	public class ContinueGamePromptBehaviour : PromptBehaviour<OnlineMatchesPrompt>
	{
		// Token: 0x060014E3 RID: 5347 RVA: 0x000614EC File Offset: 0x0005F6EC
		// Note: this type is marked as 'beforefieldinit'.
		static ContinueGamePromptBehaviour()
		{
			Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "ContinueGamePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr);
			ContinueGamePromptBehaviour.NativeFieldInfoPtr_itemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, "itemPrefab");
			ContinueGamePromptBehaviour.NativeFieldInfoPtr_noGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, "noGames");
			ContinueGamePromptBehaviour.NativeFieldInfoPtr_gameListSpinner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, "gameListSpinner");
			ContinueGamePromptBehaviour.NativeFieldInfoPtr_activeGamesPane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, "activeGamesPane");
			ContinueGamePromptBehaviour.NativeFieldInfoPtr_browserButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, "browserButton");
			ContinueGamePromptBehaviour.NativeFieldInfoPtr_gamesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, "gamesData");
			ContinueGamePromptBehaviour.NativeFieldInfoPtr_cachedDataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, "cachedDataVersion");
			ContinueGamePromptBehaviour.NativeFieldInfoPtr_canShowOurTurnActiveGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, "canShowOurTurnActiveGames");
			ContinueGamePromptBehaviour.NativeFieldInfoPtr_OnShowReconnectableGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, "OnShowReconnectableGames");
			ContinueGamePromptBehaviour.NativeFieldInfoPtr_gameEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, "gameEntries");
			ContinueGamePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, 100666373);
			ContinueGamePromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, 100666374);
			ContinueGamePromptBehaviour.NativeMethodInfoPtr_Event_ReconnectToGame_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, 100666375);
			ContinueGamePromptBehaviour.NativeMethodInfoPtr_Event_Refresh_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, 100666376);
			ContinueGamePromptBehaviour.NativeMethodInfoPtr_Event_Resign_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, 100666377);
			ContinueGamePromptBehaviour.NativeMethodInfoPtr_Event_ViewResults_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, 100666378);
			ContinueGamePromptBehaviour.NativeMethodInfoPtr_ShowGameResults_Protected_IEnumerator_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, 100666379);
			ContinueGamePromptBehaviour.NativeMethodInfoPtr_getViewGameResultsCommand_Protected_Virtual_New_Command_DBGGameResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, 100666380);
			ContinueGamePromptBehaviour.NativeMethodInfoPtr_OnGotReconnectableGames_Protected_Virtual_New_Void_GetReconnectableGames_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, 100666381);
			ContinueGamePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, 100666382);
			ContinueGamePromptBehaviour.NativeMethodInfoPtr__Event_Refresh_b__14_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, 100666383);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x000616C0 File Offset: 0x0005F8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521655, XrefRangeEnd = 521663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContinueGamePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x000616FC File Offset: 0x0005F8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521663, XrefRangeEnd = 521774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x00061730 File Offset: 0x0005F930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521774, XrefRangeEnd = 521810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ReconnectToGame(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour.NativeMethodInfoPtr_Event_ReconnectToGame_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00061774 File Offset: 0x0005F974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521810, XrefRangeEnd = 521850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContinueGamePromptBehaviour.NativeMethodInfoPtr_Event_Refresh_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x000617B0 File Offset: 0x0005F9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521850, XrefRangeEnd = 521888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Resign(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour.NativeMethodInfoPtr_Event_Resign_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x000617F4 File Offset: 0x0005F9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521888, XrefRangeEnd = 521904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ViewResults(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour.NativeMethodInfoPtr_Event_ViewResults_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00061838 File Offset: 0x0005FA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521904, XrefRangeEnd = 521910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowGameResults(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour.NativeMethodInfoPtr_ShowGameResults_Protected_IEnumerator_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00061888 File Offset: 0x0005FA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521910, XrefRangeEnd = 521914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command getViewGameResultsCommand(DBGGameResults gameResults)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameResults);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContinueGamePromptBehaviour.NativeMethodInfoPtr_getViewGameResultsCommand_Protected_Virtual_New_Command_DBGGameResults_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x000618E4 File Offset: 0x0005FAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521914, XrefRangeEnd = 521937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnGotReconnectableGames(GetReconnectableGames command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContinueGamePromptBehaviour.NativeMethodInfoPtr_OnGotReconnectableGames_Protected_Virtual_New_Void_GetReconnectableGames_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x00061934 File Offset: 0x0005FB34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 521952, RefRangeEnd = 521953, XrefRangeStart = 521937, XrefRangeEnd = 521952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContinueGamePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x00061970 File Offset: 0x0005FB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521953, XrefRangeEnd = 521976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Event_Refresh_b__14_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour.NativeMethodInfoPtr__Event_Refresh_b__14_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x0000BCA4 File Offset: 0x00009EA4
		public ContinueGamePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x000619A4 File Offset: 0x0005FBA4
		// (set) Token: 0x060014F1 RID: 5361 RVA: 0x0000BCAD File Offset: 0x00009EAD
		public unsafe SubscriptionProvider itemPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_itemPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_itemPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x000619D4 File Offset: 0x0005FBD4
		// (set) Token: 0x060014F3 RID: 5363 RVA: 0x0000BCCC File Offset: 0x00009ECC
		public unsafe GameObject noGames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_noGames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_noGames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x00061A04 File Offset: 0x0005FC04
		// (set) Token: 0x060014F5 RID: 5365 RVA: 0x0000BCEB File Offset: 0x00009EEB
		public unsafe GameObject gameListSpinner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_gameListSpinner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_gameListSpinner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x00061A34 File Offset: 0x0005FC34
		// (set) Token: 0x060014F7 RID: 5367 RVA: 0x0000BD0A File Offset: 0x00009F0A
		public unsafe RectTransform activeGamesPane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_activeGamesPane);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_activeGamesPane), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x00061A64 File Offset: 0x0005FC64
		// (set) Token: 0x060014F9 RID: 5369 RVA: 0x0000BD29 File Offset: 0x00009F29
		public unsafe Selectable browserButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_browserButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_browserButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x00061A94 File Offset: 0x0005FC94
		// (set) Token: 0x060014FB RID: 5371 RVA: 0x0000BD48 File Offset: 0x00009F48
		public unsafe ReconnectableGamesData gamesData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_gamesData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReconnectableGamesData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_gamesData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x00061AC4 File Offset: 0x0005FCC4
		// (set) Token: 0x060014FD RID: 5373 RVA: 0x0000BD67 File Offset: 0x00009F67
		public unsafe ulong cachedDataVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_cachedDataVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_cachedDataVersion)) = value;
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x00061AEC File Offset: 0x0005FCEC
		// (set) Token: 0x060014FF RID: 5375 RVA: 0x0000BD82 File Offset: 0x00009F82
		public unsafe bool canShowOurTurnActiveGames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_canShowOurTurnActiveGames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_canShowOurTurnActiveGames)) = value;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x00061B14 File Offset: 0x0005FD14
		// (set) Token: 0x06001501 RID: 5377 RVA: 0x0000BD9D File Offset: 0x00009F9D
		public unsafe UnityEvent OnShowReconnectableGames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_OnShowReconnectableGames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_OnShowReconnectableGames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x00061B44 File Offset: 0x0005FD44
		// (set) Token: 0x06001503 RID: 5379 RVA: 0x0000BDBC File Offset: 0x00009FBC
		public unsafe List<ContinueGamePromptBehaviour.OrderedGameEntry> gameEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_gameEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ContinueGamePromptBehaviour.OrderedGameEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.NativeFieldInfoPtr_gameEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeFieldInfoPtr_itemPrefab;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeFieldInfoPtr_noGames;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeFieldInfoPtr_gameListSpinner;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeFieldInfoPtr_activeGamesPane;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeFieldInfoPtr_browserButton;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeFieldInfoPtr_gamesData;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeFieldInfoPtr_cachedDataVersion;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeFieldInfoPtr_canShowOurTurnActiveGames;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeFieldInfoPtr_OnShowReconnectableGames;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeFieldInfoPtr_gameEntries;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_Event_ReconnectToGame_Public_Void_DataComposition_0;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr_Event_Refresh_Public_Virtual_New_Void_0;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr_Event_Resign_Public_Void_DataComposition_0;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeMethodInfoPtr_Event_ViewResults_Public_Void_DataComposition_0;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeMethodInfoPtr_ShowGameResults_Protected_IEnumerator_DataComposition_0;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeMethodInfoPtr_getViewGameResultsCommand_Protected_Virtual_New_Command_DBGGameResults_0;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeMethodInfoPtr_OnGotReconnectableGames_Protected_Virtual_New_Void_GetReconnectableGames_0;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeMethodInfoPtr__Event_Refresh_b__14_0_Private_Void_0;

		// Token: 0x020003BB RID: 955
		public class OrderedGameEntry : global::Il2CppSystem.Object
		{
			// Token: 0x06002C7A RID: 11386 RVA: 0x000AD738 File Offset: 0x000AB938
			// Note: this type is marked as 'beforefieldinit'.
			static OrderedGameEntry()
			{
				Il2CppClassPointerStore<ContinueGamePromptBehaviour.OrderedGameEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, "OrderedGameEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinueGamePromptBehaviour.OrderedGameEntry>.NativeClassPtr);
				ContinueGamePromptBehaviour.OrderedGameEntry.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour.OrderedGameEntry>.NativeClassPtr, "gameID");
				ContinueGamePromptBehaviour.OrderedGameEntry.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour.OrderedGameEntry>.NativeClassPtr, "data");
				ContinueGamePromptBehaviour.OrderedGameEntry.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour.OrderedGameEntry>.NativeClassPtr, "provider");
				ContinueGamePromptBehaviour.OrderedGameEntry.NativeMethodInfoPtr__ctor_Public_Void_GameID_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour.OrderedGameEntry>.NativeClassPtr, 100666384);
				ContinueGamePromptBehaviour.OrderedGameEntry.NativeMethodInfoPtr_Compare_Public_Static_Int32_OrderedGameEntry_OrderedGameEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour.OrderedGameEntry>.NativeClassPtr, 100666385);
			}

			// Token: 0x06002C7B RID: 11387 RVA: 0x000AD7C8 File Offset: 0x000AB9C8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OrderedGameEntry(GameID gameID, DataComposition data)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinueGamePromptBehaviour.OrderedGameEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour.OrderedGameEntry.NativeMethodInfoPtr__ctor_Public_Void_GameID_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C7C RID: 11388 RVA: 0x000AD828 File Offset: 0x000ABA28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521550, XrefRangeEnd = 521565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int Compare(ContinueGamePromptBehaviour.OrderedGameEntry a, ContinueGamePromptBehaviour.OrderedGameEntry b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour.OrderedGameEntry.NativeMethodInfoPtr_Compare_Public_Static_Int32_OrderedGameEntry_OrderedGameEntry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002C7D RID: 11389 RVA: 0x00016FEB File Offset: 0x000151EB
			public OrderedGameEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C9A RID: 3226
			// (get) Token: 0x06002C7E RID: 11390 RVA: 0x000AD87C File Offset: 0x000ABA7C
			// (set) Token: 0x06002C7F RID: 11391 RVA: 0x00016FF4 File Offset: 0x000151F4
			public unsafe GameID gameID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.OrderedGameEntry.NativeFieldInfoPtr_gameID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.OrderedGameEntry.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C9B RID: 3227
			// (get) Token: 0x06002C80 RID: 11392 RVA: 0x000AD8AC File Offset: 0x000ABAAC
			// (set) Token: 0x06002C81 RID: 11393 RVA: 0x00017013 File Offset: 0x00015213
			public unsafe DataComposition data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.OrderedGameEntry.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.OrderedGameEntry.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C9C RID: 3228
			// (get) Token: 0x06002C82 RID: 11394 RVA: 0x000AD8DC File Offset: 0x000ABADC
			// (set) Token: 0x06002C83 RID: 11395 RVA: 0x00017032 File Offset: 0x00015232
			public unsafe SubscriptionProvider provider
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.OrderedGameEntry.NativeFieldInfoPtr_provider);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.OrderedGameEntry.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BA2 RID: 7074
			private static readonly IntPtr NativeFieldInfoPtr_gameID;

			// Token: 0x04001BA3 RID: 7075
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04001BA4 RID: 7076
			private static readonly IntPtr NativeFieldInfoPtr_provider;

			// Token: 0x04001BA5 RID: 7077
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_DataComposition_0;

			// Token: 0x04001BA6 RID: 7078
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_OrderedGameEntry_OrderedGameEntry_0;
		}

		// Token: 0x020003BC RID: 956
		[ObfuscatedName("boardgames.menus.prompts.ContinueGamePromptBehaviour+<>O")]
		public static class __O : global::Il2CppSystem.Object
		{
			// Token: 0x06002C84 RID: 11396 RVA: 0x00017051 File Offset: 0x00015251
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<ContinueGamePromptBehaviour.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__O>.NativeClassPtr);
				ContinueGamePromptBehaviour.__O.NativeFieldInfoPtr__0___Compare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__O>.NativeClassPtr, "<0>__Compare");
			}

			// Token: 0x06002C85 RID: 11397 RVA: 0x00017085 File Offset: 0x00015285
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C9D RID: 3229
			// (get) Token: 0x06002C86 RID: 11398 RVA: 0x000AD90C File Offset: 0x000ABB0C
			// (set) Token: 0x06002C87 RID: 11399 RVA: 0x0001708E File Offset: 0x0001528E
			public unsafe static Comparison<ContinueGamePromptBehaviour.OrderedGameEntry> _0___Compare
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ContinueGamePromptBehaviour.__O.NativeFieldInfoPtr__0___Compare, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ContinueGamePromptBehaviour.OrderedGameEntry>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ContinueGamePromptBehaviour.__O.NativeFieldInfoPtr__0___Compare, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BA7 RID: 7079
			private static readonly IntPtr NativeFieldInfoPtr__0___Compare;
		}

		// Token: 0x020003BD RID: 957
		[ObfuscatedName("boardgames.menus.prompts.ContinueGamePromptBehaviour+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002C88 RID: 11400 RVA: 0x000AD934 File Offset: 0x000ABB34
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c>.NativeClassPtr);
				ContinueGamePromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c>.NativeClassPtr, "<>9");
				ContinueGamePromptBehaviour.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c>.NativeClassPtr, "<>9__13_0");
				ContinueGamePromptBehaviour.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c>.NativeClassPtr, "<>9__19_0");
				ContinueGamePromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c>.NativeClassPtr, 100666387);
				ContinueGamePromptBehaviour.__c.NativeMethodInfoPtr__Event_ReconnectToGame_b__13_0_Internal_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c>.NativeClassPtr, 100666388);
				ContinueGamePromptBehaviour.__c.NativeMethodInfoPtr__OnGotReconnectableGames_b__19_0_Internal_Boolean_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c>.NativeClassPtr, 100666389);
			}

			// Token: 0x06002C89 RID: 11401 RVA: 0x000AD9D8 File Offset: 0x000ABBD8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C8A RID: 11402 RVA: 0x000ADA14 File Offset: 0x000ABC14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521565, XrefRangeEnd = 521598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Event_ReconnectToGame_b__13_0(ErrorInfo _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour.__c.NativeMethodInfoPtr__Event_ReconnectToGame_b__13_0_Internal_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C8B RID: 11403 RVA: 0x000ADA5C File Offset: 0x000ABC5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521598, XrefRangeEnd = 521607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnGotReconnectableGames_b__19_0(SaveMetaData game)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(game);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour.__c.NativeMethodInfoPtr__OnGotReconnectableGames_b__19_0_Internal_Boolean_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C8C RID: 11404 RVA: 0x000170A0 File Offset: 0x000152A0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C9E RID: 3230
			// (get) Token: 0x06002C8D RID: 11405 RVA: 0x000ADAAC File Offset: 0x000ABCAC
			// (set) Token: 0x06002C8E RID: 11406 RVA: 0x000170A9 File Offset: 0x000152A9
			public unsafe static ContinueGamePromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ContinueGamePromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContinueGamePromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ContinueGamePromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C9F RID: 3231
			// (get) Token: 0x06002C8F RID: 11407 RVA: 0x000ADAD4 File Offset: 0x000ABCD4
			// (set) Token: 0x06002C90 RID: 11408 RVA: 0x000170BB File Offset: 0x000152BB
			public unsafe static Action<ErrorInfo> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ContinueGamePromptBehaviour.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ContinueGamePromptBehaviour.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CA0 RID: 3232
			// (get) Token: 0x06002C91 RID: 11409 RVA: 0x000ADAFC File Offset: 0x000ABCFC
			// (set) Token: 0x06002C92 RID: 11410 RVA: 0x000170CD File Offset: 0x000152CD
			public unsafe static Func<SaveMetaData, bool> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ContinueGamePromptBehaviour.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SaveMetaData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ContinueGamePromptBehaviour.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BA8 RID: 7080
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001BA9 RID: 7081
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04001BAA RID: 7082
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x04001BAB RID: 7083
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001BAC RID: 7084
			private static readonly IntPtr NativeMethodInfoPtr__Event_ReconnectToGame_b__13_0_Internal_Void_ErrorInfo_0;

			// Token: 0x04001BAD RID: 7085
			private static readonly IntPtr NativeMethodInfoPtr__OnGotReconnectableGames_b__19_0_Internal_Boolean_SaveMetaData_0;
		}

		// Token: 0x020003BE RID: 958
		[ObfuscatedName("boardgames.menus.prompts.ContinueGamePromptBehaviour+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002C93 RID: 11411 RVA: 0x000ADB24 File Offset: 0x000ABD24
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr);
				ContinueGamePromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr, "choice");
				ContinueGamePromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr, "data");
				ContinueGamePromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				ContinueGamePromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr, "<>9__1");
				ContinueGamePromptBehaviour.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr, 100666390);
				ContinueGamePromptBehaviour.__c__DisplayClass15_0.NativeMethodInfoPtr__Event_Resign_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr, 100666391);
				ContinueGamePromptBehaviour.__c__DisplayClass15_0.NativeMethodInfoPtr__Event_Resign_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr, 100666392);
			}

			// Token: 0x06002C94 RID: 11412 RVA: 0x000ADBDC File Offset: 0x000ABDDC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C95 RID: 11413 RVA: 0x000ADC18 File Offset: 0x000ABE18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521607, XrefRangeEnd = 521624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Event_Resign_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour.__c__DisplayClass15_0.NativeMethodInfoPtr__Event_Resign_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C96 RID: 11414 RVA: 0x000ADC4C File Offset: 0x000ABE4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521624, XrefRangeEnd = 521626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Event_Resign_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour.__c__DisplayClass15_0.NativeMethodInfoPtr__Event_Resign_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C97 RID: 11415 RVA: 0x000170DF File Offset: 0x000152DF
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CA1 RID: 3233
			// (get) Token: 0x06002C98 RID: 11416 RVA: 0x000ADC80 File Offset: 0x000ABE80
			// (set) Token: 0x06002C99 RID: 11417 RVA: 0x000170E8 File Offset: 0x000152E8
			public unsafe ConfirmOrDenyPrompt choice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr_choice);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr_choice), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CA2 RID: 3234
			// (get) Token: 0x06002C9A RID: 11418 RVA: 0x000ADCB0 File Offset: 0x000ABEB0
			// (set) Token: 0x06002C9B RID: 11419 RVA: 0x00017107 File Offset: 0x00015307
			public unsafe DataComposition data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CA3 RID: 3235
			// (get) Token: 0x06002C9C RID: 11420 RVA: 0x000ADCE0 File Offset: 0x000ABEE0
			// (set) Token: 0x06002C9D RID: 11421 RVA: 0x00017126 File Offset: 0x00015326
			public unsafe ContinueGamePromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContinueGamePromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CA4 RID: 3236
			// (get) Token: 0x06002C9E RID: 11422 RVA: 0x000ADD10 File Offset: 0x000ABF10
			// (set) Token: 0x06002C9F RID: 11423 RVA: 0x00017145 File Offset: 0x00015345
			public unsafe Action __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BAE RID: 7086
			private static readonly IntPtr NativeFieldInfoPtr_choice;

			// Token: 0x04001BAF RID: 7087
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04001BB0 RID: 7088
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001BB1 RID: 7089
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04001BB2 RID: 7090
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001BB3 RID: 7091
			private static readonly IntPtr NativeMethodInfoPtr__Event_Resign_b__0_Internal_Void_0;

			// Token: 0x04001BB4 RID: 7092
			private static readonly IntPtr NativeMethodInfoPtr__Event_Resign_b__1_Internal_Void_0;
		}

		// Token: 0x020003BF RID: 959
		[ObfuscatedName("boardgames.menus.prompts.ContinueGamePromptBehaviour+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002CA0 RID: 11424 RVA: 0x000ADD40 File Offset: 0x000ABF40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c__DisplayClass17_0>.NativeClassPtr);
				ContinueGamePromptBehaviour.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				ContinueGamePromptBehaviour.__c__DisplayClass17_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c__DisplayClass17_0>.NativeClassPtr, "data");
				ContinueGamePromptBehaviour.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c__DisplayClass17_0>.NativeClassPtr, 100666393);
				ContinueGamePromptBehaviour.__c__DisplayClass17_0.NativeMethodInfoPtr__ShowGameResults_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c__DisplayClass17_0>.NativeClassPtr, 100666394);
			}

			// Token: 0x06002CA1 RID: 11425 RVA: 0x000ADDBC File Offset: 0x000ABFBC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinueGamePromptBehaviour.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CA2 RID: 11426 RVA: 0x000ADDF8 File Offset: 0x000ABFF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521626, XrefRangeEnd = 521628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowGameResults_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour.__c__DisplayClass17_0.NativeMethodInfoPtr__ShowGameResults_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CA3 RID: 11427 RVA: 0x00017164 File Offset: 0x00015364
			public __c__DisplayClass17_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CA5 RID: 3237
			// (get) Token: 0x06002CA4 RID: 11428 RVA: 0x000ADE2C File Offset: 0x000AC02C
			// (set) Token: 0x06002CA5 RID: 11429 RVA: 0x0001716D File Offset: 0x0001536D
			public unsafe ContinueGamePromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContinueGamePromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CA6 RID: 3238
			// (get) Token: 0x06002CA6 RID: 11430 RVA: 0x000ADE5C File Offset: 0x000AC05C
			// (set) Token: 0x06002CA7 RID: 11431 RVA: 0x0001718C File Offset: 0x0001538C
			public unsafe DataComposition data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.__c__DisplayClass17_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour.__c__DisplayClass17_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BB5 RID: 7093
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001BB6 RID: 7094
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04001BB7 RID: 7095
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001BB8 RID: 7096
			private static readonly IntPtr NativeMethodInfoPtr__ShowGameResults_b__0_Internal_Void_0;
		}

		// Token: 0x020003C0 RID: 960
		[ObfuscatedName("boardgames.menus.prompts.ContinueGamePromptBehaviour+<ShowGameResults>d__17")]
		public sealed class _ShowGameResults_d__17 : global::Il2CppSystem.Object
		{
			// Token: 0x06002CA8 RID: 11432 RVA: 0x000ADE8C File Offset: 0x000AC08C
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowGameResults_d__17()
			{
				Il2CppClassPointerStore<ContinueGamePromptBehaviour._ShowGameResults_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContinueGamePromptBehaviour>.NativeClassPtr, "<ShowGameResults>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinueGamePromptBehaviour._ShowGameResults_d__17>.NativeClassPtr);
				ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour._ShowGameResults_d__17>.NativeClassPtr, "<>1__state");
				ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour._ShowGameResults_d__17>.NativeClassPtr, "<>2__current");
				ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour._ShowGameResults_d__17>.NativeClassPtr, "<>4__this");
				ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour._ShowGameResults_d__17>.NativeClassPtr, "data");
				ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour._ShowGameResults_d__17>.NativeClassPtr, "<>8__1");
				ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr__gameID_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour._ShowGameResults_d__17>.NativeClassPtr, "<gameID>5__2");
				ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr__getGameResultsDataCommand_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePromptBehaviour._ShowGameResults_d__17>.NativeClassPtr, "<getGameResultsDataCommand>5__3");
				ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour._ShowGameResults_d__17>.NativeClassPtr, 100666395);
				ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour._ShowGameResults_d__17>.NativeClassPtr, 100666396);
				ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour._ShowGameResults_d__17>.NativeClassPtr, 100666397);
				ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour._ShowGameResults_d__17>.NativeClassPtr, 100666398);
				ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour._ShowGameResults_d__17>.NativeClassPtr, 100666399);
				ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePromptBehaviour._ShowGameResults_d__17>.NativeClassPtr, 100666400);
			}

			// Token: 0x06002CA9 RID: 11433 RVA: 0x000ADFBC File Offset: 0x000AC1BC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowGameResults_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinueGamePromptBehaviour._ShowGameResults_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002CAA RID: 11434 RVA: 0x000AE004 File Offset: 0x000AC204
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CAB RID: 11435 RVA: 0x000AE038 File Offset: 0x000AC238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521628, XrefRangeEnd = 521650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CAE RID: 3246
			// (get) Token: 0x06002CAC RID: 11436 RVA: 0x000AE074 File Offset: 0x000AC274
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002CAD RID: 11437 RVA: 0x000AE0B4 File Offset: 0x000AC2B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521650, XrefRangeEnd = 521655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CAF RID: 3247
			// (get) Token: 0x06002CAE RID: 11438 RVA: 0x000AE0E8 File Offset: 0x000AC2E8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002CAF RID: 11439 RVA: 0x000171AB File Offset: 0x000153AB
			public _ShowGameResults_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CA7 RID: 3239
			// (get) Token: 0x06002CB0 RID: 11440 RVA: 0x000AE128 File Offset: 0x000AC328
			// (set) Token: 0x06002CB1 RID: 11441 RVA: 0x000171B4 File Offset: 0x000153B4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CA8 RID: 3240
			// (get) Token: 0x06002CB2 RID: 11442 RVA: 0x000AE150 File Offset: 0x000AC350
			// (set) Token: 0x06002CB3 RID: 11443 RVA: 0x000171CF File Offset: 0x000153CF
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CA9 RID: 3241
			// (get) Token: 0x06002CB4 RID: 11444 RVA: 0x000AE180 File Offset: 0x000AC380
			// (set) Token: 0x06002CB5 RID: 11445 RVA: 0x000171EE File Offset: 0x000153EE
			public unsafe ContinueGamePromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContinueGamePromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CAA RID: 3242
			// (get) Token: 0x06002CB6 RID: 11446 RVA: 0x000AE1B0 File Offset: 0x000AC3B0
			// (set) Token: 0x06002CB7 RID: 11447 RVA: 0x0001720D File Offset: 0x0001540D
			public unsafe DataComposition data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CAB RID: 3243
			// (get) Token: 0x06002CB8 RID: 11448 RVA: 0x000AE1E0 File Offset: 0x000AC3E0
			// (set) Token: 0x06002CB9 RID: 11449 RVA: 0x0001722C File Offset: 0x0001542C
			public unsafe ContinueGamePromptBehaviour.__c__DisplayClass17_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContinueGamePromptBehaviour.__c__DisplayClass17_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CAC RID: 3244
			// (get) Token: 0x06002CBA RID: 11450 RVA: 0x000AE210 File Offset: 0x000AC410
			// (set) Token: 0x06002CBB RID: 11451 RVA: 0x0001724B File Offset: 0x0001544B
			public unsafe GameID _gameID_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr__gameID_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr__gameID_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CAD RID: 3245
			// (get) Token: 0x06002CBC RID: 11452 RVA: 0x000AE240 File Offset: 0x000AC440
			// (set) Token: 0x06002CBD RID: 11453 RVA: 0x0001726A File Offset: 0x0001546A
			public unsafe IGetGameResultsDataCommand _getGameResultsDataCommand_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr__getGameResultsDataCommand_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGetGameResultsDataCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePromptBehaviour._ShowGameResults_d__17.NativeFieldInfoPtr__getGameResultsDataCommand_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BB9 RID: 7097
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001BBA RID: 7098
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001BBB RID: 7099
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001BBC RID: 7100
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04001BBD RID: 7101
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04001BBE RID: 7102
			private static readonly IntPtr NativeFieldInfoPtr__gameID_5__2;

			// Token: 0x04001BBF RID: 7103
			private static readonly IntPtr NativeFieldInfoPtr__getGameResultsDataCommand_5__3;

			// Token: 0x04001BC0 RID: 7104
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001BC1 RID: 7105
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BC2 RID: 7106
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001BC3 RID: 7107
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001BC4 RID: 7108
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BC5 RID: 7109
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
