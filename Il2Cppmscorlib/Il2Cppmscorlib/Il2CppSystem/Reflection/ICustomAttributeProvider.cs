using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200040F RID: 1039
	public class ICustomAttributeProvider : Il2CppObjectBase
	{
		// Token: 0x06003C05 RID: 15365 RVA: 0x0011FE98 File Offset: 0x0011E098
		// Note: this type is marked as 'beforefieldinit'.
		static ICustomAttributeProvider()
		{
			Il2CppClassPointerStore<ICustomAttributeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ICustomAttributeProvider");
			ICustomAttributeProvider.NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomAttributeProvider>.NativeClassPtr, 100672251);
			ICustomAttributeProvider.NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomAttributeProvider>.NativeClassPtr, 100672252);
			ICustomAttributeProvider.NativeMethodInfoPtr_IsDefined_Public_Abstract_Virtual_New_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomAttributeProvider>.NativeClassPtr, 100672253);
		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x0011FEFC File Offset: 0x0011E0FC
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomAttributeProvider.NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06003C07 RID: 15367 RVA: 0x0011FF54 File Offset: 0x0011E154
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Object> GetCustomAttributes(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomAttributeProvider.NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06003C08 RID: 15368 RVA: 0x0011FFC0 File Offset: 0x0011E1C0
		[CallerCount(0)]
		public unsafe virtual bool IsDefined(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomAttributeProvider.NativeMethodInfoPtr_IsDefined_Public_Abstract_Virtual_New_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x000164B3 File Offset: 0x000146B3
		public ICustomAttributeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040030BB RID: 12475
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x040030BC RID: 12476
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x040030BD RID: 12477
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Abstract_Virtual_New_Boolean_Type_Boolean_0;
	}
}
