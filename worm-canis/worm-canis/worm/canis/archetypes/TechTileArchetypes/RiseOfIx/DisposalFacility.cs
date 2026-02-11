using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TechTileArchetypes.RiseOfIx
{
	// Token: 0x020000FF RID: 255
	public class DisposalFacility : WormArchetype
	{
		// Token: 0x06001052 RID: 4178 RVA: 0x0009D1CC File Offset: 0x0009B3CC
		// Note: this type is marked as 'beforefieldinit'.
		static DisposalFacility()
		{
			Il2CppClassPointerStore<DisposalFacility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TechTileArchetypes.RiseOfIx", "DisposalFacility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisposalFacility>.NativeClassPtr);
			DisposalFacility.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisposalFacility>.NativeClassPtr, "archID");
			DisposalFacility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisposalFacility>.NativeClassPtr, 100666142);
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0009D224 File Offset: 0x0009B424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81861, XrefRangeEnd = 81992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisposalFacility()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisposalFacility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisposalFacility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0000876B File Offset: 0x0000696B
		public DisposalFacility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x0009D260 File Offset: 0x0009B460
		// (set) Token: 0x06001056 RID: 4182 RVA: 0x00008774 File Offset: 0x00006974
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DisposalFacility.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DisposalFacility.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
