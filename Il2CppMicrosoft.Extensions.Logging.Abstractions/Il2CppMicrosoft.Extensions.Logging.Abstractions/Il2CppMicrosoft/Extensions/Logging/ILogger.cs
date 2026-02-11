using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x02000011 RID: 17
	public class ILogger : Il2CppObjectBase
	{
		// Token: 0x0600006A RID: 106 RVA: 0x000023C7 File Offset: 0x000005C7
		// Note: this type is marked as 'beforefieldinit'.
		static ILogger()
		{
			Il2CppClassPointerStore<ILogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.Abstractions.dll", "Microsoft.Extensions.Logging", "ILogger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ILogger>.NativeClassPtr);
			ILogger.NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100663350);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003AC0 File Offset: 0x00001CC0
		[CallerCount(0)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.MethodInfoStoreGeneric_Log_Public_Abstract_Virtual_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0<TState>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002400 File Offset: 0x00000600
		public ILogger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0;

		// Token: 0x0200001E RID: 30
		private sealed class MethodInfoStoreGeneric_Log_Public_Abstract_Virtual_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0<TState>
		{
			// Token: 0x04000079 RID: 121
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ILogger.NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogLevel_EventId_TState_Exception_Func_3_TState_Exception_String_0, Il2CppClassPointerStore<ILogger>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) }))));
		}
	}
}
