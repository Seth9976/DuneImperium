using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000F4 RID: 244
	public class Logger : Object
	{
		// Token: 0x06001319 RID: 4889 RVA: 0x0005FCD4 File Offset: 0x0005DED4
		// Note: this type is marked as 'beforefieldinit'.
		static Logger()
		{
			Il2CppClassPointerStore<Logger>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Logger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Logger>.NativeClassPtr);
			Logger.NativeFieldInfoPtr__logHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Logger>.NativeClassPtr, "<logHandler>k__BackingField");
			Logger.NativeFieldInfoPtr__logEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Logger>.NativeClassPtr, "<logEnabled>k__BackingField");
			Logger.NativeFieldInfoPtr__filterLogType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Logger>.NativeClassPtr, "<filterLogType>k__BackingField");
			Logger.NativeMethodInfoPtr__ctor_Public_Void_ILogHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100665987);
			Logger.NativeMethodInfoPtr_get_logHandler_Public_Virtual_Final_New_get_ILogHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100665988);
			Logger.NativeMethodInfoPtr_set_logHandler_Public_Virtual_Final_New_set_Void_ILogHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100665989);
			Logger.NativeMethodInfoPtr_get_logEnabled_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100665990);
			Logger.NativeMethodInfoPtr_set_logEnabled_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100665991);
			Logger.NativeMethodInfoPtr_get_filterLogType_Public_Virtual_Final_New_get_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100665992);
			Logger.NativeMethodInfoPtr_set_filterLogType_Public_Virtual_Final_New_set_Void_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100665993);
			Logger.NativeMethodInfoPtr_IsLogTypeAllowed_Public_Virtual_Final_New_Boolean_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100665994);
			Logger.NativeMethodInfoPtr_GetString_Private_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100665995);
			Logger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100665996);
			Logger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100665997);
			Logger.NativeMethodInfoPtr_LogError_Public_Virtual_Final_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100665998);
			Logger.NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100665999);
			Logger.NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100666000);
			Logger.NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100666001);
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x0005FE6C File Offset: 0x0005E06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657931, XrefRangeEnd = 657933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Logger(ILogHandler logHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Logger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr__ctor_Public_Void_ILogHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x0005FEB8 File Offset: 0x0005E0B8
		// (set) Token: 0x0600131C RID: 4892 RVA: 0x0005FEF8 File Offset: 0x0005E0F8
		public unsafe virtual ILogHandler logHandler
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_get_logHandler_Public_Virtual_Final_New_get_ILogHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogHandler>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_set_logHandler_Public_Virtual_Final_New_set_Void_ILogHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x0005FF3C File Offset: 0x0005E13C
		// (set) Token: 0x0600131E RID: 4894 RVA: 0x0005FF78 File Offset: 0x0005E178
		public unsafe virtual bool logEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_get_logEnabled_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_set_logEnabled_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x0600131F RID: 4895 RVA: 0x0005FFB8 File Offset: 0x0005E1B8
		// (set) Token: 0x06001320 RID: 4896 RVA: 0x0005FFF4 File Offset: 0x0005E1F4
		public unsafe virtual LogType filterLogType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_get_filterLogType_Public_Virtual_Final_New_get_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_set_filterLogType_Public_Virtual_Final_New_set_Void_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00060034 File Offset: 0x0005E234
		[CallerCount(0)]
		public unsafe virtual bool IsLogTypeAllowed(LogType logType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_IsLogTypeAllowed_Public_Virtual_Final_New_Boolean_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00060080 File Offset: 0x0005E280
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 657938, RefRangeEnd = 657941, XrefRangeStart = 657933, XrefRangeEnd = 657938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_GetString_Private_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x000600BC File Offset: 0x0005E2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657941, XrefRangeEnd = 657952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Log(LogType logType, Object message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x0006010C File Offset: 0x0005E30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657952, XrefRangeEnd = 657963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Log(LogType logType, Object message, Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x00060170 File Offset: 0x0005E370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657963, XrefRangeEnd = 657976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LogError(string tag, Object message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_LogError_Public_Virtual_Final_New_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x000601C4 File Offset: 0x0005E3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657976, XrefRangeEnd = 657979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LogException(Exception exception, Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00060218 File Offset: 0x0005E418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657979, XrefRangeEnd = 657982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LogFormat(LogType logType, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x00060288 File Offset: 0x0005E488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657982, XrefRangeEnd = 657985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LogFormat(LogType logType, Object context, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00007F22 File Offset: 0x00006122
		public virtual void LogFormat(LogType logType, string format, params Object[] args)
		{
			this.LogFormat(logType, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x00007F32 File Offset: 0x00006132
		public virtual void LogFormat(LogType logType, Object context, string format, params Object[] args)
		{
			this.LogFormat(logType, context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00007F44 File Offset: 0x00006144
		public Logger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x0006030C File Offset: 0x0005E50C
		// (set) Token: 0x0600132D RID: 4909 RVA: 0x00007F4D File Offset: 0x0000614D
		public unsafe ILogHandler _logHandler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__logHandler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__logHandler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x0006033C File Offset: 0x0005E53C
		// (set) Token: 0x0600132F RID: 4911 RVA: 0x00007F6C File Offset: 0x0000616C
		public unsafe bool _logEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__logEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__logEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x00060364 File Offset: 0x0005E564
		// (set) Token: 0x06001331 RID: 4913 RVA: 0x00007F87 File Offset: 0x00006187
		public unsafe LogType _filterLogType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__filterLogType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__filterLogType_k__BackingField)) = value;
			}
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x00007FA2 File Offset: 0x000061A2
		public void Log(LogType logType, string tag, Object message)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x00007FAF File Offset: 0x000061AF
		public void Log(LogType logType, string tag, Object message, Object context)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00007FBC File Offset: 0x000061BC
		public void Log(Object message)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00007FC9 File Offset: 0x000061C9
		public void Log(string tag, Object message)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00007FD6 File Offset: 0x000061D6
		public void Log(string tag, Object message, Object context)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x00007FE3 File Offset: 0x000061E3
		public void LogWarning(string tag, Object message)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00007FF0 File Offset: 0x000061F0
		public void LogWarning(string tag, Object message, Object context)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00007FFD File Offset: 0x000061FD
		public void LogError(string tag, Object message, Object context)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x0006038C File Offset: 0x0005E58C
		public void LogException(Exception exception)
		{
			bool logEnabled = this.logEnabled;
			if (logEnabled)
			{
				this.logHandler.LogException(exception, null);
			}
		}

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeFieldInfoPtr__logHandler_k__BackingField;

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeFieldInfoPtr__logEnabled_k__BackingField;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeFieldInfoPtr__filterLogType_k__BackingField;

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ILogHandler_0;

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeMethodInfoPtr_get_logHandler_Public_Virtual_Final_New_get_ILogHandler_0;

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeMethodInfoPtr_set_logHandler_Public_Virtual_Final_New_set_Void_ILogHandler_0;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeMethodInfoPtr_get_logEnabled_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeMethodInfoPtr_set_logEnabled_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeMethodInfoPtr_get_filterLogType_Public_Virtual_Final_New_get_LogType_0;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeMethodInfoPtr_set_filterLogType_Public_Virtual_Final_New_set_Void_LogType_0;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeMethodInfoPtr_IsLogTypeAllowed_Public_Virtual_Final_New_Boolean_LogType_0;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Private_Static_String_Object_0;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_Object_0;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_Object_Object_0;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Virtual_Final_New_Void_String_Object_0;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_Object_0;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001244 RID: 4676
		public const string kNoTagFormat = "{0}";

		// Token: 0x04001245 RID: 4677
		public const string kTagFormat = "{0}: {1}";
	}
}
