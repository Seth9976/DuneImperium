using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TechTileArchetypes.RiseOfIx
{
	// Token: 0x0200010C RID: 268
	public class TroopTransports : WormArchetype
	{
		// Token: 0x06001093 RID: 4243 RVA: 0x0009DB58 File Offset: 0x0009BD58
		// Note: this type is marked as 'beforefieldinit'.
		static TroopTransports()
		{
			Il2CppClassPointerStore<TroopTransports>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TechTileArchetypes.RiseOfIx", "TroopTransports");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TroopTransports>.NativeClassPtr);
			TroopTransports.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopTransports>.NativeClassPtr, "archID");
			TroopTransports.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopTransports>.NativeClassPtr, 100666168);
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x0009DBB0 File Offset: 0x0009BDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83377, XrefRangeEnd = 83480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TroopTransports()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TroopTransports>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TroopTransports.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x000088CA File Offset: 0x00006ACA
		public TroopTransports(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x0009DBEC File Offset: 0x0009BDEC
		// (set) Token: 0x06001097 RID: 4247 RVA: 0x000088D3 File Offset: 0x00006AD3
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TroopTransports.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TroopTransports.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
