using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x02000187 RID: 391
	public class Jamis : WormArchetype
	{
		// Token: 0x060012FA RID: 4858 RVA: 0x000A35AC File Offset: 0x000A17AC
		// Note: this type is marked as 'beforefieldinit'.
		static Jamis()
		{
			Il2CppClassPointerStore<Jamis>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "Jamis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Jamis>.NativeClassPtr);
			Jamis.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jamis>.NativeClassPtr, "archID");
			Jamis.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jamis>.NativeClassPtr, 100666414);
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x000A3604 File Offset: 0x000A1804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99236, XrefRangeEnd = 99460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Jamis()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Jamis>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jamis.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x000095C3 File Offset: 0x000077C3
		public Jamis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x000A3640 File Offset: 0x000A1840
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x000095CC File Offset: 0x000077CC
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Jamis.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Jamis.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
