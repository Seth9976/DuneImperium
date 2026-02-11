using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x0200019C RID: 412
	public class HighPriorityTravel : WormArchetype
	{
		// Token: 0x06001363 RID: 4963 RVA: 0x000A4518 File Offset: 0x000A2718
		// Note: this type is marked as 'beforefieldinit'.
		static HighPriorityTravel()
		{
			Il2CppClassPointerStore<HighPriorityTravel>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "HighPriorityTravel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HighPriorityTravel>.NativeClassPtr);
			HighPriorityTravel.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighPriorityTravel>.NativeClassPtr, "archID");
			HighPriorityTravel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighPriorityTravel>.NativeClassPtr, 100666456);
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x000A4570 File Offset: 0x000A2770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103448, XrefRangeEnd = 103664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HighPriorityTravel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HighPriorityTravel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighPriorityTravel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x000097FA File Offset: 0x000079FA
		public HighPriorityTravel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x000A45AC File Offset: 0x000A27AC
		// (set) Token: 0x06001367 RID: 4967 RVA: 0x00009803 File Offset: 0x00007A03
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HighPriorityTravel.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HighPriorityTravel.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
