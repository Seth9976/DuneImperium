using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x0200003E RID: 62
	public class ISceneProvider2 : Il2CppObjectBase
	{
		// Token: 0x06000333 RID: 819 RVA: 0x00003478 File Offset: 0x00001678
		// Note: this type is marked as 'beforefieldinit'.
		static ISceneProvider2()
		{
			Il2CppClassPointerStore<ISceneProvider2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "ISceneProvider2");
			ISceneProvider2.NativeMethodInfoPtr_ReleaseScene_Public_Abstract_Virtual_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISceneProvider2>.NativeClassPtr, 100663818);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00011424 File Offset: 0x0000F624
		[CallerCount(0)]
		public unsafe virtual AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceManager);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sceneLoadHandle));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unloadOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISceneProvider2.NativeMethodInfoPtr_ReleaseScene_Public_Abstract_Virtual_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000034A7 File Offset: 0x000016A7
		public ISceneProvider2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseScene_Public_Abstract_Virtual_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_0;
	}
}
