using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TechTileArchetypes.RiseOfIx
{
	// Token: 0x0200010D RID: 269
	public class Windtraps : WormArchetype
	{
		// Token: 0x06001098 RID: 4248 RVA: 0x0009DC14 File Offset: 0x0009BE14
		// Note: this type is marked as 'beforefieldinit'.
		static Windtraps()
		{
			Il2CppClassPointerStore<Windtraps>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TechTileArchetypes.RiseOfIx", "Windtraps");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Windtraps>.NativeClassPtr);
			Windtraps.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Windtraps>.NativeClassPtr, "archID");
			Windtraps.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Windtraps>.NativeClassPtr, 100666170);
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x0009DC6C File Offset: 0x0009BE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83480, XrefRangeEnd = 83607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Windtraps()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Windtraps>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Windtraps.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x000088E5 File Offset: 0x00006AE5
		public Windtraps(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x0009DCA8 File Offset: 0x0009BEA8
		// (set) Token: 0x0600109C RID: 4252 RVA: 0x000088EE File Offset: 0x00006AEE
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Windtraps.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Windtraps.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
