using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x02000128 RID: 296
	public class Wealth : WormArchetype
	{
		// Token: 0x0600111F RID: 4383 RVA: 0x0009EFE8 File Offset: 0x0009D1E8
		// Note: this type is marked as 'beforefieldinit'.
		static Wealth()
		{
			Il2CppClassPointerStore<Wealth>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "Wealth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Wealth>.NativeClassPtr);
			Wealth.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wealth>.NativeClassPtr, "archID");
			Wealth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wealth>.NativeClassPtr, 100666224);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0009F040 File Offset: 0x0009D240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87087, XrefRangeEnd = 87225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Wealth()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Wealth>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wealth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00008BBE File Offset: 0x00006DBE
		public Wealth(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001122 RID: 4386 RVA: 0x0009F07C File Offset: 0x0009D27C
		// (set) Token: 0x06001123 RID: 4387 RVA: 0x00008BC7 File Offset: 0x00006DC7
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Wealth.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wealth.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
