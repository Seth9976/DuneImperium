using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x02000119 RID: 281
	public class HardyWarriors : WormArchetype
	{
		// Token: 0x060010D4 RID: 4308 RVA: 0x0009E4E4 File Offset: 0x0009C6E4
		// Note: this type is marked as 'beforefieldinit'.
		static HardyWarriors()
		{
			Il2CppClassPointerStore<HardyWarriors>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "HardyWarriors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardyWarriors>.NativeClassPtr);
			HardyWarriors.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardyWarriors>.NativeClassPtr, "archID");
			HardyWarriors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardyWarriors>.NativeClassPtr, 100666194);
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0009E53C File Offset: 0x0009C73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85093, XrefRangeEnd = 85252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardyWarriors()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardyWarriors>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardyWarriors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x00008A29 File Offset: 0x00006C29
		public HardyWarriors(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x0009E578 File Offset: 0x0009C778
		// (set) Token: 0x060010D8 RID: 4312 RVA: 0x00008A32 File Offset: 0x00006C32
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HardyWarriors.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HardyWarriors.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
