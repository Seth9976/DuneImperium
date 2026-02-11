using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001D7 RID: 471
	public class SietchReverendMother : WormArchetype
	{
		// Token: 0x0600148A RID: 5258 RVA: 0x000A706C File Offset: 0x000A526C
		// Note: this type is marked as 'beforefieldinit'.
		static SietchReverendMother()
		{
			Il2CppClassPointerStore<SietchReverendMother>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "SietchReverendMother");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SietchReverendMother>.NativeClassPtr);
			SietchReverendMother.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SietchReverendMother>.NativeClassPtr, "archID");
			SietchReverendMother.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SietchReverendMother>.NativeClassPtr, 100666574);
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x000A70C4 File Offset: 0x000A52C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114717, XrefRangeEnd = 114928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SietchReverendMother()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SietchReverendMother>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SietchReverendMother.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00009E33 File Offset: 0x00008033
		public SietchReverendMother(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x000A7100 File Offset: 0x000A5300
		// (set) Token: 0x0600148E RID: 5262 RVA: 0x00009E3C File Offset: 0x0000803C
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SietchReverendMother.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SietchReverendMother.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
