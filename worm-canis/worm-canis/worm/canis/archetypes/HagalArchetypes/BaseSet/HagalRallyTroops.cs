using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.BaseSet
{
	// Token: 0x020001F6 RID: 502
	public class HagalRallyTroops : WormArchetype
	{
		// Token: 0x06001525 RID: 5413 RVA: 0x000A8730 File Offset: 0x000A6930
		// Note: this type is marked as 'beforefieldinit'.
		static HagalRallyTroops()
		{
			Il2CppClassPointerStore<HagalRallyTroops>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.BaseSet", "HagalRallyTroops");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalRallyTroops>.NativeClassPtr);
			HagalRallyTroops.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalRallyTroops>.NativeClassPtr, "archID");
			HagalRallyTroops.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalRallyTroops>.NativeClassPtr, 100666636);
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x000A8788 File Offset: 0x000A6988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119269, XrefRangeEnd = 119382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalRallyTroops()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalRallyTroops>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalRallyTroops.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0000A178 File Offset: 0x00008378
		public HagalRallyTroops(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06001528 RID: 5416 RVA: 0x000A87C4 File Offset: 0x000A69C4
		// (set) Token: 0x06001529 RID: 5417 RVA: 0x0000A181 File Offset: 0x00008381
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalRallyTroops.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalRallyTroops.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
