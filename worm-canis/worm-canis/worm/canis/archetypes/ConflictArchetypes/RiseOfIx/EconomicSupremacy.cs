using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.RiseOfIx
{
	// Token: 0x020001FC RID: 508
	public class EconomicSupremacy : WormArchetype
	{
		// Token: 0x06001543 RID: 5443 RVA: 0x000A8B98 File Offset: 0x000A6D98
		// Note: this type is marked as 'beforefieldinit'.
		static EconomicSupremacy()
		{
			Il2CppClassPointerStore<EconomicSupremacy>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.RiseOfIx", "EconomicSupremacy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EconomicSupremacy>.NativeClassPtr);
			EconomicSupremacy.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EconomicSupremacy>.NativeClassPtr, "archID");
			EconomicSupremacy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EconomicSupremacy>.NativeClassPtr, 100666648);
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x000A8BF0 File Offset: 0x000A6DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119969, XrefRangeEnd = 120092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EconomicSupremacy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EconomicSupremacy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EconomicSupremacy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x0000A21A File Offset: 0x0000841A
		public EconomicSupremacy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x000A8C2C File Offset: 0x000A6E2C
		// (set) Token: 0x06001547 RID: 5447 RVA: 0x0000A223 File Offset: 0x00008423
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EconomicSupremacy.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EconomicSupremacy.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
