using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Properties
{
	// Token: 0x02000021 RID: 33
	public class IConstructorWithCount<T> : Il2CppObjectBase
	{
		// Token: 0x06000122 RID: 290 RVA: 0x000068A4 File Offset: 0x00004AA4
		// Note: this type is marked as 'beforefieldinit'.
		static IConstructorWithCount()
		{
			Il2CppClassPointerStore<IConstructorWithCount<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "IConstructorWithCount`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IConstructorWithCount<T>.NativeMethodInfoPtr_InstantiateWithCount_Public_Abstract_Virtual_New_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructorWithCount<T>>.NativeClassPtr, 100663400);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000691C File Offset: 0x00004B1C
		[CallerCount(0)]
		public unsafe virtual T InstantiateWithCount(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructorWithCount<T>.NativeMethodInfoPtr_InstantiateWithCount_Public_Abstract_Virtual_New_T_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002881 File Offset: 0x00000A81
		public IConstructorWithCount(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateWithCount_Public_Abstract_Virtual_New_T_Int32_0;
	}
}
