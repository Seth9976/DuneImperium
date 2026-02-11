using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading.Tasks;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	// Token: 0x0200004E RID: 78
	public class IAsyncOperation : Il2CppObjectBase
	{
		// Token: 0x060003EF RID: 1007 RVA: 0x00014088 File Offset: 0x00012288
		// Note: this type is marked as 'beforefieldinit'.
		static IAsyncOperation()
		{
			Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.AsyncOperations", "IAsyncOperation");
			IAsyncOperation.NativeMethodInfoPtr_GetResultAsObject_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663955);
			IAsyncOperation.NativeMethodInfoPtr_get_ResultType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663956);
			IAsyncOperation.NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663957);
			IAsyncOperation.NativeMethodInfoPtr_get_DebugName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663958);
			IAsyncOperation.NativeMethodInfoPtr_DecrementReferenceCount_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663959);
			IAsyncOperation.NativeMethodInfoPtr_IncrementReferenceCount_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663960);
			IAsyncOperation.NativeMethodInfoPtr_get_ReferenceCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663961);
			IAsyncOperation.NativeMethodInfoPtr_get_PercentComplete_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663962);
			IAsyncOperation.NativeMethodInfoPtr_GetDownloadStatus_Public_Abstract_Virtual_New_DownloadStatus_HashSet_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663963);
			IAsyncOperation.NativeMethodInfoPtr_get_Status_Public_Abstract_Virtual_New_get_AsyncOperationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663964);
			IAsyncOperation.NativeMethodInfoPtr_get_OperationException_Public_Abstract_Virtual_New_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663965);
			IAsyncOperation.NativeMethodInfoPtr_get_IsDone_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663966);
			IAsyncOperation.NativeMethodInfoPtr_set_OnDestroy_Public_Abstract_Virtual_New_set_Void_Action_1_IAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663967);
			IAsyncOperation.NativeMethodInfoPtr_GetDependencies_Public_Abstract_Virtual_New_Void_List_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663968);
			IAsyncOperation.NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663969);
			IAsyncOperation.NativeMethodInfoPtr_add_CompletedTypeless_Public_Abstract_Virtual_New_add_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663970);
			IAsyncOperation.NativeMethodInfoPtr_remove_CompletedTypeless_Public_Abstract_Virtual_New_rem_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663971);
			IAsyncOperation.NativeMethodInfoPtr_add_Destroyed_Public_Abstract_Virtual_New_add_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663972);
			IAsyncOperation.NativeMethodInfoPtr_remove_Destroyed_Public_Abstract_Virtual_New_rem_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663973);
			IAsyncOperation.NativeMethodInfoPtr_InvokeCompletionEvent_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663974);
			IAsyncOperation.NativeMethodInfoPtr_get_Task_Public_Abstract_Virtual_New_get_Task_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663975);
			IAsyncOperation.NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_Void_ResourceManager_AsyncOperationHandle_DelegateList_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663976);
			IAsyncOperation.NativeMethodInfoPtr_get_Handle_Public_Abstract_Virtual_New_get_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663977);
			IAsyncOperation.NativeMethodInfoPtr_WaitForCompletion_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncOperation>.NativeClassPtr, 100663978);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00014290 File Offset: 0x00012490
		[CallerCount(0)]
		public unsafe virtual Object GetResultAsObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_GetResultAsObject_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x000142DC File Offset: 0x000124DC
		public unsafe virtual Type ResultType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_get_ResultType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00014328 File Offset: 0x00012528
		public unsafe virtual int Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00014370 File Offset: 0x00012570
		public unsafe virtual string DebugName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_get_DebugName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000143B4 File Offset: 0x000125B4
		[CallerCount(0)]
		public unsafe virtual void DecrementReferenceCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_DecrementReferenceCount_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000143F0 File Offset: 0x000125F0
		[CallerCount(0)]
		public unsafe virtual void IncrementReferenceCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_IncrementReferenceCount_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0001442C File Offset: 0x0001262C
		public unsafe virtual int ReferenceCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_get_ReferenceCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00014474 File Offset: 0x00012674
		public unsafe virtual float PercentComplete
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_get_PercentComplete_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000144BC File Offset: 0x000126BC
		[CallerCount(0)]
		public unsafe virtual DownloadStatus GetDownloadStatus(HashSet<Object> visited)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visited);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_GetDownloadStatus_Public_Abstract_Virtual_New_DownloadStatus_HashSet_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00014514 File Offset: 0x00012714
		public unsafe virtual AsyncOperationStatus Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_get_Status_Public_Abstract_Virtual_New_get_AsyncOperationStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0001455C File Offset: 0x0001275C
		public unsafe virtual Exception OperationException
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_get_OperationException_Public_Abstract_Virtual_New_get_Exception_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x000145A8 File Offset: 0x000127A8
		public unsafe virtual bool IsDone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_get_IsDone_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012E RID: 302
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x000145F0 File Offset: 0x000127F0
		public unsafe virtual Action<IAsyncOperation> OnDestroy
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_set_OnDestroy_Public_Abstract_Virtual_New_set_Void_Action_1_IAsyncOperation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00014640 File Offset: 0x00012840
		[CallerCount(0)]
		public unsafe virtual void GetDependencies(List<AsyncOperationHandle> deps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deps);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_GetDependencies_Public_Abstract_Virtual_New_Void_List_1_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00014690 File Offset: 0x00012890
		public unsafe virtual bool IsRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000146D8 File Offset: 0x000128D8
		[CallerCount(0)]
		public unsafe virtual void add_CompletedTypeless(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_add_CompletedTypeless_Public_Abstract_Virtual_New_add_Void_Action_1_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00014728 File Offset: 0x00012928
		[CallerCount(0)]
		public unsafe virtual void remove_CompletedTypeless(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_remove_CompletedTypeless_Public_Abstract_Virtual_New_rem_Void_Action_1_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00014778 File Offset: 0x00012978
		[CallerCount(0)]
		public unsafe virtual void add_Destroyed(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_add_Destroyed_Public_Abstract_Virtual_New_add_Void_Action_1_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000147C8 File Offset: 0x000129C8
		[CallerCount(0)]
		public unsafe virtual void remove_Destroyed(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_remove_Destroyed_Public_Abstract_Virtual_New_rem_Void_Action_1_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00014818 File Offset: 0x00012A18
		[CallerCount(0)]
		public unsafe virtual void InvokeCompletionEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_InvokeCompletionEvent_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00014854 File Offset: 0x00012A54
		public unsafe virtual Task<Object> Task
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_get_Task_Public_Abstract_Virtual_New_get_Task_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000148A0 File Offset: 0x00012AA0
		[CallerCount(0)]
		public unsafe virtual void Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dependency));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(updateCallbacks);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_Void_ResourceManager_AsyncOperationHandle_DelegateList_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00014918 File Offset: 0x00012B18
		public unsafe virtual AsyncOperationHandle Handle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_get_Handle_Public_Abstract_Virtual_New_get_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle(intPtr);
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0001495C File Offset: 0x00012B5C
		[CallerCount(0)]
		public unsafe virtual void WaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncOperation.NativeMethodInfoPtr_WaitForCompletion_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00003915 File Offset: 0x00001B15
		public IAsyncOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_GetResultAsObject_Public_Abstract_Virtual_New_Object_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_get_ResultType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_DecrementReferenceCount_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_IncrementReferenceCount_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferenceCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentComplete_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadStatus_Public_Abstract_Virtual_New_DownloadStatus_HashSet_1_Object_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_Abstract_Virtual_New_get_AsyncOperationStatus_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_get_OperationException_Public_Abstract_Virtual_New_get_Exception_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDone_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_set_OnDestroy_Public_Abstract_Virtual_New_set_Void_Action_1_IAsyncOperation_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_GetDependencies_Public_Abstract_Virtual_New_Void_List_1_AsyncOperationHandle_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_add_CompletedTypeless_Public_Abstract_Virtual_New_add_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_remove_CompletedTypeless_Public_Abstract_Virtual_New_rem_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_add_Destroyed_Public_Abstract_Virtual_New_add_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_remove_Destroyed_Public_Abstract_Virtual_New_rem_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCompletionEvent_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_get_Task_Public_Abstract_Virtual_New_get_Task_1_Object_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_Void_ResourceManager_AsyncOperationHandle_DelegateList_1_Single_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_Abstract_Virtual_New_get_AsyncOperationHandle_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Public_Abstract_Virtual_New_Void_0;
	}
}
