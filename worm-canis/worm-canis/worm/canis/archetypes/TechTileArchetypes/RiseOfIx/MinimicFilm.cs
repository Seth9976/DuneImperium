using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TechTileArchetypes.RiseOfIx
{
	// Token: 0x02000105 RID: 261
	public class MinimicFilm : WormArchetype
	{
		// Token: 0x06001070 RID: 4208 RVA: 0x0009D634 File Offset: 0x0009B834
		// Note: this type is marked as 'beforefieldinit'.
		static MinimicFilm()
		{
			Il2CppClassPointerStore<MinimicFilm>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TechTileArchetypes.RiseOfIx", "MinimicFilm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinimicFilm>.NativeClassPtr);
			MinimicFilm.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimicFilm>.NativeClassPtr, "archID");
			MinimicFilm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimicFilm>.NativeClassPtr, 100666154);
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x0009D68C File Offset: 0x0009B88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82595, XrefRangeEnd = 82689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinimicFilm()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinimicFilm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinimicFilm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0000880D File Offset: 0x00006A0D
		public MinimicFilm(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x0009D6C8 File Offset: 0x0009B8C8
		// (set) Token: 0x06001074 RID: 4212 RVA: 0x00008816 File Offset: 0x00006A16
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MinimicFilm.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MinimicFilm.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
