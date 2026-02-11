using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x0200011A RID: 282
	public class Heighliner : WormArchetype
	{
		// Token: 0x060010D9 RID: 4313 RVA: 0x0009E5A0 File Offset: 0x0009C7A0
		// Note: this type is marked as 'beforefieldinit'.
		static Heighliner()
		{
			Il2CppClassPointerStore<Heighliner>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "Heighliner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Heighliner>.NativeClassPtr);
			Heighliner.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Heighliner>.NativeClassPtr, "archID");
			Heighliner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Heighliner>.NativeClassPtr, 100666196);
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0009E5F8 File Offset: 0x0009C7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85252, XrefRangeEnd = 85416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Heighliner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Heighliner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Heighliner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00008A44 File Offset: 0x00006C44
		public Heighliner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x0009E634 File Offset: 0x0009C834
		// (set) Token: 0x060010DD RID: 4317 RVA: 0x00008A4D File Offset: 0x00006C4D
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Heighliner.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Heighliner.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
