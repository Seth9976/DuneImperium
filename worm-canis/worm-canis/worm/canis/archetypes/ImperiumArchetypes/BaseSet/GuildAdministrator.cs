using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001C2 RID: 450
	public class GuildAdministrator : WormArchetype
	{
		// Token: 0x06001421 RID: 5153 RVA: 0x000A6100 File Offset: 0x000A4300
		// Note: this type is marked as 'beforefieldinit'.
		static GuildAdministrator()
		{
			Il2CppClassPointerStore<GuildAdministrator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "GuildAdministrator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuildAdministrator>.NativeClassPtr);
			GuildAdministrator.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildAdministrator>.NativeClassPtr, "archID");
			GuildAdministrator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAdministrator>.NativeClassPtr, 100666532);
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x000A6158 File Offset: 0x000A4358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110749, XrefRangeEnd = 110944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuildAdministrator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuildAdministrator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildAdministrator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x00009BFC File Offset: 0x00007DFC
		public GuildAdministrator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x000A6194 File Offset: 0x000A4394
		// (set) Token: 0x06001425 RID: 5157 RVA: 0x00009C05 File Offset: 0x00007E05
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GuildAdministrator.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuildAdministrator.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
