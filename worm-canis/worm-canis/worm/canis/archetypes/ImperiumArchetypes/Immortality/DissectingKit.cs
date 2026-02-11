using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x02000199 RID: 409
	public class DissectingKit : WormArchetype
	{
		// Token: 0x06001354 RID: 4948 RVA: 0x000A42E4 File Offset: 0x000A24E4
		// Note: this type is marked as 'beforefieldinit'.
		static DissectingKit()
		{
			Il2CppClassPointerStore<DissectingKit>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "DissectingKit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DissectingKit>.NativeClassPtr);
			DissectingKit.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DissectingKit>.NativeClassPtr, "archID");
			DissectingKit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DissectingKit>.NativeClassPtr, 100666450);
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x000A433C File Offset: 0x000A253C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102885, XrefRangeEnd = 103090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DissectingKit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DissectingKit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DissectingKit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x000097A9 File Offset: 0x000079A9
		public DissectingKit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x000A4378 File Offset: 0x000A2578
		// (set) Token: 0x06001358 RID: 4952 RVA: 0x000097B2 File Offset: 0x000079B2
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DissectingKit.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DissectingKit.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
