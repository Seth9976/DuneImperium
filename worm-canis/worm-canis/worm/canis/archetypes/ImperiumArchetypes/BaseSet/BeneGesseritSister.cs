using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001B2 RID: 434
	public class BeneGesseritSister : WormArchetype
	{
		// Token: 0x060013D1 RID: 5073 RVA: 0x000A5540 File Offset: 0x000A3740
		// Note: this type is marked as 'beforefieldinit'.
		static BeneGesseritSister()
		{
			Il2CppClassPointerStore<BeneGesseritSister>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "BeneGesseritSister");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeneGesseritSister>.NativeClassPtr);
			BeneGesseritSister.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneGesseritSister>.NativeClassPtr, "archID");
			BeneGesseritSister.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneGesseritSister>.NativeClassPtr, 100666500);
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x000A5598 File Offset: 0x000A3798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107867, XrefRangeEnd = 108061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BeneGesseritSister()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeneGesseritSister>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneGesseritSister.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x00009A4C File Offset: 0x00007C4C
		public BeneGesseritSister(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x000A55D4 File Offset: 0x000A37D4
		// (set) Token: 0x060013D5 RID: 5077 RVA: 0x00009A55 File Offset: 0x00007C55
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BeneGesseritSister.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BeneGesseritSister.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
