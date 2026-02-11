using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.BaseSet
{
	// Token: 0x02000210 RID: 528
	public class SortThroughtheChaos : WormArchetype
	{
		// Token: 0x060015A7 RID: 5543 RVA: 0x000A9A48 File Offset: 0x000A7C48
		// Note: this type is marked as 'beforefieldinit'.
		static SortThroughtheChaos()
		{
			Il2CppClassPointerStore<SortThroughtheChaos>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.BaseSet", "SortThroughtheChaos");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortThroughtheChaos>.NativeClassPtr);
			SortThroughtheChaos.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortThroughtheChaos>.NativeClassPtr, "archID");
			SortThroughtheChaos.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortThroughtheChaos>.NativeClassPtr, 100666688);
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x000A9AA0 File Offset: 0x000A7CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122247, XrefRangeEnd = 122347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortThroughtheChaos()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortThroughtheChaos>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortThroughtheChaos.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x0000A436 File Offset: 0x00008636
		public SortThroughtheChaos(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x000A9ADC File Offset: 0x000A7CDC
		// (set) Token: 0x060015AB RID: 5547 RVA: 0x0000A43F File Offset: 0x0000863F
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortThroughtheChaos.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortThroughtheChaos.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
