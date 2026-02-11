using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.RiseOfIx
{
	// Token: 0x02000111 RID: 273
	public class TechNegotiation : WormArchetype
	{
		// Token: 0x060010AC RID: 4268 RVA: 0x0009DF04 File Offset: 0x0009C104
		// Note: this type is marked as 'beforefieldinit'.
		static TechNegotiation()
		{
			Il2CppClassPointerStore<TechNegotiation>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.RiseOfIx", "TechNegotiation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TechNegotiation>.NativeClassPtr);
			TechNegotiation.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechNegotiation>.NativeClassPtr, "archID");
			TechNegotiation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TechNegotiation>.NativeClassPtr, 100666178);
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0009DF5C File Offset: 0x0009C15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83961, XrefRangeEnd = 84082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TechNegotiation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TechNegotiation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TechNegotiation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00008951 File Offset: 0x00006B51
		public TechNegotiation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x0009DF98 File Offset: 0x0009C198
		// (set) Token: 0x060010B0 RID: 4272 RVA: 0x0000895A File Offset: 0x00006B5A
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TechNegotiation.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TechNegotiation.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
