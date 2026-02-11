using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000012 RID: 18
	[Serializable]
	public sealed class GUIStyle : Object
	{
		// Token: 0x06000371 RID: 881 RVA: 0x0000DE74 File Offset: 0x0000C074
		// Note: this type is marked as 'beforefieldinit'.
		static GUIStyle()
		{
			Il2CppClassPointerStore<GUIStyle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIStyle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr);
			GUIStyle.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Ptr");
			GUIStyle.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Normal");
			GUIStyle.NativeFieldInfoPtr_m_Hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Hover");
			GUIStyle.NativeFieldInfoPtr_m_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Active");
			GUIStyle.NativeFieldInfoPtr_m_Focused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Focused");
			GUIStyle.NativeFieldInfoPtr_m_OnNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_OnNormal");
			GUIStyle.NativeFieldInfoPtr_m_OnHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_OnHover");
			GUIStyle.NativeFieldInfoPtr_m_OnActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_OnActive");
			GUIStyle.NativeFieldInfoPtr_m_OnFocused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_OnFocused");
			GUIStyle.NativeFieldInfoPtr_m_Border = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Border");
			GUIStyle.NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Padding");
			GUIStyle.NativeFieldInfoPtr_m_Margin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Margin");
			GUIStyle.NativeFieldInfoPtr_m_Overflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Overflow");
			GUIStyle.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Name");
			GUIStyle.NativeFieldInfoPtr_showKeyboardFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "showKeyboardFocus");
			GUIStyle.NativeFieldInfoPtr_s_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "s_None");
			GUIStyle.NativeMethodInfoPtr_get_rawName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663520);
			GUIStyle.NativeMethodInfoPtr_set_rawName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663521);
			GUIStyle.NativeMethodInfoPtr_get_fixedWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663522);
			GUIStyle.NativeMethodInfoPtr_get_fixedHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663523);
			GUIStyle.NativeMethodInfoPtr_get_stretchWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663524);
			GUIStyle.NativeMethodInfoPtr_get_stretchHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663525);
			GUIStyle.NativeMethodInfoPtr_set_stretchHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663526);
			GUIStyle.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663527);
			GUIStyle.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663528);
			GUIStyle.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663529);
			GUIStyle.NativeMethodInfoPtr_GetStyleStatePtr_Private_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663530);
			GUIStyle.NativeMethodInfoPtr_AssignStyleState_Private_Void_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663531);
			GUIStyle.NativeMethodInfoPtr_GetRectOffsetPtr_Private_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663532);
			GUIStyle.NativeMethodInfoPtr_Internal_Draw_Private_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663533);
			GUIStyle.NativeMethodInfoPtr_Internal_Draw2_Private_Void_Rect_GUIContent_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663534);
			GUIStyle.NativeMethodInfoPtr_SetMouseTooltip_Internal_Static_Void_String_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663535);
			GUIStyle.NativeMethodInfoPtr_IsTooltipActive_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663536);
			GUIStyle.NativeMethodInfoPtr_SetDefaultFont_Internal_Static_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663537);
			GUIStyle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663538);
			GUIStyle.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663539);
			GUIStyle.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663540);
			GUIStyle.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663541);
			GUIStyle.NativeMethodInfoPtr_get_normal_Public_get_GUIStyleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663542);
			GUIStyle.NativeMethodInfoPtr_set_normal_Public_set_Void_GUIStyleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663543);
			GUIStyle.NativeMethodInfoPtr_get_margin_Public_get_RectOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663544);
			GUIStyle.NativeMethodInfoPtr_get_padding_Public_get_RectOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663545);
			GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663546);
			GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663547);
			GUIStyle.NativeMethodInfoPtr_Draw_Private_Void_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663548);
			GUIStyle.NativeMethodInfoPtr_get_none_Public_Static_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663549);
			GUIStyle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663550);
			GUIStyle.NativeMethodInfoPtr_Internal_Draw_Injected_Private_Void_byref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663552);
			GUIStyle.NativeMethodInfoPtr_Internal_Draw2_Injected_Private_Void_byref_Rect_GUIContent_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663553);
			GUIStyle.NativeMethodInfoPtr_SetMouseTooltip_Injected_Private_Static_Void_String_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663554);
			GUIStyle.get_fontDelegateField = IL2CPP.ResolveICall<GUIStyle.get_fontDelegate>("UnityEngine.GUIStyle::get_font");
			GUIStyle.set_fontDelegateField = IL2CPP.ResolveICall<GUIStyle.set_fontDelegate>("UnityEngine.GUIStyle::set_font");
			GUIStyle.get_imagePositionDelegateField = IL2CPP.ResolveICall<GUIStyle.get_imagePositionDelegate>("UnityEngine.GUIStyle::get_imagePosition");
			GUIStyle.set_imagePositionDelegateField = IL2CPP.ResolveICall<GUIStyle.set_imagePositionDelegate>("UnityEngine.GUIStyle::set_imagePosition");
			GUIStyle.get_alignmentDelegateField = IL2CPP.ResolveICall<GUIStyle.get_alignmentDelegate>("UnityEngine.GUIStyle::get_alignment");
			GUIStyle.set_alignmentDelegateField = IL2CPP.ResolveICall<GUIStyle.set_alignmentDelegate>("UnityEngine.GUIStyle::set_alignment");
			GUIStyle.get_wordWrapDelegateField = IL2CPP.ResolveICall<GUIStyle.get_wordWrapDelegate>("UnityEngine.GUIStyle::get_wordWrap");
			GUIStyle.set_wordWrapDelegateField = IL2CPP.ResolveICall<GUIStyle.set_wordWrapDelegate>("UnityEngine.GUIStyle::set_wordWrap");
			GUIStyle.get_clippingDelegateField = IL2CPP.ResolveICall<GUIStyle.get_clippingDelegate>("UnityEngine.GUIStyle::get_clipping");
			GUIStyle.set_clippingDelegateField = IL2CPP.ResolveICall<GUIStyle.set_clippingDelegate>("UnityEngine.GUIStyle::set_clipping");
			GUIStyle.set_fixedWidthDelegateField = IL2CPP.ResolveICall<GUIStyle.set_fixedWidthDelegate>("UnityEngine.GUIStyle::set_fixedWidth");
			GUIStyle.set_fixedHeightDelegateField = IL2CPP.ResolveICall<GUIStyle.set_fixedHeightDelegate>("UnityEngine.GUIStyle::set_fixedHeight");
			GUIStyle.set_stretchWidthDelegateField = IL2CPP.ResolveICall<GUIStyle.set_stretchWidthDelegate>("UnityEngine.GUIStyle::set_stretchWidth");
			GUIStyle.get_fontSizeDelegateField = IL2CPP.ResolveICall<GUIStyle.get_fontSizeDelegate>("UnityEngine.GUIStyle::get_fontSize");
			GUIStyle.get_fontStyleDelegateField = IL2CPP.ResolveICall<GUIStyle.get_fontStyleDelegate>("UnityEngine.GUIStyle::get_fontStyle");
			GUIStyle.set_fontStyleDelegateField = IL2CPP.ResolveICall<GUIStyle.set_fontStyleDelegate>("UnityEngine.GUIStyle::set_fontStyle");
			GUIStyle.get_richTextDelegateField = IL2CPP.ResolveICall<GUIStyle.get_richTextDelegate>("UnityEngine.GUIStyle::get_richText");
			GUIStyle.set_richTextDelegateField = IL2CPP.ResolveICall<GUIStyle.set_richTextDelegate>("UnityEngine.GUIStyle::set_richText");
			GUIStyle.Internal_CopyDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_CopyDelegate>("UnityEngine.GUIStyle::Internal_Copy");
			GUIStyle.AssignRectOffsetDelegateField = IL2CPP.ResolveICall<GUIStyle.AssignRectOffsetDelegate>("UnityEngine.GUIStyle::AssignRectOffset");
			GUIStyle.Internal_GetLineHeightDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_GetLineHeightDelegate>("UnityEngine.GUIStyle::Internal_GetLineHeight");
			GUIStyle.Internal_GetNumCharactersThatFitWithinWidthDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_GetNumCharactersThatFitWithinWidthDelegate>("UnityEngine.GUIStyle::Internal_GetNumCharactersThatFitWithinWidth");
			GUIStyle.Internal_CalcHeightDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_CalcHeightDelegate>("UnityEngine.GUIStyle::Internal_CalcHeight");
			GUIStyle.Internal_GetCursorFlashOffsetDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_GetCursorFlashOffsetDelegate>("UnityEngine.GUIStyle::Internal_GetCursorFlashOffset");
			GUIStyle.get_contentOffset_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.get_contentOffset_InjectedDelegate>("UnityEngine.GUIStyle::get_contentOffset_Injected");
			GUIStyle.set_contentOffset_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.set_contentOffset_InjectedDelegate>("UnityEngine.GUIStyle::set_contentOffset_Injected");
			GUIStyle.get_clipOffset_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.get_clipOffset_InjectedDelegate>("UnityEngine.GUIStyle::get_clipOffset_Injected");
			GUIStyle.set_clipOffset_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.set_clipOffset_InjectedDelegate>("UnityEngine.GUIStyle::set_clipOffset_Injected");
			GUIStyle.get_Internal_clipOffset_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.get_Internal_clipOffset_InjectedDelegate>("UnityEngine.GUIStyle::get_Internal_clipOffset_Injected");
			GUIStyle.set_Internal_clipOffset_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.set_Internal_clipOffset_InjectedDelegate>("UnityEngine.GUIStyle::set_Internal_clipOffset_Injected");
			GUIStyle.Internal_DrawCursor_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_DrawCursor_InjectedDelegate>("UnityEngine.GUIStyle::Internal_DrawCursor_Injected");
			GUIStyle.Internal_DrawWithTextSelection_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_DrawWithTextSelection_InjectedDelegate>("UnityEngine.GUIStyle::Internal_DrawWithTextSelection_Injected");
			GUIStyle.Internal_GetCursorPixelPosition_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_GetCursorPixelPosition_InjectedDelegate>("UnityEngine.GUIStyle::Internal_GetCursorPixelPosition_Injected");
			GUIStyle.Internal_GetCursorStringIndex_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_GetCursorStringIndex_InjectedDelegate>("UnityEngine.GUIStyle::Internal_GetCursorStringIndex_Injected");
			GUIStyle.Internal_GetSelectedRenderedText_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_GetSelectedRenderedText_InjectedDelegate>("UnityEngine.GUIStyle::Internal_GetSelectedRenderedText_Injected");
			GUIStyle.Internal_GetHyperlinksRect_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_GetHyperlinksRect_InjectedDelegate>("UnityEngine.GUIStyle::Internal_GetHyperlinksRect_Injected");
			GUIStyle.Internal_CalcSize_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_CalcSize_InjectedDelegate>("UnityEngine.GUIStyle::Internal_CalcSize_Injected");
			GUIStyle.Internal_CalcSizeWithConstraints_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_CalcSizeWithConstraints_InjectedDelegate>("UnityEngine.GUIStyle::Internal_CalcSizeWithConstraints_Injected");
			GUIStyle.Internal_CalcMinMaxWidth_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_CalcMinMaxWidth_InjectedDelegate>("UnityEngine.GUIStyle::Internal_CalcMinMaxWidth_Injected");
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
		// (set) Token: 0x06000373 RID: 883 RVA: 0x0000E510 File Offset: 0x0000C710
		public unsafe string rawName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187060, XrefRangeEnd = 1187062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_rawName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187062, XrefRangeEnd = 1187064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_rawName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0000E554 File Offset: 0x0000C754
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x0000396E File Offset: 0x00001B6E
		public unsafe float fixedWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187064, XrefRangeEnd = 1187066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_fixedWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				GUIStyle.set_fixedWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000375 RID: 885 RVA: 0x0000E590 File Offset: 0x0000C790
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x00003981 File Offset: 0x00001B81
		public unsafe float fixedHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187066, XrefRangeEnd = 1187068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_fixedHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				GUIStyle.set_fixedHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0000E5CC File Offset: 0x0000C7CC
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00003994 File Offset: 0x00001B94
		public unsafe bool stretchWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187068, XrefRangeEnd = 1187070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_stretchWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				GUIStyle.set_stretchWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0000E608 File Offset: 0x0000C808
		// (set) Token: 0x06000378 RID: 888 RVA: 0x0000E644 File Offset: 0x0000C844
		public unsafe bool stretchHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187070, XrefRangeEnd = 1187072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_stretchHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187072, XrefRangeEnd = 1187074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_stretchHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x000039A7 File Offset: 0x00001BA7
		// (set) Token: 0x06000379 RID: 889 RVA: 0x0000E684 File Offset: 0x0000C884
		public unsafe int fontSize
		{
			get
			{
				return GUIStyle.get_fontSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1187076, RefRangeEnd = 1187077, XrefRangeStart = 1187074, XrefRangeEnd = 1187076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000E6C4 File Offset: 0x0000C8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187077, XrefRangeEnd = 1187079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Internal_Create(GUIStyle self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000E708 File Offset: 0x0000C908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187079, XrefRangeEnd = 1187081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Destroy(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000E73C File Offset: 0x0000C93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187081, XrefRangeEnd = 1187083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetStyleStatePtr(int idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_GetStyleStatePtr_Private_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000E788 File Offset: 0x0000C988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187083, XrefRangeEnd = 1187085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignStyleState(int idx, IntPtr srcStyleState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcStyleState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_AssignStyleState_Private_Void_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000E7D4 File Offset: 0x0000C9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187085, XrefRangeEnd = 1187087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetRectOffsetPtr(int idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_GetRectOffsetPtr_Private_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000E820 File Offset: 0x0000CA20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187087, XrefRangeEnd = 1187089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHover;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActive;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasKeyboardFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_Draw_Private_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000E8A8 File Offset: 0x0000CAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187089, XrefRangeEnd = 1187091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_Draw2_Private_Void_Rect_GUIContent_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000E914 File Offset: 0x0000CB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187091, XrefRangeEnd = 1187096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMouseTooltip(string tooltip, Rect screenRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_SetMouseTooltip_Internal_Static_Void_String_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000E958 File Offset: 0x0000CB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187096, XrefRangeEnd = 1187098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTooltipActive(string tooltip)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tooltip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_IsTooltipActive_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000E99C File Offset: 0x0000CB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187098, XrefRangeEnd = 1187100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefaultFont(Font font)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_SetDefaultFont_Internal_Static_Void_Font_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000E9D4 File Offset: 0x0000CBD4
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1187106, RefRangeEnd = 1187130, XrefRangeStart = 1187100, XrefRangeEnd = 1187106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIStyle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000EA10 File Offset: 0x0000CC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187130, XrefRangeEnd = 1187139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0000EA44 File Offset: 0x0000CC44
		// (set) Token: 0x06000387 RID: 903 RVA: 0x0000EA7C File Offset: 0x0000CC7C
		public unsafe string name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1187142, RefRangeEnd = 1187143, XrefRangeStart = 1187139, XrefRangeEnd = 1187142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187143, XrefRangeEnd = 1187146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		// (set) Token: 0x06000389 RID: 905 RVA: 0x0000EB00 File Offset: 0x0000CD00
		public unsafe GUIStyleState normal
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 1187154, RefRangeEnd = 1187177, XrefRangeStart = 1187146, XrefRangeEnd = 1187154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_normal_Public_get_GUIStyleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1187180, RefRangeEnd = 1187181, XrefRangeStart = 1187177, XrefRangeEnd = 1187180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_normal_Public_set_Void_GUIStyleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0000EB44 File Offset: 0x0000CD44
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00003B53 File Offset: 0x00001D53
		public unsafe RectOffset margin
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1187188, RefRangeEnd = 1187196, XrefRangeStart = 1187181, XrefRangeEnd = 1187188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_margin_Public_get_RectOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr3) : null;
			}
			set
			{
				this.AssignRectOffset(1, value.m_Ptr);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600038B RID: 907 RVA: 0x0000EB84 File Offset: 0x0000CD84
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x00003B64 File Offset: 0x00001D64
		public unsafe RectOffset padding
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1187203, RefRangeEnd = 1187209, XrefRangeStart = 1187196, XrefRangeEnd = 1187203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_padding_Public_get_RectOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr3) : null;
			}
			set
			{
				this.AssignRectOffset(2, value.m_Ptr);
			}
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000EBC4 File Offset: 0x0000CDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187209, XrefRangeEnd = 1187211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHover;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActive;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasKeyboardFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000EC4C File Offset: 0x0000CE4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1187235, RefRangeEnd = 1187237, XrefRangeStart = 1187211, XrefRangeEnd = 1187235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hover;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000ECC8 File Offset: 0x0000CEC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1187239, RefRangeEnd = 1187240, XrefRangeStart = 1187237, XrefRangeEnd = 1187239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHover;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActive;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasKeyboardFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Draw_Private_Void_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0000ED60 File Offset: 0x0000CF60
		public unsafe static GUIStyle none
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1187251, RefRangeEnd = 1187261, XrefRangeStart = 1187240, XrefRangeEnd = 1187251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_none_Public_Static_get_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000ED94 File Offset: 0x0000CF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187261, XrefRangeEnd = 1187278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000EDCC File Offset: 0x0000CFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187278, XrefRangeEnd = 1187280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &screenRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHover;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActive;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasKeyboardFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_Draw_Injected_Private_Void_byref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000EE54 File Offset: 0x0000D054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187280, XrefRangeEnd = 1187282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_Draw2_Injected_Private_Void_byref_Rect_GUIContent_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000EEC0 File Offset: 0x0000D0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187282, XrefRangeEnd = 1187284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &screenRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_SetMouseTooltip_Injected_Private_Static_Void_String_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x000036E1 File Offset: 0x000018E1
		public GUIStyle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000395 RID: 917 RVA: 0x0000EF04 File Offset: 0x0000D104
		// (set) Token: 0x06000396 RID: 918 RVA: 0x000036EA File Offset: 0x000018EA
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000397 RID: 919 RVA: 0x0000EF2C File Offset: 0x0000D12C
		// (set) Token: 0x06000398 RID: 920 RVA: 0x00003705 File Offset: 0x00001905
		public unsafe GUIStyleState m_Normal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Normal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Normal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000399 RID: 921 RVA: 0x0000EF5C File Offset: 0x0000D15C
		// (set) Token: 0x0600039A RID: 922 RVA: 0x00003724 File Offset: 0x00001924
		public unsafe GUIStyleState m_Hover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Hover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Hover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0000EF8C File Offset: 0x0000D18C
		// (set) Token: 0x0600039C RID: 924 RVA: 0x00003743 File Offset: 0x00001943
		public unsafe GUIStyleState m_Active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Active);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Active), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600039D RID: 925 RVA: 0x0000EFBC File Offset: 0x0000D1BC
		// (set) Token: 0x0600039E RID: 926 RVA: 0x00003762 File Offset: 0x00001962
		public unsafe GUIStyleState m_Focused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Focused);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Focused), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600039F RID: 927 RVA: 0x0000EFEC File Offset: 0x0000D1EC
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x00003781 File Offset: 0x00001981
		public unsafe GUIStyleState m_OnNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0000F01C File Offset: 0x0000D21C
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x000037A0 File Offset: 0x000019A0
		public unsafe GUIStyleState m_OnHover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnHover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnHover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0000F04C File Offset: 0x0000D24C
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x000037BF File Offset: 0x000019BF
		public unsafe GUIStyleState m_OnActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnActive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnActive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x0000F07C File Offset: 0x0000D27C
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x000037DE File Offset: 0x000019DE
		public unsafe GUIStyleState m_OnFocused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnFocused);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnFocused), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x0000F0AC File Offset: 0x0000D2AC
		// (set) Token: 0x060003A8 RID: 936 RVA: 0x000037FD File Offset: 0x000019FD
		public unsafe RectOffset m_Border
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Border);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Border), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x0000F0DC File Offset: 0x0000D2DC
		// (set) Token: 0x060003AA RID: 938 RVA: 0x0000381C File Offset: 0x00001A1C
		public unsafe RectOffset m_Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Padding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Padding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0000F10C File Offset: 0x0000D30C
		// (set) Token: 0x060003AC RID: 940 RVA: 0x0000383B File Offset: 0x00001A3B
		public unsafe RectOffset m_Margin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Margin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Margin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0000F13C File Offset: 0x0000D33C
		// (set) Token: 0x060003AE RID: 942 RVA: 0x0000385A File Offset: 0x00001A5A
		public unsafe RectOffset m_Overflow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Overflow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Overflow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0000F16C File Offset: 0x0000D36C
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00003879 File Offset: 0x00001A79
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x0000F194 File Offset: 0x0000D394
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00003898 File Offset: 0x00001A98
		public unsafe static bool showKeyboardFocus
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(GUIStyle.NativeFieldInfoPtr_showKeyboardFocus, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIStyle.NativeFieldInfoPtr_showKeyboardFocus, (void*)(&value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x000038A6 File Offset: 0x00001AA6
		public unsafe static GUIStyle s_None
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIStyle.NativeFieldInfoPtr_s_None, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIStyle.NativeFieldInfoPtr_s_None, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0000F1D8 File Offset: 0x0000D3D8
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x000038B8 File Offset: 0x00001AB8
		public Font font
		{
			get
			{
				IntPtr intPtr = GUIStyle.get_fontDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				GUIStyle.set_fontDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x000038D0 File Offset: 0x00001AD0
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x000038E2 File Offset: 0x00001AE2
		public ImagePosition imagePosition
		{
			get
			{
				return GUIStyle.get_imagePositionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				GUIStyle.set_imagePositionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x000038F5 File Offset: 0x00001AF5
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00003907 File Offset: 0x00001B07
		public TextAnchor alignment
		{
			get
			{
				return GUIStyle.get_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				GUIStyle.set_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003BB RID: 955 RVA: 0x0000391A File Offset: 0x00001B1A
		// (set) Token: 0x060003BC RID: 956 RVA: 0x0000392C File Offset: 0x00001B2C
		public bool wordWrap
		{
			get
			{
				return GUIStyle.get_wordWrapDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				GUIStyle.set_wordWrapDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000393F File Offset: 0x00001B3F
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00003951 File Offset: 0x00001B51
		public TextClipping clipping
		{
			get
			{
				return GUIStyle.get_clippingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				GUIStyle.set_clippingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0000F204 File Offset: 0x0000D404
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x00003964 File Offset: 0x00001B64
		public Vector2 contentOffset
		{
			get
			{
				Vector2 vector;
				this.get_contentOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_contentOffset_Injected(ref value);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x000039B9 File Offset: 0x00001BB9
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x000039CB File Offset: 0x00001BCB
		public FontStyle fontStyle
		{
			get
			{
				return GUIStyle.get_fontStyleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				GUIStyle.set_fontStyleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x000039DE File Offset: 0x00001BDE
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x000039F0 File Offset: 0x00001BF0
		public bool richText
		{
			get
			{
				return GUIStyle.get_richTextDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				GUIStyle.set_richTextDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0000F21C File Offset: 0x0000D41C
		// (set) Token: 0x060003CA RID: 970 RVA: 0x00003A03 File Offset: 0x00001C03
		public Vector2 clipOffset
		{
			get
			{
				Vector2 vector;
				this.get_clipOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_clipOffset_Injected(ref value);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0000F234 File Offset: 0x0000D434
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00003A0D File Offset: 0x00001C0D
		public Vector2 Internal_clipOffset
		{
			get
			{
				Vector2 vector;
				this.get_Internal_clipOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_Internal_clipOffset_Injected(ref value);
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00003A17 File Offset: 0x00001C17
		public static IntPtr Internal_Copy(GUIStyle self, GUIStyle other)
		{
			return GUIStyle.Internal_CopyDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self), IL2CPP.Il2CppObjectBaseToPtr(other));
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00003A2F File Offset: 0x00001C2F
		public void AssignRectOffset(int idx, IntPtr srcRectOffset)
		{
			GUIStyle.AssignRectOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), idx, srcRectOffset);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00003A43 File Offset: 0x00001C43
		public static float Internal_GetLineHeight(IntPtr target)
		{
			return GUIStyle.Internal_GetLineHeightDelegateField(target);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00003A50 File Offset: 0x00001C50
		public void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor)
		{
			this.Internal_DrawCursor_Injected(ref position, content, pos, ref cursorColor);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000F24C File Offset: 0x0000D44C
		public void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor)
		{
			this.Internal_DrawWithTextSelection_Injected(ref screenRect, content, isHover, isActive, on, hasKeyboardFocus, drawSelectionAsComposition, cursorFirst, cursorLast, ref cursorColor, ref selectionColor);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000F274 File Offset: 0x0000D474
		public Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex)
		{
			Vector2 vector;
			this.Internal_GetCursorPixelPosition_Injected(ref position, content, cursorStringIndex, out vector);
			return vector;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00003A5E File Offset: 0x00001C5E
		public int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition)
		{
			return this.Internal_GetCursorStringIndex_Injected(ref position, content, ref cursorPixelPosition);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00003A6B File Offset: 0x00001C6B
		public string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex)
		{
			return this.Internal_GetSelectedRenderedText_Injected(ref localPosition, mContent, selectIndex, cursorIndex);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00003A79 File Offset: 0x00001C79
		public Il2CppStructArray<Rect> Internal_GetHyperlinksRect(Rect localPosition, GUIContent mContent)
		{
			return this.Internal_GetHyperlinksRect_Injected(ref localPosition, mContent);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00003A84 File Offset: 0x00001C84
		public int Internal_GetNumCharactersThatFitWithinWidth(string text, float width)
		{
			return GUIStyle.Internal_GetNumCharactersThatFitWithinWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(text), width);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000F290 File Offset: 0x0000D490
		public Vector2 Internal_CalcSize(GUIContent content)
		{
			Vector2 vector;
			this.Internal_CalcSize_Injected(content, out vector);
			return vector;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000F2A8 File Offset: 0x0000D4A8
		public Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize)
		{
			Vector2 vector;
			this.Internal_CalcSizeWithConstraints_Injected(content, ref maxSize, out vector);
			return vector;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00003A9D File Offset: 0x00001C9D
		public float Internal_CalcHeight(GUIContent content, float width)
		{
			return GUIStyle.Internal_CalcHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(content), width);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000F2C4 File Offset: 0x0000D4C4
		public Vector2 Internal_CalcMinMaxWidth(GUIContent content)
		{
			Vector2 vector;
			this.Internal_CalcMinMaxWidth_Injected(content, out vector);
			return vector;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00003AB6 File Offset: 0x00001CB6
		public static float Internal_GetCursorFlashOffset()
		{
			return GUIStyle.Internal_GetCursorFlashOffsetDelegateField();
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00003AC2 File Offset: 0x00001CC2
		public static void CleanupRoots()
		{
			GUIStyle.s_None = null;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000F2DC File Offset: 0x0000D4DC
		public void InternalOnAfterDeserialize()
		{
			this.m_Normal = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(0));
			this.m_Hover = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(1));
			this.m_Active = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(2));
			this.m_Focused = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(3));
			this.m_OnNormal = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(4));
			this.m_OnHover = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(5));
			this.m_OnActive = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(6));
			this.m_OnFocused = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(7));
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060003DE RID: 990 RVA: 0x0000F384 File Offset: 0x0000D584
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00003ACB File Offset: 0x00001CCB
		public GUIStyleState hover
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_Hover) == null)
				{
					guistyleState = (this.m_Hover = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(1)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(1, value.m_Ptr);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0000F3B8 File Offset: 0x0000D5B8
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x00003ADC File Offset: 0x00001CDC
		public GUIStyleState active
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_Active) == null)
				{
					guistyleState = (this.m_Active = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(2)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(2, value.m_Ptr);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0000F3EC File Offset: 0x0000D5EC
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x00003AED File Offset: 0x00001CED
		public GUIStyleState onNormal
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_OnNormal) == null)
				{
					guistyleState = (this.m_OnNormal = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(4)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(4, value.m_Ptr);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0000F420 File Offset: 0x0000D620
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x00003AFE File Offset: 0x00001CFE
		public GUIStyleState onHover
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_OnHover) == null)
				{
					guistyleState = (this.m_OnHover = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(5)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(5, value.m_Ptr);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0000F454 File Offset: 0x0000D654
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00003B0F File Offset: 0x00001D0F
		public GUIStyleState onActive
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_OnActive) == null)
				{
					guistyleState = (this.m_OnActive = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(6)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(6, value.m_Ptr);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0000F488 File Offset: 0x0000D688
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00003B20 File Offset: 0x00001D20
		public GUIStyleState focused
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_Focused) == null)
				{
					guistyleState = (this.m_Focused = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(3)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(3, value.m_Ptr);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0000F4BC File Offset: 0x0000D6BC
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00003B31 File Offset: 0x00001D31
		public GUIStyleState onFocused
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_OnFocused) == null)
				{
					guistyleState = (this.m_OnFocused = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(7)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(7, value.m_Ptr);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x0000F4F0 File Offset: 0x0000D6F0
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x00003B42 File Offset: 0x00001D42
		public RectOffset border
		{
			get
			{
				RectOffset rectOffset;
				if ((rectOffset = this.m_Border) == null)
				{
					rectOffset = (this.m_Border = new RectOffset(this, this.GetRectOffsetPtr(0)));
				}
				return rectOffset;
			}
			set
			{
				this.AssignRectOffset(0, value.m_Ptr);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0000F524 File Offset: 0x0000D724
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00003B75 File Offset: 0x00001D75
		public RectOffset overflow
		{
			get
			{
				RectOffset rectOffset;
				if ((rectOffset = this.m_Overflow) == null)
				{
					rectOffset = (this.m_Overflow = new RectOffset(this, this.GetRectOffsetPtr(3)));
				}
				return rectOffset;
			}
			set
			{
				this.AssignRectOffset(3, value.m_Ptr);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00003B86 File Offset: 0x00001D86
		public float lineHeight
		{
			get
			{
				return Mathf.Round(GUIStyle.Internal_GetLineHeight(this.m_Ptr));
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00003B98 File Offset: 0x00001D98
		public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			this.Draw(position, GUIContent.none, -1, isHover, isActive, on, hasKeyboardFocus);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00003BAF File Offset: 0x00001DAF
		public void Draw(Rect position, string text, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			this.Draw(position, GUIContent.Temp(text), -1, isHover, isActive, on, hasKeyboardFocus);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00003BC8 File Offset: 0x00001DC8
		public void Draw(Rect position, Texture image, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			this.Draw(position, GUIContent.Temp(image), -1, isHover, isActive, on, hasKeyboardFocus);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00003BE1 File Offset: 0x00001DE1
		public void Draw(Rect position, GUIContent content, int controlID)
		{
			this.Draw(position, content, controlID, false, false, false, false);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00003BF2 File Offset: 0x00001DF2
		public void Draw(Rect position, GUIContent content, int controlID, bool on)
		{
			this.Draw(position, content, controlID, false, false, on, false);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000F558 File Offset: 0x0000D758
		public void DrawCursor(Rect position, GUIContent content, int controlID, int character)
		{
			Event current = Event.current;
			bool flag = current.type == EventType.Repaint;
			if (flag)
			{
				Color cursorColor = new Color(0f, 0f, 0f, 0f);
				float cursorFlashSpeed = GUI.skin.settings.cursorFlashSpeed;
				float num = (Time.realtimeSinceStartup - GUIStyle.Internal_GetCursorFlashOffset()) % cursorFlashSpeed / cursorFlashSpeed;
				bool flag2 = cursorFlashSpeed == 0f || num < 0.5f;
				if (flag2)
				{
					cursorColor = GUI.skin.settings.cursorColor;
				}
				this.Internal_DrawCursor(position, content, character, cursorColor);
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000F5F0 File Offset: 0x0000D7F0
		public void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor)
		{
			Color cursorColor = new Color(0f, 0f, 0f, 0f);
			float cursorFlashSpeed = GUI.skin.settings.cursorFlashSpeed;
			float num = (Time.realtimeSinceStartup - GUIStyle.Internal_GetCursorFlashOffset()) % cursorFlashSpeed / cursorFlashSpeed;
			bool flag = cursorFlashSpeed == 0f || num < 0.5f;
			if (flag)
			{
				cursorColor = GUI.skin.settings.cursorColor;
			}
			bool flag2 = position.Contains(Event.current.mousePosition);
			this.Internal_DrawWithTextSelection(position, content, flag2, isActive, false, hasKeyboardFocus, drawSelectionAsComposition, firstSelectedCharacter, lastSelectedCharacter, cursorColor, selectionColor);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000F690 File Offset: 0x0000D890
		public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition)
		{
			this.DrawWithTextSelection(position, content, controlID == GUIUtility.hotControl, controlID == GUIUtility.keyboardControl && GUIStyle.showKeyboardFocus, firstSelectedCharacter, lastSelectedCharacter, drawSelectionAsComposition, GUI.skin.settings.selectionColor);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00003C04 File Offset: 0x00001E04
		public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter)
		{
			this.DrawWithTextSelection(position, content, controlID, firstSelectedCharacter, lastSelectedCharacter, false);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000F6D4 File Offset: 0x0000D8D4
		public new static implicit operator GUIStyle(string str)
		{
			bool flag = GUISkin.current == null;
			GUIStyle guistyle;
			if (flag)
			{
				Debug.LogError("Unable to use a named GUIStyle without a current skin. Most likely you need to move your GUIStyle initialization code to OnGUI");
				guistyle = GUISkin.error;
			}
			else
			{
				guistyle = GUISkin.current.GetStyle(str);
			}
			return guistyle;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000F714 File Offset: 0x0000D914
		public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex)
		{
			return this.Internal_GetCursorPixelPosition(position, content, cursorStringIndex);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000F730 File Offset: 0x0000D930
		public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition)
		{
			return this.Internal_GetCursorStringIndex(position, content, cursorPixelPosition);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000F74C File Offset: 0x0000D94C
		public int GetNumCharactersThatFitWithinWidth(string text, float width)
		{
			return this.Internal_GetNumCharactersThatFitWithinWidth(text, width);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000F768 File Offset: 0x0000D968
		public Vector2 CalcSize(GUIContent content)
		{
			return this.Internal_CalcSize(content);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000F784 File Offset: 0x0000D984
		public Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints)
		{
			return this.Internal_CalcSizeWithConstraints(content, constraints);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000F7A0 File Offset: 0x0000D9A0
		public Vector2 CalcScreenSize(Vector2 contentSize)
		{
			return new Vector2((this.fixedWidth != 0f) ? this.fixedWidth : Mathf.Ceil(contentSize.x + (float)this.padding.left + (float)this.padding.right), (this.fixedHeight != 0f) ? this.fixedHeight : Mathf.Ceil(contentSize.y + (float)this.padding.top + (float)this.padding.bottom));
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000F82C File Offset: 0x0000DA2C
		public float CalcHeight(GUIContent content, float width)
		{
			return this.Internal_CalcHeight(content, width);
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00003C16 File Offset: 0x00001E16
		public bool isHeightDependantOnWidth
		{
			get
			{
				return this.fixedHeight == 0f && this.wordWrap && this.imagePosition != ImagePosition.ImageOnly;
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000F848 File Offset: 0x0000DA48
		public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth)
		{
			Vector2 vector = this.Internal_CalcMinMaxWidth(content);
			minWidth = vector.x;
			maxWidth = vector.y;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00003C3F File Offset: 0x00001E3F
		public void get_contentOffset_Injected(out Vector2 ret)
		{
			GUIStyle.get_contentOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00003C52 File Offset: 0x00001E52
		public void set_contentOffset_Injected(ref Vector2 value)
		{
			GUIStyle.set_contentOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00003C65 File Offset: 0x00001E65
		public void get_clipOffset_Injected(out Vector2 ret)
		{
			GUIStyle.get_clipOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00003C78 File Offset: 0x00001E78
		public void set_clipOffset_Injected(ref Vector2 value)
		{
			GUIStyle.set_clipOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00003C8B File Offset: 0x00001E8B
		public void get_Internal_clipOffset_Injected(out Vector2 ret)
		{
			GUIStyle.get_Internal_clipOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00003C9E File Offset: 0x00001E9E
		public void set_Internal_clipOffset_Injected(ref Vector2 value)
		{
			GUIStyle.set_Internal_clipOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00003CB1 File Offset: 0x00001EB1
		public void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor)
		{
			GUIStyle.Internal_DrawCursor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, IL2CPP.Il2CppObjectBaseToPtr(content), pos, ref cursorColor);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000F870 File Offset: 0x0000DA70
		public void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor)
		{
			GUIStyle.Internal_DrawWithTextSelection_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref screenRect, IL2CPP.Il2CppObjectBaseToPtr(content), isHover, isActive, on, hasKeyboardFocus, drawSelectionAsComposition, cursorFirst, cursorLast, ref cursorColor, ref selectionColor);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00003CCD File Offset: 0x00001ECD
		public void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret)
		{
			GUIStyle.Internal_GetCursorPixelPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, IL2CPP.Il2CppObjectBaseToPtr(content), cursorStringIndex, out ret);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00003CE9 File Offset: 0x00001EE9
		public int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition)
		{
			return GUIStyle.Internal_GetCursorStringIndex_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, IL2CPP.Il2CppObjectBaseToPtr(content), ref cursorPixelPosition);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000F8A8 File Offset: 0x0000DAA8
		public string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex)
		{
			IntPtr intPtr = GUIStyle.Internal_GetSelectedRenderedText_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref localPosition, IL2CPP.Il2CppObjectBaseToPtr(mContent), selectIndex, cursorIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000F8D8 File Offset: 0x0000DAD8
		public Il2CppStructArray<Rect> Internal_GetHyperlinksRect_Injected(ref Rect localPosition, GUIContent mContent)
		{
			IntPtr intPtr = GUIStyle.Internal_GetHyperlinksRect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref localPosition, IL2CPP.Il2CppObjectBaseToPtr(mContent));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Rect>>(intPtr2) : null;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00003D03 File Offset: 0x00001F03
		public void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret)
		{
			GUIStyle.Internal_CalcSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(content), out ret);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00003D1C File Offset: 0x00001F1C
		public void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret)
		{
			GUIStyle.Internal_CalcSizeWithConstraints_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(content), ref maxSize, out ret);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00003D36 File Offset: 0x00001F36
		public void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret)
		{
			GUIStyle.Internal_CalcMinMaxWidth_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(content), out ret);
		}

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeFieldInfoPtr_m_Hover;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeFieldInfoPtr_m_Active;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeFieldInfoPtr_m_Focused;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeFieldInfoPtr_m_OnNormal;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeFieldInfoPtr_m_OnHover;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeFieldInfoPtr_m_OnActive;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeFieldInfoPtr_m_OnFocused;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeFieldInfoPtr_m_Border;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeFieldInfoPtr_m_Margin;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeFieldInfoPtr_m_Overflow;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeFieldInfoPtr_showKeyboardFocus;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeFieldInfoPtr_s_None;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_get_rawName_Internal_get_String_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_set_rawName_Internal_set_Void_String_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedWidth_Public_get_Single_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedHeight_Public_get_Single_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_get_stretchWidth_Public_get_Boolean_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_get_stretchHeight_Public_get_Boolean_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_set_stretchHeight_Public_set_Void_Boolean_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_GUIStyle_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_GetStyleStatePtr_Private_IntPtr_Int32_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_AssignStyleState_Private_Void_Int32_IntPtr_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_GetRectOffsetPtr_Private_IntPtr_Int32_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Draw_Private_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Draw2_Private_Void_Rect_GUIContent_Int32_Boolean_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_SetMouseTooltip_Internal_Static_Void_String_Rect_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_IsTooltipActive_Internal_Static_Boolean_String_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultFont_Internal_Static_Void_Font_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_get_normal_Public_get_GUIStyleState_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_set_normal_Public_set_Void_GUIStyleState_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_get_margin_Public_get_RectOffset_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_get_padding_Public_get_RectOffset_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_Boolean_Boolean_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Private_Void_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_get_none_Public_Static_get_GUIStyle_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Draw_Injected_Private_Void_byref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Draw2_Injected_Private_Void_byref_Rect_GUIContent_Int32_Boolean_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_SetMouseTooltip_Injected_Private_Static_Void_String_byref_Rect_0;

		// Token: 0x040001C6 RID: 454
		private static readonly GUIStyle.get_fontDelegate get_fontDelegateField;

		// Token: 0x040001C7 RID: 455
		private static readonly GUIStyle.set_fontDelegate set_fontDelegateField;

		// Token: 0x040001C8 RID: 456
		private static readonly GUIStyle.get_imagePositionDelegate get_imagePositionDelegateField;

		// Token: 0x040001C9 RID: 457
		private static readonly GUIStyle.set_imagePositionDelegate set_imagePositionDelegateField;

		// Token: 0x040001CA RID: 458
		private static readonly GUIStyle.get_alignmentDelegate get_alignmentDelegateField;

		// Token: 0x040001CB RID: 459
		private static readonly GUIStyle.set_alignmentDelegate set_alignmentDelegateField;

		// Token: 0x040001CC RID: 460
		private static readonly GUIStyle.get_wordWrapDelegate get_wordWrapDelegateField;

		// Token: 0x040001CD RID: 461
		private static readonly GUIStyle.set_wordWrapDelegate set_wordWrapDelegateField;

		// Token: 0x040001CE RID: 462
		private static readonly GUIStyle.get_clippingDelegate get_clippingDelegateField;

		// Token: 0x040001CF RID: 463
		private static readonly GUIStyle.set_clippingDelegate set_clippingDelegateField;

		// Token: 0x040001D0 RID: 464
		private static readonly GUIStyle.set_fixedWidthDelegate set_fixedWidthDelegateField;

		// Token: 0x040001D1 RID: 465
		private static readonly GUIStyle.set_fixedHeightDelegate set_fixedHeightDelegateField;

		// Token: 0x040001D2 RID: 466
		private static readonly GUIStyle.set_stretchWidthDelegate set_stretchWidthDelegateField;

		// Token: 0x040001D3 RID: 467
		private static readonly GUIStyle.get_fontSizeDelegate get_fontSizeDelegateField;

		// Token: 0x040001D4 RID: 468
		private static readonly GUIStyle.get_fontStyleDelegate get_fontStyleDelegateField;

		// Token: 0x040001D5 RID: 469
		private static readonly GUIStyle.set_fontStyleDelegate set_fontStyleDelegateField;

		// Token: 0x040001D6 RID: 470
		private static readonly GUIStyle.get_richTextDelegate get_richTextDelegateField;

		// Token: 0x040001D7 RID: 471
		private static readonly GUIStyle.set_richTextDelegate set_richTextDelegateField;

		// Token: 0x040001D8 RID: 472
		private static readonly GUIStyle.Internal_CopyDelegate Internal_CopyDelegateField;

		// Token: 0x040001D9 RID: 473
		private static readonly GUIStyle.AssignRectOffsetDelegate AssignRectOffsetDelegateField;

		// Token: 0x040001DA RID: 474
		private static readonly GUIStyle.Internal_GetLineHeightDelegate Internal_GetLineHeightDelegateField;

		// Token: 0x040001DB RID: 475
		private static readonly GUIStyle.Internal_GetNumCharactersThatFitWithinWidthDelegate Internal_GetNumCharactersThatFitWithinWidthDelegateField;

		// Token: 0x040001DC RID: 476
		private static readonly GUIStyle.Internal_CalcHeightDelegate Internal_CalcHeightDelegateField;

		// Token: 0x040001DD RID: 477
		private static readonly GUIStyle.Internal_GetCursorFlashOffsetDelegate Internal_GetCursorFlashOffsetDelegateField;

		// Token: 0x040001DE RID: 478
		private static readonly GUIStyle.get_contentOffset_InjectedDelegate get_contentOffset_InjectedDelegateField;

		// Token: 0x040001DF RID: 479
		private static readonly GUIStyle.set_contentOffset_InjectedDelegate set_contentOffset_InjectedDelegateField;

		// Token: 0x040001E0 RID: 480
		private static readonly GUIStyle.get_clipOffset_InjectedDelegate get_clipOffset_InjectedDelegateField;

		// Token: 0x040001E1 RID: 481
		private static readonly GUIStyle.set_clipOffset_InjectedDelegate set_clipOffset_InjectedDelegateField;

		// Token: 0x040001E2 RID: 482
		private static readonly GUIStyle.get_Internal_clipOffset_InjectedDelegate get_Internal_clipOffset_InjectedDelegateField;

		// Token: 0x040001E3 RID: 483
		private static readonly GUIStyle.set_Internal_clipOffset_InjectedDelegate set_Internal_clipOffset_InjectedDelegateField;

		// Token: 0x040001E4 RID: 484
		private static readonly GUIStyle.Internal_DrawCursor_InjectedDelegate Internal_DrawCursor_InjectedDelegateField;

		// Token: 0x040001E5 RID: 485
		private static readonly GUIStyle.Internal_DrawWithTextSelection_InjectedDelegate Internal_DrawWithTextSelection_InjectedDelegateField;

		// Token: 0x040001E6 RID: 486
		private static readonly GUIStyle.Internal_GetCursorPixelPosition_InjectedDelegate Internal_GetCursorPixelPosition_InjectedDelegateField;

		// Token: 0x040001E7 RID: 487
		private static readonly GUIStyle.Internal_GetCursorStringIndex_InjectedDelegate Internal_GetCursorStringIndex_InjectedDelegateField;

		// Token: 0x040001E8 RID: 488
		private static readonly GUIStyle.Internal_GetSelectedRenderedText_InjectedDelegate Internal_GetSelectedRenderedText_InjectedDelegateField;

		// Token: 0x040001E9 RID: 489
		private static readonly GUIStyle.Internal_GetHyperlinksRect_InjectedDelegate Internal_GetHyperlinksRect_InjectedDelegateField;

		// Token: 0x040001EA RID: 490
		private static readonly GUIStyle.Internal_CalcSize_InjectedDelegate Internal_CalcSize_InjectedDelegateField;

		// Token: 0x040001EB RID: 491
		private static readonly GUIStyle.Internal_CalcSizeWithConstraints_InjectedDelegate Internal_CalcSizeWithConstraints_InjectedDelegateField;

		// Token: 0x040001EC RID: 492
		private static readonly GUIStyle.Internal_CalcMinMaxWidth_InjectedDelegate Internal_CalcMinMaxWidth_InjectedDelegateField;

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x0600071D RID: 1821
		private delegate IntPtr get_fontDelegate(IntPtr @this);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x0600071F RID: 1823
		private delegate void set_fontDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x06000721 RID: 1825
		private delegate ImagePosition get_imagePositionDelegate(IntPtr @this);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x06000723 RID: 1827
		private delegate void set_imagePositionDelegate(IntPtr @this, ImagePosition value);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x06000725 RID: 1829
		private delegate TextAnchor get_alignmentDelegate(IntPtr @this);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x06000727 RID: 1831
		private delegate void set_alignmentDelegate(IntPtr @this, TextAnchor value);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x06000729 RID: 1833
		private delegate bool get_wordWrapDelegate(IntPtr @this);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x0600072B RID: 1835
		private delegate void set_wordWrapDelegate(IntPtr @this, bool value);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x0600072D RID: 1837
		private delegate TextClipping get_clippingDelegate(IntPtr @this);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x0600072F RID: 1839
		private delegate void set_clippingDelegate(IntPtr @this, TextClipping value);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x06000731 RID: 1841
		private delegate void set_fixedWidthDelegate(IntPtr @this, float value);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x06000733 RID: 1843
		private delegate void set_fixedHeightDelegate(IntPtr @this, float value);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x06000735 RID: 1845
		private delegate void set_stretchWidthDelegate(IntPtr @this, bool value);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x06000737 RID: 1847
		private delegate int get_fontSizeDelegate(IntPtr @this);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x06000739 RID: 1849
		private delegate FontStyle get_fontStyleDelegate(IntPtr @this);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x0600073B RID: 1851
		private delegate void set_fontStyleDelegate(IntPtr @this, FontStyle value);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x0600073D RID: 1853
		private delegate bool get_richTextDelegate(IntPtr @this);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x0600073F RID: 1855
		private delegate void set_richTextDelegate(IntPtr @this, bool value);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x06000741 RID: 1857
		private delegate IntPtr Internal_CopyDelegate(IntPtr self, IntPtr other);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x06000743 RID: 1859
		private delegate void AssignRectOffsetDelegate(IntPtr @this, int idx, IntPtr srcRectOffset);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x06000745 RID: 1861
		private delegate float Internal_GetLineHeightDelegate(IntPtr target);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x06000747 RID: 1863
		private delegate int Internal_GetNumCharactersThatFitWithinWidthDelegate(IntPtr @this, IntPtr text, float width);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x06000749 RID: 1865
		private delegate float Internal_CalcHeightDelegate(IntPtr @this, IntPtr content, float width);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x0600074B RID: 1867
		private delegate float Internal_GetCursorFlashOffsetDelegate();

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x0600074D RID: 1869
		private delegate void get_contentOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x0600074F RID: 1871
		private delegate void set_contentOffset_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x06000751 RID: 1873
		private delegate void get_clipOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x06000753 RID: 1875
		private delegate void set_clipOffset_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x06000755 RID: 1877
		private delegate void get_Internal_clipOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x06000757 RID: 1879
		private delegate void set_Internal_clipOffset_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x06000759 RID: 1881
		private delegate void Internal_DrawCursor_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr content, int pos, IntPtr cursorColor);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x0600075B RID: 1883
		private delegate void Internal_DrawWithTextSelection_InjectedDelegate(IntPtr @this, IntPtr screenRect, IntPtr content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, IntPtr cursorColor, IntPtr selectionColor);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x0600075D RID: 1885
		private delegate void Internal_GetCursorPixelPosition_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr content, int cursorStringIndex, [Out] IntPtr ret);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x0600075F RID: 1887
		private delegate int Internal_GetCursorStringIndex_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr content, IntPtr cursorPixelPosition);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x06000761 RID: 1889
		private delegate IntPtr Internal_GetSelectedRenderedText_InjectedDelegate(IntPtr @this, IntPtr localPosition, IntPtr mContent, int selectIndex, int cursorIndex);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x06000763 RID: 1891
		private delegate IntPtr Internal_GetHyperlinksRect_InjectedDelegate(IntPtr @this, IntPtr localPosition, IntPtr mContent);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x06000765 RID: 1893
		private delegate void Internal_CalcSize_InjectedDelegate(IntPtr @this, IntPtr content, [Out] IntPtr ret);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x06000767 RID: 1895
		private delegate void Internal_CalcSizeWithConstraints_InjectedDelegate(IntPtr @this, IntPtr content, IntPtr maxSize, [Out] IntPtr ret);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x06000769 RID: 1897
		private delegate void Internal_CalcMinMaxWidth_InjectedDelegate(IntPtr @this, IntPtr content, [Out] IntPtr ret);
	}
}
