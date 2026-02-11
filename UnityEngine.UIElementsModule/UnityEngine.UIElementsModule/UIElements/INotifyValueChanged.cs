using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000063 RID: 99
	public class INotifyValueChanged<T> : Il2CppObjectBase
	{
		// Token: 0x0600092D RID: 2349 RVA: 0x0003D744 File Offset: 0x0003B944
		// Note: this type is marked as 'beforefieldinit'.
		static INotifyValueChanged()
		{
			Il2CppClassPointerStore<INotifyValueChanged<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "INotifyValueChanged`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			INotifyValueChanged<T>.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotifyValueChanged<T>>.NativeClassPtr, 100664613);
			INotifyValueChanged<T>.NativeMethodInfoPtr_set_value_Public_Abstract_Virtual_New_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotifyValueChanged<T>>.NativeClassPtr, 100664614);
			INotifyValueChanged<T>.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Abstract_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotifyValueChanged<T>>.NativeClassPtr, 100664615);
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x0003D7E4 File Offset: 0x0003B9E4
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x0003D828 File Offset: 0x0003BA28
		public unsafe virtual T value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INotifyValueChanged<T>.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INotifyValueChanged<T>.NativeMethodInfoPtr_set_value_Public_Abstract_Virtual_New_set_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0003D8AC File Offset: 0x0003BAAC
		[CallerCount(0)]
		public unsafe virtual void SetValueWithoutNotify(T newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = newValue;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref newValue;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INotifyValueChanged<T>.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Abstract_Virtual_New_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0000542C File Offset: 0x0000362C
		public INotifyValueChanged(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_T_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Abstract_Virtual_New_set_Void_T_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Abstract_Virtual_New_Void_T_0;
	}
}
