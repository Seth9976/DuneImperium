using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001E5 RID: 485
	public class WormDisableGameObjectInTutorial : MonoBehaviour
	{
		// Token: 0x0600156F RID: 5487 RVA: 0x00059358 File Offset: 0x00057558
		// Note: this type is marked as 'beforefieldinit'.
		static WormDisableGameObjectInTutorial()
		{
			Il2CppClassPointerStore<WormDisableGameObjectInTutorial>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormDisableGameObjectInTutorial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDisableGameObjectInTutorial>.NativeClassPtr);
			WormDisableGameObjectInTutorial.NativeFieldInfoPtr_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDisableGameObjectInTutorial>.NativeClassPtr, "objects");
			WormDisableGameObjectInTutorial.NativeFieldInfoPtr_ActionToCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDisableGameObjectInTutorial>.NativeClassPtr, "ActionToCheck");
			WormDisableGameObjectInTutorial.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDisableGameObjectInTutorial>.NativeClassPtr, 100666255);
			WormDisableGameObjectInTutorial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDisableGameObjectInTutorial>.NativeClassPtr, 100666256);
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x000593D8 File Offset: 0x000575D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715258, XrefRangeEnd = 715292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDisableGameObjectInTutorial.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x0005940C File Offset: 0x0005760C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715292, XrefRangeEnd = 715303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDisableGameObjectInTutorial()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDisableGameObjectInTutorial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDisableGameObjectInTutorial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x0000D02F File Offset: 0x0000B22F
		public WormDisableGameObjectInTutorial(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x00059448 File Offset: 0x00057648
		// (set) Token: 0x06001574 RID: 5492 RVA: 0x0000D038 File Offset: 0x0000B238
		public unsafe List<GameObject> objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDisableGameObjectInTutorial.NativeFieldInfoPtr_objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDisableGameObjectInTutorial.NativeFieldInfoPtr_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x00059478 File Offset: 0x00057678
		// (set) Token: 0x06001576 RID: 5494 RVA: 0x0000D057 File Offset: 0x0000B257
		public unsafe string ActionToCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDisableGameObjectInTutorial.NativeFieldInfoPtr_ActionToCheck);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDisableGameObjectInTutorial.NativeFieldInfoPtr_ActionToCheck), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeFieldInfoPtr_objects;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeFieldInfoPtr_ActionToCheck;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
