using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.RiseOfIx
{
	// Token: 0x0200010F RID: 271
	public class InterstellarShipping : WormArchetype
	{
		// Token: 0x060010A2 RID: 4258 RVA: 0x0009DD8C File Offset: 0x0009BF8C
		// Note: this type is marked as 'beforefieldinit'.
		static InterstellarShipping()
		{
			Il2CppClassPointerStore<InterstellarShipping>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.RiseOfIx", "InterstellarShipping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InterstellarShipping>.NativeClassPtr);
			InterstellarShipping.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterstellarShipping>.NativeClassPtr, "archID");
			InterstellarShipping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterstellarShipping>.NativeClassPtr, 100666174);
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x0009DDE4 File Offset: 0x0009BFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83724, XrefRangeEnd = 83844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InterstellarShipping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterstellarShipping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterstellarShipping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x0000891B File Offset: 0x00006B1B
		public InterstellarShipping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x0009DE20 File Offset: 0x0009C020
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x00008924 File Offset: 0x00006B24
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InterstellarShipping.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InterstellarShipping.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
