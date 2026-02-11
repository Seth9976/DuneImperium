using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.LeaderArchetypes.RiseOfIx
{
	// Token: 0x0200012B RID: 299
	public class PrinceRhomburVernius : WormArchetype
	{
		// Token: 0x0600112E RID: 4398 RVA: 0x0009F21C File Offset: 0x0009D41C
		// Note: this type is marked as 'beforefieldinit'.
		static PrinceRhomburVernius()
		{
			Il2CppClassPointerStore<PrinceRhomburVernius>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.LeaderArchetypes.RiseOfIx", "PrinceRhomburVernius");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrinceRhomburVernius>.NativeClassPtr);
			PrinceRhomburVernius.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrinceRhomburVernius>.NativeClassPtr, "archID");
			PrinceRhomburVernius.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrinceRhomburVernius>.NativeClassPtr, 100666230);
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x0009F274 File Offset: 0x0009D474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87439, XrefRangeEnd = 87544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrinceRhomburVernius()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrinceRhomburVernius>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrinceRhomburVernius.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00008C0F File Offset: 0x00006E0F
		public PrinceRhomburVernius(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x0009F2B0 File Offset: 0x0009D4B0
		// (set) Token: 0x06001132 RID: 4402 RVA: 0x00008C18 File Offset: 0x00006E18
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PrinceRhomburVernius.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PrinceRhomburVernius.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
