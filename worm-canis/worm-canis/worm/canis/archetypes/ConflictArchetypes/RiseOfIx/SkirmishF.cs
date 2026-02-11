using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.RiseOfIx
{
	// Token: 0x020001FE RID: 510
	public class SkirmishF : WormArchetype
	{
		// Token: 0x0600154D RID: 5453 RVA: 0x000A8D10 File Offset: 0x000A6F10
		// Note: this type is marked as 'beforefieldinit'.
		static SkirmishF()
		{
			Il2CppClassPointerStore<SkirmishF>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.RiseOfIx", "SkirmishF");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishF>.NativeClassPtr);
			SkirmishF.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishF>.NativeClassPtr, "archID");
			SkirmishF.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishF>.NativeClassPtr, 100666652);
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x000A8D68 File Offset: 0x000A6F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120206, XrefRangeEnd = 120320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkirmishF()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkirmishF>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishF.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x0000A250 File Offset: 0x00008450
		public SkirmishF(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06001550 RID: 5456 RVA: 0x000A8DA4 File Offset: 0x000A6FA4
		// (set) Token: 0x06001551 RID: 5457 RVA: 0x0000A259 File Offset: 0x00008459
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SkirmishF.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkirmishF.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
