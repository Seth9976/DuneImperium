using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001CA RID: 458
	public class LietKynes : WormArchetype
	{
		// Token: 0x06001449 RID: 5193 RVA: 0x000A66E0 File Offset: 0x000A48E0
		// Note: this type is marked as 'beforefieldinit'.
		static LietKynes()
		{
			Il2CppClassPointerStore<LietKynes>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "LietKynes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LietKynes>.NativeClassPtr);
			LietKynes.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynes>.NativeClassPtr, "archID");
			LietKynes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynes>.NativeClassPtr, 100666548);
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x000A6738 File Offset: 0x000A4938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112321, XrefRangeEnd = 112532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LietKynes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LietKynes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LietKynes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00009CD4 File Offset: 0x00007ED4
		public LietKynes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x000A6774 File Offset: 0x000A4974
		// (set) Token: 0x0600144D RID: 5197 RVA: 0x00009CDD File Offset: 0x00007EDD
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LietKynes.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LietKynes.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
