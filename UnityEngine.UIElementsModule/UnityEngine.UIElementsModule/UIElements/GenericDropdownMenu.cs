using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200005D RID: 93
	public class GenericDropdownMenu : Object
	{
		// Token: 0x06000869 RID: 2153 RVA: 0x0003AEF4 File Offset: 0x000390F4
		// Note: this type is marked as 'beforefieldinit'.
		static GenericDropdownMenu()
		{
			Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "GenericDropdownMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr);
			GenericDropdownMenu.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "ussClassName");
			GenericDropdownMenu.NativeFieldInfoPtr_itemUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "itemUssClassName");
			GenericDropdownMenu.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "labelUssClassName");
			GenericDropdownMenu.NativeFieldInfoPtr_containerInnerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "containerInnerUssClassName");
			GenericDropdownMenu.NativeFieldInfoPtr_containerOuterUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "containerOuterUssClassName");
			GenericDropdownMenu.NativeFieldInfoPtr_checkmarkUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "checkmarkUssClassName");
			GenericDropdownMenu.NativeFieldInfoPtr_separatorUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "separatorUssClassName");
			GenericDropdownMenu.NativeFieldInfoPtr_m_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "m_Items");
			GenericDropdownMenu.NativeFieldInfoPtr_m_MenuContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "m_MenuContainer");
			GenericDropdownMenu.NativeFieldInfoPtr_m_OuterContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "m_OuterContainer");
			GenericDropdownMenu.NativeFieldInfoPtr_m_ScrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "m_ScrollView");
			GenericDropdownMenu.NativeFieldInfoPtr_m_PanelRootVisualContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "m_PanelRootVisualContainer");
			GenericDropdownMenu.NativeFieldInfoPtr_m_TargetElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "m_TargetElement");
			GenericDropdownMenu.NativeFieldInfoPtr_m_DesiredRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "m_DesiredRect");
			GenericDropdownMenu.NativeFieldInfoPtr_m_NavigationManipulator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "m_NavigationManipulator");
			GenericDropdownMenu.NativeFieldInfoPtr__isSingleSelectionDropdown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "<isSingleSelectionDropdown>k__BackingField");
			GenericDropdownMenu.NativeFieldInfoPtr__closeOnParentResize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "<closeOnParentResize>k__BackingField");
			GenericDropdownMenu.NativeFieldInfoPtr_m_MousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "m_MousePosition");
			GenericDropdownMenu.NativeMethodInfoPtr_get_isSingleSelectionDropdown_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664519);
			GenericDropdownMenu.NativeMethodInfoPtr_set_isSingleSelectionDropdown_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664520);
			GenericDropdownMenu.NativeMethodInfoPtr_get_closeOnParentResize_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664521);
			GenericDropdownMenu.NativeMethodInfoPtr_set_closeOnParentResize_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664522);
			GenericDropdownMenu.NativeMethodInfoPtr_get_contentContainer_Public_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664523);
			GenericDropdownMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664524);
			GenericDropdownMenu.NativeMethodInfoPtr_OnAttachToPanel_Private_Void_AttachToPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664525);
			GenericDropdownMenu.NativeMethodInfoPtr_OnDetachFromPanel_Private_Void_DetachFromPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664526);
			GenericDropdownMenu.NativeMethodInfoPtr_Hide_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664527);
			GenericDropdownMenu.NativeMethodInfoPtr_Apply_Private_Void_KeyboardNavigationOperation_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664528);
			GenericDropdownMenu.NativeMethodInfoPtr_Apply_Private_Boolean_KeyboardNavigationOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664529);
			GenericDropdownMenu.NativeMethodInfoPtr_OnPointerDown_Private_Void_PointerDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664530);
			GenericDropdownMenu.NativeMethodInfoPtr_OnPointerMove_Private_Void_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664531);
			GenericDropdownMenu.NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664532);
			GenericDropdownMenu.NativeMethodInfoPtr_OnFocusOut_Private_Void_FocusOutEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664533);
			GenericDropdownMenu.NativeMethodInfoPtr_OnParentResized_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664534);
			GenericDropdownMenu.NativeMethodInfoPtr_UpdateSelection_Private_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664535);
			GenericDropdownMenu.NativeMethodInfoPtr_ChangeSelectedIndex_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664536);
			GenericDropdownMenu.NativeMethodInfoPtr_GetSelectedIndex_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664537);
			GenericDropdownMenu.NativeMethodInfoPtr_AddItem_Public_Virtual_Final_New_Void_String_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664538);
			GenericDropdownMenu.NativeMethodInfoPtr_AddItem_Public_Virtual_Final_New_Void_String_Boolean_Action_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664539);
			GenericDropdownMenu.NativeMethodInfoPtr_AddSeparator_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664540);
			GenericDropdownMenu.NativeMethodInfoPtr_AddItem_Private_MenuItem_String_Boolean_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664541);
			GenericDropdownMenu.NativeMethodInfoPtr_DropDown_Public_Virtual_Final_New_Void_Rect_VisualElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664542);
			GenericDropdownMenu.NativeMethodInfoPtr_OnTargetElementDetachFromPanel_Private_Void_DetachFromPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664543);
			GenericDropdownMenu.NativeMethodInfoPtr_OnContainerGeometryChanged_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664544);
			GenericDropdownMenu.NativeMethodInfoPtr_EnsureVisibilityInParent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664545);
			GenericDropdownMenu.NativeMethodInfoPtr_Method_Private_Void_Int32_byref___c__DisplayClass39_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664547);
			GenericDropdownMenu.NativeMethodInfoPtr_Method_Private_Void_Int32_byref___c__DisplayClass39_0_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, 100664548);
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x0003B2D0 File Offset: 0x000394D0
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x0003B30C File Offset: 0x0003950C
		public unsafe bool isSingleSelectionDropdown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_get_isSingleSelectionDropdown_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_set_isSingleSelectionDropdown_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0003B34C File Offset: 0x0003954C
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x0003B388 File Offset: 0x00039588
		public unsafe bool closeOnParentResize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_get_closeOnParentResize_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_set_closeOnParentResize_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x0003B3C8 File Offset: 0x000395C8
		public unsafe VisualElement contentContainer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294454, XrefRangeEnd = 294469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_get_contentContainer_Public_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0003B408 File Offset: 0x00039608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294522, RefRangeEnd = 294523, XrefRangeStart = 294469, XrefRangeEnd = 294522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericDropdownMenu()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0003B444 File Offset: 0x00039644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294523, XrefRangeEnd = 294591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAttachToPanel(AttachToPanelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_OnAttachToPanel_Private_Void_AttachToPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0003B488 File Offset: 0x00039688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294591, XrefRangeEnd = 294648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDetachFromPanel(DetachFromPanelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_OnDetachFromPanel_Private_Void_DetachFromPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0003B4CC File Offset: 0x000396CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 294653, RefRangeEnd = 294656, XrefRangeStart = 294648, XrefRangeEnd = 294653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide(bool giveFocusBack = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref giveFocusBack;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_Hide_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0003B50C File Offset: 0x0003970C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294656, XrefRangeEnd = 294659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply(KeyboardNavigationOperation op, EventBase sourceEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_Apply_Private_Void_KeyboardNavigationOperation_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0003B55C File Offset: 0x0003975C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294664, RefRangeEnd = 294665, XrefRangeStart = 294659, XrefRangeEnd = 294664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Apply(KeyboardNavigationOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_Apply_Private_Boolean_KeyboardNavigationOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0003B5A8 File Offset: 0x000397A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294665, XrefRangeEnd = 294682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerDown(PointerDownEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_OnPointerDown_Private_Void_PointerDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0003B5EC File Offset: 0x000397EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294682, XrefRangeEnd = 294699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerMove(PointerMoveEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_OnPointerMove_Private_Void_PointerMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0003B630 File Offset: 0x00039830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294699, XrefRangeEnd = 294714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerUp(PointerUpEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x0003B674 File Offset: 0x00039874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294714, XrefRangeEnd = 294722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFocusOut(FocusOutEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_OnFocusOut_Private_Void_FocusOutEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x0003B6B8 File Offset: 0x000398B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294722, XrefRangeEnd = 294723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnParentResized(GeometryChangedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_OnParentResized_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0003B6FC File Offset: 0x000398FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294732, RefRangeEnd = 294734, XrefRangeStart = 294723, XrefRangeEnd = 294732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSelection(VisualElement target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_UpdateSelection_Private_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0003B740 File Offset: 0x00039940
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294747, RefRangeEnd = 294748, XrefRangeStart = 294734, XrefRangeEnd = 294747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeSelectedIndex(int newIndex, int previousIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_ChangeSelectedIndex_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0003B78C File Offset: 0x0003998C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 294754, RefRangeEnd = 294757, XrefRangeStart = 294748, XrefRangeEnd = 294754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSelectedIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_GetSelectedIndex_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0003B7C8 File Offset: 0x000399C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294757, XrefRangeEnd = 294759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddItem(string itemName, bool isChecked, Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isChecked;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_AddItem_Public_Virtual_Final_New_Void_String_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0003B82C File Offset: 0x00039A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294759, XrefRangeEnd = 294761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddItem(string itemName, bool isChecked, Action<Object> action, Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isChecked;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_AddItem_Public_Virtual_Final_New_Void_String_Boolean_Action_1_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0003B8A4 File Offset: 0x00039AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294761, XrefRangeEnd = 294773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddSeparator(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_AddSeparator_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0003B8E8 File Offset: 0x00039AE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294837, RefRangeEnd = 294839, XrefRangeStart = 294773, XrefRangeEnd = 294837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericDropdownMenu.MenuItem AddItem(string itemName, bool isChecked, bool isEnabled, Object data = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isChecked;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEnabled;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_AddItem_Private_MenuItem_String_Boolean_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GenericDropdownMenu.MenuItem>(intPtr3) : null;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0003B968 File Offset: 0x00039B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294839, XrefRangeEnd = 294927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DropDown(Rect position, VisualElement targetElement = null, bool anchored = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetElement);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchored;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_DropDown_Public_Virtual_Final_New_Void_Rect_VisualElement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x0003B9C8 File Offset: 0x00039BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294927, XrefRangeEnd = 294932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTargetElementDetachFromPanel(DetachFromPanelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_OnTargetElementDetachFromPanel_Private_Void_DetachFromPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0003BA0C File Offset: 0x00039C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294932, XrefRangeEnd = 294933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnContainerGeometryChanged(GeometryChangedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_OnContainerGeometryChanged_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0003BA50 File Offset: 0x00039C50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294971, RefRangeEnd = 294973, XrefRangeStart = 294933, XrefRangeEnd = 294971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureVisibilityInParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_EnsureVisibilityInParent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0003BA84 File Offset: 0x00039C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294973, XrefRangeEnd = 294979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Int32_byref___c__DisplayClass39_0_PDM_0(int newIndex, ref GenericDropdownMenu.__c__DisplayClass39_0 A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_Method_Private_Void_Int32_byref___c__DisplayClass39_0_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x0003BAD8 File Offset: 0x00039CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294979, XrefRangeEnd = 294982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Int32_byref___c__DisplayClass39_0_PDM_1(int newIndex, ref GenericDropdownMenu.__c__DisplayClass39_0 A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.NativeMethodInfoPtr_Method_Private_Void_Int32_byref___c__DisplayClass39_0_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00004EEA File Offset: 0x000030EA
		public GenericDropdownMenu(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x0003BB2C File Offset: 0x00039D2C
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x00004EF3 File Offset: 0x000030F3
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GenericDropdownMenu.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GenericDropdownMenu.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x0003BB4C File Offset: 0x00039D4C
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x00004F05 File Offset: 0x00003105
		public unsafe static string itemUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GenericDropdownMenu.NativeFieldInfoPtr_itemUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GenericDropdownMenu.NativeFieldInfoPtr_itemUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x0003BB6C File Offset: 0x00039D6C
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x00004F17 File Offset: 0x00003117
		public unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GenericDropdownMenu.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GenericDropdownMenu.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x0003BB8C File Offset: 0x00039D8C
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x00004F29 File Offset: 0x00003129
		public unsafe static string containerInnerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GenericDropdownMenu.NativeFieldInfoPtr_containerInnerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GenericDropdownMenu.NativeFieldInfoPtr_containerInnerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x0003BBAC File Offset: 0x00039DAC
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x00004F3B File Offset: 0x0000313B
		public unsafe static string containerOuterUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GenericDropdownMenu.NativeFieldInfoPtr_containerOuterUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GenericDropdownMenu.NativeFieldInfoPtr_containerOuterUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x0003BBCC File Offset: 0x00039DCC
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x00004F4D File Offset: 0x0000314D
		public unsafe static string checkmarkUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GenericDropdownMenu.NativeFieldInfoPtr_checkmarkUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GenericDropdownMenu.NativeFieldInfoPtr_checkmarkUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x0003BBEC File Offset: 0x00039DEC
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x00004F5F File Offset: 0x0000315F
		public unsafe static string separatorUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GenericDropdownMenu.NativeFieldInfoPtr_separatorUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GenericDropdownMenu.NativeFieldInfoPtr_separatorUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x0003BC0C File Offset: 0x00039E0C
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x00004F71 File Offset: 0x00003171
		public unsafe List<GenericDropdownMenu.MenuItem> m_Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr_m_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GenericDropdownMenu.MenuItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr_m_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x0003BC3C File Offset: 0x00039E3C
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x00004F90 File Offset: 0x00003190
		public unsafe VisualElement m_MenuContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr_m_MenuContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr_m_MenuContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x0003BC6C File Offset: 0x00039E6C
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x00004FAF File Offset: 0x000031AF
		public unsafe VisualElement m_OuterContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr_m_OuterContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr_m_OuterContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x0003BC9C File Offset: 0x00039E9C
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x00004FCE File Offset: 0x000031CE
		public unsafe ScrollView m_ScrollView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr_m_ScrollView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr_m_ScrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0003BCCC File Offset: 0x00039ECC
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x00004FED File Offset: 0x000031ED
		public unsafe VisualElement m_PanelRootVisualContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr_m_PanelRootVisualContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr_m_PanelRootVisualContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x0003BCFC File Offset: 0x00039EFC
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x0000500C File Offset: 0x0000320C
		public unsafe VisualElement m_TargetElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr_m_TargetElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr_m_TargetElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x0003BD2C File Offset: 0x00039F2C
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x0000502B File Offset: 0x0000322B
		public unsafe Rect m_DesiredRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr_m_DesiredRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr_m_DesiredRect)) = value;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x0003BD54 File Offset: 0x00039F54
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x00005046 File Offset: 0x00003246
		public unsafe KeyboardNavigationManipulator m_NavigationManipulator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr_m_NavigationManipulator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyboardNavigationManipulator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr_m_NavigationManipulator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x0003BD84 File Offset: 0x00039F84
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x00005065 File Offset: 0x00003265
		public unsafe bool _isSingleSelectionDropdown_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr__isSingleSelectionDropdown_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr__isSingleSelectionDropdown_k__BackingField)) = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x0003BDAC File Offset: 0x00039FAC
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x00005080 File Offset: 0x00003280
		public unsafe bool _closeOnParentResize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr__closeOnParentResize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr__closeOnParentResize_k__BackingField)) = value;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x0003BDD4 File Offset: 0x00039FD4
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x0000509B File Offset: 0x0000329B
		public unsafe Vector2 m_MousePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr_m_MousePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.NativeFieldInfoPtr_m_MousePosition)) = value;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x000050B6 File Offset: 0x000032B6
		public List<GenericDropdownMenu.MenuItem> items
		{
			get
			{
				return this.m_Items;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x000050BE File Offset: 0x000032BE
		public VisualElement menuContainer
		{
			get
			{
				return this.m_MenuContainer;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x000050C6 File Offset: 0x000032C6
		public VisualElement outerContainer
		{
			get
			{
				return this.m_OuterContainer;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x000050CE File Offset: 0x000032CE
		public ScrollView scrollView
		{
			get
			{
				return this.m_ScrollView;
			}
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x000050D6 File Offset: 0x000032D6
		public void AddDisabledItem(string itemName, bool isChecked)
		{
			this.AddItem(itemName, isChecked, false, null);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x000050E4 File Offset: 0x000032E4
		public void UpdateItem(string itemName, bool isChecked)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeFieldInfoPtr_itemUssClassName;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeFieldInfoPtr_containerInnerUssClassName;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeFieldInfoPtr_containerOuterUssClassName;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeFieldInfoPtr_checkmarkUssClassName;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeFieldInfoPtr_separatorUssClassName;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeFieldInfoPtr_m_Items;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeFieldInfoPtr_m_MenuContainer;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeFieldInfoPtr_m_OuterContainer;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollView;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeFieldInfoPtr_m_PanelRootVisualContainer;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetElement;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeFieldInfoPtr_m_DesiredRect;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeFieldInfoPtr_m_NavigationManipulator;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeFieldInfoPtr__isSingleSelectionDropdown_k__BackingField;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeFieldInfoPtr__closeOnParentResize_k__BackingField;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeFieldInfoPtr_m_MousePosition;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_get_isSingleSelectionDropdown_Internal_get_Boolean_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_set_isSingleSelectionDropdown_Internal_set_Void_Boolean_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_get_closeOnParentResize_Internal_get_Boolean_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_set_closeOnParentResize_Internal_set_Void_Boolean_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_get_contentContainer_Public_get_VisualElement_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr_OnAttachToPanel_Private_Void_AttachToPanelEvent_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_OnDetachFromPanel_Private_Void_DetachFromPanelEvent_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Private_Void_Boolean_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Private_Void_KeyboardNavigationOperation_EventBase_0;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Private_Boolean_KeyboardNavigationOperation_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Private_Void_PointerDownEvent_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerMove_Private_Void_PointerMoveEvent_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_OnFocusOut_Private_Void_FocusOutEvent_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_OnParentResized_Private_Void_GeometryChangedEvent_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSelection_Private_Void_VisualElement_0;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_ChangeSelectedIndex_Private_Void_Int32_Int32_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectedIndex_Private_Int32_0;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Virtual_Final_New_Void_String_Boolean_Action_0;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Virtual_Final_New_Void_String_Boolean_Action_1_Object_Object_0;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr_AddSeparator_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Private_MenuItem_String_Boolean_Boolean_Object_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_DropDown_Public_Virtual_Final_New_Void_Rect_VisualElement_Boolean_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_OnTargetElementDetachFromPanel_Private_Void_DetachFromPanelEvent_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_OnContainerGeometryChanged_Private_Void_GeometryChangedEvent_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr_EnsureVisibilityInParent_Private_Void_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Int32_byref___c__DisplayClass39_0_PDM_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Int32_byref___c__DisplayClass39_0_PDM_1;

		// Token: 0x02000376 RID: 886
		public class MenuItem : Object
		{
			// Token: 0x060037AD RID: 14253 RVA: 0x000E41D4 File Offset: 0x000E23D4
			// Note: this type is marked as 'beforefieldinit'.
			static MenuItem()
			{
				Il2CppClassPointerStore<GenericDropdownMenu.MenuItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "MenuItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericDropdownMenu.MenuItem>.NativeClassPtr);
				GenericDropdownMenu.MenuItem.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu.MenuItem>.NativeClassPtr, "name");
				GenericDropdownMenu.MenuItem.NativeFieldInfoPtr_element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu.MenuItem>.NativeClassPtr, "element");
				GenericDropdownMenu.MenuItem.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu.MenuItem>.NativeClassPtr, "action");
				GenericDropdownMenu.MenuItem.NativeFieldInfoPtr_actionUserData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu.MenuItem>.NativeClassPtr, "actionUserData");
				GenericDropdownMenu.MenuItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDropdownMenu.MenuItem>.NativeClassPtr, 100664549);
			}

			// Token: 0x060037AE RID: 14254 RVA: 0x000E4264 File Offset: 0x000E2464
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MenuItem()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericDropdownMenu.MenuItem>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDropdownMenu.MenuItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037AF RID: 14255 RVA: 0x00017079 File Offset: 0x00015279
			public MenuItem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001132 RID: 4402
			// (get) Token: 0x060037B0 RID: 14256 RVA: 0x000E42A0 File Offset: 0x000E24A0
			// (set) Token: 0x060037B1 RID: 14257 RVA: 0x00017082 File Offset: 0x00015282
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.MenuItem.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.MenuItem.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001133 RID: 4403
			// (get) Token: 0x060037B2 RID: 14258 RVA: 0x000E42C8 File Offset: 0x000E24C8
			// (set) Token: 0x060037B3 RID: 14259 RVA: 0x000170A1 File Offset: 0x000152A1
			public unsafe VisualElement element
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.MenuItem.NativeFieldInfoPtr_element);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.MenuItem.NativeFieldInfoPtr_element), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001134 RID: 4404
			// (get) Token: 0x060037B4 RID: 14260 RVA: 0x000E42F8 File Offset: 0x000E24F8
			// (set) Token: 0x060037B5 RID: 14261 RVA: 0x000170C0 File Offset: 0x000152C0
			public unsafe Action action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.MenuItem.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.MenuItem.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001135 RID: 4405
			// (get) Token: 0x060037B6 RID: 14262 RVA: 0x000E4328 File Offset: 0x000E2528
			// (set) Token: 0x060037B7 RID: 14263 RVA: 0x000170DF File Offset: 0x000152DF
			public unsafe Action<Object> actionUserData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.MenuItem.NativeFieldInfoPtr_actionUserData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.MenuItem.NativeFieldInfoPtr_actionUserData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040027A9 RID: 10153
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x040027AA RID: 10154
			private static readonly IntPtr NativeFieldInfoPtr_element;

			// Token: 0x040027AB RID: 10155
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x040027AC RID: 10156
			private static readonly IntPtr NativeFieldInfoPtr_actionUserData;

			// Token: 0x040027AD RID: 10157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000377 RID: 887
		[ObfuscatedName("UnityEngine.UIElements.GenericDropdownMenu+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : ValueType
		{
			// Token: 0x060037B8 RID: 14264 RVA: 0x000E4358 File Offset: 0x000E2558
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<GenericDropdownMenu.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericDropdownMenu>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericDropdownMenu.__c__DisplayClass39_0>.NativeClassPtr);
				GenericDropdownMenu.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
				GenericDropdownMenu.__c__DisplayClass39_0.NativeFieldInfoPtr_selectedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDropdownMenu.__c__DisplayClass39_0>.NativeClassPtr, "selectedIndex");
			}

			// Token: 0x060037B9 RID: 14265 RVA: 0x000170FE File Offset: 0x000152FE
			public __c__DisplayClass39_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060037BA RID: 14266 RVA: 0x00017107 File Offset: 0x00015307
			public __c__DisplayClass39_0()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericDropdownMenu.__c__DisplayClass39_0>.NativeClassPtr))
			{
			}

			// Token: 0x17001136 RID: 4406
			// (get) Token: 0x060037BB RID: 14267 RVA: 0x000E43AC File Offset: 0x000E25AC
			// (set) Token: 0x060037BC RID: 14268 RVA: 0x00017119 File Offset: 0x00015319
			public unsafe GenericDropdownMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericDropdownMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001137 RID: 4407
			// (get) Token: 0x060037BD RID: 14269 RVA: 0x000E43DC File Offset: 0x000E25DC
			// (set) Token: 0x060037BE RID: 14270 RVA: 0x00017138 File Offset: 0x00015338
			public unsafe int selectedIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.__c__DisplayClass39_0.NativeFieldInfoPtr_selectedIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDropdownMenu.__c__DisplayClass39_0.NativeFieldInfoPtr_selectedIndex)) = value;
				}
			}

			// Token: 0x040027AE RID: 10158
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040027AF RID: 10159
			private static readonly IntPtr NativeFieldInfoPtr_selectedIndex;
		}

		// Token: 0x02000378 RID: 888
		public sealed class <>c__DisplayClass54_0
		{
		}
	}
}
