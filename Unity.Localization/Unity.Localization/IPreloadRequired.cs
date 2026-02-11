using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization
{
	// Token: 0x02000017 RID: 23
	public class IPreloadRequired : Il2CppObjectBase
	{
		// Token: 0x06000146 RID: 326 RVA: 0x00002879 File Offset: 0x00000A79
		// Note: this type is marked as 'beforefieldinit'.
		static IPreloadRequired()
		{
			Il2CppClassPointerStore<IPreloadRequired>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "IPreloadRequired");
			IPreloadRequired.NativeMethodInfoPtr_get_PreloadOperation_Public_Abstract_Virtual_New_get_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPreloadRequired>.NativeClassPtr, 100663555);
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000E018 File Offset: 0x0000C218
		public unsafe virtual AsyncOperationHandle PreloadOperation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPreloadRequired.NativeMethodInfoPtr_get_PreloadOperation_Public_Abstract_Virtual_New_get_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle(intPtr);
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000028A8 File Offset: 0x00000AA8
		public IPreloadRequired(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_get_PreloadOperation_Public_Abstract_Virtual_New_get_AsyncOperationHandle_0;
	}
}
