using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200000E RID: 14
	[Serializable]
	[StructLayout(2)]
	public struct bool4x2
	{
		// Token: 0x06000AD3 RID: 2771 RVA: 0x0003E1A4 File Offset: 0x0003C3A4
		// Note: this type is marked as 'beforefieldinit'.
		static bool4x2()
		{
			Il2CppClassPointerStore<bool4x2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "bool4x2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bool4x2>.NativeClassPtr);
			bool4x2.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, "c0");
			bool4x2.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, "c1");
			bool4x2.NativeMethodInfoPtr__ctor_Public_Void_bool4_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666002);
			bool4x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666003);
			bool4x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666004);
			bool4x2.NativeMethodInfoPtr_op_Implicit_Public_Static_bool4x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666005);
			bool4x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_bool4x2_bool4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666006);
			bool4x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_bool4x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666007);
			bool4x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_Boolean_bool4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666008);
			bool4x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_bool4x2_bool4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666009);
			bool4x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_bool4x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666010);
			bool4x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_Boolean_bool4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666011);
			bool4x2.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool4x2_bool4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666012);
			bool4x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x2_bool4x2_bool4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666013);
			bool4x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x2_bool4x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666014);
			bool4x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x2_Boolean_bool4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666015);
			bool4x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x2_bool4x2_bool4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666016);
			bool4x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x2_bool4x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666017);
			bool4x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x2_Boolean_bool4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666018);
			bool4x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x2_bool4x2_bool4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666019);
			bool4x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x2_bool4x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666020);
			bool4x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x2_Boolean_bool4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666021);
			bool4x2.NativeMethodInfoPtr_get_Item_Public_get_byref_bool4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666022);
			bool4x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666023);
			bool4x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666024);
			bool4x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666025);
			bool4x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, 100666026);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0003E3F0 File Offset: 0x0003C5F0
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 283577, RefRangeEnd = 283616, XrefRangeStart = 283577, XrefRangeEnd = 283616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool4x2(bool4 c0, bool4 c1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr__ctor_Public_Void_bool4_bool4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0003E430 File Offset: 0x0003C630
		[CallerCount(0)]
		public unsafe bool4x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21, bool m30, bool m31)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m20;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m21;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m30;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m31;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0003E4C4 File Offset: 0x0003C6C4
		[CallerCount(0)]
		public unsafe bool4x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0003E4F8 File Offset: 0x0003C6F8
		[CallerCount(0)]
		public unsafe static implicit operator bool4x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_op_Implicit_Public_Static_bool4x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0003E538 File Offset: 0x0003C738
		[CallerCount(0)]
		public unsafe static bool4x2 operator ==(bool4x2 lhs, bool4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_bool4x2_bool4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0003E584 File Offset: 0x0003C784
		[CallerCount(0)]
		public unsafe static bool4x2 operator ==(bool4x2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_bool4x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0003E5D0 File Offset: 0x0003C7D0
		[CallerCount(0)]
		public unsafe static bool4x2 operator ==(bool lhs, bool4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_Boolean_bool4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0003E61C File Offset: 0x0003C81C
		[CallerCount(0)]
		public unsafe static bool4x2 operator !=(bool4x2 lhs, bool4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_bool4x2_bool4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0003E668 File Offset: 0x0003C868
		[CallerCount(0)]
		public unsafe static bool4x2 operator !=(bool4x2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_bool4x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0003E6B4 File Offset: 0x0003C8B4
		[CallerCount(0)]
		public unsafe static bool4x2 operator !=(bool lhs, bool4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_Boolean_bool4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0003E700 File Offset: 0x0003C900
		[CallerCount(0)]
		public unsafe static bool4x2 operator !(bool4x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool4x2_bool4x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0003E740 File Offset: 0x0003C940
		[CallerCount(0)]
		public unsafe static bool4x2 operator &(bool4x2 lhs, bool4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x2_bool4x2_bool4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0003E78C File Offset: 0x0003C98C
		[CallerCount(0)]
		public unsafe static bool4x2 operator &(bool4x2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x2_bool4x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0003E7D8 File Offset: 0x0003C9D8
		[CallerCount(0)]
		public unsafe static bool4x2 operator &(bool lhs, bool4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x2_Boolean_bool4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0003E824 File Offset: 0x0003CA24
		[CallerCount(0)]
		public unsafe static bool4x2 operator |(bool4x2 lhs, bool4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x2_bool4x2_bool4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0003E870 File Offset: 0x0003CA70
		[CallerCount(0)]
		public unsafe static bool4x2 operator |(bool4x2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x2_bool4x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0003E8BC File Offset: 0x0003CABC
		[CallerCount(0)]
		public unsafe static bool4x2 operator |(bool lhs, bool4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x2_Boolean_bool4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0003E908 File Offset: 0x0003CB08
		[CallerCount(0)]
		public unsafe static bool4x2 operator ^(bool4x2 lhs, bool4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x2_bool4x2_bool4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0003E954 File Offset: 0x0003CB54
		[CallerCount(0)]
		public unsafe static bool4x2 operator ^(bool4x2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x2_bool4x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0003E9A0 File Offset: 0x0003CBA0
		[CallerCount(0)]
		public unsafe static bool4x2 operator ^(bool lhs, bool4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x2_Boolean_bool4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000201 RID: 513
		public unsafe ref bool4 this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_get_Item_Public_get_byref_bool4_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0003EA20 File Offset: 0x0003CC20
		[CallerCount(0)]
		public unsafe bool Equals(bool4x2 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool4x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0003EA60 File Offset: 0x0003CC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634597, XrefRangeEnd = 634600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0003EAA4 File Offset: 0x0003CCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634600, XrefRangeEnd = 634601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0003EAD4 File Offset: 0x0003CCD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634601, XrefRangeEnd = 634640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0000227A File Offset: 0x0000047A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<bool4x2>.NativeClassPtr, ref this));
		}

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool4_bool4_0;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_bool4x2_Boolean_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_bool4x2_bool4x2_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_bool4x2_Boolean_0;

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_Boolean_bool4x2_0;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_bool4x2_bool4x2_0;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_bool4x2_Boolean_0;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_Boolean_bool4x2_0;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool4x2_bool4x2_0;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x2_bool4x2_bool4x2_0;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x2_bool4x2_Boolean_0;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x2_Boolean_bool4x2_0;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x2_bool4x2_bool4x2_0;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x2_bool4x2_Boolean_0;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x2_Boolean_bool4x2_0;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x2_bool4x2_bool4x2_0;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x2_bool4x2_Boolean_0;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x2_Boolean_bool4x2_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_bool4_Int32_0;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool4x2_0;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000AF6 RID: 2806
		[FieldOffset(0)]
		public bool4 c0;

		// Token: 0x04000AF7 RID: 2807
		[FieldOffset(4)]
		public bool4 c1;
	}
}
