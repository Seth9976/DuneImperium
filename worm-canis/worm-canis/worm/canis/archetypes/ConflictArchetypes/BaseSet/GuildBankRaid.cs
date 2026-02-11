using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.BaseSet
{
	// Token: 0x02000206 RID: 518
	public class GuildBankRaid : WormArchetype
	{
		// Token: 0x06001575 RID: 5493 RVA: 0x000A92F0 File Offset: 0x000A74F0
		// Note: this type is marked as 'beforefieldinit'.
		static GuildBankRaid()
		{
			Il2CppClassPointerStore<GuildBankRaid>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.BaseSet", "GuildBankRaid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuildBankRaid>.NativeClassPtr);
			GuildBankRaid.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildBankRaid>.NativeClassPtr, "archID");
			GuildBankRaid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildBankRaid>.NativeClassPtr, 100666668);
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x000A9348 File Offset: 0x000A7548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121138, XrefRangeEnd = 121238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuildBankRaid()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuildBankRaid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildBankRaid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x0000A328 File Offset: 0x00008528
		public GuildBankRaid(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x000A9384 File Offset: 0x000A7584
		// (set) Token: 0x06001579 RID: 5497 RVA: 0x0000A331 File Offset: 0x00008531
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GuildBankRaid.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuildBankRaid.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
