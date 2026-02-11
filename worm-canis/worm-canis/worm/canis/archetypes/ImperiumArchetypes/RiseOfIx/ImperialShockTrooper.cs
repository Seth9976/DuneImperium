using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x02000183 RID: 387
	public class ImperialShockTrooper : WormArchetype
	{
		// Token: 0x060012E6 RID: 4838 RVA: 0x000A32BC File Offset: 0x000A14BC
		// Note: this type is marked as 'beforefieldinit'.
		static ImperialShockTrooper()
		{
			Il2CppClassPointerStore<ImperialShockTrooper>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "ImperialShockTrooper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImperialShockTrooper>.NativeClassPtr);
			ImperialShockTrooper.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImperialShockTrooper>.NativeClassPtr, "archID");
			ImperialShockTrooper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImperialShockTrooper>.NativeClassPtr, 100666406);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x000A3314 File Offset: 0x000A1514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98474, XrefRangeEnd = 98633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImperialShockTrooper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImperialShockTrooper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImperialShockTrooper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00009557 File Offset: 0x00007757
		public ImperialShockTrooper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x000A3350 File Offset: 0x000A1550
		// (set) Token: 0x060012EA RID: 4842 RVA: 0x00009560 File Offset: 0x00007760
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImperialShockTrooper.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImperialShockTrooper.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
