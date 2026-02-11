using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TechTileArchetypes.RiseOfIx
{
	// Token: 0x02000106 RID: 262
	public class RestrictedOrdnance : WormArchetype
	{
		// Token: 0x06001075 RID: 4213 RVA: 0x0009D6F0 File Offset: 0x0009B8F0
		// Note: this type is marked as 'beforefieldinit'.
		static RestrictedOrdnance()
		{
			Il2CppClassPointerStore<RestrictedOrdnance>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TechTileArchetypes.RiseOfIx", "RestrictedOrdnance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RestrictedOrdnance>.NativeClassPtr);
			RestrictedOrdnance.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictedOrdnance>.NativeClassPtr, "archID");
			RestrictedOrdnance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestrictedOrdnance>.NativeClassPtr, 100666156);
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0009D748 File Offset: 0x0009B948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82689, XrefRangeEnd = 82778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RestrictedOrdnance()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RestrictedOrdnance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RestrictedOrdnance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00008828 File Offset: 0x00006A28
		public RestrictedOrdnance(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x0009D784 File Offset: 0x0009B984
		// (set) Token: 0x06001079 RID: 4217 RVA: 0x00008831 File Offset: 0x00006A31
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RestrictedOrdnance.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RestrictedOrdnance.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
