using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x0200017F RID: 383
	public class FullScaleAssault : WormArchetype
	{
		// Token: 0x060012D2 RID: 4818 RVA: 0x000A2FCC File Offset: 0x000A11CC
		// Note: this type is marked as 'beforefieldinit'.
		static FullScaleAssault()
		{
			Il2CppClassPointerStore<FullScaleAssault>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "FullScaleAssault");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullScaleAssault>.NativeClassPtr);
			FullScaleAssault.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScaleAssault>.NativeClassPtr, "archID");
			FullScaleAssault.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScaleAssault>.NativeClassPtr, 100666398);
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x000A3024 File Offset: 0x000A1224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97620, XrefRangeEnd = 97833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullScaleAssault()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FullScaleAssault>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScaleAssault.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x000094EB File Offset: 0x000076EB
		public FullScaleAssault(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x000A3060 File Offset: 0x000A1260
		// (set) Token: 0x060012D6 RID: 4822 RVA: 0x000094F4 File Offset: 0x000076F4
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FullScaleAssault.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FullScaleAssault.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
