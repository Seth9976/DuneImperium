using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001D2 RID: 466
	public class SardaukarInfantry : WormArchetype
	{
		// Token: 0x06001471 RID: 5233 RVA: 0x000A6CC0 File Offset: 0x000A4EC0
		// Note: this type is marked as 'beforefieldinit'.
		static SardaukarInfantry()
		{
			Il2CppClassPointerStore<SardaukarInfantry>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "SardaukarInfantry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SardaukarInfantry>.NativeClassPtr);
			SardaukarInfantry.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SardaukarInfantry>.NativeClassPtr, "archID");
			SardaukarInfantry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SardaukarInfantry>.NativeClassPtr, 100666564);
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x000A6D18 File Offset: 0x000A4F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113840, XrefRangeEnd = 114009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SardaukarInfantry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SardaukarInfantry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SardaukarInfantry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x00009DAC File Offset: 0x00007FAC
		public SardaukarInfantry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x000A6D54 File Offset: 0x000A4F54
		// (set) Token: 0x06001475 RID: 5237 RVA: 0x00009DB5 File Offset: 0x00007FB5
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SardaukarInfantry.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SardaukarInfantry.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
