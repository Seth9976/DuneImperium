using System;
using Canis.utils.ids;
using dwd.core.settings.config.definitions;
using dwd.core.settings.platform.definitions;
using dwd.core.settings.playerPrefs.definitions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.client.utils
{
	// Token: 0x02000295 RID: 661
	public static class WormPrefs : Object
	{
		// Token: 0x06001ABB RID: 6843 RVA: 0x0006A748 File Offset: 0x00068948
		// Note: this type is marked as 'beforefieldinit'.
		static WormPrefs()
		{
			Il2CppClassPointerStore<WormPrefs>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.utils", "WormPrefs");
			WormPrefs.NativeFieldInfoPtr_EventsURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "EventsURL");
			WormPrefs.NativeFieldInfoPtr_ActiveEventsURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "ActiveEventsURL");
			WormPrefs.NativeFieldInfoPtr_ReputationEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "ReputationEnabled");
			WormPrefs.NativeFieldInfoPtr_AnonymousClaimToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "AnonymousClaimToken");
			WormPrefs.NativeFieldInfoPtr_Player3Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "Player3Type");
			WormPrefs.NativeFieldInfoPtr_Player4Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "Player4Type");
			WormPrefs.NativeFieldInfoPtr_Player1Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "Player1Color");
			WormPrefs.NativeFieldInfoPtr_Player2Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "Player2Color");
			WormPrefs.NativeFieldInfoPtr_Player3Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "Player3Color");
			WormPrefs.NativeFieldInfoPtr_Player4Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "Player4Color");
			WormPrefs.NativeFieldInfoPtr_AIType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "AIType");
			WormPrefs.NativeFieldInfoPtr_AIDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "AIDifficulty");
			WormPrefs.NativeFieldInfoPtr_DraftType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "DraftType");
			WormPrefs.NativeFieldInfoPtr_TurnTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "TurnTimer");
			WormPrefs.NativeFieldInfoPtr_HagalDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "HagalDifficulty");
			WormPrefs.NativeFieldInfoPtr_GameplayVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "GameplayVariant");
			WormPrefs.NativeFieldInfoPtr_RiseOfIxEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "RiseOfIxEnabled");
			WormPrefs.NativeFieldInfoPtr_ImmortalityEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "ImmortalityEnabled");
			WormPrefs.NativeFieldInfoPtr_MinRep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "MinRep");
			WormPrefs.NativeFieldInfoPtr_AnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "AnimationSpeed");
			WormPrefs.NativeFieldInfoPtr_AnimationsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "AnimationsEnabled");
			WormPrefs.NativeFieldInfoPtr_SeenEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "SeenEvents");
			WormPrefs.NativeFieldInfoPtr_TutorialFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "TutorialFTT");
			WormPrefs.NativeFieldInfoPtr_IxTutorialFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "IxTutorialFTT");
			WormPrefs.NativeFieldInfoPtr_ImmoTutorialFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "ImmoTutorialFTT");
			WormPrefs.NativeFieldInfoPtr_RankedGainStarsFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "RankedGainStarsFTT");
			WormPrefs.NativeFieldInfoPtr_RankedLoseStarsFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "RankedLoseStarsFTT");
			WormPrefs.NativeFieldInfoPtr_ChallengesSwitchboardEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "ChallengesSwitchboardEnabled");
			WormPrefs.NativeFieldInfoPtr_SkirmishSwitchboardEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "SkirmishSwitchboardEnabled");
			WormPrefs.NativeFieldInfoPtr_EventsSwitchboardEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "EventsSwitchboardEnabled");
			WormPrefs.NativeFieldInfoPtr_RankedPlaySwitchboardEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "RankedPlaySwitchboardEnabled");
			WormPrefs.NativeFieldInfoPtr_ShowTechTileButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "ShowTechTileButtons");
			WormPrefs.NativeFieldInfoPtr_StaticCatalog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, "StaticCatalog");
			WormPrefs.NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrefs>.NativeClassPtr, 100667218);
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x0006AA18 File Offset: 0x00068C18
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPrefs.NativeMethodInfoPtr_Init_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0000F865 File Offset: 0x0000DA65
		public WormPrefs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x0006AA40 File Offset: 0x00068C40
		// (set) Token: 0x06001ABF RID: 6847 RVA: 0x0000F86E File Offset: 0x0000DA6E
		public unsafe static StringConfigDefinition EventsURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_EventsURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_EventsURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x0006AA68 File Offset: 0x00068C68
		// (set) Token: 0x06001AC1 RID: 6849 RVA: 0x0000F880 File Offset: 0x0000DA80
		public unsafe static StringConfigDefinition ActiveEventsURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_ActiveEventsURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_ActiveEventsURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x0006AA90 File Offset: 0x00068C90
		// (set) Token: 0x06001AC3 RID: 6851 RVA: 0x0000F892 File Offset: 0x0000DA92
		public unsafe static BoolPrefDefinition ReputationEnabled
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_ReputationEnabled, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_ReputationEnabled, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x0006AAB8 File Offset: 0x00068CB8
		// (set) Token: 0x06001AC5 RID: 6853 RVA: 0x0000F8A4 File Offset: 0x0000DAA4
		public unsafe static StringPrefDefinition AnonymousClaimToken
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_AnonymousClaimToken, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_AnonymousClaimToken, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x0006AAE0 File Offset: 0x00068CE0
		// (set) Token: 0x06001AC7 RID: 6855 RVA: 0x0000F8B6 File Offset: 0x0000DAB6
		public unsafe static PlatformSettingDefinition<int> Player3Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_Player3Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_Player3Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x0006AB08 File Offset: 0x00068D08
		// (set) Token: 0x06001AC9 RID: 6857 RVA: 0x0000F8C8 File Offset: 0x0000DAC8
		public unsafe static PlatformSettingDefinition<int> Player4Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_Player4Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_Player4Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06001ACA RID: 6858 RVA: 0x0006AB30 File Offset: 0x00068D30
		// (set) Token: 0x06001ACB RID: 6859 RVA: 0x0000F8DA File Offset: 0x0000DADA
		public unsafe static PlatformSettingDefinition<int> Player1Color
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_Player1Color, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_Player1Color, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x0006AB58 File Offset: 0x00068D58
		// (set) Token: 0x06001ACD RID: 6861 RVA: 0x0000F8EC File Offset: 0x0000DAEC
		public unsafe static PlatformSettingDefinition<int> Player2Color
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_Player2Color, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_Player2Color, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x0006AB80 File Offset: 0x00068D80
		// (set) Token: 0x06001ACF RID: 6863 RVA: 0x0000F8FE File Offset: 0x0000DAFE
		public unsafe static PlatformSettingDefinition<int> Player3Color
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_Player3Color, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_Player3Color, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x0006ABA8 File Offset: 0x00068DA8
		// (set) Token: 0x06001AD1 RID: 6865 RVA: 0x0000F910 File Offset: 0x0000DB10
		public unsafe static PlatformSettingDefinition<int> Player4Color
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_Player4Color, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_Player4Color, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06001AD2 RID: 6866 RVA: 0x0006ABD0 File Offset: 0x00068DD0
		// (set) Token: 0x06001AD3 RID: 6867 RVA: 0x0000F922 File Offset: 0x0000DB22
		public unsafe static PlatformSettingDefinition<int> AIType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_AIType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_AIType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x0006ABF8 File Offset: 0x00068DF8
		// (set) Token: 0x06001AD5 RID: 6869 RVA: 0x0000F934 File Offset: 0x0000DB34
		public unsafe static PlatformSettingDefinition<int> AIDifficulty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_AIDifficulty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_AIDifficulty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x0006AC20 File Offset: 0x00068E20
		// (set) Token: 0x06001AD7 RID: 6871 RVA: 0x0000F946 File Offset: 0x0000DB46
		public unsafe static PlatformSettingDefinition<int> DraftType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_DraftType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_DraftType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x0006AC48 File Offset: 0x00068E48
		// (set) Token: 0x06001AD9 RID: 6873 RVA: 0x0000F958 File Offset: 0x0000DB58
		public unsafe static PlatformSettingDefinition<int> TurnTimer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_TurnTimer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_TurnTimer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x0006AC70 File Offset: 0x00068E70
		// (set) Token: 0x06001ADB RID: 6875 RVA: 0x0000F96A File Offset: 0x0000DB6A
		public unsafe static PlatformSettingDefinition<int> HagalDifficulty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_HagalDifficulty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_HagalDifficulty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x0006AC98 File Offset: 0x00068E98
		// (set) Token: 0x06001ADD RID: 6877 RVA: 0x0000F97C File Offset: 0x0000DB7C
		public unsafe static PlatformSettingDefinition<int> GameplayVariant
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_GameplayVariant, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_GameplayVariant, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x0006ACC0 File Offset: 0x00068EC0
		// (set) Token: 0x06001ADF RID: 6879 RVA: 0x0000F98E File Offset: 0x0000DB8E
		public unsafe static PlatformSettingDefinition<int> RiseOfIxEnabled
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_RiseOfIxEnabled, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_RiseOfIxEnabled, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x0006ACE8 File Offset: 0x00068EE8
		// (set) Token: 0x06001AE1 RID: 6881 RVA: 0x0000F9A0 File Offset: 0x0000DBA0
		public unsafe static PlatformSettingDefinition<int> ImmortalityEnabled
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_ImmortalityEnabled, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_ImmortalityEnabled, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x0006AD10 File Offset: 0x00068F10
		// (set) Token: 0x06001AE3 RID: 6883 RVA: 0x0000F9B2 File Offset: 0x0000DBB2
		public unsafe static PlatformSettingDefinition<int> MinRep
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_MinRep, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_MinRep, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x0006AD38 File Offset: 0x00068F38
		// (set) Token: 0x06001AE5 RID: 6885 RVA: 0x0000F9C4 File Offset: 0x0000DBC4
		public unsafe static PlatformSettingDefinition<float> AnimationSpeed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_AnimationSpeed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_AnimationSpeed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x0006AD60 File Offset: 0x00068F60
		// (set) Token: 0x06001AE7 RID: 6887 RVA: 0x0000F9D6 File Offset: 0x0000DBD6
		public unsafe static PlatformSettingDefinition<bool> AnimationsEnabled
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_AnimationsEnabled, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_AnimationsEnabled, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x0006AD88 File Offset: 0x00068F88
		// (set) Token: 0x06001AE9 RID: 6889 RVA: 0x0000F9E8 File Offset: 0x0000DBE8
		public unsafe static ListPlatformSettingDefinition<EventID> SeenEvents
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_SeenEvents, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListPlatformSettingDefinition<EventID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_SeenEvents, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06001AEA RID: 6890 RVA: 0x0006ADB0 File Offset: 0x00068FB0
		// (set) Token: 0x06001AEB RID: 6891 RVA: 0x0000F9FA File Offset: 0x0000DBFA
		public unsafe static PlatformSettingDefinition<bool> TutorialFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_TutorialFTT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_TutorialFTT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x0006ADD8 File Offset: 0x00068FD8
		// (set) Token: 0x06001AED RID: 6893 RVA: 0x0000FA0C File Offset: 0x0000DC0C
		public unsafe static PlatformSettingDefinition<bool> IxTutorialFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_IxTutorialFTT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_IxTutorialFTT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x0006AE00 File Offset: 0x00069000
		// (set) Token: 0x06001AEF RID: 6895 RVA: 0x0000FA1E File Offset: 0x0000DC1E
		public unsafe static PlatformSettingDefinition<bool> ImmoTutorialFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_ImmoTutorialFTT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_ImmoTutorialFTT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x0006AE28 File Offset: 0x00069028
		// (set) Token: 0x06001AF1 RID: 6897 RVA: 0x0000FA30 File Offset: 0x0000DC30
		public unsafe static PlatformSettingDefinition<bool> RankedGainStarsFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_RankedGainStarsFTT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_RankedGainStarsFTT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x0006AE50 File Offset: 0x00069050
		// (set) Token: 0x06001AF3 RID: 6899 RVA: 0x0000FA42 File Offset: 0x0000DC42
		public unsafe static PlatformSettingDefinition<bool> RankedLoseStarsFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_RankedLoseStarsFTT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_RankedLoseStarsFTT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x0006AE78 File Offset: 0x00069078
		// (set) Token: 0x06001AF5 RID: 6901 RVA: 0x0000FA54 File Offset: 0x0000DC54
		public unsafe static BoolPrefDefinition ChallengesSwitchboardEnabled
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_ChallengesSwitchboardEnabled, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_ChallengesSwitchboardEnabled, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x0006AEA0 File Offset: 0x000690A0
		// (set) Token: 0x06001AF7 RID: 6903 RVA: 0x0000FA66 File Offset: 0x0000DC66
		public unsafe static BoolPrefDefinition SkirmishSwitchboardEnabled
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_SkirmishSwitchboardEnabled, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_SkirmishSwitchboardEnabled, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001AF8 RID: 6904 RVA: 0x0006AEC8 File Offset: 0x000690C8
		// (set) Token: 0x06001AF9 RID: 6905 RVA: 0x0000FA78 File Offset: 0x0000DC78
		public unsafe static BoolPrefDefinition EventsSwitchboardEnabled
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_EventsSwitchboardEnabled, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_EventsSwitchboardEnabled, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06001AFA RID: 6906 RVA: 0x0006AEF0 File Offset: 0x000690F0
		// (set) Token: 0x06001AFB RID: 6907 RVA: 0x0000FA8A File Offset: 0x0000DC8A
		public unsafe static BoolPrefDefinition RankedPlaySwitchboardEnabled
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_RankedPlaySwitchboardEnabled, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_RankedPlaySwitchboardEnabled, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06001AFC RID: 6908 RVA: 0x0006AF18 File Offset: 0x00069118
		// (set) Token: 0x06001AFD RID: 6909 RVA: 0x0000FA9C File Offset: 0x0000DC9C
		public unsafe static BoolPrefDefinition ShowTechTileButtons
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_ShowTechTileButtons, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_ShowTechTileButtons, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06001AFE RID: 6910 RVA: 0x0006AF40 File Offset: 0x00069140
		// (set) Token: 0x06001AFF RID: 6911 RVA: 0x0000FAAE File Offset: 0x0000DCAE
		public unsafe static StringConfigDefinition StaticCatalog
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPrefs.NativeFieldInfoPtr_StaticCatalog, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPrefs.NativeFieldInfoPtr_StaticCatalog, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F72 RID: 3954
		private static readonly IntPtr NativeFieldInfoPtr_EventsURL;

		// Token: 0x04000F73 RID: 3955
		private static readonly IntPtr NativeFieldInfoPtr_ActiveEventsURL;

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeFieldInfoPtr_ReputationEnabled;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeFieldInfoPtr_AnonymousClaimToken;

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeFieldInfoPtr_Player3Type;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeFieldInfoPtr_Player4Type;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeFieldInfoPtr_Player1Color;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeFieldInfoPtr_Player2Color;

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeFieldInfoPtr_Player3Color;

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeFieldInfoPtr_Player4Color;

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeFieldInfoPtr_AIType;

		// Token: 0x04000F7D RID: 3965
		private static readonly IntPtr NativeFieldInfoPtr_AIDifficulty;

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeFieldInfoPtr_DraftType;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeFieldInfoPtr_TurnTimer;

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeFieldInfoPtr_HagalDifficulty;

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeFieldInfoPtr_GameplayVariant;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeFieldInfoPtr_RiseOfIxEnabled;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeFieldInfoPtr_ImmortalityEnabled;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeFieldInfoPtr_MinRep;

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeFieldInfoPtr_AnimationSpeed;

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeFieldInfoPtr_AnimationsEnabled;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeFieldInfoPtr_SeenEvents;

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeFieldInfoPtr_TutorialFTT;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeFieldInfoPtr_IxTutorialFTT;

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeFieldInfoPtr_ImmoTutorialFTT;

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeFieldInfoPtr_RankedGainStarsFTT;

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeFieldInfoPtr_RankedLoseStarsFTT;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeFieldInfoPtr_ChallengesSwitchboardEnabled;

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeFieldInfoPtr_SkirmishSwitchboardEnabled;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeFieldInfoPtr_EventsSwitchboardEnabled;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeFieldInfoPtr_RankedPlaySwitchboardEnabled;

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeFieldInfoPtr_ShowTechTileButtons;

		// Token: 0x04000F92 RID: 3986
		private static readonly IntPtr NativeFieldInfoPtr_StaticCatalog;

		// Token: 0x04000F93 RID: 3987
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;
	}
}
