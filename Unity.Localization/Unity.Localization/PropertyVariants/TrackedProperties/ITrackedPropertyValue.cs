using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000E5 RID: 229
	public class ITrackedPropertyValue<T> : Il2CppObjectBase
	{
		// Token: 0x06000B8B RID: 2955 RVA: 0x00034C84 File Offset: 0x00032E84
		// Note: this type is marked as 'beforefieldinit'.
		static ITrackedPropertyValue()
		{
			Il2CppClassPointerStore<ITrackedPropertyValue<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "ITrackedPropertyValue`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			ITrackedPropertyValue<T>.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Boolean_LocaleIdentifier_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackedPropertyValue<T>>.NativeClassPtr, 100665210);
			ITrackedPropertyValue<T>.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Boolean_LocaleIdentifier_LocaleIdentifier_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackedPropertyValue<T>>.NativeClassPtr, 100665211);
			ITrackedPropertyValue<T>.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_LocaleIdentifier_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackedPropertyValue<T>>.NativeClassPtr, 100665212);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00034D24 File Offset: 0x00032F24
		[CallerCount(0)]
		public unsafe virtual bool GetValue(LocaleIdentifier localeIdentifier, out T foundValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref foundValue;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITrackedPropertyValue<T>.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Boolean_LocaleIdentifier_byref_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				foundValue = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00034DD0 File Offset: 0x00032FD0
		[CallerCount(0)]
		public unsafe virtual bool GetValue(LocaleIdentifier localeIdentifier, LocaleIdentifier fallback, out T foundValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(fallback));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref foundValue;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITrackedPropertyValue<T>.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Boolean_LocaleIdentifier_LocaleIdentifier_byref_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				foundValue = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00034E94 File Offset: 0x00033094
		[CallerCount(0)]
		public unsafe virtual void SetValue(LocaleIdentifier localeIdentifier, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITrackedPropertyValue<T>.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_LocaleIdentifier_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00006C97 File Offset: 0x00004E97
		public ITrackedPropertyValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Boolean_LocaleIdentifier_byref_T_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Boolean_LocaleIdentifier_LocaleIdentifier_byref_T_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_LocaleIdentifier_T_0;
	}
}
