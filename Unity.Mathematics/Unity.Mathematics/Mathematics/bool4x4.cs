using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000010 RID: 16
	[Serializable]
	[StructLayout(2)]
	public struct bool4x4
	{
		// Token: 0x06000B09 RID: 2825 RVA: 0x0003F4BC File Offset: 0x0003D6BC
		// Note: this type is marked as 'beforefieldinit'.
		static bool4x4()
		{
			Il2CppClassPointerStore<bool4x4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "bool4x4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bool4x4>.NativeClassPtr);
			bool4x4.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, "c0");
			bool4x4.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, "c1");
			bool4x4.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, "c2");
			bool4x4.NativeFieldInfoPtr_c3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, "c3");
			bool4x4.NativeMethodInfoPtr__ctor_Public_Void_bool4_bool4_bool4_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666052);
			bool4x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666053);
			bool4x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666054);
			bool4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_bool4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666055);
			bool4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_bool4x4_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666056);
			bool4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_bool4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666057);
			bool4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_Boolean_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666058);
			bool4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_bool4x4_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666059);
			bool4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_bool4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666060);
			bool4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_Boolean_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666061);
			bool4x4.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool4x4_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666062);
			bool4x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x4_bool4x4_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666063);
			bool4x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x4_bool4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666064);
			bool4x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x4_Boolean_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666065);
			bool4x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x4_bool4x4_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666066);
			bool4x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x4_bool4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666067);
			bool4x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x4_Boolean_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666068);
			bool4x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x4_bool4x4_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666069);
			bool4x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x4_bool4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666070);
			bool4x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x4_Boolean_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666071);
			bool4x4.NativeMethodInfoPtr_get_Item_Public_get_byref_bool4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666072);
			bool4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666073);
			bool4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666074);
			bool4x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666075);
			bool4x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, 100666076);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0003F730 File Offset: 0x0003D930
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 608741, RefRangeEnd = 608768, XrefRangeStart = 608741, XrefRangeEnd = 608768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool4x4(bool4 c0, bool4 c1, bool4 c2, bool4 c3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr__ctor_Public_Void_bool4_bool4_bool4_bool4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0003F78C File Offset: 0x0003D98C
		[CallerCount(0)]
		public unsafe bool4x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23, bool m30, bool m31, bool m32, bool m33)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m02;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m03;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m12;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m13;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m20;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m21;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m22;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m23;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m30;
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m31;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m32;
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m33;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0003F898 File Offset: 0x0003DA98
		[CallerCount(0)]
		public unsafe bool4x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0003F8CC File Offset: 0x0003DACC
		[CallerCount(0)]
		public unsafe static implicit operator bool4x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_bool4x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0003F90C File Offset: 0x0003DB0C
		[CallerCount(0)]
		public unsafe static bool4x4 operator ==(bool4x4 lhs, bool4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_bool4x4_bool4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0003F958 File Offset: 0x0003DB58
		[CallerCount(0)]
		public unsafe static bool4x4 operator ==(bool4x4 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_bool4x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0003F9A4 File Offset: 0x0003DBA4
		[CallerCount(0)]
		public unsafe static bool4x4 operator ==(bool lhs, bool4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_Boolean_bool4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0003F9F0 File Offset: 0x0003DBF0
		[CallerCount(0)]
		public unsafe static bool4x4 operator !=(bool4x4 lhs, bool4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_bool4x4_bool4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0003FA3C File Offset: 0x0003DC3C
		[CallerCount(0)]
		public unsafe static bool4x4 operator !=(bool4x4 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_bool4x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0003FA88 File Offset: 0x0003DC88
		[CallerCount(0)]
		public unsafe static bool4x4 operator !=(bool lhs, bool4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_Boolean_bool4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0003FAD4 File Offset: 0x0003DCD4
		[CallerCount(0)]
		public unsafe static bool4x4 operator !(bool4x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool4x4_bool4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0003FB14 File Offset: 0x0003DD14
		[CallerCount(0)]
		public unsafe static bool4x4 operator &(bool4x4 lhs, bool4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x4_bool4x4_bool4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0003FB60 File Offset: 0x0003DD60
		[CallerCount(0)]
		public unsafe static bool4x4 operator &(bool4x4 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x4_bool4x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0003FBAC File Offset: 0x0003DDAC
		[CallerCount(0)]
		public unsafe static bool4x4 operator &(bool lhs, bool4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x4_Boolean_bool4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0003FBF8 File Offset: 0x0003DDF8
		[CallerCount(0)]
		public unsafe static bool4x4 operator |(bool4x4 lhs, bool4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x4_bool4x4_bool4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0003FC44 File Offset: 0x0003DE44
		[CallerCount(0)]
		public unsafe static bool4x4 operator |(bool4x4 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x4_bool4x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0003FC90 File Offset: 0x0003DE90
		[CallerCount(0)]
		public unsafe static bool4x4 operator |(bool lhs, bool4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x4_Boolean_bool4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0003FCDC File Offset: 0x0003DEDC
		[CallerCount(0)]
		public unsafe static bool4x4 operator ^(bool4x4 lhs, bool4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x4_bool4x4_bool4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0003FD28 File Offset: 0x0003DF28
		[CallerCount(0)]
		public unsafe static bool4x4 operator ^(bool4x4 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x4_bool4x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0003FD74 File Offset: 0x0003DF74
		[CallerCount(0)]
		public unsafe static bool4x4 operator ^(bool lhs, bool4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x4_Boolean_bool4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000203 RID: 515
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_get_Item_Public_get_byref_bool4_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0003FDF4 File Offset: 0x0003DFF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 634699, RefRangeEnd = 634700, XrefRangeStart = 634699, XrefRangeEnd = 634699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(bool4x4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0003FE34 File Offset: 0x0003E034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634700, XrefRangeEnd = 634704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0003FE78 File Offset: 0x0003E078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634704, XrefRangeEnd = 634705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0003FEA8 File Offset: 0x0003E0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634705, XrefRangeEnd = 634776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0000229E File Offset: 0x0000049E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<bool4x4>.NativeClassPtr, ref this));
		}

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeFieldInfoPtr_c3;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool4_bool4_bool4_bool4_0;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_bool4x4_Boolean_0;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_bool4x4_bool4x4_0;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_bool4x4_Boolean_0;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_Boolean_bool4x4_0;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_bool4x4_bool4x4_0;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_bool4x4_Boolean_0;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_Boolean_bool4x4_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool4x4_bool4x4_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x4_bool4x4_bool4x4_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x4_bool4x4_Boolean_0;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x4_Boolean_bool4x4_0;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x4_bool4x4_bool4x4_0;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x4_bool4x4_Boolean_0;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x4_Boolean_bool4x4_0;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x4_bool4x4_bool4x4_0;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x4_bool4x4_Boolean_0;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x4_Boolean_bool4x4_0;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_bool4_Int32_0;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool4x4_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000B34 RID: 2868
		[FieldOffset(0)]
		public bool4 c0;

		// Token: 0x04000B35 RID: 2869
		[FieldOffset(4)]
		public bool4 c1;

		// Token: 0x04000B36 RID: 2870
		[FieldOffset(8)]
		public bool4 c2;

		// Token: 0x04000B37 RID: 2871
		[FieldOffset(12)]
		public bool4 c3;
	}
}
