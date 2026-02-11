using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200006C RID: 108
	public class StandaloneInputModule : PointerInputModule
	{
		// Token: 0x06000AE1 RID: 2785 RVA: 0x00031744 File Offset: 0x0002F944
		// Note: this type is marked as 'beforefieldinit'.
		static StandaloneInputModule()
		{
			Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "StandaloneInputModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr);
			StandaloneInputModule.NativeFieldInfoPtr_m_PrevActionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_PrevActionTime");
			StandaloneInputModule.NativeFieldInfoPtr_m_LastMoveVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_LastMoveVector");
			StandaloneInputModule.NativeFieldInfoPtr_m_ConsecutiveMoveCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_ConsecutiveMoveCount");
			StandaloneInputModule.NativeFieldInfoPtr_m_LastMousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_LastMousePosition");
			StandaloneInputModule.NativeFieldInfoPtr_m_MousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_MousePosition");
			StandaloneInputModule.NativeFieldInfoPtr_m_CurrentFocusedGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_CurrentFocusedGameObject");
			StandaloneInputModule.NativeFieldInfoPtr_m_InputPointerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_InputPointerEvent");
			StandaloneInputModule.NativeFieldInfoPtr_doubleClickTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "doubleClickTime");
			StandaloneInputModule.NativeFieldInfoPtr_m_HorizontalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_HorizontalAxis");
			StandaloneInputModule.NativeFieldInfoPtr_m_VerticalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_VerticalAxis");
			StandaloneInputModule.NativeFieldInfoPtr_m_SubmitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_SubmitButton");
			StandaloneInputModule.NativeFieldInfoPtr_m_CancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_CancelButton");
			StandaloneInputModule.NativeFieldInfoPtr_m_InputActionsPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_InputActionsPerSecond");
			StandaloneInputModule.NativeFieldInfoPtr_m_RepeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_RepeatDelay");
			StandaloneInputModule.NativeFieldInfoPtr_m_ForceModuleActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_ForceModuleActive");
			StandaloneInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665095);
			StandaloneInputModule.NativeMethodInfoPtr_get_inputMode_Public_get_InputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665096);
			StandaloneInputModule.NativeMethodInfoPtr_get_allowActivationOnMobileDevice_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665097);
			StandaloneInputModule.NativeMethodInfoPtr_set_allowActivationOnMobileDevice_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665098);
			StandaloneInputModule.NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665099);
			StandaloneInputModule.NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665100);
			StandaloneInputModule.NativeMethodInfoPtr_get_inputActionsPerSecond_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665101);
			StandaloneInputModule.NativeMethodInfoPtr_set_inputActionsPerSecond_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665102);
			StandaloneInputModule.NativeMethodInfoPtr_get_repeatDelay_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665103);
			StandaloneInputModule.NativeMethodInfoPtr_set_repeatDelay_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665104);
			StandaloneInputModule.NativeMethodInfoPtr_get_horizontalAxis_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665105);
			StandaloneInputModule.NativeMethodInfoPtr_set_horizontalAxis_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665106);
			StandaloneInputModule.NativeMethodInfoPtr_get_verticalAxis_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665107);
			StandaloneInputModule.NativeMethodInfoPtr_set_verticalAxis_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665108);
			StandaloneInputModule.NativeMethodInfoPtr_get_submitButton_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665109);
			StandaloneInputModule.NativeMethodInfoPtr_set_submitButton_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665110);
			StandaloneInputModule.NativeMethodInfoPtr_get_cancelButton_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665111);
			StandaloneInputModule.NativeMethodInfoPtr_set_cancelButton_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665112);
			StandaloneInputModule.NativeMethodInfoPtr_ShouldIgnoreEventsOnNoFocus_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665113);
			StandaloneInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665114);
			StandaloneInputModule.NativeMethodInfoPtr_ReleaseMouse_Private_Void_PointerEventData_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665115);
			StandaloneInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665116);
			StandaloneInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665117);
			StandaloneInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665118);
			StandaloneInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665119);
			StandaloneInputModule.NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665120);
			StandaloneInputModule.NativeMethodInfoPtr_ProcessTouchPress_Protected_Void_PointerEventData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665121);
			StandaloneInputModule.NativeMethodInfoPtr_SendSubmitEventToSelectedObject_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665122);
			StandaloneInputModule.NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665123);
			StandaloneInputModule.NativeMethodInfoPtr_SendMoveEventToSelectedObject_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665124);
			StandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665125);
			StandaloneInputModule.NativeMethodInfoPtr_ForceAutoSelect_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665126);
			StandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665127);
			StandaloneInputModule.NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665128);
			StandaloneInputModule.NativeMethodInfoPtr_ProcessMousePress_Protected_Void_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665129);
			StandaloneInputModule.NativeMethodInfoPtr_GetCurrentFocusedGameObject_Protected_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100665130);
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00031B70 File Offset: 0x0002FD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096748, XrefRangeEnd = 1096765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandaloneInputModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x00031BAC File Offset: 0x0002FDAC
		public unsafe StandaloneInputModule.InputMode inputMode
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_get_inputMode_Public_get_InputMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x00031BE8 File Offset: 0x0002FDE8
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x00031C24 File Offset: 0x0002FE24
		public unsafe bool allowActivationOnMobileDevice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_get_allowActivationOnMobileDevice_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_set_allowActivationOnMobileDevice_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x00031C64 File Offset: 0x0002FE64
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x00031CA0 File Offset: 0x0002FEA0
		public unsafe bool forceModuleActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x00031CE0 File Offset: 0x0002FEE0
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x00031D1C File Offset: 0x0002FF1C
		public unsafe float inputActionsPerSecond
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_get_inputActionsPerSecond_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_set_inputActionsPerSecond_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x00031D5C File Offset: 0x0002FF5C
		// (set) Token: 0x06000AEB RID: 2795 RVA: 0x00031D98 File Offset: 0x0002FF98
		public unsafe float repeatDelay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_get_repeatDelay_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_set_repeatDelay_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x00031DD8 File Offset: 0x0002FFD8
		// (set) Token: 0x06000AED RID: 2797 RVA: 0x00031E10 File Offset: 0x00030010
		public unsafe string horizontalAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_get_horizontalAxis_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_set_horizontalAxis_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x00031E54 File Offset: 0x00030054
		// (set) Token: 0x06000AEF RID: 2799 RVA: 0x00031E8C File Offset: 0x0003008C
		public unsafe string verticalAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_get_verticalAxis_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_set_verticalAxis_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x00031ED0 File Offset: 0x000300D0
		// (set) Token: 0x06000AF1 RID: 2801 RVA: 0x00031F08 File Offset: 0x00030108
		public unsafe string submitButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_get_submitButton_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_set_submitButton_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x00031F4C File Offset: 0x0003014C
		// (set) Token: 0x06000AF3 RID: 2803 RVA: 0x00031F84 File Offset: 0x00030184
		public unsafe string cancelButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_get_cancelButton_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_set_cancelButton_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00031FC8 File Offset: 0x000301C8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldIgnoreEventsOnNoFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_ShouldIgnoreEventsOnNoFocus_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00032004 File Offset: 0x00030204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096765, XrefRangeEnd = 1096767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandaloneInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00032040 File Offset: 0x00030240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1096828, RefRangeEnd = 1096829, XrefRangeStart = 1096767, XrefRangeEnd = 1096828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentOverGo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_ReleaseMouse_Private_Void_PointerEventData_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00032094 File Offset: 0x00030294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096829, XrefRangeEnd = 1096841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldActivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandaloneInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x000320DC File Offset: 0x000302DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096841, XrefRangeEnd = 1096848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandaloneInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00032118 File Offset: 0x00030318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096848, XrefRangeEnd = 1096849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DeactivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandaloneInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00032154 File Offset: 0x00030354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096849, XrefRangeEnd = 1096869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Process()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandaloneInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00032190 File Offset: 0x00030390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1096974, RefRangeEnd = 1096975, XrefRangeStart = 1096869, XrefRangeEnd = 1096974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessTouchEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x000321CC File Offset: 0x000303CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096975, XrefRangeEnd = 1097083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pressed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref released;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_ProcessTouchPress_Protected_Void_PointerEventData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0003222C File Offset: 0x0003042C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1097108, RefRangeEnd = 1097109, XrefRangeStart = 1097083, XrefRangeEnd = 1097108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendSubmitEventToSelectedObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_SendSubmitEventToSelectedObject_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00032268 File Offset: 0x00030468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097109, XrefRangeEnd = 1097116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetRawMoveVector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x000322A4 File Offset: 0x000304A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1097128, RefRangeEnd = 1097129, XrefRangeStart = 1097116, XrefRangeEnd = 1097128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendMoveEventToSelectedObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_SendMoveEventToSelectedObject_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000322E0 File Offset: 0x000304E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097129, XrefRangeEnd = 1097130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMouseEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00032314 File Offset: 0x00030514
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ForceAutoSelect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandaloneInputModule.NativeMethodInfoPtr_ForceAutoSelect_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0003235C File Offset: 0x0003055C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1097153, RefRangeEnd = 1097155, XrefRangeStart = 1097130, XrefRangeEnd = 1097153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMouseEvent(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0003239C File Offset: 0x0003059C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097155, XrefRangeEnd = 1097169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendUpdateEventToSelectedObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x000323D8 File Offset: 0x000305D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1097220, RefRangeEnd = 1097223, XrefRangeStart = 1097169, XrefRangeEnd = 1097220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMousePress(PointerInputModule.MouseButtonEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_ProcessMousePress_Protected_Void_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0003241C File Offset: 0x0003061C
		[CallerCount(0)]
		public unsafe GameObject GetCurrentFocusedGameObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_GetCurrentFocusedGameObject_Protected_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00005D93 File Offset: 0x00003F93
		public StandaloneInputModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x0003245C File Offset: 0x0003065C
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x00005D9C File Offset: 0x00003F9C
		public unsafe float m_PrevActionTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_PrevActionTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_PrevActionTime)) = value;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00032484 File Offset: 0x00030684
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x00005DB7 File Offset: 0x00003FB7
		public unsafe Vector2 m_LastMoveVector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_LastMoveVector);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_LastMoveVector)) = value;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x000324AC File Offset: 0x000306AC
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x00005DD2 File Offset: 0x00003FD2
		public unsafe int m_ConsecutiveMoveCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_ConsecutiveMoveCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_ConsecutiveMoveCount)) = value;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x000324D4 File Offset: 0x000306D4
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x00005DED File Offset: 0x00003FED
		public unsafe Vector2 m_LastMousePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_LastMousePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_LastMousePosition)) = value;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x000324FC File Offset: 0x000306FC
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x00005E08 File Offset: 0x00004008
		public unsafe Vector2 m_MousePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_MousePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_MousePosition)) = value;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00032524 File Offset: 0x00030724
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x00005E23 File Offset: 0x00004023
		public unsafe GameObject m_CurrentFocusedGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_CurrentFocusedGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_CurrentFocusedGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00032554 File Offset: 0x00030754
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x00005E42 File Offset: 0x00004042
		public unsafe PointerEventData m_InputPointerEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_InputPointerEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_InputPointerEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00032584 File Offset: 0x00030784
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x00005E61 File Offset: 0x00004061
		public unsafe static float doubleClickTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(StandaloneInputModule.NativeFieldInfoPtr_doubleClickTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StandaloneInputModule.NativeFieldInfoPtr_doubleClickTime, (void*)(&value));
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x000325A0 File Offset: 0x000307A0
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x00005E6F File Offset: 0x0000406F
		public unsafe string m_HorizontalAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_HorizontalAxis);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_HorizontalAxis), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x000325C8 File Offset: 0x000307C8
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x00005E8E File Offset: 0x0000408E
		public unsafe string m_VerticalAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_VerticalAxis);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_VerticalAxis), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x000325F0 File Offset: 0x000307F0
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x00005EAD File Offset: 0x000040AD
		public unsafe string m_SubmitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_SubmitButton);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_SubmitButton), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00032618 File Offset: 0x00030818
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x00005ECC File Offset: 0x000040CC
		public unsafe string m_CancelButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_CancelButton);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_CancelButton), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x00032640 File Offset: 0x00030840
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x00005EEB File Offset: 0x000040EB
		public unsafe float m_InputActionsPerSecond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_InputActionsPerSecond);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_InputActionsPerSecond)) = value;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x00032668 File Offset: 0x00030868
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x00005F06 File Offset: 0x00004106
		public unsafe float m_RepeatDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_RepeatDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_RepeatDelay)) = value;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x00032690 File Offset: 0x00030890
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x00005F21 File Offset: 0x00004121
		public unsafe bool m_ForceModuleActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_ForceModuleActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_ForceModuleActive)) = value;
			}
		}

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevActionTime;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeFieldInfoPtr_m_LastMoveVector;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeFieldInfoPtr_m_ConsecutiveMoveCount;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeFieldInfoPtr_m_LastMousePosition;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeFieldInfoPtr_m_MousePosition;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentFocusedGameObject;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeFieldInfoPtr_m_InputPointerEvent;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeFieldInfoPtr_doubleClickTime;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalAxis;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalAxis;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeFieldInfoPtr_m_SubmitButton;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeFieldInfoPtr_m_CancelButton;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeFieldInfoPtr_m_InputActionsPerSecond;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeFieldInfoPtr_m_RepeatDelay;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeFieldInfoPtr_m_ForceModuleActive;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr_get_inputMode_Public_get_InputMode_0;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeMethodInfoPtr_get_allowActivationOnMobileDevice_Public_get_Boolean_0;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_set_allowActivationOnMobileDevice_Public_set_Void_Boolean_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_get_inputActionsPerSecond_Public_get_Single_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_set_inputActionsPerSecond_Public_set_Void_Single_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_get_repeatDelay_Public_get_Single_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_set_repeatDelay_Public_set_Void_Single_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalAxis_Public_get_String_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalAxis_Public_set_Void_String_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalAxis_Public_get_String_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalAxis_Public_set_Void_String_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_get_submitButton_Public_get_String_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_set_submitButton_Public_set_Void_String_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_get_cancelButton_Public_get_String_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_set_cancelButton_Public_set_Void_String_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_ShouldIgnoreEventsOnNoFocus_Private_Boolean_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseMouse_Private_Void_PointerEventData_GameObject_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTouchPress_Protected_Void_PointerEventData_Boolean_Boolean_0;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeMethodInfoPtr_SendSubmitEventToSelectedObject_Protected_Boolean_0;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr_SendMoveEventToSelectedObject_Protected_Boolean_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_ForceAutoSelect_Protected_Virtual_New_Boolean_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_Int32_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Protected_Boolean_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMousePress_Protected_Void_MouseButtonEventData_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentFocusedGameObject_Protected_GameObject_0;

		// Token: 0x020000D8 RID: 216
		public enum InputMode
		{
			// Token: 0x04000AC3 RID: 2755
			Mouse,
			// Token: 0x04000AC4 RID: 2756
			Buttons
		}
	}
}
