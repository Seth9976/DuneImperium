using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001B8 RID: 440
	public static class _ThreadPoolWaitCallback : Object
	{
		// Token: 0x06001C9C RID: 7324 RVA: 0x00009305 File Offset: 0x00007505
		// Note: this type is marked as 'beforefieldinit'.
		static _ThreadPoolWaitCallback()
		{
			Il2CppClassPointerStore<_ThreadPoolWaitCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "_ThreadPoolWaitCallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_ThreadPoolWaitCallback>.NativeClassPtr);
			_ThreadPoolWaitCallback.NativeMethodInfoPtr_PerformWaitCallback_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ThreadPoolWaitCallback>.NativeClassPtr, 100668225);
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x000A995C File Offset: 0x000A7B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356758, XrefRangeEnd = 1356762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PerformWaitCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_ThreadPoolWaitCallback.NativeMethodInfoPtr_PerformWaitCallback_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0000933E File Offset: 0x0000753E
		public _ThreadPoolWaitCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019F1 RID: 6641
		private static readonly IntPtr NativeMethodInfoPtr_PerformWaitCallback_Internal_Static_Boolean_0;
	}
}
