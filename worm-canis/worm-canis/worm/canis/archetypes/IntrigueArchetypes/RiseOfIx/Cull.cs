using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.RiseOfIx
{
	// Token: 0x0200013B RID: 315
	public class Cull : WormArchetype
	{
		// Token: 0x0600117E RID: 4478 RVA: 0x0009FDDC File Offset: 0x0009DFDC
		// Note: this type is marked as 'beforefieldinit'.
		static Cull()
		{
			Il2CppClassPointerStore<Cull>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.RiseOfIx", "Cull");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cull>.NativeClassPtr);
			Cull.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cull>.NativeClassPtr, "archID");
			Cull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cull>.NativeClassPtr, 100666262);
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x0009FE34 File Offset: 0x0009E034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89175, XrefRangeEnd = 89281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cull()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cull>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00008DBF File Offset: 0x00006FBF
		public Cull(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x0009FE70 File Offset: 0x0009E070
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x00008DC8 File Offset: 0x00006FC8
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Cull.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Cull.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
