using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x02000115 RID: 277
	public class Conspire : WormArchetype
	{
		// Token: 0x060010C0 RID: 4288 RVA: 0x0009E1F4 File Offset: 0x0009C3F4
		// Note: this type is marked as 'beforefieldinit'.
		static Conspire()
		{
			Il2CppClassPointerStore<Conspire>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "Conspire");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Conspire>.NativeClassPtr);
			Conspire.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conspire>.NativeClassPtr, "archID");
			Conspire.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conspire>.NativeClassPtr, 100666186);
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0009E24C File Offset: 0x0009C44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84520, XrefRangeEnd = 84682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Conspire()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Conspire>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conspire.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x000089BD File Offset: 0x00006BBD
		public Conspire(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x0009E288 File Offset: 0x0009C488
		// (set) Token: 0x060010C4 RID: 4292 RVA: 0x000089C6 File Offset: 0x00006BC6
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Conspire.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Conspire.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
