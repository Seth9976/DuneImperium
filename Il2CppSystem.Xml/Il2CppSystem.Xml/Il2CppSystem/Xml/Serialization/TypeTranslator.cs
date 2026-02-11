using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000C6 RID: 198
	public class TypeTranslator : Object
	{
		// Token: 0x0600131F RID: 4895 RVA: 0x00069B7C File Offset: 0x00067D7C
		// Note: this type is marked as 'beforefieldinit'.
		static TypeTranslator()
		{
			Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "TypeTranslator");
			TypeTranslator.NativeFieldInfoPtr_nameCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, "nameCache");
			TypeTranslator.NativeFieldInfoPtr_primitiveTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, "primitiveTypes");
			TypeTranslator.NativeFieldInfoPtr_primitiveArrayTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, "primitiveArrayTypes");
			TypeTranslator.NativeFieldInfoPtr_nullableTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, "nullableTypes");
			TypeTranslator.NativeMethodInfoPtr_GetTypeData_Public_Static_TypeData_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100666404);
			TypeTranslator.NativeMethodInfoPtr_GetTypeData_Public_Static_TypeData_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100666405);
			TypeTranslator.NativeMethodInfoPtr_GetPrimitiveTypeData_Public_Static_TypeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100666406);
			TypeTranslator.NativeMethodInfoPtr_GetPrimitiveTypeData_Public_Static_TypeData_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100666407);
			TypeTranslator.NativeMethodInfoPtr_FindPrimitiveTypeData_Public_Static_TypeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100666408);
			TypeTranslator.NativeMethodInfoPtr_GetArrayName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100666409);
			TypeTranslator.NativeMethodInfoPtr_ParseArrayType_Public_Static_Void_String_byref_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100666410);
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x00069C80 File Offset: 0x00067E80
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 384359, RefRangeEnd = 384375, XrefRangeStart = 384355, XrefRangeEnd = 384359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeData GetTypeData(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTranslator.NativeMethodInfoPtr_GetTypeData_Public_Static_TypeData_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr3) : null;
			}
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00069CC4 File Offset: 0x00067EC4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 384415, RefRangeEnd = 384425, XrefRangeStart = 384375, XrefRangeEnd = 384415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(runtimeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlDataType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref underlyingEnumType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTranslator.NativeMethodInfoPtr_GetTypeData_Public_Static_TypeData_Type_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr3) : null;
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00069D28 File Offset: 0x00067F28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 384429, RefRangeEnd = 384430, XrefRangeStart = 384425, XrefRangeEnd = 384429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeData GetPrimitiveTypeData(string typeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTranslator.NativeMethodInfoPtr_GetPrimitiveTypeData_Public_Static_TypeData_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr3) : null;
			}
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00069D6C File Offset: 0x00067F6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 384437, RefRangeEnd = 384439, XrefRangeStart = 384430, XrefRangeEnd = 384437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeData GetPrimitiveTypeData(string typeName, bool nullable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTranslator.NativeMethodInfoPtr_GetPrimitiveTypeData_Public_Static_TypeData_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr3) : null;
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x00069DC0 File Offset: 0x00067FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 384445, RefRangeEnd = 384446, XrefRangeStart = 384439, XrefRangeEnd = 384445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeData FindPrimitiveTypeData(string typeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTranslator.NativeMethodInfoPtr_FindPrimitiveTypeData_Public_Static_TypeData_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr3) : null;
			}
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x00069E04 File Offset: 0x00068004
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 384460, RefRangeEnd = 384464, XrefRangeStart = 384446, XrefRangeEnd = 384460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetArrayName(string elemName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elemName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTranslator.NativeMethodInfoPtr_GetArrayName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x00069E40 File Offset: 0x00068040
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 385088, RefRangeEnd = 385090, XrefRangeStart = 384464, XrefRangeEnd = 385088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(arrayType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(TypeTranslator.NativeMethodInfoPtr_ParseArrayType_Public_Static_Void_String_byref_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			type = IL2CPP.Il2CppStringToManaged(intPtr);
			ns = IL2CPP.Il2CppStringToManaged(intPtr2);
			dimensions = IL2CPP.Il2CppStringToManaged(intPtr3);
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x000081F5 File Offset: 0x000063F5
		public TypeTranslator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x00069EC8 File Offset: 0x000680C8
		// (set) Token: 0x06001329 RID: 4905 RVA: 0x000081FE File Offset: 0x000063FE
		public unsafe static Hashtable nameCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeTranslator.NativeFieldInfoPtr_nameCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTranslator.NativeFieldInfoPtr_nameCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x00069EF0 File Offset: 0x000680F0
		// (set) Token: 0x0600132B RID: 4907 RVA: 0x00008210 File Offset: 0x00006410
		public unsafe static Hashtable primitiveTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeTranslator.NativeFieldInfoPtr_primitiveTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTranslator.NativeFieldInfoPtr_primitiveTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x00069F18 File Offset: 0x00068118
		// (set) Token: 0x0600132D RID: 4909 RVA: 0x00008222 File Offset: 0x00006422
		public unsafe static Hashtable primitiveArrayTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeTranslator.NativeFieldInfoPtr_primitiveArrayTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTranslator.NativeFieldInfoPtr_primitiveArrayTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x00069F40 File Offset: 0x00068140
		// (set) Token: 0x0600132F RID: 4911 RVA: 0x00008234 File Offset: 0x00006434
		public unsafe static Hashtable nullableTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeTranslator.NativeFieldInfoPtr_nullableTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTranslator.NativeFieldInfoPtr_nullableTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeFieldInfoPtr_nameCache;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeFieldInfoPtr_primitiveTypes;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeFieldInfoPtr_primitiveArrayTypes;

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeFieldInfoPtr_nullableTypes;

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeData_Public_Static_TypeData_Type_0;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeData_Public_Static_TypeData_Type_String_Boolean_0;

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimitiveTypeData_Public_Static_TypeData_String_0;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimitiveTypeData_Public_Static_TypeData_String_Boolean_0;

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeMethodInfoPtr_FindPrimitiveTypeData_Public_Static_TypeData_String_0;

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayName_Public_Static_String_String_0;

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeMethodInfoPtr_ParseArrayType_Public_Static_Void_String_byref_String_byref_String_byref_String_0;
	}
}
