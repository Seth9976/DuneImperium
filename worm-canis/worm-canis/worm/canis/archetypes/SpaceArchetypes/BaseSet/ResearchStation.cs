using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x0200011F RID: 287
	public class ResearchStation : WormArchetype
	{
		// Token: 0x060010F2 RID: 4338 RVA: 0x0009E94C File Offset: 0x0009CB4C
		// Note: this type is marked as 'beforefieldinit'.
		static ResearchStation()
		{
			Il2CppClassPointerStore<ResearchStation>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "ResearchStation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchStation>.NativeClassPtr);
			ResearchStation.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchStation>.NativeClassPtr, "archID");
			ResearchStation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchStation>.NativeClassPtr, 100666206);
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x0009E9A4 File Offset: 0x0009CBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85903, XrefRangeEnd = 86055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResearchStation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchStation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchStation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x00008ACB File Offset: 0x00006CCB
		public ResearchStation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x0009E9E0 File Offset: 0x0009CBE0
		// (set) Token: 0x060010F6 RID: 4342 RVA: 0x00008AD4 File Offset: 0x00006CD4
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResearchStation.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResearchStation.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
