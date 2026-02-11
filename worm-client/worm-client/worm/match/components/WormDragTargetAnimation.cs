using System;
using dwd.core.animation;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001E9 RID: 489
	public class WormDragTargetAnimation : MonoBehaviour
	{
		// Token: 0x060015AD RID: 5549 RVA: 0x0005A084 File Offset: 0x00058284
		// Note: this type is marked as 'beforefieldinit'.
		static WormDragTargetAnimation()
		{
			Il2CppClassPointerStore<WormDragTargetAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormDragTargetAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDragTargetAnimation>.NativeClassPtr);
			WormDragTargetAnimation.NativeFieldInfoPtr_dropAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDragTargetAnimation>.NativeClassPtr, "dropAnimation");
			WormDragTargetAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDragTargetAnimation>.NativeClassPtr, 100666299);
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x0005A0DC File Offset: 0x000582DC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDragTargetAnimation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDragTargetAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDragTargetAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x0000D1EC File Offset: 0x0000B3EC
		public WormDragTargetAnimation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x0005A118 File Offset: 0x00058318
		// (set) Token: 0x060015B1 RID: 5553 RVA: 0x0000D1F5 File Offset: 0x0000B3F5
		public unsafe TriggeredBlockingAnimation dropAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetAnimation.NativeFieldInfoPtr_dropAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetAnimation.NativeFieldInfoPtr_dropAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeFieldInfoPtr_dropAnimation;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
