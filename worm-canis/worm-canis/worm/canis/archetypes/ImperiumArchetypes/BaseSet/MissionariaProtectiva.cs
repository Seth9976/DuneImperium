using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001CB RID: 459
	public class MissionariaProtectiva : WormArchetype
	{
		// Token: 0x0600144E RID: 5198 RVA: 0x000A679C File Offset: 0x000A499C
		// Note: this type is marked as 'beforefieldinit'.
		static MissionariaProtectiva()
		{
			Il2CppClassPointerStore<MissionariaProtectiva>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "MissionariaProtectiva");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionariaProtectiva>.NativeClassPtr);
			MissionariaProtectiva.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionariaProtectiva>.NativeClassPtr, "archID");
			MissionariaProtectiva.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionariaProtectiva>.NativeClassPtr, 100666550);
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x000A67F4 File Offset: 0x000A49F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112532, XrefRangeEnd = 112724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissionariaProtectiva()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionariaProtectiva>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionariaProtectiva.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00009CEF File Offset: 0x00007EEF
		public MissionariaProtectiva(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x000A6830 File Offset: 0x000A4A30
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x00009CF8 File Offset: 0x00007EF8
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MissionariaProtectiva.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MissionariaProtectiva.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
