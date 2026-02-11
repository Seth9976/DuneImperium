using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200000F RID: 15
	[Serializable]
	[StructLayout(2)]
	public struct bool4x3
	{
		// Token: 0x06000AEE RID: 2798 RVA: 0x0003EB00 File Offset: 0x0003CD00
		// Note: this type is marked as 'beforefieldinit'.
		static bool4x3()
		{
			Il2CppClassPointerStore<bool4x3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "bool4x3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bool4x3>.NativeClassPtr);
			bool4x3.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, "c0");
			bool4x3.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, "c1");
			bool4x3.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, "c2");
			bool4x3.NativeMethodInfoPtr__ctor_Public_Void_bool4_bool4_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666027);
			bool4x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666028);
			bool4x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666029);
			bool4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_bool4x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666030);
			bool4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_bool4x3_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666031);
			bool4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_bool4x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666032);
			bool4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_Boolean_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666033);
			bool4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_bool4x3_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666034);
			bool4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_bool4x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666035);
			bool4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_Boolean_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666036);
			bool4x3.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool4x3_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666037);
			bool4x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x3_bool4x3_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666038);
			bool4x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x3_bool4x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666039);
			bool4x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x3_Boolean_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666040);
			bool4x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x3_bool4x3_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666041);
			bool4x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x3_bool4x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666042);
			bool4x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x3_Boolean_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666043);
			bool4x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x3_bool4x3_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666044);
			bool4x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x3_bool4x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666045);
			bool4x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x3_Boolean_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666046);
			bool4x3.NativeMethodInfoPtr_get_Item_Public_get_byref_bool4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666047);
			bool4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666048);
			bool4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666049);
			bool4x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666050);
			bool4x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, 100666051);
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0003ED60 File Offset: 0x0003CF60
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 556229, RefRangeEnd = 556238, XrefRangeStart = 556229, XrefRangeEnd = 556238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool4x3(bool4 c0, bool4 c1, bool4 c2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr__ctor_Public_Void_bool4_bool4_bool4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0003EDB0 File Offset: 0x0003CFB0
		[CallerCount(0)]
		public unsafe bool4x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22, bool m30, bool m31, bool m32)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m30;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m31;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m32;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0003EE80 File Offset: 0x0003D080
		[CallerCount(0)]
		public unsafe bool4x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0003EEB4 File Offset: 0x0003D0B4
		[CallerCount(0)]
		public unsafe static implicit operator bool4x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_bool4x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0003EEF4 File Offset: 0x0003D0F4
		[CallerCount(0)]
		public unsafe static bool4x3 operator ==(bool4x3 lhs, bool4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_bool4x3_bool4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0003EF40 File Offset: 0x0003D140
		[CallerCount(0)]
		public unsafe static bool4x3 operator ==(bool4x3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_bool4x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0003EF8C File Offset: 0x0003D18C
		[CallerCount(0)]
		public unsafe static bool4x3 operator ==(bool lhs, bool4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_Boolean_bool4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0003EFD8 File Offset: 0x0003D1D8
		[CallerCount(0)]
		public unsafe static bool4x3 operator !=(bool4x3 lhs, bool4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_bool4x3_bool4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0003F024 File Offset: 0x0003D224
		[CallerCount(0)]
		public unsafe static bool4x3 operator !=(bool4x3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_bool4x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0003F070 File Offset: 0x0003D270
		[CallerCount(0)]
		public unsafe static bool4x3 operator !=(bool lhs, bool4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_Boolean_bool4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0003F0BC File Offset: 0x0003D2BC
		[CallerCount(0)]
		public unsafe static bool4x3 operator !(bool4x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool4x3_bool4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0003F0FC File Offset: 0x0003D2FC
		[CallerCount(0)]
		public unsafe static bool4x3 operator &(bool4x3 lhs, bool4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x3_bool4x3_bool4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0003F148 File Offset: 0x0003D348
		[CallerCount(0)]
		public unsafe static bool4x3 operator &(bool4x3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x3_bool4x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0003F194 File Offset: 0x0003D394
		[CallerCount(0)]
		public unsafe static bool4x3 operator &(bool lhs, bool4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x3_Boolean_bool4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0003F1E0 File Offset: 0x0003D3E0
		[CallerCount(0)]
		public unsafe static bool4x3 operator |(bool4x3 lhs, bool4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x3_bool4x3_bool4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0003F22C File Offset: 0x0003D42C
		[CallerCount(0)]
		public unsafe static bool4x3 operator |(bool4x3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x3_bool4x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0003F278 File Offset: 0x0003D478
		[CallerCount(0)]
		public unsafe static bool4x3 operator |(bool lhs, bool4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x3_Boolean_bool4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0003F2C4 File Offset: 0x0003D4C4
		[CallerCount(0)]
		public unsafe static bool4x3 operator ^(bool4x3 lhs, bool4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x3_bool4x3_bool4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0003F310 File Offset: 0x0003D510
		[CallerCount(0)]
		public unsafe static bool4x3 operator ^(bool4x3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x3_bool4x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0003F35C File Offset: 0x0003D55C
		[CallerCount(0)]
		public unsafe static bool4x3 operator ^(bool lhs, bool4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x3_Boolean_bool4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000202 RID: 514
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_get_Item_Public_get_byref_bool4_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0003F3DC File Offset: 0x0003D5DC
		[CallerCount(0)]
		public unsafe bool Equals(bool4x3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0003F41C File Offset: 0x0003D61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634640, XrefRangeEnd = 634643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0003F460 File Offset: 0x0003D660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634643, XrefRangeEnd = 634644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0003F490 File Offset: 0x0003D690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634644, XrefRangeEnd = 634699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0000228C File Offset: 0x0000048C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<bool4x3>.NativeClassPtr, ref this));
		}

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool4_bool4_bool4_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_bool4x3_Boolean_0;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_bool4x3_bool4x3_0;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_bool4x3_Boolean_0;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_Boolean_bool4x3_0;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_bool4x3_bool4x3_0;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_bool4x3_Boolean_0;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_Boolean_bool4x3_0;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool4x3_bool4x3_0;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x3_bool4x3_bool4x3_0;

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x3_bool4x3_Boolean_0;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4x3_Boolean_bool4x3_0;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x3_bool4x3_bool4x3_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x3_bool4x3_Boolean_0;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4x3_Boolean_bool4x3_0;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x3_bool4x3_bool4x3_0;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x3_bool4x3_Boolean_0;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4x3_Boolean_bool4x3_0;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_bool4_Int32_0;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool4x3_0;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000B14 RID: 2836
		[FieldOffset(0)]
		public bool4 c0;

		// Token: 0x04000B15 RID: 2837
		[FieldOffset(4)]
		public bool4 c1;

		// Token: 0x04000B16 RID: 2838
		[FieldOffset(8)]
		public bool4 c2;
	}
}
