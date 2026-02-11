using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.RiseOfIx
{
	// Token: 0x020001E6 RID: 486
	public class HagalInterstellarShipping : WormArchetype
	{
		// Token: 0x060014D5 RID: 5333 RVA: 0x000A7B70 File Offset: 0x000A5D70
		// Note: this type is marked as 'beforefieldinit'.
		static HagalInterstellarShipping()
		{
			Il2CppClassPointerStore<HagalInterstellarShipping>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.RiseOfIx", "HagalInterstellarShipping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalInterstellarShipping>.NativeClassPtr);
			HagalInterstellarShipping.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalInterstellarShipping>.NativeClassPtr, "archID");
			HagalInterstellarShipping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalInterstellarShipping>.NativeClassPtr, 100666604);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x000A7BC8 File Offset: 0x000A5DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117403, XrefRangeEnd = 117499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalInterstellarShipping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalInterstellarShipping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalInterstellarShipping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00009FC8 File Offset: 0x000081C8
		public HagalInterstellarShipping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x000A7C04 File Offset: 0x000A5E04
		// (set) Token: 0x060014D9 RID: 5337 RVA: 0x00009FD1 File Offset: 0x000081D1
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalInterstellarShipping.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalInterstellarShipping.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
