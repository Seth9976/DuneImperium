using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;

namespace Unity.Burst
{
	// Token: 0x0200000B RID: 11
	public sealed class BurstCompilerOptions : Object
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00004C20 File Offset: 0x00002E20
		// Note: this type is marked as 'beforefieldinit'.
		static BurstCompilerOptions()
		{
			Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "BurstCompilerOptions");
			BurstCompilerOptions.NativeFieldInfoPtr_DisableCompilationArg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "DisableCompilationArg");
			BurstCompilerOptions.NativeFieldInfoPtr_ForceSynchronousCompilationArg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "ForceSynchronousCompilationArg");
			BurstCompilerOptions.NativeFieldInfoPtr_DefaultLibraryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "DefaultLibraryName");
			BurstCompilerOptions.NativeFieldInfoPtr_BurstInitializeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "BurstInitializeName");
			BurstCompilerOptions.NativeFieldInfoPtr_BurstInitializeExternalsName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "BurstInitializeExternalsName");
			BurstCompilerOptions.NativeFieldInfoPtr_BurstInitializeStaticsName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "BurstInitializeStaticsName");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionBurstcSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionBurstcSwitch");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionGroup");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionPlatform");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionBackend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionBackend");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionGlobalSafetyChecksSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionGlobalSafetyChecksSetting");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionDisableSafetyChecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionDisableSafetyChecks");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionDisableOpt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionDisableOpt");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionFastMath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionFastMath");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionTarget");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionOptLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionOptLevel");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionLogTimings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionLogTimings");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionOptForSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionOptForSize");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionFloatPrecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionFloatPrecision");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionFloatMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionFloatMode");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionBranchProtection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionBranchProtection");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionDisableWarnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionDisableWarnings");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionAssemblyDefines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionAssemblyDefines");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionDump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionDump");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionFormat");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionDebugTrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionDebugTrap");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionDisableVectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionDisableVectors");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionDebug");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionDebugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionDebugMode");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionStaticLinkage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionStaticLinkage");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionJobMarshalling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionJobMarshalling");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionTempDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionTempDirectory");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionEnableDirectExternalLinking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionEnableDirectExternalLinking");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionLinkerOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionLinkerOptions");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionEnableAutoLayoutFallbackCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionEnableAutoLayoutFallbackCheck");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionGenerateLinkXml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionGenerateLinkXml");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionMetaDataGeneration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionMetaDataGeneration");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionDisableStringInterpolationInExceptionMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionDisableStringInterpolationInExceptionMessages");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionPlatformConfiguration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionPlatformConfiguration");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionStackProtector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionStackProtector");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionStackProtectorBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionStackProtectorBufferSize");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionCacheDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionCacheDirectory");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionJitDisableFunctionCaching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionJitDisableFunctionCaching");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionJitDisableAssemblyCaching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionJitDisableAssemblyCaching");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionJitEnableAssemblyCachingLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionJitEnableAssemblyCachingLogs");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionJitEnableSynchronousCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionJitEnableSynchronousCompilation");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionJitCompilationPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionJitCompilationPriority");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionJitIsForFunctionPointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionJitIsForFunctionPointer");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionJitManagedFunctionPointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionJitManagedFunctionPointer");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionJitManagedDelegateHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionJitManagedDelegateHandle");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionEnableInterpreter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionEnableInterpreter");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionAotAssemblyFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionAotAssemblyFolder");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionRootAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionRootAssembly");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionIncludeRootAssemblyReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionIncludeRootAssemblyReferences");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionAotMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionAotMethod");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionAotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionAotType");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionAotAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionAotAssembly");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionAotOutputPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionAotOutputPath");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionAotKeepIntermediateFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionAotKeepIntermediateFiles");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionAotNoLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionAotNoLink");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionAotOnlyStaticMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionAotOnlyStaticMethods");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionMethodPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionMethodPrefix");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionAotNoNativeToolchain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionAotNoNativeToolchain");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionAotEmitLlvmObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionAotEmitLlvmObjects");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionAotKeyFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionAotKeyFolder");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionAotDecodeFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionAotDecodeFolder");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionVerbose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionVerbose");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionValidateExternalToolChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionValidateExternalToolChain");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionCompilerThreads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionCompilerThreads");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionChunkSize");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionPrintLogOnMissingPInvokeCallbackAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionPrintLogOnMissingPInvokeCallbackAttribute");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionOutputMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionOutputMode");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionAlwaysCreateOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionAlwaysCreateOutput");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionAotPdbSearchPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionAotPdbSearchPaths");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionSafetyChecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionSafetyChecks");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionLibraryOutputMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionLibraryOutputMode");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionCompilationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionCompilationId");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionTargetFramework = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionTargetFramework");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionDiscardAssemblies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionDiscardAssemblies");
			BurstCompilerOptions.NativeFieldInfoPtr_OptionSaveExtraContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "OptionSaveExtraContext");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandShutdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandShutdown");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandCancel");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandEnableCompiler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandEnableCompiler");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandDisableCompiler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandDisableCompiler");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandSetDefaultOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandSetDefaultOptions");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandTriggerSetupRecompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandTriggerSetupRecompilation");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandIsCurrentCompilationDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandIsCurrentCompilationDone");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandTriggerRecompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandTriggerRecompilation");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandInitialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandInitialize");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandDomainReload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandDomainReload");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandVersionNotification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandVersionNotification");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandGetTargetCpuFromHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandGetTargetCpuFromHost");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandSetProfileCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandSetProfileCallbacks");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandUnloadBurstNatives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandUnloadBurstNatives");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandIsNativeApiAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandIsNativeApiAvailable");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandILPPCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandILPPCompilation");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandIsArmTestEnv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandIsArmTestEnv");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandNotifyAssemblyCompilationNotRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandNotifyAssemblyCompilationNotRequired");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandNotifyAssemblyCompilationFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandNotifyAssemblyCompilationFinished");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandNotifyCompilationStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandNotifyCompilationStarted");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandNotifyCompilationFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandNotifyCompilationFinished");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandAotCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandAotCompilation");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandRequestInitialiseDebuggerCommmand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandRequestInitialiseDebuggerCommmand");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandInitialiseDebuggerCommmand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandInitialiseDebuggerCommmand");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandRequestSetProtocolVersionEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandRequestSetProtocolVersionEditor");
			BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandSetProtocolVersionBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "CompilerCommandSetProtocolVersionBurst");
			BurstCompilerOptions.NativeFieldInfoPtr_ForceDisableBurstCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "ForceDisableBurstCompilation");
			BurstCompilerOptions.NativeFieldInfoPtr_ForceBurstCompilationSynchronously = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "ForceBurstCompilationSynchronously");
			BurstCompilerOptions.NativeFieldInfoPtr_IsSecondaryUnityProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "IsSecondaryUnityProcess");
			BurstCompilerOptions.NativeFieldInfoPtr__enableBurstCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "_enableBurstCompilation");
			BurstCompilerOptions.NativeFieldInfoPtr__enableBurstCompileSynchronously = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "_enableBurstCompileSynchronously");
			BurstCompilerOptions.NativeFieldInfoPtr__enableBurstSafetyChecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "_enableBurstSafetyChecks");
			BurstCompilerOptions.NativeFieldInfoPtr__enableBurstTimings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "_enableBurstTimings");
			BurstCompilerOptions.NativeFieldInfoPtr__enableBurstDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "_enableBurstDebug");
			BurstCompilerOptions.NativeFieldInfoPtr__forceEnableBurstSafetyChecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "_forceEnableBurstSafetyChecks");
			BurstCompilerOptions.NativeFieldInfoPtr__IsGlobal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "<IsGlobal>k__BackingField");
			BurstCompilerOptions.NativeFieldInfoPtr__OptionsChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, "<OptionsChanged>k__BackingField");
			BurstCompilerOptions.NativeMethodInfoPtr_SerialiseCompilationOptionsSafe_Internal_Static_String_Il2CppStringArray_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663380);
			BurstCompilerOptions.NativeMethodInfoPtr_DeserialiseCompilationOptionsSafe_Internal_Static_ValueTuple_3_Il2CppStringArray_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663381);
			BurstCompilerOptions.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663382);
			BurstCompilerOptions.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663383);
			BurstCompilerOptions.NativeMethodInfoPtr_get_IsGlobal_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663384);
			BurstCompilerOptions.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663385);
			BurstCompilerOptions.NativeMethodInfoPtr_get_EnableBurstCompilation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663386);
			BurstCompilerOptions.NativeMethodInfoPtr_set_EnableBurstCompilation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663387);
			BurstCompilerOptions.NativeMethodInfoPtr_get_EnableBurstCompileSynchronously_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663388);
			BurstCompilerOptions.NativeMethodInfoPtr_set_EnableBurstCompileSynchronously_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663389);
			BurstCompilerOptions.NativeMethodInfoPtr_get_EnableBurstSafetyChecks_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663390);
			BurstCompilerOptions.NativeMethodInfoPtr_set_EnableBurstSafetyChecks_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663391);
			BurstCompilerOptions.NativeMethodInfoPtr_get_ForceEnableBurstSafetyChecks_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663392);
			BurstCompilerOptions.NativeMethodInfoPtr_set_ForceEnableBurstSafetyChecks_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663393);
			BurstCompilerOptions.NativeMethodInfoPtr_get_EnableBurstDebug_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663394);
			BurstCompilerOptions.NativeMethodInfoPtr_set_EnableBurstDebug_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663395);
			BurstCompilerOptions.NativeMethodInfoPtr_get_DisableOptimizations_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663396);
			BurstCompilerOptions.NativeMethodInfoPtr_set_DisableOptimizations_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663397);
			BurstCompilerOptions.NativeMethodInfoPtr_get_EnableFastMath_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663398);
			BurstCompilerOptions.NativeMethodInfoPtr_set_EnableFastMath_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663399);
			BurstCompilerOptions.NativeMethodInfoPtr_get_EnableBurstTimings_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663400);
			BurstCompilerOptions.NativeMethodInfoPtr_set_EnableBurstTimings_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663401);
			BurstCompilerOptions.NativeMethodInfoPtr_get_RequiresSynchronousCompilation_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663402);
			BurstCompilerOptions.NativeMethodInfoPtr_get_OptionsChanged_Internal_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663403);
			BurstCompilerOptions.NativeMethodInfoPtr_set_OptionsChanged_Internal_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663404);
			BurstCompilerOptions.NativeMethodInfoPtr_Clone_Internal_BurstCompilerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663405);
			BurstCompilerOptions.NativeMethodInfoPtr_TryGetAttribute_Private_Static_Boolean_MemberInfo_byref_BurstCompileAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663406);
			BurstCompilerOptions.NativeMethodInfoPtr_TryGetAttribute_Private_Static_Boolean_Assembly_byref_BurstCompileAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663407);
			BurstCompilerOptions.NativeMethodInfoPtr_GetBurstCompileAttribute_Private_Static_BurstCompileAttribute_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663408);
			BurstCompilerOptions.NativeMethodInfoPtr_HasBurstCompileAttribute_Internal_Static_Boolean_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663409);
			BurstCompilerOptions.NativeMethodInfoPtr_MergeAttributes_Internal_Static_Void_byref_BurstCompileAttribute_byref_BurstCompileAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663410);
			BurstCompilerOptions.NativeMethodInfoPtr_TryGetOptions_Internal_Boolean_MemberInfo_byref_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663411);
			BurstCompilerOptions.NativeMethodInfoPtr_GetOptions_Internal_String_BurstCompileAttribute_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663412);
			BurstCompilerOptions.NativeMethodInfoPtr_AddOption_Private_Static_Void_StringBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663413);
			BurstCompilerOptions.NativeMethodInfoPtr_GetOption_Internal_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663414);
			BurstCompilerOptions.NativeMethodInfoPtr_OnOptionsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663415);
			BurstCompilerOptions.NativeMethodInfoPtr_MaybeTriggerRecompilation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663416);
			BurstCompilerOptions.NativeMethodInfoPtr_CheckIsSecondaryUnityProcess_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr, 100663418);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00005864 File Offset: 0x00003A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051254, XrefRangeEnd = 1051265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerialiseCompilationOptionsSafe(Il2CppStringArray roots, Il2CppStringArray folders, string options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(roots);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(folders);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_SerialiseCompilationOptionsSafe_Internal_Static_String_Il2CppStringArray_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000058C4 File Offset: 0x00003AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051265, XrefRangeEnd = 1051271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<Il2CppStringArray, Il2CppStringArray, string> DeserialiseCompilationOptionsSafe(string from)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(from);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_DeserialiseCompilationOptionsSafe_Internal_Static_ValueTuple_3_Il2CppStringArray_Il2CppStringArray_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<Il2CppStringArray, Il2CppStringArray, string>(intPtr);
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005900 File Offset: 0x00003B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051271, XrefRangeEnd = 1051282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BurstCompilerOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000593C File Offset: 0x00003B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051282, XrefRangeEnd = 1051284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BurstCompilerOptions(bool isGlobal)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompilerOptions>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isGlobal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00005984 File Offset: 0x00003B84
		public unsafe bool IsGlobal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_get_IsGlobal_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000059C0 File Offset: 0x00003BC0
		public unsafe bool IsEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051284, XrefRangeEnd = 1051285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000059FC File Offset: 0x00003BFC
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00005A38 File Offset: 0x00003C38
		public unsafe bool EnableBurstCompilation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_get_EnableBurstCompilation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1051295, RefRangeEnd = 1051296, XrefRangeStart = 1051285, XrefRangeEnd = 1051295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_set_EnableBurstCompilation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00005A78 File Offset: 0x00003C78
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00005AB4 File Offset: 0x00003CB4
		public unsafe bool EnableBurstCompileSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_get_EnableBurstCompileSynchronously_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_set_EnableBurstCompileSynchronously_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00005AF4 File Offset: 0x00003CF4
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00005B30 File Offset: 0x00003D30
		public unsafe bool EnableBurstSafetyChecks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_get_EnableBurstSafetyChecks_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_set_EnableBurstSafetyChecks_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00005B70 File Offset: 0x00003D70
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00005BAC File Offset: 0x00003DAC
		public unsafe bool ForceEnableBurstSafetyChecks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_get_ForceEnableBurstSafetyChecks_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_set_ForceEnableBurstSafetyChecks_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00005BEC File Offset: 0x00003DEC
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00005C28 File Offset: 0x00003E28
		public unsafe bool EnableBurstDebug
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_get_EnableBurstDebug_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_set_EnableBurstDebug_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00005C68 File Offset: 0x00003E68
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00005CA4 File Offset: 0x00003EA4
		public unsafe bool DisableOptimizations
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_get_DisableOptimizations_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_set_DisableOptimizations_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00005CE4 File Offset: 0x00003EE4
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00005D20 File Offset: 0x00003F20
		public unsafe bool EnableFastMath
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_get_EnableFastMath_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_set_EnableFastMath_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00005D60 File Offset: 0x00003F60
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00005D9C File Offset: 0x00003F9C
		public unsafe bool EnableBurstTimings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_get_EnableBurstTimings_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_set_EnableBurstTimings_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00005DDC File Offset: 0x00003FDC
		public unsafe bool RequiresSynchronousCompilation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051296, XrefRangeEnd = 1051297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_get_RequiresSynchronousCompilation_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00005E18 File Offset: 0x00004018
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00005E58 File Offset: 0x00004058
		public unsafe Action OptionsChanged
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_get_OptionsChanged_Internal_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_set_OptionsChanged_Internal_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00005E9C File Offset: 0x0000409C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051297, XrefRangeEnd = 1051321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BurstCompilerOptions Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_Clone_Internal_BurstCompilerOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BurstCompilerOptions>(intPtr3) : null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00005EDC File Offset: 0x000040DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051321, XrefRangeEnd = 1051328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetAttribute(MemberInfo member, out BurstCompileAttribute attribute)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_TryGetAttribute_Private_Static_Boolean_MemberInfo_byref_BurstCompileAttribute_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			attribute = ((intPtr4 == 0) ? null : new BurstCompileAttribute(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00005F40 File Offset: 0x00004140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051328, XrefRangeEnd = 1051333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetAttribute(Assembly assembly, out BurstCompileAttribute attribute)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_TryGetAttribute_Private_Static_Boolean_Assembly_byref_BurstCompileAttribute_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			attribute = ((intPtr4 == 0) ? null : new BurstCompileAttribute(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00005FA4 File Offset: 0x000041A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1051368, RefRangeEnd = 1051372, XrefRangeStart = 1051333, XrefRangeEnd = 1051368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BurstCompileAttribute GetBurstCompileAttribute(MemberInfo memberInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_GetBurstCompileAttribute_Private_Static_BurstCompileAttribute_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BurstCompileAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00005FE8 File Offset: 0x000041E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051372, XrefRangeEnd = 1051383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasBurstCompileAttribute(MemberInfo member)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_HasBurstCompileAttribute_Internal_Static_Boolean_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000602C File Offset: 0x0000422C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051383, XrefRangeEnd = 1051384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MergeAttributes(ref BurstCompileAttribute memberAttribute, [In] ref BurstCompileAttribute assemblyAttribute)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(memberAttribute);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(assemblyAttribute);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_MergeAttributes_Internal_Static_Void_byref_BurstCompileAttribute_byref_BurstCompileAttribute_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			memberAttribute = ((intPtr5 == 0) ? null : new BurstCompileAttribute(intPtr5));
			IntPtr intPtr6 = intPtr2;
			assemblyAttribute = ((intPtr6 == 0) ? null : new BurstCompileAttribute(intPtr6));
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000060A0 File Offset: 0x000042A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051384, XrefRangeEnd = 1051409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetOptions(MemberInfo member, out string flagsOut, bool isForILPostProcessing = false, bool isForCompilerClient = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isForILPostProcessing;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isForCompilerClient;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_TryGetOptions_Internal_Boolean_MemberInfo_byref_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			flagsOut = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00006124 File Offset: 0x00004324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1051769, RefRangeEnd = 1051770, XrefRangeStart = 1051409, XrefRangeEnd = 1051769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetOptions(BurstCompileAttribute attr = null, bool isForILPostProcessing = false, bool isForCompilerClient = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isForILPostProcessing;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isForCompilerClient;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_GetOptions_Internal_String_BurstCompileAttribute_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00006188 File Offset: 0x00004388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051770, XrefRangeEnd = 1051774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddOption(StringBuilder builder, string option)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_AddOption_Private_Static_Void_StringBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000061D0 File Offset: 0x000043D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051774, XrefRangeEnd = 1051786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetOption(string optionName, Object value = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(optionName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_GetOption_Internal_Static_String_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00006220 File Offset: 0x00004420
		[CallerCount(0)]
		public unsafe void OnOptionsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_OnOptionsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00006254 File Offset: 0x00004454
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MaybeTriggerRecompilation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_MaybeTriggerRecompilation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00006288 File Offset: 0x00004488
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckIsSecondaryUnityProcess()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerOptions.NativeMethodInfoPtr_CheckIsSecondaryUnityProcess_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000226D File Offset: 0x0000046D
		public BurstCompilerOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000062B8 File Offset: 0x000044B8
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00002276 File Offset: 0x00000476
		public unsafe static string DisableCompilationArg
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_DisableCompilationArg, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_DisableCompilationArg, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000062D8 File Offset: 0x000044D8
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00002288 File Offset: 0x00000488
		public unsafe static string ForceSynchronousCompilationArg
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_ForceSynchronousCompilationArg, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_ForceSynchronousCompilationArg, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000062F8 File Offset: 0x000044F8
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0000229A File Offset: 0x0000049A
		public unsafe static string DefaultLibraryName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_DefaultLibraryName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_DefaultLibraryName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00006318 File Offset: 0x00004518
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000022AC File Offset: 0x000004AC
		public unsafe static string BurstInitializeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_BurstInitializeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_BurstInitializeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00006338 File Offset: 0x00004538
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000022BE File Offset: 0x000004BE
		public unsafe static string BurstInitializeExternalsName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_BurstInitializeExternalsName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_BurstInitializeExternalsName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00006358 File Offset: 0x00004558
		// (set) Token: 0x06000095 RID: 149 RVA: 0x000022D0 File Offset: 0x000004D0
		public unsafe static string BurstInitializeStaticsName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_BurstInitializeStaticsName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_BurstInitializeStaticsName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00006378 File Offset: 0x00004578
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000022E2 File Offset: 0x000004E2
		public unsafe static string OptionBurstcSwitch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionBurstcSwitch, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionBurstcSwitch, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00006398 File Offset: 0x00004598
		// (set) Token: 0x06000099 RID: 153 RVA: 0x000022F4 File Offset: 0x000004F4
		public unsafe static string OptionGroup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionGroup, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionGroup, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000063B8 File Offset: 0x000045B8
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002306 File Offset: 0x00000506
		public unsafe static string OptionPlatform
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionPlatform, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionPlatform, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000063D8 File Offset: 0x000045D8
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002318 File Offset: 0x00000518
		public unsafe static string OptionBackend
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionBackend, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionBackend, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000063F8 File Offset: 0x000045F8
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000232A File Offset: 0x0000052A
		public unsafe static string OptionGlobalSafetyChecksSetting
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionGlobalSafetyChecksSetting, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionGlobalSafetyChecksSetting, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00006418 File Offset: 0x00004618
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000233C File Offset: 0x0000053C
		public unsafe static string OptionDisableSafetyChecks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDisableSafetyChecks, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDisableSafetyChecks, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00006438 File Offset: 0x00004638
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x0000234E File Offset: 0x0000054E
		public unsafe static string OptionDisableOpt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDisableOpt, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDisableOpt, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00006458 File Offset: 0x00004658
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00002360 File Offset: 0x00000560
		public unsafe static string OptionFastMath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionFastMath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionFastMath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00006478 File Offset: 0x00004678
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002372 File Offset: 0x00000572
		public unsafe static string OptionTarget
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionTarget, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionTarget, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00006498 File Offset: 0x00004698
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00002384 File Offset: 0x00000584
		public unsafe static string OptionOptLevel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionOptLevel, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionOptLevel, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000064B8 File Offset: 0x000046B8
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00002396 File Offset: 0x00000596
		public unsafe static string OptionLogTimings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionLogTimings, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionLogTimings, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000064D8 File Offset: 0x000046D8
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000023A8 File Offset: 0x000005A8
		public unsafe static string OptionOptForSize
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionOptForSize, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionOptForSize, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000064F8 File Offset: 0x000046F8
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000023BA File Offset: 0x000005BA
		public unsafe static string OptionFloatPrecision
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionFloatPrecision, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionFloatPrecision, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00006518 File Offset: 0x00004718
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000023CC File Offset: 0x000005CC
		public unsafe static string OptionFloatMode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionFloatMode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionFloatMode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00006538 File Offset: 0x00004738
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000023DE File Offset: 0x000005DE
		public unsafe static string OptionBranchProtection
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionBranchProtection, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionBranchProtection, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00006558 File Offset: 0x00004758
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000023F0 File Offset: 0x000005F0
		public unsafe static string OptionDisableWarnings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDisableWarnings, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDisableWarnings, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00006578 File Offset: 0x00004778
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002402 File Offset: 0x00000602
		public unsafe static string OptionAssemblyDefines
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAssemblyDefines, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAssemblyDefines, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00006598 File Offset: 0x00004798
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002414 File Offset: 0x00000614
		public unsafe static string OptionDump
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDump, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDump, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000065B8 File Offset: 0x000047B8
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002426 File Offset: 0x00000626
		public unsafe static string OptionFormat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionFormat, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionFormat, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000065D8 File Offset: 0x000047D8
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00002438 File Offset: 0x00000638
		public unsafe static string OptionDebugTrap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDebugTrap, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDebugTrap, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000065F8 File Offset: 0x000047F8
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0000244A File Offset: 0x0000064A
		public unsafe static string OptionDisableVectors
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDisableVectors, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDisableVectors, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00006618 File Offset: 0x00004818
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0000245C File Offset: 0x0000065C
		public unsafe static string OptionDebug
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDebug, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDebug, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00006638 File Offset: 0x00004838
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0000246E File Offset: 0x0000066E
		public unsafe static string OptionDebugMode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDebugMode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDebugMode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00006658 File Offset: 0x00004858
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002480 File Offset: 0x00000680
		public unsafe static string OptionStaticLinkage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionStaticLinkage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionStaticLinkage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00006678 File Offset: 0x00004878
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002492 File Offset: 0x00000692
		public unsafe static string OptionJobMarshalling
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionJobMarshalling, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionJobMarshalling, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00006698 File Offset: 0x00004898
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000024A4 File Offset: 0x000006A4
		public unsafe static string OptionTempDirectory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionTempDirectory, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionTempDirectory, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000066B8 File Offset: 0x000048B8
		// (set) Token: 0x060000CB RID: 203 RVA: 0x000024B6 File Offset: 0x000006B6
		public unsafe static string OptionEnableDirectExternalLinking
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionEnableDirectExternalLinking, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionEnableDirectExternalLinking, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000066D8 File Offset: 0x000048D8
		// (set) Token: 0x060000CD RID: 205 RVA: 0x000024C8 File Offset: 0x000006C8
		public unsafe static string OptionLinkerOptions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionLinkerOptions, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionLinkerOptions, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000066F8 File Offset: 0x000048F8
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000024DA File Offset: 0x000006DA
		public unsafe static string OptionEnableAutoLayoutFallbackCheck
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionEnableAutoLayoutFallbackCheck, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionEnableAutoLayoutFallbackCheck, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00006718 File Offset: 0x00004918
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x000024EC File Offset: 0x000006EC
		public unsafe static string OptionGenerateLinkXml
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionGenerateLinkXml, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionGenerateLinkXml, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00006738 File Offset: 0x00004938
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x000024FE File Offset: 0x000006FE
		public unsafe static string OptionMetaDataGeneration
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionMetaDataGeneration, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionMetaDataGeneration, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00006758 File Offset: 0x00004958
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00002510 File Offset: 0x00000710
		public unsafe static string OptionDisableStringInterpolationInExceptionMessages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDisableStringInterpolationInExceptionMessages, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDisableStringInterpolationInExceptionMessages, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00006778 File Offset: 0x00004978
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00002522 File Offset: 0x00000722
		public unsafe static string OptionPlatformConfiguration
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionPlatformConfiguration, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionPlatformConfiguration, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00006798 File Offset: 0x00004998
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00002534 File Offset: 0x00000734
		public unsafe static string OptionStackProtector
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionStackProtector, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionStackProtector, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000067B8 File Offset: 0x000049B8
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00002546 File Offset: 0x00000746
		public unsafe static string OptionStackProtectorBufferSize
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionStackProtectorBufferSize, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionStackProtectorBufferSize, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000067D8 File Offset: 0x000049D8
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00002558 File Offset: 0x00000758
		public unsafe static string OptionCacheDirectory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionCacheDirectory, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionCacheDirectory, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000DE RID: 222 RVA: 0x000067F8 File Offset: 0x000049F8
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0000256A File Offset: 0x0000076A
		public unsafe static string OptionJitDisableFunctionCaching
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionJitDisableFunctionCaching, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionJitDisableFunctionCaching, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00006818 File Offset: 0x00004A18
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000257C File Offset: 0x0000077C
		public unsafe static string OptionJitDisableAssemblyCaching
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionJitDisableAssemblyCaching, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionJitDisableAssemblyCaching, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00006838 File Offset: 0x00004A38
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0000258E File Offset: 0x0000078E
		public unsafe static string OptionJitEnableAssemblyCachingLogs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionJitEnableAssemblyCachingLogs, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionJitEnableAssemblyCachingLogs, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00006858 File Offset: 0x00004A58
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000025A0 File Offset: 0x000007A0
		public unsafe static string OptionJitEnableSynchronousCompilation
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionJitEnableSynchronousCompilation, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionJitEnableSynchronousCompilation, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00006878 File Offset: 0x00004A78
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x000025B2 File Offset: 0x000007B2
		public unsafe static string OptionJitCompilationPriority
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionJitCompilationPriority, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionJitCompilationPriority, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00006898 File Offset: 0x00004A98
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x000025C4 File Offset: 0x000007C4
		public unsafe static string OptionJitIsForFunctionPointer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionJitIsForFunctionPointer, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionJitIsForFunctionPointer, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000EA RID: 234 RVA: 0x000068B8 File Offset: 0x00004AB8
		// (set) Token: 0x060000EB RID: 235 RVA: 0x000025D6 File Offset: 0x000007D6
		public unsafe static string OptionJitManagedFunctionPointer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionJitManagedFunctionPointer, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionJitManagedFunctionPointer, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000068D8 File Offset: 0x00004AD8
		// (set) Token: 0x060000ED RID: 237 RVA: 0x000025E8 File Offset: 0x000007E8
		public unsafe static string OptionJitManagedDelegateHandle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionJitManagedDelegateHandle, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionJitManagedDelegateHandle, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000068F8 File Offset: 0x00004AF8
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000025FA File Offset: 0x000007FA
		public unsafe static string OptionEnableInterpreter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionEnableInterpreter, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionEnableInterpreter, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00006918 File Offset: 0x00004B18
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000260C File Offset: 0x0000080C
		public unsafe static string OptionAotAssemblyFolder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotAssemblyFolder, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotAssemblyFolder, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00006938 File Offset: 0x00004B38
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x0000261E File Offset: 0x0000081E
		public unsafe static string OptionRootAssembly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionRootAssembly, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionRootAssembly, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00006958 File Offset: 0x00004B58
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002630 File Offset: 0x00000830
		public unsafe static string OptionIncludeRootAssemblyReferences
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionIncludeRootAssemblyReferences, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionIncludeRootAssemblyReferences, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00006978 File Offset: 0x00004B78
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002642 File Offset: 0x00000842
		public unsafe static string OptionAotMethod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotMethod, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotMethod, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00006998 File Offset: 0x00004B98
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002654 File Offset: 0x00000854
		public unsafe static string OptionAotType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000069B8 File Offset: 0x00004BB8
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002666 File Offset: 0x00000866
		public unsafe static string OptionAotAssembly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotAssembly, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotAssembly, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000069D8 File Offset: 0x00004BD8
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00002678 File Offset: 0x00000878
		public unsafe static string OptionAotOutputPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotOutputPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotOutputPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000069F8 File Offset: 0x00004BF8
		// (set) Token: 0x060000FF RID: 255 RVA: 0x0000268A File Offset: 0x0000088A
		public unsafe static string OptionAotKeepIntermediateFiles
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotKeepIntermediateFiles, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotKeepIntermediateFiles, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00006A18 File Offset: 0x00004C18
		// (set) Token: 0x06000101 RID: 257 RVA: 0x0000269C File Offset: 0x0000089C
		public unsafe static string OptionAotNoLink
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotNoLink, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotNoLink, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00006A38 File Offset: 0x00004C38
		// (set) Token: 0x06000103 RID: 259 RVA: 0x000026AE File Offset: 0x000008AE
		public unsafe static string OptionAotOnlyStaticMethods
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotOnlyStaticMethods, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotOnlyStaticMethods, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00006A58 File Offset: 0x00004C58
		// (set) Token: 0x06000105 RID: 261 RVA: 0x000026C0 File Offset: 0x000008C0
		public unsafe static string OptionMethodPrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionMethodPrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionMethodPrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00006A78 File Offset: 0x00004C78
		// (set) Token: 0x06000107 RID: 263 RVA: 0x000026D2 File Offset: 0x000008D2
		public unsafe static string OptionAotNoNativeToolchain
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotNoNativeToolchain, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotNoNativeToolchain, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00006A98 File Offset: 0x00004C98
		// (set) Token: 0x06000109 RID: 265 RVA: 0x000026E4 File Offset: 0x000008E4
		public unsafe static string OptionAotEmitLlvmObjects
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotEmitLlvmObjects, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotEmitLlvmObjects, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00006AB8 File Offset: 0x00004CB8
		// (set) Token: 0x0600010B RID: 267 RVA: 0x000026F6 File Offset: 0x000008F6
		public unsafe static string OptionAotKeyFolder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotKeyFolder, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotKeyFolder, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00006AD8 File Offset: 0x00004CD8
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00002708 File Offset: 0x00000908
		public unsafe static string OptionAotDecodeFolder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotDecodeFolder, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotDecodeFolder, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00006AF8 File Offset: 0x00004CF8
		// (set) Token: 0x0600010F RID: 271 RVA: 0x0000271A File Offset: 0x0000091A
		public unsafe static string OptionVerbose
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionVerbose, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionVerbose, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00006B18 File Offset: 0x00004D18
		// (set) Token: 0x06000111 RID: 273 RVA: 0x0000272C File Offset: 0x0000092C
		public unsafe static string OptionValidateExternalToolChain
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionValidateExternalToolChain, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionValidateExternalToolChain, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00006B38 File Offset: 0x00004D38
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0000273E File Offset: 0x0000093E
		public unsafe static string OptionCompilerThreads
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionCompilerThreads, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionCompilerThreads, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00006B58 File Offset: 0x00004D58
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00002750 File Offset: 0x00000950
		public unsafe static string OptionChunkSize
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionChunkSize, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionChunkSize, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00006B78 File Offset: 0x00004D78
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00002762 File Offset: 0x00000962
		public unsafe static string OptionPrintLogOnMissingPInvokeCallbackAttribute
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionPrintLogOnMissingPInvokeCallbackAttribute, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionPrintLogOnMissingPInvokeCallbackAttribute, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00006B98 File Offset: 0x00004D98
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00002774 File Offset: 0x00000974
		public unsafe static string OptionOutputMode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionOutputMode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionOutputMode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00006BB8 File Offset: 0x00004DB8
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002786 File Offset: 0x00000986
		public unsafe static string OptionAlwaysCreateOutput
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAlwaysCreateOutput, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAlwaysCreateOutput, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00006BD8 File Offset: 0x00004DD8
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002798 File Offset: 0x00000998
		public unsafe static string OptionAotPdbSearchPaths
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotPdbSearchPaths, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionAotPdbSearchPaths, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00006BF8 File Offset: 0x00004DF8
		// (set) Token: 0x0600011F RID: 287 RVA: 0x000027AA File Offset: 0x000009AA
		public unsafe static string OptionSafetyChecks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionSafetyChecks, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionSafetyChecks, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00006C18 File Offset: 0x00004E18
		// (set) Token: 0x06000121 RID: 289 RVA: 0x000027BC File Offset: 0x000009BC
		public unsafe static string OptionLibraryOutputMode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionLibraryOutputMode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionLibraryOutputMode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00006C38 File Offset: 0x00004E38
		// (set) Token: 0x06000123 RID: 291 RVA: 0x000027CE File Offset: 0x000009CE
		public unsafe static string OptionCompilationId
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionCompilationId, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionCompilationId, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00006C58 File Offset: 0x00004E58
		// (set) Token: 0x06000125 RID: 293 RVA: 0x000027E0 File Offset: 0x000009E0
		public unsafe static string OptionTargetFramework
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionTargetFramework, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionTargetFramework, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00006C78 File Offset: 0x00004E78
		// (set) Token: 0x06000127 RID: 295 RVA: 0x000027F2 File Offset: 0x000009F2
		public unsafe static string OptionDiscardAssemblies
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDiscardAssemblies, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionDiscardAssemblies, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00006C98 File Offset: 0x00004E98
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00002804 File Offset: 0x00000A04
		public unsafe static string OptionSaveExtraContext
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionSaveExtraContext, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_OptionSaveExtraContext, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00006CB8 File Offset: 0x00004EB8
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00002816 File Offset: 0x00000A16
		public unsafe static string CompilerCommandShutdown
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandShutdown, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandShutdown, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00006CD8 File Offset: 0x00004ED8
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00002828 File Offset: 0x00000A28
		public unsafe static string CompilerCommandCancel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandCancel, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandCancel, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00006CF8 File Offset: 0x00004EF8
		// (set) Token: 0x0600012F RID: 303 RVA: 0x0000283A File Offset: 0x00000A3A
		public unsafe static string CompilerCommandEnableCompiler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandEnableCompiler, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandEnableCompiler, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00006D18 File Offset: 0x00004F18
		// (set) Token: 0x06000131 RID: 305 RVA: 0x0000284C File Offset: 0x00000A4C
		public unsafe static string CompilerCommandDisableCompiler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandDisableCompiler, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandDisableCompiler, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00006D38 File Offset: 0x00004F38
		// (set) Token: 0x06000133 RID: 307 RVA: 0x0000285E File Offset: 0x00000A5E
		public unsafe static string CompilerCommandSetDefaultOptions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandSetDefaultOptions, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandSetDefaultOptions, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00006D58 File Offset: 0x00004F58
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00002870 File Offset: 0x00000A70
		public unsafe static string CompilerCommandTriggerSetupRecompilation
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandTriggerSetupRecompilation, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandTriggerSetupRecompilation, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00006D78 File Offset: 0x00004F78
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00002882 File Offset: 0x00000A82
		public unsafe static string CompilerCommandIsCurrentCompilationDone
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandIsCurrentCompilationDone, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandIsCurrentCompilationDone, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00006D98 File Offset: 0x00004F98
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00002894 File Offset: 0x00000A94
		public unsafe static string CompilerCommandTriggerRecompilation
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandTriggerRecompilation, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandTriggerRecompilation, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00006DB8 File Offset: 0x00004FB8
		// (set) Token: 0x0600013B RID: 315 RVA: 0x000028A6 File Offset: 0x00000AA6
		public unsafe static string CompilerCommandInitialize
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandInitialize, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandInitialize, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00006DD8 File Offset: 0x00004FD8
		// (set) Token: 0x0600013D RID: 317 RVA: 0x000028B8 File Offset: 0x00000AB8
		public unsafe static string CompilerCommandDomainReload
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandDomainReload, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandDomainReload, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00006DF8 File Offset: 0x00004FF8
		// (set) Token: 0x0600013F RID: 319 RVA: 0x000028CA File Offset: 0x00000ACA
		public unsafe static string CompilerCommandVersionNotification
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandVersionNotification, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandVersionNotification, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00006E18 File Offset: 0x00005018
		// (set) Token: 0x06000141 RID: 321 RVA: 0x000028DC File Offset: 0x00000ADC
		public unsafe static string CompilerCommandGetTargetCpuFromHost
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandGetTargetCpuFromHost, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandGetTargetCpuFromHost, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00006E38 File Offset: 0x00005038
		// (set) Token: 0x06000143 RID: 323 RVA: 0x000028EE File Offset: 0x00000AEE
		public unsafe static string CompilerCommandSetProfileCallbacks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandSetProfileCallbacks, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandSetProfileCallbacks, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00006E58 File Offset: 0x00005058
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00002900 File Offset: 0x00000B00
		public unsafe static string CompilerCommandUnloadBurstNatives
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandUnloadBurstNatives, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandUnloadBurstNatives, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00006E78 File Offset: 0x00005078
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00002912 File Offset: 0x00000B12
		public unsafe static string CompilerCommandIsNativeApiAvailable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandIsNativeApiAvailable, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandIsNativeApiAvailable, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00006E98 File Offset: 0x00005098
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00002924 File Offset: 0x00000B24
		public unsafe static string CompilerCommandILPPCompilation
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandILPPCompilation, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandILPPCompilation, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00006EB8 File Offset: 0x000050B8
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00002936 File Offset: 0x00000B36
		public unsafe static string CompilerCommandIsArmTestEnv
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandIsArmTestEnv, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandIsArmTestEnv, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00006ED8 File Offset: 0x000050D8
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002948 File Offset: 0x00000B48
		public unsafe static string CompilerCommandNotifyAssemblyCompilationNotRequired
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandNotifyAssemblyCompilationNotRequired, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandNotifyAssemblyCompilationNotRequired, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00006EF8 File Offset: 0x000050F8
		// (set) Token: 0x0600014F RID: 335 RVA: 0x0000295A File Offset: 0x00000B5A
		public unsafe static string CompilerCommandNotifyAssemblyCompilationFinished
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandNotifyAssemblyCompilationFinished, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandNotifyAssemblyCompilationFinished, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00006F18 File Offset: 0x00005118
		// (set) Token: 0x06000151 RID: 337 RVA: 0x0000296C File Offset: 0x00000B6C
		public unsafe static string CompilerCommandNotifyCompilationStarted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandNotifyCompilationStarted, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandNotifyCompilationStarted, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00006F38 File Offset: 0x00005138
		// (set) Token: 0x06000153 RID: 339 RVA: 0x0000297E File Offset: 0x00000B7E
		public unsafe static string CompilerCommandNotifyCompilationFinished
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandNotifyCompilationFinished, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandNotifyCompilationFinished, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00006F58 File Offset: 0x00005158
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00002990 File Offset: 0x00000B90
		public unsafe static string CompilerCommandAotCompilation
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandAotCompilation, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandAotCompilation, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00006F78 File Offset: 0x00005178
		// (set) Token: 0x06000157 RID: 343 RVA: 0x000029A2 File Offset: 0x00000BA2
		public unsafe static string CompilerCommandRequestInitialiseDebuggerCommmand
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandRequestInitialiseDebuggerCommmand, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandRequestInitialiseDebuggerCommmand, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00006F98 File Offset: 0x00005198
		// (set) Token: 0x06000159 RID: 345 RVA: 0x000029B4 File Offset: 0x00000BB4
		public unsafe static string CompilerCommandInitialiseDebuggerCommmand
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandInitialiseDebuggerCommmand, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandInitialiseDebuggerCommmand, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00006FB8 File Offset: 0x000051B8
		// (set) Token: 0x0600015B RID: 347 RVA: 0x000029C6 File Offset: 0x00000BC6
		public unsafe static string CompilerCommandRequestSetProtocolVersionEditor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandRequestSetProtocolVersionEditor, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandRequestSetProtocolVersionEditor, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00006FD8 File Offset: 0x000051D8
		// (set) Token: 0x0600015D RID: 349 RVA: 0x000029D8 File Offset: 0x00000BD8
		public unsafe static string CompilerCommandSetProtocolVersionBurst
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandSetProtocolVersionBurst, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_CompilerCommandSetProtocolVersionBurst, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00006FF8 File Offset: 0x000051F8
		// (set) Token: 0x0600015F RID: 351 RVA: 0x000029EA File Offset: 0x00000BEA
		public unsafe static bool ForceDisableBurstCompilation
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_ForceDisableBurstCompilation, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_ForceDisableBurstCompilation, (void*)(&value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00007014 File Offset: 0x00005214
		// (set) Token: 0x06000161 RID: 353 RVA: 0x000029F8 File Offset: 0x00000BF8
		public unsafe static bool ForceBurstCompilationSynchronously
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_ForceBurstCompilationSynchronously, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_ForceBurstCompilationSynchronously, (void*)(&value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00007030 File Offset: 0x00005230
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00002A06 File Offset: 0x00000C06
		public unsafe static bool IsSecondaryUnityProcess
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(BurstCompilerOptions.NativeFieldInfoPtr_IsSecondaryUnityProcess, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompilerOptions.NativeFieldInfoPtr_IsSecondaryUnityProcess, (void*)(&value));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0000704C File Offset: 0x0000524C
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00002A14 File Offset: 0x00000C14
		public unsafe bool _enableBurstCompilation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__enableBurstCompilation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__enableBurstCompilation)) = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00007074 File Offset: 0x00005274
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002A2F File Offset: 0x00000C2F
		public unsafe bool _enableBurstCompileSynchronously
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__enableBurstCompileSynchronously);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__enableBurstCompileSynchronously)) = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0000709C File Offset: 0x0000529C
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00002A4A File Offset: 0x00000C4A
		public unsafe bool _enableBurstSafetyChecks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__enableBurstSafetyChecks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__enableBurstSafetyChecks)) = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000070C4 File Offset: 0x000052C4
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00002A65 File Offset: 0x00000C65
		public unsafe bool _enableBurstTimings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__enableBurstTimings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__enableBurstTimings)) = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000070EC File Offset: 0x000052EC
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00002A80 File Offset: 0x00000C80
		public unsafe bool _enableBurstDebug
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__enableBurstDebug);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__enableBurstDebug)) = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00007114 File Offset: 0x00005314
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00002A9B File Offset: 0x00000C9B
		public unsafe bool _forceEnableBurstSafetyChecks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__forceEnableBurstSafetyChecks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__forceEnableBurstSafetyChecks)) = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0000713C File Offset: 0x0000533C
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00002AB6 File Offset: 0x00000CB6
		public unsafe bool _IsGlobal_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__IsGlobal_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__IsGlobal_k__BackingField)) = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00007164 File Offset: 0x00005364
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00002AD1 File Offset: 0x00000CD1
		public unsafe Action _OptionsChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__OptionsChanged_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompilerOptions.NativeFieldInfoPtr__OptionsChanged_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_DisableCompilationArg;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_ForceSynchronousCompilationArg;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_DefaultLibraryName;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_BurstInitializeName;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_BurstInitializeExternalsName;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_BurstInitializeStaticsName;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr_OptionBurstcSwitch;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_OptionGroup;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_OptionPlatform;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_OptionBackend;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_OptionGlobalSafetyChecksSetting;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_OptionDisableSafetyChecks;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_OptionDisableOpt;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_OptionFastMath;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_OptionTarget;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_OptionOptLevel;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_OptionLogTimings;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_OptionOptForSize;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_OptionFloatPrecision;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_OptionFloatMode;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_OptionBranchProtection;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_OptionDisableWarnings;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_OptionAssemblyDefines;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_OptionDump;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_OptionFormat;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_OptionDebugTrap;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_OptionDisableVectors;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_OptionDebug;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_OptionDebugMode;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_OptionStaticLinkage;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_OptionJobMarshalling;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_OptionTempDirectory;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_OptionEnableDirectExternalLinking;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_OptionLinkerOptions;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_OptionEnableAutoLayoutFallbackCheck;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_OptionGenerateLinkXml;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_OptionMetaDataGeneration;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_OptionDisableStringInterpolationInExceptionMessages;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_OptionPlatformConfiguration;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_OptionStackProtector;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_OptionStackProtectorBufferSize;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_OptionCacheDirectory;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_OptionJitDisableFunctionCaching;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_OptionJitDisableAssemblyCaching;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_OptionJitEnableAssemblyCachingLogs;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_OptionJitEnableSynchronousCompilation;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_OptionJitCompilationPriority;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_OptionJitIsForFunctionPointer;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr_OptionJitManagedFunctionPointer;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_OptionJitManagedDelegateHandle;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_OptionEnableInterpreter;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_OptionAotAssemblyFolder;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_OptionRootAssembly;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_OptionIncludeRootAssemblyReferences;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_OptionAotMethod;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_OptionAotType;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_OptionAotAssembly;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_OptionAotOutputPath;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_OptionAotKeepIntermediateFiles;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_OptionAotNoLink;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_OptionAotOnlyStaticMethods;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_OptionMethodPrefix;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_OptionAotNoNativeToolchain;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_OptionAotEmitLlvmObjects;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_OptionAotKeyFolder;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_OptionAotDecodeFolder;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_OptionVerbose;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_OptionValidateExternalToolChain;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr_OptionCompilerThreads;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_OptionChunkSize;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_OptionPrintLogOnMissingPInvokeCallbackAttribute;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr_OptionOutputMode;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr_OptionAlwaysCreateOutput;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr_OptionAotPdbSearchPaths;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_OptionSafetyChecks;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_OptionLibraryOutputMode;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeFieldInfoPtr_OptionCompilationId;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeFieldInfoPtr_OptionTargetFramework;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeFieldInfoPtr_OptionDiscardAssemblies;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeFieldInfoPtr_OptionSaveExtraContext;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandShutdown;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandCancel;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandEnableCompiler;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandDisableCompiler;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandSetDefaultOptions;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandTriggerSetupRecompilation;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandIsCurrentCompilationDone;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandTriggerRecompilation;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandInitialize;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandDomainReload;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandVersionNotification;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandGetTargetCpuFromHost;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandSetProfileCallbacks;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandUnloadBurstNatives;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandIsNativeApiAvailable;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandILPPCompilation;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandIsArmTestEnv;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandNotifyAssemblyCompilationNotRequired;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandNotifyAssemblyCompilationFinished;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandNotifyCompilationStarted;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandNotifyCompilationFinished;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandAotCompilation;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandRequestInitialiseDebuggerCommmand;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandInitialiseDebuggerCommmand;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandRequestSetProtocolVersionEditor;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr_CompilerCommandSetProtocolVersionBurst;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr_ForceDisableBurstCompilation;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr_ForceBurstCompilationSynchronously;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr_IsSecondaryUnityProcess;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr__enableBurstCompilation;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeFieldInfoPtr__enableBurstCompileSynchronously;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr__enableBurstSafetyChecks;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr__enableBurstTimings;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr__enableBurstDebug;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr__forceEnableBurstSafetyChecks;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr__IsGlobal_k__BackingField;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr__OptionsChanged_k__BackingField;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_SerialiseCompilationOptionsSafe_Internal_Static_String_Il2CppStringArray_Il2CppStringArray_String_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_DeserialiseCompilationOptionsSafe_Internal_Static_ValueTuple_3_Il2CppStringArray_Il2CppStringArray_String_String_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGlobal_Private_get_Boolean_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableBurstCompilation_Public_get_Boolean_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_set_EnableBurstCompilation_Public_set_Void_Boolean_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableBurstCompileSynchronously_Public_get_Boolean_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_set_EnableBurstCompileSynchronously_Public_set_Void_Boolean_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableBurstSafetyChecks_Public_get_Boolean_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_set_EnableBurstSafetyChecks_Public_set_Void_Boolean_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_get_ForceEnableBurstSafetyChecks_Public_get_Boolean_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_set_ForceEnableBurstSafetyChecks_Public_set_Void_Boolean_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableBurstDebug_Public_get_Boolean_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_set_EnableBurstDebug_Public_set_Void_Boolean_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_get_DisableOptimizations_Public_get_Boolean_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_set_DisableOptimizations_Public_set_Void_Boolean_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableFastMath_Public_get_Boolean_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_set_EnableFastMath_Public_set_Void_Boolean_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableBurstTimings_Internal_get_Boolean_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_set_EnableBurstTimings_Internal_set_Void_Boolean_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_get_RequiresSynchronousCompilation_Internal_get_Boolean_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_get_OptionsChanged_Internal_get_Action_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_set_OptionsChanged_Internal_set_Void_Action_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_BurstCompilerOptions_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_TryGetAttribute_Private_Static_Boolean_MemberInfo_byref_BurstCompileAttribute_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_TryGetAttribute_Private_Static_Boolean_Assembly_byref_BurstCompileAttribute_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_GetBurstCompileAttribute_Private_Static_BurstCompileAttribute_MemberInfo_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_HasBurstCompileAttribute_Internal_Static_Boolean_MemberInfo_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_MergeAttributes_Internal_Static_Void_byref_BurstCompileAttribute_byref_BurstCompileAttribute_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_TryGetOptions_Internal_Boolean_MemberInfo_byref_String_Boolean_Boolean_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_GetOptions_Internal_String_BurstCompileAttribute_Boolean_Boolean_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_AddOption_Private_Static_Void_StringBuilder_String_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_GetOption_Internal_Static_String_String_Object_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_OnOptionsChanged_Private_Void_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_MaybeTriggerRecompilation_Private_Void_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_CheckIsSecondaryUnityProcess_Private_Static_Boolean_0;
	}
}
