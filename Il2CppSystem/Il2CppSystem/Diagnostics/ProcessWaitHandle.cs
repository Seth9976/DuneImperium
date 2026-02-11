using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020000A2 RID: 162
	public class ProcessWaitHandle : WaitHandle
	{
		// Token: 0x06000C25 RID: 3109 RVA: 0x0000680E File Offset: 0x00004A0E
		// Note: this type is marked as 'beforefieldinit'.
		static ProcessWaitHandle()
		{
			Il2CppClassPointerStore<ProcessWaitHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "ProcessWaitHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProcessWaitHandle>.NativeClassPtr);
			ProcessWaitHandle.NativeMethodInfoPtr__ctor_Internal_Void_SafeProcessHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessWaitHandle>.NativeClassPtr, 100665041);
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x000496E0 File Offset: 0x000478E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451750, XrefRangeEnd = 451758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProcessWaitHandle(SafeProcessHandle processHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProcessWaitHandle>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(processHandle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessWaitHandle.NativeMethodInfoPtr__ctor_Internal_Void_SafeProcessHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00006847 File Offset: 0x00004A47
		public ProcessWaitHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SafeProcessHandle_0;
	}
}
