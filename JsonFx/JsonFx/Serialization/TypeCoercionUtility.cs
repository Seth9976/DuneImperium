using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using JsonFx.Serialization.Resolvers;

namespace JsonFx.Serialization
{
	// Token: 0x02000012 RID: 18
	public sealed class TypeCoercionUtility : Object
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x000067BC File Offset: 0x000049BC
		// Note: this type is marked as 'beforefieldinit'.
		static TypeCoercionUtility()
		{
			Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization", "TypeCoercionUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr);
			TypeCoercionUtility.NativeFieldInfoPtr_AnonymousTypePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, "AnonymousTypePrefix");
			TypeCoercionUtility.NativeFieldInfoPtr_TypeGenericIEnumerable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, "TypeGenericIEnumerable");
			TypeCoercionUtility.NativeFieldInfoPtr_TypeGenericICollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, "TypeGenericICollection");
			TypeCoercionUtility.NativeFieldInfoPtr_TypeGenericIDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, "TypeGenericIDictionary");
			TypeCoercionUtility.NativeFieldInfoPtr_ErrorCtor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, "ErrorCtor");
			TypeCoercionUtility.NativeFieldInfoPtr_ErrorGenericIDictionaryKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, "ErrorGenericIDictionaryKeys");
			TypeCoercionUtility.NativeFieldInfoPtr_ResolverCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, "ResolverCache");
			TypeCoercionUtility.NativeMethodInfoPtr__ctor_Public_Void_ResolverCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, 100663381);
			TypeCoercionUtility.NativeMethodInfoPtr_InstantiateObjectDefaultCtor_Public_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, 100663382);
			TypeCoercionUtility.NativeMethodInfoPtr_InstantiateObject_Internal_Object_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, 100663383);
			TypeCoercionUtility.NativeMethodInfoPtr_SetMemberValue_Public_Void_Object_MemberMap_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, 100663384);
			TypeCoercionUtility.NativeMethodInfoPtr_CoerceType_Public_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, 100663385);
			TypeCoercionUtility.NativeMethodInfoPtr_CoerceType_Public_Object_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, 100663386);
			TypeCoercionUtility.NativeMethodInfoPtr_ParseEnumOrUnsetObject_Public_Static_Object_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, 100663387);
			TypeCoercionUtility.NativeMethodInfoPtr_CoerceType_Private_Object_Type_IDictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, 100663388);
			TypeCoercionUtility.NativeMethodInfoPtr_CoerceType_Private_Object_Type_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, 100663389);
			TypeCoercionUtility.NativeMethodInfoPtr_CoerceList_Private_Object_Type_Type_IEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, 100663390);
			TypeCoercionUtility.NativeMethodInfoPtr_CoerceCollection_Public_Object_Type_Type_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, 100663391);
			TypeCoercionUtility.NativeMethodInfoPtr_CoerceArray_Private_Array_Type_IEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, 100663392);
			TypeCoercionUtility.NativeMethodInfoPtr_ResolveInterfaceType_Private_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, 100663393);
			TypeCoercionUtility.NativeMethodInfoPtr_GetDictionaryItemType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, 100663394);
			TypeCoercionUtility.NativeMethodInfoPtr_GetElementType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, 100663395);
			TypeCoercionUtility.NativeMethodInfoPtr_FindCommonType_Public_Static_Type_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr, 100663396);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000069B8 File Offset: 0x00004BB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1189906, RefRangeEnd = 1189909, XrefRangeStart = 1189898, XrefRangeEnd = 1189906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeCoercionUtility(ResolverCache resolverCache)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolverCache);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionUtility.NativeMethodInfoPtr__ctor_Public_Void_ResolverCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00006A04 File Offset: 0x00004C04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1189943, RefRangeEnd = 1189945, XrefRangeStart = 1189909, XrefRangeEnd = 1189943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object InstantiateObjectDefaultCtor(Type targetType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionUtility.NativeMethodInfoPtr_InstantiateObjectDefaultCtor_Public_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00006A54 File Offset: 0x00004C54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1190015, RefRangeEnd = 1190017, XrefRangeStart = 1189945, XrefRangeEnd = 1190015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object InstantiateObject(Type targetType, Object args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionUtility.NativeMethodInfoPtr_InstantiateObject_Internal_Object_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00006AB8 File Offset: 0x00004CB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1190024, RefRangeEnd = 1190025, XrefRangeStart = 1190017, XrefRangeEnd = 1190024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMemberValue(Object target, MemberMap memberMap, string memberName, Object memberValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberMap);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionUtility.NativeMethodInfoPtr_SetMemberValue_Public_Void_Object_MemberMap_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00006B34 File Offset: 0x00004D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190025, XrefRangeEnd = 1190035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T CoerceType<T>(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionUtility.MethodInfoStoreGeneric_CoerceType_Public_T_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00006B80 File Offset: 0x00004D80
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1190210, RefRangeEnd = 1190220, XrefRangeStart = 1190035, XrefRangeEnd = 1190210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CoerceType(Type targetType, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionUtility.NativeMethodInfoPtr_CoerceType_Public_Object_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00006BE4 File Offset: 0x00004DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190220, XrefRangeEnd = 1190232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ParseEnumOrUnsetObject(Type targetType, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionUtility.NativeMethodInfoPtr_ParseEnumOrUnsetObject_Public_Static_Object_Type_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00006C3C File Offset: 0x00004E3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1190305, RefRangeEnd = 1190306, XrefRangeStart = 1190232, XrefRangeEnd = 1190305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CoerceType(Type targetType, IDictionary<string, Object> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionUtility.NativeMethodInfoPtr_CoerceType_Private_Object_Type_IDictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00006CA0 File Offset: 0x00004EA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1190395, RefRangeEnd = 1190396, XrefRangeStart = 1190306, XrefRangeEnd = 1190395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CoerceType(Type targetType, IDictionary value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionUtility.NativeMethodInfoPtr_CoerceType_Private_Object_Type_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00006D04 File Offset: 0x00004F04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1190451, RefRangeEnd = 1190453, XrefRangeStart = 1190396, XrefRangeEnd = 1190451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CoerceList(Type targetType, Type valueType, IEnumerable value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionUtility.NativeMethodInfoPtr_CoerceList_Private_Object_Type_Type_IEnumerable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00006D78 File Offset: 0x00004F78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1190467, RefRangeEnd = 1190469, XrefRangeStart = 1190453, XrefRangeEnd = 1190467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CoerceCollection(Type targetType, Type itemType, ICollection value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(itemType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionUtility.NativeMethodInfoPtr_CoerceCollection_Public_Object_Type_Type_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00006DEC File Offset: 0x00004FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190469, XrefRangeEnd = 1190510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Array CoerceArray(Type itemType, IEnumerable value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionUtility.NativeMethodInfoPtr_CoerceArray_Private_Array_Type_IEnumerable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00006E50 File Offset: 0x00005050
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1190540, RefRangeEnd = 1190543, XrefRangeStart = 1190510, XrefRangeEnd = 1190540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type ResolveInterfaceType(Type targetType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionUtility.NativeMethodInfoPtr_ResolveInterfaceType_Private_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00006E94 File Offset: 0x00005094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1190558, RefRangeEnd = 1190559, XrefRangeStart = 1190543, XrefRangeEnd = 1190558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetDictionaryItemType(Type targetType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionUtility.NativeMethodInfoPtr_GetDictionaryItemType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00006ED8 File Offset: 0x000050D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1190584, RefRangeEnd = 1190586, XrefRangeStart = 1190559, XrefRangeEnd = 1190584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetElementType(Type targetType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionUtility.NativeMethodInfoPtr_GetElementType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00006F1C File Offset: 0x0000511C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1190592, RefRangeEnd = 1190593, XrefRangeStart = 1190586, XrefRangeEnd = 1190592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type FindCommonType(Type itemType, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionUtility.NativeMethodInfoPtr_FindCommonType_Public_Static_Type_Type_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000024BB File Offset: 0x000006BB
		public TypeCoercionUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00006F74 File Offset: 0x00005174
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x000024C4 File Offset: 0x000006C4
		public unsafe static string AnonymousTypePrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeCoercionUtility.NativeFieldInfoPtr_AnonymousTypePrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeCoercionUtility.NativeFieldInfoPtr_AnonymousTypePrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00006F94 File Offset: 0x00005194
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x000024D6 File Offset: 0x000006D6
		public unsafe static string TypeGenericIEnumerable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeCoercionUtility.NativeFieldInfoPtr_TypeGenericIEnumerable, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeCoercionUtility.NativeFieldInfoPtr_TypeGenericIEnumerable, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00006FB4 File Offset: 0x000051B4
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x000024E8 File Offset: 0x000006E8
		public unsafe static string TypeGenericICollection
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeCoercionUtility.NativeFieldInfoPtr_TypeGenericICollection, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeCoercionUtility.NativeFieldInfoPtr_TypeGenericICollection, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00006FD4 File Offset: 0x000051D4
		// (set) Token: 0x060000DA RID: 218 RVA: 0x000024FA File Offset: 0x000006FA
		public unsafe static string TypeGenericIDictionary
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeCoercionUtility.NativeFieldInfoPtr_TypeGenericIDictionary, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeCoercionUtility.NativeFieldInfoPtr_TypeGenericIDictionary, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00006FF4 File Offset: 0x000051F4
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000250C File Offset: 0x0000070C
		public unsafe static string ErrorCtor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeCoercionUtility.NativeFieldInfoPtr_ErrorCtor, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeCoercionUtility.NativeFieldInfoPtr_ErrorCtor, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00007014 File Offset: 0x00005214
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0000251E File Offset: 0x0000071E
		public unsafe static string ErrorGenericIDictionaryKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeCoercionUtility.NativeFieldInfoPtr_ErrorGenericIDictionaryKeys, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeCoercionUtility.NativeFieldInfoPtr_ErrorGenericIDictionaryKeys, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00007034 File Offset: 0x00005234
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00002530 File Offset: 0x00000730
		public unsafe ResolverCache ResolverCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeCoercionUtility.NativeFieldInfoPtr_ResolverCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolverCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeCoercionUtility.NativeFieldInfoPtr_ResolverCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_AnonymousTypePrefix;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_TypeGenericIEnumerable;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_TypeGenericICollection;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_TypeGenericIDictionary;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_ErrorCtor;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_ErrorGenericIDictionaryKeys;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_ResolverCache;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResolverCache_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateObjectDefaultCtor_Public_Object_Type_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateObject_Internal_Object_Type_Object_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_SetMemberValue_Public_Void_Object_MemberMap_String_Object_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_CoerceType_Public_T_Object_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_CoerceType_Public_Object_Type_Object_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_ParseEnumOrUnsetObject_Public_Static_Object_Type_Object_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_CoerceType_Private_Object_Type_IDictionary_2_String_Object_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_CoerceType_Private_Object_Type_IDictionary_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_CoerceList_Private_Object_Type_Type_IEnumerable_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_CoerceCollection_Public_Object_Type_Type_ICollection_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_CoerceArray_Private_Array_Type_IEnumerable_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_ResolveInterfaceType_Private_Static_Type_Type_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_GetDictionaryItemType_Public_Static_Type_Type_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_GetElementType_Public_Static_Type_Type_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_FindCommonType_Public_Static_Type_Type_Object_0;

		// Token: 0x0200003D RID: 61
		private sealed class MethodInfoStoreGeneric_CoerceType_Public_T_Object_0<T>
		{
			// Token: 0x04000219 RID: 537
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TypeCoercionUtility.NativeMethodInfoPtr_CoerceType_Public_T_Object_0, Il2CppClassPointerStore<TypeCoercionUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
