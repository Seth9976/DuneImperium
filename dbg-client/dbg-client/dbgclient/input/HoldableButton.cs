using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace dbgclient.input
{
	// Token: 0x020000AD RID: 173
	public class HoldableButton : UIBehaviour
	{
		// Token: 0x060006EC RID: 1772 RVA: 0x00033680 File Offset: 0x00031880
		// Note: this type is marked as 'beforefieldinit'.
		static HoldableButton()
		{
			Il2CppClassPointerStore<HoldableButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.input", "HoldableButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr);
			HoldableButton.NativeFieldInfoPtr_totalHoldTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, "totalHoldTime");
			HoldableButton.NativeFieldInfoPtr_ResetHoldDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, "ResetHoldDelay");
			HoldableButton.NativeFieldInfoPtr_ClickLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, "ClickLimit");
			HoldableButton.NativeFieldInfoPtr_currentHoldTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, "currentHoldTime");
			HoldableButton.NativeFieldInfoPtr_lastHeldTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, "lastHeldTime");
			HoldableButton.NativeFieldInfoPtr_holding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, "holding");
			HoldableButton.NativeFieldInfoPtr_holdDraining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, "holdDraining");
			HoldableButton.NativeFieldInfoPtr_OnSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, "OnSelect");
			HoldableButton.NativeFieldInfoPtr_OnHold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, "OnHold");
			HoldableButton.NativeFieldInfoPtr_OnClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, "OnClick");
			HoldableButton.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, "button");
			HoldableButton.NativeMethodInfoPtr_get_CurrentHoldTime_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, 100664372);
			HoldableButton.NativeMethodInfoPtr_set_CurrentHoldTime_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, 100664373);
			HoldableButton.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, 100664374);
			HoldableButton.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, 100664375);
			HoldableButton.NativeMethodInfoPtr_Event_Hold_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, 100664376);
			HoldableButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, 100664377);
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00033804 File Offset: 0x00031A04
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x00033840 File Offset: 0x00031A40
		public unsafe float CurrentHoldTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldableButton.NativeMethodInfoPtr_get_CurrentHoldTime_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 503938, RefRangeEnd = 503940, XrefRangeStart = 503934, XrefRangeEnd = 503938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldableButton.NativeMethodInfoPtr_set_CurrentHoldTime_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00033880 File Offset: 0x00031A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503940, XrefRangeEnd = 503949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldableButton.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x000338B4 File Offset: 0x00031AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503949, XrefRangeEnd = 503952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HoldableButton.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x000338F0 File Offset: 0x00031AF0
		[CallerCount(0)]
		public unsafe void Event_Hold()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldableButton.NativeMethodInfoPtr_Event_Hold_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00033924 File Offset: 0x00031B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503952, XrefRangeEnd = 503969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HoldableButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldableButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x000052CF File Offset: 0x000034CF
		public HoldableButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00033960 File Offset: 0x00031B60
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x000052D8 File Offset: 0x000034D8
		public unsafe float totalHoldTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldableButton.NativeFieldInfoPtr_totalHoldTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldableButton.NativeFieldInfoPtr_totalHoldTime)) = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x00033988 File Offset: 0x00031B88
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x000052F3 File Offset: 0x000034F3
		public unsafe static float ResetHoldDelay
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(HoldableButton.NativeFieldInfoPtr_ResetHoldDelay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HoldableButton.NativeFieldInfoPtr_ResetHoldDelay, (void*)(&value));
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x000339A4 File Offset: 0x00031BA4
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x00005301 File Offset: 0x00003501
		public unsafe static float ClickLimit
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(HoldableButton.NativeFieldInfoPtr_ClickLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HoldableButton.NativeFieldInfoPtr_ClickLimit, (void*)(&value));
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x000339C0 File Offset: 0x00031BC0
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x0000530F File Offset: 0x0000350F
		public unsafe float currentHoldTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldableButton.NativeFieldInfoPtr_currentHoldTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldableButton.NativeFieldInfoPtr_currentHoldTime)) = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x000339E8 File Offset: 0x00031BE8
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x0000532A File Offset: 0x0000352A
		public unsafe float lastHeldTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldableButton.NativeFieldInfoPtr_lastHeldTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldableButton.NativeFieldInfoPtr_lastHeldTime)) = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x00033A10 File Offset: 0x00031C10
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x00005345 File Offset: 0x00003545
		public unsafe bool holding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldableButton.NativeFieldInfoPtr_holding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldableButton.NativeFieldInfoPtr_holding)) = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x00033A38 File Offset: 0x00031C38
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x00005360 File Offset: 0x00003560
		public unsafe bool holdDraining
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldableButton.NativeFieldInfoPtr_holdDraining);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldableButton.NativeFieldInfoPtr_holdDraining)) = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x00033A60 File Offset: 0x00031C60
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x0000537B File Offset: 0x0000357B
		public unsafe UnityEvent OnSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldableButton.NativeFieldInfoPtr_OnSelect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldableButton.NativeFieldInfoPtr_OnSelect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00033A90 File Offset: 0x00031C90
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x0000539A File Offset: 0x0000359A
		public unsafe UnityEvent<float> OnHold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldableButton.NativeFieldInfoPtr_OnHold);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldableButton.NativeFieldInfoPtr_OnHold), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00033AC0 File Offset: 0x00031CC0
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x000053B9 File Offset: 0x000035B9
		public unsafe UnityEvent OnClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldableButton.NativeFieldInfoPtr_OnClick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldableButton.NativeFieldInfoPtr_OnClick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x00033AF0 File Offset: 0x00031CF0
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x000053D8 File Offset: 0x000035D8
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldableButton.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldableButton.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeFieldInfoPtr_totalHoldTime;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeFieldInfoPtr_ResetHoldDelay;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeFieldInfoPtr_ClickLimit;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeFieldInfoPtr_currentHoldTime;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeFieldInfoPtr_lastHeldTime;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeFieldInfoPtr_holding;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeFieldInfoPtr_holdDraining;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeFieldInfoPtr_OnSelect;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeFieldInfoPtr_OnHold;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeFieldInfoPtr_OnClick;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentHoldTime_Private_get_Single_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentHoldTime_Private_set_Void_Single_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_Event_Hold_Public_Void_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
