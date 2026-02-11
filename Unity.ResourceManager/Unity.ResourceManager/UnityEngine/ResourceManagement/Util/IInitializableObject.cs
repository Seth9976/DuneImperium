using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x0200001E RID: 30
	public class IInitializableObject : Il2CppObjectBase
	{
		// Token: 0x060001BB RID: 443 RVA: 0x0000BC60 File Offset: 0x00009E60
		// Note: this type is marked as 'beforefieldinit'.
		static IInitializableObject()
		{
			Il2CppClassPointerStore<IInitializableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "IInitializableObject");
			IInitializableObject.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInitializableObject>.NativeClassPtr, 100663614);
			IInitializableObject.NativeMethodInfoPtr_InitializeAsync_Public_Abstract_Virtual_New_AsyncOperationHandle_1_Boolean_ResourceManager_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInitializableObject>.NativeClassPtr, 100663615);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000BCB0 File Offset: 0x00009EB0
		[CallerCount(0)]
		public unsafe virtual bool Initialize(string id, string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInitializableObject.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Boolean_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000BD1C File Offset: 0x00009F1C
		[CallerCount(0)]
		public unsafe virtual AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInitializableObject.NativeMethodInfoPtr_InitializeAsync_Public_Abstract_Virtual_New_AsyncOperationHandle_1_Boolean_ResourceManager_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<bool>(intPtr);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002B31 File Offset: 0x00000D31
		public IInitializableObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Boolean_String_String_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAsync_Public_Abstract_Virtual_New_AsyncOperationHandle_1_Boolean_ResourceManager_String_String_0;
	}
}
