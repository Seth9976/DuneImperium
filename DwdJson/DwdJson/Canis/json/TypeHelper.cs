using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.json
{
	// Token: 0x02000018 RID: 24
	public static class TypeHelper : Object
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x000055DC File Offset: 0x000037DC
		// Note: this type is marked as 'beforefieldinit'.
		static TypeHelper()
		{
			Il2CppClassPointerStore<TypeHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json", "TypeHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeHelper>.NativeClassPtr);
			TypeHelper.NativeFieldInfoPtr_typeAttributeLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeHelper>.NativeClassPtr, "typeAttributeLookup");
			TypeHelper.NativeFieldInfoPtr_DwdJsonMessageAttributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeHelper>.NativeClassPtr, "DwdJsonMessageAttributeType");
			TypeHelper.NativeFieldInfoPtr_enumNameLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeHelper>.NativeClassPtr, "enumNameLookup");
			TypeHelper.NativeFieldInfoPtr_enumValueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeHelper>.NativeClassPtr, "enumValueLookup");
			TypeHelper.NativeFieldInfoPtr_cachedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeHelper>.NativeClassPtr, "cachedTypes");
			TypeHelper.NativeFieldInfoPtr_EPOCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeHelper>.NativeClassPtr, "EPOCH");
			TypeHelper.NativeMethodInfoPtr_HasAttribute_Public_Static_Boolean_MemberInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeHelper>.NativeClassPtr, 100663391);
			TypeHelper.NativeMethodInfoPtr_GetAttribute_Public_Static_Attribute_MemberInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeHelper>.NativeClassPtr, 100663392);
			TypeHelper.NativeMethodInfoPtr_GetAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeHelper>.NativeClassPtr, 100663393);
			TypeHelper.NativeMethodInfoPtr_GetAttributesInternal_Private_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeHelper>.NativeClassPtr, 100663394);
			TypeHelper.NativeMethodInfoPtr_MessageNameFromType_Public_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeHelper>.NativeClassPtr, 100663395);
			TypeHelper.NativeMethodInfoPtr_MessageName_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeHelper>.NativeClassPtr, 100663396);
			TypeHelper.NativeMethodInfoPtr_TryEnumConvert_Public_Static_Boolean_String_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeHelper>.NativeClassPtr, 100663397);
			TypeHelper.NativeMethodInfoPtr_TryConvertTo_Public_Static_Boolean_Object_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeHelper>.NativeClassPtr, 100663398);
			TypeHelper.NativeMethodInfoPtr_ToUnixTimeMilliseconds_Public_Static_Int64_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeHelper>.NativeClassPtr, 100663399);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00005738 File Offset: 0x00003938
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1249287, RefRangeEnd = 1249292, XrefRangeStart = 1249282, XrefRangeEnd = 1249287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasAttribute(this MemberInfo type, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeHelper.NativeMethodInfoPtr_HasAttribute_Public_Static_Boolean_MemberInfo_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000578C File Offset: 0x0000398C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1249296, RefRangeEnd = 1249298, XrefRangeStart = 1249292, XrefRangeEnd = 1249296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Attribute GetAttribute(this MemberInfo type, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeHelper.NativeMethodInfoPtr_GetAttribute_Public_Static_Attribute_MemberInfo_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000057E4 File Offset: 0x000039E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249298, XrefRangeEnd = 1249302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> GetAttributes(this MemberInfo type, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeHelper.NativeMethodInfoPtr_GetAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000583C File Offset: 0x00003A3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1249320, RefRangeEnd = 1249323, XrefRangeStart = 1249302, XrefRangeEnd = 1249320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> GetAttributesInternal(MemberInfo type, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeHelper.NativeMethodInfoPtr_GetAttributesInternal_Private_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00005894 File Offset: 0x00003A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249323, XrefRangeEnd = 1249327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MessageNameFromType(this Type messageType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(messageType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeHelper.NativeMethodInfoPtr_MessageNameFromType_Public_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000058D0 File Offset: 0x00003AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249327, XrefRangeEnd = 1249335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MessageName(this Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeHelper.NativeMethodInfoPtr_MessageName_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000590C File Offset: 0x00003B0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1249408, RefRangeEnd = 1249410, XrefRangeStart = 1249335, XrefRangeEnd = 1249408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryEnumConvert(this string source, Type targetType, out Object result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TypeHelper.NativeMethodInfoPtr_TryEnumConvert_Public_Static_Boolean_String_Type_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005984 File Offset: 0x00003B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249410, XrefRangeEnd = 1249492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertTo(this Object source, Type targetType, out Object result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TypeHelper.NativeMethodInfoPtr_TryConvertTo_Public_Static_Boolean_Object_Type_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000059FC File Offset: 0x00003BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249492, XrefRangeEnd = 1249504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToUnixTimeMilliseconds(this DateTime dateTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeHelper.NativeMethodInfoPtr_ToUnixTimeMilliseconds_Public_Static_Int64_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002532 File Offset: 0x00000732
		public TypeHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00005A3C File Offset: 0x00003C3C
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x0000253B File Offset: 0x0000073B
		public unsafe static ConcurrentDictionary<TypeHelper.MemberInfoTypePair, Il2CppReferenceArray<Attribute>> typeAttributeLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeHelper.NativeFieldInfoPtr_typeAttributeLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<TypeHelper.MemberInfoTypePair, Il2CppReferenceArray<Attribute>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeHelper.NativeFieldInfoPtr_typeAttributeLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00005A64 File Offset: 0x00003C64
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x0000254D File Offset: 0x0000074D
		public unsafe static Type DwdJsonMessageAttributeType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeHelper.NativeFieldInfoPtr_DwdJsonMessageAttributeType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeHelper.NativeFieldInfoPtr_DwdJsonMessageAttributeType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00005A8C File Offset: 0x00003C8C
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x0000255F File Offset: 0x0000075F
		public unsafe static Dictionary<Type, Array> enumNameLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeHelper.NativeFieldInfoPtr_enumNameLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, Array>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeHelper.NativeFieldInfoPtr_enumNameLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00005AB4 File Offset: 0x00003CB4
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00002571 File Offset: 0x00000771
		public unsafe static Dictionary<Type, Array> enumValueLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeHelper.NativeFieldInfoPtr_enumValueLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, Array>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeHelper.NativeFieldInfoPtr_enumValueLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00005ADC File Offset: 0x00003CDC
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00002583 File Offset: 0x00000783
		public unsafe static Il2CppReferenceArray<Type> cachedTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeHelper.NativeFieldInfoPtr_cachedTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeHelper.NativeFieldInfoPtr_cachedTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00005B04 File Offset: 0x00003D04
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00002595 File Offset: 0x00000795
		public unsafe static DateTime EPOCH
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(TypeHelper.NativeFieldInfoPtr_EPOCH, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeHelper.NativeFieldInfoPtr_EPOCH, (void*)(&value));
			}
		}

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_typeAttributeLookup;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_DwdJsonMessageAttributeType;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_enumNameLookup;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_enumValueLookup;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_cachedTypes;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_EPOCH;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_HasAttribute_Public_Static_Boolean_MemberInfo_Type_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Static_Attribute_MemberInfo_Type_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_Type_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributesInternal_Private_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_Type_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_MessageNameFromType_Public_Static_String_Type_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_MessageName_Public_Static_String_Object_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_TryEnumConvert_Public_Static_Boolean_String_Type_byref_Object_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertTo_Public_Static_Boolean_Object_Type_byref_Object_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_ToUnixTimeMilliseconds_Public_Static_Int64_DateTime_0;

		// Token: 0x0200002A RID: 42
		public sealed class MemberInfoTypePair : ValueType
		{
			// Token: 0x06000137 RID: 311 RVA: 0x00006BB4 File Offset: 0x00004DB4
			// Note: this type is marked as 'beforefieldinit'.
			static MemberInfoTypePair()
			{
				Il2CppClassPointerStore<TypeHelper.MemberInfoTypePair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeHelper>.NativeClassPtr, "MemberInfoTypePair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeHelper.MemberInfoTypePair>.NativeClassPtr);
				TypeHelper.MemberInfoTypePair.NativeFieldInfoPtr_memberInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeHelper.MemberInfoTypePair>.NativeClassPtr, "memberInfo");
				TypeHelper.MemberInfoTypePair.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeHelper.MemberInfoTypePair>.NativeClassPtr, "type");
				TypeHelper.MemberInfoTypePair.NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeHelper.MemberInfoTypePair>.NativeClassPtr, 100663401);
				TypeHelper.MemberInfoTypePair.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeHelper.MemberInfoTypePair>.NativeClassPtr, 100663402);
				TypeHelper.MemberInfoTypePair.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MemberInfoTypePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeHelper.MemberInfoTypePair>.NativeClassPtr, 100663403);
			}

			// Token: 0x06000138 RID: 312 RVA: 0x00006C44 File Offset: 0x00004E44
			[CallerCount(238)]
			[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MemberInfoTypePair(MemberInfo memberInfo, Type type)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeHelper.MemberInfoTypePair>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeHelper.MemberInfoTypePair.NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000139 RID: 313 RVA: 0x00006CA8 File Offset: 0x00004EA8
			[CallerCount(0)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeHelper.MemberInfoTypePair.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600013A RID: 314 RVA: 0x00006CEC File Offset: 0x00004EEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249280, XrefRangeEnd = 1249282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals(TypeHelper.MemberInfoTypePair other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeHelper.MemberInfoTypePair.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MemberInfoTypePair_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600013B RID: 315 RVA: 0x0000281B File Offset: 0x00000A1B
			public MemberInfoTypePair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600013C RID: 316 RVA: 0x00002824 File Offset: 0x00000A24
			public MemberInfoTypePair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeHelper.MemberInfoTypePair>.NativeClassPtr))
			{
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x0600013D RID: 317 RVA: 0x00006D44 File Offset: 0x00004F44
			// (set) Token: 0x0600013E RID: 318 RVA: 0x00002836 File Offset: 0x00000A36
			public unsafe MemberInfo memberInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeHelper.MemberInfoTypePair.NativeFieldInfoPtr_memberInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeHelper.MemberInfoTypePair.NativeFieldInfoPtr_memberInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x0600013F RID: 319 RVA: 0x00006D74 File Offset: 0x00004F74
			// (set) Token: 0x06000140 RID: 320 RVA: 0x00002855 File Offset: 0x00000A55
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeHelper.MemberInfoTypePair.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeHelper.MemberInfoTypePair.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000B1 RID: 177
			private static readonly IntPtr NativeFieldInfoPtr_memberInfo;

			// Token: 0x040000B2 RID: 178
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x040000B3 RID: 179
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_Type_0;

			// Token: 0x040000B4 RID: 180
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x040000B5 RID: 181
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MemberInfoTypePair_0;
		}
	}
}
