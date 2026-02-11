using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200000A RID: 10
	[Serializable]
	[StructLayout(2)]
	public struct bool3x2
	{
		// Token: 0x060008D4 RID: 2260 RVA: 0x00034F10 File Offset: 0x00033110
		// Note: this type is marked as 'beforefieldinit'.
		static bool3x2()
		{
			Il2CppClassPointerStore<bool3x2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "bool3x2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bool3x2>.NativeClassPtr);
			bool3x2.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, "c0");
			bool3x2.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, "c1");
			bool3x2.NativeMethodInfoPtr__ctor_Public_Void_bool3_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665498);
			bool3x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665499);
			bool3x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665500);
			bool3x2.NativeMethodInfoPtr_op_Implicit_Public_Static_bool3x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665501);
			bool3x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_bool3x2_bool3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665502);
			bool3x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_bool3x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665503);
			bool3x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_Boolean_bool3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665504);
			bool3x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_bool3x2_bool3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665505);
			bool3x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_bool3x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665506);
			bool3x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_Boolean_bool3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665507);
			bool3x2.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool3x2_bool3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665508);
			bool3x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3x2_bool3x2_bool3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665509);
			bool3x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3x2_bool3x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665510);
			bool3x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3x2_Boolean_bool3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665511);
			bool3x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3x2_bool3x2_bool3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665512);
			bool3x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3x2_bool3x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665513);
			bool3x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3x2_Boolean_bool3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665514);
			bool3x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3x2_bool3x2_bool3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665515);
			bool3x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3x2_bool3x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665516);
			bool3x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3x2_Boolean_bool3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665517);
			bool3x2.NativeMethodInfoPtr_get_Item_Public_get_byref_bool3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665518);
			bool3x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665519);
			bool3x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665520);
			bool3x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665521);
			bool3x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, 100665522);
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0003515C File Offset: 0x0003335C
		[CallerCount(0)]
		public unsafe bool3x2(bool3 c0, bool3 c1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr__ctor_Public_Void_bool3_bool3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0003519C File Offset: 0x0003339C
		[CallerCount(0)]
		public unsafe bool3x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m20;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m21;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00035214 File Offset: 0x00033414
		[CallerCount(0)]
		public unsafe bool3x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00035248 File Offset: 0x00033448
		[CallerCount(0)]
		public unsafe static implicit operator bool3x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_op_Implicit_Public_Static_bool3x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00035288 File Offset: 0x00033488
		[CallerCount(0)]
		public unsafe static bool3x2 operator ==(bool3x2 lhs, bool3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_bool3x2_bool3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x000352D4 File Offset: 0x000334D4
		[CallerCount(0)]
		public unsafe static bool3x2 operator ==(bool3x2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_bool3x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00035320 File Offset: 0x00033520
		[CallerCount(0)]
		public unsafe static bool3x2 operator ==(bool lhs, bool3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_Boolean_bool3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0003536C File Offset: 0x0003356C
		[CallerCount(0)]
		public unsafe static bool3x2 operator !=(bool3x2 lhs, bool3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_bool3x2_bool3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x000353B8 File Offset: 0x000335B8
		[CallerCount(0)]
		public unsafe static bool3x2 operator !=(bool3x2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_bool3x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00035404 File Offset: 0x00033604
		[CallerCount(0)]
		public unsafe static bool3x2 operator !=(bool lhs, bool3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_Boolean_bool3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00035450 File Offset: 0x00033650
		[CallerCount(0)]
		public unsafe static bool3x2 operator !(bool3x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool3x2_bool3x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00035490 File Offset: 0x00033690
		[CallerCount(0)]
		public unsafe static bool3x2 operator &(bool3x2 lhs, bool3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3x2_bool3x2_bool3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x000354DC File Offset: 0x000336DC
		[CallerCount(0)]
		public unsafe static bool3x2 operator &(bool3x2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3x2_bool3x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00035528 File Offset: 0x00033728
		[CallerCount(0)]
		public unsafe static bool3x2 operator &(bool lhs, bool3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3x2_Boolean_bool3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00035574 File Offset: 0x00033774
		[CallerCount(0)]
		public unsafe static bool3x2 operator |(bool3x2 lhs, bool3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3x2_bool3x2_bool3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x000355C0 File Offset: 0x000337C0
		[CallerCount(0)]
		public unsafe static bool3x2 operator |(bool3x2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3x2_bool3x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0003560C File Offset: 0x0003380C
		[CallerCount(0)]
		public unsafe static bool3x2 operator |(bool lhs, bool3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3x2_Boolean_bool3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00035658 File Offset: 0x00033858
		[CallerCount(0)]
		public unsafe static bool3x2 operator ^(bool3x2 lhs, bool3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3x2_bool3x2_bool3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x000356A4 File Offset: 0x000338A4
		[CallerCount(0)]
		public unsafe static bool3x2 operator ^(bool3x2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3x2_bool3x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x000356F0 File Offset: 0x000338F0
		[CallerCount(0)]
		public unsafe static bool3x2 operator ^(bool lhs, bool3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3x2_Boolean_bool3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000AD RID: 173
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_get_Item_Public_get_byref_bool3_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00035770 File Offset: 0x00033970
		[CallerCount(0)]
		public unsafe bool Equals(bool3x2 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool3x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x000357B0 File Offset: 0x000339B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634428, XrefRangeEnd = 634431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x000357F4 File Offset: 0x000339F4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00035824 File Offset: 0x00033A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634431, XrefRangeEnd = 634462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00002232 File Offset: 0x00000432
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<bool3x2>.NativeClassPtr, ref this));
		}

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool3_bool3_0;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_bool3x2_Boolean_0;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_bool3x2_bool3x2_0;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_bool3x2_Boolean_0;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_Boolean_bool3x2_0;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_bool3x2_bool3x2_0;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_bool3x2_Boolean_0;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_Boolean_bool3x2_0;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool3x2_bool3x2_0;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3x2_bool3x2_bool3x2_0;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3x2_bool3x2_Boolean_0;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3x2_Boolean_bool3x2_0;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3x2_bool3x2_bool3x2_0;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3x2_bool3x2_Boolean_0;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3x2_Boolean_bool3x2_0;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3x2_bool3x2_bool3x2_0;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3x2_bool3x2_Boolean_0;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3x2_Boolean_bool3x2_0;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_bool3_Int32_0;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool3x2_0;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040008E5 RID: 2277
		[FieldOffset(0)]
		public bool3 c0;

		// Token: 0x040008E6 RID: 2278
		[FieldOffset(3)]
		public bool3 c1;
	}
}
