using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004EA RID: 1258
	public class IReadOnlyDictionary<TKey, TValue> : Il2CppObjectBase
	{
		// Token: 0x06004DA6 RID: 19878 RVA: 0x0016842C File Offset: 0x0016662C
		// Note: this type is marked as 'beforefieldinit'.
		static IReadOnlyDictionary()
		{
			Il2CppClassPointerStore<IReadOnlyDictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "IReadOnlyDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Abstract_Virtual_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674962);
			IReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674963);
			IReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674964);
			IReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_Abstract_Virtual_New_get_IEnumerable_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674965);
			IReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_Abstract_Virtual_New_get_IEnumerable_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674966);
		}

		// Token: 0x06004DA7 RID: 19879 RVA: 0x00168504 File Offset: 0x00166704
		[CallerCount(0)]
		public unsafe virtual bool ContainsKey(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Abstract_Virtual_New_Boolean_TKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004DA8 RID: 19880 RVA: 0x00168594 File Offset: 0x00166794
		[CallerCount(0)]
		public unsafe virtual bool TryGetValue(TKey key, out TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			IntPtr intPtr3;
			if (!typeof(TValue).IsValueType)
			{
				intPtr2 = 0;
				intPtr3 = &intPtr2;
			}
			else
			{
				intPtr3 = ref value;
			}
			ptr3 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_TKey_byref_TValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x17001404 RID: 5124
		public unsafe virtual TValue this[TKey key]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TKey).IsValueType)
					{
						TKey tkey = key;
						intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref key;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_TValue_TKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
				}
			}
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x06004DAA RID: 19882 RVA: 0x00168700 File Offset: 0x00166900
		public unsafe virtual IEnumerable<TKey> Keys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_Abstract_Virtual_New_get_IEnumerable_1_TKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TKey>>(intPtr3) : null;
			}
		}

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x06004DAB RID: 19883 RVA: 0x0016874C File Offset: 0x0016694C
		public unsafe virtual IEnumerable<TValue> Values
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_Abstract_Virtual_New_get_IEnumerable_1_TValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TValue>>(intPtr3) : null;
			}
		}

		// Token: 0x06004DAC RID: 19884 RVA: 0x0001C1A9 File Offset: 0x0001A3A9
		public IReadOnlyDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003F80 RID: 16256
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Abstract_Virtual_New_Boolean_TKey_0;

		// Token: 0x04003F81 RID: 16257
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_TKey_byref_TValue_0;

		// Token: 0x04003F82 RID: 16258
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_TValue_TKey_0;

		// Token: 0x04003F83 RID: 16259
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Abstract_Virtual_New_get_IEnumerable_1_TKey_0;

		// Token: 0x04003F84 RID: 16260
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Abstract_Virtual_New_get_IEnumerable_1_TValue_0;
	}
}
