using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Properties
{
	// Token: 0x0200001D RID: 29
	public static class TypeTraits<T> : Object
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x000060DC File Offset: 0x000042DC
		// Note: this type is marked as 'beforefieldinit'.
		static TypeTraits()
		{
			Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "TypeTraits`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			TypeTraits<T>.NativeFieldInfoPtr__IsValueType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, "<IsValueType>k__BackingField");
			TypeTraits<T>.NativeFieldInfoPtr__IsPrimitive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, "<IsPrimitive>k__BackingField");
			TypeTraits<T>.NativeFieldInfoPtr__IsInterface_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, "<IsInterface>k__BackingField");
			TypeTraits<T>.NativeFieldInfoPtr__IsAbstract_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, "<IsAbstract>k__BackingField");
			TypeTraits<T>.NativeFieldInfoPtr__IsArray_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, "<IsArray>k__BackingField");
			TypeTraits<T>.NativeFieldInfoPtr__IsMultidimensionalArray_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, "<IsMultidimensionalArray>k__BackingField");
			TypeTraits<T>.NativeFieldInfoPtr__IsEnum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, "<IsEnum>k__BackingField");
			TypeTraits<T>.NativeFieldInfoPtr__IsEnumFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, "<IsEnumFlags>k__BackingField");
			TypeTraits<T>.NativeFieldInfoPtr__IsNullable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, "<IsNullable>k__BackingField");
			TypeTraits<T>.NativeFieldInfoPtr__IsObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, "<IsObject>k__BackingField");
			TypeTraits<T>.NativeFieldInfoPtr__IsString_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, "<IsString>k__BackingField");
			TypeTraits<T>.NativeFieldInfoPtr__IsContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, "<IsContainer>k__BackingField");
			TypeTraits<T>.NativeFieldInfoPtr__CanBeNull_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, "<CanBeNull>k__BackingField");
			TypeTraits<T>.NativeFieldInfoPtr__IsPrimitiveOrString_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, "<IsPrimitiveOrString>k__BackingField");
			TypeTraits<T>.NativeFieldInfoPtr__IsAbstractOrInterface_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, "<IsAbstractOrInterface>k__BackingField");
			TypeTraits<T>.NativeFieldInfoPtr__IsUnityObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, "<IsUnityObject>k__BackingField");
			TypeTraits<T>.NativeFieldInfoPtr__IsLazyLoadReference_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, "<IsLazyLoadReference>k__BackingField");
			TypeTraits<T>.NativeMethodInfoPtr_get_IsValueType_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, 100663385);
			TypeTraits<T>.NativeMethodInfoPtr_get_IsPrimitive_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, 100663386);
			TypeTraits<T>.NativeMethodInfoPtr_get_IsInterface_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, 100663387);
			TypeTraits<T>.NativeMethodInfoPtr_get_IsAbstract_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, 100663388);
			TypeTraits<T>.NativeMethodInfoPtr_get_IsArray_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, 100663389);
			TypeTraits<T>.NativeMethodInfoPtr_get_IsEnum_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, 100663390);
			TypeTraits<T>.NativeMethodInfoPtr_get_IsNullable_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, 100663391);
			TypeTraits<T>.NativeMethodInfoPtr_get_IsObject_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, 100663392);
			TypeTraits<T>.NativeMethodInfoPtr_get_IsString_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, 100663393);
			TypeTraits<T>.NativeMethodInfoPtr_get_IsContainer_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, 100663394);
			TypeTraits<T>.NativeMethodInfoPtr_get_CanBeNull_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, 100663395);
			TypeTraits<T>.NativeMethodInfoPtr_get_IsAbstractOrInterface_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTraits<T>>.NativeClassPtr, 100663396);
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00006384 File Offset: 0x00004584
		public unsafe static bool IsValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230941, XrefRangeEnd = 1230945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTraits<T>.NativeMethodInfoPtr_get_IsValueType_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x000063B4 File Offset: 0x000045B4
		public unsafe static bool IsPrimitive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230945, XrefRangeEnd = 1230949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTraits<T>.NativeMethodInfoPtr_get_IsPrimitive_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000EA RID: 234 RVA: 0x000063E4 File Offset: 0x000045E4
		public unsafe static bool IsInterface
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230949, XrefRangeEnd = 1230953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTraits<T>.NativeMethodInfoPtr_get_IsInterface_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00006414 File Offset: 0x00004614
		public unsafe static bool IsAbstract
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230953, XrefRangeEnd = 1230957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTraits<T>.NativeMethodInfoPtr_get_IsAbstract_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00006444 File Offset: 0x00004644
		public unsafe static bool IsArray
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230957, XrefRangeEnd = 1230961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTraits<T>.NativeMethodInfoPtr_get_IsArray_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00006474 File Offset: 0x00004674
		public unsafe static bool IsEnum
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230961, XrefRangeEnd = 1230965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTraits<T>.NativeMethodInfoPtr_get_IsEnum_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000064A4 File Offset: 0x000046A4
		public unsafe static bool IsNullable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230965, XrefRangeEnd = 1230969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTraits<T>.NativeMethodInfoPtr_get_IsNullable_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000064D4 File Offset: 0x000046D4
		public unsafe static bool IsObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230969, XrefRangeEnd = 1230973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTraits<T>.NativeMethodInfoPtr_get_IsObject_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00006504 File Offset: 0x00004704
		public unsafe static bool IsString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230973, XrefRangeEnd = 1230977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTraits<T>.NativeMethodInfoPtr_get_IsString_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00006534 File Offset: 0x00004734
		public unsafe static bool IsContainer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230977, XrefRangeEnd = 1230981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTraits<T>.NativeMethodInfoPtr_get_IsContainer_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00006564 File Offset: 0x00004764
		public unsafe static bool CanBeNull
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230981, XrefRangeEnd = 1230985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTraits<T>.NativeMethodInfoPtr_get_CanBeNull_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00006594 File Offset: 0x00004794
		public unsafe static bool IsAbstractOrInterface
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230985, XrefRangeEnd = 1230989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTraits<T>.NativeMethodInfoPtr_get_IsAbstractOrInterface_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002726 File Offset: 0x00000926
		public TypeTraits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000065C4 File Offset: 0x000047C4
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000272F File Offset: 0x0000092F
		public unsafe static bool _IsValueType_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeTraits<T>.NativeFieldInfoPtr__IsValueType_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTraits<T>.NativeFieldInfoPtr__IsValueType_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x000065E0 File Offset: 0x000047E0
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000273D File Offset: 0x0000093D
		public unsafe static bool _IsPrimitive_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeTraits<T>.NativeFieldInfoPtr__IsPrimitive_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTraits<T>.NativeFieldInfoPtr__IsPrimitive_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x000065FC File Offset: 0x000047FC
		// (set) Token: 0x060000FA RID: 250 RVA: 0x0000274B File Offset: 0x0000094B
		public unsafe static bool _IsInterface_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeTraits<T>.NativeFieldInfoPtr__IsInterface_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTraits<T>.NativeFieldInfoPtr__IsInterface_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00006618 File Offset: 0x00004818
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002759 File Offset: 0x00000959
		public unsafe static bool _IsAbstract_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeTraits<T>.NativeFieldInfoPtr__IsAbstract_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTraits<T>.NativeFieldInfoPtr__IsAbstract_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00006634 File Offset: 0x00004834
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002767 File Offset: 0x00000967
		public unsafe static bool _IsArray_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeTraits<T>.NativeFieldInfoPtr__IsArray_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTraits<T>.NativeFieldInfoPtr__IsArray_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00006650 File Offset: 0x00004850
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00002775 File Offset: 0x00000975
		public unsafe static bool _IsMultidimensionalArray_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeTraits<T>.NativeFieldInfoPtr__IsMultidimensionalArray_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTraits<T>.NativeFieldInfoPtr__IsMultidimensionalArray_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000666C File Offset: 0x0000486C
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00002783 File Offset: 0x00000983
		public unsafe static bool _IsEnum_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeTraits<T>.NativeFieldInfoPtr__IsEnum_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTraits<T>.NativeFieldInfoPtr__IsEnum_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00006688 File Offset: 0x00004888
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00002791 File Offset: 0x00000991
		public unsafe static bool _IsEnumFlags_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeTraits<T>.NativeFieldInfoPtr__IsEnumFlags_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTraits<T>.NativeFieldInfoPtr__IsEnumFlags_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000066A4 File Offset: 0x000048A4
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0000279F File Offset: 0x0000099F
		public unsafe static bool _IsNullable_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeTraits<T>.NativeFieldInfoPtr__IsNullable_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTraits<T>.NativeFieldInfoPtr__IsNullable_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000107 RID: 263 RVA: 0x000066C0 File Offset: 0x000048C0
		// (set) Token: 0x06000108 RID: 264 RVA: 0x000027AD File Offset: 0x000009AD
		public unsafe static bool _IsObject_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeTraits<T>.NativeFieldInfoPtr__IsObject_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTraits<T>.NativeFieldInfoPtr__IsObject_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000109 RID: 265 RVA: 0x000066DC File Offset: 0x000048DC
		// (set) Token: 0x0600010A RID: 266 RVA: 0x000027BB File Offset: 0x000009BB
		public unsafe static bool _IsString_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeTraits<T>.NativeFieldInfoPtr__IsString_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTraits<T>.NativeFieldInfoPtr__IsString_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600010B RID: 267 RVA: 0x000066F8 File Offset: 0x000048F8
		// (set) Token: 0x0600010C RID: 268 RVA: 0x000027C9 File Offset: 0x000009C9
		public unsafe static bool _IsContainer_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeTraits<T>.NativeFieldInfoPtr__IsContainer_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTraits<T>.NativeFieldInfoPtr__IsContainer_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00006714 File Offset: 0x00004914
		// (set) Token: 0x0600010E RID: 270 RVA: 0x000027D7 File Offset: 0x000009D7
		public unsafe static bool _CanBeNull_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeTraits<T>.NativeFieldInfoPtr__CanBeNull_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTraits<T>.NativeFieldInfoPtr__CanBeNull_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00006730 File Offset: 0x00004930
		// (set) Token: 0x06000110 RID: 272 RVA: 0x000027E5 File Offset: 0x000009E5
		public unsafe static bool _IsPrimitiveOrString_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeTraits<T>.NativeFieldInfoPtr__IsPrimitiveOrString_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTraits<T>.NativeFieldInfoPtr__IsPrimitiveOrString_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000674C File Offset: 0x0000494C
		// (set) Token: 0x06000112 RID: 274 RVA: 0x000027F3 File Offset: 0x000009F3
		public unsafe static bool _IsAbstractOrInterface_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeTraits<T>.NativeFieldInfoPtr__IsAbstractOrInterface_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTraits<T>.NativeFieldInfoPtr__IsAbstractOrInterface_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00006768 File Offset: 0x00004968
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00002801 File Offset: 0x00000A01
		public unsafe static bool _IsUnityObject_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeTraits<T>.NativeFieldInfoPtr__IsUnityObject_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTraits<T>.NativeFieldInfoPtr__IsUnityObject_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00006784 File Offset: 0x00004984
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0000280F File Offset: 0x00000A0F
		public unsafe static bool _IsLazyLoadReference_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeTraits<T>.NativeFieldInfoPtr__IsLazyLoadReference_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTraits<T>.NativeFieldInfoPtr__IsLazyLoadReference_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000281D File Offset: 0x00000A1D
		public static bool IsMultidimensionalArray
		{
			get
			{
				return TypeTraits._IsMultidimensionalArray_k__BackingField;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00002824 File Offset: 0x00000A24
		public static bool IsEnumFlags
		{
			get
			{
				return TypeTraits._IsEnumFlags_k__BackingField;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000282B File Offset: 0x00000A2B
		public static bool IsPrimitiveOrString
		{
			get
			{
				return TypeTraits._IsPrimitiveOrString_k__BackingField;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00002832 File Offset: 0x00000A32
		public static bool IsUnityObject
		{
			get
			{
				return TypeTraits._IsUnityObject_k__BackingField;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00002839 File Offset: 0x00000A39
		public static bool IsLazyLoadReference
		{
			get
			{
				return TypeTraits._IsLazyLoadReference_k__BackingField;
			}
		}

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr__IsValueType_k__BackingField;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr__IsPrimitive_k__BackingField;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr__IsInterface_k__BackingField;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr__IsAbstract_k__BackingField;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr__IsArray_k__BackingField;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr__IsMultidimensionalArray_k__BackingField;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr__IsEnum_k__BackingField;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr__IsEnumFlags_k__BackingField;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr__IsNullable_k__BackingField;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr__IsObject_k__BackingField;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr__IsString_k__BackingField;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr__IsContainer_k__BackingField;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr__CanBeNull_k__BackingField;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr__IsPrimitiveOrString_k__BackingField;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr__IsAbstractOrInterface_k__BackingField;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr__IsUnityObject_k__BackingField;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr__IsLazyLoadReference_k__BackingField;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValueType_Public_Static_get_Boolean_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPrimitive_Public_Static_get_Boolean_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInterface_Public_Static_get_Boolean_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAbstract_Public_Static_get_Boolean_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_get_IsArray_Public_Static_get_Boolean_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnum_Public_Static_get_Boolean_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_Static_get_Boolean_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_get_IsObject_Public_Static_get_Boolean_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_IsString_Public_Static_get_Boolean_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_get_IsContainer_Public_Static_get_Boolean_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeNull_Public_Static_get_Boolean_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAbstractOrInterface_Public_Static_get_Boolean_0;
	}
}
