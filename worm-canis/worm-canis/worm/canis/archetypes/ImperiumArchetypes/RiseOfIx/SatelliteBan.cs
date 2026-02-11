using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x0200018B RID: 395
	public class SatelliteBan : WormArchetype
	{
		// Token: 0x0600130E RID: 4878 RVA: 0x000A389C File Offset: 0x000A1A9C
		// Note: this type is marked as 'beforefieldinit'.
		static SatelliteBan()
		{
			Il2CppClassPointerStore<SatelliteBan>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "SatelliteBan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SatelliteBan>.NativeClassPtr);
			SatelliteBan.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatelliteBan>.NativeClassPtr, "archID");
			SatelliteBan.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatelliteBan>.NativeClassPtr, 100666422);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x000A38F4 File Offset: 0x000A1AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100007, XrefRangeEnd = 100218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SatelliteBan()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SatelliteBan>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SatelliteBan.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x0000962F File Offset: 0x0000782F
		public SatelliteBan(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001311 RID: 4881 RVA: 0x000A3930 File Offset: 0x000A1B30
		// (set) Token: 0x06001312 RID: 4882 RVA: 0x00009638 File Offset: 0x00007838
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SatelliteBan.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SatelliteBan.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
