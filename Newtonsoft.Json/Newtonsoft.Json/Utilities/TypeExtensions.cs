using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200006E RID: 110
	public static class TypeExtensions : Object
	{
		// Token: 0x06000980 RID: 2432 RVA: 0x0003E674 File Offset: 0x0003C874
		// Note: this type is marked as 'beforefieldinit'.
		static TypeExtensions()
		{
			Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "TypeExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr);
			TypeExtensions.NativeMethodInfoPtr_Method_Public_Static_MethodInfo_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100665120);
			TypeExtensions.NativeMethodInfoPtr_MemberType_Public_Static_MemberTypes_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100665121);
			TypeExtensions.NativeMethodInfoPtr_ContainsGenericParameters_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100665122);
			TypeExtensions.NativeMethodInfoPtr_IsInterface_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100665123);
			TypeExtensions.NativeMethodInfoPtr_IsGenericType_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100665124);
			TypeExtensions.NativeMethodInfoPtr_IsGenericTypeDefinition_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100665125);
			TypeExtensions.NativeMethodInfoPtr_BaseType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100665126);
			TypeExtensions.NativeMethodInfoPtr_Assembly_Public_Static_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100665127);
			TypeExtensions.NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100665128);
			TypeExtensions.NativeMethodInfoPtr_IsClass_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100665129);
			TypeExtensions.NativeMethodInfoPtr_IsSealed_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100665130);
			TypeExtensions.NativeMethodInfoPtr_IsAbstract_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100665131);
			TypeExtensions.NativeMethodInfoPtr_IsVisible_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100665132);
			TypeExtensions.NativeMethodInfoPtr_IsValueType_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100665133);
			TypeExtensions.NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100665134);
			TypeExtensions.NativeMethodInfoPtr_AssignableToTypeName_Public_Static_Boolean_Type_String_Boolean_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100665135);
			TypeExtensions.NativeMethodInfoPtr_AssignableToTypeName_Public_Static_Boolean_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100665136);
			TypeExtensions.NativeMethodInfoPtr_ImplementInterface_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100665137);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0003E80C File Offset: 0x0003CA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746447, XrefRangeEnd = 746449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo Method(this Delegate d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_Method_Public_Static_MethodInfo_Delegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0003E850 File Offset: 0x0003CA50
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 746450, RefRangeEnd = 746460, XrefRangeStart = 746449, XrefRangeEnd = 746450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MemberTypes MemberType(this MemberInfo memberInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_MemberType_Public_Static_MemberTypes_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0003E894 File Offset: 0x0003CA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746460, XrefRangeEnd = 746461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsGenericParameters(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_ContainsGenericParameters_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0003E8D8 File Offset: 0x0003CAD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 746463, RefRangeEnd = 746466, XrefRangeStart = 746461, XrefRangeEnd = 746463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInterface(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_IsInterface_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0003E91C File Offset: 0x0003CB1C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 746467, RefRangeEnd = 746477, XrefRangeStart = 746466, XrefRangeEnd = 746467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGenericType(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_IsGenericType_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0003E960 File Offset: 0x0003CB60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 746478, RefRangeEnd = 746480, XrefRangeStart = 746477, XrefRangeEnd = 746478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGenericTypeDefinition(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_IsGenericTypeDefinition_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0003E9A4 File Offset: 0x0003CBA4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 746481, RefRangeEnd = 746492, XrefRangeStart = 746480, XrefRangeEnd = 746481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type BaseType(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_BaseType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0003E9E8 File Offset: 0x0003CBE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 746493, RefRangeEnd = 746498, XrefRangeStart = 746492, XrefRangeEnd = 746493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly Assembly(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_Assembly_Public_Static_Assembly_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0003EA2C File Offset: 0x0003CC2C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 746499, RefRangeEnd = 746505, XrefRangeStart = 746498, XrefRangeEnd = 746499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEnum(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0003EA70 File Offset: 0x0003CC70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 746507, RefRangeEnd = 746508, XrefRangeStart = 746505, XrefRangeEnd = 746507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsClass(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_IsClass_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0003EAB4 File Offset: 0x0003CCB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 746510, RefRangeEnd = 746511, XrefRangeStart = 746508, XrefRangeEnd = 746510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSealed(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_IsSealed_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0003EAF8 File Offset: 0x0003CCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746511, XrefRangeEnd = 746513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAbstract(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_IsAbstract_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0003EB3C File Offset: 0x0003CD3C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 746515, RefRangeEnd = 746523, XrefRangeStart = 746513, XrefRangeEnd = 746515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsVisible(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_IsVisible_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0003EB80 File Offset: 0x0003CD80
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 746525, RefRangeEnd = 746537, XrefRangeStart = 746523, XrefRangeEnd = 746525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValueType(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_IsValueType_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0003EBC4 File Offset: 0x0003CDC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 746539, RefRangeEnd = 746543, XrefRangeStart = 746537, XrefRangeEnd = 746539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPrimitive(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0003EC08 File Offset: 0x0003CE08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 746556, RefRangeEnd = 746557, XrefRangeStart = 746543, XrefRangeEnd = 746556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AssignableToTypeName(this Type type, string fullTypeName, bool searchInterfaces, out Type match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fullTypeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchInterfaces;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_AssignableToTypeName_Public_Static_Boolean_Type_String_Boolean_byref_Type_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			match = ((intPtr4 == 0) ? null : new Type(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0003EC8C File Offset: 0x0003CE8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 746558, RefRangeEnd = 746561, XrefRangeStart = 746557, XrefRangeEnd = 746558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AssignableToTypeName(this Type type, string fullTypeName, bool searchInterfaces)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fullTypeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchInterfaces;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_AssignableToTypeName_Public_Static_Boolean_Type_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0003ECF0 File Offset: 0x0003CEF0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 746584, RefRangeEnd = 746589, XrefRangeStart = 746561, XrefRangeEnd = 746584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ImplementInterface(this Type type, Type interfaceType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(interfaceType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_ImplementInterface_Public_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00004EAD File Offset: 0x000030AD
		public TypeExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_MethodInfo_Delegate_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr_MemberType_Public_Static_MemberTypes_MemberInfo_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_ContainsGenericParameters_Public_Static_Boolean_Type_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_IsInterface_Public_Static_Boolean_Type_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_IsGenericType_Public_Static_Boolean_Type_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_IsGenericTypeDefinition_Public_Static_Boolean_Type_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_BaseType_Public_Static_Type_Type_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr_Assembly_Public_Static_Assembly_Type_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_IsClass_Public_Static_Boolean_Type_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_IsSealed_Public_Static_Boolean_Type_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_IsAbstract_Public_Static_Boolean_Type_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_IsVisible_Public_Static_Boolean_Type_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_IsValueType_Public_Static_Boolean_Type_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_Type_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_AssignableToTypeName_Public_Static_Boolean_Type_String_Boolean_byref_Type_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_AssignableToTypeName_Public_Static_Boolean_Type_String_Boolean_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr_ImplementInterface_Public_Static_Boolean_Type_Type_0;
	}
}
