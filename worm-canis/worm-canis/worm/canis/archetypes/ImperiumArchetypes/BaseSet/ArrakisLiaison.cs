using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001AE RID: 430
	public class ArrakisLiaison : WormArchetype
	{
		// Token: 0x060013BD RID: 5053 RVA: 0x000A5250 File Offset: 0x000A3450
		// Note: this type is marked as 'beforefieldinit'.
		static ArrakisLiaison()
		{
			Il2CppClassPointerStore<ArrakisLiaison>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "ArrakisLiaison");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrakisLiaison>.NativeClassPtr);
			ArrakisLiaison.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrakisLiaison>.NativeClassPtr, "archID");
			ArrakisLiaison.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrakisLiaison>.NativeClassPtr, 100666492);
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x000A52A8 File Offset: 0x000A34A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107150, XrefRangeEnd = 107326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrakisLiaison()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrakisLiaison>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrakisLiaison.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x000099E0 File Offset: 0x00007BE0
		public ArrakisLiaison(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x000A52E4 File Offset: 0x000A34E4
		// (set) Token: 0x060013C1 RID: 5057 RVA: 0x000099E9 File Offset: 0x00007BE9
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ArrakisLiaison.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArrakisLiaison.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
