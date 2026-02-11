using System;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;

namespace worm.canis.networking
{
	// Token: 0x02000016 RID: 22
	public class WormGameResultsEntry : DBGGameResultsEntry
	{
		// Token: 0x06000131 RID: 305 RVA: 0x0006ED18 File Offset: 0x0006CF18
		// Note: this type is marked as 'beforefieldinit'.
		static WormGameResultsEntry()
		{
			Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.networking", "WormGameResultsEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr);
			WormGameResultsEntry.NativeFieldInfoPtr_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "Score");
			WormGameResultsEntry.NativeFieldInfoPtr_Rounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "Rounds");
			WormGameResultsEntry.NativeFieldInfoPtr_Spice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "Spice");
			WormGameResultsEntry.NativeFieldInfoPtr_Solari = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "Solari");
			WormGameResultsEntry.NativeFieldInfoPtr_Water = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "Water");
			WormGameResultsEntry.NativeFieldInfoPtr_GarrisonTroops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "GarrisonTroops");
			WormGameResultsEntry.NativeFieldInfoPtr_FactionInfluences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "FactionInfluences");
			WormGameResultsEntry.NativeFieldInfoPtr_SpiceMustFlowAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "SpiceMustFlowAcquired");
			WormGameResultsEntry.NativeFieldInfoPtr_MentatsUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "MentatsUsed");
			WormGameResultsEntry.NativeFieldInfoPtr_CombatsWon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "CombatsWon");
			WormGameResultsEntry.NativeFieldInfoPtr_TechAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "TechAcquired");
			WormGameResultsEntry.NativeFieldInfoPtr_Shipments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "Shipments");
			WormGameResultsEntry.NativeFieldInfoPtr_Swordmaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "Swordmaster");
			WormGameResultsEntry.NativeFieldInfoPtr_SwordmasterTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "SwordmasterTurn");
			WormGameResultsEntry.NativeFieldInfoPtr_HighCouncilSeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "HighCouncilSeat");
			WormGameResultsEntry.NativeFieldInfoPtr_HighCouncilSeatTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "HighCouncilSeatTurn");
			WormGameResultsEntry.NativeFieldInfoPtr_Alliances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "Alliances");
			WormGameResultsEntry.NativeFieldInfoPtr_LeaderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "LeaderID");
			WormGameResultsEntry.NativeFieldInfoPtr_AbilityUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "AbilityUsage");
			WormGameResultsEntry.NativeFieldInfoPtr_AdditionalReports = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "AdditionalReports");
			WormGameResultsEntry.NativeFieldInfoPtr_SkirmishScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "SkirmishScore");
			WormGameResultsEntry.NativeFieldInfoPtr_SkirmishRuleMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "SkirmishRuleMods");
			WormGameResultsEntry.NativeFieldInfoPtr_ChaumurkyTechTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "ChaumurkyTechTile");
			WormGameResultsEntry.NativeFieldInfoPtr_PaulAtreidesUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "PaulAtreidesUsed");
			WormGameResultsEntry.NativeFieldInfoPtr_PaulAtreidesWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "PaulAtreidesWins");
			WormGameResultsEntry.NativeFieldInfoPtr_DukeLetoAtreidesUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "DukeLetoAtreidesUsed");
			WormGameResultsEntry.NativeFieldInfoPtr_DukeLetoAtreidesWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "DukeLetoAtreidesWins");
			WormGameResultsEntry.NativeFieldInfoPtr_BaronVladimirHarkonnenUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "BaronVladimirHarkonnenUsed");
			WormGameResultsEntry.NativeFieldInfoPtr_BaronVladimirHarkonnenWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "BaronVladimirHarkonnenWins");
			WormGameResultsEntry.NativeFieldInfoPtr_GlossuTheBeastRabbanUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "GlossuTheBeastRabbanUsed");
			WormGameResultsEntry.NativeFieldInfoPtr_GlossuTheBeastRabbanWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "GlossuTheBeastRabbanWins");
			WormGameResultsEntry.NativeFieldInfoPtr_CountessArianaThorvaldUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "CountessArianaThorvaldUsed");
			WormGameResultsEntry.NativeFieldInfoPtr_CountessArianaThorvaldWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "CountessArianaThorvaldWins");
			WormGameResultsEntry.NativeFieldInfoPtr_EarlMemnonThorvaldUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "EarlMemnonThorvaldUsed");
			WormGameResultsEntry.NativeFieldInfoPtr_EarlMemnonThorvaldWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "EarlMemnonThorvaldWins");
			WormGameResultsEntry.NativeFieldInfoPtr_CountIlbanRicheseUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "CountIlbanRicheseUsed");
			WormGameResultsEntry.NativeFieldInfoPtr_CountIlbanRicheseWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "CountIlbanRicheseWins");
			WormGameResultsEntry.NativeFieldInfoPtr_HelenaRicheseUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "HelenaRicheseUsed");
			WormGameResultsEntry.NativeFieldInfoPtr_HelenaRicheseWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "HelenaRicheseWins");
			WormGameResultsEntry.NativeFieldInfoPtr_PrinceRhomburVerniusUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "PrinceRhomburVerniusUsed");
			WormGameResultsEntry.NativeFieldInfoPtr_PrinceRhomburVerniusWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "PrinceRhomburVerniusWins");
			WormGameResultsEntry.NativeFieldInfoPtr_TessiaVerniusUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "TessiaVerniusUsed");
			WormGameResultsEntry.NativeFieldInfoPtr_TessiaVerniusWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "TessiaVerniusWins");
			WormGameResultsEntry.NativeFieldInfoPtr_ArchdukeArmandEcazUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "ArchdukeArmandEcazUsed");
			WormGameResultsEntry.NativeFieldInfoPtr_ArchdukeArmandEcazWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "ArchdukeArmandEcazWins");
			WormGameResultsEntry.NativeFieldInfoPtr_IlesaEcazUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "IlesaEcazUsed");
			WormGameResultsEntry.NativeFieldInfoPtr_IlesaEcazWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "IlesaEcazWins");
			WormGameResultsEntry.NativeFieldInfoPtr_ViscountHundroMoritaniUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "ViscountHundroMoritaniUsed");
			WormGameResultsEntry.NativeFieldInfoPtr_ViscountHundroMoritaniWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "ViscountHundroMoritaniWins");
			WormGameResultsEntry.NativeFieldInfoPtr_PrincessYunaMoritaniUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "PrincessYunaMoritaniUsed");
			WormGameResultsEntry.NativeFieldInfoPtr_PrincessYunaMoritaniWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "PrincessYunaMoritaniWins");
			WormGameResultsEntry.NativeFieldInfoPtr_SoloHagalAttempts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "SoloHagalAttempts");
			WormGameResultsEntry.NativeFieldInfoPtr_SoloHagalWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "SoloHagalWins");
			WormGameResultsEntry.NativeFieldInfoPtr_OnlineHagalAttempts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "OnlineHagalAttempts");
			WormGameResultsEntry.NativeFieldInfoPtr_OnlineHagalWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "OnlineHagalWins");
			WormGameResultsEntry.NativeFieldInfoPtr_RoiGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "RoiGames");
			WormGameResultsEntry.NativeFieldInfoPtr_ImmoGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "ImmoGames");
			WormGameResultsEntry.NativeFieldInfoPtr_ThreePlayerAttempts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "ThreePlayerAttempts");
			WormGameResultsEntry.NativeFieldInfoPtr_ThreePlayerWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "ThreePlayerWins");
			WormGameResultsEntry.NativeFieldInfoPtr_FourPlayerAttempts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "FourPlayerAttempts");
			WormGameResultsEntry.NativeFieldInfoPtr_FourPlayerWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "FourPlayerWins");
			WormGameResultsEntry.NativeFieldInfoPtr_GraftedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "GraftedCount");
			WormGameResultsEntry.NativeFieldInfoPtr_TleilaxuAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "TleilaxuAcquired");
			WormGameResultsEntry.NativeFieldInfoPtr_TleilaxuInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "TleilaxuInfluence");
			WormGameResultsEntry.NativeFieldInfoPtr_ResearchCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, "ResearchCount");
			WormGameResultsEntry.NativeMethodInfoPtr_get_ResignedFromGame_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, 100663779);
			WormGameResultsEntry.NativeMethodInfoPtr_MakeMatchHistoryPlayerStats_Public_Virtual_Final_New_Dictionary_2_String_Int32_WormGameResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, 100663780);
			WormGameResultsEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr, 100663781);
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0006F298 File Offset: 0x0006D498
		public unsafe virtual bool ResignedFromGame
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31355, XrefRangeEnd = 31358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsEntry.NativeMethodInfoPtr_get_ResignedFromGame_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0006F2D4 File Offset: 0x0006D4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31358, XrefRangeEnd = 31661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Dictionary<string, int> MakeMatchHistoryPlayerStats(WormGameResults results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsEntry.NativeMethodInfoPtr_MakeMatchHistoryPlayerStats_Public_Virtual_Final_New_Dictionary_2_String_Int32_WormGameResults_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0006F324 File Offset: 0x0006D524
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGameResultsEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGameResultsEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002575 File Offset: 0x00000775
		public WormGameResultsEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0006F360 File Offset: 0x0006D560
		// (set) Token: 0x06000137 RID: 311 RVA: 0x0000257E File Offset: 0x0000077E
		public unsafe int Score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_Score);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_Score)) = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0006F388 File Offset: 0x0006D588
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00002599 File Offset: 0x00000799
		public unsafe int Rounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_Rounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_Rounds)) = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0006F3B0 File Offset: 0x0006D5B0
		// (set) Token: 0x0600013B RID: 315 RVA: 0x000025B4 File Offset: 0x000007B4
		public unsafe int Spice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_Spice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_Spice)) = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0006F3D8 File Offset: 0x0006D5D8
		// (set) Token: 0x0600013D RID: 317 RVA: 0x000025CF File Offset: 0x000007CF
		public unsafe int Solari
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_Solari);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_Solari)) = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0006F400 File Offset: 0x0006D600
		// (set) Token: 0x0600013F RID: 319 RVA: 0x000025EA File Offset: 0x000007EA
		public unsafe int Water
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_Water);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_Water)) = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0006F428 File Offset: 0x0006D628
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00002605 File Offset: 0x00000805
		public unsafe int GarrisonTroops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_GarrisonTroops);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_GarrisonTroops)) = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000142 RID: 322 RVA: 0x0006F450 File Offset: 0x0006D650
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00002620 File Offset: 0x00000820
		public unsafe Dictionary<Factions, int> FactionInfluences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_FactionInfluences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Factions, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_FactionInfluences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0006F480 File Offset: 0x0006D680
		// (set) Token: 0x06000145 RID: 325 RVA: 0x0000263F File Offset: 0x0000083F
		public unsafe int SpiceMustFlowAcquired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_SpiceMustFlowAcquired);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_SpiceMustFlowAcquired)) = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0006F4A8 File Offset: 0x0006D6A8
		// (set) Token: 0x06000147 RID: 327 RVA: 0x0000265A File Offset: 0x0000085A
		public unsafe int MentatsUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_MentatsUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_MentatsUsed)) = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0006F4D0 File Offset: 0x0006D6D0
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00002675 File Offset: 0x00000875
		public unsafe int CombatsWon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_CombatsWon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_CombatsWon)) = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0006F4F8 File Offset: 0x0006D6F8
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00002690 File Offset: 0x00000890
		public unsafe int TechAcquired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_TechAcquired);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_TechAcquired)) = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0006F520 File Offset: 0x0006D720
		// (set) Token: 0x0600014D RID: 333 RVA: 0x000026AB File Offset: 0x000008AB
		public unsafe int Shipments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_Shipments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_Shipments)) = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600014E RID: 334 RVA: 0x0006F548 File Offset: 0x0006D748
		// (set) Token: 0x0600014F RID: 335 RVA: 0x000026C6 File Offset: 0x000008C6
		public unsafe bool Swordmaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_Swordmaster);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_Swordmaster)) = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0006F570 File Offset: 0x0006D770
		// (set) Token: 0x06000151 RID: 337 RVA: 0x000026E1 File Offset: 0x000008E1
		public unsafe int SwordmasterTurn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_SwordmasterTurn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_SwordmasterTurn)) = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000152 RID: 338 RVA: 0x0006F598 File Offset: 0x0006D798
		// (set) Token: 0x06000153 RID: 339 RVA: 0x000026FC File Offset: 0x000008FC
		public unsafe bool HighCouncilSeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_HighCouncilSeat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_HighCouncilSeat)) = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0006F5C0 File Offset: 0x0006D7C0
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00002717 File Offset: 0x00000917
		public unsafe int HighCouncilSeatTurn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_HighCouncilSeatTurn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_HighCouncilSeatTurn)) = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0006F5E8 File Offset: 0x0006D7E8
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00002732 File Offset: 0x00000932
		public unsafe Dictionary<Factions, bool> Alliances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_Alliances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Factions, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_Alliances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000158 RID: 344 RVA: 0x0006F618 File Offset: 0x0006D818
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00002751 File Offset: 0x00000951
		public unsafe ArchetypeID LeaderID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_LeaderID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_LeaderID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0006F648 File Offset: 0x0006D848
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00002770 File Offset: 0x00000970
		public unsafe Dictionary<string, int> AbilityUsage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_AbilityUsage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_AbilityUsage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0006F678 File Offset: 0x0006D878
		// (set) Token: 0x0600015D RID: 349 RVA: 0x0000278F File Offset: 0x0000098F
		public unsafe Dictionary<string, int> AdditionalReports
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_AdditionalReports);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_AdditionalReports), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0006F6A8 File Offset: 0x0006D8A8
		// (set) Token: 0x0600015F RID: 351 RVA: 0x000027AE File Offset: 0x000009AE
		public unsafe Dictionary<LocalizableTextVariables, int> SkirmishScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_SkirmishScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<LocalizableTextVariables, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_SkirmishScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0006F6D8 File Offset: 0x0006D8D8
		// (set) Token: 0x06000161 RID: 353 RVA: 0x000027CD File Offset: 0x000009CD
		public unsafe List<int> SkirmishRuleMods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_SkirmishRuleMods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_SkirmishRuleMods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0006F708 File Offset: 0x0006D908
		// (set) Token: 0x06000163 RID: 355 RVA: 0x000027EC File Offset: 0x000009EC
		public unsafe bool ChaumurkyTechTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_ChaumurkyTechTile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_ChaumurkyTechTile)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0006F730 File Offset: 0x0006D930
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00002807 File Offset: 0x00000A07
		public unsafe bool PaulAtreidesUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_PaulAtreidesUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_PaulAtreidesUsed)) = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0006F758 File Offset: 0x0006D958
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002822 File Offset: 0x00000A22
		public unsafe bool PaulAtreidesWins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_PaulAtreidesWins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_PaulAtreidesWins)) = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0006F780 File Offset: 0x0006D980
		// (set) Token: 0x06000169 RID: 361 RVA: 0x0000283D File Offset: 0x00000A3D
		public unsafe bool DukeLetoAtreidesUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_DukeLetoAtreidesUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_DukeLetoAtreidesUsed)) = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0006F7A8 File Offset: 0x0006D9A8
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00002858 File Offset: 0x00000A58
		public unsafe bool DukeLetoAtreidesWins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_DukeLetoAtreidesWins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_DukeLetoAtreidesWins)) = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0006F7D0 File Offset: 0x0006D9D0
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00002873 File Offset: 0x00000A73
		public unsafe bool BaronVladimirHarkonnenUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_BaronVladimirHarkonnenUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_BaronVladimirHarkonnenUsed)) = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0006F7F8 File Offset: 0x0006D9F8
		// (set) Token: 0x0600016F RID: 367 RVA: 0x0000288E File Offset: 0x00000A8E
		public unsafe bool BaronVladimirHarkonnenWins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_BaronVladimirHarkonnenWins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_BaronVladimirHarkonnenWins)) = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0006F820 File Offset: 0x0006DA20
		// (set) Token: 0x06000171 RID: 369 RVA: 0x000028A9 File Offset: 0x00000AA9
		public unsafe bool GlossuTheBeastRabbanUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_GlossuTheBeastRabbanUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_GlossuTheBeastRabbanUsed)) = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0006F848 File Offset: 0x0006DA48
		// (set) Token: 0x06000173 RID: 371 RVA: 0x000028C4 File Offset: 0x00000AC4
		public unsafe bool GlossuTheBeastRabbanWins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_GlossuTheBeastRabbanWins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_GlossuTheBeastRabbanWins)) = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000174 RID: 372 RVA: 0x0006F870 File Offset: 0x0006DA70
		// (set) Token: 0x06000175 RID: 373 RVA: 0x000028DF File Offset: 0x00000ADF
		public unsafe bool CountessArianaThorvaldUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_CountessArianaThorvaldUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_CountessArianaThorvaldUsed)) = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0006F898 File Offset: 0x0006DA98
		// (set) Token: 0x06000177 RID: 375 RVA: 0x000028FA File Offset: 0x00000AFA
		public unsafe bool CountessArianaThorvaldWins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_CountessArianaThorvaldWins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_CountessArianaThorvaldWins)) = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0006F8C0 File Offset: 0x0006DAC0
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00002915 File Offset: 0x00000B15
		public unsafe bool EarlMemnonThorvaldUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_EarlMemnonThorvaldUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_EarlMemnonThorvaldUsed)) = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0006F8E8 File Offset: 0x0006DAE8
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00002930 File Offset: 0x00000B30
		public unsafe bool EarlMemnonThorvaldWins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_EarlMemnonThorvaldWins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_EarlMemnonThorvaldWins)) = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0006F910 File Offset: 0x0006DB10
		// (set) Token: 0x0600017D RID: 381 RVA: 0x0000294B File Offset: 0x00000B4B
		public unsafe bool CountIlbanRicheseUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_CountIlbanRicheseUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_CountIlbanRicheseUsed)) = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0006F938 File Offset: 0x0006DB38
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00002966 File Offset: 0x00000B66
		public unsafe bool CountIlbanRicheseWins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_CountIlbanRicheseWins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_CountIlbanRicheseWins)) = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0006F960 File Offset: 0x0006DB60
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00002981 File Offset: 0x00000B81
		public unsafe bool HelenaRicheseUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_HelenaRicheseUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_HelenaRicheseUsed)) = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0006F988 File Offset: 0x0006DB88
		// (set) Token: 0x06000183 RID: 387 RVA: 0x0000299C File Offset: 0x00000B9C
		public unsafe bool HelenaRicheseWins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_HelenaRicheseWins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_HelenaRicheseWins)) = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0006F9B0 File Offset: 0x0006DBB0
		// (set) Token: 0x06000185 RID: 389 RVA: 0x000029B7 File Offset: 0x00000BB7
		public unsafe bool PrinceRhomburVerniusUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_PrinceRhomburVerniusUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_PrinceRhomburVerniusUsed)) = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000186 RID: 390 RVA: 0x0006F9D8 File Offset: 0x0006DBD8
		// (set) Token: 0x06000187 RID: 391 RVA: 0x000029D2 File Offset: 0x00000BD2
		public unsafe bool PrinceRhomburVerniusWins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_PrinceRhomburVerniusWins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_PrinceRhomburVerniusWins)) = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0006FA00 File Offset: 0x0006DC00
		// (set) Token: 0x06000189 RID: 393 RVA: 0x000029ED File Offset: 0x00000BED
		public unsafe bool TessiaVerniusUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_TessiaVerniusUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_TessiaVerniusUsed)) = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0006FA28 File Offset: 0x0006DC28
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00002A08 File Offset: 0x00000C08
		public unsafe bool TessiaVerniusWins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_TessiaVerniusWins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_TessiaVerniusWins)) = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0006FA50 File Offset: 0x0006DC50
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00002A23 File Offset: 0x00000C23
		public unsafe bool ArchdukeArmandEcazUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_ArchdukeArmandEcazUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_ArchdukeArmandEcazUsed)) = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0006FA78 File Offset: 0x0006DC78
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00002A3E File Offset: 0x00000C3E
		public unsafe bool ArchdukeArmandEcazWins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_ArchdukeArmandEcazWins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_ArchdukeArmandEcazWins)) = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0006FAA0 File Offset: 0x0006DCA0
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00002A59 File Offset: 0x00000C59
		public unsafe bool IlesaEcazUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_IlesaEcazUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_IlesaEcazUsed)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0006FAC8 File Offset: 0x0006DCC8
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00002A74 File Offset: 0x00000C74
		public unsafe bool IlesaEcazWins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_IlesaEcazWins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_IlesaEcazWins)) = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0006FAF0 File Offset: 0x0006DCF0
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00002A8F File Offset: 0x00000C8F
		public unsafe bool ViscountHundroMoritaniUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_ViscountHundroMoritaniUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_ViscountHundroMoritaniUsed)) = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0006FB18 File Offset: 0x0006DD18
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00002AAA File Offset: 0x00000CAA
		public unsafe bool ViscountHundroMoritaniWins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_ViscountHundroMoritaniWins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_ViscountHundroMoritaniWins)) = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0006FB40 File Offset: 0x0006DD40
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00002AC5 File Offset: 0x00000CC5
		public unsafe bool PrincessYunaMoritaniUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_PrincessYunaMoritaniUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_PrincessYunaMoritaniUsed)) = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0006FB68 File Offset: 0x0006DD68
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00002AE0 File Offset: 0x00000CE0
		public unsafe bool PrincessYunaMoritaniWins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_PrincessYunaMoritaniWins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_PrincessYunaMoritaniWins)) = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0006FB90 File Offset: 0x0006DD90
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00002AFB File Offset: 0x00000CFB
		public unsafe int SoloHagalAttempts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_SoloHagalAttempts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_SoloHagalAttempts)) = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0006FBB8 File Offset: 0x0006DDB8
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00002B16 File Offset: 0x00000D16
		public unsafe int SoloHagalWins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_SoloHagalWins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_SoloHagalWins)) = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0006FBE0 File Offset: 0x0006DDE0
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002B31 File Offset: 0x00000D31
		public unsafe int OnlineHagalAttempts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_OnlineHagalAttempts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_OnlineHagalAttempts)) = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0006FC08 File Offset: 0x0006DE08
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002B4C File Offset: 0x00000D4C
		public unsafe int OnlineHagalWins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_OnlineHagalWins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_OnlineHagalWins)) = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0006FC30 File Offset: 0x0006DE30
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002B67 File Offset: 0x00000D67
		public unsafe int RoiGames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_RoiGames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_RoiGames)) = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0006FC58 File Offset: 0x0006DE58
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00002B82 File Offset: 0x00000D82
		public unsafe int ImmoGames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_ImmoGames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_ImmoGames)) = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0006FC80 File Offset: 0x0006DE80
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002B9D File Offset: 0x00000D9D
		public unsafe int ThreePlayerAttempts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_ThreePlayerAttempts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_ThreePlayerAttempts)) = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0006FCA8 File Offset: 0x0006DEA8
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00002BB8 File Offset: 0x00000DB8
		public unsafe int ThreePlayerWins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_ThreePlayerWins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_ThreePlayerWins)) = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001AC RID: 428 RVA: 0x0006FCD0 File Offset: 0x0006DED0
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00002BD3 File Offset: 0x00000DD3
		public unsafe int FourPlayerAttempts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_FourPlayerAttempts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_FourPlayerAttempts)) = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0006FCF8 File Offset: 0x0006DEF8
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00002BEE File Offset: 0x00000DEE
		public unsafe int FourPlayerWins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_FourPlayerWins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_FourPlayerWins)) = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0006FD20 File Offset: 0x0006DF20
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002C09 File Offset: 0x00000E09
		public unsafe int GraftedCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_GraftedCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_GraftedCount)) = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0006FD48 File Offset: 0x0006DF48
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002C24 File Offset: 0x00000E24
		public unsafe int TleilaxuAcquired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_TleilaxuAcquired);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_TleilaxuAcquired)) = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0006FD70 File Offset: 0x0006DF70
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002C3F File Offset: 0x00000E3F
		public unsafe int TleilaxuInfluence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_TleilaxuInfluence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_TleilaxuInfluence)) = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0006FD98 File Offset: 0x0006DF98
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00002C5A File Offset: 0x00000E5A
		public unsafe int ResearchCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_ResearchCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsEntry.NativeFieldInfoPtr_ResearchCount)) = value;
			}
		}

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr_Score;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr_Rounds;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr_Spice;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr_Solari;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr_Water;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr_GarrisonTroops;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeFieldInfoPtr_FactionInfluences;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeFieldInfoPtr_SpiceMustFlowAcquired;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr_MentatsUsed;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr_CombatsWon;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_TechAcquired;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_Shipments;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr_Swordmaster;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_SwordmasterTurn;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_HighCouncilSeat;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_HighCouncilSeatTurn;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_Alliances;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_LeaderID;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_AbilityUsage;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalReports;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_SkirmishScore;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_SkirmishRuleMods;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr_ChaumurkyTechTile;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr_PaulAtreidesUsed;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr_PaulAtreidesWins;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_DukeLetoAtreidesUsed;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_DukeLetoAtreidesWins;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_BaronVladimirHarkonnenUsed;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_BaronVladimirHarkonnenWins;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_GlossuTheBeastRabbanUsed;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr_GlossuTheBeastRabbanWins;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_CountessArianaThorvaldUsed;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_CountessArianaThorvaldWins;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_EarlMemnonThorvaldUsed;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr_EarlMemnonThorvaldWins;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeFieldInfoPtr_CountIlbanRicheseUsed;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr_CountIlbanRicheseWins;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr_HelenaRicheseUsed;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr_HelenaRicheseWins;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr_PrinceRhomburVerniusUsed;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_PrinceRhomburVerniusWins;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_TessiaVerniusUsed;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_TessiaVerniusWins;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_ArchdukeArmandEcazUsed;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr_ArchdukeArmandEcazWins;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeFieldInfoPtr_IlesaEcazUsed;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeFieldInfoPtr_IlesaEcazWins;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr_ViscountHundroMoritaniUsed;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeFieldInfoPtr_ViscountHundroMoritaniWins;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeFieldInfoPtr_PrincessYunaMoritaniUsed;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeFieldInfoPtr_PrincessYunaMoritaniWins;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeFieldInfoPtr_SoloHagalAttempts;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeFieldInfoPtr_SoloHagalWins;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeFieldInfoPtr_OnlineHagalAttempts;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeFieldInfoPtr_OnlineHagalWins;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeFieldInfoPtr_RoiGames;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeFieldInfoPtr_ImmoGames;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeFieldInfoPtr_ThreePlayerAttempts;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeFieldInfoPtr_ThreePlayerWins;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeFieldInfoPtr_FourPlayerAttempts;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeFieldInfoPtr_FourPlayerWins;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeFieldInfoPtr_GraftedCount;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeFieldInfoPtr_TleilaxuAcquired;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeFieldInfoPtr_TleilaxuInfluence;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeFieldInfoPtr_ResearchCount;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_get_ResignedFromGame_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_MakeMatchHistoryPlayerStats_Public_Virtual_Final_New_Dictionary_2_String_Int32_WormGameResults_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
