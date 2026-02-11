using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001C4 RID: 452
	public class GuildBankers : WormArchetype
	{
		// Token: 0x0600142B RID: 5163 RVA: 0x000A6278 File Offset: 0x000A4478
		// Note: this type is marked as 'beforefieldinit'.
		static GuildBankers()
		{
			Il2CppClassPointerStore<GuildBankers>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "GuildBankers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuildBankers>.NativeClassPtr);
			GuildBankers.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildBankers>.NativeClassPtr, "archID");
			GuildBankers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildBankers>.NativeClassPtr, 100666536);
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x000A62D0 File Offset: 0x000A44D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111144, XrefRangeEnd = 111328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuildBankers()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuildBankers>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildBankers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00009C32 File Offset: 0x00007E32
		public GuildBankers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x000A630C File Offset: 0x000A450C
		// (set) Token: 0x0600142F RID: 5167 RVA: 0x00009C3B File Offset: 0x00007E3B
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GuildBankers.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuildBankers.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
