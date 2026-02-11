using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Properties
{
	// Token: 0x02000005 RID: 5
	public sealed class PropertySetter<TContainer, TValue> : MulticastDelegate
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00003738 File Offset: 0x00001938
		// Note: this type is marked as 'beforefieldinit'.
		static PropertySetter()
		{
			Il2CppClassPointerStore<PropertySetter<TContainer, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "PropertySetter`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			PropertySetter<TContainer, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySetter<TContainer, TValue>>.NativeClassPtr, 100663299);
			PropertySetter<TContainer, TValue>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_TContainer_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySetter<TContainer, TValue>>.NativeClassPtr, 100663300);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000037D4 File Offset: 0x000019D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230381, XrefRangeEnd = 1230385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertySetter(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertySetter<TContainer, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySetter<TContainer, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003830 File Offset: 0x00001A30
		[CallerCount(0)]
		public unsafe void Invoke(ref TContainer container, TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(container);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = value;
				intPtr2 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PropertySetter<TContainer, TValue>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_TContainer_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			container = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TContainer>(intPtr5, false, false));
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020B5 File Offset: 0x000002B5
		public PropertySetter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_TContainer_TValue_0;
	}
}
