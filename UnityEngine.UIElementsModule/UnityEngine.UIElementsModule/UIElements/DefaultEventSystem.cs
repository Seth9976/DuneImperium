using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x0200009E RID: 158
	public class DefaultEventSystem : Object
	{
		// Token: 0x06000F8B RID: 3979 RVA: 0x00053B9C File Offset: 0x00051D9C
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultEventSystem()
		{
			Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DefaultEventSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr);
			DefaultEventSystem.NativeFieldInfoPtr_IsEditorRemoteConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "IsEditorRemoteConnected");
			DefaultEventSystem.NativeFieldInfoPtr_m_Input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_Input");
			DefaultEventSystem.NativeFieldInfoPtr_m_HorizontalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_HorizontalAxis");
			DefaultEventSystem.NativeFieldInfoPtr_m_VerticalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_VerticalAxis");
			DefaultEventSystem.NativeFieldInfoPtr_m_SubmitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_SubmitButton");
			DefaultEventSystem.NativeFieldInfoPtr_m_CancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_CancelButton");
			DefaultEventSystem.NativeFieldInfoPtr_m_InputActionsPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_InputActionsPerSecond");
			DefaultEventSystem.NativeFieldInfoPtr_m_RepeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_RepeatDelay");
			DefaultEventSystem.NativeFieldInfoPtr_m_SendingTouchEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_SendingTouchEvents");
			DefaultEventSystem.NativeFieldInfoPtr_m_SendingPenEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_SendingPenEvent");
			DefaultEventSystem.NativeFieldInfoPtr_m_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_Event");
			DefaultEventSystem.NativeFieldInfoPtr_m_FocusedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_FocusedPanel");
			DefaultEventSystem.NativeFieldInfoPtr_m_PreviousFocusedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_PreviousFocusedPanel");
			DefaultEventSystem.NativeFieldInfoPtr_m_PreviousFocusedElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_PreviousFocusedElement");
			DefaultEventSystem.NativeFieldInfoPtr_m_CurrentModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_CurrentModifiers");
			DefaultEventSystem.NativeFieldInfoPtr_m_LastMousePressButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_LastMousePressButton");
			DefaultEventSystem.NativeFieldInfoPtr_m_NextMousePressTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_NextMousePressTime");
			DefaultEventSystem.NativeFieldInfoPtr_m_LastMouseClickCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_LastMouseClickCount");
			DefaultEventSystem.NativeFieldInfoPtr_m_LastMousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_LastMousePosition");
			DefaultEventSystem.NativeFieldInfoPtr_m_MouseProcessedAtLeastOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_MouseProcessedAtLeastOnce");
			DefaultEventSystem.NativeFieldInfoPtr_m_ConsecutiveMoveCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_ConsecutiveMoveCount");
			DefaultEventSystem.NativeFieldInfoPtr_m_LastMoveVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_LastMoveVector");
			DefaultEventSystem.NativeFieldInfoPtr_m_PrevActionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_PrevActionTime");
			DefaultEventSystem.NativeFieldInfoPtr_m_IsMoveFromKeyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "m_IsMoveFromKeyboard");
			DefaultEventSystem.NativeMethodInfoPtr_get_isAppFocused_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665500);
			DefaultEventSystem.NativeMethodInfoPtr_get_input_Internal_get_IInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665501);
			DefaultEventSystem.NativeMethodInfoPtr_GetDefaultInput_Private_IInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665502);
			DefaultEventSystem.NativeMethodInfoPtr_ShouldIgnoreEventsOnAppNotFocused_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665503);
			DefaultEventSystem.NativeMethodInfoPtr_get_focusedPanel_Public_get_BaseRuntimePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665504);
			DefaultEventSystem.NativeMethodInfoPtr_set_focusedPanel_Public_set_Void_BaseRuntimePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665505);
			DefaultEventSystem.NativeMethodInfoPtr_Update_Public_Void_UpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665506);
			DefaultEventSystem.NativeMethodInfoPtr_FocusBasedEventSequence_Internal_FocusBasedEventSequenceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665507);
			DefaultEventSystem.NativeMethodInfoPtr_SendIMGUIEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665508);
			DefaultEventSystem.NativeMethodInfoPtr_ProcessMouseEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665509);
			DefaultEventSystem.NativeMethodInfoPtr_SendInputEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665510);
			DefaultEventSystem.NativeMethodInfoPtr_OnFocusEvent_Internal_Void_RuntimePanel_FocusEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665511);
			DefaultEventSystem.NativeMethodInfoPtr_SendFocusBasedEvent_Internal_Void_Func_2_TArg_EventBase_TArg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665512);
			DefaultEventSystem.NativeMethodInfoPtr_SendPositionBasedEvent_Private_Void_Vector3_Vector3_Int32_Nullable_1_Int32_Func_4_Vector3_Vector3_TArg_EventBase_TArg_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665513);
			DefaultEventSystem.NativeMethodInfoPtr_UpdateFocusedPanel_Private_Void_BaseRuntimePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665514);
			DefaultEventSystem.NativeMethodInfoPtr_MakeTouchEvent_Private_Static_EventBase_Touch_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665515);
			DefaultEventSystem.NativeMethodInfoPtr_MakePenEvent_Private_Static_EventBase_PenData_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665516);
			DefaultEventSystem.NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665517);
			DefaultEventSystem.NativeMethodInfoPtr_ProcessPenEvents_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665518);
			DefaultEventSystem.NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665519);
			DefaultEventSystem.NativeMethodInfoPtr_ShouldSendMoveFromInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665520);
			DefaultEventSystem.NativeMethodInfoPtr_ProcessTabEvent_Private_Void_Event_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665521);
			DefaultEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, 100665522);
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x00053F78 File Offset: 0x00052178
		public unsafe bool isAppFocused
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307962, XrefRangeEnd = 307966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_get_isAppFocused_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x00053FB4 File Offset: 0x000521B4
		// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x00008051 File Offset: 0x00006251
		public unsafe DefaultEventSystem.IInput input
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 307968, RefRangeEnd = 307975, XrefRangeStart = 307966, XrefRangeEnd = 307968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_get_input_Internal_get_IInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DefaultEventSystem.IInput>(intPtr3) : null;
			}
			set
			{
				this.m_Input = value;
			}
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x00053FF4 File Offset: 0x000521F4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 307990, RefRangeEnd = 308008, XrefRangeStart = 307975, XrefRangeEnd = 307990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultEventSystem.IInput GetDefaultInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_GetDefaultInput_Private_IInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DefaultEventSystem.IInput>(intPtr3) : null;
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00054034 File Offset: 0x00052234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308008, XrefRangeEnd = 308009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldIgnoreEventsOnAppNotFocused()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_ShouldIgnoreEventsOnAppNotFocused_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x00054070 File Offset: 0x00052270
		// (set) Token: 0x06000F91 RID: 3985 RVA: 0x000540B0 File Offset: 0x000522B0
		public unsafe BaseRuntimePanel focusedPanel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_get_focusedPanel_Public_get_BaseRuntimePanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseRuntimePanel>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 308012, RefRangeEnd = 308016, XrefRangeStart = 308009, XrefRangeEnd = 308012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_set_focusedPanel_Public_set_Void_BaseRuntimePanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x000540F4 File Offset: 0x000522F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308032, RefRangeEnd = 308033, XrefRangeStart = 308016, XrefRangeEnd = 308032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(DefaultEventSystem.UpdateMode updateMode = DefaultEventSystem.UpdateMode.Always)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_Update_Public_Void_UpdateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00054134 File Offset: 0x00052334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308033, XrefRangeEnd = 308034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultEventSystem.FocusBasedEventSequenceContext FocusBasedEventSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_FocusBasedEventSequence_Internal_FocusBasedEventSequenceContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new DefaultEventSystem.FocusBasedEventSequenceContext(intPtr);
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x0005416C File Offset: 0x0005236C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308139, RefRangeEnd = 308140, XrefRangeStart = 308034, XrefRangeEnd = 308139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendIMGUIEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_SendIMGUIEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x000541A0 File Offset: 0x000523A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308247, RefRangeEnd = 308248, XrefRangeStart = 308140, XrefRangeEnd = 308247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMouseEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_ProcessMouseEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x000541D4 File Offset: 0x000523D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308306, RefRangeEnd = 308307, XrefRangeStart = 308248, XrefRangeEnd = 308306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendInputEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_SendInputEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00054208 File Offset: 0x00052408
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 308012, RefRangeEnd = 308016, XrefRangeStart = 308012, XrefRangeEnd = 308016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFocusEvent(RuntimePanel panel, FocusEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_OnFocusEvent_Internal_Void_RuntimePanel_FocusEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0005425C File Offset: 0x0005245C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308343, RefRangeEnd = 308344, XrefRangeStart = 308307, XrefRangeEnd = 308343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendFocusBasedEvent<TArg>(Func<TArg, EventBase> evtFactory, TArg arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evtFactory);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArg).IsValueType)
			{
				TArg targ = arg;
				intPtr = ((targ is string) ? IL2CPP.ManagedStringToIl2Cpp(targ as string) : IL2CPP.Il2CppObjectBaseToPtr(targ as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.MethodInfoStoreGeneric_SendFocusBasedEvent_Internal_Void_Func_2_TArg_EventBase_TArg_0<TArg>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x000542E8 File Offset: 0x000524E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 308403, RefRangeEnd = 308406, XrefRangeStart = 308344, XrefRangeEnd = 308403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPositionBasedEvent<TArg>(Vector3 mousePosition, Vector3 delta, int pointerId, Nullable<int> targetDisplay, Func<Vector3, Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mousePosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delta;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(targetDisplay));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evtFactory);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArg).IsValueType)
			{
				TArg targ = arg;
				intPtr = ((targ is string) ? IL2CPP.ManagedStringToIl2Cpp(targ as string) : IL2CPP.Il2CppObjectBaseToPtr(targ as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deselectIfNoTarget;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.MethodInfoStoreGeneric_SendPositionBasedEvent_Private_Void_Vector3_Vector3_Int32_Nullable_1_Int32_Func_4_Vector3_Vector3_TArg_EventBase_TArg_Boolean_0<TArg>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x000543C4 File Offset: 0x000525C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308410, RefRangeEnd = 308412, XrefRangeStart = 308406, XrefRangeEnd = 308410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFocusedPanel(BaseRuntimePanel runtimePanel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(runtimePanel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_UpdateFocusedPanel_Private_Void_BaseRuntimePanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00054408 File Offset: 0x00052608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308418, RefRangeEnd = 308419, XrefRangeStart = 308412, XrefRangeEnd = 308418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventBase MakeTouchEvent(Touch touch, EventModifiers modifiers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_MakeTouchEvent_Private_Static_EventBase_Touch_EventModifiers_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00054458 File Offset: 0x00052658
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308423, RefRangeEnd = 308424, XrefRangeStart = 308419, XrefRangeEnd = 308423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventBase MakePenEvent(PenData pen, EventModifiers modifiers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pen;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_MakePenEvent_Private_Static_EventBase_PenData_EventModifiers_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x000544A8 File Offset: 0x000526A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308478, RefRangeEnd = 308479, XrefRangeStart = 308424, XrefRangeEnd = 308478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessTouchEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x000544E4 File Offset: 0x000526E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308512, RefRangeEnd = 308513, XrefRangeStart = 308479, XrefRangeEnd = 308512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessPenEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_ProcessPenEvents_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00054520 File Offset: 0x00052720
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308531, RefRangeEnd = 308533, XrefRangeStart = 308513, XrefRangeEnd = 308531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetRawMoveVector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x0005455C File Offset: 0x0005275C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308542, RefRangeEnd = 308543, XrefRangeStart = 308533, XrefRangeEnd = 308542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldSendMoveFromInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_ShouldSendMoveFromInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00054598 File Offset: 0x00052798
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308568, RefRangeEnd = 308569, XrefRangeStart = 308543, XrefRangeEnd = 308568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessTabEvent(Event e, EventModifiers modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr_ProcessTabEvent_Private_Void_Event_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x000545E8 File Offset: 0x000527E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308593, RefRangeEnd = 308595, XrefRangeStart = 308569, XrefRangeEnd = 308593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultEventSystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00007DA5 File Offset: 0x00005FA5
		public DefaultEventSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00054624 File Offset: 0x00052824
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x00007DAE File Offset: 0x00005FAE
		public unsafe static Func<bool> IsEditorRemoteConnected
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultEventSystem.NativeFieldInfoPtr_IsEditorRemoteConnected, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultEventSystem.NativeFieldInfoPtr_IsEditorRemoteConnected, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x0005464C File Offset: 0x0005284C
		// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x00007DC0 File Offset: 0x00005FC0
		public unsafe DefaultEventSystem.IInput m_Input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_Input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultEventSystem.IInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_Input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x0005467C File Offset: 0x0005287C
		// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x00007DDF File Offset: 0x00005FDF
		public unsafe string m_HorizontalAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_HorizontalAxis);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_HorizontalAxis), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x000546A4 File Offset: 0x000528A4
		// (set) Token: 0x06000FAB RID: 4011 RVA: 0x00007DFE File Offset: 0x00005FFE
		public unsafe string m_VerticalAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_VerticalAxis);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_VerticalAxis), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x000546CC File Offset: 0x000528CC
		// (set) Token: 0x06000FAD RID: 4013 RVA: 0x00007E1D File Offset: 0x0000601D
		public unsafe string m_SubmitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_SubmitButton);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_SubmitButton), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x000546F4 File Offset: 0x000528F4
		// (set) Token: 0x06000FAF RID: 4015 RVA: 0x00007E3C File Offset: 0x0000603C
		public unsafe string m_CancelButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_CancelButton);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_CancelButton), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x0005471C File Offset: 0x0005291C
		// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x00007E5B File Offset: 0x0000605B
		public unsafe float m_InputActionsPerSecond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_InputActionsPerSecond);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_InputActionsPerSecond)) = value;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x00054744 File Offset: 0x00052944
		// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x00007E76 File Offset: 0x00006076
		public unsafe float m_RepeatDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_RepeatDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_RepeatDelay)) = value;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x0005476C File Offset: 0x0005296C
		// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x00007E91 File Offset: 0x00006091
		public unsafe bool m_SendingTouchEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_SendingTouchEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_SendingTouchEvents)) = value;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x00054794 File Offset: 0x00052994
		// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x00007EAC File Offset: 0x000060AC
		public unsafe bool m_SendingPenEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_SendingPenEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_SendingPenEvent)) = value;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x000547BC File Offset: 0x000529BC
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x00007EC7 File Offset: 0x000060C7
		public unsafe Event m_Event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_Event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x000547EC File Offset: 0x000529EC
		// (set) Token: 0x06000FBB RID: 4027 RVA: 0x00007EE6 File Offset: 0x000060E6
		public unsafe BaseRuntimePanel m_FocusedPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_FocusedPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseRuntimePanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_FocusedPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x0005481C File Offset: 0x00052A1C
		// (set) Token: 0x06000FBD RID: 4029 RVA: 0x00007F05 File Offset: 0x00006105
		public unsafe BaseRuntimePanel m_PreviousFocusedPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_PreviousFocusedPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseRuntimePanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_PreviousFocusedPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x0005484C File Offset: 0x00052A4C
		// (set) Token: 0x06000FBF RID: 4031 RVA: 0x00007F24 File Offset: 0x00006124
		public unsafe Focusable m_PreviousFocusedElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_PreviousFocusedElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_PreviousFocusedElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x0005487C File Offset: 0x00052A7C
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x00007F43 File Offset: 0x00006143
		public unsafe EventModifiers m_CurrentModifiers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_CurrentModifiers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_CurrentModifiers)) = value;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x000548A4 File Offset: 0x00052AA4
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x00007F5E File Offset: 0x0000615E
		public unsafe int m_LastMousePressButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_LastMousePressButton);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_LastMousePressButton)) = value;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x000548CC File Offset: 0x00052ACC
		// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x00007F79 File Offset: 0x00006179
		public unsafe float m_NextMousePressTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_NextMousePressTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_NextMousePressTime)) = value;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x000548F4 File Offset: 0x00052AF4
		// (set) Token: 0x06000FC7 RID: 4039 RVA: 0x00007F94 File Offset: 0x00006194
		public unsafe int m_LastMouseClickCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_LastMouseClickCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_LastMouseClickCount)) = value;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x0005491C File Offset: 0x00052B1C
		// (set) Token: 0x06000FC9 RID: 4041 RVA: 0x00007FAF File Offset: 0x000061AF
		public unsafe Vector2 m_LastMousePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_LastMousePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_LastMousePosition)) = value;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x00054944 File Offset: 0x00052B44
		// (set) Token: 0x06000FCB RID: 4043 RVA: 0x00007FCA File Offset: 0x000061CA
		public unsafe bool m_MouseProcessedAtLeastOnce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_MouseProcessedAtLeastOnce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_MouseProcessedAtLeastOnce)) = value;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x0005496C File Offset: 0x00052B6C
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x00007FE5 File Offset: 0x000061E5
		public unsafe int m_ConsecutiveMoveCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_ConsecutiveMoveCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_ConsecutiveMoveCount)) = value;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x00054994 File Offset: 0x00052B94
		// (set) Token: 0x06000FCF RID: 4047 RVA: 0x00008000 File Offset: 0x00006200
		public unsafe Vector2 m_LastMoveVector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_LastMoveVector);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_LastMoveVector)) = value;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x000549BC File Offset: 0x00052BBC
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x0000801B File Offset: 0x0000621B
		public unsafe float m_PrevActionTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_PrevActionTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_PrevActionTime)) = value;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x000549E4 File Offset: 0x00052BE4
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x00008036 File Offset: 0x00006236
		public unsafe bool m_IsMoveFromKeyboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_IsMoveFromKeyboard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.NativeFieldInfoPtr_m_IsMoveFromKeyboard)) = value;
			}
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00054A0C File Offset: 0x00052C0C
		public void Reset()
		{
			this.m_LastMousePressButton = -1;
			this.m_NextMousePressTime = 0f;
			this.m_LastMouseClickCount = 0;
			this.m_LastMousePosition = Vector2.zero;
			this.m_MouseProcessedAtLeastOnce = false;
			this.m_ConsecutiveMoveCount = 0;
			this.m_IsMoveFromKeyboard = false;
			this.m_FocusedPanel = null;
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00054A5C File Offset: 0x00052C5C
		public void SendPositionBasedEvent<TArg>(Vector3 mousePosition, Vector3 delta, int pointerId, Func<Vector3, Vector3, TArg, EventBase> evtFactory, TArg arg, [Optional] bool deselectIfNoTarget)
		{
			this.SendPositionBasedEvent<TArg>(mousePosition, delta, pointerId, null, evtFactory, arg, deselectIfNoTarget);
		}

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeFieldInfoPtr_IsEditorRemoteConnected;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeFieldInfoPtr_m_Input;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalAxis;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalAxis;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeFieldInfoPtr_m_SubmitButton;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeFieldInfoPtr_m_CancelButton;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeFieldInfoPtr_m_InputActionsPerSecond;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeFieldInfoPtr_m_RepeatDelay;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeFieldInfoPtr_m_SendingTouchEvents;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeFieldInfoPtr_m_SendingPenEvent;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeFieldInfoPtr_m_Event;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeFieldInfoPtr_m_FocusedPanel;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousFocusedPanel;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousFocusedElement;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentModifiers;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeFieldInfoPtr_m_LastMousePressButton;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeFieldInfoPtr_m_NextMousePressTime;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeFieldInfoPtr_m_LastMouseClickCount;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeFieldInfoPtr_m_LastMousePosition;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeFieldInfoPtr_m_MouseProcessedAtLeastOnce;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeFieldInfoPtr_m_ConsecutiveMoveCount;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeFieldInfoPtr_m_LastMoveVector;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevActionTime;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeFieldInfoPtr_m_IsMoveFromKeyboard;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeMethodInfoPtr_get_isAppFocused_Private_get_Boolean_0;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr_get_input_Internal_get_IInput_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInput_Private_IInput_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr_ShouldIgnoreEventsOnAppNotFocused_Private_Boolean_0;

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeMethodInfoPtr_get_focusedPanel_Public_get_BaseRuntimePanel_0;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeMethodInfoPtr_set_focusedPanel_Public_set_Void_BaseRuntimePanel_0;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_UpdateMode_0;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeMethodInfoPtr_FocusBasedEventSequence_Internal_FocusBasedEventSequenceContext_0;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeMethodInfoPtr_SendIMGUIEvents_Private_Void_0;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMouseEvents_Private_Void_0;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeMethodInfoPtr_SendInputEvents_Private_Void_0;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeMethodInfoPtr_OnFocusEvent_Internal_Void_RuntimePanel_FocusEvent_0;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeMethodInfoPtr_SendFocusBasedEvent_Internal_Void_Func_2_TArg_EventBase_TArg_0;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeMethodInfoPtr_SendPositionBasedEvent_Private_Void_Vector3_Vector3_Int32_Nullable_1_Int32_Func_4_Vector3_Vector3_TArg_EventBase_TArg_Boolean_0;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFocusedPanel_Private_Void_BaseRuntimePanel_0;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr_MakeTouchEvent_Private_Static_EventBase_Touch_EventModifiers_0;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeMethodInfoPtr_MakePenEvent_Private_Static_EventBase_PenData_EventModifiers_0;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPenEvents_Private_Boolean_0;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSendMoveFromInput_Private_Boolean_0;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTabEvent_Private_Void_Event_EventModifiers_0;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003D7 RID: 983
		public enum UpdateMode
		{
			// Token: 0x040028F0 RID: 10480
			Always,
			// Token: 0x040028F1 RID: 10481
			IgnoreIfAppNotFocused
		}

		// Token: 0x020003D8 RID: 984
		public sealed class FocusBasedEventSequenceContext : ValueType
		{
			// Token: 0x060039F1 RID: 14833 RVA: 0x000EAC58 File Offset: 0x000E8E58
			// Note: this type is marked as 'beforefieldinit'.
			static FocusBasedEventSequenceContext()
			{
				Il2CppClassPointerStore<DefaultEventSystem.FocusBasedEventSequenceContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "FocusBasedEventSequenceContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultEventSystem.FocusBasedEventSequenceContext>.NativeClassPtr);
				DefaultEventSystem.FocusBasedEventSequenceContext.NativeFieldInfoPtr_es = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem.FocusBasedEventSequenceContext>.NativeClassPtr, "es");
				DefaultEventSystem.FocusBasedEventSequenceContext.NativeMethodInfoPtr__ctor_Public_Void_DefaultEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.FocusBasedEventSequenceContext>.NativeClassPtr, 100665524);
				DefaultEventSystem.FocusBasedEventSequenceContext.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.FocusBasedEventSequenceContext>.NativeClassPtr, 100665525);
			}

			// Token: 0x060039F2 RID: 14834 RVA: 0x000EACC0 File Offset: 0x000E8EC0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 307874, RefRangeEnd = 307876, XrefRangeStart = 307868, XrefRangeEnd = 307874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FocusBasedEventSequenceContext(DefaultEventSystem es)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultEventSystem.FocusBasedEventSequenceContext>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(es);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.FocusBasedEventSequenceContext.NativeMethodInfoPtr__ctor_Public_Void_DefaultEventSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060039F3 RID: 14835 RVA: 0x000EAD10 File Offset: 0x000E8F10
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 307879, RefRangeEnd = 307881, XrefRangeStart = 307876, XrefRangeEnd = 307879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.FocusBasedEventSequenceContext.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039F4 RID: 14836 RVA: 0x00018864 File Offset: 0x00016A64
			public FocusBasedEventSequenceContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060039F5 RID: 14837 RVA: 0x0001886D File Offset: 0x00016A6D
			public FocusBasedEventSequenceContext()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultEventSystem.FocusBasedEventSequenceContext>.NativeClassPtr))
			{
			}

			// Token: 0x170011C1 RID: 4545
			// (get) Token: 0x060039F6 RID: 14838 RVA: 0x000EAD48 File Offset: 0x000E8F48
			// (set) Token: 0x060039F7 RID: 14839 RVA: 0x0001887F File Offset: 0x00016A7F
			public unsafe DefaultEventSystem es
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.FocusBasedEventSequenceContext.NativeFieldInfoPtr_es);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultEventSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultEventSystem.FocusBasedEventSequenceContext.NativeFieldInfoPtr_es), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040028F2 RID: 10482
			private static readonly IntPtr NativeFieldInfoPtr_es;

			// Token: 0x040028F3 RID: 10483
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DefaultEventSystem_0;

			// Token: 0x040028F4 RID: 10484
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x020003D9 RID: 985
		public class IInput : Il2CppObjectBase
		{
			// Token: 0x060039F8 RID: 14840 RVA: 0x000EAD78 File Offset: 0x000E8F78
			// Note: this type is marked as 'beforefieldinit'.
			static IInput()
			{
				Il2CppClassPointerStore<DefaultEventSystem.IInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "IInput");
				DefaultEventSystem.IInput.NativeMethodInfoPtr_GetButtonDown_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.IInput>.NativeClassPtr, 100665526);
				DefaultEventSystem.IInput.NativeMethodInfoPtr_GetAxisRaw_Public_Abstract_Virtual_New_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.IInput>.NativeClassPtr, 100665527);
				DefaultEventSystem.IInput.NativeMethodInfoPtr_ClearLastPenContactEvent_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.IInput>.NativeClassPtr, 100665528);
				DefaultEventSystem.IInput.NativeMethodInfoPtr_GetLastPenContactEvent_Public_Abstract_Virtual_New_PenData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.IInput>.NativeClassPtr, 100665529);
				DefaultEventSystem.IInput.NativeMethodInfoPtr_get_touchCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.IInput>.NativeClassPtr, 100665530);
				DefaultEventSystem.IInput.NativeMethodInfoPtr_GetTouch_Public_Abstract_Virtual_New_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.IInput>.NativeClassPtr, 100665531);
				DefaultEventSystem.IInput.NativeMethodInfoPtr_get_mousePresent_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.IInput>.NativeClassPtr, 100665532);
				DefaultEventSystem.IInput.NativeMethodInfoPtr_GetMouseButtonDown_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.IInput>.NativeClassPtr, 100665533);
				DefaultEventSystem.IInput.NativeMethodInfoPtr_GetMouseButtonUp_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.IInput>.NativeClassPtr, 100665534);
				DefaultEventSystem.IInput.NativeMethodInfoPtr_get_mousePosition_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.IInput>.NativeClassPtr, 100665535);
				DefaultEventSystem.IInput.NativeMethodInfoPtr_get_mouseButtonCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.IInput>.NativeClassPtr, 100665536);
				DefaultEventSystem.IInput.NativeMethodInfoPtr_get_anyKey_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.IInput>.NativeClassPtr, 100665537);
				DefaultEventSystem.IInput.NativeMethodInfoPtr_get_unscaledTime_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.IInput>.NativeClassPtr, 100665538);
				DefaultEventSystem.IInput.NativeMethodInfoPtr_get_doubleClickTime_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.IInput>.NativeClassPtr, 100665539);
			}

			// Token: 0x060039F9 RID: 14841 RVA: 0x000EAEB4 File Offset: 0x000E90B4
			[CallerCount(0)]
			public unsafe virtual bool GetButtonDown(string button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(button);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultEventSystem.IInput.NativeMethodInfoPtr_GetButtonDown_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060039FA RID: 14842 RVA: 0x000EAF0C File Offset: 0x000E910C
			[CallerCount(0)]
			public unsafe virtual float GetAxisRaw(string axis)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(axis);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultEventSystem.IInput.NativeMethodInfoPtr_GetAxisRaw_Public_Abstract_Virtual_New_Single_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060039FB RID: 14843 RVA: 0x000EAF64 File Offset: 0x000E9164
			[CallerCount(0)]
			public unsafe virtual void ClearLastPenContactEvent()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultEventSystem.IInput.NativeMethodInfoPtr_ClearLastPenContactEvent_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039FC RID: 14844 RVA: 0x000EAFA0 File Offset: 0x000E91A0
			[CallerCount(0)]
			public unsafe virtual PenData GetLastPenContactEvent()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultEventSystem.IInput.NativeMethodInfoPtr_GetLastPenContactEvent_Public_Abstract_Virtual_New_PenData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170011C2 RID: 4546
			// (get) Token: 0x060039FD RID: 14845 RVA: 0x000EAFE8 File Offset: 0x000E91E8
			public unsafe virtual int touchCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultEventSystem.IInput.NativeMethodInfoPtr_get_touchCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060039FE RID: 14846 RVA: 0x000EB030 File Offset: 0x000E9230
			[CallerCount(0)]
			public unsafe virtual Touch GetTouch(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultEventSystem.IInput.NativeMethodInfoPtr_GetTouch_Public_Abstract_Virtual_New_Touch_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011C3 RID: 4547
			// (get) Token: 0x060039FF RID: 14847 RVA: 0x000EB084 File Offset: 0x000E9284
			public unsafe virtual bool mousePresent
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultEventSystem.IInput.NativeMethodInfoPtr_get_mousePresent_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A00 RID: 14848 RVA: 0x000EB0CC File Offset: 0x000E92CC
			[CallerCount(0)]
			public unsafe virtual bool GetMouseButtonDown(int button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultEventSystem.IInput.NativeMethodInfoPtr_GetMouseButtonDown_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A01 RID: 14849 RVA: 0x000EB120 File Offset: 0x000E9320
			[CallerCount(0)]
			public unsafe virtual bool GetMouseButtonUp(int button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultEventSystem.IInput.NativeMethodInfoPtr_GetMouseButtonUp_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011C4 RID: 4548
			// (get) Token: 0x06003A02 RID: 14850 RVA: 0x000EB174 File Offset: 0x000E9374
			public unsafe virtual Vector3 mousePosition
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultEventSystem.IInput.NativeMethodInfoPtr_get_mousePosition_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011C5 RID: 4549
			// (get) Token: 0x06003A03 RID: 14851 RVA: 0x000EB1BC File Offset: 0x000E93BC
			public unsafe virtual int mouseButtonCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultEventSystem.IInput.NativeMethodInfoPtr_get_mouseButtonCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011C6 RID: 4550
			// (get) Token: 0x06003A04 RID: 14852 RVA: 0x000EB204 File Offset: 0x000E9404
			public unsafe virtual bool anyKey
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultEventSystem.IInput.NativeMethodInfoPtr_get_anyKey_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011C7 RID: 4551
			// (get) Token: 0x06003A05 RID: 14853 RVA: 0x000EB24C File Offset: 0x000E944C
			public unsafe virtual float unscaledTime
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultEventSystem.IInput.NativeMethodInfoPtr_get_unscaledTime_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011C8 RID: 4552
			// (get) Token: 0x06003A06 RID: 14854 RVA: 0x000EB294 File Offset: 0x000E9494
			public unsafe virtual float doubleClickTime
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultEventSystem.IInput.NativeMethodInfoPtr_get_doubleClickTime_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A07 RID: 14855 RVA: 0x0001889E File Offset: 0x00016A9E
			public IInput(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040028F5 RID: 10485
			private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Abstract_Virtual_New_Boolean_String_0;

			// Token: 0x040028F6 RID: 10486
			private static readonly IntPtr NativeMethodInfoPtr_GetAxisRaw_Public_Abstract_Virtual_New_Single_String_0;

			// Token: 0x040028F7 RID: 10487
			private static readonly IntPtr NativeMethodInfoPtr_ClearLastPenContactEvent_Public_Abstract_Virtual_New_Void_0;

			// Token: 0x040028F8 RID: 10488
			private static readonly IntPtr NativeMethodInfoPtr_GetLastPenContactEvent_Public_Abstract_Virtual_New_PenData_0;

			// Token: 0x040028F9 RID: 10489
			private static readonly IntPtr NativeMethodInfoPtr_get_touchCount_Public_Abstract_Virtual_New_get_Int32_0;

			// Token: 0x040028FA RID: 10490
			private static readonly IntPtr NativeMethodInfoPtr_GetTouch_Public_Abstract_Virtual_New_Touch_Int32_0;

			// Token: 0x040028FB RID: 10491
			private static readonly IntPtr NativeMethodInfoPtr_get_mousePresent_Public_Abstract_Virtual_New_get_Boolean_0;

			// Token: 0x040028FC RID: 10492
			private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonDown_Public_Abstract_Virtual_New_Boolean_Int32_0;

			// Token: 0x040028FD RID: 10493
			private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonUp_Public_Abstract_Virtual_New_Boolean_Int32_0;

			// Token: 0x040028FE RID: 10494
			private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Public_Abstract_Virtual_New_get_Vector3_0;

			// Token: 0x040028FF RID: 10495
			private static readonly IntPtr NativeMethodInfoPtr_get_mouseButtonCount_Public_Abstract_Virtual_New_get_Int32_0;

			// Token: 0x04002900 RID: 10496
			private static readonly IntPtr NativeMethodInfoPtr_get_anyKey_Public_Abstract_Virtual_New_get_Boolean_0;

			// Token: 0x04002901 RID: 10497
			private static readonly IntPtr NativeMethodInfoPtr_get_unscaledTime_Public_Abstract_Virtual_New_get_Single_0;

			// Token: 0x04002902 RID: 10498
			private static readonly IntPtr NativeMethodInfoPtr_get_doubleClickTime_Public_Abstract_Virtual_New_get_Single_0;
		}

		// Token: 0x020003DA RID: 986
		public class Input : Object
		{
			// Token: 0x06003A08 RID: 14856 RVA: 0x000EB2DC File Offset: 0x000E94DC
			// Note: this type is marked as 'beforefieldinit'.
			static Input()
			{
				Il2CppClassPointerStore<DefaultEventSystem.Input>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "Input");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultEventSystem.Input>.NativeClassPtr);
				DefaultEventSystem.Input.NativeMethodInfoPtr_GetButtonDown_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.Input>.NativeClassPtr, 100665540);
				DefaultEventSystem.Input.NativeMethodInfoPtr_GetAxisRaw_Public_Virtual_Final_New_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.Input>.NativeClassPtr, 100665541);
				DefaultEventSystem.Input.NativeMethodInfoPtr_ClearLastPenContactEvent_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.Input>.NativeClassPtr, 100665542);
				DefaultEventSystem.Input.NativeMethodInfoPtr_GetLastPenContactEvent_Public_Virtual_Final_New_PenData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.Input>.NativeClassPtr, 100665543);
				DefaultEventSystem.Input.NativeMethodInfoPtr_get_touchCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.Input>.NativeClassPtr, 100665544);
				DefaultEventSystem.Input.NativeMethodInfoPtr_GetTouch_Public_Virtual_Final_New_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.Input>.NativeClassPtr, 100665545);
				DefaultEventSystem.Input.NativeMethodInfoPtr_get_mousePresent_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.Input>.NativeClassPtr, 100665546);
				DefaultEventSystem.Input.NativeMethodInfoPtr_GetMouseButtonDown_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.Input>.NativeClassPtr, 100665547);
				DefaultEventSystem.Input.NativeMethodInfoPtr_GetMouseButtonUp_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.Input>.NativeClassPtr, 100665548);
				DefaultEventSystem.Input.NativeMethodInfoPtr_get_mousePosition_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.Input>.NativeClassPtr, 100665549);
				DefaultEventSystem.Input.NativeMethodInfoPtr_get_mouseButtonCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.Input>.NativeClassPtr, 100665550);
				DefaultEventSystem.Input.NativeMethodInfoPtr_get_anyKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.Input>.NativeClassPtr, 100665551);
				DefaultEventSystem.Input.NativeMethodInfoPtr_get_unscaledTime_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.Input>.NativeClassPtr, 100665552);
				DefaultEventSystem.Input.NativeMethodInfoPtr_get_doubleClickTime_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.Input>.NativeClassPtr, 100665553);
				DefaultEventSystem.Input.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.Input>.NativeClassPtr, 100665554);
			}

			// Token: 0x06003A09 RID: 14857 RVA: 0x000EB434 File Offset: 0x000E9634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307881, XrefRangeEnd = 307882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool GetButtonDown(string button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(button);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.Input.NativeMethodInfoPtr_GetButtonDown_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A0A RID: 14858 RVA: 0x000EB484 File Offset: 0x000E9684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307882, XrefRangeEnd = 307883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual float GetAxisRaw(string axis)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(axis);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.Input.NativeMethodInfoPtr_GetAxisRaw_Public_Virtual_Final_New_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A0B RID: 14859 RVA: 0x000EB4D4 File Offset: 0x000E96D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307883, XrefRangeEnd = 307884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void ClearLastPenContactEvent()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.Input.NativeMethodInfoPtr_ClearLastPenContactEvent_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A0C RID: 14860 RVA: 0x000EB508 File Offset: 0x000E9708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307884, XrefRangeEnd = 307885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual PenData GetLastPenContactEvent()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.Input.NativeMethodInfoPtr_GetLastPenContactEvent_Public_Virtual_Final_New_PenData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170011C9 RID: 4553
			// (get) Token: 0x06003A0D RID: 14861 RVA: 0x000EB544 File Offset: 0x000E9744
			public unsafe virtual int touchCount
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307885, XrefRangeEnd = 307886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.Input.NativeMethodInfoPtr_get_touchCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A0E RID: 14862 RVA: 0x000EB580 File Offset: 0x000E9780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307886, XrefRangeEnd = 307887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Touch GetTouch(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.Input.NativeMethodInfoPtr_GetTouch_Public_Virtual_Final_New_Touch_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011CA RID: 4554
			// (get) Token: 0x06003A0F RID: 14863 RVA: 0x000EB5CC File Offset: 0x000E97CC
			public unsafe virtual bool mousePresent
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307887, XrefRangeEnd = 307888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.Input.NativeMethodInfoPtr_get_mousePresent_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A10 RID: 14864 RVA: 0x000EB608 File Offset: 0x000E9808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307888, XrefRangeEnd = 307889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool GetMouseButtonDown(int button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.Input.NativeMethodInfoPtr_GetMouseButtonDown_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A11 RID: 14865 RVA: 0x000EB654 File Offset: 0x000E9854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307889, XrefRangeEnd = 307890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool GetMouseButtonUp(int button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.Input.NativeMethodInfoPtr_GetMouseButtonUp_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011CB RID: 4555
			// (get) Token: 0x06003A12 RID: 14866 RVA: 0x000EB6A0 File Offset: 0x000E98A0
			public unsafe virtual Vector3 mousePosition
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307890, XrefRangeEnd = 307891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.Input.NativeMethodInfoPtr_get_mousePosition_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011CC RID: 4556
			// (get) Token: 0x06003A13 RID: 14867 RVA: 0x000EB6DC File Offset: 0x000E98DC
			public unsafe virtual int mouseButtonCount
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.Input.NativeMethodInfoPtr_get_mouseButtonCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011CD RID: 4557
			// (get) Token: 0x06003A14 RID: 14868 RVA: 0x000EB718 File Offset: 0x000E9918
			public unsafe virtual bool anyKey
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307891, XrefRangeEnd = 307892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.Input.NativeMethodInfoPtr_get_anyKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011CE RID: 4558
			// (get) Token: 0x06003A15 RID: 14869 RVA: 0x000EB754 File Offset: 0x000E9954
			public unsafe virtual float unscaledTime
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307892, XrefRangeEnd = 307893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.Input.NativeMethodInfoPtr_get_unscaledTime_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011CF RID: 4559
			// (get) Token: 0x06003A16 RID: 14870 RVA: 0x000EB790 File Offset: 0x000E9990
			public unsafe virtual float doubleClickTime
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307893, XrefRangeEnd = 307894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.Input.NativeMethodInfoPtr_get_doubleClickTime_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A17 RID: 14871 RVA: 0x000EB7CC File Offset: 0x000E99CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Input()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultEventSystem.Input>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.Input.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A18 RID: 14872 RVA: 0x000188A7 File Offset: 0x00016AA7
			public Input(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002903 RID: 10499
			private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Virtual_Final_New_Boolean_String_0;

			// Token: 0x04002904 RID: 10500
			private static readonly IntPtr NativeMethodInfoPtr_GetAxisRaw_Public_Virtual_Final_New_Single_String_0;

			// Token: 0x04002905 RID: 10501
			private static readonly IntPtr NativeMethodInfoPtr_ClearLastPenContactEvent_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002906 RID: 10502
			private static readonly IntPtr NativeMethodInfoPtr_GetLastPenContactEvent_Public_Virtual_Final_New_PenData_0;

			// Token: 0x04002907 RID: 10503
			private static readonly IntPtr NativeMethodInfoPtr_get_touchCount_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04002908 RID: 10504
			private static readonly IntPtr NativeMethodInfoPtr_GetTouch_Public_Virtual_Final_New_Touch_Int32_0;

			// Token: 0x04002909 RID: 10505
			private static readonly IntPtr NativeMethodInfoPtr_get_mousePresent_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x0400290A RID: 10506
			private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonDown_Public_Virtual_Final_New_Boolean_Int32_0;

			// Token: 0x0400290B RID: 10507
			private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonUp_Public_Virtual_Final_New_Boolean_Int32_0;

			// Token: 0x0400290C RID: 10508
			private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Public_Virtual_Final_New_get_Vector3_0;

			// Token: 0x0400290D RID: 10509
			private static readonly IntPtr NativeMethodInfoPtr_get_mouseButtonCount_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x0400290E RID: 10510
			private static readonly IntPtr NativeMethodInfoPtr_get_anyKey_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x0400290F RID: 10511
			private static readonly IntPtr NativeMethodInfoPtr_get_unscaledTime_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x04002910 RID: 10512
			private static readonly IntPtr NativeMethodInfoPtr_get_doubleClickTime_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x04002911 RID: 10513
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003DB RID: 987
		public class NoInput : Object
		{
			// Token: 0x06003A19 RID: 14873 RVA: 0x000EB808 File Offset: 0x000E9A08
			// Note: this type is marked as 'beforefieldinit'.
			static NoInput()
			{
				Il2CppClassPointerStore<DefaultEventSystem.NoInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "NoInput");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultEventSystem.NoInput>.NativeClassPtr);
				DefaultEventSystem.NoInput.NativeMethodInfoPtr_GetButtonDown_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.NoInput>.NativeClassPtr, 100665555);
				DefaultEventSystem.NoInput.NativeMethodInfoPtr_GetAxisRaw_Public_Virtual_Final_New_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.NoInput>.NativeClassPtr, 100665556);
				DefaultEventSystem.NoInput.NativeMethodInfoPtr_get_touchCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.NoInput>.NativeClassPtr, 100665557);
				DefaultEventSystem.NoInput.NativeMethodInfoPtr_GetTouch_Public_Virtual_Final_New_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.NoInput>.NativeClassPtr, 100665558);
				DefaultEventSystem.NoInput.NativeMethodInfoPtr_ClearLastPenContactEvent_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.NoInput>.NativeClassPtr, 100665559);
				DefaultEventSystem.NoInput.NativeMethodInfoPtr_GetLastPenContactEvent_Public_Virtual_Final_New_PenData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.NoInput>.NativeClassPtr, 100665560);
				DefaultEventSystem.NoInput.NativeMethodInfoPtr_get_mousePresent_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.NoInput>.NativeClassPtr, 100665561);
				DefaultEventSystem.NoInput.NativeMethodInfoPtr_GetMouseButtonDown_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.NoInput>.NativeClassPtr, 100665562);
				DefaultEventSystem.NoInput.NativeMethodInfoPtr_GetMouseButtonUp_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.NoInput>.NativeClassPtr, 100665563);
				DefaultEventSystem.NoInput.NativeMethodInfoPtr_get_mousePosition_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.NoInput>.NativeClassPtr, 100665564);
				DefaultEventSystem.NoInput.NativeMethodInfoPtr_get_mouseButtonCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.NoInput>.NativeClassPtr, 100665565);
				DefaultEventSystem.NoInput.NativeMethodInfoPtr_get_anyKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.NoInput>.NativeClassPtr, 100665566);
				DefaultEventSystem.NoInput.NativeMethodInfoPtr_get_unscaledTime_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.NoInput>.NativeClassPtr, 100665567);
				DefaultEventSystem.NoInput.NativeMethodInfoPtr_get_doubleClickTime_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.NoInput>.NativeClassPtr, 100665568);
				DefaultEventSystem.NoInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.NoInput>.NativeClassPtr, 100665569);
			}

			// Token: 0x06003A1A RID: 14874 RVA: 0x000EB960 File Offset: 0x000E9B60
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool GetButtonDown(string button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(button);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NoInput.NativeMethodInfoPtr_GetButtonDown_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A1B RID: 14875 RVA: 0x000EB9B0 File Offset: 0x000E9BB0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual float GetAxisRaw(string axis)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(axis);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NoInput.NativeMethodInfoPtr_GetAxisRaw_Public_Virtual_Final_New_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011D0 RID: 4560
			// (get) Token: 0x06003A1C RID: 14876 RVA: 0x000EBA00 File Offset: 0x000E9C00
			public unsafe virtual int touchCount
			{
				[CallerCount(74)]
				[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NoInput.NativeMethodInfoPtr_get_touchCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A1D RID: 14877 RVA: 0x000EBA3C File Offset: 0x000E9C3C
			[CallerCount(0)]
			public unsafe virtual Touch GetTouch(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NoInput.NativeMethodInfoPtr_GetTouch_Public_Virtual_Final_New_Touch_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A1E RID: 14878 RVA: 0x000EBA88 File Offset: 0x000E9C88
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void ClearLastPenContactEvent()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NoInput.NativeMethodInfoPtr_ClearLastPenContactEvent_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A1F RID: 14879 RVA: 0x000EBABC File Offset: 0x000E9CBC
			[CallerCount(0)]
			public unsafe virtual PenData GetLastPenContactEvent()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NoInput.NativeMethodInfoPtr_GetLastPenContactEvent_Public_Virtual_Final_New_PenData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170011D1 RID: 4561
			// (get) Token: 0x06003A20 RID: 14880 RVA: 0x000EBAF8 File Offset: 0x000E9CF8
			public unsafe virtual bool mousePresent
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NoInput.NativeMethodInfoPtr_get_mousePresent_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A21 RID: 14881 RVA: 0x000EBB34 File Offset: 0x000E9D34
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool GetMouseButtonDown(int button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NoInput.NativeMethodInfoPtr_GetMouseButtonDown_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A22 RID: 14882 RVA: 0x000EBB80 File Offset: 0x000E9D80
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool GetMouseButtonUp(int button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NoInput.NativeMethodInfoPtr_GetMouseButtonUp_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011D2 RID: 4562
			// (get) Token: 0x06003A23 RID: 14883 RVA: 0x000EBBCC File Offset: 0x000E9DCC
			public unsafe virtual Vector3 mousePosition
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NoInput.NativeMethodInfoPtr_get_mousePosition_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011D3 RID: 4563
			// (get) Token: 0x06003A24 RID: 14884 RVA: 0x000EBC08 File Offset: 0x000E9E08
			public unsafe virtual int mouseButtonCount
			{
				[CallerCount(74)]
				[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NoInput.NativeMethodInfoPtr_get_mouseButtonCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011D4 RID: 4564
			// (get) Token: 0x06003A25 RID: 14885 RVA: 0x000EBC44 File Offset: 0x000E9E44
			public unsafe virtual bool anyKey
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NoInput.NativeMethodInfoPtr_get_anyKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011D5 RID: 4565
			// (get) Token: 0x06003A26 RID: 14886 RVA: 0x000EBC80 File Offset: 0x000E9E80
			public unsafe virtual float unscaledTime
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NoInput.NativeMethodInfoPtr_get_unscaledTime_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011D6 RID: 4566
			// (get) Token: 0x06003A27 RID: 14887 RVA: 0x000EBCBC File Offset: 0x000E9EBC
			public unsafe virtual float doubleClickTime
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NoInput.NativeMethodInfoPtr_get_doubleClickTime_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A28 RID: 14888 RVA: 0x000EBCF8 File Offset: 0x000E9EF8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NoInput()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultEventSystem.NoInput>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.NoInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A29 RID: 14889 RVA: 0x000188B0 File Offset: 0x00016AB0
			public NoInput(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002912 RID: 10514
			private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Virtual_Final_New_Boolean_String_0;

			// Token: 0x04002913 RID: 10515
			private static readonly IntPtr NativeMethodInfoPtr_GetAxisRaw_Public_Virtual_Final_New_Single_String_0;

			// Token: 0x04002914 RID: 10516
			private static readonly IntPtr NativeMethodInfoPtr_get_touchCount_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04002915 RID: 10517
			private static readonly IntPtr NativeMethodInfoPtr_GetTouch_Public_Virtual_Final_New_Touch_Int32_0;

			// Token: 0x04002916 RID: 10518
			private static readonly IntPtr NativeMethodInfoPtr_ClearLastPenContactEvent_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002917 RID: 10519
			private static readonly IntPtr NativeMethodInfoPtr_GetLastPenContactEvent_Public_Virtual_Final_New_PenData_0;

			// Token: 0x04002918 RID: 10520
			private static readonly IntPtr NativeMethodInfoPtr_get_mousePresent_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04002919 RID: 10521
			private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonDown_Public_Virtual_Final_New_Boolean_Int32_0;

			// Token: 0x0400291A RID: 10522
			private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonUp_Public_Virtual_Final_New_Boolean_Int32_0;

			// Token: 0x0400291B RID: 10523
			private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Public_Virtual_Final_New_get_Vector3_0;

			// Token: 0x0400291C RID: 10524
			private static readonly IntPtr NativeMethodInfoPtr_get_mouseButtonCount_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x0400291D RID: 10525
			private static readonly IntPtr NativeMethodInfoPtr_get_anyKey_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x0400291E RID: 10526
			private static readonly IntPtr NativeMethodInfoPtr_get_unscaledTime_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x0400291F RID: 10527
			private static readonly IntPtr NativeMethodInfoPtr_get_doubleClickTime_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x04002920 RID: 10528
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003DC RID: 988
		[ObfuscatedName("UnityEngine.UIElements.DefaultEventSystem+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003A2A RID: 14890 RVA: 0x000EBD34 File Offset: 0x000E9F34
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr);
				DefaultEventSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, "<>9");
				DefaultEventSystem.__c.NativeFieldInfoPtr___9__30_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, "<>9__30_0");
				DefaultEventSystem.__c.NativeFieldInfoPtr___9__30_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, "<>9__30_1");
				DefaultEventSystem.__c.NativeFieldInfoPtr___9__30_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, "<>9__30_2");
				DefaultEventSystem.__c.NativeFieldInfoPtr___9__36_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, "<>9__36_0");
				DefaultEventSystem.__c.NativeFieldInfoPtr___9__36_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, "<>9__36_1");
				DefaultEventSystem.__c.NativeFieldInfoPtr___9__36_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, "<>9__36_2");
				DefaultEventSystem.__c.NativeFieldInfoPtr___9__37_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, "<>9__37_0");
				DefaultEventSystem.__c.NativeFieldInfoPtr___9__37_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, "<>9__37_1");
				DefaultEventSystem.__c.NativeFieldInfoPtr___9__37_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, "<>9__37_2");
				DefaultEventSystem.__c.NativeFieldInfoPtr___9__45_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, "<>9__45_0");
				DefaultEventSystem.__c.NativeFieldInfoPtr___9__46_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, "<>9__46_0");
				DefaultEventSystem.__c.NativeFieldInfoPtr___9__53_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, "<>9__53_0");
				DefaultEventSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, 100665571);
				DefaultEventSystem.__c.NativeMethodInfoPtr__SendIMGUIEvents_b__30_0_Internal_EventBase_DefaultEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, 100665572);
				DefaultEventSystem.__c.NativeMethodInfoPtr__SendIMGUIEvents_b__30_1_Internal_EventBase_Vector3_Vector3_ValueTuple_2_EventModifiers_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, 100665573);
				DefaultEventSystem.__c.NativeMethodInfoPtr__SendIMGUIEvents_b__30_2_Internal_EventBase_Vector3_Vector3_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, 100665574);
				DefaultEventSystem.__c.NativeMethodInfoPtr__ProcessMouseEvents_b__36_0_Internal_EventBase_Vector3_Vector3_DefaultEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, 100665575);
				DefaultEventSystem.__c.NativeMethodInfoPtr__ProcessMouseEvents_b__36_1_Internal_EventBase_Vector3_Vector3_ValueTuple_3_Int32_Int32_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, 100665576);
				DefaultEventSystem.__c.NativeMethodInfoPtr__ProcessMouseEvents_b__36_2_Internal_EventBase_Vector3_Vector3_ValueTuple_3_Int32_Int32_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, 100665577);
				DefaultEventSystem.__c.NativeMethodInfoPtr__SendInputEvents_b__37_0_Internal_EventBase_DefaultEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, 100665578);
				DefaultEventSystem.__c.NativeMethodInfoPtr__SendInputEvents_b__37_1_Internal_EventBase_DefaultEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, 100665579);
				DefaultEventSystem.__c.NativeMethodInfoPtr__SendInputEvents_b__37_2_Internal_EventBase_DefaultEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, 100665580);
				DefaultEventSystem.__c.NativeMethodInfoPtr__ProcessTouchEvents_b__45_0_Internal_EventBase_Vector3_Vector3_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, 100665581);
				DefaultEventSystem.__c.NativeMethodInfoPtr__ProcessPenEvents_b__46_0_Internal_EventBase_Vector3_Vector3_PenData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, 100665582);
				DefaultEventSystem.__c.NativeMethodInfoPtr__ProcessTabEvent_b__53_0_Internal_EventBase_ValueTuple_3_Direction_EventModifiers_IInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, 100665583);
				DefaultEventSystem.__c.NativeMethodInfoPtr___cctor_b__58_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr, 100665584);
			}

			// Token: 0x06003A2B RID: 14891 RVA: 0x000EBF7C File Offset: 0x000EA17C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultEventSystem.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A2C RID: 14892 RVA: 0x000EBFB8 File Offset: 0x000EA1B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307894, XrefRangeEnd = 307899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventBase _SendIMGUIEvents_b__30_0(DefaultEventSystem self)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.__c.NativeMethodInfoPtr__SendIMGUIEvents_b__30_0_Internal_EventBase_DefaultEventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
				}
			}

			// Token: 0x06003A2D RID: 14893 RVA: 0x000EC008 File Offset: 0x000EA208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307899, XrefRangeEnd = 307910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventBase _SendIMGUIEvents_b__30_1(Vector3 panelPosition, Vector3 _, ValueTuple<EventModifiers, Vector2> t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref panelPosition;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(t));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.__c.NativeMethodInfoPtr__SendIMGUIEvents_b__30_1_Internal_EventBase_Vector3_Vector3_ValueTuple_2_EventModifiers_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
			}

			// Token: 0x06003A2E RID: 14894 RVA: 0x000EC07C File Offset: 0x000EA27C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307910, XrefRangeEnd = 307917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventBase _SendIMGUIEvents_b__30_2(Vector3 panelPosition, Vector3 panelDelta, Event evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref panelPosition;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref panelDelta;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.__c.NativeMethodInfoPtr__SendIMGUIEvents_b__30_2_Internal_EventBase_Vector3_Vector3_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
			}

			// Token: 0x06003A2F RID: 14895 RVA: 0x000EC0E8 File Offset: 0x000EA2E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307917, XrefRangeEnd = 307920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventBase _ProcessMouseEvents_b__36_0(Vector3 panelPosition, Vector3 panelDelta, DefaultEventSystem self)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref panelPosition;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref panelDelta;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(self);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.__c.NativeMethodInfoPtr__ProcessMouseEvents_b__36_0_Internal_EventBase_Vector3_Vector3_DefaultEventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
			}

			// Token: 0x06003A30 RID: 14896 RVA: 0x000EC154 File Offset: 0x000EA354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307920, XrefRangeEnd = 307921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventBase _ProcessMouseEvents_b__36_1(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<int, int, EventModifiers> t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref panelPosition;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref panelDelta;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(t));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.__c.NativeMethodInfoPtr__ProcessMouseEvents_b__36_1_Internal_EventBase_Vector3_Vector3_ValueTuple_3_Int32_Int32_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
			}

			// Token: 0x06003A31 RID: 14897 RVA: 0x000EC1C8 File Offset: 0x000EA3C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307921, XrefRangeEnd = 307922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventBase _ProcessMouseEvents_b__36_2(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<int, int, EventModifiers> t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref panelPosition;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref panelDelta;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(t));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.__c.NativeMethodInfoPtr__ProcessMouseEvents_b__36_2_Internal_EventBase_Vector3_Vector3_ValueTuple_3_Int32_Int32_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
			}

			// Token: 0x06003A32 RID: 14898 RVA: 0x000EC23C File Offset: 0x000EA43C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307922, XrefRangeEnd = 307928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventBase _SendInputEvents_b__37_0(DefaultEventSystem self)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.__c.NativeMethodInfoPtr__SendInputEvents_b__37_0_Internal_EventBase_DefaultEventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
				}
			}

			// Token: 0x06003A33 RID: 14899 RVA: 0x000EC28C File Offset: 0x000EA48C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307928, XrefRangeEnd = 307936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventBase _SendInputEvents_b__37_1(DefaultEventSystem self)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.__c.NativeMethodInfoPtr__SendInputEvents_b__37_1_Internal_EventBase_DefaultEventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
				}
			}

			// Token: 0x06003A34 RID: 14900 RVA: 0x000EC2DC File Offset: 0x000EA4DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307936, XrefRangeEnd = 307944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventBase _SendInputEvents_b__37_2(DefaultEventSystem self)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.__c.NativeMethodInfoPtr__SendInputEvents_b__37_2_Internal_EventBase_DefaultEventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
				}
			}

			// Token: 0x06003A35 RID: 14901 RVA: 0x000EC32C File Offset: 0x000EA52C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307944, XrefRangeEnd = 307950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventBase _ProcessTouchEvents_b__45_0(Vector3 panelPosition, Vector3 panelDelta, Touch _touch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref panelPosition;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref panelDelta;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _touch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.__c.NativeMethodInfoPtr__ProcessTouchEvents_b__45_0_Internal_EventBase_Vector3_Vector3_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
			}

			// Token: 0x06003A36 RID: 14902 RVA: 0x000EC394 File Offset: 0x000EA594
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307950, XrefRangeEnd = 307954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventBase _ProcessPenEvents_b__46_0(Vector3 panelPosition, Vector3 panelDelta, PenData _pen)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref panelPosition;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref panelDelta;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _pen;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.__c.NativeMethodInfoPtr__ProcessPenEvents_b__46_0_Internal_EventBase_Vector3_Vector3_PenData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
			}

			// Token: 0x06003A37 RID: 14903 RVA: 0x000EC3FC File Offset: 0x000EA5FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307954, XrefRangeEnd = 307962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventBase _ProcessTabEvent_b__53_0(ValueTuple<NavigationMoveEvent.Direction, EventModifiers, DefaultEventSystem.IInput> t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(t));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.__c.NativeMethodInfoPtr__ProcessTabEvent_b__53_0_Internal_EventBase_ValueTuple_3_Direction_EventModifiers_IInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
				}
			}

			// Token: 0x06003A38 RID: 14904 RVA: 0x000EC454 File Offset: 0x000EA654
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __cctor_b__58_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultEventSystem.__c.NativeMethodInfoPtr___cctor_b__58_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003A39 RID: 14905 RVA: 0x000188B9 File Offset: 0x00016AB9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011D7 RID: 4567
			// (get) Token: 0x06003A3A RID: 14906 RVA: 0x000EC490 File Offset: 0x000EA690
			// (set) Token: 0x06003A3B RID: 14907 RVA: 0x000188C2 File Offset: 0x00016AC2
			public unsafe static DefaultEventSystem.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultEventSystem.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011D8 RID: 4568
			// (get) Token: 0x06003A3C RID: 14908 RVA: 0x000EC4B8 File Offset: 0x000EA6B8
			// (set) Token: 0x06003A3D RID: 14909 RVA: 0x000188D4 File Offset: 0x00016AD4
			public unsafe static Func<DefaultEventSystem, EventBase> __9__30_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__30_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DefaultEventSystem, EventBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__30_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011D9 RID: 4569
			// (get) Token: 0x06003A3E RID: 14910 RVA: 0x000EC4E0 File Offset: 0x000EA6E0
			// (set) Token: 0x06003A3F RID: 14911 RVA: 0x000188E6 File Offset: 0x00016AE6
			public unsafe static Func<Vector3, Vector3, ValueTuple<EventModifiers, Vector2>, EventBase> __9__30_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__30_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, Vector3, ValueTuple<EventModifiers, Vector2>, EventBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__30_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011DA RID: 4570
			// (get) Token: 0x06003A40 RID: 14912 RVA: 0x000EC508 File Offset: 0x000EA708
			// (set) Token: 0x06003A41 RID: 14913 RVA: 0x000188F8 File Offset: 0x00016AF8
			public unsafe static Func<Vector3, Vector3, Event, EventBase> __9__30_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__30_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, Vector3, Event, EventBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__30_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011DB RID: 4571
			// (get) Token: 0x06003A42 RID: 14914 RVA: 0x000EC530 File Offset: 0x000EA730
			// (set) Token: 0x06003A43 RID: 14915 RVA: 0x0001890A File Offset: 0x00016B0A
			public unsafe static Func<Vector3, Vector3, DefaultEventSystem, EventBase> __9__36_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__36_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, Vector3, DefaultEventSystem, EventBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__36_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011DC RID: 4572
			// (get) Token: 0x06003A44 RID: 14916 RVA: 0x000EC558 File Offset: 0x000EA758
			// (set) Token: 0x06003A45 RID: 14917 RVA: 0x0001891C File Offset: 0x00016B1C
			public unsafe static Func<Vector3, Vector3, ValueTuple<int, int, EventModifiers>, EventBase> __9__36_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__36_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, Vector3, ValueTuple<int, int, EventModifiers>, EventBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__36_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011DD RID: 4573
			// (get) Token: 0x06003A46 RID: 14918 RVA: 0x000EC580 File Offset: 0x000EA780
			// (set) Token: 0x06003A47 RID: 14919 RVA: 0x0001892E File Offset: 0x00016B2E
			public unsafe static Func<Vector3, Vector3, ValueTuple<int, int, EventModifiers>, EventBase> __9__36_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__36_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, Vector3, ValueTuple<int, int, EventModifiers>, EventBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__36_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011DE RID: 4574
			// (get) Token: 0x06003A48 RID: 14920 RVA: 0x000EC5A8 File Offset: 0x000EA7A8
			// (set) Token: 0x06003A49 RID: 14921 RVA: 0x00018940 File Offset: 0x00016B40
			public unsafe static Func<DefaultEventSystem, EventBase> __9__37_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__37_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DefaultEventSystem, EventBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__37_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011DF RID: 4575
			// (get) Token: 0x06003A4A RID: 14922 RVA: 0x000EC5D0 File Offset: 0x000EA7D0
			// (set) Token: 0x06003A4B RID: 14923 RVA: 0x00018952 File Offset: 0x00016B52
			public unsafe static Func<DefaultEventSystem, EventBase> __9__37_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__37_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DefaultEventSystem, EventBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__37_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011E0 RID: 4576
			// (get) Token: 0x06003A4C RID: 14924 RVA: 0x000EC5F8 File Offset: 0x000EA7F8
			// (set) Token: 0x06003A4D RID: 14925 RVA: 0x00018964 File Offset: 0x00016B64
			public unsafe static Func<DefaultEventSystem, EventBase> __9__37_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__37_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DefaultEventSystem, EventBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__37_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011E1 RID: 4577
			// (get) Token: 0x06003A4E RID: 14926 RVA: 0x000EC620 File Offset: 0x000EA820
			// (set) Token: 0x06003A4F RID: 14927 RVA: 0x00018976 File Offset: 0x00016B76
			public unsafe static Func<Vector3, Vector3, Touch, EventBase> __9__45_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__45_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, Vector3, Touch, EventBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__45_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011E2 RID: 4578
			// (get) Token: 0x06003A50 RID: 14928 RVA: 0x000EC648 File Offset: 0x000EA848
			// (set) Token: 0x06003A51 RID: 14929 RVA: 0x00018988 File Offset: 0x00016B88
			public unsafe static Func<Vector3, Vector3, PenData, EventBase> __9__46_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__46_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, Vector3, PenData, EventBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__46_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011E3 RID: 4579
			// (get) Token: 0x06003A52 RID: 14930 RVA: 0x000EC670 File Offset: 0x000EA870
			// (set) Token: 0x06003A53 RID: 14931 RVA: 0x0001899A File Offset: 0x00016B9A
			public unsafe static Func<ValueTuple<NavigationMoveEvent.Direction, EventModifiers, DefaultEventSystem.IInput>, EventBase> __9__53_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__53_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<NavigationMoveEvent.Direction, EventModifiers, DefaultEventSystem.IInput>, EventBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultEventSystem.__c.NativeFieldInfoPtr___9__53_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002921 RID: 10529
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002922 RID: 10530
			private static readonly IntPtr NativeFieldInfoPtr___9__30_0;

			// Token: 0x04002923 RID: 10531
			private static readonly IntPtr NativeFieldInfoPtr___9__30_1;

			// Token: 0x04002924 RID: 10532
			private static readonly IntPtr NativeFieldInfoPtr___9__30_2;

			// Token: 0x04002925 RID: 10533
			private static readonly IntPtr NativeFieldInfoPtr___9__36_0;

			// Token: 0x04002926 RID: 10534
			private static readonly IntPtr NativeFieldInfoPtr___9__36_1;

			// Token: 0x04002927 RID: 10535
			private static readonly IntPtr NativeFieldInfoPtr___9__36_2;

			// Token: 0x04002928 RID: 10536
			private static readonly IntPtr NativeFieldInfoPtr___9__37_0;

			// Token: 0x04002929 RID: 10537
			private static readonly IntPtr NativeFieldInfoPtr___9__37_1;

			// Token: 0x0400292A RID: 10538
			private static readonly IntPtr NativeFieldInfoPtr___9__37_2;

			// Token: 0x0400292B RID: 10539
			private static readonly IntPtr NativeFieldInfoPtr___9__45_0;

			// Token: 0x0400292C RID: 10540
			private static readonly IntPtr NativeFieldInfoPtr___9__46_0;

			// Token: 0x0400292D RID: 10541
			private static readonly IntPtr NativeFieldInfoPtr___9__53_0;

			// Token: 0x0400292E RID: 10542
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400292F RID: 10543
			private static readonly IntPtr NativeMethodInfoPtr__SendIMGUIEvents_b__30_0_Internal_EventBase_DefaultEventSystem_0;

			// Token: 0x04002930 RID: 10544
			private static readonly IntPtr NativeMethodInfoPtr__SendIMGUIEvents_b__30_1_Internal_EventBase_Vector3_Vector3_ValueTuple_2_EventModifiers_Vector2_0;

			// Token: 0x04002931 RID: 10545
			private static readonly IntPtr NativeMethodInfoPtr__SendIMGUIEvents_b__30_2_Internal_EventBase_Vector3_Vector3_Event_0;

			// Token: 0x04002932 RID: 10546
			private static readonly IntPtr NativeMethodInfoPtr__ProcessMouseEvents_b__36_0_Internal_EventBase_Vector3_Vector3_DefaultEventSystem_0;

			// Token: 0x04002933 RID: 10547
			private static readonly IntPtr NativeMethodInfoPtr__ProcessMouseEvents_b__36_1_Internal_EventBase_Vector3_Vector3_ValueTuple_3_Int32_Int32_EventModifiers_0;

			// Token: 0x04002934 RID: 10548
			private static readonly IntPtr NativeMethodInfoPtr__ProcessMouseEvents_b__36_2_Internal_EventBase_Vector3_Vector3_ValueTuple_3_Int32_Int32_EventModifiers_0;

			// Token: 0x04002935 RID: 10549
			private static readonly IntPtr NativeMethodInfoPtr__SendInputEvents_b__37_0_Internal_EventBase_DefaultEventSystem_0;

			// Token: 0x04002936 RID: 10550
			private static readonly IntPtr NativeMethodInfoPtr__SendInputEvents_b__37_1_Internal_EventBase_DefaultEventSystem_0;

			// Token: 0x04002937 RID: 10551
			private static readonly IntPtr NativeMethodInfoPtr__SendInputEvents_b__37_2_Internal_EventBase_DefaultEventSystem_0;

			// Token: 0x04002938 RID: 10552
			private static readonly IntPtr NativeMethodInfoPtr__ProcessTouchEvents_b__45_0_Internal_EventBase_Vector3_Vector3_Touch_0;

			// Token: 0x04002939 RID: 10553
			private static readonly IntPtr NativeMethodInfoPtr__ProcessPenEvents_b__46_0_Internal_EventBase_Vector3_Vector3_PenData_0;

			// Token: 0x0400293A RID: 10554
			private static readonly IntPtr NativeMethodInfoPtr__ProcessTabEvent_b__53_0_Internal_EventBase_ValueTuple_3_Direction_EventModifiers_IInput_0;

			// Token: 0x0400293B RID: 10555
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__58_0_Internal_Boolean_0;
		}

		// Token: 0x020003DD RID: 989
		private sealed class MethodInfoStoreGeneric_SendFocusBasedEvent_Internal_Void_Func_2_TArg_EventBase_TArg_0<TArg>
		{
			// Token: 0x0400293C RID: 10556
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DefaultEventSystem.NativeMethodInfoPtr_SendFocusBasedEvent_Internal_Void_Func_2_TArg_EventBase_TArg_0, Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg>.NativeClassPtr)) }))));
		}

		// Token: 0x020003DE RID: 990
		private sealed class MethodInfoStoreGeneric_SendPositionBasedEvent_Private_Void_Vector3_Vector3_Int32_Nullable_1_Int32_Func_4_Vector3_Vector3_TArg_EventBase_TArg_Boolean_0<TArg>
		{
			// Token: 0x0400293D RID: 10557
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DefaultEventSystem.NativeMethodInfoPtr_SendPositionBasedEvent_Private_Void_Vector3_Vector3_Int32_Nullable_1_Int32_Func_4_Vector3_Vector3_TArg_EventBase_TArg_Boolean_0, Il2CppClassPointerStore<DefaultEventSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg>.NativeClassPtr)) }))));
		}

		// Token: 0x020003DF RID: 991
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
