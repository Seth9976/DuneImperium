using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000155 RID: 341
	public class Ambush : WormArchetype
	{
		// Token: 0x06001200 RID: 4608 RVA: 0x000A10F4 File Offset: 0x0009F2F4
		// Note: this type is marked as 'beforefieldinit'.
		static Ambush()
		{
			Il2CppClassPointerStore<Ambush>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "Ambush");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ambush>.NativeClassPtr);
			Ambush.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ambush>.NativeClassPtr, "archID");
			Ambush.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ambush>.NativeClassPtr, 100666314);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x000A114C File Offset: 0x0009F34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92259, XrefRangeEnd = 92372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ambush()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ambush>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ambush.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x0000907D File Offset: 0x0000727D
		public Ambush(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x000A1188 File Offset: 0x0009F388
		// (set) Token: 0x06001204 RID: 4612 RVA: 0x00009086 File Offset: 0x00007286
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Ambush.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Ambush.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
