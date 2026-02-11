using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000004 RID: 4
	[Serializable]
	[StructLayout(2)]
	public struct bool2
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00003378 File Offset: 0x00001578
		// Note: this type is marked as 'beforefieldinit'.
		static bool2()
		{
			Il2CppClassPointerStore<bool2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "bool2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bool2>.NativeClassPtr);
			bool2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool2>.NativeClassPtr, "x");
			bool2.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool2>.NativeClassPtr, "y");
			bool2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663300);
			bool2.NativeMethodInfoPtr__ctor_Public_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663301);
			bool2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663302);
			bool2.NativeMethodInfoPtr_op_Implicit_Public_Static_bool2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663303);
			bool2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_bool2_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663304);
			bool2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_bool2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663305);
			bool2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_Boolean_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663306);
			bool2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_bool2_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663307);
			bool2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_bool2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663308);
			bool2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_Boolean_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663309);
			bool2.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool2_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663310);
			bool2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2_bool2_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663311);
			bool2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2_bool2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663312);
			bool2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2_Boolean_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663313);
			bool2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2_bool2_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663314);
			bool2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2_bool2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663315);
			bool2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2_Boolean_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663316);
			bool2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2_bool2_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663317);
			bool2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2_bool2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663318);
			bool2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2_Boolean_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663319);
			bool2.NativeMethodInfoPtr_get_xxxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663320);
			bool2.NativeMethodInfoPtr_get_xxxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663321);
			bool2.NativeMethodInfoPtr_get_xxyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663322);
			bool2.NativeMethodInfoPtr_get_xxyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663323);
			bool2.NativeMethodInfoPtr_get_xyxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663324);
			bool2.NativeMethodInfoPtr_get_xyxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663325);
			bool2.NativeMethodInfoPtr_get_xyyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663326);
			bool2.NativeMethodInfoPtr_get_xyyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663327);
			bool2.NativeMethodInfoPtr_get_yxxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663328);
			bool2.NativeMethodInfoPtr_get_yxxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663329);
			bool2.NativeMethodInfoPtr_get_yxyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663330);
			bool2.NativeMethodInfoPtr_get_yxyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663331);
			bool2.NativeMethodInfoPtr_get_yyxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663332);
			bool2.NativeMethodInfoPtr_get_yyxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663333);
			bool2.NativeMethodInfoPtr_get_yyyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663334);
			bool2.NativeMethodInfoPtr_get_yyyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663335);
			bool2.NativeMethodInfoPtr_get_xxx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663336);
			bool2.NativeMethodInfoPtr_get_xxy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663337);
			bool2.NativeMethodInfoPtr_get_xyx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663338);
			bool2.NativeMethodInfoPtr_get_xyy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663339);
			bool2.NativeMethodInfoPtr_get_yxx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663340);
			bool2.NativeMethodInfoPtr_get_yxy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663341);
			bool2.NativeMethodInfoPtr_get_yyx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663342);
			bool2.NativeMethodInfoPtr_get_yyy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663343);
			bool2.NativeMethodInfoPtr_get_xx_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663344);
			bool2.NativeMethodInfoPtr_get_xy_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663345);
			bool2.NativeMethodInfoPtr_set_xy_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663346);
			bool2.NativeMethodInfoPtr_get_yx_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663347);
			bool2.NativeMethodInfoPtr_set_yx_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663348);
			bool2.NativeMethodInfoPtr_get_yy_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663349);
			bool2.NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663350);
			bool2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663351);
			bool2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663352);
			bool2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663353);
			bool2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663354);
			bool2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2>.NativeClassPtr, 100663355);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00003830 File Offset: 0x00001A30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 630174, RefRangeEnd = 630177, XrefRangeStart = 630174, XrefRangeEnd = 630174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool2(bool x, bool y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00003870 File Offset: 0x00001A70
		[CallerCount(0)]
		public unsafe bool2(bool2 xy)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr__ctor_Public_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000038A4 File Offset: 0x00001AA4
		[CallerCount(0)]
		public unsafe bool2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000038D8 File Offset: 0x00001AD8
		[CallerCount(0)]
		public unsafe static implicit operator bool2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_op_Implicit_Public_Static_bool2_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003918 File Offset: 0x00001B18
		[CallerCount(0)]
		public unsafe static bool2 operator ==(bool2 lhs, bool2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_bool2_bool2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003964 File Offset: 0x00001B64
		[CallerCount(0)]
		public unsafe static bool2 operator ==(bool2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_bool2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000039B0 File Offset: 0x00001BB0
		[CallerCount(0)]
		public unsafe static bool2 operator ==(bool lhs, bool2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_Boolean_bool2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000039FC File Offset: 0x00001BFC
		[CallerCount(0)]
		public unsafe static bool2 operator !=(bool2 lhs, bool2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_bool2_bool2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003A48 File Offset: 0x00001C48
		[CallerCount(0)]
		public unsafe static bool2 operator !=(bool2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_bool2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003A94 File Offset: 0x00001C94
		[CallerCount(0)]
		public unsafe static bool2 operator !=(bool lhs, bool2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_Boolean_bool2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[CallerCount(0)]
		public unsafe static bool2 operator !(bool2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool2_bool2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003B20 File Offset: 0x00001D20
		[CallerCount(0)]
		public unsafe static bool2 operator &(bool2 lhs, bool2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2_bool2_bool2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003B6C File Offset: 0x00001D6C
		[CallerCount(0)]
		public unsafe static bool2 operator &(bool2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2_bool2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[CallerCount(0)]
		public unsafe static bool2 operator &(bool lhs, bool2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2_Boolean_bool2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003C04 File Offset: 0x00001E04
		[CallerCount(0)]
		public unsafe static bool2 operator |(bool2 lhs, bool2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2_bool2_bool2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003C50 File Offset: 0x00001E50
		[CallerCount(0)]
		public unsafe static bool2 operator |(bool2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2_bool2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003C9C File Offset: 0x00001E9C
		[CallerCount(0)]
		public unsafe static bool2 operator |(bool lhs, bool2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2_Boolean_bool2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003CE8 File Offset: 0x00001EE8
		[CallerCount(0)]
		public unsafe static bool2 operator ^(bool2 lhs, bool2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2_bool2_bool2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003D34 File Offset: 0x00001F34
		[CallerCount(0)]
		public unsafe static bool2 operator ^(bool2 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2_bool2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003D80 File Offset: 0x00001F80
		[CallerCount(0)]
		public unsafe static bool2 operator ^(bool lhs, bool2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2_Boolean_bool2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00003DCC File Offset: 0x00001FCC
		public unsafe bool4 xxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_xxxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00003DFC File Offset: 0x00001FFC
		public unsafe bool4 xxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_xxxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00003E2C File Offset: 0x0000202C
		public unsafe bool4 xxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_xxyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00003E5C File Offset: 0x0000205C
		public unsafe bool4 xxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_xxyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00003E8C File Offset: 0x0000208C
		public unsafe bool4 xyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_xyxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00003EBC File Offset: 0x000020BC
		public unsafe bool4 xyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_xyxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00003EEC File Offset: 0x000020EC
		public unsafe bool4 xyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_xyyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00003F1C File Offset: 0x0000211C
		public unsafe bool4 xyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_xyyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00003F4C File Offset: 0x0000214C
		public unsafe bool4 yxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_yxxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00003F7C File Offset: 0x0000217C
		public unsafe bool4 yxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_yxxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003FAC File Offset: 0x000021AC
		public unsafe bool4 yxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_yxyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00003FDC File Offset: 0x000021DC
		public unsafe bool4 yxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_yxyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000029 RID: 41 RVA: 0x0000400C File Offset: 0x0000220C
		public unsafe bool4 yyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_yyxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0000403C File Offset: 0x0000223C
		public unsafe bool4 yyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_yyxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002B RID: 43 RVA: 0x0000406C File Offset: 0x0000226C
		public unsafe bool4 yyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_yyyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002C RID: 44 RVA: 0x0000409C File Offset: 0x0000229C
		public unsafe bool4 yyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_yyyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000040CC File Offset: 0x000022CC
		public unsafe bool3 xxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_xxx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000040FC File Offset: 0x000022FC
		public unsafe bool3 xxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_xxy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002F RID: 47 RVA: 0x0000412C File Offset: 0x0000232C
		public unsafe bool3 xyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_xyx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000415C File Offset: 0x0000235C
		public unsafe bool3 xyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_xyy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000031 RID: 49 RVA: 0x0000418C File Offset: 0x0000238C
		public unsafe bool3 yxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_yxx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000041BC File Offset: 0x000023BC
		public unsafe bool3 yxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_yxy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000041EC File Offset: 0x000023EC
		public unsafe bool3 yyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_yyx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0000421C File Offset: 0x0000241C
		public unsafe bool3 yyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_yyy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000035 RID: 53 RVA: 0x0000424C File Offset: 0x0000244C
		public unsafe bool2 xx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_xx_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000036 RID: 54 RVA: 0x0000427C File Offset: 0x0000247C
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000042AC File Offset: 0x000024AC
		public unsafe bool2 xy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_xy_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_set_xy_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000042E0 File Offset: 0x000024E0
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00004310 File Offset: 0x00002510
		public unsafe bool2 yx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_yx_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_set_yx_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00004344 File Offset: 0x00002544
		public unsafe bool2 yy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_yy_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001D RID: 29
		public unsafe bool this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000043F4 File Offset: 0x000025F4
		[CallerCount(0)]
		public unsafe bool Equals(bool2 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004434 File Offset: 0x00002634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 630177, XrefRangeEnd = 630180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004478 File Offset: 0x00002678
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000044A8 File Offset: 0x000026A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 630180, XrefRangeEnd = 630188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000209B File Offset: 0x0000029B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<bool2>.NativeClassPtr, ref this));
		}

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_bool2_Boolean_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2_bool2_bool2_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2_bool2_Boolean_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2_Boolean_bool2_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_bool2_bool2_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_bool2_Boolean_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_Boolean_bool2_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool2_bool2_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2_bool2_bool2_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2_bool2_Boolean_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool2_Boolean_bool2_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2_bool2_bool2_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2_bool2_Boolean_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool2_Boolean_bool2_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2_bool2_bool2_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2_bool2_Boolean_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool2_Boolean_bool2_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxx_Public_get_bool4_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxy_Public_get_bool4_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyx_Public_get_bool4_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyy_Public_get_bool4_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxx_Public_get_bool4_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxy_Public_get_bool4_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyx_Public_get_bool4_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyy_Public_get_bool4_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxx_Public_get_bool4_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxy_Public_get_bool4_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyx_Public_get_bool4_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyy_Public_get_bool4_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxx_Public_get_bool4_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxy_Public_get_bool4_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyx_Public_get_bool4_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyy_Public_get_bool4_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_get_xxx_Public_get_bool3_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_get_xxy_Public_get_bool3_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_get_xyx_Public_get_bool3_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_get_xyy_Public_get_bool3_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_get_yxx_Public_get_bool3_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_get_yxy_Public_get_bool3_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_get_yyx_Public_get_bool3_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_get_yyy_Public_get_bool3_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_get_xx_Public_get_bool2_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_get_xy_Public_get_bool2_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_set_xy_Public_set_Void_bool2_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_get_yx_Public_get_bool2_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_set_yx_Public_set_Void_bool2_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_get_yy_Public_get_bool2_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool2_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400003E RID: 62
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool x;

		// Token: 0x0400003F RID: 63
		[FieldOffset(1)]
		[MarshalAs(4)]
		public bool y;

		// Token: 0x02000050 RID: 80
		public sealed class DebuggerProxy : Object
		{
			// Token: 0x060025B5 RID: 9653 RVA: 0x000C2CB4 File Offset: 0x000C0EB4
			// Note: this type is marked as 'beforefieldinit'.
			static DebuggerProxy()
			{
				Il2CppClassPointerStore<bool2.DebuggerProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<bool2>.NativeClassPtr, "DebuggerProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bool2.DebuggerProxy>.NativeClassPtr);
				bool2.DebuggerProxy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool2.DebuggerProxy>.NativeClassPtr, "x");
				bool2.DebuggerProxy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool2.DebuggerProxy>.NativeClassPtr, "y");
				bool2.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool2.DebuggerProxy>.NativeClassPtr, 100663356);
			}

			// Token: 0x060025B6 RID: 9654 RVA: 0x000C2D1C File Offset: 0x000C0F1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 630173, XrefRangeEnd = 630174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebuggerProxy(bool2 v)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<bool2.DebuggerProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool2.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_bool2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060025B7 RID: 9655 RVA: 0x00002BB3 File Offset: 0x00000DB3
			public DebuggerProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BF1 RID: 3057
			// (get) Token: 0x060025B8 RID: 9656 RVA: 0x000C2D64 File Offset: 0x000C0F64
			// (set) Token: 0x060025B9 RID: 9657 RVA: 0x00002BBC File Offset: 0x00000DBC
			public unsafe bool x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bool2.DebuggerProxy.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bool2.DebuggerProxy.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17000BF2 RID: 3058
			// (get) Token: 0x060025BA RID: 9658 RVA: 0x000C2D8C File Offset: 0x000C0F8C
			// (set) Token: 0x060025BB RID: 9659 RVA: 0x00002BD7 File Offset: 0x00000DD7
			public unsafe bool y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bool2.DebuggerProxy.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bool2.DebuggerProxy.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x04002643 RID: 9795
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04002644 RID: 9796
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04002645 RID: 9797
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2_0;
		}
	}
}
