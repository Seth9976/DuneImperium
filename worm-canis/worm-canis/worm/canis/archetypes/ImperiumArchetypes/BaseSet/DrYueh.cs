using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001BA RID: 442
	public class DrYueh : WormArchetype
	{
		// Token: 0x060013F9 RID: 5113 RVA: 0x000A5B20 File Offset: 0x000A3D20
		// Note: this type is marked as 'beforefieldinit'.
		static DrYueh()
		{
			Il2CppClassPointerStore<DrYueh>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "DrYueh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrYueh>.NativeClassPtr);
			DrYueh.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrYueh>.NativeClassPtr, "archID");
			DrYueh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrYueh>.NativeClassPtr, 100666516);
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x000A5B78 File Offset: 0x000A3D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109248, XrefRangeEnd = 109440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrYueh()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrYueh>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrYueh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x00009B24 File Offset: 0x00007D24
		public DrYueh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x000A5BB4 File Offset: 0x000A3DB4
		// (set) Token: 0x060013FD RID: 5117 RVA: 0x00009B2D File Offset: 0x00007D2D
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DrYueh.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DrYueh.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
