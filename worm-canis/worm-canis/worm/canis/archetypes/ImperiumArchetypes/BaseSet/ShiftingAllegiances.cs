using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001D6 RID: 470
	public class ShiftingAllegiances : WormArchetype
	{
		// Token: 0x06001485 RID: 5253 RVA: 0x000A6FB0 File Offset: 0x000A51B0
		// Note: this type is marked as 'beforefieldinit'.
		static ShiftingAllegiances()
		{
			Il2CppClassPointerStore<ShiftingAllegiances>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "ShiftingAllegiances");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShiftingAllegiances>.NativeClassPtr);
			ShiftingAllegiances.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShiftingAllegiances>.NativeClassPtr, "archID");
			ShiftingAllegiances.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShiftingAllegiances>.NativeClassPtr, 100666572);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x000A7008 File Offset: 0x000A5208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114536, XrefRangeEnd = 114717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShiftingAllegiances()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShiftingAllegiances>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShiftingAllegiances.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x00009E18 File Offset: 0x00008018
		public ShiftingAllegiances(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x000A7044 File Offset: 0x000A5244
		// (set) Token: 0x06001489 RID: 5257 RVA: 0x00009E21 File Offset: 0x00008021
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShiftingAllegiances.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShiftingAllegiances.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
