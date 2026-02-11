using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x0200003F RID: 63
	public static class SceneProviderExtensions : Object
	{
		// Token: 0x06000336 RID: 822 RVA: 0x000034B0 File Offset: 0x000016B0
		// Note: this type is marked as 'beforefieldinit'.
		static SceneProviderExtensions()
		{
			Il2CppClassPointerStore<SceneProviderExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "SceneProviderExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneProviderExtensions>.NativeClassPtr);
			SceneProviderExtensions.NativeMethodInfoPtr_ReleaseScene_Public_Static_AsyncOperationHandle_1_SceneInstance_ISceneProvider_ResourceManager_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProviderExtensions>.NativeClassPtr, 100663819);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0001149C File Offset: 0x0000F69C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1140697, RefRangeEnd = 1140701, XrefRangeStart = 1140683, XrefRangeEnd = 1140697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<SceneInstance> ReleaseScene(this ISceneProvider provider, ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resourceManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sceneLoadHandle));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unloadOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneProviderExtensions.NativeMethodInfoPtr_ReleaseScene_Public_Static_AsyncOperationHandle_1_SceneInstance_ISceneProvider_ResourceManager_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000034E9 File Offset: 0x000016E9
		public SceneProviderExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseScene_Public_Static_AsyncOperationHandle_1_SceneInstance_ISceneProvider_ResourceManager_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_0;
	}
}
