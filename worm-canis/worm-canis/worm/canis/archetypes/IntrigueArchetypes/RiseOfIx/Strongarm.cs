using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.RiseOfIx
{
	// Token: 0x02000147 RID: 327
	public class Strongarm : WormArchetype
	{
		// Token: 0x060011BA RID: 4538 RVA: 0x000A06AC File Offset: 0x0009E8AC
		// Note: this type is marked as 'beforefieldinit'.
		static Strongarm()
		{
			Il2CppClassPointerStore<Strongarm>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.RiseOfIx", "Strongarm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Strongarm>.NativeClassPtr);
			Strongarm.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Strongarm>.NativeClassPtr, "archID");
			Strongarm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Strongarm>.NativeClassPtr, 100666286);
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x000A0704 File Offset: 0x0009E904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90560, XrefRangeEnd = 90666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Strongarm()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Strongarm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Strongarm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00008F03 File Offset: 0x00007103
		public Strongarm(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x000A0740 File Offset: 0x0009E940
		// (set) Token: 0x060011BE RID: 4542 RVA: 0x00008F0C File Offset: 0x0000710C
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Strongarm.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Strongarm.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
