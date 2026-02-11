using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.BaseSet
{
	// Token: 0x020001F9 RID: 505
	public class HagalSelectiveBreeding : WormArchetype
	{
		// Token: 0x06001534 RID: 5428 RVA: 0x000A8964 File Offset: 0x000A6B64
		// Note: this type is marked as 'beforefieldinit'.
		static HagalSelectiveBreeding()
		{
			Il2CppClassPointerStore<HagalSelectiveBreeding>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.BaseSet", "HagalSelectiveBreeding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalSelectiveBreeding>.NativeClassPtr);
			HagalSelectiveBreeding.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSelectiveBreeding>.NativeClassPtr, "archID");
			HagalSelectiveBreeding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSelectiveBreeding>.NativeClassPtr, 100666642);
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x000A89BC File Offset: 0x000A6BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119599, XrefRangeEnd = 119720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalSelectiveBreeding()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalSelectiveBreeding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSelectiveBreeding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0000A1C9 File Offset: 0x000083C9
		public HagalSelectiveBreeding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001537 RID: 5431 RVA: 0x000A89F8 File Offset: 0x000A6BF8
		// (set) Token: 0x06001538 RID: 5432 RVA: 0x0000A1D2 File Offset: 0x000083D2
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalSelectiveBreeding.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalSelectiveBreeding.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
