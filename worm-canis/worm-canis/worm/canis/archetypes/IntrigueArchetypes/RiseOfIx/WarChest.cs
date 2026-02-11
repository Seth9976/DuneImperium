using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.RiseOfIx
{
	// Token: 0x02000148 RID: 328
	public class WarChest : WormArchetype
	{
		// Token: 0x060011BF RID: 4543 RVA: 0x000A0768 File Offset: 0x0009E968
		// Note: this type is marked as 'beforefieldinit'.
		static WarChest()
		{
			Il2CppClassPointerStore<WarChest>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.RiseOfIx", "WarChest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarChest>.NativeClassPtr);
			WarChest.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarChest>.NativeClassPtr, "archID");
			WarChest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarChest>.NativeClassPtr, 100666288);
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x000A07C0 File Offset: 0x0009E9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90666, XrefRangeEnd = 90805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WarChest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarChest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarChest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00008F1E File Offset: 0x0000711E
		public WarChest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x000A07FC File Offset: 0x0009E9FC
		// (set) Token: 0x060011C3 RID: 4547 RVA: 0x00008F27 File Offset: 0x00007127
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WarChest.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WarChest.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
