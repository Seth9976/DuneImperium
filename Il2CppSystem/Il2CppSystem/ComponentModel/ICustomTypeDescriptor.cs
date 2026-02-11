using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000111 RID: 273
	public class ICustomTypeDescriptor : Il2CppObjectBase
	{
		// Token: 0x06001110 RID: 4368 RVA: 0x0005D184 File Offset: 0x0005B384
		// Note: this type is marked as 'beforefieldinit'.
		static ICustomTypeDescriptor()
		{
			Il2CppClassPointerStore<ICustomTypeDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ICustomTypeDescriptor");
			ICustomTypeDescriptor.NativeMethodInfoPtr_GetAttributes_Public_Abstract_Virtual_New_AttributeCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomTypeDescriptor>.NativeClassPtr, 100665777);
			ICustomTypeDescriptor.NativeMethodInfoPtr_GetClassName_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomTypeDescriptor>.NativeClassPtr, 100665778);
			ICustomTypeDescriptor.NativeMethodInfoPtr_GetComponentName_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomTypeDescriptor>.NativeClassPtr, 100665779);
			ICustomTypeDescriptor.NativeMethodInfoPtr_GetConverter_Public_Abstract_Virtual_New_TypeConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomTypeDescriptor>.NativeClassPtr, 100665780);
			ICustomTypeDescriptor.NativeMethodInfoPtr_GetDefaultEvent_Public_Abstract_Virtual_New_EventDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomTypeDescriptor>.NativeClassPtr, 100665781);
			ICustomTypeDescriptor.NativeMethodInfoPtr_GetDefaultProperty_Public_Abstract_Virtual_New_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomTypeDescriptor>.NativeClassPtr, 100665782);
			ICustomTypeDescriptor.NativeMethodInfoPtr_GetEditor_Public_Abstract_Virtual_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomTypeDescriptor>.NativeClassPtr, 100665783);
			ICustomTypeDescriptor.NativeMethodInfoPtr_GetEvents_Public_Abstract_Virtual_New_EventDescriptorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomTypeDescriptor>.NativeClassPtr, 100665784);
			ICustomTypeDescriptor.NativeMethodInfoPtr_GetEvents_Public_Abstract_Virtual_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomTypeDescriptor>.NativeClassPtr, 100665785);
			ICustomTypeDescriptor.NativeMethodInfoPtr_GetProperties_Public_Abstract_Virtual_New_PropertyDescriptorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomTypeDescriptor>.NativeClassPtr, 100665786);
			ICustomTypeDescriptor.NativeMethodInfoPtr_GetProperties_Public_Abstract_Virtual_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomTypeDescriptor>.NativeClassPtr, 100665787);
			ICustomTypeDescriptor.NativeMethodInfoPtr_GetPropertyOwner_Public_Abstract_Virtual_New_Object_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomTypeDescriptor>.NativeClassPtr, 100665788);
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0005D29C File Offset: 0x0005B49C
		[CallerCount(0)]
		public unsafe virtual AttributeCollection GetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomTypeDescriptor.NativeMethodInfoPtr_GetAttributes_Public_Abstract_Virtual_New_AttributeCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeCollection>(intPtr3) : null;
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0005D2E8 File Offset: 0x0005B4E8
		[CallerCount(0)]
		public unsafe virtual string GetClassName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomTypeDescriptor.NativeMethodInfoPtr_GetClassName_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0005D32C File Offset: 0x0005B52C
		[CallerCount(0)]
		public unsafe virtual string GetComponentName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomTypeDescriptor.NativeMethodInfoPtr_GetComponentName_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0005D370 File Offset: 0x0005B570
		[CallerCount(0)]
		public unsafe virtual TypeConverter GetConverter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomTypeDescriptor.NativeMethodInfoPtr_GetConverter_Public_Abstract_Virtual_New_TypeConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeConverter>(intPtr3) : null;
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0005D3BC File Offset: 0x0005B5BC
		[CallerCount(0)]
		public unsafe virtual EventDescriptor GetDefaultEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomTypeDescriptor.NativeMethodInfoPtr_GetDefaultEvent_Public_Abstract_Virtual_New_EventDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptor>(intPtr3) : null;
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x0005D408 File Offset: 0x0005B608
		[CallerCount(0)]
		public unsafe virtual PropertyDescriptor GetDefaultProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomTypeDescriptor.NativeMethodInfoPtr_GetDefaultProperty_Public_Abstract_Virtual_New_PropertyDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptor>(intPtr3) : null;
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x0005D454 File Offset: 0x0005B654
		[CallerCount(0)]
		public unsafe virtual Object GetEditor(Type editorBaseType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(editorBaseType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomTypeDescriptor.NativeMethodInfoPtr_GetEditor_Public_Abstract_Virtual_New_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0005D4B0 File Offset: 0x0005B6B0
		[CallerCount(0)]
		public unsafe virtual EventDescriptorCollection GetEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomTypeDescriptor.NativeMethodInfoPtr_GetEvents_Public_Abstract_Virtual_New_EventDescriptorCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0005D4FC File Offset: 0x0005B6FC
		[CallerCount(0)]
		public unsafe virtual EventDescriptorCollection GetEvents(Il2CppReferenceArray<Attribute> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomTypeDescriptor.NativeMethodInfoPtr_GetEvents_Public_Abstract_Virtual_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0005D558 File Offset: 0x0005B758
		[CallerCount(0)]
		public unsafe virtual PropertyDescriptorCollection GetProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomTypeDescriptor.NativeMethodInfoPtr_GetProperties_Public_Abstract_Virtual_New_PropertyDescriptorCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0005D5A4 File Offset: 0x0005B7A4
		[CallerCount(0)]
		public unsafe virtual PropertyDescriptorCollection GetProperties(Il2CppReferenceArray<Attribute> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomTypeDescriptor.NativeMethodInfoPtr_GetProperties_Public_Abstract_Virtual_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0005D600 File Offset: 0x0005B800
		[CallerCount(0)]
		public unsafe virtual Object GetPropertyOwner(PropertyDescriptor pd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomTypeDescriptor.NativeMethodInfoPtr_GetPropertyOwner_Public_Abstract_Virtual_New_Object_PropertyDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0000807E File Offset: 0x0000627E
		public ICustomTypeDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Abstract_Virtual_New_AttributeCollection_0;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_GetClassName_Public_Abstract_Virtual_New_String_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentName_Public_Abstract_Virtual_New_String_0;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeMethodInfoPtr_GetConverter_Public_Abstract_Virtual_New_TypeConverter_0;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultEvent_Public_Abstract_Virtual_New_EventDescriptor_0;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultProperty_Public_Abstract_Virtual_New_PropertyDescriptor_0;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeMethodInfoPtr_GetEditor_Public_Abstract_Virtual_New_Object_Type_0;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeMethodInfoPtr_GetEvents_Public_Abstract_Virtual_New_EventDescriptorCollection_0;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeMethodInfoPtr_GetEvents_Public_Abstract_Virtual_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Abstract_Virtual_New_PropertyDescriptorCollection_0;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Abstract_Virtual_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyOwner_Public_Abstract_Virtual_New_Object_PropertyDescriptor_0;
	}
}
