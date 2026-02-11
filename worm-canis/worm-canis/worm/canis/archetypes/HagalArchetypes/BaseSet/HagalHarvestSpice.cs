using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.BaseSet
{
	// Token: 0x020001F4 RID: 500
	public class HagalHarvestSpice : WormArchetype
	{
		// Token: 0x0600151B RID: 5403 RVA: 0x000A85B8 File Offset: 0x000A67B8
		// Note: this type is marked as 'beforefieldinit'.
		static HagalHarvestSpice()
		{
			Il2CppClassPointerStore<HagalHarvestSpice>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.BaseSet", "HagalHarvestSpice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalHarvestSpice>.NativeClassPtr);
			HagalHarvestSpice.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHarvestSpice>.NativeClassPtr, "archID");
			HagalHarvestSpice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHarvestSpice>.NativeClassPtr, 100666632);
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x000A8610 File Offset: 0x000A6810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119033, XrefRangeEnd = 119136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalHarvestSpice()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalHarvestSpice>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalHarvestSpice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x0000A142 File Offset: 0x00008342
		public HagalHarvestSpice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x000A864C File Offset: 0x000A684C
		// (set) Token: 0x0600151F RID: 5407 RVA: 0x0000A14B File Offset: 0x0000834B
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalHarvestSpice.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalHarvestSpice.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
