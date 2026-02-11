using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200020A RID: 522
	public class IUxmlObjectFactory<T> : Il2CppObjectBase where T : new()
	{
		// Token: 0x06002814 RID: 10260 RVA: 0x000B0458 File Offset: 0x000AE658
		// Note: this type is marked as 'beforefieldinit'.
		static IUxmlObjectFactory()
		{
			Il2CppClassPointerStore<IUxmlObjectFactory<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IUxmlObjectFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IUxmlObjectFactory<T>.NativeMethodInfoPtr_CreateObject_Public_Abstract_Virtual_New_T_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUxmlObjectFactory<T>>.NativeClassPtr, 100669329);
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x000B04D0 File Offset: 0x000AE6D0
		[CallerCount(0)]
		public unsafe virtual T CreateObject(IUxmlAttributes bag, CreationContext cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUxmlObjectFactory<T>.NativeMethodInfoPtr_CreateObject_Public_Abstract_Virtual_New_T_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x00010346 File Offset: 0x0000E546
		public IUxmlObjectFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C65 RID: 7269
		private static readonly IntPtr NativeMethodInfoPtr_CreateObject_Public_Abstract_Virtual_New_T_IUxmlAttributes_CreationContext_0;
	}
}
