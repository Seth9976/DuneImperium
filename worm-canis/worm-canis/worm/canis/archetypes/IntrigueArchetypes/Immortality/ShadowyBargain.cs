using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.Immortality
{
	// Token: 0x02000150 RID: 336
	public class ShadowyBargain : WormArchetype
	{
		// Token: 0x060011E7 RID: 4583 RVA: 0x000A0D48 File Offset: 0x0009EF48
		// Note: this type is marked as 'beforefieldinit'.
		static ShadowyBargain()
		{
			Il2CppClassPointerStore<ShadowyBargain>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.Immortality", "ShadowyBargain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowyBargain>.NativeClassPtr);
			ShadowyBargain.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowyBargain>.NativeClassPtr, "archID");
			ShadowyBargain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowyBargain>.NativeClassPtr, 100666304);
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x000A0DA0 File Offset: 0x0009EFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91629, XrefRangeEnd = 91756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShadowyBargain()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowyBargain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowyBargain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00008FF6 File Offset: 0x000071F6
		public ShadowyBargain(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x000A0DDC File Offset: 0x0009EFDC
		// (set) Token: 0x060011EB RID: 4587 RVA: 0x00008FFF File Offset: 0x000071FF
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShadowyBargain.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowyBargain.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
