using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020002A6 RID: 678
	public class SoapServices : Object
	{
		// Token: 0x06002B81 RID: 11137 RVA: 0x000E5BAC File Offset: 0x000E3DAC
		// Note: this type is marked as 'beforefieldinit'.
		static SoapServices()
		{
			Il2CppClassPointerStore<SoapServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "SoapServices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapServices>.NativeClassPtr);
			SoapServices.NativeFieldInfoPtr__xmlTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, "_xmlTypes");
			SoapServices.NativeFieldInfoPtr__xmlElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, "_xmlElements");
			SoapServices.NativeFieldInfoPtr__soapActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, "_soapActions");
			SoapServices.NativeFieldInfoPtr__soapActionsMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, "_soapActionsMethods");
			SoapServices.NativeFieldInfoPtr__typeInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, "_typeInfos");
			SoapServices.NativeMethodInfoPtr_get_XmlNsForClrTypeWithAssembly_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100670343);
			SoapServices.NativeMethodInfoPtr_get_XmlNsForClrTypeWithNs_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100670344);
			SoapServices.NativeMethodInfoPtr_get_XmlNsForClrTypeWithNsAndAssembly_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100670345);
			SoapServices.NativeMethodInfoPtr_CodeXmlNamespaceForClrTypeNamespace_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100670346);
			SoapServices.NativeMethodInfoPtr_GetNameKey_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100670347);
			SoapServices.NativeMethodInfoPtr_GetAssemblyName_Private_Static_String_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100670348);
			SoapServices.NativeMethodInfoPtr_GetXmlElementForInteropType_Public_Static_Boolean_Type_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100670349);
			SoapServices.NativeMethodInfoPtr_GetXmlNamespaceForMethodCall_Public_Static_String_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100670350);
			SoapServices.NativeMethodInfoPtr_GetXmlNamespaceForMethodResponse_Public_Static_String_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100670351);
			SoapServices.NativeMethodInfoPtr_GetXmlTypeForInteropType_Public_Static_Boolean_Type_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100670352);
			SoapServices.NativeMethodInfoPtr_PreLoad_Public_Static_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100670353);
			SoapServices.NativeMethodInfoPtr_PreLoad_Public_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100670354);
			SoapServices.NativeMethodInfoPtr_RegisterInteropXmlElement_Public_Static_Void_String_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100670355);
			SoapServices.NativeMethodInfoPtr_RegisterInteropXmlType_Public_Static_Void_String_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100670356);
			SoapServices.NativeMethodInfoPtr_EncodeNs_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100670357);
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06002B82 RID: 11138 RVA: 0x000E5D6C File Offset: 0x000E3F6C
		public unsafe static string XmlNsForClrTypeWithAssembly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379285, XrefRangeEnd = 1379287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_get_XmlNsForClrTypeWithAssembly_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06002B83 RID: 11139 RVA: 0x000E5D98 File Offset: 0x000E3F98
		public unsafe static string XmlNsForClrTypeWithNs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379287, XrefRangeEnd = 1379289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_get_XmlNsForClrTypeWithNs_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06002B84 RID: 11140 RVA: 0x000E5DC4 File Offset: 0x000E3FC4
		public unsafe static string XmlNsForClrTypeWithNsAndAssembly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379289, XrefRangeEnd = 1379291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_get_XmlNsForClrTypeWithNsAndAssembly_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x000E5DF0 File Offset: 0x000E3FF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1379315, RefRangeEnd = 1379318, XrefRangeStart = 1379291, XrefRangeEnd = 1379315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeNamespace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_CodeXmlNamespaceForClrTypeNamespace_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B86 RID: 11142 RVA: 0x000E5E40 File Offset: 0x000E4040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379318, XrefRangeEnd = 1379321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNameKey(string name, string namspace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namspace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_GetNameKey_Private_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x000E5E90 File Offset: 0x000E4090
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1379329, RefRangeEnd = 1379331, XrefRangeStart = 1379321, XrefRangeEnd = 1379329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAssemblyName(MethodBase mb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_GetAssemblyName_Private_Static_String_MethodBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x000E5ECC File Offset: 0x000E40CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379331, XrefRangeEnd = 1379339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_GetXmlElementForInteropType_Public_Static_Boolean_Type_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			xmlElement = IL2CPP.Il2CppStringToManaged(intPtr);
			xmlNamespace = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x000E5F44 File Offset: 0x000E4144
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1379345, RefRangeEnd = 1379347, XrefRangeStart = 1379339, XrefRangeEnd = 1379345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetXmlNamespaceForMethodCall(MethodBase mb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_GetXmlNamespaceForMethodCall_Public_Static_String_MethodBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x000E5F80 File Offset: 0x000E4180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1379353, RefRangeEnd = 1379354, XrefRangeStart = 1379347, XrefRangeEnd = 1379353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetXmlNamespaceForMethodResponse(MethodBase mb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_GetXmlNamespaceForMethodResponse_Public_Static_String_MethodBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x000E5FBC File Offset: 0x000E41BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379354, XrefRangeEnd = 1379362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_GetXmlTypeForInteropType_Public_Static_Boolean_Type_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			xmlType = IL2CPP.Il2CppStringToManaged(intPtr);
			xmlTypeNamespace = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x000E6034 File Offset: 0x000E4234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379362, XrefRangeEnd = 1379367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PreLoad(Assembly assembly)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_PreLoad_Public_Static_Void_Assembly_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x000E606C File Offset: 0x000E426C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1379440, RefRangeEnd = 1379443, XrefRangeStart = 1379367, XrefRangeEnd = 1379440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PreLoad(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_PreLoad_Public_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x000E60A4 File Offset: 0x000E42A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1379457, RefRangeEnd = 1379458, XrefRangeStart = 1379443, XrefRangeEnd = 1379457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_RegisterInteropXmlElement_Public_Static_Void_String_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x000E6100 File Offset: 0x000E4300
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1379472, RefRangeEnd = 1379474, XrefRangeStart = 1379458, XrefRangeEnd = 1379472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlTypeNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_RegisterInteropXmlType_Public_Static_Void_String_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x000E615C File Offset: 0x000E435C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1379490, RefRangeEnd = 1379492, XrefRangeStart = 1379474, XrefRangeEnd = 1379490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncodeNs(string ns)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_EncodeNs_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x0000E801 File Offset: 0x0000CA01
		public SoapServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06002B92 RID: 11154 RVA: 0x000E6198 File Offset: 0x000E4398
		// (set) Token: 0x06002B93 RID: 11155 RVA: 0x0000E80A File Offset: 0x0000CA0A
		public unsafe static Hashtable _xmlTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SoapServices.NativeFieldInfoPtr__xmlTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SoapServices.NativeFieldInfoPtr__xmlTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06002B94 RID: 11156 RVA: 0x000E61C0 File Offset: 0x000E43C0
		// (set) Token: 0x06002B95 RID: 11157 RVA: 0x0000E81C File Offset: 0x0000CA1C
		public unsafe static Hashtable _xmlElements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SoapServices.NativeFieldInfoPtr__xmlElements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SoapServices.NativeFieldInfoPtr__xmlElements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06002B96 RID: 11158 RVA: 0x000E61E8 File Offset: 0x000E43E8
		// (set) Token: 0x06002B97 RID: 11159 RVA: 0x0000E82E File Offset: 0x0000CA2E
		public unsafe static Hashtable _soapActions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SoapServices.NativeFieldInfoPtr__soapActions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SoapServices.NativeFieldInfoPtr__soapActions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06002B98 RID: 11160 RVA: 0x000E6210 File Offset: 0x000E4410
		// (set) Token: 0x06002B99 RID: 11161 RVA: 0x0000E840 File Offset: 0x0000CA40
		public unsafe static Hashtable _soapActionsMethods
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SoapServices.NativeFieldInfoPtr__soapActionsMethods, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SoapServices.NativeFieldInfoPtr__soapActionsMethods, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06002B9A RID: 11162 RVA: 0x000E6238 File Offset: 0x000E4438
		// (set) Token: 0x06002B9B RID: 11163 RVA: 0x0000E852 File Offset: 0x0000CA52
		public unsafe static Hashtable _typeInfos
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SoapServices.NativeFieldInfoPtr__typeInfos, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SoapServices.NativeFieldInfoPtr__typeInfos, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040024D5 RID: 9429
		private static readonly IntPtr NativeFieldInfoPtr__xmlTypes;

		// Token: 0x040024D6 RID: 9430
		private static readonly IntPtr NativeFieldInfoPtr__xmlElements;

		// Token: 0x040024D7 RID: 9431
		private static readonly IntPtr NativeFieldInfoPtr__soapActions;

		// Token: 0x040024D8 RID: 9432
		private static readonly IntPtr NativeFieldInfoPtr__soapActionsMethods;

		// Token: 0x040024D9 RID: 9433
		private static readonly IntPtr NativeFieldInfoPtr__typeInfos;

		// Token: 0x040024DA RID: 9434
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNsForClrTypeWithAssembly_Public_Static_get_String_0;

		// Token: 0x040024DB RID: 9435
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNsForClrTypeWithNs_Public_Static_get_String_0;

		// Token: 0x040024DC RID: 9436
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNsForClrTypeWithNsAndAssembly_Public_Static_get_String_0;

		// Token: 0x040024DD RID: 9437
		private static readonly IntPtr NativeMethodInfoPtr_CodeXmlNamespaceForClrTypeNamespace_Public_Static_String_String_String_0;

		// Token: 0x040024DE RID: 9438
		private static readonly IntPtr NativeMethodInfoPtr_GetNameKey_Private_Static_String_String_String_0;

		// Token: 0x040024DF RID: 9439
		private static readonly IntPtr NativeMethodInfoPtr_GetAssemblyName_Private_Static_String_MethodBase_0;

		// Token: 0x040024E0 RID: 9440
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlElementForInteropType_Public_Static_Boolean_Type_byref_String_byref_String_0;

		// Token: 0x040024E1 RID: 9441
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlNamespaceForMethodCall_Public_Static_String_MethodBase_0;

		// Token: 0x040024E2 RID: 9442
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlNamespaceForMethodResponse_Public_Static_String_MethodBase_0;

		// Token: 0x040024E3 RID: 9443
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlTypeForInteropType_Public_Static_Boolean_Type_byref_String_byref_String_0;

		// Token: 0x040024E4 RID: 9444
		private static readonly IntPtr NativeMethodInfoPtr_PreLoad_Public_Static_Void_Assembly_0;

		// Token: 0x040024E5 RID: 9445
		private static readonly IntPtr NativeMethodInfoPtr_PreLoad_Public_Static_Void_Type_0;

		// Token: 0x040024E6 RID: 9446
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInteropXmlElement_Public_Static_Void_String_String_Type_0;

		// Token: 0x040024E7 RID: 9447
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInteropXmlType_Public_Static_Void_String_String_Type_0;

		// Token: 0x040024E8 RID: 9448
		private static readonly IntPtr NativeMethodInfoPtr_EncodeNs_Private_Static_String_String_0;

		// Token: 0x02000667 RID: 1639
		public class TypeInfo : Object
		{
			// Token: 0x06005B1E RID: 23326 RVA: 0x0019EFC8 File Offset: 0x0019D1C8
			// Note: this type is marked as 'beforefieldinit'.
			static TypeInfo()
			{
				Il2CppClassPointerStore<SoapServices.TypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, "TypeInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapServices.TypeInfo>.NativeClassPtr);
				SoapServices.TypeInfo.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices.TypeInfo>.NativeClassPtr, "Attributes");
				SoapServices.TypeInfo.NativeFieldInfoPtr_Elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices.TypeInfo>.NativeClassPtr, "Elements");
				SoapServices.TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices.TypeInfo>.NativeClassPtr, 100670359);
			}

			// Token: 0x06005B1F RID: 23327 RVA: 0x0019F030 File Offset: 0x0019D230
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TypeInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoapServices.TypeInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B20 RID: 23328 RVA: 0x00020FDF File Offset: 0x0001F1DF
			public TypeInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001759 RID: 5977
			// (get) Token: 0x06005B21 RID: 23329 RVA: 0x0019F06C File Offset: 0x0019D26C
			// (set) Token: 0x06005B22 RID: 23330 RVA: 0x00020FE8 File Offset: 0x0001F1E8
			public unsafe Hashtable Attributes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapServices.TypeInfo.NativeFieldInfoPtr_Attributes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapServices.TypeInfo.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700175A RID: 5978
			// (get) Token: 0x06005B23 RID: 23331 RVA: 0x0019F09C File Offset: 0x0019D29C
			// (set) Token: 0x06005B24 RID: 23332 RVA: 0x00021007 File Offset: 0x0001F207
			public unsafe Hashtable Elements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapServices.TypeInfo.NativeFieldInfoPtr_Elements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapServices.TypeInfo.NativeFieldInfoPtr_Elements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004A52 RID: 19026
			private static readonly IntPtr NativeFieldInfoPtr_Attributes;

			// Token: 0x04004A53 RID: 19027
			private static readonly IntPtr NativeFieldInfoPtr_Elements;

			// Token: 0x04004A54 RID: 19028
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
