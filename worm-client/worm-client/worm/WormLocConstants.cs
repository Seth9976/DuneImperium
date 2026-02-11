using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace worm
{
	// Token: 0x02000037 RID: 55
	public static class WormLocConstants : Object
	{
		// Token: 0x06000265 RID: 613 RVA: 0x0002074C File Offset: 0x0001E94C
		// Note: this type is marked as 'beforefieldinit'.
		static WormLocConstants()
		{
			Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormLocConstants");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr);
			WormLocConstants.NativeFieldInfoPtr_ConfirmResignRanked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "ConfirmResignRanked");
			WormLocConstants.NativeFieldInfoPtr_ConfirmResignRankedWithRepLoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "ConfirmResignRankedWithRepLoss");
			WormLocConstants.NativeFieldInfoPtr_ConfirmResignOnline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "ConfirmResignOnline");
			WormLocConstants.NativeFieldInfoPtr_ConfirmResignOnlineNoRepLoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "ConfirmResignOnlineNoRepLoss");
			WormLocConstants.NativeFieldInfoPtr_YourTurnHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "YourTurnHeader");
			WormLocConstants.NativeFieldInfoPtr_SelectLeaderHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "SelectLeaderHeader");
			WormLocConstants.NativeFieldInfoPtr_SelectOpponentHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "SelectOpponentHeader");
			WormLocConstants.NativeFieldInfoPtr_SelectTrashCardHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "SelectTrashCardHeader");
			WormLocConstants.NativeFieldInfoPtr_SelectDiscardCardHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "SelectDiscardCardHeader");
			WormLocConstants.NativeFieldInfoPtr_SelectFactionHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "SelectFactionHeader");
			WormLocConstants.NativeFieldInfoPtr_SelectMasterstrokeFactionsHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "SelectMasterstrokeFactionsHeader");
			WormLocConstants.NativeFieldInfoPtr_OtherMemoryHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "OtherMemoryHeader");
			WormLocConstants.NativeFieldInfoPtr_GameResultsVictory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "GameResultsVictory");
			WormLocConstants.NativeFieldInfoPtr_GameResultsDefeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "GameResultsDefeat");
			WormLocConstants.NativeFieldInfoPtr_GameResultsTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "GameResultsTutorial");
			WormLocConstants.NativeFieldInfoPtr_SkirmishRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "SkirmishRules");
			WormLocConstants.NativeFieldInfoPtr_SkirmishSeasonAndGameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "SkirmishSeasonAndGameText");
			WormLocConstants.NativeFieldInfoPtr_SkirmishSeasonClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "SkirmishSeasonClosed");
			WormLocConstants.NativeFieldInfoPtr_SkirmishMatchClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "SkirmishMatchClosed");
			WormLocConstants.NativeFieldInfoPtr_SkirmishSavedGameReminder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "SkirmishSavedGameReminder");
			WormLocConstants.NativeFieldInfoPtr_ResignedForInactivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocConstants>.NativeClassPtr, "ResignedForInactivity");
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00003181 File Offset: 0x00001381
		public WormLocConstants(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00020920 File Offset: 0x0001EB20
		// (set) Token: 0x06000268 RID: 616 RVA: 0x0000318A File Offset: 0x0000138A
		public unsafe static string ConfirmResignRanked
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_ConfirmResignRanked, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_ConfirmResignRanked, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00020940 File Offset: 0x0001EB40
		// (set) Token: 0x0600026A RID: 618 RVA: 0x0000319C File Offset: 0x0000139C
		public unsafe static string ConfirmResignRankedWithRepLoss
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_ConfirmResignRankedWithRepLoss, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_ConfirmResignRankedWithRepLoss, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00020960 File Offset: 0x0001EB60
		// (set) Token: 0x0600026C RID: 620 RVA: 0x000031AE File Offset: 0x000013AE
		public unsafe static string ConfirmResignOnline
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_ConfirmResignOnline, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_ConfirmResignOnline, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00020980 File Offset: 0x0001EB80
		// (set) Token: 0x0600026E RID: 622 RVA: 0x000031C0 File Offset: 0x000013C0
		public unsafe static string ConfirmResignOnlineNoRepLoss
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_ConfirmResignOnlineNoRepLoss, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_ConfirmResignOnlineNoRepLoss, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600026F RID: 623 RVA: 0x000209A0 File Offset: 0x0001EBA0
		// (set) Token: 0x06000270 RID: 624 RVA: 0x000031D2 File Offset: 0x000013D2
		public unsafe static string YourTurnHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_YourTurnHeader, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_YourTurnHeader, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000271 RID: 625 RVA: 0x000209C0 File Offset: 0x0001EBC0
		// (set) Token: 0x06000272 RID: 626 RVA: 0x000031E4 File Offset: 0x000013E4
		public unsafe static string SelectLeaderHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_SelectLeaderHeader, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_SelectLeaderHeader, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000273 RID: 627 RVA: 0x000209E0 File Offset: 0x0001EBE0
		// (set) Token: 0x06000274 RID: 628 RVA: 0x000031F6 File Offset: 0x000013F6
		public unsafe static string SelectOpponentHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_SelectOpponentHeader, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_SelectOpponentHeader, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00020A00 File Offset: 0x0001EC00
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00003208 File Offset: 0x00001408
		public unsafe static string SelectTrashCardHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_SelectTrashCardHeader, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_SelectTrashCardHeader, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00020A20 File Offset: 0x0001EC20
		// (set) Token: 0x06000278 RID: 632 RVA: 0x0000321A File Offset: 0x0000141A
		public unsafe static string SelectDiscardCardHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_SelectDiscardCardHeader, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_SelectDiscardCardHeader, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00020A40 File Offset: 0x0001EC40
		// (set) Token: 0x0600027A RID: 634 RVA: 0x0000322C File Offset: 0x0000142C
		public unsafe static string SelectFactionHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_SelectFactionHeader, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_SelectFactionHeader, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00020A60 File Offset: 0x0001EC60
		// (set) Token: 0x0600027C RID: 636 RVA: 0x0000323E File Offset: 0x0000143E
		public unsafe static string SelectMasterstrokeFactionsHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_SelectMasterstrokeFactionsHeader, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_SelectMasterstrokeFactionsHeader, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00020A80 File Offset: 0x0001EC80
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00003250 File Offset: 0x00001450
		public unsafe static string OtherMemoryHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_OtherMemoryHeader, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_OtherMemoryHeader, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00020AA0 File Offset: 0x0001ECA0
		// (set) Token: 0x06000280 RID: 640 RVA: 0x00003262 File Offset: 0x00001462
		public unsafe static string GameResultsVictory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_GameResultsVictory, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_GameResultsVictory, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00020AC0 File Offset: 0x0001ECC0
		// (set) Token: 0x06000282 RID: 642 RVA: 0x00003274 File Offset: 0x00001474
		public unsafe static string GameResultsDefeat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_GameResultsDefeat, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_GameResultsDefeat, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00020AE0 File Offset: 0x0001ECE0
		// (set) Token: 0x06000284 RID: 644 RVA: 0x00003286 File Offset: 0x00001486
		public unsafe static string GameResultsTutorial
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_GameResultsTutorial, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_GameResultsTutorial, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00020B00 File Offset: 0x0001ED00
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00003298 File Offset: 0x00001498
		public unsafe static string SkirmishRules
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_SkirmishRules, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_SkirmishRules, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00020B20 File Offset: 0x0001ED20
		// (set) Token: 0x06000288 RID: 648 RVA: 0x000032AA File Offset: 0x000014AA
		public unsafe static string SkirmishSeasonAndGameText
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_SkirmishSeasonAndGameText, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_SkirmishSeasonAndGameText, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00020B40 File Offset: 0x0001ED40
		// (set) Token: 0x0600028A RID: 650 RVA: 0x000032BC File Offset: 0x000014BC
		public unsafe static string SkirmishSeasonClosed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_SkirmishSeasonClosed, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_SkirmishSeasonClosed, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00020B60 File Offset: 0x0001ED60
		// (set) Token: 0x0600028C RID: 652 RVA: 0x000032CE File Offset: 0x000014CE
		public unsafe static string SkirmishMatchClosed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_SkirmishMatchClosed, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_SkirmishMatchClosed, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00020B80 File Offset: 0x0001ED80
		// (set) Token: 0x0600028E RID: 654 RVA: 0x000032E0 File Offset: 0x000014E0
		public unsafe static string SkirmishSavedGameReminder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_SkirmishSavedGameReminder, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_SkirmishSavedGameReminder, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00020BA0 File Offset: 0x0001EDA0
		// (set) Token: 0x06000290 RID: 656 RVA: 0x000032F2 File Offset: 0x000014F2
		public unsafe static string ResignedForInactivity
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormLocConstants.NativeFieldInfoPtr_ResignedForInactivity, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLocConstants.NativeFieldInfoPtr_ResignedForInactivity, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmResignRanked;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmResignRankedWithRepLoss;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmResignOnline;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmResignOnlineNoRepLoss;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr_YourTurnHeader;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr_SelectLeaderHeader;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeFieldInfoPtr_SelectOpponentHeader;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeFieldInfoPtr_SelectTrashCardHeader;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeFieldInfoPtr_SelectDiscardCardHeader;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeFieldInfoPtr_SelectFactionHeader;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr_SelectMasterstrokeFactionsHeader;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr_OtherMemoryHeader;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr_GameResultsVictory;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeFieldInfoPtr_GameResultsDefeat;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeFieldInfoPtr_GameResultsTutorial;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeFieldInfoPtr_SkirmishRules;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr_SkirmishSeasonAndGameText;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr_SkirmishSeasonClosed;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr_SkirmishMatchClosed;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeFieldInfoPtr_SkirmishSavedGameReminder;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr_ResignedForInactivity;
	}
}
