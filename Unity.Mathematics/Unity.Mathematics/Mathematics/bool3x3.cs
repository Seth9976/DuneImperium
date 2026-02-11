using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200000B RID: 11
	[Serializable]
	[StructLayout(2)]
	public struct bool3x3
	{
		// Token: 0x060008EF RID: 2287 RVA: 0x00035850 File Offset: 0x00033A50
		// Note: this type is marked as 'beforefieldinit'.
		static bool3x3()
		{
			Il2CppClassPointerStore<bool3x3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "bool3x3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bool3x3>.NativeClassPtr);
			bool3x3.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, "c0");
			bool3x3.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, "c1");
			bool3x3.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, "c2");
			bool3x3.NativeMethodInfoPtr__ctor_Public_Void_bool3_bool3_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665523);
			bool3x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665524);
			bool3x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665525);
			bool3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_bool3x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665526);
			bool3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_bool3x3_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665527);
			bool3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_bool3x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665528);
			bool3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_Boolean_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665529);
			bool3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_bool3x3_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665530);
			bool3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_bool3x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665531);
			bool3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_Boolean_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665532);
			bool3x3.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool3x3_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665533);
			bool3x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3x3_bool3x3_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665534);
			bool3x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3x3_bool3x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665535);
			bool3x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3x3_Boolean_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665536);
			bool3x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3x3_bool3x3_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665537);
			bool3x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3x3_bool3x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665538);
			bool3x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3x3_Boolean_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665539);
			bool3x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3x3_bool3x3_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665540);
			bool3x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3x3_bool3x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665541);
			bool3x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3x3_Boolean_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665542);
			bool3x3.NativeMethodInfoPtr_get_Item_Public_get_byref_bool3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665543);
			bool3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665544);
			bool3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665545);
			bool3x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665546);
			bool3x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, 100665547);
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00035AB0 File Offset: 0x00033CB0
		[CallerCount(0)]
		public unsafe bool3x3(bool3 c0, bool3 c1, bool3 c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr__ctor_Public_Void_bool3_bool3_bool3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00035B00 File Offset: 0x00033D00
		[CallerCount(0)]
		public unsafe bool3x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m02;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m12;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m20;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m21;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m22;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00035BA4 File Offset: 0x00033DA4
		[CallerCount(0)]
		public unsafe bool3x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00035BD8 File Offset: 0x00033DD8
		[CallerCount(0)]
		public unsafe static implicit operator bool3x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_bool3x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00035C18 File Offset: 0x00033E18
		[CallerCount(0)]
		public unsafe static bool3x3 operator ==(bool3x3 lhs, bool3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_bool3x3_bool3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00035C64 File Offset: 0x00033E64
		[CallerCount(0)]
		public unsafe static bool3x3 operator ==(bool3x3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_bool3x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00035CB0 File Offset: 0x00033EB0
		[CallerCount(0)]
		public unsafe static bool3x3 operator ==(bool lhs, bool3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_Boolean_bool3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00035CFC File Offset: 0x00033EFC
		[CallerCount(0)]
		public unsafe static bool3x3 operator !=(bool3x3 lhs, bool3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_bool3x3_bool3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00035D48 File Offset: 0x00033F48
		[CallerCount(0)]
		public unsafe static bool3x3 operator !=(bool3x3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_bool3x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00035D94 File Offset: 0x00033F94
		[CallerCount(0)]
		public unsafe static bool3x3 operator !=(bool lhs, bool3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_Boolean_bool3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00035DE0 File Offset: 0x00033FE0
		[CallerCount(0)]
		public unsafe static bool3x3 operator !(bool3x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool3x3_bool3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00035E20 File Offset: 0x00034020
		[CallerCount(0)]
		public unsafe static bool3x3 operator &(bool3x3 lhs, bool3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3x3_bool3x3_bool3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00035E6C File Offset: 0x0003406C
		[CallerCount(0)]
		public unsafe static bool3x3 operator &(bool3x3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3x3_bool3x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00035EB8 File Offset: 0x000340B8
		[CallerCount(0)]
		public unsafe static bool3x3 operator &(bool lhs, bool3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3x3_Boolean_bool3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00035F04 File Offset: 0x00034104
		[CallerCount(0)]
		public unsafe static bool3x3 operator |(bool3x3 lhs, bool3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3x3_bool3x3_bool3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00035F50 File Offset: 0x00034150
		[CallerCount(0)]
		public unsafe static bool3x3 operator |(bool3x3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3x3_bool3x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00035F9C File Offset: 0x0003419C
		[CallerCount(0)]
		public unsafe static bool3x3 operator |(bool lhs, bool3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3x3_Boolean_bool3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00035FE8 File Offset: 0x000341E8
		[CallerCount(0)]
		public unsafe static bool3x3 operator ^(bool3x3 lhs, bool3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3x3_bool3x3_bool3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00036034 File Offset: 0x00034234
		[CallerCount(0)]
		public unsafe static bool3x3 operator ^(bool3x3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3x3_bool3x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00036080 File Offset: 0x00034280
		[CallerCount(0)]
		public unsafe static bool3x3 operator ^(bool lhs, bool3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3x3_Boolean_bool3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000AE RID: 174
		public unsafe ref bool3 this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_get_Item_Public_get_byref_bool3_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00036100 File Offset: 0x00034300
		[CallerCount(0)]
		public unsafe bool Equals(bool3x3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00036140 File Offset: 0x00034340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634462, XrefRangeEnd = 634465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00036184 File Offset: 0x00034384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634465, XrefRangeEnd = 634466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x000361B4 File Offset: 0x000343B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634466, XrefRangeEnd = 634509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00002244 File Offset: 0x00000444
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<bool3x3>.NativeClassPtr, ref this));
		}

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool3_bool3_bool3_0;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_bool3x3_Boolean_0;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_bool3x3_bool3x3_0;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_bool3x3_Boolean_0;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_Boolean_bool3x3_0;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_bool3x3_bool3x3_0;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_bool3x3_Boolean_0;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_Boolean_bool3x3_0;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool3x3_bool3x3_0;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3x3_bool3x3_bool3x3_0;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3x3_bool3x3_Boolean_0;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3x3_Boolean_bool3x3_0;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3x3_bool3x3_bool3x3_0;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3x3_bool3x3_Boolean_0;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3x3_Boolean_bool3x3_0;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3x3_bool3x3_bool3x3_0;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3x3_bool3x3_Boolean_0;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3x3_Boolean_bool3x3_0;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_bool3_Int32_0;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool3x3_0;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000903 RID: 2307
		[FieldOffset(0)]
		public bool3 c0;

		// Token: 0x04000904 RID: 2308
		[FieldOffset(3)]
		public bool3 c1;

		// Token: 0x04000905 RID: 2309
		[FieldOffset(6)]
		public bool3 c2;
	}
}
