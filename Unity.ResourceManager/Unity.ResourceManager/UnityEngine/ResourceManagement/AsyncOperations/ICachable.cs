using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	// Token: 0x0200004D RID: 77
	public class ICachable : Il2CppObjectBase
	{
		// Token: 0x060003EB RID: 1003 RVA: 0x00013F9C File Offset: 0x0001219C
		// Note: this type is marked as 'beforefieldinit'.
		static ICachable()
		{
			Il2CppClassPointerStore<ICachable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.AsyncOperations", "ICachable");
			ICachable.NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_IOperationCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICachable>.NativeClassPtr, 100663953);
			ICachable.NativeMethodInfoPtr_set_Key_Public_Abstract_Virtual_New_set_Void_IOperationCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICachable>.NativeClassPtr, 100663954);
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00013FEC File Offset: 0x000121EC
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x00014038 File Offset: 0x00012238
		public unsafe virtual IOperationCacheKey Key
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICachable.NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_IOperationCacheKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOperationCacheKey>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICachable.NativeMethodInfoPtr_set_Key_Public_Abstract_Virtual_New_set_Void_IOperationCacheKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000390C File Offset: 0x00001B0C
		public ICachable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_IOperationCacheKey_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_Abstract_Virtual_New_set_Void_IOperationCacheKey_0;
	}
}
