using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.LeaderArchetypes.BaseSet
{
	// Token: 0x02000137 RID: 311
	public class PaulAtreides : WormArchetype
	{
		// Token: 0x0600116A RID: 4458 RVA: 0x0009FAEC File Offset: 0x0009DCEC
		// Note: this type is marked as 'beforefieldinit'.
		static PaulAtreides()
		{
			Il2CppClassPointerStore<PaulAtreides>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.LeaderArchetypes.BaseSet", "PaulAtreides");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaulAtreides>.NativeClassPtr);
			PaulAtreides.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaulAtreides>.NativeClassPtr, "archID");
			PaulAtreides.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaulAtreides>.NativeClassPtr, 100666254);
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x0009FB44 File Offset: 0x0009DD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88726, XrefRangeEnd = 88824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PaulAtreides()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PaulAtreides>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaulAtreides.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x00008D53 File Offset: 0x00006F53
		public PaulAtreides(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x0009FB80 File Offset: 0x0009DD80
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x00008D5C File Offset: 0x00006F5C
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PaulAtreides.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PaulAtreides.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
