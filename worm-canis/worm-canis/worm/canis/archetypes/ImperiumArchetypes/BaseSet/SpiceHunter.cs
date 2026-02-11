using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001DB RID: 475
	public class SpiceHunter : WormArchetype
	{
		// Token: 0x0600149E RID: 5278 RVA: 0x000A735C File Offset: 0x000A555C
		// Note: this type is marked as 'beforefieldinit'.
		static SpiceHunter()
		{
			Il2CppClassPointerStore<SpiceHunter>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "SpiceHunter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpiceHunter>.NativeClassPtr);
			SpiceHunter.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceHunter>.NativeClassPtr, "archID");
			SpiceHunter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceHunter>.NativeClassPtr, 100666582);
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x000A73B4 File Offset: 0x000A55B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115485, XrefRangeEnd = 115694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpiceHunter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpiceHunter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceHunter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00009E9F File Offset: 0x0000809F
		public SpiceHunter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x000A73F0 File Offset: 0x000A55F0
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x00009EA8 File Offset: 0x000080A8
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpiceHunter.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpiceHunter.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
