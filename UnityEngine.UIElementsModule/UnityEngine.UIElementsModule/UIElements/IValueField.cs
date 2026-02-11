using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200008B RID: 139
	public class IValueField<T> : Il2CppObjectBase
	{
		// Token: 0x06000E2E RID: 3630 RVA: 0x0004EC8C File Offset: 0x0004CE8C
		// Note: this type is marked as 'beforefieldinit'.
		static IValueField()
		{
			Il2CppClassPointerStore<IValueField<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IValueField`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IValueField<T>.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueField<T>>.NativeClassPtr, 100665312);
			IValueField<T>.NativeMethodInfoPtr_set_value_Public_Abstract_Virtual_New_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueField<T>>.NativeClassPtr, 100665313);
			IValueField<T>.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Abstract_Virtual_New_Void_Vector3_DeltaSpeed_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueField<T>>.NativeClassPtr, 100665314);
			IValueField<T>.NativeMethodInfoPtr_StartDragging_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueField<T>>.NativeClassPtr, 100665315);
			IValueField<T>.NativeMethodInfoPtr_StopDragging_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueField<T>>.NativeClassPtr, 100665316);
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x0004ED54 File Offset: 0x0004CF54
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x0004ED98 File Offset: 0x0004CF98
		public unsafe virtual T value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValueField<T>.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValueField<T>.NativeMethodInfoPtr_set_value_Public_Abstract_Virtual_New_set_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x0004EE1C File Offset: 0x0004D01C
		[CallerCount(0)]
		public unsafe virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, T startValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = startValue;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref startValue;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValueField<T>.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Abstract_Virtual_New_Void_Vector3_DeltaSpeed_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0004EEBC File Offset: 0x0004D0BC
		[CallerCount(0)]
		public unsafe virtual void StartDragging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValueField<T>.NativeMethodInfoPtr_StartDragging_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0004EEF8 File Offset: 0x0004D0F8
		[CallerCount(0)]
		public unsafe virtual void StopDragging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValueField<T>.NativeMethodInfoPtr_StopDragging_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00007532 File Offset: 0x00005732
		public IValueField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_T_0;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Abstract_Virtual_New_set_Void_T_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Abstract_Virtual_New_Void_Vector3_DeltaSpeed_T_0;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_StartDragging_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_StopDragging_Public_Abstract_Virtual_New_Void_0;
	}
}
