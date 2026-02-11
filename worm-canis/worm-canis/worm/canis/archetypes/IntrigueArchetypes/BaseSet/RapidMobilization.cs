using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000169 RID: 361
	public class RapidMobilization : WormArchetype
	{
		// Token: 0x06001264 RID: 4708 RVA: 0x000A1FA4 File Offset: 0x000A01A4
		// Note: this type is marked as 'beforefieldinit'.
		static RapidMobilization()
		{
			Il2CppClassPointerStore<RapidMobilization>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "RapidMobilization");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RapidMobilization>.NativeClassPtr);
			RapidMobilization.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilization>.NativeClassPtr, "archID");
			RapidMobilization.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilization>.NativeClassPtr, 100666354);
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x000A1FFC File Offset: 0x000A01FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94425, XrefRangeEnd = 94526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RapidMobilization()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RapidMobilization>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilization.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00009299 File Offset: 0x00007499
		public RapidMobilization(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x000A2038 File Offset: 0x000A0238
		// (set) Token: 0x06001268 RID: 4712 RVA: 0x000092A2 File Offset: 0x000074A2
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RapidMobilization.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RapidMobilization.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
