using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x020001AB RID: 427
	public class ThroneRoomPolitics : WormArchetype
	{
		// Token: 0x060013AE RID: 5038 RVA: 0x000A501C File Offset: 0x000A321C
		// Note: this type is marked as 'beforefieldinit'.
		static ThroneRoomPolitics()
		{
			Il2CppClassPointerStore<ThroneRoomPolitics>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "ThroneRoomPolitics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThroneRoomPolitics>.NativeClassPtr);
			ThroneRoomPolitics.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThroneRoomPolitics>.NativeClassPtr, "archID");
			ThroneRoomPolitics.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThroneRoomPolitics>.NativeClassPtr, 100666486);
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x000A5074 File Offset: 0x000A3274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106552, XrefRangeEnd = 106751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThroneRoomPolitics()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThroneRoomPolitics>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThroneRoomPolitics.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0000998F File Offset: 0x00007B8F
		public ThroneRoomPolitics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x000A50B0 File Offset: 0x000A32B0
		// (set) Token: 0x060013B2 RID: 5042 RVA: 0x00009998 File Offset: 0x00007B98
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThroneRoomPolitics.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThroneRoomPolitics.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
