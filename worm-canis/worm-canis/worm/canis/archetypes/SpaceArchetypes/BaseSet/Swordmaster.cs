using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x02000126 RID: 294
	public class Swordmaster : WormArchetype
	{
		// Token: 0x06001115 RID: 4373 RVA: 0x0009EE70 File Offset: 0x0009D070
		// Note: this type is marked as 'beforefieldinit'.
		static Swordmaster()
		{
			Il2CppClassPointerStore<Swordmaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "Swordmaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Swordmaster>.NativeClassPtr);
			Swordmaster.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swordmaster>.NativeClassPtr, "archID");
			Swordmaster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Swordmaster>.NativeClassPtr, 100666220);
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x0009EEC8 File Offset: 0x0009D0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86843, XrefRangeEnd = 86952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Swordmaster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Swordmaster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Swordmaster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x00008B88 File Offset: 0x00006D88
		public Swordmaster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x0009EF04 File Offset: 0x0009D104
		// (set) Token: 0x06001119 RID: 4377 RVA: 0x00008B91 File Offset: 0x00006D91
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Swordmaster.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Swordmaster.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
