using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x02000117 RID: 279
	public class HaggaBasin : WormArchetype
	{
		// Token: 0x060010CA RID: 4298 RVA: 0x0009E36C File Offset: 0x0009C56C
		// Note: this type is marked as 'beforefieldinit'.
		static HaggaBasin()
		{
			Il2CppClassPointerStore<HaggaBasin>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "HaggaBasin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HaggaBasin>.NativeClassPtr);
			HaggaBasin.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HaggaBasin>.NativeClassPtr, "archID");
			HaggaBasin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HaggaBasin>.NativeClassPtr, 100666190);
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x0009E3C4 File Offset: 0x0009C5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84843, XrefRangeEnd = 84978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HaggaBasin()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HaggaBasin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HaggaBasin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x000089F3 File Offset: 0x00006BF3
		public HaggaBasin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x0009E400 File Offset: 0x0009C600
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x000089FC File Offset: 0x00006BFC
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HaggaBasin.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HaggaBasin.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
