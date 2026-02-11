using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x02000177 RID: 375
	public class BountyHunter : WormArchetype
	{
		// Token: 0x060012AA RID: 4778 RVA: 0x000A29EC File Offset: 0x000A0BEC
		// Note: this type is marked as 'beforefieldinit'.
		static BountyHunter()
		{
			Il2CppClassPointerStore<BountyHunter>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "BountyHunter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BountyHunter>.NativeClassPtr);
			BountyHunter.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BountyHunter>.NativeClassPtr, "archID");
			BountyHunter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BountyHunter>.NativeClassPtr, 100666382);
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x000A2A44 File Offset: 0x000A0C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96037, XrefRangeEnd = 96234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BountyHunter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BountyHunter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BountyHunter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00009413 File Offset: 0x00007613
		public BountyHunter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x000A2A80 File Offset: 0x000A0C80
		// (set) Token: 0x060012AE RID: 4782 RVA: 0x0000941C File Offset: 0x0000761C
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BountyHunter.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BountyHunter.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
