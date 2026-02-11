using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.LeaderArchetypes.BaseSet
{
	// Token: 0x02000136 RID: 310
	public class HelenaRichese : WormArchetype
	{
		// Token: 0x06001165 RID: 4453 RVA: 0x0009FA30 File Offset: 0x0009DC30
		// Note: this type is marked as 'beforefieldinit'.
		static HelenaRichese()
		{
			Il2CppClassPointerStore<HelenaRichese>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.LeaderArchetypes.BaseSet", "HelenaRichese");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelenaRichese>.NativeClassPtr);
			HelenaRichese.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelenaRichese>.NativeClassPtr, "archID");
			HelenaRichese.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelenaRichese>.NativeClassPtr, 100666252);
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0009FA88 File Offset: 0x0009DC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88637, XrefRangeEnd = 88726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HelenaRichese()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelenaRichese>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelenaRichese.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00008D38 File Offset: 0x00006F38
		public HelenaRichese(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x0009FAC4 File Offset: 0x0009DCC4
		// (set) Token: 0x06001169 RID: 4457 RVA: 0x00008D41 File Offset: 0x00006F41
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HelenaRichese.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HelenaRichese.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
