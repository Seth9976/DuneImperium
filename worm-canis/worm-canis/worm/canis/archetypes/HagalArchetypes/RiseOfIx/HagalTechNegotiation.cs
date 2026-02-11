using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.RiseOfIx
{
	// Token: 0x020001E8 RID: 488
	public class HagalTechNegotiation : WormArchetype
	{
		// Token: 0x060014DF RID: 5343 RVA: 0x000A7CE8 File Offset: 0x000A5EE8
		// Note: this type is marked as 'beforefieldinit'.
		static HagalTechNegotiation()
		{
			Il2CppClassPointerStore<HagalTechNegotiation>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.RiseOfIx", "HagalTechNegotiation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalTechNegotiation>.NativeClassPtr);
			HagalTechNegotiation.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTechNegotiation>.NativeClassPtr, "archID");
			HagalTechNegotiation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTechNegotiation>.NativeClassPtr, 100666608);
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x000A7D40 File Offset: 0x000A5F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117595, XrefRangeEnd = 117703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalTechNegotiation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalTechNegotiation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTechNegotiation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00009FFE File Offset: 0x000081FE
		public HagalTechNegotiation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x000A7D7C File Offset: 0x000A5F7C
		// (set) Token: 0x060014E3 RID: 5347 RVA: 0x0000A007 File Offset: 0x00008207
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalTechNegotiation.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalTechNegotiation.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
