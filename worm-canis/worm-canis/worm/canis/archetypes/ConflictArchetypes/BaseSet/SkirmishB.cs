using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.BaseSet
{
	// Token: 0x0200020D RID: 525
	public class SkirmishB : WormArchetype
	{
		// Token: 0x06001598 RID: 5528 RVA: 0x000A9814 File Offset: 0x000A7A14
		// Note: this type is marked as 'beforefieldinit'.
		static SkirmishB()
		{
			Il2CppClassPointerStore<SkirmishB>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.BaseSet", "SkirmishB");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishB>.NativeClassPtr);
			SkirmishB.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishB>.NativeClassPtr, "archID");
			SkirmishB.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishB>.NativeClassPtr, 100666682);
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x000A986C File Offset: 0x000A7A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121942, XrefRangeEnd = 122047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkirmishB()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkirmishB>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishB.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x0000A3E5 File Offset: 0x000085E5
		public SkirmishB(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x000A98A8 File Offset: 0x000A7AA8
		// (set) Token: 0x0600159C RID: 5532 RVA: 0x0000A3EE File Offset: 0x000085EE
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SkirmishB.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkirmishB.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
