using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TechTileArchetypes.RiseOfIx
{
	// Token: 0x02000102 RID: 258
	public class HoltzmanEngine : WormArchetype
	{
		// Token: 0x06001061 RID: 4193 RVA: 0x0009D400 File Offset: 0x0009B600
		// Note: this type is marked as 'beforefieldinit'.
		static HoltzmanEngine()
		{
			Il2CppClassPointerStore<HoltzmanEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TechTileArchetypes.RiseOfIx", "HoltzmanEngine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HoltzmanEngine>.NativeClassPtr);
			HoltzmanEngine.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngine>.NativeClassPtr, "archID");
			HoltzmanEngine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngine>.NativeClassPtr, 100666148);
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x0009D458 File Offset: 0x0009B658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82217, XrefRangeEnd = 82337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HoltzmanEngine()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HoltzmanEngine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x000087BC File Offset: 0x000069BC
		public HoltzmanEngine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x0009D494 File Offset: 0x0009B694
		// (set) Token: 0x06001065 RID: 4197 RVA: 0x000087C5 File Offset: 0x000069C5
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HoltzmanEngine.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HoltzmanEngine.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
