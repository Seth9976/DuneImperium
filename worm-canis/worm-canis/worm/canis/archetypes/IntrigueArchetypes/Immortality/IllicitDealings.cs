using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.Immortality
{
	// Token: 0x0200014F RID: 335
	public class IllicitDealings : WormArchetype
	{
		// Token: 0x060011E2 RID: 4578 RVA: 0x000A0C8C File Offset: 0x0009EE8C
		// Note: this type is marked as 'beforefieldinit'.
		static IllicitDealings()
		{
			Il2CppClassPointerStore<IllicitDealings>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.Immortality", "IllicitDealings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IllicitDealings>.NativeClassPtr);
			IllicitDealings.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IllicitDealings>.NativeClassPtr, "archID");
			IllicitDealings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllicitDealings>.NativeClassPtr, 100666302);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x000A0CE4 File Offset: 0x0009EEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91509, XrefRangeEnd = 91629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IllicitDealings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IllicitDealings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllicitDealings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00008FDB File Offset: 0x000071DB
		public IllicitDealings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x000A0D20 File Offset: 0x0009EF20
		// (set) Token: 0x060011E6 RID: 4582 RVA: 0x00008FE4 File Offset: 0x000071E4
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IllicitDealings.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IllicitDealings.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
