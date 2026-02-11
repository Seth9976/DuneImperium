using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000163 RID: 355
	public class Infiltrate : WormArchetype
	{
		// Token: 0x06001246 RID: 4678 RVA: 0x000A1B3C File Offset: 0x0009FD3C
		// Note: this type is marked as 'beforefieldinit'.
		static Infiltrate()
		{
			Il2CppClassPointerStore<Infiltrate>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "Infiltrate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Infiltrate>.NativeClassPtr);
			Infiltrate.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Infiltrate>.NativeClassPtr, "archID");
			Infiltrate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Infiltrate>.NativeClassPtr, 100666342);
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x000A1B94 File Offset: 0x0009FD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93763, XrefRangeEnd = 93864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Infiltrate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Infiltrate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Infiltrate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x000091F7 File Offset: 0x000073F7
		public Infiltrate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x000A1BD0 File Offset: 0x0009FDD0
		// (set) Token: 0x0600124A RID: 4682 RVA: 0x00009200 File Offset: 0x00007400
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Infiltrate.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Infiltrate.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
