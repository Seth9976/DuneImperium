using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007A RID: 122
	public class IAttributeProvider : Il2CppObjectBase
	{
		// Token: 0x06000A4A RID: 2634 RVA: 0x00041F90 File Offset: 0x00040190
		// Note: this type is marked as 'beforefieldinit'.
		static IAttributeProvider()
		{
			Il2CppClassPointerStore<IAttributeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "IAttributeProvider");
			IAttributeProvider.NativeMethodInfoPtr_GetAttributes_Public_Abstract_Virtual_New_IList_1_Attribute_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttributeProvider>.NativeClassPtr, 100665279);
			IAttributeProvider.NativeMethodInfoPtr_GetAttributes_Public_Abstract_Virtual_New_IList_1_Attribute_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttributeProvider>.NativeClassPtr, 100665280);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00041FE0 File Offset: 0x000401E0
		[CallerCount(0)]
		public unsafe virtual IList<Attribute> GetAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttributeProvider.NativeMethodInfoPtr_GetAttributes_Public_Abstract_Virtual_New_IList_1_Attribute_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Attribute>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00042038 File Offset: 0x00040238
		[CallerCount(0)]
		public unsafe virtual IList<Attribute> GetAttributes(Type attributeType, bool inherit)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttributeProvider.NativeMethodInfoPtr_GetAttributes_Public_Abstract_Virtual_New_IList_1_Attribute_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Attribute>>(intPtr3) : null;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00005226 File Offset: 0x00003426
		public IAttributeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Abstract_Virtual_New_IList_1_Attribute_Boolean_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Abstract_Virtual_New_IList_1_Attribute_Type_Boolean_0;
	}
}
