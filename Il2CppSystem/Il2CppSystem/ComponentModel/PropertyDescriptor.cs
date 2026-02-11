using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000121 RID: 289
	public class PropertyDescriptor : MemberDescriptor
	{
		// Token: 0x06001196 RID: 4502 RVA: 0x0005F530 File Offset: 0x0005D730
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyDescriptor()
		{
			Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "PropertyDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr);
			PropertyDescriptor.NativeFieldInfoPtr__converter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, "_converter");
			PropertyDescriptor.NativeFieldInfoPtr__valueChangedHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, "_valueChangedHandlers");
			PropertyDescriptor.NativeFieldInfoPtr__editors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, "_editors");
			PropertyDescriptor.NativeFieldInfoPtr__editorTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, "_editorTypes");
			PropertyDescriptor.NativeFieldInfoPtr__editorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, "_editorCount");
			PropertyDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_String_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, 100665852);
			PropertyDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_MemberDescriptor_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, 100665853);
			PropertyDescriptor.NativeMethodInfoPtr_get_ComponentType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, 100665854);
			PropertyDescriptor.NativeMethodInfoPtr_get_Converter_Public_Virtual_New_get_TypeConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, 100665855);
			PropertyDescriptor.NativeMethodInfoPtr_get_IsReadOnly_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, 100665856);
			PropertyDescriptor.NativeMethodInfoPtr_get_PropertyType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, 100665857);
			PropertyDescriptor.NativeMethodInfoPtr_CanResetValue_Public_Abstract_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, 100665858);
			PropertyDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, 100665859);
			PropertyDescriptor.NativeMethodInfoPtr_CreateInstance_Protected_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, 100665860);
			PropertyDescriptor.NativeMethodInfoPtr_FillAttributes_Protected_Virtual_Void_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, 100665861);
			PropertyDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, 100665862);
			PropertyDescriptor.NativeMethodInfoPtr_GetInvocationTarget_Protected_Virtual_Object_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, 100665863);
			PropertyDescriptor.NativeMethodInfoPtr_GetTypeFromName_Protected_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, 100665864);
			PropertyDescriptor.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, 100665865);
			PropertyDescriptor.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, 100665866);
			PropertyDescriptor.NativeMethodInfoPtr_ResetValue_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, 100665867);
			PropertyDescriptor.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, 100665868);
			PropertyDescriptor.NativeMethodInfoPtr_ShouldSerializeValue_Public_Abstract_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr, 100665869);
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x0005F72C File Offset: 0x0005D92C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 458985, RefRangeEnd = 458995, XrefRangeStart = 458985, XrefRangeEnd = 458995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDescriptor(string name, Il2CppReferenceArray<Attribute> attrs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_String_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x0005F78C File Offset: 0x0005D98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459613, XrefRangeEnd = 459614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDescriptor(MemberDescriptor descr, Il2CppReferenceArray<Attribute> attrs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(descr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_MemberDescriptor_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x0005F7EC File Offset: 0x0005D9EC
		public unsafe virtual Type ComponentType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDescriptor.NativeMethodInfoPtr_get_ComponentType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x0005F838 File Offset: 0x0005DA38
		public unsafe virtual TypeConverter Converter
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459614, XrefRangeEnd = 459642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDescriptor.NativeMethodInfoPtr_get_Converter_Public_Virtual_New_get_TypeConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeConverter>(intPtr3) : null;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x0005F884 File Offset: 0x0005DA84
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDescriptor.NativeMethodInfoPtr_get_IsReadOnly_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x0005F8CC File Offset: 0x0005DACC
		public unsafe virtual Type PropertyType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDescriptor.NativeMethodInfoPtr_get_PropertyType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0005F918 File Offset: 0x0005DB18
		[CallerCount(0)]
		public unsafe virtual bool CanResetValue(Object component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDescriptor.NativeMethodInfoPtr_CanResetValue_Public_Abstract_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x0005F970 File Offset: 0x0005DB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459642, XrefRangeEnd = 459652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0005F9C8 File Offset: 0x0005DBC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 459673, RefRangeEnd = 459674, XrefRangeStart = 459652, XrefRangeEnd = 459673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateInstance(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDescriptor.NativeMethodInfoPtr_CreateInstance_Protected_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x0005FA18 File Offset: 0x0005DC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459674, XrefRangeEnd = 459678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FillAttributes(IList attributeList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDescriptor.NativeMethodInfoPtr_FillAttributes_Protected_Virtual_Void_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0005FA68 File Offset: 0x0005DC68
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x0005FAB0 File Offset: 0x0005DCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459678, XrefRangeEnd = 459691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetInvocationTarget(Type type, Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDescriptor.NativeMethodInfoPtr_GetInvocationTarget_Protected_Virtual_Object_Type_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0005FB20 File Offset: 0x0005DD20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 459706, RefRangeEnd = 459707, XrefRangeStart = 459691, XrefRangeEnd = 459706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetTypeFromName(string typeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDescriptor.NativeMethodInfoPtr_GetTypeFromName_Protected_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x0005FB70 File Offset: 0x0005DD70
		[CallerCount(0)]
		public unsafe virtual Object GetValue(Object component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDescriptor.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0005FBCC File Offset: 0x0005DDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459707, XrefRangeEnd = 459709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValueChanged(Object component, EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDescriptor.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Object_EventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0005FC2C File Offset: 0x0005DE2C
		[CallerCount(0)]
		public unsafe virtual void ResetValue(Object component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDescriptor.NativeMethodInfoPtr_ResetValue_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0005FC7C File Offset: 0x0005DE7C
		[CallerCount(0)]
		public unsafe virtual void SetValue(Object component, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDescriptor.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0005FCDC File Offset: 0x0005DEDC
		[CallerCount(0)]
		public unsafe virtual bool ShouldSerializeValue(Object component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDescriptor.NativeMethodInfoPtr_ShouldSerializeValue_Public_Abstract_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x00008339 File Offset: 0x00006539
		public PropertyDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x0005FD34 File Offset: 0x0005DF34
		// (set) Token: 0x060011AB RID: 4523 RVA: 0x00008342 File Offset: 0x00006542
		public unsafe TypeConverter _converter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDescriptor.NativeFieldInfoPtr__converter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDescriptor.NativeFieldInfoPtr__converter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x0005FD64 File Offset: 0x0005DF64
		// (set) Token: 0x060011AD RID: 4525 RVA: 0x00008361 File Offset: 0x00006561
		public unsafe Hashtable _valueChangedHandlers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDescriptor.NativeFieldInfoPtr__valueChangedHandlers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDescriptor.NativeFieldInfoPtr__valueChangedHandlers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x0005FD94 File Offset: 0x0005DF94
		// (set) Token: 0x060011AF RID: 4527 RVA: 0x00008380 File Offset: 0x00006580
		public unsafe Il2CppReferenceArray<Object> _editors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDescriptor.NativeFieldInfoPtr__editors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDescriptor.NativeFieldInfoPtr__editors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x0005FDC4 File Offset: 0x0005DFC4
		// (set) Token: 0x060011B1 RID: 4529 RVA: 0x0000839F File Offset: 0x0000659F
		public unsafe Il2CppReferenceArray<Type> _editorTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDescriptor.NativeFieldInfoPtr__editorTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDescriptor.NativeFieldInfoPtr__editorTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x0005FDF4 File Offset: 0x0005DFF4
		// (set) Token: 0x060011B3 RID: 4531 RVA: 0x000083BE File Offset: 0x000065BE
		public unsafe int _editorCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDescriptor.NativeFieldInfoPtr__editorCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDescriptor.NativeFieldInfoPtr__editorCount)) = value;
			}
		}

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeFieldInfoPtr__converter;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeFieldInfoPtr__valueChangedHandlers;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeFieldInfoPtr__editors;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeFieldInfoPtr__editorTypes;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeFieldInfoPtr__editorCount;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_MemberDescriptor_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeMethodInfoPtr_get_ComponentType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeMethodInfoPtr_get_Converter_Public_Virtual_New_get_TypeConverter_0;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr_CanResetValue_Public_Abstract_Virtual_New_Boolean_Object_0;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Protected_Object_Type_0;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeMethodInfoPtr_FillAttributes_Protected_Virtual_Void_IList_0;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeMethodInfoPtr_GetInvocationTarget_Protected_Virtual_Object_Type_Object_0;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeFromName_Protected_Type_String_0;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_Object_0;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Object_EventArgs_0;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeMethodInfoPtr_ResetValue_Public_Abstract_Virtual_New_Void_Object_0;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Object_0;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSerializeValue_Public_Abstract_Virtual_New_Boolean_Object_0;
	}
}
