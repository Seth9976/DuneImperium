using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.BaseSet
{
	// Token: 0x020001F3 RID: 499
	public class HagalHardyWarriors : WormArchetype
	{
		// Token: 0x06001516 RID: 5398 RVA: 0x000A84FC File Offset: 0x000A66FC
		// Note: this type is marked as 'beforefieldinit'.
		static HagalHardyWarriors()
		{
			Il2CppClassPointerStore<HagalHardyWarriors>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.BaseSet", "HagalHardyWarriors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalHardyWarriors>.NativeClassPtr);
			HagalHardyWarriors.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHardyWarriors>.NativeClassPtr, "archID");
			HagalHardyWarriors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHardyWarriors>.NativeClassPtr, 100666630);
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x000A8554 File Offset: 0x000A6754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118900, XrefRangeEnd = 119033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalHardyWarriors()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalHardyWarriors>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalHardyWarriors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x0000A127 File Offset: 0x00008327
		public HagalHardyWarriors(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x000A8590 File Offset: 0x000A6790
		// (set) Token: 0x0600151A RID: 5402 RVA: 0x0000A130 File Offset: 0x00008330
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalHardyWarriors.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalHardyWarriors.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
