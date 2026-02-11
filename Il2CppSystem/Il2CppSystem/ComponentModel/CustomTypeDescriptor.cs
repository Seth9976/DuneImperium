using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000100 RID: 256
	public class CustomTypeDescriptor : Object
	{
		// Token: 0x06001023 RID: 4131 RVA: 0x00058F80 File Offset: 0x00057180
		// Note: this type is marked as 'beforefieldinit'.
		static CustomTypeDescriptor()
		{
			Il2CppClassPointerStore<CustomTypeDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "CustomTypeDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomTypeDescriptor>.NativeClassPtr);
			CustomTypeDescriptor.NativeFieldInfoPtr__parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTypeDescriptor>.NativeClassPtr, "_parent");
			CustomTypeDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTypeDescriptor>.NativeClassPtr, 100665623);
			CustomTypeDescriptor.NativeMethodInfoPtr_GetAttributes_Public_Virtual_New_AttributeCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTypeDescriptor>.NativeClassPtr, 100665624);
			CustomTypeDescriptor.NativeMethodInfoPtr_GetClassName_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTypeDescriptor>.NativeClassPtr, 100665625);
			CustomTypeDescriptor.NativeMethodInfoPtr_GetComponentName_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTypeDescriptor>.NativeClassPtr, 100665626);
			CustomTypeDescriptor.NativeMethodInfoPtr_GetConverter_Public_Virtual_New_TypeConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTypeDescriptor>.NativeClassPtr, 100665627);
			CustomTypeDescriptor.NativeMethodInfoPtr_GetDefaultEvent_Public_Virtual_New_EventDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTypeDescriptor>.NativeClassPtr, 100665628);
			CustomTypeDescriptor.NativeMethodInfoPtr_GetDefaultProperty_Public_Virtual_New_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTypeDescriptor>.NativeClassPtr, 100665629);
			CustomTypeDescriptor.NativeMethodInfoPtr_GetEditor_Public_Virtual_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTypeDescriptor>.NativeClassPtr, 100665630);
			CustomTypeDescriptor.NativeMethodInfoPtr_GetEvents_Public_Virtual_New_EventDescriptorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTypeDescriptor>.NativeClassPtr, 100665631);
			CustomTypeDescriptor.NativeMethodInfoPtr_GetEvents_Public_Virtual_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTypeDescriptor>.NativeClassPtr, 100665632);
			CustomTypeDescriptor.NativeMethodInfoPtr_GetProperties_Public_Virtual_New_PropertyDescriptorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTypeDescriptor>.NativeClassPtr, 100665633);
			CustomTypeDescriptor.NativeMethodInfoPtr_GetProperties_Public_Virtual_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTypeDescriptor>.NativeClassPtr, 100665634);
			CustomTypeDescriptor.NativeMethodInfoPtr_GetPropertyOwner_Public_Virtual_New_Object_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTypeDescriptor>.NativeClassPtr, 100665635);
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x000590C8 File Offset: 0x000572C8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomTypeDescriptor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomTypeDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomTypeDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00059104 File Offset: 0x00057304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458588, XrefRangeEnd = 458593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AttributeCollection GetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomTypeDescriptor.NativeMethodInfoPtr_GetAttributes_Public_Virtual_New_AttributeCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeCollection>(intPtr3) : null;
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00059150 File Offset: 0x00057350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458593, XrefRangeEnd = 458596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetClassName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomTypeDescriptor.NativeMethodInfoPtr_GetClassName_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00059194 File Offset: 0x00057394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458596, XrefRangeEnd = 458599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetComponentName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomTypeDescriptor.NativeMethodInfoPtr_GetComponentName_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x000591D8 File Offset: 0x000573D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458599, XrefRangeEnd = 458604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TypeConverter GetConverter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomTypeDescriptor.NativeMethodInfoPtr_GetConverter_Public_Virtual_New_TypeConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeConverter>(intPtr3) : null;
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x00059224 File Offset: 0x00057424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458604, XrefRangeEnd = 458607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EventDescriptor GetDefaultEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomTypeDescriptor.NativeMethodInfoPtr_GetDefaultEvent_Public_Virtual_New_EventDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptor>(intPtr3) : null;
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00059270 File Offset: 0x00057470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458607, XrefRangeEnd = 458610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PropertyDescriptor GetDefaultProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomTypeDescriptor.NativeMethodInfoPtr_GetDefaultProperty_Public_Virtual_New_PropertyDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptor>(intPtr3) : null;
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x000592BC File Offset: 0x000574BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458610, XrefRangeEnd = 458613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetEditor(Type editorBaseType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(editorBaseType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomTypeDescriptor.NativeMethodInfoPtr_GetEditor_Public_Virtual_New_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00059318 File Offset: 0x00057518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458613, XrefRangeEnd = 458618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EventDescriptorCollection GetEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomTypeDescriptor.NativeMethodInfoPtr_GetEvents_Public_Virtual_New_EventDescriptorCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00059364 File Offset: 0x00057564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458618, XrefRangeEnd = 458623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EventDescriptorCollection GetEvents(Il2CppReferenceArray<Attribute> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomTypeDescriptor.NativeMethodInfoPtr_GetEvents_Public_Virtual_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x000593C0 File Offset: 0x000575C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458623, XrefRangeEnd = 458628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PropertyDescriptorCollection GetProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomTypeDescriptor.NativeMethodInfoPtr_GetProperties_Public_Virtual_New_PropertyDescriptorCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0005940C File Offset: 0x0005760C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458628, XrefRangeEnd = 458633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PropertyDescriptorCollection GetProperties(Il2CppReferenceArray<Attribute> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomTypeDescriptor.NativeMethodInfoPtr_GetProperties_Public_Virtual_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00059468 File Offset: 0x00057668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458633, XrefRangeEnd = 458636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetPropertyOwner(PropertyDescriptor pd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomTypeDescriptor.NativeMethodInfoPtr_GetPropertyOwner_Public_Virtual_New_Object_PropertyDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00007CA5 File Offset: 0x00005EA5
		public CustomTypeDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x000594C4 File Offset: 0x000576C4
		// (set) Token: 0x06001033 RID: 4147 RVA: 0x00007CAE File Offset: 0x00005EAE
		public unsafe ICustomTypeDescriptor _parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomTypeDescriptor.NativeFieldInfoPtr__parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICustomTypeDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomTypeDescriptor.NativeFieldInfoPtr__parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeFieldInfoPtr__parent;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Virtual_New_AttributeCollection_0;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeMethodInfoPtr_GetClassName_Public_Virtual_New_String_0;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentName_Public_Virtual_New_String_0;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeMethodInfoPtr_GetConverter_Public_Virtual_New_TypeConverter_0;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultEvent_Public_Virtual_New_EventDescriptor_0;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultProperty_Public_Virtual_New_PropertyDescriptor_0;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_GetEditor_Public_Virtual_New_Object_Type_0;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeMethodInfoPtr_GetEvents_Public_Virtual_New_EventDescriptorCollection_0;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeMethodInfoPtr_GetEvents_Public_Virtual_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Virtual_New_PropertyDescriptorCollection_0;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Virtual_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyOwner_Public_Virtual_New_Object_PropertyDescriptor_0;
	}
}
