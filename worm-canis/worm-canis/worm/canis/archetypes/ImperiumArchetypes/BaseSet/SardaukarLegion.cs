using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001D3 RID: 467
	public class SardaukarLegion : WormArchetype
	{
		// Token: 0x06001476 RID: 5238 RVA: 0x000A6D7C File Offset: 0x000A4F7C
		// Note: this type is marked as 'beforefieldinit'.
		static SardaukarLegion()
		{
			Il2CppClassPointerStore<SardaukarLegion>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "SardaukarLegion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SardaukarLegion>.NativeClassPtr);
			SardaukarLegion.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SardaukarLegion>.NativeClassPtr, "archID");
			SardaukarLegion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SardaukarLegion>.NativeClassPtr, 100666566);
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x000A6DD4 File Offset: 0x000A4FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114009, XrefRangeEnd = 114204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SardaukarLegion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SardaukarLegion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SardaukarLegion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00009DC7 File Offset: 0x00007FC7
		public SardaukarLegion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x000A6E10 File Offset: 0x000A5010
		// (set) Token: 0x0600147A RID: 5242 RVA: 0x00009DD0 File Offset: 0x00007FD0
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SardaukarLegion.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SardaukarLegion.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
