using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.SceneManagement;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x0200003D RID: 61
	public class ISceneProvider : Il2CppObjectBase
	{
		// Token: 0x0600032E RID: 814 RVA: 0x00011234 File Offset: 0x0000F434
		// Note: this type is marked as 'beforefieldinit'.
		static ISceneProvider()
		{
			Il2CppClassPointerStore<ISceneProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "ISceneProvider");
			ISceneProvider.NativeMethodInfoPtr_ProvideScene_Public_Abstract_Virtual_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_IResourceLocation_LoadSceneMode_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISceneProvider>.NativeClassPtr, 100663815);
			ISceneProvider.NativeMethodInfoPtr_ProvideScene_Public_Abstract_Virtual_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_IResourceLocation_LoadSceneParameters_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISceneProvider>.NativeClassPtr, 100663816);
			ISceneProvider.NativeMethodInfoPtr_ReleaseScene_Public_Abstract_Virtual_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_AsyncOperationHandle_1_SceneInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISceneProvider>.NativeClassPtr, 100663817);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00011298 File Offset: 0x0000F498
		[CallerCount(0)]
		public unsafe virtual AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneMode loadMode, bool activateOnLoad, int priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceManager);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISceneProvider.NativeMethodInfoPtr_ProvideScene_Public_Abstract_Virtual_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_IResourceLocation_LoadSceneMode_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00011328 File Offset: 0x0000F528
		[CallerCount(0)]
		public unsafe virtual AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceManager);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadSceneParameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISceneProvider.NativeMethodInfoPtr_ProvideScene_Public_Abstract_Virtual_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_IResourceLocation_LoadSceneParameters_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x000113B8 File Offset: 0x0000F5B8
		[CallerCount(0)]
		public unsafe virtual AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceManager);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sceneLoadHandle));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISceneProvider.NativeMethodInfoPtr_ReleaseScene_Public_Abstract_Virtual_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_AsyncOperationHandle_1_SceneInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000346F File Offset: 0x0000166F
		public ISceneProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_ProvideScene_Public_Abstract_Virtual_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_IResourceLocation_LoadSceneMode_Boolean_Int32_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_ProvideScene_Public_Abstract_Virtual_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_IResourceLocation_LoadSceneParameters_Boolean_Int32_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseScene_Public_Abstract_Virtual_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_AsyncOperationHandle_1_SceneInstance_0;
	}
}
