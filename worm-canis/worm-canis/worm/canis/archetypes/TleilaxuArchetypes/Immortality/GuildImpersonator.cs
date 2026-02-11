using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TleilaxuArchetypes.Immortality
{
	// Token: 0x020000F1 RID: 241
	public class GuildImpersonator : WormArchetype
	{
		// Token: 0x0600100C RID: 4108 RVA: 0x0009C784 File Offset: 0x0009A984
		// Note: this type is marked as 'beforefieldinit'.
		static GuildImpersonator()
		{
			Il2CppClassPointerStore<GuildImpersonator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TleilaxuArchetypes.Immortality", "GuildImpersonator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuildImpersonator>.NativeClassPtr);
			GuildImpersonator.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildImpersonator>.NativeClassPtr, "archID");
			GuildImpersonator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildImpersonator>.NativeClassPtr, 100666114);
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0009C7DC File Offset: 0x0009A9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79631, XrefRangeEnd = 79821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuildImpersonator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuildImpersonator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildImpersonator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x000085F1 File Offset: 0x000067F1
		public GuildImpersonator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x0009C818 File Offset: 0x0009AA18
		// (set) Token: 0x06001010 RID: 4112 RVA: 0x000085FA File Offset: 0x000067FA
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GuildImpersonator.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuildImpersonator.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
