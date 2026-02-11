using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Events;

namespace dwd.core
{
	// Token: 0x02000031 RID: 49
	[Serializable]
	public class UnityEventArchID : UnityEvent<ArchetypeID>
	{
		// Token: 0x06000181 RID: 385 RVA: 0x00002DE2 File Offset: 0x00000FE2
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventArchID()
		{
			Il2CppClassPointerStore<UnityEventArchID>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core", "UnityEventArchID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventArchID>.NativeClassPtr);
			UnityEventArchID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventArchID>.NativeClassPtr, 100663504);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000BC1C File Offset: 0x00009E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120134, XrefRangeEnd = 1120137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventArchID()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventArchID>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventArchID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002E1B File Offset: 0x0000101B
		public UnityEventArchID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
