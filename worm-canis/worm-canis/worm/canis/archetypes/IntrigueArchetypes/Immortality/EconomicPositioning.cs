using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.Immortality
{
	// Token: 0x0200014C RID: 332
	public class EconomicPositioning : WormArchetype
	{
		// Token: 0x060011D3 RID: 4563 RVA: 0x000A0A58 File Offset: 0x0009EC58
		// Note: this type is marked as 'beforefieldinit'.
		static EconomicPositioning()
		{
			Il2CppClassPointerStore<EconomicPositioning>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.Immortality", "EconomicPositioning");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EconomicPositioning>.NativeClassPtr);
			EconomicPositioning.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EconomicPositioning>.NativeClassPtr, "archID");
			EconomicPositioning.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EconomicPositioning>.NativeClassPtr, 100666296);
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x000A0AB0 File Offset: 0x0009ECB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91159, XrefRangeEnd = 91293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EconomicPositioning()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EconomicPositioning>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EconomicPositioning.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00008F8A File Offset: 0x0000718A
		public EconomicPositioning(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x000A0AEC File Offset: 0x0009ECEC
		// (set) Token: 0x060011D7 RID: 4567 RVA: 0x00008F93 File Offset: 0x00007193
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EconomicPositioning.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EconomicPositioning.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
