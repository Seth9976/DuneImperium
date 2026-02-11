using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.Immortality
{
	// Token: 0x020001EA RID: 490
	public class HagalCarthagShadowLeft : WormArchetype
	{
		// Token: 0x060014E9 RID: 5353 RVA: 0x000A7E60 File Offset: 0x000A6060
		// Note: this type is marked as 'beforefieldinit'.
		static HagalCarthagShadowLeft()
		{
			Il2CppClassPointerStore<HagalCarthagShadowLeft>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.Immortality", "HagalCarthagShadowLeft");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalCarthagShadowLeft>.NativeClassPtr);
			HagalCarthagShadowLeft.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowLeft>.NativeClassPtr, "archID");
			HagalCarthagShadowLeft.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowLeft>.NativeClassPtr, 100666612);
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x000A7EB8 File Offset: 0x000A60B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117821, XrefRangeEnd = 117939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalCarthagShadowLeft()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalCarthagShadowLeft>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowLeft.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x0000A034 File Offset: 0x00008234
		public HagalCarthagShadowLeft(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x000A7EF4 File Offset: 0x000A60F4
		// (set) Token: 0x060014ED RID: 5357 RVA: 0x0000A03D File Offset: 0x0000823D
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalCarthagShadowLeft.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalCarthagShadowLeft.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
