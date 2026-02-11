using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000173 RID: 371
	public class WaterofLife : WormArchetype
	{
		// Token: 0x06001296 RID: 4758 RVA: 0x000A26FC File Offset: 0x000A08FC
		// Note: this type is marked as 'beforefieldinit'.
		static WaterofLife()
		{
			Il2CppClassPointerStore<WaterofLife>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "WaterofLife");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterofLife>.NativeClassPtr);
			WaterofLife.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterofLife>.NativeClassPtr, "archID");
			WaterofLife.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterofLife>.NativeClassPtr, 100666374);
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x000A2754 File Offset: 0x000A0954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95510, XrefRangeEnd = 95616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterofLife()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterofLife>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterofLife.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x000093A7 File Offset: 0x000075A7
		public WaterofLife(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x000A2790 File Offset: 0x000A0990
		// (set) Token: 0x0600129A RID: 4762 RVA: 0x000093B0 File Offset: 0x000075B0
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WaterofLife.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaterofLife.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
