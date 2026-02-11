using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.RiseOfIx
{
	// Token: 0x02000138 RID: 312
	public class AdvancedWeaponry : WormArchetype
	{
		// Token: 0x0600116F RID: 4463 RVA: 0x0009FBA8 File Offset: 0x0009DDA8
		// Note: this type is marked as 'beforefieldinit'.
		static AdvancedWeaponry()
		{
			Il2CppClassPointerStore<AdvancedWeaponry>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.RiseOfIx", "AdvancedWeaponry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedWeaponry>.NativeClassPtr);
			AdvancedWeaponry.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedWeaponry>.NativeClassPtr, "archID");
			AdvancedWeaponry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedWeaponry>.NativeClassPtr, 100666256);
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x0009FC00 File Offset: 0x0009DE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88824, XrefRangeEnd = 88949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedWeaponry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedWeaponry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedWeaponry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00008D6E File Offset: 0x00006F6E
		public AdvancedWeaponry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x0009FC3C File Offset: 0x0009DE3C
		// (set) Token: 0x06001173 RID: 4467 RVA: 0x00008D77 File Offset: 0x00006F77
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AdvancedWeaponry.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AdvancedWeaponry.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
