using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.util
{
	// Token: 0x02000091 RID: 145
	public class LogProcessor : MonoBehaviour
	{
		// Token: 0x06000A48 RID: 2632 RVA: 0x0003AB20 File Offset: 0x00038D20
		// Note: this type is marked as 'beforefieldinit'.
		static LogProcessor()
		{
			Il2CppClassPointerStore<LogProcessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.util", "LogProcessor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogProcessor>.NativeClassPtr);
			LogProcessor.NativeMethodInfoPtr_ProcessLog_Public_Abstract_Virtual_New_Void_String_String_byref_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogProcessor>.NativeClassPtr, 100664728);
			LogProcessor.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogProcessor>.NativeClassPtr, 100664729);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0003AB78 File Offset: 0x00038D78
		[CallerCount(0)]
		public unsafe virtual void ProcessLog(string logString, string stackTrace, ref LogType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LogProcessor.NativeMethodInfoPtr_ProcessLog_Public_Abstract_Virtual_New_Void_String_String_byref_LogType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0003ABE8 File Offset: 0x00038DE8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogProcessor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogProcessor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogProcessor.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00005A7A File Offset: 0x00003C7A
		public LogProcessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_ProcessLog_Public_Abstract_Virtual_New_Void_String_String_byref_LogType_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
