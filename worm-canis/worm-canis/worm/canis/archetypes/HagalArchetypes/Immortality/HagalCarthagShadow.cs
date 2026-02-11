using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.Immortality
{
	// Token: 0x020001E9 RID: 489
	public class HagalCarthagShadow : WormArchetype
	{
		// Token: 0x060014E4 RID: 5348 RVA: 0x000A7DA4 File Offset: 0x000A5FA4
		// Note: this type is marked as 'beforefieldinit'.
		static HagalCarthagShadow()
		{
			Il2CppClassPointerStore<HagalCarthagShadow>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.Immortality", "HagalCarthagShadow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalCarthagShadow>.NativeClassPtr);
			HagalCarthagShadow.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadow>.NativeClassPtr, "archID");
			HagalCarthagShadow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadow>.NativeClassPtr, 100666610);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x000A7DFC File Offset: 0x000A5FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117703, XrefRangeEnd = 117821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalCarthagShadow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalCarthagShadow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0000A019 File Offset: 0x00008219
		public HagalCarthagShadow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060014E7 RID: 5351 RVA: 0x000A7E38 File Offset: 0x000A6038
		// (set) Token: 0x060014E8 RID: 5352 RVA: 0x0000A022 File Offset: 0x00008222
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalCarthagShadow.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalCarthagShadow.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
