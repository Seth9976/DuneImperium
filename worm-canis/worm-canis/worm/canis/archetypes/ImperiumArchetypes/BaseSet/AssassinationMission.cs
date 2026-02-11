using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001B0 RID: 432
	public class AssassinationMission : WormArchetype
	{
		// Token: 0x060013C7 RID: 5063 RVA: 0x000A53C8 File Offset: 0x000A35C8
		// Note: this type is marked as 'beforefieldinit'.
		static AssassinationMission()
		{
			Il2CppClassPointerStore<AssassinationMission>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "AssassinationMission");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssassinationMission>.NativeClassPtr);
			AssassinationMission.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssassinationMission>.NativeClassPtr, "archID");
			AssassinationMission.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssassinationMission>.NativeClassPtr, 100666496);
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x000A5420 File Offset: 0x000A3620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107505, XrefRangeEnd = 107674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssassinationMission()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssassinationMission>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssassinationMission.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x00009A16 File Offset: 0x00007C16
		public AssassinationMission(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x000A545C File Offset: 0x000A365C
		// (set) Token: 0x060013CB RID: 5067 RVA: 0x00009A1F File Offset: 0x00007C1F
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AssassinationMission.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssassinationMission.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
