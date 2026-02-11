using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x02000186 RID: 390
	public class IxianEngineer : WormArchetype
	{
		// Token: 0x060012F5 RID: 4853 RVA: 0x000A34F0 File Offset: 0x000A16F0
		// Note: this type is marked as 'beforefieldinit'.
		static IxianEngineer()
		{
			Il2CppClassPointerStore<IxianEngineer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "IxianEngineer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IxianEngineer>.NativeClassPtr);
			IxianEngineer.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IxianEngineer>.NativeClassPtr, "archID");
			IxianEngineer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IxianEngineer>.NativeClassPtr, 100666412);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x000A3548 File Offset: 0x000A1748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99050, XrefRangeEnd = 99236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IxianEngineer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IxianEngineer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IxianEngineer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x000095A8 File Offset: 0x000077A8
		public IxianEngineer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x000A3584 File Offset: 0x000A1784
		// (set) Token: 0x060012F9 RID: 4857 RVA: 0x000095B1 File Offset: 0x000077B1
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IxianEngineer.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IxianEngineer.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
