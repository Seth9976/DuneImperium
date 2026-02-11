using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.logging
{
	// Token: 0x02000175 RID: 373
	public class ILogger : Il2CppObjectBase
	{
		// Token: 0x06001574 RID: 5492 RVA: 0x00069BF4 File Offset: 0x00067DF4
		// Note: this type is marked as 'beforefieldinit'.
		static ILogger()
		{
			Il2CppClassPointerStore<ILogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.logging", "ILogger");
			ILogger.NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100666532);
			ILogger.NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100666533);
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00069C44 File Offset: 0x00067E44
		[CallerCount(0)]
		public unsafe virtual void Log(LogType level, string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogType_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00069CA0 File Offset: 0x00067EA0
		[CallerCount(0)]
		public unsafe virtual void Log(LogType level, string s, [Optional] Il2CppReferenceArray<global::Il2CppSystem.Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<global::Il2CppSystem.Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x0000978D File Offset: 0x0000798D
		public virtual void Log(LogType level, string s, params global::Il2CppSystem.Object[] args)
		{
			this.Log(level, s, new Il2CppReferenceArray<global::Il2CppSystem.Object>(args));
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x0000979D File Offset: 0x0000799D
		public ILogger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F42 RID: 3906
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogType_String_0;

		// Token: 0x04000F43 RID: 3907
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0;
	}
}
