using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace zen.src.match.monobehaviours
{
	// Token: 0x0200006E RID: 110
	public class OnDemandAnimateTimer : AnimateTimer
	{
		// Token: 0x060005DE RID: 1502 RVA: 0x00023108 File Offset: 0x00021308
		// Note: this type is marked as 'beforefieldinit'.
		static OnDemandAnimateTimer()
		{
			Il2CppClassPointerStore<OnDemandAnimateTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.monobehaviours", "OnDemandAnimateTimer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDemandAnimateTimer>.NativeClassPtr);
			OnDemandAnimateTimer.NativeFieldInfoPtr_timerContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDemandAnimateTimer>.NativeClassPtr, "timerContainer");
			OnDemandAnimateTimer.NativeFieldInfoPtr_modalsNeedingTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDemandAnimateTimer>.NativeClassPtr, "modalsNeedingTimer");
			OnDemandAnimateTimer.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandAnimateTimer>.NativeClassPtr, 100664230);
			OnDemandAnimateTimer.NativeMethodInfoPtr_ToggleTimer_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandAnimateTimer>.NativeClassPtr, 100664231);
			OnDemandAnimateTimer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandAnimateTimer>.NativeClassPtr, 100664232);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0002319C File Offset: 0x0002139C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988188, XrefRangeEnd = 988197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnDemandAnimateTimer.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000231D8 File Offset: 0x000213D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988197, XrefRangeEnd = 988207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleTimer(bool maintainTimer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maintainTimer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDemandAnimateTimer.NativeMethodInfoPtr_ToggleTimer_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00023218 File Offset: 0x00021418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988207, XrefRangeEnd = 988230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnDemandAnimateTimer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnDemandAnimateTimer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDemandAnimateTimer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00004AE6 File Offset: 0x00002CE6
		public OnDemandAnimateTimer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00023254 File Offset: 0x00021454
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x00004AEF File Offset: 0x00002CEF
		public unsafe CanvasGroup timerContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandAnimateTimer.NativeFieldInfoPtr_timerContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandAnimateTimer.NativeFieldInfoPtr_timerContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00023284 File Offset: 0x00021484
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x00004B0E File Offset: 0x00002D0E
		public unsafe int modalsNeedingTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandAnimateTimer.NativeFieldInfoPtr_modalsNeedingTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandAnimateTimer.NativeFieldInfoPtr_modalsNeedingTimer)) = value;
			}
		}

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeFieldInfoPtr_timerContainer;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeFieldInfoPtr_modalsNeedingTimer;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_ToggleTimer_Public_Void_Boolean_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
