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
	// Token: 0x020000DF RID: 223
	public class CallbackEventHandler : Object
	{
		// Token: 0x06001314 RID: 4884 RVA: 0x0005FD2C File Offset: 0x0005DF2C
		// Note: this type is marked as 'beforefieldinit'.
		static CallbackEventHandler()
		{
			Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "CallbackEventHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr);
			CallbackEventHandler.NativeFieldInfoPtr_isIMGUIContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, "isIMGUIContainer");
			CallbackEventHandler.NativeFieldInfoPtr_m_CallbackRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, "m_CallbackRegistry");
			CallbackEventHandler.NativeFieldInfoPtr_ExecuteDefaultActionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, "ExecuteDefaultActionName");
			CallbackEventHandler.NativeFieldInfoPtr_ExecuteDefaultActionAtTargetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, "ExecuteDefaultActionAtTargetName");
			CallbackEventHandler.NativeMethodInfoPtr_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100665985);
			CallbackEventHandler.NativeMethodInfoPtr_AddEventCategories_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100665986);
			CallbackEventHandler.NativeMethodInfoPtr_RegisterCallback_Public_Void_EventCallback_2_TEventType_TUserArgsType_TUserArgsType_TrickleDown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100665987);
			CallbackEventHandler.NativeMethodInfoPtr_RegisterCallback_Internal_Void_EventCallback_1_TEventType_InvokePolicy_TrickleDown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100665988);
			CallbackEventHandler.NativeMethodInfoPtr_UnregisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100665989);
			CallbackEventHandler.NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100665990);
			CallbackEventHandler.NativeMethodInfoPtr_SendEvent_Internal_Abstract_Virtual_New_Void_EventBase_DispatchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100665991);
			CallbackEventHandler.NativeMethodInfoPtr_HandleEventAtTargetPhase_Internal_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100665992);
			CallbackEventHandler.NativeMethodInfoPtr_HandleEventAtTargetAndDefaultPhase_Internal_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100665993);
			CallbackEventHandler.NativeMethodInfoPtr_HandleEventAtCurrentTargetAndPhase_Internal_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100665994);
			CallbackEventHandler.NativeMethodInfoPtr_UnityEngine_UIElements_IEventHandler_HandleEvent_Private_Virtual_Final_New_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100665995);
			CallbackEventHandler.NativeMethodInfoPtr_HandleEvent_Public_Virtual_New_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100665996);
			CallbackEventHandler.NativeMethodInfoPtr_HasTrickleDownHandlers_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100665997);
			CallbackEventHandler.NativeMethodInfoPtr_HasBubbleUpHandlers_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100665998);
			CallbackEventHandler.NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Protected_Virtual_New_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100665999);
			CallbackEventHandler.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_New_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100666000);
			CallbackEventHandler.NativeMethodInfoPtr_ExecuteDefaultActionDisabledAtTarget_Internal_Virtual_New_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100666001);
			CallbackEventHandler.NativeMethodInfoPtr_ExecuteDefaultActionDisabled_Internal_Virtual_New_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100666002);
			CallbackEventHandler.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100666003);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0005FF28 File Offset: 0x0005E128
		[CallerCount(180)]
		[CachedScanResults(RefRangeStart = 313474, RefRangeEnd = 313654, XrefRangeStart = 313465, XrefRangeEnd = 313474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTrickleDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackEventHandler.MethodInfoStoreGeneric_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0<TEventType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0005FF78 File Offset: 0x0005E178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313654, XrefRangeEnd = 313662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddEventCategories<TEventType>() where TEventType : EventBase<TEventType>, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackEventHandler.MethodInfoStoreGeneric_AddEventCategories_Private_Void_0<TEventType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0005FFAC File Offset: 0x0005E1AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313671, RefRangeEnd = 313672, XrefRangeStart = 313662, XrefRangeEnd = 313671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCallback<TEventType, TUserArgsType>(EventCallback<TEventType, TUserArgsType> callback, TUserArgsType userArgs, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TUserArgsType).IsValueType)
			{
				TUserArgsType tuserArgsType = userArgs;
				intPtr = ((tuserArgsType is string) ? IL2CPP.ManagedStringToIl2Cpp(tuserArgsType as string) : IL2CPP.Il2CppObjectBaseToPtr(tuserArgsType as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref userArgs;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTrickleDown;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CallbackEventHandler.MethodInfoStoreGeneric_RegisterCallback_Public_Void_EventCallback_2_TEventType_TUserArgsType_TUserArgsType_TrickleDown_0<TEventType, TUserArgsType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00060044 File Offset: 0x0005E244
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 313681, RefRangeEnd = 313691, XrefRangeStart = 313672, XrefRangeEnd = 313681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCallback<TEventType>(EventCallback<TEventType> callback, InvokePolicy invokePolicy, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokePolicy;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTrickleDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackEventHandler.MethodInfoStoreGeneric_RegisterCallback_Internal_Void_EventCallback_1_TEventType_InvokePolicy_TrickleDown_0<TEventType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x000600A4 File Offset: 0x0005E2A4
		[CallerCount(113)]
		[CachedScanResults(RefRangeStart = 313693, RefRangeEnd = 313806, XrefRangeStart = 313691, XrefRangeEnd = 313693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTrickleDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackEventHandler.MethodInfoStoreGeneric_UnregisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0<TEventType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x000600F4 File Offset: 0x0005E2F4
		[CallerCount(0)]
		public unsafe virtual void SendEvent(EventBase e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallbackEventHandler.NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00060144 File Offset: 0x0005E344
		[CallerCount(0)]
		public unsafe virtual void SendEvent(EventBase e, DispatchMode dispatchMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dispatchMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallbackEventHandler.NativeMethodInfoPtr_SendEvent_Internal_Abstract_Virtual_New_Void_EventBase_DispatchMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x000601A0 File Offset: 0x0005E3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313806, XrefRangeEnd = 313807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleEventAtTargetPhase(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackEventHandler.NativeMethodInfoPtr_HandleEventAtTargetPhase_Internal_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x000601E4 File Offset: 0x0005E3E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 313808, RefRangeEnd = 313812, XrefRangeStart = 313807, XrefRangeEnd = 313808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleEventAtTargetAndDefaultPhase(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackEventHandler.NativeMethodInfoPtr_HandleEventAtTargetAndDefaultPhase_Internal_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x00060228 File Offset: 0x0005E428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283236, RefRangeEnd = 283237, XrefRangeStart = 283236, XrefRangeEnd = 283237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleEventAtCurrentTargetAndPhase(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackEventHandler.NativeMethodInfoPtr_HandleEventAtCurrentTargetAndPhase_Internal_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0006026C File Offset: 0x0005E46C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283236, RefRangeEnd = 283237, XrefRangeStart = 283236, XrefRangeEnd = 283237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_UIElements_IEventHandler_HandleEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackEventHandler.NativeMethodInfoPtr_UnityEngine_UIElements_IEventHandler_HandleEvent_Private_Virtual_Final_New_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x000602B0 File Offset: 0x0005E4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313812, XrefRangeEnd = 313833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallbackEventHandler.NativeMethodInfoPtr_HandleEvent_Public_Virtual_New_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00060300 File Offset: 0x0005E500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313833, RefRangeEnd = 313834, XrefRangeStart = 313833, XrefRangeEnd = 313833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasTrickleDownHandlers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackEventHandler.NativeMethodInfoPtr_HasTrickleDownHandlers_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0006033C File Offset: 0x0005E53C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313834, RefRangeEnd = 313835, XrefRangeStart = 313834, XrefRangeEnd = 313834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasBubbleUpHandlers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackEventHandler.NativeMethodInfoPtr_HasBubbleUpHandlers_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00060378 File Offset: 0x0005E578
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExecuteDefaultActionAtTarget(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallbackEventHandler.NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Protected_Virtual_New_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x000603C8 File Offset: 0x0005E5C8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExecuteDefaultAction(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallbackEventHandler.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_New_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x00060418 File Offset: 0x0005E618
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExecuteDefaultActionDisabledAtTarget(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallbackEventHandler.NativeMethodInfoPtr_ExecuteDefaultActionDisabledAtTarget_Internal_Virtual_New_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x00060468 File Offset: 0x0005E668
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExecuteDefaultActionDisabled(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallbackEventHandler.NativeMethodInfoPtr_ExecuteDefaultActionDisabled_Internal_Virtual_New_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x000604B8 File Offset: 0x0005E6B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313836, RefRangeEnd = 313837, XrefRangeStart = 313835, XrefRangeEnd = 313836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallbackEventHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackEventHandler.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x00009691 File Offset: 0x00007891
		public CallbackEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x000604F4 File Offset: 0x0005E6F4
		// (set) Token: 0x0600132A RID: 4906 RVA: 0x0000969A File Offset: 0x0000789A
		public unsafe bool isIMGUIContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackEventHandler.NativeFieldInfoPtr_isIMGUIContainer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackEventHandler.NativeFieldInfoPtr_isIMGUIContainer)) = value;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x0006051C File Offset: 0x0005E71C
		// (set) Token: 0x0600132C RID: 4908 RVA: 0x000096B5 File Offset: 0x000078B5
		public unsafe EventCallbackRegistry m_CallbackRegistry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackEventHandler.NativeFieldInfoPtr_m_CallbackRegistry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallbackRegistry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackEventHandler.NativeFieldInfoPtr_m_CallbackRegistry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x0006054C File Offset: 0x0005E74C
		// (set) Token: 0x0600132E RID: 4910 RVA: 0x000096D4 File Offset: 0x000078D4
		public unsafe static string ExecuteDefaultActionName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CallbackEventHandler.NativeFieldInfoPtr_ExecuteDefaultActionName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallbackEventHandler.NativeFieldInfoPtr_ExecuteDefaultActionName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x0006056C File Offset: 0x0005E76C
		// (set) Token: 0x06001330 RID: 4912 RVA: 0x000096E6 File Offset: 0x000078E6
		public unsafe static string ExecuteDefaultActionAtTargetName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CallbackEventHandler.NativeFieldInfoPtr_ExecuteDefaultActionAtTargetName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallbackEventHandler.NativeFieldInfoPtr_ExecuteDefaultActionAtTargetName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x0006058C File Offset: 0x0005E78C
		public void UnregisterCallback<TEventType, TUserArgsType>(EventCallback<TEventType, TUserArgsType> callback, [Optional] TrickleDown useTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
			bool flag = this.m_CallbackRegistry != null;
			if (flag)
			{
				this.m_CallbackRegistry.UnregisterCallback<TEventType, TUserArgsType>(callback, useTrickleDown);
			}
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x000605B8 File Offset: 0x0005E7B8
		public bool TryGetUserArgs<TEventType, TCallbackArgs>(EventCallback<TEventType, TCallbackArgs> callback, TrickleDown useTrickleDown, out TCallbackArgs userData) where TEventType : EventBase<TEventType>, new()
		{
			userData = default(TCallbackArgs);
			bool flag = this.m_CallbackRegistry != null;
			return flag && this.m_CallbackRegistry.TryGetUserArgs<TEventType, TCallbackArgs>(callback, useTrickleDown, out userData);
		}

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeFieldInfoPtr_isIMGUIContainer;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeFieldInfoPtr_m_CallbackRegistry;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeFieldInfoPtr_ExecuteDefaultActionName;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeFieldInfoPtr_ExecuteDefaultActionAtTargetName;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr_AddEventCategories_Private_Void_0;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallback_Public_Void_EventCallback_2_TEventType_TUserArgsType_TUserArgsType_TrickleDown_0;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallback_Internal_Void_EventCallback_1_TEventType_InvokePolicy_TrickleDown_0;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_EventBase_0;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Internal_Abstract_Virtual_New_Void_EventBase_DispatchMode_0;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr_HandleEventAtTargetPhase_Internal_Void_EventBase_0;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeMethodInfoPtr_HandleEventAtTargetAndDefaultPhase_Internal_Void_EventBase_0;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_HandleEventAtCurrentTargetAndPhase_Internal_Void_EventBase_0;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IEventHandler_HandleEvent_Private_Virtual_Final_New_Void_EventBase_0;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeMethodInfoPtr_HandleEvent_Public_Virtual_New_Void_EventBase_0;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeMethodInfoPtr_HasTrickleDownHandlers_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr_HasBubbleUpHandlers_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Protected_Virtual_New_Void_EventBase_0;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_New_Void_EventBase_0;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultActionDisabledAtTarget_Internal_Virtual_New_Void_EventBase_0;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultActionDisabled_Internal_Virtual_New_Void_EventBase_0;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000402 RID: 1026
		private sealed class MethodInfoStoreGeneric_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0<TEventType>
		{
			// Token: 0x0400298F RID: 10639
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallbackEventHandler.NativeMethodInfoPtr_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0, Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000403 RID: 1027
		private sealed class MethodInfoStoreGeneric_AddEventCategories_Private_Void_0<TEventType>
		{
			// Token: 0x04002990 RID: 10640
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallbackEventHandler.NativeMethodInfoPtr_AddEventCategories_Private_Void_0, Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000404 RID: 1028
		private sealed class MethodInfoStoreGeneric_RegisterCallback_Public_Void_EventCallback_2_TEventType_TUserArgsType_TUserArgsType_TrickleDown_0<TEventType, TUserArgsType>
		{
			// Token: 0x04002991 RID: 10641
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallbackEventHandler.NativeMethodInfoPtr_RegisterCallback_Public_Void_EventCallback_2_TEventType_TUserArgsType_TUserArgsType_TrickleDown_0, Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TUserArgsType>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000405 RID: 1029
		private sealed class MethodInfoStoreGeneric_RegisterCallback_Internal_Void_EventCallback_1_TEventType_InvokePolicy_TrickleDown_0<TEventType>
		{
			// Token: 0x04002992 RID: 10642
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallbackEventHandler.NativeMethodInfoPtr_RegisterCallback_Internal_Void_EventCallback_1_TEventType_InvokePolicy_TrickleDown_0, Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000406 RID: 1030
		private sealed class MethodInfoStoreGeneric_UnregisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0<TEventType>
		{
			// Token: 0x04002993 RID: 10643
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallbackEventHandler.NativeMethodInfoPtr_UnregisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0, Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)) }))));
		}
	}
}
