using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000168 RID: 360
	public class PrivateArmy : WormArchetype
	{
		// Token: 0x0600125F RID: 4703 RVA: 0x000A1EE8 File Offset: 0x000A00E8
		// Note: this type is marked as 'beforefieldinit'.
		static PrivateArmy()
		{
			Il2CppClassPointerStore<PrivateArmy>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "PrivateArmy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrivateArmy>.NativeClassPtr);
			PrivateArmy.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrivateArmy>.NativeClassPtr, "archID");
			PrivateArmy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrivateArmy>.NativeClassPtr, 100666352);
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x000A1F40 File Offset: 0x000A0140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94312, XrefRangeEnd = 94425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrivateArmy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrivateArmy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrivateArmy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x0000927E File Offset: 0x0000747E
		public PrivateArmy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x000A1F7C File Offset: 0x000A017C
		// (set) Token: 0x06001263 RID: 4707 RVA: 0x00009287 File Offset: 0x00007487
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PrivateArmy.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PrivateArmy.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
