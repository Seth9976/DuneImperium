using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x0200011E RID: 286
	public class RallyTroops : WormArchetype
	{
		// Token: 0x060010ED RID: 4333 RVA: 0x0009E890 File Offset: 0x0009CA90
		// Note: this type is marked as 'beforefieldinit'.
		static RallyTroops()
		{
			Il2CppClassPointerStore<RallyTroops>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "RallyTroops");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RallyTroops>.NativeClassPtr);
			RallyTroops.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RallyTroops>.NativeClassPtr, "archID");
			RallyTroops.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RallyTroops>.NativeClassPtr, 100666204);
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0009E8E8 File Offset: 0x0009CAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85792, XrefRangeEnd = 85903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RallyTroops()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RallyTroops>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RallyTroops.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x00008AB0 File Offset: 0x00006CB0
		public RallyTroops(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x060010F0 RID: 4336 RVA: 0x0009E924 File Offset: 0x0009CB24
		// (set) Token: 0x060010F1 RID: 4337 RVA: 0x00008AB9 File Offset: 0x00006CB9
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RallyTroops.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RallyTroops.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
