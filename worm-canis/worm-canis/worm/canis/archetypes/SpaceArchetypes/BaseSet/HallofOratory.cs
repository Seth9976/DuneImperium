using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x02000118 RID: 280
	public class HallofOratory : WormArchetype
	{
		// Token: 0x060010CF RID: 4303 RVA: 0x0009E428 File Offset: 0x0009C628
		// Note: this type is marked as 'beforefieldinit'.
		static HallofOratory()
		{
			Il2CppClassPointerStore<HallofOratory>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "HallofOratory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HallofOratory>.NativeClassPtr);
			HallofOratory.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HallofOratory>.NativeClassPtr, "archID");
			HallofOratory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HallofOratory>.NativeClassPtr, 100666192);
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0009E480 File Offset: 0x0009C680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84978, XrefRangeEnd = 85093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HallofOratory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HallofOratory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HallofOratory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x00008A0E File Offset: 0x00006C0E
		public HallofOratory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060010D2 RID: 4306 RVA: 0x0009E4BC File Offset: 0x0009C6BC
		// (set) Token: 0x060010D3 RID: 4307 RVA: 0x00008A17 File Offset: 0x00006C17
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HallofOratory.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HallofOratory.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
