using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.BaseSet
{
	// Token: 0x02000202 RID: 514
	public class BattleforImperialBasin : WormArchetype
	{
		// Token: 0x06001561 RID: 5473 RVA: 0x000A9000 File Offset: 0x000A7200
		// Note: this type is marked as 'beforefieldinit'.
		static BattleforImperialBasin()
		{
			Il2CppClassPointerStore<BattleforImperialBasin>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.BaseSet", "BattleforImperialBasin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleforImperialBasin>.NativeClassPtr);
			BattleforImperialBasin.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleforImperialBasin>.NativeClassPtr, "archID");
			BattleforImperialBasin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleforImperialBasin>.NativeClassPtr, 100666660);
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x000A9058 File Offset: 0x000A7258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120700, XrefRangeEnd = 120833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BattleforImperialBasin()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleforImperialBasin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleforImperialBasin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x0000A2BC File Offset: 0x000084BC
		public BattleforImperialBasin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x000A9094 File Offset: 0x000A7294
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x0000A2C5 File Offset: 0x000084C5
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BattleforImperialBasin.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BattleforImperialBasin.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
