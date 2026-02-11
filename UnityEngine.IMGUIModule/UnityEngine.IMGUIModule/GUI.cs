using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	public class GUI : Object
	{
		// Token: 0x06000064 RID: 100 RVA: 0x0000666C File Offset: 0x0000486C
		// Note: this type is marked as 'beforefieldinit'.
		static GUI()
		{
			Il2CppClassPointerStore<GUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUI");
			GUI.NativeFieldInfoPtr_s_HotTextField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_HotTextField");
			GUI.NativeFieldInfoPtr_s_BoxHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_BoxHash");
			GUI.NativeFieldInfoPtr_s_ButonHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_ButonHash");
			GUI.NativeFieldInfoPtr_s_RepeatButtonHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_RepeatButtonHash");
			GUI.NativeFieldInfoPtr_s_ToggleHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_ToggleHash");
			GUI.NativeFieldInfoPtr_s_ButtonGridHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_ButtonGridHash");
			GUI.NativeFieldInfoPtr_s_SliderHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_SliderHash");
			GUI.NativeFieldInfoPtr_s_BeginGroupHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_BeginGroupHash");
			GUI.NativeFieldInfoPtr_s_ScrollviewHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_ScrollviewHash");
			GUI.NativeFieldInfoPtr__nextScrollStepTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "<nextScrollStepTime>k__BackingField");
			GUI.NativeFieldInfoPtr_s_Skin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_Skin");
			GUI.NativeFieldInfoPtr_s_ToolTipRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_ToolTipRect");
			GUI.NativeFieldInfoPtr__scrollViewStates_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "<scrollViewStates>k__BackingField");
			GUI.NativeMethodInfoPtr_get_color_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663359);
			GUI.NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663360);
			GUI.NativeMethodInfoPtr_get_backgroundColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663361);
			GUI.NativeMethodInfoPtr_set_backgroundColor_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663362);
			GUI.NativeMethodInfoPtr_get_contentColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663363);
			GUI.NativeMethodInfoPtr_set_contentColor_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663364);
			GUI.NativeMethodInfoPtr_get_changed_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663365);
			GUI.NativeMethodInfoPtr_set_changed_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663366);
			GUI.NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663367);
			GUI.NativeMethodInfoPtr_set_enabled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663368);
			GUI.NativeMethodInfoPtr_GrabMouseControl_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663369);
			GUI.NativeMethodInfoPtr_HasMouseControl_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663370);
			GUI.NativeMethodInfoPtr_ReleaseMouseControl_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663371);
			GUI.NativeMethodInfoPtr_set_nextScrollStepTime_Internal_Static_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663373);
			GUI.NativeMethodInfoPtr_set_skin_Public_Static_set_Void_GUISkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663374);
			GUI.NativeMethodInfoPtr_get_skin_Public_Static_get_GUISkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663375);
			GUI.NativeMethodInfoPtr_DoSetSkin_Internal_Static_Void_GUISkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663376);
			GUI.NativeMethodInfoPtr_get_matrix_Public_Static_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663377);
			GUI.NativeMethodInfoPtr_set_matrix_Public_Static_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663378);
			GUI.NativeMethodInfoPtr_Label_Public_Static_Void_Rect_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663379);
			GUI.NativeMethodInfoPtr_Label_Public_Static_Void_Rect_String_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663380);
			GUI.NativeMethodInfoPtr_Label_Public_Static_Void_Rect_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663381);
			GUI.NativeMethodInfoPtr_Box_Public_Static_Void_Rect_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663382);
			GUI.NativeMethodInfoPtr_Box_Public_Static_Void_Rect_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663383);
			GUI.NativeMethodInfoPtr_Button_Public_Static_Boolean_Rect_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663384);
			GUI.NativeMethodInfoPtr_Button_Public_Static_Boolean_Rect_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663385);
			GUI.NativeMethodInfoPtr_Button_Internal_Static_Boolean_Rect_Int32_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663386);
			GUI.NativeMethodInfoPtr_DoControl_Internal_Static_Boolean_Rect_Int32_Boolean_Boolean_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663387);
			GUI.NativeMethodInfoPtr_DoLabel_Private_Static_Void_Rect_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663388);
			GUI.NativeMethodInfoPtr_DoButton_Internal_Static_Boolean_Rect_Int32_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663389);
			GUI.NativeMethodInfoPtr_get_scrollViewStates_Internal_Static_get_GenericStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663390);
			GUI.NativeMethodInfoPtr_CallWindowDelegate_Internal_Static_Void_WindowFunction_Int32_Int32_GUISkin_Int32_Single_Single_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663391);
			GUI.NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663392);
			GUI.NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663393);
			GUI.NativeMethodInfoPtr_get_backgroundColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663394);
			GUI.NativeMethodInfoPtr_set_backgroundColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663395);
			GUI.NativeMethodInfoPtr_get_contentColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663396);
			GUI.NativeMethodInfoPtr_set_contentColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663397);
			GUI.get_depthDelegateField = IL2CPP.ResolveICall<GUI.get_depthDelegate>("UnityEngine.GUI::get_depth");
			GUI.set_depthDelegateField = IL2CPP.ResolveICall<GUI.set_depthDelegate>("UnityEngine.GUI::set_depth");
			GUI.get_usePageScrollbarsDelegateField = IL2CPP.ResolveICall<GUI.get_usePageScrollbarsDelegate>("UnityEngine.GUI::get_usePageScrollbars");
			GUI.get_isInsideListDelegateField = IL2CPP.ResolveICall<GUI.get_isInsideListDelegate>("UnityEngine.GUI::get_isInsideList");
			GUI.set_isInsideListDelegateField = IL2CPP.ResolveICall<GUI.set_isInsideListDelegate>("UnityEngine.GUI::set_isInsideList");
			GUI.get_blendMaterialDelegateField = IL2CPP.ResolveICall<GUI.get_blendMaterialDelegate>("UnityEngine.GUI::get_blendMaterial");
			GUI.get_blitMaterialDelegateField = IL2CPP.ResolveICall<GUI.get_blitMaterialDelegate>("UnityEngine.GUI::get_blitMaterial");
			GUI.get_roundedRectMaterialDelegateField = IL2CPP.ResolveICall<GUI.get_roundedRectMaterialDelegate>("UnityEngine.GUI::get_roundedRectMaterial");
			GUI.get_roundedRectWithColorPerBorderMaterialDelegateField = IL2CPP.ResolveICall<GUI.get_roundedRectWithColorPerBorderMaterialDelegate>("UnityEngine.GUI::get_roundedRectWithColorPerBorderMaterial");
			GUI.SetNextControlNameDelegateField = IL2CPP.ResolveICall<GUI.SetNextControlNameDelegate>("UnityEngine.GUI::SetNextControlName");
			GUI.GetNameOfFocusedControlDelegateField = IL2CPP.ResolveICall<GUI.GetNameOfFocusedControlDelegate>("UnityEngine.GUI::GetNameOfFocusedControl");
			GUI.FocusControlDelegateField = IL2CPP.ResolveICall<GUI.FocusControlDelegate>("UnityEngine.GUI::FocusControl");
			GUI.InternalRepaintEditorWindowDelegateField = IL2CPP.ResolveICall<GUI.InternalRepaintEditorWindowDelegate>("UnityEngine.GUI::InternalRepaintEditorWindow");
			GUI.Internal_GetTooltipDelegateField = IL2CPP.ResolveICall<GUI.Internal_GetTooltipDelegate>("UnityEngine.GUI::Internal_GetTooltip");
			GUI.Internal_SetTooltipDelegateField = IL2CPP.ResolveICall<GUI.Internal_SetTooltipDelegate>("UnityEngine.GUI::Internal_SetTooltip");
			GUI.Internal_GetMouseTooltipDelegateField = IL2CPP.ResolveICall<GUI.Internal_GetMouseTooltipDelegate>("UnityEngine.GUI::Internal_GetMouseTooltip");
			GUI.BringWindowToFrontDelegateField = IL2CPP.ResolveICall<GUI.BringWindowToFrontDelegate>("UnityEngine.GUI::BringWindowToFront");
			GUI.BringWindowToBackDelegateField = IL2CPP.ResolveICall<GUI.BringWindowToBackDelegate>("UnityEngine.GUI::BringWindowToBack");
			GUI.FocusWindowDelegateField = IL2CPP.ResolveICall<GUI.FocusWindowDelegate>("UnityEngine.GUI::FocusWindow");
			GUI.UnfocusWindowDelegateField = IL2CPP.ResolveICall<GUI.UnfocusWindowDelegate>("UnityEngine.GUI::UnfocusWindow");
			GUI.Internal_BeginWindowsDelegateField = IL2CPP.ResolveICall<GUI.Internal_BeginWindowsDelegate>("UnityEngine.GUI::Internal_BeginWindows");
			GUI.Internal_EndWindowsDelegateField = IL2CPP.ResolveICall<GUI.Internal_EndWindowsDelegate>("UnityEngine.GUI::Internal_EndWindows");
			GUI.Internal_ConcatenateDelegateField = IL2CPP.ResolveICall<GUI.Internal_ConcatenateDelegate>("UnityEngine.GUI::Internal_Concatenate");
			GUI.Internal_DoModalWindow_InjectedDelegateField = IL2CPP.ResolveICall<GUI.Internal_DoModalWindow_InjectedDelegate>("UnityEngine.GUI::Internal_DoModalWindow_Injected");
			GUI.Internal_DoWindow_InjectedDelegateField = IL2CPP.ResolveICall<GUI.Internal_DoWindow_InjectedDelegate>("UnityEngine.GUI::Internal_DoWindow_Injected");
			GUI.DragWindow_InjectedDelegateField = IL2CPP.ResolveICall<GUI.DragWindow_InjectedDelegate>("UnityEngine.GUI::DragWindow_Injected");
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00006C14 File Offset: 0x00004E14
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00006C44 File Offset: 0x00004E44
		public unsafe static Color color
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1185397, RefRangeEnd = 1185399, XrefRangeStart = 1185392, XrefRangeEnd = 1185397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_color_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1185404, RefRangeEnd = 1185407, XrefRangeStart = 1185399, XrefRangeEnd = 1185404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00006C78 File Offset: 0x00004E78
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00006CA8 File Offset: 0x00004EA8
		public unsafe static Color backgroundColor
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1185412, RefRangeEnd = 1185414, XrefRangeStart = 1185407, XrefRangeEnd = 1185412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_backgroundColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1185419, RefRangeEnd = 1185421, XrefRangeStart = 1185414, XrefRangeEnd = 1185419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_set_backgroundColor_Public_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00006CDC File Offset: 0x00004EDC
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00006D0C File Offset: 0x00004F0C
		public unsafe static Color contentColor
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1185426, RefRangeEnd = 1185428, XrefRangeStart = 1185421, XrefRangeEnd = 1185426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_contentColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1185433, RefRangeEnd = 1185435, XrefRangeStart = 1185428, XrefRangeEnd = 1185433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_set_contentColor_Public_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00006D40 File Offset: 0x00004F40
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00006D70 File Offset: 0x00004F70
		public unsafe static bool changed
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1185437, RefRangeEnd = 1185439, XrefRangeStart = 1185435, XrefRangeEnd = 1185437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_changed_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1185441, RefRangeEnd = 1185443, XrefRangeStart = 1185439, XrefRangeEnd = 1185441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_set_changed_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00006DA4 File Offset: 0x00004FA4
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00006DD4 File Offset: 0x00004FD4
		public unsafe static bool enabled
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1185445, RefRangeEnd = 1185447, XrefRangeStart = 1185443, XrefRangeEnd = 1185445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1185449, RefRangeEnd = 1185452, XrefRangeStart = 1185447, XrefRangeEnd = 1185449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_set_enabled_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00006E08 File Offset: 0x00005008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185452, XrefRangeEnd = 1185454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GrabMouseControl(int id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_GrabMouseControl_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00006E3C File Offset: 0x0000503C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185454, XrefRangeEnd = 1185456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasMouseControl(int id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_HasMouseControl_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00006E7C File Offset: 0x0000507C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185456, XrefRangeEnd = 1185499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseMouseControl()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_ReleaseMouseControl_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00002361 File Offset: 0x00000561
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00006EA4 File Offset: 0x000050A4
		public unsafe static DateTime nextScrollStepTime
		{
			get
			{
				return GUI._nextScrollStepTime_k__BackingField;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185499, XrefRangeEnd = 1185503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_set_nextScrollStepTime_Internal_Static_set_Void_DateTime_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00006F10 File Offset: 0x00005110
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00006ED8 File Offset: 0x000050D8
		public unsafe static GUISkin skin
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1185521, RefRangeEnd = 1185522, XrefRangeStart = 1185513, XrefRangeEnd = 1185521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_skin_Public_Static_get_GUISkin_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUISkin>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1185511, RefRangeEnd = 1185513, XrefRangeStart = 1185503, XrefRangeEnd = 1185511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_set_skin_Public_Static_set_Void_GUISkin_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00006F44 File Offset: 0x00005144
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1185553, RefRangeEnd = 1185556, XrefRangeStart = 1185522, XrefRangeEnd = 1185553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoSetSkin(GUISkin newSkin)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSkin);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DoSetSkin_Internal_Static_Void_GUISkin_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00006F7C File Offset: 0x0000517C
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00006FAC File Offset: 0x000051AC
		public unsafe static Matrix4x4 matrix
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1185558, RefRangeEnd = 1185560, XrefRangeStart = 1185556, XrefRangeEnd = 1185558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_matrix_Public_Static_get_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1185562, RefRangeEnd = 1185564, XrefRangeStart = 1185560, XrefRangeEnd = 1185562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_set_matrix_Public_Static_set_Void_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00006FE0 File Offset: 0x000051E0
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 1185580, RefRangeEnd = 1185619, XrefRangeStart = 1185564, XrefRangeEnd = 1185580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Label(Rect position, string text)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_Label_Public_Static_Void_Rect_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00007024 File Offset: 0x00005224
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 1185634, RefRangeEnd = 1185662, XrefRangeStart = 1185619, XrefRangeEnd = 1185634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Label(Rect position, string text, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_Label_Public_Static_Void_Rect_String_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000707C File Offset: 0x0000527C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185662, XrefRangeEnd = 1185670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Label(Rect position, GUIContent content, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_Label_Public_Static_Void_Rect_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000070D4 File Offset: 0x000052D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1185679, RefRangeEnd = 1185680, XrefRangeStart = 1185670, XrefRangeEnd = 1185679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Box(Rect position, string text)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_Box_Public_Static_Void_Rect_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00007118 File Offset: 0x00005318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1185703, RefRangeEnd = 1185704, XrefRangeStart = 1185680, XrefRangeEnd = 1185703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Box(Rect position, GUIContent content, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_Box_Public_Static_Void_Rect_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00007170 File Offset: 0x00005370
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1185713, RefRangeEnd = 1185720, XrefRangeStart = 1185704, XrefRangeEnd = 1185713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Button(Rect position, string text)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_Button_Public_Static_Boolean_Rect_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000071C0 File Offset: 0x000053C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1185744, RefRangeEnd = 1185745, XrefRangeStart = 1185720, XrefRangeEnd = 1185744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Button(Rect position, GUIContent content, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_Button_Public_Static_Boolean_Rect_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00007224 File Offset: 0x00005424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185745, XrefRangeEnd = 1185761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Button(Rect position, int id, GUIContent content, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_Button_Internal_Static_Boolean_Rect_Int32_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00007294 File Offset: 0x00005494
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1185820, RefRangeEnd = 1185823, XrefRangeStart = 1185761, XrefRangeEnd = 1185820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hover;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DoControl_Internal_Static_Boolean_Rect_Int32_Boolean_Boolean_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00007324 File Offset: 0x00005524
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1185859, RefRangeEnd = 1185862, XrefRangeStart = 1185823, XrefRangeEnd = 1185859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoLabel(Rect position, GUIContent content, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DoLabel_Private_Static_Void_Rect_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000737C File Offset: 0x0000557C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185862, XrefRangeEnd = 1185871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DoButton_Internal_Static_Boolean_Rect_Int32_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000073EC File Offset: 0x000055EC
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00002602 File Offset: 0x00000802
		public unsafe static GenericStack scrollViewStates
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185871, XrefRangeEnd = 1185875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_scrollViewStates_Internal_Static_get_GenericStack_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GenericStack>(intPtr3) : null;
			}
			set
			{
				GUI._scrollViewStates_k__BackingField = value;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00007420 File Offset: 0x00005620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185875, XrefRangeEnd = 1185943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instanceID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_skin);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceRect;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_CallWindowDelegate_Internal_Static_Void_WindowFunction_Int32_Int32_GUISkin_Int32_Single_Single_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000074C4 File Offset: 0x000056C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185943, XrefRangeEnd = 1185945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_color_Injected(out Color ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000074F8 File Offset: 0x000056F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185945, XrefRangeEnd = 1185947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_color_Injected(ref Color value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000752C File Offset: 0x0000572C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185947, XrefRangeEnd = 1185949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_backgroundColor_Injected(out Color ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_backgroundColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00007560 File Offset: 0x00005760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185949, XrefRangeEnd = 1185951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_backgroundColor_Injected(ref Color value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_set_backgroundColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00007594 File Offset: 0x00005794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185951, XrefRangeEnd = 1185953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_contentColor_Injected(out Color ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_contentColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000075C8 File Offset: 0x000057C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185953, XrefRangeEnd = 1185955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_contentColor_Injected(ref Color value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_set_contentColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000021AC File Offset: 0x000003AC
		public GUI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000075FC File Offset: 0x000057FC
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000021B5 File Offset: 0x000003B5
		public unsafe static int s_HotTextField
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_HotTextField, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_HotTextField, (void*)(&value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00007618 File Offset: 0x00005818
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000021C3 File Offset: 0x000003C3
		public unsafe static int s_BoxHash
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_BoxHash, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_BoxHash, (void*)(&value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00007634 File Offset: 0x00005834
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000021D1 File Offset: 0x000003D1
		public unsafe static int s_ButonHash
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_ButonHash, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_ButonHash, (void*)(&value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00007650 File Offset: 0x00005850
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000021DF File Offset: 0x000003DF
		public unsafe static int s_RepeatButtonHash
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_RepeatButtonHash, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_RepeatButtonHash, (void*)(&value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000766C File Offset: 0x0000586C
		// (set) Token: 0x06000095 RID: 149 RVA: 0x000021ED File Offset: 0x000003ED
		public unsafe static int s_ToggleHash
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_ToggleHash, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_ToggleHash, (void*)(&value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00007688 File Offset: 0x00005888
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000021FB File Offset: 0x000003FB
		public unsafe static int s_ButtonGridHash
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_ButtonGridHash, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_ButtonGridHash, (void*)(&value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000076A4 File Offset: 0x000058A4
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002209 File Offset: 0x00000409
		public unsafe static int s_SliderHash
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_SliderHash, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_SliderHash, (void*)(&value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000076C0 File Offset: 0x000058C0
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002217 File Offset: 0x00000417
		public unsafe static int s_BeginGroupHash
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_BeginGroupHash, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_BeginGroupHash, (void*)(&value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000076DC File Offset: 0x000058DC
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002225 File Offset: 0x00000425
		public unsafe static int s_ScrollviewHash
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_ScrollviewHash, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_ScrollviewHash, (void*)(&value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000076F8 File Offset: 0x000058F8
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002233 File Offset: 0x00000433
		public unsafe static DateTime _nextScrollStepTime_k__BackingField
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr__nextScrollStepTime_k__BackingField, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr__nextScrollStepTime_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00007714 File Offset: 0x00005914
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002241 File Offset: 0x00000441
		public unsafe static GUISkin s_Skin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_Skin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUISkin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_Skin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000773C File Offset: 0x0000593C
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002253 File Offset: 0x00000453
		public unsafe static Rect s_ToolTipRect
		{
			get
			{
				Rect rect;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_ToolTipRect, (void*)(&rect));
				return rect;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_ToolTipRect, (void*)(&value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00007758 File Offset: 0x00005958
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00002261 File Offset: 0x00000461
		public unsafe static GenericStack _scrollViewStates_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr__scrollViewStates_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericStack>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr__scrollViewStates_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00002273 File Offset: 0x00000473
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x0000227F File Offset: 0x0000047F
		public static int depth
		{
			get
			{
				return GUI.get_depthDelegateField();
			}
			set
			{
				GUI.set_depthDelegateField(value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000228C File Offset: 0x0000048C
		public static bool usePageScrollbars
		{
			get
			{
				return GUI.get_usePageScrollbarsDelegateField();
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00002298 File Offset: 0x00000498
		// (set) Token: 0x060000AA RID: 170 RVA: 0x000022A4 File Offset: 0x000004A4
		public static bool isInsideList
		{
			get
			{
				return GUI.get_isInsideListDelegateField();
			}
			set
			{
				GUI.set_isInsideListDelegateField(value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00007780 File Offset: 0x00005980
		public static Material blendMaterial
		{
			get
			{
				IntPtr intPtr = GUI.get_blendMaterialDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000077A8 File Offset: 0x000059A8
		public static Material blitMaterial
		{
			get
			{
				IntPtr intPtr = GUI.get_blitMaterialDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000AD RID: 173 RVA: 0x000077D0 File Offset: 0x000059D0
		public static Material roundedRectMaterial
		{
			get
			{
				IntPtr intPtr = GUI.get_roundedRectMaterialDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000077F8 File Offset: 0x000059F8
		public static Material roundedRectWithColorPerBorderMaterial
		{
			get
			{
				IntPtr intPtr = GUI.get_roundedRectWithColorPerBorderMaterialDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000022B1 File Offset: 0x000004B1
		public static void SetNextControlName(string name)
		{
			GUI.SetNextControlNameDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00007820 File Offset: 0x00005A20
		public static string GetNameOfFocusedControl()
		{
			IntPtr intPtr = GUI.GetNameOfFocusedControlDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000022C3 File Offset: 0x000004C3
		public static void FocusControl(string name)
		{
			GUI.FocusControlDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000022D5 File Offset: 0x000004D5
		public static void InternalRepaintEditorWindow()
		{
			GUI.InternalRepaintEditorWindowDelegateField();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00007840 File Offset: 0x00005A40
		public static string Internal_GetTooltip()
		{
			IntPtr intPtr = GUI.Internal_GetTooltipDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000022E1 File Offset: 0x000004E1
		public static void Internal_SetTooltip(string value)
		{
			GUI.Internal_SetTooltipDelegateField(IL2CPP.ManagedStringToIl2Cpp(value));
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00007860 File Offset: 0x00005A60
		public static string Internal_GetMouseTooltip()
		{
			IntPtr intPtr = GUI.Internal_GetMouseTooltipDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00007880 File Offset: 0x00005A80
		public static Rect Internal_DoModalWindow(int id, int instanceID, Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, Object skin)
		{
			Rect rect;
			GUI.Internal_DoModalWindow_Injected(id, instanceID, ref clientRect, func, content, style, skin, out rect);
			return rect;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000078A0 File Offset: 0x00005AA0
		public static Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, Object skin, bool forceRectOnLayout)
		{
			Rect rect;
			GUI.Internal_DoWindow_Injected(id, instanceID, ref clientRect, func, title, style, skin, forceRectOnLayout, out rect);
			return rect;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000022F3 File Offset: 0x000004F3
		public static void DragWindow(Rect position)
		{
			GUI.DragWindow_Injected(ref position);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000022FC File Offset: 0x000004FC
		public static void BringWindowToFront(int windowID)
		{
			GUI.BringWindowToFrontDelegateField(windowID);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002309 File Offset: 0x00000509
		public static void BringWindowToBack(int windowID)
		{
			GUI.BringWindowToBackDelegateField(windowID);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002316 File Offset: 0x00000516
		public static void FocusWindow(int windowID)
		{
			GUI.FocusWindowDelegateField(windowID);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002323 File Offset: 0x00000523
		public static void UnfocusWindow()
		{
			GUI.UnfocusWindowDelegateField();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000232F File Offset: 0x0000052F
		public static void Internal_BeginWindows()
		{
			GUI.Internal_BeginWindowsDelegateField();
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000233B File Offset: 0x0000053B
		public static void Internal_EndWindows()
		{
			GUI.Internal_EndWindowsDelegateField();
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000078C4 File Offset: 0x00005AC4
		public static string Internal_Concatenate(GUIContent first, GUIContent second)
		{
			IntPtr intPtr = GUI.Internal_ConcatenateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(first), IL2CPP.Il2CppObjectBaseToPtr(second));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00002347 File Offset: 0x00000547
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00002354 File Offset: 0x00000554
		public static int scrollTroughSide
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002368 File Offset: 0x00000568
		public static void CleanupRoots()
		{
			GUI.s_Skin = null;
			GUIUtility.CleanupRoots();
			GUILayoutUtility.CleanupRoots();
			GUISkin.CleanupRoots();
			GUIStyle.CleanupRoots();
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x000078F0 File Offset: 0x00005AF0
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002389 File Offset: 0x00000589
		public static string tooltip
		{
			get
			{
				string text = GUI.Internal_GetTooltip();
				bool flag = text != null;
				string text2;
				if (flag)
				{
					text2 = text;
				}
				else
				{
					text2 = "";
				}
				return text2;
			}
			set
			{
				GUI.Internal_SetTooltip(value);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00002393 File Offset: 0x00000593
		public static string mouseTooltip
		{
			get
			{
				return GUI.Internal_GetMouseTooltip();
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000791C File Offset: 0x00005B1C
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x0000239A File Offset: 0x0000059A
		public static Rect tooltipRect
		{
			get
			{
				return GUI.s_ToolTipRect;
			}
			set
			{
				GUI.s_ToolTipRect = value;
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000023A3 File Offset: 0x000005A3
		public static void Label(Rect position, Texture image)
		{
			GUI.Label(position, GUIContent.Temp(image), GUI.s_Skin.label);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000023BD File Offset: 0x000005BD
		public static void Label(Rect position, GUIContent content)
		{
			GUI.Label(position, content, GUI.s_Skin.label);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000023D2 File Offset: 0x000005D2
		public static void Label(Rect position, Texture image, GUIStyle style)
		{
			GUI.Label(position, GUIContent.Temp(image), style);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000023E3 File Offset: 0x000005E3
		public static void DrawTexture(Rect position, Texture image)
		{
			GUI.DrawTexture(position, image, ScaleMode.StretchToFill);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000023EF File Offset: 0x000005EF
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode)
		{
			GUI.DrawTexture(position, image, scaleMode, true);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000023FC File Offset: 0x000005FC
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend)
		{
			GUI.DrawTexture(position, image, scaleMode, alphaBlend, 0f);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000240E File Offset: 0x0000060E
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect)
		{
			GUI.DrawTexture(position, image, scaleMode, alphaBlend, imageAspect, GUI.color, 0f, 0f);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00007934 File Offset: 0x00005B34
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius)
		{
			Vector4 vector = Vector4.one * borderWidth;
			GUI.DrawTexture(position, image, scaleMode, alphaBlend, imageAspect, color, vector, borderRadius);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00007960 File Offset: 0x00005B60
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius)
		{
			Vector4 vector = Vector4.one * borderRadius;
			GUI.DrawTexture(position, image, scaleMode, alphaBlend, imageAspect, color, borderWidths, vector);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000798C File Offset: 0x00005B8C
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses)
		{
			GUI.DrawTexture(position, image, scaleMode, alphaBlend, imageAspect, color, borderWidths, borderRadiuses, true);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000079B0 File Offset: 0x00005BB0
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners)
		{
			GUI.DrawTexture(position, image, scaleMode, alphaBlend, imageAspect, color, color, color, color, borderWidths, borderRadiuses, drawSmoothCorners);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000079D8 File Offset: 0x00005BD8
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses)
		{
			GUI.DrawTexture(position, image, scaleMode, alphaBlend, imageAspect, leftColor, topColor, rightColor, bottomColor, borderWidths, borderRadiuses, true);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000242C File Offset: 0x0000062C
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00007A00 File Offset: 0x00005C00
		public static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect)
		{
			float num = position.width / position.height;
			bool flag = false;
			switch (scaleMode)
			{
			case ScaleMode.StretchToFill:
				outScreenRect = position;
				outSourceRect = new Rect(0f, 0f, 1f, 1f);
				flag = true;
				break;
			case ScaleMode.ScaleAndCrop:
			{
				bool flag2 = num > imageAspect;
				if (flag2)
				{
					float num2 = imageAspect / num;
					outScreenRect = position;
					outSourceRect = new Rect(0f, (1f - num2) * 0.5f, 1f, num2);
					flag = true;
				}
				else
				{
					float num3 = num / imageAspect;
					outScreenRect = position;
					outSourceRect = new Rect(0.5f - num3 * 0.5f, 0f, num3, 1f);
					flag = true;
				}
				break;
			}
			case ScaleMode.ScaleToFit:
			{
				bool flag3 = num > imageAspect;
				if (flag3)
				{
					float num4 = imageAspect / num;
					outScreenRect = new Rect(position.xMin + position.width * (1f - num4) * 0.5f, position.yMin, num4 * position.width, position.height);
					outSourceRect = new Rect(0f, 0f, 1f, 1f);
					flag = true;
				}
				else
				{
					float num5 = num / imageAspect;
					outScreenRect = new Rect(position.xMin, position.yMin + position.height * (1f - num5) * 0.5f, position.width, num5 * position.height);
					outSourceRect = new Rect(0f, 0f, 1f, 1f);
					flag = true;
				}
				break;
			}
			}
			return flag;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002439 File Offset: 0x00000639
		public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords)
		{
			GUI.DrawTextureWithTexCoords(position, image, texCoords, true);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002446 File Offset: 0x00000646
		public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords, bool alphaBlend)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002453 File Offset: 0x00000653
		public static void Box(Rect position, Texture image)
		{
			GUI.Box(position, GUIContent.Temp(image), GUI.s_Skin.box);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000246D File Offset: 0x0000066D
		public static void Box(Rect position, GUIContent content)
		{
			GUI.Box(position, content, GUI.s_Skin.box);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002482 File Offset: 0x00000682
		public static void Box(Rect position, string text, GUIStyle style)
		{
			GUI.Box(position, GUIContent.Temp(text), style);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002493 File Offset: 0x00000693
		public static void Box(Rect position, Texture image, GUIStyle style)
		{
			GUI.Box(position, GUIContent.Temp(image), style);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00007BD0 File Offset: 0x00005DD0
		public static bool Button(Rect position, Texture image)
		{
			return GUI.Button(position, GUIContent.Temp(image), GUI.s_Skin.button);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00007BF8 File Offset: 0x00005DF8
		public static bool Button(Rect position, GUIContent content)
		{
			return GUI.Button(position, content, GUI.s_Skin.button);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00007C1C File Offset: 0x00005E1C
		public static bool Button(Rect position, string text, GUIStyle style)
		{
			return GUI.Button(position, GUIContent.Temp(text), style);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00007C3C File Offset: 0x00005E3C
		public static bool Button(Rect position, Texture image, GUIStyle style)
		{
			return GUI.Button(position, GUIContent.Temp(image), style);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00007C5C File Offset: 0x00005E5C
		public static bool RepeatButton(Rect position, string text)
		{
			return GUI.DoRepeatButton(position, GUIContent.Temp(text), GUI.s_Skin.button, FocusType.Passive);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00007C88 File Offset: 0x00005E88
		public static bool RepeatButton(Rect position, Texture image)
		{
			return GUI.DoRepeatButton(position, GUIContent.Temp(image), GUI.s_Skin.button, FocusType.Passive);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00007CB4 File Offset: 0x00005EB4
		public static bool RepeatButton(Rect position, GUIContent content)
		{
			return GUI.DoRepeatButton(position, content, GUI.s_Skin.button, FocusType.Passive);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00007CD8 File Offset: 0x00005ED8
		public static bool RepeatButton(Rect position, string text, GUIStyle style)
		{
			return GUI.DoRepeatButton(position, GUIContent.Temp(text), style, FocusType.Passive);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00007CF8 File Offset: 0x00005EF8
		public static bool RepeatButton(Rect position, Texture image, GUIStyle style)
		{
			return GUI.DoRepeatButton(position, GUIContent.Temp(image), style, FocusType.Passive);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00007D18 File Offset: 0x00005F18
		public static bool RepeatButton(Rect position, GUIContent content, GUIStyle style)
		{
			return GUI.DoRepeatButton(position, content, style, FocusType.Passive);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00007D34 File Offset: 0x00005F34
		public static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType)
		{
			GUIUtility.CheckOnGUI();
			int controlID = GUIUtility.GetControlID(GUI.s_RepeatButtonHash, focusType, position);
			EventType typeForControl = Event.current.GetTypeForControl(controlID);
			EventType eventType = typeForControl;
			bool flag;
			if (eventType != EventType.MouseDown)
			{
				if (eventType != EventType.MouseUp)
				{
					if (eventType != EventType.Repaint)
					{
						flag = false;
					}
					else
					{
						style.Draw(position, content, controlID, false, position.Contains(Event.current.mousePosition));
						flag = controlID == GUIUtility.hotControl && position.Contains(Event.current.mousePosition);
					}
				}
				else
				{
					bool flag2 = GUIUtility.hotControl == controlID;
					if (flag2)
					{
						GUIUtility.hotControl = 0;
						Event.current.Use();
						flag = position.Contains(Event.current.mousePosition);
					}
					else
					{
						flag = false;
					}
				}
			}
			else
			{
				bool flag3 = position.Contains(Event.current.mousePosition);
				if (flag3)
				{
					GUIUtility.hotControl = controlID;
					Event.current.Use();
				}
				flag = false;
			}
			return flag;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00007E24 File Offset: 0x00006024
		public static string TextField(Rect position, string text)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, -1, GUI.skin.textField);
			return guicontent.text;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00007E60 File Offset: 0x00006060
		public static string TextField(Rect position, string text, int maxLength)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, maxLength, GUI.skin.textField);
			return guicontent.text;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00007E9C File Offset: 0x0000609C
		public static string TextField(Rect position, string text, GUIStyle style)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, -1, style);
			return guicontent.text;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00007ED0 File Offset: 0x000060D0
		public static string TextField(Rect position, string text, int maxLength, GUIStyle style)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, maxLength, style);
			return guicontent.text;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00007F04 File Offset: 0x00006104
		public static string PasswordField(Rect position, string password, char maskChar)
		{
			return GUI.PasswordField(position, password, maskChar, -1, GUI.skin.textField);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00007F2C File Offset: 0x0000612C
		public static string PasswordField(Rect position, string password, char maskChar, int maxLength)
		{
			return GUI.PasswordField(position, password, maskChar, maxLength, GUI.skin.textField);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00007F54 File Offset: 0x00006154
		public static string PasswordField(Rect position, string password, char maskChar, GUIStyle style)
		{
			return GUI.PasswordField(position, password, maskChar, -1, style);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00007F70 File Offset: 0x00006170
		public static string PasswordField(Rect position, string password, char maskChar, int maxLength, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			string text = GUI.PasswordFieldGetStrToShow(password, maskChar);
			GUIContent guicontent = GUIContent.Temp(text);
			bool changed = GUI.changed;
			GUI.changed = false;
			bool flag = TouchScreenKeyboard.isSupported && !TouchScreenKeyboard.isInPlaceEditingAllowed;
			if (flag)
			{
				GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard), guicontent, false, maxLength, style, password, maskChar);
			}
			else
			{
				GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, maxLength, style);
			}
			text = (GUI.changed ? guicontent.text : password);
			GUI.changed = GUI.changed || changed;
			return text;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00008004 File Offset: 0x00006204
		public static string PasswordFieldGetStrToShow(string password, char maskChar)
		{
			return (Event.current.type == EventType.Repaint || Event.current.type == EventType.MouseDown) ? "".PadRight(password.Length, maskChar) : password;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00008044 File Offset: 0x00006244
		public static string TextArea(Rect position, string text)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, true, -1, GUI.skin.textArea);
			return guicontent.text;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00008080 File Offset: 0x00006280
		public static string TextArea(Rect position, string text, int maxLength)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, true, maxLength, GUI.skin.textArea);
			return guicontent.text;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000080BC File Offset: 0x000062BC
		public static string TextArea(Rect position, string text, GUIStyle style)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, true, -1, style);
			return guicontent.text;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000080F0 File Offset: 0x000062F0
		public static string TextArea(Rect position, string text, int maxLength, GUIStyle style)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, true, maxLength, style);
			return guicontent.text;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000024A4 File Offset: 0x000006A4
		public static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style)
		{
			GUI.DoTextField(position, id, content, multiline, maxLength, style, null);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000024B6 File Offset: 0x000006B6
		public static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText)
		{
			GUI.DoTextField(position, id, content, multiline, maxLength, style, secureText, '\0');
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00008124 File Offset: 0x00006324
		public static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar)
		{
			GUIUtility.CheckOnGUI();
			bool flag = maxLength >= 0 && content.text.Length > maxLength;
			if (flag)
			{
				content.text = content.text.Substring(0, maxLength);
			}
			TextEditor textEditor = GUIUtility.GetStateObject(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TextEditor>()), id).Cast<TextEditor>();
			textEditor.text = content.text;
			textEditor.SaveBackup();
			textEditor.position = position;
			textEditor.style = style;
			textEditor.multiline = multiline;
			textEditor.controlID = id;
			textEditor.DetectFocusChange();
			bool isRequiredToForceOpen = TouchScreenKeyboard.isRequiredToForceOpen;
			if (isRequiredToForceOpen)
			{
				GUI.HandleTextFieldEventForDesktopWithForcedKeyboard(position, id, content, multiline, maxLength, style, secureText, textEditor);
			}
			else
			{
				bool flag2 = TouchScreenKeyboard.isSupported && !TouchScreenKeyboard.isInPlaceEditingAllowed;
				if (flag2)
				{
					GUI.HandleTextFieldEventForTouchscreen(position, id, content, multiline, maxLength, style, secureText, maskChar, textEditor);
				}
				else
				{
					GUI.HandleTextFieldEventForDesktop(position, id, content, multiline, maxLength, style, textEditor);
				}
			}
			textEditor.UpdateScrollOffsetIfNeeded(Event.current);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00008220 File Offset: 0x00006420
		public static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor)
		{
			Event current = Event.current;
			EventType type = current.type;
			EventType eventType = type;
			if (eventType != EventType.MouseDown)
			{
				if (eventType == EventType.Repaint)
				{
					bool flag = editor.keyboardOnScreen != null;
					if (flag)
					{
						content.text = editor.keyboardOnScreen.text;
						bool flag2 = maxLength >= 0 && content.text.Length > maxLength;
						if (flag2)
						{
							content.text = content.text.Substring(0, maxLength);
						}
						bool flag3 = editor.keyboardOnScreen.status > TouchScreenKeyboard.Status.Visible;
						if (flag3)
						{
							editor.keyboardOnScreen = null;
							GUI.changed = true;
						}
					}
					string text = content.text;
					bool flag4 = secureText != null;
					if (flag4)
					{
						content.text = GUI.PasswordFieldGetStrToShow(text, maskChar);
					}
					style.Draw(position, content, id, false);
					content.text = text;
				}
			}
			else
			{
				bool flag5 = position.Contains(current.mousePosition);
				if (flag5)
				{
					GUIUtility.hotControl = id;
					bool flag6 = GUI.s_HotTextField != -1 && GUI.s_HotTextField != id;
					if (flag6)
					{
						TextEditor textEditor = GUIUtility.GetStateObject(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TextEditor>()), GUI.s_HotTextField).Cast<TextEditor>();
						textEditor.keyboardOnScreen = null;
					}
					GUI.s_HotTextField = id;
					bool flag7 = GUIUtility.keyboardControl != id;
					if (flag7)
					{
						GUIUtility.keyboardControl = id;
					}
					editor.keyboardOnScreen = TouchScreenKeyboard.Open(secureText ?? content.text, TouchScreenKeyboardType.Default, true, multiline, secureText != null);
					current.Use();
				}
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000024CA File Offset: 0x000006CA
		public static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000083AC File Offset: 0x000065AC
		public static void HandleTextFieldEventForDesktopWithForcedKeyboard(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, TextEditor editor)
		{
			bool flag = false;
			bool flag2 = Event.current.type == EventType.Repaint;
			if (flag2)
			{
				bool flag3 = GUI.s_HotTextField != -1 && GUI.s_HotTextField != id;
				if (flag3)
				{
					TextEditor textEditor = GUIUtility.GetStateObject(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TextEditor>()), GUI.s_HotTextField).Cast<TextEditor>();
					textEditor.keyboardOnScreen.active = false;
					textEditor.keyboardOnScreen = null;
				}
				bool flag4 = editor.keyboardOnScreen != null;
				if (flag4)
				{
					bool flag5 = GUIUtility.keyboardControl != id || !Application.isFocused;
					if (flag5)
					{
						editor.keyboardOnScreen.active = false;
						editor.keyboardOnScreen = null;
					}
					else
					{
						bool flag6 = !editor.keyboardOnScreen.active;
						if (flag6)
						{
							flag = true;
						}
					}
				}
				else
				{
					bool flag7 = GUIUtility.keyboardControl == id && Application.isFocused;
					if (flag7)
					{
						flag = true;
					}
				}
			}
			bool flag8 = flag;
			if (flag8)
			{
				editor.keyboardOnScreen = TouchScreenKeyboard.Open(secureText ?? content.text, TouchScreenKeyboardType.Default, true, multiline, secureText != null);
			}
			GUI.HandleTextFieldEventForDesktop(position, id, content, multiline, maxLength, style, editor);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000084D0 File Offset: 0x000066D0
		public static bool Toggle(Rect position, bool value, string text)
		{
			return GUI.Toggle(position, value, GUIContent.Temp(text), GUI.s_Skin.toggle);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000084FC File Offset: 0x000066FC
		public static bool Toggle(Rect position, bool value, Texture image)
		{
			return GUI.Toggle(position, value, GUIContent.Temp(image), GUI.s_Skin.toggle);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00008528 File Offset: 0x00006728
		public static bool Toggle(Rect position, bool value, GUIContent content)
		{
			return GUI.Toggle(position, value, content, GUI.s_Skin.toggle);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000854C File Offset: 0x0000674C
		public static bool Toggle(Rect position, bool value, string text, GUIStyle style)
		{
			return GUI.Toggle(position, value, GUIContent.Temp(text), style);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000856C File Offset: 0x0000676C
		public static bool Toggle(Rect position, bool value, Texture image, GUIStyle style)
		{
			return GUI.Toggle(position, value, GUIContent.Temp(image), style);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000858C File Offset: 0x0000678C
		public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoToggle(position, GUIUtility.GetControlID(GUI.s_ToggleHash, FocusType.Passive, position), value, content, style);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000085BC File Offset: 0x000067BC
		public static bool Toggle(Rect position, int id, bool value, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoToggle(position, id, value, content, style);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000085E0 File Offset: 0x000067E0
		public static int Toolbar(Rect position, int selected, Il2CppStringArray texts)
		{
			return GUI.Toolbar(position, selected, GUIContent.Temp(texts), GUI.s_Skin.button);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000860C File Offset: 0x0000680C
		public static int Toolbar(Rect position, int selected, Il2CppReferenceArray<Texture> images)
		{
			return GUI.Toolbar(position, selected, GUIContent.Temp(images), GUI.s_Skin.button);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00008638 File Offset: 0x00006838
		public static int Toolbar(Rect position, int selected, Il2CppReferenceArray<GUIContent> contents)
		{
			return GUI.Toolbar(position, selected, contents, GUI.s_Skin.button);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000865C File Offset: 0x0000685C
		public static int Toolbar(Rect position, int selected, Il2CppStringArray texts, GUIStyle style)
		{
			return GUI.Toolbar(position, selected, GUIContent.Temp(texts), style);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000867C File Offset: 0x0000687C
		public static int Toolbar(Rect position, int selected, Il2CppReferenceArray<Texture> images, GUIStyle style)
		{
			return GUI.Toolbar(position, selected, GUIContent.Temp(images), style);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000869C File Offset: 0x0000689C
		public static int Toolbar(Rect position, int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style)
		{
			return GUI.Toolbar(position, selected, contents, null, style, GUI.ToolbarButtonSize.Fixed, null);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000086BC File Offset: 0x000068BC
		public static int Toolbar(Rect position, int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style, GUI.ToolbarButtonSize buttonSize)
		{
			return GUI.Toolbar(position, selected, contents, null, style, buttonSize, null);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000086DC File Offset: 0x000068DC
		public static int Toolbar(Rect position, int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStringArray controlNames, GUIStyle style, GUI.ToolbarButtonSize buttonSize, [Optional] Il2CppStructArray<bool> contentsEnabled)
		{
			GUIUtility.CheckOnGUI();
			GUIStyle guistyle;
			GUIStyle guistyle2;
			GUIStyle guistyle3;
			GUI.FindStyles(ref style, out guistyle, out guistyle2, out guistyle3, "left", "mid", "right");
			return GUI.DoButtonGrid(position, selected, contents, controlNames, contents.Length, style, guistyle, guistyle2, guistyle3, buttonSize, contentsEnabled);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000872C File Offset: 0x0000692C
		public static int SelectionGrid(Rect position, int selected, Il2CppStringArray texts, int xCount)
		{
			return GUI.SelectionGrid(position, selected, GUIContent.Temp(texts), xCount, null);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00008750 File Offset: 0x00006950
		public static int SelectionGrid(Rect position, int selected, Il2CppReferenceArray<Texture> images, int xCount)
		{
			return GUI.SelectionGrid(position, selected, GUIContent.Temp(images), xCount, null);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00008774 File Offset: 0x00006974
		public static int SelectionGrid(Rect position, int selected, Il2CppReferenceArray<GUIContent> content, int xCount)
		{
			return GUI.SelectionGrid(position, selected, content, xCount, null);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00008790 File Offset: 0x00006990
		public static int SelectionGrid(Rect position, int selected, Il2CppStringArray texts, int xCount, GUIStyle style)
		{
			return GUI.SelectionGrid(position, selected, GUIContent.Temp(texts), xCount, style);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000087B4 File Offset: 0x000069B4
		public static int SelectionGrid(Rect position, int selected, Il2CppReferenceArray<Texture> images, int xCount, GUIStyle style)
		{
			return GUI.SelectionGrid(position, selected, GUIContent.Temp(images), xCount, style);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000087D8 File Offset: 0x000069D8
		public static int SelectionGrid(Rect position, int selected, Il2CppReferenceArray<GUIContent> contents, int xCount, GUIStyle style)
		{
			bool flag = style == null;
			if (flag)
			{
				style = GUI.s_Skin.button;
			}
			return GUI.DoButtonGrid(position, selected, contents, null, xCount, style, style, style, style, GUI.ToolbarButtonSize.Fixed, null);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00008814 File Offset: 0x00006A14
		public static void FindStyles(ref GUIStyle style, out GUIStyle firstStyle, out GUIStyle midStyle, out GUIStyle lastStyle, string first, string mid, string last)
		{
			bool flag = style == null;
			if (flag)
			{
				style = GUI.skin.button;
			}
			string name = style.name;
			midStyle = GUI.skin.FindStyle(String.Concat(name, mid)) ?? style;
			firstStyle = GUI.skin.FindStyle(String.Concat(name, first)) ?? midStyle;
			lastStyle = GUI.skin.FindStyle(String.Concat(name, last)) ?? midStyle;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00008890 File Offset: 0x00006A90
		public static int CalcTotalHorizSpacing(int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle)
		{
			bool flag = xCount < 2;
			int num;
			if (flag)
			{
				num = 0;
			}
			else
			{
				bool flag2 = xCount == 2;
				if (flag2)
				{
					num = Mathf.Max(firstStyle.margin.right, lastStyle.margin.left);
				}
				else
				{
					int num2 = Mathf.Max(midStyle.margin.left, midStyle.margin.right);
					num = Mathf.Max(firstStyle.margin.right, midStyle.margin.left) + Mathf.Max(midStyle.margin.right, lastStyle.margin.left) + num2 * (xCount - 3);
				}
			}
			return num;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00008934 File Offset: 0x00006B34
		public static bool DoToggle(Rect position, int id, bool value, GUIContent content, GUIStyle style)
		{
			return GUI.DoControl(position, id, value, position.Contains(Event.current.mousePosition), content, style);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000024D7 File Offset: 0x000006D7
		public static Il2CppStructArray<Rect> CalcGridRectsFixedWidthFixedMargin(Rect position, int itemCount, int itemsPerRow, float elemWidth, float elemHeight, float spacingHorizontal, float spacingVertical)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000024E4 File Offset: 0x000006E4
		public static int DoButtonGrid(Rect position, int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStringArray controlNames, int itemsPerRow, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, GUI.ToolbarButtonSize buttonSize, [Optional] Il2CppStructArray<bool> contentsEnabled)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000024F1 File Offset: 0x000006F1
		public static Il2CppStructArray<Rect> CalcGridRects(Rect position, Il2CppReferenceArray<GUIContent> contents, int xCount, float elemWidth, float elemHeight, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, GUI.ToolbarButtonSize buttonSize)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00008964 File Offset: 0x00006B64
		public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue)
		{
			return GUI.Slider(position, value, 0f, leftValue, rightValue, GUI.skin.horizontalSlider, GUI.skin.horizontalSliderThumb, true, 0, GUI.skin.horizontalSliderThumbExtent);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000089A4 File Offset: 0x00006BA4
		public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb)
		{
			return GUI.Slider(position, value, 0f, leftValue, rightValue, slider, thumb, true, 0, null);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000089CC File Offset: 0x00006BCC
		public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle thumbExtent)
		{
			return GUI.Slider(position, value, 0f, leftValue, rightValue, slider, thumb, true, 0, (thumbExtent == null && thumb == GUI.skin.horizontalSliderThumb) ? GUI.skin.horizontalSliderThumbExtent : thumbExtent);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00008A14 File Offset: 0x00006C14
		public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue)
		{
			return GUI.Slider(position, value, 0f, topValue, bottomValue, GUI.skin.verticalSlider, GUI.skin.verticalSliderThumb, false, 0, GUI.skin.verticalSliderThumbExtent);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00008A54 File Offset: 0x00006C54
		public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue, GUIStyle slider, GUIStyle thumb)
		{
			return GUI.Slider(position, value, 0f, topValue, bottomValue, slider, thumb, false, 0, null);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00008A7C File Offset: 0x00006C7C
		public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue, GUIStyle slider, GUIStyle thumb, GUIStyle thumbExtent)
		{
			return GUI.Slider(position, value, 0f, topValue, bottomValue, slider, thumb, false, 0, (thumbExtent == null && thumb == GUI.skin.verticalSliderThumb) ? GUI.skin.verticalSliderThumbExtent : thumbExtent);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000024FE File Offset: 0x000006FE
		public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, [Optional] GUIStyle thumbExtent)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00008AC4 File Offset: 0x00006CC4
		public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue)
		{
			return GUI.Scroller(position, value, size, leftValue, rightValue, GUI.skin.horizontalScrollbar, GUI.skin.horizontalScrollbarThumb, GUI.skin.horizontalScrollbarLeftButton, GUI.skin.horizontalScrollbarRightButton, true);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00008B0C File Offset: 0x00006D0C
		public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style)
		{
			return GUI.Scroller(position, value, size, leftValue, rightValue, style, GUI.skin.GetStyle(String.Concat(style.name, "thumb")), GUI.skin.GetStyle(String.Concat(style.name, "leftbutton")), GUI.skin.GetStyle(String.Concat(style.name, "rightbutton")), true);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000250B File Offset: 0x0000070B
		public static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00008B80 File Offset: 0x00006D80
		public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue)
		{
			return GUI.Scroller(position, value, size, topValue, bottomValue, GUI.skin.verticalScrollbar, GUI.skin.verticalScrollbarThumb, GUI.skin.verticalScrollbarUpButton, GUI.skin.verticalScrollbarDownButton, false);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00008BC8 File Offset: 0x00006DC8
		public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style)
		{
			return GUI.Scroller(position, value, size, topValue, bottomValue, style, GUI.skin.GetStyle(String.Concat(style.name, "thumb")), GUI.skin.GetStyle(String.Concat(style.name, "upbutton")), GUI.skin.GetStyle(String.Concat(style.name, "downbutton")), false);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002518 File Offset: 0x00000718
		public static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002525 File Offset: 0x00000725
		public static void BeginClip(Rect position, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
			GUIUtility.CheckOnGUI();
			GUIClip.Push(position, scrollOffset, renderOffset, resetOffset);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002538 File Offset: 0x00000738
		public static void BeginGroup(Rect position)
		{
			GUI.BeginGroup(position, GUIContent.none, GUIStyle.none);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000254C File Offset: 0x0000074C
		public static void BeginGroup(Rect position, string text)
		{
			GUI.BeginGroup(position, GUIContent.Temp(text), GUIStyle.none);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002561 File Offset: 0x00000761
		public static void BeginGroup(Rect position, Texture image)
		{
			GUI.BeginGroup(position, GUIContent.Temp(image), GUIStyle.none);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002576 File Offset: 0x00000776
		public static void BeginGroup(Rect position, GUIContent content)
		{
			GUI.BeginGroup(position, content, GUIStyle.none);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002586 File Offset: 0x00000786
		public static void BeginGroup(Rect position, GUIStyle style)
		{
			GUI.BeginGroup(position, GUIContent.none, style);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002596 File Offset: 0x00000796
		public static void BeginGroup(Rect position, string text, GUIStyle style)
		{
			GUI.BeginGroup(position, GUIContent.Temp(text), style);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000025A7 File Offset: 0x000007A7
		public static void BeginGroup(Rect position, Texture image, GUIStyle style)
		{
			GUI.BeginGroup(position, GUIContent.Temp(image), style);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000025B8 File Offset: 0x000007B8
		public static void BeginGroup(Rect position, GUIContent content, GUIStyle style)
		{
			GUI.BeginGroup(position, content, style, Vector2.zero);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00008C3C File Offset: 0x00006E3C
		public static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset)
		{
			GUIUtility.CheckOnGUI();
			int controlID = GUIUtility.GetControlID(GUI.s_BeginGroupHash, FocusType.Passive);
			bool flag = content != GUIContent.none || style != GUIStyle.none;
			if (flag)
			{
				EventType type = Event.current.type;
				EventType eventType = type;
				if (eventType != EventType.Repaint)
				{
					bool flag2 = position.Contains(Event.current.mousePosition);
					if (flag2)
					{
						GUIUtility.mouseUsed = true;
					}
				}
				else
				{
					style.Draw(position, content, controlID);
				}
			}
			GUIClip.Push(position, scrollOffset, Vector2.zero, false);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000025C9 File Offset: 0x000007C9
		public static void EndGroup()
		{
			GUIUtility.CheckOnGUI();
			GUIClip.Internal_Pop();
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000025D8 File Offset: 0x000007D8
		public static void BeginClip(Rect position)
		{
			GUIUtility.CheckOnGUI();
			GUIClip.Push(position, Vector2.zero, Vector2.zero, false);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000025F3 File Offset: 0x000007F3
		public static void EndClip()
		{
			GUIUtility.CheckOnGUI();
			GUIClip.Pop();
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00008CC8 File Offset: 0x00006EC8
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, false, false, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00008D04 File Offset: 0x00006F04
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00008D40 File Offset: 0x00006F40
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, false, false, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00008D6C File Offset: 0x00006F6C
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00008D98 File Offset: 0x00006F98
		public static Vector2 DoBeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000260A File Offset: 0x0000080A
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002617 File Offset: 0x00000817
		public static void EndScrollView()
		{
			GUI.EndScrollView(true);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002621 File Offset: 0x00000821
		public static void EndScrollView(bool handleScrollWheel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00008DBC File Offset: 0x00006FBC
		public static ScrollViewState GetTopScrollView()
		{
			bool flag = GUI.scrollViewStates.Count != 0;
			ScrollViewState scrollViewState;
			if (flag)
			{
				scrollViewState = GUI.scrollViewStates.Peek().Cast<ScrollViewState>();
			}
			else
			{
				scrollViewState = null;
			}
			return scrollViewState;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00008DF4 File Offset: 0x00006FF4
		public static void ScrollTo(Rect position)
		{
			ScrollViewState topScrollView = GUI.GetTopScrollView();
			if (topScrollView != null)
			{
				topScrollView.ScrollTo(position);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00008E18 File Offset: 0x00007018
		public static bool ScrollTowards(Rect position, float maxDelta)
		{
			ScrollViewState topScrollView = GUI.GetTopScrollView();
			bool flag = topScrollView == null;
			return !flag && topScrollView.ScrollTowards(position, maxDelta);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00008E44 File Offset: 0x00007044
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, string text)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, GUIContent.Temp(text), GUI.skin.window, GUI.skin, true);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00008E7C File Offset: 0x0000707C
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, Texture image)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, GUIContent.Temp(image), GUI.skin.window, GUI.skin, true);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00008EB4 File Offset: 0x000070B4
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, content, GUI.skin.window, GUI.skin, true);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00008EE8 File Offset: 0x000070E8
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, string text, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, GUIContent.Temp(text), style, GUI.skin, true);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00008F18 File Offset: 0x00007118
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, Texture image, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, GUIContent.Temp(image), style, GUI.skin, true);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00008F48 File Offset: 0x00007148
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, title, style, GUI.skin, true);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00008F74 File Offset: 0x00007174
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, string text)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, GUIContent.Temp(text), GUI.skin.window, GUI.skin);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00008FAC File Offset: 0x000071AC
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, Texture image)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, GUIContent.Temp(image), GUI.skin.window, GUI.skin);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00008FE4 File Offset: 0x000071E4
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, content, GUI.skin.window, GUI.skin);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00009014 File Offset: 0x00007214
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, string text, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, GUIContent.Temp(text), style, GUI.skin);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00009044 File Offset: 0x00007244
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, Texture image, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, GUIContent.Temp(image), style, GUI.skin);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00009074 File Offset: 0x00007274
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, content, style, GUI.skin);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000909C File Offset: 0x0000729C
		public static Rect DoWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout)
		{
			return GUI.Internal_DoWindow(id, GUIUtility.s_OriginalID, clientRect, func, title, style, skin, forceRectOnLayout);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000090C4 File Offset: 0x000072C4
		public static Rect DoModalWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUISkin skin)
		{
			return GUI.Internal_DoModalWindow(id, GUIUtility.s_OriginalID, clientRect, func, content, style, skin);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000262E File Offset: 0x0000082E
		public static void DragWindow()
		{
			GUI.DragWindow(new Rect(0f, 0f, 10000f, 10000f));
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000090E8 File Offset: 0x000072E8
		public static void BeginWindows(int skinMode, int editorWindowInstanceID)
		{
			GUILayoutGroup topLevel = GUILayoutUtility.current.topLevel;
			GenericStack layoutGroups = GUILayoutUtility.current.layoutGroups;
			GUILayoutGroup windows = GUILayoutUtility.current.windows;
			Matrix4x4 matrix = GUI.matrix;
			GUI.Internal_BeginWindows();
			GUI.matrix = matrix;
			GUILayoutUtility.current.topLevel = topLevel;
			GUILayoutUtility.current.layoutGroups = layoutGroups;
			GUILayoutUtility.current.windows = windows;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000914C File Offset: 0x0000734C
		public static void EndWindows()
		{
			GUILayoutGroup topLevel = GUILayoutUtility.current.topLevel;
			GenericStack layoutGroups = GUILayoutUtility.current.layoutGroups;
			GUILayoutGroup windows = GUILayoutUtility.current.windows;
			GUI.Internal_EndWindows();
			GUILayoutUtility.current.topLevel = topLevel;
			GUILayoutUtility.current.layoutGroups = layoutGroups;
			GUILayoutUtility.current.windows = windows;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000091A4 File Offset: 0x000073A4
		public static void Internal_DoModalWindow_Injected(int id, int instanceID, ref Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, Object skin, out Rect ret)
		{
			GUI.Internal_DoModalWindow_InjectedDelegateField(id, instanceID, ref clientRect, IL2CPP.Il2CppObjectBaseToPtr(func), IL2CPP.Il2CppObjectBaseToPtr(content), IL2CPP.Il2CppObjectBaseToPtr(style), IL2CPP.Il2CppObjectBaseToPtr(skin), out ret);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000091DC File Offset: 0x000073DC
		public static void Internal_DoWindow_Injected(int id, int instanceID, ref Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, Object skin, bool forceRectOnLayout, out Rect ret)
		{
			GUI.Internal_DoWindow_InjectedDelegateField(id, instanceID, ref clientRect, IL2CPP.Il2CppObjectBaseToPtr(func), IL2CPP.Il2CppObjectBaseToPtr(title), IL2CPP.Il2CppObjectBaseToPtr(style), IL2CPP.Il2CppObjectBaseToPtr(skin), forceRectOnLayout, out ret);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002650 File Offset: 0x00000850
		public static void DragWindow_Injected(ref Rect position)
		{
			GUI.DragWindow_InjectedDelegateField(ref position);
		}

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_s_HotTextField;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_s_BoxHash;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_s_ButonHash;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_s_RepeatButtonHash;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_s_ToggleHash;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_s_ButtonGridHash;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_s_SliderHash;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr_s_BeginGroupHash;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_s_ScrollviewHash;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr__nextScrollStepTime_k__BackingField;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_s_Skin;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_s_ToolTipRect;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr__scrollViewStates_k__BackingField;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_Static_get_Color_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_get_backgroundColor_Public_Static_get_Color_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_set_backgroundColor_Public_Static_set_Void_Color_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_get_contentColor_Public_Static_get_Color_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_set_contentColor_Public_Static_set_Void_Color_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_get_changed_Public_Static_get_Boolean_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_set_changed_Public_Static_set_Void_Boolean_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_Static_set_Void_Boolean_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_GrabMouseControl_Internal_Static_Void_Int32_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_HasMouseControl_Internal_Static_Boolean_Int32_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseMouseControl_Internal_Static_Void_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_set_nextScrollStepTime_Internal_Static_set_Void_DateTime_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_set_skin_Public_Static_set_Void_GUISkin_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_get_skin_Public_Static_get_GUISkin_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_DoSetSkin_Internal_Static_Void_GUISkin_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_get_matrix_Public_Static_get_Matrix4x4_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_set_matrix_Public_Static_set_Void_Matrix4x4_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_Label_Public_Static_Void_Rect_String_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_Label_Public_Static_Void_Rect_String_GUIStyle_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_Label_Public_Static_Void_Rect_GUIContent_GUIStyle_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_Box_Public_Static_Void_Rect_String_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_Box_Public_Static_Void_Rect_GUIContent_GUIStyle_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_Button_Public_Static_Boolean_Rect_String_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_Button_Public_Static_Boolean_Rect_GUIContent_GUIStyle_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_Button_Internal_Static_Boolean_Rect_Int32_GUIContent_GUIStyle_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_DoControl_Internal_Static_Boolean_Rect_Int32_Boolean_Boolean_GUIContent_GUIStyle_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_DoLabel_Private_Static_Void_Rect_GUIContent_GUIStyle_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_DoButton_Internal_Static_Boolean_Rect_Int32_GUIContent_GUIStyle_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollViewStates_Internal_Static_get_GenericStack_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_CallWindowDelegate_Internal_Static_Void_WindowFunction_Int32_Int32_GUISkin_Int32_Single_Single_GUIStyle_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_get_backgroundColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_set_backgroundColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_get_contentColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_set_contentColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x040000BB RID: 187
		public const float s_ScrollStepSize = 10f;

		// Token: 0x040000BC RID: 188
		private static readonly GUI.get_depthDelegate get_depthDelegateField;

		// Token: 0x040000BD RID: 189
		private static readonly GUI.set_depthDelegate set_depthDelegateField;

		// Token: 0x040000BE RID: 190
		private static readonly GUI.get_usePageScrollbarsDelegate get_usePageScrollbarsDelegateField;

		// Token: 0x040000BF RID: 191
		private static readonly GUI.get_isInsideListDelegate get_isInsideListDelegateField;

		// Token: 0x040000C0 RID: 192
		private static readonly GUI.set_isInsideListDelegate set_isInsideListDelegateField;

		// Token: 0x040000C1 RID: 193
		private static readonly GUI.get_blendMaterialDelegate get_blendMaterialDelegateField;

		// Token: 0x040000C2 RID: 194
		private static readonly GUI.get_blitMaterialDelegate get_blitMaterialDelegateField;

		// Token: 0x040000C3 RID: 195
		private static readonly GUI.get_roundedRectMaterialDelegate get_roundedRectMaterialDelegateField;

		// Token: 0x040000C4 RID: 196
		private static readonly GUI.get_roundedRectWithColorPerBorderMaterialDelegate get_roundedRectWithColorPerBorderMaterialDelegateField;

		// Token: 0x040000C5 RID: 197
		private static readonly GUI.SetNextControlNameDelegate SetNextControlNameDelegateField;

		// Token: 0x040000C6 RID: 198
		private static readonly GUI.GetNameOfFocusedControlDelegate GetNameOfFocusedControlDelegateField;

		// Token: 0x040000C7 RID: 199
		private static readonly GUI.FocusControlDelegate FocusControlDelegateField;

		// Token: 0x040000C8 RID: 200
		private static readonly GUI.InternalRepaintEditorWindowDelegate InternalRepaintEditorWindowDelegateField;

		// Token: 0x040000C9 RID: 201
		private static readonly GUI.Internal_GetTooltipDelegate Internal_GetTooltipDelegateField;

		// Token: 0x040000CA RID: 202
		private static readonly GUI.Internal_SetTooltipDelegate Internal_SetTooltipDelegateField;

		// Token: 0x040000CB RID: 203
		private static readonly GUI.Internal_GetMouseTooltipDelegate Internal_GetMouseTooltipDelegateField;

		// Token: 0x040000CC RID: 204
		private static readonly GUI.BringWindowToFrontDelegate BringWindowToFrontDelegateField;

		// Token: 0x040000CD RID: 205
		private static readonly GUI.BringWindowToBackDelegate BringWindowToBackDelegateField;

		// Token: 0x040000CE RID: 206
		private static readonly GUI.FocusWindowDelegate FocusWindowDelegateField;

		// Token: 0x040000CF RID: 207
		private static readonly GUI.UnfocusWindowDelegate UnfocusWindowDelegateField;

		// Token: 0x040000D0 RID: 208
		private static readonly GUI.Internal_BeginWindowsDelegate Internal_BeginWindowsDelegateField;

		// Token: 0x040000D1 RID: 209
		private static readonly GUI.Internal_EndWindowsDelegate Internal_EndWindowsDelegateField;

		// Token: 0x040000D2 RID: 210
		private static readonly GUI.Internal_ConcatenateDelegate Internal_ConcatenateDelegateField;

		// Token: 0x040000D3 RID: 211
		private static readonly GUI.Internal_DoModalWindow_InjectedDelegate Internal_DoModalWindow_InjectedDelegateField;

		// Token: 0x040000D4 RID: 212
		private static readonly GUI.Internal_DoWindow_InjectedDelegate Internal_DoWindow_InjectedDelegateField;

		// Token: 0x040000D5 RID: 213
		private static readonly GUI.DragWindow_InjectedDelegate DragWindow_InjectedDelegateField;

		// Token: 0x0200003A RID: 58
		public sealed class WindowFunction : MulticastDelegate
		{
			// Token: 0x060006A1 RID: 1697 RVA: 0x00004DC9 File Offset: 0x00002FC9
			// Note: this type is marked as 'beforefieldinit'.
			static WindowFunction()
			{
				Il2CppClassPointerStore<GUI.WindowFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GUI>.NativeClassPtr, "WindowFunction");
				GUI.WindowFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI.WindowFunction>.NativeClassPtr, 100663398);
				GUI.WindowFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI.WindowFunction>.NativeClassPtr, 100663399);
			}

			// Token: 0x060006A2 RID: 1698 RVA: 0x0001781C File Offset: 0x00015A1C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 677799, RefRangeEnd = 677853, XrefRangeStart = 677799, XrefRangeEnd = 677853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WindowFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUI.WindowFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.WindowFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006A3 RID: 1699 RVA: 0x00017878 File Offset: 0x00015A78
			[CallerCount(0)]
			public unsafe void Invoke(int id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.WindowFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006A4 RID: 1700 RVA: 0x00004E07 File Offset: 0x00003007
			public WindowFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060006A5 RID: 1701 RVA: 0x00004E10 File Offset: 0x00003010
			public static implicit operator GUI.WindowFunction(Action<int> A_0)
			{
				return DelegateSupport.ConvertDelegate<GUI.WindowFunction>(A_0);
			}

			// Token: 0x060006A6 RID: 1702 RVA: 0x00004E18 File Offset: 0x00003018
			public static GUI.WindowFunction operator +(GUI.WindowFunction A_0, GUI.WindowFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<GUI.WindowFunction>();
			}

			// Token: 0x060006A7 RID: 1703 RVA: 0x00004E26 File Offset: 0x00003026
			public static GUI.WindowFunction operator -(GUI.WindowFunction A_0, GUI.WindowFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<GUI.WindowFunction>();
				}
				return delegate2;
			}

			// Token: 0x04000392 RID: 914
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000393 RID: 915
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0;
		}

		// Token: 0x0200003B RID: 59
		public enum ToolbarButtonSize
		{
			// Token: 0x04000395 RID: 917
			Fixed,
			// Token: 0x04000396 RID: 918
			FitToContents
		}

		// Token: 0x0200003C RID: 60
		public abstract class Scope
		{
		}

		// Token: 0x0200003D RID: 61
		public class GroupScope : GUI.Scope
		{
		}

		// Token: 0x0200003E RID: 62
		public class ScrollViewScope : GUI.Scope
		{
		}

		// Token: 0x0200003F RID: 63
		public class ClipScope : GUI.Scope
		{
		}

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x060006A9 RID: 1705
		private delegate int get_depthDelegate();

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x060006AB RID: 1707
		private delegate void set_depthDelegate(int value);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x060006AD RID: 1709
		private delegate bool get_usePageScrollbarsDelegate();

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x060006AF RID: 1711
		private delegate bool get_isInsideListDelegate();

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x060006B1 RID: 1713
		private delegate void set_isInsideListDelegate(bool value);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x060006B3 RID: 1715
		private delegate IntPtr get_blendMaterialDelegate();

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x060006B5 RID: 1717
		private delegate IntPtr get_blitMaterialDelegate();

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x060006B7 RID: 1719
		private delegate IntPtr get_roundedRectMaterialDelegate();

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x060006B9 RID: 1721
		private delegate IntPtr get_roundedRectWithColorPerBorderMaterialDelegate();

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x060006BB RID: 1723
		private delegate void SetNextControlNameDelegate(IntPtr name);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x060006BD RID: 1725
		private delegate IntPtr GetNameOfFocusedControlDelegate();

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x060006BF RID: 1727
		private delegate void FocusControlDelegate(IntPtr name);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x060006C1 RID: 1729
		private delegate void InternalRepaintEditorWindowDelegate();

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x060006C3 RID: 1731
		private delegate IntPtr Internal_GetTooltipDelegate();

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x060006C5 RID: 1733
		private delegate void Internal_SetTooltipDelegate(IntPtr value);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x060006C7 RID: 1735
		private delegate IntPtr Internal_GetMouseTooltipDelegate();

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x060006C9 RID: 1737
		private delegate void BringWindowToFrontDelegate(int windowID);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x060006CB RID: 1739
		private delegate void BringWindowToBackDelegate(int windowID);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x060006CD RID: 1741
		private delegate void FocusWindowDelegate(int windowID);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x060006CF RID: 1743
		private delegate void UnfocusWindowDelegate();

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x060006D1 RID: 1745
		private delegate void Internal_BeginWindowsDelegate();

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x060006D3 RID: 1747
		private delegate void Internal_EndWindowsDelegate();

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x060006D5 RID: 1749
		private delegate IntPtr Internal_ConcatenateDelegate(IntPtr first, IntPtr second);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x060006D7 RID: 1751
		private delegate void Internal_DoModalWindow_InjectedDelegate(int id, int instanceID, IntPtr clientRect, IntPtr func, IntPtr content, IntPtr style, IntPtr skin, [Out] IntPtr ret);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x060006D9 RID: 1753
		private delegate void Internal_DoWindow_InjectedDelegate(int id, int instanceID, IntPtr clientRect, IntPtr func, IntPtr title, IntPtr style, IntPtr skin, bool forceRectOnLayout, [Out] IntPtr ret);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x060006DB RID: 1755
		private delegate void DragWindow_InjectedDelegate(IntPtr position);
	}
}
