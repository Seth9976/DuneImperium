using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001F7 RID: 503
	public class XmlListConverter : XmlBaseConverter
	{
		// Token: 0x06002ACD RID: 10957 RVA: 0x000C7C48 File Offset: 0x000C5E48
		// Note: this type is marked as 'beforefieldinit'.
		static XmlListConverter()
		{
			Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlListConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr);
			XmlListConverter.NativeFieldInfoPtr_atomicConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, "atomicConverter");
			XmlListConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100669549);
			XmlListConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100669550);
			XmlListConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100669551);
			XmlListConverter.NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlValueConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100669552);
			XmlListConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100669553);
			XmlListConverter.NativeMethodInfoPtr_ChangeListType_Protected_Virtual_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100669554);
			XmlListConverter.NativeMethodInfoPtr_IsListType_Private_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100669555);
			XmlListConverter.NativeMethodInfoPtr_ToArray_Private_Il2CppArrayBase_1_T_Object_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100669556);
			XmlListConverter.NativeMethodInfoPtr_ToList_Private_IList_Object_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100669557);
			XmlListConverter.NativeMethodInfoPtr_StringAsList_Private_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100669558);
			XmlListConverter.NativeMethodInfoPtr_ListAsString_Private_String_IEnumerable_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100669559);
			XmlListConverter.NativeMethodInfoPtr_CreateInvalidClrMappingException_Private_Exception_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100669560);
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x000C7D7C File Offset: 0x000C5F7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 422299, RefRangeEnd = 422300, XrefRangeStart = 422299, XrefRangeEnd = 422300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlListConverter(XmlBaseConverter atomicConverter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(atomicConverter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x000C7DC8 File Offset: 0x000C5FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422375, XrefRangeEnd = 422380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlListConverter(XmlBaseConverter atomicConverter, Type clrTypeDefault)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(atomicConverter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clrTypeDefault);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x000C7E28 File Offset: 0x000C6028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422380, XrefRangeEnd = 422384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlListConverter(XmlSchemaType schemaType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x000C7E74 File Offset: 0x000C6074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 422401, RefRangeEnd = 422402, XrefRangeStart = 422384, XrefRangeEnd = 422401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlValueConverter Create(XmlValueConverter atomicConverter)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(atomicConverter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlValueConverter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x000C7EB8 File Offset: 0x000C60B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422402, XrefRangeEnd = 422418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlListConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x000C7F38 File Offset: 0x000C6138
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 422661, RefRangeEnd = 422662, XrefRangeStart = 422418, XrefRangeEnd = 422661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeListType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlListConverter.NativeMethodInfoPtr_ChangeListType_Protected_Virtual_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x000C7FB8 File Offset: 0x000C61B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422662, XrefRangeEnd = 422689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsListType(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.NativeMethodInfoPtr_IsListType_Private_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x000C8008 File Offset: 0x000C6208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422689, XrefRangeEnd = 422727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> ToArray<T>(Object list, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.MethodInfoStoreGeneric_ToArray_Private_Il2CppArrayBase_1_T_Object_IXmlNamespaceResolver_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x000C8064 File Offset: 0x000C6264
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 422784, RefRangeEnd = 422785, XrefRangeStart = 422727, XrefRangeEnd = 422784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList ToList(Object list, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.NativeMethodInfoPtr_ToList_Private_IList_Object_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x000C80C8 File Offset: 0x000C62C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422785, XrefRangeEnd = 422795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> StringAsList(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.NativeMethodInfoPtr_StringAsList_Private_List_1_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x000C8118 File Offset: 0x000C6318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422795, XrefRangeEnd = 422819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.NativeMethodInfoPtr_ListAsString_Private_String_IEnumerable_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x000C8174 File Offset: 0x000C6374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422819, XrefRangeEnd = 422841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.NativeMethodInfoPtr_CreateInvalidClrMappingException_Private_Exception_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x00011A6F File Offset: 0x0000FC6F
		public XmlListConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06002ADB RID: 10971 RVA: 0x000C81D8 File Offset: 0x000C63D8
		// (set) Token: 0x06002ADC RID: 10972 RVA: 0x00011A78 File Offset: 0x0000FC78
		public unsafe XmlValueConverter atomicConverter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlListConverter.NativeFieldInfoPtr_atomicConverter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlListConverter.NativeFieldInfoPtr_atomicConverter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020B6 RID: 8374
		private static readonly IntPtr NativeFieldInfoPtr_atomicConverter;

		// Token: 0x040020B7 RID: 8375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0;

		// Token: 0x040020B8 RID: 8376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_Type_0;

		// Token: 0x040020B9 RID: 8377
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0;

		// Token: 0x040020BA RID: 8378
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlValueConverter_0;

		// Token: 0x040020BB RID: 8379
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x040020BC RID: 8380
		private static readonly IntPtr NativeMethodInfoPtr_ChangeListType_Protected_Virtual_Object_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x040020BD RID: 8381
		private static readonly IntPtr NativeMethodInfoPtr_IsListType_Private_Boolean_Type_0;

		// Token: 0x040020BE RID: 8382
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Private_Il2CppArrayBase_1_T_Object_IXmlNamespaceResolver_0;

		// Token: 0x040020BF RID: 8383
		private static readonly IntPtr NativeMethodInfoPtr_ToList_Private_IList_Object_IXmlNamespaceResolver_0;

		// Token: 0x040020C0 RID: 8384
		private static readonly IntPtr NativeMethodInfoPtr_StringAsList_Private_List_1_String_String_0;

		// Token: 0x040020C1 RID: 8385
		private static readonly IntPtr NativeMethodInfoPtr_ListAsString_Private_String_IEnumerable_IXmlNamespaceResolver_0;

		// Token: 0x040020C2 RID: 8386
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidClrMappingException_Private_Exception_Type_Type_0;

		// Token: 0x02000273 RID: 627
		private sealed class MethodInfoStoreGeneric_ToArray_Private_Il2CppArrayBase_1_T_Object_IXmlNamespaceResolver_0<T>
		{
			// Token: 0x0400276B RID: 10091
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(XmlListConverter.NativeMethodInfoPtr_ToArray_Private_Il2CppArrayBase_1_T_Object_IXmlNamespaceResolver_0, Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
