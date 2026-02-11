using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.Immortality
{
	// Token: 0x02000153 RID: 339
	public class ViciousTalents : WormArchetype
	{
		// Token: 0x060011F6 RID: 4598 RVA: 0x000A0F7C File Offset: 0x0009F17C
		// Note: this type is marked as 'beforefieldinit'.
		static ViciousTalents()
		{
			Il2CppClassPointerStore<ViciousTalents>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.Immortality", "ViciousTalents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViciousTalents>.NativeClassPtr);
			ViciousTalents.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViciousTalents>.NativeClassPtr, "archID");
			ViciousTalents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalents>.NativeClassPtr, 100666310);
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x000A0FD4 File Offset: 0x0009F1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92016, XrefRangeEnd = 92146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ViciousTalents()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViciousTalents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViciousTalents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00009047 File Offset: 0x00007247
		public ViciousTalents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x000A1010 File Offset: 0x0009F210
		// (set) Token: 0x060011FA RID: 4602 RVA: 0x00009050 File Offset: 0x00007250
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ViciousTalents.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ViciousTalents.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
