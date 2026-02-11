using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001C5 RID: 453
	public class GunThopter : WormArchetype
	{
		// Token: 0x06001430 RID: 5168 RVA: 0x000A6334 File Offset: 0x000A4534
		// Note: this type is marked as 'beforefieldinit'.
		static GunThopter()
		{
			Il2CppClassPointerStore<GunThopter>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "GunThopter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GunThopter>.NativeClassPtr);
			GunThopter.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopter>.NativeClassPtr, "archID");
			GunThopter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopter>.NativeClassPtr, 100666538);
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x000A638C File Offset: 0x000A458C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111328, XrefRangeEnd = 111499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GunThopter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GunThopter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00009C4D File Offset: 0x00007E4D
		public GunThopter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x000A63C8 File Offset: 0x000A45C8
		// (set) Token: 0x06001434 RID: 5172 RVA: 0x00009C56 File Offset: 0x00007E56
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GunThopter.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GunThopter.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
