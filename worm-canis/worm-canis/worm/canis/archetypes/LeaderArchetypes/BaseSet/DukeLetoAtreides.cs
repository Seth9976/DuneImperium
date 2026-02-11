using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.LeaderArchetypes.BaseSet
{
	// Token: 0x02000133 RID: 307
	public class DukeLetoAtreides : WormArchetype
	{
		// Token: 0x06001156 RID: 4438 RVA: 0x0009F7FC File Offset: 0x0009D9FC
		// Note: this type is marked as 'beforefieldinit'.
		static DukeLetoAtreides()
		{
			Il2CppClassPointerStore<DukeLetoAtreides>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.LeaderArchetypes.BaseSet", "DukeLetoAtreides");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DukeLetoAtreides>.NativeClassPtr);
			DukeLetoAtreides.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DukeLetoAtreides>.NativeClassPtr, "archID");
			DukeLetoAtreides.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DukeLetoAtreides>.NativeClassPtr, 100666246);
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x0009F854 File Offset: 0x0009DA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88313, XrefRangeEnd = 88418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DukeLetoAtreides()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DukeLetoAtreides>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DukeLetoAtreides.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00008CE7 File Offset: 0x00006EE7
		public DukeLetoAtreides(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x0009F890 File Offset: 0x0009DA90
		// (set) Token: 0x0600115A RID: 4442 RVA: 0x00008CF0 File Offset: 0x00006EF0
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DukeLetoAtreides.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DukeLetoAtreides.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
