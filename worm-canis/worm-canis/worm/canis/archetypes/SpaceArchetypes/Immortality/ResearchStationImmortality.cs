using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.Immortality
{
	// Token: 0x02000112 RID: 274
	public class ResearchStationImmortality : WormArchetype
	{
		// Token: 0x060010B1 RID: 4273 RVA: 0x0009DFC0 File Offset: 0x0009C1C0
		// Note: this type is marked as 'beforefieldinit'.
		static ResearchStationImmortality()
		{
			Il2CppClassPointerStore<ResearchStationImmortality>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.Immortality", "ResearchStationImmortality");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchStationImmortality>.NativeClassPtr);
			ResearchStationImmortality.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchStationImmortality>.NativeClassPtr, "archID");
			ResearchStationImmortality.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchStationImmortality>.NativeClassPtr, 100666180);
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0009E018 File Offset: 0x0009C218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84082, XrefRangeEnd = 84232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResearchStationImmortality()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchStationImmortality>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchStationImmortality.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0000896C File Offset: 0x00006B6C
		public ResearchStationImmortality(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x0009E054 File Offset: 0x0009C254
		// (set) Token: 0x060010B5 RID: 4277 RVA: 0x00008975 File Offset: 0x00006B75
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResearchStationImmortality.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResearchStationImmortality.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
