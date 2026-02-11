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

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	// Token: 0x02000055 RID: 85
	public class IGenericProviderOperation : Il2CppObjectBase
	{
		// Token: 0x060004F4 RID: 1268 RVA: 0x00018C60 File Offset: 0x00016E60
		// Note: this type is marked as 'beforefieldinit'.
		static IGenericProviderOperation()
		{
			Il2CppClassPointerStore<IGenericProviderOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.AsyncOperations", "IGenericProviderOperation");
			IGenericProviderOperation.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_ResourceManager_IResourceProvider_IResourceLocation_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericProviderOperation>.NativeClassPtr, 100664150);
			IGenericProviderOperation.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_ResourceManager_IResourceProvider_IResourceLocation_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericProviderOperation>.NativeClassPtr, 100664151);
			IGenericProviderOperation.NativeMethodInfoPtr_get_ProvideHandleVersion_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericProviderOperation>.NativeClassPtr, 100664152);
			IGenericProviderOperation.NativeMethodInfoPtr_get_Location_Public_Abstract_Virtual_New_get_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericProviderOperation>.NativeClassPtr, 100664153);
			IGenericProviderOperation.NativeMethodInfoPtr_get_DependencyCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericProviderOperation>.NativeClassPtr, 100664154);
			IGenericProviderOperation.NativeMethodInfoPtr_GetDependencies_Public_Abstract_Virtual_New_Void_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericProviderOperation>.NativeClassPtr, 100664155);
			IGenericProviderOperation.NativeMethodInfoPtr_GetDependency_Public_Abstract_Virtual_New_TDepObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericProviderOperation>.NativeClassPtr, 100664156);
			IGenericProviderOperation.NativeMethodInfoPtr_SetProgressCallback_Public_Abstract_Virtual_New_Void_Func_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericProviderOperation>.NativeClassPtr, 100664157);
			IGenericProviderOperation.NativeMethodInfoPtr_ProviderCompleted_Public_Abstract_Virtual_New_Void_T_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericProviderOperation>.NativeClassPtr, 100664158);
			IGenericProviderOperation.NativeMethodInfoPtr_get_RequestedType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericProviderOperation>.NativeClassPtr, 100664159);
			IGenericProviderOperation.NativeMethodInfoPtr_SetDownloadProgressCallback_Public_Abstract_Virtual_New_Void_Func_1_DownloadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericProviderOperation>.NativeClassPtr, 100664160);
			IGenericProviderOperation.NativeMethodInfoPtr_SetWaitForCompletionCallback_Public_Abstract_Virtual_New_Void_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericProviderOperation>.NativeClassPtr, 100664161);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00018D78 File Offset: 0x00016F78
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericProviderOperation.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_ResourceManager_IResourceProvider_IResourceLocation_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00018E04 File Offset: 0x00017004
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericProviderOperation.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_ResourceManager_IResourceProvider_IResourceLocation_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00018E9C File Offset: 0x0001709C
		public unsafe virtual int ProvideHandleVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericProviderOperation.NativeMethodInfoPtr_get_ProvideHandleVersion_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00018EE4 File Offset: 0x000170E4
		public unsafe virtual IResourceLocation Location
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericProviderOperation.NativeMethodInfoPtr_get_Location_Public_Abstract_Virtual_New_get_IResourceLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr3) : null;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00018F30 File Offset: 0x00017130
		public unsafe virtual int DependencyCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericProviderOperation.NativeMethodInfoPtr_get_DependencyCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00018F78 File Offset: 0x00017178
		[CallerCount(0)]
		public unsafe virtual void GetDependencies(IList<Object> dstList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dstList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericProviderOperation.NativeMethodInfoPtr_GetDependencies_Public_Abstract_Virtual_New_Void_IList_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00018FC8 File Offset: 0x000171C8
		[CallerCount(0)]
		public unsafe virtual TDepObject GetDependency<TDepObject>(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericProviderOperation.MethodInfoStoreGeneric_GetDependency_Public_Abstract_Virtual_New_TDepObject_Int32_0<TDepObject>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TDepObject>(intPtr, false, true);
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001901C File Offset: 0x0001721C
		[CallerCount(0)]
		public unsafe virtual void SetProgressCallback(Func<float> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericProviderOperation.NativeMethodInfoPtr_SetProgressCallback_Public_Abstract_Virtual_New_Void_Func_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0001906C File Offset: 0x0001726C
		[CallerCount(0)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericProviderOperation.MethodInfoStoreGeneric_ProviderCompleted_Public_Abstract_Virtual_New_Void_T_Boolean_Exception_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00019110 File Offset: 0x00017310
		public unsafe virtual Type RequestedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericProviderOperation.NativeMethodInfoPtr_get_RequestedType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001915C File Offset: 0x0001735C
		[CallerCount(0)]
		public unsafe virtual void SetDownloadProgressCallback(Func<DownloadStatus> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericProviderOperation.NativeMethodInfoPtr_SetDownloadProgressCallback_Public_Abstract_Virtual_New_Void_Func_1_DownloadStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x000191AC File Offset: 0x000173AC
		[CallerCount(0)]
		public unsafe virtual void SetWaitForCompletionCallback(Func<bool> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericProviderOperation.NativeMethodInfoPtr_SetWaitForCompletionCallback_Public_Abstract_Virtual_New_Void_Func_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00003CE1 File Offset: 0x00001EE1
		public IGenericProviderOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_ResourceManager_IResourceProvider_IResourceLocation_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_ResourceManager_IResourceProvider_IResourceLocation_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_Boolean_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_get_ProvideHandleVersion_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr_get_Location_Public_Abstract_Virtual_New_get_IResourceLocation_0;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_get_DependencyCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_GetDependencies_Public_Abstract_Virtual_New_Void_IList_1_Object_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_GetDependency_Public_Abstract_Virtual_New_TDepObject_Int32_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_SetProgressCallback_Public_Abstract_Virtual_New_Void_Func_1_Single_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_ProviderCompleted_Public_Abstract_Virtual_New_Void_T_Boolean_Exception_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestedType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_SetDownloadProgressCallback_Public_Abstract_Virtual_New_Void_Func_1_DownloadStatus_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_SetWaitForCompletionCallback_Public_Abstract_Virtual_New_Void_Func_1_Boolean_0;

		// Token: 0x02000093 RID: 147
		private sealed class MethodInfoStoreGeneric_GetDependency_Public_Abstract_Virtual_New_TDepObject_Int32_0<TDepObject>
		{
			// Token: 0x040004F5 RID: 1269
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IGenericProviderOperation.NativeMethodInfoPtr_GetDependency_Public_Abstract_Virtual_New_TDepObject_Int32_0, Il2CppClassPointerStore<IGenericProviderOperation>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDepObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000094 RID: 148
		private sealed class MethodInfoStoreGeneric_ProviderCompleted_Public_Abstract_Virtual_New_Void_T_Boolean_Exception_0<T>
		{
			// Token: 0x040004F6 RID: 1270
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IGenericProviderOperation.NativeMethodInfoPtr_ProviderCompleted_Public_Abstract_Virtual_New_Void_T_Boolean_Exception_0, Il2CppClassPointerStore<IGenericProviderOperation>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
