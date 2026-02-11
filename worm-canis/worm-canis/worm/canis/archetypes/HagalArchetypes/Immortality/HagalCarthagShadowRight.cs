using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.Immortality
{
	// Token: 0x020001EB RID: 491
	public class HagalCarthagShadowRight : WormArchetype
	{
		// Token: 0x060014EE RID: 5358 RVA: 0x000A7F1C File Offset: 0x000A611C
		// Note: this type is marked as 'beforefieldinit'.
		static HagalCarthagShadowRight()
		{
			Il2CppClassPointerStore<HagalCarthagShadowRight>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.Immortality", "HagalCarthagShadowRight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalCarthagShadowRight>.NativeClassPtr);
			HagalCarthagShadowRight.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowRight>.NativeClassPtr, "archID");
			HagalCarthagShadowRight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowRight>.NativeClassPtr, 100666614);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x000A7F74 File Offset: 0x000A6174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117939, XrefRangeEnd = 118057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalCarthagShadowRight()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalCarthagShadowRight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowRight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0000A04F File Offset: 0x0000824F
		public HagalCarthagShadowRight(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x000A7FB0 File Offset: 0x000A61B0
		// (set) Token: 0x060014F2 RID: 5362 RVA: 0x0000A058 File Offset: 0x00008258
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalCarthagShadowRight.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalCarthagShadowRight.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
