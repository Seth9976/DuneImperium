using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.ui
{
	// Token: 0x02000122 RID: 290
	public class OnlineStatusIndicator : MonoBehaviour
	{
		// Token: 0x06000EEA RID: 3818 RVA: 0x0003E474 File Offset: 0x0003C674
		// Note: this type is marked as 'beforefieldinit'.
		static OnlineStatusIndicator()
		{
			Il2CppClassPointerStore<OnlineStatusIndicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.ui", "OnlineStatusIndicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlineStatusIndicator>.NativeClassPtr);
			OnlineStatusIndicator.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineStatusIndicator>.NativeClassPtr, "animator");
			OnlineStatusIndicator.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineStatusIndicator>.NativeClassPtr, 100665416);
			OnlineStatusIndicator.NativeMethodInfoPtr_SetStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineStatusIndicator>.NativeClassPtr, 100665417);
			OnlineStatusIndicator.NativeMethodInfoPtr_SetIsAI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineStatusIndicator>.NativeClassPtr, 100665418);
			OnlineStatusIndicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineStatusIndicator>.NativeClassPtr, 100665419);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0003E508 File Offset: 0x0003C708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996819, XrefRangeEnd = 996822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineStatusIndicator.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x0003E53C File Offset: 0x0003C73C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 996833, RefRangeEnd = 996837, XrefRangeStart = 996822, XrefRangeEnd = 996833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStatus(bool online)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref online;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineStatusIndicator.NativeMethodInfoPtr_SetStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0003E57C File Offset: 0x0003C77C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 996845, RefRangeEnd = 996847, XrefRangeStart = 996837, XrefRangeEnd = 996845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsAI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineStatusIndicator.NativeMethodInfoPtr_SetIsAI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0003E5B0 File Offset: 0x0003C7B0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnlineStatusIndicator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlineStatusIndicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineStatusIndicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00008FD9 File Offset: 0x000071D9
		public OnlineStatusIndicator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x0003E5EC File Offset: 0x0003C7EC
		// (set) Token: 0x06000EF1 RID: 3825 RVA: 0x00008FE2 File Offset: 0x000071E2
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineStatusIndicator.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineStatusIndicator.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeMethodInfoPtr_SetStatus_Public_Void_Boolean_0;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeMethodInfoPtr_SetIsAI_Public_Void_0;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
