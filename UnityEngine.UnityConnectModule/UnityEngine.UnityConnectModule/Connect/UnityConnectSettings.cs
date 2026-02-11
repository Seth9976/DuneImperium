using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Connect
{
	// Token: 0x02000002 RID: 2
	public class UnityConnectSettings : Object
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000003 RID: 3 RVA: 0x0000205C File Offset: 0x0000025C
		public static bool enabled
		{
			get
			{
				return UnityConnectSettings.get_enabledDelegateField();
			}
			set
			{
				UnityConnectSettings.set_enabledDelegateField(value);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002069 File Offset: 0x00000269
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002075 File Offset: 0x00000275
		public static bool testMode
		{
			get
			{
				return UnityConnectSettings.get_testModeDelegateField();
			}
			set
			{
				UnityConnectSettings.set_testModeDelegateField(value);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000021F8 File Offset: 0x000003F8
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002082 File Offset: 0x00000282
		public static string eventUrl
		{
			get
			{
				IntPtr intPtr = UnityConnectSettings.get_eventUrlDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				UnityConnectSettings.set_eventUrlDelegateField(IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002218 File Offset: 0x00000418
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002094 File Offset: 0x00000294
		public static string eventOldUrl
		{
			get
			{
				IntPtr intPtr = UnityConnectSettings.get_eventOldUrlDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				UnityConnectSettings.set_eventOldUrlDelegateField(IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002238 File Offset: 0x00000438
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000020A6 File Offset: 0x000002A6
		public static string configUrl
		{
			get
			{
				IntPtr intPtr = UnityConnectSettings.get_configUrlDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				UnityConnectSettings.set_configUrlDelegateField(IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020B8 File Offset: 0x000002B8
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000020C4 File Offset: 0x000002C4
		public static int testInitMode
		{
			get
			{
				return UnityConnectSettings.get_testInitModeDelegateField();
			}
			set
			{
				UnityConnectSettings.set_testInitModeDelegateField(value);
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly UnityConnectSettings.get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.get_enabledDelegate>("UnityEngine.Connect.UnityConnectSettings::get_enabled");

		// Token: 0x04000002 RID: 2
		private static readonly UnityConnectSettings.set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.set_enabledDelegate>("UnityEngine.Connect.UnityConnectSettings::set_enabled");

		// Token: 0x04000003 RID: 3
		private static readonly UnityConnectSettings.get_testModeDelegate get_testModeDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.get_testModeDelegate>("UnityEngine.Connect.UnityConnectSettings::get_testMode");

		// Token: 0x04000004 RID: 4
		private static readonly UnityConnectSettings.set_testModeDelegate set_testModeDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.set_testModeDelegate>("UnityEngine.Connect.UnityConnectSettings::set_testMode");

		// Token: 0x04000005 RID: 5
		private static readonly UnityConnectSettings.get_eventUrlDelegate get_eventUrlDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.get_eventUrlDelegate>("UnityEngine.Connect.UnityConnectSettings::get_eventUrl");

		// Token: 0x04000006 RID: 6
		private static readonly UnityConnectSettings.set_eventUrlDelegate set_eventUrlDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.set_eventUrlDelegate>("UnityEngine.Connect.UnityConnectSettings::set_eventUrl");

		// Token: 0x04000007 RID: 7
		private static readonly UnityConnectSettings.get_eventOldUrlDelegate get_eventOldUrlDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.get_eventOldUrlDelegate>("UnityEngine.Connect.UnityConnectSettings::get_eventOldUrl");

		// Token: 0x04000008 RID: 8
		private static readonly UnityConnectSettings.set_eventOldUrlDelegate set_eventOldUrlDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.set_eventOldUrlDelegate>("UnityEngine.Connect.UnityConnectSettings::set_eventOldUrl");

		// Token: 0x04000009 RID: 9
		private static readonly UnityConnectSettings.get_configUrlDelegate get_configUrlDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.get_configUrlDelegate>("UnityEngine.Connect.UnityConnectSettings::get_configUrl");

		// Token: 0x0400000A RID: 10
		private static readonly UnityConnectSettings.set_configUrlDelegate set_configUrlDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.set_configUrlDelegate>("UnityEngine.Connect.UnityConnectSettings::set_configUrl");

		// Token: 0x0400000B RID: 11
		private static readonly UnityConnectSettings.get_testInitModeDelegate get_testInitModeDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.get_testInitModeDelegate>("UnityEngine.Connect.UnityConnectSettings::get_testInitMode");

		// Token: 0x0400000C RID: 12
		private static readonly UnityConnectSettings.set_testInitModeDelegate set_testInitModeDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.set_testInitModeDelegate>("UnityEngine.Connect.UnityConnectSettings::set_testInitMode");

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x0600001A RID: 26
		private delegate bool get_enabledDelegate();

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600001C RID: 28
		private delegate void set_enabledDelegate(bool value);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x0600001E RID: 30
		private delegate bool get_testModeDelegate();

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000020 RID: 32
		private delegate void set_testModeDelegate(bool value);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000022 RID: 34
		private delegate IntPtr get_eventUrlDelegate();

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000024 RID: 36
		private delegate void set_eventUrlDelegate(IntPtr value);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000026 RID: 38
		private delegate IntPtr get_eventOldUrlDelegate();

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000028 RID: 40
		private delegate void set_eventOldUrlDelegate(IntPtr value);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x0600002A RID: 42
		private delegate IntPtr get_configUrlDelegate();

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x0600002C RID: 44
		private delegate void set_configUrlDelegate(IntPtr value);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x0600002E RID: 46
		private delegate int get_testInitModeDelegate();

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000030 RID: 48
		private delegate void set_testInitModeDelegate(int value);
	}
}
