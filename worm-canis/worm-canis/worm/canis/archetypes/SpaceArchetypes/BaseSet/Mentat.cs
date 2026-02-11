using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x0200011D RID: 285
	public class Mentat : WormArchetype
	{
		// Token: 0x060010E8 RID: 4328 RVA: 0x0009E7D4 File Offset: 0x0009C9D4
		// Note: this type is marked as 'beforefieldinit'.
		static Mentat()
		{
			Il2CppClassPointerStore<Mentat>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "Mentat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mentat>.NativeClassPtr);
			Mentat.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mentat>.NativeClassPtr, "archID");
			Mentat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mentat>.NativeClassPtr, 100666202);
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x0009E82C File Offset: 0x0009CA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85669, XrefRangeEnd = 85792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mentat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mentat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mentat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x00008A95 File Offset: 0x00006C95
		public Mentat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x0009E868 File Offset: 0x0009CA68
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x00008A9E File Offset: 0x00006C9E
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Mentat.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Mentat.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
