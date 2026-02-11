using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace InControl
{
	// Token: 0x02000040 RID: 64
	public class InControlInputModule : PointerInputModule
	{
		// Token: 0x06000561 RID: 1377 RVA: 0x0001B644 File Offset: 0x00019844
		// Note: this type is marked as 'beforefieldinit'.
		static InControlInputModule()
		{
			Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "InControlInputModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr);
			InControlInputModule.NativeFieldInfoPtr_submitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "submitButton");
			InControlInputModule.NativeFieldInfoPtr_cancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "cancelButton");
			InControlInputModule.NativeFieldInfoPtr_analogMoveThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "analogMoveThreshold");
			InControlInputModule.NativeFieldInfoPtr_moveRepeatFirstDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "moveRepeatFirstDuration");
			InControlInputModule.NativeFieldInfoPtr_moveRepeatDelayDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "moveRepeatDelayDuration");
			InControlInputModule.NativeFieldInfoPtr_forceModuleActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "forceModuleActive");
			InControlInputModule.NativeFieldInfoPtr_allowMouseInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "allowMouseInput");
			InControlInputModule.NativeFieldInfoPtr_focusOnMouseHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "focusOnMouseHover");
			InControlInputModule.NativeFieldInfoPtr_allowTouchInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "allowTouchInput");
			InControlInputModule.NativeFieldInfoPtr_inputDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "inputDevice");
			InControlInputModule.NativeFieldInfoPtr_thisMousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "thisMousePosition");
			InControlInputModule.NativeFieldInfoPtr_lastMousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "lastMousePosition");
			InControlInputModule.NativeFieldInfoPtr_thisVectorState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "thisVectorState");
			InControlInputModule.NativeFieldInfoPtr_lastVectorState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "lastVectorState");
			InControlInputModule.NativeFieldInfoPtr_thisSubmitState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "thisSubmitState");
			InControlInputModule.NativeFieldInfoPtr_lastSubmitState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "lastSubmitState");
			InControlInputModule.NativeFieldInfoPtr_thisCancelState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "thisCancelState");
			InControlInputModule.NativeFieldInfoPtr_lastCancelState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "lastCancelState");
			InControlInputModule.NativeFieldInfoPtr_moveWasRepeated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "moveWasRepeated");
			InControlInputModule.NativeFieldInfoPtr_nextMoveRepeatTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "nextMoveRepeatTime");
			InControlInputModule.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "direction");
			InControlInputModule.NativeFieldInfoPtr__SubmitAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "<SubmitAction>k__BackingField");
			InControlInputModule.NativeFieldInfoPtr__CancelAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "<CancelAction>k__BackingField");
			InControlInputModule.NativeFieldInfoPtr__MoveAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, "<MoveAction>k__BackingField");
			InControlInputModule.NativeMethodInfoPtr_get_SubmitAction_Public_get_PlayerAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664024);
			InControlInputModule.NativeMethodInfoPtr_set_SubmitAction_Public_set_Void_PlayerAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664025);
			InControlInputModule.NativeMethodInfoPtr_get_CancelAction_Public_get_PlayerAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664026);
			InControlInputModule.NativeMethodInfoPtr_set_CancelAction_Public_set_Void_PlayerAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664027);
			InControlInputModule.NativeMethodInfoPtr_get_MoveAction_Public_get_PlayerTwoAxisAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664028);
			InControlInputModule.NativeMethodInfoPtr_set_MoveAction_Public_set_Void_PlayerTwoAxisAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664029);
			InControlInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664030);
			InControlInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664031);
			InControlInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664032);
			InControlInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664033);
			InControlInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664034);
			InControlInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664035);
			InControlInputModule.NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664036);
			InControlInputModule.NativeMethodInfoPtr_SendButtonEventToSelectedObject_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664037);
			InControlInputModule.NativeMethodInfoPtr_SendVectorEventToSelectedObject_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664038);
			InControlInputModule.NativeMethodInfoPtr_ProcessMove_Protected_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664039);
			InControlInputModule.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664040);
			InControlInputModule.NativeMethodInfoPtr_UpdateInputState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664041);
			InControlInputModule.NativeMethodInfoPtr_set_Device_Public_set_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664042);
			InControlInputModule.NativeMethodInfoPtr_get_Device_Public_get_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664043);
			InControlInputModule.NativeMethodInfoPtr_get_SubmitButton_Private_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664044);
			InControlInputModule.NativeMethodInfoPtr_get_CancelButton_Private_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664045);
			InControlInputModule.NativeMethodInfoPtr_SetVectorRepeatTimer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664046);
			InControlInputModule.NativeMethodInfoPtr_get_VectorIsPressed_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664047);
			InControlInputModule.NativeMethodInfoPtr_get_VectorIsReleased_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664048);
			InControlInputModule.NativeMethodInfoPtr_get_VectorHasChanged_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664049);
			InControlInputModule.NativeMethodInfoPtr_get_VectorWasPressed_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664050);
			InControlInputModule.NativeMethodInfoPtr_get_SubmitWasPressed_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664051);
			InControlInputModule.NativeMethodInfoPtr_get_SubmitWasReleased_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664052);
			InControlInputModule.NativeMethodInfoPtr_get_CancelWasPressed_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664053);
			InControlInputModule.NativeMethodInfoPtr_get_MouseHasMoved_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664054);
			InControlInputModule.NativeMethodInfoPtr_get_MouseButtonWasPressed_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664055);
			InControlInputModule.NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664056);
			InControlInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664057);
			InControlInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664058);
			InControlInputModule.NativeMethodInfoPtr_ProcessMousePress_Protected_Void_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664059);
			InControlInputModule.NativeMethodInfoPtr_ProcessTouchPress_Protected_Void_PointerEventData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr, 100664060);
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x0001BB38 File Offset: 0x00019D38
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x0001BB78 File Offset: 0x00019D78
		public unsafe PlayerAction SubmitAction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_get_SubmitAction_Public_get_PlayerAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_set_SubmitAction_Public_set_Void_PlayerAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x0001BBBC File Offset: 0x00019DBC
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x0001BBFC File Offset: 0x00019DFC
		public unsafe PlayerAction CancelAction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_get_CancelAction_Public_get_PlayerAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_set_CancelAction_Public_set_Void_PlayerAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x0001BC40 File Offset: 0x00019E40
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x0001BC80 File Offset: 0x00019E80
		public unsafe PlayerTwoAxisAction MoveAction
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 39587, RefRangeEnd = 39588, XrefRangeStart = 39587, XrefRangeEnd = 39588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_get_MoveAction_Public_get_PlayerTwoAxisAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerTwoAxisAction>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_set_MoveAction_Public_set_Void_PlayerTwoAxisAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0001BCC4 File Offset: 0x00019EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781358, XrefRangeEnd = 781368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InControlInputModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InControlInputModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0001BD00 File Offset: 0x00019F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781368, XrefRangeEnd = 781378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InControlInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0001BD3C File Offset: 0x00019F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781378, XrefRangeEnd = 781389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsModuleSupported()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InControlInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0001BD84 File Offset: 0x00019F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781389, XrefRangeEnd = 781407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldActivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InControlInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0001BDCC File Offset: 0x00019FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781407, XrefRangeEnd = 781424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InControlInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0001BE08 File Offset: 0x0001A008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781424, XrefRangeEnd = 781443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Process()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InControlInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0001BE44 File Offset: 0x0001A044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 781552, RefRangeEnd = 781553, XrefRangeStart = 781443, XrefRangeEnd = 781552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessTouchEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0001BE80 File Offset: 0x0001A080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 781576, RefRangeEnd = 781577, XrefRangeStart = 781553, XrefRangeEnd = 781576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendButtonEventToSelectedObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_SendButtonEventToSelectedObject_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0001BEBC File Offset: 0x0001A0BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 781595, RefRangeEnd = 781596, XrefRangeStart = 781577, XrefRangeEnd = 781595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendVectorEventToSelectedObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_SendVectorEventToSelectedObject_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0001BEF8 File Offset: 0x0001A0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781596, XrefRangeEnd = 781608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessMove(PointerEventData pointerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InControlInputModule.NativeMethodInfoPtr_ProcessMove_Protected_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0001BF48 File Offset: 0x0001A148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781608, XrefRangeEnd = 781621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0001BF7C File Offset: 0x0001A17C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 781653, RefRangeEnd = 781654, XrefRangeStart = 781621, XrefRangeEnd = 781653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInputState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_UpdateInputState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0001BFF4 File Offset: 0x0001A1F4
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x0001BFB0 File Offset: 0x0001A1B0
		public unsafe InputDevice Device
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781654, XrefRangeEnd = 781658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_get_Device_Public_get_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_set_Device_Public_set_Void_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0001C034 File Offset: 0x0001A234
		public unsafe InputControl SubmitButton
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781658, XrefRangeEnd = 781665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_get_SubmitButton_Private_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0001C074 File Offset: 0x0001A274
		public unsafe InputControl CancelButton
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781665, XrefRangeEnd = 781672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_get_CancelButton_Private_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0001C0B4 File Offset: 0x0001A2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781672, XrefRangeEnd = 781673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorRepeatTimer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_SetVectorRepeatTimer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0001C0E8 File Offset: 0x0001A2E8
		public unsafe bool VectorIsPressed
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 781675, RefRangeEnd = 781676, XrefRangeStart = 781673, XrefRangeEnd = 781675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_get_VectorIsPressed_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0001C124 File Offset: 0x0001A324
		public unsafe bool VectorIsReleased
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781676, XrefRangeEnd = 781678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_get_VectorIsReleased_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0001C160 File Offset: 0x0001A360
		public unsafe bool VectorHasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_get_VectorHasChanged_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x0001C19C File Offset: 0x0001A39C
		public unsafe bool VectorWasPressed
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 781678, RefRangeEnd = 781680, XrefRangeStart = 781678, XrefRangeEnd = 781678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_get_VectorWasPressed_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x0001C1D8 File Offset: 0x0001A3D8
		public unsafe bool SubmitWasPressed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_get_SubmitWasPressed_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x0001C214 File Offset: 0x0001A414
		public unsafe bool SubmitWasReleased
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_get_SubmitWasReleased_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0001C250 File Offset: 0x0001A450
		public unsafe bool CancelWasPressed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_get_CancelWasPressed_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x0001C28C File Offset: 0x0001A48C
		public unsafe bool MouseHasMoved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_get_MouseHasMoved_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0001C2C8 File Offset: 0x0001A4C8
		public unsafe static bool MouseButtonWasPressed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781680, XrefRangeEnd = 781691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_get_MouseButtonWasPressed_Private_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0001C2F8 File Offset: 0x0001A4F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781691, XrefRangeEnd = 781705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendUpdateEventToSelectedObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0001C334 File Offset: 0x0001A534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781705, XrefRangeEnd = 781706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMouseEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0001C368 File Offset: 0x0001A568
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 781729, RefRangeEnd = 781731, XrefRangeStart = 781706, XrefRangeEnd = 781729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMouseEvent(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0001C3A8 File Offset: 0x0001A5A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 781829, RefRangeEnd = 781832, XrefRangeStart = 781731, XrefRangeEnd = 781829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMousePress(PointerInputModule.MouseButtonEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_ProcessMousePress_Protected_Void_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0001C3EC File Offset: 0x0001A5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781832, XrefRangeEnd = 781950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputModule.NativeMethodInfoPtr_ProcessTouchPress_Protected_Void_PointerEventData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00004118 File Offset: 0x00002318
		public InControlInputModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x0001C44C File Offset: 0x0001A64C
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x00004121 File Offset: 0x00002321
		public unsafe InControlInputModule.Button submitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_submitButton);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_submitButton)) = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x0001C474 File Offset: 0x0001A674
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x0000413C File Offset: 0x0000233C
		public unsafe InControlInputModule.Button cancelButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_cancelButton);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_cancelButton)) = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x0001C49C File Offset: 0x0001A69C
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x00004157 File Offset: 0x00002357
		public unsafe float analogMoveThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_analogMoveThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_analogMoveThreshold)) = value;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x0001C4C4 File Offset: 0x0001A6C4
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x00004172 File Offset: 0x00002372
		public unsafe float moveRepeatFirstDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_moveRepeatFirstDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_moveRepeatFirstDuration)) = value;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0001C4EC File Offset: 0x0001A6EC
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x0000418D File Offset: 0x0000238D
		public unsafe float moveRepeatDelayDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_moveRepeatDelayDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_moveRepeatDelayDuration)) = value;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0001C514 File Offset: 0x0001A714
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x000041A8 File Offset: 0x000023A8
		public unsafe bool forceModuleActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_forceModuleActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_forceModuleActive)) = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0001C53C File Offset: 0x0001A73C
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x000041C3 File Offset: 0x000023C3
		public unsafe bool allowMouseInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_allowMouseInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_allowMouseInput)) = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x0001C564 File Offset: 0x0001A764
		// (set) Token: 0x06000597 RID: 1431 RVA: 0x000041DE File Offset: 0x000023DE
		public unsafe bool focusOnMouseHover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_focusOnMouseHover);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_focusOnMouseHover)) = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x0001C58C File Offset: 0x0001A78C
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x000041F9 File Offset: 0x000023F9
		public unsafe bool allowTouchInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_allowTouchInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_allowTouchInput)) = value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0001C5B4 File Offset: 0x0001A7B4
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x00004214 File Offset: 0x00002414
		public unsafe InputDevice inputDevice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_inputDevice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_inputDevice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x0001C5E4 File Offset: 0x0001A7E4
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x00004233 File Offset: 0x00002433
		public unsafe Vector3 thisMousePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_thisMousePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_thisMousePosition)) = value;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x0001C60C File Offset: 0x0001A80C
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x0000424E File Offset: 0x0000244E
		public unsafe Vector3 lastMousePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_lastMousePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_lastMousePosition)) = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0001C634 File Offset: 0x0001A834
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x00004269 File Offset: 0x00002469
		public unsafe Vector2 thisVectorState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_thisVectorState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_thisVectorState)) = value;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0001C65C File Offset: 0x0001A85C
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x00004284 File Offset: 0x00002484
		public unsafe Vector2 lastVectorState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_lastVectorState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_lastVectorState)) = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x0001C684 File Offset: 0x0001A884
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x0000429F File Offset: 0x0000249F
		public unsafe bool thisSubmitState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_thisSubmitState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_thisSubmitState)) = value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0001C6AC File Offset: 0x0001A8AC
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x000042BA File Offset: 0x000024BA
		public unsafe bool lastSubmitState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_lastSubmitState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_lastSubmitState)) = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x0001C6D4 File Offset: 0x0001A8D4
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x000042D5 File Offset: 0x000024D5
		public unsafe bool thisCancelState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_thisCancelState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_thisCancelState)) = value;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x0001C6FC File Offset: 0x0001A8FC
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x000042F0 File Offset: 0x000024F0
		public unsafe bool lastCancelState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_lastCancelState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_lastCancelState)) = value;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x0001C724 File Offset: 0x0001A924
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x0000430B File Offset: 0x0000250B
		public unsafe bool moveWasRepeated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_moveWasRepeated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_moveWasRepeated)) = value;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x0001C74C File Offset: 0x0001A94C
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x00004326 File Offset: 0x00002526
		public unsafe float nextMoveRepeatTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_nextMoveRepeatTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_nextMoveRepeatTime)) = value;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0001C774 File Offset: 0x0001A974
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x00004341 File Offset: 0x00002541
		public unsafe TwoAxisInputControl direction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_direction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TwoAxisInputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr_direction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x0001C7A4 File Offset: 0x0001A9A4
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x00004360 File Offset: 0x00002560
		public unsafe PlayerAction _SubmitAction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr__SubmitAction_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr__SubmitAction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0001C7D4 File Offset: 0x0001A9D4
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x0000437F File Offset: 0x0000257F
		public unsafe PlayerAction _CancelAction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr__CancelAction_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr__CancelAction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x0001C804 File Offset: 0x0001AA04
		// (set) Token: 0x060005B7 RID: 1463 RVA: 0x0000439E File Offset: 0x0000259E
		public unsafe PlayerTwoAxisAction _MoveAction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr__MoveAction_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerTwoAxisAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputModule.NativeFieldInfoPtr__MoveAction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeFieldInfoPtr_submitButton;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeFieldInfoPtr_cancelButton;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeFieldInfoPtr_analogMoveThreshold;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeFieldInfoPtr_moveRepeatFirstDuration;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeFieldInfoPtr_moveRepeatDelayDuration;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeFieldInfoPtr_forceModuleActive;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeFieldInfoPtr_allowMouseInput;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeFieldInfoPtr_focusOnMouseHover;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeFieldInfoPtr_allowTouchInput;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeFieldInfoPtr_inputDevice;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeFieldInfoPtr_thisMousePosition;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeFieldInfoPtr_lastMousePosition;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeFieldInfoPtr_thisVectorState;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeFieldInfoPtr_lastVectorState;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeFieldInfoPtr_thisSubmitState;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeFieldInfoPtr_lastSubmitState;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeFieldInfoPtr_thisCancelState;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeFieldInfoPtr_lastCancelState;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeFieldInfoPtr_moveWasRepeated;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeFieldInfoPtr_nextMoveRepeatTime;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeFieldInfoPtr_direction;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeFieldInfoPtr__SubmitAction_k__BackingField;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeFieldInfoPtr__CancelAction_k__BackingField;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeFieldInfoPtr__MoveAction_k__BackingField;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_get_SubmitAction_Public_get_PlayerAction_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_set_SubmitAction_Public_set_Void_PlayerAction_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_get_CancelAction_Public_get_PlayerAction_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_set_CancelAction_Public_set_Void_PlayerAction_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveAction_Public_get_PlayerTwoAxisAction_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_set_MoveAction_Public_set_Void_PlayerTwoAxisAction_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_SendButtonEventToSelectedObject_Private_Boolean_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_SendVectorEventToSelectedObject_Private_Boolean_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMove_Protected_Virtual_Void_PointerEventData_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInputState_Private_Void_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_set_Device_Public_set_Void_InputDevice_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_get_Device_Public_get_InputDevice_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_get_SubmitButton_Private_get_InputControl_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_get_CancelButton_Private_get_InputControl_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorRepeatTimer_Private_Void_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_get_VectorIsPressed_Private_get_Boolean_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr_get_VectorIsReleased_Private_get_Boolean_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_get_VectorHasChanged_Private_get_Boolean_0;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr_get_VectorWasPressed_Private_get_Boolean_0;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr_get_SubmitWasPressed_Private_get_Boolean_0;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr_get_SubmitWasReleased_Private_get_Boolean_0;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_get_CancelWasPressed_Private_get_Boolean_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_get_MouseHasMoved_Private_get_Boolean_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_get_MouseButtonWasPressed_Private_Static_get_Boolean_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Protected_Boolean_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_Int32_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMousePress_Protected_Void_MouseButtonEventData_0;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTouchPress_Protected_Void_PointerEventData_Boolean_Boolean_0;

		// Token: 0x02000212 RID: 530
		public enum Button
		{
			// Token: 0x04000D90 RID: 3472
			Action1 = 19,
			// Token: 0x04000D91 RID: 3473
			Action2,
			// Token: 0x04000D92 RID: 3474
			Action3,
			// Token: 0x04000D93 RID: 3475
			Action4
		}
	}
}
