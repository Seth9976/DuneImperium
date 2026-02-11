using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000006 RID: 6
	[Serializable]
	[StructLayout(2)]
	public struct bool2x2
	{
		// Token: 0x060007E4 RID: 2020 RVA: 0x0003064C File Offset: 0x0002E84C
		// Note: this type is marked as 'beforefieldinit'.
		static bool2x2()
		{
			Il2CppClassPointerStore<bool2x2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "bool2x2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bool2x2>.NativeClassPtr);
			bool2x2.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, "c0");
			bool2x2.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, "c1");
			bool2x2.NativeMethodInfoPtr__ctor_Public_Void_bool2_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665265);
			bool2x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665266);
			bool2x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665267);
			bool2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_bool2x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665268);
			bool2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_bool2x2_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665269);
			bool2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_bool2x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665270);
			bool2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_Boolean_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665271);
			bool2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_bool2x2_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665272);
			bool2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_bool2x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665273);
			bool2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_Boolean_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665274);
			bool2x2.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool2x2_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665275);
			bool2x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x2_bool2x2_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665276);
			bool2x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x2_bool2x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665277);
			bool2x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x2_Boolean_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665278);
			bool2x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x2_bool2x2_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665279);
			bool2x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x2_bool2x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665280);
			bool2x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x2_Boolean_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665281);
			bool2x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x2_bool2x2_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665282);
			bool2x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x2_bool2x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665283);
			bool2x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x2_Boolean_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665284);
			bool2x2.NativeMethodInfoPtr_get_Item_Public_get_byref_bool2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665285);
			bool2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665286);
			bool2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665287);
			bool2x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665288);
			bool2x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, 100665289);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00030898 File Offset: 0x0002EA98
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 438691, RefRangeEnd = 438696, XrefRangeStart = 438691, XrefRangeEnd = 438696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool2x2(bool2 c0, bool2 c1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr__ctor_Public_Void_bool2_bool2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000308D8 File Offset: 0x0002EAD8
		[CallerCount(0)]
		public unsafe bool2x2(bool m00, bool m01, bool m10, bool m11)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00030934 File Offset: 0x0002EB34
		[CallerCount(0)]
		public unsafe bool2x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00030968 File Offset: 0x0002EB68
		[CallerCount(0)]
		public unsafe static implicit operator bool2x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_bool2x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x000309A8 File Offset: 0x0002EBA8
		[CallerCount(0)]
		public unsafe static bool2x2 operator ==(bool2x2 lhs, bool2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_bool2x2_bool2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x000309F4 File Offset: 0x0002EBF4
		[CallerCount(0)]
		public unsafe static bool2x2 operator ==(bool2x2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_bool2x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00030A40 File Offset: 0x0002EC40
		[CallerCount(0)]
		public unsafe static bool2x2 operator ==(bool lhs, bool2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_Boolean_bool2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00030A8C File Offset: 0x0002EC8C
		[CallerCount(0)]
		public unsafe static bool2x2 operator !=(bool2x2 lhs, bool2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_bool2x2_bool2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00030AD8 File Offset: 0x0002ECD8
		[CallerCount(0)]
		public unsafe static bool2x2 operator !=(bool2x2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_bool2x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00030B24 File Offset: 0x0002ED24
		[CallerCount(0)]
		public unsafe static bool2x2 operator !=(bool lhs, bool2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_Boolean_bool2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00030B70 File Offset: 0x0002ED70
		[CallerCount(0)]
		public unsafe static bool2x2 operator !(bool2x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool2x2_bool2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00030BB0 File Offset: 0x0002EDB0
		[CallerCount(0)]
		public unsafe static bool2x2 operator &(bool2x2 lhs, bool2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x2_bool2x2_bool2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00030BFC File Offset: 0x0002EDFC
		[CallerCount(0)]
		public unsafe static bool2x2 operator &(bool2x2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x2_bool2x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00030C48 File Offset: 0x0002EE48
		[CallerCount(0)]
		public unsafe static bool2x2 operator &(bool lhs, bool2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x2_Boolean_bool2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00030C94 File Offset: 0x0002EE94
		[CallerCount(0)]
		public unsafe static bool2x2 operator |(bool2x2 lhs, bool2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x2_bool2x2_bool2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00030CE0 File Offset: 0x0002EEE0
		[CallerCount(0)]
		public unsafe static bool2x2 operator |(bool2x2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x2_bool2x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00030D2C File Offset: 0x0002EF2C
		[CallerCount(0)]
		public unsafe static bool2x2 operator |(bool lhs, bool2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x2_Boolean_bool2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00030D78 File Offset: 0x0002EF78
		[CallerCount(0)]
		public unsafe static bool2x2 operator ^(bool2x2 lhs, bool2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x2_bool2x2_bool2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00030DC4 File Offset: 0x0002EFC4
		[CallerCount(0)]
		public unsafe static bool2x2 operator ^(bool2x2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x2_bool2x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00030E10 File Offset: 0x0002F010
		[CallerCount(0)]
		public unsafe static bool2x2 operator ^(bool lhs, bool2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x2_Boolean_bool2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000034 RID: 52
		public unsafe ref bool2 this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_get_Item_Public_get_byref_bool2_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00030E90 File Offset: 0x0002F090
		[CallerCount(0)]
		public unsafe bool Equals(bool2x2 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00030ED0 File Offset: 0x0002F0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634309, XrefRangeEnd = 634312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00030F14 File Offset: 0x0002F114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634312, XrefRangeEnd = 634313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00030F44 File Offset: 0x0002F144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634313, XrefRangeEnd = 634336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x000021EA File Offset: 0x000003EA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<bool2x2>.NativeClassPtr, ref this));
		}

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2_bool2_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_bool2x2_Boolean_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_bool2x2_bool2x2_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_bool2x2_Boolean_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_Boolean_bool2x2_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_bool2x2_bool2x2_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_bool2x2_Boolean_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_Boolean_bool2x2_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool2x2_bool2x2_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x2_bool2x2_bool2x2_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x2_bool2x2_Boolean_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x2_Boolean_bool2x2_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x2_bool2x2_bool2x2_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x2_bool2x2_Boolean_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x2_Boolean_bool2x2_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x2_bool2x2_bool2x2_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x2_bool2x2_Boolean_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x2_Boolean_bool2x2_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_bool2_Int32_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool2x2_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040007E5 RID: 2021
		[FieldOffset(0)]
		public bool2 c0;

		// Token: 0x040007E6 RID: 2022
		[FieldOffset(2)]
		public bool2 c1;
	}
}
