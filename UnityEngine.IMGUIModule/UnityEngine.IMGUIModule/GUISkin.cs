using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000010 RID: 16
	[Serializable]
	public sealed class GUISkin : ScriptableObject
	{
		// Token: 0x060002E3 RID: 739 RVA: 0x0000BE50 File Offset: 0x0000A050
		// Note: this type is marked as 'beforefieldinit'.
		static GUISkin()
		{
			Il2CppClassPointerStore<GUISkin>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUISkin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUISkin>.NativeClassPtr);
			GUISkin.NativeFieldInfoPtr_m_Font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_Font");
			GUISkin.NativeFieldInfoPtr_m_box = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_box");
			GUISkin.NativeFieldInfoPtr_m_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_button");
			GUISkin.NativeFieldInfoPtr_m_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_toggle");
			GUISkin.NativeFieldInfoPtr_m_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_label");
			GUISkin.NativeFieldInfoPtr_m_textField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_textField");
			GUISkin.NativeFieldInfoPtr_m_textArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_textArea");
			GUISkin.NativeFieldInfoPtr_m_window = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_window");
			GUISkin.NativeFieldInfoPtr_m_horizontalSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalSlider");
			GUISkin.NativeFieldInfoPtr_m_horizontalSliderThumb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalSliderThumb");
			GUISkin.NativeFieldInfoPtr_m_horizontalSliderThumbExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalSliderThumbExtent");
			GUISkin.NativeFieldInfoPtr_m_verticalSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalSlider");
			GUISkin.NativeFieldInfoPtr_m_verticalSliderThumb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalSliderThumb");
			GUISkin.NativeFieldInfoPtr_m_verticalSliderThumbExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalSliderThumbExtent");
			GUISkin.NativeFieldInfoPtr_m_SliderMixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_SliderMixed");
			GUISkin.NativeFieldInfoPtr_m_horizontalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalScrollbar");
			GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarThumb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalScrollbarThumb");
			GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarLeftButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalScrollbarLeftButton");
			GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarRightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalScrollbarRightButton");
			GUISkin.NativeFieldInfoPtr_m_verticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalScrollbar");
			GUISkin.NativeFieldInfoPtr_m_verticalScrollbarThumb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalScrollbarThumb");
			GUISkin.NativeFieldInfoPtr_m_verticalScrollbarUpButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalScrollbarUpButton");
			GUISkin.NativeFieldInfoPtr_m_verticalScrollbarDownButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalScrollbarDownButton");
			GUISkin.NativeFieldInfoPtr_m_ScrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_ScrollView");
			GUISkin.NativeFieldInfoPtr_m_CustomStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_CustomStyles");
			GUISkin.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_Settings");
			GUISkin.NativeFieldInfoPtr_ms_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "ms_Error");
			GUISkin.NativeFieldInfoPtr_m_Styles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_Styles");
			GUISkin.NativeFieldInfoPtr_m_SkinChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_SkinChanged");
			GUISkin.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "current");
			GUISkin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663449);
			GUISkin.NativeMethodInfoPtr_OnEnable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663450);
			GUISkin.NativeMethodInfoPtr_CleanupRoots_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663451);
			GUISkin.NativeMethodInfoPtr_get_font_Public_get_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663452);
			GUISkin.NativeMethodInfoPtr_set_font_Public_set_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663453);
			GUISkin.NativeMethodInfoPtr_get_box_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663454);
			GUISkin.NativeMethodInfoPtr_set_box_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663455);
			GUISkin.NativeMethodInfoPtr_get_label_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663456);
			GUISkin.NativeMethodInfoPtr_set_label_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663457);
			GUISkin.NativeMethodInfoPtr_get_textField_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663458);
			GUISkin.NativeMethodInfoPtr_set_textField_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663459);
			GUISkin.NativeMethodInfoPtr_get_textArea_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663460);
			GUISkin.NativeMethodInfoPtr_set_textArea_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663461);
			GUISkin.NativeMethodInfoPtr_get_button_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663462);
			GUISkin.NativeMethodInfoPtr_set_button_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663463);
			GUISkin.NativeMethodInfoPtr_get_toggle_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663464);
			GUISkin.NativeMethodInfoPtr_set_toggle_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663465);
			GUISkin.NativeMethodInfoPtr_get_window_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663466);
			GUISkin.NativeMethodInfoPtr_set_window_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663467);
			GUISkin.NativeMethodInfoPtr_get_horizontalSlider_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663468);
			GUISkin.NativeMethodInfoPtr_set_horizontalSlider_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663469);
			GUISkin.NativeMethodInfoPtr_get_horizontalSliderThumb_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663470);
			GUISkin.NativeMethodInfoPtr_set_horizontalSliderThumb_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663471);
			GUISkin.NativeMethodInfoPtr_get_horizontalSliderThumbExtent_Internal_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663472);
			GUISkin.NativeMethodInfoPtr_set_horizontalSliderThumbExtent_Internal_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663473);
			GUISkin.NativeMethodInfoPtr_get_sliderMixed_Internal_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663474);
			GUISkin.NativeMethodInfoPtr_set_sliderMixed_Internal_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663475);
			GUISkin.NativeMethodInfoPtr_get_verticalSlider_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663476);
			GUISkin.NativeMethodInfoPtr_set_verticalSlider_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663477);
			GUISkin.NativeMethodInfoPtr_get_verticalSliderThumb_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663478);
			GUISkin.NativeMethodInfoPtr_set_verticalSliderThumb_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663479);
			GUISkin.NativeMethodInfoPtr_get_verticalSliderThumbExtent_Internal_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663480);
			GUISkin.NativeMethodInfoPtr_set_verticalSliderThumbExtent_Internal_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663481);
			GUISkin.NativeMethodInfoPtr_get_horizontalScrollbar_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663482);
			GUISkin.NativeMethodInfoPtr_set_horizontalScrollbar_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663483);
			GUISkin.NativeMethodInfoPtr_get_horizontalScrollbarThumb_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663484);
			GUISkin.NativeMethodInfoPtr_set_horizontalScrollbarThumb_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663485);
			GUISkin.NativeMethodInfoPtr_get_horizontalScrollbarLeftButton_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663486);
			GUISkin.NativeMethodInfoPtr_set_horizontalScrollbarLeftButton_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663487);
			GUISkin.NativeMethodInfoPtr_get_horizontalScrollbarRightButton_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663488);
			GUISkin.NativeMethodInfoPtr_set_horizontalScrollbarRightButton_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663489);
			GUISkin.NativeMethodInfoPtr_get_verticalScrollbar_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663490);
			GUISkin.NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663491);
			GUISkin.NativeMethodInfoPtr_get_verticalScrollbarThumb_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663492);
			GUISkin.NativeMethodInfoPtr_set_verticalScrollbarThumb_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663493);
			GUISkin.NativeMethodInfoPtr_get_verticalScrollbarUpButton_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663494);
			GUISkin.NativeMethodInfoPtr_set_verticalScrollbarUpButton_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663495);
			GUISkin.NativeMethodInfoPtr_get_verticalScrollbarDownButton_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663496);
			GUISkin.NativeMethodInfoPtr_set_verticalScrollbarDownButton_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663497);
			GUISkin.NativeMethodInfoPtr_get_scrollView_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663498);
			GUISkin.NativeMethodInfoPtr_set_scrollView_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663499);
			GUISkin.NativeMethodInfoPtr_get_customStyles_Public_get_Il2CppReferenceArray_1_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663500);
			GUISkin.NativeMethodInfoPtr_set_customStyles_Public_set_Void_Il2CppReferenceArray_1_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663501);
			GUISkin.NativeMethodInfoPtr_get_settings_Public_get_GUISettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663502);
			GUISkin.NativeMethodInfoPtr_get_error_Internal_Static_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663503);
			GUISkin.NativeMethodInfoPtr_Apply_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663504);
			GUISkin.NativeMethodInfoPtr_BuildStyleCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663505);
			GUISkin.NativeMethodInfoPtr_GetStyle_Public_GUIStyle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663506);
			GUISkin.NativeMethodInfoPtr_FindStyle_Public_GUIStyle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663507);
			GUISkin.NativeMethodInfoPtr_MakeCurrent_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663508);
			GUISkin.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663509);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000C59C File Offset: 0x0000A79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186328, XrefRangeEnd = 1186339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUISkin()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUISkin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000C5D8 File Offset: 0x0000A7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186339, XrefRangeEnd = 1186346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_OnEnable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000C60C File Offset: 0x0000A80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186346, XrefRangeEnd = 1186353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupRoots()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_CleanupRoots_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0000C634 File Offset: 0x0000A834
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x0000C674 File Offset: 0x0000A874
		public unsafe Font font
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 318167, RefRangeEnd = 318212, XrefRangeStart = 318167, XrefRangeEnd = 318212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_font_Public_get_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1186372, RefRangeEnd = 1186373, XrefRangeStart = 1186353, XrefRangeEnd = 1186372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_font_Public_set_Void_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x0000C6B8 File Offset: 0x0000A8B8
		// (set) Token: 0x060002EA RID: 746 RVA: 0x0000C6F8 File Offset: 0x0000A8F8
		public unsafe GUIStyle box
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 337628, RefRangeEnd = 337663, XrefRangeStart = 337628, XrefRangeEnd = 337663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_box_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186373, XrefRangeEnd = 1186381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_box_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0000C73C File Offset: 0x0000A93C
		// (set) Token: 0x060002EC RID: 748 RVA: 0x0000C77C File Offset: 0x0000A97C
		public unsafe GUIStyle label
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 285338, RefRangeEnd = 285365, XrefRangeStart = 285338, XrefRangeEnd = 285365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_label_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186381, XrefRangeEnd = 1186389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_label_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000C7C0 File Offset: 0x0000A9C0
		// (set) Token: 0x060002EE RID: 750 RVA: 0x0000C800 File Offset: 0x0000AA00
		public unsafe GUIStyle textField
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 331976, RefRangeEnd = 331977, XrefRangeStart = 331976, XrefRangeEnd = 331977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_textField_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186389, XrefRangeEnd = 1186397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_textField_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002EF RID: 751 RVA: 0x0000C844 File Offset: 0x0000AA44
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x0000C884 File Offset: 0x0000AA84
		public unsafe GUIStyle textArea
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_textArea_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186397, XrefRangeEnd = 1186405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_textArea_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000C8C8 File Offset: 0x0000AAC8
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x0000C908 File Offset: 0x0000AB08
		public unsafe GUIStyle button
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 318860, RefRangeEnd = 318862, XrefRangeStart = 318860, XrefRangeEnd = 318862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_button_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186405, XrefRangeEnd = 1186413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_button_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0000C94C File Offset: 0x0000AB4C
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x0000C98C File Offset: 0x0000AB8C
		public unsafe GUIStyle toggle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_toggle_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186413, XrefRangeEnd = 1186421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_toggle_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000C9D0 File Offset: 0x0000ABD0
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x0000CA10 File Offset: 0x0000AC10
		public unsafe GUIStyle window
		{
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 312325, RefRangeEnd = 312368, XrefRangeStart = 312325, XrefRangeEnd = 312368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_window_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186421, XrefRangeEnd = 1186429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_window_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x0000CA54 File Offset: 0x0000AC54
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x0000CA94 File Offset: 0x0000AC94
		public unsafe GUIStyle horizontalSlider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalSlider_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186429, XrefRangeEnd = 1186437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalSlider_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x0000CAD8 File Offset: 0x0000ACD8
		// (set) Token: 0x060002FA RID: 762 RVA: 0x0000CB18 File Offset: 0x0000AD18
		public unsafe GUIStyle horizontalSliderThumb
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 337728, RefRangeEnd = 337731, XrefRangeStart = 337728, XrefRangeEnd = 337731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalSliderThumb_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186437, XrefRangeEnd = 1186445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalSliderThumb_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002FB RID: 763 RVA: 0x0000CB5C File Offset: 0x0000AD5C
		// (set) Token: 0x060002FC RID: 764 RVA: 0x0000CB9C File Offset: 0x0000AD9C
		public unsafe GUIStyle horizontalSliderThumbExtent
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 312534, RefRangeEnd = 312536, XrefRangeStart = 312534, XrefRangeEnd = 312536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalSliderThumbExtent_Internal_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186445, XrefRangeEnd = 1186453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalSliderThumbExtent_Internal_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002FD RID: 765 RVA: 0x0000CBE0 File Offset: 0x0000ADE0
		// (set) Token: 0x060002FE RID: 766 RVA: 0x0000CC20 File Offset: 0x0000AE20
		public unsafe GUIStyle sliderMixed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_sliderMixed_Internal_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186453, XrefRangeEnd = 1186461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_sliderMixed_Internal_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002FF RID: 767 RVA: 0x0000CC64 File Offset: 0x0000AE64
		// (set) Token: 0x06000300 RID: 768 RVA: 0x0000CCA4 File Offset: 0x0000AEA4
		public unsafe GUIStyle verticalSlider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalSlider_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186461, XrefRangeEnd = 1186469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalSlider_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000301 RID: 769 RVA: 0x0000CCE8 File Offset: 0x0000AEE8
		// (set) Token: 0x06000302 RID: 770 RVA: 0x0000CD28 File Offset: 0x0000AF28
		public unsafe GUIStyle verticalSliderThumb
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalSliderThumb_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186469, XrefRangeEnd = 1186477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalSliderThumb_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0000CD6C File Offset: 0x0000AF6C
		// (set) Token: 0x06000304 RID: 772 RVA: 0x0000CDAC File Offset: 0x0000AFAC
		public unsafe GUIStyle verticalSliderThumbExtent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalSliderThumbExtent_Internal_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186477, XrefRangeEnd = 1186485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalSliderThumbExtent_Internal_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0000CDF0 File Offset: 0x0000AFF0
		// (set) Token: 0x06000306 RID: 774 RVA: 0x0000CE30 File Offset: 0x0000B030
		public unsafe GUIStyle horizontalScrollbar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalScrollbar_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186485, XrefRangeEnd = 1186493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalScrollbar_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000307 RID: 775 RVA: 0x0000CE74 File Offset: 0x0000B074
		// (set) Token: 0x06000308 RID: 776 RVA: 0x0000CEB4 File Offset: 0x0000B0B4
		public unsafe GUIStyle horizontalScrollbarThumb
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalScrollbarThumb_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186493, XrefRangeEnd = 1186501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalScrollbarThumb_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0000CEF8 File Offset: 0x0000B0F8
		// (set) Token: 0x0600030A RID: 778 RVA: 0x0000CF38 File Offset: 0x0000B138
		public unsafe GUIStyle horizontalScrollbarLeftButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalScrollbarLeftButton_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186501, XrefRangeEnd = 1186509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalScrollbarLeftButton_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0000CF7C File Offset: 0x0000B17C
		// (set) Token: 0x0600030C RID: 780 RVA: 0x0000CFBC File Offset: 0x0000B1BC
		public unsafe GUIStyle horizontalScrollbarRightButton
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 321260, RefRangeEnd = 321264, XrefRangeStart = 321260, XrefRangeEnd = 321264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalScrollbarRightButton_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186509, XrefRangeEnd = 1186517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalScrollbarRightButton_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0000D000 File Offset: 0x0000B200
		// (set) Token: 0x0600030E RID: 782 RVA: 0x0000D040 File Offset: 0x0000B240
		public unsafe GUIStyle verticalScrollbar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalScrollbar_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186517, XrefRangeEnd = 1186525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600030F RID: 783 RVA: 0x0000D084 File Offset: 0x0000B284
		// (set) Token: 0x06000310 RID: 784 RVA: 0x0000D0C4 File Offset: 0x0000B2C4
		public unsafe GUIStyle verticalScrollbarThumb
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalScrollbarThumb_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186525, XrefRangeEnd = 1186533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalScrollbarThumb_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000311 RID: 785 RVA: 0x0000D108 File Offset: 0x0000B308
		// (set) Token: 0x06000312 RID: 786 RVA: 0x0000D148 File Offset: 0x0000B348
		public unsafe GUIStyle verticalScrollbarUpButton
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 321321, RefRangeEnd = 321322, XrefRangeStart = 321321, XrefRangeEnd = 321322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalScrollbarUpButton_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186533, XrefRangeEnd = 1186541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalScrollbarUpButton_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000313 RID: 787 RVA: 0x0000D18C File Offset: 0x0000B38C
		// (set) Token: 0x06000314 RID: 788 RVA: 0x0000D1CC File Offset: 0x0000B3CC
		public unsafe GUIStyle verticalScrollbarDownButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalScrollbarDownButton_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186541, XrefRangeEnd = 1186549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalScrollbarDownButton_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000315 RID: 789 RVA: 0x0000D210 File Offset: 0x0000B410
		// (set) Token: 0x06000316 RID: 790 RVA: 0x0000D250 File Offset: 0x0000B450
		public unsafe GUIStyle scrollView
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_scrollView_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186549, XrefRangeEnd = 1186557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_scrollView_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000317 RID: 791 RVA: 0x0000D294 File Offset: 0x0000B494
		// (set) Token: 0x06000318 RID: 792 RVA: 0x0000D2D4 File Offset: 0x0000B4D4
		public unsafe Il2CppReferenceArray<GUIStyle> customStyles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_customStyles_Public_get_Il2CppReferenceArray_1_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GUIStyle>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186557, XrefRangeEnd = 1186565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_customStyles_Public_set_Void_Il2CppReferenceArray_1_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0000D318 File Offset: 0x0000B518
		public unsafe GUISettings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_settings_Public_get_GUISettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUISettings>(intPtr3) : null;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0000D358 File Offset: 0x0000B558
		public unsafe static GUIStyle error
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1186581, RefRangeEnd = 1186584, XrefRangeStart = 1186565, XrefRangeEnd = 1186581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_error_Internal_Static_get_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000D38C File Offset: 0x0000B58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_Apply_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000D3C0 File Offset: 0x0000B5C0
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 1186922, RefRangeEnd = 1186952, XrefRangeStart = 1186584, XrefRangeEnd = 1186922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildStyleCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_BuildStyleCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000D3F4 File Offset: 0x0000B5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186952, XrefRangeEnd = 1186990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIStyle GetStyle(string styleName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(styleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_GetStyle_Public_GUIStyle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000D444 File Offset: 0x0000B644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186990, XrefRangeEnd = 1186994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIStyle FindStyle(string styleName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(styleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_FindStyle_Public_GUIStyle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000D494 File Offset: 0x0000B694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186994, XrefRangeEnd = 1187004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeCurrent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_MakeCurrent_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000D4C8 File Offset: 0x0000B6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187004, XrefRangeEnd = 1187014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000032EF File Offset: 0x000014EF
		public GUISkin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0000D508 File Offset: 0x0000B708
		// (set) Token: 0x06000323 RID: 803 RVA: 0x000032F8 File Offset: 0x000014F8
		public unsafe Font m_Font
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_Font);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_Font), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0000D538 File Offset: 0x0000B738
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00003317 File Offset: 0x00001517
		public unsafe GUIStyle m_box
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_box);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_box), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000D568 File Offset: 0x0000B768
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00003336 File Offset: 0x00001536
		public unsafe GUIStyle m_button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0000D598 File Offset: 0x0000B798
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00003355 File Offset: 0x00001555
		public unsafe GUIStyle m_toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0000D5C8 File Offset: 0x0000B7C8
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00003374 File Offset: 0x00001574
		public unsafe GUIStyle m_label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0000D5F8 File Offset: 0x0000B7F8
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00003393 File Offset: 0x00001593
		public unsafe GUIStyle m_textField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_textField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_textField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0000D628 File Offset: 0x0000B828
		// (set) Token: 0x0600032F RID: 815 RVA: 0x000033B2 File Offset: 0x000015B2
		public unsafe GUIStyle m_textArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_textArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_textArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0000D658 File Offset: 0x0000B858
		// (set) Token: 0x06000331 RID: 817 RVA: 0x000033D1 File Offset: 0x000015D1
		public unsafe GUIStyle m_window
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_window);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_window), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000D688 File Offset: 0x0000B888
		// (set) Token: 0x06000333 RID: 819 RVA: 0x000033F0 File Offset: 0x000015F0
		public unsafe GUIStyle m_horizontalSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0000D6B8 File Offset: 0x0000B8B8
		// (set) Token: 0x06000335 RID: 821 RVA: 0x0000340F File Offset: 0x0000160F
		public unsafe GUIStyle m_horizontalSliderThumb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalSliderThumb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalSliderThumb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000D6E8 File Offset: 0x0000B8E8
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0000342E File Offset: 0x0000162E
		public unsafe GUIStyle m_horizontalSliderThumbExtent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalSliderThumbExtent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalSliderThumbExtent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000D718 File Offset: 0x0000B918
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0000344D File Offset: 0x0000164D
		public unsafe GUIStyle m_verticalSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000D748 File Offset: 0x0000B948
		// (set) Token: 0x0600033B RID: 827 RVA: 0x0000346C File Offset: 0x0000166C
		public unsafe GUIStyle m_verticalSliderThumb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalSliderThumb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalSliderThumb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0000D778 File Offset: 0x0000B978
		// (set) Token: 0x0600033D RID: 829 RVA: 0x0000348B File Offset: 0x0000168B
		public unsafe GUIStyle m_verticalSliderThumbExtent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalSliderThumbExtent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalSliderThumbExtent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0000D7A8 File Offset: 0x0000B9A8
		// (set) Token: 0x0600033F RID: 831 RVA: 0x000034AA File Offset: 0x000016AA
		public unsafe GUIStyle m_SliderMixed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_SliderMixed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_SliderMixed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0000D7D8 File Offset: 0x0000B9D8
		// (set) Token: 0x06000341 RID: 833 RVA: 0x000034C9 File Offset: 0x000016C9
		public unsafe GUIStyle m_horizontalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0000D808 File Offset: 0x0000BA08
		// (set) Token: 0x06000343 RID: 835 RVA: 0x000034E8 File Offset: 0x000016E8
		public unsafe GUIStyle m_horizontalScrollbarThumb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarThumb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarThumb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0000D838 File Offset: 0x0000BA38
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00003507 File Offset: 0x00001707
		public unsafe GUIStyle m_horizontalScrollbarLeftButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarLeftButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarLeftButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0000D868 File Offset: 0x0000BA68
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00003526 File Offset: 0x00001726
		public unsafe GUIStyle m_horizontalScrollbarRightButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarRightButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarRightButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000348 RID: 840 RVA: 0x0000D898 File Offset: 0x0000BA98
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00003545 File Offset: 0x00001745
		public unsafe GUIStyle m_verticalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0000D8C8 File Offset: 0x0000BAC8
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00003564 File Offset: 0x00001764
		public unsafe GUIStyle m_verticalScrollbarThumb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbarThumb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbarThumb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0000D8F8 File Offset: 0x0000BAF8
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00003583 File Offset: 0x00001783
		public unsafe GUIStyle m_verticalScrollbarUpButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbarUpButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbarUpButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0000D928 File Offset: 0x0000BB28
		// (set) Token: 0x0600034F RID: 847 RVA: 0x000035A2 File Offset: 0x000017A2
		public unsafe GUIStyle m_verticalScrollbarDownButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbarDownButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbarDownButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0000D958 File Offset: 0x0000BB58
		// (set) Token: 0x06000351 RID: 849 RVA: 0x000035C1 File Offset: 0x000017C1
		public unsafe GUIStyle m_ScrollView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_ScrollView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_ScrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0000D988 File Offset: 0x0000BB88
		// (set) Token: 0x06000353 RID: 851 RVA: 0x000035E0 File Offset: 0x000017E0
		public unsafe Il2CppReferenceArray<GUIStyle> m_CustomStyles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_CustomStyles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GUIStyle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_CustomStyles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0000D9B8 File Offset: 0x0000BBB8
		// (set) Token: 0x06000355 RID: 853 RVA: 0x000035FF File Offset: 0x000017FF
		public unsafe GUISettings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUISettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0000D9E8 File Offset: 0x0000BBE8
		// (set) Token: 0x06000357 RID: 855 RVA: 0x0000361E File Offset: 0x0000181E
		public unsafe static GUIStyle ms_Error
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUISkin.NativeFieldInfoPtr_ms_Error, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUISkin.NativeFieldInfoPtr_ms_Error, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0000DA10 File Offset: 0x0000BC10
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00003630 File Offset: 0x00001830
		public unsafe Dictionary<string, GUIStyle> m_Styles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_Styles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GUIStyle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_Styles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0000DA40 File Offset: 0x0000BC40
		// (set) Token: 0x0600035B RID: 859 RVA: 0x0000364F File Offset: 0x0000184F
		public unsafe static GUISkin.SkinChangedDelegate m_SkinChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUISkin.NativeFieldInfoPtr_m_SkinChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUISkin.SkinChangedDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUISkin.NativeFieldInfoPtr_m_SkinChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0000DA68 File Offset: 0x0000BC68
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00003661 File Offset: 0x00001861
		public unsafe static GUISkin current
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUISkin.NativeFieldInfoPtr_current, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUISkin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUISkin.NativeFieldInfoPtr_current, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeFieldInfoPtr_m_Font;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeFieldInfoPtr_m_box;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeFieldInfoPtr_m_button;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeFieldInfoPtr_m_toggle;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeFieldInfoPtr_m_label;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeFieldInfoPtr_m_textField;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeFieldInfoPtr_m_textArea;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr_m_window;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalSlider;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalSliderThumb;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalSliderThumbExtent;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalSlider;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalSliderThumb;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalSliderThumbExtent;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_m_SliderMixed;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalScrollbar;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalScrollbarThumb;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalScrollbarLeftButton;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalScrollbarRightButton;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalScrollbar;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalScrollbarThumb;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalScrollbarUpButton;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalScrollbarDownButton;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollView;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomStyles;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeFieldInfoPtr_ms_Error;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeFieldInfoPtr_m_Styles;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeFieldInfoPtr_m_SkinChanged;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Internal_Void_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_CleanupRoots_Internal_Static_Void_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_get_font_Public_get_Font_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_set_font_Public_set_Void_Font_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_get_box_Public_get_GUIStyle_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_set_box_Public_set_Void_GUIStyle_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_get_label_Public_get_GUIStyle_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_set_label_Public_set_Void_GUIStyle_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_get_textField_Public_get_GUIStyle_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_set_textField_Public_set_Void_GUIStyle_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_get_textArea_Public_get_GUIStyle_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_set_textArea_Public_set_Void_GUIStyle_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_get_GUIStyle_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_set_button_Public_set_Void_GUIStyle_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_get_toggle_Public_get_GUIStyle_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_set_toggle_Public_set_Void_GUIStyle_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_get_window_Public_get_GUIStyle_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_set_window_Public_set_Void_GUIStyle_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalSlider_Public_get_GUIStyle_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalSlider_Public_set_Void_GUIStyle_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalSliderThumb_Public_get_GUIStyle_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalSliderThumb_Public_set_Void_GUIStyle_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalSliderThumbExtent_Internal_get_GUIStyle_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalSliderThumbExtent_Internal_set_Void_GUIStyle_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_get_sliderMixed_Internal_get_GUIStyle_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_set_sliderMixed_Internal_set_Void_GUIStyle_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalSlider_Public_get_GUIStyle_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalSlider_Public_set_Void_GUIStyle_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalSliderThumb_Public_get_GUIStyle_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalSliderThumb_Public_set_Void_GUIStyle_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalSliderThumbExtent_Internal_get_GUIStyle_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalSliderThumbExtent_Internal_set_Void_GUIStyle_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbar_Public_get_GUIStyle_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbar_Public_set_Void_GUIStyle_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbarThumb_Public_get_GUIStyle_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbarThumb_Public_set_Void_GUIStyle_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbarLeftButton_Public_get_GUIStyle_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbarLeftButton_Public_set_Void_GUIStyle_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbarRightButton_Public_get_GUIStyle_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbarRightButton_Public_set_Void_GUIStyle_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbar_Public_get_GUIStyle_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_GUIStyle_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbarThumb_Public_get_GUIStyle_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbarThumb_Public_set_Void_GUIStyle_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbarUpButton_Public_get_GUIStyle_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbarUpButton_Public_set_Void_GUIStyle_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbarDownButton_Public_get_GUIStyle_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbarDownButton_Public_set_Void_GUIStyle_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollView_Public_get_GUIStyle_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_set_scrollView_Public_set_Void_GUIStyle_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_get_customStyles_Public_get_Il2CppReferenceArray_1_GUIStyle_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_set_customStyles_Public_set_Void_Il2CppReferenceArray_1_GUIStyle_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_GUISettings_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_get_error_Internal_Static_get_GUIStyle_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Internal_Void_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_BuildStyleCache_Private_Void_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_GetStyle_Public_GUIStyle_String_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_FindStyle_Public_GUIStyle_String_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_MakeCurrent_Internal_Void_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0;

		// Token: 0x02000073 RID: 115
		public sealed class SkinChangedDelegate : MulticastDelegate
		{
			// Token: 0x0600070F RID: 1807 RVA: 0x00004ECA File Offset: 0x000030CA
			// Note: this type is marked as 'beforefieldinit'.
			static SkinChangedDelegate()
			{
				Il2CppClassPointerStore<GUISkin.SkinChangedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "SkinChangedDelegate");
				GUISkin.SkinChangedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin.SkinChangedDelegate>.NativeClassPtr, 100663510);
				GUISkin.SkinChangedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin.SkinChangedDelegate>.NativeClassPtr, 100663511);
			}

			// Token: 0x06000710 RID: 1808 RVA: 0x00017BB4 File Offset: 0x00015DB4
			[CallerCount(288)]
			[CachedScanResults(RefRangeStart = 320972, RefRangeEnd = 321260, XrefRangeStart = 320972, XrefRangeEnd = 321260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SkinChangedDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUISkin.SkinChangedDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.SkinChangedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000711 RID: 1809 RVA: 0x00017C10 File Offset: 0x00015E10
			[CallerCount(0)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.SkinChangedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000712 RID: 1810 RVA: 0x00004F08 File Offset: 0x00003108
			public SkinChangedDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000713 RID: 1811 RVA: 0x00004F11 File Offset: 0x00003111
			public static implicit operator GUISkin.SkinChangedDelegate(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<GUISkin.SkinChangedDelegate>(A_0);
			}

			// Token: 0x06000714 RID: 1812 RVA: 0x00004F19 File Offset: 0x00003119
			public static GUISkin.SkinChangedDelegate operator +(GUISkin.SkinChangedDelegate A_0, GUISkin.SkinChangedDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<GUISkin.SkinChangedDelegate>();
			}

			// Token: 0x06000715 RID: 1813 RVA: 0x00004F27 File Offset: 0x00003127
			public static GUISkin.SkinChangedDelegate operator -(GUISkin.SkinChangedDelegate A_0, GUISkin.SkinChangedDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<GUISkin.SkinChangedDelegate>();
				}
				return delegate2;
			}

			// Token: 0x040003B1 RID: 945
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040003B2 RID: 946
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}
	}
}
