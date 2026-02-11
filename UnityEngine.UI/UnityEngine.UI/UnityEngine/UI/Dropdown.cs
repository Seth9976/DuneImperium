using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI.CoroutineTween;

namespace UnityEngine.UI
{
	// Token: 0x0200000F RID: 15
	public class Dropdown : Selectable
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x0000A034 File Offset: 0x00008234
		// Note: this type is marked as 'beforefieldinit'.
		static Dropdown()
		{
			Il2CppClassPointerStore<Dropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Dropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dropdown>.NativeClassPtr);
			Dropdown.NativeFieldInfoPtr_m_Template = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_Template");
			Dropdown.NativeFieldInfoPtr_m_CaptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_CaptionText");
			Dropdown.NativeFieldInfoPtr_m_CaptionImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_CaptionImage");
			Dropdown.NativeFieldInfoPtr_m_ItemText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_ItemText");
			Dropdown.NativeFieldInfoPtr_m_ItemImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_ItemImage");
			Dropdown.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_Value");
			Dropdown.NativeFieldInfoPtr_m_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_Options");
			Dropdown.NativeFieldInfoPtr_m_OnValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_OnValueChanged");
			Dropdown.NativeFieldInfoPtr_m_AlphaFadeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_AlphaFadeSpeed");
			Dropdown.NativeFieldInfoPtr_m_Dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_Dropdown");
			Dropdown.NativeFieldInfoPtr_m_Blocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_Blocker");
			Dropdown.NativeFieldInfoPtr_m_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_Items");
			Dropdown.NativeFieldInfoPtr_m_AlphaTweenRunner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "m_AlphaTweenRunner");
			Dropdown.NativeFieldInfoPtr_validTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "validTemplate");
			Dropdown.NativeFieldInfoPtr_kHighSortingLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "kHighSortingLayer");
			Dropdown.NativeFieldInfoPtr_s_NoOptionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "s_NoOptionData");
			Dropdown.NativeMethodInfoPtr_get_template_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663410);
			Dropdown.NativeMethodInfoPtr_set_template_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663411);
			Dropdown.NativeMethodInfoPtr_get_captionText_Public_get_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663412);
			Dropdown.NativeMethodInfoPtr_set_captionText_Public_set_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663413);
			Dropdown.NativeMethodInfoPtr_get_captionImage_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663414);
			Dropdown.NativeMethodInfoPtr_set_captionImage_Public_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663415);
			Dropdown.NativeMethodInfoPtr_get_itemText_Public_get_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663416);
			Dropdown.NativeMethodInfoPtr_set_itemText_Public_set_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663417);
			Dropdown.NativeMethodInfoPtr_get_itemImage_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663418);
			Dropdown.NativeMethodInfoPtr_set_itemImage_Public_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663419);
			Dropdown.NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663420);
			Dropdown.NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663421);
			Dropdown.NativeMethodInfoPtr_get_onValueChanged_Public_get_DropdownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663422);
			Dropdown.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_DropdownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663423);
			Dropdown.NativeMethodInfoPtr_get_alphaFadeSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663424);
			Dropdown.NativeMethodInfoPtr_set_alphaFadeSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663425);
			Dropdown.NativeMethodInfoPtr_get_value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663426);
			Dropdown.NativeMethodInfoPtr_set_value_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663427);
			Dropdown.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663428);
			Dropdown.NativeMethodInfoPtr_Set_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663429);
			Dropdown.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663430);
			Dropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663431);
			Dropdown.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663432);
			Dropdown.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663433);
			Dropdown.NativeMethodInfoPtr_RefreshShownValue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663434);
			Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663435);
			Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663436);
			Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663437);
			Dropdown.NativeMethodInfoPtr_ClearOptions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663438);
			Dropdown.NativeMethodInfoPtr_SetupTemplate_Private_Void_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663439);
			Dropdown.NativeMethodInfoPtr_GetOrAddComponent_Private_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663440);
			Dropdown.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663441);
			Dropdown.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663442);
			Dropdown.NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663443);
			Dropdown.NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663444);
			Dropdown.NativeMethodInfoPtr_CreateBlocker_Protected_Virtual_New_GameObject_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663445);
			Dropdown.NativeMethodInfoPtr_DestroyBlocker_Protected_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663446);
			Dropdown.NativeMethodInfoPtr_CreateDropdownList_Protected_Virtual_New_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663447);
			Dropdown.NativeMethodInfoPtr_DestroyDropdownList_Protected_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663448);
			Dropdown.NativeMethodInfoPtr_CreateItem_Protected_Virtual_New_DropdownItem_DropdownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663449);
			Dropdown.NativeMethodInfoPtr_DestroyItem_Protected_Virtual_New_Void_DropdownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663450);
			Dropdown.NativeMethodInfoPtr_AddItem_Private_DropdownItem_OptionData_Boolean_DropdownItem_List_1_DropdownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663451);
			Dropdown.NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663452);
			Dropdown.NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663453);
			Dropdown.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663454);
			Dropdown.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663455);
			Dropdown.NativeMethodInfoPtr_DelayedDestroyDropdownList_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663456);
			Dropdown.NativeMethodInfoPtr_ImmediateDestroyDropdownList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663457);
			Dropdown.NativeMethodInfoPtr_OnSelectItem_Private_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, 100663458);
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000A578 File Offset: 0x00008778
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000A5B8 File Offset: 0x000087B8
		public unsafe RectTransform template
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_get_template_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082831, XrefRangeEnd = 1082833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_set_template_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000A5FC File Offset: 0x000087FC
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x0000A63C File Offset: 0x0000883C
		public unsafe Text captionText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_get_captionText_Public_get_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Text>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082833, XrefRangeEnd = 1082835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_set_captionText_Public_set_Void_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000A680 File Offset: 0x00008880
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x0000A6C0 File Offset: 0x000088C0
		public unsafe Image captionImage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_get_captionImage_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082835, XrefRangeEnd = 1082837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_set_captionImage_Public_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000A704 File Offset: 0x00008904
		// (set) Token: 0x060000CA RID: 202 RVA: 0x0000A744 File Offset: 0x00008944
		public unsafe Text itemText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_get_itemText_Public_get_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Text>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082837, XrefRangeEnd = 1082839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_set_itemText_Public_set_Void_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000A788 File Offset: 0x00008988
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0000A7C8 File Offset: 0x000089C8
		public unsafe Image itemImage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_get_itemImage_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082839, XrefRangeEnd = 1082841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_set_itemImage_Public_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000A80C File Offset: 0x00008A0C
		// (set) Token: 0x060000CE RID: 206 RVA: 0x0000A84C File Offset: 0x00008A4C
		public unsafe List<Dropdown.OptionData> options
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Dropdown.OptionData>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082841, XrefRangeEnd = 1082844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000A890 File Offset: 0x00008A90
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000A8D0 File Offset: 0x00008AD0
		public unsafe Dropdown.DropdownEvent onValueChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_get_onValueChanged_Public_get_DropdownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dropdown.DropdownEvent>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_DropdownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000A914 File Offset: 0x00008B14
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000A950 File Offset: 0x00008B50
		public unsafe float alphaFadeSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_get_alphaFadeSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_set_alphaFadeSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000A990 File Offset: 0x00008B90
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x0000A9CC File Offset: 0x00008BCC
		public unsafe int value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_get_value_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082844, XrefRangeEnd = 1082845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_set_value_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000AA0C File Offset: 0x00008C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082845, XrefRangeEnd = 1082846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValueWithoutNotify(int input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000AA4C File Offset: 0x00008C4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1082859, RefRangeEnd = 1082863, XrefRangeStart = 1082846, XrefRangeEnd = 1082859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int value, bool sendCallback = true)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_Set_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000AA98 File Offset: 0x00008C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082863, XrefRangeEnd = 1082893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dropdown()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000AAD4 File Offset: 0x00008CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082893, XrefRangeEnd = 1082906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000AB10 File Offset: 0x00008D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082906, XrefRangeEnd = 1082926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000AB4C File Offset: 0x00008D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082926, XrefRangeEnd = 1082933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000AB88 File Offset: 0x00008D88
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1082958, RefRangeEnd = 1082975, XrefRangeStart = 1082933, XrefRangeEnd = 1082958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshShownValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_RefreshShownValue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000ABBC File Offset: 0x00008DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082975, XrefRangeEnd = 1082980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOptions(List<Dropdown.OptionData> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000AC00 File Offset: 0x00008E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082980, XrefRangeEnd = 1082997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOptions(List<string> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000AC44 File Offset: 0x00008E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082997, XrefRangeEnd = 1083014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOptions(List<Sprite> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000AC88 File Offset: 0x00008E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083014, XrefRangeEnd = 1083018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_ClearOptions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000ACBC File Offset: 0x00008EBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1083119, RefRangeEnd = 1083120, XrefRangeStart = 1083018, XrefRangeEnd = 1083119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupTemplate(Canvas rootCanvas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootCanvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_SetupTemplate_Private_Void_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000AD00 File Offset: 0x00008F00
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1039114, RefRangeEnd = 1039121, XrefRangeStart = 1039114, XrefRangeEnd = 1039121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetOrAddComponent<T>(GameObject go) where T : Component
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.MethodInfoStoreGeneric_GetOrAddComponent_Private_Static_T_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000AD40 File Offset: 0x00008F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083120, XrefRangeEnd = 1083121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000AD90 File Offset: 0x00008F90
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000ADE0 File Offset: 0x00008FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083121, XrefRangeEnd = 1083122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCancel(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000AE30 File Offset: 0x00009030
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1083264, RefRangeEnd = 1083266, XrefRangeStart = 1083122, XrefRangeEnd = 1083264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000AE64 File Offset: 0x00009064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083266, XrefRangeEnd = 1083339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject CreateBlocker(Canvas rootCanvas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootCanvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_CreateBlocker_Protected_Virtual_New_GameObject_Canvas_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000AEC0 File Offset: 0x000090C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083339, XrefRangeEnd = 1083343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyBlocker(GameObject blocker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(blocker);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_DestroyBlocker_Protected_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000AF10 File Offset: 0x00009110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083343, XrefRangeEnd = 1083349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject CreateDropdownList(GameObject template)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(template);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_CreateDropdownList_Protected_Virtual_New_GameObject_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000AF6C File Offset: 0x0000916C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083349, XrefRangeEnd = 1083353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyDropdownList(GameObject dropdownList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dropdownList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_DestroyDropdownList_Protected_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000AFBC File Offset: 0x000091BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083353, XrefRangeEnd = 1083359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Dropdown.DropdownItem CreateItem(Dropdown.DropdownItem itemTemplate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemTemplate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_CreateItem_Protected_Virtual_New_DropdownItem_DropdownItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dropdown.DropdownItem>(intPtr3) : null;
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000B018 File Offset: 0x00009218
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyItem(Dropdown.DropdownItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.NativeMethodInfoPtr_DestroyItem_Protected_Virtual_New_Void_DropdownItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000B068 File Offset: 0x00009268
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1083397, RefRangeEnd = 1083398, XrefRangeStart = 1083359, XrefRangeEnd = 1083397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dropdown.DropdownItem AddItem(Dropdown.OptionData data, bool selected, Dropdown.DropdownItem itemTemplate, List<Dropdown.DropdownItem> items)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_AddItem_Private_DropdownItem_OptionData_Boolean_DropdownItem_List_1_DropdownItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dropdown.DropdownItem>(intPtr3) : null;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000B0EC File Offset: 0x000092EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083398, XrefRangeEnd = 1083403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000B138 File Offset: 0x00009338
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1083414, RefRangeEnd = 1083417, XrefRangeStart = 1083403, XrefRangeEnd = 1083414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000B194 File Offset: 0x00009394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083417, XrefRangeEnd = 1083425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alpha;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000B1D4 File Offset: 0x000093D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1083445, RefRangeEnd = 1083449, XrefRangeStart = 1083425, XrefRangeEnd = 1083445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000B208 File Offset: 0x00009408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083449, XrefRangeEnd = 1083454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedDestroyDropdownList(float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_DelayedDestroyDropdownList_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000B254 File Offset: 0x00009454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1083471, RefRangeEnd = 1083472, XrefRangeStart = 1083454, XrefRangeEnd = 1083471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImmediateDestroyDropdownList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_ImmediateDestroyDropdownList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000B288 File Offset: 0x00009488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083472, XrefRangeEnd = 1083484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSelectItem(Toggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.NativeMethodInfoPtr_OnSelectItem_Private_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002435 File Offset: 0x00000635
		public Dropdown(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000B2CC File Offset: 0x000094CC
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000243E File Offset: 0x0000063E
		public unsafe RectTransform m_Template
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Template);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Template), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000B2FC File Offset: 0x000094FC
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000245D File Offset: 0x0000065D
		public unsafe Text m_CaptionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_CaptionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_CaptionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000B32C File Offset: 0x0000952C
		// (set) Token: 0x060000FA RID: 250 RVA: 0x0000247C File Offset: 0x0000067C
		public unsafe Image m_CaptionImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_CaptionImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_CaptionImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000B35C File Offset: 0x0000955C
		// (set) Token: 0x060000FC RID: 252 RVA: 0x0000249B File Offset: 0x0000069B
		public unsafe Text m_ItemText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_ItemText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_ItemText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000B38C File Offset: 0x0000958C
		// (set) Token: 0x060000FE RID: 254 RVA: 0x000024BA File Offset: 0x000006BA
		public unsafe Image m_ItemImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_ItemImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_ItemImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000B3BC File Offset: 0x000095BC
		// (set) Token: 0x06000100 RID: 256 RVA: 0x000024D9 File Offset: 0x000006D9
		public unsafe int m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Value)) = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000B3E4 File Offset: 0x000095E4
		// (set) Token: 0x06000102 RID: 258 RVA: 0x000024F4 File Offset: 0x000006F4
		public unsafe Dropdown.OptionDataList m_Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown.OptionDataList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000B414 File Offset: 0x00009614
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00002513 File Offset: 0x00000713
		public unsafe Dropdown.DropdownEvent m_OnValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_OnValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown.DropdownEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_OnValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000B444 File Offset: 0x00009644
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00002532 File Offset: 0x00000732
		public unsafe float m_AlphaFadeSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_AlphaFadeSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_AlphaFadeSpeed)) = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0000B46C File Offset: 0x0000966C
		// (set) Token: 0x06000108 RID: 264 RVA: 0x0000254D File Offset: 0x0000074D
		public unsafe GameObject m_Dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0000B49C File Offset: 0x0000969C
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000256C File Offset: 0x0000076C
		public unsafe GameObject m_Blocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Blocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Blocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000B4CC File Offset: 0x000096CC
		// (set) Token: 0x0600010C RID: 268 RVA: 0x0000258B File Offset: 0x0000078B
		public unsafe List<Dropdown.DropdownItem> m_Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Dropdown.DropdownItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000B4FC File Offset: 0x000096FC
		// (set) Token: 0x0600010E RID: 270 RVA: 0x000025AA File Offset: 0x000007AA
		public unsafe TweenRunner<FloatTween> m_AlphaTweenRunner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_AlphaTweenRunner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenRunner<FloatTween>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_m_AlphaTweenRunner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0000B52C File Offset: 0x0000972C
		// (set) Token: 0x06000110 RID: 272 RVA: 0x000025C9 File Offset: 0x000007C9
		public unsafe bool validTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_validTemplate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.NativeFieldInfoPtr_validTemplate)) = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000B554 File Offset: 0x00009754
		// (set) Token: 0x06000112 RID: 274 RVA: 0x000025E4 File Offset: 0x000007E4
		public unsafe static int kHighSortingLayer
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Dropdown.NativeFieldInfoPtr_kHighSortingLayer, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dropdown.NativeFieldInfoPtr_kHighSortingLayer, (void*)(&value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000B570 File Offset: 0x00009770
		// (set) Token: 0x06000114 RID: 276 RVA: 0x000025F2 File Offset: 0x000007F2
		public unsafe static Dropdown.OptionData s_NoOptionData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dropdown.NativeFieldInfoPtr_s_NoOptionData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown.OptionData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dropdown.NativeFieldInfoPtr_s_NoOptionData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_m_Template;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_m_CaptionText;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_m_CaptionImage;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemText;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemImage;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_m_Options;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_m_OnValueChanged;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr_m_AlphaFadeSpeed;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_m_Dropdown;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_m_Blocker;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr_m_Items;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr_m_AlphaTweenRunner;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr_validTemplate;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_kHighSortingLayer;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_s_NoOptionData;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_get_template_Public_get_RectTransform_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_set_template_Public_set_Void_RectTransform_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_get_captionText_Public_get_Text_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_set_captionText_Public_set_Void_Text_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_get_captionImage_Public_get_Image_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_set_captionImage_Public_set_Void_Image_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_get_itemText_Public_get_Text_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_set_itemText_Public_set_Void_Text_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_get_itemImage_Public_get_Image_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_set_itemImage_Public_set_Void_Image_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_get_onValueChanged_Public_get_DropdownEvent_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_DropdownEvent_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_get_alphaFadeSpeed_Public_get_Single_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_set_alphaFadeSpeed_Public_set_Void_Single_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Int32_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_Int32_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Void_Int32_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_Set_Private_Void_Int32_Boolean_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_RefreshShownValue_Public_Void_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_AddOptions_Public_Void_List_1_OptionData_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_AddOptions_Public_Void_List_1_String_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_AddOptions_Public_Void_List_1_Sprite_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_ClearOptions_Public_Void_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_SetupTemplate_Private_Void_Canvas_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAddComponent_Private_Static_T_GameObject_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_CreateBlocker_Protected_Virtual_New_GameObject_Canvas_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_DestroyBlocker_Protected_Virtual_New_Void_GameObject_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_CreateDropdownList_Protected_Virtual_New_GameObject_GameObject_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_DestroyDropdownList_Protected_Virtual_New_Void_GameObject_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_CreateItem_Protected_Virtual_New_DropdownItem_DropdownItem_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Protected_Virtual_New_Void_DropdownItem_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Private_DropdownItem_OptionData_Boolean_DropdownItem_List_1_DropdownItem_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_AlphaFadeList_Private_Void_Single_Single_Single_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_DelayedDestroyDropdownList_Private_IEnumerator_Single_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_ImmediateDestroyDropdownList_Private_Void_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectItem_Private_Void_Toggle_0;

		// Token: 0x0200007E RID: 126
		public class DropdownItem : MonoBehaviour
		{
			// Token: 0x06000BF1 RID: 3057 RVA: 0x00034CA8 File Offset: 0x00032EA8
			// Note: this type is marked as 'beforefieldinit'.
			static DropdownItem()
			{
				Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "DropdownItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr);
				Dropdown.DropdownItem.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, "m_Text");
				Dropdown.DropdownItem.NativeFieldInfoPtr_m_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, "m_Image");
				Dropdown.DropdownItem.NativeFieldInfoPtr_m_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, "m_RectTransform");
				Dropdown.DropdownItem.NativeFieldInfoPtr_m_Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, "m_Toggle");
				Dropdown.DropdownItem.NativeMethodInfoPtr_get_text_Public_get_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100663460);
				Dropdown.DropdownItem.NativeMethodInfoPtr_set_text_Public_set_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100663461);
				Dropdown.DropdownItem.NativeMethodInfoPtr_get_image_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100663462);
				Dropdown.DropdownItem.NativeMethodInfoPtr_set_image_Public_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100663463);
				Dropdown.DropdownItem.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100663464);
				Dropdown.DropdownItem.NativeMethodInfoPtr_set_rectTransform_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100663465);
				Dropdown.DropdownItem.NativeMethodInfoPtr_get_toggle_Public_get_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100663466);
				Dropdown.DropdownItem.NativeMethodInfoPtr_set_toggle_Public_set_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100663467);
				Dropdown.DropdownItem.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100663468);
				Dropdown.DropdownItem.NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100663469);
				Dropdown.DropdownItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr, 100663470);
			}

			// Token: 0x17000400 RID: 1024
			// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00034E00 File Offset: 0x00033000
			// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x00034E40 File Offset: 0x00033040
			public unsafe Text text
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownItem.NativeMethodInfoPtr_get_text_Public_get_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Text>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownItem.NativeMethodInfoPtr_set_text_Public_set_Void_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000401 RID: 1025
			// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x00034E84 File Offset: 0x00033084
			// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x00034EC4 File Offset: 0x000330C4
			public unsafe Image image
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownItem.NativeMethodInfoPtr_get_image_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownItem.NativeMethodInfoPtr_set_image_Public_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000402 RID: 1026
			// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x00034F08 File Offset: 0x00033108
			// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x00034F48 File Offset: 0x00033148
			public unsafe RectTransform rectTransform
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownItem.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownItem.NativeMethodInfoPtr_set_rectTransform_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000403 RID: 1027
			// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x00034F8C File Offset: 0x0003318C
			// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x00034FCC File Offset: 0x000331CC
			public unsafe Toggle toggle
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownItem.NativeMethodInfoPtr_get_toggle_Public_get_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownItem.NativeMethodInfoPtr_set_toggle_Public_set_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000BFA RID: 3066 RVA: 0x00035010 File Offset: 0x00033210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082783, XrefRangeEnd = 1082790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void OnPointerEnter(PointerEventData eventData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.DropdownItem.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BFB RID: 3067 RVA: 0x00035060 File Offset: 0x00033260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082790, XrefRangeEnd = 1082798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void OnCancel(BaseEventData eventData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dropdown.DropdownItem.NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BFC RID: 3068 RVA: 0x000350B0 File Offset: 0x000332B0
			[CallerCount(311)]
			[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DropdownItem()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown.DropdownItem>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BFD RID: 3069 RVA: 0x000065E7 File Offset: 0x000047E7
			public DropdownItem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003FC RID: 1020
			// (get) Token: 0x06000BFE RID: 3070 RVA: 0x000350EC File Offset: 0x000332EC
			// (set) Token: 0x06000BFF RID: 3071 RVA: 0x000065F0 File Offset: 0x000047F0
			public unsafe Text m_Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.DropdownItem.NativeFieldInfoPtr_m_Text);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.DropdownItem.NativeFieldInfoPtr_m_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003FD RID: 1021
			// (get) Token: 0x06000C00 RID: 3072 RVA: 0x0003511C File Offset: 0x0003331C
			// (set) Token: 0x06000C01 RID: 3073 RVA: 0x0000660F File Offset: 0x0000480F
			public unsafe Image m_Image
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.DropdownItem.NativeFieldInfoPtr_m_Image);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.DropdownItem.NativeFieldInfoPtr_m_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003FE RID: 1022
			// (get) Token: 0x06000C02 RID: 3074 RVA: 0x0003514C File Offset: 0x0003334C
			// (set) Token: 0x06000C03 RID: 3075 RVA: 0x0000662E File Offset: 0x0000482E
			public unsafe RectTransform m_RectTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.DropdownItem.NativeFieldInfoPtr_m_RectTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.DropdownItem.NativeFieldInfoPtr_m_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003FF RID: 1023
			// (get) Token: 0x06000C04 RID: 3076 RVA: 0x0003517C File Offset: 0x0003337C
			// (set) Token: 0x06000C05 RID: 3077 RVA: 0x0000664D File Offset: 0x0000484D
			public unsafe Toggle m_Toggle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.DropdownItem.NativeFieldInfoPtr_m_Toggle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.DropdownItem.NativeFieldInfoPtr_m_Toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008F5 RID: 2293
			private static readonly IntPtr NativeFieldInfoPtr_m_Text;

			// Token: 0x040008F6 RID: 2294
			private static readonly IntPtr NativeFieldInfoPtr_m_Image;

			// Token: 0x040008F7 RID: 2295
			private static readonly IntPtr NativeFieldInfoPtr_m_RectTransform;

			// Token: 0x040008F8 RID: 2296
			private static readonly IntPtr NativeFieldInfoPtr_m_Toggle;

			// Token: 0x040008F9 RID: 2297
			private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_Text_0;

			// Token: 0x040008FA RID: 2298
			private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_Text_0;

			// Token: 0x040008FB RID: 2299
			private static readonly IntPtr NativeMethodInfoPtr_get_image_Public_get_Image_0;

			// Token: 0x040008FC RID: 2300
			private static readonly IntPtr NativeMethodInfoPtr_set_image_Public_set_Void_Image_0;

			// Token: 0x040008FD RID: 2301
			private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;

			// Token: 0x040008FE RID: 2302
			private static readonly IntPtr NativeMethodInfoPtr_set_rectTransform_Public_set_Void_RectTransform_0;

			// Token: 0x040008FF RID: 2303
			private static readonly IntPtr NativeMethodInfoPtr_get_toggle_Public_get_Toggle_0;

			// Token: 0x04000900 RID: 2304
			private static readonly IntPtr NativeMethodInfoPtr_set_toggle_Public_set_Void_Toggle_0;

			// Token: 0x04000901 RID: 2305
			private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0;

			// Token: 0x04000902 RID: 2306
			private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0;

			// Token: 0x04000903 RID: 2307
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200007F RID: 127
		[Serializable]
		public class OptionData : Object
		{
			// Token: 0x06000C06 RID: 3078 RVA: 0x000351AC File Offset: 0x000333AC
			// Note: this type is marked as 'beforefieldinit'.
			static OptionData()
			{
				Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "OptionData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr);
				Dropdown.OptionData.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, "m_Text");
				Dropdown.OptionData.NativeFieldInfoPtr_m_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, "m_Image");
				Dropdown.OptionData.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, 100663471);
				Dropdown.OptionData.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, 100663472);
				Dropdown.OptionData.NativeMethodInfoPtr_get_image_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, 100663473);
				Dropdown.OptionData.NativeMethodInfoPtr_set_image_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, 100663474);
				Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, 100663475);
				Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, 100663476);
				Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, 100663477);
				Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_String_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr, 100663478);
			}

			// Token: 0x17000406 RID: 1030
			// (get) Token: 0x06000C07 RID: 3079 RVA: 0x000352A0 File Offset: 0x000334A0
			// (set) Token: 0x06000C08 RID: 3080 RVA: 0x000352D8 File Offset: 0x000334D8
			public unsafe string text
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionData.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionData.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000407 RID: 1031
			// (get) Token: 0x06000C09 RID: 3081 RVA: 0x0003531C File Offset: 0x0003351C
			// (set) Token: 0x06000C0A RID: 3082 RVA: 0x0003535C File Offset: 0x0003355C
			public unsafe Sprite image
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionData.NativeMethodInfoPtr_get_image_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionData.NativeMethodInfoPtr_set_image_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000C0B RID: 3083 RVA: 0x000353A0 File Offset: 0x000335A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C0C RID: 3084 RVA: 0x000353DC File Offset: 0x000335DC
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionData(string text)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C0D RID: 3085 RVA: 0x00035428 File Offset: 0x00033628
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 320067, RefRangeEnd = 320078, XrefRangeStart = 320067, XrefRangeEnd = 320078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionData(Sprite image)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C0E RID: 3086 RVA: 0x00035474 File Offset: 0x00033674
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionData(string text, Sprite image)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown.OptionData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionData.NativeMethodInfoPtr__ctor_Public_Void_String_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C0F RID: 3087 RVA: 0x0000666C File Offset: 0x0000486C
			public OptionData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000404 RID: 1028
			// (get) Token: 0x06000C10 RID: 3088 RVA: 0x000354D4 File Offset: 0x000336D4
			// (set) Token: 0x06000C11 RID: 3089 RVA: 0x00006675 File Offset: 0x00004875
			public unsafe string m_Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.OptionData.NativeFieldInfoPtr_m_Text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.OptionData.NativeFieldInfoPtr_m_Text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000405 RID: 1029
			// (get) Token: 0x06000C12 RID: 3090 RVA: 0x000354FC File Offset: 0x000336FC
			// (set) Token: 0x06000C13 RID: 3091 RVA: 0x00006694 File Offset: 0x00004894
			public unsafe Sprite m_Image
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.OptionData.NativeFieldInfoPtr_m_Image);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.OptionData.NativeFieldInfoPtr_m_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000904 RID: 2308
			private static readonly IntPtr NativeFieldInfoPtr_m_Text;

			// Token: 0x04000905 RID: 2309
			private static readonly IntPtr NativeFieldInfoPtr_m_Image;

			// Token: 0x04000906 RID: 2310
			private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

			// Token: 0x04000907 RID: 2311
			private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

			// Token: 0x04000908 RID: 2312
			private static readonly IntPtr NativeMethodInfoPtr_get_image_Public_get_Sprite_0;

			// Token: 0x04000909 RID: 2313
			private static readonly IntPtr NativeMethodInfoPtr_set_image_Public_set_Void_Sprite_0;

			// Token: 0x0400090A RID: 2314
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400090B RID: 2315
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

			// Token: 0x0400090C RID: 2316
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Sprite_0;

			// Token: 0x0400090D RID: 2317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Sprite_0;
		}

		// Token: 0x02000080 RID: 128
		[Serializable]
		public class OptionDataList : Object
		{
			// Token: 0x06000C14 RID: 3092 RVA: 0x0003552C File Offset: 0x0003372C
			// Note: this type is marked as 'beforefieldinit'.
			static OptionDataList()
			{
				Il2CppClassPointerStore<Dropdown.OptionDataList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "OptionDataList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dropdown.OptionDataList>.NativeClassPtr);
				Dropdown.OptionDataList.NativeFieldInfoPtr_m_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown.OptionDataList>.NativeClassPtr, "m_Options");
				Dropdown.OptionDataList.NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionDataList>.NativeClassPtr, 100663479);
				Dropdown.OptionDataList.NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionDataList>.NativeClassPtr, 100663480);
				Dropdown.OptionDataList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.OptionDataList>.NativeClassPtr, 100663481);
			}

			// Token: 0x17000409 RID: 1033
			// (get) Token: 0x06000C15 RID: 3093 RVA: 0x000355A8 File Offset: 0x000337A8
			// (set) Token: 0x06000C16 RID: 3094 RVA: 0x000355E8 File Offset: 0x000337E8
			public unsafe List<Dropdown.OptionData> options
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionDataList.NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Dropdown.OptionData>>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionDataList.NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000C17 RID: 3095 RVA: 0x0003562C File Offset: 0x0003382C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082798, XrefRangeEnd = 1082806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionDataList()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown.OptionDataList>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.OptionDataList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C18 RID: 3096 RVA: 0x000066B3 File Offset: 0x000048B3
			public OptionDataList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000408 RID: 1032
			// (get) Token: 0x06000C19 RID: 3097 RVA: 0x00035668 File Offset: 0x00033868
			// (set) Token: 0x06000C1A RID: 3098 RVA: 0x000066BC File Offset: 0x000048BC
			public unsafe List<Dropdown.OptionData> m_Options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.OptionDataList.NativeFieldInfoPtr_m_Options);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Dropdown.OptionData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.OptionDataList.NativeFieldInfoPtr_m_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400090E RID: 2318
			private static readonly IntPtr NativeFieldInfoPtr_m_Options;

			// Token: 0x0400090F RID: 2319
			private static readonly IntPtr NativeMethodInfoPtr_get_options_Public_get_List_1_OptionData_0;

			// Token: 0x04000910 RID: 2320
			private static readonly IntPtr NativeMethodInfoPtr_set_options_Public_set_Void_List_1_OptionData_0;

			// Token: 0x04000911 RID: 2321
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000081 RID: 129
		[Serializable]
		public class DropdownEvent : UnityEvent<int>
		{
			// Token: 0x06000C1B RID: 3099 RVA: 0x000066DB File Offset: 0x000048DB
			// Note: this type is marked as 'beforefieldinit'.
			static DropdownEvent()
			{
				Il2CppClassPointerStore<Dropdown.DropdownEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "DropdownEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dropdown.DropdownEvent>.NativeClassPtr);
				Dropdown.DropdownEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.DropdownEvent>.NativeClassPtr, 100663482);
			}

			// Token: 0x06000C1C RID: 3100 RVA: 0x00035698 File Offset: 0x00033898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082806, XrefRangeEnd = 1082809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DropdownEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown.DropdownEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.DropdownEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C1D RID: 3101 RVA: 0x0000670F File Offset: 0x0000490F
			public DropdownEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000912 RID: 2322
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000082 RID: 130
		[ObfuscatedName("UnityEngine.UI.Dropdown+<>c__DisplayClass63_0")]
		public sealed class __c__DisplayClass63_0 : Object
		{
			// Token: 0x06000C1E RID: 3102 RVA: 0x000356D4 File Offset: 0x000338D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass63_0()
			{
				Il2CppClassPointerStore<Dropdown.__c__DisplayClass63_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "<>c__DisplayClass63_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dropdown.__c__DisplayClass63_0>.NativeClassPtr);
				Dropdown.__c__DisplayClass63_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown.__c__DisplayClass63_0>.NativeClassPtr, "item");
				Dropdown.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown.__c__DisplayClass63_0>.NativeClassPtr, "<>4__this");
				Dropdown.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.__c__DisplayClass63_0>.NativeClassPtr, 100663483);
				Dropdown.__c__DisplayClass63_0.NativeMethodInfoPtr__Show_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown.__c__DisplayClass63_0>.NativeClassPtr, 100663484);
			}

			// Token: 0x06000C1F RID: 3103 RVA: 0x00035750 File Offset: 0x00033950
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass63_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown.__c__DisplayClass63_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C20 RID: 3104 RVA: 0x0003578C File Offset: 0x0003398C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082809, XrefRangeEnd = 1082821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Show_b__0(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown.__c__DisplayClass63_0.NativeMethodInfoPtr__Show_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C21 RID: 3105 RVA: 0x00006718 File Offset: 0x00004918
			public __c__DisplayClass63_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700040A RID: 1034
			// (get) Token: 0x06000C22 RID: 3106 RVA: 0x000357CC File Offset: 0x000339CC
			// (set) Token: 0x06000C23 RID: 3107 RVA: 0x00006721 File Offset: 0x00004921
			public unsafe Dropdown.DropdownItem item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.__c__DisplayClass63_0.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown.DropdownItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.__c__DisplayClass63_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700040B RID: 1035
			// (get) Token: 0x06000C24 RID: 3108 RVA: 0x000357FC File Offset: 0x000339FC
			// (set) Token: 0x06000C25 RID: 3109 RVA: 0x00006740 File Offset: 0x00004940
			public unsafe Dropdown __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000913 RID: 2323
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04000914 RID: 2324
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000915 RID: 2325
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000916 RID: 2326
			private static readonly IntPtr NativeMethodInfoPtr__Show_b__0_Internal_Void_Boolean_0;
		}

		// Token: 0x02000083 RID: 131
		[ObfuscatedName("UnityEngine.UI.Dropdown+<DelayedDestroyDropdownList>d__75")]
		public sealed class _DelayedDestroyDropdownList_d__75 : Object
		{
			// Token: 0x06000C26 RID: 3110 RVA: 0x0003582C File Offset: 0x00033A2C
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedDestroyDropdownList_d__75()
			{
				Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__75>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dropdown>.NativeClassPtr, "<DelayedDestroyDropdownList>d__75");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__75>.NativeClassPtr);
				Dropdown._DelayedDestroyDropdownList_d__75.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__75>.NativeClassPtr, "<>1__state");
				Dropdown._DelayedDestroyDropdownList_d__75.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__75>.NativeClassPtr, "<>2__current");
				Dropdown._DelayedDestroyDropdownList_d__75.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__75>.NativeClassPtr, "delay");
				Dropdown._DelayedDestroyDropdownList_d__75.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__75>.NativeClassPtr, "<>4__this");
				Dropdown._DelayedDestroyDropdownList_d__75.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__75>.NativeClassPtr, 100663485);
				Dropdown._DelayedDestroyDropdownList_d__75.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__75>.NativeClassPtr, 100663486);
				Dropdown._DelayedDestroyDropdownList_d__75.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__75>.NativeClassPtr, 100663487);
				Dropdown._DelayedDestroyDropdownList_d__75.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__75>.NativeClassPtr, 100663488);
				Dropdown._DelayedDestroyDropdownList_d__75.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__75>.NativeClassPtr, 100663489);
				Dropdown._DelayedDestroyDropdownList_d__75.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__75>.NativeClassPtr, 100663490);
			}

			// Token: 0x06000C27 RID: 3111 RVA: 0x00035920 File Offset: 0x00033B20
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedDestroyDropdownList_d__75(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dropdown._DelayedDestroyDropdownList_d__75>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown._DelayedDestroyDropdownList_d__75.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C28 RID: 3112 RVA: 0x00035968 File Offset: 0x00033B68
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown._DelayedDestroyDropdownList_d__75.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C29 RID: 3113 RVA: 0x0003599C File Offset: 0x00033B9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082821, XrefRangeEnd = 1082826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown._DelayedDestroyDropdownList_d__75.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000410 RID: 1040
			// (get) Token: 0x06000C2A RID: 3114 RVA: 0x000359D8 File Offset: 0x00033BD8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown._DelayedDestroyDropdownList_d__75.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C2B RID: 3115 RVA: 0x00035A18 File Offset: 0x00033C18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082826, XrefRangeEnd = 1082831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown._DelayedDestroyDropdownList_d__75.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000411 RID: 1041
			// (get) Token: 0x06000C2C RID: 3116 RVA: 0x00035A4C File Offset: 0x00033C4C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dropdown._DelayedDestroyDropdownList_d__75.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C2D RID: 3117 RVA: 0x0000675F File Offset: 0x0000495F
			public _DelayedDestroyDropdownList_d__75(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700040C RID: 1036
			// (get) Token: 0x06000C2E RID: 3118 RVA: 0x00035A8C File Offset: 0x00033C8C
			// (set) Token: 0x06000C2F RID: 3119 RVA: 0x00006768 File Offset: 0x00004968
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown._DelayedDestroyDropdownList_d__75.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown._DelayedDestroyDropdownList_d__75.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700040D RID: 1037
			// (get) Token: 0x06000C30 RID: 3120 RVA: 0x00035AB4 File Offset: 0x00033CB4
			// (set) Token: 0x06000C31 RID: 3121 RVA: 0x00006783 File Offset: 0x00004983
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown._DelayedDestroyDropdownList_d__75.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown._DelayedDestroyDropdownList_d__75.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700040E RID: 1038
			// (get) Token: 0x06000C32 RID: 3122 RVA: 0x00035AE4 File Offset: 0x00033CE4
			// (set) Token: 0x06000C33 RID: 3123 RVA: 0x000067A2 File Offset: 0x000049A2
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown._DelayedDestroyDropdownList_d__75.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown._DelayedDestroyDropdownList_d__75.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x1700040F RID: 1039
			// (get) Token: 0x06000C34 RID: 3124 RVA: 0x00035B0C File Offset: 0x00033D0C
			// (set) Token: 0x06000C35 RID: 3125 RVA: 0x000067BD File Offset: 0x000049BD
			public unsafe Dropdown __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown._DelayedDestroyDropdownList_d__75.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dropdown._DelayedDestroyDropdownList_d__75.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000917 RID: 2327
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000918 RID: 2328
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000919 RID: 2329
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x0400091A RID: 2330
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400091B RID: 2331
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400091C RID: 2332
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400091D RID: 2333
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400091E RID: 2334
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400091F RID: 2335
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000920 RID: 2336
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000084 RID: 132
		private sealed class MethodInfoStoreGeneric_GetOrAddComponent_Private_Static_T_GameObject_0<T>
		{
			// Token: 0x04000921 RID: 2337
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Dropdown.NativeMethodInfoPtr_GetOrAddComponent_Private_Static_T_GameObject_0, Il2CppClassPointerStore<Dropdown>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
