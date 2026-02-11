using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Newtonsoft.Json
{
	// Token: 0x02000014 RID: 20
	public class IArrayPool<T> : Il2CppObjectBase
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00012798 File Offset: 0x00010998
		// Note: this type is marked as 'beforefieldinit'.
		static IArrayPool()
		{
			Il2CppClassPointerStore<IArrayPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "IArrayPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IArrayPool<T>.NativeMethodInfoPtr_Rent_Public_Abstract_Virtual_New_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArrayPool<T>>.NativeClassPtr, 100663317);
			IArrayPool<T>.NativeMethodInfoPtr_Return_Public_Abstract_Virtual_New_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArrayPool<T>>.NativeClassPtr, 100663318);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00012824 File Offset: 0x00010A24
		[CallerCount(0)]
		public unsafe virtual Il2CppArrayBase<T> Rent(int minimumLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minimumLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IArrayPool<T>.NativeMethodInfoPtr_Rent_Public_Abstract_Virtual_New_Il2CppArrayBase_1_T_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00012874 File Offset: 0x00010A74
		[CallerCount(0)]
		public unsafe virtual void Return(Il2CppArrayBase<T> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IArrayPool<T>.NativeMethodInfoPtr_Return_Public_Abstract_Virtual_New_Void_Il2CppArrayBase_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000229A File Offset: 0x0000049A
		public IArrayPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_Rent_Public_Abstract_Virtual_New_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_Return_Public_Abstract_Virtual_New_Void_Il2CppArrayBase_1_T_0;
	}
}
