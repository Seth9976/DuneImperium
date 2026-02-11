using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.animation
{
	// Token: 0x02000219 RID: 537
	public class UpdateAnimatorOnEnable : MonoBehaviour
	{
		// Token: 0x06001D66 RID: 7526 RVA: 0x0008806C File Offset: 0x0008626C
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateAnimatorOnEnable()
		{
			Il2CppClassPointerStore<UpdateAnimatorOnEnable>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.animation", "UpdateAnimatorOnEnable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateAnimatorOnEnable>.NativeClassPtr);
			UpdateAnimatorOnEnable.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateAnimatorOnEnable>.NativeClassPtr, 100668035);
			UpdateAnimatorOnEnable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateAnimatorOnEnable>.NativeClassPtr, 100668036);
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x000880C4 File Offset: 0x000862C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886398, XrefRangeEnd = 886405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateAnimatorOnEnable.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x000880F8 File Offset: 0x000862F8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateAnimatorOnEnable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateAnimatorOnEnable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateAnimatorOnEnable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x0000C87C File Offset: 0x0000AA7C
		public UpdateAnimatorOnEnable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001496 RID: 5270
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001497 RID: 5271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
