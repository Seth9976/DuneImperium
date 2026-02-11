using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.BaseSet
{
	// Token: 0x020001F7 RID: 503
	public class HagalReshuffle : WormArchetype
	{
		// Token: 0x0600152A RID: 5418 RVA: 0x000A87EC File Offset: 0x000A69EC
		// Note: this type is marked as 'beforefieldinit'.
		static HagalReshuffle()
		{
			Il2CppClassPointerStore<HagalReshuffle>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.BaseSet", "HagalReshuffle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalReshuffle>.NativeClassPtr);
			HagalReshuffle.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalReshuffle>.NativeClassPtr, "archID");
			HagalReshuffle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalReshuffle>.NativeClassPtr, 100666638);
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x000A8844 File Offset: 0x000A6A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119382, XrefRangeEnd = 119478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalReshuffle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalReshuffle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalReshuffle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0000A193 File Offset: 0x00008393
		public HagalReshuffle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x0600152D RID: 5421 RVA: 0x000A8880 File Offset: 0x000A6A80
		// (set) Token: 0x0600152E RID: 5422 RVA: 0x0000A19C File Offset: 0x0000839C
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalReshuffle.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalReshuffle.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
