using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TleilaxuArchetypes.Immortality
{
	// Token: 0x020000F5 RID: 245
	public class SligFarmer : WormArchetype
	{
		// Token: 0x06001020 RID: 4128 RVA: 0x0009CA74 File Offset: 0x0009AC74
		// Note: this type is marked as 'beforefieldinit'.
		static SligFarmer()
		{
			Il2CppClassPointerStore<SligFarmer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TleilaxuArchetypes.Immortality", "SligFarmer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SligFarmer>.NativeClassPtr);
			SligFarmer.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SligFarmer>.NativeClassPtr, "archID");
			SligFarmer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SligFarmer>.NativeClassPtr, 100666122);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0009CACC File Offset: 0x0009ACCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80316, XrefRangeEnd = 80496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SligFarmer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SligFarmer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SligFarmer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x0000865D File Offset: 0x0000685D
		public SligFarmer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x0009CB08 File Offset: 0x0009AD08
		// (set) Token: 0x06001024 RID: 4132 RVA: 0x00008666 File Offset: 0x00006866
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SligFarmer.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SligFarmer.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
