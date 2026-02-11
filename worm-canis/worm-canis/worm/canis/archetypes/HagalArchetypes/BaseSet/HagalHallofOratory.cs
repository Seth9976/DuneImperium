using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.BaseSet
{
	// Token: 0x020001F2 RID: 498
	public class HagalHallofOratory : WormArchetype
	{
		// Token: 0x06001511 RID: 5393 RVA: 0x000A8440 File Offset: 0x000A6640
		// Note: this type is marked as 'beforefieldinit'.
		static HagalHallofOratory()
		{
			Il2CppClassPointerStore<HagalHallofOratory>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.BaseSet", "HagalHallofOratory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalHallofOratory>.NativeClassPtr);
			HagalHallofOratory.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHallofOratory>.NativeClassPtr, "archID");
			HagalHallofOratory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHallofOratory>.NativeClassPtr, 100666628);
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x000A8498 File Offset: 0x000A6698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118787, XrefRangeEnd = 118900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalHallofOratory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalHallofOratory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalHallofOratory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x0000A10C File Offset: 0x0000830C
		public HagalHallofOratory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x000A84D4 File Offset: 0x000A66D4
		// (set) Token: 0x06001515 RID: 5397 RVA: 0x0000A115 File Offset: 0x00008315
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalHallofOratory.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalHallofOratory.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
