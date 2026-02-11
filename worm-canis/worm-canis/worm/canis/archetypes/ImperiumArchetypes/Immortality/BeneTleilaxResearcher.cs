using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x02000195 RID: 405
	public class BeneTleilaxResearcher : WormArchetype
	{
		// Token: 0x06001340 RID: 4928 RVA: 0x000A3FF4 File Offset: 0x000A21F4
		// Note: this type is marked as 'beforefieldinit'.
		static BeneTleilaxResearcher()
		{
			Il2CppClassPointerStore<BeneTleilaxResearcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "BeneTleilaxResearcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeneTleilaxResearcher>.NativeClassPtr);
			BeneTleilaxResearcher.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneTleilaxResearcher>.NativeClassPtr, "archID");
			BeneTleilaxResearcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcher>.NativeClassPtr, 100666442);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x000A404C File Offset: 0x000A224C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102080, XrefRangeEnd = 102286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BeneTleilaxResearcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeneTleilaxResearcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0000973D File Offset: 0x0000793D
		public BeneTleilaxResearcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001343 RID: 4931 RVA: 0x000A4088 File Offset: 0x000A2288
		// (set) Token: 0x06001344 RID: 4932 RVA: 0x00009746 File Offset: 0x00007946
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BeneTleilaxResearcher.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BeneTleilaxResearcher.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
