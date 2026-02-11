using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x0200016F RID: 367
	public class TheSleeperMustAwaken : WormArchetype
	{
		// Token: 0x06001282 RID: 4738 RVA: 0x000A240C File Offset: 0x000A060C
		// Note: this type is marked as 'beforefieldinit'.
		static TheSleeperMustAwaken()
		{
			Il2CppClassPointerStore<TheSleeperMustAwaken>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "TheSleeperMustAwaken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TheSleeperMustAwaken>.NativeClassPtr);
			TheSleeperMustAwaken.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheSleeperMustAwaken>.NativeClassPtr, "archID");
			TheSleeperMustAwaken.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheSleeperMustAwaken>.NativeClassPtr, 100666366);
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x000A2464 File Offset: 0x000A0664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95068, XrefRangeEnd = 95169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TheSleeperMustAwaken()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TheSleeperMustAwaken>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TheSleeperMustAwaken.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x0000933B File Offset: 0x0000753B
		public TheSleeperMustAwaken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x000A24A0 File Offset: 0x000A06A0
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x00009344 File Offset: 0x00007544
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TheSleeperMustAwaken.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TheSleeperMustAwaken.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
