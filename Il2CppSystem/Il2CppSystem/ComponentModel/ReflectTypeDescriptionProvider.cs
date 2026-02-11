using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000144 RID: 324
	public sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider
	{
		// Token: 0x06001377 RID: 4983 RVA: 0x00067028 File Offset: 0x00065228
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectTypeDescriptionProvider()
		{
			Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ReflectTypeDescriptionProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr);
			ReflectTypeDescriptionProvider.NativeFieldInfoPtr__typeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, "_typeData");
			ReflectTypeDescriptionProvider.NativeFieldInfoPtr__typeConstructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, "_typeConstructor");
			ReflectTypeDescriptionProvider.NativeFieldInfoPtr__editorTables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, "_editorTables");
			ReflectTypeDescriptionProvider.NativeFieldInfoPtr__intrinsicTypeConverters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, "_intrinsicTypeConverters");
			ReflectTypeDescriptionProvider.NativeFieldInfoPtr__intrinsicReferenceKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, "_intrinsicReferenceKey");
			ReflectTypeDescriptionProvider.NativeFieldInfoPtr__intrinsicNullableKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, "_intrinsicNullableKey");
			ReflectTypeDescriptionProvider.NativeFieldInfoPtr__dictionaryKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, "_dictionaryKey");
			ReflectTypeDescriptionProvider.NativeFieldInfoPtr__propertyCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, "_propertyCache");
			ReflectTypeDescriptionProvider.NativeFieldInfoPtr__eventCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, "_eventCache");
			ReflectTypeDescriptionProvider.NativeFieldInfoPtr__attributeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, "_attributeCache");
			ReflectTypeDescriptionProvider.NativeFieldInfoPtr__extendedPropertyCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, "_extendedPropertyCache");
			ReflectTypeDescriptionProvider.NativeFieldInfoPtr__extenderProviderKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, "_extenderProviderKey");
			ReflectTypeDescriptionProvider.NativeFieldInfoPtr__extenderPropertiesKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, "_extenderPropertiesKey");
			ReflectTypeDescriptionProvider.NativeFieldInfoPtr__extenderProviderPropertiesKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, "_extenderProviderPropertiesKey");
			ReflectTypeDescriptionProvider.NativeFieldInfoPtr__skipInterfaceAttributeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, "_skipInterfaceAttributeList");
			ReflectTypeDescriptionProvider.NativeFieldInfoPtr__internalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, "_internalSyncObject");
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666106);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_get_IntrinsicTypeConverters_Private_Static_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666107);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_CreateInstance_Public_Virtual_Object_IServiceProvider_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666108);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_CreateInstance_Private_Static_Object_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666109);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetAttributes_Internal_AttributeCollection_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666110);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetCache_Public_Virtual_IDictionary_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666111);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetClassName_Internal_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666112);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetComponentName_Internal_String_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666113);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetConverter_Internal_TypeConverter_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666114);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetDefaultEvent_Internal_EventDescriptor_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666115);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetDefaultProperty_Internal_PropertyDescriptor_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666116);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetEditor_Internal_Object_Type_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666117);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetEditorTable_Private_Static_Hashtable_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666118);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetEvents_Internal_EventDescriptorCollection_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666119);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedAttributes_Internal_AttributeCollection_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666120);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedClassName_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666121);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedComponentName_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666122);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedConverter_Internal_TypeConverter_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666123);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedDefaultEvent_Internal_EventDescriptor_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666124);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedDefaultProperty_Internal_PropertyDescriptor_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666125);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedEditor_Internal_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666126);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedEvents_Internal_EventDescriptorCollection_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666127);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedProperties_Internal_PropertyDescriptorCollection_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666128);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtenderProviders_FamOrAssem_Virtual_Il2CppReferenceArray_1_IExtenderProvider_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666129);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtenders_Private_Static_Il2CppReferenceArray_1_IExtenderProvider_ICollection_Object_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666130);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedPropertyOwner_Internal_Object_Object_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666131);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedTypeDescriptor_Public_Virtual_ICustomTypeDescriptor_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666132);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetProperties_Internal_PropertyDescriptorCollection_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666133);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetPropertyOwner_Internal_Object_Type_Object_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666134);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetReflectionType_Public_Virtual_Type_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666135);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetTypeData_Private_ReflectedTypeData_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666136);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetTypeDescriptor_Public_Virtual_ICustomTypeDescriptor_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666137);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetTypeFromName_Private_Static_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666138);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_IsPopulated_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666139);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_ReflectGetAttributes_Private_Static_Il2CppReferenceArray_1_Attribute_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666140);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_ReflectGetAttributes_Internal_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666141);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_ReflectGetEvents_Private_Static_Il2CppReferenceArray_1_EventDescriptor_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666142);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_ReflectGetExtendedProperties_Private_Static_Il2CppReferenceArray_1_PropertyDescriptor_IExtenderProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666143);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_ReflectGetProperties_Private_Static_Il2CppReferenceArray_1_PropertyDescriptor_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666144);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_Refresh_Internal_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666145);
			ReflectTypeDescriptionProvider.NativeMethodInfoPtr_SearchIntrinsicTable_Private_Static_Object_Hashtable_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, 100666146);
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x000674CC File Offset: 0x000656CC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectTypeDescriptionProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x00067508 File Offset: 0x00065708
		public unsafe static Hashtable IntrinsicTypeConverters
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 462688, RefRangeEnd = 462689, XrefRangeStart = 462515, XrefRangeEnd = 462688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_get_IntrinsicTypeConverters_Private_Static_get_Hashtable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0006753C File Offset: 0x0006573C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462689, XrefRangeEnd = 462709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object CreateInstance(IServiceProvider provider, Type objectType, Il2CppReferenceArray<Type> argTypes, Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argTypes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_CreateInstance_Public_Virtual_Object_IServiceProvider_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x000675C4 File Offset: 0x000657C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 462720, RefRangeEnd = 462724, XrefRangeStart = 462709, XrefRangeEnd = 462720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstance(Type objectType, Type callingType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callingType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_CreateInstance_Private_Static_Object_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x0006761C File Offset: 0x0006581C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 462727, RefRangeEnd = 462728, XrefRangeStart = 462724, XrefRangeEnd = 462727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeCollection GetAttributes(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetAttributes_Internal_AttributeCollection_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0006766C File Offset: 0x0006586C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462728, XrefRangeEnd = 462765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IDictionary GetCache(Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetCache_Public_Virtual_IDictionary_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x000676BC File Offset: 0x000658BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462765, XrefRangeEnd = 462767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetClassName(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetClassName_Internal_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00067704 File Offset: 0x00065904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 462781, RefRangeEnd = 462782, XrefRangeStart = 462767, XrefRangeEnd = 462781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetComponentName(Type type, Object instance)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetComponentName_Internal_String_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x00067760 File Offset: 0x00065960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 462785, RefRangeEnd = 462786, XrefRangeStart = 462782, XrefRangeEnd = 462785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeConverter GetConverter(Type type, Object instance)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetConverter_Internal_TypeConverter_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeConverter>(intPtr3) : null;
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x000677C4 File Offset: 0x000659C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 462789, RefRangeEnd = 462790, XrefRangeStart = 462786, XrefRangeEnd = 462789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDescriptor GetDefaultEvent(Type type, Object instance)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetDefaultEvent_Internal_EventDescriptor_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptor>(intPtr3) : null;
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00067828 File Offset: 0x00065A28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 462793, RefRangeEnd = 462794, XrefRangeStart = 462790, XrefRangeEnd = 462793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDescriptor GetDefaultProperty(Type type, Object instance)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetDefaultProperty_Internal_PropertyDescriptor_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptor>(intPtr3) : null;
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x0006788C File Offset: 0x00065A8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 462797, RefRangeEnd = 462798, XrefRangeStart = 462794, XrefRangeEnd = 462797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetEditor(Type type, Object instance, Type editorBaseType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(editorBaseType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetEditor_Internal_Object_Type_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x00067900 File Offset: 0x00065B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462798, XrefRangeEnd = 462856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Hashtable GetEditorTable(Type editorBaseType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(editorBaseType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetEditorTable_Private_Static_Hashtable_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x00067944 File Offset: 0x00065B44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 462859, RefRangeEnd = 462861, XrefRangeStart = 462856, XrefRangeEnd = 462859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDescriptorCollection GetEvents(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetEvents_Internal_EventDescriptorCollection_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x00067994 File Offset: 0x00065B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462861, XrefRangeEnd = 462865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeCollection GetExtendedAttributes(Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedAttributes_Internal_AttributeCollection_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x000679E4 File Offset: 0x00065BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462865, XrefRangeEnd = 462868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetExtendedClassName(Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedClassName_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00067A2C File Offset: 0x00065C2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 462883, RefRangeEnd = 462884, XrefRangeStart = 462868, XrefRangeEnd = 462883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetExtendedComponentName(Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedComponentName_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x00067A74 File Offset: 0x00065C74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 462888, RefRangeEnd = 462889, XrefRangeStart = 462884, XrefRangeEnd = 462888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeConverter GetExtendedConverter(Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedConverter_Internal_TypeConverter_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeConverter>(intPtr3) : null;
			}
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00067AC4 File Offset: 0x00065CC4
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDescriptor GetExtendedDefaultEvent(Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedDefaultEvent_Internal_EventDescriptor_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00067B14 File Offset: 0x00065D14
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDescriptor GetExtendedDefaultProperty(Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedDefaultProperty_Internal_PropertyDescriptor_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x00067B64 File Offset: 0x00065D64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 462893, RefRangeEnd = 462894, XrefRangeStart = 462889, XrefRangeEnd = 462893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetExtendedEditor(Object instance, Type editorBaseType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(editorBaseType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedEditor_Internal_Object_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x00067BC8 File Offset: 0x00065DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462894, XrefRangeEnd = 462898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDescriptorCollection GetExtendedEvents(Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedEvents_Internal_EventDescriptorCollection_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x00067C18 File Offset: 0x00065E18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 462953, RefRangeEnd = 462955, XrefRangeStart = 462898, XrefRangeEnd = 462953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDescriptorCollection GetExtendedProperties(Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedProperties_Internal_PropertyDescriptorCollection_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00067C68 File Offset: 0x00065E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462955, XrefRangeEnd = 462994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<IExtenderProvider> GetExtenderProviders(Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtenderProviders_FamOrAssem_Virtual_Il2CppReferenceArray_1_IExtenderProvider_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IExtenderProvider>>(intPtr3) : null;
			}
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00067CB8 File Offset: 0x00065EB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463073, RefRangeEnd = 463074, XrefRangeStart = 462994, XrefRangeEnd = 463073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<IExtenderProvider> GetExtenders(ICollection components, Object instance, IDictionary cache)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(components);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtenders_Private_Static_Il2CppReferenceArray_1_IExtenderProvider_ICollection_Object_IDictionary_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IExtenderProvider>>(intPtr3) : null;
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x00067D20 File Offset: 0x00065F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463074, XrefRangeEnd = 463080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetExtendedPropertyOwner(Object instance, PropertyDescriptor pd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedPropertyOwner_Internal_Object_Object_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00067D84 File Offset: 0x00065F84
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ICustomTypeDescriptor GetExtendedTypeDescriptor(Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedTypeDescriptor_Public_Virtual_ICustomTypeDescriptor_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICustomTypeDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00067DD4 File Offset: 0x00065FD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 463083, RefRangeEnd = 463085, XrefRangeStart = 463080, XrefRangeEnd = 463083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDescriptorCollection GetProperties(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetProperties_Internal_PropertyDescriptorCollection_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00067E24 File Offset: 0x00066024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463085, XrefRangeEnd = 463089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetPropertyOwner(Type type, Object instance, PropertyDescriptor pd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetPropertyOwner_Internal_Object_Type_Object_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00067E98 File Offset: 0x00066098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetReflectionType(Type objectType, Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetReflectionType_Public_Virtual_Type_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00067EFC File Offset: 0x000660FC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 463112, RefRangeEnd = 463127, XrefRangeStart = 463089, XrefRangeEnd = 463112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(Type type, bool createIfNeeded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createIfNeeded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetTypeData_Private_ReflectedTypeData_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReflectTypeDescriptionProvider.ReflectedTypeData>(intPtr3) : null;
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x00067F5C File Offset: 0x0006615C
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetTypeDescriptor_Public_Virtual_ICustomTypeDescriptor_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICustomTypeDescriptor>(intPtr3) : null;
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00067FC0 File Offset: 0x000661C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463143, RefRangeEnd = 463144, XrefRangeStart = 463127, XrefRangeEnd = 463143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetTypeFromName(string typeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_GetTypeFromName_Private_Static_Type_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x00068004 File Offset: 0x00066204
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463145, RefRangeEnd = 463146, XrefRangeStart = 463144, XrefRangeEnd = 463145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPopulated(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_IsPopulated_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x00068054 File Offset: 0x00066254
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 463205, RefRangeEnd = 463207, XrefRangeStart = 463146, XrefRangeEnd = 463205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> ReflectGetAttributes(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_ReflectGetAttributes_Private_Static_Il2CppReferenceArray_1_Attribute_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
			}
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00068098 File Offset: 0x00066298
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 463266, RefRangeEnd = 463270, XrefRangeStart = 463207, XrefRangeEnd = 463266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> ReflectGetAttributes(MemberInfo member)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_ReflectGetAttributes_Internal_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
			}
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x000680DC File Offset: 0x000662DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463345, RefRangeEnd = 463346, XrefRangeStart = 463270, XrefRangeEnd = 463345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<EventDescriptor> ReflectGetEvents(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_ReflectGetEvents_Private_Static_Il2CppReferenceArray_1_EventDescriptor_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EventDescriptor>>(intPtr3) : null;
			}
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x00068120 File Offset: 0x00066320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463510, RefRangeEnd = 463511, XrefRangeStart = 463346, XrefRangeEnd = 463510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<PropertyDescriptor> ReflectGetExtendedProperties(IExtenderProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_ReflectGetExtendedProperties_Private_Static_Il2CppReferenceArray_1_PropertyDescriptor_IExtenderProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PropertyDescriptor>>(intPtr3) : null;
			}
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00068164 File Offset: 0x00066364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463576, RefRangeEnd = 463577, XrefRangeStart = 463511, XrefRangeEnd = 463576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<PropertyDescriptor> ReflectGetProperties(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_ReflectGetProperties_Private_Static_Il2CppReferenceArray_1_PropertyDescriptor_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PropertyDescriptor>>(intPtr3) : null;
			}
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x000681A8 File Offset: 0x000663A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463584, RefRangeEnd = 463585, XrefRangeStart = 463577, XrefRangeEnd = 463584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_Refresh_Internal_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x000681EC File Offset: 0x000663EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463674, RefRangeEnd = 463675, XrefRangeStart = 463585, XrefRangeEnd = 463674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object SearchIntrinsicTable(Hashtable table, Type callingType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callingType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.NativeMethodInfoPtr_SearchIntrinsicTable_Private_Static_Object_Hashtable_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00008E0B File Offset: 0x0000700B
		public ReflectTypeDescriptionProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x00068244 File Offset: 0x00066444
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x00008E14 File Offset: 0x00007014
		public unsafe Hashtable _typeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__typeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__typeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x00068274 File Offset: 0x00066474
		// (set) Token: 0x060013A5 RID: 5029 RVA: 0x00008E33 File Offset: 0x00007033
		public unsafe static Il2CppReferenceArray<Type> _typeConstructor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__typeConstructor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__typeConstructor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x0006829C File Offset: 0x0006649C
		// (set) Token: 0x060013A7 RID: 5031 RVA: 0x00008E45 File Offset: 0x00007045
		public unsafe static Hashtable _editorTables
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__editorTables, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__editorTables, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x000682C4 File Offset: 0x000664C4
		// (set) Token: 0x060013A9 RID: 5033 RVA: 0x00008E57 File Offset: 0x00007057
		public unsafe static Hashtable _intrinsicTypeConverters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__intrinsicTypeConverters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__intrinsicTypeConverters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x000682EC File Offset: 0x000664EC
		// (set) Token: 0x060013AB RID: 5035 RVA: 0x00008E69 File Offset: 0x00007069
		public unsafe static Object _intrinsicReferenceKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__intrinsicReferenceKey, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__intrinsicReferenceKey, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x00068314 File Offset: 0x00066514
		// (set) Token: 0x060013AD RID: 5037 RVA: 0x00008E7B File Offset: 0x0000707B
		public unsafe static Object _intrinsicNullableKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__intrinsicNullableKey, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__intrinsicNullableKey, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x0006833C File Offset: 0x0006653C
		// (set) Token: 0x060013AF RID: 5039 RVA: 0x00008E8D File Offset: 0x0000708D
		public unsafe static Object _dictionaryKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__dictionaryKey, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__dictionaryKey, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x00068364 File Offset: 0x00066564
		// (set) Token: 0x060013B1 RID: 5041 RVA: 0x00008E9F File Offset: 0x0000709F
		public unsafe static Hashtable _propertyCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__propertyCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__propertyCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x0006838C File Offset: 0x0006658C
		// (set) Token: 0x060013B3 RID: 5043 RVA: 0x00008EB1 File Offset: 0x000070B1
		public unsafe static Hashtable _eventCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__eventCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__eventCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x000683B4 File Offset: 0x000665B4
		// (set) Token: 0x060013B5 RID: 5045 RVA: 0x00008EC3 File Offset: 0x000070C3
		public unsafe static Hashtable _attributeCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__attributeCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__attributeCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x000683DC File Offset: 0x000665DC
		// (set) Token: 0x060013B7 RID: 5047 RVA: 0x00008ED5 File Offset: 0x000070D5
		public unsafe static Hashtable _extendedPropertyCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__extendedPropertyCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__extendedPropertyCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x00068404 File Offset: 0x00066604
		// (set) Token: 0x060013B9 RID: 5049 RVA: 0x00008EE7 File Offset: 0x000070E7
		public unsafe static Guid _extenderProviderKey
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__extenderProviderKey, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__extenderProviderKey, (void*)(&value));
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x00068420 File Offset: 0x00066620
		// (set) Token: 0x060013BB RID: 5051 RVA: 0x00008EF5 File Offset: 0x000070F5
		public unsafe static Guid _extenderPropertiesKey
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__extenderPropertiesKey, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__extenderPropertiesKey, (void*)(&value));
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x0006843C File Offset: 0x0006663C
		// (set) Token: 0x060013BD RID: 5053 RVA: 0x00008F03 File Offset: 0x00007103
		public unsafe static Guid _extenderProviderPropertiesKey
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__extenderProviderPropertiesKey, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__extenderProviderPropertiesKey, (void*)(&value));
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x00068458 File Offset: 0x00066658
		// (set) Token: 0x060013BF RID: 5055 RVA: 0x00008F11 File Offset: 0x00007111
		public unsafe static Il2CppReferenceArray<Type> _skipInterfaceAttributeList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__skipInterfaceAttributeList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__skipInterfaceAttributeList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x00068480 File Offset: 0x00066680
		// (set) Token: 0x060013C1 RID: 5057 RVA: 0x00008F23 File Offset: 0x00007123
		public unsafe static Object _internalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__internalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectTypeDescriptionProvider.NativeFieldInfoPtr__internalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeFieldInfoPtr__typeData;

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeFieldInfoPtr__typeConstructor;

		// Token: 0x04000F54 RID: 3924
		private static readonly IntPtr NativeFieldInfoPtr__editorTables;

		// Token: 0x04000F55 RID: 3925
		private static readonly IntPtr NativeFieldInfoPtr__intrinsicTypeConverters;

		// Token: 0x04000F56 RID: 3926
		private static readonly IntPtr NativeFieldInfoPtr__intrinsicReferenceKey;

		// Token: 0x04000F57 RID: 3927
		private static readonly IntPtr NativeFieldInfoPtr__intrinsicNullableKey;

		// Token: 0x04000F58 RID: 3928
		private static readonly IntPtr NativeFieldInfoPtr__dictionaryKey;

		// Token: 0x04000F59 RID: 3929
		private static readonly IntPtr NativeFieldInfoPtr__propertyCache;

		// Token: 0x04000F5A RID: 3930
		private static readonly IntPtr NativeFieldInfoPtr__eventCache;

		// Token: 0x04000F5B RID: 3931
		private static readonly IntPtr NativeFieldInfoPtr__attributeCache;

		// Token: 0x04000F5C RID: 3932
		private static readonly IntPtr NativeFieldInfoPtr__extendedPropertyCache;

		// Token: 0x04000F5D RID: 3933
		private static readonly IntPtr NativeFieldInfoPtr__extenderProviderKey;

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeFieldInfoPtr__extenderPropertiesKey;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeFieldInfoPtr__extenderProviderPropertiesKey;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeFieldInfoPtr__skipInterfaceAttributeList;

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeFieldInfoPtr__internalSyncObject;

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeMethodInfoPtr_get_IntrinsicTypeConverters_Private_Static_get_Hashtable_0;

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_Object_IServiceProvider_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000F65 RID: 3941
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Private_Static_Object_Type_Type_0;

		// Token: 0x04000F66 RID: 3942
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Internal_AttributeCollection_Type_0;

		// Token: 0x04000F67 RID: 3943
		private static readonly IntPtr NativeMethodInfoPtr_GetCache_Public_Virtual_IDictionary_Object_0;

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeMethodInfoPtr_GetClassName_Internal_String_Type_0;

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentName_Internal_String_Type_Object_0;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeMethodInfoPtr_GetConverter_Internal_TypeConverter_Type_Object_0;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultEvent_Internal_EventDescriptor_Type_Object_0;

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultProperty_Internal_PropertyDescriptor_Type_Object_0;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeMethodInfoPtr_GetEditor_Internal_Object_Type_Object_Type_0;

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeMethodInfoPtr_GetEditorTable_Private_Static_Hashtable_Type_0;

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeMethodInfoPtr_GetEvents_Internal_EventDescriptorCollection_Type_0;

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeMethodInfoPtr_GetExtendedAttributes_Internal_AttributeCollection_Object_0;

		// Token: 0x04000F71 RID: 3953
		private static readonly IntPtr NativeMethodInfoPtr_GetExtendedClassName_Internal_String_Object_0;

		// Token: 0x04000F72 RID: 3954
		private static readonly IntPtr NativeMethodInfoPtr_GetExtendedComponentName_Internal_String_Object_0;

		// Token: 0x04000F73 RID: 3955
		private static readonly IntPtr NativeMethodInfoPtr_GetExtendedConverter_Internal_TypeConverter_Object_0;

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeMethodInfoPtr_GetExtendedDefaultEvent_Internal_EventDescriptor_Object_0;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeMethodInfoPtr_GetExtendedDefaultProperty_Internal_PropertyDescriptor_Object_0;

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeMethodInfoPtr_GetExtendedEditor_Internal_Object_Object_Type_0;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeMethodInfoPtr_GetExtendedEvents_Internal_EventDescriptorCollection_Object_0;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeMethodInfoPtr_GetExtendedProperties_Internal_PropertyDescriptorCollection_Object_0;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeMethodInfoPtr_GetExtenderProviders_FamOrAssem_Virtual_Il2CppReferenceArray_1_IExtenderProvider_Object_0;

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeMethodInfoPtr_GetExtenders_Private_Static_Il2CppReferenceArray_1_IExtenderProvider_ICollection_Object_IDictionary_0;

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeMethodInfoPtr_GetExtendedPropertyOwner_Internal_Object_Object_PropertyDescriptor_0;

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeMethodInfoPtr_GetExtendedTypeDescriptor_Public_Virtual_ICustomTypeDescriptor_Object_0;

		// Token: 0x04000F7D RID: 3965
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Internal_PropertyDescriptorCollection_Type_0;

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyOwner_Internal_Object_Type_Object_PropertyDescriptor_0;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeMethodInfoPtr_GetReflectionType_Public_Virtual_Type_Type_Object_0;

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeData_Private_ReflectedTypeData_Type_Boolean_0;

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeDescriptor_Public_Virtual_ICustomTypeDescriptor_Type_Object_0;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeFromName_Private_Static_Type_String_0;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeMethodInfoPtr_IsPopulated_Internal_Boolean_Type_0;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeMethodInfoPtr_ReflectGetAttributes_Private_Static_Il2CppReferenceArray_1_Attribute_Type_0;

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeMethodInfoPtr_ReflectGetAttributes_Internal_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_0;

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeMethodInfoPtr_ReflectGetEvents_Private_Static_Il2CppReferenceArray_1_EventDescriptor_Type_0;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeMethodInfoPtr_ReflectGetExtendedProperties_Private_Static_Il2CppReferenceArray_1_PropertyDescriptor_IExtenderProvider_0;

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeMethodInfoPtr_ReflectGetProperties_Private_Static_Il2CppReferenceArray_1_PropertyDescriptor_Type_0;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Internal_Void_Type_0;

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeMethodInfoPtr_SearchIntrinsicTable_Private_Static_Object_Hashtable_Type_0;

		// Token: 0x020002DF RID: 735
		public class ReflectedTypeData : Object
		{
			// Token: 0x06002C3B RID: 11323 RVA: 0x000C2DCC File Offset: 0x000C0FCC
			// Note: this type is marked as 'beforefieldinit'.
			static ReflectedTypeData()
			{
				Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectTypeDescriptionProvider>.NativeClassPtr, "ReflectedTypeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr);
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, "_type");
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, "_attributes");
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, "_events");
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, "_properties");
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__converter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, "_converter");
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__editors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, "_editors");
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__editorTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, "_editorTypes");
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__editorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, "_editorCount");
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr__ctor_Internal_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, 100666148);
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_get_IsPopulated_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, 100666149);
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetAttributes_Internal_AttributeCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, 100666150);
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetClassName_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, 100666151);
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetComponentName_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, 100666152);
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetConverter_Internal_TypeConverter_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, 100666153);
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetDefaultEvent_Internal_EventDescriptor_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, 100666154);
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetDefaultProperty_Internal_PropertyDescriptor_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, 100666155);
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetEditor_Internal_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, 100666156);
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetEditorAttribute_Private_Static_EditorAttribute_AttributeCollection_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, 100666157);
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetEvents_Internal_EventDescriptorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, 100666158);
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetProperties_Internal_PropertyDescriptorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, 100666159);
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetTypeFromName_Private_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, 100666160);
				ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_Refresh_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr, 100666161);
			}

			// Token: 0x06002C3C RID: 11324 RVA: 0x000C2FB0 File Offset: 0x000C11B0
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReflectedTypeData(Type type)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectTypeDescriptionProvider.ReflectedTypeData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr__ctor_Internal_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000DE9 RID: 3561
			// (get) Token: 0x06002C3D RID: 11325 RVA: 0x000C2FFC File Offset: 0x000C11FC
			public unsafe bool IsPopulated
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_get_IsPopulated_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C3E RID: 11326 RVA: 0x000C3038 File Offset: 0x000C1238
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 462206, RefRangeEnd = 462207, XrefRangeStart = 462146, XrefRangeEnd = 462206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AttributeCollection GetAttributes()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetAttributes_Internal_AttributeCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeCollection>(intPtr3) : null;
			}

			// Token: 0x06002C3F RID: 11327 RVA: 0x000C3078 File Offset: 0x000C1278
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetClassName(Object instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetClassName_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002C40 RID: 11328 RVA: 0x000C30C0 File Offset: 0x000C12C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462207, XrefRangeEnd = 462220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetComponentName(Object instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetComponentName_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002C41 RID: 11329 RVA: 0x000C3108 File Offset: 0x000C1308
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 462283, RefRangeEnd = 462285, XrefRangeStart = 462220, XrefRangeEnd = 462283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TypeConverter GetConverter(Object instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetConverter_Internal_TypeConverter_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeConverter>(intPtr3) : null;
				}
			}

			// Token: 0x06002C42 RID: 11330 RVA: 0x000C3158 File Offset: 0x000C1358
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 462306, RefRangeEnd = 462307, XrefRangeStart = 462285, XrefRangeEnd = 462306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventDescriptor GetDefaultEvent(Object instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetDefaultEvent_Internal_EventDescriptor_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptor>(intPtr3) : null;
				}
			}

			// Token: 0x06002C43 RID: 11331 RVA: 0x000C31A8 File Offset: 0x000C13A8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 462328, RefRangeEnd = 462329, XrefRangeStart = 462307, XrefRangeEnd = 462328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PropertyDescriptor GetDefaultProperty(Object instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetDefaultProperty_Internal_PropertyDescriptor_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptor>(intPtr3) : null;
				}
			}

			// Token: 0x06002C44 RID: 11332 RVA: 0x000C31F8 File Offset: 0x000C13F8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 462347, RefRangeEnd = 462349, XrefRangeStart = 462329, XrefRangeEnd = 462347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object GetEditor(Object instance, Type editorBaseType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(editorBaseType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetEditor_Internal_Object_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06002C45 RID: 11333 RVA: 0x000C325C File Offset: 0x000C145C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 462372, RefRangeEnd = 462374, XrefRangeStart = 462349, XrefRangeEnd = 462372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static EditorAttribute GetEditorAttribute(AttributeCollection attributes, Type editorBaseType)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(editorBaseType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetEditorAttribute_Private_Static_EditorAttribute_AttributeCollection_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EditorAttribute>(intPtr3) : null;
			}

			// Token: 0x06002C46 RID: 11334 RVA: 0x000C32B4 File Offset: 0x000C14B4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 462426, RefRangeEnd = 462427, XrefRangeStart = 462374, XrefRangeEnd = 462426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventDescriptorCollection GetEvents()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetEvents_Internal_EventDescriptorCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
			}

			// Token: 0x06002C47 RID: 11335 RVA: 0x000C32F4 File Offset: 0x000C14F4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 462484, RefRangeEnd = 462485, XrefRangeStart = 462427, XrefRangeEnd = 462484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PropertyDescriptorCollection GetProperties()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetProperties_Internal_PropertyDescriptorCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
			}

			// Token: 0x06002C48 RID: 11336 RVA: 0x000C3334 File Offset: 0x000C1534
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 462506, RefRangeEnd = 462509, XrefRangeStart = 462485, XrefRangeEnd = 462506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Type GetTypeFromName(string typeName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_GetTypeFromName_Private_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x06002C49 RID: 11337 RVA: 0x000C3384 File Offset: 0x000C1584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462509, XrefRangeEnd = 462515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Refresh()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeMethodInfoPtr_Refresh_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C4A RID: 11338 RVA: 0x00013EF7 File Offset: 0x000120F7
			public ReflectedTypeData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DE1 RID: 3553
			// (get) Token: 0x06002C4B RID: 11339 RVA: 0x000C33B8 File Offset: 0x000C15B8
			// (set) Token: 0x06002C4C RID: 11340 RVA: 0x00013F00 File Offset: 0x00012100
			public unsafe Type _type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DE2 RID: 3554
			// (get) Token: 0x06002C4D RID: 11341 RVA: 0x000C33E8 File Offset: 0x000C15E8
			// (set) Token: 0x06002C4E RID: 11342 RVA: 0x00013F1F File Offset: 0x0001211F
			public unsafe AttributeCollection _attributes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__attributes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeCollection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DE3 RID: 3555
			// (get) Token: 0x06002C4F RID: 11343 RVA: 0x000C3418 File Offset: 0x000C1618
			// (set) Token: 0x06002C50 RID: 11344 RVA: 0x00013F3E File Offset: 0x0001213E
			public unsafe EventDescriptorCollection _events
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__events);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__events), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DE4 RID: 3556
			// (get) Token: 0x06002C51 RID: 11345 RVA: 0x000C3448 File Offset: 0x000C1648
			// (set) Token: 0x06002C52 RID: 11346 RVA: 0x00013F5D File Offset: 0x0001215D
			public unsafe PropertyDescriptorCollection _properties
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__properties);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__properties), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DE5 RID: 3557
			// (get) Token: 0x06002C53 RID: 11347 RVA: 0x000C3478 File Offset: 0x000C1678
			// (set) Token: 0x06002C54 RID: 11348 RVA: 0x00013F7C File Offset: 0x0001217C
			public unsafe TypeConverter _converter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__converter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeConverter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__converter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DE6 RID: 3558
			// (get) Token: 0x06002C55 RID: 11349 RVA: 0x000C34A8 File Offset: 0x000C16A8
			// (set) Token: 0x06002C56 RID: 11350 RVA: 0x00013F9B File Offset: 0x0001219B
			public unsafe Il2CppReferenceArray<Object> _editors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__editors);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__editors), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DE7 RID: 3559
			// (get) Token: 0x06002C57 RID: 11351 RVA: 0x000C34D8 File Offset: 0x000C16D8
			// (set) Token: 0x06002C58 RID: 11352 RVA: 0x00013FBA File Offset: 0x000121BA
			public unsafe Il2CppReferenceArray<Type> _editorTypes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__editorTypes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__editorTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DE8 RID: 3560
			// (get) Token: 0x06002C59 RID: 11353 RVA: 0x000C3508 File Offset: 0x000C1708
			// (set) Token: 0x06002C5A RID: 11354 RVA: 0x00013FD9 File Offset: 0x000121D9
			public unsafe int _editorCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__editorCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectTypeDescriptionProvider.ReflectedTypeData.NativeFieldInfoPtr__editorCount)) = value;
				}
			}

			// Token: 0x040022EF RID: 8943
			private static readonly IntPtr NativeFieldInfoPtr__type;

			// Token: 0x040022F0 RID: 8944
			private static readonly IntPtr NativeFieldInfoPtr__attributes;

			// Token: 0x040022F1 RID: 8945
			private static readonly IntPtr NativeFieldInfoPtr__events;

			// Token: 0x040022F2 RID: 8946
			private static readonly IntPtr NativeFieldInfoPtr__properties;

			// Token: 0x040022F3 RID: 8947
			private static readonly IntPtr NativeFieldInfoPtr__converter;

			// Token: 0x040022F4 RID: 8948
			private static readonly IntPtr NativeFieldInfoPtr__editors;

			// Token: 0x040022F5 RID: 8949
			private static readonly IntPtr NativeFieldInfoPtr__editorTypes;

			// Token: 0x040022F6 RID: 8950
			private static readonly IntPtr NativeFieldInfoPtr__editorCount;

			// Token: 0x040022F7 RID: 8951
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_0;

			// Token: 0x040022F8 RID: 8952
			private static readonly IntPtr NativeMethodInfoPtr_get_IsPopulated_Internal_get_Boolean_0;

			// Token: 0x040022F9 RID: 8953
			private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Internal_AttributeCollection_0;

			// Token: 0x040022FA RID: 8954
			private static readonly IntPtr NativeMethodInfoPtr_GetClassName_Internal_String_Object_0;

			// Token: 0x040022FB RID: 8955
			private static readonly IntPtr NativeMethodInfoPtr_GetComponentName_Internal_String_Object_0;

			// Token: 0x040022FC RID: 8956
			private static readonly IntPtr NativeMethodInfoPtr_GetConverter_Internal_TypeConverter_Object_0;

			// Token: 0x040022FD RID: 8957
			private static readonly IntPtr NativeMethodInfoPtr_GetDefaultEvent_Internal_EventDescriptor_Object_0;

			// Token: 0x040022FE RID: 8958
			private static readonly IntPtr NativeMethodInfoPtr_GetDefaultProperty_Internal_PropertyDescriptor_Object_0;

			// Token: 0x040022FF RID: 8959
			private static readonly IntPtr NativeMethodInfoPtr_GetEditor_Internal_Object_Object_Type_0;

			// Token: 0x04002300 RID: 8960
			private static readonly IntPtr NativeMethodInfoPtr_GetEditorAttribute_Private_Static_EditorAttribute_AttributeCollection_Type_0;

			// Token: 0x04002301 RID: 8961
			private static readonly IntPtr NativeMethodInfoPtr_GetEvents_Internal_EventDescriptorCollection_0;

			// Token: 0x04002302 RID: 8962
			private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Internal_PropertyDescriptorCollection_0;

			// Token: 0x04002303 RID: 8963
			private static readonly IntPtr NativeMethodInfoPtr_GetTypeFromName_Private_Type_String_0;

			// Token: 0x04002304 RID: 8964
			private static readonly IntPtr NativeMethodInfoPtr_Refresh_Internal_Void_0;
		}
	}
}
