using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.BaseSet
{
	// Token: 0x020001F5 RID: 501
	public class HagalHeighliner : WormArchetype
	{
		// Token: 0x06001520 RID: 5408 RVA: 0x000A8674 File Offset: 0x000A6874
		// Note: this type is marked as 'beforefieldinit'.
		static HagalHeighliner()
		{
			Il2CppClassPointerStore<HagalHeighliner>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.BaseSet", "HagalHeighliner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalHeighliner>.NativeClassPtr);
			HagalHeighliner.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHeighliner>.NativeClassPtr, "archID");
			HagalHeighliner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHeighliner>.NativeClassPtr, 100666634);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x000A86CC File Offset: 0x000A68CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119136, XrefRangeEnd = 119269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalHeighliner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalHeighliner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalHeighliner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x0000A15D File Offset: 0x0000835D
		public HagalHeighliner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x000A8708 File Offset: 0x000A6908
		// (set) Token: 0x06001524 RID: 5412 RVA: 0x0000A166 File Offset: 0x00008366
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalHeighliner.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalHeighliner.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
