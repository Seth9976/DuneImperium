using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000172 RID: 370
	public class UrgentMission : WormArchetype
	{
		// Token: 0x06001291 RID: 4753 RVA: 0x000A2640 File Offset: 0x000A0840
		// Note: this type is marked as 'beforefieldinit'.
		static UrgentMission()
		{
			Il2CppClassPointerStore<UrgentMission>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "UrgentMission");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UrgentMission>.NativeClassPtr);
			UrgentMission.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UrgentMission>.NativeClassPtr, "archID");
			UrgentMission.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UrgentMission>.NativeClassPtr, 100666372);
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x000A2698 File Offset: 0x000A0898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95409, XrefRangeEnd = 95510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UrgentMission()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UrgentMission>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UrgentMission.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x0000938C File Offset: 0x0000758C
		public UrgentMission(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x000A26D4 File Offset: 0x000A08D4
		// (set) Token: 0x06001295 RID: 4757 RVA: 0x00009395 File Offset: 0x00007595
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UrgentMission.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UrgentMission.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
