using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000007 RID: 7
	[Serializable]
	[StructLayout(2)]
	public struct bool2x3
	{
		// Token: 0x060007FF RID: 2047 RVA: 0x00030F70 File Offset: 0x0002F170
		// Note: this type is marked as 'beforefieldinit'.
		static bool2x3()
		{
			Il2CppClassPointerStore<bool2x3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "bool2x3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bool2x3>.NativeClassPtr);
			bool2x3.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, "c0");
			bool2x3.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, "c1");
			bool2x3.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, "c2");
			bool2x3.NativeMethodInfoPtr__ctor_Public_Void_bool2_bool2_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665290);
			bool2x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665291);
			bool2x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665292);
			bool2x3.NativeMethodInfoPtr_op_Implicit_Public_Static_bool2x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665293);
			bool2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_bool2x3_bool2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665294);
			bool2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_bool2x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665295);
			bool2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_Boolean_bool2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665296);
			bool2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_bool2x3_bool2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665297);
			bool2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_bool2x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665298);
			bool2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_Boolean_bool2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665299);
			bool2x3.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool2x3_bool2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665300);
			bool2x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x3_bool2x3_bool2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665301);
			bool2x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x3_bool2x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665302);
			bool2x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x3_Boolean_bool2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665303);
			bool2x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x3_bool2x3_bool2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665304);
			bool2x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x3_bool2x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665305);
			bool2x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x3_Boolean_bool2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665306);
			bool2x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x3_bool2x3_bool2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665307);
			bool2x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x3_bool2x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665308);
			bool2x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x3_Boolean_bool2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665309);
			bool2x3.NativeMethodInfoPtr_get_Item_Public_get_byref_bool2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665310);
			bool2x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665311);
			bool2x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665312);
			bool2x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665313);
			bool2x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, 100665314);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x000311D0 File Offset: 0x0002F3D0
		[CallerCount(0)]
		public unsafe bool2x3(bool2 c0, bool2 c1, bool2 c2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr__ctor_Public_Void_bool2_bool2_bool2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00031220 File Offset: 0x0002F420
		[CallerCount(0)]
		public unsafe bool2x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m02;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m12;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00031298 File Offset: 0x0002F498
		[CallerCount(0)]
		public unsafe bool2x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x000312CC File Offset: 0x0002F4CC
		[CallerCount(0)]
		public unsafe static implicit operator bool2x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_op_Implicit_Public_Static_bool2x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0003130C File Offset: 0x0002F50C
		[CallerCount(0)]
		public unsafe static bool2x3 operator ==(bool2x3 lhs, bool2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_bool2x3_bool2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00031358 File Offset: 0x0002F558
		[CallerCount(0)]
		public unsafe static bool2x3 operator ==(bool2x3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_bool2x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000313A4 File Offset: 0x0002F5A4
		[CallerCount(0)]
		public unsafe static bool2x3 operator ==(bool lhs, bool2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_Boolean_bool2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000313F0 File Offset: 0x0002F5F0
		[CallerCount(0)]
		public unsafe static bool2x3 operator !=(bool2x3 lhs, bool2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_bool2x3_bool2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0003143C File Offset: 0x0002F63C
		[CallerCount(0)]
		public unsafe static bool2x3 operator !=(bool2x3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_bool2x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00031488 File Offset: 0x0002F688
		[CallerCount(0)]
		public unsafe static bool2x3 operator !=(bool lhs, bool2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_Boolean_bool2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000314D4 File Offset: 0x0002F6D4
		[CallerCount(0)]
		public unsafe static bool2x3 operator !(bool2x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool2x3_bool2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00031514 File Offset: 0x0002F714
		[CallerCount(0)]
		public unsafe static bool2x3 operator &(bool2x3 lhs, bool2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x3_bool2x3_bool2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00031560 File Offset: 0x0002F760
		[CallerCount(0)]
		public unsafe static bool2x3 operator &(bool2x3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x3_bool2x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x000315AC File Offset: 0x0002F7AC
		[CallerCount(0)]
		public unsafe static bool2x3 operator &(bool lhs, bool2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x3_Boolean_bool2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x000315F8 File Offset: 0x0002F7F8
		[CallerCount(0)]
		public unsafe static bool2x3 operator |(bool2x3 lhs, bool2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x3_bool2x3_bool2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00031644 File Offset: 0x0002F844
		[CallerCount(0)]
		public unsafe static bool2x3 operator |(bool2x3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x3_bool2x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00031690 File Offset: 0x0002F890
		[CallerCount(0)]
		public unsafe static bool2x3 operator |(bool lhs, bool2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x3_Boolean_bool2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x000316DC File Offset: 0x0002F8DC
		[CallerCount(0)]
		public unsafe static bool2x3 operator ^(bool2x3 lhs, bool2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x3_bool2x3_bool2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00031728 File Offset: 0x0002F928
		[CallerCount(0)]
		public unsafe static bool2x3 operator ^(bool2x3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x3_bool2x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00031774 File Offset: 0x0002F974
		[CallerCount(0)]
		public unsafe static bool2x3 operator ^(bool lhs, bool2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x3_Boolean_bool2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000035 RID: 53
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_get_Item_Public_get_byref_bool2_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x000317F4 File Offset: 0x0002F9F4
		[CallerCount(0)]
		public unsafe bool Equals(bool2x3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool2x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00031834 File Offset: 0x0002FA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634336, XrefRangeEnd = 634339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00031878 File Offset: 0x0002FA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634339, XrefRangeEnd = 634340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x000318A8 File Offset: 0x0002FAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634340, XrefRangeEnd = 634371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x000021FC File Offset: 0x000003FC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<bool2x3>.NativeClassPtr, ref this));
		}

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2_bool2_bool2_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_bool2x3_Boolean_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_bool2x3_bool2x3_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_bool2x3_Boolean_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_Boolean_bool2x3_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_bool2x3_bool2x3_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_bool2x3_Boolean_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_Boolean_bool2x3_0;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool2x3_bool2x3_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x3_bool2x3_bool2x3_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x3_bool2x3_Boolean_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x3_Boolean_bool2x3_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x3_bool2x3_bool2x3_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x3_bool2x3_Boolean_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x3_Boolean_bool2x3_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x3_bool2x3_bool2x3_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x3_bool2x3_Boolean_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x3_Boolean_bool2x3_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_bool2_Int32_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool2x3_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000803 RID: 2051
		[FieldOffset(0)]
		public bool2 c0;

		// Token: 0x04000804 RID: 2052
		[FieldOffset(2)]
		public bool2 c1;

		// Token: 0x04000805 RID: 2053
		[FieldOffset(4)]
		public bool2 c2;
	}
}
