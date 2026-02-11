using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.Immortality
{
	// Token: 0x020001EC RID: 492
	public class HagalResearchStation : WormArchetype
	{
		// Token: 0x060014F3 RID: 5363 RVA: 0x000A7FD8 File Offset: 0x000A61D8
		// Note: this type is marked as 'beforefieldinit'.
		static HagalResearchStation()
		{
			Il2CppClassPointerStore<HagalResearchStation>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.Immortality", "HagalResearchStation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalResearchStation>.NativeClassPtr);
			HagalResearchStation.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalResearchStation>.NativeClassPtr, "archID");
			HagalResearchStation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalResearchStation>.NativeClassPtr, 100666616);
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x000A8030 File Offset: 0x000A6230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118057, XrefRangeEnd = 118170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalResearchStation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalResearchStation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalResearchStation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0000A06A File Offset: 0x0000826A
		public HagalResearchStation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x000A806C File Offset: 0x000A626C
		// (set) Token: 0x060014F7 RID: 5367 RVA: 0x0000A073 File Offset: 0x00008273
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalResearchStation.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalResearchStation.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
