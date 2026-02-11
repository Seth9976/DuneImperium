using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.BaseSet
{
	// Token: 0x0200020A RID: 522
	public class SiegeofArrakeen : WormArchetype
	{
		// Token: 0x06001589 RID: 5513 RVA: 0x000A95E0 File Offset: 0x000A77E0
		// Note: this type is marked as 'beforefieldinit'.
		static SiegeofArrakeen()
		{
			Il2CppClassPointerStore<SiegeofArrakeen>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.BaseSet", "SiegeofArrakeen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SiegeofArrakeen>.NativeClassPtr);
			SiegeofArrakeen.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SiegeofArrakeen>.NativeClassPtr, "archID");
			SiegeofArrakeen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SiegeofArrakeen>.NativeClassPtr, 100666676);
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x000A9638 File Offset: 0x000A7838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121571, XrefRangeEnd = 121704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SiegeofArrakeen()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SiegeofArrakeen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SiegeofArrakeen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x0000A394 File Offset: 0x00008594
		public SiegeofArrakeen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x000A9674 File Offset: 0x000A7874
		// (set) Token: 0x0600158D RID: 5517 RVA: 0x0000A39D File Offset: 0x0000859D
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SiegeofArrakeen.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SiegeofArrakeen.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
