using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.BaseSet
{
	// Token: 0x020001ED RID: 493
	public class HagalArrakeen : WormArchetype
	{
		// Token: 0x060014F8 RID: 5368 RVA: 0x000A8094 File Offset: 0x000A6294
		// Note: this type is marked as 'beforefieldinit'.
		static HagalArrakeen()
		{
			Il2CppClassPointerStore<HagalArrakeen>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.BaseSet", "HagalArrakeen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalArrakeen>.NativeClassPtr);
			HagalArrakeen.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalArrakeen>.NativeClassPtr, "archID");
			HagalArrakeen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalArrakeen>.NativeClassPtr, 100666618);
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x000A80EC File Offset: 0x000A62EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118170, XrefRangeEnd = 118295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalArrakeen()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalArrakeen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalArrakeen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x0000A085 File Offset: 0x00008285
		public HagalArrakeen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x000A8128 File Offset: 0x000A6328
		// (set) Token: 0x060014FC RID: 5372 RVA: 0x0000A08E File Offset: 0x0000828E
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalArrakeen.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalArrakeen.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
