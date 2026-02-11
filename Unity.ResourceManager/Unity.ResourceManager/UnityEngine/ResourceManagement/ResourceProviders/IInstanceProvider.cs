using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x02000037 RID: 55
	public class IInstanceProvider : Il2CppObjectBase
	{
		// Token: 0x060002F8 RID: 760 RVA: 0x000103CC File Offset: 0x0000E5CC
		// Note: this type is marked as 'beforefieldinit'.
		static IInstanceProvider()
		{
			Il2CppClassPointerStore<IInstanceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "IInstanceProvider");
			IInstanceProvider.NativeMethodInfoPtr_ProvideInstance_Public_Abstract_Virtual_New_GameObject_ResourceManager_AsyncOperationHandle_1_GameObject_InstantiationParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInstanceProvider>.NativeClassPtr, 100663785);
			IInstanceProvider.NativeMethodInfoPtr_ReleaseInstance_Public_Abstract_Virtual_New_Void_ResourceManager_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInstanceProvider>.NativeClassPtr, 100663786);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0001041C File Offset: 0x0000E61C
		[CallerCount(0)]
		public unsafe virtual GameObject ProvideInstance(ResourceManager resourceManager, AsyncOperationHandle<GameObject> prefabHandle, InstantiationParameters instantiateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceManager);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(prefabHandle));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(instantiateParameters));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInstanceProvider.NativeMethodInfoPtr_ProvideInstance_Public_Abstract_Virtual_New_GameObject_ResourceManager_AsyncOperationHandle_1_GameObject_InstantiationParameters_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x000104A8 File Offset: 0x0000E6A8
		[CallerCount(0)]
		public unsafe virtual void ReleaseInstance(ResourceManager resourceManager, GameObject instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceManager);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInstanceProvider.NativeMethodInfoPtr_ReleaseInstance_Public_Abstract_Virtual_New_Void_ResourceManager_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000336C File Offset: 0x0000156C
		public IInstanceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_ProvideInstance_Public_Abstract_Virtual_New_GameObject_ResourceManager_AsyncOperationHandle_1_GameObject_InstantiationParameters_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseInstance_Public_Abstract_Virtual_New_Void_ResourceManager_GameObject_0;
	}
}
