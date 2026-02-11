using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.BaseSet
{
	// Token: 0x020001F8 RID: 504
	public class HagalSecrets : WormArchetype
	{
		// Token: 0x0600152F RID: 5423 RVA: 0x000A88A8 File Offset: 0x000A6AA8
		// Note: this type is marked as 'beforefieldinit'.
		static HagalSecrets()
		{
			Il2CppClassPointerStore<HagalSecrets>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.BaseSet", "HagalSecrets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalSecrets>.NativeClassPtr);
			HagalSecrets.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSecrets>.NativeClassPtr, "archID");
			HagalSecrets.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSecrets>.NativeClassPtr, 100666640);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x000A8900 File Offset: 0x000A6B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119478, XrefRangeEnd = 119599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalSecrets()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalSecrets>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSecrets.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0000A1AE File Offset: 0x000083AE
		public HagalSecrets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001532 RID: 5426 RVA: 0x000A893C File Offset: 0x000A6B3C
		// (set) Token: 0x06001533 RID: 5427 RVA: 0x0000A1B7 File Offset: 0x000083B7
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalSecrets.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalSecrets.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
