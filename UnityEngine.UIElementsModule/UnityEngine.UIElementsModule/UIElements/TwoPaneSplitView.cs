using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000094 RID: 148
	public class TwoPaneSplitView : VisualElement
	{
		// Token: 0x06000ECD RID: 3789 RVA: 0x00051298 File Offset: 0x0004F498
		// Note: this type is marked as 'beforefieldinit'.
		static TwoPaneSplitView()
		{
			Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TwoPaneSplitView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr);
			TwoPaneSplitView.NativeFieldInfoPtr_s_UssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "s_UssClassName");
			TwoPaneSplitView.NativeFieldInfoPtr_s_ContentContainerClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "s_ContentContainerClassName");
			TwoPaneSplitView.NativeFieldInfoPtr_s_HandleDragLineClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "s_HandleDragLineClassName");
			TwoPaneSplitView.NativeFieldInfoPtr_s_HandleDragLineVerticalClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "s_HandleDragLineVerticalClassName");
			TwoPaneSplitView.NativeFieldInfoPtr_s_HandleDragLineHorizontalClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "s_HandleDragLineHorizontalClassName");
			TwoPaneSplitView.NativeFieldInfoPtr_s_HandleDragLineAnchorClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "s_HandleDragLineAnchorClassName");
			TwoPaneSplitView.NativeFieldInfoPtr_s_HandleDragLineAnchorVerticalClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "s_HandleDragLineAnchorVerticalClassName");
			TwoPaneSplitView.NativeFieldInfoPtr_s_HandleDragLineAnchorHorizontalClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "s_HandleDragLineAnchorHorizontalClassName");
			TwoPaneSplitView.NativeFieldInfoPtr_s_VerticalClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "s_VerticalClassName");
			TwoPaneSplitView.NativeFieldInfoPtr_s_HorizontalClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "s_HorizontalClassName");
			TwoPaneSplitView.NativeFieldInfoPtr_m_LeftPane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "m_LeftPane");
			TwoPaneSplitView.NativeFieldInfoPtr_m_RightPane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "m_RightPane");
			TwoPaneSplitView.NativeFieldInfoPtr_m_FixedPane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "m_FixedPane");
			TwoPaneSplitView.NativeFieldInfoPtr_m_FlexedPane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "m_FlexedPane");
			TwoPaneSplitView.NativeFieldInfoPtr_m_FixedPaneDimension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "m_FixedPaneDimension");
			TwoPaneSplitView.NativeFieldInfoPtr_m_DragLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "m_DragLine");
			TwoPaneSplitView.NativeFieldInfoPtr_m_DragLineAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "m_DragLineAnchor");
			TwoPaneSplitView.NativeFieldInfoPtr_m_CollapseMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "m_CollapseMode");
			TwoPaneSplitView.NativeFieldInfoPtr_m_CollapseChildCalledBeforeSetupComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "m_CollapseChildCalledBeforeSetupComplete");
			TwoPaneSplitView.NativeFieldInfoPtr_m_CollapsedChildIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "m_CollapsedChildIndex");
			TwoPaneSplitView.NativeFieldInfoPtr_m_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "m_Content");
			TwoPaneSplitView.NativeFieldInfoPtr_m_Orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "m_Orientation");
			TwoPaneSplitView.NativeFieldInfoPtr_m_FixedPaneIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "m_FixedPaneIndex");
			TwoPaneSplitView.NativeFieldInfoPtr_m_FixedPaneInitialDimension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "m_FixedPaneInitialDimension");
			TwoPaneSplitView.NativeFieldInfoPtr_m_Resizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "m_Resizer");
			TwoPaneSplitView.NativeMethodInfoPtr_get_fixedPane_Public_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665397);
			TwoPaneSplitView.NativeMethodInfoPtr_get_flexedPane_Public_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665398);
			TwoPaneSplitView.NativeMethodInfoPtr_get_dragLine_Internal_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665399);
			TwoPaneSplitView.NativeMethodInfoPtr_get_fixedPaneIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665400);
			TwoPaneSplitView.NativeMethodInfoPtr_get_orientation_Public_get_TwoPaneSplitViewOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665401);
			TwoPaneSplitView.NativeMethodInfoPtr_get_fixedPaneDimension_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665402);
			TwoPaneSplitView.NativeMethodInfoPtr_set_fixedPaneDimension_Internal_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665403);
			TwoPaneSplitView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665404);
			TwoPaneSplitView.NativeMethodInfoPtr_CollapseChild_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665405);
			TwoPaneSplitView.NativeMethodInfoPtr_Init_Internal_Void_Int32_Single_TwoPaneSplitViewOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665406);
			TwoPaneSplitView.NativeMethodInfoPtr_OnPostDisplaySetup_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665407);
			TwoPaneSplitView.NativeMethodInfoPtr_ReplacePanesBasedOnAnchor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665408);
			TwoPaneSplitView.NativeMethodInfoPtr_OnAnchorPostDisplaySetup_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665409);
			TwoPaneSplitView.NativeMethodInfoPtr_IdentifyLeftAndRightPane_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665410);
			TwoPaneSplitView.NativeMethodInfoPtr_PostDisplaySetup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665411);
			TwoPaneSplitView.NativeMethodInfoPtr_OnSizeChange_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665412);
			TwoPaneSplitView.NativeMethodInfoPtr_UpdateLayout_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665413);
			TwoPaneSplitView.NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665414);
			TwoPaneSplitView.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665415);
			TwoPaneSplitView.NativeMethodInfoPtr_SetDragLineOffset_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665416);
			TwoPaneSplitView.NativeMethodInfoPtr_SetFixedPaneDimension_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, 100665417);
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x00051660 File Offset: 0x0004F860
		public unsafe VisualElement fixedPane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.NativeMethodInfoPtr_get_fixedPane_Public_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x000516A0 File Offset: 0x0004F8A0
		public unsafe VisualElement flexedPane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.NativeMethodInfoPtr_get_flexedPane_Public_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x000516E0 File Offset: 0x0004F8E0
		public unsafe VisualElement dragLine
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.NativeMethodInfoPtr_get_dragLine_Internal_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x00051720 File Offset: 0x0004F920
		// (set) Token: 0x06000F16 RID: 3862 RVA: 0x00051F80 File Offset: 0x00050180
		public unsafe int fixedPaneIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.NativeMethodInfoPtr_get_fixedPaneIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = value == this.m_FixedPaneIndex;
				if (!flag)
				{
					this.Init(value, this.m_FixedPaneInitialDimension, this.m_Orientation);
				}
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x0005175C File Offset: 0x0004F95C
		// (set) Token: 0x06000F19 RID: 3865 RVA: 0x00051FE8 File Offset: 0x000501E8
		public unsafe TwoPaneSplitViewOrientation orientation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.NativeMethodInfoPtr_get_orientation_Public_get_TwoPaneSplitViewOrientation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = value == this.m_Orientation;
				if (!flag)
				{
					this.Init(this.m_FixedPaneIndex, this.m_FixedPaneInitialDimension, value);
				}
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x00051798 File Offset: 0x0004F998
		// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x000517D4 File Offset: 0x0004F9D4
		public unsafe float fixedPaneDimension
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306746, XrefRangeEnd = 306747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.NativeMethodInfoPtr_get_fixedPaneDimension_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306747, XrefRangeEnd = 306748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.NativeMethodInfoPtr_set_fixedPaneDimension_Internal_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00051814 File Offset: 0x0004FA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306748, XrefRangeEnd = 306787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TwoPaneSplitView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00051850 File Offset: 0x0004FA50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306829, RefRangeEnd = 306830, XrefRangeStart = 306787, XrefRangeEnd = 306829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CollapseChild(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.NativeMethodInfoPtr_CollapseChild_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00051890 File Offset: 0x0004FA90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306892, RefRangeEnd = 306893, XrefRangeStart = 306830, XrefRangeEnd = 306892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(int fixedPaneIndex, float fixedPaneInitialDimension, TwoPaneSplitViewOrientation orientation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fixedPaneIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fixedPaneInitialDimension;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref orientation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.NativeMethodInfoPtr_Init_Internal_Void_Int32_Single_TwoPaneSplitViewOrientation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x000518EC File Offset: 0x0004FAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306893, XrefRangeEnd = 306908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPostDisplaySetup(GeometryChangedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.NativeMethodInfoPtr_OnPostDisplaySetup_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00051930 File Offset: 0x0004FB30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 306914, RefRangeEnd = 306916, XrefRangeStart = 306908, XrefRangeEnd = 306914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplacePanesBasedOnAnchor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.NativeMethodInfoPtr_ReplacePanesBasedOnAnchor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00051964 File Offset: 0x0004FB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306916, XrefRangeEnd = 306920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAnchorPostDisplaySetup(GeometryChangedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.NativeMethodInfoPtr_OnAnchorPostDisplaySetup_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x000519A8 File Offset: 0x0004FBA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 306927, RefRangeEnd = 306929, XrefRangeStart = 306920, XrefRangeEnd = 306927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IdentifyLeftAndRightPane()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.NativeMethodInfoPtr_IdentifyLeftAndRightPane_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x000519DC File Offset: 0x0004FBDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307108, RefRangeEnd = 307111, XrefRangeStart = 306929, XrefRangeEnd = 307108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PostDisplaySetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.NativeMethodInfoPtr_PostDisplaySetup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x00051A10 File Offset: 0x0004FC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307111, XrefRangeEnd = 307112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSizeChange(GeometryChangedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.NativeMethodInfoPtr_OnSizeChange_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00051A54 File Offset: 0x0004FC54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 307175, RefRangeEnd = 307176, XrefRangeStart = 307112, XrefRangeEnd = 307175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLayout(bool updateFixedPane, bool updateDragLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateFixedPane;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateDragLine;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.NativeMethodInfoPtr_UpdateLayout_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x00051AA0 File Offset: 0x0004FCA0
		public unsafe override VisualElement contentContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwoPaneSplitView.NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00051AEC File Offset: 0x0004FCEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307176, XrefRangeEnd = 307180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnViewDataReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwoPaneSplitView.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00051B28 File Offset: 0x0004FD28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 307185, RefRangeEnd = 307186, XrefRangeStart = 307180, XrefRangeEnd = 307185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDragLineOffset(float offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.NativeMethodInfoPtr_SetDragLineOffset_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00051B68 File Offset: 0x0004FD68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 307191, RefRangeEnd = 307192, XrefRangeStart = 307186, XrefRangeEnd = 307191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFixedPaneDimension(float dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dimension;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.NativeMethodInfoPtr_SetFixedPaneDimension_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0000790E File Offset: 0x00005B0E
		public TwoPaneSplitView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x00051BA8 File Offset: 0x0004FDA8
		// (set) Token: 0x06000EE5 RID: 3813 RVA: 0x00007917 File Offset: 0x00005B17
		public unsafe static string s_UssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwoPaneSplitView.NativeFieldInfoPtr_s_UssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwoPaneSplitView.NativeFieldInfoPtr_s_UssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x00051BC8 File Offset: 0x0004FDC8
		// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x00007929 File Offset: 0x00005B29
		public unsafe static string s_ContentContainerClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwoPaneSplitView.NativeFieldInfoPtr_s_ContentContainerClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwoPaneSplitView.NativeFieldInfoPtr_s_ContentContainerClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x00051BE8 File Offset: 0x0004FDE8
		// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x0000793B File Offset: 0x00005B3B
		public unsafe static string s_HandleDragLineClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwoPaneSplitView.NativeFieldInfoPtr_s_HandleDragLineClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwoPaneSplitView.NativeFieldInfoPtr_s_HandleDragLineClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x00051C08 File Offset: 0x0004FE08
		// (set) Token: 0x06000EEB RID: 3819 RVA: 0x0000794D File Offset: 0x00005B4D
		public unsafe static string s_HandleDragLineVerticalClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwoPaneSplitView.NativeFieldInfoPtr_s_HandleDragLineVerticalClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwoPaneSplitView.NativeFieldInfoPtr_s_HandleDragLineVerticalClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x00051C28 File Offset: 0x0004FE28
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x0000795F File Offset: 0x00005B5F
		public unsafe static string s_HandleDragLineHorizontalClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwoPaneSplitView.NativeFieldInfoPtr_s_HandleDragLineHorizontalClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwoPaneSplitView.NativeFieldInfoPtr_s_HandleDragLineHorizontalClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x00051C48 File Offset: 0x0004FE48
		// (set) Token: 0x06000EEF RID: 3823 RVA: 0x00007971 File Offset: 0x00005B71
		public unsafe static string s_HandleDragLineAnchorClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwoPaneSplitView.NativeFieldInfoPtr_s_HandleDragLineAnchorClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwoPaneSplitView.NativeFieldInfoPtr_s_HandleDragLineAnchorClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x00051C68 File Offset: 0x0004FE68
		// (set) Token: 0x06000EF1 RID: 3825 RVA: 0x00007983 File Offset: 0x00005B83
		public unsafe static string s_HandleDragLineAnchorVerticalClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwoPaneSplitView.NativeFieldInfoPtr_s_HandleDragLineAnchorVerticalClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwoPaneSplitView.NativeFieldInfoPtr_s_HandleDragLineAnchorVerticalClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x00051C88 File Offset: 0x0004FE88
		// (set) Token: 0x06000EF3 RID: 3827 RVA: 0x00007995 File Offset: 0x00005B95
		public unsafe static string s_HandleDragLineAnchorHorizontalClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwoPaneSplitView.NativeFieldInfoPtr_s_HandleDragLineAnchorHorizontalClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwoPaneSplitView.NativeFieldInfoPtr_s_HandleDragLineAnchorHorizontalClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x00051CA8 File Offset: 0x0004FEA8
		// (set) Token: 0x06000EF5 RID: 3829 RVA: 0x000079A7 File Offset: 0x00005BA7
		public unsafe static string s_VerticalClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwoPaneSplitView.NativeFieldInfoPtr_s_VerticalClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwoPaneSplitView.NativeFieldInfoPtr_s_VerticalClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x00051CC8 File Offset: 0x0004FEC8
		// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x000079B9 File Offset: 0x00005BB9
		public unsafe static string s_HorizontalClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwoPaneSplitView.NativeFieldInfoPtr_s_HorizontalClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwoPaneSplitView.NativeFieldInfoPtr_s_HorizontalClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x00051CE8 File Offset: 0x0004FEE8
		// (set) Token: 0x06000EF9 RID: 3833 RVA: 0x000079CB File Offset: 0x00005BCB
		public unsafe VisualElement m_LeftPane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_LeftPane);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_LeftPane), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x00051D18 File Offset: 0x0004FF18
		// (set) Token: 0x06000EFB RID: 3835 RVA: 0x000079EA File Offset: 0x00005BEA
		public unsafe VisualElement m_RightPane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_RightPane);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_RightPane), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x00051D48 File Offset: 0x0004FF48
		// (set) Token: 0x06000EFD RID: 3837 RVA: 0x00007A09 File Offset: 0x00005C09
		public unsafe VisualElement m_FixedPane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_FixedPane);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_FixedPane), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x00051D78 File Offset: 0x0004FF78
		// (set) Token: 0x06000EFF RID: 3839 RVA: 0x00007A28 File Offset: 0x00005C28
		public unsafe VisualElement m_FlexedPane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_FlexedPane);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_FlexedPane), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00051DA8 File Offset: 0x0004FFA8
		// (set) Token: 0x06000F01 RID: 3841 RVA: 0x00007A47 File Offset: 0x00005C47
		public unsafe float m_FixedPaneDimension
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_FixedPaneDimension);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_FixedPaneDimension)) = value;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x00051DD0 File Offset: 0x0004FFD0
		// (set) Token: 0x06000F03 RID: 3843 RVA: 0x00007A62 File Offset: 0x00005C62
		public unsafe VisualElement m_DragLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_DragLine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_DragLine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x00051E00 File Offset: 0x00050000
		// (set) Token: 0x06000F05 RID: 3845 RVA: 0x00007A81 File Offset: 0x00005C81
		public unsafe VisualElement m_DragLineAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_DragLineAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_DragLineAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x00051E30 File Offset: 0x00050030
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x00007AA0 File Offset: 0x00005CA0
		public unsafe bool m_CollapseMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_CollapseMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_CollapseMode)) = value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x00051E58 File Offset: 0x00050058
		// (set) Token: 0x06000F09 RID: 3849 RVA: 0x00007ABB File Offset: 0x00005CBB
		public unsafe bool m_CollapseChildCalledBeforeSetupComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_CollapseChildCalledBeforeSetupComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_CollapseChildCalledBeforeSetupComplete)) = value;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x00051E80 File Offset: 0x00050080
		// (set) Token: 0x06000F0B RID: 3851 RVA: 0x00007AD6 File Offset: 0x00005CD6
		public unsafe int m_CollapsedChildIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_CollapsedChildIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_CollapsedChildIndex)) = value;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x00051EA8 File Offset: 0x000500A8
		// (set) Token: 0x06000F0D RID: 3853 RVA: 0x00007AF1 File Offset: 0x00005CF1
		public unsafe VisualElement m_Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x00051ED8 File Offset: 0x000500D8
		// (set) Token: 0x06000F0F RID: 3855 RVA: 0x00007B10 File Offset: 0x00005D10
		public unsafe TwoPaneSplitViewOrientation m_Orientation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_Orientation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_Orientation)) = value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x00051F00 File Offset: 0x00050100
		// (set) Token: 0x06000F11 RID: 3857 RVA: 0x00007B2B File Offset: 0x00005D2B
		public unsafe int m_FixedPaneIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_FixedPaneIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_FixedPaneIndex)) = value;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x00051F28 File Offset: 0x00050128
		// (set) Token: 0x06000F13 RID: 3859 RVA: 0x00007B46 File Offset: 0x00005D46
		public unsafe float m_FixedPaneInitialDimension
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_FixedPaneInitialDimension);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_FixedPaneInitialDimension)) = value;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x00051F50 File Offset: 0x00050150
		// (set) Token: 0x06000F15 RID: 3861 RVA: 0x00007B61 File Offset: 0x00005D61
		public unsafe TwoPaneSplitViewResizer m_Resizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_Resizer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TwoPaneSplitViewResizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.NativeFieldInfoPtr_m_Resizer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x00007B80 File Offset: 0x00005D80
		// (set) Token: 0x06000F18 RID: 3864 RVA: 0x00051FB4 File Offset: 0x000501B4
		public float fixedPaneInitialDimension
		{
			get
			{
				return this.m_FixedPaneInitialDimension;
			}
			set
			{
				bool flag = value == this.m_FixedPaneInitialDimension;
				if (!flag)
				{
					this.Init(this.m_FixedPaneIndex, value, this.m_Orientation);
				}
			}
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0005201C File Offset: 0x0005021C
		public void UnCollapse()
		{
			bool flag = this.m_LeftPane == null;
			if (!flag)
			{
				VisualElement visualElement = null;
				bool flag2 = this.m_LeftPane.style.display == DisplayStyle.None;
				if (flag2)
				{
					visualElement = this.m_LeftPane;
				}
				else
				{
					bool flag3 = this.m_RightPane.style.display == DisplayStyle.None;
					if (flag3)
					{
						visualElement = this.m_RightPane;
					}
				}
				bool flag4 = visualElement == null;
				if (!flag4)
				{
					this.m_LeftPane.style.display = DisplayStyle.Flex;
					this.m_RightPane.style.display = DisplayStyle.Flex;
					this.m_DragLine.style.display = DisplayStyle.Flex;
					this.m_DragLineAnchor.style.display = DisplayStyle.Flex;
					this.m_LeftPane.style.flexGrow = 0f;
					this.m_RightPane.style.flexGrow = 0f;
					this.m_CollapseMode = false;
					this.m_CollapseChildCalledBeforeSetupComplete = false;
					this.m_CollapsedChildIndex = -1;
					this.Init(this.m_FixedPaneIndex, this.m_FixedPaneInitialDimension, this.m_Orientation);
					visualElement.RegisterCallback<GeometryChangedEvent>(new EventCallback<GeometryChangedEvent>(this.OnUncollapsedPaneResized), TrickleDown.NoTrickleDown);
				}
			}
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00007B88 File Offset: 0x00005D88
		public void OnUncollapsedPaneResized(GeometryChangedEvent evt)
		{
			this.UpdateDragLineAnchorOffset();
			evt.target.TryCast<VisualElement>().UnregisterCallback<GeometryChangedEvent>(new EventCallback<GeometryChangedEvent>(this.OnUncollapsedPaneResized), TrickleDown.NoTrickleDown);
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00007BB0 File Offset: 0x00005DB0
		public void UpdateDragLineAnchorOffset()
		{
			this.UpdateLayout(false, true);
		}

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeFieldInfoPtr_s_UssClassName;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeFieldInfoPtr_s_ContentContainerClassName;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeFieldInfoPtr_s_HandleDragLineClassName;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeFieldInfoPtr_s_HandleDragLineVerticalClassName;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeFieldInfoPtr_s_HandleDragLineHorizontalClassName;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeFieldInfoPtr_s_HandleDragLineAnchorClassName;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeFieldInfoPtr_s_HandleDragLineAnchorVerticalClassName;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeFieldInfoPtr_s_HandleDragLineAnchorHorizontalClassName;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeFieldInfoPtr_s_VerticalClassName;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeFieldInfoPtr_s_HorizontalClassName;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeFieldInfoPtr_m_LeftPane;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeFieldInfoPtr_m_RightPane;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeFieldInfoPtr_m_FixedPane;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeFieldInfoPtr_m_FlexedPane;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeFieldInfoPtr_m_FixedPaneDimension;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeFieldInfoPtr_m_DragLine;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeFieldInfoPtr_m_DragLineAnchor;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeFieldInfoPtr_m_CollapseMode;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeFieldInfoPtr_m_CollapseChildCalledBeforeSetupComplete;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeFieldInfoPtr_m_CollapsedChildIndex;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeFieldInfoPtr_m_Content;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeFieldInfoPtr_m_Orientation;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeFieldInfoPtr_m_FixedPaneIndex;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeFieldInfoPtr_m_FixedPaneInitialDimension;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeFieldInfoPtr_m_Resizer;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedPane_Public_get_VisualElement_0;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeMethodInfoPtr_get_flexedPane_Public_get_VisualElement_0;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeMethodInfoPtr_get_dragLine_Internal_get_VisualElement_0;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedPaneIndex_Public_get_Int32_0;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeMethodInfoPtr_get_orientation_Public_get_TwoPaneSplitViewOrientation_0;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedPaneDimension_Internal_get_Single_0;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeMethodInfoPtr_set_fixedPaneDimension_Internal_set_Void_Single_0;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeMethodInfoPtr_CollapseChild_Public_Void_Int32_0;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_Int32_Single_TwoPaneSplitViewOrientation_0;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeMethodInfoPtr_OnPostDisplaySetup_Private_Void_GeometryChangedEvent_0;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeMethodInfoPtr_ReplacePanesBasedOnAnchor_Private_Void_0;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeMethodInfoPtr_OnAnchorPostDisplaySetup_Private_Void_GeometryChangedEvent_0;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeMethodInfoPtr_IdentifyLeftAndRightPane_Private_Void_0;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeMethodInfoPtr_PostDisplaySetup_Private_Void_0;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeMethodInfoPtr_OnSizeChange_Private_Void_GeometryChangedEvent_0;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLayout_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_SetDragLineOffset_Private_Void_Single_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr_SetFixedPaneDimension_Private_Void_Single_0;

		// Token: 0x020003CD RID: 973
		public new class UxmlFactory : UxmlFactory<TwoPaneSplitView, TwoPaneSplitView.UxmlTraits>
		{
			// Token: 0x060039C5 RID: 14789 RVA: 0x00018675 File Offset: 0x00016875
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<TwoPaneSplitView.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwoPaneSplitView.UxmlFactory>.NativeClassPtr);
				TwoPaneSplitView.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView.UxmlFactory>.NativeClassPtr, 100665419);
			}

			// Token: 0x060039C6 RID: 14790 RVA: 0x000EA404 File Offset: 0x000E8604
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306710, RefRangeEnd = 306711, XrefRangeStart = 306707, XrefRangeEnd = 306710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwoPaneSplitView.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039C7 RID: 14791 RVA: 0x000186A9 File Offset: 0x000168A9
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040028D6 RID: 10454
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003CE RID: 974
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x060039C8 RID: 14792 RVA: 0x000EA440 File Offset: 0x000E8640
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<TwoPaneSplitView.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TwoPaneSplitView>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwoPaneSplitView.UxmlTraits>.NativeClassPtr);
				TwoPaneSplitView.UxmlTraits.NativeFieldInfoPtr_m_FixedPaneIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView.UxmlTraits>.NativeClassPtr, "m_FixedPaneIndex");
				TwoPaneSplitView.UxmlTraits.NativeFieldInfoPtr_m_FixedPaneInitialDimension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView.UxmlTraits>.NativeClassPtr, "m_FixedPaneInitialDimension");
				TwoPaneSplitView.UxmlTraits.NativeFieldInfoPtr_m_Orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitView.UxmlTraits>.NativeClassPtr, "m_Orientation");
				TwoPaneSplitView.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView.UxmlTraits>.NativeClassPtr, 100665420);
				TwoPaneSplitView.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitView.UxmlTraits>.NativeClassPtr, 100665421);
			}

			// Token: 0x060039C9 RID: 14793 RVA: 0x000EA4D0 File Offset: 0x000E86D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306711, XrefRangeEnd = 306717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bag);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwoPaneSplitView.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039CA RID: 14794 RVA: 0x000EA548 File Offset: 0x000E8748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306717, XrefRangeEnd = 306746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwoPaneSplitView.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitView.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039CB RID: 14795 RVA: 0x000186B2 File Offset: 0x000168B2
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011BA RID: 4538
			// (get) Token: 0x060039CC RID: 14796 RVA: 0x000EA584 File Offset: 0x000E8784
			// (set) Token: 0x060039CD RID: 14797 RVA: 0x000186BB File Offset: 0x000168BB
			public unsafe UxmlIntAttributeDescription m_FixedPaneIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.UxmlTraits.NativeFieldInfoPtr_m_FixedPaneIndex);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.UxmlTraits.NativeFieldInfoPtr_m_FixedPaneIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011BB RID: 4539
			// (get) Token: 0x060039CE RID: 14798 RVA: 0x000EA5B4 File Offset: 0x000E87B4
			// (set) Token: 0x060039CF RID: 14799 RVA: 0x000186DA File Offset: 0x000168DA
			public unsafe UxmlIntAttributeDescription m_FixedPaneInitialDimension
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.UxmlTraits.NativeFieldInfoPtr_m_FixedPaneInitialDimension);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.UxmlTraits.NativeFieldInfoPtr_m_FixedPaneInitialDimension), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011BC RID: 4540
			// (get) Token: 0x060039D0 RID: 14800 RVA: 0x000EA5E4 File Offset: 0x000E87E4
			// (set) Token: 0x060039D1 RID: 14801 RVA: 0x000186F9 File Offset: 0x000168F9
			public unsafe UxmlEnumAttributeDescription<TwoPaneSplitViewOrientation> m_Orientation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.UxmlTraits.NativeFieldInfoPtr_m_Orientation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlEnumAttributeDescription<TwoPaneSplitViewOrientation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitView.UxmlTraits.NativeFieldInfoPtr_m_Orientation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040028D7 RID: 10455
			private static readonly IntPtr NativeFieldInfoPtr_m_FixedPaneIndex;

			// Token: 0x040028D8 RID: 10456
			private static readonly IntPtr NativeFieldInfoPtr_m_FixedPaneInitialDimension;

			// Token: 0x040028D9 RID: 10457
			private static readonly IntPtr NativeFieldInfoPtr_m_Orientation;

			// Token: 0x040028DA RID: 10458
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x040028DB RID: 10459
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0200058E RID: 1422
			public sealed class <get_uxmlChildElementsDescription>d__4
			{
			}
		}
	}
}
