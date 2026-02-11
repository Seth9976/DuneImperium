using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x0200000F RID: 15
	public sealed class Logger : Object
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00003270 File Offset: 0x00001470
		// Note: this type is marked as 'beforefieldinit'.
		static Logger()
		{
			Il2CppClassPointerStore<Logger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "Microsoft.Extensions.Logging", "Logger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Logger>.NativeClassPtr);
			Logger.NativeFieldInfoPtr__categoryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Logger>.NativeClassPtr, "_categoryName");
			Logger.NativeFieldInfoPtr__Loggers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Logger>.NativeClassPtr, "<Loggers>k__BackingField");
			Logger.NativeFieldInfoPtr__MessageLoggers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Logger>.NativeClassPtr, "<MessageLoggers>k__BackingField");
			Logger.NativeFieldInfoPtr__ScopeLoggers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Logger>.NativeClassPtr, "<ScopeLoggers>k__BackingField");
			Logger.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_LoggerInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663318);
			Logger.NativeMethodInfoPtr_get_Loggers_Public_get_Il2CppReferenceArray_1_LoggerInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663319);
			Logger.NativeMethodInfoPtr_set_Loggers_Public_set_Void_Il2CppReferenceArray_1_LoggerInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663320);
			Logger.NativeMethodInfoPtr_get_MessageLoggers_Public_get_Il2CppReferenceArray_1_MessageLogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663321);
			Logger.NativeMethodInfoPtr_set_MessageLoggers_Public_set_Void_Il2CppReferenceArray_1_MessageLogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663322);
			Logger.NativeMethodInfoPtr_set_ScopeLoggers_Public_set_Void_Il2CppReferenceArray_1_ScopeLogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663323);
			Logger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663324);
			Logger.NativeMethodInfoPtr_ThrowLoggingError_Private_Static_Void_List_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663325);
			Logger.NativeMethodInfoPtr_Method_Internal_Static_Void_LogLevel_EventId_ILogger_Exception_Func_3_TState_Exception_String_byref_List_1_Exception_byref_TState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663326);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000033A4 File Offset: 0x000015A4
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Logger(string categoryName, Il2CppReferenceArray<LoggerInformation> loggers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Logger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loggers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_LoggerInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00003404 File Offset: 0x00001604
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00003444 File Offset: 0x00001644
		public unsafe Il2CppReferenceArray<LoggerInformation> Loggers
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_get_Loggers_Public_get_Il2CppReferenceArray_1_LoggerInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LoggerInformation>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_set_Loggers_Public_set_Void_Il2CppReferenceArray_1_LoggerInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00003488 File Offset: 0x00001688
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000034C8 File Offset: 0x000016C8
		public unsafe Il2CppReferenceArray<MessageLogger> MessageLoggers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_get_MessageLoggers_Public_get_Il2CppReferenceArray_1_MessageLogger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MessageLogger>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_set_MessageLoggers_Public_set_Void_Il2CppReferenceArray_1_MessageLogger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0000350C File Offset: 0x0000170C
		public unsafe Il2CppReferenceArray<ScopeLogger> ScopeLoggers
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_set_ScopeLoggers_Public_set_Void_Il2CppReferenceArray_1_ScopeLogger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003550 File Offset: 0x00001750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263951, XrefRangeEnd = 1263957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(eventId));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TState).IsValueType)
			{
				TState tstate = state;
				intPtr = ((tstate is string) ? IL2CPP.ManagedStringToIl2Cpp(tstate as string) : IL2CPP.Il2CppObjectBaseToPtr(tstate as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref state;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatter);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Logger.MethodInfoStoreGeneric_Log_Public_Virtual_Final_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0<TState>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003614 File Offset: 0x00001814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1263963, RefRangeEnd = 1263964, XrefRangeStart = 1263957, XrefRangeEnd = 1263963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowLoggingError(List<Exception> exceptions)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_ThrowLoggingError_Private_Static_Void_List_1_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000364C File Offset: 0x0000184C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1263976, RefRangeEnd = 1263977, XrefRangeStart = 1263964, XrefRangeEnd = 1263976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_LogLevel_EventId_ILogger_Exception_Func_3_TState_Exception_String_byref_List_1_Exception_byref_TState_0<TState>(LogLevel logLevel, EventId eventId, ILogger logger, Exception exception, Func<TState, Exception, string> formatter, ref List<Exception> exceptions, [In] ref TState state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(eventId));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(logger);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatter);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(exceptions);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Logger.MethodInfoStoreGeneric_Method_Internal_Static_Void_LogLevel_EventId_ILogger_Exception_Func_3_TState_Exception_String_byref_List_1_Exception_byref_TState_0<TState>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			exceptions = ((intPtr5 == 0) ? null : new List<Exception>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			state = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TState>(intPtr6, false, false));
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000225A File Offset: 0x0000045A
		public Logger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00003724 File Offset: 0x00001924
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00002263 File Offset: 0x00000463
		public unsafe string _categoryName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__categoryName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__categoryName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0000374C File Offset: 0x0000194C
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00002282 File Offset: 0x00000482
		public unsafe Il2CppReferenceArray<LoggerInformation> _Loggers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__Loggers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LoggerInformation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__Loggers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000377C File Offset: 0x0000197C
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000022A1 File Offset: 0x000004A1
		public unsafe Il2CppReferenceArray<MessageLogger> _MessageLoggers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__MessageLoggers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MessageLogger>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__MessageLoggers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000037AC File Offset: 0x000019AC
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000022C0 File Offset: 0x000004C0
		public unsafe Il2CppReferenceArray<ScopeLogger> _ScopeLoggers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__ScopeLoggers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScopeLogger>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__ScopeLoggers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr__categoryName;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr__Loggers_k__BackingField;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr__MessageLoggers_k__BackingField;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr__ScopeLoggers_k__BackingField;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_LoggerInformation_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_get_Loggers_Public_get_Il2CppReferenceArray_1_LoggerInformation_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_set_Loggers_Public_set_Void_Il2CppReferenceArray_1_LoggerInformation_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_get_MessageLoggers_Public_get_Il2CppReferenceArray_1_MessageLogger_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_set_MessageLoggers_Public_set_Void_Il2CppReferenceArray_1_MessageLogger_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_set_ScopeLoggers_Public_set_Void_Il2CppReferenceArray_1_ScopeLogger_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_ThrowLoggingError_Private_Static_Void_List_1_Exception_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_LogLevel_EventId_ILogger_Exception_Func_3_TState_Exception_String_byref_List_1_Exception_byref_TState_0;

		// Token: 0x0200001E RID: 30
		public sealed class LoggerDebugView : Object
		{
			// Token: 0x060000DF RID: 223 RVA: 0x000027E7 File Offset: 0x000009E7
			// Note: this type is marked as 'beforefieldinit'.
			static LoggerDebugView()
			{
				Il2CppClassPointerStore<Logger.LoggerDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Logger>.NativeClassPtr, "LoggerDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Logger.LoggerDebugView>.NativeClassPtr);
			}

			// Token: 0x060000E0 RID: 224 RVA: 0x00002807 File Offset: 0x00000A07
			public LoggerDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}

		// Token: 0x0200001F RID: 31
		private sealed class MethodInfoStoreGeneric_Log_Public_Virtual_Final_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0<TState>
		{
			// Token: 0x04000083 RID: 131
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Logger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0, Il2CppClassPointerStore<Logger>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) }))));
		}

		// Token: 0x02000020 RID: 32
		private sealed class MethodInfoStoreGeneric_Method_Internal_Static_Void_LogLevel_EventId_ILogger_Exception_Func_3_TState_Exception_String_byref_List_1_Exception_byref_TState_0<TState>
		{
			// Token: 0x04000084 RID: 132
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Logger.NativeMethodInfoPtr_Method_Internal_Static_Void_LogLevel_EventId_ILogger_Exception_Func_3_TState_Exception_String_byref_List_1_Exception_byref_TState_0, Il2CppClassPointerStore<Logger>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) }))));
		}
	}
}
