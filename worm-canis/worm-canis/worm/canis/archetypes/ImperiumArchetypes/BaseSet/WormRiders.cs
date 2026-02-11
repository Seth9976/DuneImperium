using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001E2 RID: 482
	public class WormRiders : WormArchetype
	{
		// Token: 0x060014C1 RID: 5313 RVA: 0x000A7880 File Offset: 0x000A5A80
		// Note: this type is marked as 'beforefieldinit'.
		static WormRiders()
		{
			Il2CppClassPointerStore<WormRiders>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "WormRiders");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRiders>.NativeClassPtr);
			WormRiders.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRiders>.NativeClassPtr, "archID");
			WormRiders.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRiders>.NativeClassPtr, 100666596);
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x000A78D8 File Offset: 0x000A5AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116857, XrefRangeEnd = 117076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormRiders()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRiders>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRiders.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00009F5C File Offset: 0x0000815C
		public WormRiders(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x000A7914 File Offset: 0x000A5B14
		// (set) Token: 0x060014C5 RID: 5317 RVA: 0x00009F65 File Offset: 0x00008165
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormRiders.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormRiders.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
