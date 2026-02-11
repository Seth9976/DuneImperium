using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Advertisements
{
	// Token: 0x02000003 RID: 3
	public static class UnityAdsSettings
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000020D1 File Offset: 0x000002D1
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000020DD File Offset: 0x000002DD
		public static bool enabled
		{
			get
			{
				return UnityAdsSettings.get_enabledDelegateField();
			}
			set
			{
				UnityAdsSettings.set_enabledDelegateField(value);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000022E0 File Offset: 0x000004E0
		public static bool IsPlatformEnabled(RuntimePlatform platform)
		{
			return true;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020EA File Offset: 0x000002EA
		public static void SetPlatformEnabled(RuntimePlatform platform, bool value)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000020ED File Offset: 0x000002ED
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000020F9 File Offset: 0x000002F9
		public static bool initializeOnStartup
		{
			get
			{
				return UnityAdsSettings.get_initializeOnStartupDelegateField();
			}
			set
			{
				UnityAdsSettings.set_initializeOnStartupDelegateField(value);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002106 File Offset: 0x00000306
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002112 File Offset: 0x00000312
		public static bool testMode
		{
			get
			{
				return UnityAdsSettings.get_testModeDelegateField();
			}
			set
			{
				UnityAdsSettings.set_testModeDelegateField(value);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000022F4 File Offset: 0x000004F4
		public static string GetGameId(RuntimePlatform platform)
		{
			IntPtr intPtr = UnityAdsSettings.GetGameIdDelegateField(platform);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000211F File Offset: 0x0000031F
		public static void SetGameId(RuntimePlatform platform, string gameId)
		{
			UnityAdsSettings.SetGameIdDelegateField(platform, IL2CPP.ManagedStringToIl2Cpp(gameId));
		}

		// Token: 0x0400000D RID: 13
		private static readonly UnityAdsSettings.get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<UnityAdsSettings.get_enabledDelegate>("UnityEngine.Advertisements.UnityAdsSettings::get_enabled");

		// Token: 0x0400000E RID: 14
		private static readonly UnityAdsSettings.set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<UnityAdsSettings.set_enabledDelegate>("UnityEngine.Advertisements.UnityAdsSettings::set_enabled");

		// Token: 0x0400000F RID: 15
		private static readonly UnityAdsSettings.get_initializeOnStartupDelegate get_initializeOnStartupDelegateField = IL2CPP.ResolveICall<UnityAdsSettings.get_initializeOnStartupDelegate>("UnityEngine.Advertisements.UnityAdsSettings::get_initializeOnStartup");

		// Token: 0x04000010 RID: 16
		private static readonly UnityAdsSettings.set_initializeOnStartupDelegate set_initializeOnStartupDelegateField = IL2CPP.ResolveICall<UnityAdsSettings.set_initializeOnStartupDelegate>("UnityEngine.Advertisements.UnityAdsSettings::set_initializeOnStartup");

		// Token: 0x04000011 RID: 17
		private static readonly UnityAdsSettings.get_testModeDelegate get_testModeDelegateField = IL2CPP.ResolveICall<UnityAdsSettings.get_testModeDelegate>("UnityEngine.Advertisements.UnityAdsSettings::get_testMode");

		// Token: 0x04000012 RID: 18
		private static readonly UnityAdsSettings.set_testModeDelegate set_testModeDelegateField = IL2CPP.ResolveICall<UnityAdsSettings.set_testModeDelegate>("UnityEngine.Advertisements.UnityAdsSettings::set_testMode");

		// Token: 0x04000013 RID: 19
		private static readonly UnityAdsSettings.GetGameIdDelegate GetGameIdDelegateField = IL2CPP.ResolveICall<UnityAdsSettings.GetGameIdDelegate>("UnityEngine.Advertisements.UnityAdsSettings::GetGameId");

		// Token: 0x04000014 RID: 20
		private static readonly UnityAdsSettings.SetGameIdDelegate SetGameIdDelegateField = IL2CPP.ResolveICall<UnityAdsSettings.SetGameIdDelegate>("UnityEngine.Advertisements.UnityAdsSettings::SetGameId");

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x06000032 RID: 50
		private delegate bool get_enabledDelegate();

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x06000034 RID: 52
		private delegate void set_enabledDelegate(bool value);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x06000036 RID: 54
		private delegate bool get_initializeOnStartupDelegate();

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x06000038 RID: 56
		private delegate void set_initializeOnStartupDelegate(bool value);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x0600003A RID: 58
		private delegate bool get_testModeDelegate();

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x0600003C RID: 60
		private delegate void set_testModeDelegate(bool value);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x0600003E RID: 62
		private delegate IntPtr GetGameIdDelegate(RuntimePlatform platform);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x06000040 RID: 64
		private delegate void SetGameIdDelegate(RuntimePlatform platform, IntPtr gameId);
	}
}
