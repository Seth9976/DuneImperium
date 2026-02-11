using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x0200002D RID: 45
	public class TMP_Dropdown : Selectable
	{
		// Token: 0x060003FD RID: 1021 RVA: 0x000168C8 File Offset: 0x00014AC8
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Dropdown()
		{
			Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Dropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr);
			TMP_Dropdown.NativeFieldInfoPtr_m_Template = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_Template");
			TMP_Dropdown.NativeFieldInfoPtr_m_CaptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_CaptionText");
			TMP_Dropdown.NativeFieldInfoPtr_m_CaptionImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_CaptionImage");
			TMP_Dropdown.NativeFieldInfoPtr_m_Placeholder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_Placeholder");
			TMP_Dropdown.NativeFieldInfoPtr_m_ItemText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_ItemText");
			TMP_Dropdown.NativeFieldInfoPtr_m_ItemImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_ItemImage");
			TMP_Dropdown.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_Value");
			TMP_Dropdown.NativeFieldInfoPtr_m_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_Options");
			TMP_Dropdown.NativeFieldInfoPtr_m_OnValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_OnValueChanged");
			TMP_Dropdown.NativeFieldInfoPtr_m_AlphaFadeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_AlphaFadeSpeed");
			TMP_Dropdown.NativeFieldInfoPtr_m_Dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_Dropdown");
			TMP_Dropdown.NativeFieldInfoPtr_m_Blocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_Blocker");
			TMP_Dropdown.NativeFieldInfoPtr_m_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_Items");
			TMP_Dropdown.NativeFieldInfoPtr_m_AlphaTweenRunner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_AlphaTweenRunner");
			TMP_Dropdown.NativeFieldInfoPtr_validTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "validTemplate");
			TMP_Dropdown.NativeFieldInfoPtr_m_Coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "m_Coroutine");
			TMP_Dropdown.NativeFieldInfoPtr_s_NoOptionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "s_NoOptionData");
			TMP_Dropdown.NativeMethodInfoPtr_get_template_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663681);
			TMP_Dropdown.NativeMethodInfoPtr_set_template_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663682);
			TMP_Dropdown.NativeMethodInfoPtr_get_captionText_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663683);
			TMP_Dropdown.NativeMethodInfoPtr_set_captionText_Public_set_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663684);
			TMP_Dropdown.NativeMethodInfoPtr_get_captionImage_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663685);
			TMP_Dropdown.NativeMethodInfoPtr_set_captionImage_Public_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663686);
			TMP_Dropdown.NativeMethodInfoPtr_get_placeholder_Public_get_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663687);
			TMP_Dropdown.NativeMethodInfoPtr_set_placeholder_Public_set_Void_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663688);
			TMP_Dropdown.NativeMethodInfoPtr_get_itemText_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663689);
			TMP_Dropdown.NativeMethodInfoPtr_set_itemText_Public_set_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663690);
			TMP_Dropdown.NativeMethodInfoPtr_get_itemImage_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663691);
			TMP_Dropdown.NativeMethodInfoPtr_set_itemImage_Public_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663692);
			TMP_Dropdown.NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663693);
			TMP_Dropdown.NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663694);
			TMP_Dropdown.NativeMethodInfoPtr_get_onValueChanged_Public_get_DropdownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663695);
			TMP_Dropdown.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_DropdownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663696);
			TMP_Dropdown.NativeMethodInfoPtr_get_alphaFadeSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663697);
			TMP_Dropdown.NativeMethodInfoPtr_set_alphaFadeSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663698);
			TMP_Dropdown.NativeMethodInfoPtr_get_value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663699);
			TMP_Dropdown.NativeMethodInfoPtr_set_value_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663700);
			TMP_Dropdown.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663701);
			TMP_Dropdown.NativeMethodInfoPtr_SetValue_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663702);
			TMP_Dropdown.NativeMethodInfoPtr_get_IsExpanded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663703);
			TMP_Dropdown.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663704);
			TMP_Dropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663705);
			TMP_Dropdown.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663706);
			TMP_Dropdown.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663707);
			TMP_Dropdown.NativeMethodInfoPtr_RefreshShownValue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663708);
			TMP_Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663709);
			TMP_Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663710);
			TMP_Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663711);
			TMP_Dropdown.NativeMethodInfoPtr_ClearOptions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663712);
			TMP_Dropdown.NativeMethodInfoPtr_SetupTemplate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663713);
			TMP_Dropdown.NativeMethodInfoPtr_GetOrAddComponent_Private_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663714);
			TMP_Dropdown.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663715);
			TMP_Dropdown.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663716);
			TMP_Dropdown.NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663717);
			TMP_Dropdown.NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663718);
			TMP_Dropdown.NativeMethodInfoPtr_CreateBlocker_Protected_Virtual_New_GameObject_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663719);
			TMP_Dropdown.NativeMethodInfoPtr_DestroyBlocker_Protected_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663720);
			TMP_Dropdown.NativeMethodInfoPtr_CreateDropdownList_Protected_Virtual_New_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663721);
			TMP_Dropdown.NativeMethodInfoPtr_DestroyDropdownList_Protected_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663722);
			TMP_Dropdown.NativeMethodInfoPtr_CreateItem_Protected_Virtual_New_DropdownItem_DropdownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663723);
			TMP_Dropdown.NativeMethodInfoPtr_DestroyItem_Protected_Virtual_New_Void_DropdownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663724);
			TMP_Dropdown.NativeMethodInfoPtr_AddItem_Private_DropdownItem_OptionData_Boolean_DropdownItem_List_1_DropdownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663725);
			TMP_Dropdown.NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663726);
			TMP_Dropdown.NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663727);
			TMP_Dropdown.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663728);
			TMP_Dropdown.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663729);
			TMP_Dropdown.NativeMethodInfoPtr_DelayedDestroyDropdownList_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663730);
			TMP_Dropdown.NativeMethodInfoPtr_ImmediateDestroyDropdownList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663731);
			TMP_Dropdown.NativeMethodInfoPtr_OnSelectItem_Private_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, 100663732);
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00016E5C File Offset: 0x0001505C
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00016E9C File Offset: 0x0001509C
		public unsafe RectTransform template
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_template_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038781, XrefRangeEnd = 1038783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_template_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00016EE0 File Offset: 0x000150E0
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00016F20 File Offset: 0x00015120
		public unsafe TMP_Text captionText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_captionText_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038783, XrefRangeEnd = 1038785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_captionText_Public_set_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00016F64 File Offset: 0x00015164
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00016FA4 File Offset: 0x000151A4
		public unsafe Image captionImage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_captionImage_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038785, XrefRangeEnd = 1038787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_captionImage_Public_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00016FE8 File Offset: 0x000151E8
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00017028 File Offset: 0x00015228
		public unsafe Graphic placeholder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_placeholder_Public_get_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038787, XrefRangeEnd = 1038789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_placeholder_Public_set_Void_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x0001706C File Offset: 0x0001526C
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x000170AC File Offset: 0x000152AC
		public unsafe TMP_Text itemText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_itemText_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038789, XrefRangeEnd = 1038791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_itemText_Public_set_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x000170F0 File Offset: 0x000152F0
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x00017130 File Offset: 0x00015330
		public unsafe Image itemImage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_itemImage_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038791, XrefRangeEnd = 1038793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_itemImage_Public_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00017174 File Offset: 0x00015374
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x000171B4 File Offset: 0x000153B4
		public unsafe List<TMP_Dropdown.OptionData> options
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1038793, RefRangeEnd = 1038795, XrefRangeStart = 1038793, XrefRangeEnd = 1038793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_Dropdown.OptionData>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038795, XrefRangeEnd = 1038798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x000171F8 File Offset: 0x000153F8
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00017238 File Offset: 0x00015438
		public unsafe TMP_Dropdown.DropdownEvent onValueChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_onValueChanged_Public_get_DropdownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown.DropdownEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_DropdownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0001727C File Offset: 0x0001547C
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x000172B8 File Offset: 0x000154B8
		public unsafe float alphaFadeSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_alphaFadeSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_alphaFadeSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x000172F8 File Offset: 0x000154F8
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00017334 File Offset: 0x00015534
		public unsafe int value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_value_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1038799, RefRangeEnd = 1038803, XrefRangeStart = 1038798, XrefRangeEnd = 1038799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_set_value_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00017374 File Offset: 0x00015574
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1038804, RefRangeEnd = 1038806, XrefRangeStart = 1038803, XrefRangeEnd = 1038804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValueWithoutNotify(int input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x000173B4 File Offset: 0x000155B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1038822, RefRangeEnd = 1038826, XrefRangeStart = 1038806, XrefRangeEnd = 1038822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(int value, bool sendCallback = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendCallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_SetValue_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00017400 File Offset: 0x00015600
		public unsafe bool IsExpanded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038826, XrefRangeEnd = 1038830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_get_IsExpanded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0001743C File Offset: 0x0001563C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038830, XrefRangeEnd = 1038860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Dropdown()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00017478 File Offset: 0x00015678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038860, XrefRangeEnd = 1038873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000174B4 File Offset: 0x000156B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038873, XrefRangeEnd = 1038893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000174F0 File Offset: 0x000156F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038893, XrefRangeEnd = 1038900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0001752C File Offset: 0x0001572C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1038929, RefRangeEnd = 1038947, XrefRangeStart = 1038900, XrefRangeEnd = 1038929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshShownValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_RefreshShownValue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00017560 File Offset: 0x00015760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1038952, RefRangeEnd = 1038953, XrefRangeStart = 1038947, XrefRangeEnd = 1038952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOptions(List<TMP_Dropdown.OptionData> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000175A4 File Offset: 0x000157A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1038971, RefRangeEnd = 1038976, XrefRangeStart = 1038953, XrefRangeEnd = 1038971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOptions(List<string> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000175E8 File Offset: 0x000157E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038976, XrefRangeEnd = 1038994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOptions(List<Sprite> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0001762C File Offset: 0x0001582C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1039002, RefRangeEnd = 1039008, XrefRangeStart = 1038994, XrefRangeEnd = 1039002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_ClearOptions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00017660 File Offset: 0x00015860
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1039106, RefRangeEnd = 1039107, XrefRangeStart = 1039008, XrefRangeEnd = 1039106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupTemplate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_SetupTemplate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00017694 File Offset: 0x00015894
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1039114, RefRangeEnd = 1039121, XrefRangeStart = 1039107, XrefRangeEnd = 1039114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetOrAddComponent<T>(GameObject go) where T : Component
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.MethodInfoStoreGeneric_GetOrAddComponent_Private_Static_T_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x000176D4 File Offset: 0x000158D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039121, XrefRangeEnd = 1039122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00017724 File Offset: 0x00015924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00017774 File Offset: 0x00015974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039122, XrefRangeEnd = 1039123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCancel(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x000177C4 File Offset: 0x000159C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1039271, RefRangeEnd = 1039273, XrefRangeStart = 1039123, XrefRangeEnd = 1039271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x000177F8 File Offset: 0x000159F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039273, XrefRangeEnd = 1039339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject CreateBlocker(Canvas rootCanvas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootCanvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_CreateBlocker_Protected_Virtual_New_GameObject_Canvas_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00017854 File Offset: 0x00015A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039339, XrefRangeEnd = 1039343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyBlocker(GameObject blocker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(blocker);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_DestroyBlocker_Protected_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000178A4 File Offset: 0x00015AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039343, XrefRangeEnd = 1039349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject CreateDropdownList(GameObject template)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(template);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_CreateDropdownList_Protected_Virtual_New_GameObject_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00017900 File Offset: 0x00015B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039349, XrefRangeEnd = 1039353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyDropdownList(GameObject dropdownList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dropdownList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_DestroyDropdownList_Protected_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00017950 File Offset: 0x00015B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039353, XrefRangeEnd = 1039359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TMP_Dropdown.DropdownItem CreateItem(TMP_Dropdown.DropdownItem itemTemplate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemTemplate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_CreateItem_Protected_Virtual_New_DropdownItem_DropdownItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown.DropdownItem>(intPtr3) : null;
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000179AC File Offset: 0x00015BAC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyItem(TMP_Dropdown.DropdownItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.NativeMethodInfoPtr_DestroyItem_Protected_Virtual_New_Void_DropdownItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000179FC File Offset: 0x00015BFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1039397, RefRangeEnd = 1039398, XrefRangeStart = 1039359, XrefRangeEnd = 1039397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Dropdown.DropdownItem AddItem(TMP_Dropdown.OptionData data, bool selected, TMP_Dropdown.DropdownItem itemTemplate, List<TMP_Dropdown.DropdownItem> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selected;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(itemTemplate);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_AddItem_Private_DropdownItem_OptionData_Boolean_DropdownItem_List_1_DropdownItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown.DropdownItem>(intPtr3) : null;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00017A80 File Offset: 0x00015C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039398, XrefRangeEnd = 1039403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlphaFadeList(float duration, float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref duration;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00017ACC File Offset: 0x00015CCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1039414, RefRangeEnd = 1039417, XrefRangeStart = 1039403, XrefRangeEnd = 1039414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlphaFadeList(float duration, float start, float end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref duration;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00017B28 File Offset: 0x00015D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039417, XrefRangeEnd = 1039425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alpha;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00017B68 File Offset: 0x00015D68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1039445, RefRangeEnd = 1039449, XrefRangeStart = 1039425, XrefRangeEnd = 1039445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00017B9C File Offset: 0x00015D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039449, XrefRangeEnd = 1039454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedDestroyDropdownList(float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_DelayedDestroyDropdownList_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00017BE8 File Offset: 0x00015DE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1039476, RefRangeEnd = 1039478, XrefRangeStart = 1039454, XrefRangeEnd = 1039476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImmediateDestroyDropdownList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_ImmediateDestroyDropdownList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00017C1C File Offset: 0x00015E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039478, XrefRangeEnd = 1039490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSelectItem(Toggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.NativeMethodInfoPtr_OnSelectItem_Private_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00003FD8 File Offset: 0x000021D8
		public TMP_Dropdown(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x00017C60 File Offset: 0x00015E60
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00003FE1 File Offset: 0x000021E1
		public unsafe RectTransform m_Template
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Template);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Template), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00017C90 File Offset: 0x00015E90
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00004000 File Offset: 0x00002200
		public unsafe TMP_Text m_CaptionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_CaptionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_CaptionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00017CC0 File Offset: 0x00015EC0
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x0000401F File Offset: 0x0000221F
		public unsafe Image m_CaptionImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_CaptionImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_CaptionImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x00017CF0 File Offset: 0x00015EF0
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x0000403E File Offset: 0x0000223E
		public unsafe Graphic m_Placeholder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Placeholder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Placeholder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x00017D20 File Offset: 0x00015F20
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x0000405D File Offset: 0x0000225D
		public unsafe TMP_Text m_ItemText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_ItemText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_ItemText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00017D50 File Offset: 0x00015F50
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x0000407C File Offset: 0x0000227C
		public unsafe Image m_ItemImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_ItemImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_ItemImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00017D80 File Offset: 0x00015F80
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x0000409B File Offset: 0x0000229B
		public unsafe int m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Value)) = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00017DA8 File Offset: 0x00015FA8
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x000040B6 File Offset: 0x000022B6
		public unsafe TMP_Dropdown.OptionDataList m_Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown.OptionDataList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x00017DD8 File Offset: 0x00015FD8
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x000040D5 File Offset: 0x000022D5
		public unsafe TMP_Dropdown.DropdownEvent m_OnValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_OnValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown.DropdownEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_OnValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00017E08 File Offset: 0x00016008
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x000040F4 File Offset: 0x000022F4
		public unsafe float m_AlphaFadeSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_AlphaFadeSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_AlphaFadeSpeed)) = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00017E30 File Offset: 0x00016030
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x0000410F File Offset: 0x0000230F
		public unsafe GameObject m_Dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00017E60 File Offset: 0x00016060
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x0000412E File Offset: 0x0000232E
		public unsafe GameObject m_Blocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Blocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Blocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x00017E90 File Offset: 0x00016090
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x0000414D File Offset: 0x0000234D
		public unsafe List<TMP_Dropdown.DropdownItem> m_Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Dropdown.DropdownItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00017EC0 File Offset: 0x000160C0
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x0000416C File Offset: 0x0000236C
		public unsafe TweenRunner<FloatTween> m_AlphaTweenRunner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_AlphaTweenRunner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenRunner<FloatTween>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_AlphaTweenRunner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00017EF0 File Offset: 0x000160F0
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x0000418B File Offset: 0x0000238B
		public unsafe bool validTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_validTemplate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_validTemplate)) = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00017F18 File Offset: 0x00016118
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x000041A6 File Offset: 0x000023A6
		public unsafe Coroutine m_Coroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Coroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.NativeFieldInfoPtr_m_Coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x00017F48 File Offset: 0x00016148
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x000041C5 File Offset: 0x000023C5
		public unsafe static TMP_Dropdown.OptionData s_NoOptionData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Dropdown.NativeFieldInfoPtr_s_NoOptionData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown.OptionData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Dropdown.NativeFieldInfoPtr_s_NoOptionData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeFieldInfoPtr_m_Template;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeFieldInfoPtr_m_CaptionText;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeFieldInfoPtr_m_CaptionImage;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeFieldInfoPtr_m_Placeholder;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemText;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemImage;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeFieldInfoPtr_m_Options;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeFieldInfoPtr_m_OnValueChanged;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeFieldInfoPtr_m_AlphaFadeSpeed;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeFieldInfoPtr_m_Dropdown;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeFieldInfoPtr_m_Blocker;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeFieldInfoPtr_m_Items;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeFieldInfoPtr_m_AlphaTweenRunner;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeFieldInfoPtr_validTemplate;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeFieldInfoPtr_m_Coroutine;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeFieldInfoPtr_s_NoOptionData;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_get_template_Public_get_RectTransform_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_set_template_Public_set_Void_RectTransform_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_get_captionText_Public_get_TMP_Text_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_set_captionText_Public_set_Void_TMP_Text_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_get_captionImage_Public_get_Image_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_set_captionImage_Public_set_Void_Image_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_get_placeholder_Public_get_Graphic_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_set_placeholder_Public_set_Void_Graphic_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_get_itemText_Public_get_TMP_Text_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_set_itemText_Public_set_Void_TMP_Text_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr_get_itemImage_Public_get_Image_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_set_itemImage_Public_set_Void_Image_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_get_onValueChanged_Public_get_DropdownEvent_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_DropdownEvent_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_get_alphaFadeSpeed_Public_get_Single_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_set_alphaFadeSpeed_Public_set_Void_Single_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Int32_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_Int32_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Void_Int32_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Private_Void_Int32_Boolean_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_get_IsExpanded_Public_get_Boolean_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_RefreshShownValue_Public_Void_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_AddOptions_Public_Void_List_1_OptionData_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_AddOptions_Public_Void_List_1_String_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_AddOptions_Public_Void_List_1_Sprite_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_ClearOptions_Public_Void_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_SetupTemplate_Private_Void_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAddComponent_Private_Static_T_GameObject_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_CreateBlocker_Protected_Virtual_New_GameObject_Canvas_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_DestroyBlocker_Protected_Virtual_New_Void_GameObject_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_CreateDropdownList_Protected_Virtual_New_GameObject_GameObject_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_DestroyDropdownList_Protected_Virtual_New_Void_GameObject_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_CreateItem_Protected_Virtual_New_DropdownItem_DropdownItem_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Protected_Virtual_New_Void_DropdownItem_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Private_DropdownItem_OptionData_Boolean_DropdownItem_List_1_DropdownItem_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_Single_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_DelayedDestroyDropdownList_Private_IEnumerator_Single_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_ImmediateDestroyDropdownList_Private_Void_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectItem_Private_Void_Toggle_0;

		// Token: 0x02000081 RID: 129
		public class DropdownItem : MonoBehaviour
		{
			// Token: 0x06000ED8 RID: 3800 RVA: 0x0003BA18 File Offset: 0x00039C18
			// Note: this type is marked as 'beforefieldinit'.
			static DropdownItem()
			{
				Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "DropdownItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr);
				TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, "m_Text");
				TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, "m_Image");
				TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, "m_RectTransform");
				TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, "m_Toggle");
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_get_text_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100663734);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_set_text_Public_set_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100663735);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_get_image_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100663736);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_set_image_Public_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100663737);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100663738);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_set_rectTransform_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100663739);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_get_toggle_Public_get_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100663740);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_set_toggle_Public_set_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100663741);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100663742);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100663743);
				TMP_Dropdown.DropdownItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr, 100663744);
			}

			// Token: 0x1700057E RID: 1406
			// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x0003BB70 File Offset: 0x00039D70
			// (set) Token: 0x06000EDA RID: 3802 RVA: 0x0003BBB0 File Offset: 0x00039DB0
			public unsafe TMP_Text text
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_get_text_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_set_text_Public_set_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700057F RID: 1407
			// (get) Token: 0x06000EDB RID: 3803 RVA: 0x0003BBF4 File Offset: 0x00039DF4
			// (set) Token: 0x06000EDC RID: 3804 RVA: 0x0003BC34 File Offset: 0x00039E34
			public unsafe Image image
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_get_image_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_set_image_Public_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000580 RID: 1408
			// (get) Token: 0x06000EDD RID: 3805 RVA: 0x0003BC78 File Offset: 0x00039E78
			// (set) Token: 0x06000EDE RID: 3806 RVA: 0x0003BCB8 File Offset: 0x00039EB8
			public unsafe RectTransform rectTransform
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_set_rectTransform_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000581 RID: 1409
			// (get) Token: 0x06000EDF RID: 3807 RVA: 0x0003BCFC File Offset: 0x00039EFC
			// (set) Token: 0x06000EE0 RID: 3808 RVA: 0x0003BD3C File Offset: 0x00039F3C
			public unsafe Toggle toggle
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_get_toggle_Public_get_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_set_toggle_Public_set_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000EE1 RID: 3809 RVA: 0x0003BD80 File Offset: 0x00039F80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038733, XrefRangeEnd = 1038740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void OnPointerEnter(PointerEventData eventData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000EE2 RID: 3810 RVA: 0x0003BDD0 File Offset: 0x00039FD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038740, XrefRangeEnd = 1038748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void OnCancel(BaseEventData eventData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Dropdown.DropdownItem.NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000EE3 RID: 3811 RVA: 0x0003BE20 File Offset: 0x0003A020
			[CallerCount(311)]
			[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DropdownItem()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown.DropdownItem>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EE4 RID: 3812 RVA: 0x00009075 File Offset: 0x00007275
			public DropdownItem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700057A RID: 1402
			// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x0003BE5C File Offset: 0x0003A05C
			// (set) Token: 0x06000EE6 RID: 3814 RVA: 0x0000907E File Offset: 0x0000727E
			public unsafe TMP_Text m_Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_Text);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700057B RID: 1403
			// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x0003BE8C File Offset: 0x0003A08C
			// (set) Token: 0x06000EE8 RID: 3816 RVA: 0x0000909D File Offset: 0x0000729D
			public unsafe Image m_Image
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_Image);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700057C RID: 1404
			// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x0003BEBC File Offset: 0x0003A0BC
			// (set) Token: 0x06000EEA RID: 3818 RVA: 0x000090BC File Offset: 0x000072BC
			public unsafe RectTransform m_RectTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_RectTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700057D RID: 1405
			// (get) Token: 0x06000EEB RID: 3819 RVA: 0x0003BEEC File Offset: 0x0003A0EC
			// (set) Token: 0x06000EEC RID: 3820 RVA: 0x000090DB File Offset: 0x000072DB
			public unsafe Toggle m_Toggle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_Toggle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.DropdownItem.NativeFieldInfoPtr_m_Toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000BBB RID: 3003
			private static readonly IntPtr NativeFieldInfoPtr_m_Text;

			// Token: 0x04000BBC RID: 3004
			private static readonly IntPtr NativeFieldInfoPtr_m_Image;

			// Token: 0x04000BBD RID: 3005
			private static readonly IntPtr NativeFieldInfoPtr_m_RectTransform;

			// Token: 0x04000BBE RID: 3006
			private static readonly IntPtr NativeFieldInfoPtr_m_Toggle;

			// Token: 0x04000BBF RID: 3007
			private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_TMP_Text_0;

			// Token: 0x04000BC0 RID: 3008
			private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_TMP_Text_0;

			// Token: 0x04000BC1 RID: 3009
			private static readonly IntPtr NativeMethodInfoPtr_get_image_Public_get_Image_0;

			// Token: 0x04000BC2 RID: 3010
			private static readonly IntPtr NativeMethodInfoPtr_set_image_Public_set_Void_Image_0;

			// Token: 0x04000BC3 RID: 3011
			private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;

			// Token: 0x04000BC4 RID: 3012
			private static readonly IntPtr NativeMethodInfoPtr_set_rectTransform_Public_set_Void_RectTransform_0;

			// Token: 0x04000BC5 RID: 3013
			private static readonly IntPtr NativeMethodInfoPtr_get_toggle_Public_get_Toggle_0;

			// Token: 0x04000BC6 RID: 3014
			private static readonly IntPtr NativeMethodInfoPtr_set_toggle_Public_set_Void_Toggle_0;

			// Token: 0x04000BC7 RID: 3015
			private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0;

			// Token: 0x04000BC8 RID: 3016
			private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0;

			// Token: 0x04000BC9 RID: 3017
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000082 RID: 130
		[Serializable]
		public class OptionData : global::Il2CppSystem.Object
		{
			// Token: 0x06000EED RID: 3821 RVA: 0x0003BF1C File Offset: 0x0003A11C
			// Note: this type is marked as 'beforefieldinit'.
			static OptionData()
			{
				Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "OptionData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr);
				TMP_Dropdown.OptionData.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, "m_Text");
				TMP_Dropdown.OptionData.NativeFieldInfoPtr_m_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, "m_Image");
				TMP_Dropdown.OptionData.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, 100663745);
				TMP_Dropdown.OptionData.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, 100663746);
				TMP_Dropdown.OptionData.NativeMethodInfoPtr_get_image_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, 100663747);
				TMP_Dropdown.OptionData.NativeMethodInfoPtr_set_image_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, 100663748);
				TMP_Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, 100663749);
				TMP_Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, 100663750);
				TMP_Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, 100663751);
				TMP_Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_String_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr, 100663752);
			}

			// Token: 0x17000584 RID: 1412
			// (get) Token: 0x06000EEE RID: 3822 RVA: 0x0003C010 File Offset: 0x0003A210
			// (set) Token: 0x06000EEF RID: 3823 RVA: 0x0003C048 File Offset: 0x0003A248
			public unsafe string text
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionData.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionData.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000585 RID: 1413
			// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x0003C08C File Offset: 0x0003A28C
			// (set) Token: 0x06000EF1 RID: 3825 RVA: 0x0003C0CC File Offset: 0x0003A2CC
			public unsafe Sprite image
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionData.NativeMethodInfoPtr_get_image_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionData.NativeMethodInfoPtr_set_image_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000EF2 RID: 3826 RVA: 0x0003C110 File Offset: 0x0003A310
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EF3 RID: 3827 RVA: 0x0003C14C File Offset: 0x0003A34C
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionData(string text)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000EF4 RID: 3828 RVA: 0x0003C198 File Offset: 0x0003A398
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 320067, RefRangeEnd = 320078, XrefRangeStart = 320067, XrefRangeEnd = 320078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionData(Sprite image)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000EF5 RID: 3829 RVA: 0x0003C1E4 File Offset: 0x0003A3E4
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionData(string text, Sprite image)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown.OptionData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_String_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EF6 RID: 3830 RVA: 0x000090FA File Offset: 0x000072FA
			public OptionData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000582 RID: 1410
			// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x0003C244 File Offset: 0x0003A444
			// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x00009103 File Offset: 0x00007303
			public unsafe string m_Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.OptionData.NativeFieldInfoPtr_m_Text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.OptionData.NativeFieldInfoPtr_m_Text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000583 RID: 1411
			// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x0003C26C File Offset: 0x0003A46C
			// (set) Token: 0x06000EFA RID: 3834 RVA: 0x00009122 File Offset: 0x00007322
			public unsafe Sprite m_Image
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.OptionData.NativeFieldInfoPtr_m_Image);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.OptionData.NativeFieldInfoPtr_m_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000BCA RID: 3018
			private static readonly IntPtr NativeFieldInfoPtr_m_Text;

			// Token: 0x04000BCB RID: 3019
			private static readonly IntPtr NativeFieldInfoPtr_m_Image;

			// Token: 0x04000BCC RID: 3020
			private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

			// Token: 0x04000BCD RID: 3021
			private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

			// Token: 0x04000BCE RID: 3022
			private static readonly IntPtr NativeMethodInfoPtr_get_image_Public_get_Sprite_0;

			// Token: 0x04000BCF RID: 3023
			private static readonly IntPtr NativeMethodInfoPtr_set_image_Public_set_Void_Sprite_0;

			// Token: 0x04000BD0 RID: 3024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000BD1 RID: 3025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

			// Token: 0x04000BD2 RID: 3026
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Sprite_0;

			// Token: 0x04000BD3 RID: 3027
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Sprite_0;
		}

		// Token: 0x02000083 RID: 131
		[Serializable]
		public class OptionDataList : global::Il2CppSystem.Object
		{
			// Token: 0x06000EFB RID: 3835 RVA: 0x0003C29C File Offset: 0x0003A49C
			// Note: this type is marked as 'beforefieldinit'.
			static OptionDataList()
			{
				Il2CppClassPointerStore<TMP_Dropdown.OptionDataList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "OptionDataList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Dropdown.OptionDataList>.NativeClassPtr);
				TMP_Dropdown.OptionDataList.NativeFieldInfoPtr_m_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown.OptionDataList>.NativeClassPtr, "m_Options");
				TMP_Dropdown.OptionDataList.NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionDataList>.NativeClassPtr, 100663753);
				TMP_Dropdown.OptionDataList.NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionDataList>.NativeClassPtr, 100663754);
				TMP_Dropdown.OptionDataList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.OptionDataList>.NativeClassPtr, 100663755);
			}

			// Token: 0x17000587 RID: 1415
			// (get) Token: 0x06000EFC RID: 3836 RVA: 0x0003C318 File Offset: 0x0003A518
			// (set) Token: 0x06000EFD RID: 3837 RVA: 0x0003C358 File Offset: 0x0003A558
			public unsafe List<TMP_Dropdown.OptionData> options
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionDataList.NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_Dropdown.OptionData>>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionDataList.NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000EFE RID: 3838 RVA: 0x0003C39C File Offset: 0x0003A59C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038748, XrefRangeEnd = 1038756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionDataList()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown.OptionDataList>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.OptionDataList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EFF RID: 3839 RVA: 0x00009141 File Offset: 0x00007341
			public OptionDataList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000586 RID: 1414
			// (get) Token: 0x06000F00 RID: 3840 RVA: 0x0003C3D8 File Offset: 0x0003A5D8
			// (set) Token: 0x06000F01 RID: 3841 RVA: 0x0000914A File Offset: 0x0000734A
			public unsafe List<TMP_Dropdown.OptionData> m_Options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.OptionDataList.NativeFieldInfoPtr_m_Options);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Dropdown.OptionData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.OptionDataList.NativeFieldInfoPtr_m_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000BD4 RID: 3028
			private static readonly IntPtr NativeFieldInfoPtr_m_Options;

			// Token: 0x04000BD5 RID: 3029
			private static readonly IntPtr NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0;

			// Token: 0x04000BD6 RID: 3030
			private static readonly IntPtr NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0;

			// Token: 0x04000BD7 RID: 3031
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000084 RID: 132
		[Serializable]
		public class DropdownEvent : UnityEvent<int>
		{
			// Token: 0x06000F02 RID: 3842 RVA: 0x00009169 File Offset: 0x00007369
			// Note: this type is marked as 'beforefieldinit'.
			static DropdownEvent()
			{
				Il2CppClassPointerStore<TMP_Dropdown.DropdownEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "DropdownEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Dropdown.DropdownEvent>.NativeClassPtr);
				TMP_Dropdown.DropdownEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.DropdownEvent>.NativeClassPtr, 100663756);
			}

			// Token: 0x06000F03 RID: 3843 RVA: 0x0003C408 File Offset: 0x0003A608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038756, XrefRangeEnd = 1038759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DropdownEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown.DropdownEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.DropdownEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F04 RID: 3844 RVA: 0x0000919D File Offset: 0x0000739D
			public DropdownEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000BD8 RID: 3032
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000085 RID: 133
		[ObfuscatedName("TMPro.TMP_Dropdown+<>c__DisplayClass69_0")]
		public sealed class __c__DisplayClass69_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000F05 RID: 3845 RVA: 0x0003C444 File Offset: 0x0003A644
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass69_0()
			{
				Il2CppClassPointerStore<TMP_Dropdown.__c__DisplayClass69_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "<>c__DisplayClass69_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Dropdown.__c__DisplayClass69_0>.NativeClassPtr);
				TMP_Dropdown.__c__DisplayClass69_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown.__c__DisplayClass69_0>.NativeClassPtr, "item");
				TMP_Dropdown.__c__DisplayClass69_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown.__c__DisplayClass69_0>.NativeClassPtr, "<>4__this");
				TMP_Dropdown.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.__c__DisplayClass69_0>.NativeClassPtr, 100663757);
				TMP_Dropdown.__c__DisplayClass69_0.NativeMethodInfoPtr__Show_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown.__c__DisplayClass69_0>.NativeClassPtr, 100663758);
			}

			// Token: 0x06000F06 RID: 3846 RVA: 0x0003C4C0 File Offset: 0x0003A6C0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass69_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown.__c__DisplayClass69_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F07 RID: 3847 RVA: 0x0003C4FC File Offset: 0x0003A6FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038759, XrefRangeEnd = 1038771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Show_b__0(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown.__c__DisplayClass69_0.NativeMethodInfoPtr__Show_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000F08 RID: 3848 RVA: 0x000091A6 File Offset: 0x000073A6
			public __c__DisplayClass69_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000588 RID: 1416
			// (get) Token: 0x06000F09 RID: 3849 RVA: 0x0003C53C File Offset: 0x0003A73C
			// (set) Token: 0x06000F0A RID: 3850 RVA: 0x000091AF File Offset: 0x000073AF
			public unsafe TMP_Dropdown.DropdownItem item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.__c__DisplayClass69_0.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown.DropdownItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.__c__DisplayClass69_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000589 RID: 1417
			// (get) Token: 0x06000F0B RID: 3851 RVA: 0x0003C56C File Offset: 0x0003A76C
			// (set) Token: 0x06000F0C RID: 3852 RVA: 0x000091CE File Offset: 0x000073CE
			public unsafe TMP_Dropdown __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.__c__DisplayClass69_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown.__c__DisplayClass69_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000BD9 RID: 3033
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04000BDA RID: 3034
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000BDB RID: 3035
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000BDC RID: 3036
			private static readonly IntPtr NativeMethodInfoPtr__Show_b__0_Internal_Void_Boolean_0;
		}

		// Token: 0x02000086 RID: 134
		[ObfuscatedName("TMPro.TMP_Dropdown+<DelayedDestroyDropdownList>d__81")]
		public sealed class _DelayedDestroyDropdownList_d__81 : global::Il2CppSystem.Object
		{
			// Token: 0x06000F0D RID: 3853 RVA: 0x0003C59C File Offset: 0x0003A79C
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedDestroyDropdownList_d__81()
			{
				Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr, "<DelayedDestroyDropdownList>d__81");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr);
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, "<>1__state");
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, "<>2__current");
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, "delay");
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, "<>4__this");
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, 100663759);
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, 100663760);
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, 100663761);
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, 100663762);
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, 100663763);
				TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr, 100663764);
			}

			// Token: 0x06000F0E RID: 3854 RVA: 0x0003C690 File Offset: 0x0003A890
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedDestroyDropdownList_d__81(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Dropdown._DelayedDestroyDropdownList_d__81>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000F0F RID: 3855 RVA: 0x0003C6D8 File Offset: 0x0003A8D8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F10 RID: 3856 RVA: 0x0003C70C File Offset: 0x0003A90C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038771, XrefRangeEnd = 1038776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700058E RID: 1422
			// (get) Token: 0x06000F11 RID: 3857 RVA: 0x0003C748 File Offset: 0x0003A948
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000F12 RID: 3858 RVA: 0x0003C788 File Offset: 0x0003A988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038776, XrefRangeEnd = 1038781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700058F RID: 1423
			// (get) Token: 0x06000F13 RID: 3859 RVA: 0x0003C7BC File Offset: 0x0003A9BC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000F14 RID: 3860 RVA: 0x000091ED File Offset: 0x000073ED
			public _DelayedDestroyDropdownList_d__81(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700058A RID: 1418
			// (get) Token: 0x06000F15 RID: 3861 RVA: 0x0003C7FC File Offset: 0x0003A9FC
			// (set) Token: 0x06000F16 RID: 3862 RVA: 0x000091F6 File Offset: 0x000073F6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700058B RID: 1419
			// (get) Token: 0x06000F17 RID: 3863 RVA: 0x0003C824 File Offset: 0x0003AA24
			// (set) Token: 0x06000F18 RID: 3864 RVA: 0x00009211 File Offset: 0x00007411
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700058C RID: 1420
			// (get) Token: 0x06000F19 RID: 3865 RVA: 0x0003C854 File Offset: 0x0003AA54
			// (set) Token: 0x06000F1A RID: 3866 RVA: 0x00009230 File Offset: 0x00007430
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x1700058D RID: 1421
			// (get) Token: 0x06000F1B RID: 3867 RVA: 0x0003C87C File Offset: 0x0003AA7C
			// (set) Token: 0x06000F1C RID: 3868 RVA: 0x0000924B File Offset: 0x0000744B
			public unsafe TMP_Dropdown __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Dropdown._DelayedDestroyDropdownList_d__81.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000BDD RID: 3037
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000BDE RID: 3038
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000BDF RID: 3039
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x04000BE0 RID: 3040
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000BE1 RID: 3041
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000BE2 RID: 3042
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000BE3 RID: 3043
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000BE4 RID: 3044
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000BE5 RID: 3045
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000BE6 RID: 3046
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000087 RID: 135
		private sealed class MethodInfoStoreGeneric_GetOrAddComponent_Private_Static_T_GameObject_0<T>
		{
			// Token: 0x04000BE7 RID: 3047
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TMP_Dropdown.NativeMethodInfoPtr_GetOrAddComponent_Private_Static_T_GameObject_0, Il2CppClassPointerStore<TMP_Dropdown>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
