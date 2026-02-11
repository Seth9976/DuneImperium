using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x0200015E RID: 350
	public class DemandRespect : WormArchetype
	{
		// Token: 0x0600122D RID: 4653 RVA: 0x000A1790 File Offset: 0x0009F990
		// Note: this type is marked as 'beforefieldinit'.
		static DemandRespect()
		{
			Il2CppClassPointerStore<DemandRespect>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "DemandRespect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DemandRespect>.NativeClassPtr);
			DemandRespect.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemandRespect>.NativeClassPtr, "archID");
			DemandRespect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemandRespect>.NativeClassPtr, 100666332);
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x000A17E8 File Offset: 0x0009F9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93218, XrefRangeEnd = 93333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DemandRespect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DemandRespect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemandRespect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x00009170 File Offset: 0x00007370
		public DemandRespect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x000A1824 File Offset: 0x0009FA24
		// (set) Token: 0x06001231 RID: 4657 RVA: 0x00009179 File Offset: 0x00007379
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DemandRespect.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DemandRespect.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
