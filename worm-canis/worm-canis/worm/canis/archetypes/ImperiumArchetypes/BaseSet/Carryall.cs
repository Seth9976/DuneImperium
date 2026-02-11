using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001B3 RID: 435
	public class Carryall : WormArchetype
	{
		// Token: 0x060013D6 RID: 5078 RVA: 0x000A55FC File Offset: 0x000A37FC
		// Note: this type is marked as 'beforefieldinit'.
		static Carryall()
		{
			Il2CppClassPointerStore<Carryall>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "Carryall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Carryall>.NativeClassPtr);
			Carryall.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Carryall>.NativeClassPtr, "archID");
			Carryall.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Carryall>.NativeClassPtr, 100666502);
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x000A5654 File Offset: 0x000A3854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108061, XrefRangeEnd = 108235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Carryall()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Carryall>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Carryall.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00009A67 File Offset: 0x00007C67
		public Carryall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x000A5690 File Offset: 0x000A3890
		// (set) Token: 0x060013DA RID: 5082 RVA: 0x00009A70 File Offset: 0x00007C70
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Carryall.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Carryall.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
