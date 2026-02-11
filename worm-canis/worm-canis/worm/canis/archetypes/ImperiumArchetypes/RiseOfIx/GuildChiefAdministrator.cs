using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x02000181 RID: 385
	public class GuildChiefAdministrator : WormArchetype
	{
		// Token: 0x060012DC RID: 4828 RVA: 0x000A3144 File Offset: 0x000A1344
		// Note: this type is marked as 'beforefieldinit'.
		static GuildChiefAdministrator()
		{
			Il2CppClassPointerStore<GuildChiefAdministrator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "GuildChiefAdministrator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuildChiefAdministrator>.NativeClassPtr);
			GuildChiefAdministrator.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildChiefAdministrator>.NativeClassPtr, "archID");
			GuildChiefAdministrator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildChiefAdministrator>.NativeClassPtr, 100666402);
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x000A319C File Offset: 0x000A139C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98054, XrefRangeEnd = 98273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuildChiefAdministrator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuildChiefAdministrator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildChiefAdministrator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00009521 File Offset: 0x00007721
		public GuildChiefAdministrator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x000A31D8 File Offset: 0x000A13D8
		// (set) Token: 0x060012E0 RID: 4832 RVA: 0x0000952A File Offset: 0x0000772A
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GuildChiefAdministrator.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuildChiefAdministrator.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
