using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Events;

namespace dwd.core
{
	// Token: 0x0200002B RID: 43
	[Serializable]
	public class UnityEventInt : UnityEvent<int>
	{
		// Token: 0x0600016F RID: 367 RVA: 0x00002C56 File Offset: 0x00000E56
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventInt()
		{
			Il2CppClassPointerStore<UnityEventInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core", "UnityEventInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventInt>.NativeClassPtr);
			UnityEventInt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventInt>.NativeClassPtr, 100663498);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000BAB4 File Offset: 0x00009CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120112, XrefRangeEnd = 1120115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventInt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventInt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventInt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002C8F File Offset: 0x00000E8F
		public UnityEventInt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
