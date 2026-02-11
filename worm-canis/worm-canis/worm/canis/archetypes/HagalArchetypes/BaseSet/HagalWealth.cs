using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.BaseSet
{
	// Token: 0x020001FB RID: 507
	public class HagalWealth : WormArchetype
	{
		// Token: 0x0600153E RID: 5438 RVA: 0x000A8ADC File Offset: 0x000A6CDC
		// Note: this type is marked as 'beforefieldinit'.
		static HagalWealth()
		{
			Il2CppClassPointerStore<HagalWealth>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.BaseSet", "HagalWealth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalWealth>.NativeClassPtr);
			HagalWealth.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalWealth>.NativeClassPtr, "archID");
			HagalWealth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalWealth>.NativeClassPtr, 100666646);
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x000A8B34 File Offset: 0x000A6D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119848, XrefRangeEnd = 119969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalWealth()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalWealth>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalWealth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x0000A1FF File Offset: 0x000083FF
		public HagalWealth(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x000A8B70 File Offset: 0x000A6D70
		// (set) Token: 0x06001542 RID: 5442 RVA: 0x0000A208 File Offset: 0x00008408
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalWealth.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalWealth.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
