using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200002A RID: 42
	[Serializable]
	[StructLayout(2)]
	public struct half2
	{
		// Token: 0x06001657 RID: 5719 RVA: 0x00077748 File Offset: 0x00075948
		// Note: this type is marked as 'beforefieldinit'.
		static half2()
		{
			Il2CppClassPointerStore<half2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "half2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<half2>.NativeClassPtr);
			half2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half2>.NativeClassPtr, "x");
			half2.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half2>.NativeClassPtr, "y");
			half2.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half2>.NativeClassPtr, "zero");
			half2.NativeMethodInfoPtr__ctor_Public_Void_half_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668845);
			half2.NativeMethodInfoPtr__ctor_Public_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668846);
			half2.NativeMethodInfoPtr__ctor_Public_Void_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668847);
			half2.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668848);
			half2.NativeMethodInfoPtr__ctor_Public_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668849);
			half2.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668850);
			half2.NativeMethodInfoPtr__ctor_Public_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668851);
			half2.NativeMethodInfoPtr_op_Implicit_Public_Static_half2_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668852);
			half2.NativeMethodInfoPtr_op_Explicit_Public_Static_half2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668853);
			half2.NativeMethodInfoPtr_op_Explicit_Public_Static_half2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668854);
			half2.NativeMethodInfoPtr_op_Explicit_Public_Static_half2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668855);
			half2.NativeMethodInfoPtr_op_Explicit_Public_Static_half2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668856);
			half2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_half2_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668857);
			half2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_half2_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668858);
			half2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_half_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668859);
			half2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_half2_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668860);
			half2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_half2_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668861);
			half2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_half_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668862);
			half2.NativeMethodInfoPtr_get_xxxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668863);
			half2.NativeMethodInfoPtr_get_xxxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668864);
			half2.NativeMethodInfoPtr_get_xxyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668865);
			half2.NativeMethodInfoPtr_get_xxyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668866);
			half2.NativeMethodInfoPtr_get_xyxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668867);
			half2.NativeMethodInfoPtr_get_xyxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668868);
			half2.NativeMethodInfoPtr_get_xyyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668869);
			half2.NativeMethodInfoPtr_get_xyyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668870);
			half2.NativeMethodInfoPtr_get_yxxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668871);
			half2.NativeMethodInfoPtr_get_yxxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668872);
			half2.NativeMethodInfoPtr_get_yxyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668873);
			half2.NativeMethodInfoPtr_get_yxyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668874);
			half2.NativeMethodInfoPtr_get_yyxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668875);
			half2.NativeMethodInfoPtr_get_yyxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668876);
			half2.NativeMethodInfoPtr_get_yyyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668877);
			half2.NativeMethodInfoPtr_get_yyyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668878);
			half2.NativeMethodInfoPtr_get_xxx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668879);
			half2.NativeMethodInfoPtr_get_xxy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668880);
			half2.NativeMethodInfoPtr_get_xyx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668881);
			half2.NativeMethodInfoPtr_get_xyy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668882);
			half2.NativeMethodInfoPtr_get_yxx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668883);
			half2.NativeMethodInfoPtr_get_yxy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668884);
			half2.NativeMethodInfoPtr_get_yyx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668885);
			half2.NativeMethodInfoPtr_get_yyy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668886);
			half2.NativeMethodInfoPtr_get_xx_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668887);
			half2.NativeMethodInfoPtr_get_xy_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668888);
			half2.NativeMethodInfoPtr_set_xy_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668889);
			half2.NativeMethodInfoPtr_get_yx_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668890);
			half2.NativeMethodInfoPtr_set_yx_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668891);
			half2.NativeMethodInfoPtr_get_yy_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668892);
			half2.NativeMethodInfoPtr_get_Item_Public_get_half_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668893);
			half2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668894);
			half2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668895);
			half2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668896);
			half2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668897);
			half2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668898);
			half2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2>.NativeClassPtr, 100668899);
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00077C00 File Offset: 0x00075E00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 438691, RefRangeEnd = 438696, XrefRangeStart = 438691, XrefRangeEnd = 438696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe half2(half x, half y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr__ctor_Public_Void_half_half_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00077C40 File Offset: 0x00075E40
		[CallerCount(0)]
		public unsafe half2(half2 xy)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr__ctor_Public_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x00077C74 File Offset: 0x00075E74
		[CallerCount(0)]
		public unsafe half2(half v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr__ctor_Public_Void_half_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00077CA8 File Offset: 0x00075EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639014, XrefRangeEnd = 639016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe half2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x00077CDC File Offset: 0x00075EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639016, XrefRangeEnd = 639018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe half2(float2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr__ctor_Public_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00077D10 File Offset: 0x00075F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639018, XrefRangeEnd = 639020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe half2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00077D44 File Offset: 0x00075F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639020, XrefRangeEnd = 639022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe half2(double2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr__ctor_Public_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x00077D78 File Offset: 0x00075F78
		[CallerCount(0)]
		public unsafe static implicit operator half2(half v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_op_Implicit_Public_Static_half2_half_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00077DB8 File Offset: 0x00075FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator half2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_op_Explicit_Public_Static_half2_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x00077DF8 File Offset: 0x00075FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator half2(float2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_op_Explicit_Public_Static_half2_float2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x00077E38 File Offset: 0x00076038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator half2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_op_Explicit_Public_Static_half2_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00077E78 File Offset: 0x00076078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator half2(double2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_op_Explicit_Public_Static_half2_double2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x00077EB8 File Offset: 0x000760B8
		[CallerCount(0)]
		public unsafe static bool2 operator ==(half2 lhs, half2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_half2_half2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00077F04 File Offset: 0x00076104
		[CallerCount(0)]
		public unsafe static bool2 operator ==(half2 lhs, half rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_half2_half_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00077F50 File Offset: 0x00076150
		[CallerCount(0)]
		public unsafe static bool2 operator ==(half lhs, half2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_half_half2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00077F9C File Offset: 0x0007619C
		[CallerCount(0)]
		public unsafe static bool2 operator !=(half2 lhs, half2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_half2_half2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00077FE8 File Offset: 0x000761E8
		[CallerCount(0)]
		public unsafe static bool2 operator !=(half2 lhs, half rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_half2_half_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x00078034 File Offset: 0x00076234
		[CallerCount(0)]
		public unsafe static bool2 operator !=(half lhs, half2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_half_half2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x0600166A RID: 5738 RVA: 0x00078080 File Offset: 0x00076280
		public unsafe half4 xxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_xxxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x0600166B RID: 5739 RVA: 0x000780B0 File Offset: 0x000762B0
		public unsafe half4 xxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_xxxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x000780E0 File Offset: 0x000762E0
		public unsafe half4 xxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_xxyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x0600166D RID: 5741 RVA: 0x00078110 File Offset: 0x00076310
		public unsafe half4 xxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_xxyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x00078140 File Offset: 0x00076340
		public unsafe half4 xyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_xyxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x0600166F RID: 5743 RVA: 0x00078170 File Offset: 0x00076370
		public unsafe half4 xyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_xyxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x000781A0 File Offset: 0x000763A0
		public unsafe half4 xyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_xyyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001671 RID: 5745 RVA: 0x000781D0 File Offset: 0x000763D0
		public unsafe half4 xyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_xyyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x00078200 File Offset: 0x00076400
		public unsafe half4 yxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_yxxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x00078230 File Offset: 0x00076430
		public unsafe half4 yxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_yxxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x00078260 File Offset: 0x00076460
		public unsafe half4 yxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_yxyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001675 RID: 5749 RVA: 0x00078290 File Offset: 0x00076490
		public unsafe half4 yxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_yxyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x000782C0 File Offset: 0x000764C0
		public unsafe half4 yyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_yyxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x000782F0 File Offset: 0x000764F0
		public unsafe half4 yyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_yyxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x00078320 File Offset: 0x00076520
		public unsafe half4 yyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_yyyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x00078350 File Offset: 0x00076550
		public unsafe half4 yyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_yyyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x00078380 File Offset: 0x00076580
		public unsafe half3 xxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_xxx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x0600167B RID: 5755 RVA: 0x000783B0 File Offset: 0x000765B0
		public unsafe half3 xxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_xxy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x000783E0 File Offset: 0x000765E0
		public unsafe half3 xyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_xyx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x00078410 File Offset: 0x00076610
		public unsafe half3 xyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_xyy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x00078440 File Offset: 0x00076640
		public unsafe half3 yxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_yxx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x00078470 File Offset: 0x00076670
		public unsafe half3 yxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_yxy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x000784A0 File Offset: 0x000766A0
		public unsafe half3 yyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_yyx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x000784D0 File Offset: 0x000766D0
		public unsafe half3 yyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_yyy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001682 RID: 5762 RVA: 0x00078500 File Offset: 0x00076700
		public unsafe half2 xx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_xx_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001683 RID: 5763 RVA: 0x00078530 File Offset: 0x00076730
		// (set) Token: 0x06001684 RID: 5764 RVA: 0x00078560 File Offset: 0x00076760
		public unsafe half2 xy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_xy_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_set_xy_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001685 RID: 5765 RVA: 0x00078594 File Offset: 0x00076794
		// (set) Token: 0x06001686 RID: 5766 RVA: 0x000785C4 File Offset: 0x000767C4
		public unsafe half2 yx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_yx_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_set_yx_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001687 RID: 5767 RVA: 0x000785F8 File Offset: 0x000767F8
		public unsafe half2 yy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_yy_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700061E RID: 1566
		public unsafe half this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_get_Item_Public_get_half_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_half_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x000786A8 File Offset: 0x000768A8
		[CallerCount(0)]
		public unsafe bool Equals(half2 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_half2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x000786E8 File Offset: 0x000768E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639022, XrefRangeEnd = 639025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x0007872C File Offset: 0x0007692C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x0007875C File Offset: 0x0007695C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639025, XrefRangeEnd = 639033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00078788 File Offset: 0x00076988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639033, XrefRangeEnd = 639038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x00002624 File Offset: 0x00000824
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<half2>.NativeClassPtr, ref this));
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001690 RID: 5776 RVA: 0x000787D8 File Offset: 0x000769D8
		// (set) Token: 0x06001691 RID: 5777 RVA: 0x00002636 File Offset: 0x00000836
		public unsafe static half2 zero
		{
			get
			{
				half2 half;
				IL2CPP.il2cpp_field_static_get_value(half2.NativeFieldInfoPtr_zero, (void*)(&half));
				return half;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(half2.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x040016AC RID: 5804
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040016AD RID: 5805
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040016AE RID: 5806
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x040016AF RID: 5807
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half_half_0;

		// Token: 0x040016B0 RID: 5808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half2_0;

		// Token: 0x040016B1 RID: 5809
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half_0;

		// Token: 0x040016B2 RID: 5810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x040016B3 RID: 5811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2_0;

		// Token: 0x040016B4 RID: 5812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x040016B5 RID: 5813
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2_0;

		// Token: 0x040016B6 RID: 5814
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_half2_half_0;

		// Token: 0x040016B7 RID: 5815
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_half2_Single_0;

		// Token: 0x040016B8 RID: 5816
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_half2_float2_0;

		// Token: 0x040016B9 RID: 5817
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_half2_Double_0;

		// Token: 0x040016BA RID: 5818
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_half2_double2_0;

		// Token: 0x040016BB RID: 5819
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2_half2_half2_0;

		// Token: 0x040016BC RID: 5820
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2_half2_half_0;

		// Token: 0x040016BD RID: 5821
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2_half_half2_0;

		// Token: 0x040016BE RID: 5822
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_half2_half2_0;

		// Token: 0x040016BF RID: 5823
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_half2_half_0;

		// Token: 0x040016C0 RID: 5824
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_half_half2_0;

		// Token: 0x040016C1 RID: 5825
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxx_Public_get_half4_0;

		// Token: 0x040016C2 RID: 5826
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxy_Public_get_half4_0;

		// Token: 0x040016C3 RID: 5827
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyx_Public_get_half4_0;

		// Token: 0x040016C4 RID: 5828
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyy_Public_get_half4_0;

		// Token: 0x040016C5 RID: 5829
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxx_Public_get_half4_0;

		// Token: 0x040016C6 RID: 5830
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxy_Public_get_half4_0;

		// Token: 0x040016C7 RID: 5831
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyx_Public_get_half4_0;

		// Token: 0x040016C8 RID: 5832
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyy_Public_get_half4_0;

		// Token: 0x040016C9 RID: 5833
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxx_Public_get_half4_0;

		// Token: 0x040016CA RID: 5834
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxy_Public_get_half4_0;

		// Token: 0x040016CB RID: 5835
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyx_Public_get_half4_0;

		// Token: 0x040016CC RID: 5836
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyy_Public_get_half4_0;

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxx_Public_get_half4_0;

		// Token: 0x040016CE RID: 5838
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxy_Public_get_half4_0;

		// Token: 0x040016CF RID: 5839
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyx_Public_get_half4_0;

		// Token: 0x040016D0 RID: 5840
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyy_Public_get_half4_0;

		// Token: 0x040016D1 RID: 5841
		private static readonly IntPtr NativeMethodInfoPtr_get_xxx_Public_get_half3_0;

		// Token: 0x040016D2 RID: 5842
		private static readonly IntPtr NativeMethodInfoPtr_get_xxy_Public_get_half3_0;

		// Token: 0x040016D3 RID: 5843
		private static readonly IntPtr NativeMethodInfoPtr_get_xyx_Public_get_half3_0;

		// Token: 0x040016D4 RID: 5844
		private static readonly IntPtr NativeMethodInfoPtr_get_xyy_Public_get_half3_0;

		// Token: 0x040016D5 RID: 5845
		private static readonly IntPtr NativeMethodInfoPtr_get_yxx_Public_get_half3_0;

		// Token: 0x040016D6 RID: 5846
		private static readonly IntPtr NativeMethodInfoPtr_get_yxy_Public_get_half3_0;

		// Token: 0x040016D7 RID: 5847
		private static readonly IntPtr NativeMethodInfoPtr_get_yyx_Public_get_half3_0;

		// Token: 0x040016D8 RID: 5848
		private static readonly IntPtr NativeMethodInfoPtr_get_yyy_Public_get_half3_0;

		// Token: 0x040016D9 RID: 5849
		private static readonly IntPtr NativeMethodInfoPtr_get_xx_Public_get_half2_0;

		// Token: 0x040016DA RID: 5850
		private static readonly IntPtr NativeMethodInfoPtr_get_xy_Public_get_half2_0;

		// Token: 0x040016DB RID: 5851
		private static readonly IntPtr NativeMethodInfoPtr_set_xy_Public_set_Void_half2_0;

		// Token: 0x040016DC RID: 5852
		private static readonly IntPtr NativeMethodInfoPtr_get_yx_Public_get_half2_0;

		// Token: 0x040016DD RID: 5853
		private static readonly IntPtr NativeMethodInfoPtr_set_yx_Public_set_Void_half2_0;

		// Token: 0x040016DE RID: 5854
		private static readonly IntPtr NativeMethodInfoPtr_get_yy_Public_get_half2_0;

		// Token: 0x040016DF RID: 5855
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_half_Int32_0;

		// Token: 0x040016E0 RID: 5856
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_half_0;

		// Token: 0x040016E1 RID: 5857
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_half2_0;

		// Token: 0x040016E2 RID: 5858
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040016E3 RID: 5859
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040016E4 RID: 5860
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040016E5 RID: 5861
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040016E6 RID: 5862
		[FieldOffset(0)]
		public half x;

		// Token: 0x040016E7 RID: 5863
		[FieldOffset(2)]
		public half y;

		// Token: 0x0200005D RID: 93
		public sealed class DebuggerProxy : Object
		{
			// Token: 0x0600260A RID: 9738 RVA: 0x000C3878 File Offset: 0x000C1A78
			// Note: this type is marked as 'beforefieldinit'.
			static DebuggerProxy()
			{
				Il2CppClassPointerStore<half2.DebuggerProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<half2>.NativeClassPtr, "DebuggerProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<half2.DebuggerProxy>.NativeClassPtr);
				half2.DebuggerProxy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half2.DebuggerProxy>.NativeClassPtr, "x");
				half2.DebuggerProxy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half2.DebuggerProxy>.NativeClassPtr, "y");
				half2.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half2.DebuggerProxy>.NativeClassPtr, 100668900);
			}

			// Token: 0x0600260B RID: 9739 RVA: 0x000C38E0 File Offset: 0x000C1AE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639013, XrefRangeEnd = 639014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebuggerProxy(half2 v)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<half2.DebuggerProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half2.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_half2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600260C RID: 9740 RVA: 0x00002F01 File Offset: 0x00001101
			public DebuggerProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C0C RID: 3084
			// (get) Token: 0x0600260D RID: 9741 RVA: 0x000C3928 File Offset: 0x000C1B28
			// (set) Token: 0x0600260E RID: 9742 RVA: 0x00002F0A File Offset: 0x0000110A
			public unsafe half x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(half2.DebuggerProxy.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(half2.DebuggerProxy.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17000C0D RID: 3085
			// (get) Token: 0x0600260F RID: 9743 RVA: 0x000C3950 File Offset: 0x000C1B50
			// (set) Token: 0x06002610 RID: 9744 RVA: 0x00002F25 File Offset: 0x00001125
			public unsafe half y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(half2.DebuggerProxy.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(half2.DebuggerProxy.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x04002680 RID: 9856
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04002681 RID: 9857
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04002682 RID: 9858
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half2_0;
		}
	}
}
