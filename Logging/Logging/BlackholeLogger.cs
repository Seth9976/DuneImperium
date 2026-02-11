using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Extensions.Logging;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Logging
{
	// Token: 0x02000008 RID: 8
	public class BlackholeLogger : Object
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002C68 File Offset: 0x00000E68
		// Note: this type is marked as 'beforefieldinit'.
		static BlackholeLogger()
		{
			Il2CppClassPointerStore<BlackholeLogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Logging.dll", "Logging", "BlackholeLogger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackholeLogger>.NativeClassPtr);
			BlackholeLogger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackholeLogger>.NativeClassPtr, 100663319);
			BlackholeLogger.NativeMethodInfoPtr_IsEnabled_Public_Virtual_Final_New_Boolean_LogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackholeLogger>.NativeClassPtr, 100663320);
			BlackholeLogger.NativeMethodInfoPtr_BeginScope_Public_Virtual_Final_New_IDisposable_TState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackholeLogger>.NativeClassPtr, 100663321);
			BlackholeLogger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackholeLogger>.NativeClassPtr, 100663322);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BlackholeLogger.MethodInfoStoreGeneric_Log_Public_Virtual_Final_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0<TState>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002DAC File Offset: 0x00000FAC
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsEnabled(LogLevel logLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logLevel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackholeLogger.NativeMethodInfoPtr_IsEnabled_Public_Virtual_Final_New_Boolean_LogLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002DF8 File Offset: 0x00000FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271029, XrefRangeEnd = 1271038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDisposable BeginScope<TState>(TState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
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
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BlackholeLogger.MethodInfoStoreGeneric_BeginScope_Public_Virtual_Final_New_IDisposable_TState_0<TState>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr4) : null;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002E80 File Offset: 0x00001080
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlackholeLogger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackholeLogger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackholeLogger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000020F9 File Offset: 0x000002F9
		public BlackholeLogger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabled_Public_Virtual_Final_New_Boolean_LogLevel_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_BeginScope_Public_Virtual_Final_New_IDisposable_TState_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200000E RID: 14
		private sealed class MethodInfoStoreGeneric_Log_Public_Virtual_Final_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0<TState>
		{
			// Token: 0x04000075 RID: 117
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BlackholeLogger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0, Il2CppClassPointerStore<BlackholeLogger>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) }))));
		}

		// Token: 0x0200000F RID: 15
		private sealed class MethodInfoStoreGeneric_BeginScope_Public_Virtual_Final_New_IDisposable_TState_0<TState>
		{
			// Token: 0x04000076 RID: 118
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BlackholeLogger.NativeMethodInfoPtr_BeginScope_Public_Virtual_Final_New_IDisposable_TState_0, Il2CppClassPointerStore<BlackholeLogger>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) }))));
		}
	}
}
