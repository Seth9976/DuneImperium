using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using UnityEngine.Pool;

namespace Unity.Properties
{
	// Token: 0x02000022 RID: 34
	public static class TypeUtility : Object
	{
		// Token: 0x06000125 RID: 293 RVA: 0x00006970 File Offset: 0x00004B70
		// Note: this type is marked as 'beforefieldinit'.
		static TypeUtility()
		{
			Il2CppClassPointerStore<TypeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "TypeUtility");
			TypeUtility.NativeFieldInfoPtr_s_TypeConstructors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, "s_TypeConstructors");
			TypeUtility.NativeFieldInfoPtr_s_CreateTypeConstructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, "s_CreateTypeConstructor");
			TypeUtility.NativeFieldInfoPtr_s_CachedResolvedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, "s_CachedResolvedName");
			TypeUtility.NativeFieldInfoPtr_s_Builders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, "s_Builders");
			TypeUtility.NativeFieldInfoPtr_syncedPoolObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, "syncedPoolObject");
			TypeUtility.NativeMethodInfoPtr_GetTypeDisplayName_Public_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663402);
			TypeUtility.NativeMethodInfoPtr_GetTypeDisplayName_Private_Static_String_Type_IReadOnlyList_1_Type_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663403);
			TypeUtility.NativeMethodInfoPtr_GetRootType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663404);
			TypeUtility.NativeMethodInfoPtr_CreateTypeConstructor_Private_Static_ITypeConstructor_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663405);
			TypeUtility.NativeMethodInfoPtr_CreateTypeConstructor_Private_Static_ITypeConstructor_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663406);
			TypeUtility.NativeMethodInfoPtr_GetTypeConstructor_Private_Static_ITypeConstructor_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663407);
			TypeUtility.NativeMethodInfoPtr_GetTypeConstructor_Private_Static_ITypeConstructor_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663408);
			TypeUtility.NativeMethodInfoPtr_CanBeInstantiated_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663409);
			TypeUtility.NativeMethodInfoPtr_CanBeInstantiated_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663410);
			TypeUtility.NativeMethodInfoPtr_SetExplicitInstantiationMethod_Public_Static_Void_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663411);
			TypeUtility.NativeMethodInfoPtr_Instantiate_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663412);
			TypeUtility.NativeMethodInfoPtr_TryInstantiate_Public_Static_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663413);
			TypeUtility.NativeMethodInfoPtr_Instantiate_Public_Static_T_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663414);
			TypeUtility.NativeMethodInfoPtr_TryInstantiate_Public_Static_Boolean_Type_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663415);
			TypeUtility.NativeMethodInfoPtr_InstantiateArray_Public_Static_TArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663416);
			TypeUtility.NativeMethodInfoPtr_TryInstantiateArray_Public_Static_Boolean_Int32_byref_TArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663417);
			TypeUtility.NativeMethodInfoPtr_InstantiateArray_Public_Static_TArray_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663418);
			TypeUtility.NativeMethodInfoPtr_CheckIsAssignableFrom_Private_Static_Void_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663419);
			TypeUtility.NativeMethodInfoPtr_CheckCanBeInstantiated_Private_Static_Void_ITypeConstructor_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663420);
			TypeUtility.NativeMethodInfoPtr_CheckCanBeInstantiated_Private_Static_Void_ITypeConstructor_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, 100663421);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00006B8C File Offset: 0x00004D8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1231210, RefRangeEnd = 1231211, XrefRangeStart = 1231196, XrefRangeEnd = 1231210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTypeDisplayName(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.NativeMethodInfoPtr_GetTypeDisplayName_Public_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00006BC8 File Offset: 0x00004DC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1231369, RefRangeEnd = 1231371, XrefRangeStart = 1231211, XrefRangeEnd = 1231369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTypeDisplayName(Type type, IReadOnlyList<Type> args, ref int argIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &argIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.NativeMethodInfoPtr_GetTypeDisplayName_Private_Static_String_Type_IReadOnlyList_1_Type_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00006C24 File Offset: 0x00004E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231371, XrefRangeEnd = 1231385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetRootType(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.NativeMethodInfoPtr_GetRootType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00006C68 File Offset: 0x00004E68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1231414, RefRangeEnd = 1231415, XrefRangeStart = 1231385, XrefRangeEnd = 1231414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeUtility.ITypeConstructor CreateTypeConstructor(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.NativeMethodInfoPtr_CreateTypeConstructor_Private_Static_ITypeConstructor_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeUtility.ITypeConstructor>(intPtr3) : null;
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00006CAC File Offset: 0x00004EAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1231433, RefRangeEnd = 1231434, XrefRangeStart = 1231415, XrefRangeEnd = 1231433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeUtility.ITypeConstructor<T> CreateTypeConstructor<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.MethodInfoStoreGeneric_CreateTypeConstructor_Private_Static_ITypeConstructor_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeUtility.ITypeConstructor<T>>(intPtr3) : null;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00006CE0 File Offset: 0x00004EE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1231441, RefRangeEnd = 1231443, XrefRangeStart = 1231434, XrefRangeEnd = 1231441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeUtility.ITypeConstructor GetTypeConstructor(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.NativeMethodInfoPtr_GetTypeConstructor_Private_Static_ITypeConstructor_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeUtility.ITypeConstructor>(intPtr3) : null;
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00006D24 File Offset: 0x00004F24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1231447, RefRangeEnd = 1231448, XrefRangeStart = 1231443, XrefRangeEnd = 1231447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeUtility.ITypeConstructor<T> GetTypeConstructor<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.MethodInfoStoreGeneric_GetTypeConstructor_Private_Static_ITypeConstructor_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeUtility.ITypeConstructor<T>>(intPtr3) : null;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00006D58 File Offset: 0x00004F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231448, XrefRangeEnd = 1231465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBeInstantiated(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.NativeMethodInfoPtr_CanBeInstantiated_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00006D9C File Offset: 0x00004F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231465, XrefRangeEnd = 1231473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBeInstantiated<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.MethodInfoStoreGeneric_CanBeInstantiated_Public_Static_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00006DCC File Offset: 0x00004FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231473, XrefRangeEnd = 1231482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetExplicitInstantiationMethod<T>(Func<T> constructor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.MethodInfoStoreGeneric_SetExplicitInstantiationMethod_Public_Static_Void_Func_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00006E04 File Offset: 0x00005004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231482, XrefRangeEnd = 1231494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.MethodInfoStoreGeneric_Instantiate_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00006E34 File Offset: 0x00005034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231494, XrefRangeEnd = 1231503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryInstantiate<T>(out T instance)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref instance;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TypeUtility.MethodInfoStoreGeneric_TryInstantiate_Public_Static_Boolean_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					instance = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00006EB4 File Offset: 0x000050B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231503, XrefRangeEnd = 1231525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(Type derivedType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.MethodInfoStoreGeneric_Instantiate_Public_Static_T_Type_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00006EF4 File Offset: 0x000050F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231525, XrefRangeEnd = 1231545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryInstantiate<T>(Type derivedType, out T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TypeUtility.MethodInfoStoreGeneric_TryInstantiate_Public_Static_Boolean_Type_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00006F84 File Offset: 0x00005184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231545, XrefRangeEnd = 1231571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TArray InstantiateArray<TArray>(int count = 0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.MethodInfoStoreGeneric_InstantiateArray_Public_Static_TArray_Int32_0<TArray>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TArray>(intPtr, false, true);
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00006FC0 File Offset: 0x000051C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231571, XrefRangeEnd = 1231598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryInstantiateArray<TArray>(int count, out TArray instance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TArray).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref instance;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TypeUtility.MethodInfoStoreGeneric_TryInstantiateArray_Public_Static_Boolean_Int32_byref_TArray_0<TArray>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TArray).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				instance = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TArray>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000704C File Offset: 0x0000524C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231598, XrefRangeEnd = 1231625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TArray InstantiateArray<TArray>(Type derivedType, int count = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.MethodInfoStoreGeneric_InstantiateArray_Public_Static_TArray_Type_Int32_0<TArray>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TArray>(intPtr, false, true);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00007098 File Offset: 0x00005298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1231625, RefRangeEnd = 1231626, XrefRangeStart = 1231625, XrefRangeEnd = 1231625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckIsAssignableFrom(Type type, Type derivedType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(derivedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.NativeMethodInfoPtr_CheckIsAssignableFrom_Private_Static_Void_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000070E0 File Offset: 0x000052E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231626, XrefRangeEnd = 1231630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckCanBeInstantiated<T>(TypeUtility.ITypeConstructor<T> constructor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.MethodInfoStoreGeneric_CheckCanBeInstantiated_Private_Static_Void_ITypeConstructor_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00007118 File Offset: 0x00005318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1231633, RefRangeEnd = 1231634, XrefRangeStart = 1231630, XrefRangeEnd = 1231633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckCanBeInstantiated(TypeUtility.ITypeConstructor constructor, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.NativeMethodInfoPtr_CheckCanBeInstantiated_Private_Static_Void_ITypeConstructor_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000288A File Offset: 0x00000A8A
		public TypeUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00007160 File Offset: 0x00005360
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00002893 File Offset: 0x00000A93
		public unsafe static ConcurrentDictionary<Type, TypeUtility.ITypeConstructor> s_TypeConstructors
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeUtility.NativeFieldInfoPtr_s_TypeConstructors, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Type, TypeUtility.ITypeConstructor>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeUtility.NativeFieldInfoPtr_s_TypeConstructors, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00007188 File Offset: 0x00005388
		// (set) Token: 0x0600013E RID: 318 RVA: 0x000028A5 File Offset: 0x00000AA5
		public unsafe static MethodInfo s_CreateTypeConstructor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeUtility.NativeFieldInfoPtr_s_CreateTypeConstructor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeUtility.NativeFieldInfoPtr_s_CreateTypeConstructor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600013F RID: 319 RVA: 0x000071B0 File Offset: 0x000053B0
		// (set) Token: 0x06000140 RID: 320 RVA: 0x000028B7 File Offset: 0x00000AB7
		public unsafe static ConcurrentDictionary<Type, string> s_CachedResolvedName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeUtility.NativeFieldInfoPtr_s_CachedResolvedName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Type, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeUtility.NativeFieldInfoPtr_s_CachedResolvedName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000071D8 File Offset: 0x000053D8
		// (set) Token: 0x06000142 RID: 322 RVA: 0x000028C9 File Offset: 0x00000AC9
		public unsafe static ObjectPool<StringBuilder> s_Builders
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeUtility.NativeFieldInfoPtr_s_Builders, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<StringBuilder>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeUtility.NativeFieldInfoPtr_s_Builders, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00007200 File Offset: 0x00005400
		// (set) Token: 0x06000144 RID: 324 RVA: 0x000028DB File Offset: 0x00000ADB
		public unsafe static Object syncedPoolObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeUtility.NativeFieldInfoPtr_syncedPoolObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeUtility.NativeFieldInfoPtr_syncedPoolObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_s_TypeConstructors;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_s_CreateTypeConstructor;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_s_CachedResolvedName;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_s_Builders;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_syncedPoolObject;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeDisplayName_Public_Static_String_Type_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeDisplayName_Private_Static_String_Type_IReadOnlyList_1_Type_byref_Int32_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_GetRootType_Public_Static_Type_Type_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_CreateTypeConstructor_Private_Static_ITypeConstructor_Type_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_CreateTypeConstructor_Private_Static_ITypeConstructor_1_T_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeConstructor_Private_Static_ITypeConstructor_Type_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeConstructor_Private_Static_ITypeConstructor_1_T_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_CanBeInstantiated_Public_Static_Boolean_Type_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_CanBeInstantiated_Public_Static_Boolean_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_SetExplicitInstantiationMethod_Public_Static_Void_Func_1_T_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_TryInstantiate_Public_Static_Boolean_byref_T_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_Type_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_TryInstantiate_Public_Static_Boolean_Type_byref_T_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateArray_Public_Static_TArray_Int32_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_TryInstantiateArray_Public_Static_Boolean_Int32_byref_TArray_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateArray_Public_Static_TArray_Type_Int32_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_CheckIsAssignableFrom_Private_Static_Void_Type_Type_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanBeInstantiated_Private_Static_Void_ITypeConstructor_1_T_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanBeInstantiated_Private_Static_Void_ITypeConstructor_Type_0;

		// Token: 0x02000067 RID: 103
		public class ITypeConstructor : Il2CppObjectBase
		{
			// Token: 0x0600021E RID: 542 RVA: 0x00003189 File Offset: 0x00001389
			// Note: this type is marked as 'beforefieldinit'.
			static ITypeConstructor()
			{
				Il2CppClassPointerStore<TypeUtility.ITypeConstructor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, "ITypeConstructor");
				TypeUtility.ITypeConstructor.NativeMethodInfoPtr_get_CanBeInstantiated_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.ITypeConstructor>.NativeClassPtr, 100663422);
				TypeUtility.ITypeConstructor.NativeMethodInfoPtr_Instantiate_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.ITypeConstructor>.NativeClassPtr, 100663423);
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x0600021F RID: 543 RVA: 0x00009414 File Offset: 0x00007614
			public unsafe virtual bool CanBeInstantiated
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeUtility.ITypeConstructor.NativeMethodInfoPtr_get_CanBeInstantiated_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000220 RID: 544 RVA: 0x0000945C File Offset: 0x0000765C
			[CallerCount(0)]
			public unsafe virtual Object Instantiate()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeUtility.ITypeConstructor.NativeMethodInfoPtr_Instantiate_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06000221 RID: 545 RVA: 0x000031C7 File Offset: 0x000013C7
			public ITypeConstructor(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000101 RID: 257
			private static readonly IntPtr NativeMethodInfoPtr_get_CanBeInstantiated_Public_Abstract_Virtual_New_get_Boolean_0;

			// Token: 0x04000102 RID: 258
			private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Abstract_Virtual_New_Object_0;
		}

		// Token: 0x02000068 RID: 104
		public class ITypeConstructor<T> : Il2CppObjectBase
		{
			// Token: 0x06000222 RID: 546 RVA: 0x000094A8 File Offset: 0x000076A8
			// Note: this type is marked as 'beforefieldinit'.
			static ITypeConstructor()
			{
				Il2CppClassPointerStore<TypeUtility.ITypeConstructor<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, "ITypeConstructor`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				TypeUtility.ITypeConstructor<T>.NativeMethodInfoPtr_Instantiate_Public_Abstract_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.ITypeConstructor<T>>.NativeClassPtr, 100663424);
				TypeUtility.ITypeConstructor<T>.NativeMethodInfoPtr_SetExplicitConstructor_Public_Abstract_Virtual_New_Void_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.ITypeConstructor<T>>.NativeClassPtr, 100663425);
			}

			// Token: 0x06000223 RID: 547 RVA: 0x0000952C File Offset: 0x0000772C
			[CallerCount(0)]
			public unsafe virtual T Instantiate()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeUtility.ITypeConstructor<T>.NativeMethodInfoPtr_Instantiate_Public_Abstract_Virtual_New_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x06000224 RID: 548 RVA: 0x00009570 File Offset: 0x00007770
			[CallerCount(0)]
			public unsafe virtual void SetExplicitConstructor(Func<T> constructor)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructor);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeUtility.ITypeConstructor<T>.NativeMethodInfoPtr_SetExplicitConstructor_Public_Abstract_Virtual_New_Void_Func_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000225 RID: 549 RVA: 0x000031D0 File Offset: 0x000013D0
			public ITypeConstructor(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000103 RID: 259
			private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Abstract_Virtual_New_T_0;

			// Token: 0x04000104 RID: 260
			private static readonly IntPtr NativeMethodInfoPtr_SetExplicitConstructor_Public_Abstract_Virtual_New_Void_Func_1_T_0;
		}

		// Token: 0x02000069 RID: 105
		public class TypeConstructor<T> : Object
		{
			// Token: 0x06000226 RID: 550 RVA: 0x000095C0 File Offset: 0x000077C0
			// Note: this type is marked as 'beforefieldinit'.
			static TypeConstructor()
			{
				Il2CppClassPointerStore<TypeUtility.TypeConstructor<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, "TypeConstructor`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeUtility.TypeConstructor<T>>.NativeClassPtr);
				TypeUtility.TypeConstructor<T>.NativeFieldInfoPtr_m_ExplicitConstructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeUtility.TypeConstructor<T>>.NativeClassPtr, "m_ExplicitConstructor");
				TypeUtility.TypeConstructor<T>.NativeFieldInfoPtr_m_ImplicitConstructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeUtility.TypeConstructor<T>>.NativeClassPtr, "m_ImplicitConstructor");
				TypeUtility.TypeConstructor<T>.NativeFieldInfoPtr_m_OverrideConstructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeUtility.TypeConstructor<T>>.NativeClassPtr, "m_OverrideConstructor");
				TypeUtility.TypeConstructor<T>.NativeMethodInfoPtr_Unity_Properties_TypeUtility_ITypeConstructor_get_CanBeInstantiated_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.TypeConstructor<T>>.NativeClassPtr, 100663426);
				TypeUtility.TypeConstructor<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.TypeConstructor<T>>.NativeClassPtr, 100663427);
				TypeUtility.TypeConstructor<T>.NativeMethodInfoPtr_SetImplicitConstructor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.TypeConstructor<T>>.NativeClassPtr, 100663428);
				TypeUtility.TypeConstructor<T>.NativeMethodInfoPtr_CreateValueTypeInstance_Private_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.TypeConstructor<T>>.NativeClassPtr, 100663429);
				TypeUtility.TypeConstructor<T>.NativeMethodInfoPtr_CreateScriptableObjectInstance_Private_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.TypeConstructor<T>>.NativeClassPtr, 100663430);
				TypeUtility.TypeConstructor<T>.NativeMethodInfoPtr_CreateClassInstance_Private_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.TypeConstructor<T>>.NativeClassPtr, 100663431);
				TypeUtility.TypeConstructor<T>.NativeMethodInfoPtr_SetExplicitConstructor_Public_Virtual_Final_New_Void_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.TypeConstructor<T>>.NativeClassPtr, 100663432);
				TypeUtility.TypeConstructor<T>.NativeMethodInfoPtr_Unity_Properties_TypeUtility_ITypeConstructor_T__Instantiate_Private_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.TypeConstructor<T>>.NativeClassPtr, 100663433);
				TypeUtility.TypeConstructor<T>.NativeMethodInfoPtr_Unity_Properties_TypeUtility_ITypeConstructor_Instantiate_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.TypeConstructor<T>>.NativeClassPtr, 100663434);
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x06000227 RID: 551 RVA: 0x00009718 File Offset: 0x00007918
			public unsafe virtual bool Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230989, XrefRangeEnd = 1230994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.TypeConstructor<T>.NativeMethodInfoPtr_Unity_Properties_TypeUtility_ITypeConstructor_get_CanBeInstantiated_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000228 RID: 552 RVA: 0x00009754 File Offset: 0x00007954
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1231071, RefRangeEnd = 1231072, XrefRangeStart = 1230994, XrefRangeEnd = 1231071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TypeConstructor()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeUtility.TypeConstructor<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.TypeConstructor<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000229 RID: 553 RVA: 0x00009790 File Offset: 0x00007990
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1231095, RefRangeEnd = 1231096, XrefRangeStart = 1231072, XrefRangeEnd = 1231095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetImplicitConstructor()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.TypeConstructor<T>.NativeMethodInfoPtr_SetImplicitConstructor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600022A RID: 554 RVA: 0x000097C4 File Offset: 0x000079C4
			[CallerCount(0)]
			public unsafe static T CreateValueTypeInstance()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.TypeConstructor<T>.NativeMethodInfoPtr_CreateValueTypeInstance_Private_Static_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x0600022B RID: 555 RVA: 0x000097F4 File Offset: 0x000079F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231096, XrefRangeEnd = 1231105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static T CreateScriptableObjectInstance()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.TypeConstructor<T>.NativeMethodInfoPtr_CreateScriptableObjectInstance_Private_Static_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x0600022C RID: 556 RVA: 0x00009824 File Offset: 0x00007A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231105, XrefRangeEnd = 1231107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static T CreateClassInstance()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.TypeConstructor<T>.NativeMethodInfoPtr_CreateClassInstance_Private_Static_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x0600022D RID: 557 RVA: 0x00009854 File Offset: 0x00007A54
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void SetExplicitConstructor(Func<T> constructor)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructor);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.TypeConstructor<T>.NativeMethodInfoPtr_SetExplicitConstructor_Public_Virtual_Final_New_Void_Func_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600022E RID: 558 RVA: 0x00009898 File Offset: 0x00007A98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231107, XrefRangeEnd = 1231116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual T Unity_Properties_TypeUtility_ITypeConstructor_T__Instantiate()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.TypeConstructor<T>.NativeMethodInfoPtr_Unity_Properties_TypeUtility_ITypeConstructor_T__Instantiate_Private_Virtual_Final_New_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x0600022F RID: 559 RVA: 0x000098D4 File Offset: 0x00007AD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231116, XrefRangeEnd = 1231119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object Unity_Properties_TypeUtility_ITypeConstructor_Instantiate()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.TypeConstructor<T>.NativeMethodInfoPtr_Unity_Properties_TypeUtility_ITypeConstructor_Instantiate_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06000230 RID: 560 RVA: 0x000031D9 File Offset: 0x000013D9
			public TypeConstructor(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x06000231 RID: 561 RVA: 0x00009914 File Offset: 0x00007B14
			// (set) Token: 0x06000232 RID: 562 RVA: 0x000031E2 File Offset: 0x000013E2
			public unsafe Func<T> m_ExplicitConstructor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeUtility.TypeConstructor<T>.NativeFieldInfoPtr_m_ExplicitConstructor);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeUtility.TypeConstructor<T>.NativeFieldInfoPtr_m_ExplicitConstructor), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x06000233 RID: 563 RVA: 0x00009944 File Offset: 0x00007B44
			// (set) Token: 0x06000234 RID: 564 RVA: 0x00003201 File Offset: 0x00001401
			public unsafe Func<T> m_ImplicitConstructor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeUtility.TypeConstructor<T>.NativeFieldInfoPtr_m_ImplicitConstructor);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeUtility.TypeConstructor<T>.NativeFieldInfoPtr_m_ImplicitConstructor), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x06000235 RID: 565 RVA: 0x00009974 File Offset: 0x00007B74
			// (set) Token: 0x06000236 RID: 566 RVA: 0x00003220 File Offset: 0x00001420
			public unsafe IConstructor<T> m_OverrideConstructor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeUtility.TypeConstructor<T>.NativeFieldInfoPtr_m_OverrideConstructor);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConstructor<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeUtility.TypeConstructor<T>.NativeFieldInfoPtr_m_OverrideConstructor), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000105 RID: 261
			private static readonly IntPtr NativeFieldInfoPtr_m_ExplicitConstructor;

			// Token: 0x04000106 RID: 262
			private static readonly IntPtr NativeFieldInfoPtr_m_ImplicitConstructor;

			// Token: 0x04000107 RID: 263
			private static readonly IntPtr NativeFieldInfoPtr_m_OverrideConstructor;

			// Token: 0x04000108 RID: 264
			private static readonly IntPtr NativeMethodInfoPtr_Unity_Properties_TypeUtility_ITypeConstructor_get_CanBeInstantiated_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000109 RID: 265
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400010A RID: 266
			private static readonly IntPtr NativeMethodInfoPtr_SetImplicitConstructor_Private_Void_0;

			// Token: 0x0400010B RID: 267
			private static readonly IntPtr NativeMethodInfoPtr_CreateValueTypeInstance_Private_Static_T_0;

			// Token: 0x0400010C RID: 268
			private static readonly IntPtr NativeMethodInfoPtr_CreateScriptableObjectInstance_Private_Static_T_0;

			// Token: 0x0400010D RID: 269
			private static readonly IntPtr NativeMethodInfoPtr_CreateClassInstance_Private_Static_T_0;

			// Token: 0x0400010E RID: 270
			private static readonly IntPtr NativeMethodInfoPtr_SetExplicitConstructor_Public_Virtual_Final_New_Void_Func_1_T_0;

			// Token: 0x0400010F RID: 271
			private static readonly IntPtr NativeMethodInfoPtr_Unity_Properties_TypeUtility_ITypeConstructor_T__Instantiate_Private_Virtual_Final_New_T_0;

			// Token: 0x04000110 RID: 272
			private static readonly IntPtr NativeMethodInfoPtr_Unity_Properties_TypeUtility_ITypeConstructor_Instantiate_Private_Virtual_Final_New_Object_0;
		}

		// Token: 0x0200006A RID: 106
		public class NonConstructable : Object
		{
			// Token: 0x06000237 RID: 567 RVA: 0x000099A4 File Offset: 0x00007BA4
			// Note: this type is marked as 'beforefieldinit'.
			static NonConstructable()
			{
				Il2CppClassPointerStore<TypeUtility.NonConstructable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, "NonConstructable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeUtility.NonConstructable>.NativeClassPtr);
				TypeUtility.NonConstructable.NativeMethodInfoPtr_Unity_Properties_TypeUtility_ITypeConstructor_get_CanBeInstantiated_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.NonConstructable>.NativeClassPtr, 100663435);
				TypeUtility.NonConstructable.NativeMethodInfoPtr_Instantiate_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.NonConstructable>.NativeClassPtr, 100663436);
				TypeUtility.NonConstructable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.NonConstructable>.NativeClassPtr, 100663437);
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x06000238 RID: 568 RVA: 0x00009A0C File Offset: 0x00007C0C
			public unsafe virtual bool Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.NonConstructable.NativeMethodInfoPtr_Unity_Properties_TypeUtility_ITypeConstructor_get_CanBeInstantiated_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000239 RID: 569 RVA: 0x00009A48 File Offset: 0x00007C48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231119, XrefRangeEnd = 1231125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object Instantiate()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.NonConstructable.NativeMethodInfoPtr_Instantiate_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x0600023A RID: 570 RVA: 0x00009A88 File Offset: 0x00007C88
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NonConstructable()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeUtility.NonConstructable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.NonConstructable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600023B RID: 571 RVA: 0x0000323F File Offset: 0x0000143F
			public NonConstructable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000111 RID: 273
			private static readonly IntPtr NativeMethodInfoPtr_Unity_Properties_TypeUtility_ITypeConstructor_get_CanBeInstantiated_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000112 RID: 274
			private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Virtual_Final_New_Object_0;

			// Token: 0x04000113 RID: 275
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200006B RID: 107
		public sealed class Cache<T> : ValueType
		{
			// Token: 0x0600023C RID: 572 RVA: 0x00009AC4 File Offset: 0x00007CC4
			// Note: this type is marked as 'beforefieldinit'.
			static Cache()
			{
				Il2CppClassPointerStore<TypeUtility.Cache<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, "Cache`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeUtility.Cache<T>>.NativeClassPtr);
				TypeUtility.Cache<T>.NativeFieldInfoPtr_TypeConstructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeUtility.Cache<T>>.NativeClassPtr, "TypeConstructor");
			}

			// Token: 0x0600023D RID: 573 RVA: 0x00003248 File Offset: 0x00001448
			public Cache(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600023E RID: 574 RVA: 0x00003251 File Offset: 0x00001451
			public Cache()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeUtility.Cache<T>>.NativeClassPtr))
			{
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x0600023F RID: 575 RVA: 0x00009B40 File Offset: 0x00007D40
			// (set) Token: 0x06000240 RID: 576 RVA: 0x00003263 File Offset: 0x00001463
			public unsafe static TypeUtility.ITypeConstructor<T> TypeConstructor
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TypeUtility.Cache<T>.NativeFieldInfoPtr_TypeConstructor, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeUtility.ITypeConstructor<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TypeUtility.Cache<T>.NativeFieldInfoPtr_TypeConstructor, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000114 RID: 276
			private static readonly IntPtr NativeFieldInfoPtr_TypeConstructor;
		}

		// Token: 0x0200006C RID: 108
		public class TypeConstructorVisitor : Object
		{
			// Token: 0x06000241 RID: 577 RVA: 0x00009B68 File Offset: 0x00007D68
			// Note: this type is marked as 'beforefieldinit'.
			static TypeConstructorVisitor()
			{
				Il2CppClassPointerStore<TypeUtility.TypeConstructorVisitor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, "TypeConstructorVisitor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeUtility.TypeConstructorVisitor>.NativeClassPtr);
				TypeUtility.TypeConstructorVisitor.NativeFieldInfoPtr_TypeConstructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeUtility.TypeConstructorVisitor>.NativeClassPtr, "TypeConstructor");
				TypeUtility.TypeConstructorVisitor.NativeMethodInfoPtr_Visit_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.TypeConstructorVisitor>.NativeClassPtr, 100663438);
				TypeUtility.TypeConstructorVisitor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.TypeConstructorVisitor>.NativeClassPtr, 100663439);
			}

			// Token: 0x06000242 RID: 578 RVA: 0x00009BD0 File Offset: 0x00007DD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231125, XrefRangeEnd = 1231190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Visit<TContainer>()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.TypeConstructorVisitor.MethodInfoStoreGeneric_Visit_Public_Virtual_Final_New_Void_0<TContainer>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000243 RID: 579 RVA: 0x00009C04 File Offset: 0x00007E04
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TypeConstructorVisitor()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeUtility.TypeConstructorVisitor>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.TypeConstructorVisitor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000244 RID: 580 RVA: 0x00003275 File Offset: 0x00001475
			public TypeConstructorVisitor(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x06000245 RID: 581 RVA: 0x00009C40 File Offset: 0x00007E40
			// (set) Token: 0x06000246 RID: 582 RVA: 0x0000327E File Offset: 0x0000147E
			public unsafe TypeUtility.ITypeConstructor TypeConstructor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeUtility.TypeConstructorVisitor.NativeFieldInfoPtr_TypeConstructor);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeUtility.ITypeConstructor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeUtility.TypeConstructorVisitor.NativeFieldInfoPtr_TypeConstructor), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000115 RID: 277
			private static readonly IntPtr NativeFieldInfoPtr_TypeConstructor;

			// Token: 0x04000116 RID: 278
			private static readonly IntPtr NativeMethodInfoPtr_Visit_Public_Virtual_Final_New_Void_0;

			// Token: 0x04000117 RID: 279
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x020000B3 RID: 179
			private sealed class MethodInfoStoreGeneric_Visit_Public_Virtual_Final_New_Void_0<TContainer>
			{
				// Token: 0x04000197 RID: 407
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TypeUtility.TypeConstructorVisitor.NativeMethodInfoPtr_Visit_Public_Virtual_Final_New_Void_0, Il2CppClassPointerStore<TypeUtility.TypeConstructorVisitor>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x0200006D RID: 109
		[ObfuscatedName("Unity.Properties.TypeUtility+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000247 RID: 583 RVA: 0x00009C70 File Offset: 0x00007E70
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TypeUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeUtility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeUtility.__c>.NativeClassPtr);
				TypeUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeUtility.__c>.NativeClassPtr, "<>9");
				TypeUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.__c>.NativeClassPtr, 100663441);
				TypeUtility.__c.NativeMethodInfoPtr___cctor_b__11_0_Internal_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.__c>.NativeClassPtr, 100663442);
				TypeUtility.__c.NativeMethodInfoPtr___cctor_b__11_1_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.__c>.NativeClassPtr, 100663443);
				TypeUtility.__c.NativeMethodInfoPtr___cctor_b__11_2_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtility.__c>.NativeClassPtr, 100663444);
			}

			// Token: 0x06000248 RID: 584 RVA: 0x00009D00 File Offset: 0x00007F00
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeUtility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000249 RID: 585 RVA: 0x00009D3C File Offset: 0x00007F3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231190, XrefRangeEnd = 1231194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StringBuilder __cctor_b__11_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.__c.NativeMethodInfoPtr___cctor_b__11_0_Internal_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}

			// Token: 0x0600024A RID: 586 RVA: 0x00009D7C File Offset: 0x00007F7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__11_1(StringBuilder sb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.__c.NativeMethodInfoPtr___cctor_b__11_1_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600024B RID: 587 RVA: 0x00009DC0 File Offset: 0x00007FC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231194, XrefRangeEnd = 1231196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string __cctor_b__11_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtility.__c.NativeMethodInfoPtr___cctor_b__11_2_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600024C RID: 588 RVA: 0x0000329D File Offset: 0x0000149D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x0600024D RID: 589 RVA: 0x00009DF8 File Offset: 0x00007FF8
			// (set) Token: 0x0600024E RID: 590 RVA: 0x000032A6 File Offset: 0x000014A6
			public unsafe static TypeUtility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TypeUtility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeUtility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TypeUtility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000118 RID: 280
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000119 RID: 281
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400011A RID: 282
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__11_0_Internal_StringBuilder_0;

			// Token: 0x0400011B RID: 283
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__11_1_Internal_Void_StringBuilder_0;

			// Token: 0x0400011C RID: 284
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__11_2_Internal_String_0;
		}

		// Token: 0x0200006E RID: 110
		private sealed class MethodInfoStoreGeneric_CreateTypeConstructor_Private_Static_ITypeConstructor_1_T_0<T>
		{
			// Token: 0x0400011D RID: 285
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TypeUtility.NativeMethodInfoPtr_CreateTypeConstructor_Private_Static_ITypeConstructor_1_T_0, Il2CppClassPointerStore<TypeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200006F RID: 111
		private sealed class MethodInfoStoreGeneric_GetTypeConstructor_Private_Static_ITypeConstructor_1_T_0<T>
		{
			// Token: 0x0400011E RID: 286
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TypeUtility.NativeMethodInfoPtr_GetTypeConstructor_Private_Static_ITypeConstructor_1_T_0, Il2CppClassPointerStore<TypeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000070 RID: 112
		private sealed class MethodInfoStoreGeneric_CanBeInstantiated_Public_Static_Boolean_0<T>
		{
			// Token: 0x0400011F RID: 287
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TypeUtility.NativeMethodInfoPtr_CanBeInstantiated_Public_Static_Boolean_0, Il2CppClassPointerStore<TypeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000071 RID: 113
		private sealed class MethodInfoStoreGeneric_SetExplicitInstantiationMethod_Public_Static_Void_Func_1_T_0<T>
		{
			// Token: 0x04000120 RID: 288
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TypeUtility.NativeMethodInfoPtr_SetExplicitInstantiationMethod_Public_Static_Void_Func_1_T_0, Il2CppClassPointerStore<TypeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000072 RID: 114
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_0<T>
		{
			// Token: 0x04000121 RID: 289
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TypeUtility.NativeMethodInfoPtr_Instantiate_Public_Static_T_0, Il2CppClassPointerStore<TypeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000073 RID: 115
		private sealed class MethodInfoStoreGeneric_TryInstantiate_Public_Static_Boolean_byref_T_0<T>
		{
			// Token: 0x04000122 RID: 290
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TypeUtility.NativeMethodInfoPtr_TryInstantiate_Public_Static_Boolean_byref_T_0, Il2CppClassPointerStore<TypeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000074 RID: 116
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_Type_0<T>
		{
			// Token: 0x04000123 RID: 291
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TypeUtility.NativeMethodInfoPtr_Instantiate_Public_Static_T_Type_0, Il2CppClassPointerStore<TypeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000075 RID: 117
		private sealed class MethodInfoStoreGeneric_TryInstantiate_Public_Static_Boolean_Type_byref_T_0<T>
		{
			// Token: 0x04000124 RID: 292
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TypeUtility.NativeMethodInfoPtr_TryInstantiate_Public_Static_Boolean_Type_byref_T_0, Il2CppClassPointerStore<TypeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000076 RID: 118
		private sealed class MethodInfoStoreGeneric_InstantiateArray_Public_Static_TArray_Int32_0<TArray>
		{
			// Token: 0x04000125 RID: 293
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TypeUtility.NativeMethodInfoPtr_InstantiateArray_Public_Static_TArray_Int32_0, Il2CppClassPointerStore<TypeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArray>.NativeClassPtr)) }))));
		}

		// Token: 0x02000077 RID: 119
		private sealed class MethodInfoStoreGeneric_TryInstantiateArray_Public_Static_Boolean_Int32_byref_TArray_0<TArray>
		{
			// Token: 0x04000126 RID: 294
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TypeUtility.NativeMethodInfoPtr_TryInstantiateArray_Public_Static_Boolean_Int32_byref_TArray_0, Il2CppClassPointerStore<TypeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArray>.NativeClassPtr)) }))));
		}

		// Token: 0x02000078 RID: 120
		private sealed class MethodInfoStoreGeneric_InstantiateArray_Public_Static_TArray_Type_Int32_0<TArray>
		{
			// Token: 0x04000127 RID: 295
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TypeUtility.NativeMethodInfoPtr_InstantiateArray_Public_Static_TArray_Type_Int32_0, Il2CppClassPointerStore<TypeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArray>.NativeClassPtr)) }))));
		}

		// Token: 0x02000079 RID: 121
		private sealed class MethodInfoStoreGeneric_CheckCanBeInstantiated_Private_Static_Void_ITypeConstructor_1_T_0<T>
		{
			// Token: 0x04000128 RID: 296
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TypeUtility.NativeMethodInfoPtr_CheckCanBeInstantiated_Private_Static_Void_ITypeConstructor_1_T_0, Il2CppClassPointerStore<TypeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200007A RID: 122
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
