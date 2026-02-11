using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Events;

namespace dwd.core
{
	// Token: 0x0200002C RID: 44
	[Serializable]
	public class UnityEventFloat : UnityEvent<float>
	{
		// Token: 0x06000172 RID: 370 RVA: 0x00002C98 File Offset: 0x00000E98
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventFloat()
		{
			Il2CppClassPointerStore<UnityEventFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core", "UnityEventFloat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventFloat>.NativeClassPtr);
			UnityEventFloat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventFloat>.NativeClassPtr, 100663499);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120115, XrefRangeEnd = 1120118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventFloat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventFloat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventFloat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002CD1 File Offset: 0x00000ED1
		public UnityEventFloat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
