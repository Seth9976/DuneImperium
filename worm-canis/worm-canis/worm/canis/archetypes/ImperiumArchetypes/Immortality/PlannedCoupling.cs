using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x020001A4 RID: 420
	public class PlannedCoupling : WormArchetype
	{
		// Token: 0x0600138B RID: 5003 RVA: 0x000A4AF8 File Offset: 0x000A2CF8
		// Note: this type is marked as 'beforefieldinit'.
		static PlannedCoupling()
		{
			Il2CppClassPointerStore<PlannedCoupling>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "PlannedCoupling");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlannedCoupling>.NativeClassPtr);
			PlannedCoupling.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlannedCoupling>.NativeClassPtr, "archID");
			PlannedCoupling.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlannedCoupling>.NativeClassPtr, 100666472);
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x000A4B50 File Offset: 0x000A2D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105122, XrefRangeEnd = 105318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlannedCoupling()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlannedCoupling>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlannedCoupling.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x000098D2 File Offset: 0x00007AD2
		public PlannedCoupling(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x000A4B8C File Offset: 0x000A2D8C
		// (set) Token: 0x0600138F RID: 5007 RVA: 0x000098DB File Offset: 0x00007ADB
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlannedCoupling.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlannedCoupling.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
