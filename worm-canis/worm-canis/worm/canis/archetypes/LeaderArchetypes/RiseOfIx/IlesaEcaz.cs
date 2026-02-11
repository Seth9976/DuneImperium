using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.LeaderArchetypes.RiseOfIx
{
	// Token: 0x0200012A RID: 298
	public class IlesaEcaz : WormArchetype
	{
		// Token: 0x06001129 RID: 4393 RVA: 0x0009F160 File Offset: 0x0009D360
		// Note: this type is marked as 'beforefieldinit'.
		static IlesaEcaz()
		{
			Il2CppClassPointerStore<IlesaEcaz>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.LeaderArchetypes.RiseOfIx", "IlesaEcaz");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IlesaEcaz>.NativeClassPtr);
			IlesaEcaz.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IlesaEcaz>.NativeClassPtr, "archID");
			IlesaEcaz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IlesaEcaz>.NativeClassPtr, 100666228);
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x0009F1B8 File Offset: 0x0009D3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87323, XrefRangeEnd = 87439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IlesaEcaz()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IlesaEcaz>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IlesaEcaz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00008BF4 File Offset: 0x00006DF4
		public IlesaEcaz(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x0009F1F4 File Offset: 0x0009D3F4
		// (set) Token: 0x0600112D RID: 4397 RVA: 0x00008BFD File Offset: 0x00006DFD
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IlesaEcaz.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IlesaEcaz.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
