using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.BaseSet
{
	// Token: 0x02000201 RID: 513
	public class BattleforCarthag : WormArchetype
	{
		// Token: 0x0600155C RID: 5468 RVA: 0x000A8F44 File Offset: 0x000A7144
		// Note: this type is marked as 'beforefieldinit'.
		static BattleforCarthag()
		{
			Il2CppClassPointerStore<BattleforCarthag>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.BaseSet", "BattleforCarthag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleforCarthag>.NativeClassPtr);
			BattleforCarthag.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleforCarthag>.NativeClassPtr, "archID");
			BattleforCarthag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleforCarthag>.NativeClassPtr, 100666658);
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x000A8F9C File Offset: 0x000A719C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120567, XrefRangeEnd = 120700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BattleforCarthag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleforCarthag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleforCarthag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x0000A2A1 File Offset: 0x000084A1
		public BattleforCarthag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600155F RID: 5471 RVA: 0x000A8FD8 File Offset: 0x000A71D8
		// (set) Token: 0x06001560 RID: 5472 RVA: 0x0000A2AA File Offset: 0x000084AA
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BattleforCarthag.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BattleforCarthag.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
