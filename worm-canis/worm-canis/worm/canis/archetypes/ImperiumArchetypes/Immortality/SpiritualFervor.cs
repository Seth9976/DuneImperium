using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x020001A9 RID: 425
	public class SpiritualFervor : WormArchetype
	{
		// Token: 0x060013A4 RID: 5028 RVA: 0x000A4EA4 File Offset: 0x000A30A4
		// Note: this type is marked as 'beforefieldinit'.
		static SpiritualFervor()
		{
			Il2CppClassPointerStore<SpiritualFervor>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "SpiritualFervor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpiritualFervor>.NativeClassPtr);
			SpiritualFervor.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiritualFervor>.NativeClassPtr, "archID");
			SpiritualFervor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiritualFervor>.NativeClassPtr, 100666482);
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x000A4EFC File Offset: 0x000A30FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106168, XrefRangeEnd = 106341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpiritualFervor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpiritualFervor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiritualFervor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00009959 File Offset: 0x00007B59
		public SpiritualFervor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x060013A7 RID: 5031 RVA: 0x000A4F38 File Offset: 0x000A3138
		// (set) Token: 0x060013A8 RID: 5032 RVA: 0x00009962 File Offset: 0x00007B62
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpiritualFervor.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpiritualFervor.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
