using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001BC RID: 444
	public class DunetheDesertPlanet : WormArchetype
	{
		// Token: 0x06001403 RID: 5123 RVA: 0x000A5C98 File Offset: 0x000A3E98
		// Note: this type is marked as 'beforefieldinit'.
		static DunetheDesertPlanet()
		{
			Il2CppClassPointerStore<DunetheDesertPlanet>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "DunetheDesertPlanet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DunetheDesertPlanet>.NativeClassPtr);
			DunetheDesertPlanet.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DunetheDesertPlanet>.NativeClassPtr, "archID");
			DunetheDesertPlanet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DunetheDesertPlanet>.NativeClassPtr, 100666520);
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x000A5CF0 File Offset: 0x000A3EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109632, XrefRangeEnd = 109772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DunetheDesertPlanet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DunetheDesertPlanet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DunetheDesertPlanet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x00009B5A File Offset: 0x00007D5A
		public DunetheDesertPlanet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x000A5D2C File Offset: 0x000A3F2C
		// (set) Token: 0x06001407 RID: 5127 RVA: 0x00009B63 File Offset: 0x00007D63
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DunetheDesertPlanet.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DunetheDesertPlanet.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
