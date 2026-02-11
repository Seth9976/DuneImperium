using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.RiseOfIx
{
	// Token: 0x020001E7 RID: 487
	public class HagalSmugglingInterstellarShipping : WormArchetype
	{
		// Token: 0x060014DA RID: 5338 RVA: 0x000A7C2C File Offset: 0x000A5E2C
		// Note: this type is marked as 'beforefieldinit'.
		static HagalSmugglingInterstellarShipping()
		{
			Il2CppClassPointerStore<HagalSmugglingInterstellarShipping>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.RiseOfIx", "HagalSmugglingInterstellarShipping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalSmugglingInterstellarShipping>.NativeClassPtr);
			HagalSmugglingInterstellarShipping.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSmugglingInterstellarShipping>.NativeClassPtr, "archID");
			HagalSmugglingInterstellarShipping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSmugglingInterstellarShipping>.NativeClassPtr, 100666606);
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x000A7C84 File Offset: 0x000A5E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117499, XrefRangeEnd = 117595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalSmugglingInterstellarShipping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalSmugglingInterstellarShipping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSmugglingInterstellarShipping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00009FE3 File Offset: 0x000081E3
		public HagalSmugglingInterstellarShipping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x000A7CC0 File Offset: 0x000A5EC0
		// (set) Token: 0x060014DE RID: 5342 RVA: 0x00009FEC File Offset: 0x000081EC
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalSmugglingInterstellarShipping.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalSmugglingInterstellarShipping.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
