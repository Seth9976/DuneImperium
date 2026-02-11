using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000162 RID: 354
	public class GuildAuthorization : WormArchetype
	{
		// Token: 0x06001241 RID: 4673 RVA: 0x000A1A80 File Offset: 0x0009FC80
		// Note: this type is marked as 'beforefieldinit'.
		static GuildAuthorization()
		{
			Il2CppClassPointerStore<GuildAuthorization>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "GuildAuthorization");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuildAuthorization>.NativeClassPtr);
			GuildAuthorization.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildAuthorization>.NativeClassPtr, "archID");
			GuildAuthorization.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAuthorization>.NativeClassPtr, 100666340);
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x000A1AD8 File Offset: 0x0009FCD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93649, XrefRangeEnd = 93763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuildAuthorization()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuildAuthorization>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildAuthorization.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x000091DC File Offset: 0x000073DC
		public GuildAuthorization(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x000A1B14 File Offset: 0x0009FD14
		// (set) Token: 0x06001245 RID: 4677 RVA: 0x000091E5 File Offset: 0x000073E5
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GuildAuthorization.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuildAuthorization.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
