using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq
{
	// Token: 0x0200001B RID: 27
	public class IOrderedEnumerable<TElement> : Il2CppObjectBase
	{
		// Token: 0x06000116 RID: 278 RVA: 0x00014F20 File Offset: 0x00013120
		// Note: this type is marked as 'beforefieldinit'.
		static IOrderedEnumerable()
		{
			Il2CppClassPointerStore<IOrderedEnumerable<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "IOrderedEnumerable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IOrderedEnumerable<TElement>.NativeMethodInfoPtr_CreateOrderedEnumerable_Public_Abstract_Virtual_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOrderedEnumerable<TElement>>.NativeClassPtr, 100663725);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00014F98 File Offset: 0x00013198
		[CallerCount(0)]
		public unsafe virtual IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref descending;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOrderedEnumerable<TKey>.MethodInfoStoreGeneric_CreateOrderedEnumerable_Public_Abstract_Virtual_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<TElement>>(intPtr3) : null;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000022C4 File Offset: 0x000004C4
		public IOrderedEnumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_CreateOrderedEnumerable_Public_Abstract_Virtual_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0;

		// Token: 0x020001B5 RID: 437
		private sealed class MethodInfoStoreGeneric_CreateOrderedEnumerable_Public_Abstract_Virtual_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0
		{
			// Token: 0x04000F76 RID: 3958
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IOrderedEnumerable<TKey>.NativeMethodInfoPtr_CreateOrderedEnumerable_Public_Abstract_Virtual_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0, Il2CppClassPointerStore<IOrderedEnumerable<TKey>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)) }))));
		}
	}
}
