using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Properties
{
	// Token: 0x02000004 RID: 4
	public sealed class PropertyGetter<TContainer, TValue> : MulticastDelegate
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000035DC File Offset: 0x000017DC
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyGetter()
		{
			Il2CppClassPointerStore<PropertyGetter<TContainer, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "PropertyGetter`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			PropertyGetter<TContainer, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGetter<TContainer, TValue>>.NativeClassPtr, 100663297);
			PropertyGetter<TContainer, TValue>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TValue_byref_TContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyGetter<TContainer, TValue>>.NativeClassPtr, 100663298);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00003678 File Offset: 0x00001878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230377, XrefRangeEnd = 1230381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyGetter(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyGetter<TContainer, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyGetter<TContainer, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000036D4 File Offset: 0x000018D4
		[CallerCount(0)]
		public unsafe TValue Invoke(ref TContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(container);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PropertyGetter<TContainer, TValue>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TValue_byref_TContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				container = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<TContainer>(intPtr4, false, false));
				return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020AC File Offset: 0x000002AC
		public PropertyGetter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TValue_byref_TContainer_0;
	}
}
