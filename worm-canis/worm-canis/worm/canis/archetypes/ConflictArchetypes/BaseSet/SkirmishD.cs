using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.BaseSet
{
	// Token: 0x0200020F RID: 527
	public class SkirmishD : WormArchetype
	{
		// Token: 0x060015A2 RID: 5538 RVA: 0x000A998C File Offset: 0x000A7B8C
		// Note: this type is marked as 'beforefieldinit'.
		static SkirmishD()
		{
			Il2CppClassPointerStore<SkirmishD>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.BaseSet", "SkirmishD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishD>.NativeClassPtr);
			SkirmishD.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishD>.NativeClassPtr, "archID");
			SkirmishD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishD>.NativeClassPtr, 100666686);
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x000A99E4 File Offset: 0x000A7BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122147, XrefRangeEnd = 122247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkirmishD()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkirmishD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x0000A41B File Offset: 0x0000861B
		public SkirmishD(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060015A5 RID: 5541 RVA: 0x000A9A20 File Offset: 0x000A7C20
		// (set) Token: 0x060015A6 RID: 5542 RVA: 0x0000A424 File Offset: 0x00008624
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SkirmishD.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkirmishD.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
