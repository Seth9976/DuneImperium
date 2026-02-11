using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.BaseSet
{
	// Token: 0x02000204 RID: 516
	public class DesertPower : WormArchetype
	{
		// Token: 0x0600156B RID: 5483 RVA: 0x000A9178 File Offset: 0x000A7378
		// Note: this type is marked as 'beforefieldinit'.
		static DesertPower()
		{
			Il2CppClassPointerStore<DesertPower>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.BaseSet", "DesertPower");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesertPower>.NativeClassPtr);
			DesertPower.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertPower>.NativeClassPtr, "archID");
			DesertPower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertPower>.NativeClassPtr, 100666664);
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x000A91D0 File Offset: 0x000A73D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120933, XrefRangeEnd = 121038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DesertPower()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesertPower>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertPower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x0000A2F2 File Offset: 0x000084F2
		public DesertPower(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x000A920C File Offset: 0x000A740C
		// (set) Token: 0x0600156F RID: 5487 RVA: 0x0000A2FB File Offset: 0x000084FB
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesertPower.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesertPower.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
