using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000170 RID: 368
	public class Tiebreaker : WormArchetype
	{
		// Token: 0x06001287 RID: 4743 RVA: 0x000A24C8 File Offset: 0x000A06C8
		// Note: this type is marked as 'beforefieldinit'.
		static Tiebreaker()
		{
			Il2CppClassPointerStore<Tiebreaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "Tiebreaker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tiebreaker>.NativeClassPtr);
			Tiebreaker.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tiebreaker>.NativeClassPtr, "archID");
			Tiebreaker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tiebreaker>.NativeClassPtr, 100666368);
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x000A2520 File Offset: 0x000A0720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95169, XrefRangeEnd = 95294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tiebreaker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tiebreaker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tiebreaker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x00009356 File Offset: 0x00007556
		public Tiebreaker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x000A255C File Offset: 0x000A075C
		// (set) Token: 0x0600128B RID: 4747 RVA: 0x0000935F File Offset: 0x0000755F
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Tiebreaker.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Tiebreaker.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
