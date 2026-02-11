using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TleilaxuArchetypes.Immortality
{
	// Token: 0x020000F3 RID: 243
	public class ReclaimedForces : WormArchetype
	{
		// Token: 0x06001016 RID: 4118 RVA: 0x0009C8FC File Offset: 0x0009AAFC
		// Note: this type is marked as 'beforefieldinit'.
		static ReclaimedForces()
		{
			Il2CppClassPointerStore<ReclaimedForces>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TleilaxuArchetypes.Immortality", "ReclaimedForces");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReclaimedForces>.NativeClassPtr);
			ReclaimedForces.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReclaimedForces>.NativeClassPtr, "archID");
			ReclaimedForces.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReclaimedForces>.NativeClassPtr, 100666118);
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x0009C954 File Offset: 0x0009AB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79998, XrefRangeEnd = 80128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReclaimedForces()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReclaimedForces>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReclaimedForces.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00008627 File Offset: 0x00006827
		public ReclaimedForces(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001019 RID: 4121 RVA: 0x0009C990 File Offset: 0x0009AB90
		// (set) Token: 0x0600101A RID: 4122 RVA: 0x00008630 File Offset: 0x00006830
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReclaimedForces.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReclaimedForces.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
