using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001DA RID: 474
	public class SpaceTravel : WormArchetype
	{
		// Token: 0x06001499 RID: 5273 RVA: 0x000A72A0 File Offset: 0x000A54A0
		// Note: this type is marked as 'beforefieldinit'.
		static SpaceTravel()
		{
			Il2CppClassPointerStore<SpaceTravel>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "SpaceTravel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpaceTravel>.NativeClassPtr);
			SpaceTravel.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpaceTravel>.NativeClassPtr, "archID");
			SpaceTravel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceTravel>.NativeClassPtr, 100666580);
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x000A72F8 File Offset: 0x000A54F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115293, XrefRangeEnd = 115485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpaceTravel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpaceTravel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpaceTravel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x00009E84 File Offset: 0x00008084
		public SpaceTravel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x000A7334 File Offset: 0x000A5534
		// (set) Token: 0x0600149D RID: 5277 RVA: 0x00009E8D File Offset: 0x0000808D
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpaceTravel.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpaceTravel.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
