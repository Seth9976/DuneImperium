using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Extensions.Logging;
using Il2CppSystem;

namespace Logging
{
	// Token: 0x02000009 RID: 9
	public static class Debug : Object
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00002EBC File Offset: 0x000010BC
		// Note: this type is marked as 'beforefieldinit'.
		static Debug()
		{
			Il2CppClassPointerStore<Debug>.NativeClassPtr = IL2CPP.GetIl2CppClass("Logging.dll", "Logging", "Debug");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Debug>.NativeClassPtr);
			Debug.NativeFieldInfoPtr_logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug>.NativeClassPtr, "logger");
			Debug.NativeFieldInfoPtr_aiLogger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug>.NativeClassPtr, "aiLogger");
			Debug.NativeFieldInfoPtr_EnableAILogging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug>.NativeClassPtr, "EnableAILogging");
			Debug.NativeFieldInfoPtr__loggerFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug>.NativeClassPtr, "_loggerFactory");
			Debug.NativeFieldInfoPtr__aiLoggerFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug>.NativeClassPtr, "_aiLoggerFactory");
			Debug.NativeFieldInfoPtr_portNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug>.NativeClassPtr, "portNumber");
			Debug.NativeFieldInfoPtr_environment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug>.NativeClassPtr, "environment");
			Debug.NativeMethodInfoPtr_get_Logger_Public_Static_get_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663323);
			Debug.NativeMethodInfoPtr_get_AILogger_Private_Static_get_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663324);
			Debug.NativeMethodInfoPtr_get_Factory_Public_Static_get_ILoggerFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663325);
			Debug.NativeMethodInfoPtr_get_AIFactory_Public_Static_get_ILoggerFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663326);
			Debug.NativeMethodInfoPtr_InitializeLogger_Public_Static_Void_String_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663327);
			Debug.NativeMethodInfoPtr_EnableLoggingForAI_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663328);
			Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663329);
			Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663330);
			Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663331);
			Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663332);
			Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663333);
			Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663334);
			Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663335);
			Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663336);
			Debug.NativeMethodInfoPtr_LogInfoException_Public_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663337);
			Debug.NativeMethodInfoPtr_Log_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663338);
			Debug.NativeMethodInfoPtr_LogWithTime_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663339);
			Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663340);
			Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663341);
			Debug.NativeMethodInfoPtr_LogFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663342);
			Debug.NativeMethodInfoPtr_LogDebug_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663343);
			Debug.NativeMethodInfoPtr_LogDebugFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663344);
			Debug.NativeMethodInfoPtr_LogAI_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663345);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003144 File Offset: 0x00001344
		public unsafe static ILogger Logger
		{
			[CallerCount(133)]
			[CachedScanResults(RefRangeStart = 1271103, RefRangeEnd = 1271236, XrefRangeStart = 1271086, XrefRangeEnd = 1271103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_get_Logger_Public_Static_get_ILogger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00003178 File Offset: 0x00001378
		public unsafe static ILogger AILogger
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1271281, RefRangeEnd = 1271282, XrefRangeStart = 1271236, XrefRangeEnd = 1271281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_get_AILogger_Private_Static_get_ILogger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000031AC File Offset: 0x000013AC
		public unsafe static ILoggerFactory Factory
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1271310, RefRangeEnd = 1271312, XrefRangeStart = 1271282, XrefRangeEnd = 1271310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_get_Factory_Public_Static_get_ILoggerFactory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILoggerFactory>(intPtr3) : null;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000031E0 File Offset: 0x000013E0
		public unsafe static ILoggerFactory AIFactory
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271312, XrefRangeEnd = 1271340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_get_AIFactory_Public_Static_get_ILoggerFactory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILoggerFactory>(intPtr3) : null;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003214 File Offset: 0x00001414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271340, XrefRangeEnd = 1271357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeLogger(string configFile, int port, string env, int pid)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(configFile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(env);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_InitializeLogger_Public_Static_Void_String_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003278 File Offset: 0x00001478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271357, XrefRangeEnd = 1271361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnableLoggingForAI(bool enable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_EnableLoggingForAI_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000032AC File Offset: 0x000014AC
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 1271371, RefRangeEnd = 1271419, XrefRangeStart = 1271361, XrefRangeEnd = 1271371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(string message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000032E4 File Offset: 0x000014E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271430, RefRangeEnd = 1271431, XrefRangeStart = 1271419, XrefRangeEnd = 1271430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000331C File Offset: 0x0000151C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271446, RefRangeEnd = 1271447, XrefRangeStart = 1271431, XrefRangeEnd = 1271446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003354 File Offset: 0x00001554
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 1271458, RefRangeEnd = 1271491, XrefRangeStart = 1271447, XrefRangeEnd = 1271458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(string message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000338C File Offset: 0x0000158C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271491, XrefRangeEnd = 1271503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000033C4 File Offset: 0x000015C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1271518, RefRangeEnd = 1271520, XrefRangeStart = 1271503, XrefRangeEnd = 1271518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(string message, Exception exception)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_String_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000340C File Offset: 0x0000160C
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1271527, RefRangeEnd = 1271553, XrefRangeStart = 1271520, XrefRangeEnd = 1271527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003444 File Offset: 0x00001644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271560, RefRangeEnd = 1271561, XrefRangeStart = 1271553, XrefRangeEnd = 1271560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogException(string message, Exception exception)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_String_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000348C File Offset: 0x0000168C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1271576, RefRangeEnd = 1271578, XrefRangeStart = 1271561, XrefRangeEnd = 1271576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogInfoException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogInfoException_Public_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000034C4 File Offset: 0x000016C4
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 1271597, RefRangeEnd = 1271658, XrefRangeStart = 1271578, XrefRangeEnd = 1271597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(string message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Log_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000034FC File Offset: 0x000016FC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1271680, RefRangeEnd = 1271690, XrefRangeStart = 1271658, XrefRangeEnd = 1271680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWithTime(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWithTime_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003534 File Offset: 0x00001734
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1271698, RefRangeEnd = 1271704, XrefRangeStart = 1271690, XrefRangeEnd = 1271698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarningFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000358C File Offset: 0x0000178C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1271712, RefRangeEnd = 1271714, XrefRangeStart = 1271704, XrefRangeEnd = 1271712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogErrorFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000035E4 File Offset: 0x000017E4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1271722, RefRangeEnd = 1271740, XrefRangeStart = 1271714, XrefRangeEnd = 1271722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000363C File Offset: 0x0000183C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1271751, RefRangeEnd = 1271755, XrefRangeStart = 1271740, XrefRangeEnd = 1271751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogDebug(string message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogDebug_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003674 File Offset: 0x00001874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271755, XrefRangeEnd = 1271763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogDebugFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogDebugFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000036CC File Offset: 0x000018CC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1271776, RefRangeEnd = 1271788, XrefRangeStart = 1271763, XrefRangeEnd = 1271776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogAI(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogAI_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002102 File Offset: 0x00000302
		public static void LogWarningFormat(string format, params Object[] args)
		{
			Debug.LogWarningFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002110 File Offset: 0x00000310
		public static void LogErrorFormat(string format, params Object[] args)
		{
			Debug.LogErrorFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000211E File Offset: 0x0000031E
		public static void LogFormat(string format, params Object[] args)
		{
			Debug.LogFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000212C File Offset: 0x0000032C
		public static void LogDebugFormat(string format, params Object[] args)
		{
			Debug.LogDebugFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000213A File Offset: 0x0000033A
		public Debug(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00003704 File Offset: 0x00001904
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002143 File Offset: 0x00000343
		public unsafe static ILogger logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Debug.NativeFieldInfoPtr_logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debug.NativeFieldInfoPtr_logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0000372C File Offset: 0x0000192C
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002155 File Offset: 0x00000355
		public unsafe static ILogger aiLogger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Debug.NativeFieldInfoPtr_aiLogger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debug.NativeFieldInfoPtr_aiLogger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00003754 File Offset: 0x00001954
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002167 File Offset: 0x00000367
		public unsafe static bool EnableAILogging
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Debug.NativeFieldInfoPtr_EnableAILogging, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debug.NativeFieldInfoPtr_EnableAILogging, (void*)(&value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00003770 File Offset: 0x00001970
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002175 File Offset: 0x00000375
		public unsafe static ILoggerFactory _loggerFactory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Debug.NativeFieldInfoPtr__loggerFactory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILoggerFactory>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debug.NativeFieldInfoPtr__loggerFactory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00003798 File Offset: 0x00001998
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002187 File Offset: 0x00000387
		public unsafe static ILoggerFactory _aiLoggerFactory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Debug.NativeFieldInfoPtr__aiLoggerFactory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILoggerFactory>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debug.NativeFieldInfoPtr__aiLoggerFactory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000037C0 File Offset: 0x000019C0
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002199 File Offset: 0x00000399
		public unsafe static int portNumber
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Debug.NativeFieldInfoPtr_portNumber, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debug.NativeFieldInfoPtr_portNumber, (void*)(&value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000037DC File Offset: 0x000019DC
		// (set) Token: 0x06000054 RID: 84 RVA: 0x000021A7 File Offset: 0x000003A7
		public unsafe static string environment
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Debug.NativeFieldInfoPtr_environment, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debug.NativeFieldInfoPtr_environment, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_logger;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_aiLogger;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_EnableAILogging;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr__loggerFactory;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr__aiLoggerFactory;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_portNumber;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_environment;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_Logger_Public_Static_get_ILogger_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_get_AILogger_Private_Static_get_ILogger_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_Factory_Public_Static_get_ILoggerFactory_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_get_AIFactory_Public_Static_get_ILoggerFactory_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_InitializeLogger_Public_Static_Void_String_Int32_String_Int32_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_EnableLoggingForAI_Public_Static_Void_Boolean_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_String_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Exception_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_String_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_String_Exception_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_String_Exception_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_LogInfoException_Public_Static_Void_Exception_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_String_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_LogWithTime_Public_Static_Void_Object_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_LogFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_LogDebug_Public_Static_Void_String_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_LogDebugFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_LogAI_Public_Static_Void_Object_0;

		// Token: 0x02000010 RID: 16
		[ObfuscatedName("Logging.Debug+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060000B0 RID: 176 RVA: 0x00005230 File Offset: 0x00003430
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Debug.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Debug>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Debug.__c>.NativeClassPtr);
				Debug.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug.__c>.NativeClassPtr, "<>9");
				Debug.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug.__c>.NativeClassPtr, "<>9__12_1");
				Debug.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug.__c>.NativeClassPtr, "<>9__12_0");
				Debug.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug.__c>.NativeClassPtr, "<>9__14_1");
				Debug.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug.__c>.NativeClassPtr, "<>9__14_0");
				Debug.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug.__c>.NativeClassPtr, 100663348);
				Debug.__c.NativeMethodInfoPtr__get_Factory_b__12_0_Internal_Void_ILoggingBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug.__c>.NativeClassPtr, 100663349);
				Debug.__c.NativeMethodInfoPtr__get_Factory_b__12_1_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug.__c>.NativeClassPtr, 100663350);
				Debug.__c.NativeMethodInfoPtr__get_AIFactory_b__14_0_Internal_Void_ILoggingBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug.__c>.NativeClassPtr, 100663351);
				Debug.__c.NativeMethodInfoPtr__get_AIFactory_b__14_1_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug.__c>.NativeClassPtr, 100663352);
			}

			// Token: 0x060000B1 RID: 177 RVA: 0x00005324 File Offset: 0x00003524
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Debug.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000B2 RID: 178 RVA: 0x00005360 File Offset: 0x00003560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271038, XrefRangeEnd = 1271069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _get_Factory_b__12_0(ILoggingBuilder logging)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(logging);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.__c.NativeMethodInfoPtr__get_Factory_b__12_0_Internal_Void_ILoggingBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000B3 RID: 179 RVA: 0x000053A4 File Offset: 0x000035A4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _get_Factory_b__12_1(Object options)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.__c.NativeMethodInfoPtr__get_Factory_b__12_1_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000B4 RID: 180 RVA: 0x000053E8 File Offset: 0x000035E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271069, XrefRangeEnd = 1271086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _get_AIFactory_b__14_0(ILoggingBuilder logging)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(logging);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.__c.NativeMethodInfoPtr__get_AIFactory_b__14_0_Internal_Void_ILoggingBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000B5 RID: 181 RVA: 0x0000542C File Offset: 0x0000362C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _get_AIFactory_b__14_1(Object options)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.__c.NativeMethodInfoPtr__get_AIFactory_b__14_1_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000B6 RID: 182 RVA: 0x00002359 File Offset: 0x00000559
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000B7 RID: 183 RVA: 0x00005470 File Offset: 0x00003670
			// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002362 File Offset: 0x00000562
			public unsafe static Debug.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Debug.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Debug.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Debug.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000B9 RID: 185 RVA: 0x00005498 File Offset: 0x00003698
			// (set) Token: 0x060000BA RID: 186 RVA: 0x00002374 File Offset: 0x00000574
			public unsafe static Action<Object> __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Debug.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Debug.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000BB RID: 187 RVA: 0x000054C0 File Offset: 0x000036C0
			// (set) Token: 0x060000BC RID: 188 RVA: 0x00002386 File Offset: 0x00000586
			public unsafe static Action<ILoggingBuilder> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Debug.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ILoggingBuilder>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Debug.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000BD RID: 189 RVA: 0x000054E8 File Offset: 0x000036E8
			// (set) Token: 0x060000BE RID: 190 RVA: 0x00002398 File Offset: 0x00000598
			public unsafe static Action<Object> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Debug.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Debug.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000BF RID: 191 RVA: 0x00005510 File Offset: 0x00003710
			// (set) Token: 0x060000C0 RID: 192 RVA: 0x000023AA File Offset: 0x000005AA
			public unsafe static Action<ILoggingBuilder> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Debug.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ILoggingBuilder>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Debug.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000077 RID: 119
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000078 RID: 120
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x04000079 RID: 121
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x0400007A RID: 122
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x0400007B RID: 123
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x0400007C RID: 124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400007D RID: 125
			private static readonly IntPtr NativeMethodInfoPtr__get_Factory_b__12_0_Internal_Void_ILoggingBuilder_0;

			// Token: 0x0400007E RID: 126
			private static readonly IntPtr NativeMethodInfoPtr__get_Factory_b__12_1_Internal_Void_Object_0;

			// Token: 0x0400007F RID: 127
			private static readonly IntPtr NativeMethodInfoPtr__get_AIFactory_b__14_0_Internal_Void_ILoggingBuilder_0;

			// Token: 0x04000080 RID: 128
			private static readonly IntPtr NativeMethodInfoPtr__get_AIFactory_b__14_1_Internal_Void_Object_0;
		}
	}
}
