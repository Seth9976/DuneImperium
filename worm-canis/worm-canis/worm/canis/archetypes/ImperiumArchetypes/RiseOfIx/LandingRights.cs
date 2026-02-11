using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x02000188 RID: 392
	public class LandingRights : WormArchetype
	{
		// Token: 0x060012FF RID: 4863 RVA: 0x000A3668 File Offset: 0x000A1868
		// Note: this type is marked as 'beforefieldinit'.
		static LandingRights()
		{
			Il2CppClassPointerStore<LandingRights>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "LandingRights");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingRights>.NativeClassPtr);
			LandingRights.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingRights>.NativeClassPtr, "archID");
			LandingRights.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingRights>.NativeClassPtr, 100666416);
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x000A36C0 File Offset: 0x000A18C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99460, XrefRangeEnd = 99661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandingRights()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingRights>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingRights.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x000095DE File Offset: 0x000077DE
		public LandingRights(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x000A36FC File Offset: 0x000A18FC
		// (set) Token: 0x06001303 RID: 4867 RVA: 0x000095E7 File Offset: 0x000077E7
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LandingRights.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandingRights.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
