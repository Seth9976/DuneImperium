using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;
using Il2CppSystem.Threading;
using UnityEngine.Diagnostics;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x02000068 RID: 104
	public class Application : Object
	{
		// Token: 0x0600036C RID: 876 RVA: 0x00020058 File Offset: 0x0001E258
		// Note: this type is marked as 'beforefieldinit'.
		static Application()
		{
			Il2CppClassPointerStore<Application>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Application");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Application>.NativeClassPtr);
			Application.NativeFieldInfoPtr_lowMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "lowMemory");
			Application.NativeFieldInfoPtr_memoryUsageChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "memoryUsageChanged");
			Application.NativeFieldInfoPtr_s_LogCallbackHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "s_LogCallbackHandler");
			Application.NativeFieldInfoPtr_s_LogCallbackHandlerThreaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "s_LogCallbackHandlerThreaded");
			Application.NativeFieldInfoPtr_focusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "focusChanged");
			Application.NativeFieldInfoPtr_deepLinkActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "deepLinkActivated");
			Application.NativeFieldInfoPtr_wantsToQuit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "wantsToQuit");
			Application.NativeFieldInfoPtr_quitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "quitting");
			Application.NativeFieldInfoPtr_unloading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "unloading");
			Application.NativeFieldInfoPtr_s_currentCancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "s_currentCancellationTokenSource");
			Application.NativeMethodInfoPtr_Quit_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663641);
			Application.NativeMethodInfoPtr_Quit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663642);
			Application.NativeMethodInfoPtr_get_isPlaying_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663643);
			Application.NativeMethodInfoPtr_get_isFocused_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663644);
			Application.NativeMethodInfoPtr_get_isBatchMode_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663645);
			Application.NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663646);
			Application.NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663647);
			Application.NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663648);
			Application.NativeMethodInfoPtr_get_temporaryCachePath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663649);
			Application.NativeMethodInfoPtr_get_absoluteURL_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663650);
			Application.NativeMethodInfoPtr_get_unityVersion_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663651);
			Application.NativeMethodInfoPtr_get_identifier_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663652);
			Application.NativeMethodInfoPtr_get_productName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663653);
			Application.NativeMethodInfoPtr_OpenURL_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663654);
			Application.NativeMethodInfoPtr_get_targetFrameRate_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663655);
			Application.NativeMethodInfoPtr_set_targetFrameRate_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663656);
			Application.NativeMethodInfoPtr_SetLogCallbackDefined_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663657);
			Application.NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663658);
			Application.NativeMethodInfoPtr_get_isMobilePlatform_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663659);
			Application.NativeMethodInfoPtr_get_isConsolePlatform_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663660);
			Application.NativeMethodInfoPtr_get_systemLanguage_Public_Static_get_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663661);
			Application.NativeMethodInfoPtr_get_internetReachability_Public_Static_get_NetworkReachability_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663662);
			Application.NativeMethodInfoPtr_add_lowMemory_Public_Static_add_Void_LowMemoryCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663663);
			Application.NativeMethodInfoPtr_remove_lowMemory_Public_Static_rem_Void_LowMemoryCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663664);
			Application.NativeMethodInfoPtr_CallLowMemory_Internal_Static_Void_ApplicationMemoryUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663665);
			Application.NativeMethodInfoPtr_HasLogCallback_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663666);
			Application.NativeMethodInfoPtr_add_logMessageReceivedThreaded_Public_Static_add_Void_LogCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663667);
			Application.NativeMethodInfoPtr_remove_logMessageReceivedThreaded_Public_Static_rem_Void_LogCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663668);
			Application.NativeMethodInfoPtr_CallLogCallback_Private_Static_Void_String_String_LogType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663669);
			Application.NativeMethodInfoPtr_add_deepLinkActivated_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663670);
			Application.NativeMethodInfoPtr_remove_deepLinkActivated_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663671);
			Application.NativeMethodInfoPtr_add_wantsToQuit_Public_Static_add_Void_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663672);
			Application.NativeMethodInfoPtr_remove_wantsToQuit_Public_Static_rem_Void_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663673);
			Application.NativeMethodInfoPtr_Internal_ApplicationWantsToQuit_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663674);
			Application.NativeMethodInfoPtr_get_exitCancellationToken_Public_Static_get_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663675);
			Application.NativeMethodInfoPtr_Internal_ApplicationInit_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663676);
			Application.NativeMethodInfoPtr_Internal_ApplicationQuit_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663677);
			Application.NativeMethodInfoPtr_Internal_ApplicationUnload_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663678);
			Application.NativeMethodInfoPtr_InvokeOnBeforeRender_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663679);
			Application.NativeMethodInfoPtr_InvokeFocusChanged_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663680);
			Application.NativeMethodInfoPtr_InvokeDeepLinkActivated_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663681);
			Application.NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663682);
			Application.CancelQuitDelegateField = IL2CPP.ResolveICall<Application.CancelQuitDelegate>("UnityEngine.Application::CancelQuit");
			Application.UnloadDelegateField = IL2CPP.ResolveICall<Application.UnloadDelegate>("UnityEngine.Application::Unload");
			Application.get_isLoadingLevelDelegateField = IL2CPP.ResolveICall<Application.get_isLoadingLevelDelegate>("UnityEngine.Application::get_isLoadingLevel");
			Application.SimulateMemoryUsageDelegateField = IL2CPP.ResolveICall<Application.SimulateMemoryUsageDelegate>("UnityEngine.Application::SimulateMemoryUsage");
			Application.CanStreamedLevelBeLoadedDelegateField = IL2CPP.ResolveICall<Application.CanStreamedLevelBeLoadedDelegate>("UnityEngine.Application::CanStreamedLevelBeLoaded");
			Application.IsPlayingDelegateField = IL2CPP.ResolveICall<Application.IsPlayingDelegate>("UnityEngine.Application::IsPlaying");
			Application.GetBuildTagsDelegateField = IL2CPP.ResolveICall<Application.GetBuildTagsDelegate>("UnityEngine.Application::GetBuildTags");
			Application.SetBuildTagsDelegateField = IL2CPP.ResolveICall<Application.SetBuildTagsDelegate>("UnityEngine.Application::SetBuildTags");
			Application.get_buildGUIDDelegateField = IL2CPP.ResolveICall<Application.get_buildGUIDDelegate>("UnityEngine.Application::get_buildGUID");
			Application.get_runInBackgroundDelegateField = IL2CPP.ResolveICall<Application.get_runInBackgroundDelegate>("UnityEngine.Application::get_runInBackground");
			Application.set_runInBackgroundDelegateField = IL2CPP.ResolveICall<Application.set_runInBackgroundDelegate>("UnityEngine.Application::set_runInBackground");
			Application.HasProLicenseDelegateField = IL2CPP.ResolveICall<Application.HasProLicenseDelegate>("UnityEngine.Application::HasProLicense");
			Application.get_isTestRunDelegateField = IL2CPP.ResolveICall<Application.get_isTestRunDelegate>("UnityEngine.Application::get_isTestRun");
			Application.get_isHumanControllingUsDelegateField = IL2CPP.ResolveICall<Application.get_isHumanControllingUsDelegate>("UnityEngine.Application::get_isHumanControllingUs");
			Application.HasARGVDelegateField = IL2CPP.ResolveICall<Application.HasARGVDelegate>("UnityEngine.Application::HasARGV");
			Application.GetValueForARGVDelegateField = IL2CPP.ResolveICall<Application.GetValueForARGVDelegate>("UnityEngine.Application::GetValueForARGV");
			Application.Internal_ExternalCallDelegateField = IL2CPP.ResolveICall<Application.Internal_ExternalCallDelegate>("UnityEngine.Application::Internal_ExternalCall");
			Application.get_unityVersionVerDelegateField = IL2CPP.ResolveICall<Application.get_unityVersionVerDelegate>("UnityEngine.Application::get_unityVersionVer");
			Application.get_unityVersionMajDelegateField = IL2CPP.ResolveICall<Application.get_unityVersionMajDelegate>("UnityEngine.Application::get_unityVersionMaj");
			Application.get_unityVersionMinDelegateField = IL2CPP.ResolveICall<Application.get_unityVersionMinDelegate>("UnityEngine.Application::get_unityVersionMin");
			Application.get_versionDelegateField = IL2CPP.ResolveICall<Application.get_versionDelegate>("UnityEngine.Application::get_version");
			Application.get_installerNameDelegateField = IL2CPP.ResolveICall<Application.get_installerNameDelegate>("UnityEngine.Application::get_installerName");
			Application.get_installModeDelegateField = IL2CPP.ResolveICall<Application.get_installModeDelegate>("UnityEngine.Application::get_installMode");
			Application.get_sandboxTypeDelegateField = IL2CPP.ResolveICall<Application.get_sandboxTypeDelegate>("UnityEngine.Application::get_sandboxType");
			Application.get_companyNameDelegateField = IL2CPP.ResolveICall<Application.get_companyNameDelegate>("UnityEngine.Application::get_companyName");
			Application.get_cloudProjectIdDelegateField = IL2CPP.ResolveICall<Application.get_cloudProjectIdDelegate>("UnityEngine.Application::get_cloudProjectId");
			Application.get_stackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.get_stackTraceLogTypeDelegate>("UnityEngine.Application::get_stackTraceLogType");
			Application.set_stackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.set_stackTraceLogTypeDelegate>("UnityEngine.Application::set_stackTraceLogType");
			Application.GetStackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.GetStackTraceLogTypeDelegate>("UnityEngine.Application::GetStackTraceLogType");
			Application.SetStackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.SetStackTraceLogTypeDelegate>("UnityEngine.Application::SetStackTraceLogType");
			Application.get_consoleLogPathDelegateField = IL2CPP.ResolveICall<Application.get_consoleLogPathDelegate>("UnityEngine.Application::get_consoleLogPath");
			Application.get_backgroundLoadingPriorityDelegateField = IL2CPP.ResolveICall<Application.get_backgroundLoadingPriorityDelegate>("UnityEngine.Application::get_backgroundLoadingPriority");
			Application.set_backgroundLoadingPriorityDelegateField = IL2CPP.ResolveICall<Application.set_backgroundLoadingPriorityDelegate>("UnityEngine.Application::set_backgroundLoadingPriority");
			Application.get_genuineDelegateField = IL2CPP.ResolveICall<Application.get_genuineDelegate>("UnityEngine.Application::get_genuine");
			Application.get_genuineCheckAvailableDelegateField = IL2CPP.ResolveICall<Application.get_genuineCheckAvailableDelegate>("UnityEngine.Application::get_genuineCheckAvailable");
			Application.RequestUserAuthorizationDelegateField = IL2CPP.ResolveICall<Application.RequestUserAuthorizationDelegate>("UnityEngine.Application::RequestUserAuthorization");
			Application.HasUserAuthorizationDelegateField = IL2CPP.ResolveICall<Application.HasUserAuthorizationDelegate>("UnityEngine.Application::HasUserAuthorization");
			Application.get_submitAnalyticsDelegateField = IL2CPP.ResolveICall<Application.get_submitAnalyticsDelegate>("UnityEngine.Application::get_submitAnalytics");
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000206D4 File Offset: 0x0001E8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644641, XrefRangeEnd = 644643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Quit(int exitCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref exitCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Quit_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00020708 File Offset: 0x0001E908
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 644648, RefRangeEnd = 644651, XrefRangeStart = 644643, XrefRangeEnd = 644648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Quit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Quit_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00020730 File Offset: 0x0001E930
		public unsafe static bool isPlaying
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 644653, RefRangeEnd = 644693, XrefRangeStart = 644651, XrefRangeEnd = 644653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isPlaying_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00020760 File Offset: 0x0001E960
		public unsafe static bool isFocused
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 644695, RefRangeEnd = 644697, XrefRangeStart = 644693, XrefRangeEnd = 644695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isFocused_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000371 RID: 881 RVA: 0x00020790 File Offset: 0x0001E990
		public unsafe static bool isBatchMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 644699, RefRangeEnd = 644700, XrefRangeStart = 644697, XrefRangeEnd = 644699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isBatchMode_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000372 RID: 882 RVA: 0x000207C0 File Offset: 0x0001E9C0
		public unsafe static string dataPath
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 644702, RefRangeEnd = 644709, XrefRangeStart = 644700, XrefRangeEnd = 644702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000373 RID: 883 RVA: 0x000207EC File Offset: 0x0001E9EC
		public unsafe static string streamingAssetsPath
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 644711, RefRangeEnd = 644719, XrefRangeStart = 644709, XrefRangeEnd = 644711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00020818 File Offset: 0x0001EA18
		public unsafe static string persistentDataPath
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 644721, RefRangeEnd = 644739, XrefRangeStart = 644719, XrefRangeEnd = 644721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00020844 File Offset: 0x0001EA44
		public unsafe static string temporaryCachePath
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 644741, RefRangeEnd = 644744, XrefRangeStart = 644739, XrefRangeEnd = 644741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_temporaryCachePath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00020870 File Offset: 0x0001EA70
		public unsafe static string absoluteURL
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 644746, RefRangeEnd = 644748, XrefRangeStart = 644744, XrefRangeEnd = 644746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_absoluteURL_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0002089C File Offset: 0x0001EA9C
		public unsafe static string unityVersion
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 644750, RefRangeEnd = 644751, XrefRangeStart = 644748, XrefRangeEnd = 644750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_unityVersion_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000378 RID: 888 RVA: 0x000208C8 File Offset: 0x0001EAC8
		public unsafe static string identifier
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 644753, RefRangeEnd = 644754, XrefRangeStart = 644751, XrefRangeEnd = 644753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_identifier_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000379 RID: 889 RVA: 0x000208F4 File Offset: 0x0001EAF4
		public unsafe static string productName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 644756, RefRangeEnd = 644759, XrefRangeStart = 644754, XrefRangeEnd = 644756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_productName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00020920 File Offset: 0x0001EB20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 644761, RefRangeEnd = 644763, XrefRangeStart = 644759, XrefRangeEnd = 644761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenURL(string url)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_OpenURL_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00020958 File Offset: 0x0001EB58
		// (set) Token: 0x0600037C RID: 892 RVA: 0x00020988 File Offset: 0x0001EB88
		public unsafe static int targetFrameRate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 644765, RefRangeEnd = 644766, XrefRangeStart = 644763, XrefRangeEnd = 644765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_targetFrameRate_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 644768, RefRangeEnd = 644772, XrefRangeStart = 644766, XrefRangeEnd = 644768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_set_targetFrameRate_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000209BC File Offset: 0x0001EBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644772, XrefRangeEnd = 644782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLogCallbackDefined(bool defined)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref defined;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_SetLogCallbackDefined_Private_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600037E RID: 894 RVA: 0x000209F0 File Offset: 0x0001EBF0
		public unsafe static RuntimePlatform platform
		{
			[CallerCount(128)]
			[CachedScanResults(RefRangeStart = 644784, RefRangeEnd = 644912, XrefRangeStart = 644782, XrefRangeEnd = 644784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00020A20 File Offset: 0x0001EC20
		public unsafe static bool isMobilePlatform
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 644918, RefRangeEnd = 644938, XrefRangeStart = 644912, XrefRangeEnd = 644918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isMobilePlatform_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00020A50 File Offset: 0x0001EC50
		public unsafe static bool isConsolePlatform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 644943, RefRangeEnd = 644945, XrefRangeStart = 644938, XrefRangeEnd = 644943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isConsolePlatform_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00020A80 File Offset: 0x0001EC80
		public unsafe static SystemLanguage systemLanguage
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 644947, RefRangeEnd = 644952, XrefRangeStart = 644945, XrefRangeEnd = 644947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_systemLanguage_Public_Static_get_SystemLanguage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00020AB0 File Offset: 0x0001ECB0
		public unsafe static NetworkReachability internetReachability
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 644954, RefRangeEnd = 644959, XrefRangeStart = 644952, XrefRangeEnd = 644954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_internetReachability_Public_Static_get_NetworkReachability_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00020AE0 File Offset: 0x0001ECE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644970, RefRangeEnd = 644971, XrefRangeStart = 644959, XrefRangeEnd = 644970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_lowMemory(Application.LowMemoryCallback value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_add_lowMemory_Public_Static_add_Void_LowMemoryCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00020B18 File Offset: 0x0001ED18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644982, RefRangeEnd = 644983, XrefRangeStart = 644971, XrefRangeEnd = 644982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_lowMemory(Application.LowMemoryCallback value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_remove_lowMemory_Public_Static_rem_Void_LowMemoryCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00020B50 File Offset: 0x0001ED50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644983, XrefRangeEnd = 644990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallLowMemory(ApplicationMemoryUsage usage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref usage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_CallLowMemory_Internal_Static_Void_ApplicationMemoryUsage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00020B84 File Offset: 0x0001ED84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644990, XrefRangeEnd = 644994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasLogCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_HasLogCallback_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00020BB4 File Offset: 0x0001EDB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 645011, RefRangeEnd = 645015, XrefRangeStart = 644994, XrefRangeEnd = 645011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_logMessageReceivedThreaded(Application.LogCallback value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_add_logMessageReceivedThreaded_Public_Static_add_Void_LogCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00020BEC File Offset: 0x0001EDEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 645030, RefRangeEnd = 645033, XrefRangeStart = 645015, XrefRangeEnd = 645030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_logMessageReceivedThreaded(Application.LogCallback value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_remove_logMessageReceivedThreaded_Public_Static_rem_Void_LogCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00020C24 File Offset: 0x0001EE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645033, XrefRangeEnd = 645040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokedOnMainThread;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_CallLogCallback_Private_Static_Void_String_String_LogType_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00020C88 File Offset: 0x0001EE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645040, XrefRangeEnd = 645053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_deepLinkActivated(Action<string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_add_deepLinkActivated_Public_Static_add_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00020CC0 File Offset: 0x0001EEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645053, XrefRangeEnd = 645066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_deepLinkActivated(Action<string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_remove_deepLinkActivated_Public_Static_rem_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00020CF8 File Offset: 0x0001EEF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 645079, RefRangeEnd = 645080, XrefRangeStart = 645066, XrefRangeEnd = 645079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_wantsToQuit(Func<bool> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_add_wantsToQuit_Public_Static_add_Void_Func_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00020D30 File Offset: 0x0001EF30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 645093, RefRangeEnd = 645094, XrefRangeStart = 645080, XrefRangeEnd = 645093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_wantsToQuit(Func<bool> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_remove_wantsToQuit_Public_Static_rem_Void_Func_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00020D68 File Offset: 0x0001EF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645094, XrefRangeEnd = 645110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_ApplicationWantsToQuit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Internal_ApplicationWantsToQuit_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00020D98 File Offset: 0x0001EF98
		public unsafe static CancellationToken exitCancellationToken
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 645116, RefRangeEnd = 645117, XrefRangeStart = 645110, XrefRangeEnd = 645116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_exitCancellationToken_Public_Static_get_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CancellationToken(intPtr);
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00020DC4 File Offset: 0x0001EFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645117, XrefRangeEnd = 645127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ApplicationInit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Internal_ApplicationInit_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00020DEC File Offset: 0x0001EFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645127, XrefRangeEnd = 645135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ApplicationQuit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Internal_ApplicationQuit_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00020E14 File Offset: 0x0001F014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645135, XrefRangeEnd = 645141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ApplicationUnload()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Internal_ApplicationUnload_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00020E3C File Offset: 0x0001F03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645141, XrefRangeEnd = 645145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnBeforeRender()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_InvokeOnBeforeRender_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00020E64 File Offset: 0x0001F064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645145, XrefRangeEnd = 645151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeFocusChanged(bool focus)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref focus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_InvokeFocusChanged_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00020E98 File Offset: 0x0001F098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645151, XrefRangeEnd = 645157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeDeepLinkActivated(string url)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_InvokeDeepLinkActivated_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00020ED0 File Offset: 0x0001F0D0
		public unsafe static bool isEditor
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 291198, RefRangeEnd = 291216, XrefRangeStart = 291198, XrefRangeEnd = 291216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00003B4C File Offset: 0x00001D4C
		public Application(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00020F00 File Offset: 0x0001F100
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00003B55 File Offset: 0x00001D55
		public unsafe static Application.LowMemoryCallback lowMemory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_lowMemory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Application.LowMemoryCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_lowMemory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00020F28 File Offset: 0x0001F128
		// (set) Token: 0x0600039B RID: 923 RVA: 0x00003B67 File Offset: 0x00001D67
		public unsafe static Application.MemoryUsageChangedCallback memoryUsageChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_memoryUsageChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Application.MemoryUsageChangedCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_memoryUsageChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00020F50 File Offset: 0x0001F150
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00003B79 File Offset: 0x00001D79
		public unsafe static Application.LogCallback s_LogCallbackHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_s_LogCallbackHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Application.LogCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_s_LogCallbackHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00020F78 File Offset: 0x0001F178
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00003B8B File Offset: 0x00001D8B
		public unsafe static Application.LogCallback s_LogCallbackHandlerThreaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_s_LogCallbackHandlerThreaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Application.LogCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_s_LogCallbackHandlerThreaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00020FA0 File Offset: 0x0001F1A0
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00003B9D File Offset: 0x00001D9D
		public unsafe static Action<bool> focusChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_focusChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_focusChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00020FC8 File Offset: 0x0001F1C8
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00003BAF File Offset: 0x00001DAF
		public unsafe static Action<string> deepLinkActivated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_deepLinkActivated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_deepLinkActivated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00020FF0 File Offset: 0x0001F1F0
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00003BC1 File Offset: 0x00001DC1
		public unsafe static Func<bool> wantsToQuit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_wantsToQuit, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_wantsToQuit, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00021018 File Offset: 0x0001F218
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x00003BD3 File Offset: 0x00001DD3
		public unsafe static Action quitting
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_quitting, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_quitting, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00021040 File Offset: 0x0001F240
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00003BE5 File Offset: 0x00001DE5
		public unsafe static Action unloading
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_unloading, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_unloading, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00021068 File Offset: 0x0001F268
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00003BF7 File Offset: 0x00001DF7
		public unsafe static CancellationTokenSource s_currentCancellationTokenSource
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_s_currentCancellationTokenSource, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_s_currentCancellationTokenSource, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00003C09 File Offset: 0x00001E09
		public static void CancelQuit()
		{
			Application.CancelQuitDelegateField();
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00003C15 File Offset: 0x00001E15
		public static void Unload()
		{
			Application.UnloadDelegateField();
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00003C21 File Offset: 0x00001E21
		public static bool isLoadingLevel
		{
			get
			{
				return Application.get_isLoadingLevelDelegateField();
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00003C2D File Offset: 0x00001E2D
		public static void SimulateMemoryUsage(ApplicationMemoryUsage usage)
		{
			Application.SimulateMemoryUsageDelegateField(usage);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00021090 File Offset: 0x0001F290
		public static float GetStreamProgressForLevel(int levelIndex)
		{
			bool flag = levelIndex >= 0 && levelIndex < UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
			float num;
			if (flag)
			{
				num = 1f;
			}
			else
			{
				num = 0f;
			}
			return num;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x000210C4 File Offset: 0x0001F2C4
		public static float GetStreamProgressForLevel(string levelName)
		{
			return 1f;
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x000210DC File Offset: 0x0001F2DC
		public static int streamedBytes
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x000210F0 File Offset: 0x0001F2F0
		public static bool webSecurityEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00021104 File Offset: 0x0001F304
		public static bool CanStreamedLevelBeLoaded(int levelIndex)
		{
			return levelIndex >= 0 && levelIndex < UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00003C3A File Offset: 0x00001E3A
		public static bool CanStreamedLevelBeLoaded(string levelName)
		{
			return Application.CanStreamedLevelBeLoadedDelegateField(IL2CPP.ManagedStringToIl2Cpp(levelName));
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00003C4C File Offset: 0x00001E4C
		public static bool IsPlaying(Object obj)
		{
			return Application.IsPlayingDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00021128 File Offset: 0x0001F328
		public static Il2CppStringArray GetBuildTags()
		{
			IntPtr intPtr = Application.GetBuildTagsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00003C5E File Offset: 0x00001E5E
		public static void SetBuildTags(Il2CppStringArray buildTags)
		{
			Application.SetBuildTagsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(buildTags));
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00021150 File Offset: 0x0001F350
		public static string buildGUID
		{
			get
			{
				IntPtr intPtr = Application.get_buildGUIDDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00003C70 File Offset: 0x00001E70
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00003C7C File Offset: 0x00001E7C
		public static bool runInBackground
		{
			get
			{
				return Application.get_runInBackgroundDelegateField();
			}
			set
			{
				Application.set_runInBackgroundDelegateField(value);
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00003C89 File Offset: 0x00001E89
		public static bool HasProLicense()
		{
			return Application.HasProLicenseDelegateField();
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00003C95 File Offset: 0x00001E95
		public static bool isTestRun
		{
			get
			{
				return Application.get_isTestRunDelegateField();
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00003CA1 File Offset: 0x00001EA1
		public static bool isHumanControllingUs
		{
			get
			{
				return Application.get_isHumanControllingUsDelegateField();
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00003CAD File Offset: 0x00001EAD
		public static bool HasARGV(string name)
		{
			return Application.HasARGVDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00021170 File Offset: 0x0001F370
		public static string GetValueForARGV(string name)
		{
			IntPtr intPtr = Application.GetValueForARGVDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00021194 File Offset: 0x0001F394
		public static void ExternalEval(string script)
		{
			bool flag = script.Length > 0 && script.get_Chars(script.Length - 1) != ';';
			if (flag)
			{
				script = String.Concat(script, ";");
			}
			Application.Internal_ExternalCall(script);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00003CBF File Offset: 0x00001EBF
		public static void Internal_ExternalCall(string script)
		{
			Application.Internal_ExternalCallDelegateField(IL2CPP.ManagedStringToIl2Cpp(script));
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00003CD1 File Offset: 0x00001ED1
		public static int unityVersionVer
		{
			get
			{
				return Application.get_unityVersionVerDelegateField();
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00003CDD File Offset: 0x00001EDD
		public static int unityVersionMaj
		{
			get
			{
				return Application.get_unityVersionMajDelegateField();
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00003CE9 File Offset: 0x00001EE9
		public static int unityVersionMin
		{
			get
			{
				return Application.get_unityVersionMinDelegateField();
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x000211DC File Offset: 0x0001F3DC
		public static string version
		{
			get
			{
				IntPtr intPtr = Application.get_versionDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x000211FC File Offset: 0x0001F3FC
		public static string installerName
		{
			get
			{
				IntPtr intPtr = Application.get_installerNameDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00003CF5 File Offset: 0x00001EF5
		public static ApplicationInstallMode installMode
		{
			get
			{
				return Application.get_installModeDelegateField();
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00003D01 File Offset: 0x00001F01
		public static ApplicationSandboxType sandboxType
		{
			get
			{
				return Application.get_sandboxTypeDelegateField();
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003CA RID: 970 RVA: 0x0002121C File Offset: 0x0001F41C
		public static string companyName
		{
			get
			{
				IntPtr intPtr = Application.get_companyNameDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0002123C File Offset: 0x0001F43C
		public static string cloudProjectId
		{
			get
			{
				IntPtr intPtr = Application.get_cloudProjectIdDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00003D0D File Offset: 0x00001F0D
		public static void ForceCrash(int mode)
		{
			UnityEngine.Diagnostics.Utils.ForceCrash((UnityEngine.Diagnostics.ForcedCrashCategory)mode);
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00003D17 File Offset: 0x00001F17
		// (set) Token: 0x060003CE RID: 974 RVA: 0x00003D23 File Offset: 0x00001F23
		public static StackTraceLogType stackTraceLogType
		{
			get
			{
				return Application.get_stackTraceLogTypeDelegateField();
			}
			set
			{
				Application.set_stackTraceLogTypeDelegateField(value);
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00003D30 File Offset: 0x00001F30
		public static StackTraceLogType GetStackTraceLogType(LogType logType)
		{
			return Application.GetStackTraceLogTypeDelegateField(logType);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00003D3D File Offset: 0x00001F3D
		public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType)
		{
			Application.SetStackTraceLogTypeDelegateField(logType, stackTraceType);
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0002125C File Offset: 0x0001F45C
		public static string consoleLogPath
		{
			get
			{
				IntPtr intPtr = Application.get_consoleLogPathDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00003D4B File Offset: 0x00001F4B
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00003D57 File Offset: 0x00001F57
		public static ThreadPriority backgroundLoadingPriority
		{
			get
			{
				return Application.get_backgroundLoadingPriorityDelegateField();
			}
			set
			{
				Application.set_backgroundLoadingPriorityDelegateField(value);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00003D64 File Offset: 0x00001F64
		public static bool genuine
		{
			get
			{
				return Application.get_genuineDelegateField();
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00003D70 File Offset: 0x00001F70
		public static bool genuineCheckAvailable
		{
			get
			{
				return Application.get_genuineCheckAvailableDelegateField();
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0002127C File Offset: 0x0001F47C
		public static AsyncOperation RequestUserAuthorization(UserAuthorization mode)
		{
			IntPtr intPtr = Application.RequestUserAuthorizationDelegateField(mode);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00003D7C File Offset: 0x00001F7C
		public static bool HasUserAuthorization(UserAuthorization mode)
		{
			return Application.HasUserAuthorizationDelegateField(mode);
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00003D89 File Offset: 0x00001F89
		public static bool submitAnalytics
		{
			get
			{
				return Application.get_submitAnalyticsDelegateField();
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x000212A4 File Offset: 0x0001F4A4
		public static bool isShowingSplashScreen
		{
			get
			{
				return !UnityEngine.Rendering.SplashScreen.isFinished;
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00003D95 File Offset: 0x00001F95
		public static void add_memoryUsageChanged(Application.MemoryUsageChangedCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00003DA2 File Offset: 0x00001FA2
		public static void remove_memoryUsageChanged(Application.MemoryUsageChangedCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00003DAF File Offset: 0x00001FAF
		public static void add_logMessageReceived(Application.LogCallback value)
		{
			Application.s_LogCallbackHandler = Delegate.Combine(Application.s_LogCallbackHandler, value).Cast<Application.LogCallback>();
			Application.SetLogCallbackDefined(true);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00003DCE File Offset: 0x00001FCE
		public static void remove_logMessageReceived(Application.LogCallback value)
		{
			Application.s_LogCallbackHandler = Delegate.Remove(Application.s_LogCallbackHandler, value).Cast<Application.LogCallback>();
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00003DE6 File Offset: 0x00001FE6
		public static void InvokeOnAdvertisingIdentifierCallback(string advertisingId, bool trackingEnabled)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000212C0 File Offset: 0x0001F4C0
		public static string ObjectToJSString(Object o)
		{
			bool flag = o == null;
			string text;
			if (flag)
			{
				text = "null";
			}
			else
			{
				bool flag2 = o.TryCast<string>() != null;
				if (flag2)
				{
					string text2 = o.ToString().Replace("\\", "\\\\");
					text2 = text2.Replace("\"", "\\\"");
					text2 = text2.Replace("\n", "\\n");
					text2 = text2.Replace("\r", "\\r");
					text2 = text2.Replace("\0", "");
					text2 = text2.Replace("\u2028", "");
					text2 = text2.Replace("\u2029", "");
					text = String.Concat("\"", text2, "\"");
				}
				else
				{
					bool flag3 = o is int || o is short || o is uint || o is ushort || o is byte;
					if (flag3)
					{
						text = o.ToString();
					}
					else
					{
						bool flag4 = o is float;
						if (flag4)
						{
							NumberFormatInfo numberFormat = CultureInfo.InvariantCulture.NumberFormat;
							text = ((float)o).ToString(numberFormat);
						}
						else
						{
							bool flag5 = o is double;
							if (flag5)
							{
								NumberFormatInfo numberFormat2 = CultureInfo.InvariantCulture.NumberFormat;
								text = ((double)o).ToString(numberFormat2);
							}
							else
							{
								bool flag6 = o is char;
								if (flag6)
								{
									bool flag7 = (char)o == '"';
									if (flag7)
									{
										text = "\"\\\"\"";
									}
									else
									{
										text = String.Concat("\"", o.ToString(), "\"");
									}
								}
								else
								{
									bool flag8 = o.TryCast<IList>() != null;
									if (flag8)
									{
										IList list = o.Cast<IList>();
										StringBuilder stringBuilder = new StringBuilder();
										stringBuilder.Append("new Array(");
										int count = list.Count;
										for (int i = 0; i < count; i++)
										{
											bool flag9 = i != 0;
											if (flag9)
											{
												stringBuilder.Append(", ");
											}
											stringBuilder.Append(Application.ObjectToJSString(list[i]));
										}
										stringBuilder.Append(")");
										text = stringBuilder.ToString();
									}
									else
									{
										text = Application.ObjectToJSString(o.ToString());
									}
								}
							}
						}
					}
				}
			}
			return text;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00003DF3 File Offset: 0x00001FF3
		public static void ExternalCall(string functionName, Il2CppReferenceArray<Object> args)
		{
			Application.Internal_ExternalCall(Application.BuildInvocationForArguments(functionName, args));
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00003E03 File Offset: 0x00002003
		public static void ExternalCall(string functionName, params Object[] args)
		{
			Application.ExternalCall(functionName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00003E11 File Offset: 0x00002011
		public static string BuildInvocationForArguments(string functionName, Il2CppReferenceArray<Object> args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00003E1E File Offset: 0x0000201E
		public static string BuildInvocationForArguments(string functionName, params Object[] args)
		{
			return Application.BuildInvocationForArguments(functionName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00021518 File Offset: 0x0001F718
		public static bool isPlayer
		{
			get
			{
				return !Application.isEditor;
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00021534 File Offset: 0x0001F734
		public static void DontDestroyOnLoad(Object o)
		{
			bool flag = o != null;
			if (flag)
			{
				Object.DontDestroyOnLoad(o);
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00003E2C File Offset: 0x0000202C
		public static void CaptureScreenshot(string filename, int superSize)
		{
			throw new NotSupportedException("Application.CaptureScreenshot is obsolete. Use ScreenCapture.CaptureScreenshot instead.");
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00003E39 File Offset: 0x00002039
		public static void CaptureScreenshot(string filename)
		{
			throw new NotSupportedException("Application.CaptureScreenshot is obsolete. Use ScreenCapture.CaptureScreenshot instead.");
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00003E46 File Offset: 0x00002046
		public static void add_onBeforeRender(UnityEngine.Events.UnityAction value)
		{
			BeforeRenderHelper.RegisterCallback(value);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00003E50 File Offset: 0x00002050
		public static void remove_onBeforeRender(UnityEngine.Events.UnityAction value)
		{
			BeforeRenderHelper.UnregisterCallback(value);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00003E5A File Offset: 0x0000205A
		public static void add_focusChanged(Action<bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00003E67 File Offset: 0x00002067
		public static void remove_focusChanged(Action<bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00003E74 File Offset: 0x00002074
		public static void add_quitting(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00003E81 File Offset: 0x00002081
		public static void remove_quitting(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00003E8E File Offset: 0x0000208E
		public static void add_unloading(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00003E9B File Offset: 0x0000209B
		public static void remove_unloading(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00003EA8 File Offset: 0x000020A8
		public static void RegisterLogCallback(Application.LogCallback handler)
		{
			Application.RegisterLogCallback(handler, false);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00003EB3 File Offset: 0x000020B3
		public static void RegisterLogCallbackThreaded(Application.LogCallback handler)
		{
			Application.RegisterLogCallback(handler, true);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00003EBE File Offset: 0x000020BE
		public static void RegisterLogCallback(Application.LogCallback handler, bool threaded)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00021554 File Offset: 0x0001F754
		public static int levelCount
		{
			get
			{
				return UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0002156C File Offset: 0x0001F76C
		public static int loadedLevel
		{
			get
			{
				return UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0002158C File Offset: 0x0001F78C
		public static string loadedLevelName
		{
			get
			{
				return UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00003ECB File Offset: 0x000020CB
		public static void LoadLevel(int index)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(index, UnityEngine.SceneManagement.LoadSceneMode.Single);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00003ED6 File Offset: 0x000020D6
		public static void LoadLevel(string name)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(name, UnityEngine.SceneManagement.LoadSceneMode.Single);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00003EE1 File Offset: 0x000020E1
		public static void LoadLevelAdditive(int index)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(index, UnityEngine.SceneManagement.LoadSceneMode.Additive);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00003EEC File Offset: 0x000020EC
		public static void LoadLevelAdditive(string name)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(name, UnityEngine.SceneManagement.LoadSceneMode.Additive);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000215AC File Offset: 0x0001F7AC
		public static AsyncOperation LoadLevelAsync(int index)
		{
			return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(index, UnityEngine.SceneManagement.LoadSceneMode.Single);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x000215C8 File Offset: 0x0001F7C8
		public static AsyncOperation LoadLevelAsync(string levelName)
		{
			return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(levelName, UnityEngine.SceneManagement.LoadSceneMode.Single);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x000215E4 File Offset: 0x0001F7E4
		public static AsyncOperation LoadLevelAdditiveAsync(int index)
		{
			return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(index, UnityEngine.SceneManagement.LoadSceneMode.Additive);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00021600 File Offset: 0x0001F800
		public static AsyncOperation LoadLevelAdditiveAsync(string levelName)
		{
			return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(levelName, UnityEngine.SceneManagement.LoadSceneMode.Additive);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0002161C File Offset: 0x0001F81C
		public static bool UnloadLevel(int index)
		{
			return UnityEngine.SceneManagement.SceneManager.UnloadScene(index);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00021634 File Offset: 0x0001F834
		public static bool UnloadLevel(string scenePath)
		{
			return UnityEngine.SceneManagement.SceneManager.UnloadScene(scenePath);
		}

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeFieldInfoPtr_lowMemory;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeFieldInfoPtr_memoryUsageChanged;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeFieldInfoPtr_s_LogCallbackHandler;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeFieldInfoPtr_s_LogCallbackHandlerThreaded;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeFieldInfoPtr_focusChanged;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeFieldInfoPtr_deepLinkActivated;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeFieldInfoPtr_wantsToQuit;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeFieldInfoPtr_quitting;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeFieldInfoPtr_unloading;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeFieldInfoPtr_s_currentCancellationTokenSource;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_Quit_Public_Static_Void_Int32_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_Quit_Public_Static_Void_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_get_isPlaying_Public_Static_get_Boolean_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_get_isFocused_Public_Static_get_Boolean_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_get_isBatchMode_Public_Static_get_Boolean_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_get_temporaryCachePath_Public_Static_get_String_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_get_absoluteURL_Public_Static_get_String_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_get_unityVersion_Public_Static_get_String_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_get_identifier_Public_Static_get_String_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_get_productName_Public_Static_get_String_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_OpenURL_Public_Static_Void_String_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_get_targetFrameRate_Public_Static_get_Int32_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_set_targetFrameRate_Public_Static_set_Void_Int32_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_SetLogCallbackDefined_Private_Static_Void_Boolean_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_get_isMobilePlatform_Public_Static_get_Boolean_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_get_isConsolePlatform_Public_Static_get_Boolean_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_get_systemLanguage_Public_Static_get_SystemLanguage_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_get_internetReachability_Public_Static_get_NetworkReachability_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_add_lowMemory_Public_Static_add_Void_LowMemoryCallback_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_remove_lowMemory_Public_Static_rem_Void_LowMemoryCallback_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_CallLowMemory_Internal_Static_Void_ApplicationMemoryUsage_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_HasLogCallback_Internal_Static_Boolean_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_add_logMessageReceivedThreaded_Public_Static_add_Void_LogCallback_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_remove_logMessageReceivedThreaded_Public_Static_rem_Void_LogCallback_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_CallLogCallback_Private_Static_Void_String_String_LogType_Boolean_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_add_deepLinkActivated_Public_Static_add_Void_Action_1_String_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_remove_deepLinkActivated_Public_Static_rem_Void_Action_1_String_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_add_wantsToQuit_Public_Static_add_Void_Func_1_Boolean_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_remove_wantsToQuit_Public_Static_rem_Void_Func_1_Boolean_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ApplicationWantsToQuit_Private_Static_Boolean_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_get_exitCancellationToken_Public_Static_get_CancellationToken_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ApplicationInit_Private_Static_Void_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ApplicationQuit_Private_Static_Void_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ApplicationUnload_Private_Static_Void_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnBeforeRender_Internal_Static_Void_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_InvokeFocusChanged_Internal_Static_Void_Boolean_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_InvokeDeepLinkActivated_Internal_Static_Void_String_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0;

		// Token: 0x040002DC RID: 732
		private static readonly Application.CancelQuitDelegate CancelQuitDelegateField;

		// Token: 0x040002DD RID: 733
		private static readonly Application.UnloadDelegate UnloadDelegateField;

		// Token: 0x040002DE RID: 734
		private static readonly Application.get_isLoadingLevelDelegate get_isLoadingLevelDelegateField;

		// Token: 0x040002DF RID: 735
		private static readonly Application.SimulateMemoryUsageDelegate SimulateMemoryUsageDelegateField;

		// Token: 0x040002E0 RID: 736
		private static readonly Application.CanStreamedLevelBeLoadedDelegate CanStreamedLevelBeLoadedDelegateField;

		// Token: 0x040002E1 RID: 737
		private static readonly Application.IsPlayingDelegate IsPlayingDelegateField;

		// Token: 0x040002E2 RID: 738
		private static readonly Application.GetBuildTagsDelegate GetBuildTagsDelegateField;

		// Token: 0x040002E3 RID: 739
		private static readonly Application.SetBuildTagsDelegate SetBuildTagsDelegateField;

		// Token: 0x040002E4 RID: 740
		private static readonly Application.get_buildGUIDDelegate get_buildGUIDDelegateField;

		// Token: 0x040002E5 RID: 741
		private static readonly Application.get_runInBackgroundDelegate get_runInBackgroundDelegateField;

		// Token: 0x040002E6 RID: 742
		private static readonly Application.set_runInBackgroundDelegate set_runInBackgroundDelegateField;

		// Token: 0x040002E7 RID: 743
		private static readonly Application.HasProLicenseDelegate HasProLicenseDelegateField;

		// Token: 0x040002E8 RID: 744
		private static readonly Application.get_isTestRunDelegate get_isTestRunDelegateField;

		// Token: 0x040002E9 RID: 745
		private static readonly Application.get_isHumanControllingUsDelegate get_isHumanControllingUsDelegateField;

		// Token: 0x040002EA RID: 746
		private static readonly Application.HasARGVDelegate HasARGVDelegateField;

		// Token: 0x040002EB RID: 747
		private static readonly Application.GetValueForARGVDelegate GetValueForARGVDelegateField;

		// Token: 0x040002EC RID: 748
		private static readonly Application.Internal_ExternalCallDelegate Internal_ExternalCallDelegateField;

		// Token: 0x040002ED RID: 749
		private static readonly Application.get_unityVersionVerDelegate get_unityVersionVerDelegateField;

		// Token: 0x040002EE RID: 750
		private static readonly Application.get_unityVersionMajDelegate get_unityVersionMajDelegateField;

		// Token: 0x040002EF RID: 751
		private static readonly Application.get_unityVersionMinDelegate get_unityVersionMinDelegateField;

		// Token: 0x040002F0 RID: 752
		private static readonly Application.get_versionDelegate get_versionDelegateField;

		// Token: 0x040002F1 RID: 753
		private static readonly Application.get_installerNameDelegate get_installerNameDelegateField;

		// Token: 0x040002F2 RID: 754
		private static readonly Application.get_installModeDelegate get_installModeDelegateField;

		// Token: 0x040002F3 RID: 755
		private static readonly Application.get_sandboxTypeDelegate get_sandboxTypeDelegateField;

		// Token: 0x040002F4 RID: 756
		private static readonly Application.get_companyNameDelegate get_companyNameDelegateField;

		// Token: 0x040002F5 RID: 757
		private static readonly Application.get_cloudProjectIdDelegate get_cloudProjectIdDelegateField;

		// Token: 0x040002F6 RID: 758
		private static readonly Application.get_stackTraceLogTypeDelegate get_stackTraceLogTypeDelegateField;

		// Token: 0x040002F7 RID: 759
		private static readonly Application.set_stackTraceLogTypeDelegate set_stackTraceLogTypeDelegateField;

		// Token: 0x040002F8 RID: 760
		private static readonly Application.GetStackTraceLogTypeDelegate GetStackTraceLogTypeDelegateField;

		// Token: 0x040002F9 RID: 761
		private static readonly Application.SetStackTraceLogTypeDelegate SetStackTraceLogTypeDelegateField;

		// Token: 0x040002FA RID: 762
		private static readonly Application.get_consoleLogPathDelegate get_consoleLogPathDelegateField;

		// Token: 0x040002FB RID: 763
		private static readonly Application.get_backgroundLoadingPriorityDelegate get_backgroundLoadingPriorityDelegateField;

		// Token: 0x040002FC RID: 764
		private static readonly Application.set_backgroundLoadingPriorityDelegate set_backgroundLoadingPriorityDelegateField;

		// Token: 0x040002FD RID: 765
		private static readonly Application.get_genuineDelegate get_genuineDelegateField;

		// Token: 0x040002FE RID: 766
		private static readonly Application.get_genuineCheckAvailableDelegate get_genuineCheckAvailableDelegateField;

		// Token: 0x040002FF RID: 767
		private static readonly Application.RequestUserAuthorizationDelegate RequestUserAuthorizationDelegateField;

		// Token: 0x04000300 RID: 768
		private static readonly Application.HasUserAuthorizationDelegate HasUserAuthorizationDelegateField;

		// Token: 0x04000301 RID: 769
		private static readonly Application.get_submitAnalyticsDelegate get_submitAnalyticsDelegateField;

		// Token: 0x02000404 RID: 1028
		public sealed class LowMemoryCallback : MulticastDelegate
		{
			// Token: 0x060030F6 RID: 12534 RVA: 0x00013942 File Offset: 0x00011B42
			// Note: this type is marked as 'beforefieldinit'.
			static LowMemoryCallback()
			{
				Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Application>.NativeClassPtr, "LowMemoryCallback");
				Application.LowMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr, 100663684);
				Application.LowMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr, 100663685);
			}

			// Token: 0x060030F7 RID: 12535 RVA: 0x000B8244 File Offset: 0x000B6444
			[CallerCount(288)]
			[CachedScanResults(RefRangeStart = 320972, RefRangeEnd = 321260, XrefRangeStart = 320972, XrefRangeEnd = 321260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LowMemoryCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LowMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030F8 RID: 12536 RVA: 0x000B82A0 File Offset: 0x000B64A0
			[CallerCount(0)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LowMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030F9 RID: 12537 RVA: 0x00013980 File Offset: 0x00011B80
			public LowMemoryCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060030FA RID: 12538 RVA: 0x00013989 File Offset: 0x00011B89
			public static implicit operator Application.LowMemoryCallback(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<Application.LowMemoryCallback>(A_0);
			}

			// Token: 0x060030FB RID: 12539 RVA: 0x00013991 File Offset: 0x00011B91
			public static Application.LowMemoryCallback operator +(Application.LowMemoryCallback A_0, Application.LowMemoryCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Application.LowMemoryCallback>();
			}

			// Token: 0x060030FC RID: 12540 RVA: 0x0001399F File Offset: 0x00011B9F
			public static Application.LowMemoryCallback operator -(Application.LowMemoryCallback A_0, Application.LowMemoryCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Application.LowMemoryCallback>();
				}
				return delegate2;
			}

			// Token: 0x04002B23 RID: 11043
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B24 RID: 11044
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}

		// Token: 0x02000405 RID: 1029
		public sealed class MemoryUsageChangedCallback : MulticastDelegate
		{
			// Token: 0x060030FD RID: 12541 RVA: 0x000139B0 File Offset: 0x00011BB0
			// Note: this type is marked as 'beforefieldinit'.
			static MemoryUsageChangedCallback()
			{
				Il2CppClassPointerStore<Application.MemoryUsageChangedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Application>.NativeClassPtr, "MemoryUsageChangedCallback");
				Application.MemoryUsageChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.MemoryUsageChangedCallback>.NativeClassPtr, 100663686);
				Application.MemoryUsageChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ApplicationMemoryUsageChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.MemoryUsageChangedCallback>.NativeClassPtr, 100663687);
			}

			// Token: 0x060030FE RID: 12542 RVA: 0x000B82D4 File Offset: 0x000B64D4
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 408098, RefRangeEnd = 408114, XrefRangeStart = 408098, XrefRangeEnd = 408114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MemoryUsageChangedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Application.MemoryUsageChangedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.MemoryUsageChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030FF RID: 12543 RVA: 0x000B8330 File Offset: 0x000B6530
			[CallerCount(0)]
			public unsafe void Invoke([In] ref ApplicationMemoryUsageChange usage)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &usage;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.MemoryUsageChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ApplicationMemoryUsageChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003100 RID: 12544 RVA: 0x000139EE File Offset: 0x00011BEE
			public MemoryUsageChangedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002B25 RID: 11045
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B26 RID: 11046
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ApplicationMemoryUsageChange_0;
		}

		// Token: 0x02000406 RID: 1030
		public sealed class LogCallback : MulticastDelegate
		{
			// Token: 0x06003101 RID: 12545 RVA: 0x000139F7 File Offset: 0x00011BF7
			// Note: this type is marked as 'beforefieldinit'.
			static LogCallback()
			{
				Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Application>.NativeClassPtr, "LogCallback");
				Application.LogCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr, 100663688);
				Application.LogCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr, 100663689);
			}

			// Token: 0x06003102 RID: 12546 RVA: 0x000B8370 File Offset: 0x000B6570
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 644627, RefRangeEnd = 644641, XrefRangeStart = 644623, XrefRangeEnd = 644627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LogCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LogCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003103 RID: 12547 RVA: 0x000B83CC File Offset: 0x000B65CC
			[CallerCount(0)]
			public unsafe void Invoke(string condition, string stackTrace, LogType type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(condition);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LogCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003104 RID: 12548 RVA: 0x00013A35 File Offset: 0x00011C35
			public LogCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003105 RID: 12549 RVA: 0x00013A3E File Offset: 0x00011C3E
			public static implicit operator Application.LogCallback(Action<string, string, LogType> A_0)
			{
				return DelegateSupport.ConvertDelegate<Application.LogCallback>(A_0);
			}

			// Token: 0x06003106 RID: 12550 RVA: 0x00013A46 File Offset: 0x00011C46
			public static Application.LogCallback operator +(Application.LogCallback A_0, Application.LogCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Application.LogCallback>();
			}

			// Token: 0x06003107 RID: 12551 RVA: 0x00013A54 File Offset: 0x00011C54
			public static Application.LogCallback operator -(Application.LogCallback A_0, Application.LogCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Application.LogCallback>();
				}
				return delegate2;
			}

			// Token: 0x04002B27 RID: 11047
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B28 RID: 11048
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_LogType_0;
		}

		// Token: 0x02000407 RID: 1031
		// (Invoke) Token: 0x06003109 RID: 12553
		private delegate void CancelQuitDelegate();

		// Token: 0x02000408 RID: 1032
		// (Invoke) Token: 0x0600310B RID: 12555
		private delegate void UnloadDelegate();

		// Token: 0x02000409 RID: 1033
		// (Invoke) Token: 0x0600310D RID: 12557
		private delegate bool get_isLoadingLevelDelegate();

		// Token: 0x0200040A RID: 1034
		// (Invoke) Token: 0x0600310F RID: 12559
		private delegate void SimulateMemoryUsageDelegate(ApplicationMemoryUsage usage);

		// Token: 0x0200040B RID: 1035
		// (Invoke) Token: 0x06003111 RID: 12561
		private delegate bool CanStreamedLevelBeLoadedDelegate(IntPtr levelName);

		// Token: 0x0200040C RID: 1036
		// (Invoke) Token: 0x06003113 RID: 12563
		private delegate bool IsPlayingDelegate(IntPtr obj);

		// Token: 0x0200040D RID: 1037
		// (Invoke) Token: 0x06003115 RID: 12565
		private delegate IntPtr GetBuildTagsDelegate();

		// Token: 0x0200040E RID: 1038
		// (Invoke) Token: 0x06003117 RID: 12567
		private delegate void SetBuildTagsDelegate(IntPtr buildTags);

		// Token: 0x0200040F RID: 1039
		// (Invoke) Token: 0x06003119 RID: 12569
		private delegate IntPtr get_buildGUIDDelegate();

		// Token: 0x02000410 RID: 1040
		// (Invoke) Token: 0x0600311B RID: 12571
		private delegate bool get_runInBackgroundDelegate();

		// Token: 0x02000411 RID: 1041
		// (Invoke) Token: 0x0600311D RID: 12573
		private delegate void set_runInBackgroundDelegate(bool value);

		// Token: 0x02000412 RID: 1042
		// (Invoke) Token: 0x0600311F RID: 12575
		private delegate bool HasProLicenseDelegate();

		// Token: 0x02000413 RID: 1043
		// (Invoke) Token: 0x06003121 RID: 12577
		private delegate bool get_isTestRunDelegate();

		// Token: 0x02000414 RID: 1044
		// (Invoke) Token: 0x06003123 RID: 12579
		private delegate bool get_isHumanControllingUsDelegate();

		// Token: 0x02000415 RID: 1045
		// (Invoke) Token: 0x06003125 RID: 12581
		private delegate bool HasARGVDelegate(IntPtr name);

		// Token: 0x02000416 RID: 1046
		// (Invoke) Token: 0x06003127 RID: 12583
		private delegate IntPtr GetValueForARGVDelegate(IntPtr name);

		// Token: 0x02000417 RID: 1047
		// (Invoke) Token: 0x06003129 RID: 12585
		private delegate void Internal_ExternalCallDelegate(IntPtr script);

		// Token: 0x02000418 RID: 1048
		// (Invoke) Token: 0x0600312B RID: 12587
		private delegate int get_unityVersionVerDelegate();

		// Token: 0x02000419 RID: 1049
		// (Invoke) Token: 0x0600312D RID: 12589
		private delegate int get_unityVersionMajDelegate();

		// Token: 0x0200041A RID: 1050
		// (Invoke) Token: 0x0600312F RID: 12591
		private delegate int get_unityVersionMinDelegate();

		// Token: 0x0200041B RID: 1051
		// (Invoke) Token: 0x06003131 RID: 12593
		private delegate IntPtr get_versionDelegate();

		// Token: 0x0200041C RID: 1052
		// (Invoke) Token: 0x06003133 RID: 12595
		private delegate IntPtr get_installerNameDelegate();

		// Token: 0x0200041D RID: 1053
		// (Invoke) Token: 0x06003135 RID: 12597
		private delegate ApplicationInstallMode get_installModeDelegate();

		// Token: 0x0200041E RID: 1054
		// (Invoke) Token: 0x06003137 RID: 12599
		private delegate ApplicationSandboxType get_sandboxTypeDelegate();

		// Token: 0x0200041F RID: 1055
		// (Invoke) Token: 0x06003139 RID: 12601
		private delegate IntPtr get_companyNameDelegate();

		// Token: 0x02000420 RID: 1056
		// (Invoke) Token: 0x0600313B RID: 12603
		private delegate IntPtr get_cloudProjectIdDelegate();

		// Token: 0x02000421 RID: 1057
		// (Invoke) Token: 0x0600313D RID: 12605
		private delegate StackTraceLogType get_stackTraceLogTypeDelegate();

		// Token: 0x02000422 RID: 1058
		// (Invoke) Token: 0x0600313F RID: 12607
		private delegate void set_stackTraceLogTypeDelegate(StackTraceLogType value);

		// Token: 0x02000423 RID: 1059
		// (Invoke) Token: 0x06003141 RID: 12609
		private delegate StackTraceLogType GetStackTraceLogTypeDelegate(LogType logType);

		// Token: 0x02000424 RID: 1060
		// (Invoke) Token: 0x06003143 RID: 12611
		private delegate void SetStackTraceLogTypeDelegate(LogType logType, StackTraceLogType stackTraceType);

		// Token: 0x02000425 RID: 1061
		// (Invoke) Token: 0x06003145 RID: 12613
		private delegate IntPtr get_consoleLogPathDelegate();

		// Token: 0x02000426 RID: 1062
		// (Invoke) Token: 0x06003147 RID: 12615
		private delegate ThreadPriority get_backgroundLoadingPriorityDelegate();

		// Token: 0x02000427 RID: 1063
		// (Invoke) Token: 0x06003149 RID: 12617
		private delegate void set_backgroundLoadingPriorityDelegate(ThreadPriority value);

		// Token: 0x02000428 RID: 1064
		// (Invoke) Token: 0x0600314B RID: 12619
		private delegate bool get_genuineDelegate();

		// Token: 0x02000429 RID: 1065
		// (Invoke) Token: 0x0600314D RID: 12621
		private delegate bool get_genuineCheckAvailableDelegate();

		// Token: 0x0200042A RID: 1066
		// (Invoke) Token: 0x0600314F RID: 12623
		private delegate IntPtr RequestUserAuthorizationDelegate(UserAuthorization mode);

		// Token: 0x0200042B RID: 1067
		// (Invoke) Token: 0x06003151 RID: 12625
		private delegate bool HasUserAuthorizationDelegate(UserAuthorization mode);

		// Token: 0x0200042C RID: 1068
		// (Invoke) Token: 0x06003153 RID: 12627
		private delegate bool get_submitAnalyticsDelegate();
	}
}
