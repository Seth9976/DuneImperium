using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.BaseSet
{
	// Token: 0x0200020C RID: 524
	public class SkirmishA : WormArchetype
	{
		// Token: 0x06001593 RID: 5523 RVA: 0x000A9758 File Offset: 0x000A7958
		// Note: this type is marked as 'beforefieldinit'.
		static SkirmishA()
		{
			Il2CppClassPointerStore<SkirmishA>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.BaseSet", "SkirmishA");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishA>.NativeClassPtr);
			SkirmishA.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishA>.NativeClassPtr, "archID");
			SkirmishA.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishA>.NativeClassPtr, 100666680);
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x000A97B0 File Offset: 0x000A79B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121837, XrefRangeEnd = 121942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkirmishA()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkirmishA>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishA.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x0000A3CA File Offset: 0x000085CA
		public SkirmishA(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x000A97EC File Offset: 0x000A79EC
		// (set) Token: 0x06001597 RID: 5527 RVA: 0x0000A3D3 File Offset: 0x000085D3
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SkirmishA.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkirmishA.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
