using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Events;
using worm.canis.data.enums;

namespace worm.menus.components
{
	// Token: 0x020000A5 RID: 165
	[Serializable]
	public class UnityEventForSet : UnityEvent<Set>
	{
		// Token: 0x06000671 RID: 1649 RVA: 0x00005384 File Offset: 0x00003584
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventForSet()
		{
			Il2CppClassPointerStore<UnityEventForSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.components", "UnityEventForSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventForSet>.NativeClassPtr);
			UnityEventForSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventForSet>.NativeClassPtr, 100664198);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0002C464 File Offset: 0x0002A664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696310, XrefRangeEnd = 696313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventForSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventForSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventForSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x000053BD File Offset: 0x000035BD
		public UnityEventForSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
