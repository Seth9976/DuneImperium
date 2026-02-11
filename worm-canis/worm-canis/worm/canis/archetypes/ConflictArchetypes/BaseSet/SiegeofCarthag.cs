using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.BaseSet
{
	// Token: 0x0200020B RID: 523
	public class SiegeofCarthag : WormArchetype
	{
		// Token: 0x0600158E RID: 5518 RVA: 0x000A969C File Offset: 0x000A789C
		// Note: this type is marked as 'beforefieldinit'.
		static SiegeofCarthag()
		{
			Il2CppClassPointerStore<SiegeofCarthag>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.BaseSet", "SiegeofCarthag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SiegeofCarthag>.NativeClassPtr);
			SiegeofCarthag.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SiegeofCarthag>.NativeClassPtr, "archID");
			SiegeofCarthag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiegeofCarthag>.NativeClassPtr, 100666678);
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x000A96F4 File Offset: 0x000A78F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121704, XrefRangeEnd = 121837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SiegeofCarthag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SiegeofCarthag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiegeofCarthag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x0000A3AF File Offset: 0x000085AF
		public SiegeofCarthag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x000A9730 File Offset: 0x000A7930
		// (set) Token: 0x06001592 RID: 5522 RVA: 0x0000A3B8 File Offset: 0x000085B8
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SiegeofCarthag.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SiegeofCarthag.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
