using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000F2 RID: 242
	public class ILogger : Il2CppObjectBase
	{
		// Token: 0x0600130A RID: 4874 RVA: 0x0005F850 File Offset: 0x0005DA50
		// Note: this type is marked as 'beforefieldinit'.
		static ILogger()
		{
			Il2CppClassPointerStore<ILogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ILogger");
			ILogger.NativeMethodInfoPtr_get_logHandler_Public_Abstract_Virtual_New_get_ILogHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100665978);
			ILogger.NativeMethodInfoPtr_get_logEnabled_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100665979);
			ILogger.NativeMethodInfoPtr_IsLogTypeAllowed_Public_Abstract_Virtual_New_Boolean_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100665980);
			ILogger.NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100665981);
			ILogger.NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogType_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100665982);
			ILogger.NativeMethodInfoPtr_LogError_Public_Abstract_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100665983);
			ILogger.NativeMethodInfoPtr_LogFormat_Public_Abstract_Virtual_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100665984);
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x0005F904 File Offset: 0x0005DB04
		public unsafe virtual ILogHandler logHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_get_logHandler_Public_Abstract_Virtual_New_get_ILogHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogHandler>(intPtr3) : null;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x0005F950 File Offset: 0x0005DB50
		public unsafe virtual bool logEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_get_logEnabled_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x0005F998 File Offset: 0x0005DB98
		[CallerCount(0)]
		public unsafe virtual bool IsLogTypeAllowed(LogType logType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_IsLogTypeAllowed_Public_Abstract_Virtual_New_Boolean_LogType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x0005F9EC File Offset: 0x0005DBEC
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogType_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x0005FA48 File Offset: 0x0005DC48
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogType_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x0005FAB8 File Offset: 0x0005DCB8
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_LogError_Public_Abstract_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x0005FB18 File Offset: 0x0005DD18
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_LogFormat_Public_Abstract_Virtual_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00007EEE File Offset: 0x000060EE
		public virtual void LogFormat(LogType logType, string format, params Object[] args)
		{
			this.LogFormat(logType, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00007EFE File Offset: 0x000060FE
		public ILogger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001229 RID: 4649
		private static readonly IntPtr NativeMethodInfoPtr_get_logHandler_Public_Abstract_Virtual_New_get_ILogHandler_0;

		// Token: 0x0400122A RID: 4650
		private static readonly IntPtr NativeMethodInfoPtr_get_logEnabled_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400122B RID: 4651
		private static readonly IntPtr NativeMethodInfoPtr_IsLogTypeAllowed_Public_Abstract_Virtual_New_Boolean_LogType_0;

		// Token: 0x0400122C RID: 4652
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogType_Object_0;

		// Token: 0x0400122D RID: 4653
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogType_Object_Object_0;

		// Token: 0x0400122E RID: 4654
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Abstract_Virtual_New_Void_String_Object_0;

		// Token: 0x0400122F RID: 4655
		private static readonly IntPtr NativeMethodInfoPtr_LogFormat_Public_Abstract_Virtual_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0;
	}
}
