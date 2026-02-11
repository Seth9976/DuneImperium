using System;
using System.Runtime.InteropServices;
using Google.Apis.Util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Google.Apis.Logging
{
	// Token: 0x02000018 RID: 24
	public class BaseLogger : Object
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x000076E8 File Offset: 0x000058E8
		// Note: this type is marked as 'beforefieldinit'.
		static BaseLogger()
		{
			Il2CppClassPointerStore<BaseLogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Logging", "BaseLogger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr);
			BaseLogger.NativeFieldInfoPtr_DateTimeFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, "DateTimeFormatString");
			BaseLogger.NativeFieldInfoPtr__loggerForTypeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, "_loggerForTypeString");
			BaseLogger.NativeFieldInfoPtr__Clock_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, "<Clock>k__BackingField");
			BaseLogger.NativeFieldInfoPtr__LoggerForType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, "<LoggerForType>k__BackingField");
			BaseLogger.NativeFieldInfoPtr__MinimumLogLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, "<MinimumLogLevel>k__BackingField");
			BaseLogger.NativeFieldInfoPtr__IsDebugEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, "<IsDebugEnabled>k__BackingField");
			BaseLogger.NativeFieldInfoPtr__IsInfoEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, "<IsInfoEnabled>k__BackingField");
			BaseLogger.NativeFieldInfoPtr__IsWarningEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, "<IsWarningEnabled>k__BackingField");
			BaseLogger.NativeFieldInfoPtr__IsErrorEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, "<IsErrorEnabled>k__BackingField");
			BaseLogger.NativeMethodInfoPtr__ctor_Protected_Void_LogLevel_IClock_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, 100663435);
			BaseLogger.NativeMethodInfoPtr_get_Clock_Public_get_IClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, 100663436);
			BaseLogger.NativeMethodInfoPtr_get_LoggerForType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, 100663437);
			BaseLogger.NativeMethodInfoPtr_get_MinimumLogLevel_Public_get_LogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, 100663438);
			BaseLogger.NativeMethodInfoPtr_get_IsDebugEnabled_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, 100663439);
			BaseLogger.NativeMethodInfoPtr_get_IsInfoEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, 100663440);
			BaseLogger.NativeMethodInfoPtr_get_IsWarningEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, 100663441);
			BaseLogger.NativeMethodInfoPtr_get_IsErrorEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, 100663442);
			BaseLogger.NativeMethodInfoPtr_BuildNewLogger_Protected_Abstract_Virtual_New_ILogger_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, 100663443);
			BaseLogger.NativeMethodInfoPtr_ForType_Public_Virtual_Final_New_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, 100663444);
			BaseLogger.NativeMethodInfoPtr_ForType_Public_Virtual_Final_New_ILogger_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, 100663445);
			BaseLogger.NativeMethodInfoPtr_Log_Protected_Abstract_Virtual_New_Void_LogLevel_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, 100663446);
			BaseLogger.NativeMethodInfoPtr_FormatLogEntry_Private_String_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, 100663447);
			BaseLogger.NativeMethodInfoPtr_Debug_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, 100663448);
			BaseLogger.NativeMethodInfoPtr_Info_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, 100663449);
			BaseLogger.NativeMethodInfoPtr_Warning_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, 100663450);
			BaseLogger.NativeMethodInfoPtr_Error_Public_Virtual_Final_New_Void_Exception_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, 100663451);
			BaseLogger.NativeMethodInfoPtr_Error_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr, 100663452);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00007934 File Offset: 0x00005B34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1211019, RefRangeEnd = 1211023, XrefRangeStart = 1210994, XrefRangeEnd = 1211019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseLogger(LogLevel minimumLogLevel, IClock clock, Type forType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseLogger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minimumLogLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clock);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseLogger.NativeMethodInfoPtr__ctor_Protected_Void_LogLevel_IClock_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000079A0 File Offset: 0x00005BA0
		public unsafe IClock Clock
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseLogger.NativeMethodInfoPtr_get_Clock_Public_get_IClock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr3) : null;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000079E0 File Offset: 0x00005BE0
		public unsafe Type LoggerForType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseLogger.NativeMethodInfoPtr_get_LoggerForType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00007A20 File Offset: 0x00005C20
		public unsafe LogLevel MinimumLogLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseLogger.NativeMethodInfoPtr_get_MinimumLogLevel_Public_get_LogLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00007A5C File Offset: 0x00005C5C
		public unsafe virtual bool IsDebugEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseLogger.NativeMethodInfoPtr_get_IsDebugEnabled_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00007A98 File Offset: 0x00005C98
		public unsafe bool IsInfoEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseLogger.NativeMethodInfoPtr_get_IsInfoEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00007AD4 File Offset: 0x00005CD4
		public unsafe bool IsWarningEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseLogger.NativeMethodInfoPtr_get_IsWarningEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00007B10 File Offset: 0x00005D10
		public unsafe bool IsErrorEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseLogger.NativeMethodInfoPtr_get_IsErrorEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00007B4C File Offset: 0x00005D4C
		[CallerCount(0)]
		public unsafe virtual ILogger BuildNewLogger(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseLogger.NativeMethodInfoPtr_BuildNewLogger_Protected_Abstract_Virtual_New_ILogger_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00007BA8 File Offset: 0x00005DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211023, XrefRangeEnd = 1211029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ILogger ForType<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseLogger.MethodInfoStoreGeneric_ForType_Public_Virtual_Final_New_ILogger_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00007BE8 File Offset: 0x00005DE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1211033, RefRangeEnd = 1211034, XrefRangeStart = 1211029, XrefRangeEnd = 1211033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ILogger ForType(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseLogger.NativeMethodInfoPtr_ForType_Public_Virtual_Final_New_ILogger_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00007C38 File Offset: 0x00005E38
		[CallerCount(0)]
		public unsafe virtual void Log(LogLevel logLevel, string formattedMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(formattedMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseLogger.NativeMethodInfoPtr_Log_Protected_Abstract_Virtual_New_Void_LogLevel_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00007C94 File Offset: 0x00005E94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1211059, RefRangeEnd = 1211064, XrefRangeStart = 1211034, XrefRangeEnd = 1211059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatLogEntry(string severityString, string message, [Optional] Il2CppReferenceArray<Object> formatArgs)
		{
			if (formatArgs == null)
			{
				formatArgs = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(severityString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseLogger.NativeMethodInfoPtr_FormatLogEntry_Private_String_String_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00007D10 File Offset: 0x00005F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211064, XrefRangeEnd = 1211067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Debug(string message, [Optional] Il2CppReferenceArray<Object> formatArgs)
		{
			if (formatArgs == null)
			{
				formatArgs = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseLogger.NativeMethodInfoPtr_Debug_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00007D74 File Offset: 0x00005F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211067, XrefRangeEnd = 1211070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Info(string message, [Optional] Il2CppReferenceArray<Object> formatArgs)
		{
			if (formatArgs == null)
			{
				formatArgs = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseLogger.NativeMethodInfoPtr_Info_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00007DD8 File Offset: 0x00005FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211070, XrefRangeEnd = 1211073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Warning(string message, [Optional] Il2CppReferenceArray<Object> formatArgs)
		{
			if (formatArgs == null)
			{
				formatArgs = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseLogger.NativeMethodInfoPtr_Warning_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00007E3C File Offset: 0x0000603C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211073, XrefRangeEnd = 1211079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Error(Exception exception, string message, [Optional] Il2CppReferenceArray<Object> formatArgs)
		{
			if (formatArgs == null)
			{
				formatArgs = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseLogger.NativeMethodInfoPtr_Error_Public_Virtual_Final_New_Void_Exception_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00007EB0 File Offset: 0x000060B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211079, XrefRangeEnd = 1211082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Error(string message, [Optional] Il2CppReferenceArray<Object> formatArgs)
		{
			if (formatArgs == null)
			{
				formatArgs = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseLogger.NativeMethodInfoPtr_Error_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000024DF File Offset: 0x000006DF
		public string FormatLogEntry(string severityString, string message, params Object[] formatArgs)
		{
			return this.FormatLogEntry(severityString, message, new Il2CppReferenceArray<Object>(formatArgs));
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000024EF File Offset: 0x000006EF
		public virtual void Debug(string message, params Object[] formatArgs)
		{
			this.Debug(message, new Il2CppReferenceArray<Object>(formatArgs));
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000024FE File Offset: 0x000006FE
		public virtual void Info(string message, params Object[] formatArgs)
		{
			this.Info(message, new Il2CppReferenceArray<Object>(formatArgs));
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000250D File Offset: 0x0000070D
		public virtual void Warning(string message, params Object[] formatArgs)
		{
			this.Warning(message, new Il2CppReferenceArray<Object>(formatArgs));
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000251C File Offset: 0x0000071C
		public virtual void Error(Exception exception, string message, params Object[] formatArgs)
		{
			this.Error(exception, message, new Il2CppReferenceArray<Object>(formatArgs));
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000252C File Offset: 0x0000072C
		public virtual void Error(string message, params Object[] formatArgs)
		{
			this.Error(message, new Il2CppReferenceArray<Object>(formatArgs));
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000253B File Offset: 0x0000073B
		public BaseLogger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00007F14 File Offset: 0x00006114
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002544 File Offset: 0x00000744
		public unsafe static string DateTimeFormatString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseLogger.NativeFieldInfoPtr_DateTimeFormatString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseLogger.NativeFieldInfoPtr_DateTimeFormatString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00007F34 File Offset: 0x00006134
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00002556 File Offset: 0x00000756
		public unsafe string _loggerForTypeString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseLogger.NativeFieldInfoPtr__loggerForTypeString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseLogger.NativeFieldInfoPtr__loggerForTypeString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00007F5C File Offset: 0x0000615C
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00002575 File Offset: 0x00000775
		public unsafe IClock _Clock_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseLogger.NativeFieldInfoPtr__Clock_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseLogger.NativeFieldInfoPtr__Clock_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00007F8C File Offset: 0x0000618C
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00002594 File Offset: 0x00000794
		public unsafe Type _LoggerForType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseLogger.NativeFieldInfoPtr__LoggerForType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseLogger.NativeFieldInfoPtr__LoggerForType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00007FBC File Offset: 0x000061BC
		// (set) Token: 0x06000103 RID: 259 RVA: 0x000025B3 File Offset: 0x000007B3
		public unsafe LogLevel _MinimumLogLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseLogger.NativeFieldInfoPtr__MinimumLogLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseLogger.NativeFieldInfoPtr__MinimumLogLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00007FE4 File Offset: 0x000061E4
		// (set) Token: 0x06000105 RID: 261 RVA: 0x000025CE File Offset: 0x000007CE
		public unsafe bool _IsDebugEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseLogger.NativeFieldInfoPtr__IsDebugEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseLogger.NativeFieldInfoPtr__IsDebugEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000106 RID: 262 RVA: 0x0000800C File Offset: 0x0000620C
		// (set) Token: 0x06000107 RID: 263 RVA: 0x000025E9 File Offset: 0x000007E9
		public unsafe bool _IsInfoEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseLogger.NativeFieldInfoPtr__IsInfoEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseLogger.NativeFieldInfoPtr__IsInfoEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00008034 File Offset: 0x00006234
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00002604 File Offset: 0x00000804
		public unsafe bool _IsWarningEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseLogger.NativeFieldInfoPtr__IsWarningEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseLogger.NativeFieldInfoPtr__IsWarningEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0000805C File Offset: 0x0000625C
		// (set) Token: 0x0600010B RID: 267 RVA: 0x0000261F File Offset: 0x0000081F
		public unsafe bool _IsErrorEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseLogger.NativeFieldInfoPtr__IsErrorEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseLogger.NativeFieldInfoPtr__IsErrorEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_DateTimeFormatString;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr__loggerForTypeString;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr__Clock_k__BackingField;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr__LoggerForType_k__BackingField;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr__MinimumLogLevel_k__BackingField;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr__IsDebugEnabled_k__BackingField;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr__IsInfoEnabled_k__BackingField;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr__IsWarningEnabled_k__BackingField;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr__IsErrorEnabled_k__BackingField;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_LogLevel_IClock_Type_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_get_Clock_Public_get_IClock_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_get_LoggerForType_Public_get_Type_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_get_MinimumLogLevel_Public_get_LogLevel_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDebugEnabled_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInfoEnabled_Public_get_Boolean_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_get_IsWarningEnabled_Public_get_Boolean_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_get_IsErrorEnabled_Public_get_Boolean_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_BuildNewLogger_Protected_Abstract_Virtual_New_ILogger_Type_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_ForType_Public_Virtual_Final_New_ILogger_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_ForType_Public_Virtual_Final_New_ILogger_Type_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_Log_Protected_Abstract_Virtual_New_Void_LogLevel_String_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_FormatLogEntry_Private_String_String_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_Debug_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_Info_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_Warning_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_Error_Public_Virtual_Final_New_Void_Exception_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_Error_Public_Virtual_Final_New_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0200004F RID: 79
		private sealed class MethodInfoStoreGeneric_ForType_Public_Virtual_Final_New_ILogger_0<T>
		{
			// Token: 0x040001F8 RID: 504
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BaseLogger.NativeMethodInfoPtr_ForType_Public_Virtual_Final_New_ILogger_0, Il2CppClassPointerStore<BaseLogger>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
