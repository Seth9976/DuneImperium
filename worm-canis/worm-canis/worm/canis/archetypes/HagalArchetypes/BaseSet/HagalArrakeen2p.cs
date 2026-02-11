using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.BaseSet
{
	// Token: 0x020001EE RID: 494
	public class HagalArrakeen2p : WormArchetype
	{
		// Token: 0x060014FD RID: 5373 RVA: 0x000A8150 File Offset: 0x000A6350
		// Note: this type is marked as 'beforefieldinit'.
		static HagalArrakeen2p()
		{
			Il2CppClassPointerStore<HagalArrakeen2p>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.BaseSet", "HagalArrakeen2p");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalArrakeen2p>.NativeClassPtr);
			HagalArrakeen2p.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalArrakeen2p>.NativeClassPtr, "archID");
			HagalArrakeen2p.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalArrakeen2p>.NativeClassPtr, 100666620);
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x000A81A8 File Offset: 0x000A63A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118295, XrefRangeEnd = 118420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalArrakeen2p()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalArrakeen2p>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalArrakeen2p.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x0000A0A0 File Offset: 0x000082A0
		public HagalArrakeen2p(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x000A81E4 File Offset: 0x000A63E4
		// (set) Token: 0x06001501 RID: 5377 RVA: 0x0000A0A9 File Offset: 0x000082A9
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalArrakeen2p.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalArrakeen2p.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
