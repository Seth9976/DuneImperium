using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x020001A1 RID: 417
	public class LongReach : WormArchetype
	{
		// Token: 0x0600137C RID: 4988 RVA: 0x000A48C4 File Offset: 0x000A2AC4
		// Note: this type is marked as 'beforefieldinit'.
		static LongReach()
		{
			Il2CppClassPointerStore<LongReach>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "LongReach");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LongReach>.NativeClassPtr);
			LongReach.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongReach>.NativeClassPtr, "archID");
			LongReach.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongReach>.NativeClassPtr, 100666466);
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x000A491C File Offset: 0x000A2B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104480, XrefRangeEnd = 104691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LongReach()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LongReach>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongReach.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00009881 File Offset: 0x00007A81
		public LongReach(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x000A4958 File Offset: 0x000A2B58
		// (set) Token: 0x06001380 RID: 4992 RVA: 0x0000988A File Offset: 0x00007A8A
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LongReach.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LongReach.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
