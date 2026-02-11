using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.BaseSet
{
	// Token: 0x020001EF RID: 495
	public class HagalCarthag : WormArchetype
	{
		// Token: 0x06001502 RID: 5378 RVA: 0x000A820C File Offset: 0x000A640C
		// Note: this type is marked as 'beforefieldinit'.
		static HagalCarthag()
		{
			Il2CppClassPointerStore<HagalCarthag>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.BaseSet", "HagalCarthag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalCarthag>.NativeClassPtr);
			HagalCarthag.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthag>.NativeClassPtr, "archID");
			HagalCarthag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthag>.NativeClassPtr, 100666622);
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x000A8264 File Offset: 0x000A6464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118420, XrefRangeEnd = 118540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalCarthag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalCarthag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x0000A0BB File Offset: 0x000082BB
		public HagalCarthag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x000A82A0 File Offset: 0x000A64A0
		// (set) Token: 0x06001506 RID: 5382 RVA: 0x0000A0C4 File Offset: 0x000082C4
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalCarthag.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalCarthag.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
