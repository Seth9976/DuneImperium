using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x020001AA RID: 426
	public class StillsuitManufacturer : WormArchetype
	{
		// Token: 0x060013A9 RID: 5033 RVA: 0x000A4F60 File Offset: 0x000A3160
		// Note: this type is marked as 'beforefieldinit'.
		static StillsuitManufacturer()
		{
			Il2CppClassPointerStore<StillsuitManufacturer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "StillsuitManufacturer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StillsuitManufacturer>.NativeClassPtr);
			StillsuitManufacturer.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StillsuitManufacturer>.NativeClassPtr, "archID");
			StillsuitManufacturer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StillsuitManufacturer>.NativeClassPtr, 100666484);
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x000A4FB8 File Offset: 0x000A31B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106341, XrefRangeEnd = 106552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StillsuitManufacturer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StillsuitManufacturer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StillsuitManufacturer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00009974 File Offset: 0x00007B74
		public StillsuitManufacturer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x000A4FF4 File Offset: 0x000A31F4
		// (set) Token: 0x060013AD RID: 5037 RVA: 0x0000997D File Offset: 0x00007B7D
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StillsuitManufacturer.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StillsuitManufacturer.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
