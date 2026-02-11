using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace worm.match.components
{
	// Token: 0x020001B3 RID: 435
	public class HoldableButton : UIBehaviour
	{
		// Token: 0x0600132F RID: 4911 RVA: 0x00052564 File Offset: 0x00050764
		// Note: this type is marked as 'beforefieldinit'.
		static HoldableButton()
		{
			Il2CppClassPointerStore<HoldableButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "HoldableButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr);
			HoldableButton.NativeFieldInfoPtr_totalHoldTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, "totalHoldTime");
			HoldableButton.NativeFieldInfoPtr_ResetHoldDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, "ResetHoldDelay");
			HoldableButton.NativeFieldInfoPtr_currentHoldTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, "currentHoldTime");
			HoldableButton.NativeFieldInfoPtr_lastHeldTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, "lastHeldTime");
			HoldableButton.NativeFieldInfoPtr_holding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, "holding");
			HoldableButton.NativeFieldInfoPtr_OnSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, "OnSelect");
			HoldableButton.NativeFieldInfoPtr_OnHold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, "OnHold");
			HoldableButton.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, "button");
			HoldableButton.NativeMethodInfoPtr_get_CurrentHoldTime_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, 100665921);
			HoldableButton.NativeMethodInfoPtr_set_CurrentHoldTime_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, 100665922);
			HoldableButton.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, 100665923);
			HoldableButton.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, 100665924);
			HoldableButton.NativeMethodInfoPtr_Event_HoldingContextual_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, 100665925);
			HoldableButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr, 100665926);
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x000526AC File Offset: 0x000508AC
		// (set) Token: 0x06001331 RID: 4913 RVA: 0x000526E8 File Offset: 0x000508E8
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
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 712782, RefRangeEnd = 712783, XrefRangeStart = 712778, XrefRangeEnd = 712782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06001332 RID: 4914 RVA: 0x00052728 File Offset: 0x00050928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712783, XrefRangeEnd = 712790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldableButton.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x0005275C File Offset: 0x0005095C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712790, XrefRangeEnd = 712793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HoldableButton.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00052798 File Offset: 0x00050998
		[CallerCount(0)]
		public unsafe void Event_HoldingContextual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldableButton.NativeMethodInfoPtr_Event_HoldingContextual_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x000527CC File Offset: 0x000509CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712793, XrefRangeEnd = 712806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HoldableButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HoldableButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldableButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x0000BE8A File Offset: 0x0000A08A
		public HoldableButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x00052808 File Offset: 0x00050A08
		// (set) Token: 0x06001338 RID: 4920 RVA: 0x0000BE93 File Offset: 0x0000A093
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

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x00052830 File Offset: 0x00050A30
		// (set) Token: 0x0600133A RID: 4922 RVA: 0x0000BEAE File Offset: 0x0000A0AE
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

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x0005284C File Offset: 0x00050A4C
		// (set) Token: 0x0600133C RID: 4924 RVA: 0x0000BEBC File Offset: 0x0000A0BC
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

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x00052874 File Offset: 0x00050A74
		// (set) Token: 0x0600133E RID: 4926 RVA: 0x0000BED7 File Offset: 0x0000A0D7
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

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x0600133F RID: 4927 RVA: 0x0005289C File Offset: 0x00050A9C
		// (set) Token: 0x06001340 RID: 4928 RVA: 0x0000BEF2 File Offset: 0x0000A0F2
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

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001341 RID: 4929 RVA: 0x000528C4 File Offset: 0x00050AC4
		// (set) Token: 0x06001342 RID: 4930 RVA: 0x0000BF0D File Offset: 0x0000A10D
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

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001343 RID: 4931 RVA: 0x000528F4 File Offset: 0x00050AF4
		// (set) Token: 0x06001344 RID: 4932 RVA: 0x0000BF2C File Offset: 0x0000A12C
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

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001345 RID: 4933 RVA: 0x00052924 File Offset: 0x00050B24
		// (set) Token: 0x06001346 RID: 4934 RVA: 0x0000BF4B File Offset: 0x0000A14B
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

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeFieldInfoPtr_totalHoldTime;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeFieldInfoPtr_ResetHoldDelay;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeFieldInfoPtr_currentHoldTime;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeFieldInfoPtr_lastHeldTime;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeFieldInfoPtr_holding;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeFieldInfoPtr_OnSelect;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeFieldInfoPtr_OnHold;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentHoldTime_Private_get_Single_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentHoldTime_Private_set_Void_Single_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeMethodInfoPtr_Event_HoldingContextual_Public_Void_0;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
