using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x02000124 RID: 292
	public class SietchTabr : WormArchetype
	{
		// Token: 0x0600110B RID: 4363 RVA: 0x0009ECF8 File Offset: 0x0009CEF8
		// Note: this type is marked as 'beforefieldinit'.
		static SietchTabr()
		{
			Il2CppClassPointerStore<SietchTabr>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "SietchTabr");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SietchTabr>.NativeClassPtr);
			SietchTabr.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SietchTabr>.NativeClassPtr, "archID");
			SietchTabr.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SietchTabr>.NativeClassPtr, 100666216);
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0009ED50 File Offset: 0x0009CF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86559, XrefRangeEnd = 86689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SietchTabr()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SietchTabr>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SietchTabr.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00008B52 File Offset: 0x00006D52
		public SietchTabr(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x0009ED8C File Offset: 0x0009CF8C
		// (set) Token: 0x0600110F RID: 4367 RVA: 0x00008B5B File Offset: 0x00006D5B
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SietchTabr.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SietchTabr.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
