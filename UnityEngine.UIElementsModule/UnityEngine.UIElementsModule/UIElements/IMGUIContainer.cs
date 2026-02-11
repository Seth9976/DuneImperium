using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000141 RID: 321
	public class IMGUIContainer : VisualElement
	{
		// Token: 0x060017C9 RID: 6089 RVA: 0x00071358 File Offset: 0x0006F558
		// Note: this type is marked as 'beforefieldinit'.
		static IMGUIContainer()
		{
			Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IMGUIContainer");
			IMGUIContainer.NativeFieldInfoPtr_m_OnGUIHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "m_OnGUIHandler");
			IMGUIContainer.NativeFieldInfoPtr_m_ObjectGUIState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "m_ObjectGUIState");
			IMGUIContainer.NativeFieldInfoPtr_useOwnerObjectGUIState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "useOwnerObjectGUIState");
			IMGUIContainer.NativeFieldInfoPtr__lastWorldClip_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "<lastWorldClip>k__BackingField");
			IMGUIContainer.NativeFieldInfoPtr_m_CullingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "m_CullingEnabled");
			IMGUIContainer.NativeFieldInfoPtr_m_IsFocusDelegated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "m_IsFocusDelegated");
			IMGUIContainer.NativeFieldInfoPtr_m_RefreshCachedLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "m_RefreshCachedLayout");
			IMGUIContainer.NativeFieldInfoPtr_m_Cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "m_Cache");
			IMGUIContainer.NativeFieldInfoPtr_m_CachedClippingRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "m_CachedClippingRect");
			IMGUIContainer.NativeFieldInfoPtr_m_CachedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "m_CachedTransform");
			IMGUIContainer.NativeFieldInfoPtr__contextType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "<contextType>k__BackingField");
			IMGUIContainer.NativeFieldInfoPtr_lostFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "lostFocus");
			IMGUIContainer.NativeFieldInfoPtr_receivedFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "receivedFocus");
			IMGUIContainer.NativeFieldInfoPtr_focusChangeDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "focusChangeDirection");
			IMGUIContainer.NativeFieldInfoPtr_hasFocusableControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "hasFocusableControls");
			IMGUIContainer.NativeFieldInfoPtr_newKeyboardFocusControlID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "newKeyboardFocusControlID");
			IMGUIContainer.NativeFieldInfoPtr__focusOnlyIfHasFocusableControls_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "<focusOnlyIfHasFocusableControls>k__BackingField");
			IMGUIContainer.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "ussClassName");
			IMGUIContainer.NativeFieldInfoPtr_ussFoldoutChildDepthClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "ussFoldoutChildDepthClassName");
			IMGUIContainer.NativeFieldInfoPtr_ussFoldoutChildDepthClassNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "ussFoldoutChildDepthClassNames");
			IMGUIContainer.NativeFieldInfoPtr_m_GUIGlobals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "m_GUIGlobals");
			IMGUIContainer.NativeFieldInfoPtr_k_OnGUIMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "k_OnGUIMarker");
			IMGUIContainer.NativeFieldInfoPtr_k_ImmediateCallbackMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "k_ImmediateCallbackMarker");
			IMGUIContainer.NativeFieldInfoPtr_s_DefaultMeasureEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "s_DefaultMeasureEvent");
			IMGUIContainer.NativeFieldInfoPtr_s_MeasureEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "s_MeasureEvent");
			IMGUIContainer.NativeFieldInfoPtr_s_CurrentEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "s_CurrentEvent");
			IMGUIContainer.NativeMethodInfoPtr_get_onGUIHandler_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666835);
			IMGUIContainer.NativeMethodInfoPtr_set_onGUIHandler_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666836);
			IMGUIContainer.NativeMethodInfoPtr_get_guiState_Internal_get_ObjectGUIState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666837);
			IMGUIContainer.NativeMethodInfoPtr_get_lastWorldClip_Internal_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666838);
			IMGUIContainer.NativeMethodInfoPtr_set_lastWorldClip_Internal_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666839);
			IMGUIContainer.NativeMethodInfoPtr_get_cullingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666840);
			IMGUIContainer.NativeMethodInfoPtr_get_cache_Private_get_LayoutCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666841);
			IMGUIContainer.NativeMethodInfoPtr_get_layoutMeasuredWidth_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666842);
			IMGUIContainer.NativeMethodInfoPtr_get_layoutMeasuredHeight_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666843);
			IMGUIContainer.NativeMethodInfoPtr_get_contextType_Public_get_ContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666844);
			IMGUIContainer.NativeMethodInfoPtr_set_contextType_Public_set_Void_ContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666845);
			IMGUIContainer.NativeMethodInfoPtr_get_focusOnlyIfHasFocusableControls_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666846);
			IMGUIContainer.NativeMethodInfoPtr_get_canGrabFocus_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666847);
			IMGUIContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666849);
			IMGUIContainer.NativeMethodInfoPtr__ctor_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666850);
			IMGUIContainer.NativeMethodInfoPtr_OnGenerateVisualContent_Private_Void_MeshGenerationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666851);
			IMGUIContainer.NativeMethodInfoPtr_SaveGlobals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666852);
			IMGUIContainer.NativeMethodInfoPtr_RestoreGlobals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666853);
			IMGUIContainer.NativeMethodInfoPtr_DoOnGUI_Private_Void_Event_Matrix4x4_Rect_Boolean_Rect_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666854);
			IMGUIContainer.NativeMethodInfoPtr_MarkDirtyLayout_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666855);
			IMGUIContainer.NativeMethodInfoPtr_ProcessEvent_Internal_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666856);
			IMGUIContainer.NativeMethodInfoPtr_DoIMGUIRepaint_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666857);
			IMGUIContainer.NativeMethodInfoPtr_SendEventToIMGUI_Internal_Boolean_EventBase_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666858);
			IMGUIContainer.NativeMethodInfoPtr_SendEventToIMGUIRaw_Private_Boolean_EventBase_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666859);
			IMGUIContainer.NativeMethodInfoPtr_VerifyBounds_Private_Boolean_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666860);
			IMGUIContainer.NativeMethodInfoPtr_IsContainerCapturingTheMouse_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666861);
			IMGUIContainer.NativeMethodInfoPtr_IsLocalEvent_Private_Boolean_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666862);
			IMGUIContainer.NativeMethodInfoPtr_IsEventInsideLocalWindow_Private_Boolean_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666863);
			IMGUIContainer.NativeMethodInfoPtr_IsDockAreaMouseUp_Private_Static_Boolean_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666864);
			IMGUIContainer.NativeMethodInfoPtr_HandleIMGUIEvent_Private_Boolean_Event_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666865);
			IMGUIContainer.NativeMethodInfoPtr_HandleIMGUIEvent_Internal_Boolean_Event_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666866);
			IMGUIContainer.NativeMethodInfoPtr_HandleIMGUIEvent_Private_Boolean_Event_Matrix4x4_Rect_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666867);
			IMGUIContainer.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666868);
			IMGUIContainer.NativeMethodInfoPtr_SetFoldoutDepthClass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666869);
			IMGUIContainer.NativeMethodInfoPtr_DoMeasure_FamOrAssem_Virtual_Vector2_Single_MeasureMode_Single_MeasureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666870);
			IMGUIContainer.NativeMethodInfoPtr_GetCurrentClipRect_Private_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666871);
			IMGUIContainer.NativeMethodInfoPtr_GetCurrentTransformAndClip_Private_Static_Void_IMGUIContainer_Event_byref_Matrix4x4_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666872);
			IMGUIContainer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666873);
			IMGUIContainer.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666874);
			IMGUIContainer.NativeMethodInfoPtr__DoOnGUI_b__56_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100666875);
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x000718A8 File Offset: 0x0006FAA8
		// (set) Token: 0x060017CB RID: 6091 RVA: 0x000718E8 File Offset: 0x0006FAE8
		public unsafe Action onGUIHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_get_onGUIHandler_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319386, XrefRangeEnd = 319390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_set_onGUIHandler_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x0007192C File Offset: 0x0006FB2C
		public unsafe ObjectGUIState guiState
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 319399, RefRangeEnd = 319400, XrefRangeStart = 319390, XrefRangeEnd = 319399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_get_guiState_Internal_get_ObjectGUIState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectGUIState>(intPtr3) : null;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060017CD RID: 6093 RVA: 0x0007196C File Offset: 0x0006FB6C
		// (set) Token: 0x060017CE RID: 6094 RVA: 0x000719A8 File Offset: 0x0006FBA8
		public unsafe Rect lastWorldClip
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_get_lastWorldClip_Internal_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_set_lastWorldClip_Internal_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x000719E8 File Offset: 0x0006FBE8
		// (set) Token: 0x06001827 RID: 6183 RVA: 0x0000B1D2 File Offset: 0x000093D2
		public unsafe bool cullingEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_get_cullingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_CullingEnabled = value;
				base.IncrementVersion(VersionChangeType.Repaint);
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x00071A24 File Offset: 0x0006FC24
		public unsafe GUILayoutUtility.LayoutCache cache
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 319405, RefRangeEnd = 319415, XrefRangeStart = 319400, XrefRangeEnd = 319405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_get_cache_Private_get_LayoutCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutUtility.LayoutCache>(intPtr3) : null;
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x00071A64 File Offset: 0x0006FC64
		public unsafe float layoutMeasuredWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319415, XrefRangeEnd = 319418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_get_layoutMeasuredWidth_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x00071AA0 File Offset: 0x0006FCA0
		public unsafe float layoutMeasuredHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319418, XrefRangeEnd = 319421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_get_layoutMeasuredHeight_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x00071ADC File Offset: 0x0006FCDC
		// (set) Token: 0x060017D4 RID: 6100 RVA: 0x00071B18 File Offset: 0x0006FD18
		public unsafe ContextType contextType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_get_contextType_Public_get_ContextType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_set_contextType_Public_set_Void_ContextType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060017D5 RID: 6101 RVA: 0x00071B58 File Offset: 0x0006FD58
		// (set) Token: 0x06001828 RID: 6184 RVA: 0x0000B1E8 File Offset: 0x000093E8
		public unsafe bool focusOnlyIfHasFocusableControls
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_get_focusOnlyIfHasFocusableControls_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._focusOnlyIfHasFocusableControls_k__BackingField = value;
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x00071B94 File Offset: 0x0006FD94
		public unsafe override bool canGrabFocus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMGUIContainer.NativeMethodInfoPtr_get_canGrabFocus_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x00071BDC File Offset: 0x0006FDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319421, XrefRangeEnd = 319422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMGUIContainer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x00071C18 File Offset: 0x0006FE18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319460, RefRangeEnd = 319461, XrefRangeStart = 319422, XrefRangeEnd = 319460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMGUIContainer(Action onGUIHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onGUIHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr__ctor_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x00071C64 File Offset: 0x0006FE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319461, XrefRangeEnd = 319472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_OnGenerateVisualContent_Private_Void_MeshGenerationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00071CA8 File Offset: 0x0006FEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319472, XrefRangeEnd = 319484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveGlobals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_SaveGlobals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x00071CDC File Offset: 0x0006FEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319484, XrefRangeEnd = 319496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreGlobals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_RestoreGlobals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x00071D10 File Offset: 0x0006FF10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 319672, RefRangeEnd = 319675, XrefRangeStart = 319496, XrefRangeEnd = 319672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parentTransform;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clippingRect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isComputingLayout;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layoutSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onGUIHandler);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canAffectFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_DoOnGUI_Private_Void_Event_Matrix4x4_Rect_Boolean_Rect_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x00071DAC File Offset: 0x0006FFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319675, XrefRangeEnd = 319676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkDirtyLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_MarkDirtyLayout_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x00071DE0 File Offset: 0x0006FFE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319698, RefRangeEnd = 319699, XrefRangeStart = 319676, XrefRangeEnd = 319698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void ProcessEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_ProcessEvent_Internal_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x00071E24 File Offset: 0x00070024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319699, XrefRangeEnd = 319718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoIMGUIRepaint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_DoIMGUIRepaint_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x00071E58 File Offset: 0x00070058
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 319758, RefRangeEnd = 319760, XrefRangeStart = 319718, XrefRangeEnd = 319758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = true, bool verifyBounds = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canAffectFocus;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref verifyBounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_SendEventToIMGUI_Internal_Boolean_EventBase_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x00071EC4 File Offset: 0x000700C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 319761, RefRangeEnd = 319763, XrefRangeStart = 319760, XrefRangeEnd = 319761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendEventToIMGUIRaw(EventBase evt, bool canAffectFocus, bool verifyBounds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canAffectFocus;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref verifyBounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_SendEventToIMGUIRaw_Private_Boolean_EventBase_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x00071F30 File Offset: 0x00070130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319812, RefRangeEnd = 319813, XrefRangeStart = 319763, XrefRangeEnd = 319812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool VerifyBounds(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_VerifyBounds_Private_Boolean_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x00071F80 File Offset: 0x00070180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319813, XrefRangeEnd = 319822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsContainerCapturingTheMouse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_IsContainerCapturingTheMouse_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00071FBC File Offset: 0x000701BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319858, RefRangeEnd = 319859, XrefRangeStart = 319822, XrefRangeEnd = 319858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLocalEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_IsLocalEvent_Private_Boolean_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x0007200C File Offset: 0x0007020C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319859, XrefRangeEnd = 319880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEventInsideLocalWindow(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_IsEventInsideLocalWindow_Private_Boolean_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x0007205C File Offset: 0x0007025C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319880, XrefRangeEnd = 319887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDockAreaMouseUp(EventBase evt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_IsDockAreaMouseUp_Private_Static_Boolean_EventBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x000720A0 File Offset: 0x000702A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319887, XrefRangeEnd = 319896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleIMGUIEvent(Event e, bool canAffectFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canAffectFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_HandleIMGUIEvent_Private_Boolean_Event_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x000720FC File Offset: 0x000702FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319905, RefRangeEnd = 319906, XrefRangeStart = 319896, XrefRangeEnd = 319905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onGUIHandler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canAffectFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_HandleIMGUIEvent_Internal_Boolean_Event_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x0007216C File Offset: 0x0007036C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 319946, RefRangeEnd = 319949, XrefRangeStart = 319906, XrefRangeEnd = 319946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldTransform;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clippingRect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onGUIHandler);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canAffectFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_HandleIMGUIEvent_Private_Boolean_Event_Matrix4x4_Rect_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x000721F8 File Offset: 0x000703F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319949, XrefRangeEnd = 319998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExecuteDefaultAction(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMGUIContainer.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00072248 File Offset: 0x00070448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319998, XrefRangeEnd = 320020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFoldoutDepthClass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_SetFoldoutDepthClass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x0007227C File Offset: 0x0007047C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320020, XrefRangeEnd = 320047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desiredWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desiredHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMGUIContainer.NativeMethodInfoPtr_DoMeasure_FamOrAssem_Virtual_Vector2_Single_MeasureMode_Single_MeasureMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x000722FC File Offset: 0x000704FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320047, XrefRangeEnd = 320048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect GetCurrentClipRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_GetCurrentClipRect_Private_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x00072338 File Offset: 0x00070538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320048, XrefRangeEnd = 320053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &transform;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &clipRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_GetCurrentTransformAndClip_Private_Static_Void_IMGUIContainer_Event_byref_Matrix4x4_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x0007239C File Offset: 0x0007059C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320053, XrefRangeEnd = 320057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x000723D0 File Offset: 0x000705D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320057, XrefRangeEnd = 320058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposeManaged)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposeManaged;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMGUIContainer.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x0007241C File Offset: 0x0007061C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320058, XrefRangeEnd = 320059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _DoOnGUI_b__56_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr__DoOnGUI_b__56_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x0000AF4B File Offset: 0x0000914B
		public IMGUIContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060017F3 RID: 6131 RVA: 0x00072450 File Offset: 0x00070650
		// (set) Token: 0x060017F4 RID: 6132 RVA: 0x0000AF54 File Offset: 0x00009154
		public unsafe Action m_OnGUIHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_OnGUIHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_OnGUIHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060017F5 RID: 6133 RVA: 0x00072480 File Offset: 0x00070680
		// (set) Token: 0x060017F6 RID: 6134 RVA: 0x0000AF73 File Offset: 0x00009173
		public unsafe ObjectGUIState m_ObjectGUIState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_ObjectGUIState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectGUIState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_ObjectGUIState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x000724B0 File Offset: 0x000706B0
		// (set) Token: 0x060017F8 RID: 6136 RVA: 0x0000AF92 File Offset: 0x00009192
		public unsafe bool useOwnerObjectGUIState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_useOwnerObjectGUIState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_useOwnerObjectGUIState)) = value;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x000724D8 File Offset: 0x000706D8
		// (set) Token: 0x060017FA RID: 6138 RVA: 0x0000AFAD File Offset: 0x000091AD
		public unsafe Rect _lastWorldClip_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr__lastWorldClip_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr__lastWorldClip_k__BackingField)) = value;
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x00072500 File Offset: 0x00070700
		// (set) Token: 0x060017FC RID: 6140 RVA: 0x0000AFC8 File Offset: 0x000091C8
		public unsafe bool m_CullingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_CullingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_CullingEnabled)) = value;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x00072528 File Offset: 0x00070728
		// (set) Token: 0x060017FE RID: 6142 RVA: 0x0000AFE3 File Offset: 0x000091E3
		public unsafe bool m_IsFocusDelegated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_IsFocusDelegated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_IsFocusDelegated)) = value;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x00072550 File Offset: 0x00070750
		// (set) Token: 0x06001800 RID: 6144 RVA: 0x0000AFFE File Offset: 0x000091FE
		public unsafe bool m_RefreshCachedLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_RefreshCachedLayout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_RefreshCachedLayout)) = value;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x00072578 File Offset: 0x00070778
		// (set) Token: 0x06001802 RID: 6146 RVA: 0x0000B019 File Offset: 0x00009219
		public unsafe GUILayoutUtility.LayoutCache m_Cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_Cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUILayoutUtility.LayoutCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_Cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x000725A8 File Offset: 0x000707A8
		// (set) Token: 0x06001804 RID: 6148 RVA: 0x0000B038 File Offset: 0x00009238
		public unsafe Rect m_CachedClippingRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_CachedClippingRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_CachedClippingRect)) = value;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x000725D0 File Offset: 0x000707D0
		// (set) Token: 0x06001806 RID: 6150 RVA: 0x0000B053 File Offset: 0x00009253
		public unsafe Matrix4x4 m_CachedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_CachedTransform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_CachedTransform)) = value;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x000725F8 File Offset: 0x000707F8
		// (set) Token: 0x06001808 RID: 6152 RVA: 0x0000B06E File Offset: 0x0000926E
		public unsafe ContextType _contextType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr__contextType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr__contextType_k__BackingField)) = value;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001809 RID: 6153 RVA: 0x00072620 File Offset: 0x00070820
		// (set) Token: 0x0600180A RID: 6154 RVA: 0x0000B089 File Offset: 0x00009289
		public unsafe bool lostFocus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_lostFocus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_lostFocus)) = value;
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x00072648 File Offset: 0x00070848
		// (set) Token: 0x0600180C RID: 6156 RVA: 0x0000B0A4 File Offset: 0x000092A4
		public unsafe bool receivedFocus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_receivedFocus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_receivedFocus)) = value;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x00072670 File Offset: 0x00070870
		// (set) Token: 0x0600180E RID: 6158 RVA: 0x0000B0BF File Offset: 0x000092BF
		public unsafe FocusChangeDirection focusChangeDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_focusChangeDirection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_focusChangeDirection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x000726A0 File Offset: 0x000708A0
		// (set) Token: 0x06001810 RID: 6160 RVA: 0x0000B0DE File Offset: 0x000092DE
		public unsafe bool hasFocusableControls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_hasFocusableControls);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_hasFocusableControls)) = value;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x000726C8 File Offset: 0x000708C8
		// (set) Token: 0x06001812 RID: 6162 RVA: 0x0000B0F9 File Offset: 0x000092F9
		public unsafe int newKeyboardFocusControlID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_newKeyboardFocusControlID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_newKeyboardFocusControlID)) = value;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x000726F0 File Offset: 0x000708F0
		// (set) Token: 0x06001814 RID: 6164 RVA: 0x0000B114 File Offset: 0x00009314
		public unsafe bool _focusOnlyIfHasFocusableControls_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr__focusOnlyIfHasFocusableControls_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr__focusOnlyIfHasFocusableControls_k__BackingField)) = value;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x00072718 File Offset: 0x00070918
		// (set) Token: 0x06001816 RID: 6166 RVA: 0x0000B12F File Offset: 0x0000932F
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IMGUIContainer.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IMGUIContainer.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x00072738 File Offset: 0x00070938
		// (set) Token: 0x06001818 RID: 6168 RVA: 0x0000B141 File Offset: 0x00009341
		public unsafe static string ussFoldoutChildDepthClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IMGUIContainer.NativeFieldInfoPtr_ussFoldoutChildDepthClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IMGUIContainer.NativeFieldInfoPtr_ussFoldoutChildDepthClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x00072758 File Offset: 0x00070958
		// (set) Token: 0x0600181A RID: 6170 RVA: 0x0000B153 File Offset: 0x00009353
		public unsafe static List<string> ussFoldoutChildDepthClassNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IMGUIContainer.NativeFieldInfoPtr_ussFoldoutChildDepthClassNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IMGUIContainer.NativeFieldInfoPtr_ussFoldoutChildDepthClassNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x00072780 File Offset: 0x00070980
		// (set) Token: 0x0600181C RID: 6172 RVA: 0x0000B165 File Offset: 0x00009365
		public unsafe IMGUIContainer.GUIGlobals m_GUIGlobals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_GUIGlobals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_GUIGlobals)) = value;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x000727A8 File Offset: 0x000709A8
		// (set) Token: 0x0600181E RID: 6174 RVA: 0x0000B180 File Offset: 0x00009380
		public unsafe static ProfilerMarker k_OnGUIMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(IMGUIContainer.NativeFieldInfoPtr_k_OnGUIMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IMGUIContainer.NativeFieldInfoPtr_k_OnGUIMarker, (void*)(&value));
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x000727C4 File Offset: 0x000709C4
		// (set) Token: 0x06001820 RID: 6176 RVA: 0x0000B18E File Offset: 0x0000938E
		public unsafe static ProfilerMarker k_ImmediateCallbackMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(IMGUIContainer.NativeFieldInfoPtr_k_ImmediateCallbackMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IMGUIContainer.NativeFieldInfoPtr_k_ImmediateCallbackMarker, (void*)(&value));
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x000727E0 File Offset: 0x000709E0
		// (set) Token: 0x06001822 RID: 6178 RVA: 0x0000B19C File Offset: 0x0000939C
		public unsafe static Event s_DefaultMeasureEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IMGUIContainer.NativeFieldInfoPtr_s_DefaultMeasureEvent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IMGUIContainer.NativeFieldInfoPtr_s_DefaultMeasureEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x00072808 File Offset: 0x00070A08
		// (set) Token: 0x06001824 RID: 6180 RVA: 0x0000B1AE File Offset: 0x000093AE
		public unsafe static Event s_MeasureEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IMGUIContainer.NativeFieldInfoPtr_s_MeasureEvent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IMGUIContainer.NativeFieldInfoPtr_s_MeasureEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x00072830 File Offset: 0x00070A30
		// (set) Token: 0x06001826 RID: 6182 RVA: 0x0000B1C0 File Offset: 0x000093C0
		public unsafe static Event s_CurrentEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IMGUIContainer.NativeFieldInfoPtr_s_CurrentEvent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IMGUIContainer.NativeFieldInfoPtr_s_CurrentEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeFieldInfoPtr_m_OnGUIHandler;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectGUIState;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeFieldInfoPtr_useOwnerObjectGUIState;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeFieldInfoPtr__lastWorldClip_k__BackingField;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingEnabled;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeFieldInfoPtr_m_IsFocusDelegated;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshCachedLayout;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeFieldInfoPtr_m_Cache;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedClippingRect;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedTransform;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeFieldInfoPtr__contextType_k__BackingField;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeFieldInfoPtr_lostFocus;

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeFieldInfoPtr_receivedFocus;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeFieldInfoPtr_focusChangeDirection;

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeFieldInfoPtr_hasFocusableControls;

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeFieldInfoPtr_newKeyboardFocusControlID;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeFieldInfoPtr__focusOnlyIfHasFocusableControls_k__BackingField;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeFieldInfoPtr_ussFoldoutChildDepthClassName;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeFieldInfoPtr_ussFoldoutChildDepthClassNames;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeFieldInfoPtr_m_GUIGlobals;

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeFieldInfoPtr_k_OnGUIMarker;

		// Token: 0x04001051 RID: 4177
		private static readonly IntPtr NativeFieldInfoPtr_k_ImmediateCallbackMarker;

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultMeasureEvent;

		// Token: 0x04001053 RID: 4179
		private static readonly IntPtr NativeFieldInfoPtr_s_MeasureEvent;

		// Token: 0x04001054 RID: 4180
		private static readonly IntPtr NativeFieldInfoPtr_s_CurrentEvent;

		// Token: 0x04001055 RID: 4181
		private static readonly IntPtr NativeMethodInfoPtr_get_onGUIHandler_Public_get_Action_0;

		// Token: 0x04001056 RID: 4182
		private static readonly IntPtr NativeMethodInfoPtr_set_onGUIHandler_Public_set_Void_Action_0;

		// Token: 0x04001057 RID: 4183
		private static readonly IntPtr NativeMethodInfoPtr_get_guiState_Internal_get_ObjectGUIState_0;

		// Token: 0x04001058 RID: 4184
		private static readonly IntPtr NativeMethodInfoPtr_get_lastWorldClip_Internal_get_Rect_0;

		// Token: 0x04001059 RID: 4185
		private static readonly IntPtr NativeMethodInfoPtr_set_lastWorldClip_Internal_set_Void_Rect_0;

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingEnabled_Public_get_Boolean_0;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeMethodInfoPtr_get_cache_Private_get_LayoutCache_0;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutMeasuredWidth_Private_get_Single_0;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutMeasuredHeight_Private_get_Single_0;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeMethodInfoPtr_get_contextType_Public_get_ContextType_0;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeMethodInfoPtr_set_contextType_Public_set_Void_ContextType_0;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeMethodInfoPtr_get_focusOnlyIfHasFocusableControls_Internal_get_Boolean_0;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeMethodInfoPtr_get_canGrabFocus_Public_Virtual_get_Boolean_0;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_0;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeMethodInfoPtr_OnGenerateVisualContent_Private_Void_MeshGenerationContext_0;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr_SaveGlobals_Private_Void_0;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr_RestoreGlobals_Private_Void_0;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeMethodInfoPtr_DoOnGUI_Private_Void_Event_Matrix4x4_Rect_Boolean_Rect_Action_Boolean_0;

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeMethodInfoPtr_MarkDirtyLayout_Public_Void_0;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEvent_Internal_Void_EventBase_0;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeMethodInfoPtr_DoIMGUIRepaint_Private_Void_0;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeMethodInfoPtr_SendEventToIMGUI_Internal_Boolean_EventBase_Boolean_Boolean_0;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeMethodInfoPtr_SendEventToIMGUIRaw_Private_Boolean_EventBase_Boolean_Boolean_0;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeMethodInfoPtr_VerifyBounds_Private_Boolean_EventBase_0;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeMethodInfoPtr_IsContainerCapturingTheMouse_Private_Boolean_0;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeMethodInfoPtr_IsLocalEvent_Private_Boolean_EventBase_0;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeMethodInfoPtr_IsEventInsideLocalWindow_Private_Boolean_EventBase_0;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeMethodInfoPtr_IsDockAreaMouseUp_Private_Static_Boolean_EventBase_0;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeMethodInfoPtr_HandleIMGUIEvent_Private_Boolean_Event_Boolean_0;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeMethodInfoPtr_HandleIMGUIEvent_Internal_Boolean_Event_Action_Boolean_0;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr_HandleIMGUIEvent_Private_Boolean_Event_Matrix4x4_Rect_Action_Boolean_0;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeMethodInfoPtr_SetFoldoutDepthClass_Private_Void_0;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr_DoMeasure_FamOrAssem_Virtual_Vector2_Single_MeasureMode_Single_MeasureMode_0;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentClipRect_Private_Rect_0;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentTransformAndClip_Private_Static_Void_IMGUIContainer_Event_byref_Matrix4x4_byref_Rect_0;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeMethodInfoPtr__DoOnGUI_b__56_0_Private_Void_0;

		// Token: 0x0200046E RID: 1134
		public new class UxmlFactory : UxmlFactory<IMGUIContainer, IMGUIContainer.UxmlTraits>
		{
			// Token: 0x06003C1B RID: 15387 RVA: 0x0001938A File Offset: 0x0001758A
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<IMGUIContainer.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IMGUIContainer.UxmlFactory>.NativeClassPtr);
				IMGUIContainer.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer.UxmlFactory>.NativeClassPtr, 100666876);
			}

			// Token: 0x06003C1C RID: 15388 RVA: 0x000F19A0 File Offset: 0x000EFBA0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 319382, RefRangeEnd = 319383, XrefRangeStart = 319379, XrefRangeEnd = 319382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IMGUIContainer.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C1D RID: 15389 RVA: 0x000193BE File Offset: 0x000175BE
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002A5C RID: 10844
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200046F RID: 1135
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x06003C1E RID: 15390 RVA: 0x000193C7 File Offset: 0x000175C7
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<IMGUIContainer.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IMGUIContainer.UxmlTraits>.NativeClassPtr);
				IMGUIContainer.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer.UxmlTraits>.NativeClassPtr, 100666877);
			}

			// Token: 0x06003C1F RID: 15391 RVA: 0x000F19DC File Offset: 0x000EFBDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319383, XrefRangeEnd = 319386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IMGUIContainer.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C20 RID: 15392 RVA: 0x000193FB File Offset: 0x000175FB
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002A5D RID: 10845
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000590 RID: 1424
			public sealed class <get_uxmlChildElementsDescription>d__2
			{
			}
		}

		// Token: 0x02000470 RID: 1136
		[StructLayout(2)]
		public struct GUIGlobals
		{
			// Token: 0x06003C21 RID: 15393 RVA: 0x000F1A18 File Offset: 0x000EFC18
			// Note: this type is marked as 'beforefieldinit'.
			static GUIGlobals()
			{
				Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "GUIGlobals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr);
				IMGUIContainer.GUIGlobals.NativeFieldInfoPtr_matrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr, "matrix");
				IMGUIContainer.GUIGlobals.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr, "color");
				IMGUIContainer.GUIGlobals.NativeFieldInfoPtr_contentColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr, "contentColor");
				IMGUIContainer.GUIGlobals.NativeFieldInfoPtr_backgroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr, "backgroundColor");
				IMGUIContainer.GUIGlobals.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr, "enabled");
				IMGUIContainer.GUIGlobals.NativeFieldInfoPtr_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr, "changed");
				IMGUIContainer.GUIGlobals.NativeFieldInfoPtr_displayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr, "displayIndex");
			}

			// Token: 0x06003C22 RID: 15394 RVA: 0x00019404 File Offset: 0x00017604
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr, ref this));
			}

			// Token: 0x04002A5E RID: 10846
			private static readonly IntPtr NativeFieldInfoPtr_matrix;

			// Token: 0x04002A5F RID: 10847
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04002A60 RID: 10848
			private static readonly IntPtr NativeFieldInfoPtr_contentColor;

			// Token: 0x04002A61 RID: 10849
			private static readonly IntPtr NativeFieldInfoPtr_backgroundColor;

			// Token: 0x04002A62 RID: 10850
			private static readonly IntPtr NativeFieldInfoPtr_enabled;

			// Token: 0x04002A63 RID: 10851
			private static readonly IntPtr NativeFieldInfoPtr_changed;

			// Token: 0x04002A64 RID: 10852
			private static readonly IntPtr NativeFieldInfoPtr_displayIndex;

			// Token: 0x04002A65 RID: 10853
			[FieldOffset(0)]
			public Matrix4x4 matrix;

			// Token: 0x04002A66 RID: 10854
			[FieldOffset(64)]
			public Color color;

			// Token: 0x04002A67 RID: 10855
			[FieldOffset(80)]
			public Color contentColor;

			// Token: 0x04002A68 RID: 10856
			[FieldOffset(96)]
			public Color backgroundColor;

			// Token: 0x04002A69 RID: 10857
			[FieldOffset(112)]
			[MarshalAs(4)]
			public bool enabled;

			// Token: 0x04002A6A RID: 10858
			[FieldOffset(113)]
			[MarshalAs(4)]
			public bool changed;

			// Token: 0x04002A6B RID: 10859
			[FieldOffset(116)]
			public int displayIndex;
		}
	}
}
