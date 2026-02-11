using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.BaseSet
{
	// Token: 0x020001FA RID: 506
	public class HagalStillsuits : WormArchetype
	{
		// Token: 0x06001539 RID: 5433 RVA: 0x000A8A20 File Offset: 0x000A6C20
		// Note: this type is marked as 'beforefieldinit'.
		static HagalStillsuits()
		{
			Il2CppClassPointerStore<HagalStillsuits>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.BaseSet", "HagalStillsuits");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalStillsuits>.NativeClassPtr);
			HagalStillsuits.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalStillsuits>.NativeClassPtr, "archID");
			HagalStillsuits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalStillsuits>.NativeClassPtr, 100666644);
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x000A8A78 File Offset: 0x000A6C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119720, XrefRangeEnd = 119848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalStillsuits()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalStillsuits>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalStillsuits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0000A1E4 File Offset: 0x000083E4
		public HagalStillsuits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x000A8AB4 File Offset: 0x000A6CB4
		// (set) Token: 0x0600153D RID: 5437 RVA: 0x0000A1ED File Offset: 0x000083ED
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalStillsuits.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalStillsuits.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
