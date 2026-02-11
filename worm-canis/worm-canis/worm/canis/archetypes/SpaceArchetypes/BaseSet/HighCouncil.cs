using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x0200011B RID: 283
	public class HighCouncil : WormArchetype
	{
		// Token: 0x060010DE RID: 4318 RVA: 0x0009E65C File Offset: 0x0009C85C
		// Note: this type is marked as 'beforefieldinit'.
		static HighCouncil()
		{
			Il2CppClassPointerStore<HighCouncil>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "HighCouncil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HighCouncil>.NativeClassPtr);
			HighCouncil.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighCouncil>.NativeClassPtr, "archID");
			HighCouncil.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighCouncil>.NativeClassPtr, 100666198);
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0009E6B4 File Offset: 0x0009C8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85416, XrefRangeEnd = 85534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HighCouncil()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HighCouncil>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighCouncil.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00008A5F File Offset: 0x00006C5F
		public HighCouncil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x0009E6F0 File Offset: 0x0009C8F0
		// (set) Token: 0x060010E2 RID: 4322 RVA: 0x00008A68 File Offset: 0x00006C68
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HighCouncil.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HighCouncil.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
