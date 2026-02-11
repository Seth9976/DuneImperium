using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TechTileArchetypes.RiseOfIx
{
	// Token: 0x02000103 RID: 259
	public class InvasionShips : WormArchetype
	{
		// Token: 0x06001066 RID: 4198 RVA: 0x0009D4BC File Offset: 0x0009B6BC
		// Note: this type is marked as 'beforefieldinit'.
		static InvasionShips()
		{
			Il2CppClassPointerStore<InvasionShips>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TechTileArchetypes.RiseOfIx", "InvasionShips");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvasionShips>.NativeClassPtr);
			InvasionShips.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvasionShips>.NativeClassPtr, "archID");
			InvasionShips.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvasionShips>.NativeClassPtr, 100666150);
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0009D514 File Offset: 0x0009B714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82337, XrefRangeEnd = 82466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvasionShips()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvasionShips>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvasionShips.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x000087D7 File Offset: 0x000069D7
		public InvasionShips(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x0009D550 File Offset: 0x0009B750
		// (set) Token: 0x0600106A RID: 4202 RVA: 0x000087E0 File Offset: 0x000069E0
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InvasionShips.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InvasionShips.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
