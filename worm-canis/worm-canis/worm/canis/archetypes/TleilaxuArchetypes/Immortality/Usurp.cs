using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TleilaxuArchetypes.Immortality
{
	// Token: 0x020000FB RID: 251
	public class Usurp : WormArchetype
	{
		// Token: 0x0600103E RID: 4158 RVA: 0x0009CEDC File Offset: 0x0009B0DC
		// Note: this type is marked as 'beforefieldinit'.
		static Usurp()
		{
			Il2CppClassPointerStore<Usurp>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TleilaxuArchetypes.Immortality", "Usurp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Usurp>.NativeClassPtr);
			Usurp.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Usurp>.NativeClassPtr, "archID");
			Usurp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Usurp>.NativeClassPtr, 100666134);
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0009CF34 File Offset: 0x0009B134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81403, XrefRangeEnd = 81553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Usurp()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Usurp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Usurp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x000086FF File Offset: 0x000068FF
		public Usurp(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x0009CF70 File Offset: 0x0009B170
		// (set) Token: 0x06001042 RID: 4162 RVA: 0x00008708 File Offset: 0x00006908
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Usurp.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Usurp.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
