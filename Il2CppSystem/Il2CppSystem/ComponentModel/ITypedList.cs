using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000115 RID: 277
	public class ITypedList : Il2CppObjectBase
	{
		// Token: 0x06001127 RID: 4391 RVA: 0x0005D744 File Offset: 0x0005B944
		// Note: this type is marked as 'beforefieldinit'.
		static ITypedList()
		{
			Il2CppClassPointerStore<ITypedList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ITypedList");
			ITypedList.NativeMethodInfoPtr_GetListName_Public_Abstract_Virtual_New_String_Il2CppReferenceArray_1_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITypedList>.NativeClassPtr, 100665792);
			ITypedList.NativeMethodInfoPtr_GetItemProperties_Public_Abstract_Virtual_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITypedList>.NativeClassPtr, 100665793);
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0005D794 File Offset: 0x0005B994
		[CallerCount(0)]
		public unsafe virtual string GetListName(Il2CppReferenceArray<PropertyDescriptor> listAccessors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listAccessors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITypedList.NativeMethodInfoPtr_GetListName_Public_Abstract_Virtual_New_String_Il2CppReferenceArray_1_PropertyDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x0005D7E8 File Offset: 0x0005B9E8
		[CallerCount(0)]
		public unsafe virtual PropertyDescriptorCollection GetItemProperties(Il2CppReferenceArray<PropertyDescriptor> listAccessors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listAccessors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITypedList.NativeMethodInfoPtr_GetItemProperties_Public_Abstract_Virtual_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_PropertyDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x0000812F File Offset: 0x0000632F
		public ITypedList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeMethodInfoPtr_GetListName_Public_Abstract_Virtual_New_String_Il2CppReferenceArray_1_PropertyDescriptor_0;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeMethodInfoPtr_GetItemProperties_Public_Abstract_Virtual_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_PropertyDescriptor_0;
	}
}
