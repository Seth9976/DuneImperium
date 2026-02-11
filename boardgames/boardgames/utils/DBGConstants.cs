using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text.RegularExpressions;
using localization;

namespace boardgames.utils
{
	// Token: 0x0200010C RID: 268
	public static class DBGConstants : Object
	{
		// Token: 0x06000CE7 RID: 3303 RVA: 0x0003A13C File Offset: 0x0003833C
		// Note: this type is marked as 'beforefieldinit'.
		static DBGConstants()
		{
			Il2CppClassPointerStore<DBGConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.utils", "DBGConstants");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr);
			DBGConstants.NativeFieldInfoPtr_MaxLobbyPageEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "MaxLobbyPageEntries");
			DBGConstants.NativeFieldInfoPtr_SlowAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "SlowAnimationSpeed");
			DBGConstants.NativeFieldInfoPtr_NormalAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "NormalAnimationSpeed");
			DBGConstants.NativeFieldInfoPtr_FastAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "FastAnimationSpeed");
			DBGConstants.NativeFieldInfoPtr_VeryFastAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "VeryFastAnimationSpeed");
			DBGConstants.NativeFieldInfoPtr_FastestAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "FastestAnimationSpeed");
			DBGConstants.NativeFieldInfoPtr_UIScaleSmall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "UIScaleSmall");
			DBGConstants.NativeFieldInfoPtr_UIScaleDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "UIScaleDefault");
			DBGConstants.NativeFieldInfoPtr_UIScaleLarge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "UIScaleLarge");
			DBGConstants.NativeFieldInfoPtr_UIScaleExtraLarge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "UIScaleExtraLarge");
			DBGConstants.NativeFieldInfoPtr_QualityLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "QualityLevels");
			DBGConstants.NativeFieldInfoPtr_UIScaleOptionsOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "UIScaleOptionsOrder");
			DBGConstants.NativeFieldInfoPtr_TurnTimerAmounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "TurnTimerAmounts");
			DBGConstants.NativeFieldInfoPtr_AIDifficultyLevelNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "AIDifficultyLevelNames");
			DBGConstants.NativeFieldInfoPtr_MinHumanPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "MinHumanPlayers");
			DBGConstants.NativeFieldInfoPtr_MinMatchPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "MinMatchPlayers");
			DBGConstants.NativeFieldInfoPtr_MaxMatchPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "MaxMatchPlayers");
			DBGConstants.NativeFieldInfoPtr__SupportedLocales_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "<SupportedLocales>k__BackingField");
			DBGConstants.NativeFieldInfoPtr_EmailRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "EmailRegex");
			DBGConstants.NativeFieldInfoPtr_PasswordMustContainRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "PasswordMustContainRegex");
			DBGConstants.NativeFieldInfoPtr_ScreenNameRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "ScreenNameRegex");
			DBGConstants.NativeFieldInfoPtr_DemoScenarioName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "DemoScenarioName");
			DBGConstants.NativeFieldInfoPtr_FriendType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "FriendType");
			DBGConstants.NativeFieldInfoPtr_CameraEntityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "CameraEntityName");
			DBGConstants.NativeFieldInfoPtr_PlatformClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "PlatformClient");
			DBGConstants.NativeFieldInfoPtr_TopLeaderboardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "TopLeaderboardCount");
			DBGConstants.NativeFieldInfoPtr_NearLeaderboardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "NearLeaderboardCount");
			DBGConstants.NativeFieldInfoPtr_DailyChallengeTopLeaderboardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "DailyChallengeTopLeaderboardCount");
			DBGConstants.NativeFieldInfoPtr_DailyChallengeNearLeaderboardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "DailyChallengeNearLeaderboardCount");
			DBGConstants.NativeFieldInfoPtr_AspectRatioConfigLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "AspectRatioConfigLabel");
			DBGConstants.NativeMethodInfoPtr_UIScaleToPlatform_Public_Static_UInt32_UIScale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, 100665322);
			DBGConstants.NativeMethodInfoPtr_PlatformToUIScale_Public_Static_UIScale_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, 100665323);
			DBGConstants.NativeMethodInfoPtr_get_SupportedLocales_Public_Static_get_List_1_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, 100665324);
			DBGConstants.NativeMethodInfoPtr_set_SupportedLocales_Public_Static_set_Void_List_1_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, 100665325);
			DBGConstants.NativeMethodInfoPtr_get_PlatformClientFirstUpper_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, 100665326);
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x0003A428 File Offset: 0x00038628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 996221, RefRangeEnd = 996222, XrefRangeStart = 996221, XrefRangeEnd = 996221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint UIScaleToPlatform(DBGConstants.UIScale scale)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGConstants.NativeMethodInfoPtr_UIScaleToPlatform_Public_Static_UInt32_UIScale_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0003A468 File Offset: 0x00038668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 996222, RefRangeEnd = 996223, XrefRangeStart = 996222, XrefRangeEnd = 996222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DBGConstants.UIScale PlatformToUIScale(uint platform)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGConstants.NativeMethodInfoPtr_PlatformToUIScale_Public_Static_UIScale_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x0003A4A8 File Offset: 0x000386A8
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x0003A4DC File Offset: 0x000386DC
		public unsafe static List<TextLocalization.Locale> SupportedLocales
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996223, XrefRangeEnd = 996227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGConstants.NativeMethodInfoPtr_get_SupportedLocales_Public_Static_get_List_1_Locale_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TextLocalization.Locale>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996227, XrefRangeEnd = 996233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGConstants.NativeMethodInfoPtr_set_SupportedLocales_Public_Static_set_Void_List_1_Locale_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x0003A514 File Offset: 0x00038714
		public unsafe static string PlatformClientFirstUpper
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 996246, RefRangeEnd = 996252, XrefRangeStart = 996233, XrefRangeEnd = 996246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGConstants.NativeMethodInfoPtr_get_PlatformClientFirstUpper_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00007E95 File Offset: 0x00006095
		public DBGConstants(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0003A540 File Offset: 0x00038740
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x00007E9E File Offset: 0x0000609E
		public unsafe static int MaxLobbyPageEntries
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_MaxLobbyPageEntries, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_MaxLobbyPageEntries, (void*)(&value));
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x0003A55C File Offset: 0x0003875C
		// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x00007EAC File Offset: 0x000060AC
		public unsafe static float SlowAnimationSpeed
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_SlowAnimationSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_SlowAnimationSpeed, (void*)(&value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x0003A578 File Offset: 0x00038778
		// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x00007EBA File Offset: 0x000060BA
		public unsafe static float NormalAnimationSpeed
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_NormalAnimationSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_NormalAnimationSpeed, (void*)(&value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x0003A594 File Offset: 0x00038794
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x00007EC8 File Offset: 0x000060C8
		public unsafe static float FastAnimationSpeed
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_FastAnimationSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_FastAnimationSpeed, (void*)(&value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x0003A5B0 File Offset: 0x000387B0
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x00007ED6 File Offset: 0x000060D6
		public unsafe static float VeryFastAnimationSpeed
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_VeryFastAnimationSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_VeryFastAnimationSpeed, (void*)(&value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x0003A5CC File Offset: 0x000387CC
		// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x00007EE4 File Offset: 0x000060E4
		public unsafe static float FastestAnimationSpeed
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_FastestAnimationSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_FastestAnimationSpeed, (void*)(&value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x0003A5E8 File Offset: 0x000387E8
		// (set) Token: 0x06000CFB RID: 3323 RVA: 0x00007EF2 File Offset: 0x000060F2
		public unsafe static float UIScaleSmall
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_UIScaleSmall, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_UIScaleSmall, (void*)(&value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x0003A604 File Offset: 0x00038804
		// (set) Token: 0x06000CFD RID: 3325 RVA: 0x00007F00 File Offset: 0x00006100
		public unsafe static float UIScaleDefault
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_UIScaleDefault, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_UIScaleDefault, (void*)(&value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x0003A620 File Offset: 0x00038820
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x00007F0E File Offset: 0x0000610E
		public unsafe static float UIScaleLarge
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_UIScaleLarge, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_UIScaleLarge, (void*)(&value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x0003A63C File Offset: 0x0003883C
		// (set) Token: 0x06000D01 RID: 3329 RVA: 0x00007F1C File Offset: 0x0000611C
		public unsafe static float UIScaleExtraLarge
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_UIScaleExtraLarge, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_UIScaleExtraLarge, (void*)(&value));
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x0003A658 File Offset: 0x00038858
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x00007F2A File Offset: 0x0000612A
		public unsafe static List<ValueTuple<int, string>> QualityLevels
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_QualityLevels, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<int, string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_QualityLevels, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x0003A680 File Offset: 0x00038880
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x00007F3C File Offset: 0x0000613C
		public unsafe static IReadOnlyList<DBGConstants.UIScale> UIScaleOptionsOrder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_UIScaleOptionsOrder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DBGConstants.UIScale>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_UIScaleOptionsOrder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x0003A6A8 File Offset: 0x000388A8
		// (set) Token: 0x06000D07 RID: 3335 RVA: 0x00007F4E File Offset: 0x0000614E
		public unsafe static List<TimeSpan> TurnTimerAmounts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_TurnTimerAmounts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TimeSpan>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_TurnTimerAmounts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x0003A6D0 File Offset: 0x000388D0
		// (set) Token: 0x06000D09 RID: 3337 RVA: 0x00007F60 File Offset: 0x00006160
		public unsafe static List<ValueTuple<DBGConstants.AIDifficultyLevels, string>> AIDifficultyLevelNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_AIDifficultyLevelNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<DBGConstants.AIDifficultyLevels, string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_AIDifficultyLevelNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x0003A6F8 File Offset: 0x000388F8
		// (set) Token: 0x06000D0B RID: 3339 RVA: 0x00007F72 File Offset: 0x00006172
		public unsafe static int MinHumanPlayers
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_MinHumanPlayers, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_MinHumanPlayers, (void*)(&value));
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x0003A714 File Offset: 0x00038914
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x00007F80 File Offset: 0x00006180
		public unsafe static int MinMatchPlayers
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_MinMatchPlayers, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_MinMatchPlayers, (void*)(&value));
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x0003A730 File Offset: 0x00038930
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x00007F8E File Offset: 0x0000618E
		public unsafe static int MaxMatchPlayers
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_MaxMatchPlayers, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_MaxMatchPlayers, (void*)(&value));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x0003A74C File Offset: 0x0003894C
		// (set) Token: 0x06000D11 RID: 3345 RVA: 0x00007F9C File Offset: 0x0000619C
		public unsafe static List<TextLocalization.Locale> _SupportedLocales_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr__SupportedLocales_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TextLocalization.Locale>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr__SupportedLocales_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x0003A774 File Offset: 0x00038974
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x00007FAE File Offset: 0x000061AE
		public unsafe static Regex EmailRegex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_EmailRegex, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_EmailRegex, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x0003A79C File Offset: 0x0003899C
		// (set) Token: 0x06000D15 RID: 3349 RVA: 0x00007FC0 File Offset: 0x000061C0
		public unsafe static List<Regex> PasswordMustContainRegex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_PasswordMustContainRegex, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Regex>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_PasswordMustContainRegex, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x0003A7C4 File Offset: 0x000389C4
		// (set) Token: 0x06000D17 RID: 3351 RVA: 0x00007FD2 File Offset: 0x000061D2
		public unsafe static Regex ScreenNameRegex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_ScreenNameRegex, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_ScreenNameRegex, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x0003A7EC File Offset: 0x000389EC
		// (set) Token: 0x06000D19 RID: 3353 RVA: 0x00007FE4 File Offset: 0x000061E4
		public unsafe static string DemoScenarioName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_DemoScenarioName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_DemoScenarioName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x0003A80C File Offset: 0x00038A0C
		// (set) Token: 0x06000D1B RID: 3355 RVA: 0x00007FF6 File Offset: 0x000061F6
		public unsafe static string FriendType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_FriendType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_FriendType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x0003A82C File Offset: 0x00038A2C
		// (set) Token: 0x06000D1D RID: 3357 RVA: 0x00008008 File Offset: 0x00006208
		public unsafe static string CameraEntityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_CameraEntityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_CameraEntityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x0003A84C File Offset: 0x00038A4C
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x0000801A File Offset: 0x0000621A
		public unsafe static string PlatformClient
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_PlatformClient, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_PlatformClient, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x0003A86C File Offset: 0x00038A6C
		// (set) Token: 0x06000D21 RID: 3361 RVA: 0x0000802C File Offset: 0x0000622C
		public unsafe static int TopLeaderboardCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_TopLeaderboardCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_TopLeaderboardCount, (void*)(&value));
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x0003A888 File Offset: 0x00038A88
		// (set) Token: 0x06000D23 RID: 3363 RVA: 0x0000803A File Offset: 0x0000623A
		public unsafe static int NearLeaderboardCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_NearLeaderboardCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_NearLeaderboardCount, (void*)(&value));
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x0003A8A4 File Offset: 0x00038AA4
		// (set) Token: 0x06000D25 RID: 3365 RVA: 0x00008048 File Offset: 0x00006248
		public unsafe static int DailyChallengeTopLeaderboardCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_DailyChallengeTopLeaderboardCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_DailyChallengeTopLeaderboardCount, (void*)(&value));
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x0003A8C0 File Offset: 0x00038AC0
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x00008056 File Offset: 0x00006256
		public unsafe static int DailyChallengeNearLeaderboardCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_DailyChallengeNearLeaderboardCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_DailyChallengeNearLeaderboardCount, (void*)(&value));
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x0003A8DC File Offset: 0x00038ADC
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x00008064 File Offset: 0x00006264
		public unsafe static string AspectRatioConfigLabel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGConstants.NativeFieldInfoPtr_AspectRatioConfigLabel, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGConstants.NativeFieldInfoPtr_AspectRatioConfigLabel, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeFieldInfoPtr_MaxLobbyPageEntries;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeFieldInfoPtr_SlowAnimationSpeed;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeFieldInfoPtr_NormalAnimationSpeed;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeFieldInfoPtr_FastAnimationSpeed;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeFieldInfoPtr_VeryFastAnimationSpeed;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeFieldInfoPtr_FastestAnimationSpeed;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeFieldInfoPtr_UIScaleSmall;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeFieldInfoPtr_UIScaleDefault;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeFieldInfoPtr_UIScaleLarge;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeFieldInfoPtr_UIScaleExtraLarge;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeFieldInfoPtr_QualityLevels;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeFieldInfoPtr_UIScaleOptionsOrder;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeFieldInfoPtr_TurnTimerAmounts;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeFieldInfoPtr_AIDifficultyLevelNames;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeFieldInfoPtr_MinHumanPlayers;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeFieldInfoPtr_MinMatchPlayers;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeFieldInfoPtr_MaxMatchPlayers;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeFieldInfoPtr__SupportedLocales_k__BackingField;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeFieldInfoPtr_EmailRegex;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeFieldInfoPtr_PasswordMustContainRegex;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeFieldInfoPtr_ScreenNameRegex;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeFieldInfoPtr_DemoScenarioName;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeFieldInfoPtr_FriendType;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeFieldInfoPtr_CameraEntityName;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeFieldInfoPtr_PlatformClient;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeFieldInfoPtr_TopLeaderboardCount;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeFieldInfoPtr_NearLeaderboardCount;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeFieldInfoPtr_DailyChallengeTopLeaderboardCount;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeFieldInfoPtr_DailyChallengeNearLeaderboardCount;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeFieldInfoPtr_AspectRatioConfigLabel;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_UIScaleToPlatform_Public_Static_UInt32_UIScale_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_PlatformToUIScale_Public_Static_UIScale_UInt32_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportedLocales_Public_Static_get_List_1_Locale_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_set_SupportedLocales_Public_Static_set_Void_List_1_Locale_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_get_PlatformClientFirstUpper_Public_Static_get_String_0;

		// Token: 0x02000250 RID: 592
		public enum QualityLevel
		{
			// Token: 0x0400109C RID: 4252
			High = 2,
			// Token: 0x0400109D RID: 4253
			Medium = 1,
			// Token: 0x0400109E RID: 4254
			Low = 0
		}

		// Token: 0x02000251 RID: 593
		public enum UIScale
		{
			// Token: 0x040010A0 RID: 4256
			Medium,
			// Token: 0x040010A1 RID: 4257
			Large,
			// Token: 0x040010A2 RID: 4258
			Small
		}

		// Token: 0x02000252 RID: 594
		public enum FriendStatuses
		{
			// Token: 0x040010A4 RID: 4260
			InviteSent,
			// Token: 0x040010A5 RID: 4261
			InviteReceived,
			// Token: 0x040010A6 RID: 4262
			Owned,
			// Token: 0x040010A7 RID: 4263
			Unowned
		}

		// Token: 0x02000253 RID: 595
		public enum AIDifficultyLevels
		{
			// Token: 0x040010A9 RID: 4265
			Easy,
			// Token: 0x040010AA RID: 4266
			Medium,
			// Token: 0x040010AB RID: 4267
			Hard
		}

		// Token: 0x02000254 RID: 596
		public enum ChallengeDifficulties
		{
			// Token: 0x040010AD RID: 4269
			Normal,
			// Token: 0x040010AE RID: 4270
			Heroic,
			// Token: 0x040010AF RID: 4271
			Legendary
		}

		// Token: 0x02000255 RID: 597
		public static class DBGHintFlavors : Object
		{
			// Token: 0x06001B74 RID: 7028 RVA: 0x00065E1C File Offset: 0x0006401C
			// Note: this type is marked as 'beforefieldinit'.
			static DBGHintFlavors()
			{
				Il2CppClassPointerStore<DBGConstants.DBGHintFlavors>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGConstants>.NativeClassPtr, "DBGHintFlavors");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGConstants.DBGHintFlavors>.NativeClassPtr);
				DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_Selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants.DBGHintFlavors>.NativeClassPtr, "Selectable");
				DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_Discard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants.DBGHintFlavors>.NativeClassPtr, "Discard");
				DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_Filtered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants.DBGHintFlavors>.NativeClassPtr, "Filtered");
				DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_FilteredSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants.DBGHintFlavors>.NativeClassPtr, "FilteredSelection");
				DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_Hinted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants.DBGHintFlavors>.NativeClassPtr, "Hinted");
				DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_Drag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants.DBGHintFlavors>.NativeClassPtr, "Drag");
				DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_Drop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGConstants.DBGHintFlavors>.NativeClassPtr, "Drop");
			}

			// Token: 0x06001B75 RID: 7029 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
			public DBGHintFlavors(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000816 RID: 2070
			// (get) Token: 0x06001B76 RID: 7030 RVA: 0x00065ED4 File Offset: 0x000640D4
			// (set) Token: 0x06001B77 RID: 7031 RVA: 0x0000EDF9 File Offset: 0x0000CFF9
			public unsafe static string Selectable
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_Selectable, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_Selectable, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000817 RID: 2071
			// (get) Token: 0x06001B78 RID: 7032 RVA: 0x00065EF4 File Offset: 0x000640F4
			// (set) Token: 0x06001B79 RID: 7033 RVA: 0x0000EE0B File Offset: 0x0000D00B
			public unsafe static string Discard
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_Discard, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_Discard, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000818 RID: 2072
			// (get) Token: 0x06001B7A RID: 7034 RVA: 0x00065F14 File Offset: 0x00064114
			// (set) Token: 0x06001B7B RID: 7035 RVA: 0x0000EE1D File Offset: 0x0000D01D
			public unsafe static string Filtered
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_Filtered, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_Filtered, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000819 RID: 2073
			// (get) Token: 0x06001B7C RID: 7036 RVA: 0x00065F34 File Offset: 0x00064134
			// (set) Token: 0x06001B7D RID: 7037 RVA: 0x0000EE2F File Offset: 0x0000D02F
			public unsafe static string FilteredSelection
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_FilteredSelection, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_FilteredSelection, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700081A RID: 2074
			// (get) Token: 0x06001B7E RID: 7038 RVA: 0x00065F54 File Offset: 0x00064154
			// (set) Token: 0x06001B7F RID: 7039 RVA: 0x0000EE41 File Offset: 0x0000D041
			public unsafe static string Hinted
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_Hinted, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_Hinted, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700081B RID: 2075
			// (get) Token: 0x06001B80 RID: 7040 RVA: 0x00065F74 File Offset: 0x00064174
			// (set) Token: 0x06001B81 RID: 7041 RVA: 0x0000EE53 File Offset: 0x0000D053
			public unsafe static string Drag
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_Drag, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_Drag, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700081C RID: 2076
			// (get) Token: 0x06001B82 RID: 7042 RVA: 0x00065F94 File Offset: 0x00064194
			// (set) Token: 0x06001B83 RID: 7043 RVA: 0x0000EE65 File Offset: 0x0000D065
			public unsafe static string Drop
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_Drop, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGConstants.DBGHintFlavors.NativeFieldInfoPtr_Drop, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040010B0 RID: 4272
			private static readonly IntPtr NativeFieldInfoPtr_Selectable;

			// Token: 0x040010B1 RID: 4273
			private static readonly IntPtr NativeFieldInfoPtr_Discard;

			// Token: 0x040010B2 RID: 4274
			private static readonly IntPtr NativeFieldInfoPtr_Filtered;

			// Token: 0x040010B3 RID: 4275
			private static readonly IntPtr NativeFieldInfoPtr_FilteredSelection;

			// Token: 0x040010B4 RID: 4276
			private static readonly IntPtr NativeFieldInfoPtr_Hinted;

			// Token: 0x040010B5 RID: 4277
			private static readonly IntPtr NativeFieldInfoPtr_Drag;

			// Token: 0x040010B6 RID: 4278
			private static readonly IntPtr NativeFieldInfoPtr_Drop;
		}
	}
}
