using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200014B RID: 331
	public class ScriptingRuntime : Object
	{
		// Token: 0x0600191C RID: 6428 RVA: 0x00009C84 File Offset: 0x00007E84
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptingRuntime()
		{
			Il2CppClassPointerStore<ScriptingRuntime>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ScriptingRuntime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingRuntime>.NativeClassPtr);
			ScriptingRuntime.NativeMethodInfoPtr_GetAllUserAssemblies_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingRuntime>.NativeClassPtr, 100666757);
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x0007601C File Offset: 0x0007421C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 667132, RefRangeEnd = 667134, XrefRangeStart = 667130, XrefRangeEnd = 667132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetAllUserAssemblies()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingRuntime.NativeMethodInfoPtr_GetAllUserAssemblies_Public_Static_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x00009CBD File Offset: 0x00007EBD
		public ScriptingRuntime(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001666 RID: 5734
		private static readonly IntPtr NativeMethodInfoPtr_GetAllUserAssemblies_Public_Static_Il2CppStringArray_0;
	}
}
