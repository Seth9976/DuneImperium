using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TleilaxuArchetypes.Immortality
{
	// Token: 0x020000EF RID: 239
	public class FromtheTanks : WormArchetype
	{
		// Token: 0x06001002 RID: 4098 RVA: 0x0009C60C File Offset: 0x0009A80C
		// Note: this type is marked as 'beforefieldinit'.
		static FromtheTanks()
		{
			Il2CppClassPointerStore<FromtheTanks>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TleilaxuArchetypes.Immortality", "FromtheTanks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FromtheTanks>.NativeClassPtr);
			FromtheTanks.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FromtheTanks>.NativeClassPtr, "archID");
			FromtheTanks.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FromtheTanks>.NativeClassPtr, 100666110);
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0009C664 File Offset: 0x0009A864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79322, XrefRangeEnd = 79467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FromtheTanks()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FromtheTanks>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FromtheTanks.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x000085BB File Offset: 0x000067BB
		public FromtheTanks(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x0009C6A0 File Offset: 0x0009A8A0
		// (set) Token: 0x06001006 RID: 4102 RVA: 0x000085C4 File Offset: 0x000067C4
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FromtheTanks.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FromtheTanks.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
