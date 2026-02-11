using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000164 RID: 356
	public class KnowTheirWays : WormArchetype
	{
		// Token: 0x0600124B RID: 4683 RVA: 0x000A1BF8 File Offset: 0x0009FDF8
		// Note: this type is marked as 'beforefieldinit'.
		static KnowTheirWays()
		{
			Il2CppClassPointerStore<KnowTheirWays>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "KnowTheirWays");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnowTheirWays>.NativeClassPtr);
			KnowTheirWays.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnowTheirWays>.NativeClassPtr, "archID");
			KnowTheirWays.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnowTheirWays>.NativeClassPtr, 100666344);
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x000A1C50 File Offset: 0x0009FE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93864, XrefRangeEnd = 93978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KnowTheirWays()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KnowTheirWays>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnowTheirWays.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00009212 File Offset: 0x00007412
		public KnowTheirWays(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x000A1C8C File Offset: 0x0009FE8C
		// (set) Token: 0x0600124F RID: 4687 RVA: 0x0000921B File Offset: 0x0000741B
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KnowTheirWays.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KnowTheirWays.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
