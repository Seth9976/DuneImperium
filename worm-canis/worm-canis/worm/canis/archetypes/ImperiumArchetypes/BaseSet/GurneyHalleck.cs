using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001C6 RID: 454
	public class GurneyHalleck : WormArchetype
	{
		// Token: 0x06001435 RID: 5173 RVA: 0x000A63F0 File Offset: 0x000A45F0
		// Note: this type is marked as 'beforefieldinit'.
		static GurneyHalleck()
		{
			Il2CppClassPointerStore<GurneyHalleck>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "GurneyHalleck");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GurneyHalleck>.NativeClassPtr);
			GurneyHalleck.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GurneyHalleck>.NativeClassPtr, "archID");
			GurneyHalleck.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GurneyHalleck>.NativeClassPtr, 100666540);
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x000A6448 File Offset: 0x000A4648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111499, XrefRangeEnd = 111705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GurneyHalleck()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GurneyHalleck>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GurneyHalleck.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00009C68 File Offset: 0x00007E68
		public GurneyHalleck(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x000A6484 File Offset: 0x000A4684
		// (set) Token: 0x06001439 RID: 5177 RVA: 0x00009C71 File Offset: 0x00007E71
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GurneyHalleck.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GurneyHalleck.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
