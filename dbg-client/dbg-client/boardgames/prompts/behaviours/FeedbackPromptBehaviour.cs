using System;
using boardgames.menus.prompts;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.prompts.behaviours
{
	// Token: 0x020000FF RID: 255
	public class FeedbackPromptBehaviour : PromptBehaviour<FeedbackPrompt>
	{
		// Token: 0x06000AC7 RID: 2759 RVA: 0x0003FBF4 File Offset: 0x0003DDF4
		// Note: this type is marked as 'beforefieldinit'.
		static FeedbackPromptBehaviour()
		{
			Il2CppClassPointerStore<FeedbackPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.prompts.behaviours", "FeedbackPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedbackPromptBehaviour>.NativeClassPtr);
			FeedbackPromptBehaviour.NativeFieldInfoPtr_emailUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackPromptBehaviour>.NativeClassPtr, "emailUI");
			FeedbackPromptBehaviour.NativeFieldInfoPtr_emailInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackPromptBehaviour>.NativeClassPtr, "emailInput");
			FeedbackPromptBehaviour.NativeFieldInfoPtr_feedbackInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackPromptBehaviour>.NativeClassPtr, "feedbackInput");
			FeedbackPromptBehaviour.NativeFieldInfoPtr_sendFeedbackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackPromptBehaviour>.NativeClassPtr, "sendFeedbackButton");
			FeedbackPromptBehaviour.NativeFieldInfoPtr_badEmailIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackPromptBehaviour>.NativeClassPtr, "badEmailIcon");
			FeedbackPromptBehaviour.NativeFieldInfoPtr_sendLogsToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackPromptBehaviour>.NativeClassPtr, "sendLogsToggle");
			FeedbackPromptBehaviour.NativeFieldInfoPtr_sendScreenshotToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackPromptBehaviour>.NativeClassPtr, "sendScreenshotToggle");
			FeedbackPromptBehaviour.NativeFieldInfoPtr_emailInputGamepadTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackPromptBehaviour>.NativeClassPtr, "emailInputGamepadTarget");
			FeedbackPromptBehaviour.NativeMethodInfoPtr_get_isEmailValid_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackPromptBehaviour>.NativeClassPtr, 100664880);
			FeedbackPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackPromptBehaviour>.NativeClassPtr, 100664881);
			FeedbackPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackPromptBehaviour>.NativeClassPtr, 100664882);
			FeedbackPromptBehaviour.NativeMethodInfoPtr_Event_SendFeedback_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackPromptBehaviour>.NativeClassPtr, 100664883);
			FeedbackPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackPromptBehaviour>.NativeClassPtr, 100664884);
			FeedbackPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackPromptBehaviour>.NativeClassPtr, 100664885);
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x0003FD3C File Offset: 0x0003DF3C
		public unsafe bool isEmailValid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507259, XrefRangeEnd = 507265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackPromptBehaviour.NativeMethodInfoPtr_get_isEmailValid_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0003FD78 File Offset: 0x0003DF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507265, XrefRangeEnd = 507284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FeedbackPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0003FDB4 File Offset: 0x0003DFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507284, XrefRangeEnd = 507294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0003FDE8 File Offset: 0x0003DFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507294, XrefRangeEnd = 507309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SendFeedback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackPromptBehaviour.NativeMethodInfoPtr_Event_SendFeedback_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0003FE1C File Offset: 0x0003E01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507309, XrefRangeEnd = 507314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0003FE50 File Offset: 0x0003E050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507314, XrefRangeEnd = 507317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FeedbackPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeedbackPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x000071B8 File Offset: 0x000053B8
		public FeedbackPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0003FE8C File Offset: 0x0003E08C
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x000071C1 File Offset: 0x000053C1
		public unsafe GameObject emailUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackPromptBehaviour.NativeFieldInfoPtr_emailUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackPromptBehaviour.NativeFieldInfoPtr_emailUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0003FEBC File Offset: 0x0003E0BC
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x000071E0 File Offset: 0x000053E0
		public unsafe TMP_InputField emailInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackPromptBehaviour.NativeFieldInfoPtr_emailInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackPromptBehaviour.NativeFieldInfoPtr_emailInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0003FEEC File Offset: 0x0003E0EC
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x000071FF File Offset: 0x000053FF
		public unsafe TMP_InputField feedbackInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackPromptBehaviour.NativeFieldInfoPtr_feedbackInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackPromptBehaviour.NativeFieldInfoPtr_feedbackInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x0003FF1C File Offset: 0x0003E11C
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x0000721E File Offset: 0x0000541E
		public unsafe Button sendFeedbackButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackPromptBehaviour.NativeFieldInfoPtr_sendFeedbackButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackPromptBehaviour.NativeFieldInfoPtr_sendFeedbackButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0003FF4C File Offset: 0x0003E14C
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x0000723D File Offset: 0x0000543D
		public unsafe GameObject badEmailIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackPromptBehaviour.NativeFieldInfoPtr_badEmailIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackPromptBehaviour.NativeFieldInfoPtr_badEmailIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0003FF7C File Offset: 0x0003E17C
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x0000725C File Offset: 0x0000545C
		public unsafe Toggle sendLogsToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackPromptBehaviour.NativeFieldInfoPtr_sendLogsToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackPromptBehaviour.NativeFieldInfoPtr_sendLogsToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x0003FFAC File Offset: 0x0003E1AC
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x0000727B File Offset: 0x0000547B
		public unsafe Toggle sendScreenshotToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackPromptBehaviour.NativeFieldInfoPtr_sendScreenshotToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackPromptBehaviour.NativeFieldInfoPtr_sendScreenshotToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x0003FFDC File Offset: 0x0003E1DC
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x0000729A File Offset: 0x0000549A
		public unsafe GameObject emailInputGamepadTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackPromptBehaviour.NativeFieldInfoPtr_emailInputGamepadTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackPromptBehaviour.NativeFieldInfoPtr_emailInputGamepadTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeFieldInfoPtr_emailUI;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeFieldInfoPtr_emailInput;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeFieldInfoPtr_feedbackInput;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeFieldInfoPtr_sendFeedbackButton;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeFieldInfoPtr_badEmailIcon;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeFieldInfoPtr_sendLogsToggle;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeFieldInfoPtr_sendScreenshotToggle;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeFieldInfoPtr_emailInputGamepadTarget;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_get_isEmailValid_Private_get_Boolean_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_Event_SendFeedback_Public_Void_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr_Event_Dismiss_Public_Void_0;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
