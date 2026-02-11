using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001BD RID: 445
	public class FedaykinDeathCommando : WormArchetype
	{
		// Token: 0x06001408 RID: 5128 RVA: 0x000A5D54 File Offset: 0x000A3F54
		// Note: this type is marked as 'beforefieldinit'.
		static FedaykinDeathCommando()
		{
			Il2CppClassPointerStore<FedaykinDeathCommando>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "FedaykinDeathCommando");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FedaykinDeathCommando>.NativeClassPtr);
			FedaykinDeathCommando.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FedaykinDeathCommando>.NativeClassPtr, "archID");
			FedaykinDeathCommando.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FedaykinDeathCommando>.NativeClassPtr, 100666522);
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x000A5DAC File Offset: 0x000A3FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109772, XrefRangeEnd = 109988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FedaykinDeathCommando()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FedaykinDeathCommando>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FedaykinDeathCommando.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x00009B75 File Offset: 0x00007D75
		public FedaykinDeathCommando(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x000A5DE8 File Offset: 0x000A3FE8
		// (set) Token: 0x0600140C RID: 5132 RVA: 0x00009B7E File Offset: 0x00007D7E
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FedaykinDeathCommando.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FedaykinDeathCommando.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
