using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.TextCore.Text;

namespace UnityEngine
{
	// Token: 0x02000020 RID: 32
	public class TextSelectingUtilities : Object
	{
		// Token: 0x060005F6 RID: 1526 RVA: 0x000159FC File Offset: 0x00013BFC
		// Note: this type is marked as 'beforefieldinit'.
		static TextSelectingUtilities()
		{
			Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "TextSelectingUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr);
			TextSelectingUtilities.NativeFieldInfoPtr_dblClickSnap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "dblClickSnap");
			TextSelectingUtilities.NativeFieldInfoPtr_iAltCursorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "iAltCursorPos");
			TextSelectingUtilities.NativeFieldInfoPtr_hasHorizontalCursorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "hasHorizontalCursorPos");
			TextSelectingUtilities.NativeFieldInfoPtr_m_bJustSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "m_bJustSelected");
			TextSelectingUtilities.NativeFieldInfoPtr_m_MouseDragSelectsWholeWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "m_MouseDragSelectsWholeWords");
			TextSelectingUtilities.NativeFieldInfoPtr_m_DblClickInitPosStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "m_DblClickInitPosStart");
			TextSelectingUtilities.NativeFieldInfoPtr_m_DblClickInitPosEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "m_DblClickInitPosEnd");
			TextSelectingUtilities.NativeFieldInfoPtr_m_TextHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "m_TextHandle");
			TextSelectingUtilities.NativeFieldInfoPtr_kMoveDownHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "kMoveDownHeight");
			TextSelectingUtilities.NativeFieldInfoPtr_kNewLineChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "kNewLineChar");
			TextSelectingUtilities.NativeFieldInfoPtr_m_RevealCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "m_RevealCursor");
			TextSelectingUtilities.NativeFieldInfoPtr_m_CursorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "m_CursorIndex");
			TextSelectingUtilities.NativeFieldInfoPtr_m_SelectIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "m_SelectIndex");
			TextSelectingUtilities.NativeFieldInfoPtr_s_KeySelectOps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "s_KeySelectOps");
			TextSelectingUtilities.NativeFieldInfoPtr_OnCursorIndexChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "OnCursorIndexChange");
			TextSelectingUtilities.NativeFieldInfoPtr_OnSelectIndexChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "OnSelectIndexChange");
			TextSelectingUtilities.NativeFieldInfoPtr_OnRevealCursorChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "OnRevealCursorChange");
			TextSelectingUtilities.NativeMethodInfoPtr_get_hasSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663692);
			TextSelectingUtilities.NativeMethodInfoPtr_get_revealCursor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663693);
			TextSelectingUtilities.NativeMethodInfoPtr_set_revealCursor_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663694);
			TextSelectingUtilities.NativeMethodInfoPtr_get_m_CharacterCount_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663695);
			TextSelectingUtilities.NativeMethodInfoPtr_get_characterCount_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663696);
			TextSelectingUtilities.NativeMethodInfoPtr_get_m_TextElementInfos_Private_get_Il2CppReferenceArray_1_TextElementInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663697);
			TextSelectingUtilities.NativeMethodInfoPtr_get_cursorIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663698);
			TextSelectingUtilities.NativeMethodInfoPtr_set_cursorIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663699);
			TextSelectingUtilities.NativeMethodInfoPtr_SetCursorIndexWithoutNotify_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663700);
			TextSelectingUtilities.NativeMethodInfoPtr_get_selectIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663701);
			TextSelectingUtilities.NativeMethodInfoPtr_set_selectIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663702);
			TextSelectingUtilities.NativeMethodInfoPtr_SetSelectIndexWithoutNotify_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663703);
			TextSelectingUtilities.NativeMethodInfoPtr_get_selectedText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663704);
			TextSelectingUtilities.NativeMethodInfoPtr__ctor_Public_Void_TextHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663705);
			TextSelectingUtilities.NativeMethodInfoPtr_HandleKeyEvent_Internal_Boolean_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663706);
			TextSelectingUtilities.NativeMethodInfoPtr_PerformOperation_Private_Boolean_TextSelectOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663707);
			TextSelectingUtilities.NativeMethodInfoPtr_MapKey_Private_Static_Void_String_TextSelectOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663708);
			TextSelectingUtilities.NativeMethodInfoPtr_InitKeyActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663709);
			TextSelectingUtilities.NativeMethodInfoPtr_ClearCursorPos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663710);
			TextSelectingUtilities.NativeMethodInfoPtr_OnFocus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663711);
			TextSelectingUtilities.NativeMethodInfoPtr_SelectAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663712);
			TextSelectingUtilities.NativeMethodInfoPtr_SelectNone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663713);
			TextSelectingUtilities.NativeMethodInfoPtr_SelectLeft_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663714);
			TextSelectingUtilities.NativeMethodInfoPtr_SelectRight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663715);
			TextSelectingUtilities.NativeMethodInfoPtr_SelectUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663716);
			TextSelectingUtilities.NativeMethodInfoPtr_SelectDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663717);
			TextSelectingUtilities.NativeMethodInfoPtr_SelectTextEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663718);
			TextSelectingUtilities.NativeMethodInfoPtr_SelectTextStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663719);
			TextSelectingUtilities.NativeMethodInfoPtr_SelectToStartOfNextWord_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663720);
			TextSelectingUtilities.NativeMethodInfoPtr_SelectToEndOfPreviousWord_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663721);
			TextSelectingUtilities.NativeMethodInfoPtr_SelectWordRight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663722);
			TextSelectingUtilities.NativeMethodInfoPtr_SelectWordLeft_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663723);
			TextSelectingUtilities.NativeMethodInfoPtr_SelectGraphicalLineStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663724);
			TextSelectingUtilities.NativeMethodInfoPtr_SelectGraphicalLineEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663725);
			TextSelectingUtilities.NativeMethodInfoPtr_SelectParagraphForward_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663726);
			TextSelectingUtilities.NativeMethodInfoPtr_SelectParagraphBackward_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663727);
			TextSelectingUtilities.NativeMethodInfoPtr_SelectCurrentWord_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663728);
			TextSelectingUtilities.NativeMethodInfoPtr_SelectCurrentParagraph_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663729);
			TextSelectingUtilities.NativeMethodInfoPtr_MoveRight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663730);
			TextSelectingUtilities.NativeMethodInfoPtr_MoveLeft_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663731);
			TextSelectingUtilities.NativeMethodInfoPtr_MoveUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663732);
			TextSelectingUtilities.NativeMethodInfoPtr_MoveDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663733);
			TextSelectingUtilities.NativeMethodInfoPtr_MoveLineStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663734);
			TextSelectingUtilities.NativeMethodInfoPtr_MoveLineEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663735);
			TextSelectingUtilities.NativeMethodInfoPtr_MoveGraphicalLineStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663736);
			TextSelectingUtilities.NativeMethodInfoPtr_MoveGraphicalLineEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663737);
			TextSelectingUtilities.NativeMethodInfoPtr_MoveTextStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663738);
			TextSelectingUtilities.NativeMethodInfoPtr_MoveTextEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663739);
			TextSelectingUtilities.NativeMethodInfoPtr_MoveParagraphForward_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663740);
			TextSelectingUtilities.NativeMethodInfoPtr_MoveParagraphBackward_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663741);
			TextSelectingUtilities.NativeMethodInfoPtr_MoveWordRight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663742);
			TextSelectingUtilities.NativeMethodInfoPtr_MoveToStartOfNextWord_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663743);
			TextSelectingUtilities.NativeMethodInfoPtr_MoveToEndOfPreviousWord_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663744);
			TextSelectingUtilities.NativeMethodInfoPtr_MoveWordLeft_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663745);
			TextSelectingUtilities.NativeMethodInfoPtr_MouseDragSelectsWholeWords_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663746);
			TextSelectingUtilities.NativeMethodInfoPtr_ExpandSelectGraphicalLineStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663747);
			TextSelectingUtilities.NativeMethodInfoPtr_ExpandSelectGraphicalLineEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663748);
			TextSelectingUtilities.NativeMethodInfoPtr_DblClickSnap_Public_Void_DblClickSnapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663749);
			TextSelectingUtilities.NativeMethodInfoPtr_MoveCursorToPosition_Internal_FamOrAssem_Void_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663750);
			TextSelectingUtilities.NativeMethodInfoPtr_SelectToPosition_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663751);
			TextSelectingUtilities.NativeMethodInfoPtr_FindNextSeperator_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663752);
			TextSelectingUtilities.NativeMethodInfoPtr_FindPrevSeperator_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663753);
			TextSelectingUtilities.NativeMethodInfoPtr_FindStartOfNextWord_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663754);
			TextSelectingUtilities.NativeMethodInfoPtr_FindEndOfPreviousWord_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663755);
			TextSelectingUtilities.NativeMethodInfoPtr_FindEndOfClassification_Private_Int32_Int32_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663756);
			TextSelectingUtilities.NativeMethodInfoPtr_ClampTextIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663757);
			TextSelectingUtilities.NativeMethodInfoPtr_EnsureValidCodePointIndex_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663758);
			TextSelectingUtilities.NativeMethodInfoPtr_IsValidCodePointIndex_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663759);
			TextSelectingUtilities.NativeMethodInfoPtr_IndexOfEndOfLine_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663760);
			TextSelectingUtilities.NativeMethodInfoPtr_PreviousCodePointIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663761);
			TextSelectingUtilities.NativeMethodInfoPtr_NextCodePointIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663762);
			TextSelectingUtilities.NativeMethodInfoPtr_GetGraphicalLineStart_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663763);
			TextSelectingUtilities.NativeMethodInfoPtr_GetGraphicalLineEnd_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663764);
			TextSelectingUtilities.NativeMethodInfoPtr_Copy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663765);
			TextSelectingUtilities.NativeMethodInfoPtr_ClassifyChar_Private_CharacterType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663766);
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x0001615C File Offset: 0x0001435C
		public unsafe bool hasSelection
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1188585, RefRangeEnd = 1188591, XrefRangeStart = 1188583, XrefRangeEnd = 1188585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_get_hasSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00016198 File Offset: 0x00014398
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x000161D4 File Offset: 0x000143D4
		public unsafe bool revealCursor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_get_revealCursor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_set_revealCursor_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x00016214 File Offset: 0x00014414
		public unsafe int m_CharacterCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188591, XrefRangeEnd = 1188592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_get_m_CharacterCount_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00016250 File Offset: 0x00014450
		public unsafe int characterCount
		{
			[CallerCount(56)]
			[CachedScanResults(RefRangeStart = 1188596, RefRangeEnd = 1188652, XrefRangeStart = 1188592, XrefRangeEnd = 1188596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_get_characterCount_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x0001628C File Offset: 0x0001448C
		public unsafe Il2CppReferenceArray<TextElementInfo> m_TextElementInfos
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188652, XrefRangeEnd = 1188653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_get_m_TextElementInfos_Private_get_Il2CppReferenceArray_1_TextElementInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextElementInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x000162CC File Offset: 0x000144CC
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00016308 File Offset: 0x00014508
		public unsafe int cursorIndex
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1188654, RefRangeEnd = 1188657, XrefRangeStart = 1188653, XrefRangeEnd = 1188654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_get_cursorIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1188657, RefRangeEnd = 1188658, XrefRangeStart = 1188657, XrefRangeEnd = 1188657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_set_cursorIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00016348 File Offset: 0x00014548
		[CallerCount(0)]
		public unsafe void SetCursorIndexWithoutNotify(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SetCursorIndexWithoutNotify_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x00016388 File Offset: 0x00014588
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x000163C4 File Offset: 0x000145C4
		public unsafe int selectIndex
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1188659, RefRangeEnd = 1188661, XrefRangeStart = 1188658, XrefRangeEnd = 1188659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_get_selectIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1188661, RefRangeEnd = 1188662, XrefRangeStart = 1188661, XrefRangeEnd = 1188661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_set_selectIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00016404 File Offset: 0x00014604
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 170594, RefRangeEnd = 170603, XrefRangeStart = 170594, XrefRangeEnd = 170603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectIndexWithoutNotify(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SetSelectIndexWithoutNotify_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00016444 File Offset: 0x00014644
		public unsafe string selectedText
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1188676, RefRangeEnd = 1188677, XrefRangeStart = 1188662, XrefRangeEnd = 1188676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_get_selectedText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0001647C File Offset: 0x0001467C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1188679, RefRangeEnd = 1188680, XrefRangeStart = 1188677, XrefRangeEnd = 1188679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextSelectingUtilities(TextHandle textHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textHandle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr__ctor_Public_Void_TextHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x000164C8 File Offset: 0x000146C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1188695, RefRangeEnd = 1188697, XrefRangeStart = 1188680, XrefRangeEnd = 1188695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleKeyEvent(Event e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_HandleKeyEvent_Internal_Boolean_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00016518 File Offset: 0x00014718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188697, XrefRangeEnd = 1188777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PerformOperation(TextSelectOp operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref operation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_PerformOperation_Private_Boolean_TextSelectOp_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00016564 File Offset: 0x00014764
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1188784, RefRangeEnd = 1188796, XrefRangeStart = 1188777, XrefRangeEnd = 1188784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MapKey(string key, TextSelectOp action)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_MapKey_Private_Static_Void_String_TextSelectOp_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000165A8 File Offset: 0x000147A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1188862, RefRangeEnd = 1188863, XrefRangeStart = 1188796, XrefRangeEnd = 1188862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitKeyActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_InitKeyActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x000165DC File Offset: 0x000147DC
		[CallerCount(0)]
		public unsafe void ClearCursorPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_ClearCursorPos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00016610 File Offset: 0x00014810
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1188863, RefRangeEnd = 1188865, XrefRangeStart = 1188863, XrefRangeEnd = 1188863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFocus(bool selectAll = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selectAll;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_OnFocus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00016650 File Offset: 0x00014850
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1188865, RefRangeEnd = 1188869, XrefRangeStart = 1188865, XrefRangeEnd = 1188865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SelectAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00016684 File Offset: 0x00014884
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1188870, RefRangeEnd = 1188872, XrefRangeStart = 1188869, XrefRangeEnd = 1188870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectNone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SelectNone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x000166B8 File Offset: 0x000148B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188872, XrefRangeEnd = 1188878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SelectLeft_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x000166EC File Offset: 0x000148EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188878, XrefRangeEnd = 1188884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SelectRight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00016720 File Offset: 0x00014920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188884, XrefRangeEnd = 1188886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SelectUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00016754 File Offset: 0x00014954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188886, XrefRangeEnd = 1188888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SelectDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00016788 File Offset: 0x00014988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188888, XrefRangeEnd = 1188889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectTextEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SelectTextEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000167BC File Offset: 0x000149BC
		[CallerCount(0)]
		public unsafe void SelectTextStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SelectTextStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x000167F0 File Offset: 0x000149F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188889, XrefRangeEnd = 1188891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectToStartOfNextWord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SelectToStartOfNextWord_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00016824 File Offset: 0x00014A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188891, XrefRangeEnd = 1188893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectToEndOfPreviousWord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SelectToEndOfPreviousWord_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00016858 File Offset: 0x00014A58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1188905, RefRangeEnd = 1188906, XrefRangeStart = 1188893, XrefRangeEnd = 1188905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectWordRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SelectWordRight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0001688C File Offset: 0x00014A8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1188918, RefRangeEnd = 1188919, XrefRangeStart = 1188906, XrefRangeEnd = 1188918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectWordLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SelectWordLeft_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000168C0 File Offset: 0x00014AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188919, XrefRangeEnd = 1188921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectGraphicalLineStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SelectGraphicalLineStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x000168F4 File Offset: 0x00014AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188921, XrefRangeEnd = 1188923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectGraphicalLineEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SelectGraphicalLineEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00016928 File Offset: 0x00014B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188923, XrefRangeEnd = 1188933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectParagraphForward()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SelectParagraphForward_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0001695C File Offset: 0x00014B5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1188936, RefRangeEnd = 1188937, XrefRangeStart = 1188933, XrefRangeEnd = 1188936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectParagraphBackward()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SelectParagraphBackward_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00016990 File Offset: 0x00014B90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1188983, RefRangeEnd = 1188984, XrefRangeStart = 1188937, XrefRangeEnd = 1188983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectCurrentWord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SelectCurrentWord_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x000169C4 File Offset: 0x00014BC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1188992, RefRangeEnd = 1188993, XrefRangeStart = 1188984, XrefRangeEnd = 1188992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectCurrentParagraph()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SelectCurrentParagraph_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x000169F8 File Offset: 0x00014BF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1189002, RefRangeEnd = 1189003, XrefRangeStart = 1188993, XrefRangeEnd = 1189002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_MoveRight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00016A2C File Offset: 0x00014C2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1189012, RefRangeEnd = 1189014, XrefRangeStart = 1189003, XrefRangeEnd = 1189012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_MoveLeft_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00016A60 File Offset: 0x00014C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189014, XrefRangeEnd = 1189022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_MoveUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00016A94 File Offset: 0x00014C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189022, XrefRangeEnd = 1189031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_MoveDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00016AC8 File Offset: 0x00014CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189031, XrefRangeEnd = 1189037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveLineStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_MoveLineStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00016AFC File Offset: 0x00014CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189037, XrefRangeEnd = 1189043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveLineEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_MoveLineEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00016B30 File Offset: 0x00014D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189043, XrefRangeEnd = 1189048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveGraphicalLineStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_MoveGraphicalLineStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00016B64 File Offset: 0x00014D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189048, XrefRangeEnd = 1189053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveGraphicalLineEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_MoveGraphicalLineEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00016B98 File Offset: 0x00014D98
		[CallerCount(0)]
		public unsafe void MoveTextStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_MoveTextStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00016BCC File Offset: 0x00014DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189053, XrefRangeEnd = 1189054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveTextEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_MoveTextEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00016C00 File Offset: 0x00014E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189054, XrefRangeEnd = 1189063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveParagraphForward()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_MoveParagraphForward_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00016C34 File Offset: 0x00014E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189063, XrefRangeEnd = 1189068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveParagraphBackward()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_MoveParagraphBackward_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00016C68 File Offset: 0x00014E68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1189080, RefRangeEnd = 1189082, XrefRangeStart = 1189068, XrefRangeEnd = 1189080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveWordRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_MoveWordRight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00016C9C File Offset: 0x00014E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189082, XrefRangeEnd = 1189087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToStartOfNextWord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_MoveToStartOfNextWord_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00016CD0 File Offset: 0x00014ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189087, XrefRangeEnd = 1189092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToEndOfPreviousWord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_MoveToEndOfPreviousWord_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00016D04 File Offset: 0x00014F04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1189107, RefRangeEnd = 1189109, XrefRangeStart = 1189092, XrefRangeEnd = 1189107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveWordLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_MoveWordLeft_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00016D38 File Offset: 0x00014F38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1189117, RefRangeEnd = 1189120, XrefRangeStart = 1189109, XrefRangeEnd = 1189117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MouseDragSelectsWholeWords(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref on;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_MouseDragSelectsWholeWords_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00016D78 File Offset: 0x00014F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189120, XrefRangeEnd = 1189128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandSelectGraphicalLineStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_ExpandSelectGraphicalLineStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00016DAC File Offset: 0x00014FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189128, XrefRangeEnd = 1189136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandSelectGraphicalLineEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_ExpandSelectGraphicalLineEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00016DE0 File Offset: 0x00014FE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DblClickSnap(TextEditor.DblClickSnapping snapping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapping;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_DblClickSnap_Public_Void_DblClickSnapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00016E20 File Offset: 0x00015020
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1189138, RefRangeEnd = 1189140, XrefRangeStart = 1189136, XrefRangeEnd = 1189138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cursorPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shift;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_MoveCursorToPosition_Internal_FamOrAssem_Void_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00016E6C File Offset: 0x0001506C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1189199, RefRangeEnd = 1189200, XrefRangeStart = 1189140, XrefRangeEnd = 1189199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectToPosition(Vector2 cursorPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cursorPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_SelectToPosition_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00016EAC File Offset: 0x000150AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189200, XrefRangeEnd = 1189207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindNextSeperator(int startPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_FindNextSeperator_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00016EF8 File Offset: 0x000150F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189207, XrefRangeEnd = 1189210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindPrevSeperator(int startPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_FindPrevSeperator_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00016F44 File Offset: 0x00015144
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1189215, RefRangeEnd = 1189219, XrefRangeStart = 1189210, XrefRangeEnd = 1189215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindStartOfNextWord(int p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_FindStartOfNextWord_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00016F90 File Offset: 0x00015190
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1189227, RefRangeEnd = 1189231, XrefRangeStart = 1189219, XrefRangeEnd = 1189227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindEndOfPreviousWord(int p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_FindEndOfPreviousWord_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00016FDC File Offset: 0x000151DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189231, XrefRangeEnd = 1189241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindEndOfClassification(int p, TextSelectingUtilities.Direction dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_FindEndOfClassification_Private_Int32_Int32_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00017034 File Offset: 0x00015234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189241, XrefRangeEnd = 1189242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ClampTextIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_ClampTextIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00017080 File Offset: 0x00015280
		[CallerCount(217)]
		[CachedScanResults(RefRangeStart = 1189252, RefRangeEnd = 1189469, XrefRangeStart = 1189242, XrefRangeEnd = 1189252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EnsureValidCodePointIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_EnsureValidCodePointIndex_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x000170CC File Offset: 0x000152CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189469, XrefRangeEnd = 1189476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidCodePointIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_IsValidCodePointIndex_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00017118 File Offset: 0x00015318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1189478, RefRangeEnd = 1189479, XrefRangeStart = 1189476, XrefRangeEnd = 1189478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfEndOfLine(int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_IndexOfEndOfLine_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00017164 File Offset: 0x00015364
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1189485, RefRangeEnd = 1189508, XrefRangeStart = 1189479, XrefRangeEnd = 1189485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PreviousCodePointIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_PreviousCodePointIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000171B0 File Offset: 0x000153B0
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1189516, RefRangeEnd = 1189540, XrefRangeStart = 1189508, XrefRangeEnd = 1189516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int NextCodePointIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_NextCodePointIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x000171FC File Offset: 0x000153FC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1189548, RefRangeEnd = 1189554, XrefRangeStart = 1189540, XrefRangeEnd = 1189548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetGraphicalLineStart(int p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_GetGraphicalLineStart_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00017248 File Offset: 0x00015448
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1189562, RefRangeEnd = 1189568, XrefRangeStart = 1189554, XrefRangeEnd = 1189562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetGraphicalLineEnd(int p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_GetGraphicalLineEnd_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00017294 File Offset: 0x00015494
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1189576, RefRangeEnd = 1189580, XrefRangeStart = 1189568, XrefRangeEnd = 1189576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_Copy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x000172C8 File Offset: 0x000154C8
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 1189589, RefRangeEnd = 1189622, XrefRangeStart = 1189580, XrefRangeEnd = 1189589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextSelectingUtilities.CharacterType ClassifyChar(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSelectingUtilities.NativeMethodInfoPtr_ClassifyChar_Private_CharacterType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00004A8C File Offset: 0x00002C8C
		public TextSelectingUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x00017314 File Offset: 0x00015514
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x00004A95 File Offset: 0x00002C95
		public unsafe TextEditor.DblClickSnapping dblClickSnap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_dblClickSnap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_dblClickSnap)) = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x0001733C File Offset: 0x0001553C
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x00004AB0 File Offset: 0x00002CB0
		public unsafe int iAltCursorPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_iAltCursorPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_iAltCursorPos)) = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00017364 File Offset: 0x00015564
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x00004ACB File Offset: 0x00002CCB
		public unsafe bool hasHorizontalCursorPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_hasHorizontalCursorPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_hasHorizontalCursorPos)) = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x0001738C File Offset: 0x0001558C
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x00004AE6 File Offset: 0x00002CE6
		public unsafe bool m_bJustSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_m_bJustSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_m_bJustSelected)) = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x000173B4 File Offset: 0x000155B4
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x00004B01 File Offset: 0x00002D01
		public unsafe bool m_MouseDragSelectsWholeWords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_m_MouseDragSelectsWholeWords);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_m_MouseDragSelectsWholeWords)) = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x000173DC File Offset: 0x000155DC
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x00004B1C File Offset: 0x00002D1C
		public unsafe int m_DblClickInitPosStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_m_DblClickInitPosStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_m_DblClickInitPosStart)) = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x00017404 File Offset: 0x00015604
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00004B37 File Offset: 0x00002D37
		public unsafe int m_DblClickInitPosEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_m_DblClickInitPosEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_m_DblClickInitPosEnd)) = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0001742C File Offset: 0x0001562C
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x00004B52 File Offset: 0x00002D52
		public unsafe TextHandle m_TextHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_m_TextHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_m_TextHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x0001745C File Offset: 0x0001565C
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x00004B71 File Offset: 0x00002D71
		public unsafe static int kMoveDownHeight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextSelectingUtilities.NativeFieldInfoPtr_kMoveDownHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextSelectingUtilities.NativeFieldInfoPtr_kMoveDownHeight, (void*)(&value));
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00017478 File Offset: 0x00015678
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x00004B7F File Offset: 0x00002D7F
		public unsafe static char kNewLineChar
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(TextSelectingUtilities.NativeFieldInfoPtr_kNewLineChar, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextSelectingUtilities.NativeFieldInfoPtr_kNewLineChar, (void*)(&value));
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x00017494 File Offset: 0x00015694
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x00004B8D File Offset: 0x00002D8D
		public unsafe bool m_RevealCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_m_RevealCursor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_m_RevealCursor)) = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x000174BC File Offset: 0x000156BC
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x00004BA8 File Offset: 0x00002DA8
		public unsafe int m_CursorIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_m_CursorIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_m_CursorIndex)) = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x000174E4 File Offset: 0x000156E4
		// (set) Token: 0x0600065C RID: 1628 RVA: 0x00004BC3 File Offset: 0x00002DC3
		public unsafe int m_SelectIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_m_SelectIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_m_SelectIndex)) = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x0001750C File Offset: 0x0001570C
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x00004BDE File Offset: 0x00002DDE
		public unsafe static Dictionary<Event, TextSelectOp> s_KeySelectOps
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextSelectingUtilities.NativeFieldInfoPtr_s_KeySelectOps, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Event, TextSelectOp>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextSelectingUtilities.NativeFieldInfoPtr_s_KeySelectOps, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x00017534 File Offset: 0x00015734
		// (set) Token: 0x06000660 RID: 1632 RVA: 0x00004BF0 File Offset: 0x00002DF0
		public unsafe Action OnCursorIndexChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_OnCursorIndexChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_OnCursorIndexChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x00017564 File Offset: 0x00015764
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x00004C0F File Offset: 0x00002E0F
		public unsafe Action OnSelectIndexChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_OnSelectIndexChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_OnSelectIndexChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x00017594 File Offset: 0x00015794
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x00004C2E File Offset: 0x00002E2E
		public unsafe Action OnRevealCursorChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_OnRevealCursorChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSelectingUtilities.NativeFieldInfoPtr_OnRevealCursorChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeFieldInfoPtr_dblClickSnap;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeFieldInfoPtr_iAltCursorPos;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeFieldInfoPtr_hasHorizontalCursorPos;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeFieldInfoPtr_m_bJustSelected;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeFieldInfoPtr_m_MouseDragSelectsWholeWords;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeFieldInfoPtr_m_DblClickInitPosStart;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeFieldInfoPtr_m_DblClickInitPosEnd;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeFieldInfoPtr_m_TextHandle;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeFieldInfoPtr_kMoveDownHeight;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeFieldInfoPtr_kNewLineChar;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeFieldInfoPtr_m_RevealCursor;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeFieldInfoPtr_m_CursorIndex;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectIndex;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeFieldInfoPtr_s_KeySelectOps;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeFieldInfoPtr_OnCursorIndexChange;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeFieldInfoPtr_OnSelectIndexChange;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeFieldInfoPtr_OnRevealCursorChange;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_get_hasSelection_Public_get_Boolean_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_get_revealCursor_Public_get_Boolean_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_set_revealCursor_Public_set_Void_Boolean_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_get_m_CharacterCount_Private_get_Int32_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_get_characterCount_Private_get_Int32_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_get_m_TextElementInfos_Private_get_Il2CppReferenceArray_1_TextElementInfo_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_get_cursorIndex_Public_get_Int32_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_set_cursorIndex_Public_set_Void_Int32_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_SetCursorIndexWithoutNotify_Internal_Void_Int32_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_get_selectIndex_Public_get_Int32_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_set_selectIndex_Public_set_Void_Int32_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectIndexWithoutNotify_Internal_Void_Int32_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedText_Public_get_String_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextHandle_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_HandleKeyEvent_Internal_Boolean_Event_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_PerformOperation_Private_Boolean_TextSelectOp_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_MapKey_Private_Static_Void_String_TextSelectOp_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_InitKeyActions_Private_Void_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_ClearCursorPos_Public_Void_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_OnFocus_Public_Void_Boolean_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_SelectAll_Public_Void_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_SelectNone_Public_Void_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_SelectLeft_Public_Void_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_SelectRight_Public_Void_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_SelectUp_Public_Void_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_SelectDown_Public_Void_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_SelectTextEnd_Public_Void_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_SelectTextStart_Public_Void_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_SelectToStartOfNextWord_Public_Void_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_SelectToEndOfPreviousWord_Public_Void_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_SelectWordRight_Public_Void_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_SelectWordLeft_Public_Void_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_SelectGraphicalLineStart_Public_Void_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_SelectGraphicalLineEnd_Public_Void_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_SelectParagraphForward_Public_Void_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_SelectParagraphBackward_Public_Void_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_SelectCurrentWord_Public_Void_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_SelectCurrentParagraph_Public_Void_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_MoveRight_Public_Void_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_MoveLeft_Public_Void_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_MoveUp_Public_Void_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_MoveDown_Public_Void_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_MoveLineStart_Public_Void_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_MoveLineEnd_Public_Void_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_MoveGraphicalLineStart_Public_Void_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_MoveGraphicalLineEnd_Public_Void_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_MoveTextStart_Public_Void_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_MoveTextEnd_Public_Void_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_MoveParagraphForward_Public_Void_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_MoveParagraphBackward_Public_Void_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_MoveWordRight_Public_Void_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_MoveToStartOfNextWord_Public_Void_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_MoveToEndOfPreviousWord_Public_Void_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_MoveWordLeft_Public_Void_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_MouseDragSelectsWholeWords_Public_Void_Boolean_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_ExpandSelectGraphicalLineStart_Public_Void_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_ExpandSelectGraphicalLineEnd_Public_Void_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_DblClickSnap_Public_Void_DblClickSnapping_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_MoveCursorToPosition_Internal_FamOrAssem_Void_Vector2_Boolean_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_SelectToPosition_Public_Void_Vector2_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_FindNextSeperator_Private_Int32_Int32_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_FindPrevSeperator_Private_Int32_Int32_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_FindStartOfNextWord_Public_Int32_Int32_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_FindEndOfPreviousWord_Public_Int32_Int32_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_FindEndOfClassification_Private_Int32_Int32_Direction_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_ClampTextIndex_Private_Int32_Int32_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_EnsureValidCodePointIndex_Internal_Int32_Int32_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_IsValidCodePointIndex_Private_Boolean_Int32_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfEndOfLine_Private_Int32_Int32_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_PreviousCodePointIndex_Public_Int32_Int32_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_NextCodePointIndex_Public_Int32_Int32_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicalLineStart_Private_Int32_Int32_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicalLineEnd_Private_Int32_Int32_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Void_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_ClassifyChar_Private_CharacterType_Int32_0;

		// Token: 0x020000B4 RID: 180
		public enum CharacterType
		{
			// Token: 0x040003F2 RID: 1010
			LetterLike,
			// Token: 0x040003F3 RID: 1011
			Symbol,
			// Token: 0x040003F4 RID: 1012
			Symbol2,
			// Token: 0x040003F5 RID: 1013
			WhiteSpace,
			// Token: 0x040003F6 RID: 1014
			NewLine
		}

		// Token: 0x020000B5 RID: 181
		public enum Direction
		{
			// Token: 0x040003F8 RID: 1016
			Forward,
			// Token: 0x040003F9 RID: 1017
			Backward
		}
	}
}
