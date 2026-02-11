using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x02000017 RID: 23
	public static class LoggerExtensions : Object
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00003D50 File Offset: 0x00001F50
		// Note: this type is marked as 'beforefieldinit'.
		static LoggerExtensions()
		{
			Il2CppClassPointerStore<LoggerExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.Abstractions.dll", "Microsoft.Extensions.Logging", "LoggerExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoggerExtensions>.NativeClassPtr);
			LoggerExtensions.NativeFieldInfoPtr__messageFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerExtensions>.NativeClassPtr, "_messageFormatter");
			LoggerExtensions.NativeMethodInfoPtr_LogDebug_Public_Static_Void_ILogger_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerExtensions>.NativeClassPtr, 100663355);
			LoggerExtensions.NativeMethodInfoPtr_LogInformation_Public_Static_Void_ILogger_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerExtensions>.NativeClassPtr, 100663356);
			LoggerExtensions.NativeMethodInfoPtr_LogWarning_Public_Static_Void_ILogger_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerExtensions>.NativeClassPtr, 100663357);
			LoggerExtensions.NativeMethodInfoPtr_LogError_Public_Static_Void_ILogger_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerExtensions>.NativeClassPtr, 100663358);
			LoggerExtensions.NativeMethodInfoPtr_Log_Public_Static_Void_ILogger_LogLevel_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerExtensions>.NativeClassPtr, 100663359);
			LoggerExtensions.NativeMethodInfoPtr_Log_Public_Static_Void_ILogger_LogLevel_EventId_Exception_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerExtensions>.NativeClassPtr, 100663360);
			LoggerExtensions.NativeMethodInfoPtr_MessageFormatter_Private_Static_String_FormattedLogValues_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerExtensions>.NativeClassPtr, 100663361);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003E20 File Offset: 0x00002020
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1264699, RefRangeEnd = 1264701, XrefRangeStart = 1264695, XrefRangeEnd = 1264699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogDebug(this ILogger logger, string message, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logger);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerExtensions.NativeMethodInfoPtr_LogDebug_Public_Static_Void_ILogger_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003E88 File Offset: 0x00002088
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1264705, RefRangeEnd = 1264707, XrefRangeStart = 1264701, XrefRangeEnd = 1264705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogInformation(this ILogger logger, string message, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logger);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerExtensions.NativeMethodInfoPtr_LogInformation_Public_Static_Void_ILogger_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003EF0 File Offset: 0x000020F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1264711, RefRangeEnd = 1264712, XrefRangeStart = 1264707, XrefRangeEnd = 1264711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(this ILogger logger, string message, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logger);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerExtensions.NativeMethodInfoPtr_LogWarning_Public_Static_Void_ILogger_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003F58 File Offset: 0x00002158
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1264716, RefRangeEnd = 1264719, XrefRangeStart = 1264712, XrefRangeEnd = 1264716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(this ILogger logger, string message, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logger);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerExtensions.NativeMethodInfoPtr_LogError_Public_Static_Void_ILogger_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003FC0 File Offset: 0x000021C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1264733, RefRangeEnd = 1264737, XrefRangeStart = 1264719, XrefRangeEnd = 1264733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(this ILogger logger, LogLevel logLevel, string message, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logger);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerExtensions.NativeMethodInfoPtr_Log_Public_Static_Void_ILogger_LogLevel_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004038 File Offset: 0x00002238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264737, XrefRangeEnd = 1264747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(this ILogger logger, LogLevel logLevel, EventId eventId, Exception exception, string message, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logger);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(eventId));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerExtensions.NativeMethodInfoPtr_Log_Public_Static_Void_ILogger_LogLevel_EventId_Exception_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000040DC File Offset: 0x000022DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264747, XrefRangeEnd = 1264751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MessageFormatter(FormattedLogValues state, Exception error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerExtensions.NativeMethodInfoPtr_MessageFormatter_Private_Static_String_FormattedLogValues_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000251A File Offset: 0x0000071A
		public static void LogDebug(ILogger logger, string message, params Object[] args)
		{
			logger.LogDebug(message, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002529 File Offset: 0x00000729
		public static void LogInformation(ILogger logger, string message, params Object[] args)
		{
			logger.LogInformation(message, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002538 File Offset: 0x00000738
		public static void LogWarning(ILogger logger, string message, params Object[] args)
		{
			logger.LogWarning(message, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002547 File Offset: 0x00000747
		public static void LogError(ILogger logger, string message, params Object[] args)
		{
			logger.LogError(message, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002556 File Offset: 0x00000756
		public static void Log(ILogger logger, LogLevel logLevel, string message, params Object[] args)
		{
			logger.Log(logLevel, message, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002566 File Offset: 0x00000766
		public static void Log(ILogger logger, LogLevel logLevel, EventId eventId, Exception exception, string message, params Object[] args)
		{
			logger.Log(logLevel, eventId, exception, message, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000257A File Offset: 0x0000077A
		public LoggerExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00004130 File Offset: 0x00002330
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00002583 File Offset: 0x00000783
		public unsafe static Func<FormattedLogValues, Exception, string> _messageFormatter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoggerExtensions.NativeFieldInfoPtr__messageFormatter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FormattedLogValues, Exception, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoggerExtensions.NativeFieldInfoPtr__messageFormatter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr__messageFormatter;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_LogDebug_Public_Static_Void_ILogger_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_LogInformation_Public_Static_Void_ILogger_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_ILogger_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_ILogger_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_ILogger_LogLevel_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_ILogger_LogLevel_EventId_Exception_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_MessageFormatter_Private_Static_String_FormattedLogValues_Exception_0;
	}
}
