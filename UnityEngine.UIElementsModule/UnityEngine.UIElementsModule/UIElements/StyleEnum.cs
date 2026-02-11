using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000199 RID: 409
	public sealed class StyleEnum<T> : ValueType where T : new()
	{
		// Token: 0x060021CD RID: 8653 RVA: 0x00098448 File Offset: 0x00096648
		// Note: this type is marked as 'beforefieldinit'.
		static StyleEnum()
		{
			Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleEnum`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr);
			StyleEnum<T>.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr, "m_Value");
			StyleEnum<T>.NativeFieldInfoPtr_m_Keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr, "m_Keyword");
			StyleEnum<T>.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr, 100668286);
			StyleEnum<T>.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr, 100668287);
			StyleEnum<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr, 100668288);
			StyleEnum<T>.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr, 100668289);
			StyleEnum<T>.NativeMethodInfoPtr__ctor_Internal_Void_T_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr, 100668290);
			StyleEnum<T>.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleEnum_1_T_StyleEnum_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr, 100668291);
			StyleEnum<T>.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_StyleEnum_1_T_StyleEnum_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr, 100668292);
			StyleEnum<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleEnum_1_T_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr, 100668293);
			StyleEnum<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleEnum_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr, 100668294);
			StyleEnum<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleEnum_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr, 100668295);
			StyleEnum<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr, 100668296);
			StyleEnum<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr, 100668297);
			StyleEnum<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr, 100668298);
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x000985E0 File Offset: 0x000967E0
		// (set) Token: 0x060021E1 RID: 8673 RVA: 0x0000E22B File Offset: 0x0000C42B
		public unsafe T value
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 335396, RefRangeEnd = 335399, XrefRangeStart = 335396, XrefRangeEnd = 335396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleEnum<T>.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x00098620 File Offset: 0x00096820
		// (set) Token: 0x060021E2 RID: 8674 RVA: 0x0000E23C File Offset: 0x0000C43C
		public unsafe StyleKeyword keyword
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 283125, RefRangeEnd = 283150, XrefRangeStart = 283125, XrefRangeEnd = 283150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleEnum<T>.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x00098664 File Offset: 0x00096864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335399, XrefRangeEnd = 335400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleEnum(T v)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = v;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref v;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StyleEnum<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x000986EC File Offset: 0x000968EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335400, XrefRangeEnd = 335401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleEnum(StyleKeyword keyword)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleEnum<T>.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x00098738 File Offset: 0x00096938
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 335401, RefRangeEnd = 335403, XrefRangeStart = 335401, XrefRangeEnd = 335401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleEnum(T v, StyleKeyword keyword)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = v;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref v;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyword;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StyleEnum<T>.NativeMethodInfoPtr__ctor_Internal_Void_T_StyleKeyword_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x000987CC File Offset: 0x000969CC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 335403, RefRangeEnd = 335409, XrefRangeStart = 335403, XrefRangeEnd = 335403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(StyleEnum<T> lhs, StyleEnum<T> rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleEnum<T>.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleEnum_1_T_StyleEnum_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x0009882C File Offset: 0x00096A2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 335410, RefRangeEnd = 335412, XrefRangeStart = 335409, XrefRangeEnd = 335410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(StyleEnum<T> lhs, StyleEnum<T> rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleEnum<T>.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_StyleEnum_1_T_StyleEnum_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x0009888C File Offset: 0x00096A8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 335414, RefRangeEnd = 335417, XrefRangeStart = 335412, XrefRangeEnd = 335414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator StyleEnum<T>(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleEnum<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleEnum_1_T_StyleKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StyleEnum<T>(intPtr);
			}
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x000988C4 File Offset: 0x00096AC4
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 335419, RefRangeEnd = 335462, XrefRangeStart = 335417, XrefRangeEnd = 335419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator StyleEnum<T>(T v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = v;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref v;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StyleEnum<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleEnum_1_T_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return new StyleEnum<T>(intPtr2);
			}
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x00098938 File Offset: 0x00096B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335462, XrefRangeEnd = 335463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(StyleEnum<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleEnum<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleEnum_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x00098990 File Offset: 0x00096B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335463, XrefRangeEnd = 335470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleEnum<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x000989E4 File Offset: 0x00096BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335470, XrefRangeEnd = 335472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleEnum<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x00098A28 File Offset: 0x00096C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335472, XrefRangeEnd = 335476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleEnum<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x0000E1F5 File Offset: 0x0000C3F5
		public StyleEnum(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x0000E1FE File Offset: 0x0000C3FE
		public StyleEnum()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleEnum<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x00098A64 File Offset: 0x00096C64
		// (set) Token: 0x060021DE RID: 8670 RVA: 0x00098A8C File Offset: 0x00096C8C
		public unsafe T m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleEnum<T>.NativeFieldInfoPtr_m_Value);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleEnum<T>.NativeFieldInfoPtr_m_Value);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x00098B34 File Offset: 0x00096D34
		// (set) Token: 0x060021E0 RID: 8672 RVA: 0x0000E210 File Offset: 0x0000C410
		public unsafe StyleKeyword m_Keyword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleEnum<T>.NativeFieldInfoPtr_m_Keyword);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleEnum<T>.NativeFieldInfoPtr_m_Keyword)) = value;
			}
		}

		// Token: 0x040017BC RID: 6076
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x040017BD RID: 6077
		private static readonly IntPtr NativeFieldInfoPtr_m_Keyword;

		// Token: 0x040017BE RID: 6078
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_T_0;

		// Token: 0x040017BF RID: 6079
		private static readonly IntPtr NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0;

		// Token: 0x040017C0 RID: 6080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;

		// Token: 0x040017C1 RID: 6081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0;

		// Token: 0x040017C2 RID: 6082
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_T_StyleKeyword_0;

		// Token: 0x040017C3 RID: 6083
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleEnum_1_T_StyleEnum_1_T_0;

		// Token: 0x040017C4 RID: 6084
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_StyleEnum_1_T_StyleEnum_1_T_0;

		// Token: 0x040017C5 RID: 6085
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StyleEnum_1_T_StyleKeyword_0;

		// Token: 0x040017C6 RID: 6086
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StyleEnum_1_T_T_0;

		// Token: 0x040017C7 RID: 6087
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleEnum_1_T_0;

		// Token: 0x040017C8 RID: 6088
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040017C9 RID: 6089
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040017CA RID: 6090
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
