using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200006A RID: 106
	public class BaseInputModule : UIBehaviour
	{
		// Token: 0x06000A9B RID: 2715 RVA: 0x000304DC File Offset: 0x0002E6DC
		// Note: this type is marked as 'beforefieldinit'.
		static BaseInputModule()
		{
			Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "BaseInputModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr);
			BaseInputModule.NativeFieldInfoPtr_m_RaycastResultCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, "m_RaycastResultCache");
			BaseInputModule.NativeFieldInfoPtr_m_SendPointerHoverToParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, "m_SendPointerHoverToParent");
			BaseInputModule.NativeFieldInfoPtr_m_AxisEventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, "m_AxisEventData");
			BaseInputModule.NativeFieldInfoPtr_m_EventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, "m_EventSystem");
			BaseInputModule.NativeFieldInfoPtr_m_BaseEventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, "m_BaseEventData");
			BaseInputModule.NativeFieldInfoPtr_m_InputOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, "m_InputOverride");
			BaseInputModule.NativeFieldInfoPtr_m_DefaultInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, "m_DefaultInput");
			BaseInputModule.NativeMethodInfoPtr_get_sendPointerHoverToParent_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665042);
			BaseInputModule.NativeMethodInfoPtr_set_sendPointerHoverToParent_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665043);
			BaseInputModule.NativeMethodInfoPtr_get_input_Public_get_BaseInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665044);
			BaseInputModule.NativeMethodInfoPtr_get_inputOverride_Public_get_BaseInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665045);
			BaseInputModule.NativeMethodInfoPtr_set_inputOverride_Public_set_Void_BaseInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665046);
			BaseInputModule.NativeMethodInfoPtr_get_eventSystem_Protected_get_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665047);
			BaseInputModule.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665048);
			BaseInputModule.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665049);
			BaseInputModule.NativeMethodInfoPtr_Process_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665050);
			BaseInputModule.NativeMethodInfoPtr_FindFirstRaycast_Protected_Static_RaycastResult_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665051);
			BaseInputModule.NativeMethodInfoPtr_DetermineMoveDirection_Protected_Static_MoveDirection_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665052);
			BaseInputModule.NativeMethodInfoPtr_DetermineMoveDirection_Protected_Static_MoveDirection_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665053);
			BaseInputModule.NativeMethodInfoPtr_FindCommonRoot_Protected_Static_GameObject_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665054);
			BaseInputModule.NativeMethodInfoPtr_HandlePointerExitAndEnter_Protected_Void_PointerEventData_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665055);
			BaseInputModule.NativeMethodInfoPtr_GetAxisEventData_Protected_Virtual_New_AxisEventData_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665056);
			BaseInputModule.NativeMethodInfoPtr_GetBaseEventData_Protected_Virtual_New_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665057);
			BaseInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665058);
			BaseInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665059);
			BaseInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665060);
			BaseInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665061);
			BaseInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665062);
			BaseInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665063);
			BaseInputModule.NativeMethodInfoPtr_ConvertUIToolkitPointerId_Public_Virtual_New_Int32_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665064);
			BaseInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100665065);
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x00030778 File Offset: 0x0002E978
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x000307B4 File Offset: 0x0002E9B4
		public unsafe bool sendPointerHoverToParent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_get_sendPointerHoverToParent_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_set_sendPointerHoverToParent_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x000307F4 File Offset: 0x0002E9F4
		public unsafe BaseInput input
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 1096278, RefRangeEnd = 1096320, XrefRangeStart = 1096247, XrefRangeEnd = 1096278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_get_input_Public_get_BaseInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInput>(intPtr3) : null;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00030834 File Offset: 0x0002EA34
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x00030874 File Offset: 0x0002EA74
		public unsafe BaseInput inputOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_get_inputOverride_Public_get_BaseInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInput>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_set_inputOverride_Public_set_Void_BaseInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x000308B8 File Offset: 0x0002EAB8
		public unsafe EventSystem eventSystem
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_get_eventSystem_Protected_get_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr3) : null;
			}
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x000308F8 File Offset: 0x0002EAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096320, XrefRangeEnd = 1096326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00030934 File Offset: 0x0002EB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096326, XrefRangeEnd = 1096328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00030970 File Offset: 0x0002EB70
		[CallerCount(0)]
		public unsafe virtual void Process()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_Process_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x000309AC File Offset: 0x0002EBAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1096336, RefRangeEnd = 1096338, XrefRangeStart = 1096328, XrefRangeEnd = 1096336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastResult FindFirstRaycast(List<RaycastResult> candidates)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(candidates);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_FindFirstRaycast_Protected_Static_RaycastResult_List_1_RaycastResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RaycastResult(intPtr);
			}
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x000309E8 File Offset: 0x0002EBE8
		[CallerCount(0)]
		public unsafe static MoveDirection DetermineMoveDirection(float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_DetermineMoveDirection_Protected_Static_MoveDirection_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00030A34 File Offset: 0x0002EC34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1096338, RefRangeEnd = 1096339, XrefRangeStart = 1096338, XrefRangeEnd = 1096338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MoveDirection DetermineMoveDirection(float x, float y, float deadZone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deadZone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_DetermineMoveDirection_Protected_Static_MoveDirection_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00030A90 File Offset: 0x0002EC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096339, XrefRangeEnd = 1096362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(g1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(g2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_FindCommonRoot_Protected_Static_GameObject_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00030AE8 File Offset: 0x0002ECE8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1096419, RefRangeEnd = 1096431, XrefRangeStart = 1096362, XrefRangeEnd = 1096419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentPointerData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newEnterTarget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_HandlePointerExitAndEnter_Protected_Void_PointerEventData_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00030B3C File Offset: 0x0002ED3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096431, XrefRangeEnd = 1096440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveDeadZone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_GetAxisEventData_Protected_Virtual_New_AxisEventData_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisEventData>(intPtr3) : null;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00030BB0 File Offset: 0x0002EDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096440, XrefRangeEnd = 1096446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual BaseEventData GetBaseEventData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_GetBaseEventData_Protected_Virtual_New_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseEventData>(intPtr3) : null;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00030BFC File Offset: 0x0002EDFC
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsPointerOverGameObject(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00030C50 File Offset: 0x0002EE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096446, XrefRangeEnd = 1096447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldActivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00030C98 File Offset: 0x0002EE98
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeactivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00030CD4 File Offset: 0x0002EED4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ActivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00030D10 File Offset: 0x0002EF10
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00030D4C File Offset: 0x0002EF4C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsModuleSupported()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00030D94 File Offset: 0x0002EF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096447, XrefRangeEnd = 1096451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourcePointerData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_ConvertUIToolkitPointerId_Public_Virtual_New_Int32_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00030DEC File Offset: 0x0002EFEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1096459, RefRangeEnd = 1096460, XrefRangeStart = 1096451, XrefRangeEnd = 1096459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseInputModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00005C36 File Offset: 0x00003E36
		public BaseInputModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x00030E28 File Offset: 0x0002F028
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x00005C3F File Offset: 0x00003E3F
		public unsafe List<RaycastResult> m_RaycastResultCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_RaycastResultCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RaycastResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_RaycastResultCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00030E58 File Offset: 0x0002F058
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x00005C5E File Offset: 0x00003E5E
		public unsafe bool m_SendPointerHoverToParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_SendPointerHoverToParent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_SendPointerHoverToParent)) = value;
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00030E80 File Offset: 0x0002F080
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00005C79 File Offset: 0x00003E79
		public unsafe AxisEventData m_AxisEventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_AxisEventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AxisEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_AxisEventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00030EB0 File Offset: 0x0002F0B0
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x00005C98 File Offset: 0x00003E98
		public unsafe EventSystem m_EventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_EventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_EventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x00030EE0 File Offset: 0x0002F0E0
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00005CB7 File Offset: 0x00003EB7
		public unsafe BaseEventData m_BaseEventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_BaseEventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_BaseEventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00030F10 File Offset: 0x0002F110
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x00005CD6 File Offset: 0x00003ED6
		public unsafe BaseInput m_InputOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_InputOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_InputOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x00030F40 File Offset: 0x0002F140
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x00005CF5 File Offset: 0x00003EF5
		public unsafe BaseInput m_DefaultInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_DefaultInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_DefaultInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeFieldInfoPtr_m_RaycastResultCache;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeFieldInfoPtr_m_SendPointerHoverToParent;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeFieldInfoPtr_m_AxisEventData;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeFieldInfoPtr_m_EventSystem;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseEventData;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeFieldInfoPtr_m_InputOverride;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultInput;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_get_sendPointerHoverToParent_Internal_get_Boolean_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr_set_sendPointerHoverToParent_Internal_set_Void_Boolean_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_get_input_Public_get_BaseInput_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_get_inputOverride_Public_get_BaseInput_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_set_inputOverride_Public_set_Void_BaseInput_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_get_eventSystem_Protected_get_EventSystem_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstRaycast_Protected_Static_RaycastResult_List_1_RaycastResult_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_DetermineMoveDirection_Protected_Static_MoveDirection_Single_Single_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_DetermineMoveDirection_Protected_Static_MoveDirection_Single_Single_Single_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_FindCommonRoot_Protected_Static_GameObject_GameObject_GameObject_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_HandlePointerExitAndEnter_Protected_Void_PointerEventData_GameObject_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisEventData_Protected_Virtual_New_AxisEventData_Single_Single_Single_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseEventData_Protected_Virtual_New_BaseEventData_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_New_Boolean_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateModule_Public_Virtual_New_Void_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_UpdateModule_Public_Virtual_New_Void_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_New_Boolean_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_ConvertUIToolkitPointerId_Public_Virtual_New_Int32_PointerEventData_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
