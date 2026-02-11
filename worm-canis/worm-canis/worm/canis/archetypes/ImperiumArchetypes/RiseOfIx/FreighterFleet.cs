using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x0200017E RID: 382
	public class FreighterFleet : WormArchetype
	{
		// Token: 0x060012CD RID: 4813 RVA: 0x000A2F10 File Offset: 0x000A1110
		// Note: this type is marked as 'beforefieldinit'.
		static FreighterFleet()
		{
			Il2CppClassPointerStore<FreighterFleet>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "FreighterFleet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreighterFleet>.NativeClassPtr);
			FreighterFleet.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleet>.NativeClassPtr, "archID");
			FreighterFleet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleet>.NativeClassPtr, 100666396);
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x000A2F68 File Offset: 0x000A1168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97408, XrefRangeEnd = 97620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FreighterFleet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreighterFleet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x000094D0 File Offset: 0x000076D0
		public FreighterFleet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060012D0 RID: 4816 RVA: 0x000A2FA4 File Offset: 0x000A11A4
		// (set) Token: 0x060012D1 RID: 4817 RVA: 0x000094D9 File Offset: 0x000076D9
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FreighterFleet.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FreighterFleet.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
