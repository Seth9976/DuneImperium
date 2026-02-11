using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Events;

namespace dwd.core
{
	// Token: 0x0200002A RID: 42
	[Serializable]
	public class UnityEventBool : UnityEvent<bool>
	{
		// Token: 0x0600016C RID: 364 RVA: 0x00002C14 File Offset: 0x00000E14
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventBool()
		{
			Il2CppClassPointerStore<UnityEventBool>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core", "UnityEventBool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventBool>.NativeClassPtr);
			UnityEventBool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBool>.NativeClassPtr, 100663497);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000BA78 File Offset: 0x00009C78
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1120102, RefRangeEnd = 1120112, XrefRangeStart = 1120099, XrefRangeEnd = 1120102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventBool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventBool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002C4D File Offset: 0x00000E4D
		public UnityEventBool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
