using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x02000127 RID: 295
	public class TheGreatFlat : WormArchetype
	{
		// Token: 0x0600111A RID: 4378 RVA: 0x0009EF2C File Offset: 0x0009D12C
		// Note: this type is marked as 'beforefieldinit'.
		static TheGreatFlat()
		{
			Il2CppClassPointerStore<TheGreatFlat>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "TheGreatFlat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TheGreatFlat>.NativeClassPtr);
			TheGreatFlat.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheGreatFlat>.NativeClassPtr, "archID");
			TheGreatFlat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheGreatFlat>.NativeClassPtr, 100666222);
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0009EF84 File Offset: 0x0009D184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86952, XrefRangeEnd = 87087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TheGreatFlat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TheGreatFlat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TheGreatFlat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00008BA3 File Offset: 0x00006DA3
		public TheGreatFlat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x0009EFC0 File Offset: 0x0009D1C0
		// (set) Token: 0x0600111E RID: 4382 RVA: 0x00008BAC File Offset: 0x00006DAC
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TheGreatFlat.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TheGreatFlat.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
