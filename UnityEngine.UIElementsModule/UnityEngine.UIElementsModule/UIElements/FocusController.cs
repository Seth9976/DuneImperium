using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000130 RID: 304
	public class FocusController : Object
	{
		// Token: 0x06001677 RID: 5751 RVA: 0x0006C984 File Offset: 0x0006AB84
		// Note: this type is marked as 'beforefieldinit'.
		static FocusController()
		{
			Il2CppClassPointerStore<FocusController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "FocusController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FocusController>.NativeClassPtr);
			FocusController.NativeFieldInfoPtr__focusRing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusController>.NativeClassPtr, "<focusRing>k__BackingField");
			FocusController.NativeFieldInfoPtr_m_SelectedTextElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusController>.NativeClassPtr, "m_SelectedTextElement");
			FocusController.NativeFieldInfoPtr_m_FocusedElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusController>.NativeClassPtr, "m_FocusedElements");
			FocusController.NativeFieldInfoPtr_m_LastFocusedElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusController>.NativeClassPtr, "m_LastFocusedElement");
			FocusController.NativeFieldInfoPtr_m_LastPendingFocusedElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusController>.NativeClassPtr, "m_LastPendingFocusedElement");
			FocusController.NativeFieldInfoPtr_m_PendingFocusCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusController>.NativeClassPtr, "m_PendingFocusCount");
			FocusController.NativeFieldInfoPtr__imguiKeyboardControl_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusController>.NativeClassPtr, "<imguiKeyboardControl>k__BackingField");
			FocusController.NativeMethodInfoPtr__ctor_Public_Void_IFocusRing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666656);
			FocusController.NativeMethodInfoPtr_get_focusRing_Private_get_IFocusRing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666657);
			FocusController.NativeMethodInfoPtr_set_selectedTextElement_Internal_set_Void_TextElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666658);
			FocusController.NativeMethodInfoPtr_get_focusedElement_Public_get_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666659);
			FocusController.NativeMethodInfoPtr_IsFocused_Internal_Boolean_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666660);
			FocusController.NativeMethodInfoPtr_GetRetargetedFocusedElement_Internal_Focusable_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666661);
			FocusController.NativeMethodInfoPtr_GetLeafFocusedElement_Internal_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666662);
			FocusController.NativeMethodInfoPtr_IsLocalElement_Private_Boolean_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666663);
			FocusController.NativeMethodInfoPtr_IsPendingFocus_Internal_Boolean_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666664);
			FocusController.NativeMethodInfoPtr_SetFocusToLastFocusedElement_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666665);
			FocusController.NativeMethodInfoPtr_BlurLastFocusedElement_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666666);
			FocusController.NativeMethodInfoPtr_DoFocusChange_Internal_Void_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666667);
			FocusController.NativeMethodInfoPtr_ProcessPendingFocusChange_Internal_Void_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666668);
			FocusController.NativeMethodInfoPtr_FocusNextInDirection_Internal_Focusable_FocusChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666669);
			FocusController.NativeMethodInfoPtr_AboutToReleaseFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_DispatchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666670);
			FocusController.NativeMethodInfoPtr_ReleaseFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_DispatchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666671);
			FocusController.NativeMethodInfoPtr_AboutToGrabFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_DispatchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666672);
			FocusController.NativeMethodInfoPtr_GrabFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_Boolean_DispatchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666673);
			FocusController.NativeMethodInfoPtr_Blur_Internal_Void_Focusable_Boolean_DispatchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666674);
			FocusController.NativeMethodInfoPtr_SwitchFocus_Internal_Void_Focusable_Boolean_DispatchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666675);
			FocusController.NativeMethodInfoPtr_SwitchFocus_Internal_Void_Focusable_FocusChangeDirection_Boolean_DispatchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666676);
			FocusController.NativeMethodInfoPtr_SwitchFocusOnEvent_Internal_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666677);
			FocusController.NativeMethodInfoPtr_ReevaluateFocus_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666678);
			FocusController.NativeMethodInfoPtr_GetFocusableParentForPointerEvent_Internal_Boolean_Focusable_byref_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666679);
			FocusController.NativeMethodInfoPtr_get_imguiKeyboardControl_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666680);
			FocusController.NativeMethodInfoPtr_set_imguiKeyboardControl_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666681);
			FocusController.NativeMethodInfoPtr_SyncIMGUIFocus_Internal_Void_Int32_Focusable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusController>.NativeClassPtr, 100666682);
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x0006CC5C File Offset: 0x0006AE5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317606, RefRangeEnd = 317608, XrefRangeStart = 317597, XrefRangeEnd = 317606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FocusController(IFocusRing focusRing)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FocusController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusRing);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr__ctor_Public_Void_IFocusRing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x0006CCA8 File Offset: 0x0006AEA8
		public unsafe IFocusRing focusRing
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_get_focusRing_Private_get_IFocusRing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFocusRing>(intPtr3) : null;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x0000A750 File Offset: 0x00008950
		// (set) Token: 0x0600167A RID: 5754 RVA: 0x0006CCE8 File Offset: 0x0006AEE8
		public unsafe TextElement selectedTextElement
		{
			get
			{
				return this.m_SelectedTextElement;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 317613, RefRangeEnd = 317617, XrefRangeStart = 317608, XrefRangeEnd = 317613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_set_selectedTextElement_Internal_set_Void_TextElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x0600167B RID: 5755 RVA: 0x0006CD2C File Offset: 0x0006AF2C
		public unsafe Focusable focusedElement
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 317619, RefRangeEnd = 317621, XrefRangeStart = 317617, XrefRangeEnd = 317619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_get_focusedElement_Public_get_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
			}
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x0006CD6C File Offset: 0x0006AF6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317638, RefRangeEnd = 317640, XrefRangeStart = 317621, XrefRangeEnd = 317638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFocused(Focusable f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_IsFocused_Internal_Boolean_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x0006CDBC File Offset: 0x0006AFBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317668, RefRangeEnd = 317670, XrefRangeStart = 317640, XrefRangeEnd = 317668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Focusable GetRetargetedFocusedElement(VisualElement retargetAgainst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(retargetAgainst);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_GetRetargetedFocusedElement_Internal_Focusable_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
			}
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x0006CE0C File Offset: 0x0006B00C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 317672, RefRangeEnd = 317685, XrefRangeStart = 317670, XrefRangeEnd = 317672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Focusable GetLeafFocusedElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_GetLeafFocusedElement_Internal_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x0006CE4C File Offset: 0x0006B04C
		[CallerCount(0)]
		public unsafe bool IsLocalElement(Focusable f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_IsLocalElement_Private_Boolean_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x0006CE9C File Offset: 0x0006B09C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317689, RefRangeEnd = 317690, XrefRangeStart = 317685, XrefRangeEnd = 317689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPendingFocus(Focusable f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_IsPendingFocus_Internal_Boolean_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x0006CEEC File Offset: 0x0006B0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317690, XrefRangeEnd = 317693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFocusToLastFocusedElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_SetFocusToLastFocusedElement_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x0006CF20 File Offset: 0x0006B120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317693, XrefRangeEnd = 317702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlurLastFocusedElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_BlurLastFocusedElement_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x0006CF54 File Offset: 0x0006B154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317702, XrefRangeEnd = 317715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoFocusChange(Focusable f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_DoFocusChange_Internal_Void_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x0006CF98 File Offset: 0x0006B198
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317729, RefRangeEnd = 317732, XrefRangeStart = 317715, XrefRangeEnd = 317729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessPendingFocusChange(Focusable f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_ProcessPendingFocusChange_Internal_Void_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x0006CFDC File Offset: 0x0006B1DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317736, RefRangeEnd = 317738, XrefRangeStart = 317732, XrefRangeEnd = 317736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Focusable FocusNextInDirection(FocusChangeDirection direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(direction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_FocusNextInDirection_Internal_Focusable_FocusChangeDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
			}
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x0006D02C File Offset: 0x0006B22C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317747, RefRangeEnd = 317749, XrefRangeStart = 317738, XrefRangeEnd = 317747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(willGiveFocusTo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dispatchMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_AboutToReleaseFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_DispatchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x0006D0A0 File Offset: 0x0006B2A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317758, RefRangeEnd = 317760, XrefRangeStart = 317749, XrefRangeEnd = 317758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(willGiveFocusTo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dispatchMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_ReleaseFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_DispatchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x0006D114 File Offset: 0x0006B314
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317769, RefRangeEnd = 317771, XrefRangeStart = 317760, XrefRangeEnd = 317769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, DispatchMode dispatchMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(willTakeFocusFrom);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dispatchMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_AboutToGrabFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_DispatchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x0006D188 File Offset: 0x0006B388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317780, RefRangeEnd = 317781, XrefRangeStart = 317771, XrefRangeEnd = 317780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, bool bIsFocusDelegated, DispatchMode dispatchMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(willTakeFocusFrom);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIsFocusDelegated;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dispatchMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_GrabFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_Boolean_DispatchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x0006D20C File Offset: 0x0006B40C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317789, RefRangeEnd = 317791, XrefRangeStart = 317781, XrefRangeEnd = 317789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blur(Focusable focusable, bool bIsFocusDelegated = false, DispatchMode dispatchMode = DispatchMode.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIsFocusDelegated;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dispatchMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_Blur_Internal_Void_Focusable_Boolean_DispatchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x0006D26C File Offset: 0x0006B46C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317799, RefRangeEnd = 317801, XrefRangeStart = 317791, XrefRangeEnd = 317799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchFocus(Focusable newFocusedElement, bool bIsFocusDelegated = false, DispatchMode dispatchMode = DispatchMode.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newFocusedElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIsFocusDelegated;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dispatchMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_SwitchFocus_Internal_Void_Focusable_Boolean_DispatchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x0006D2CC File Offset: 0x0006B4CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317822, RefRangeEnd = 317825, XrefRangeStart = 317801, XrefRangeEnd = 317822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction, bool bIsFocusDelegated = false, DispatchMode dispatchMode = DispatchMode.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newFocusedElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIsFocusDelegated;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dispatchMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_SwitchFocus_Internal_Void_Focusable_FocusChangeDirection_Boolean_DispatchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x0006D33C File Offset: 0x0006B53C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317847, RefRangeEnd = 317850, XrefRangeStart = 317825, XrefRangeEnd = 317847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchFocusOnEvent(EventBase e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_SwitchFocusOnEvent_Internal_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x0006D380 File Offset: 0x0006B580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317857, RefRangeEnd = 317858, XrefRangeStart = 317850, XrefRangeEnd = 317857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReevaluateFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_ReevaluateFocus_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x0006D3B4 File Offset: 0x0006B5B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317860, RefRangeEnd = 317861, XrefRangeStart = 317858, XrefRangeEnd = 317860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetFocusableParentForPointerEvent(Focusable target, out Focusable effectiveTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_GetFocusableParentForPointerEvent_Internal_Boolean_Focusable_byref_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			effectiveTarget = ((intPtr4 == 0) ? null : new Focusable(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001690 RID: 5776 RVA: 0x0006D424 File Offset: 0x0006B624
		// (set) Token: 0x06001691 RID: 5777 RVA: 0x0006D460 File Offset: 0x0006B660
		public unsafe int imguiKeyboardControl
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_get_imguiKeyboardControl_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 135903, RefRangeEnd = 135917, XrefRangeStart = 135903, XrefRangeEnd = 135917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_set_imguiKeyboardControl_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x0006D4A0 File Offset: 0x0006B6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317861, XrefRangeEnd = 317883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref imguiKeyboardControlID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(imguiContainerHavingKeyboardControl);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceSwitch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusController.NativeMethodInfoPtr_SyncIMGUIFocus_Internal_Void_Int32_Focusable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x0000A676 File Offset: 0x00008876
		public FocusController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x0006D500 File Offset: 0x0006B700
		// (set) Token: 0x06001695 RID: 5781 RVA: 0x0000A67F File Offset: 0x0000887F
		public unsafe IFocusRing _focusRing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr__focusRing_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFocusRing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr__focusRing_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x0006D530 File Offset: 0x0006B730
		// (set) Token: 0x06001697 RID: 5783 RVA: 0x0000A69E File Offset: 0x0000889E
		public unsafe TextElement m_SelectedTextElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr_m_SelectedTextElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr_m_SelectedTextElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x0006D560 File Offset: 0x0006B760
		// (set) Token: 0x06001699 RID: 5785 RVA: 0x0000A6BD File Offset: 0x000088BD
		public unsafe List<FocusController.FocusedElement> m_FocusedElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr_m_FocusedElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FocusController.FocusedElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr_m_FocusedElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x0006D590 File Offset: 0x0006B790
		// (set) Token: 0x0600169B RID: 5787 RVA: 0x0000A6DC File Offset: 0x000088DC
		public unsafe Focusable m_LastFocusedElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr_m_LastFocusedElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr_m_LastFocusedElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x0006D5C0 File Offset: 0x0006B7C0
		// (set) Token: 0x0600169D RID: 5789 RVA: 0x0000A6FB File Offset: 0x000088FB
		public unsafe Focusable m_LastPendingFocusedElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr_m_LastPendingFocusedElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr_m_LastPendingFocusedElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x0006D5F0 File Offset: 0x0006B7F0
		// (set) Token: 0x0600169F RID: 5791 RVA: 0x0000A71A File Offset: 0x0000891A
		public unsafe int m_PendingFocusCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr_m_PendingFocusCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr_m_PendingFocusCount)) = value;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x0006D618 File Offset: 0x0006B818
		// (set) Token: 0x060016A1 RID: 5793 RVA: 0x0000A735 File Offset: 0x00008935
		public unsafe int _imguiKeyboardControl_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr__imguiKeyboardControl_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.NativeFieldInfoPtr__imguiKeyboardControl_k__BackingField)) = value;
			}
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x0000A758 File Offset: 0x00008958
		public void ClearPendingFocusEvents()
		{
			this.m_PendingFocusCount = 0;
			this.m_LastPendingFocusedElement = null;
		}

		// Token: 0x04000F4E RID: 3918
		private static readonly IntPtr NativeFieldInfoPtr__focusRing_k__BackingField;

		// Token: 0x04000F4F RID: 3919
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedTextElement;

		// Token: 0x04000F50 RID: 3920
		private static readonly IntPtr NativeFieldInfoPtr_m_FocusedElements;

		// Token: 0x04000F51 RID: 3921
		private static readonly IntPtr NativeFieldInfoPtr_m_LastFocusedElement;

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeFieldInfoPtr_m_LastPendingFocusedElement;

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeFieldInfoPtr_m_PendingFocusCount;

		// Token: 0x04000F54 RID: 3924
		private static readonly IntPtr NativeFieldInfoPtr__imguiKeyboardControl_k__BackingField;

		// Token: 0x04000F55 RID: 3925
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IFocusRing_0;

		// Token: 0x04000F56 RID: 3926
		private static readonly IntPtr NativeMethodInfoPtr_get_focusRing_Private_get_IFocusRing_0;

		// Token: 0x04000F57 RID: 3927
		private static readonly IntPtr NativeMethodInfoPtr_set_selectedTextElement_Internal_set_Void_TextElement_0;

		// Token: 0x04000F58 RID: 3928
		private static readonly IntPtr NativeMethodInfoPtr_get_focusedElement_Public_get_Focusable_0;

		// Token: 0x04000F59 RID: 3929
		private static readonly IntPtr NativeMethodInfoPtr_IsFocused_Internal_Boolean_Focusable_0;

		// Token: 0x04000F5A RID: 3930
		private static readonly IntPtr NativeMethodInfoPtr_GetRetargetedFocusedElement_Internal_Focusable_VisualElement_0;

		// Token: 0x04000F5B RID: 3931
		private static readonly IntPtr NativeMethodInfoPtr_GetLeafFocusedElement_Internal_Focusable_0;

		// Token: 0x04000F5C RID: 3932
		private static readonly IntPtr NativeMethodInfoPtr_IsLocalElement_Private_Boolean_Focusable_0;

		// Token: 0x04000F5D RID: 3933
		private static readonly IntPtr NativeMethodInfoPtr_IsPendingFocus_Internal_Boolean_Focusable_0;

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeMethodInfoPtr_SetFocusToLastFocusedElement_Internal_Void_0;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeMethodInfoPtr_BlurLastFocusedElement_Internal_Void_0;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeMethodInfoPtr_DoFocusChange_Internal_Void_Focusable_0;

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPendingFocusChange_Internal_Void_Focusable_0;

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeMethodInfoPtr_FocusNextInDirection_Internal_Focusable_FocusChangeDirection_0;

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeMethodInfoPtr_AboutToReleaseFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_DispatchMode_0;

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_DispatchMode_0;

		// Token: 0x04000F65 RID: 3941
		private static readonly IntPtr NativeMethodInfoPtr_AboutToGrabFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_DispatchMode_0;

		// Token: 0x04000F66 RID: 3942
		private static readonly IntPtr NativeMethodInfoPtr_GrabFocus_Private_Void_Focusable_Focusable_FocusChangeDirection_Boolean_DispatchMode_0;

		// Token: 0x04000F67 RID: 3943
		private static readonly IntPtr NativeMethodInfoPtr_Blur_Internal_Void_Focusable_Boolean_DispatchMode_0;

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeMethodInfoPtr_SwitchFocus_Internal_Void_Focusable_Boolean_DispatchMode_0;

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeMethodInfoPtr_SwitchFocus_Internal_Void_Focusable_FocusChangeDirection_Boolean_DispatchMode_0;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeMethodInfoPtr_SwitchFocusOnEvent_Internal_Void_EventBase_0;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeMethodInfoPtr_ReevaluateFocus_Internal_Void_0;

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeMethodInfoPtr_GetFocusableParentForPointerEvent_Internal_Boolean_Focusable_byref_Focusable_0;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeMethodInfoPtr_get_imguiKeyboardControl_Internal_get_Int32_0;

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeMethodInfoPtr_set_imguiKeyboardControl_Internal_set_Void_Int32_0;

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeMethodInfoPtr_SyncIMGUIFocus_Internal_Void_Int32_Focusable_Boolean_0;

		// Token: 0x02000465 RID: 1125
		public sealed class FocusedElement : ValueType
		{
			// Token: 0x06003BE4 RID: 15332 RVA: 0x000F0E48 File Offset: 0x000EF048
			// Note: this type is marked as 'beforefieldinit'.
			static FocusedElement()
			{
				Il2CppClassPointerStore<FocusController.FocusedElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FocusController>.NativeClassPtr, "FocusedElement");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FocusController.FocusedElement>.NativeClassPtr);
				FocusController.FocusedElement.NativeFieldInfoPtr_m_SubTreeRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusController.FocusedElement>.NativeClassPtr, "m_SubTreeRoot");
				FocusController.FocusedElement.NativeFieldInfoPtr_m_FocusedElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusController.FocusedElement>.NativeClassPtr, "m_FocusedElement");
			}

			// Token: 0x06003BE5 RID: 15333 RVA: 0x000191F1 File Offset: 0x000173F1
			public FocusedElement(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003BE6 RID: 15334 RVA: 0x000191FA File Offset: 0x000173FA
			public FocusedElement()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FocusController.FocusedElement>.NativeClassPtr))
			{
			}

			// Token: 0x17001230 RID: 4656
			// (get) Token: 0x06003BE7 RID: 15335 RVA: 0x000F0E9C File Offset: 0x000EF09C
			// (set) Token: 0x06003BE8 RID: 15336 RVA: 0x0001920C File Offset: 0x0001740C
			public unsafe VisualElement m_SubTreeRoot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.FocusedElement.NativeFieldInfoPtr_m_SubTreeRoot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.FocusedElement.NativeFieldInfoPtr_m_SubTreeRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001231 RID: 4657
			// (get) Token: 0x06003BE9 RID: 15337 RVA: 0x000F0ECC File Offset: 0x000EF0CC
			// (set) Token: 0x06003BEA RID: 15338 RVA: 0x0001922B File Offset: 0x0001742B
			public unsafe Focusable m_FocusedElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.FocusedElement.NativeFieldInfoPtr_m_FocusedElement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusController.FocusedElement.NativeFieldInfoPtr_m_FocusedElement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A3B RID: 10811
			private static readonly IntPtr NativeFieldInfoPtr_m_SubTreeRoot;

			// Token: 0x04002A3C RID: 10812
			private static readonly IntPtr NativeFieldInfoPtr_m_FocusedElement;
		}
	}
}
