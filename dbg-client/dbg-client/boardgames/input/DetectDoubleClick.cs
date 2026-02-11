using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace boardgames.input
{
	// Token: 0x02000131 RID: 305
	public class DetectDoubleClick : MonoBehaviour
	{
		// Token: 0x06000D7E RID: 3454 RVA: 0x00048288 File Offset: 0x00046488
		// Note: this type is marked as 'beforefieldinit'.
		static DetectDoubleClick()
		{
			Il2CppClassPointerStore<DetectDoubleClick>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "DetectDoubleClick");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetectDoubleClick>.NativeClassPtr);
			DetectDoubleClick.NativeFieldInfoPtr_OnObjectDoubleClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectDoubleClick>.NativeClassPtr, "OnObjectDoubleClicked");
			DetectDoubleClick.NativeFieldInfoPtr_onOnlySingleClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectDoubleClick>.NativeClassPtr, "onOnlySingleClick");
			DetectDoubleClick.NativeFieldInfoPtr_imitateSelectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectDoubleClick>.NativeClassPtr, "imitateSelectable");
			DetectDoubleClick.NativeFieldInfoPtr_doubleClickBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectDoubleClick>.NativeClassPtr, "doubleClickBuffer");
			DetectDoubleClick.NativeFieldInfoPtr_localClickCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectDoubleClick>.NativeClassPtr, "localClickCount");
			DetectDoubleClick.NativeFieldInfoPtr_lastClickTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectDoubleClick>.NativeClassPtr, "lastClickTime");
			DetectDoubleClick.NativeMethodInfoPtr_get_ClickTimedOut_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectDoubleClick>.NativeClassPtr, 100665251);
			DetectDoubleClick.NativeMethodInfoPtr_get_TriggerEvents_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectDoubleClick>.NativeClassPtr, 100665252);
			DetectDoubleClick.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectDoubleClick>.NativeClassPtr, 100665253);
			DetectDoubleClick.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectDoubleClick>.NativeClassPtr, 100665254);
			DetectDoubleClick.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectDoubleClick>.NativeClassPtr, 100665255);
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x00048394 File Offset: 0x00046594
		public unsafe bool ClickTimedOut
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510825, XrefRangeEnd = 510826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetectDoubleClick.NativeMethodInfoPtr_get_ClickTimedOut_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x000483D0 File Offset: 0x000465D0
		public unsafe bool TriggerEvents
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 510830, RefRangeEnd = 510832, XrefRangeStart = 510826, XrefRangeEnd = 510830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetectDoubleClick.NativeMethodInfoPtr_get_TriggerEvents_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0004840C File Offset: 0x0004660C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510832, XrefRangeEnd = 510835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetectDoubleClick.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00048450 File Offset: 0x00046650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510835, XrefRangeEnd = 510838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetectDoubleClick.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00048484 File Offset: 0x00046684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510838, XrefRangeEnd = 510848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DetectDoubleClick()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DetectDoubleClick>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetectDoubleClick.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00008863 File Offset: 0x00006A63
		public DetectDoubleClick(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x000484C0 File Offset: 0x000466C0
		// (set) Token: 0x06000D86 RID: 3462 RVA: 0x0000886C File Offset: 0x00006A6C
		public unsafe UnityEvent OnObjectDoubleClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetectDoubleClick.NativeFieldInfoPtr_OnObjectDoubleClicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetectDoubleClick.NativeFieldInfoPtr_OnObjectDoubleClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x000484F0 File Offset: 0x000466F0
		// (set) Token: 0x06000D88 RID: 3464 RVA: 0x0000888B File Offset: 0x00006A8B
		public unsafe UnityEvent onOnlySingleClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetectDoubleClick.NativeFieldInfoPtr_onOnlySingleClick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetectDoubleClick.NativeFieldInfoPtr_onOnlySingleClick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x00048520 File Offset: 0x00046720
		// (set) Token: 0x06000D8A RID: 3466 RVA: 0x000088AA File Offset: 0x00006AAA
		public unsafe Selectable imitateSelectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetectDoubleClick.NativeFieldInfoPtr_imitateSelectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetectDoubleClick.NativeFieldInfoPtr_imitateSelectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x00048550 File Offset: 0x00046750
		// (set) Token: 0x06000D8C RID: 3468 RVA: 0x000088C9 File Offset: 0x00006AC9
		public unsafe float doubleClickBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetectDoubleClick.NativeFieldInfoPtr_doubleClickBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetectDoubleClick.NativeFieldInfoPtr_doubleClickBuffer)) = value;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x00048578 File Offset: 0x00046778
		// (set) Token: 0x06000D8E RID: 3470 RVA: 0x000088E4 File Offset: 0x00006AE4
		public unsafe int localClickCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetectDoubleClick.NativeFieldInfoPtr_localClickCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetectDoubleClick.NativeFieldInfoPtr_localClickCount)) = value;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x000485A0 File Offset: 0x000467A0
		// (set) Token: 0x06000D90 RID: 3472 RVA: 0x000088FF File Offset: 0x00006AFF
		public unsafe float lastClickTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetectDoubleClick.NativeFieldInfoPtr_lastClickTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetectDoubleClick.NativeFieldInfoPtr_lastClickTime)) = value;
			}
		}

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeFieldInfoPtr_OnObjectDoubleClicked;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeFieldInfoPtr_onOnlySingleClick;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeFieldInfoPtr_imitateSelectable;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeFieldInfoPtr_doubleClickBuffer;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeFieldInfoPtr_localClickCount;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeFieldInfoPtr_lastClickTime;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_get_ClickTimedOut_Private_get_Boolean_0;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_get_TriggerEvents_Private_get_Boolean_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
