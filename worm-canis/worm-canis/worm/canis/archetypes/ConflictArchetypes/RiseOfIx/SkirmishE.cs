using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.RiseOfIx
{
	// Token: 0x020001FD RID: 509
	public class SkirmishE : WormArchetype
	{
		// Token: 0x06001548 RID: 5448 RVA: 0x000A8C54 File Offset: 0x000A6E54
		// Note: this type is marked as 'beforefieldinit'.
		static SkirmishE()
		{
			Il2CppClassPointerStore<SkirmishE>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.RiseOfIx", "SkirmishE");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishE>.NativeClassPtr);
			SkirmishE.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishE>.NativeClassPtr, "archID");
			SkirmishE.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishE>.NativeClassPtr, 100666650);
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x000A8CAC File Offset: 0x000A6EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120092, XrefRangeEnd = 120206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkirmishE()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkirmishE>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishE.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0000A235 File Offset: 0x00008435
		public SkirmishE(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x000A8CE8 File Offset: 0x000A6EE8
		// (set) Token: 0x0600154C RID: 5452 RVA: 0x0000A23E File Offset: 0x0000843E
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SkirmishE.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkirmishE.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
