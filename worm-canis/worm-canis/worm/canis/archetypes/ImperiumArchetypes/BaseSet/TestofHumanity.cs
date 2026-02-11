using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001DE RID: 478
	public class TestofHumanity : WormArchetype
	{
		// Token: 0x060014AD RID: 5293 RVA: 0x000A7590 File Offset: 0x000A5790
		// Note: this type is marked as 'beforefieldinit'.
		static TestofHumanity()
		{
			Il2CppClassPointerStore<TestofHumanity>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "TestofHumanity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TestofHumanity>.NativeClassPtr);
			TestofHumanity.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestofHumanity>.NativeClassPtr, "archID");
			TestofHumanity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestofHumanity>.NativeClassPtr, 100666588);
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x000A75E8 File Offset: 0x000A57E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116099, XrefRangeEnd = 116297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TestofHumanity()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TestofHumanity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestofHumanity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00009EF0 File Offset: 0x000080F0
		public TestofHumanity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x000A7624 File Offset: 0x000A5824
		// (set) Token: 0x060014B1 RID: 5297 RVA: 0x00009EF9 File Offset: 0x000080F9
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TestofHumanity.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TestofHumanity.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
