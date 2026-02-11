using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.BaseSet
{
	// Token: 0x02000208 RID: 520
	public class RaidStockpiles : WormArchetype
	{
		// Token: 0x0600157F RID: 5503 RVA: 0x000A9468 File Offset: 0x000A7668
		// Note: this type is marked as 'beforefieldinit'.
		static RaidStockpiles()
		{
			Il2CppClassPointerStore<RaidStockpiles>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.BaseSet", "RaidStockpiles");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaidStockpiles>.NativeClassPtr);
			RaidStockpiles.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaidStockpiles>.NativeClassPtr, "archID");
			RaidStockpiles.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaidStockpiles>.NativeClassPtr, 100666672);
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x000A94C0 File Offset: 0x000A76C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121338, XrefRangeEnd = 121438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RaidStockpiles()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RaidStockpiles>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaidStockpiles.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x0000A35E File Offset: 0x0000855E
		public RaidStockpiles(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x000A94FC File Offset: 0x000A76FC
		// (set) Token: 0x06001583 RID: 5507 RVA: 0x0000A367 File Offset: 0x00008567
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RaidStockpiles.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RaidStockpiles.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
