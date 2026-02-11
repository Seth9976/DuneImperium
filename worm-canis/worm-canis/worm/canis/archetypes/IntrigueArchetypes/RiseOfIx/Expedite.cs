using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.RiseOfIx
{
	// Token: 0x0200013D RID: 317
	public class Expedite : WormArchetype
	{
		// Token: 0x06001188 RID: 4488 RVA: 0x0009FF54 File Offset: 0x0009E154
		// Note: this type is marked as 'beforefieldinit'.
		static Expedite()
		{
			Il2CppClassPointerStore<Expedite>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.RiseOfIx", "Expedite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Expedite>.NativeClassPtr);
			Expedite.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expedite>.NativeClassPtr, "archID");
			Expedite.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expedite>.NativeClassPtr, 100666266);
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x0009FFAC File Offset: 0x0009E1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89401, XrefRangeEnd = 89521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expedite()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Expedite>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expedite.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00008DF5 File Offset: 0x00006FF5
		public Expedite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x0009FFE8 File Offset: 0x0009E1E8
		// (set) Token: 0x0600118C RID: 4492 RVA: 0x00008DFE File Offset: 0x00006FFE
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Expedite.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Expedite.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
