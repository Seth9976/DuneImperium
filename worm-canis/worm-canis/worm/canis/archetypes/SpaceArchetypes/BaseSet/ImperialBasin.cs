using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x0200011C RID: 284
	public class ImperialBasin : WormArchetype
	{
		// Token: 0x060010E3 RID: 4323 RVA: 0x0009E718 File Offset: 0x0009C918
		// Note: this type is marked as 'beforefieldinit'.
		static ImperialBasin()
		{
			Il2CppClassPointerStore<ImperialBasin>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "ImperialBasin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImperialBasin>.NativeClassPtr);
			ImperialBasin.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImperialBasin>.NativeClassPtr, "archID");
			ImperialBasin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImperialBasin>.NativeClassPtr, 100666200);
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0009E770 File Offset: 0x0009C970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85534, XrefRangeEnd = 85669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImperialBasin()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImperialBasin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImperialBasin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x00008A7A File Offset: 0x00006C7A
		public ImperialBasin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x0009E7AC File Offset: 0x0009C9AC
		// (set) Token: 0x060010E7 RID: 4327 RVA: 0x00008A83 File Offset: 0x00006C83
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImperialBasin.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImperialBasin.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
