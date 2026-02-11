using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.data
{
	// Token: 0x02000159 RID: 345
	public class TCGameOptions : Object
	{
		// Token: 0x06000F1F RID: 3871 RVA: 0x000588F0 File Offset: 0x00056AF0
		// Note: this type is marked as 'beforefieldinit'.
		static TCGameOptions()
		{
			Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.data", "TCGameOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr);
			TCGameOptions.NativeFieldInfoPtr_AILevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "AILevel");
			TCGameOptions.NativeFieldInfoPtr_IsTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "IsTutorial");
			TCGameOptions.NativeFieldInfoPtr_TutorialProgression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "TutorialProgression");
			TCGameOptions.NativeFieldInfoPtr_MatchType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "MatchType");
			TCGameOptions.NativeFieldInfoPtr_GameType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "GameType");
			TCGameOptions.NativeFieldInfoPtr_IsPassAndPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "IsPassAndPlay");
			TCGameOptions.NativeFieldInfoPtr_IsPBM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "IsPBM");
			TCGameOptions.NativeFieldInfoPtr_PBM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "PBM");
			TCGameOptions.NativeFieldInfoPtr_Match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "Match");
			TCGameOptions.NativeFieldInfoPtr_SceneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "SceneName");
			TCGameOptions.NativeFieldInfoPtr_Tutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "Tutorial");
			TCGameOptions.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "Default");
			TCGameOptions.NativeFieldInfoPtr_AIPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "AIPlayers");
			TCGameOptions.NativeFieldInfoPtr_FriendGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "FriendGame");
			TCGameOptions.NativeFieldInfoPtr_WaitForPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "WaitForPlayers");
			TCGameOptions.NativeFieldInfoPtr_CreatorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "CreatorID");
			TCGameOptions.NativeFieldInfoPtr_IsCampaign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "IsCampaign");
			TCGameOptions.NativeFieldInfoPtr_Scenario = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "Scenario");
			TCGameOptions.NativeFieldInfoPtr_Headless = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "Headless");
			TCGameOptions.NativeFieldInfoPtr_IsObfuscated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "IsObfuscated");
			TCGameOptions.NativeFieldInfoPtr_IsOptimization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, "IsOptimization");
			TCGameOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr, 100666532);
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x00058AD8 File Offset: 0x00056CD8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TCGameOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TCGameOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TCGameOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00007AB1 File Offset: 0x00005CB1
		public TCGameOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x00058B14 File Offset: 0x00056D14
		// (set) Token: 0x06000F23 RID: 3875 RVA: 0x00007ABA File Offset: 0x00005CBA
		public unsafe static string AILevel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_AILevel, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_AILevel, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x00058B34 File Offset: 0x00056D34
		// (set) Token: 0x06000F25 RID: 3877 RVA: 0x00007ACC File Offset: 0x00005CCC
		public unsafe static string IsTutorial
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_IsTutorial, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_IsTutorial, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x00058B54 File Offset: 0x00056D54
		// (set) Token: 0x06000F27 RID: 3879 RVA: 0x00007ADE File Offset: 0x00005CDE
		public unsafe static string TutorialProgression
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_TutorialProgression, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_TutorialProgression, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x00058B74 File Offset: 0x00056D74
		// (set) Token: 0x06000F29 RID: 3881 RVA: 0x00007AF0 File Offset: 0x00005CF0
		public unsafe static string MatchType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_MatchType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_MatchType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x00058B94 File Offset: 0x00056D94
		// (set) Token: 0x06000F2B RID: 3883 RVA: 0x00007B02 File Offset: 0x00005D02
		public unsafe static string GameType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_GameType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_GameType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x00058BB4 File Offset: 0x00056DB4
		// (set) Token: 0x06000F2D RID: 3885 RVA: 0x00007B14 File Offset: 0x00005D14
		public unsafe static string IsPassAndPlay
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_IsPassAndPlay, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_IsPassAndPlay, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x00058BD4 File Offset: 0x00056DD4
		// (set) Token: 0x06000F2F RID: 3887 RVA: 0x00007B26 File Offset: 0x00005D26
		public unsafe static string IsPBM
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_IsPBM, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_IsPBM, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x00058BF4 File Offset: 0x00056DF4
		// (set) Token: 0x06000F31 RID: 3889 RVA: 0x00007B38 File Offset: 0x00005D38
		public unsafe static string PBM
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_PBM, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_PBM, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x00058C14 File Offset: 0x00056E14
		// (set) Token: 0x06000F33 RID: 3891 RVA: 0x00007B4A File Offset: 0x00005D4A
		public unsafe static string Match
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_Match, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_Match, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x00058C34 File Offset: 0x00056E34
		// (set) Token: 0x06000F35 RID: 3893 RVA: 0x00007B5C File Offset: 0x00005D5C
		public unsafe static string SceneName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_SceneName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_SceneName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x00058C54 File Offset: 0x00056E54
		// (set) Token: 0x06000F37 RID: 3895 RVA: 0x00007B6E File Offset: 0x00005D6E
		public unsafe static string Tutorial
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_Tutorial, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_Tutorial, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x00058C74 File Offset: 0x00056E74
		// (set) Token: 0x06000F39 RID: 3897 RVA: 0x00007B80 File Offset: 0x00005D80
		public unsafe static string Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_Default, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x00058C94 File Offset: 0x00056E94
		// (set) Token: 0x06000F3B RID: 3899 RVA: 0x00007B92 File Offset: 0x00005D92
		public unsafe static string AIPlayers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_AIPlayers, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_AIPlayers, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x00058CB4 File Offset: 0x00056EB4
		// (set) Token: 0x06000F3D RID: 3901 RVA: 0x00007BA4 File Offset: 0x00005DA4
		public unsafe static string FriendGame
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_FriendGame, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_FriendGame, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x00058CD4 File Offset: 0x00056ED4
		// (set) Token: 0x06000F3F RID: 3903 RVA: 0x00007BB6 File Offset: 0x00005DB6
		public unsafe static string WaitForPlayers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_WaitForPlayers, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_WaitForPlayers, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x00058CF4 File Offset: 0x00056EF4
		// (set) Token: 0x06000F41 RID: 3905 RVA: 0x00007BC8 File Offset: 0x00005DC8
		public unsafe static string CreatorID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_CreatorID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_CreatorID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x00058D14 File Offset: 0x00056F14
		// (set) Token: 0x06000F43 RID: 3907 RVA: 0x00007BDA File Offset: 0x00005DDA
		public unsafe static string IsCampaign
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_IsCampaign, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_IsCampaign, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x00058D34 File Offset: 0x00056F34
		// (set) Token: 0x06000F45 RID: 3909 RVA: 0x00007BEC File Offset: 0x00005DEC
		public unsafe static string Scenario
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_Scenario, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_Scenario, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x00058D54 File Offset: 0x00056F54
		// (set) Token: 0x06000F47 RID: 3911 RVA: 0x00007BFE File Offset: 0x00005DFE
		public unsafe static string Headless
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_Headless, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_Headless, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x00058D74 File Offset: 0x00056F74
		// (set) Token: 0x06000F49 RID: 3913 RVA: 0x00007C10 File Offset: 0x00005E10
		public unsafe static string IsObfuscated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_IsObfuscated, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_IsObfuscated, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x00058D94 File Offset: 0x00056F94
		// (set) Token: 0x06000F4B RID: 3915 RVA: 0x00007C22 File Offset: 0x00005E22
		public unsafe static string IsOptimization
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCGameOptions.NativeFieldInfoPtr_IsOptimization, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCGameOptions.NativeFieldInfoPtr_IsOptimization, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeFieldInfoPtr_AILevel;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeFieldInfoPtr_IsTutorial;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeFieldInfoPtr_TutorialProgression;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeFieldInfoPtr_MatchType;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeFieldInfoPtr_GameType;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeFieldInfoPtr_IsPassAndPlay;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeFieldInfoPtr_IsPBM;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeFieldInfoPtr_PBM;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeFieldInfoPtr_Match;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeFieldInfoPtr_SceneName;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeFieldInfoPtr_Tutorial;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeFieldInfoPtr_AIPlayers;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeFieldInfoPtr_FriendGame;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeFieldInfoPtr_WaitForPlayers;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeFieldInfoPtr_CreatorID;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeFieldInfoPtr_IsCampaign;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeFieldInfoPtr_Scenario;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeFieldInfoPtr_Headless;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeFieldInfoPtr_IsObfuscated;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeFieldInfoPtr_IsOptimization;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
