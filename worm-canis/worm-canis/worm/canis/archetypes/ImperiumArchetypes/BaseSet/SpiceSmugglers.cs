using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001DC RID: 476
	public class SpiceSmugglers : WormArchetype
	{
		// Token: 0x060014A3 RID: 5283 RVA: 0x000A7418 File Offset: 0x000A5618
		// Note: this type is marked as 'beforefieldinit'.
		static SpiceSmugglers()
		{
			Il2CppClassPointerStore<SpiceSmugglers>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "SpiceSmugglers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpiceSmugglers>.NativeClassPtr);
			SpiceSmugglers.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceSmugglers>.NativeClassPtr, "archID");
			SpiceSmugglers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceSmugglers>.NativeClassPtr, 100666584);
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x000A7470 File Offset: 0x000A5670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115694, XrefRangeEnd = 115891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpiceSmugglers()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpiceSmugglers>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceSmugglers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00009EBA File Offset: 0x000080BA
		public SpiceSmugglers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x000A74AC File Offset: 0x000A56AC
		// (set) Token: 0x060014A7 RID: 5287 RVA: 0x00009EC3 File Offset: 0x000080C3
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpiceSmugglers.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpiceSmugglers.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
