using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Events;

namespace dwd.core
{
	// Token: 0x0200002E RID: 46
	[Serializable]
	public class UnityEventForDataComp : UnityEvent<DataComposition>
	{
		// Token: 0x06000178 RID: 376 RVA: 0x00002D1C File Offset: 0x00000F1C
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventForDataComp()
		{
			Il2CppClassPointerStore<UnityEventForDataComp>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core", "UnityEventForDataComp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventForDataComp>.NativeClassPtr);
			UnityEventForDataComp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventForDataComp>.NativeClassPtr, 100663501);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000BB68 File Offset: 0x00009D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120124, XrefRangeEnd = 1120127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventForDataComp()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventForDataComp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventForDataComp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002D55 File Offset: 0x00000F55
		public UnityEventForDataComp(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
