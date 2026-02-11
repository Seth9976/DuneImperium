using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.RiseOfIx
{
	// Token: 0x020001E3 RID: 483
	public class HagalDreadnought : WormArchetype
	{
		// Token: 0x060014C6 RID: 5318 RVA: 0x000A793C File Offset: 0x000A5B3C
		// Note: this type is marked as 'beforefieldinit'.
		static HagalDreadnought()
		{
			Il2CppClassPointerStore<HagalDreadnought>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.RiseOfIx", "HagalDreadnought");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalDreadnought>.NativeClassPtr);
			HagalDreadnought.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalDreadnought>.NativeClassPtr, "archID");
			HagalDreadnought.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalDreadnought>.NativeClassPtr, 100666598);
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x000A7994 File Offset: 0x000A5B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117076, XrefRangeEnd = 117189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalDreadnought()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalDreadnought>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalDreadnought.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00009F77 File Offset: 0x00008177
		public HagalDreadnought(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x000A79D0 File Offset: 0x000A5BD0
		// (set) Token: 0x060014CA RID: 5322 RVA: 0x00009F80 File Offset: 0x00008180
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalDreadnought.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalDreadnought.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
