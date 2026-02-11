using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.LeaderArchetypes.RiseOfIx
{
	// Token: 0x02000129 RID: 297
	public class ArchdukeArmandEcaz : WormArchetype
	{
		// Token: 0x06001124 RID: 4388 RVA: 0x0009F0A4 File Offset: 0x0009D2A4
		// Note: this type is marked as 'beforefieldinit'.
		static ArchdukeArmandEcaz()
		{
			Il2CppClassPointerStore<ArchdukeArmandEcaz>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.LeaderArchetypes.RiseOfIx", "ArchdukeArmandEcaz");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchdukeArmandEcaz>.NativeClassPtr);
			ArchdukeArmandEcaz.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchdukeArmandEcaz>.NativeClassPtr, "archID");
			ArchdukeArmandEcaz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchdukeArmandEcaz>.NativeClassPtr, 100666226);
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x0009F0FC File Offset: 0x0009D2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87225, XrefRangeEnd = 87323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchdukeArmandEcaz()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchdukeArmandEcaz>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchdukeArmandEcaz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00008BD9 File Offset: 0x00006DD9
		public ArchdukeArmandEcaz(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x0009F138 File Offset: 0x0009D338
		// (set) Token: 0x06001128 RID: 4392 RVA: 0x00008BE2 File Offset: 0x00006DE2
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ArchdukeArmandEcaz.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArchdukeArmandEcaz.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
