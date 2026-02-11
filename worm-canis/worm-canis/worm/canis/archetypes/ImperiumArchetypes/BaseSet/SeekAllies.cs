using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001D5 RID: 469
	public class SeekAllies : WormArchetype
	{
		// Token: 0x06001480 RID: 5248 RVA: 0x000A6EF4 File Offset: 0x000A50F4
		// Note: this type is marked as 'beforefieldinit'.
		static SeekAllies()
		{
			Il2CppClassPointerStore<SeekAllies>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "SeekAllies");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SeekAllies>.NativeClassPtr);
			SeekAllies.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeekAllies>.NativeClassPtr, "archID");
			SeekAllies.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeekAllies>.NativeClassPtr, 100666570);
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x000A6F4C File Offset: 0x000A514C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114385, XrefRangeEnd = 114536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SeekAllies()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SeekAllies>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SeekAllies.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x00009DFD File Offset: 0x00007FFD
		public SeekAllies(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x000A6F88 File Offset: 0x000A5188
		// (set) Token: 0x06001484 RID: 5252 RVA: 0x00009E06 File Offset: 0x00008006
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SeekAllies.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SeekAllies.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
