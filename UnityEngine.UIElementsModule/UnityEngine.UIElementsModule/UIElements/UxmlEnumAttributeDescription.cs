using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x02000200 RID: 512
	public class UxmlEnumAttributeDescription<T> : TypedUxmlAttributeDescription<T> where T : new()
	{
		// Token: 0x060027DD RID: 10205 RVA: 0x000AF6B0 File Offset: 0x000AD8B0
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlEnumAttributeDescription()
		{
			Il2CppClassPointerStore<UxmlEnumAttributeDescription<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlEnumAttributeDescription`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlEnumAttributeDescription<T>>.NativeClassPtr);
			UxmlEnumAttributeDescription<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlEnumAttributeDescription<T>>.NativeClassPtr, 100669299);
			UxmlEnumAttributeDescription<T>.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_T_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlEnumAttributeDescription<T>>.NativeClassPtr, 100669300);
			UxmlEnumAttributeDescription<T>.NativeMethodInfoPtr_TryGetValueFromBag_Public_Boolean_IUxmlAttributes_CreationContext_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlEnumAttributeDescription<T>>.NativeClassPtr, 100669301);
			UxmlEnumAttributeDescription<T>.NativeMethodInfoPtr_ConvertValueToEnum_Private_Static_U_String_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlEnumAttributeDescription<T>>.NativeClassPtr, 100669302);
			UxmlEnumAttributeDescription<T>.NativeMethodInfoPtr_GetEnumNameErrorMessage_Private_Static_String_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlEnumAttributeDescription<T>>.NativeClassPtr, 100669303);
			UxmlEnumAttributeDescription<T>.NativeMethodInfoPtr_GetEnumRangeErrorMessage_Private_Static_String_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlEnumAttributeDescription<T>>.NativeClassPtr, 100669304);
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x000AF794 File Offset: 0x000AD994
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 343860, RefRangeEnd = 343879, XrefRangeStart = 343801, XrefRangeEnd = 343860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlEnumAttributeDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlEnumAttributeDescription<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlEnumAttributeDescription<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x000AF7D0 File Offset: 0x000AD9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343879, XrefRangeEnd = 343892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override T GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlEnumAttributeDescription<T>.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_T_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x000AF83C File Offset: 0x000ADA3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 343905, RefRangeEnd = 343907, XrefRangeStart = 343892, XrefRangeEnd = 343905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UxmlEnumAttributeDescription<T>.NativeMethodInfoPtr_TryGetValueFromBag_Public_Boolean_IUxmlAttributes_CreationContext_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x000AF8CC File Offset: 0x000ADACC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 343935, RefRangeEnd = 343937, XrefRangeStart = 343907, XrefRangeEnd = 343935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static U ConvertValueToEnum<U>(string v, U defaultValue) where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(U).IsValueType)
			{
				U u = defaultValue;
				intPtr = ((u is string) ? IL2CPP.ManagedStringToIl2Cpp(u as string) : IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref defaultValue;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UxmlEnumAttributeDescription<U>.MethodInfoStoreGeneric_ConvertValueToEnum_Private_Static_U_String_U_0.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<U>(intPtr2, false, true);
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x000AF954 File Offset: 0x000ADB54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 343965, RefRangeEnd = 343966, XrefRangeStart = 343937, XrefRangeEnd = 343965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetEnumNameErrorMessage(string v, Type enumType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlEnumAttributeDescription<T>.NativeMethodInfoPtr_GetEnumNameErrorMessage_Private_Static_String_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x000AF9A4 File Offset: 0x000ADBA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 343971, RefRangeEnd = 343972, XrefRangeStart = 343966, XrefRangeEnd = 343971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetEnumRangeErrorMessage(string v, Type enumType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlEnumAttributeDescription<T>.NativeMethodInfoPtr_GetEnumRangeErrorMessage_Private_Static_String_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x00010242 File Offset: 0x0000E442
		public UxmlEnumAttributeDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x060027E5 RID: 10213 RVA: 0x000AF9F4 File Offset: 0x000ADBF4
		public override string defaultValueAsString
		{
			get
			{
				T defaultValue = base.defaultValue;
				return defaultValue.ToString(CultureInfo.InvariantCulture.NumberFormat);
			}
		}

		// Token: 0x04001C4C RID: 7244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C4D RID: 7245
		private static readonly IntPtr NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_T_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001C4E RID: 7246
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValueFromBag_Public_Boolean_IUxmlAttributes_CreationContext_byref_T_0;

		// Token: 0x04001C4F RID: 7247
		private static readonly IntPtr NativeMethodInfoPtr_ConvertValueToEnum_Private_Static_U_String_U_0;

		// Token: 0x04001C50 RID: 7248
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumNameErrorMessage_Private_Static_String_String_Type_0;

		// Token: 0x04001C51 RID: 7249
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumRangeErrorMessage_Private_Static_String_String_Type_0;

		// Token: 0x02000513 RID: 1299
		[ObfuscatedName("UnityEngine.UIElements.UxmlEnumAttributeDescription`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003FEE RID: 16366 RVA: 0x000FE4DC File Offset: 0x000FC6DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UxmlEnumAttributeDescription<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UxmlEnumAttributeDescription<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlEnumAttributeDescription<T>.__c>.NativeClassPtr);
				UxmlEnumAttributeDescription<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlEnumAttributeDescription<T>.__c>.NativeClassPtr, "<>9");
				UxmlEnumAttributeDescription<T>.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlEnumAttributeDescription<T>.__c>.NativeClassPtr, "<>9__3_0");
				UxmlEnumAttributeDescription<T>.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlEnumAttributeDescription<T>.__c>.NativeClassPtr, "<>9__4_0");
				UxmlEnumAttributeDescription<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlEnumAttributeDescription<T>.__c>.NativeClassPtr, 100669306);
				UxmlEnumAttributeDescription<T>.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_T_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlEnumAttributeDescription<T>.__c>.NativeClassPtr, 100669307);
				UxmlEnumAttributeDescription<T>.__c.NativeMethodInfoPtr__TryGetValueFromBag_b__4_0_Internal_T_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlEnumAttributeDescription<T>.__c>.NativeClassPtr, 100669308);
			}

			// Token: 0x06003FEF RID: 16367 RVA: 0x000FE5BC File Offset: 0x000FC7BC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlEnumAttributeDescription<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlEnumAttributeDescription<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003FF0 RID: 16368 RVA: 0x000FE5F8 File Offset: 0x000FC7F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343796, XrefRangeEnd = 343801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _GetValueFromBag_b__3_0(string s, T convertible)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = convertible;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref convertible;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UxmlEnumAttributeDescription<T>.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_T_String_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}

			// Token: 0x06003FF1 RID: 16369 RVA: 0x000FE68C File Offset: 0x000FC88C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _TryGetValueFromBag_b__4_0(string s, T convertible)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = convertible;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref convertible;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UxmlEnumAttributeDescription<T>.__c.NativeMethodInfoPtr__TryGetValueFromBag_b__4_0_Internal_T_String_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}

			// Token: 0x06003FF2 RID: 16370 RVA: 0x0001ACC3 File Offset: 0x00018EC3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001324 RID: 4900
			// (get) Token: 0x06003FF3 RID: 16371 RVA: 0x000FE720 File Offset: 0x000FC920
			// (set) Token: 0x06003FF4 RID: 16372 RVA: 0x0001ACCC File Offset: 0x00018ECC
			public unsafe static UxmlEnumAttributeDescription<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlEnumAttributeDescription<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlEnumAttributeDescription<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlEnumAttributeDescription<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001325 RID: 4901
			// (get) Token: 0x06003FF5 RID: 16373 RVA: 0x000FE748 File Offset: 0x000FC948
			// (set) Token: 0x06003FF6 RID: 16374 RVA: 0x0001ACDE File Offset: 0x00018EDE
			public unsafe static Func<string, T, T> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlEnumAttributeDescription<T>.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, T, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlEnumAttributeDescription<T>.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001326 RID: 4902
			// (get) Token: 0x06003FF7 RID: 16375 RVA: 0x000FE770 File Offset: 0x000FC970
			// (set) Token: 0x06003FF8 RID: 16376 RVA: 0x0001ACF0 File Offset: 0x00018EF0
			public unsafe static Func<string, T, T> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlEnumAttributeDescription<T>.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, T, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlEnumAttributeDescription<T>.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D1B RID: 11547
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D1C RID: 11548
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04002D1D RID: 11549
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04002D1E RID: 11550
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D1F RID: 11551
			private static readonly IntPtr NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_T_String_T_0;

			// Token: 0x04002D20 RID: 11552
			private static readonly IntPtr NativeMethodInfoPtr__TryGetValueFromBag_b__4_0_Internal_T_String_T_0;
		}

		// Token: 0x02000514 RID: 1300
		private sealed class MethodInfoStoreGeneric_ConvertValueToEnum_Private_Static_U_String_U_0
		{
			// Token: 0x04002D21 RID: 11553
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UxmlEnumAttributeDescription<U>.NativeMethodInfoPtr_ConvertValueToEnum_Private_Static_U_String_U_0, Il2CppClassPointerStore<UxmlEnumAttributeDescription<U>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}
	}
}
