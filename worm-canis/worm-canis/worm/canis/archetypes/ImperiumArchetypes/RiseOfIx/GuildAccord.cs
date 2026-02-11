using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x02000180 RID: 384
	public class GuildAccord : WormArchetype
	{
		// Token: 0x060012D7 RID: 4823 RVA: 0x000A3088 File Offset: 0x000A1288
		// Note: this type is marked as 'beforefieldinit'.
		static GuildAccord()
		{
			Il2CppClassPointerStore<GuildAccord>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "GuildAccord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuildAccord>.NativeClassPtr);
			GuildAccord.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildAccord>.NativeClassPtr, "archID");
			GuildAccord.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAccord>.NativeClassPtr, 100666400);
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x000A30E0 File Offset: 0x000A12E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97833, XrefRangeEnd = 98054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuildAccord()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuildAccord>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildAccord.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00009506 File Offset: 0x00007706
		public GuildAccord(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x000A311C File Offset: 0x000A131C
		// (set) Token: 0x060012DB RID: 4827 RVA: 0x0000950F File Offset: 0x0000770F
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GuildAccord.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuildAccord.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
