using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.matchThread
{
	// Token: 0x0200008D RID: 141
	public class ExecutionStackException : Exception
	{
		// Token: 0x06000773 RID: 1907 RVA: 0x00004D43 File Offset: 0x00002F43
		// Note: this type is marked as 'beforefieldinit'.
		static ExecutionStackException()
		{
			Il2CppClassPointerStore<ExecutionStackException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.matchThread", "ExecutionStackException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecutionStackException>.NativeClassPtr);
			ExecutionStackException.NativeMethodInfoPtr__ctor_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionStackException>.NativeClassPtr, 100664838);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00037BD4 File Offset: 0x00035DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557874, XrefRangeEnd = 557880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionStackException(Exception e)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionStackException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionStackException.NativeMethodInfoPtr__ctor_Public_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00004D7C File Offset: 0x00002F7C
		public ExecutionStackException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Exception_0;
	}
}
