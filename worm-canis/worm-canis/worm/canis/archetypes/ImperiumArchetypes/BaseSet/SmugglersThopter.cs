using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001D9 RID: 473
	public class SmugglersThopter : WormArchetype
	{
		// Token: 0x06001494 RID: 5268 RVA: 0x000A71E4 File Offset: 0x000A53E4
		// Note: this type is marked as 'beforefieldinit'.
		static SmugglersThopter()
		{
			Il2CppClassPointerStore<SmugglersThopter>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "SmugglersThopter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmugglersThopter>.NativeClassPtr);
			SmugglersThopter.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmugglersThopter>.NativeClassPtr, "archID");
			SmugglersThopter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmugglersThopter>.NativeClassPtr, 100666578);
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x000A723C File Offset: 0x000A543C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115079, XrefRangeEnd = 115293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmugglersThopter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmugglersThopter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmugglersThopter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x00009E69 File Offset: 0x00008069
		public SmugglersThopter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x000A7278 File Offset: 0x000A5478
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x00009E72 File Offset: 0x00008072
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SmugglersThopter.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SmugglersThopter.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
