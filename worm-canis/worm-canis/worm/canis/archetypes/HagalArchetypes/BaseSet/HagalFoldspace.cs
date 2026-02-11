using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.BaseSet
{
	// Token: 0x020001F1 RID: 497
	public class HagalFoldspace : WormArchetype
	{
		// Token: 0x0600150C RID: 5388 RVA: 0x000A8384 File Offset: 0x000A6584
		// Note: this type is marked as 'beforefieldinit'.
		static HagalFoldspace()
		{
			Il2CppClassPointerStore<HagalFoldspace>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.BaseSet", "HagalFoldspace");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalFoldspace>.NativeClassPtr);
			HagalFoldspace.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalFoldspace>.NativeClassPtr, "archID");
			HagalFoldspace.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalFoldspace>.NativeClassPtr, 100666626);
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x000A83DC File Offset: 0x000A65DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118666, XrefRangeEnd = 118787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalFoldspace()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalFoldspace>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalFoldspace.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x0000A0F1 File Offset: 0x000082F1
		public HagalFoldspace(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x000A8418 File Offset: 0x000A6618
		// (set) Token: 0x06001510 RID: 5392 RVA: 0x0000A0FA File Offset: 0x000082FA
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalFoldspace.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalFoldspace.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
