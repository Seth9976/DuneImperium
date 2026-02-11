using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000035 RID: 53
	public class Selectable : UIBehaviour
	{
		// Token: 0x06000690 RID: 1680 RVA: 0x0002083C File Offset: 0x0001EA3C
		// Note: this type is marked as 'beforefieldinit'.
		static Selectable()
		{
			Il2CppClassPointerStore<Selectable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Selectable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Selectable>.NativeClassPtr);
			Selectable.NativeFieldInfoPtr_s_Selectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "s_Selectables");
			Selectable.NativeFieldInfoPtr_s_SelectableCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "s_SelectableCount");
			Selectable.NativeFieldInfoPtr_m_EnableCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_EnableCalled");
			Selectable.NativeFieldInfoPtr_m_Navigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_Navigation");
			Selectable.NativeFieldInfoPtr_m_Transition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_Transition");
			Selectable.NativeFieldInfoPtr_m_Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_Colors");
			Selectable.NativeFieldInfoPtr_m_SpriteState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_SpriteState");
			Selectable.NativeFieldInfoPtr_m_AnimationTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_AnimationTriggers");
			Selectable.NativeFieldInfoPtr_m_Interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_Interactable");
			Selectable.NativeFieldInfoPtr_m_TargetGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_TargetGraphic");
			Selectable.NativeFieldInfoPtr_m_GroupsAllowInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_GroupsAllowInteraction");
			Selectable.NativeFieldInfoPtr_m_CurrentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_CurrentIndex");
			Selectable.NativeFieldInfoPtr__isPointerInside_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "<isPointerInside>k__BackingField");
			Selectable.NativeFieldInfoPtr__isPointerDown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "<isPointerDown>k__BackingField");
			Selectable.NativeFieldInfoPtr__hasSelection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "<hasSelection>k__BackingField");
			Selectable.NativeFieldInfoPtr_m_CanvasGroupCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_CanvasGroupCache");
			Selectable.NativeMethodInfoPtr_get_allSelectablesArray_Public_Static_get_Il2CppReferenceArray_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664351);
			Selectable.NativeMethodInfoPtr_get_allSelectableCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664352);
			Selectable.NativeMethodInfoPtr_get_allSelectables_Public_Static_get_List_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664353);
			Selectable.NativeMethodInfoPtr_AllSelectablesNoAlloc_Public_Static_Int32_Il2CppReferenceArray_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664354);
			Selectable.NativeMethodInfoPtr_get_navigation_Public_get_Navigation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664355);
			Selectable.NativeMethodInfoPtr_set_navigation_Public_set_Void_Navigation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664356);
			Selectable.NativeMethodInfoPtr_get_transition_Public_get_Transition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664357);
			Selectable.NativeMethodInfoPtr_set_transition_Public_set_Void_Transition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664358);
			Selectable.NativeMethodInfoPtr_get_colors_Public_get_ColorBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664359);
			Selectable.NativeMethodInfoPtr_set_colors_Public_set_Void_ColorBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664360);
			Selectable.NativeMethodInfoPtr_get_spriteState_Public_get_SpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664361);
			Selectable.NativeMethodInfoPtr_set_spriteState_Public_set_Void_SpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664362);
			Selectable.NativeMethodInfoPtr_get_animationTriggers_Public_get_AnimationTriggers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664363);
			Selectable.NativeMethodInfoPtr_set_animationTriggers_Public_set_Void_AnimationTriggers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664364);
			Selectable.NativeMethodInfoPtr_get_targetGraphic_Public_get_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664365);
			Selectable.NativeMethodInfoPtr_set_targetGraphic_Public_set_Void_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664366);
			Selectable.NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664367);
			Selectable.NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664368);
			Selectable.NativeMethodInfoPtr_get_isPointerInside_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664369);
			Selectable.NativeMethodInfoPtr_set_isPointerInside_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664370);
			Selectable.NativeMethodInfoPtr_get_isPointerDown_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664371);
			Selectable.NativeMethodInfoPtr_set_isPointerDown_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664372);
			Selectable.NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664373);
			Selectable.NativeMethodInfoPtr_set_hasSelection_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664374);
			Selectable.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664375);
			Selectable.NativeMethodInfoPtr_get_image_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664376);
			Selectable.NativeMethodInfoPtr_set_image_Public_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664377);
			Selectable.NativeMethodInfoPtr_get_animator_Public_get_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664378);
			Selectable.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664379);
			Selectable.NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664380);
			Selectable.NativeMethodInfoPtr_ParentGroupAllowsInteraction_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664381);
			Selectable.NativeMethodInfoPtr_IsInteractable_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664382);
			Selectable.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664383);
			Selectable.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664384);
			Selectable.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664385);
			Selectable.NativeMethodInfoPtr_OnSetProperty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664386);
			Selectable.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664387);
			Selectable.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664388);
			Selectable.NativeMethodInfoPtr_get_currentSelectionState_Protected_get_SelectionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664389);
			Selectable.NativeMethodInfoPtr_InstantClearState_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664390);
			Selectable.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_New_Void_SelectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664391);
			Selectable.NativeMethodInfoPtr_FindSelectable_Public_Selectable_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664392);
			Selectable.NativeMethodInfoPtr_GetPointOnRectEdge_Private_Static_Vector3_RectTransform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664393);
			Selectable.NativeMethodInfoPtr_Navigate_Private_Void_AxisEventData_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664394);
			Selectable.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_New_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664395);
			Selectable.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_New_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664396);
			Selectable.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_New_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664397);
			Selectable.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_New_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664398);
			Selectable.NativeMethodInfoPtr_OnMove_Public_Virtual_New_Void_AxisEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664399);
			Selectable.NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664400);
			Selectable.NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664401);
			Selectable.NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664402);
			Selectable.NativeMethodInfoPtr_IsHighlighted_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664403);
			Selectable.NativeMethodInfoPtr_IsPressed_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664404);
			Selectable.NativeMethodInfoPtr_EvaluateAndTransitionToSelectionState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664405);
			Selectable.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664406);
			Selectable.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664407);
			Selectable.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664408);
			Selectable.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664409);
			Selectable.NativeMethodInfoPtr_OnSelect_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664410);
			Selectable.NativeMethodInfoPtr_OnDeselect_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664411);
			Selectable.NativeMethodInfoPtr_Select_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664412);
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00020E84 File Offset: 0x0001F084
		public unsafe static Il2CppReferenceArray<Selectable> allSelectablesArray
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1091568, RefRangeEnd = 1091570, XrefRangeStart = 1091559, XrefRangeEnd = 1091568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_allSelectablesArray_Public_Static_get_Il2CppReferenceArray_1_Selectable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Selectable>>(intPtr3) : null;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00020EB8 File Offset: 0x0001F0B8
		public unsafe static int allSelectableCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091570, XrefRangeEnd = 1091574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_allSelectableCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00020EE8 File Offset: 0x0001F0E8
		public unsafe static List<Selectable> allSelectables
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091574, XrefRangeEnd = 1091592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_allSelectables_Public_Static_get_List_1_Selectable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Selectable>>(intPtr3) : null;
			}
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00020F1C File Offset: 0x0001F11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091592, XrefRangeEnd = 1091602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AllSelectablesNoAlloc(Il2CppReferenceArray<Selectable> selectables)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectables);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_AllSelectablesNoAlloc_Public_Static_Int32_Il2CppReferenceArray_1_Selectable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00020F60 File Offset: 0x0001F160
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00020F98 File Offset: 0x0001F198
		public unsafe Navigation navigation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_navigation_Public_get_Navigation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Navigation(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1091606, RefRangeEnd = 1091613, XrefRangeStart = 1091602, XrefRangeEnd = 1091606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_navigation_Public_set_Void_Navigation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00020FE0 File Offset: 0x0001F1E0
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x0002101C File Offset: 0x0001F21C
		public unsafe Selectable.Transition transition
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_transition_Public_get_Transition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091613, XrefRangeEnd = 1091617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_transition_Public_set_Void_Transition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x0002105C File Offset: 0x0001F25C
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x00021098 File Offset: 0x0001F298
		public unsafe ColorBlock colors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_colors_Public_get_ColorBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1091621, RefRangeEnd = 1091623, XrefRangeStart = 1091617, XrefRangeEnd = 1091621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_colors_Public_set_Void_ColorBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x000210D8 File Offset: 0x0001F2D8
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x00021110 File Offset: 0x0001F310
		public unsafe SpriteState spriteState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_spriteState_Public_get_SpriteState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SpriteState(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091623, XrefRangeEnd = 1091627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_spriteState_Public_set_Void_SpriteState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00021158 File Offset: 0x0001F358
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x00021198 File Offset: 0x0001F398
		public unsafe AnimationTriggers animationTriggers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_animationTriggers_Public_get_AnimationTriggers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationTriggers>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091627, XrefRangeEnd = 1091631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_animationTriggers_Public_set_Void_AnimationTriggers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x000211DC File Offset: 0x0001F3DC
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x0002121C File Offset: 0x0001F41C
		public unsafe Graphic targetGraphic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_targetGraphic_Public_get_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1091635, RefRangeEnd = 1091643, XrefRangeStart = 1091631, XrefRangeEnd = 1091635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_targetGraphic_Public_set_Void_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00021260 File Offset: 0x0001F460
		// (set) Token: 0x060006A2 RID: 1698 RVA: 0x0002129C File Offset: 0x0001F49C
		public unsafe bool interactable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(86)]
			[CachedScanResults(RefRangeStart = 1091666, RefRangeEnd = 1091752, XrefRangeStart = 1091643, XrefRangeEnd = 1091666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x000212DC File Offset: 0x0001F4DC
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x00021318 File Offset: 0x0001F518
		public unsafe bool isPointerInside
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_isPointerInside_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_isPointerInside_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x00021358 File Offset: 0x0001F558
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x00021394 File Offset: 0x0001F594
		public unsafe bool isPointerDown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_isPointerDown_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_isPointerDown_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x000213D4 File Offset: 0x0001F5D4
		// (set) Token: 0x060006A8 RID: 1704 RVA: 0x00021410 File Offset: 0x0001F610
		public unsafe bool hasSelection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_hasSelection_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00021450 File Offset: 0x0001F650
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1091770, RefRangeEnd = 1091778, XrefRangeStart = 1091752, XrefRangeEnd = 1091770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Selectable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Selectable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x0002148C File Offset: 0x0001F68C
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x000214CC File Offset: 0x0001F6CC
		public unsafe Image image
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1091779, RefRangeEnd = 1091783, XrefRangeStart = 1091778, XrefRangeEnd = 1091779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_image_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_image_Public_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00021510 File Offset: 0x0001F710
		public unsafe Animator animator
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1091786, RefRangeEnd = 1091792, XrefRangeStart = 1091783, XrefRangeEnd = 1091786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_animator_Public_get_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr3) : null;
			}
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00021550 File Offset: 0x0001F750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091792, XrefRangeEnd = 1091800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0002158C File Offset: 0x0001F78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091800, XrefRangeEnd = 1091802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCanvasGroupChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x000215C8 File Offset: 0x0001F7C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1091824, RefRangeEnd = 1091826, XrefRangeStart = 1091802, XrefRangeEnd = 1091824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParentGroupAllowsInteraction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_ParentGroupAllowsInteraction_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00021604 File Offset: 0x0001F804
		[CallerCount(0)]
		public unsafe virtual bool IsInteractable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_IsInteractable_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0002164C File Offset: 0x0001F84C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1091829, RefRangeEnd = 1091837, XrefRangeStart = 1091826, XrefRangeEnd = 1091829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00021688 File Offset: 0x0001F888
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1091878, RefRangeEnd = 1091883, XrefRangeStart = 1091837, XrefRangeEnd = 1091878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x000216C4 File Offset: 0x0001F8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091883, XrefRangeEnd = 1091884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00021700 File Offset: 0x0001F900
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1091829, RefRangeEnd = 1091837, XrefRangeStart = 1091829, XrefRangeEnd = 1091837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSetProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_OnSetProperty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00021734 File Offset: 0x0001F934
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1091895, RefRangeEnd = 1091902, XrefRangeStart = 1091884, XrefRangeEnd = 1091895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00021770 File Offset: 0x0001F970
		[CallerCount(0)]
		public unsafe void OnApplicationFocus(bool hasFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hasFocus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x000217B0 File Offset: 0x0001F9B0
		public unsafe Selectable.SelectionState currentSelectionState
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1091902, RefRangeEnd = 1091907, XrefRangeStart = 1091902, XrefRangeEnd = 1091902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_currentSelectionState_Protected_get_SelectionState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x000217EC File Offset: 0x0001F9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091907, XrefRangeEnd = 1091908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InstantClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_InstantClearState_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00021828 File Offset: 0x0001FA28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1091929, RefRangeEnd = 1091933, XrefRangeStart = 1091908, XrefRangeEnd = 1091929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instant;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_New_Void_SelectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00021880 File Offset: 0x0001FA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091933, XrefRangeEnd = 1091981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Selectable FindSelectable(Vector3 dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dir;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_FindSelectable_Public_Selectable_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x000218CC File Offset: 0x0001FACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1091989, RefRangeEnd = 1091990, XrefRangeStart = 1091981, XrefRangeEnd = 1091989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_GetPointOnRectEdge_Private_Static_Vector3_RectTransform_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0002191C File Offset: 0x0001FB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091990, XrefRangeEnd = 1091996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Navigate(AxisEventData eventData, Selectable sel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_Navigate_Private_Void_AxisEventData_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00021970 File Offset: 0x0001FB70
		[CallerCount(0)]
		public unsafe virtual Selectable FindSelectableOnLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_New_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x000219BC File Offset: 0x0001FBBC
		[CallerCount(0)]
		public unsafe virtual Selectable FindSelectableOnRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_New_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00021A08 File Offset: 0x0001FC08
		[CallerCount(0)]
		public unsafe virtual Selectable FindSelectableOnUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_New_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00021A54 File Offset: 0x0001FC54
		[CallerCount(0)]
		public unsafe virtual Selectable FindSelectableOnDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_New_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00021AA0 File Offset: 0x0001FCA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1092002, RefRangeEnd = 1092004, XrefRangeStart = 1091996, XrefRangeEnd = 1092002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnMove(AxisEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnMove_Public_Virtual_New_Void_AxisEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00021AF0 File Offset: 0x0001FCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092004, XrefRangeEnd = 1092012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartColorTween(Color targetColor, bool instant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetColor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instant;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00021B3C File Offset: 0x0001FD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092012, XrefRangeEnd = 1092019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoSpriteSwap(Sprite newSprite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00021B80 File Offset: 0x0001FD80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1092047, RefRangeEnd = 1092049, XrefRangeStart = 1092019, XrefRangeEnd = 1092047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerAnimation(string triggername)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(triggername);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00021BC4 File Offset: 0x0001FDC4
		[CallerCount(0)]
		public unsafe bool IsHighlighted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_IsHighlighted_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00021C00 File Offset: 0x0001FE00
		[CallerCount(0)]
		public unsafe bool IsPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_IsPressed_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00021C3C File Offset: 0x0001FE3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1092050, RefRangeEnd = 1092053, XrefRangeStart = 1092049, XrefRangeEnd = 1092050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateAndTransitionToSelectionState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_EvaluateAndTransitionToSelectionState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00021C70 File Offset: 0x0001FE70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1092067, RefRangeEnd = 1092071, XrefRangeStart = 1092053, XrefRangeEnd = 1092067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00021CC0 File Offset: 0x0001FEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092071, XrefRangeEnd = 1092072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00021D10 File Offset: 0x0001FF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092072, XrefRangeEnd = 1092073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00021D60 File Offset: 0x0001FF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092073, XrefRangeEnd = 1092074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00021DB0 File Offset: 0x0001FFB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1092075, RefRangeEnd = 1092078, XrefRangeStart = 1092074, XrefRangeEnd = 1092075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnSelect_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00021E00 File Offset: 0x00020000
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1092079, RefRangeEnd = 1092082, XrefRangeStart = 1092078, XrefRangeEnd = 1092079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnDeselect_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00021E50 File Offset: 0x00020050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092082, XrefRangeEnd = 1092098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Select()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_Select_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00004489 File Offset: 0x00002689
		public Selectable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x00021E8C File Offset: 0x0002008C
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x00004492 File Offset: 0x00002692
		public unsafe static Il2CppReferenceArray<Selectable> s_Selectables
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Selectable.NativeFieldInfoPtr_s_Selectables, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Selectable>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Selectable.NativeFieldInfoPtr_s_Selectables, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x00021EB4 File Offset: 0x000200B4
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x000044A4 File Offset: 0x000026A4
		public unsafe static int s_SelectableCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Selectable.NativeFieldInfoPtr_s_SelectableCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Selectable.NativeFieldInfoPtr_s_SelectableCount, (void*)(&value));
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00021ED0 File Offset: 0x000200D0
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x000044B2 File Offset: 0x000026B2
		public unsafe bool m_EnableCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_EnableCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_EnableCalled)) = value;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00021EF8 File Offset: 0x000200F8
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x000044CD File Offset: 0x000026CD
		public Navigation m_Navigation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Navigation);
				return new Navigation(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Navigation>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Navigation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Navigation>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00021F28 File Offset: 0x00020128
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x000044FB File Offset: 0x000026FB
		public unsafe Selectable.Transition m_Transition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Transition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Transition)) = value;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x00021F50 File Offset: 0x00020150
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x00004516 File Offset: 0x00002716
		public unsafe ColorBlock m_Colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Colors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Colors)) = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x00021F78 File Offset: 0x00020178
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x00004531 File Offset: 0x00002731
		public SpriteState m_SpriteState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_SpriteState);
				return new SpriteState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_SpriteState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00021FA8 File Offset: 0x000201A8
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x0000455F File Offset: 0x0000275F
		public unsafe AnimationTriggers m_AnimationTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_AnimationTriggers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationTriggers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_AnimationTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00021FD8 File Offset: 0x000201D8
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x0000457E File Offset: 0x0000277E
		public unsafe bool m_Interactable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Interactable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Interactable)) = value;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00022000 File Offset: 0x00020200
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x00004599 File Offset: 0x00002799
		public unsafe Graphic m_TargetGraphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_TargetGraphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_TargetGraphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x00022030 File Offset: 0x00020230
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x000045B8 File Offset: 0x000027B8
		public unsafe bool m_GroupsAllowInteraction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_GroupsAllowInteraction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_GroupsAllowInteraction)) = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00022058 File Offset: 0x00020258
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x000045D3 File Offset: 0x000027D3
		public unsafe int m_CurrentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_CurrentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_CurrentIndex)) = value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00022080 File Offset: 0x00020280
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x000045EE File Offset: 0x000027EE
		public unsafe bool _isPointerInside_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr__isPointerInside_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr__isPointerInside_k__BackingField)) = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x000220A8 File Offset: 0x000202A8
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x00004609 File Offset: 0x00002809
		public unsafe bool _isPointerDown_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr__isPointerDown_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr__isPointerDown_k__BackingField)) = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x000220D0 File Offset: 0x000202D0
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x00004624 File Offset: 0x00002824
		public unsafe bool _hasSelection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr__hasSelection_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr__hasSelection_k__BackingField)) = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x000220F8 File Offset: 0x000202F8
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x0000463F File Offset: 0x0000283F
		public unsafe List<CanvasGroup> m_CanvasGroupCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_CanvasGroupCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CanvasGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_CanvasGroupCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeFieldInfoPtr_s_Selectables;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeFieldInfoPtr_s_SelectableCount;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeFieldInfoPtr_m_EnableCalled;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeFieldInfoPtr_m_Navigation;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeFieldInfoPtr_m_Transition;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeFieldInfoPtr_m_Colors;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteState;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimationTriggers;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeFieldInfoPtr_m_Interactable;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetGraphic;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeFieldInfoPtr_m_GroupsAllowInteraction;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentIndex;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeFieldInfoPtr__isPointerInside_k__BackingField;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeFieldInfoPtr__isPointerDown_k__BackingField;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeFieldInfoPtr__hasSelection_k__BackingField;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeFieldInfoPtr_m_CanvasGroupCache;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_get_allSelectablesArray_Public_Static_get_Il2CppReferenceArray_1_Selectable_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_get_allSelectableCount_Public_Static_get_Int32_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_get_allSelectables_Public_Static_get_List_1_Selectable_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_AllSelectablesNoAlloc_Public_Static_Int32_Il2CppReferenceArray_1_Selectable_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_get_navigation_Public_get_Navigation_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_set_navigation_Public_set_Void_Navigation_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_get_transition_Public_get_Transition_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_set_transition_Public_set_Void_Transition_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_get_colors_Public_get_ColorBlock_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_set_colors_Public_set_Void_ColorBlock_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteState_Public_get_SpriteState_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteState_Public_set_Void_SpriteState_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_get_animationTriggers_Public_get_AnimationTriggers_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_set_animationTriggers_Public_set_Void_AnimationTriggers_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_get_targetGraphic_Public_get_Graphic_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_set_targetGraphic_Public_set_Void_Graphic_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_get_isPointerInside_Private_get_Boolean_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_set_isPointerInside_Private_set_Void_Boolean_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_get_isPointerDown_Private_get_Boolean_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_set_isPointerDown_Private_set_Void_Boolean_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_set_hasSelection_Private_set_Void_Boolean_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_get_image_Public_get_Image_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_set_image_Public_set_Void_Image_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_get_animator_Public_get_Animator_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_ParentGroupAllowsInteraction_Private_Boolean_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_IsInteractable_Public_Virtual_New_Boolean_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_OnSetProperty_Private_Void_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_get_currentSelectionState_Protected_get_SelectionState_0;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_InstantClearState_Protected_Virtual_New_Void_0;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_New_Void_SelectionState_Boolean_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectable_Public_Selectable_Vector3_0;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr_GetPointOnRectEdge_Private_Static_Vector3_RectTransform_Vector2_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr_Navigate_Private_Void_AxisEventData_Selectable_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_New_Selectable_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_New_Selectable_0;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_New_Selectable_0;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_New_Selectable_0;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_OnMove_Public_Virtual_New_Void_AxisEventData_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeMethodInfoPtr_IsHighlighted_Protected_Boolean_0;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeMethodInfoPtr_IsPressed_Protected_Boolean_0;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateAndTransitionToSelectionState_Private_Void_0;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_New_Void_0;

		// Token: 0x020000B0 RID: 176
		public enum Transition
		{
			// Token: 0x040009F7 RID: 2551
			None,
			// Token: 0x040009F8 RID: 2552
			ColorTint,
			// Token: 0x040009F9 RID: 2553
			SpriteSwap,
			// Token: 0x040009FA RID: 2554
			Animation
		}

		// Token: 0x020000B1 RID: 177
		public enum SelectionState
		{
			// Token: 0x040009FC RID: 2556
			Normal,
			// Token: 0x040009FD RID: 2557
			Highlighted,
			// Token: 0x040009FE RID: 2558
			Pressed,
			// Token: 0x040009FF RID: 2559
			Selected,
			// Token: 0x04000A00 RID: 2560
			Disabled
		}
	}
}
