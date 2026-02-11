using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001DE RID: 478
	public class WormConflictThirdPlaceDisabler : MonoBehaviour
	{
		// Token: 0x06001528 RID: 5416 RVA: 0x00058570 File Offset: 0x00056770
		// Note: this type is marked as 'beforefieldinit'.
		static WormConflictThirdPlaceDisabler()
		{
			Il2CppClassPointerStore<WormConflictThirdPlaceDisabler>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormConflictThirdPlaceDisabler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictThirdPlaceDisabler>.NativeClassPtr);
			WormConflictThirdPlaceDisabler.NativeFieldInfoPtr_animParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictThirdPlaceDisabler>.NativeClassPtr, "animParam");
			WormConflictThirdPlaceDisabler.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictThirdPlaceDisabler>.NativeClassPtr, 100666212);
			WormConflictThirdPlaceDisabler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictThirdPlaceDisabler>.NativeClassPtr, 100666213);
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x000585DC File Offset: 0x000567DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714924, XrefRangeEnd = 714933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictThirdPlaceDisabler.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00058610 File Offset: 0x00056810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714933, XrefRangeEnd = 714937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConflictThirdPlaceDisabler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictThirdPlaceDisabler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictThirdPlaceDisabler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x0000CE23 File Offset: 0x0000B023
		public WormConflictThirdPlaceDisabler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x0005864C File Offset: 0x0005684C
		// (set) Token: 0x0600152D RID: 5421 RVA: 0x0000CE2C File Offset: 0x0000B02C
		public unsafe string animParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictThirdPlaceDisabler.NativeFieldInfoPtr_animParam);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictThirdPlaceDisabler.NativeFieldInfoPtr_animParam), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeFieldInfoPtr_animParam;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
