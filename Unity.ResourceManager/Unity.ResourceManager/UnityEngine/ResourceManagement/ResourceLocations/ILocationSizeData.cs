using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.ResourceManagement.ResourceLocations
{
	// Token: 0x02000046 RID: 70
	public class ILocationSizeData : Il2CppObjectBase
	{
		// Token: 0x0600036E RID: 878 RVA: 0x000035B3 File Offset: 0x000017B3
		// Note: this type is marked as 'beforefieldinit'.
		static ILocationSizeData()
		{
			Il2CppClassPointerStore<ILocationSizeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceLocations", "ILocationSizeData");
			ILocationSizeData.NativeMethodInfoPtr_ComputeSize_Public_Abstract_Virtual_New_Int64_IResourceLocation_ResourceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocationSizeData>.NativeClassPtr, 100663890);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000123C8 File Offset: 0x000105C8
		[CallerCount(0)]
		public unsafe virtual long ComputeSize(IResourceLocation location, ResourceManager resourceManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resourceManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocationSizeData.NativeMethodInfoPtr_ComputeSize_Public_Abstract_Virtual_New_Int64_IResourceLocation_ResourceManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000035E2 File Offset: 0x000017E2
		public ILocationSizeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_ComputeSize_Public_Abstract_Virtual_New_Int64_IResourceLocation_ResourceManager_0;
	}
}
