using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000136 RID: 310
	public static class RuntimeEventDispatcher : Object
	{
		// Token: 0x0600174B RID: 5963 RVA: 0x0000ABFA File Offset: 0x00008DFA
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeEventDispatcher()
		{
			Il2CppClassPointerStore<RuntimeEventDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "RuntimeEventDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeEventDispatcher>.NativeClassPtr);
			RuntimeEventDispatcher.NativeMethodInfoPtr_Create_Public_Static_EventDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeEventDispatcher>.NativeClassPtr, 100666775);
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x0006F944 File Offset: 0x0006DB44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318519, RefRangeEnd = 318520, XrefRangeStart = 318450, XrefRangeEnd = 318519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventDispatcher Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeEventDispatcher.NativeMethodInfoPtr_Create_Public_Static_EventDispatcher_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr3) : null;
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x0000AC33 File Offset: 0x00008E33
		public RuntimeEventDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_EventDispatcher_0;
	}
}
