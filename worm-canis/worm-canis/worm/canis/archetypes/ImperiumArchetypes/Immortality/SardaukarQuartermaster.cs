using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x020001A6 RID: 422
	public class SardaukarQuartermaster : WormArchetype
	{
		// Token: 0x06001395 RID: 5013 RVA: 0x000A4C70 File Offset: 0x000A2E70
		// Note: this type is marked as 'beforefieldinit'.
		static SardaukarQuartermaster()
		{
			Il2CppClassPointerStore<SardaukarQuartermaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "SardaukarQuartermaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SardaukarQuartermaster>.NativeClassPtr);
			SardaukarQuartermaster.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SardaukarQuartermaster>.NativeClassPtr, "archID");
			SardaukarQuartermaster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SardaukarQuartermaster>.NativeClassPtr, 100666476);
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x000A4CC8 File Offset: 0x000A2EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105532, XrefRangeEnd = 105745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SardaukarQuartermaster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SardaukarQuartermaster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SardaukarQuartermaster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x00009908 File Offset: 0x00007B08
		public SardaukarQuartermaster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x000A4D04 File Offset: 0x000A2F04
		// (set) Token: 0x06001399 RID: 5017 RVA: 0x00009911 File Offset: 0x00007B11
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SardaukarQuartermaster.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SardaukarQuartermaster.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
