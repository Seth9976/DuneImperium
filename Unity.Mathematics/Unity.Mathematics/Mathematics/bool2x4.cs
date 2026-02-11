using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000008 RID: 8
	[Serializable]
	[StructLayout(2)]
	public struct bool2x4
	{
		// Token: 0x0600081A RID: 2074 RVA: 0x000318D4 File Offset: 0x0002FAD4
		// Note: this type is marked as 'beforefieldinit'.
		static bool2x4()
		{
			Il2CppClassPointerStore<bool2x4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "bool2x4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bool2x4>.NativeClassPtr);
			bool2x4.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, "c0");
			bool2x4.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, "c1");
			bool2x4.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, "c2");
			bool2x4.NativeFieldInfoPtr_c3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, "c3");
			bool2x4.NativeMethodInfoPtr__ctor_Public_Void_bool2_bool2_bool2_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665315);
			bool2x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665316);
			bool2x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665317);
			bool2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_bool2x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665318);
			bool2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_bool2x4_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665319);
			bool2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_bool2x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665320);
			bool2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_Boolean_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665321);
			bool2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_bool2x4_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665322);
			bool2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_bool2x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665323);
			bool2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_Boolean_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665324);
			bool2x4.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool2x4_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665325);
			bool2x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x4_bool2x4_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665326);
			bool2x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x4_bool2x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665327);
			bool2x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x4_Boolean_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665328);
			bool2x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x4_bool2x4_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665329);
			bool2x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x4_bool2x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665330);
			bool2x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x4_Boolean_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665331);
			bool2x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x4_bool2x4_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665332);
			bool2x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x4_bool2x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665333);
			bool2x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x4_Boolean_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665334);
			bool2x4.NativeMethodInfoPtr_get_Item_Public_get_byref_bool2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665335);
			bool2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665336);
			bool2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665337);
			bool2x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665338);
			bool2x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, 100665339);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00031B48 File Offset: 0x0002FD48
		[CallerCount(0)]
		public unsafe bool2x4(bool2 c0, bool2 c1, bool2 c2, bool2 c3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr__ctor_Public_Void_bool2_bool2_bool2_bool2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00031BA4 File Offset: 0x0002FDA4
		[CallerCount(0)]
		public unsafe bool2x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m02;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m03;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m12;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m13;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00031C38 File Offset: 0x0002FE38
		[CallerCount(0)]
		public unsafe bool2x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00031C6C File Offset: 0x0002FE6C
		[CallerCount(0)]
		public unsafe static implicit operator bool2x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_bool2x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00031CAC File Offset: 0x0002FEAC
		[CallerCount(0)]
		public unsafe static bool2x4 operator ==(bool2x4 lhs, bool2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_bool2x4_bool2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00031CF8 File Offset: 0x0002FEF8
		[CallerCount(0)]
		public unsafe static bool2x4 operator ==(bool2x4 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_bool2x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00031D44 File Offset: 0x0002FF44
		[CallerCount(0)]
		public unsafe static bool2x4 operator ==(bool lhs, bool2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_Boolean_bool2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00031D90 File Offset: 0x0002FF90
		[CallerCount(0)]
		public unsafe static bool2x4 operator !=(bool2x4 lhs, bool2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_bool2x4_bool2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00031DDC File Offset: 0x0002FFDC
		[CallerCount(0)]
		public unsafe static bool2x4 operator !=(bool2x4 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_bool2x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00031E28 File Offset: 0x00030028
		[CallerCount(0)]
		public unsafe static bool2x4 operator !=(bool lhs, bool2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_Boolean_bool2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00031E74 File Offset: 0x00030074
		[CallerCount(0)]
		public unsafe static bool2x4 operator !(bool2x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool2x4_bool2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00031EB4 File Offset: 0x000300B4
		[CallerCount(0)]
		public unsafe static bool2x4 operator &(bool2x4 lhs, bool2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x4_bool2x4_bool2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00031F00 File Offset: 0x00030100
		[CallerCount(0)]
		public unsafe static bool2x4 operator &(bool2x4 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x4_bool2x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00031F4C File Offset: 0x0003014C
		[CallerCount(0)]
		public unsafe static bool2x4 operator &(bool lhs, bool2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x4_Boolean_bool2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00031F98 File Offset: 0x00030198
		[CallerCount(0)]
		public unsafe static bool2x4 operator |(bool2x4 lhs, bool2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x4_bool2x4_bool2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00031FE4 File Offset: 0x000301E4
		[CallerCount(0)]
		public unsafe static bool2x4 operator |(bool2x4 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x4_bool2x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00032030 File Offset: 0x00030230
		[CallerCount(0)]
		public unsafe static bool2x4 operator |(bool lhs, bool2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x4_Boolean_bool2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0003207C File Offset: 0x0003027C
		[CallerCount(0)]
		public unsafe static bool2x4 operator ^(bool2x4 lhs, bool2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x4_bool2x4_bool2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x000320C8 File Offset: 0x000302C8
		[CallerCount(0)]
		public unsafe static bool2x4 operator ^(bool2x4 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x4_bool2x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00032114 File Offset: 0x00030314
		[CallerCount(0)]
		public unsafe static bool2x4 operator ^(bool lhs, bool2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x4_Boolean_bool2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000036 RID: 54
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_get_Item_Public_get_byref_bool2_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00032194 File Offset: 0x00030394
		[CallerCount(0)]
		public unsafe bool Equals(bool2x4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000321D4 File Offset: 0x000303D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634371, XrefRangeEnd = 634374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00032218 File Offset: 0x00030418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634374, XrefRangeEnd = 634375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00032248 File Offset: 0x00030448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634375, XrefRangeEnd = 634414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0000220E File Offset: 0x0000040E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<bool2x4>.NativeClassPtr, ref this));
		}

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeFieldInfoPtr_c3;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2_bool2_bool2_bool2_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_bool2x4_Boolean_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_bool2x4_bool2x4_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_bool2x4_Boolean_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_Boolean_bool2x4_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_bool2x4_bool2x4_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_bool2x4_Boolean_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_Boolean_bool2x4_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool2x4_bool2x4_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x4_bool2x4_bool2x4_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x4_bool2x4_Boolean_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2x4_Boolean_bool2x4_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x4_bool2x4_bool2x4_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x4_bool2x4_Boolean_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2x4_Boolean_bool2x4_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x4_bool2x4_bool2x4_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x4_bool2x4_Boolean_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2x4_Boolean_bool2x4_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_bool2_Int32_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool2x4_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000823 RID: 2083
		[FieldOffset(0)]
		public bool2 c0;

		// Token: 0x04000824 RID: 2084
		[FieldOffset(2)]
		public bool2 c1;

		// Token: 0x04000825 RID: 2085
		[FieldOffset(4)]
		public bool2 c2;

		// Token: 0x04000826 RID: 2086
		[FieldOffset(6)]
		public bool2 c3;
	}
}
