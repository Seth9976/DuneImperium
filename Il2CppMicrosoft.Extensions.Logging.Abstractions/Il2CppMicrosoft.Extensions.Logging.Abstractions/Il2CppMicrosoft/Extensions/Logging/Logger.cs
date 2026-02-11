using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x02000018 RID: 24
	public class Logger<T> : Object
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00004158 File Offset: 0x00002358
		// Note: this type is marked as 'beforefieldinit'.
		static Logger()
		{
			Il2CppClassPointerStore<Logger<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.Abstractions.dll", "Microsoft.Extensions.Logging", "Logger`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Logger<T>>.NativeClassPtr);
			Logger<T>.NativeFieldInfoPtr__logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Logger<T>>.NativeClassPtr, "_logger");
			Logger<T>.NativeMethodInfoPtr__ctor_Public_Void_ILoggerFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger<T>>.NativeClassPtr, 100663363);
			Logger<T>.NativeMethodInfoPtr_Microsoft_Extensions_Logging_ILogger_Log_Private_Virtual_Final_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger<T>>.NativeClassPtr, 100663364);
			Logger<T>.NativeMethodInfoPtr_GetCategoryName_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger<T>>.NativeClassPtr, 100663365);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004214 File Offset: 0x00002414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264751, XrefRangeEnd = 1264761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Logger(ILoggerFactory factory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Logger<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger<T>.NativeMethodInfoPtr__ctor_Public_Void_ILoggerFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00004260 File Offset: 0x00002460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264761, XrefRangeEnd = 1264766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Microsoft_Extensions_Logging_ILogger_Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Logger<TState>.MethodInfoStoreGeneric_Microsoft_Extensions_Logging_ILogger_Log_Private_Virtual_Final_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004324 File Offset: 0x00002524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264766, XrefRangeEnd = 1264775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCategoryName()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger<T>.NativeMethodInfoPtr_GetCategoryName_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002595 File Offset: 0x00000795
		public Logger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00004350 File Offset: 0x00002550
		// (set) Token: 0x06000092 RID: 146 RVA: 0x0000259E File Offset: 0x0000079E
		public unsafe ILogger _logger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger<T>.NativeFieldInfoPtr__logger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger<T>.NativeFieldInfoPtr__logger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr__logger;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ILoggerFactory_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_Microsoft_Extensions_Logging_ILogger_Log_Private_Virtual_Final_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_GetCategoryName_Private_Static_String_0;

		// Token: 0x0200001F RID: 31
		private sealed class MethodInfoStoreGeneric_Microsoft_Extensions_Logging_ILogger_Log_Private_Virtual_Final_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0
		{
			// Token: 0x0400007A RID: 122
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Logger<TState>.NativeMethodInfoPtr_Microsoft_Extensions_Logging_ILogger_Log_Private_Virtual_Final_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0, Il2CppClassPointerStore<Logger<TState>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) }))));
		}
	}
}
