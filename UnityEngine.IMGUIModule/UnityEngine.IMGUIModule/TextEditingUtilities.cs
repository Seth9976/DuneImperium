using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.TextCore.Text;

namespace UnityEngine
{
	// Token: 0x0200001E RID: 30
	public class TextEditingUtilities : Object
	{
		// Token: 0x06000531 RID: 1329 RVA: 0x00012C80 File Offset: 0x00010E80
		// Note: this type is marked as 'beforefieldinit'.
		static TextEditingUtilities()
		{
			Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "TextEditingUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr);
			TextEditingUtilities.NativeFieldInfoPtr_m_TextSelectingUtility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, "m_TextSelectingUtility");
			TextEditingUtilities.NativeFieldInfoPtr_m_TextHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, "m_TextHandle");
			TextEditingUtilities.NativeFieldInfoPtr_m_CursorIndexSavedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, "m_CursorIndexSavedState");
			TextEditingUtilities.NativeFieldInfoPtr_isCompositionActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, "isCompositionActive");
			TextEditingUtilities.NativeFieldInfoPtr_m_UpdateImeWindowPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, "m_UpdateImeWindowPosition");
			TextEditingUtilities.NativeFieldInfoPtr_multiline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, "multiline");
			TextEditingUtilities.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, "m_Text");
			TextEditingUtilities.NativeFieldInfoPtr_s_KeyEditOps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, "s_KeyEditOps");
			TextEditingUtilities.NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663658);
			TextEditingUtilities.NativeMethodInfoPtr_set_revealCursor_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663659);
			TextEditingUtilities.NativeMethodInfoPtr_get_cursorIndex_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663660);
			TextEditingUtilities.NativeMethodInfoPtr_set_cursorIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663661);
			TextEditingUtilities.NativeMethodInfoPtr_get_selectIndex_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663662);
			TextEditingUtilities.NativeMethodInfoPtr_set_selectIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663663);
			TextEditingUtilities.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663664);
			TextEditingUtilities.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663665);
			TextEditingUtilities.NativeMethodInfoPtr__ctor_Public_Void_TextSelectingUtilities_TextHandle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663666);
			TextEditingUtilities.NativeMethodInfoPtr_UpdateImeState_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663667);
			TextEditingUtilities.NativeMethodInfoPtr_ShouldUpdateImeWindowPosition_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663668);
			TextEditingUtilities.NativeMethodInfoPtr_SetImeWindowPosition_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663669);
			TextEditingUtilities.NativeMethodInfoPtr_GeneratePreviewString_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663670);
			TextEditingUtilities.NativeMethodInfoPtr_EnableCursorPreviewState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663671);
			TextEditingUtilities.NativeMethodInfoPtr_RestoreCursorState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663672);
			TextEditingUtilities.NativeMethodInfoPtr_HandleKeyEvent_Internal_Boolean_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663673);
			TextEditingUtilities.NativeMethodInfoPtr_PerformOperation_Private_Void_TextEditOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663674);
			TextEditingUtilities.NativeMethodInfoPtr_MapKey_Private_Static_Void_String_TextEditOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663675);
			TextEditingUtilities.NativeMethodInfoPtr_InitKeyActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663676);
			TextEditingUtilities.NativeMethodInfoPtr_DeleteLineBack_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663677);
			TextEditingUtilities.NativeMethodInfoPtr_DeleteWordBack_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663678);
			TextEditingUtilities.NativeMethodInfoPtr_DeleteWordForward_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663679);
			TextEditingUtilities.NativeMethodInfoPtr_Delete_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663680);
			TextEditingUtilities.NativeMethodInfoPtr_Backspace_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663681);
			TextEditingUtilities.NativeMethodInfoPtr_DeleteSelection_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663682);
			TextEditingUtilities.NativeMethodInfoPtr_ReplaceSelection_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663683);
			TextEditingUtilities.NativeMethodInfoPtr_Insert_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663684);
			TextEditingUtilities.NativeMethodInfoPtr_CanPaste_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663685);
			TextEditingUtilities.NativeMethodInfoPtr_Cut_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663686);
			TextEditingUtilities.NativeMethodInfoPtr_Paste_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663687);
			TextEditingUtilities.NativeMethodInfoPtr_ReplaceNewlinesWithSpaces_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663688);
			TextEditingUtilities.NativeMethodInfoPtr_OnBlur_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663689);
			TextEditingUtilities.NativeMethodInfoPtr_TouchScreenKeyboardShouldBeUsed_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663690);
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00012FE4 File Offset: 0x000111E4
		public unsafe bool hasSelection
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188231, XrefRangeEnd = 1188233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x0001394C File Offset: 0x00011B4C
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x00013020 File Offset: 0x00011220
		public unsafe bool revealCursor
		{
			get
			{
				return this.m_TextSelectingUtility.revealCursor;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_set_revealCursor_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00013060 File Offset: 0x00011260
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x0001309C File Offset: 0x0001129C
		public unsafe int cursorIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188233, XrefRangeEnd = 1188235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_get_cursorIndex_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_set_cursorIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x000130DC File Offset: 0x000112DC
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x00013118 File Offset: 0x00011318
		public unsafe int selectIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188235, XrefRangeEnd = 1188237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_get_selectIndex_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_set_selectIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00013158 File Offset: 0x00011358
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x00013190 File Offset: 0x00011390
		public unsafe string text
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 318860, RefRangeEnd = 318862, XrefRangeStart = 318860, XrefRangeEnd = 318862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1188241, RefRangeEnd = 1188243, XrefRangeStart = 1188237, XrefRangeEnd = 1188241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x000131D4 File Offset: 0x000113D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1188247, RefRangeEnd = 1188248, XrefRangeStart = 1188243, XrefRangeEnd = 1188247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextEditingUtilities(TextSelectingUtilities selectingUtilities, TextHandle textHandle, string text)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectingUtilities);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textHandle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr__ctor_Public_Void_TextSelectingUtilities_TextHandle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00013244 File Offset: 0x00011444
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1188254, RefRangeEnd = 1188255, XrefRangeStart = 1188248, XrefRangeEnd = 1188254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UpdateImeState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_UpdateImeState_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00013280 File Offset: 0x00011480
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1188255, RefRangeEnd = 1188256, XrefRangeStart = 1188255, XrefRangeEnd = 1188255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldUpdateImeWindowPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_ShouldUpdateImeWindowPosition_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x000132BC File Offset: 0x000114BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1188266, RefRangeEnd = 1188267, XrefRangeStart = 1188256, XrefRangeEnd = 1188266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetImeWindowPosition(Vector2 worldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref worldPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_SetImeWindowPosition_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000132FC File Offset: 0x000114FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1188282, RefRangeEnd = 1188283, XrefRangeStart = 1188267, XrefRangeEnd = 1188282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GeneratePreviewString(bool richText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref richText;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_GeneratePreviewString_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00013340 File Offset: 0x00011540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1188289, RefRangeEnd = 1188290, XrefRangeStart = 1188283, XrefRangeEnd = 1188289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableCursorPreviewState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_EnableCursorPreviewState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00013374 File Offset: 0x00011574
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1188290, RefRangeEnd = 1188299, XrefRangeStart = 1188290, XrefRangeEnd = 1188290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreCursorState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_RestoreCursorState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000133A8 File Offset: 0x000115A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1188315, RefRangeEnd = 1188316, XrefRangeStart = 1188299, XrefRangeEnd = 1188315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleKeyEvent(Event e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_HandleKeyEvent_Internal_Boolean_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x000133F8 File Offset: 0x000115F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188316, XrefRangeEnd = 1188320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformOperation(TextEditOp operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref operation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_PerformOperation_Private_Void_TextEditOp_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00013438 File Offset: 0x00011638
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1188327, RefRangeEnd = 1188350, XrefRangeStart = 1188320, XrefRangeEnd = 1188327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MapKey(string key, TextEditOp action)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_MapKey_Private_Static_Void_String_TextEditOp_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0001347C File Offset: 0x0001167C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1188453, RefRangeEnd = 1188454, XrefRangeStart = 1188350, XrefRangeEnd = 1188453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitKeyActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_InitKeyActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x000134B0 File Offset: 0x000116B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188454, XrefRangeEnd = 1188460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeleteLineBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_DeleteLineBack_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x000134EC File Offset: 0x000116EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188460, XrefRangeEnd = 1188466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeleteWordBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_DeleteWordBack_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00013528 File Offset: 0x00011728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188466, XrefRangeEnd = 1188472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeleteWordForward()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_DeleteWordForward_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00013564 File Offset: 0x00011764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188472, XrefRangeEnd = 1188476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_Delete_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x000135A0 File Offset: 0x000117A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188476, XrefRangeEnd = 1188480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Backspace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_Backspace_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x000135DC File Offset: 0x000117DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1188507, RefRangeEnd = 1188509, XrefRangeStart = 1188480, XrefRangeEnd = 1188507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeleteSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_DeleteSelection_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00013618 File Offset: 0x00011818
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1188518, RefRangeEnd = 1188519, XrefRangeStart = 1188509, XrefRangeEnd = 1188518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceSelection(string replace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(replace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_ReplaceSelection_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0001365C File Offset: 0x0001185C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188519, XrefRangeEnd = 1188524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_Insert_Public_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0001369C File Offset: 0x0001189C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1188529, RefRangeEnd = 1188530, XrefRangeStart = 1188524, XrefRangeEnd = 1188529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanPaste()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_CanPaste_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x000136D8 File Offset: 0x000118D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188530, XrefRangeEnd = 1188533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Cut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_Cut_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00013714 File Offset: 0x00011914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188533, XrefRangeEnd = 1188542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Paste()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_Paste_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00013750 File Offset: 0x00011950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188542, XrefRangeEnd = 1188550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReplaceNewlinesWithSpaces(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_ReplaceNewlinesWithSpaces_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0001378C File Offset: 0x0001198C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1188551, RefRangeEnd = 1188553, XrefRangeStart = 1188550, XrefRangeEnd = 1188551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBlur()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_OnBlur_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x000137C0 File Offset: 0x000119C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1188559, RefRangeEnd = 1188564, XrefRangeStart = 1188553, XrefRangeEnd = 1188559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TouchScreenKeyboardShouldBeUsed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingUtilities.NativeMethodInfoPtr_TouchScreenKeyboardShouldBeUsed_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0000454C File Offset: 0x0000274C
		public TextEditingUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x000137FC File Offset: 0x000119FC
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x00004555 File Offset: 0x00002755
		public unsafe TextSelectingUtilities m_TextSelectingUtility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingUtilities.NativeFieldInfoPtr_m_TextSelectingUtility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextSelectingUtilities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingUtilities.NativeFieldInfoPtr_m_TextSelectingUtility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x0001382C File Offset: 0x00011A2C
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x00004574 File Offset: 0x00002774
		public unsafe TextHandle m_TextHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingUtilities.NativeFieldInfoPtr_m_TextHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingUtilities.NativeFieldInfoPtr_m_TextHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x0001385C File Offset: 0x00011A5C
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x00004593 File Offset: 0x00002793
		public unsafe int m_CursorIndexSavedState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingUtilities.NativeFieldInfoPtr_m_CursorIndexSavedState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingUtilities.NativeFieldInfoPtr_m_CursorIndexSavedState)) = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x00013884 File Offset: 0x00011A84
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x000045AE File Offset: 0x000027AE
		public unsafe bool isCompositionActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingUtilities.NativeFieldInfoPtr_isCompositionActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingUtilities.NativeFieldInfoPtr_isCompositionActive)) = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x000138AC File Offset: 0x00011AAC
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x000045C9 File Offset: 0x000027C9
		public unsafe bool m_UpdateImeWindowPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingUtilities.NativeFieldInfoPtr_m_UpdateImeWindowPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingUtilities.NativeFieldInfoPtr_m_UpdateImeWindowPosition)) = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x000138D4 File Offset: 0x00011AD4
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x000045E4 File Offset: 0x000027E4
		public unsafe bool multiline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingUtilities.NativeFieldInfoPtr_multiline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingUtilities.NativeFieldInfoPtr_multiline)) = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x000138FC File Offset: 0x00011AFC
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x000045FF File Offset: 0x000027FF
		public unsafe string m_Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingUtilities.NativeFieldInfoPtr_m_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingUtilities.NativeFieldInfoPtr_m_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00013924 File Offset: 0x00011B24
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x0000461E File Offset: 0x0000281E
		public unsafe static Dictionary<Event, TextEditOp> s_KeyEditOps
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextEditingUtilities.NativeFieldInfoPtr_s_KeyEditOps, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Event, TextEditOp>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextEditingUtilities.NativeFieldInfoPtr_s_KeyEditOps, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00004630 File Offset: 0x00002830
		public string SelectedText
		{
			get
			{
				return this.m_TextSelectingUtility.selectedText;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x0000463D File Offset: 0x0000283D
		public int m_iAltCursorPos
		{
			get
			{
				return this.m_TextSelectingUtility.iAltCursorPos;
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0001396C File Offset: 0x00011B6C
		public void MoveSelectionToAltCursor()
		{
			this.RestoreCursorState();
			bool flag = this.m_iAltCursorPos == -1;
			if (!flag)
			{
				int iAltCursorPos = this.m_iAltCursorPos;
				string selectedText = this.SelectedText;
				this.text = this.text.Insert(iAltCursorPos, selectedText);
				bool flag2 = iAltCursorPos < this.cursorIndex;
				if (flag2)
				{
					this.cursorIndex += selectedText.Length;
					this.selectIndex += selectedText.Length;
				}
				this.DeleteSelection();
				this.selectIndex = (this.cursorIndex = iAltCursorPos);
				this.m_TextSelectingUtility.ClearCursorPos();
			}
		}

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeFieldInfoPtr_m_TextSelectingUtility;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeFieldInfoPtr_m_TextHandle;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeFieldInfoPtr_m_CursorIndexSavedState;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeFieldInfoPtr_isCompositionActive;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateImeWindowPosition;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeFieldInfoPtr_multiline;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeFieldInfoPtr_m_Text;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeFieldInfoPtr_s_KeyEditOps;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_set_revealCursor_Internal_set_Void_Boolean_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_get_cursorIndex_Private_get_Int32_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_set_cursorIndex_Private_set_Void_Int32_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_get_selectIndex_Private_get_Int32_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_set_selectIndex_Private_set_Void_Int32_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextSelectingUtilities_TextHandle_String_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_UpdateImeState_Public_Boolean_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_ShouldUpdateImeWindowPosition_Public_Boolean_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_SetImeWindowPosition_Public_Void_Vector2_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePreviewString_Public_String_Boolean_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_EnableCursorPreviewState_Public_Void_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_RestoreCursorState_Public_Void_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_HandleKeyEvent_Internal_Boolean_Event_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_PerformOperation_Private_Void_TextEditOp_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_MapKey_Private_Static_Void_String_TextEditOp_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_InitKeyActions_Private_Void_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_DeleteLineBack_Public_Boolean_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_DeleteWordBack_Public_Boolean_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_DeleteWordForward_Public_Boolean_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Boolean_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_Backspace_Public_Boolean_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_DeleteSelection_Public_Boolean_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceSelection_Public_Void_String_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Void_Char_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_CanPaste_Public_Boolean_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_Cut_Public_Boolean_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_Paste_Public_Boolean_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceNewlinesWithSpaces_Private_Static_String_String_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_OnBlur_Internal_Void_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_TouchScreenKeyboardShouldBeUsed_Internal_Boolean_0;
	}
}
