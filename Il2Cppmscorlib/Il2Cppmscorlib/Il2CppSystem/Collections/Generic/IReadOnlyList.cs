using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004EB RID: 1259
	public class IReadOnlyList<T> : Il2CppObjectBase
	{
		// Token: 0x06004DAD RID: 19885 RVA: 0x00168798 File Offset: 0x00166998
		// Note: this type is marked as 'beforefieldinit'.
		static IReadOnlyList()
		{
			Il2CppClassPointerStore<IReadOnlyList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "IReadOnlyList`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IReadOnlyList<T>.NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReadOnlyList<T>>.NativeClassPtr, 100674967);
		}

		// Token: 0x17001407 RID: 5127
		public unsafe virtual T this[int index]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReadOnlyList<T>.NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_T_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
		}

		// Token: 0x06004DAF RID: 19887 RVA: 0x0001C1B2 File Offset: 0x0001A3B2
		public IReadOnlyList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003F85 RID: 16261
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_T_Int32_0;
	}
}
