using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000022 RID: 34
	public static class NoReflectionHelper : Object
	{
		// Token: 0x0600022C RID: 556 RVA: 0x00002CD0 File Offset: 0x00000ED0
		// Note: this type is marked as 'beforefieldinit'.
		static NoReflectionHelper()
		{
			Il2CppClassPointerStore<NoReflectionHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "NoReflectionHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoReflectionHelper>.NativeClassPtr);
			NoReflectionHelper.NativeMethodInfoPtr_GetProvider_Internal_Static_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoReflectionHelper>.NativeClassPtr, 100663682);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00023664 File Offset: 0x00021864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429213, RefRangeEnd = 429214, XrefRangeStart = 429206, XrefRangeEnd = 429213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetProvider()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoReflectionHelper.NativeMethodInfoPtr_GetProvider_Internal_Static_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002D09 File Offset: 0x00000F09
		public NoReflectionHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_GetProvider_Internal_Static_Object_0;
	}
}
