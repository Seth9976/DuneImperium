using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Events;

namespace dwd.core
{
	// Token: 0x0200002F RID: 47
	[Serializable]
	public class UnityToggleEventForDataComp : UnityEvent<DataComposition, bool>
	{
		// Token: 0x0600017B RID: 379 RVA: 0x00002D5E File Offset: 0x00000F5E
		// Note: this type is marked as 'beforefieldinit'.
		static UnityToggleEventForDataComp()
		{
			Il2CppClassPointerStore<UnityToggleEventForDataComp>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core", "UnityToggleEventForDataComp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityToggleEventForDataComp>.NativeClassPtr);
			UnityToggleEventForDataComp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityToggleEventForDataComp>.NativeClassPtr, 100663502);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000BBA4 File Offset: 0x00009DA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1120130, RefRangeEnd = 1120131, XrefRangeStart = 1120127, XrefRangeEnd = 1120130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityToggleEventForDataComp()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityToggleEventForDataComp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityToggleEventForDataComp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002D97 File Offset: 0x00000F97
		public UnityToggleEventForDataComp(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
