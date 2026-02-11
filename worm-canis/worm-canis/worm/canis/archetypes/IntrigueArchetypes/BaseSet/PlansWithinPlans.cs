using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000166 RID: 358
	public class PlansWithinPlans : WormArchetype
	{
		// Token: 0x06001255 RID: 4693 RVA: 0x000A1D70 File Offset: 0x0009FF70
		// Note: this type is marked as 'beforefieldinit'.
		static PlansWithinPlans()
		{
			Il2CppClassPointerStore<PlansWithinPlans>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "PlansWithinPlans");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlansWithinPlans>.NativeClassPtr);
			PlansWithinPlans.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlansWithinPlans>.NativeClassPtr, "archID");
			PlansWithinPlans.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlansWithinPlans>.NativeClassPtr, 100666348);
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x000A1DC8 File Offset: 0x0009FFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94091, XrefRangeEnd = 94206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlansWithinPlans()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlansWithinPlans>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlansWithinPlans.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00009248 File Offset: 0x00007448
		public PlansWithinPlans(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x000A1E04 File Offset: 0x000A0004
		// (set) Token: 0x06001259 RID: 4697 RVA: 0x00009251 File Offset: 0x00007451
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlansWithinPlans.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlansWithinPlans.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
