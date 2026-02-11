using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000014 RID: 20
	public class GUIUtility : Object
	{
		// Token: 0x0600041A RID: 1050 RVA: 0x0000F9E0 File Offset: 0x0000DBE0
		// Note: this type is marked as 'beforefieldinit'.
		static GUIUtility()
		{
			Il2CppClassPointerStore<GUIUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr);
			GUIUtility.NativeFieldInfoPtr_s_ControlCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "s_ControlCount");
			GUIUtility.NativeFieldInfoPtr_s_SkinMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "s_SkinMode");
			GUIUtility.NativeFieldInfoPtr_s_OriginalID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "s_OriginalID");
			GUIUtility.NativeFieldInfoPtr_takeCapture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "takeCapture");
			GUIUtility.NativeFieldInfoPtr_releaseCapture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "releaseCapture");
			GUIUtility.NativeFieldInfoPtr_processEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "processEvent");
			GUIUtility.NativeFieldInfoPtr_cleanupRoots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "cleanupRoots");
			GUIUtility.NativeFieldInfoPtr_endContainerGUIFromException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "endContainerGUIFromException");
			GUIUtility.NativeFieldInfoPtr_guiChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "guiChanged");
			GUIUtility.NativeFieldInfoPtr_beforeEventProcessed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "beforeEventProcessed");
			GUIUtility.NativeFieldInfoPtr_m_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "m_Event");
			GUIUtility.NativeFieldInfoPtr__guiIsExiting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "<guiIsExiting>k__BackingField");
			GUIUtility.NativeFieldInfoPtr_s_HasCurrentWindowKeyFocusFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "s_HasCurrentWindowKeyFocusFunc");
			GUIUtility.NativeMethodInfoPtr_get_pixelsPerPoint_Internal_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663556);
			GUIUtility.NativeMethodInfoPtr_get_guiDepth_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663557);
			GUIUtility.NativeMethodInfoPtr_get_textFieldInput_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663558);
			GUIUtility.NativeMethodInfoPtr_get_systemCopyBuffer_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663559);
			GUIUtility.NativeMethodInfoPtr_set_systemCopyBuffer_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663560);
			GUIUtility.NativeMethodInfoPtr_Internal_GetControlID_Private_Static_Int32_Int32_FocusType_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663561);
			GUIUtility.NativeMethodInfoPtr_GetControlID_Public_Static_Int32_Int32_FocusType_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663562);
			GUIUtility.NativeMethodInfoPtr_BeginContainerFromOwner_Internal_Static_Void_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663563);
			GUIUtility.NativeMethodInfoPtr_BeginContainer_Internal_Static_Void_ObjectGUIState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663564);
			GUIUtility.NativeMethodInfoPtr_Internal_EndContainer_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663565);
			GUIUtility.NativeMethodInfoPtr_CheckForTabEvent_Internal_Static_Int32_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663566);
			GUIUtility.NativeMethodInfoPtr_SetKeyboardControlToFirstControlId_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663567);
			GUIUtility.NativeMethodInfoPtr_SetKeyboardControlToLastControlId_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663568);
			GUIUtility.NativeMethodInfoPtr_HasFocusableControls_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663569);
			GUIUtility.NativeMethodInfoPtr_OwnsId_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663570);
			GUIUtility.NativeMethodInfoPtr_AlignRectToDevice_Public_Static_Rect_Rect_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663571);
			GUIUtility.NativeMethodInfoPtr_get_compositionString_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663572);
			GUIUtility.NativeMethodInfoPtr_set_imeCompositionMode_Internal_Static_set_Void_IMECompositionMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663573);
			GUIUtility.NativeMethodInfoPtr_set_compositionCursorPos_Internal_Static_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663574);
			GUIUtility.NativeMethodInfoPtr_Internal_GetHotControl_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663575);
			GUIUtility.NativeMethodInfoPtr_Internal_GetKeyboardControl_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663576);
			GUIUtility.NativeMethodInfoPtr_Internal_SetHotControl_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663577);
			GUIUtility.NativeMethodInfoPtr_Internal_SetKeyboardControl_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663578);
			GUIUtility.NativeMethodInfoPtr_Internal_GetDefaultSkin_Private_Static_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663579);
			GUIUtility.NativeMethodInfoPtr_Internal_ExitGUI_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663580);
			GUIUtility.NativeMethodInfoPtr_MarkGUIChanged_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663581);
			GUIUtility.NativeMethodInfoPtr_GetControlID_Public_Static_Int32_Int32_FocusType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663582);
			GUIUtility.NativeMethodInfoPtr_set_guiIsExiting_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663583);
			GUIUtility.NativeMethodInfoPtr_get_hotControl_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663584);
			GUIUtility.NativeMethodInfoPtr_set_hotControl_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663585);
			GUIUtility.NativeMethodInfoPtr_TakeCapture_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663586);
			GUIUtility.NativeMethodInfoPtr_RemoveCapture_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663587);
			GUIUtility.NativeMethodInfoPtr_get_keyboardControl_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663588);
			GUIUtility.NativeMethodInfoPtr_set_keyboardControl_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663589);
			GUIUtility.NativeMethodInfoPtr_HasKeyFocus_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663590);
			GUIUtility.NativeMethodInfoPtr_ExitGUI_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663591);
			GUIUtility.NativeMethodInfoPtr_GetDefaultSkin_Internal_Static_GUISkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663592);
			GUIUtility.NativeMethodInfoPtr_ProcessEvent_Internal_Static_Void_Int32_IntPtr_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663593);
			GUIUtility.NativeMethodInfoPtr_EndContainer_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663594);
			GUIUtility.NativeMethodInfoPtr_BeginGUI_Internal_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663595);
			GUIUtility.NativeMethodInfoPtr_DestroyGUI_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663596);
			GUIUtility.NativeMethodInfoPtr_EndGUI_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663597);
			GUIUtility.NativeMethodInfoPtr_EndGUIFromException_Internal_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663598);
			GUIUtility.NativeMethodInfoPtr_EndContainerGUIFromException_Internal_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663599);
			GUIUtility.NativeMethodInfoPtr_ResetGlobalState_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663600);
			GUIUtility.NativeMethodInfoPtr_IsExitGUIException_Internal_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663601);
			GUIUtility.NativeMethodInfoPtr_ShouldRethrowException_Internal_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663602);
			GUIUtility.NativeMethodInfoPtr_CheckOnGUI_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663603);
			GUIUtility.NativeMethodInfoPtr_RoundToPixelGrid_Internal_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663604);
			GUIUtility.NativeMethodInfoPtr_AlignRectToDevice_Public_Static_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663605);
			GUIUtility.NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663606);
			GUIUtility.NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663607);
			GUIUtility.NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663608);
			GUIUtility.NativeMethodInfoPtr_Internal_GetControlID_Injected_Private_Static_Int32_Int32_FocusType_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663610);
			GUIUtility.NativeMethodInfoPtr_AlignRectToDevice_Injected_Private_Static_Void_byref_Rect_byref_Int32_byref_Int32_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663611);
			GUIUtility.NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663612);
			GUIUtility.get_hasModalWindowDelegateField = IL2CPP.ResolveICall<GUIUtility.get_hasModalWindowDelegate>("UnityEngine.GUIUtility::get_hasModalWindow");
			GUIUtility.get_mouseUsedDelegateField = IL2CPP.ResolveICall<GUIUtility.get_mouseUsedDelegate>("UnityEngine.GUIUtility::get_mouseUsed");
			GUIUtility.set_mouseUsedDelegateField = IL2CPP.ResolveICall<GUIUtility.set_mouseUsedDelegate>("UnityEngine.GUIUtility::set_mouseUsed");
			GUIUtility.set_textFieldInputDelegateField = IL2CPP.ResolveICall<GUIUtility.set_textFieldInputDelegate>("UnityEngine.GUIUtility::set_textFieldInput");
			GUIUtility.get_manualTex2SRGBEnabledDelegateField = IL2CPP.ResolveICall<GUIUtility.get_manualTex2SRGBEnabledDelegate>("UnityEngine.GUIUtility::get_manualTex2SRGBEnabled");
			GUIUtility.set_manualTex2SRGBEnabledDelegateField = IL2CPP.ResolveICall<GUIUtility.set_manualTex2SRGBEnabledDelegate>("UnityEngine.GUIUtility::set_manualTex2SRGBEnabled");
			GUIUtility.GetPermanentControlIDDelegateField = IL2CPP.ResolveICall<GUIUtility.GetPermanentControlIDDelegate>("UnityEngine.GUIUtility::GetPermanentControlID");
			GUIUtility.get_imeCompositionModeDelegateField = IL2CPP.ResolveICall<GUIUtility.get_imeCompositionModeDelegate>("UnityEngine.GUIUtility::get_imeCompositionMode");
			GUIUtility.GetChangedDelegateField = IL2CPP.ResolveICall<GUIUtility.GetChangedDelegate>("UnityEngine.GUIUtility::GetChanged");
			GUIUtility.SetChangedDelegateField = IL2CPP.ResolveICall<GUIUtility.SetChangedDelegate>("UnityEngine.GUIUtility::SetChanged");
			GUIUtility.SetDidGUIWindowsEatLastEventDelegateField = IL2CPP.ResolveICall<GUIUtility.SetDidGUIWindowsEatLastEventDelegate>("UnityEngine.GUIUtility::SetDidGUIWindowsEatLastEvent");
			GUIUtility.Internal_GetBuiltinSkinDelegateField = IL2CPP.ResolveICall<GUIUtility.Internal_GetBuiltinSkinDelegate>("UnityEngine.GUIUtility::Internal_GetBuiltinSkin");
			GUIUtility.get_s_EditorScreenPointOffset_InjectedDelegateField = IL2CPP.ResolveICall<GUIUtility.get_s_EditorScreenPointOffset_InjectedDelegate>("UnityEngine.GUIUtility::get_s_EditorScreenPointOffset_Injected");
			GUIUtility.set_s_EditorScreenPointOffset_InjectedDelegateField = IL2CPP.ResolveICall<GUIUtility.set_s_EditorScreenPointOffset_InjectedDelegate>("UnityEngine.GUIUtility::set_s_EditorScreenPointOffset_Injected");
			GUIUtility.get_compositionCursorPos_InjectedDelegateField = IL2CPP.ResolveICall<GUIUtility.get_compositionCursorPos_InjectedDelegate>("UnityEngine.GUIUtility::get_compositionCursorPos_Injected");
			GUIUtility.Internal_MultiplyPoint_InjectedDelegateField = IL2CPP.ResolveICall<GUIUtility.Internal_MultiplyPoint_InjectedDelegate>("UnityEngine.GUIUtility::Internal_MultiplyPoint_Injected");
			GUIUtility.InternalWindowToScreenPoint_InjectedDelegateField = IL2CPP.ResolveICall<GUIUtility.InternalWindowToScreenPoint_InjectedDelegate>("UnityEngine.GUIUtility::InternalWindowToScreenPoint_Injected");
			GUIUtility.InternalScreenToWindowPoint_InjectedDelegateField = IL2CPP.ResolveICall<GUIUtility.InternalScreenToWindowPoint_InjectedDelegate>("UnityEngine.GUIUtility::InternalScreenToWindowPoint_Injected");
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x00010084 File Offset: 0x0000E284
		public unsafe static float pixelsPerPoint
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1187300, RefRangeEnd = 1187308, XrefRangeStart = 1187298, XrefRangeEnd = 1187300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_get_pixelsPerPoint_Internal_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x000100B4 File Offset: 0x0000E2B4
		public unsafe static int guiDepth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187308, XrefRangeEnd = 1187310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_get_guiDepth_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x000100E4 File Offset: 0x0000E2E4
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x00003E84 File Offset: 0x00002084
		public unsafe static bool textFieldInput
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187310, XrefRangeEnd = 1187312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_get_textFieldInput_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				GUIUtility.set_textFieldInputDelegateField(value);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00010114 File Offset: 0x0000E314
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00010140 File Offset: 0x0000E340
		public unsafe static string systemCopyBuffer
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1187314, RefRangeEnd = 1187318, XrefRangeStart = 1187312, XrefRangeEnd = 1187314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_get_systemCopyBuffer_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1187320, RefRangeEnd = 1187323, XrefRangeStart = 1187318, XrefRangeEnd = 1187320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_set_systemCopyBuffer_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00010178 File Offset: 0x0000E378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187323, XrefRangeEnd = 1187328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_GetControlID(int hint, FocusType focusType, Rect rect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hint;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref focusType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_Internal_GetControlID_Private_Static_Int32_Int32_FocusType_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000101D4 File Offset: 0x0000E3D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1187337, RefRangeEnd = 1187340, XrefRangeStart = 1187328, XrefRangeEnd = 1187337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetControlID(int hint, FocusType focusType, Rect rect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hint;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref focusType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_GetControlID_Public_Static_Int32_Int32_FocusType_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00010230 File Offset: 0x0000E430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1187342, RefRangeEnd = 1187343, XrefRangeStart = 1187340, XrefRangeEnd = 1187342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginContainerFromOwner(ScriptableObject owner)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_BeginContainerFromOwner_Internal_Static_Void_ScriptableObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00010268 File Offset: 0x0000E468
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1187345, RefRangeEnd = 1187346, XrefRangeStart = 1187343, XrefRangeEnd = 1187345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginContainer(ObjectGUIState objectGUIState)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectGUIState);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_BeginContainer_Internal_Static_Void_ObjectGUIState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x000102A0 File Offset: 0x0000E4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187346, XrefRangeEnd = 1187348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_EndContainer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_Internal_EndContainer_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000102C8 File Offset: 0x0000E4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187348, XrefRangeEnd = 1187350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CheckForTabEvent(Event evt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_CheckForTabEvent_Internal_Static_Int32_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0001030C File Offset: 0x0000E50C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1187352, RefRangeEnd = 1187354, XrefRangeStart = 1187350, XrefRangeEnd = 1187352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetKeyboardControlToFirstControlId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_SetKeyboardControlToFirstControlId_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00010334 File Offset: 0x0000E534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1187356, RefRangeEnd = 1187357, XrefRangeStart = 1187354, XrefRangeEnd = 1187356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetKeyboardControlToLastControlId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_SetKeyboardControlToLastControlId_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0001035C File Offset: 0x0000E55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187357, XrefRangeEnd = 1187359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasFocusableControls()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_HasFocusableControls_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0001038C File Offset: 0x0000E58C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1187361, RefRangeEnd = 1187362, XrefRangeStart = 1187359, XrefRangeEnd = 1187361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool OwnsId(int id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_OwnsId_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000103CC File Offset: 0x0000E5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187362, XrefRangeEnd = 1187367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &widthInPixels;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &heightInPixels;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_AlignRectToDevice_Public_Static_Rect_Rect_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00010428 File Offset: 0x0000E628
		public unsafe static string compositionString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187367, XrefRangeEnd = 1187369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_get_compositionString_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00003EB6 File Offset: 0x000020B6
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00010454 File Offset: 0x0000E654
		public unsafe static IMECompositionMode imeCompositionMode
		{
			get
			{
				return GUIUtility.get_imeCompositionModeDelegateField();
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1187371, RefRangeEnd = 1187375, XrefRangeStart = 1187369, XrefRangeEnd = 1187371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_set_imeCompositionMode_Internal_Static_set_Void_IMECompositionMode_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00010F3C File Offset: 0x0000F13C
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00010488 File Offset: 0x0000E688
		public unsafe static Vector2 compositionCursorPos
		{
			get
			{
				Vector2 vector;
				GUIUtility.get_compositionCursorPos_Injected(out vector);
				return vector;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187375, XrefRangeEnd = 1187380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_set_compositionCursorPos_Internal_Static_set_Void_Vector2_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000104BC File Offset: 0x0000E6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187380, XrefRangeEnd = 1187382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_GetHotControl()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_Internal_GetHotControl_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000104EC File Offset: 0x0000E6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187382, XrefRangeEnd = 1187384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_GetKeyboardControl()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_Internal_GetKeyboardControl_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0001051C File Offset: 0x0000E71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187384, XrefRangeEnd = 1187386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SetHotControl(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_Internal_SetHotControl_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00010550 File Offset: 0x0000E750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187386, XrefRangeEnd = 1187388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SetKeyboardControl(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_Internal_SetKeyboardControl_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00010584 File Offset: 0x0000E784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187388, XrefRangeEnd = 1187390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_GetDefaultSkin(int skinMode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skinMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_Internal_GetDefaultSkin_Private_Static_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000105C4 File Offset: 0x0000E7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187390, XrefRangeEnd = 1187392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ExitGUI()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_Internal_ExitGUI_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000105EC File Offset: 0x0000E7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187392, XrefRangeEnd = 1187396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkGUIChanged()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_MarkGUIChanged_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00010614 File Offset: 0x0000E814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187396, XrefRangeEnd = 1187401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetControlID(int hint, FocusType focus)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hint;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref focus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_GetControlID_Public_Static_Int32_Int32_FocusType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x00003EE8 File Offset: 0x000020E8
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00010660 File Offset: 0x0000E860
		public unsafe static bool guiIsExiting
		{
			get
			{
				return GUIUtility._guiIsExiting_k__BackingField;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187401, XrefRangeEnd = 1187405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_set_guiIsExiting_Internal_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00010694 File Offset: 0x0000E894
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x000106C4 File Offset: 0x0000E8C4
		public unsafe static int hotControl
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1187410, RefRangeEnd = 1187412, XrefRangeStart = 1187405, XrefRangeEnd = 1187410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_get_hotControl_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1187417, RefRangeEnd = 1187420, XrefRangeStart = 1187412, XrefRangeEnd = 1187417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_set_hotControl_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000106F8 File Offset: 0x0000E8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187420, XrefRangeEnd = 1187424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TakeCapture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_TakeCapture_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00010720 File Offset: 0x0000E920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187424, XrefRangeEnd = 1187428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveCapture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_RemoveCapture_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x00010748 File Offset: 0x0000E948
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x00010778 File Offset: 0x0000E978
		public unsafe static int keyboardControl
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1187433, RefRangeEnd = 1187439, XrefRangeStart = 1187428, XrefRangeEnd = 1187433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_get_keyboardControl_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1187444, RefRangeEnd = 1187445, XrefRangeStart = 1187439, XrefRangeEnd = 1187444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_set_keyboardControl_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000107AC File Offset: 0x0000E9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187445, XrefRangeEnd = 1187453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasKeyFocus(int controlID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controlID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_HasKeyFocus_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000107EC File Offset: 0x0000E9EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1187458, RefRangeEnd = 1187459, XrefRangeStart = 1187453, XrefRangeEnd = 1187458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExitGUI()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_ExitGUI_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00010814 File Offset: 0x0000EA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187459, XrefRangeEnd = 1187466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUISkin GetDefaultSkin()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_GetDefaultSkin_Internal_Static_GUISkin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUISkin>(intPtr3) : null;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00010848 File Offset: 0x0000EA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187466, XrefRangeEnd = 1187485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeEventPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_ProcessEvent_Internal_Static_Void_Int32_IntPtr_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00010898 File Offset: 0x0000EA98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1187492, RefRangeEnd = 1187494, XrefRangeStart = 1187485, XrefRangeEnd = 1187492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndContainer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_EndContainer_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000108C0 File Offset: 0x0000EAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187494, XrefRangeEnd = 1187527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginGUI(int skinMode, int instanceID, int useGUILayout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skinMode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instanceID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useGUILayout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_BeginGUI_Internal_Static_Void_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00010910 File Offset: 0x0000EB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187527, XrefRangeEnd = 1187540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyGUI(int instanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_DestroyGUI_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00010944 File Offset: 0x0000EB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187540, XrefRangeEnd = 1187586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndGUI(int layoutType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layoutType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_EndGUI_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00010978 File Offset: 0x0000EB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187586, XrefRangeEnd = 1187599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EndGUIFromException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_EndGUIFromException_Internal_Static_Boolean_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x000109BC File Offset: 0x0000EBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187599, XrefRangeEnd = 1187603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EndContainerGUIFromException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_EndContainerGUIFromException_Internal_Static_Boolean_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00010A00 File Offset: 0x0000EC00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1187628, RefRangeEnd = 1187629, XrefRangeStart = 1187603, XrefRangeEnd = 1187628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetGlobalState()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_ResetGlobalState_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00010A28 File Offset: 0x0000EC28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1187634, RefRangeEnd = 1187636, XrefRangeStart = 1187629, XrefRangeEnd = 1187634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsExitGUIException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_IsExitGUIException_Internal_Static_Boolean_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00010A6C File Offset: 0x0000EC6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1187644, RefRangeEnd = 1187645, XrefRangeStart = 1187636, XrefRangeEnd = 1187644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldRethrowException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_ShouldRethrowException_Internal_Static_Boolean_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00010AB0 File Offset: 0x0000ECB0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1187650, RefRangeEnd = 1187661, XrefRangeStart = 1187645, XrefRangeEnd = 1187650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckOnGUI()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_CheckOnGUI_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00010AD8 File Offset: 0x0000ECD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1187669, RefRangeEnd = 1187671, XrefRangeStart = 1187661, XrefRangeEnd = 1187669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float RoundToPixelGrid(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_RoundToPixelGrid_Internal_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00010B18 File Offset: 0x0000ED18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1187679, RefRangeEnd = 1187680, XrefRangeStart = 1187671, XrefRangeEnd = 1187679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect AlignRectToDevice(Rect rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_AlignRectToDevice_Public_Static_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00010B58 File Offset: 0x0000ED58
		[CallerCount(0)]
		public unsafe static bool HitTest(Rect rect, Vector2 point, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Vector2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00010BB4 File Offset: 0x0000EDB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1187683, RefRangeEnd = 1187685, XrefRangeStart = 1187680, XrefRangeEnd = 1187683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDirectManipulationDevice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Vector2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00010C10 File Offset: 0x0000EE10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1187697, RefRangeEnd = 1187699, XrefRangeStart = 1187685, XrefRangeEnd = 1187697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HitTest(Rect rect, Event evt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Event_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00010C60 File Offset: 0x0000EE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187699, XrefRangeEnd = 1187701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_GetControlID_Injected(int hint, FocusType focusType, ref Rect rect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hint;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref focusType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_Internal_GetControlID_Injected_Private_Static_Int32_Int32_FocusType_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00010CBC File Offset: 0x0000EEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187701, XrefRangeEnd = 1187703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AlignRectToDevice_Injected(ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &widthInPixels;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &heightInPixels;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_AlignRectToDevice_Injected_Private_Static_Void_byref_Rect_byref_Int32_byref_Int32_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00010D18 File Offset: 0x0000EF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187703, XrefRangeEnd = 1187705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_compositionCursorPos_Injected(ref Vector2 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00003D73 File Offset: 0x00001F73
		public GUIUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00010D4C File Offset: 0x0000EF4C
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00003D7C File Offset: 0x00001F7C
		public unsafe static int s_ControlCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_s_ControlCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_s_ControlCount, (void*)(&value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00010D68 File Offset: 0x0000EF68
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00003D8A File Offset: 0x00001F8A
		public unsafe static int s_SkinMode
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_s_SkinMode, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_s_SkinMode, (void*)(&value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x00010D84 File Offset: 0x0000EF84
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x00003D98 File Offset: 0x00001F98
		public unsafe static int s_OriginalID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_s_OriginalID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_s_OriginalID, (void*)(&value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x00010DA0 File Offset: 0x0000EFA0
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x00003DA6 File Offset: 0x00001FA6
		public unsafe static Action takeCapture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_takeCapture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_takeCapture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00010DC8 File Offset: 0x0000EFC8
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x00003DB8 File Offset: 0x00001FB8
		public unsafe static Action releaseCapture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_releaseCapture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_releaseCapture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00010DF0 File Offset: 0x0000EFF0
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00003DCA File Offset: 0x00001FCA
		public unsafe static Func<int, IntPtr, bool> processEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_processEvent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, IntPtr, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_processEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00010E18 File Offset: 0x0000F018
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x00003DDC File Offset: 0x00001FDC
		public unsafe static Action cleanupRoots
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_cleanupRoots, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_cleanupRoots, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00010E40 File Offset: 0x0000F040
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00003DEE File Offset: 0x00001FEE
		public unsafe static Func<Exception, bool> endContainerGUIFromException
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_endContainerGUIFromException, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Exception, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_endContainerGUIFromException, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00010E68 File Offset: 0x0000F068
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x00003E00 File Offset: 0x00002000
		public unsafe static Action guiChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_guiChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_guiChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00010E90 File Offset: 0x0000F090
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x00003E12 File Offset: 0x00002012
		public unsafe static Action<EventType, KeyCode> beforeEventProcessed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_beforeEventProcessed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<EventType, KeyCode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_beforeEventProcessed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x00010EB8 File Offset: 0x0000F0B8
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x00003E24 File Offset: 0x00002024
		public unsafe static Event m_Event
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_m_Event, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_m_Event, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x00010EE0 File Offset: 0x0000F0E0
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x00003E36 File Offset: 0x00002036
		public unsafe static bool _guiIsExiting_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr__guiIsExiting_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr__guiIsExiting_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00010EFC File Offset: 0x0000F0FC
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00003E44 File Offset: 0x00002044
		public unsafe static Func<bool> s_HasCurrentWindowKeyFocusFunc
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_s_HasCurrentWindowKeyFocusFunc, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_s_HasCurrentWindowKeyFocusFunc, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x00003E56 File Offset: 0x00002056
		public static bool hasModalWindow
		{
			get
			{
				return GUIUtility.get_hasModalWindowDelegateField();
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00010F24 File Offset: 0x0000F124
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x00003E62 File Offset: 0x00002062
		public static Vector2 s_EditorScreenPointOffset
		{
			get
			{
				Vector2 vector;
				GUIUtility.get_s_EditorScreenPointOffset_Injected(out vector);
				return vector;
			}
			set
			{
				GUIUtility.set_s_EditorScreenPointOffset_Injected(ref value);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x00003E6B File Offset: 0x0000206B
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00003E77 File Offset: 0x00002077
		public static bool mouseUsed
		{
			get
			{
				return GUIUtility.get_mouseUsedDelegateField();
			}
			set
			{
				GUIUtility.set_mouseUsedDelegateField(value);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00003E91 File Offset: 0x00002091
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x00003E9D File Offset: 0x0000209D
		public static bool manualTex2SRGBEnabled
		{
			get
			{
				return GUIUtility.get_manualTex2SRGBEnabledDelegateField();
			}
			set
			{
				GUIUtility.set_manualTex2SRGBEnabledDelegateField(value);
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00003EAA File Offset: 0x000020AA
		public static int GetPermanentControlID()
		{
			return GUIUtility.GetPermanentControlIDDelegateField();
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00010F54 File Offset: 0x0000F154
		public static Vector3 Internal_MultiplyPoint(Vector3 point, Matrix4x4 transform)
		{
			Vector3 vector;
			GUIUtility.Internal_MultiplyPoint_Injected(ref point, ref transform, out vector);
			return vector;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00003EC2 File Offset: 0x000020C2
		public static bool GetChanged()
		{
			return GUIUtility.GetChangedDelegateField();
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00003ECE File Offset: 0x000020CE
		public static void SetChanged(bool changed)
		{
			GUIUtility.SetChangedDelegateField(changed);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00003EDB File Offset: 0x000020DB
		public static void SetDidGUIWindowsEatLastEvent(bool value)
		{
			GUIUtility.SetDidGUIWindowsEatLastEventDelegateField(value);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00010F70 File Offset: 0x0000F170
		public static Object Internal_GetBuiltinSkin(int skin)
		{
			IntPtr intPtr = GUIUtility.Internal_GetBuiltinSkinDelegateField(skin);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00010F98 File Offset: 0x0000F198
		public static Vector2 InternalWindowToScreenPoint(Vector2 windowPoint)
		{
			Vector2 vector;
			GUIUtility.InternalWindowToScreenPoint_Injected(ref windowPoint, out vector);
			return vector;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00010FB0 File Offset: 0x0000F1B0
		public static Vector2 InternalScreenToWindowPoint(Vector2 screenPoint)
		{
			Vector2 vector;
			GUIUtility.InternalScreenToWindowPoint_Injected(ref screenPoint, out vector);
			return vector;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00010FC8 File Offset: 0x0000F1C8
		public static int GetControlID(FocusType focus)
		{
			return GUIUtility.GetControlID(0, focus);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00010FE4 File Offset: 0x0000F1E4
		public static int GetControlID(GUIContent contents, FocusType focus)
		{
			return GUIUtility.GetControlID(contents.hash, focus);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00011004 File Offset: 0x0000F204
		public static int GetControlID(FocusType focus, Rect position)
		{
			return GUIUtility.GetControlID(0, focus, position);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00011020 File Offset: 0x0000F220
		public static int GetControlID(GUIContent contents, FocusType focus, Rect position)
		{
			return GUIUtility.GetControlID(contents.hash, focus, position);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00011040 File Offset: 0x0000F240
		public static Object GetStateObject(Type t, int controlID)
		{
			return GUIStateObjects.GetStateObject(t, controlID);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0001105C File Offset: 0x0000F25C
		public static Object QueryStateObject(Type t, int controlID)
		{
			return GUIStateObjects.QueryStateObject(t, controlID);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00011078 File Offset: 0x0000F278
		public static GUISkin GetDefaultSkin(int skinMode)
		{
			return GUIUtility.Internal_GetDefaultSkin(skinMode).TryCast<GUISkin>();
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00011098 File Offset: 0x0000F298
		public static GUISkin GetBuiltinSkin(int skin)
		{
			return GUIUtility.Internal_GetBuiltinSkin(skin).TryCast<GUISkin>();
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00003EEF File Offset: 0x000020EF
		public static void CleanupRoots()
		{
			Action cleanupRoots = GUIUtility.cleanupRoots;
			if (cleanupRoots != null)
			{
				cleanupRoots.Invoke();
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x000110B8 File Offset: 0x0000F2B8
		public static float RoundToPixelGrid(float v, float scale)
		{
			return Mathf.Floor(v * scale + 0.48f) / scale;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x000110DC File Offset: 0x0000F2DC
		public static Vector2 GUIToScreenPoint(Vector2 guiPoint)
		{
			return GUIUtility.InternalWindowToScreenPoint(GUIClip.UnclipToWindow(guiPoint));
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000110FC File Offset: 0x0000F2FC
		public static Rect GUIToScreenRect(Rect guiRect)
		{
			Vector2 vector = GUIUtility.GUIToScreenPoint(new Vector2(guiRect.x, guiRect.y));
			guiRect.x = vector.x;
			guiRect.y = vector.y;
			return guiRect;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00011144 File Offset: 0x0000F344
		public static Vector2 ScreenToGUIPoint(Vector2 screenPoint)
		{
			return GUIClip.ClipToWindow(GUIUtility.InternalScreenToWindowPoint(screenPoint));
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00011164 File Offset: 0x0000F364
		public static Rect ScreenToGUIRect(Rect screenRect)
		{
			Vector2 vector = GUIUtility.ScreenToGUIPoint(new Vector2(screenRect.x, screenRect.y));
			screenRect.x = vector.x;
			screenRect.y = vector.y;
			return screenRect;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000111AC File Offset: 0x0000F3AC
		public static void RotateAroundPivot(float angle, Vector2 pivotPoint)
		{
			Matrix4x4 matrix = GUI.matrix;
			GUI.matrix = Matrix4x4.identity;
			Vector2 vector = GUIClip.Unclip(pivotPoint);
			Matrix4x4 matrix4x = Matrix4x4.TRS(vector, Quaternion.Euler(0f, 0f, angle), Vector3.one) * Matrix4x4.TRS(-vector, Quaternion.identity, Vector3.one);
			GUI.matrix = matrix4x * matrix;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00011220 File Offset: 0x0000F420
		public static void ScaleAroundPivot(Vector2 scale, Vector2 pivotPoint)
		{
			Matrix4x4 matrix = GUI.matrix;
			Vector2 vector = GUIClip.Unclip(pivotPoint);
			Matrix4x4 matrix4x = Matrix4x4.TRS(vector, Quaternion.identity, new Vector3(scale.x, scale.y, 1f)) * Matrix4x4.TRS(-vector, Quaternion.identity, Vector3.one);
			GUI.matrix = matrix4x * matrix;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00003F03 File Offset: 0x00002103
		public static void get_s_EditorScreenPointOffset_Injected(out Vector2 ret)
		{
			GUIUtility.get_s_EditorScreenPointOffset_InjectedDelegateField(out ret);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00003F10 File Offset: 0x00002110
		public static void set_s_EditorScreenPointOffset_Injected(ref Vector2 value)
		{
			GUIUtility.set_s_EditorScreenPointOffset_InjectedDelegateField(ref value);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00003F1D File Offset: 0x0000211D
		public static void get_compositionCursorPos_Injected(out Vector2 ret)
		{
			GUIUtility.get_compositionCursorPos_InjectedDelegateField(out ret);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00003F2A File Offset: 0x0000212A
		public static void Internal_MultiplyPoint_Injected(ref Vector3 point, ref Matrix4x4 transform, out Vector3 ret)
		{
			GUIUtility.Internal_MultiplyPoint_InjectedDelegateField(ref point, ref transform, out ret);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00003F39 File Offset: 0x00002139
		public static void InternalWindowToScreenPoint_Injected(ref Vector2 windowPoint, out Vector2 ret)
		{
			GUIUtility.InternalWindowToScreenPoint_InjectedDelegateField(ref windowPoint, out ret);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00003F47 File Offset: 0x00002147
		public static void InternalScreenToWindowPoint_Injected(ref Vector2 screenPoint, out Vector2 ret)
		{
			GUIUtility.InternalScreenToWindowPoint_InjectedDelegateField(ref screenPoint, out ret);
		}

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeFieldInfoPtr_s_ControlCount;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeFieldInfoPtr_s_SkinMode;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeFieldInfoPtr_s_OriginalID;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeFieldInfoPtr_takeCapture;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeFieldInfoPtr_releaseCapture;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeFieldInfoPtr_processEvent;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr_cleanupRoots;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr_endContainerGUIFromException;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeFieldInfoPtr_guiChanged;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeFieldInfoPtr_beforeEventProcessed;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeFieldInfoPtr_m_Event;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeFieldInfoPtr__guiIsExiting_k__BackingField;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeFieldInfoPtr_s_HasCurrentWindowKeyFocusFunc;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelsPerPoint_Internal_Static_get_Single_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_get_guiDepth_Internal_Static_get_Int32_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_get_textFieldInput_Internal_Static_get_Boolean_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_get_systemCopyBuffer_Public_Static_get_String_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_set_systemCopyBuffer_Public_Static_set_Void_String_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetControlID_Private_Static_Int32_Int32_FocusType_Rect_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_GetControlID_Public_Static_Int32_Int32_FocusType_Rect_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_BeginContainerFromOwner_Internal_Static_Void_ScriptableObject_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr_BeginContainer_Internal_Static_Void_ObjectGUIState_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_Internal_EndContainer_Internal_Static_Void_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_CheckForTabEvent_Internal_Static_Int32_Event_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_SetKeyboardControlToFirstControlId_Internal_Static_Void_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_SetKeyboardControlToLastControlId_Internal_Static_Void_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_HasFocusableControls_Internal_Static_Boolean_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_OwnsId_Internal_Static_Boolean_Int32_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_AlignRectToDevice_Public_Static_Rect_Rect_byref_Int32_byref_Int32_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_get_compositionString_Internal_Static_get_String_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_set_imeCompositionMode_Internal_Static_set_Void_IMECompositionMode_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_set_compositionCursorPos_Internal_Static_set_Void_Vector2_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetHotControl_Private_Static_Int32_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetKeyboardControl_Private_Static_Int32_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetHotControl_Private_Static_Void_Int32_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetKeyboardControl_Private_Static_Void_Int32_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetDefaultSkin_Private_Static_Object_Int32_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ExitGUI_Private_Static_Void_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_MarkGUIChanged_Private_Static_Void_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_GetControlID_Public_Static_Int32_Int32_FocusType_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_set_guiIsExiting_Internal_Static_set_Void_Boolean_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_get_hotControl_Public_Static_get_Int32_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_set_hotControl_Public_Static_set_Void_Int32_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_TakeCapture_Internal_Static_Void_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCapture_Internal_Static_Void_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_get_keyboardControl_Public_Static_get_Int32_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_set_keyboardControl_Public_Static_set_Void_Int32_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_HasKeyFocus_Internal_Static_Boolean_Int32_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_ExitGUI_Public_Static_Void_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultSkin_Internal_Static_GUISkin_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEvent_Internal_Static_Void_Int32_IntPtr_byref_Boolean_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_EndContainer_Internal_Static_Void_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_BeginGUI_Internal_Static_Void_Int32_Int32_Int32_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_DestroyGUI_Internal_Static_Void_Int32_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_EndGUI_Internal_Static_Void_Int32_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_EndGUIFromException_Internal_Static_Boolean_Exception_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_EndContainerGUIFromException_Internal_Static_Boolean_Exception_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_ResetGlobalState_Internal_Static_Void_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_IsExitGUIException_Internal_Static_Boolean_Exception_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_ShouldRethrowException_Internal_Static_Boolean_Exception_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_CheckOnGUI_Internal_Static_Void_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_RoundToPixelGrid_Internal_Static_Single_Single_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_AlignRectToDevice_Public_Static_Rect_Rect_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Vector2_Int32_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Vector2_Boolean_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Event_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetControlID_Injected_Private_Static_Int32_Int32_FocusType_byref_Rect_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_AlignRectToDevice_Injected_Private_Static_Void_byref_Rect_byref_Int32_byref_Int32_byref_Rect_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0;

		// Token: 0x04000234 RID: 564
		private static readonly GUIUtility.get_hasModalWindowDelegate get_hasModalWindowDelegateField;

		// Token: 0x04000235 RID: 565
		private static readonly GUIUtility.get_mouseUsedDelegate get_mouseUsedDelegateField;

		// Token: 0x04000236 RID: 566
		private static readonly GUIUtility.set_mouseUsedDelegate set_mouseUsedDelegateField;

		// Token: 0x04000237 RID: 567
		private static readonly GUIUtility.set_textFieldInputDelegate set_textFieldInputDelegateField;

		// Token: 0x04000238 RID: 568
		private static readonly GUIUtility.get_manualTex2SRGBEnabledDelegate get_manualTex2SRGBEnabledDelegateField;

		// Token: 0x04000239 RID: 569
		private static readonly GUIUtility.set_manualTex2SRGBEnabledDelegate set_manualTex2SRGBEnabledDelegateField;

		// Token: 0x0400023A RID: 570
		private static readonly GUIUtility.GetPermanentControlIDDelegate GetPermanentControlIDDelegateField;

		// Token: 0x0400023B RID: 571
		private static readonly GUIUtility.get_imeCompositionModeDelegate get_imeCompositionModeDelegateField;

		// Token: 0x0400023C RID: 572
		private static readonly GUIUtility.GetChangedDelegate GetChangedDelegateField;

		// Token: 0x0400023D RID: 573
		private static readonly GUIUtility.SetChangedDelegate SetChangedDelegateField;

		// Token: 0x0400023E RID: 574
		private static readonly GUIUtility.SetDidGUIWindowsEatLastEventDelegate SetDidGUIWindowsEatLastEventDelegateField;

		// Token: 0x0400023F RID: 575
		private static readonly GUIUtility.Internal_GetBuiltinSkinDelegate Internal_GetBuiltinSkinDelegateField;

		// Token: 0x04000240 RID: 576
		private static readonly GUIUtility.get_s_EditorScreenPointOffset_InjectedDelegate get_s_EditorScreenPointOffset_InjectedDelegateField;

		// Token: 0x04000241 RID: 577
		private static readonly GUIUtility.set_s_EditorScreenPointOffset_InjectedDelegate set_s_EditorScreenPointOffset_InjectedDelegateField;

		// Token: 0x04000242 RID: 578
		private static readonly GUIUtility.get_compositionCursorPos_InjectedDelegate get_compositionCursorPos_InjectedDelegateField;

		// Token: 0x04000243 RID: 579
		private static readonly GUIUtility.Internal_MultiplyPoint_InjectedDelegate Internal_MultiplyPoint_InjectedDelegateField;

		// Token: 0x04000244 RID: 580
		private static readonly GUIUtility.InternalWindowToScreenPoint_InjectedDelegate InternalWindowToScreenPoint_InjectedDelegateField;

		// Token: 0x04000245 RID: 581
		private static readonly GUIUtility.InternalScreenToWindowPoint_InjectedDelegate InternalScreenToWindowPoint_InjectedDelegateField;

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x0600076B RID: 1899
		private delegate bool get_hasModalWindowDelegate();

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x0600076D RID: 1901
		private delegate bool get_mouseUsedDelegate();

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x0600076F RID: 1903
		private delegate void set_mouseUsedDelegate(bool value);

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x06000771 RID: 1905
		private delegate void set_textFieldInputDelegate(bool value);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x06000773 RID: 1907
		private delegate bool get_manualTex2SRGBEnabledDelegate();

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x06000775 RID: 1909
		private delegate void set_manualTex2SRGBEnabledDelegate(bool value);

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x06000777 RID: 1911
		private delegate int GetPermanentControlIDDelegate();

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x06000779 RID: 1913
		private delegate IMECompositionMode get_imeCompositionModeDelegate();

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x0600077B RID: 1915
		private delegate bool GetChangedDelegate();

		// Token: 0x020000A7 RID: 167
		// (Invoke) Token: 0x0600077D RID: 1917
		private delegate void SetChangedDelegate(bool changed);

		// Token: 0x020000A8 RID: 168
		// (Invoke) Token: 0x0600077F RID: 1919
		private delegate void SetDidGUIWindowsEatLastEventDelegate(bool value);

		// Token: 0x020000A9 RID: 169
		// (Invoke) Token: 0x06000781 RID: 1921
		private delegate IntPtr Internal_GetBuiltinSkinDelegate(int skin);

		// Token: 0x020000AA RID: 170
		// (Invoke) Token: 0x06000783 RID: 1923
		private delegate void get_s_EditorScreenPointOffset_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x06000785 RID: 1925
		private delegate void set_s_EditorScreenPointOffset_InjectedDelegate(IntPtr value);

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x06000787 RID: 1927
		private delegate void get_compositionCursorPos_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x020000AD RID: 173
		// (Invoke) Token: 0x06000789 RID: 1929
		private delegate void Internal_MultiplyPoint_InjectedDelegate(IntPtr point, IntPtr transform, [Out] IntPtr ret);

		// Token: 0x020000AE RID: 174
		// (Invoke) Token: 0x0600078B RID: 1931
		private delegate void InternalWindowToScreenPoint_InjectedDelegate(IntPtr windowPoint, [Out] IntPtr ret);

		// Token: 0x020000AF RID: 175
		// (Invoke) Token: 0x0600078D RID: 1933
		private delegate void InternalScreenToWindowPoint_InjectedDelegate(IntPtr screenPoint, [Out] IntPtr ret);
	}
}
