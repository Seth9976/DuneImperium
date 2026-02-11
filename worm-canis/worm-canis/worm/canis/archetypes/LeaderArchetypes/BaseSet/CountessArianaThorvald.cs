using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.LeaderArchetypes.BaseSet
{
	// Token: 0x02000131 RID: 305
	public class CountessArianaThorvald : WormArchetype
	{
		// Token: 0x0600114C RID: 4428 RVA: 0x0009F684 File Offset: 0x0009D884
		// Note: this type is marked as 'beforefieldinit'.
		static CountessArianaThorvald()
		{
			Il2CppClassPointerStore<CountessArianaThorvald>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.LeaderArchetypes.BaseSet", "CountessArianaThorvald");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountessArianaThorvald>.NativeClassPtr);
			CountessArianaThorvald.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountessArianaThorvald>.NativeClassPtr, "archID");
			CountessArianaThorvald.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountessArianaThorvald>.NativeClassPtr, 100666242);
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x0009F6DC File Offset: 0x0009D8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88076, XrefRangeEnd = 88199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CountessArianaThorvald()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CountessArianaThorvald>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountessArianaThorvald.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x00008CB1 File Offset: 0x00006EB1
		public CountessArianaThorvald(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x0009F718 File Offset: 0x0009D918
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x00008CBA File Offset: 0x00006EBA
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CountessArianaThorvald.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CountessArianaThorvald.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
