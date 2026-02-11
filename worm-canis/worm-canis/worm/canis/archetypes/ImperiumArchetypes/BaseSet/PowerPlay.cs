using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001CF RID: 463
	public class PowerPlay : WormArchetype
	{
		// Token: 0x06001462 RID: 5218 RVA: 0x000A6A8C File Offset: 0x000A4C8C
		// Note: this type is marked as 'beforefieldinit'.
		static PowerPlay()
		{
			Il2CppClassPointerStore<PowerPlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "PowerPlay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerPlay>.NativeClassPtr);
			PowerPlay.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerPlay>.NativeClassPtr, "archID");
			PowerPlay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerPlay>.NativeClassPtr, 100666558);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x000A6AE4 File Offset: 0x000A4CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113306, XrefRangeEnd = 113488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerPlay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerPlay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerPlay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00009D5B File Offset: 0x00007F5B
		public PowerPlay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001465 RID: 5221 RVA: 0x000A6B20 File Offset: 0x000A4D20
		// (set) Token: 0x06001466 RID: 5222 RVA: 0x00009D64 File Offset: 0x00007F64
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PowerPlay.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PowerPlay.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
