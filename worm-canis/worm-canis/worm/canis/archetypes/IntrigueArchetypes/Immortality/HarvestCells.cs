using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.Immortality
{
	// Token: 0x0200014E RID: 334
	public class HarvestCells : WormArchetype
	{
		// Token: 0x060011DD RID: 4573 RVA: 0x000A0BD0 File Offset: 0x0009EDD0
		// Note: this type is marked as 'beforefieldinit'.
		static HarvestCells()
		{
			Il2CppClassPointerStore<HarvestCells>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.Immortality", "HarvestCells");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HarvestCells>.NativeClassPtr);
			HarvestCells.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestCells>.NativeClassPtr, "archID");
			HarvestCells.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestCells>.NativeClassPtr, 100666300);
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x000A0C28 File Offset: 0x0009EE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91408, XrefRangeEnd = 91509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HarvestCells()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HarvestCells>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestCells.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00008FC0 File Offset: 0x000071C0
		public HarvestCells(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x000A0C64 File Offset: 0x0009EE64
		// (set) Token: 0x060011E1 RID: 4577 RVA: 0x00008FC9 File Offset: 0x000071C9
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HarvestCells.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HarvestCells.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
