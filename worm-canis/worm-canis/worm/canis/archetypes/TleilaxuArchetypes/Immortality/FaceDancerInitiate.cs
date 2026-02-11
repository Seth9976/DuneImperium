using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TleilaxuArchetypes.Immortality
{
	// Token: 0x020000EE RID: 238
	public class FaceDancerInitiate : WormArchetype
	{
		// Token: 0x06000FFD RID: 4093 RVA: 0x0009C550 File Offset: 0x0009A750
		// Note: this type is marked as 'beforefieldinit'.
		static FaceDancerInitiate()
		{
			Il2CppClassPointerStore<FaceDancerInitiate>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TleilaxuArchetypes.Immortality", "FaceDancerInitiate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FaceDancerInitiate>.NativeClassPtr);
			FaceDancerInitiate.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceDancerInitiate>.NativeClassPtr, "archID");
			FaceDancerInitiate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceDancerInitiate>.NativeClassPtr, 100666108);
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0009C5A8 File Offset: 0x0009A7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79134, XrefRangeEnd = 79322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FaceDancerInitiate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FaceDancerInitiate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceDancerInitiate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x000085A0 File Offset: 0x000067A0
		public FaceDancerInitiate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x0009C5E4 File Offset: 0x0009A7E4
		// (set) Token: 0x06001001 RID: 4097 RVA: 0x000085A9 File Offset: 0x000067A9
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FaceDancerInitiate.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FaceDancerInitiate.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
