using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.ComponentModel.Design;
using Il2CppSystem.Diagnostics;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000146 RID: 326
	public sealed class TypeDescriptor : Object
	{
		// Token: 0x060013F0 RID: 5104 RVA: 0x0006964C File Offset: 0x0006784C
		// Note: this type is marked as 'beforefieldinit'.
		static TypeDescriptor()
		{
			Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "TypeDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr);
			TypeDescriptor.NativeFieldInfoPtr__providerTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "_providerTable");
			TypeDescriptor.NativeFieldInfoPtr__providerTypeTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "_providerTypeTable");
			TypeDescriptor.NativeFieldInfoPtr__defaultProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "_defaultProviders");
			TypeDescriptor.NativeFieldInfoPtr__associationTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "_associationTable");
			TypeDescriptor.NativeFieldInfoPtr__metadataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "_metadataVersion");
			TypeDescriptor.NativeFieldInfoPtr__collisionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "_collisionIndex");
			TypeDescriptor.NativeFieldInfoPtr_TraceDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "TraceDescriptor");
			TypeDescriptor.NativeFieldInfoPtr__pipelineInitializeKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "_pipelineInitializeKeys");
			TypeDescriptor.NativeFieldInfoPtr__pipelineMergeKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "_pipelineMergeKeys");
			TypeDescriptor.NativeFieldInfoPtr__pipelineFilterKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "_pipelineFilterKeys");
			TypeDescriptor.NativeFieldInfoPtr__pipelineAttributeFilterKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "_pipelineAttributeFilterKeys");
			TypeDescriptor.NativeFieldInfoPtr__internalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "_internalSyncObject");
			TypeDescriptor.NativeFieldInfoPtr_Refreshed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "Refreshed");
			TypeDescriptor.NativeMethodInfoPtr_get_ComObjectType_Public_Static_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666220);
			TypeDescriptor.NativeMethodInfoPtr_get_InterfaceType_Public_Static_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666221);
			TypeDescriptor.NativeMethodInfoPtr_get_MetadataVersion_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666222);
			TypeDescriptor.NativeMethodInfoPtr_AddProvider_Public_Static_Void_TypeDescriptionProvider_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666223);
			TypeDescriptor.NativeMethodInfoPtr_CheckDefaultProvider_Private_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666224);
			TypeDescriptor.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_IServiceProvider_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666225);
			TypeDescriptor.NativeMethodInfoPtr_FilterMembers_Private_Static_ArrayList_IList_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666226);
			TypeDescriptor.NativeMethodInfoPtr_GetAssociation_Public_Static_Object_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666227);
			TypeDescriptor.NativeMethodInfoPtr_GetAttributes_Public_Static_AttributeCollection_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666228);
			TypeDescriptor.NativeMethodInfoPtr_GetAttributes_Public_Static_AttributeCollection_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666229);
			TypeDescriptor.NativeMethodInfoPtr_GetAttributes_Public_Static_AttributeCollection_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666230);
			TypeDescriptor.NativeMethodInfoPtr_GetCache_Internal_Static_IDictionary_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666231);
			TypeDescriptor.NativeMethodInfoPtr_GetConverter_Public_Static_TypeConverter_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666232);
			TypeDescriptor.NativeMethodInfoPtr_GetDescriptor_Internal_Static_ICustomTypeDescriptor_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666233);
			TypeDescriptor.NativeMethodInfoPtr_GetDescriptor_Internal_Static_ICustomTypeDescriptor_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666234);
			TypeDescriptor.NativeMethodInfoPtr_GetExtendedDescriptor_Internal_Static_ICustomTypeDescriptor_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666235);
			TypeDescriptor.NativeMethodInfoPtr_GetEvents_Public_Static_EventDescriptorCollection_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666236);
			TypeDescriptor.NativeMethodInfoPtr_GetEvents_Public_Static_EventDescriptorCollection_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666237);
			TypeDescriptor.NativeMethodInfoPtr_GetEvents_Public_Static_EventDescriptorCollection_Object_Il2CppReferenceArray_1_Attribute_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666238);
			TypeDescriptor.NativeMethodInfoPtr_GetExtenderCollisionSuffix_Private_Static_String_MemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666239);
			TypeDescriptor.NativeMethodInfoPtr_GetNodeForBaseType_Private_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666240);
			TypeDescriptor.NativeMethodInfoPtr_GetProperties_Public_Static_PropertyDescriptorCollection_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666241);
			TypeDescriptor.NativeMethodInfoPtr_GetProperties_Public_Static_PropertyDescriptorCollection_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666242);
			TypeDescriptor.NativeMethodInfoPtr_GetProperties_Public_Static_PropertyDescriptorCollection_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666243);
			TypeDescriptor.NativeMethodInfoPtr_GetProperties_Public_Static_PropertyDescriptorCollection_Object_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666244);
			TypeDescriptor.NativeMethodInfoPtr_GetProperties_Public_Static_PropertyDescriptorCollection_Object_Il2CppReferenceArray_1_Attribute_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666245);
			TypeDescriptor.NativeMethodInfoPtr_GetPropertiesImpl_Private_Static_PropertyDescriptorCollection_Object_Il2CppReferenceArray_1_Attribute_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666246);
			TypeDescriptor.NativeMethodInfoPtr_GetProviderRecursive_Internal_Static_TypeDescriptionProvider_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666247);
			TypeDescriptor.NativeMethodInfoPtr_GetReflectionType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666248);
			TypeDescriptor.NativeMethodInfoPtr_NodeFor_Private_Static_TypeDescriptionNode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666249);
			TypeDescriptor.NativeMethodInfoPtr_NodeFor_Private_Static_TypeDescriptionNode_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666250);
			TypeDescriptor.NativeMethodInfoPtr_NodeFor_Private_Static_TypeDescriptionNode_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666251);
			TypeDescriptor.NativeMethodInfoPtr_NodeFor_Private_Static_TypeDescriptionNode_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666252);
			TypeDescriptor.NativeMethodInfoPtr_PipelineAttributeFilter_Private_Static_ICollection_Int32_ICollection_Il2CppReferenceArray_1_Attribute_Object_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666253);
			TypeDescriptor.NativeMethodInfoPtr_PipelineFilter_Private_Static_ICollection_Int32_ICollection_Object_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666254);
			TypeDescriptor.NativeMethodInfoPtr_PipelineInitialize_Private_Static_ICollection_Int32_ICollection_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666255);
			TypeDescriptor.NativeMethodInfoPtr_PipelineMerge_Private_Static_ICollection_Int32_ICollection_ICollection_Object_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666256);
			TypeDescriptor.NativeMethodInfoPtr_RaiseRefresh_Private_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666257);
			TypeDescriptor.NativeMethodInfoPtr_Refresh_Public_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666258);
			TypeDescriptor.NativeMethodInfoPtr_ShouldHideMember_Private_Static_Boolean_MemberDescriptor_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666259);
			TypeDescriptor.NativeMethodInfoPtr_SortDescriptorArray_Public_Static_Void_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, 100666260);
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x00069AB4 File Offset: 0x00067CB4
		public unsafe static Type ComObjectType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464419, XrefRangeEnd = 464425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_get_ComObjectType_Public_Static_get_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x00069AE8 File Offset: 0x00067CE8
		public unsafe static Type InterfaceType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464425, XrefRangeEnd = 464431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_get_InterfaceType_Public_Static_get_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x00069B1C File Offset: 0x00067D1C
		public unsafe static int MetadataVersion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464431, XrefRangeEnd = 464435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_get_MetadataVersion_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00069B4C File Offset: 0x00067D4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 464461, RefRangeEnd = 464462, XrefRangeStart = 464435, XrefRangeEnd = 464461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddProvider(TypeDescriptionProvider provider, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_AddProvider_Public_Static_Void_TypeDescriptionProvider_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00069B94 File Offset: 0x00067D94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 464545, RefRangeEnd = 464547, XrefRangeStart = 464462, XrefRangeEnd = 464545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckDefaultProvider(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_CheckDefaultProvider_Private_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x00069BCC File Offset: 0x00067DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 464571, RefRangeEnd = 464572, XrefRangeStart = 464547, XrefRangeEnd = 464571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstance(IServiceProvider provider, Type objectType, Il2CppReferenceArray<Type> argTypes, Il2CppReferenceArray<Object> args)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_IServiceProvider_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x00069C48 File Offset: 0x00067E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464572, XrefRangeEnd = 464594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArrayList FilterMembers(IList members, Il2CppReferenceArray<Attribute> attributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(members);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_FilterMembers_Private_Static_ArrayList_IList_Il2CppReferenceArray_1_Attribute_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00069CA0 File Offset: 0x00067EA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 464642, RefRangeEnd = 464646, XrefRangeStart = 464594, XrefRangeEnd = 464642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetAssociation(Type type, Object primary)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(primary);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetAssociation_Public_Static_Object_Type_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00069CF8 File Offset: 0x00067EF8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 464663, RefRangeEnd = 464671, XrefRangeStart = 464646, XrefRangeEnd = 464663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeCollection GetAttributes(Type componentType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(componentType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetAttributes_Public_Static_AttributeCollection_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00069D3C File Offset: 0x00067F3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 464675, RefRangeEnd = 464679, XrefRangeStart = 464671, XrefRangeEnd = 464675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeCollection GetAttributes(Object component)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetAttributes_Public_Static_AttributeCollection_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x00069D80 File Offset: 0x00067F80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 464726, RefRangeEnd = 464727, XrefRangeStart = 464679, XrefRangeEnd = 464726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeCollection GetAttributes(Object component, bool noCustomTypeDesc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noCustomTypeDesc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetAttributes_Public_Static_AttributeCollection_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeCollection>(intPtr3) : null;
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x00069DD4 File Offset: 0x00067FD4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 464735, RefRangeEnd = 464741, XrefRangeStart = 464727, XrefRangeEnd = 464735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IDictionary GetCache(Object instance)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetCache_Internal_Static_IDictionary_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00069E18 File Offset: 0x00068018
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 464751, RefRangeEnd = 464759, XrefRangeStart = 464741, XrefRangeEnd = 464751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeConverter GetConverter(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetConverter_Public_Static_TypeConverter_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeConverter>(intPtr3) : null;
			}
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00069E5C File Offset: 0x0006805C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 464777, RefRangeEnd = 464781, XrefRangeStart = 464759, XrefRangeEnd = 464777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICustomTypeDescriptor GetDescriptor(Type type, string typeName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetDescriptor_Internal_Static_ICustomTypeDescriptor_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICustomTypeDescriptor>(intPtr3) : null;
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00069EB4 File Offset: 0x000680B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 464801, RefRangeEnd = 464804, XrefRangeStart = 464781, XrefRangeEnd = 464801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICustomTypeDescriptor GetDescriptor(Object component, bool noCustomTypeDesc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noCustomTypeDesc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetDescriptor_Internal_Static_ICustomTypeDescriptor_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICustomTypeDescriptor>(intPtr3) : null;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00069F08 File Offset: 0x00068108
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 464818, RefRangeEnd = 464824, XrefRangeStart = 464804, XrefRangeEnd = 464818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICustomTypeDescriptor GetExtendedDescriptor(Object component)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetExtendedDescriptor_Internal_Static_ICustomTypeDescriptor_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICustomTypeDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00069F4C File Offset: 0x0006814C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 464841, RefRangeEnd = 464842, XrefRangeStart = 464824, XrefRangeEnd = 464841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventDescriptorCollection GetEvents(Type componentType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(componentType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetEvents_Public_Static_EventDescriptorCollection_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x00069F90 File Offset: 0x00068190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 464846, RefRangeEnd = 464847, XrefRangeStart = 464842, XrefRangeEnd = 464846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventDescriptorCollection GetEvents(Object component)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetEvents_Public_Static_EventDescriptorCollection_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00069FD4 File Offset: 0x000681D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 464898, RefRangeEnd = 464899, XrefRangeStart = 464847, XrefRangeEnd = 464898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventDescriptorCollection GetEvents(Object component, Il2CppReferenceArray<Attribute> attributes, bool noCustomTypeDesc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noCustomTypeDesc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetEvents_Public_Static_EventDescriptorCollection_Object_Il2CppReferenceArray_1_Attribute_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0006A038 File Offset: 0x00068238
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 464933, RefRangeEnd = 464935, XrefRangeStart = 464899, XrefRangeEnd = 464933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetExtenderCollisionSuffix(MemberDescriptor member)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetExtenderCollisionSuffix_Private_Static_String_MemberDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x0006A074 File Offset: 0x00068274
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 464949, RefRangeEnd = 464950, XrefRangeStart = 464935, XrefRangeEnd = 464949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetNodeForBaseType(Type searchType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(searchType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetNodeForBaseType_Private_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x0006A0B8 File Offset: 0x000682B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 464967, RefRangeEnd = 464968, XrefRangeStart = 464950, XrefRangeEnd = 464967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyDescriptorCollection GetProperties(Type componentType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(componentType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetProperties_Public_Static_PropertyDescriptorCollection_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x0006A0FC File Offset: 0x000682FC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 464975, RefRangeEnd = 464981, XrefRangeStart = 464968, XrefRangeEnd = 464975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyDescriptorCollection GetProperties(Object component)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetProperties_Public_Static_PropertyDescriptorCollection_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x0006A140 File Offset: 0x00068340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464981, XrefRangeEnd = 464985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyDescriptorCollection GetProperties(Object component, bool noCustomTypeDesc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noCustomTypeDesc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetProperties_Public_Static_PropertyDescriptorCollection_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x0006A194 File Offset: 0x00068394
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 464992, RefRangeEnd = 464994, XrefRangeStart = 464985, XrefRangeEnd = 464992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyDescriptorCollection GetProperties(Object component, Il2CppReferenceArray<Attribute> attributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetProperties_Public_Static_PropertyDescriptorCollection_Object_Il2CppReferenceArray_1_Attribute_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x0006A1EC File Offset: 0x000683EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464994, XrefRangeEnd = 464998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyDescriptorCollection GetProperties(Object component, Il2CppReferenceArray<Attribute> attributes, bool noCustomTypeDesc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noCustomTypeDesc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetProperties_Public_Static_PropertyDescriptorCollection_Object_Il2CppReferenceArray_1_Attribute_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x0006A250 File Offset: 0x00068450
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 465060, RefRangeEnd = 465065, XrefRangeStart = 464998, XrefRangeEnd = 465060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyDescriptorCollection GetPropertiesImpl(Object component, Il2CppReferenceArray<Attribute> attributes, bool noCustomTypeDesc, bool noAttributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noCustomTypeDesc;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noAttributes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetPropertiesImpl_Private_Static_PropertyDescriptorCollection_Object_Il2CppReferenceArray_1_Attribute_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x0006A2C4 File Offset: 0x000684C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 465069, RefRangeEnd = 465076, XrefRangeStart = 465065, XrefRangeEnd = 465069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeDescriptionProvider GetProviderRecursive(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetProviderRecursive_Internal_Static_TypeDescriptionProvider_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeDescriptionProvider>(intPtr3) : null;
			}
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x0006A308 File Offset: 0x00068508
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 465095, RefRangeEnd = 465097, XrefRangeStart = 465076, XrefRangeEnd = 465095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetReflectionType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_GetReflectionType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x0006A34C File Offset: 0x0006854C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465097, XrefRangeEnd = 465101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeDescriptor.TypeDescriptionNode NodeFor(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_NodeFor_Private_Static_TypeDescriptionNode_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeDescriptor.TypeDescriptionNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x0006A390 File Offset: 0x00068590
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 465169, RefRangeEnd = 465176, XrefRangeStart = 465101, XrefRangeEnd = 465169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeDescriptor.TypeDescriptionNode NodeFor(Type type, bool createDelegator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createDelegator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_NodeFor_Private_Static_TypeDescriptionNode_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeDescriptor.TypeDescriptionNode>(intPtr3) : null;
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x0006A3E4 File Offset: 0x000685E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465176, XrefRangeEnd = 465180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeDescriptor.TypeDescriptionNode NodeFor(Object instance)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_NodeFor_Private_Static_TypeDescriptionNode_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeDescriptor.TypeDescriptionNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x0006A428 File Offset: 0x00068628
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 465211, RefRangeEnd = 465215, XrefRangeStart = 465180, XrefRangeEnd = 465211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeDescriptor.TypeDescriptionNode NodeFor(Object instance, bool createDelegator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createDelegator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_NodeFor_Private_Static_TypeDescriptionNode_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeDescriptor.TypeDescriptionNode>(intPtr3) : null;
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x0006A47C File Offset: 0x0006867C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 465240, RefRangeEnd = 465243, XrefRangeStart = 465215, XrefRangeEnd = 465240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Il2CppReferenceArray<Attribute> filter, Object instance, IDictionary cache)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pipelineType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(members);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_PipelineAttributeFilter_Private_Static_ICollection_Int32_ICollection_Il2CppReferenceArray_1_Attribute_Object_IDictionary_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x0006A508 File Offset: 0x00068708
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 465434, RefRangeEnd = 465440, XrefRangeStart = 465243, XrefRangeEnd = 465434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICollection PipelineFilter(int pipelineType, ICollection members, Object instance, IDictionary cache)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pipelineType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(members);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_PipelineFilter_Private_Static_ICollection_Int32_ICollection_Object_IDictionary_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x0006A580 File Offset: 0x00068780
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 465493, RefRangeEnd = 465496, XrefRangeStart = 465440, XrefRangeEnd = 465493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pipelineType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(members);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_PipelineInitialize_Private_Static_ICollection_Int32_ICollection_IDictionary_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x0006A5E4 File Offset: 0x000687E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 465623, RefRangeEnd = 465629, XrefRangeStart = 465496, XrefRangeEnd = 465623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, Object instance, IDictionary cache)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pipelineType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(primary);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondary);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_PipelineMerge_Private_Static_ICollection_Int32_ICollection_ICollection_Object_IDictionary_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x0006A670 File Offset: 0x00068870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465629, XrefRangeEnd = 465638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseRefresh(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_RaiseRefresh_Private_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x0006A6A8 File Offset: 0x000688A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 465699, RefRangeEnd = 465700, XrefRangeStart = 465638, XrefRangeEnd = 465699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Refresh(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_Refresh_Public_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x0006A6E0 File Offset: 0x000688E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 465701, RefRangeEnd = 465702, XrefRangeStart = 465700, XrefRangeEnd = 465701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldHideMember(MemberDescriptor member, Attribute attribute)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_ShouldHideMember_Private_Static_Boolean_MemberDescriptor_Attribute_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x0006A734 File Offset: 0x00068934
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 465793, RefRangeEnd = 465797, XrefRangeStart = 465702, XrefRangeEnd = 465793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SortDescriptorArray(IList infos)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(infos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.NativeMethodInfoPtr_SortDescriptorArray_Public_Static_Void_IList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x00008F5E File Offset: 0x0000715E
		public TypeDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x0006A76C File Offset: 0x0006896C
		// (set) Token: 0x0600141C RID: 5148 RVA: 0x00008F67 File Offset: 0x00007167
		public unsafe static WeakHashtable _providerTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeDescriptor.NativeFieldInfoPtr__providerTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakHashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeDescriptor.NativeFieldInfoPtr__providerTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x0006A794 File Offset: 0x00068994
		// (set) Token: 0x0600141E RID: 5150 RVA: 0x00008F79 File Offset: 0x00007179
		public unsafe static Hashtable _providerTypeTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeDescriptor.NativeFieldInfoPtr__providerTypeTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeDescriptor.NativeFieldInfoPtr__providerTypeTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x0006A7BC File Offset: 0x000689BC
		// (set) Token: 0x06001420 RID: 5152 RVA: 0x00008F8B File Offset: 0x0000718B
		public unsafe static Hashtable _defaultProviders
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeDescriptor.NativeFieldInfoPtr__defaultProviders, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeDescriptor.NativeFieldInfoPtr__defaultProviders, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x0006A7E4 File Offset: 0x000689E4
		// (set) Token: 0x06001422 RID: 5154 RVA: 0x00008F9D File Offset: 0x0000719D
		public unsafe static WeakHashtable _associationTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeDescriptor.NativeFieldInfoPtr__associationTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakHashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeDescriptor.NativeFieldInfoPtr__associationTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x0006A80C File Offset: 0x00068A0C
		// (set) Token: 0x06001424 RID: 5156 RVA: 0x00008FAF File Offset: 0x000071AF
		public unsafe static int _metadataVersion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TypeDescriptor.NativeFieldInfoPtr__metadataVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeDescriptor.NativeFieldInfoPtr__metadataVersion, (void*)(&value));
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x0006A828 File Offset: 0x00068A28
		// (set) Token: 0x06001426 RID: 5158 RVA: 0x00008FBD File Offset: 0x000071BD
		public unsafe static int _collisionIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TypeDescriptor.NativeFieldInfoPtr__collisionIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeDescriptor.NativeFieldInfoPtr__collisionIndex, (void*)(&value));
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x0006A844 File Offset: 0x00068A44
		// (set) Token: 0x06001428 RID: 5160 RVA: 0x00008FCB File Offset: 0x000071CB
		public unsafe static BooleanSwitch TraceDescriptor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeDescriptor.NativeFieldInfoPtr_TraceDescriptor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BooleanSwitch>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeDescriptor.NativeFieldInfoPtr_TraceDescriptor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x0006A86C File Offset: 0x00068A6C
		// (set) Token: 0x0600142A RID: 5162 RVA: 0x00008FDD File Offset: 0x000071DD
		public unsafe static Il2CppStructArray<Guid> _pipelineInitializeKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeDescriptor.NativeFieldInfoPtr__pipelineInitializeKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Guid>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeDescriptor.NativeFieldInfoPtr__pipelineInitializeKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x0006A894 File Offset: 0x00068A94
		// (set) Token: 0x0600142C RID: 5164 RVA: 0x00008FEF File Offset: 0x000071EF
		public unsafe static Il2CppStructArray<Guid> _pipelineMergeKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeDescriptor.NativeFieldInfoPtr__pipelineMergeKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Guid>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeDescriptor.NativeFieldInfoPtr__pipelineMergeKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x0600142D RID: 5165 RVA: 0x0006A8BC File Offset: 0x00068ABC
		// (set) Token: 0x0600142E RID: 5166 RVA: 0x00009001 File Offset: 0x00007201
		public unsafe static Il2CppStructArray<Guid> _pipelineFilterKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeDescriptor.NativeFieldInfoPtr__pipelineFilterKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Guid>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeDescriptor.NativeFieldInfoPtr__pipelineFilterKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x0006A8E4 File Offset: 0x00068AE4
		// (set) Token: 0x06001430 RID: 5168 RVA: 0x00009013 File Offset: 0x00007213
		public unsafe static Il2CppStructArray<Guid> _pipelineAttributeFilterKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeDescriptor.NativeFieldInfoPtr__pipelineAttributeFilterKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Guid>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeDescriptor.NativeFieldInfoPtr__pipelineAttributeFilterKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x0006A90C File Offset: 0x00068B0C
		// (set) Token: 0x06001432 RID: 5170 RVA: 0x00009025 File Offset: 0x00007225
		public unsafe static Object _internalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeDescriptor.NativeFieldInfoPtr__internalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeDescriptor.NativeFieldInfoPtr__internalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x0006A934 File Offset: 0x00068B34
		// (set) Token: 0x06001434 RID: 5172 RVA: 0x00009037 File Offset: 0x00007237
		public unsafe static RefreshEventHandler Refreshed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeDescriptor.NativeFieldInfoPtr_Refreshed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RefreshEventHandler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeDescriptor.NativeFieldInfoPtr_Refreshed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeFieldInfoPtr__providerTable;

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeFieldInfoPtr__providerTypeTable;

		// Token: 0x04000FB7 RID: 4023
		private static readonly IntPtr NativeFieldInfoPtr__defaultProviders;

		// Token: 0x04000FB8 RID: 4024
		private static readonly IntPtr NativeFieldInfoPtr__associationTable;

		// Token: 0x04000FB9 RID: 4025
		private static readonly IntPtr NativeFieldInfoPtr__metadataVersion;

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeFieldInfoPtr__collisionIndex;

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeFieldInfoPtr_TraceDescriptor;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeFieldInfoPtr__pipelineInitializeKeys;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeFieldInfoPtr__pipelineMergeKeys;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeFieldInfoPtr__pipelineFilterKeys;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeFieldInfoPtr__pipelineAttributeFilterKeys;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeFieldInfoPtr__internalSyncObject;

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeFieldInfoPtr_Refreshed;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeMethodInfoPtr_get_ComObjectType_Public_Static_get_Type_0;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeMethodInfoPtr_get_InterfaceType_Public_Static_get_Type_0;

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeMethodInfoPtr_get_MetadataVersion_Internal_Static_get_Int32_0;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeMethodInfoPtr_AddProvider_Public_Static_Void_TypeDescriptionProvider_Type_0;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeMethodInfoPtr_CheckDefaultProvider_Private_Static_Void_Type_0;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_IServiceProvider_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeMethodInfoPtr_FilterMembers_Private_Static_ArrayList_IList_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeMethodInfoPtr_GetAssociation_Public_Static_Object_Type_Object_0;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Static_AttributeCollection_Type_0;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Static_AttributeCollection_Object_0;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Static_AttributeCollection_Object_Boolean_0;

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeMethodInfoPtr_GetCache_Internal_Static_IDictionary_Object_0;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeMethodInfoPtr_GetConverter_Public_Static_TypeConverter_Type_0;

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptor_Internal_Static_ICustomTypeDescriptor_Type_String_0;

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptor_Internal_Static_ICustomTypeDescriptor_Object_Boolean_0;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeMethodInfoPtr_GetExtendedDescriptor_Internal_Static_ICustomTypeDescriptor_Object_0;

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeMethodInfoPtr_GetEvents_Public_Static_EventDescriptorCollection_Type_0;

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeMethodInfoPtr_GetEvents_Public_Static_EventDescriptorCollection_Object_0;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeMethodInfoPtr_GetEvents_Public_Static_EventDescriptorCollection_Object_Il2CppReferenceArray_1_Attribute_Boolean_0;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeMethodInfoPtr_GetExtenderCollisionSuffix_Private_Static_String_MemberDescriptor_0;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeMethodInfoPtr_GetNodeForBaseType_Private_Static_Type_Type_0;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Static_PropertyDescriptorCollection_Type_0;

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Static_PropertyDescriptorCollection_Object_0;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Static_PropertyDescriptorCollection_Object_Boolean_0;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Static_PropertyDescriptorCollection_Object_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Static_PropertyDescriptorCollection_Object_Il2CppReferenceArray_1_Attribute_Boolean_0;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesImpl_Private_Static_PropertyDescriptorCollection_Object_Il2CppReferenceArray_1_Attribute_Boolean_Boolean_0;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeMethodInfoPtr_GetProviderRecursive_Internal_Static_TypeDescriptionProvider_Type_0;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeMethodInfoPtr_GetReflectionType_Public_Static_Type_Type_0;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeMethodInfoPtr_NodeFor_Private_Static_TypeDescriptionNode_Type_0;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeMethodInfoPtr_NodeFor_Private_Static_TypeDescriptionNode_Type_Boolean_0;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeMethodInfoPtr_NodeFor_Private_Static_TypeDescriptionNode_Object_0;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeMethodInfoPtr_NodeFor_Private_Static_TypeDescriptionNode_Object_Boolean_0;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeMethodInfoPtr_PipelineAttributeFilter_Private_Static_ICollection_Int32_ICollection_Il2CppReferenceArray_1_Attribute_Object_IDictionary_0;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeMethodInfoPtr_PipelineFilter_Private_Static_ICollection_Int32_ICollection_Object_IDictionary_0;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeMethodInfoPtr_PipelineInitialize_Private_Static_ICollection_Int32_ICollection_IDictionary_0;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeMethodInfoPtr_PipelineMerge_Private_Static_ICollection_Int32_ICollection_ICollection_Object_IDictionary_0;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeMethodInfoPtr_RaiseRefresh_Private_Static_Void_Type_0;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Static_Void_Type_0;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeMethodInfoPtr_ShouldHideMember_Private_Static_Boolean_MemberDescriptor_Attribute_0;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeMethodInfoPtr_SortDescriptorArray_Public_Static_Void_IList_0;

		// Token: 0x020002E2 RID: 738
		public sealed class AttributeFilterCacheItem : Object
		{
			// Token: 0x06002C79 RID: 11385 RVA: 0x000C3D80 File Offset: 0x000C1F80
			// Note: this type is marked as 'beforefieldinit'.
			static AttributeFilterCacheItem()
			{
				Il2CppClassPointerStore<TypeDescriptor.AttributeFilterCacheItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "AttributeFilterCacheItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDescriptor.AttributeFilterCacheItem>.NativeClassPtr);
				TypeDescriptor.AttributeFilterCacheItem.NativeFieldInfoPtr__filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor.AttributeFilterCacheItem>.NativeClassPtr, "_filter");
				TypeDescriptor.AttributeFilterCacheItem.NativeFieldInfoPtr_FilteredMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor.AttributeFilterCacheItem>.NativeClassPtr, "FilteredMembers");
				TypeDescriptor.AttributeFilterCacheItem.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Attribute_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.AttributeFilterCacheItem>.NativeClassPtr, 100666262);
				TypeDescriptor.AttributeFilterCacheItem.NativeMethodInfoPtr_IsValid_Internal_Boolean_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.AttributeFilterCacheItem>.NativeClassPtr, 100666263);
			}

			// Token: 0x06002C7A RID: 11386 RVA: 0x000C3DFC File Offset: 0x000C1FFC
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AttributeFilterCacheItem(Il2CppReferenceArray<Attribute> filter, ICollection filteredMembers)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDescriptor.AttributeFilterCacheItem>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filteredMembers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.AttributeFilterCacheItem.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Attribute_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C7B RID: 11387 RVA: 0x000C3E5C File Offset: 0x000C205C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464010, XrefRangeEnd = 464011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsValid(Il2CppReferenceArray<Attribute> filter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.AttributeFilterCacheItem.NativeMethodInfoPtr_IsValid_Internal_Boolean_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C7C RID: 11388 RVA: 0x00014082 File Offset: 0x00012282
			public AttributeFilterCacheItem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DF6 RID: 3574
			// (get) Token: 0x06002C7D RID: 11389 RVA: 0x000C3EAC File Offset: 0x000C20AC
			// (set) Token: 0x06002C7E RID: 11390 RVA: 0x0001408B File Offset: 0x0001228B
			public unsafe Il2CppReferenceArray<Attribute> _filter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.AttributeFilterCacheItem.NativeFieldInfoPtr__filter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.AttributeFilterCacheItem.NativeFieldInfoPtr__filter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DF7 RID: 3575
			// (get) Token: 0x06002C7F RID: 11391 RVA: 0x000C3EDC File Offset: 0x000C20DC
			// (set) Token: 0x06002C80 RID: 11392 RVA: 0x000140AA File Offset: 0x000122AA
			public unsafe ICollection FilteredMembers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.AttributeFilterCacheItem.NativeFieldInfoPtr_FilteredMembers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.AttributeFilterCacheItem.NativeFieldInfoPtr_FilteredMembers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400231B RID: 8987
			private static readonly IntPtr NativeFieldInfoPtr__filter;

			// Token: 0x0400231C RID: 8988
			private static readonly IntPtr NativeFieldInfoPtr_FilteredMembers;

			// Token: 0x0400231D RID: 8989
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Attribute_ICollection_0;

			// Token: 0x0400231E RID: 8990
			private static readonly IntPtr NativeMethodInfoPtr_IsValid_Internal_Boolean_Il2CppReferenceArray_1_Attribute_0;
		}

		// Token: 0x020002E3 RID: 739
		public sealed class FilterCacheItem : Object
		{
			// Token: 0x06002C81 RID: 11393 RVA: 0x000C3F0C File Offset: 0x000C210C
			// Note: this type is marked as 'beforefieldinit'.
			static FilterCacheItem()
			{
				Il2CppClassPointerStore<TypeDescriptor.FilterCacheItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "FilterCacheItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDescriptor.FilterCacheItem>.NativeClassPtr);
				TypeDescriptor.FilterCacheItem.NativeFieldInfoPtr__filterService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor.FilterCacheItem>.NativeClassPtr, "_filterService");
				TypeDescriptor.FilterCacheItem.NativeFieldInfoPtr_FilteredMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor.FilterCacheItem>.NativeClassPtr, "FilteredMembers");
				TypeDescriptor.FilterCacheItem.NativeMethodInfoPtr__ctor_Internal_Void_ITypeDescriptorFilterService_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.FilterCacheItem>.NativeClassPtr, 100666264);
				TypeDescriptor.FilterCacheItem.NativeMethodInfoPtr_IsValid_Internal_Boolean_ITypeDescriptorFilterService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.FilterCacheItem>.NativeClassPtr, 100666265);
			}

			// Token: 0x06002C82 RID: 11394 RVA: 0x000C3F88 File Offset: 0x000C2188
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FilterCacheItem(ITypeDescriptorFilterService filterService, ICollection filteredMembers)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDescriptor.FilterCacheItem>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(filterService);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filteredMembers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.FilterCacheItem.NativeMethodInfoPtr__ctor_Internal_Void_ITypeDescriptorFilterService_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C83 RID: 11395 RVA: 0x000C3FE8 File Offset: 0x000C21E8
			[CallerCount(0)]
			public unsafe bool IsValid(ITypeDescriptorFilterService filterService)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(filterService);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.FilterCacheItem.NativeMethodInfoPtr_IsValid_Internal_Boolean_ITypeDescriptorFilterService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C84 RID: 11396 RVA: 0x000140C9 File Offset: 0x000122C9
			public FilterCacheItem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DF8 RID: 3576
			// (get) Token: 0x06002C85 RID: 11397 RVA: 0x000C4038 File Offset: 0x000C2238
			// (set) Token: 0x06002C86 RID: 11398 RVA: 0x000140D2 File Offset: 0x000122D2
			public unsafe ITypeDescriptorFilterService _filterService
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.FilterCacheItem.NativeFieldInfoPtr__filterService);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITypeDescriptorFilterService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.FilterCacheItem.NativeFieldInfoPtr__filterService), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DF9 RID: 3577
			// (get) Token: 0x06002C87 RID: 11399 RVA: 0x000C4068 File Offset: 0x000C2268
			// (set) Token: 0x06002C88 RID: 11400 RVA: 0x000140F1 File Offset: 0x000122F1
			public unsafe ICollection FilteredMembers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.FilterCacheItem.NativeFieldInfoPtr_FilteredMembers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.FilterCacheItem.NativeFieldInfoPtr_FilteredMembers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400231F RID: 8991
			private static readonly IntPtr NativeFieldInfoPtr__filterService;

			// Token: 0x04002320 RID: 8992
			private static readonly IntPtr NativeFieldInfoPtr_FilteredMembers;

			// Token: 0x04002321 RID: 8993
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ITypeDescriptorFilterService_ICollection_0;

			// Token: 0x04002322 RID: 8994
			private static readonly IntPtr NativeMethodInfoPtr_IsValid_Internal_Boolean_ITypeDescriptorFilterService_0;
		}

		// Token: 0x020002E4 RID: 740
		public class IUnimplemented : Il2CppObjectBase
		{
			// Token: 0x06002C89 RID: 11401 RVA: 0x00014110 File Offset: 0x00012310
			// Note: this type is marked as 'beforefieldinit'.
			static IUnimplemented()
			{
				Il2CppClassPointerStore<TypeDescriptor.IUnimplemented>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "IUnimplemented");
			}

			// Token: 0x06002C8A RID: 11402 RVA: 0x00014126 File Offset: 0x00012326
			public IUnimplemented(IntPtr pointer)
				: base(pointer)
			{
			}
		}

		// Token: 0x020002E5 RID: 741
		public sealed class MemberDescriptorComparer : Object
		{
			// Token: 0x06002C8B RID: 11403 RVA: 0x000C4098 File Offset: 0x000C2298
			// Note: this type is marked as 'beforefieldinit'.
			static MemberDescriptorComparer()
			{
				Il2CppClassPointerStore<TypeDescriptor.MemberDescriptorComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "MemberDescriptorComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDescriptor.MemberDescriptorComparer>.NativeClassPtr);
				TypeDescriptor.MemberDescriptorComparer.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor.MemberDescriptorComparer>.NativeClassPtr, "Instance");
				TypeDescriptor.MemberDescriptorComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.MemberDescriptorComparer>.NativeClassPtr, 100666266);
				TypeDescriptor.MemberDescriptorComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.MemberDescriptorComparer>.NativeClassPtr, 100666267);
			}

			// Token: 0x06002C8C RID: 11404 RVA: 0x000C4100 File Offset: 0x000C2300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464011, XrefRangeEnd = 464019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Compare(Object left, Object right)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.MemberDescriptorComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002C8D RID: 11405 RVA: 0x000C4160 File Offset: 0x000C2360
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MemberDescriptorComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDescriptor.MemberDescriptorComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.MemberDescriptorComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C8E RID: 11406 RVA: 0x0001412F File Offset: 0x0001232F
			public MemberDescriptorComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DFA RID: 3578
			// (get) Token: 0x06002C8F RID: 11407 RVA: 0x000C419C File Offset: 0x000C239C
			// (set) Token: 0x06002C90 RID: 11408 RVA: 0x00014138 File Offset: 0x00012338
			public unsafe static TypeDescriptor.MemberDescriptorComparer Instance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TypeDescriptor.MemberDescriptorComparer.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeDescriptor.MemberDescriptorComparer>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TypeDescriptor.MemberDescriptorComparer.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002323 RID: 8995
			private static readonly IntPtr NativeFieldInfoPtr_Instance;

			// Token: 0x04002324 RID: 8996
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;

			// Token: 0x04002325 RID: 8997
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002E6 RID: 742
		public sealed class MergedTypeDescriptor : Object
		{
			// Token: 0x06002C91 RID: 11409 RVA: 0x000C41C4 File Offset: 0x000C23C4
			// Note: this type is marked as 'beforefieldinit'.
			static MergedTypeDescriptor()
			{
				Il2CppClassPointerStore<TypeDescriptor.MergedTypeDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "MergedTypeDescriptor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDescriptor.MergedTypeDescriptor>.NativeClassPtr);
				TypeDescriptor.MergedTypeDescriptor.NativeFieldInfoPtr__primary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor.MergedTypeDescriptor>.NativeClassPtr, "_primary");
				TypeDescriptor.MergedTypeDescriptor.NativeFieldInfoPtr__secondary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor.MergedTypeDescriptor>.NativeClassPtr, "_secondary");
				TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr__ctor_Internal_Void_ICustomTypeDescriptor_ICustomTypeDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.MergedTypeDescriptor>.NativeClassPtr, 100666269);
				TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetAttributes_Private_Virtual_Final_New_AttributeCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.MergedTypeDescriptor>.NativeClassPtr, 100666270);
				TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetClassName_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.MergedTypeDescriptor>.NativeClassPtr, 100666271);
				TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetComponentName_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.MergedTypeDescriptor>.NativeClassPtr, 100666272);
				TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetConverter_Private_Virtual_Final_New_TypeConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.MergedTypeDescriptor>.NativeClassPtr, 100666273);
				TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent_Private_Virtual_Final_New_EventDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.MergedTypeDescriptor>.NativeClassPtr, 100666274);
				TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty_Private_Virtual_Final_New_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.MergedTypeDescriptor>.NativeClassPtr, 100666275);
				TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEditor_Private_Virtual_Final_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.MergedTypeDescriptor>.NativeClassPtr, 100666276);
				TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.MergedTypeDescriptor>.NativeClassPtr, 100666277);
				TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.MergedTypeDescriptor>.NativeClassPtr, 100666278);
				TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.MergedTypeDescriptor>.NativeClassPtr, 100666279);
				TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.MergedTypeDescriptor>.NativeClassPtr, 100666280);
				TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner_Private_Virtual_Final_New_Object_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.MergedTypeDescriptor>.NativeClassPtr, 100666281);
			}

			// Token: 0x06002C92 RID: 11410 RVA: 0x000C431C File Offset: 0x000C251C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MergedTypeDescriptor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDescriptor.MergedTypeDescriptor>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(primary);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondary);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr__ctor_Internal_Void_ICustomTypeDescriptor_ICustomTypeDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C93 RID: 11411 RVA: 0x000C437C File Offset: 0x000C257C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464019, XrefRangeEnd = 464024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AttributeCollection System_ComponentModel_ICustomTypeDescriptor_GetAttributes()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetAttributes_Private_Virtual_Final_New_AttributeCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeCollection>(intPtr3) : null;
			}

			// Token: 0x06002C94 RID: 11412 RVA: 0x000C43BC File Offset: 0x000C25BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464024, XrefRangeEnd = 464029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string System_ComponentModel_ICustomTypeDescriptor_GetClassName()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetClassName_Private_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06002C95 RID: 11413 RVA: 0x000C43F4 File Offset: 0x000C25F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464029, XrefRangeEnd = 464034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string System_ComponentModel_ICustomTypeDescriptor_GetComponentName()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetComponentName_Private_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06002C96 RID: 11414 RVA: 0x000C442C File Offset: 0x000C262C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464034, XrefRangeEnd = 464039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TypeConverter System_ComponentModel_ICustomTypeDescriptor_GetConverter()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetConverter_Private_Virtual_Final_New_TypeConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeConverter>(intPtr3) : null;
			}

			// Token: 0x06002C97 RID: 11415 RVA: 0x000C446C File Offset: 0x000C266C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464039, XrefRangeEnd = 464044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventDescriptor System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent_Private_Virtual_Final_New_EventDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptor>(intPtr3) : null;
			}

			// Token: 0x06002C98 RID: 11416 RVA: 0x000C44AC File Offset: 0x000C26AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464044, XrefRangeEnd = 464049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PropertyDescriptor System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty_Private_Virtual_Final_New_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptor>(intPtr3) : null;
			}

			// Token: 0x06002C99 RID: 11417 RVA: 0x000C44EC File Offset: 0x000C26EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464049, XrefRangeEnd = 464058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object System_ComponentModel_ICustomTypeDescriptor_GetEditor(Type editorBaseType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(editorBaseType);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEditor_Private_Virtual_Final_New_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C9A RID: 11418 RVA: 0x000C453C File Offset: 0x000C273C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464058, XrefRangeEnd = 464063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetEvents()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
			}

			// Token: 0x06002C9B RID: 11419 RVA: 0x000C457C File Offset: 0x000C277C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464063, XrefRangeEnd = 464068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetEvents(Il2CppReferenceArray<Attribute> attributes)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
				}
			}

			// Token: 0x06002C9C RID: 11420 RVA: 0x000C45CC File Offset: 0x000C27CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464068, XrefRangeEnd = 464073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PropertyDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetProperties()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
			}

			// Token: 0x06002C9D RID: 11421 RVA: 0x000C460C File Offset: 0x000C280C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464073, XrefRangeEnd = 464078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PropertyDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetProperties(Il2CppReferenceArray<Attribute> attributes)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
				}
			}

			// Token: 0x06002C9E RID: 11422 RVA: 0x000C465C File Offset: 0x000C285C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464078, XrefRangeEnd = 464083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner(PropertyDescriptor pd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pd);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.MergedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner_Private_Virtual_Final_New_Object_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C9F RID: 11423 RVA: 0x0001414A File Offset: 0x0001234A
			public MergedTypeDescriptor(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DFB RID: 3579
			// (get) Token: 0x06002CA0 RID: 11424 RVA: 0x000C46AC File Offset: 0x000C28AC
			// (set) Token: 0x06002CA1 RID: 11425 RVA: 0x00014153 File Offset: 0x00012353
			public unsafe ICustomTypeDescriptor _primary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.MergedTypeDescriptor.NativeFieldInfoPtr__primary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICustomTypeDescriptor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.MergedTypeDescriptor.NativeFieldInfoPtr__primary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DFC RID: 3580
			// (get) Token: 0x06002CA2 RID: 11426 RVA: 0x000C46DC File Offset: 0x000C28DC
			// (set) Token: 0x06002CA3 RID: 11427 RVA: 0x00014172 File Offset: 0x00012372
			public unsafe ICustomTypeDescriptor _secondary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.MergedTypeDescriptor.NativeFieldInfoPtr__secondary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICustomTypeDescriptor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.MergedTypeDescriptor.NativeFieldInfoPtr__secondary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002326 RID: 8998
			private static readonly IntPtr NativeFieldInfoPtr__primary;

			// Token: 0x04002327 RID: 8999
			private static readonly IntPtr NativeFieldInfoPtr__secondary;

			// Token: 0x04002328 RID: 9000
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ICustomTypeDescriptor_ICustomTypeDescriptor_0;

			// Token: 0x04002329 RID: 9001
			private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetAttributes_Private_Virtual_Final_New_AttributeCollection_0;

			// Token: 0x0400232A RID: 9002
			private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetClassName_Private_Virtual_Final_New_String_0;

			// Token: 0x0400232B RID: 9003
			private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetComponentName_Private_Virtual_Final_New_String_0;

			// Token: 0x0400232C RID: 9004
			private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetConverter_Private_Virtual_Final_New_TypeConverter_0;

			// Token: 0x0400232D RID: 9005
			private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent_Private_Virtual_Final_New_EventDescriptor_0;

			// Token: 0x0400232E RID: 9006
			private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty_Private_Virtual_Final_New_PropertyDescriptor_0;

			// Token: 0x0400232F RID: 9007
			private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEditor_Private_Virtual_Final_New_Object_Type_0;

			// Token: 0x04002330 RID: 9008
			private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_0;

			// Token: 0x04002331 RID: 9009
			private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0;

			// Token: 0x04002332 RID: 9010
			private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_0;

			// Token: 0x04002333 RID: 9011
			private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0;

			// Token: 0x04002334 RID: 9012
			private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner_Private_Virtual_Final_New_Object_PropertyDescriptor_0;
		}

		// Token: 0x020002E7 RID: 743
		public sealed class TypeDescriptionNode : TypeDescriptionProvider
		{
			// Token: 0x06002CA4 RID: 11428 RVA: 0x000C470C File Offset: 0x000C290C
			// Note: this type is marked as 'beforefieldinit'.
			static TypeDescriptionNode()
			{
				Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "TypeDescriptionNode");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode>.NativeClassPtr);
				TypeDescriptor.TypeDescriptionNode.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode>.NativeClassPtr, "Next");
				TypeDescriptor.TypeDescriptionNode.NativeFieldInfoPtr_Provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode>.NativeClassPtr, "Provider");
				TypeDescriptor.TypeDescriptionNode.NativeMethodInfoPtr__ctor_Internal_Void_TypeDescriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode>.NativeClassPtr, 100666282);
				TypeDescriptor.TypeDescriptionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_Object_IServiceProvider_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode>.NativeClassPtr, 100666283);
				TypeDescriptor.TypeDescriptionNode.NativeMethodInfoPtr_GetCache_Public_Virtual_IDictionary_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode>.NativeClassPtr, 100666284);
				TypeDescriptor.TypeDescriptionNode.NativeMethodInfoPtr_GetExtendedTypeDescriptor_Public_Virtual_ICustomTypeDescriptor_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode>.NativeClassPtr, 100666285);
				TypeDescriptor.TypeDescriptionNode.NativeMethodInfoPtr_GetExtenderProviders_FamOrAssem_Virtual_Il2CppReferenceArray_1_IExtenderProvider_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode>.NativeClassPtr, 100666286);
				TypeDescriptor.TypeDescriptionNode.NativeMethodInfoPtr_GetReflectionType_Public_Virtual_Type_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode>.NativeClassPtr, 100666287);
				TypeDescriptor.TypeDescriptionNode.NativeMethodInfoPtr_GetTypeDescriptor_Public_Virtual_ICustomTypeDescriptor_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode>.NativeClassPtr, 100666288);
			}

			// Token: 0x06002CA5 RID: 11429 RVA: 0x000C47EC File Offset: 0x000C29EC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 464354, RefRangeEnd = 464355, XrefRangeStart = 464351, XrefRangeEnd = 464354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TypeDescriptionNode(TypeDescriptionProvider provider)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.NativeMethodInfoPtr__ctor_Internal_Void_TypeDescriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002CA6 RID: 11430 RVA: 0x000C4838 File Offset: 0x000C2A38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464355, XrefRangeEnd = 464379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_Object_IServiceProvider_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06002CA7 RID: 11431 RVA: 0x000C48C0 File Offset: 0x000C2AC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464379, XrefRangeEnd = 464386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IDictionary GetCache(Object instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.NativeMethodInfoPtr_GetCache_Public_Virtual_IDictionary_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
				}
			}

			// Token: 0x06002CA8 RID: 11432 RVA: 0x000C4910 File Offset: 0x000C2B10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464386, XrefRangeEnd = 464391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override ICustomTypeDescriptor GetExtendedTypeDescriptor(Object instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.NativeMethodInfoPtr_GetExtendedTypeDescriptor_Public_Virtual_ICustomTypeDescriptor_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICustomTypeDescriptor>(intPtr3) : null;
				}
			}

			// Token: 0x06002CA9 RID: 11433 RVA: 0x000C4960 File Offset: 0x000C2B60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464391, XrefRangeEnd = 464398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Il2CppReferenceArray<IExtenderProvider> GetExtenderProviders(Object instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.NativeMethodInfoPtr_GetExtenderProviders_FamOrAssem_Virtual_Il2CppReferenceArray_1_IExtenderProvider_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IExtenderProvider>>(intPtr3) : null;
				}
			}

			// Token: 0x06002CAA RID: 11434 RVA: 0x000C49B0 File Offset: 0x000C2BB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464398, XrefRangeEnd = 464409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.NativeMethodInfoPtr_GetReflectionType_Public_Virtual_Type_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}

			// Token: 0x06002CAB RID: 11435 RVA: 0x000C4A14 File Offset: 0x000C2C14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464409, XrefRangeEnd = 464419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.NativeMethodInfoPtr_GetTypeDescriptor_Public_Virtual_ICustomTypeDescriptor_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICustomTypeDescriptor>(intPtr3) : null;
			}

			// Token: 0x06002CAC RID: 11436 RVA: 0x00014191 File Offset: 0x00012391
			public TypeDescriptionNode(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DFD RID: 3581
			// (get) Token: 0x06002CAD RID: 11437 RVA: 0x000C4A78 File Offset: 0x000C2C78
			// (set) Token: 0x06002CAE RID: 11438 RVA: 0x0001419A File Offset: 0x0001239A
			public unsafe TypeDescriptor.TypeDescriptionNode Next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.TypeDescriptionNode.NativeFieldInfoPtr_Next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeDescriptor.TypeDescriptionNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.TypeDescriptionNode.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DFE RID: 3582
			// (get) Token: 0x06002CAF RID: 11439 RVA: 0x000C4AA8 File Offset: 0x000C2CA8
			// (set) Token: 0x06002CB0 RID: 11440 RVA: 0x000141B9 File Offset: 0x000123B9
			public unsafe TypeDescriptionProvider Provider
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.TypeDescriptionNode.NativeFieldInfoPtr_Provider);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeDescriptionProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.TypeDescriptionNode.NativeFieldInfoPtr_Provider), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002335 RID: 9013
			private static readonly IntPtr NativeFieldInfoPtr_Next;

			// Token: 0x04002336 RID: 9014
			private static readonly IntPtr NativeFieldInfoPtr_Provider;

			// Token: 0x04002337 RID: 9015
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TypeDescriptionProvider_0;

			// Token: 0x04002338 RID: 9016
			private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_Object_IServiceProvider_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0;

			// Token: 0x04002339 RID: 9017
			private static readonly IntPtr NativeMethodInfoPtr_GetCache_Public_Virtual_IDictionary_Object_0;

			// Token: 0x0400233A RID: 9018
			private static readonly IntPtr NativeMethodInfoPtr_GetExtendedTypeDescriptor_Public_Virtual_ICustomTypeDescriptor_Object_0;

			// Token: 0x0400233B RID: 9019
			private static readonly IntPtr NativeMethodInfoPtr_GetExtenderProviders_FamOrAssem_Virtual_Il2CppReferenceArray_1_IExtenderProvider_Object_0;

			// Token: 0x0400233C RID: 9020
			private static readonly IntPtr NativeMethodInfoPtr_GetReflectionType_Public_Virtual_Type_Type_Object_0;

			// Token: 0x0400233D RID: 9021
			private static readonly IntPtr NativeMethodInfoPtr_GetTypeDescriptor_Public_Virtual_ICustomTypeDescriptor_Type_Object_0;

			// Token: 0x020003B8 RID: 952
			public sealed class DefaultExtendedTypeDescriptor : ValueType
			{
				// Token: 0x06003553 RID: 13651 RVA: 0x000DD538 File Offset: 0x000DB738
				// Note: this type is marked as 'beforefieldinit'.
				static DefaultExtendedTypeDescriptor()
				{
					Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode>.NativeClassPtr, "DefaultExtendedTypeDescriptor");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor>.NativeClassPtr);
					TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeFieldInfoPtr__node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor>.NativeClassPtr, "_node");
					TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor>.NativeClassPtr, "_instance");
					TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr__ctor_Internal_Void_TypeDescriptionNode_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor>.NativeClassPtr, 100666289);
					TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetAttributes_Private_Virtual_Final_New_AttributeCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor>.NativeClassPtr, 100666290);
					TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetClassName_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor>.NativeClassPtr, 100666291);
					TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetComponentName_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor>.NativeClassPtr, 100666292);
					TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetConverter_Private_Virtual_Final_New_TypeConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor>.NativeClassPtr, 100666293);
					TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent_Private_Virtual_Final_New_EventDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor>.NativeClassPtr, 100666294);
					TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty_Private_Virtual_Final_New_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor>.NativeClassPtr, 100666295);
					TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEditor_Private_Virtual_Final_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor>.NativeClassPtr, 100666296);
					TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor>.NativeClassPtr, 100666297);
					TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor>.NativeClassPtr, 100666298);
					TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor>.NativeClassPtr, 100666299);
					TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor>.NativeClassPtr, 100666300);
					TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner_Private_Virtual_Final_New_Object_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor>.NativeClassPtr, 100666301);
				}

				// Token: 0x06003554 RID: 13652 RVA: 0x000DD690 File Offset: 0x000DB890
				[CallerCount(238)]
				[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe DefaultExtendedTypeDescriptor(TypeDescriptor.TypeDescriptionNode node, Object instance)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr__ctor_Internal_Void_TypeDescriptionNode_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003555 RID: 13653 RVA: 0x000DD6F4 File Offset: 0x000DB8F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464083, XrefRangeEnd = 464093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe AttributeCollection System_ComponentModel_ICustomTypeDescriptor_GetAttributes()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetAttributes_Private_Virtual_Final_New_AttributeCollection_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeCollection>(intPtr3) : null;
				}

				// Token: 0x06003556 RID: 13654 RVA: 0x000DD738 File Offset: 0x000DB938
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464093, XrefRangeEnd = 464099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string System_ComponentModel_ICustomTypeDescriptor_GetClassName()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetClassName_Private_Virtual_Final_New_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06003557 RID: 13655 RVA: 0x000DD774 File Offset: 0x000DB974
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464099, XrefRangeEnd = 464128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string System_ComponentModel_ICustomTypeDescriptor_GetComponentName()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetComponentName_Private_Virtual_Final_New_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06003558 RID: 13656 RVA: 0x000DD7B0 File Offset: 0x000DB9B0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464128, XrefRangeEnd = 464135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe TypeConverter System_ComponentModel_ICustomTypeDescriptor_GetConverter()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetConverter_Private_Virtual_Final_New_TypeConverter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeConverter>(intPtr3) : null;
				}

				// Token: 0x06003559 RID: 13657 RVA: 0x000DD7F4 File Offset: 0x000DB9F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464135, XrefRangeEnd = 464164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe EventDescriptor System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent_Private_Virtual_Final_New_EventDescriptor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptor>(intPtr3) : null;
				}

				// Token: 0x0600355A RID: 13658 RVA: 0x000DD838 File Offset: 0x000DBA38
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464164, XrefRangeEnd = 464193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe PropertyDescriptor System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty_Private_Virtual_Final_New_PropertyDescriptor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptor>(intPtr3) : null;
				}

				// Token: 0x0600355B RID: 13659 RVA: 0x000DD87C File Offset: 0x000DBA7C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464193, XrefRangeEnd = 464232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Object System_ComponentModel_ICustomTypeDescriptor_GetEditor(Type editorBaseType)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(editorBaseType);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEditor_Private_Virtual_Final_New_Object_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600355C RID: 13660 RVA: 0x000DD8D4 File Offset: 0x000DBAD4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464232, XrefRangeEnd = 464242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe EventDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetEvents()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
				}

				// Token: 0x0600355D RID: 13661 RVA: 0x000DD918 File Offset: 0x000DBB18
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464242, XrefRangeEnd = 464252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe EventDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetEvents(Il2CppReferenceArray<Attribute> attributes)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
					}
				}

				// Token: 0x0600355E RID: 13662 RVA: 0x000DD970 File Offset: 0x000DBB70
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464252, XrefRangeEnd = 464259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe PropertyDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetProperties()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
				}

				// Token: 0x0600355F RID: 13663 RVA: 0x000DD9B4 File Offset: 0x000DBBB4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464259, XrefRangeEnd = 464266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe PropertyDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetProperties(Il2CppReferenceArray<Attribute> attributes)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
					}
				}

				// Token: 0x06003560 RID: 13664 RVA: 0x000DDA0C File Offset: 0x000DBC0C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464266, XrefRangeEnd = 464271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Object System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner(PropertyDescriptor pd)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(pd);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner_Private_Virtual_Final_New_Object_PropertyDescriptor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06003561 RID: 13665 RVA: 0x0001A38E File Offset: 0x0001858E
				public DefaultExtendedTypeDescriptor(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06003562 RID: 13666 RVA: 0x0001A397 File Offset: 0x00018597
				public DefaultExtendedTypeDescriptor()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor>.NativeClassPtr))
				{
				}

				// Token: 0x170010B0 RID: 4272
				// (get) Token: 0x06003563 RID: 13667 RVA: 0x000DDA64 File Offset: 0x000DBC64
				// (set) Token: 0x06003564 RID: 13668 RVA: 0x0001A3A9 File Offset: 0x000185A9
				public unsafe TypeDescriptor.TypeDescriptionNode _node
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeFieldInfoPtr__node);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeDescriptor.TypeDescriptionNode>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeFieldInfoPtr__node), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170010B1 RID: 4273
				// (get) Token: 0x06003565 RID: 13669 RVA: 0x000DDA94 File Offset: 0x000DBC94
				// (set) Token: 0x06003566 RID: 13670 RVA: 0x0001A3C8 File Offset: 0x000185C8
				public unsafe Object _instance
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeFieldInfoPtr__instance);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor.NativeFieldInfoPtr__instance), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400284E RID: 10318
				private static readonly IntPtr NativeFieldInfoPtr__node;

				// Token: 0x0400284F RID: 10319
				private static readonly IntPtr NativeFieldInfoPtr__instance;

				// Token: 0x04002850 RID: 10320
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TypeDescriptionNode_Object_0;

				// Token: 0x04002851 RID: 10321
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetAttributes_Private_Virtual_Final_New_AttributeCollection_0;

				// Token: 0x04002852 RID: 10322
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetClassName_Private_Virtual_Final_New_String_0;

				// Token: 0x04002853 RID: 10323
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetComponentName_Private_Virtual_Final_New_String_0;

				// Token: 0x04002854 RID: 10324
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetConverter_Private_Virtual_Final_New_TypeConverter_0;

				// Token: 0x04002855 RID: 10325
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent_Private_Virtual_Final_New_EventDescriptor_0;

				// Token: 0x04002856 RID: 10326
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty_Private_Virtual_Final_New_PropertyDescriptor_0;

				// Token: 0x04002857 RID: 10327
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEditor_Private_Virtual_Final_New_Object_Type_0;

				// Token: 0x04002858 RID: 10328
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_0;

				// Token: 0x04002859 RID: 10329
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0;

				// Token: 0x0400285A RID: 10330
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_0;

				// Token: 0x0400285B RID: 10331
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0;

				// Token: 0x0400285C RID: 10332
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner_Private_Virtual_Final_New_Object_PropertyDescriptor_0;
			}

			// Token: 0x020003B9 RID: 953
			public sealed class DefaultTypeDescriptor : ValueType
			{
				// Token: 0x06003567 RID: 13671 RVA: 0x000DDAC4 File Offset: 0x000DBCC4
				// Note: this type is marked as 'beforefieldinit'.
				static DefaultTypeDescriptor()
				{
					Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode>.NativeClassPtr, "DefaultTypeDescriptor");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr);
					TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeFieldInfoPtr__node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr, "_node");
					TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeFieldInfoPtr__objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr, "_objectType");
					TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr, "_instance");
					TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr__ctor_Internal_Void_TypeDescriptionNode_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr, 100666302);
					TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetAttributes_Private_Virtual_Final_New_AttributeCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr, 100666303);
					TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetClassName_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr, 100666304);
					TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetComponentName_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr, 100666305);
					TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetConverter_Private_Virtual_Final_New_TypeConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr, 100666306);
					TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent_Private_Virtual_Final_New_EventDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr, 100666307);
					TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty_Private_Virtual_Final_New_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr, 100666308);
					TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEditor_Private_Virtual_Final_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr, 100666309);
					TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr, 100666310);
					TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr, 100666311);
					TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr, 100666312);
					TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr, 100666313);
					TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner_Private_Virtual_Final_New_Object_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr, 100666314);
				}

				// Token: 0x06003568 RID: 13672 RVA: 0x000DDC30 File Offset: 0x000DBE30
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 338072, RefRangeEnd = 338082, XrefRangeStart = 338072, XrefRangeEnd = 338082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe DefaultTypeDescriptor(TypeDescriptor.TypeDescriptionNode node, Type objectType, Object instance)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr__ctor_Internal_Void_TypeDescriptionNode_Type_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003569 RID: 13673 RVA: 0x000DDCA4 File Offset: 0x000DBEA4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464271, XrefRangeEnd = 464278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe AttributeCollection System_ComponentModel_ICustomTypeDescriptor_GetAttributes()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetAttributes_Private_Virtual_Final_New_AttributeCollection_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeCollection>(intPtr3) : null;
				}

				// Token: 0x0600356A RID: 13674 RVA: 0x000DDCE8 File Offset: 0x000DBEE8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464278, XrefRangeEnd = 464283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string System_ComponentModel_ICustomTypeDescriptor_GetClassName()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetClassName_Private_Virtual_Final_New_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x0600356B RID: 13675 RVA: 0x000DDD24 File Offset: 0x000DBF24
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464283, XrefRangeEnd = 464289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string System_ComponentModel_ICustomTypeDescriptor_GetComponentName()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetComponentName_Private_Virtual_Final_New_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x0600356C RID: 13676 RVA: 0x000DDD60 File Offset: 0x000DBF60
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464289, XrefRangeEnd = 464296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe TypeConverter System_ComponentModel_ICustomTypeDescriptor_GetConverter()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetConverter_Private_Virtual_Final_New_TypeConverter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeConverter>(intPtr3) : null;
				}

				// Token: 0x0600356D RID: 13677 RVA: 0x000DDDA4 File Offset: 0x000DBFA4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464296, XrefRangeEnd = 464302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe EventDescriptor System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent_Private_Virtual_Final_New_EventDescriptor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptor>(intPtr3) : null;
				}

				// Token: 0x0600356E RID: 13678 RVA: 0x000DDDE8 File Offset: 0x000DBFE8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464302, XrefRangeEnd = 464308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe PropertyDescriptor System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty_Private_Virtual_Final_New_PropertyDescriptor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptor>(intPtr3) : null;
				}

				// Token: 0x0600356F RID: 13679 RVA: 0x000DDE2C File Offset: 0x000DC02C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464308, XrefRangeEnd = 464318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Object System_ComponentModel_ICustomTypeDescriptor_GetEditor(Type editorBaseType)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(editorBaseType);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEditor_Private_Virtual_Final_New_Object_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06003570 RID: 13680 RVA: 0x000DDE84 File Offset: 0x000DC084
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464318, XrefRangeEnd = 464325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe EventDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetEvents()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
				}

				// Token: 0x06003571 RID: 13681 RVA: 0x000DDEC8 File Offset: 0x000DC0C8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464325, XrefRangeEnd = 464332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe EventDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetEvents(Il2CppReferenceArray<Attribute> attributes)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
					}
				}

				// Token: 0x06003572 RID: 13682 RVA: 0x000DDF20 File Offset: 0x000DC120
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464332, XrefRangeEnd = 464339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe PropertyDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetProperties()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
				}

				// Token: 0x06003573 RID: 13683 RVA: 0x000DDF64 File Offset: 0x000DC164
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464339, XrefRangeEnd = 464346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe PropertyDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetProperties(Il2CppReferenceArray<Attribute> attributes)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
					}
				}

				// Token: 0x06003574 RID: 13684 RVA: 0x000DDFBC File Offset: 0x000DC1BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464346, XrefRangeEnd = 464351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Object System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner(PropertyDescriptor pd)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(pd);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner_Private_Virtual_Final_New_Object_PropertyDescriptor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06003575 RID: 13685 RVA: 0x0001A3E7 File Offset: 0x000185E7
				public DefaultTypeDescriptor(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06003576 RID: 13686 RVA: 0x0001A3F0 File Offset: 0x000185F0
				public DefaultTypeDescriptor()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor>.NativeClassPtr))
				{
				}

				// Token: 0x170010B2 RID: 4274
				// (get) Token: 0x06003577 RID: 13687 RVA: 0x000DE014 File Offset: 0x000DC214
				// (set) Token: 0x06003578 RID: 13688 RVA: 0x0001A402 File Offset: 0x00018602
				public unsafe TypeDescriptor.TypeDescriptionNode _node
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeFieldInfoPtr__node);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeDescriptor.TypeDescriptionNode>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeFieldInfoPtr__node), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170010B3 RID: 4275
				// (get) Token: 0x06003579 RID: 13689 RVA: 0x000DE044 File Offset: 0x000DC244
				// (set) Token: 0x0600357A RID: 13690 RVA: 0x0001A421 File Offset: 0x00018621
				public unsafe Type _objectType
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeFieldInfoPtr__objectType);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeFieldInfoPtr__objectType), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170010B4 RID: 4276
				// (get) Token: 0x0600357B RID: 13691 RVA: 0x000DE074 File Offset: 0x000DC274
				// (set) Token: 0x0600357C RID: 13692 RVA: 0x0001A440 File Offset: 0x00018640
				public unsafe Object _instance
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeFieldInfoPtr__instance);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor.NativeFieldInfoPtr__instance), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400285D RID: 10333
				private static readonly IntPtr NativeFieldInfoPtr__node;

				// Token: 0x0400285E RID: 10334
				private static readonly IntPtr NativeFieldInfoPtr__objectType;

				// Token: 0x0400285F RID: 10335
				private static readonly IntPtr NativeFieldInfoPtr__instance;

				// Token: 0x04002860 RID: 10336
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TypeDescriptionNode_Type_Object_0;

				// Token: 0x04002861 RID: 10337
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetAttributes_Private_Virtual_Final_New_AttributeCollection_0;

				// Token: 0x04002862 RID: 10338
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetClassName_Private_Virtual_Final_New_String_0;

				// Token: 0x04002863 RID: 10339
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetComponentName_Private_Virtual_Final_New_String_0;

				// Token: 0x04002864 RID: 10340
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetConverter_Private_Virtual_Final_New_TypeConverter_0;

				// Token: 0x04002865 RID: 10341
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent_Private_Virtual_Final_New_EventDescriptor_0;

				// Token: 0x04002866 RID: 10342
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty_Private_Virtual_Final_New_PropertyDescriptor_0;

				// Token: 0x04002867 RID: 10343
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEditor_Private_Virtual_Final_New_Object_Type_0;

				// Token: 0x04002868 RID: 10344
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_0;

				// Token: 0x04002869 RID: 10345
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0;

				// Token: 0x0400286A RID: 10346
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_0;

				// Token: 0x0400286B RID: 10347
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0;

				// Token: 0x0400286C RID: 10348
				private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner_Private_Virtual_Final_New_Object_PropertyDescriptor_0;
			}
		}

		// Token: 0x020002E8 RID: 744
		public sealed class TypeDescriptorComObject : Object
		{
			// Token: 0x06002CB1 RID: 11441 RVA: 0x000141D8 File Offset: 0x000123D8
			// Note: this type is marked as 'beforefieldinit'.
			static TypeDescriptorComObject()
			{
				Il2CppClassPointerStore<TypeDescriptor.TypeDescriptorComObject>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "TypeDescriptorComObject");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptorComObject>.NativeClassPtr);
			}

			// Token: 0x06002CB2 RID: 11442 RVA: 0x000141F8 File Offset: 0x000123F8
			public TypeDescriptorComObject(IntPtr pointer)
				: base(pointer)
			{
			}
		}

		// Token: 0x020002E9 RID: 745
		public sealed class TypeDescriptorInterface : Object
		{
			// Token: 0x06002CB3 RID: 11443 RVA: 0x00014201 File Offset: 0x00012401
			// Note: this type is marked as 'beforefieldinit'.
			static TypeDescriptorInterface()
			{
				Il2CppClassPointerStore<TypeDescriptor.TypeDescriptorInterface>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeDescriptor>.NativeClassPtr, "TypeDescriptorInterface");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDescriptor.TypeDescriptorInterface>.NativeClassPtr);
			}

			// Token: 0x06002CB4 RID: 11444 RVA: 0x00014221 File Offset: 0x00012421
			public TypeDescriptorInterface(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
