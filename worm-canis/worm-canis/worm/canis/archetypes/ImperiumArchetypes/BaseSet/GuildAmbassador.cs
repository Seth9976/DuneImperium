using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001C3 RID: 451
	public class GuildAmbassador : WormArchetype
	{
		// Token: 0x06001426 RID: 5158 RVA: 0x000A61BC File Offset: 0x000A43BC
		// Note: this type is marked as 'beforefieldinit'.
		static GuildAmbassador()
		{
			Il2CppClassPointerStore<GuildAmbassador>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "GuildAmbassador");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuildAmbassador>.NativeClassPtr);
			GuildAmbassador.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildAmbassador>.NativeClassPtr, "archID");
			GuildAmbassador.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAmbassador>.NativeClassPtr, 100666534);
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x000A6214 File Offset: 0x000A4414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110944, XrefRangeEnd = 111144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuildAmbassador()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuildAmbassador>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildAmbassador.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x00009C17 File Offset: 0x00007E17
		public GuildAmbassador(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x000A6250 File Offset: 0x000A4450
		// (set) Token: 0x0600142A RID: 5162 RVA: 0x00009C20 File Offset: 0x00007E20
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GuildAmbassador.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuildAmbassador.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
