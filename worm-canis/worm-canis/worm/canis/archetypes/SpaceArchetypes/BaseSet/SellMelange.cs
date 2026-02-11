using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x02000123 RID: 291
	public class SellMelange : WormArchetype
	{
		// Token: 0x06001106 RID: 4358 RVA: 0x0009EC3C File Offset: 0x0009CE3C
		// Note: this type is marked as 'beforefieldinit'.
		static SellMelange()
		{
			Il2CppClassPointerStore<SellMelange>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "SellMelange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SellMelange>.NativeClassPtr);
			SellMelange.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellMelange>.NativeClassPtr, "archID");
			SellMelange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellMelange>.NativeClassPtr, 100666214);
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x0009EC94 File Offset: 0x0009CE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86460, XrefRangeEnd = 86559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SellMelange()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SellMelange>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellMelange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00008B37 File Offset: 0x00006D37
		public SellMelange(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x0009ECD0 File Offset: 0x0009CED0
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x00008B40 File Offset: 0x00006D40
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SellMelange.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SellMelange.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
