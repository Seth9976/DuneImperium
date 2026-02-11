using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	// Token: 0x02000056 RID: 86
	public class ProviderOperation<TObject> : AsyncOperationBase<TObject>
	{
		// Token: 0x06000502 RID: 1282 RVA: 0x000191FC File Offset: 0x000173FC
		// Note: this type is marked as 'beforefieldinit'.
		static ProviderOperation()
		{
			Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.AsyncOperations", "ProviderOperation`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr);
			ProviderOperation<TObject>.NativeFieldInfoPtr_m_ReleaseDependenciesOnFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, "m_ReleaseDependenciesOnFailure");
			ProviderOperation<TObject>.NativeFieldInfoPtr_m_GetProgressCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, "m_GetProgressCallback");
			ProviderOperation<TObject>.NativeFieldInfoPtr_m_GetDownloadProgressCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, "m_GetDownloadProgressCallback");
			ProviderOperation<TObject>.NativeFieldInfoPtr_m_WaitForCompletionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, "m_WaitForCompletionCallback");
			ProviderOperation<TObject>.NativeFieldInfoPtr_m_ProviderCompletedCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, "m_ProviderCompletedCalled");
			ProviderOperation<TObject>.NativeFieldInfoPtr_m_DownloadStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, "m_DownloadStatus");
			ProviderOperation<TObject>.NativeFieldInfoPtr_m_Provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, "m_Provider");
			ProviderOperation<TObject>.NativeFieldInfoPtr_m_DepOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, "m_DepOp");
			ProviderOperation<TObject>.NativeFieldInfoPtr_m_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, "m_Location");
			ProviderOperation<TObject>.NativeFieldInfoPtr_m_ProvideHandleVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, "m_ProvideHandleVersion");
			ProviderOperation<TObject>.NativeFieldInfoPtr_m_NeedsRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, "m_NeedsRelease");
			ProviderOperation<TObject>.NativeFieldInfoPtr__UnityEngine_ResourceManagement_AsyncOperations_ICachable_Key_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, "<UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key>k__BackingField");
			ProviderOperation<TObject>.NativeFieldInfoPtr_m_ResourceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, "m_ResourceManager");
			ProviderOperation<TObject>.NativeFieldInfoPtr_k_OperationWaitingToCompletePercentComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, "k_OperationWaitingToCompletePercentComplete");
			ProviderOperation<TObject>.NativeFieldInfoPtr_kInvalidHandleMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, "kInvalidHandleMsg");
			ProviderOperation<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_ICachable_get_Key_Private_Virtual_Final_New_get_IOperationCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664162);
			ProviderOperation<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_ICachable_set_Key_Private_Virtual_Final_New_set_Void_IOperationCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664163);
			ProviderOperation<TObject>.NativeMethodInfoPtr_get_ProvideHandleVersion_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664164);
			ProviderOperation<TObject>.NativeMethodInfoPtr_get_Location_Public_Virtual_Final_New_get_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664165);
			ProviderOperation<TObject>.NativeMethodInfoPtr_SetDownloadProgressCallback_Public_Virtual_Final_New_Void_Func_1_DownloadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664166);
			ProviderOperation<TObject>.NativeMethodInfoPtr_SetWaitForCompletionCallback_Public_Virtual_Final_New_Void_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664167);
			ProviderOperation<TObject>.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664168);
			ProviderOperation<TObject>.NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_DownloadStatus_HashSet_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664169);
			ProviderOperation<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664170);
			ProviderOperation<TObject>.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664171);
			ProviderOperation<TObject>.NativeMethodInfoPtr_ReleaseDependencies_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664172);
			ProviderOperation<TObject>.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664173);
			ProviderOperation<TObject>.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Final_New_Void_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664174);
			ProviderOperation<TObject>.NativeMethodInfoPtr_get_RequestedType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664175);
			ProviderOperation<TObject>.NativeMethodInfoPtr_get_DependencyCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664176);
			ProviderOperation<TObject>.NativeMethodInfoPtr_GetDependency_Public_Virtual_Final_New_TDepObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664177);
			ProviderOperation<TObject>.NativeMethodInfoPtr_SetProgressCallback_Public_Virtual_Final_New_Void_Func_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664178);
			ProviderOperation<TObject>.NativeMethodInfoPtr_ProviderCompleted_Public_Virtual_Final_New_Void_T_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664179);
			ProviderOperation<TObject>.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664180);
			ProviderOperation<TObject>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664181);
			ProviderOperation<TObject>.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_ResourceManager_IResourceProvider_IResourceLocation_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664182);
			ProviderOperation<TObject>.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_ResourceManager_IResourceProvider_IResourceLocation_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664183);
			ProviderOperation<TObject>.NativeMethodInfoPtr_WaitForCompletionHandler_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664184);
			ProviderOperation<TObject>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr, 100664185);
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x00019574 File Offset: 0x00017774
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x000195B4 File Offset: 0x000177B4
		public unsafe virtual IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderOperation<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_ICachable_get_Key_Private_Virtual_Final_New_get_IOperationCacheKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOperationCacheKey>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderOperation<TObject>.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_ICachable_set_Key_Private_Virtual_Final_New_set_Void_IOperationCacheKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x000195F8 File Offset: 0x000177F8
		public unsafe virtual int ProvideHandleVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderOperation<TObject>.NativeMethodInfoPtr_get_ProvideHandleVersion_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00019634 File Offset: 0x00017834
		public unsafe virtual IResourceLocation Location
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderOperation<TObject>.NativeMethodInfoPtr_get_Location_Public_Virtual_Final_New_get_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr3) : null;
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00019674 File Offset: 0x00017874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143474, XrefRangeEnd = 1143475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetDownloadProgressCallback(Func<DownloadStatus> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderOperation<TObject>.NativeMethodInfoPtr_SetDownloadProgressCallback_Public_Virtual_Final_New_Void_Func_1_DownloadStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x000196B8 File Offset: 0x000178B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetWaitForCompletionCallback(Func<bool> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderOperation<TObject>.NativeMethodInfoPtr_SetWaitForCompletionCallback_Public_Virtual_Final_New_Void_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000196FC File Offset: 0x000178FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143475, XrefRangeEnd = 1143488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InvokeWaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProviderOperation<TObject>.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00019744 File Offset: 0x00017944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143488, XrefRangeEnd = 1143496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DownloadStatus GetDownloadStatus(HashSet<Object> visited)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visited);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProviderOperation<TObject>.NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_DownloadStatus_HashSet_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0001979C File Offset: 0x0001799C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143496, XrefRangeEnd = 1143513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProviderOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProviderOperation<TObject>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderOperation<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x000197D8 File Offset: 0x000179D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143513, XrefRangeEnd = 1143522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetDependencies(List<AsyncOperationHandle> deps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deps);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProviderOperation<TObject>.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00019828 File Offset: 0x00017A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143522, XrefRangeEnd = 1143528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReleaseDependencies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProviderOperation<TObject>.NativeMethodInfoPtr_ReleaseDependencies_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00019864 File Offset: 0x00017A64
		public unsafe override string DebugName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143528, XrefRangeEnd = 1143543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProviderOperation<TObject>.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x000198A8 File Offset: 0x00017AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143543, XrefRangeEnd = 1143571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetDependencies(IList<Object> dstList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dstList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderOperation<TObject>.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Final_New_Void_IList_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x000198EC File Offset: 0x00017AEC
		public unsafe virtual Type RequestedType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143571, XrefRangeEnd = 1143579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderOperation<TObject>.NativeMethodInfoPtr_get_RequestedType_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x0001992C File Offset: 0x00017B2C
		public unsafe virtual int DependencyCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143579, XrefRangeEnd = 1143590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderOperation<TObject>.NativeMethodInfoPtr_get_DependencyCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00019968 File Offset: 0x00017B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143590, XrefRangeEnd = 1143604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TDepObject GetDependency<TDepObject>(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderOperation<TDepObject>.MethodInfoStoreGeneric_GetDependency_Public_Virtual_Final_New_TDepObject_Int32_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TDepObject>(intPtr, false, true);
			}
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x000199B0 File Offset: 0x00017BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetProgressCallback(Func<float> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderOperation<TObject>.NativeMethodInfoPtr_SetProgressCallback_Public_Virtual_Final_New_Void_Func_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x000199F4 File Offset: 0x00017BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1143624, RefRangeEnd = 1143625, XrefRangeStart = 1143604, XrefRangeEnd = 1143624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProviderCompleted<T>(T result, bool status, Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = result;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref result;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ProviderOperation<T>.MethodInfoStoreGeneric_ProviderCompleted_Public_Virtual_Final_New_Void_T_Boolean_Exception_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00019A8C File Offset: 0x00017C8C
		public unsafe override float Progress
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143625, XrefRangeEnd = 1143657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProviderOperation<TObject>.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00019AD4 File Offset: 0x00017CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143657, XrefRangeEnd = 1143676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProviderOperation<TObject>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00019B10 File Offset: 0x00017D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143676, XrefRangeEnd = 1143741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(depOp));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderOperation<TObject>.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_ResourceManager_IResourceProvider_IResourceLocation_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00019B90 File Offset: 0x00017D90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1143756, RefRangeEnd = 1143757, XrefRangeStart = 1143741, XrefRangeEnd = 1143756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool releaseDependenciesOnFailure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(depOp));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseDependenciesOnFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderOperation<TObject>.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_ResourceManager_IResourceProvider_IResourceLocation_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00019C1C File Offset: 0x00017E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143757, XrefRangeEnd = 1143766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WaitForCompletionHandler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderOperation<TObject>.NativeMethodInfoPtr_WaitForCompletionHandler_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00019C58 File Offset: 0x00017E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143766, XrefRangeEnd = 1143778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProviderOperation<TObject>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00003CEA File Offset: 0x00001EEA
		public ProviderOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00019C94 File Offset: 0x00017E94
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x00003CF3 File Offset: 0x00001EF3
		public unsafe bool m_ReleaseDependenciesOnFailure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_ReleaseDependenciesOnFailure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_ReleaseDependenciesOnFailure)) = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x00019CBC File Offset: 0x00017EBC
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x00003D0E File Offset: 0x00001F0E
		public unsafe Func<float> m_GetProgressCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_GetProgressCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_GetProgressCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00019CEC File Offset: 0x00017EEC
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00003D2D File Offset: 0x00001F2D
		public unsafe Func<DownloadStatus> m_GetDownloadProgressCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_GetDownloadProgressCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DownloadStatus>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_GetDownloadProgressCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00019D1C File Offset: 0x00017F1C
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00003D4C File Offset: 0x00001F4C
		public unsafe Func<bool> m_WaitForCompletionCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_WaitForCompletionCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_WaitForCompletionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00019D4C File Offset: 0x00017F4C
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00003D6B File Offset: 0x00001F6B
		public unsafe bool m_ProviderCompletedCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_ProviderCompletedCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_ProviderCompletedCalled)) = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00019D74 File Offset: 0x00017F74
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00003D86 File Offset: 0x00001F86
		public unsafe DownloadStatus m_DownloadStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_DownloadStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_DownloadStatus)) = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00019D9C File Offset: 0x00017F9C
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00003DA1 File Offset: 0x00001FA1
		public unsafe IResourceProvider m_Provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_Provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_Provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00019DCC File Offset: 0x00017FCC
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00003DC0 File Offset: 0x00001FC0
		public AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_DepOp);
				return new AsyncOperationHandle<IList<AsyncOperationHandle>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_DepOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00019DFC File Offset: 0x00017FFC
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x00003DEE File Offset: 0x00001FEE
		public unsafe IResourceLocation m_Location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_Location);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_Location), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00019E2C File Offset: 0x0001802C
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00003E0D File Offset: 0x0000200D
		public unsafe int m_ProvideHandleVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_ProvideHandleVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_ProvideHandleVersion)) = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00019E54 File Offset: 0x00018054
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x00003E28 File Offset: 0x00002028
		public unsafe bool m_NeedsRelease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_NeedsRelease);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_NeedsRelease)) = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00019E7C File Offset: 0x0001807C
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x00003E43 File Offset: 0x00002043
		public unsafe IOperationCacheKey _UnityEngine_ResourceManagement_AsyncOperations_ICachable_Key_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr__UnityEngine_ResourceManagement_AsyncOperations_ICachable_Key_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOperationCacheKey>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr__UnityEngine_ResourceManagement_AsyncOperations_ICachable_Key_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00019EAC File Offset: 0x000180AC
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x00003E62 File Offset: 0x00002062
		public unsafe ResourceManager m_ResourceManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_ResourceManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderOperation<TObject>.NativeFieldInfoPtr_m_ResourceManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00019EDC File Offset: 0x000180DC
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x00003E81 File Offset: 0x00002081
		public unsafe static float k_OperationWaitingToCompletePercentComplete
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ProviderOperation<TObject>.NativeFieldInfoPtr_k_OperationWaitingToCompletePercentComplete, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProviderOperation<TObject>.NativeFieldInfoPtr_k_OperationWaitingToCompletePercentComplete, (void*)(&value));
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00019EF8 File Offset: 0x000180F8
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x00003E8F File Offset: 0x0000208F
		public unsafe static string kInvalidHandleMsg
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProviderOperation<TObject>.NativeFieldInfoPtr_kInvalidHandleMsg, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProviderOperation<TObject>.NativeFieldInfoPtr_kInvalidHandleMsg, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeFieldInfoPtr_m_ReleaseDependenciesOnFailure;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeFieldInfoPtr_m_GetProgressCallback;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeFieldInfoPtr_m_GetDownloadProgressCallback;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitForCompletionCallback;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeFieldInfoPtr_m_ProviderCompletedCalled;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeFieldInfoPtr_m_DownloadStatus;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeFieldInfoPtr_m_Provider;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeFieldInfoPtr_m_DepOp;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeFieldInfoPtr_m_Location;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeFieldInfoPtr_m_ProvideHandleVersion;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeFieldInfoPtr_m_NeedsRelease;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_ResourceManagement_AsyncOperations_ICachable_Key_k__BackingField;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeFieldInfoPtr_m_ResourceManager;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeFieldInfoPtr_k_OperationWaitingToCompletePercentComplete;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeFieldInfoPtr_kInvalidHandleMsg;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_ICachable_get_Key_Private_Virtual_Final_New_get_IOperationCacheKey_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_ICachable_set_Key_Private_Virtual_Final_New_set_Void_IOperationCacheKey_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_get_ProvideHandleVersion_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_get_Location_Public_Virtual_Final_New_get_IResourceLocation_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_SetDownloadProgressCallback_Public_Virtual_Final_New_Void_Func_1_DownloadStatus_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_SetWaitForCompletionCallback_Public_Virtual_Final_New_Void_Func_1_Boolean_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_DownloadStatus_HashSet_1_Object_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseDependencies_Internal_Virtual_Void_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_GetDependencies_Public_Virtual_Final_New_Void_IList_1_Object_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestedType_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_get_DependencyCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_GetDependency_Public_Virtual_Final_New_TDepObject_Int32_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_SetProgressCallback_Public_Virtual_Final_New_Void_Func_1_Single_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_ProviderCompleted_Public_Virtual_Final_New_Void_T_Boolean_Exception_0;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_ResourceManager_IResourceProvider_IResourceLocation_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_ResourceManager_IResourceProvider_IResourceLocation_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_Boolean_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletionHandler_Private_Boolean_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

		// Token: 0x02000095 RID: 149
		private sealed class MethodInfoStoreGeneric_GetDependency_Public_Virtual_Final_New_TDepObject_Int32_0
		{
			// Token: 0x040004F7 RID: 1271
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ProviderOperation<TDepObject>.NativeMethodInfoPtr_GetDependency_Public_Virtual_Final_New_TDepObject_Int32_0, Il2CppClassPointerStore<ProviderOperation<TDepObject>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDepObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000096 RID: 150
		private sealed class MethodInfoStoreGeneric_ProviderCompleted_Public_Virtual_Final_New_Void_T_Boolean_Exception_0
		{
			// Token: 0x040004F8 RID: 1272
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ProviderOperation<T>.NativeMethodInfoPtr_ProviderCompleted_Public_Virtual_Final_New_Void_T_Boolean_Exception_0, Il2CppClassPointerStore<ProviderOperation<T>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
