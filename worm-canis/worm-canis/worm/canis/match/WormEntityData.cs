using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.canis.match
{
	// Token: 0x02000017 RID: 23
	[Serializable]
	public class WormEntityData : Object
	{
		// Token: 0x060001B8 RID: 440 RVA: 0x0006FDC0 File Offset: 0x0006DFC0
		// Note: this type is marked as 'beforefieldinit'.
		static WormEntityData()
		{
			Il2CppClassPointerStore<WormEntityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.match", "WormEntityData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEntityData>.NativeClassPtr);
			WormEntityData.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntityData>.NativeClassPtr, "archID");
			WormEntityData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityData>.NativeClassPtr, 100663782);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0006FE18 File Offset: 0x0006E018
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEntityData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEntityData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002C75 File Offset: 0x00000E75
		public WormEntityData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0006FE54 File Offset: 0x0006E054
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00002C7E File Offset: 0x00000E7E
		public unsafe ArchetypeID archID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityData.NativeFieldInfoPtr_archID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityData.NativeFieldInfoPtr_archID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
