using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001B9 RID: 441
	public class Diplomacy : WormArchetype
	{
		// Token: 0x060013F4 RID: 5108 RVA: 0x000A5A64 File Offset: 0x000A3C64
		// Note: this type is marked as 'beforefieldinit'.
		static Diplomacy()
		{
			Il2CppClassPointerStore<Diplomacy>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "Diplomacy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Diplomacy>.NativeClassPtr);
			Diplomacy.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Diplomacy>.NativeClassPtr, "archID");
			Diplomacy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Diplomacy>.NativeClassPtr, 100666514);
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x000A5ABC File Offset: 0x000A3CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109099, XrefRangeEnd = 109248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Diplomacy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Diplomacy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Diplomacy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x00009B09 File Offset: 0x00007D09
		public Diplomacy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x000A5AF8 File Offset: 0x000A3CF8
		// (set) Token: 0x060013F8 RID: 5112 RVA: 0x00009B12 File Offset: 0x00007D12
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Diplomacy.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Diplomacy.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
