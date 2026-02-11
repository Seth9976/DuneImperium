using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001C0 RID: 448
	public class FremenCamp : WormArchetype
	{
		// Token: 0x06001417 RID: 5143 RVA: 0x000A5F88 File Offset: 0x000A4188
		// Note: this type is marked as 'beforefieldinit'.
		static FremenCamp()
		{
			Il2CppClassPointerStore<FremenCamp>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "FremenCamp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FremenCamp>.NativeClassPtr);
			FremenCamp.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FremenCamp>.NativeClassPtr, "archID");
			FremenCamp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FremenCamp>.NativeClassPtr, 100666528);
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x000A5FE0 File Offset: 0x000A41E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110372, XrefRangeEnd = 110559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FremenCamp()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FremenCamp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FremenCamp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x00009BC6 File Offset: 0x00007DC6
		public FremenCamp(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x000A601C File Offset: 0x000A421C
		// (set) Token: 0x0600141B RID: 5147 RVA: 0x00009BCF File Offset: 0x00007DCF
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FremenCamp.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FremenCamp.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
