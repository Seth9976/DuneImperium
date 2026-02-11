using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x02000020 RID: 32
	public class IAllocationStrategy : Il2CppObjectBase
	{
		// Token: 0x060001C3 RID: 451 RVA: 0x0000BE6C File Offset: 0x0000A06C
		// Note: this type is marked as 'beforefieldinit'.
		static IAllocationStrategy()
		{
			Il2CppClassPointerStore<IAllocationStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "IAllocationStrategy");
			IAllocationStrategy.NativeMethodInfoPtr_New_Public_Abstract_Virtual_New_Object_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAllocationStrategy>.NativeClassPtr, 100663618);
			IAllocationStrategy.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAllocationStrategy>.NativeClassPtr, 100663619);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000BEBC File Offset: 0x0000A0BC
		[CallerCount(0)]
		public unsafe virtual Object New(Type type, int typeHash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeHash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAllocationStrategy.NativeMethodInfoPtr_New_Public_Abstract_Virtual_New_Object_Type_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000BF28 File Offset: 0x0000A128
		[CallerCount(0)]
		public unsafe virtual void Release(int typeHash, Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeHash;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAllocationStrategy.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002B43 File Offset: 0x00000D43
		public IAllocationStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Abstract_Virtual_New_Object_Type_Int32_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_Int32_Object_0;
	}
}
