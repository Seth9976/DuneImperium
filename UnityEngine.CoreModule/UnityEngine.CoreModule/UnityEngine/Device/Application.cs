using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Threading;
using UnityEngine.Events;

namespace UnityEngine.Device
{
	// Token: 0x02000269 RID: 617
	public static class Application : Object
	{
		// Token: 0x06002AB4 RID: 10932 RVA: 0x000ADFCC File Offset: 0x000AC1CC
		// Note: this type is marked as 'beforefieldinit'.
		static Application()
		{
			Il2CppClassPointerStore<Application>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Device", "Application");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Application>.NativeClassPtr);
			Application.NativeMethodInfoPtr_get_isMobilePlatform_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100668581);
			Application.NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100668582);
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06002AB5 RID: 10933 RVA: 0x000AE024 File Offset: 0x000AC224
		public unsafe static bool isMobilePlatform
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685898, RefRangeEnd = 685899, XrefRangeStart = 685894, XrefRangeEnd = 685898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isMobilePlatform_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06002AB6 RID: 10934 RVA: 0x000AE054 File Offset: 0x000AC254
		public unsafe static RuntimePlatform platform
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 685903, RefRangeEnd = 685907, XrefRangeStart = 685899, XrefRangeEnd = 685903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x00010B3C File Offset: 0x0000ED3C
		public Application(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06002AB8 RID: 10936 RVA: 0x00010B45 File Offset: 0x0000ED45
		public static string absoluteURL
		{
			get
			{
				return Application.absoluteURL;
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06002AB9 RID: 10937 RVA: 0x00010B4C File Offset: 0x0000ED4C
		// (set) Token: 0x06002ABA RID: 10938 RVA: 0x00010B53 File Offset: 0x0000ED53
		public static ThreadPriority backgroundLoadingPriority
		{
			get
			{
				return Application.backgroundLoadingPriority;
			}
			set
			{
				Application.backgroundLoadingPriority = value;
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06002ABB RID: 10939 RVA: 0x00010B5C File Offset: 0x0000ED5C
		public static string buildGUID
		{
			get
			{
				return Application.buildGUID;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06002ABC RID: 10940 RVA: 0x00010B63 File Offset: 0x0000ED63
		public static string cloudProjectId
		{
			get
			{
				return Application.cloudProjectId;
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06002ABD RID: 10941 RVA: 0x00010B6A File Offset: 0x0000ED6A
		public static string companyName
		{
			get
			{
				return Application.companyName;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06002ABE RID: 10942 RVA: 0x00010B71 File Offset: 0x0000ED71
		public static string consoleLogPath
		{
			get
			{
				return Application.consoleLogPath;
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06002ABF RID: 10943 RVA: 0x00010B78 File Offset: 0x0000ED78
		public static string dataPath
		{
			get
			{
				return Application.dataPath;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x00010B7F File Offset: 0x0000ED7F
		public static bool genuine
		{
			get
			{
				return Application.genuine;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x00010B86 File Offset: 0x0000ED86
		public static bool genuineCheckAvailable
		{
			get
			{
				return Application.genuineCheckAvailable;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x00010B8D File Offset: 0x0000ED8D
		public static string identifier
		{
			get
			{
				return Application.identifier;
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x00010B94 File Offset: 0x0000ED94
		public static string installerName
		{
			get
			{
				return Application.installerName;
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x00010B9B File Offset: 0x0000ED9B
		public static ApplicationInstallMode installMode
		{
			get
			{
				return Application.installMode;
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06002AC5 RID: 10949 RVA: 0x00010BA2 File Offset: 0x0000EDA2
		public static NetworkReachability internetReachability
		{
			get
			{
				return Application.internetReachability;
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06002AC6 RID: 10950 RVA: 0x00010BA9 File Offset: 0x0000EDA9
		public static bool isBatchMode
		{
			get
			{
				return Application.isBatchMode;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x00010BB0 File Offset: 0x0000EDB0
		public static bool isConsolePlatform
		{
			get
			{
				return Application.isConsolePlatform;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06002AC8 RID: 10952 RVA: 0x00010BB7 File Offset: 0x0000EDB7
		public static bool isEditor
		{
			get
			{
				return Application.isEditor;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x00010BBE File Offset: 0x0000EDBE
		public static bool isFocused
		{
			get
			{
				return Application.isFocused;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06002ACA RID: 10954 RVA: 0x00010BC5 File Offset: 0x0000EDC5
		public static bool isPlaying
		{
			get
			{
				return Application.isPlaying;
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x00010BCC File Offset: 0x0000EDCC
		public static string persistentDataPath
		{
			get
			{
				return Application.persistentDataPath;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06002ACC RID: 10956 RVA: 0x00010BD3 File Offset: 0x0000EDD3
		public static string productName
		{
			get
			{
				return Application.productName;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06002ACD RID: 10957 RVA: 0x00010BDA File Offset: 0x0000EDDA
		// (set) Token: 0x06002ACE RID: 10958 RVA: 0x00010BE1 File Offset: 0x0000EDE1
		public static bool runInBackground
		{
			get
			{
				return Application.runInBackground;
			}
			set
			{
				Application.runInBackground = value;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06002ACF RID: 10959 RVA: 0x00010BEA File Offset: 0x0000EDEA
		public static ApplicationSandboxType sandboxType
		{
			get
			{
				return Application.sandboxType;
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06002AD0 RID: 10960 RVA: 0x00010BF1 File Offset: 0x0000EDF1
		public static string streamingAssetsPath
		{
			get
			{
				return Application.streamingAssetsPath;
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06002AD1 RID: 10961 RVA: 0x00010BF8 File Offset: 0x0000EDF8
		public static SystemLanguage systemLanguage
		{
			get
			{
				return Application.systemLanguage;
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06002AD2 RID: 10962 RVA: 0x00010BFF File Offset: 0x0000EDFF
		// (set) Token: 0x06002AD3 RID: 10963 RVA: 0x00010C06 File Offset: 0x0000EE06
		public static int targetFrameRate
		{
			get
			{
				return Application.targetFrameRate;
			}
			set
			{
				Application.targetFrameRate = value;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06002AD4 RID: 10964 RVA: 0x00010C0F File Offset: 0x0000EE0F
		public static string temporaryCachePath
		{
			get
			{
				return Application.temporaryCachePath;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x00010C16 File Offset: 0x0000EE16
		public static string unityVersion
		{
			get
			{
				return Application.unityVersion;
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06002AD6 RID: 10966 RVA: 0x00010C1D File Offset: 0x0000EE1D
		public static string version
		{
			get
			{
				return Application.version;
			}
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x00010C24 File Offset: 0x0000EE24
		public static void add_deepLinkActivated(Action<string> value)
		{
			Application.add_deepLinkActivated(value);
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x00010C2D File Offset: 0x0000EE2D
		public static void remove_deepLinkActivated(Action<string> value)
		{
			Application.remove_deepLinkActivated(value);
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x00010C36 File Offset: 0x0000EE36
		public static void add_focusChanged(Action<bool> value)
		{
			Application.add_focusChanged(value);
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static void remove_focusChanged(Action<bool> value)
		{
			Application.remove_focusChanged(value);
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x00010C48 File Offset: 0x0000EE48
		public static void add_logMessageReceived(Application.LogCallback value)
		{
			Application.add_logMessageReceived(value);
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x00010C51 File Offset: 0x0000EE51
		public static void remove_logMessageReceived(Application.LogCallback value)
		{
			Application.remove_logMessageReceived(value);
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x00010C5A File Offset: 0x0000EE5A
		public static void add_logMessageReceivedThreaded(Application.LogCallback value)
		{
			Application.add_logMessageReceivedThreaded(value);
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x00010C63 File Offset: 0x0000EE63
		public static void remove_logMessageReceivedThreaded(Application.LogCallback value)
		{
			Application.remove_logMessageReceivedThreaded(value);
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x00010C6C File Offset: 0x0000EE6C
		public static void add_lowMemory(Application.LowMemoryCallback value)
		{
			Application.add_lowMemory(value);
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x00010C75 File Offset: 0x0000EE75
		public static void remove_lowMemory(Application.LowMemoryCallback value)
		{
			Application.remove_lowMemory(value);
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x00010C7E File Offset: 0x0000EE7E
		public static void add_memoryUsageChanged(Application.MemoryUsageChangedCallback value)
		{
			Application.add_memoryUsageChanged(value);
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x00010C87 File Offset: 0x0000EE87
		public static void remove_memoryUsageChanged(Application.MemoryUsageChangedCallback value)
		{
			Application.remove_memoryUsageChanged(value);
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x00010C90 File Offset: 0x0000EE90
		public static void add_onBeforeRender(UnityEngine.Events.UnityAction value)
		{
			Application.add_onBeforeRender(value);
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x00010C99 File Offset: 0x0000EE99
		public static void remove_onBeforeRender(UnityEngine.Events.UnityAction value)
		{
			Application.remove_onBeforeRender(value);
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x00010CA2 File Offset: 0x0000EEA2
		public static void add_quitting(Action value)
		{
			Application.add_quitting(value);
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x00010CAB File Offset: 0x0000EEAB
		public static void remove_quitting(Action value)
		{
			Application.remove_quitting(value);
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x00010CB4 File Offset: 0x0000EEB4
		public static void add_wantsToQuit(Func<bool> value)
		{
			Application.add_wantsToQuit(value);
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x00010CBD File Offset: 0x0000EEBD
		public static void remove_wantsToQuit(Func<bool> value)
		{
			Application.remove_wantsToQuit(value);
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x00010CC6 File Offset: 0x0000EEC6
		public static void add_unloading(Action value)
		{
			Application.add_unloading(value);
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x00010CCF File Offset: 0x0000EECF
		public static void remove_unloading(Action value)
		{
			Application.remove_unloading(value);
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x000AE084 File Offset: 0x000AC284
		public static bool CanStreamedLevelBeLoaded(int levelIndex)
		{
			return Application.CanStreamedLevelBeLoaded(levelIndex);
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x000AE09C File Offset: 0x000AC29C
		public static bool CanStreamedLevelBeLoaded(string levelName)
		{
			return Application.CanStreamedLevelBeLoaded(levelName);
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x000AE0B4 File Offset: 0x000AC2B4
		public static Il2CppStringArray GetBuildTags()
		{
			return Application.GetBuildTags();
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x00010CD8 File Offset: 0x0000EED8
		public static void SetBuildTags(Il2CppStringArray buildTags)
		{
			Application.SetBuildTags(buildTags);
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x000AE0CC File Offset: 0x000AC2CC
		public static StackTraceLogType GetStackTraceLogType(LogType logType)
		{
			return Application.GetStackTraceLogType(logType);
		}

		// Token: 0x06002AF0 RID: 10992 RVA: 0x000AE0E4 File Offset: 0x000AC2E4
		public static bool HasProLicense()
		{
			return Application.HasProLicense();
		}

		// Token: 0x06002AF1 RID: 10993 RVA: 0x000AE0FC File Offset: 0x000AC2FC
		public static bool HasUserAuthorization(UserAuthorization mode)
		{
			return Application.HasUserAuthorization(mode);
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x000AE114 File Offset: 0x000AC314
		public static bool IsPlaying(Object obj)
		{
			return Application.IsPlaying(obj);
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x00010CE2 File Offset: 0x0000EEE2
		public static void OpenURL(string url)
		{
			Application.OpenURL(url);
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x00010CEC File Offset: 0x0000EEEC
		public static void Quit()
		{
			Application.Quit();
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x00010CF5 File Offset: 0x0000EEF5
		public static void Quit(int exitCode)
		{
			Application.Quit(exitCode);
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x000AE12C File Offset: 0x000AC32C
		public static AsyncOperation RequestUserAuthorization(UserAuthorization mode)
		{
			return Application.RequestUserAuthorization(mode);
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x00010CFF File Offset: 0x0000EEFF
		public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType)
		{
			Application.SetStackTraceLogType(logType, stackTraceType);
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x00010D0A File Offset: 0x0000EF0A
		public static void Unload()
		{
			Application.Unload();
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06002AF9 RID: 11001 RVA: 0x00010D13 File Offset: 0x0000EF13
		public static CancellationToken exitCancellationToken
		{
			get
			{
				return Application.exitCancellationToken;
			}
		}

		// Token: 0x04002567 RID: 9575
		private static readonly IntPtr NativeMethodInfoPtr_get_isMobilePlatform_Public_Static_get_Boolean_0;

		// Token: 0x04002568 RID: 9576
		private static readonly IntPtr NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0;
	}
}
