using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.LeaderArchetypes.BaseSet
{
	// Token: 0x02000132 RID: 306
	public class CountIlbanRichese : WormArchetype
	{
		// Token: 0x06001151 RID: 4433 RVA: 0x0009F740 File Offset: 0x0009D940
		// Note: this type is marked as 'beforefieldinit'.
		static CountIlbanRichese()
		{
			Il2CppClassPointerStore<CountIlbanRichese>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.LeaderArchetypes.BaseSet", "CountIlbanRichese");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountIlbanRichese>.NativeClassPtr);
			CountIlbanRichese.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountIlbanRichese>.NativeClassPtr, "archID");
			CountIlbanRichese.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountIlbanRichese>.NativeClassPtr, 100666244);
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0009F798 File Offset: 0x0009D998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88199, XrefRangeEnd = 88313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CountIlbanRichese()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CountIlbanRichese>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountIlbanRichese.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00008CCC File Offset: 0x00006ECC
		public CountIlbanRichese(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x0009F7D4 File Offset: 0x0009D9D4
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x00008CD5 File Offset: 0x00006ED5
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CountIlbanRichese.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CountIlbanRichese.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
