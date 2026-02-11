using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.RiseOfIx
{
	// Token: 0x02000110 RID: 272
	public class Smuggling : WormArchetype
	{
		// Token: 0x060010A7 RID: 4263 RVA: 0x0009DE48 File Offset: 0x0009C048
		// Note: this type is marked as 'beforefieldinit'.
		static Smuggling()
		{
			Il2CppClassPointerStore<Smuggling>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.RiseOfIx", "Smuggling");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Smuggling>.NativeClassPtr);
			Smuggling.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smuggling>.NativeClassPtr, "archID");
			Smuggling.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smuggling>.NativeClassPtr, 100666176);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0009DEA0 File Offset: 0x0009C0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83844, XrefRangeEnd = 83961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Smuggling()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Smuggling>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smuggling.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00008936 File Offset: 0x00006B36
		public Smuggling(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x0009DEDC File Offset: 0x0009C0DC
		// (set) Token: 0x060010AB RID: 4267 RVA: 0x0000893F File Offset: 0x00006B3F
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Smuggling.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Smuggling.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
