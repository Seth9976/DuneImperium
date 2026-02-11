using System;
using boardgames.menus.prompts.behaviours;
using dbgclient.menus.commands;
using dwd.core.data.composition;
using dwd.core.platform.providers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;

namespace lib.canis.dbg_client.prompts.behaviours
{
	// Token: 0x02000037 RID: 55
	public class DailyChallengeLeaderboardPromptBehaviour : LeaderboardPromptBehaviour
	{
		// Token: 0x06000227 RID: 551 RVA: 0x0002471C File Offset: 0x0002291C
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeLeaderboardPromptBehaviour()
		{
			Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.dbg_client.prompts.behaviours", "DailyChallengeLeaderboardPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr);
			DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_headerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, "headerText");
			DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, "currentPlayerDisplay");
			DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerEntryRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, "currentPlayerEntryRoot");
			DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_topHundredSeperator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, "topHundredSeperator");
			DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_displayLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, "displayLimit");
			DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_platformProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, "platformProvider");
			DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_sortOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, "sortOrder");
			DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, "currentPlayerView");
			DailyChallengeLeaderboardPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, 100663636);
			DailyChallengeLeaderboardPromptBehaviour.NativeMethodInfoPtr_UpdateDisplay_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, 100663637);
			DailyChallengeLeaderboardPromptBehaviour.NativeMethodInfoPtr_UpdateFriendsToggle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, 100663638);
			DailyChallengeLeaderboardPromptBehaviour.NativeMethodInfoPtr_FetchAndUpdateDisplay_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, 100663639);
			DailyChallengeLeaderboardPromptBehaviour.NativeMethodInfoPtr_ShowLeaderboardData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, 100663640);
			DailyChallengeLeaderboardPromptBehaviour.NativeMethodInfoPtr_delaySetSeperatorPosition_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, 100663641);
			DailyChallengeLeaderboardPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, 100663642);
			DailyChallengeLeaderboardPromptBehaviour.NativeMethodInfoPtr_Event_ToggleSortOrder_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, 100663643);
			DailyChallengeLeaderboardPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, 100663644);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000248A0 File Offset: 0x00022AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498114, XrefRangeEnd = 498136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeLeaderboardPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000248DC File Offset: 0x00022ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498136, XrefRangeEnd = 498143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateDisplay(bool friends)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref friends;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeLeaderboardPromptBehaviour.NativeMethodInfoPtr_UpdateDisplay_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00024928 File Offset: 0x00022B28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 498152, RefRangeEnd = 498154, XrefRangeStart = 498143, XrefRangeEnd = 498152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFriendsToggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour.NativeMethodInfoPtr_UpdateFriendsToggle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0002495C File Offset: 0x00022B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498154, XrefRangeEnd = 498159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FetchAndUpdateDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour.NativeMethodInfoPtr_FetchAndUpdateDisplay_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0002499C File Offset: 0x00022B9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 498232, RefRangeEnd = 498234, XrefRangeStart = 498159, XrefRangeEnd = 498232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowLeaderboardData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour.NativeMethodInfoPtr_ShowLeaderboardData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000249D0 File Offset: 0x00022BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498234, XrefRangeEnd = 498239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator delaySetSeperatorPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour.NativeMethodInfoPtr_delaySetSeperatorPosition_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00024A10 File Offset: 0x00022C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498239, XrefRangeEnd = 498244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00024A44 File Offset: 0x00022C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498244, XrefRangeEnd = 498245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleSortOrder(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour.NativeMethodInfoPtr_Event_ToggleSortOrder_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00024A84 File Offset: 0x00022C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498245, XrefRangeEnd = 498246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeLeaderboardPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002EB1 File Offset: 0x000010B1
		public DailyChallengeLeaderboardPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00024AC0 File Offset: 0x00022CC0
		// (set) Token: 0x06000233 RID: 563 RVA: 0x00002EBA File Offset: 0x000010BA
		public unsafe TMP_Text headerText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_headerText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_headerText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00024AF0 File Offset: 0x00022CF0
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00002ED9 File Offset: 0x000010D9
		public unsafe GameObject currentPlayerDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00024B20 File Offset: 0x00022D20
		// (set) Token: 0x06000237 RID: 567 RVA: 0x00002EF8 File Offset: 0x000010F8
		public unsafe Transform currentPlayerEntryRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerEntryRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerEntryRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00024B50 File Offset: 0x00022D50
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00002F17 File Offset: 0x00001117
		public unsafe GameObject topHundredSeperator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_topHundredSeperator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_topHundredSeperator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00024B80 File Offset: 0x00022D80
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00002F36 File Offset: 0x00001136
		public unsafe int displayLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_displayLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_displayLimit)) = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00024BA8 File Offset: 0x00022DA8
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00002F51 File Offset: 0x00001151
		public unsafe PlatformProvider platformProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_platformProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_platformProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00024BD8 File Offset: 0x00022DD8
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00002F70 File Offset: 0x00001170
		public unsafe FetchDailyChallengeLeaderboard.SortMode sortOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_sortOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_sortOrder)) = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00024C00 File Offset: 0x00022E00
		// (set) Token: 0x06000241 RID: 577 RVA: 0x00002F8B File Offset: 0x0000118B
		public unsafe SubscriptionProvider currentPlayerView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_headerText;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_currentPlayerDisplay;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeFieldInfoPtr_currentPlayerEntryRoot;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeFieldInfoPtr_topHundredSeperator;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeFieldInfoPtr_displayLimit;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeFieldInfoPtr_platformProvider;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr_sortOrder;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr_currentPlayerView;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplay_Protected_Virtual_Void_Boolean_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFriendsToggle_Private_Void_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_FetchAndUpdateDisplay_Private_IEnumerator_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_ShowLeaderboardData_Private_Void_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_delaySetSeperatorPosition_Private_IEnumerator_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_Event_Dismiss_Public_Void_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleSortOrder_Public_Void_Boolean_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002DA RID: 730
		[ObfuscatedName("lib.canis.dbg_client.prompts.behaviours.DailyChallengeLeaderboardPromptBehaviour+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600224D RID: 8781 RVA: 0x0008F1B8 File Offset: 0x0008D3B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour.__c>.NativeClassPtr);
				DailyChallengeLeaderboardPromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour.__c>.NativeClassPtr, "<>9");
				DailyChallengeLeaderboardPromptBehaviour.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour.__c>.NativeClassPtr, "<>9__12_0");
				DailyChallengeLeaderboardPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour.__c>.NativeClassPtr, 100663646);
				DailyChallengeLeaderboardPromptBehaviour.__c.NativeMethodInfoPtr__ShowLeaderboardData_b__12_0_Internal_Boolean_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour.__c>.NativeClassPtr, 100663647);
			}

			// Token: 0x0600224E RID: 8782 RVA: 0x0008F234 File Offset: 0x0008D434
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600224F RID: 8783 RVA: 0x0008F270 File Offset: 0x0008D470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498060, XrefRangeEnd = 498063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ShowLeaderboardData_b__12_0(DataComposition d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour.__c.NativeMethodInfoPtr__ShowLeaderboardData_b__12_0_Internal_Boolean_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002250 RID: 8784 RVA: 0x00011E48 File Offset: 0x00010048
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000937 RID: 2359
			// (get) Token: 0x06002251 RID: 8785 RVA: 0x0008F2C0 File Offset: 0x0008D4C0
			// (set) Token: 0x06002252 RID: 8786 RVA: 0x00011E51 File Offset: 0x00010051
			public unsafe static DailyChallengeLeaderboardPromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DailyChallengeLeaderboardPromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyChallengeLeaderboardPromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DailyChallengeLeaderboardPromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000938 RID: 2360
			// (get) Token: 0x06002253 RID: 8787 RVA: 0x0008F2E8 File Offset: 0x0008D4E8
			// (set) Token: 0x06002254 RID: 8788 RVA: 0x00011E63 File Offset: 0x00010063
			public unsafe static Func<DataComposition, bool> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DailyChallengeLeaderboardPromptBehaviour.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataComposition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DailyChallengeLeaderboardPromptBehaviour.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001596 RID: 5526
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001597 RID: 5527
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04001598 RID: 5528
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001599 RID: 5529
			private static readonly IntPtr NativeMethodInfoPtr__ShowLeaderboardData_b__12_0_Internal_Boolean_DataComposition_0;
		}

		// Token: 0x020002DB RID: 731
		[ObfuscatedName("lib.canis.dbg_client.prompts.behaviours.DailyChallengeLeaderboardPromptBehaviour+<FetchAndUpdateDisplay>d__11")]
		public sealed class _FetchAndUpdateDisplay_d__11 : global::Il2CppSystem.Object
		{
			// Token: 0x06002255 RID: 8789 RVA: 0x0008F310 File Offset: 0x0008D510
			// Note: this type is marked as 'beforefieldinit'.
			static _FetchAndUpdateDisplay_d__11()
			{
				Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, "<FetchAndUpdateDisplay>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11>.NativeClassPtr);
				DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11>.NativeClassPtr, "<>1__state");
				DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11>.NativeClassPtr, "<>2__current");
				DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11>.NativeClassPtr, "<>4__this");
				DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeFieldInfoPtr__loadCommand_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11>.NativeClassPtr, "<loadCommand>5__2");
				DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11>.NativeClassPtr, 100663648);
				DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11>.NativeClassPtr, 100663649);
				DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11>.NativeClassPtr, 100663650);
				DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11>.NativeClassPtr, 100663651);
				DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11>.NativeClassPtr, 100663652);
				DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11>.NativeClassPtr, 100663653);
			}

			// Token: 0x06002256 RID: 8790 RVA: 0x0008F404 File Offset: 0x0008D604
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FetchAndUpdateDisplay_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002257 RID: 8791 RVA: 0x0008F44C File Offset: 0x0008D64C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002258 RID: 8792 RVA: 0x0008F480 File Offset: 0x0008D680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498063, XrefRangeEnd = 498099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700093D RID: 2365
			// (get) Token: 0x06002259 RID: 8793 RVA: 0x0008F4BC File Offset: 0x0008D6BC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600225A RID: 8794 RVA: 0x0008F4FC File Offset: 0x0008D6FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498099, XrefRangeEnd = 498104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700093E RID: 2366
			// (get) Token: 0x0600225B RID: 8795 RVA: 0x0008F530 File Offset: 0x0008D730
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600225C RID: 8796 RVA: 0x00011E75 File Offset: 0x00010075
			public _FetchAndUpdateDisplay_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000939 RID: 2361
			// (get) Token: 0x0600225D RID: 8797 RVA: 0x0008F570 File Offset: 0x0008D770
			// (set) Token: 0x0600225E RID: 8798 RVA: 0x00011E7E File Offset: 0x0001007E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700093A RID: 2362
			// (get) Token: 0x0600225F RID: 8799 RVA: 0x0008F598 File Offset: 0x0008D798
			// (set) Token: 0x06002260 RID: 8800 RVA: 0x00011E99 File Offset: 0x00010099
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700093B RID: 2363
			// (get) Token: 0x06002261 RID: 8801 RVA: 0x0008F5C8 File Offset: 0x0008D7C8
			// (set) Token: 0x06002262 RID: 8802 RVA: 0x00011EB8 File Offset: 0x000100B8
			public unsafe DailyChallengeLeaderboardPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyChallengeLeaderboardPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700093C RID: 2364
			// (get) Token: 0x06002263 RID: 8803 RVA: 0x0008F5F8 File Offset: 0x0008D7F8
			// (set) Token: 0x06002264 RID: 8804 RVA: 0x00011ED7 File Offset: 0x000100D7
			public unsafe LoadDailyChallengeLeaderboards _loadCommand_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeFieldInfoPtr__loadCommand_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadDailyChallengeLeaderboards>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour._FetchAndUpdateDisplay_d__11.NativeFieldInfoPtr__loadCommand_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400159A RID: 5530
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400159B RID: 5531
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400159C RID: 5532
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400159D RID: 5533
			private static readonly IntPtr NativeFieldInfoPtr__loadCommand_5__2;

			// Token: 0x0400159E RID: 5534
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400159F RID: 5535
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015A0 RID: 5536
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040015A1 RID: 5537
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040015A2 RID: 5538
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015A3 RID: 5539
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002DC RID: 732
		[ObfuscatedName("lib.canis.dbg_client.prompts.behaviours.DailyChallengeLeaderboardPromptBehaviour+<delaySetSeperatorPosition>d__13")]
		public sealed class _delaySetSeperatorPosition_d__13 : global::Il2CppSystem.Object
		{
			// Token: 0x06002265 RID: 8805 RVA: 0x0008F628 File Offset: 0x0008D828
			// Note: this type is marked as 'beforefieldinit'.
			static _delaySetSeperatorPosition_d__13()
			{
				Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour>.NativeClassPtr, "<delaySetSeperatorPosition>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13>.NativeClassPtr);
				DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13>.NativeClassPtr, "<>1__state");
				DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13>.NativeClassPtr, "<>2__current");
				DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13>.NativeClassPtr, "<>4__this");
				DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13>.NativeClassPtr, 100663654);
				DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13>.NativeClassPtr, 100663655);
				DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13>.NativeClassPtr, 100663656);
				DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13>.NativeClassPtr, 100663657);
				DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13>.NativeClassPtr, 100663658);
				DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13>.NativeClassPtr, 100663659);
			}

			// Token: 0x06002266 RID: 8806 RVA: 0x0008F708 File Offset: 0x0008D908
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _delaySetSeperatorPosition_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002267 RID: 8807 RVA: 0x0008F750 File Offset: 0x0008D950
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002268 RID: 8808 RVA: 0x0008F784 File Offset: 0x0008D984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498104, XrefRangeEnd = 498109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000942 RID: 2370
			// (get) Token: 0x06002269 RID: 8809 RVA: 0x0008F7C0 File Offset: 0x0008D9C0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600226A RID: 8810 RVA: 0x0008F800 File Offset: 0x0008DA00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498109, XrefRangeEnd = 498114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000943 RID: 2371
			// (get) Token: 0x0600226B RID: 8811 RVA: 0x0008F834 File Offset: 0x0008DA34
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600226C RID: 8812 RVA: 0x00011EF6 File Offset: 0x000100F6
			public _delaySetSeperatorPosition_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700093F RID: 2367
			// (get) Token: 0x0600226D RID: 8813 RVA: 0x0008F874 File Offset: 0x0008DA74
			// (set) Token: 0x0600226E RID: 8814 RVA: 0x00011EFF File Offset: 0x000100FF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000940 RID: 2368
			// (get) Token: 0x0600226F RID: 8815 RVA: 0x0008F89C File Offset: 0x0008DA9C
			// (set) Token: 0x06002270 RID: 8816 RVA: 0x00011F1A File Offset: 0x0001011A
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000941 RID: 2369
			// (get) Token: 0x06002271 RID: 8817 RVA: 0x0008F8CC File Offset: 0x0008DACC
			// (set) Token: 0x06002272 RID: 8818 RVA: 0x00011F39 File Offset: 0x00010139
			public unsafe DailyChallengeLeaderboardPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyChallengeLeaderboardPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardPromptBehaviour._delaySetSeperatorPosition_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015A4 RID: 5540
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015A5 RID: 5541
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040015A6 RID: 5542
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015A7 RID: 5543
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040015A8 RID: 5544
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015A9 RID: 5545
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040015AA RID: 5546
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040015AB RID: 5547
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015AC RID: 5548
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
