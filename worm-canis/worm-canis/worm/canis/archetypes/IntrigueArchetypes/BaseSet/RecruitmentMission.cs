using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x0200016A RID: 362
	public class RecruitmentMission : WormArchetype
	{
		// Token: 0x06001269 RID: 4713 RVA: 0x000A2060 File Offset: 0x000A0260
		// Note: this type is marked as 'beforefieldinit'.
		static RecruitmentMission()
		{
			Il2CppClassPointerStore<RecruitmentMission>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "RecruitmentMission");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecruitmentMission>.NativeClassPtr);
			RecruitmentMission.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecruitmentMission>.NativeClassPtr, "archID");
			RecruitmentMission.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecruitmentMission>.NativeClassPtr, 100666356);
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x000A20B8 File Offset: 0x000A02B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94526, XrefRangeEnd = 94641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RecruitmentMission()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecruitmentMission>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecruitmentMission.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x000092B4 File Offset: 0x000074B4
		public RecruitmentMission(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x000A20F4 File Offset: 0x000A02F4
		// (set) Token: 0x0600126D RID: 4717 RVA: 0x000092BD File Offset: 0x000074BD
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RecruitmentMission.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RecruitmentMission.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
