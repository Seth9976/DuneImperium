using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.BaseSet
{
	// Token: 0x02000200 RID: 512
	public class BattleforArrakeen : WormArchetype
	{
		// Token: 0x06001557 RID: 5463 RVA: 0x000A8E88 File Offset: 0x000A7088
		// Note: this type is marked as 'beforefieldinit'.
		static BattleforArrakeen()
		{
			Il2CppClassPointerStore<BattleforArrakeen>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.BaseSet", "BattleforArrakeen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleforArrakeen>.NativeClassPtr);
			BattleforArrakeen.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleforArrakeen>.NativeClassPtr, "archID");
			BattleforArrakeen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleforArrakeen>.NativeClassPtr, 100666656);
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x000A8EE0 File Offset: 0x000A70E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120434, XrefRangeEnd = 120567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BattleforArrakeen()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleforArrakeen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleforArrakeen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x0000A286 File Offset: 0x00008486
		public BattleforArrakeen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x000A8F1C File Offset: 0x000A711C
		// (set) Token: 0x0600155B RID: 5467 RVA: 0x0000A28F File Offset: 0x0000848F
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BattleforArrakeen.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BattleforArrakeen.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
