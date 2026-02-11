using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001D8 RID: 472
	public class TextSelectingManipulator : Object
	{
		// Token: 0x0600249B RID: 9371 RVA: 0x000A3E38 File Offset: 0x000A2038
		// Note: this type is marked as 'beforefieldinit'.
		static TextSelectingManipulator()
		{
			Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TextSelectingManipulator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr);
			TextSelectingManipulator.NativeFieldInfoPtr_m_SelectingUtilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, "m_SelectingUtilities");
			TextSelectingManipulator.NativeFieldInfoPtr_selectAllOnMouseUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, "selectAllOnMouseUp");
			TextSelectingManipulator.NativeFieldInfoPtr_m_TextElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, "m_TextElement");
			TextSelectingManipulator.NativeFieldInfoPtr_m_ClickStartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, "m_ClickStartPosition");
			TextSelectingManipulator.NativeFieldInfoPtr_m_Dragged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, "m_Dragged");
			TextSelectingManipulator.NativeFieldInfoPtr_m_IsClicking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, "m_IsClicking");
			TextSelectingManipulator.NativeFieldInfoPtr_k_DragThresholdSqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, "k_DragThresholdSqr");
			TextSelectingManipulator.NativeFieldInfoPtr_m_ConsecutiveMouseDownCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, "m_ConsecutiveMouseDownCount");
			TextSelectingManipulator.NativeFieldInfoPtr_m_LastMouseDownTimeStamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, "m_LastMouseDownTimeStamp");
			TextSelectingManipulator.NativeFieldInfoPtr_m_ImguiEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, "m_ImguiEvent");
			TextSelectingManipulator.NativeMethodInfoPtr_get_isClicking_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668835);
			TextSelectingManipulator.NativeMethodInfoPtr_set_isClicking_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668836);
			TextSelectingManipulator.NativeMethodInfoPtr__ctor_Public_Void_TextElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668837);
			TextSelectingManipulator.NativeMethodInfoPtr_get_cursorIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668838);
			TextSelectingManipulator.NativeMethodInfoPtr_set_cursorIndex_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668839);
			TextSelectingManipulator.NativeMethodInfoPtr_get_selectIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668840);
			TextSelectingManipulator.NativeMethodInfoPtr_set_selectIndex_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668841);
			TextSelectingManipulator.NativeMethodInfoPtr_OnRevealCursor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668842);
			TextSelectingManipulator.NativeMethodInfoPtr_OnSelectIndexChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668843);
			TextSelectingManipulator.NativeMethodInfoPtr_OnCursorIndexChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668844);
			TextSelectingManipulator.NativeMethodInfoPtr_RevealCursor_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668845);
			TextSelectingManipulator.NativeMethodInfoPtr_HasSelection_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668846);
			TextSelectingManipulator.NativeMethodInfoPtr_HasFocus_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668847);
			TextSelectingManipulator.NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Internal_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668848);
			TextSelectingManipulator.NativeMethodInfoPtr_OnFocusEvent_Private_Void_FocusEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668849);
			TextSelectingManipulator.NativeMethodInfoPtr_OnBlurEvent_Private_Void_BlurEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668850);
			TextSelectingManipulator.NativeMethodInfoPtr_OnKeyDown_Private_Void_KeyDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668851);
			TextSelectingManipulator.NativeMethodInfoPtr_OnPointerDownEvent_Private_Void_PointerDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668852);
			TextSelectingManipulator.NativeMethodInfoPtr_OnPointerMoveEvent_Private_Void_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668853);
			TextSelectingManipulator.NativeMethodInfoPtr_OnPointerUpEvent_Private_Void_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668854);
			TextSelectingManipulator.NativeMethodInfoPtr_OnValidateCommandEvent_Private_Void_ValidateCommandEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668855);
			TextSelectingManipulator.NativeMethodInfoPtr_OnExecuteCommandEvent_Private_Void_ExecuteCommandEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668856);
			TextSelectingManipulator.NativeMethodInfoPtr_MoveDistanceQualifiesForDrag_Private_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr, 100668857);
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x0600249C RID: 9372 RVA: 0x000A40FC File Offset: 0x000A22FC
		// (set) Token: 0x0600249D RID: 9373 RVA: 0x000A4138 File Offset: 0x000A2338
		public unsafe bool isClicking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_get_isClicking_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_set_isClicking_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x000A4178 File Offset: 0x000A2378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338698, RefRangeEnd = 338699, XrefRangeStart = 338648, XrefRangeEnd = 338698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextSelectingManipulator(TextElement textElement)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextSelectingManipulator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textElement);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr__ctor_Public_Void_TextElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x0600249F RID: 9375 RVA: 0x000A41C4 File Offset: 0x000A23C4
		// (set) Token: 0x060024A0 RID: 9376 RVA: 0x000A4200 File Offset: 0x000A2400
		public unsafe int cursorIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 338700, RefRangeEnd = 338701, XrefRangeStart = 338699, XrefRangeEnd = 338700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_get_cursorIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 338703, RefRangeEnd = 338704, XrefRangeStart = 338701, XrefRangeEnd = 338703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_set_cursorIndex_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060024A1 RID: 9377 RVA: 0x000A4240 File Offset: 0x000A2440
		// (set) Token: 0x060024A2 RID: 9378 RVA: 0x000A427C File Offset: 0x000A247C
		public unsafe int selectIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 338705, RefRangeEnd = 338706, XrefRangeStart = 338704, XrefRangeEnd = 338705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_get_selectIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 338708, RefRangeEnd = 338709, XrefRangeStart = 338706, XrefRangeEnd = 338708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_set_selectIndex_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x000A42BC File Offset: 0x000A24BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338709, XrefRangeEnd = 338711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRevealCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_OnRevealCursor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x000A42F0 File Offset: 0x000A24F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338711, XrefRangeEnd = 338718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSelectIndexChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_OnSelectIndexChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x000A4324 File Offset: 0x000A2524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338718, XrefRangeEnd = 338725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCursorIndexChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_OnCursorIndexChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x000A4358 File Offset: 0x000A2558
		[CallerCount(0)]
		public unsafe bool RevealCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_RevealCursor_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x000A4394 File Offset: 0x000A2594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338725, XrefRangeEnd = 338727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_HasSelection_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x000A43D0 File Offset: 0x000A25D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338729, RefRangeEnd = 338730, XrefRangeStart = 338727, XrefRangeEnd = 338729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_HasFocus_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x000A440C File Offset: 0x000A260C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338825, RefRangeEnd = 338826, XrefRangeStart = 338730, XrefRangeEnd = 338825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteDefaultActionAtTarget(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Internal_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x000A4450 File Offset: 0x000A2650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338826, XrefRangeEnd = 338849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFocusEvent(FocusEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_OnFocusEvent_Private_Void_FocusEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x000A4494 File Offset: 0x000A2694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338849, XrefRangeEnd = 338853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBlurEvent(BlurEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_OnBlurEvent_Private_Void_BlurEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x000A44D8 File Offset: 0x000A26D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338853, XrefRangeEnd = 338857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnKeyDown(KeyDownEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_OnKeyDown_Private_Void_KeyDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x000A451C File Offset: 0x000A271C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338895, RefRangeEnd = 338896, XrefRangeStart = 338857, XrefRangeEnd = 338895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerDownEvent(PointerDownEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_OnPointerDownEvent_Private_Void_PointerDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x000A4560 File Offset: 0x000A2760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338911, RefRangeEnd = 338912, XrefRangeStart = 338896, XrefRangeEnd = 338911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerMoveEvent(PointerMoveEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_OnPointerMoveEvent_Private_Void_PointerMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x000A45A4 File Offset: 0x000A27A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338912, XrefRangeEnd = 338917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerUpEvent(PointerUpEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_OnPointerUpEvent_Private_Void_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x000A45E8 File Offset: 0x000A27E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338917, XrefRangeEnd = 338938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidateCommandEvent(ValidateCommandEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_OnValidateCommandEvent_Private_Void_ValidateCommandEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x000A462C File Offset: 0x000A282C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338938, XrefRangeEnd = 338951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnExecuteCommandEvent(ExecuteCommandEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_OnExecuteCommandEvent_Private_Void_ExecuteCommandEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x000A4670 File Offset: 0x000A2870
		[CallerCount(0)]
		public unsafe bool MoveDistanceQualifiesForDrag(Vector2 start, Vector2 current)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref current;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingManipulator.NativeMethodInfoPtr_MoveDistanceQualifiesForDrag_Private_Boolean_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x0000F132 File Offset: 0x0000D332
		public TextSelectingManipulator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x060024B4 RID: 9396 RVA: 0x000A46C8 File Offset: 0x000A28C8
		// (set) Token: 0x060024B5 RID: 9397 RVA: 0x0000F13B File Offset: 0x0000D33B
		public unsafe TextSelectingUtilities m_SelectingUtilities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingManipulator.NativeFieldInfoPtr_m_SelectingUtilities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextSelectingUtilities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingManipulator.NativeFieldInfoPtr_m_SelectingUtilities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x000A46F8 File Offset: 0x000A28F8
		// (set) Token: 0x060024B7 RID: 9399 RVA: 0x0000F15A File Offset: 0x0000D35A
		public unsafe bool selectAllOnMouseUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingManipulator.NativeFieldInfoPtr_selectAllOnMouseUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingManipulator.NativeFieldInfoPtr_selectAllOnMouseUp)) = value;
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x060024B8 RID: 9400 RVA: 0x000A4720 File Offset: 0x000A2920
		// (set) Token: 0x060024B9 RID: 9401 RVA: 0x0000F175 File Offset: 0x0000D375
		public unsafe TextElement m_TextElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingManipulator.NativeFieldInfoPtr_m_TextElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingManipulator.NativeFieldInfoPtr_m_TextElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x060024BA RID: 9402 RVA: 0x000A4750 File Offset: 0x000A2950
		// (set) Token: 0x060024BB RID: 9403 RVA: 0x0000F194 File Offset: 0x0000D394
		public unsafe Vector2 m_ClickStartPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingManipulator.NativeFieldInfoPtr_m_ClickStartPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingManipulator.NativeFieldInfoPtr_m_ClickStartPosition)) = value;
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x060024BC RID: 9404 RVA: 0x000A4778 File Offset: 0x000A2978
		// (set) Token: 0x060024BD RID: 9405 RVA: 0x0000F1AF File Offset: 0x0000D3AF
		public unsafe bool m_Dragged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingManipulator.NativeFieldInfoPtr_m_Dragged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingManipulator.NativeFieldInfoPtr_m_Dragged)) = value;
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x060024BE RID: 9406 RVA: 0x000A47A0 File Offset: 0x000A29A0
		// (set) Token: 0x060024BF RID: 9407 RVA: 0x0000F1CA File Offset: 0x0000D3CA
		public unsafe bool m_IsClicking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingManipulator.NativeFieldInfoPtr_m_IsClicking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingManipulator.NativeFieldInfoPtr_m_IsClicking)) = value;
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x060024C0 RID: 9408 RVA: 0x000A47C8 File Offset: 0x000A29C8
		// (set) Token: 0x060024C1 RID: 9409 RVA: 0x0000F1E5 File Offset: 0x0000D3E5
		public unsafe static int k_DragThresholdSqr
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextSelectingManipulator.NativeFieldInfoPtr_k_DragThresholdSqr, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextSelectingManipulator.NativeFieldInfoPtr_k_DragThresholdSqr, (void*)(&value));
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x060024C2 RID: 9410 RVA: 0x000A47E4 File Offset: 0x000A29E4
		// (set) Token: 0x060024C3 RID: 9411 RVA: 0x0000F1F3 File Offset: 0x0000D3F3
		public unsafe int m_ConsecutiveMouseDownCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingManipulator.NativeFieldInfoPtr_m_ConsecutiveMouseDownCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingManipulator.NativeFieldInfoPtr_m_ConsecutiveMouseDownCount)) = value;
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x060024C4 RID: 9412 RVA: 0x000A480C File Offset: 0x000A2A0C
		// (set) Token: 0x060024C5 RID: 9413 RVA: 0x0000F20E File Offset: 0x0000D40E
		public unsafe long m_LastMouseDownTimeStamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingManipulator.NativeFieldInfoPtr_m_LastMouseDownTimeStamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingManipulator.NativeFieldInfoPtr_m_LastMouseDownTimeStamp)) = value;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x060024C6 RID: 9414 RVA: 0x000A4834 File Offset: 0x000A2A34
		// (set) Token: 0x060024C7 RID: 9415 RVA: 0x0000F229 File Offset: 0x0000D429
		public unsafe Event m_ImguiEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingManipulator.NativeFieldInfoPtr_m_ImguiEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingManipulator.NativeFieldInfoPtr_m_ImguiEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A4E RID: 6734
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectingUtilities;

		// Token: 0x04001A4F RID: 6735
		private static readonly IntPtr NativeFieldInfoPtr_selectAllOnMouseUp;

		// Token: 0x04001A50 RID: 6736
		private static readonly IntPtr NativeFieldInfoPtr_m_TextElement;

		// Token: 0x04001A51 RID: 6737
		private static readonly IntPtr NativeFieldInfoPtr_m_ClickStartPosition;

		// Token: 0x04001A52 RID: 6738
		private static readonly IntPtr NativeFieldInfoPtr_m_Dragged;

		// Token: 0x04001A53 RID: 6739
		private static readonly IntPtr NativeFieldInfoPtr_m_IsClicking;

		// Token: 0x04001A54 RID: 6740
		private static readonly IntPtr NativeFieldInfoPtr_k_DragThresholdSqr;

		// Token: 0x04001A55 RID: 6741
		private static readonly IntPtr NativeFieldInfoPtr_m_ConsecutiveMouseDownCount;

		// Token: 0x04001A56 RID: 6742
		private static readonly IntPtr NativeFieldInfoPtr_m_LastMouseDownTimeStamp;

		// Token: 0x04001A57 RID: 6743
		private static readonly IntPtr NativeFieldInfoPtr_m_ImguiEvent;

		// Token: 0x04001A58 RID: 6744
		private static readonly IntPtr NativeMethodInfoPtr_get_isClicking_Internal_get_Boolean_0;

		// Token: 0x04001A59 RID: 6745
		private static readonly IntPtr NativeMethodInfoPtr_set_isClicking_Internal_set_Void_Boolean_0;

		// Token: 0x04001A5A RID: 6746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextElement_0;

		// Token: 0x04001A5B RID: 6747
		private static readonly IntPtr NativeMethodInfoPtr_get_cursorIndex_Internal_get_Int32_0;

		// Token: 0x04001A5C RID: 6748
		private static readonly IntPtr NativeMethodInfoPtr_set_cursorIndex_Internal_set_Void_Int32_0;

		// Token: 0x04001A5D RID: 6749
		private static readonly IntPtr NativeMethodInfoPtr_get_selectIndex_Internal_get_Int32_0;

		// Token: 0x04001A5E RID: 6750
		private static readonly IntPtr NativeMethodInfoPtr_set_selectIndex_Internal_set_Void_Int32_0;

		// Token: 0x04001A5F RID: 6751
		private static readonly IntPtr NativeMethodInfoPtr_OnRevealCursor_Private_Void_0;

		// Token: 0x04001A60 RID: 6752
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectIndexChange_Private_Void_0;

		// Token: 0x04001A61 RID: 6753
		private static readonly IntPtr NativeMethodInfoPtr_OnCursorIndexChange_Private_Void_0;

		// Token: 0x04001A62 RID: 6754
		private static readonly IntPtr NativeMethodInfoPtr_RevealCursor_Internal_Boolean_0;

		// Token: 0x04001A63 RID: 6755
		private static readonly IntPtr NativeMethodInfoPtr_HasSelection_Internal_Boolean_0;

		// Token: 0x04001A64 RID: 6756
		private static readonly IntPtr NativeMethodInfoPtr_HasFocus_Internal_Boolean_0;

		// Token: 0x04001A65 RID: 6757
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Internal_Void_EventBase_0;

		// Token: 0x04001A66 RID: 6758
		private static readonly IntPtr NativeMethodInfoPtr_OnFocusEvent_Private_Void_FocusEvent_0;

		// Token: 0x04001A67 RID: 6759
		private static readonly IntPtr NativeMethodInfoPtr_OnBlurEvent_Private_Void_BlurEvent_0;

		// Token: 0x04001A68 RID: 6760
		private static readonly IntPtr NativeMethodInfoPtr_OnKeyDown_Private_Void_KeyDownEvent_0;

		// Token: 0x04001A69 RID: 6761
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDownEvent_Private_Void_PointerDownEvent_0;

		// Token: 0x04001A6A RID: 6762
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerMoveEvent_Private_Void_PointerMoveEvent_0;

		// Token: 0x04001A6B RID: 6763
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUpEvent_Private_Void_PointerUpEvent_0;

		// Token: 0x04001A6C RID: 6764
		private static readonly IntPtr NativeMethodInfoPtr_OnValidateCommandEvent_Private_Void_ValidateCommandEvent_0;

		// Token: 0x04001A6D RID: 6765
		private static readonly IntPtr NativeMethodInfoPtr_OnExecuteCommandEvent_Private_Void_ExecuteCommandEvent_0;

		// Token: 0x04001A6E RID: 6766
		private static readonly IntPtr NativeMethodInfoPtr_MoveDistanceQualifiesForDrag_Private_Boolean_Vector2_Vector2_0;
	}
}
